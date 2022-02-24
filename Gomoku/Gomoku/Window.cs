using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;
using NeuralNet;

namespace Gomoku
{
    public partial class Window : Form
    {
        Board Board = new Board();
        //DataTable dtState = new DataTable();
        DataTable dtNetworkResponses = new DataTable();
        int dim = 15;
        
        bool IsMouseLeftDown = false;
        bool IsMouseRightDown = false;
        bool bwCancel = false;
        bool BlackHasMove = true;

        int GamesToReadCount = 0;
        int GamesAlreadyRead = 0;
        int GamesAlreadyReadBlackWins = 0;
        int GamesAlreadyReadWhiteWins = 0;

        Predictions Predictions = new Predictions();

        NeuralNetwork actualNetwork = null;

        public Window()
        {
            InitializeComponent();
        }

        private void Window_Load(object sender, EventArgs e)
        {
            Object[] tab = new Object[15];

            for (int r = 0; r < 15; r++)
            {
                dgv.Rows.Add(tab);
            }

            pBackgroud_Resize(null, null);
            ColorTable();

            int gamesCount = new DirectoryInfo("./Games").GetFiles().Length;

            if (gamesCount > 0)
            {
                nudGamesToRead.Minimum = 1;
                nudGamesToRead.Value = 1;
                nudGamesToRead.Maximum = gamesCount;
                nudGamesToRead.Value = gamesCount;
            }
            else
            {
                nudGamesToRead.Minimum = 0;
                nudGamesToRead.Value = 0;
                nudGamesToRead.Maximum = 0;
            }

            lblInfoGierCount.Text = "/ " + gamesCount;

            Predictions.CountPredictions(Board);
            ShowPredictions();

            // *** TEST AREA ***
            /*Game predicionGame = new Game();
            predicionGame.MakeMove(new Position() { R = 3, C = 2, MovingPlayer = Position.Player.Black });
            predicionGame.MakeMove(new Position() { R = 2, C = 3, MovingPlayer = Position.Player.White });
            predicionGame.MakeMove(new Position() { R = 3, C = 4, MovingPlayer = Position.Player.Black });
            predicionGame.MakeMove(new Position() { R = 3, C = 3, MovingPlayer = Position.Player.White });
            predicionGame.MakeMove(new Position() { R = 4, C = 3, MovingPlayer = Position.Player.Black });
            predicionGame.MakeMove(new Position() { R = 5, C = 2, MovingPlayer = Position.Player.White });

            Console.WriteLine("Prediction game");
            predicionGame.Board.Print();

            
            Game testGame = new Game();
            testGame.MakeMove(new Position() { R = 2, C = 1, MovingPlayer = Position.Player.Black });
            testGame.MakeMove(new Position() { R = 1, C = 2, MovingPlayer = Position.Player.White });
            testGame.MakeMove(new Position() { R = 2, C = 3, MovingPlayer = Position.Player.Black });
            testGame.MakeMove(new Position() { R = 2, C = 2, MovingPlayer = Position.Player.White });
            testGame.MakeMove(new Position() { R = 3, C = 2, MovingPlayer = Position.Player.Black });
            Console.WriteLine("Test game");
            testGame.Board.Print();

            Predictions = new Predictions();
            bool b = Predictions.PredictGame(testGame.Board, predicionGame);
            Predictions.CountPredictionsByKnownCalculated();
            
            ShowPredictions();*/
        }

        private void CellClick(int RowIndex, int ColumnIndex)
        {
            if (rbPlacementMode.Checked)
            {
                //dtState.Rows[RowIndex][ColumnIndex] = GetClickedValue(IsMouseLeftDown);

                Console.WriteLine("CellClick: " + RowIndex + " x " + ColumnIndex);

                if (cbPrzelaczZawodnika.Checked)
                {
                    bLR_Click(null, null);
                }
            }
            else if (rbGameMode.Checked)
            {
                Position position = new Position()
                {
                    C = ColumnIndex,
                    R = RowIndex,
                    MovingPlayer = BlackHasMove ? Position.Player.Black : Position.Player.White
                };

                Board.MakeMove(position);
                
                //dtState.Rows[RowIndex][ColumnIndex] = BlackHasMove ? "-1" : "1";
                ColorTable();

                BlackHasMove = !BlackHasMove;

                tbColorSign.BackColor = (BlackHasMove) ? Color.Black : Color.White;
                Predictions.CountPredictions(Board);
                ShowPredictions();
            }
        }

        private void ShowPredictions()
        {
            for (int r = 0; r < dgv.Columns.Count; r++)
            {
                for (int c = 0; c < dgv.Columns.Count; c++)
                {
                    dgv.Rows[r].Cells[c].Value = Predictions.PredictionsByKnownCalculated[r, c] + Environment.NewLine +
                        Predictions.PredictionsByKnownStrinct[r, c] + Environment.NewLine +
                        Predictions.PredictionsByKnownAfterRotation[r, c] + Environment.NewLine +
                        Predictions.PredictionsByKnownAfterShift[r, c];
                }
            }

            ColorTable();
        }

        private void ResetDgv()
        {
            Board = new Board();
            //dgv.DataSource = dtState;
            
            for (int c = 0; c < dgv.Columns.Count; c++)
            {
                for (int r = 0; r < dgv.Columns.Count; r++)
                {
                    dgv.Rows[r].Cells[c].Value = "0";
                }
            }

            ColorTable();
        }

        private void ColorTable()
        {
            
            for (int r = 0; r < dgv.Rows.Count; r++)
            {
                for (int c = 0; c < dgv.Columns.Count; c++)
                {
                    switch (Board.Positions[r, c].Owner)
                    {
                        case Position.Player.Black:
                            FillCellWithColor(r, c, Color.Black);

                            break;
                        
                        case Position.Player.White:
                            FillCellWithColor(r, c, Color.White);

                            break;
                        
                        default:
                            if (Predictions.PredictionsByKnownCalculated[r, c] == 0)
                            {
                                FillCellWithColor(r, c, Color.FromArgb(240, 176, 90));
                            } 
                            else
                            {
                                int percent = Predictions.PredictionsByKnownCalculated[r, c] * 100 / Predictions.maxPredicionCalculated;
                                int percent2 = 100 - (Predictions.PredictionsByKnownCalculated[r, c] * 100 / Predictions.maxPredicionCalculated);
                                // 0 - 100
                                // 100 - 200
                                FillCellWithColor(r, c, Color.FromArgb(255, percent2 * 2, percent2 * 2));
                            }

                            break;
                    }
                }
            }

            if (Board.Positions[7, 7].Owner == Position.Player.None && Predictions.PredictionsByKnownCalculated[7, 7] == 0)
            {
                FillCellWithColor(7, 7, Color.FromArgb(204, 146, 81));
            }
        }

        private void ResetTable()
        {
            Board = new Board();
            BlackHasMove = true;
            tbColorSign.BackColor = Color.Black;

            ResetDgv();
            ColorTable();
            Predictions.CountPredictions(Board);
            ShowPredictions();
        }

        private void FillCellWithColor(int r, int c, Color color)
        {
            dgv.Rows[r].Cells[c].Style.BackColor = color;
            dgv.Rows[r].Cells[c].Style.SelectionBackColor = color;

            dgv.Rows[r].Cells[c].Style.ForeColor = (color == Color.White || color == Color.Black) ? color : Color.Black;
            dgv.Rows[r].Cells[c].Style.SelectionForeColor = (color == Color.White || color == Color.Black) ? color : Color.Black;
        }

        private String GetClickedValue(bool isMouseLeftDown)
        {
            if (isMouseLeftDown)
            {
                if (rbBlueL.Checked) return tbBlack.Text;
                if (rbBrownL.Checked) return tbBrown.Text;
                if (rbGreenL.Checked) return tbWhite.Text;
                if (rbGreyL.Checked) return tbGrey.Text;
                if (rbRedL.Checked) return tbRed.Text;
                if (rbBackgroundL.Checked) return tbBackground.Text;
            }
            else
            {
                if (rbBlueR.Checked) return tbBlack.Text;
                if (rbBrownR.Checked) return tbBrown.Text;
                if (rbGreenR.Checked) return tbWhite.Text;
                if (rbGreyR.Checked) return tbGrey.Text;
                if (rbRedR.Checked) return tbRed.Text;
                if (rbBackgroundR.Checked) return tbBackground.Text;
            }

            return "0";
        }

        private Color GetColorByValue(String value)
        {
            if (value.Equals(tbBlack.Text)) return tbBlack.BackColor;
            if (value.Equals(tbBrown.Text)) return tbBrown.BackColor;
            if (value.Equals(tbWhite.Text)) return tbWhite.BackColor;
            if (value.Equals(tbGrey.Text)) return tbGrey.BackColor;
            if (value.Equals(tbRed.Text)) return tbRed.BackColor;
            if (value.Equals(tbBackground.Text)) return tbBackground.BackColor;

            return Color.FromArgb(240, 240, 240);
        }

        private void pBackgroud_Resize(object sender, EventArgs e)
        {
            int w = pBackgroud.Width;
            int h = pBackgroud.Height;

            int dimension = (w > h) ? h : w;

            dgv.Width = dimension;
            dgv.Height = dimension;

            dgv.Location = new Point((pBackgroud.Width - dgv.Width) / 2, (pBackgroud.Height - dgv.Height) / 2);
            //ResetDgv();
        }

        
        private void dgv_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && IsMouseLeftDown)
            {
                IsMouseLeftDown = false;
                ColorTable();
            }

            if (e.Button == MouseButtons.Right && IsMouseRightDown)
            {
                IsMouseRightDown = false;
                ColorTable();
            }
        }

        private void dgv_MouseLeave(object sender, EventArgs e)
        {
            if (IsMouseLeftDown || IsMouseRightDown)
            {
                ColorTable();
            }

            IsMouseLeftDown = false;
            IsMouseRightDown = false;
        }

        private void dgv_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            IsMouseLeftDown = false;
            IsMouseRightDown = false;

            if (e.Button == MouseButtons.Left)
            {
                IsMouseLeftDown = true;
            }
            else if (e.Button == MouseButtons.Right)
            {
                IsMouseRightDown = true;
            }

            CellClick(e.RowIndex, e.ColumnIndex);
        }

        private void dgv_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (IsMouseLeftDown || IsMouseRightDown)
            {
                CellClick(e.RowIndex, e.ColumnIndex);
            }
        }

        private void bLR_Click(object sender, EventArgs e)
        {
            String valueL = GetClickedValue(true);
            String valueR = GetClickedValue(false);

            for (int r = 0; r < dgv.Rows.Count; r++)
            {
                for (int c = 0; c < dgv.Rows.Count; c++)
                {
                    if (dgv.Rows[r].Cells[c].Value.ToString().Equals(valueL))
                    {
                        dgv.Rows[r].Cells[c].Value = valueR;
                    }
                    else if (dgv.Rows[r].Cells[c].Value.ToString().Equals(valueR))
                    {
                        dgv.Rows[r].Cells[c].Value = valueL;
                    }
                }
            }

            ColorTable();
        }

        private void bClearExample_Click(object sender, EventArgs e)
        {
            ResetTable();
        }

        private void CheckNetworAnswer()
        {
            if (actualNetwork == null)
            {
                LoadNetwork();
            }

            if (actualNetwork != null)
            {
                List<double> inputData = new List<double>();

                for (int r = 0; r < dgv.Rows.Count; r++)
                {
                    for (int c = 0; c < dgv.Rows.Count; c++)
                    {
                        inputData.Add(double.Parse(dgv.Rows[r].Cells[c].Value.ToString()));
                    }
                }

                inputData.Add(-1); // bias

                String errMsg = "";
                List<double> result = actualNetwork.CountOutputData(inputData, out errMsg);

                if (errMsg == null)
                {
                    int idx = 0;
                    int maxR = 0;
                    int maxC = 0;

                    for (int r = 0; r < dgv.Rows.Count; r++)
                    {
                        for (int c = 0; c < dgv.Columns.Count; c++)
                        {
                            double percentage = ((int)(result[idx++] * 10000)) / 10000.0; // get value in format x,xxxx

                            if (double.Parse(dgv.Rows[r].Cells[c].Value.ToString()) > double.Parse(dgv.Rows[maxR].Cells[maxC].Value.ToString()))
                            {
                                maxR = r;
                                maxC = c;
                            }

                            dtNetworkResponses.Rows[r][c] = percentage;
                            /*dgv.Rows[r].Cells[c].Style.BackColor = Color.White;
                            dgv.Rows[r].Cells[c].Style.ForeColor = GetColorOfPercentage(percentage);
                            dgv.Rows[r].Cells[c].Style.SelectionForeColor = GetColorOfPercentage(percentage);*/
                        }
                    }

                    double winner = double.Parse(dgv.Rows[maxR].Cells[maxC].Value.ToString());
                    Color winnerForeColor = GetColorOfPercentage(winner);
                    Color winnerBackColor = GetColorByValue("1");

                    dgv.Rows[maxR].Cells[maxC].Style.BackColor = winnerBackColor;
                    dgv.Rows[maxR].Cells[maxC].Style.ForeColor = winnerForeColor;
                    dgv.Rows[maxR].Cells[maxC].Style.SelectionForeColor = winnerForeColor;
                }
                else
                {
                    MessageBox.Show(this, errMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LoadNetwork()
        {
            if (ofdOpen.ShowDialog(this) == DialogResult.OK)
            {
                FileInfo fiOpenFile = new FileInfo(ofdOpen.FileName);
                try
                {
                    actualNetwork = Tools.DeSerializeObject<NeuralNetwork>(fiOpenFile.FullName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, "Exception: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    actualNetwork = null;
                }
            }
        }

        private Color GetColorOfPercentage(double percentage)
        {
            int rgbParam = (int)(100 - percentage);

            return Color.FromArgb(rgbParam, rgbParam, rgbParam);
        }

        private void GetResultsFromKurnik()
        {
            // https://www.kurnik.pl/p/?g=gm[142822685].txt

            int cnt = 1;

            for (long i = 142812382 - 50000; i < 142812382; i++)
            {
                String url = "https://www.kurnik.pl/p/?g=gm" + i + ".txt";
                Uri uriPower = new Uri(url);

                HttpWebRequest webRequestPower = HttpWebRequest.Create(uriPower) as HttpWebRequest;

                CookieCollection cockies = new CookieCollection();

                webRequestPower.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/84.0.4147.105 Safari/537.36";
                webRequestPower.Method = "GET";
                webRequestPower.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,image/apng,*/*;q=0.8,application/signed-exchange;v=b3;q=0.9";
                webRequestPower.CookieContainer = new CookieContainer();
                webRequestPower.AllowAutoRedirect = false;

                WebResponse webResponsePower = webRequestPower.GetResponse();
                StreamReader sr = new StreamReader(webResponsePower.GetResponseStream(), System.Text.Encoding.UTF8);
                String content = sr.ReadToEnd();
                sr.Close();
                webResponsePower.Close();

                StreamWriter sw = new StreamWriter("./Games/gm" + i + ".txt");
                sw.Write(content);
                sw.Close();

                Console.WriteLine((cnt++) + ". " + url);
            }
        }

        private void bwLoadGames_DoWork(object sender, DoWorkEventArgs e)
        {
            Predictions = new Predictions();
            
            bwCancel = false;

            FileInfo[] files = new DirectoryInfo("./Games").GetFiles();

            for (GamesAlreadyRead = 0; GamesAlreadyRead < GamesToReadCount; GamesAlreadyRead++)
            {
                if (bwCancel) return;

                if (GamesAlreadyRead % 100 == 0)
                {
                    bwLoadGames.ReportProgress(GamesAlreadyRead * 100 / GamesToReadCount);
                }

                Game game = new Game(files[GamesAlreadyRead].FullName);

                if (game.PositionsLoadedOK && game.GameWasFinished)
                {
                    if (game.Winner == Position.Player.Black)
                    {
                        Predictions.GamesBlackWon.Add(game);
                    } 
                    else if (game.Winner == Position.Player.White)
                    {
                        Predictions.GamesWhiteWon.Add(game);
                    }
                }
                else if (!game.PositionsLoadedOK)
                {
                    Console.WriteLine("Nie dodałem gry z pliku " + files[GamesAlreadyRead].FullName + ", bo był błąd: " + game.errMsg);
                }
                else if (game.GameWasFinished)
                {
                    // Console.WriteLine("Nie dodałem gry z pliku " + files[i].FullName + ", bo gra nie była dokończona");
                }
            }
        }

        private void bwLoadGames_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            pbLoading.Value = e.ProgressPercentage;
            RefreshGamesAlreadyReadStatistics();
        }

        private void RefreshGamesAlreadyReadStatistics()
        {
            lblAlreadyReadGamesCount.Text = GamesAlreadyRead.ToString();
            lblAlreadyReadBlackWins.Text = Predictions.GamesBlackWon.Count.ToString();//GamesAlreadyReadBlackWins.ToString();
            lblAlreadyReadWhiteWins.Text = Predictions.GamesWhiteWon.Count.ToString();

        }

        private void bwLoadGames_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            pbLoading.Value = 0;
            bStartLoadingGames.Visible = true;
            bStopLoadingGames.Visible = false;
            nudGamesToRead.Enabled = true;
            RefreshGamesAlreadyReadStatistics();
            Predictions.CountPredictions(Board);
            ShowPredictions();
        }

        private void bStopLoadingGames_Click(object sender, EventArgs e)
        {
            bwCancel = true;
        }

        private void bStartLoadingGames_Click(object sender, EventArgs e)
        {
            bStartLoadingGames.Visible = false;
            bStopLoadingGames.Visible = true;
            nudGamesToRead.Enabled = false;
            GamesToReadCount = (int)nudGamesToRead.Value;
            bwLoadGames.RunWorkerAsync();
        }

        private void dgv_Resize(object sender, EventArgs e)
        {
            for (int c = 0; c < dim; c++)
            {
                dgv.Columns[c].Width = (dgv.Width - dim) / dim;
                dgv.Columns[c].ReadOnly = true;
            }

            for (int r = 0; r < dim; r++)
            {
                dgv.Rows[r].Height = (dgv.Width - dim) / dim;
            }
        }
    }
}
