using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KIK
{
    public partial class Okno : Form
    {
        bool ruchMaX = true;
        String fileName = "KIK learning data.csv";

        List<String> stany = new List<string>();
        List<String> ruchy = new List<string>();


        double wartoscRuchuNaRemis = 0.3;
        double wartoscRuchuNaPrzegrana = 0;
        double wartoscBrakuRuchuNaPrzegrana = 0.15;
        double wartoscRuchuNaWygrana = 1;

        public Okno()
        {
            InitializeComponent();
            lPlikInfo.Text = "Ruchy zapisane w pliku: " + fileName;
            cbIleWRzedzie.SelectedIndex = 1;
            Reset();

            // poligon doświadczalny:
            /*int tableSize = 15;
            int[,] table = new int[tableSize, tableSize];

            stany.Clear();
            stany.Clear();
            ResetTable(table);

            for (int r = 0; r< 15; r++)
            {
                for (int c = 0; c < 15; c++)
                {
                    table[r, c] = 1;
                }
            }
            table[0, 14] = 1;
            table[0, 13] = 1;
            table[0, 12] = 1;
            table[0, 11] = 1;
            table[0, 10] = 1;
            table[0, 9] = 1;
            table[0, 8] = 1;
            table[0, 7] = 1;
            table[0, 6] = 1;

            PrintTable(table);

            Console.WriteLine("Winner: " + WhoWins(table));*/
        }

        public void Reset()
        {
            stany.Clear();
            ruchy.Clear();

            const int cellDimension = 150;

            dgv.Rows.Clear();

            dgv.Rows.Add("", "", "");
            dgv.Rows.Add("", "", "");
            dgv.Rows.Add("", "", "");

            for (int rowIdx = 0; rowIdx < dgv.RowCount; rowIdx++)
            {
                dgv.Rows[rowIdx].MinimumHeight = cellDimension;
            }

            for (int colIdx = 0; colIdx < dgv.ColumnCount; colIdx++)
            {
                dgv.Columns[colIdx].MinimumWidth = cellDimension;
            }

            ruchMaX = true;
            lKtoMaRuch.Text = "Tera ruch ma " + (ruchMaX ? "X" : "O");

            Unselect();
        }

        private void BReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private bool CzyKoniecGry()
        {
            bool remis = true;
            for (int colIdx = 0; colIdx < dgv.ColumnCount && remis; colIdx++)
            {
                for (int rowIdx = 0; rowIdx < dgv.ColumnCount; rowIdx++)
                {
                    if (dgv[colIdx, rowIdx].Value.ToString() == "")
                    {
                        remis = false;
                        break;
                    }
                }
            }

            if (remis)
            {
                ZapiszPartię(0);
                MessageBox.Show(this, "Remis!", "Koniec gry", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }

            for (int colIdx = 0; colIdx < dgv.ColumnCount; colIdx++)
            {
                if (dgv[colIdx, 0].Value.ToString() != "" &&
                    dgv[colIdx, 0].Value.ToString() == dgv[colIdx, 1].Value.ToString() && dgv[colIdx, 0].Value.ToString() == dgv[colIdx, 2].Value.ToString())
                {
                    ZapiszPartię(dgv[colIdx, 0].Value.ToString() == "X" ? 1 : -1);
                    
                    MessageBox.Show(this, "Wygrał " + dgv[colIdx, 0].Value.ToString(), "Koniec gry", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    return true;
                }
            }

            for (int rowIdx = 0; rowIdx < dgv.ColumnCount; rowIdx++)
            {
                if (dgv[0, rowIdx].Value.ToString() != "" &&
                    dgv[0, rowIdx].Value.ToString() == dgv[1, rowIdx].Value.ToString() && dgv[0, rowIdx].Value.ToString() == dgv[2, rowIdx].Value.ToString())
                {
                    ZapiszPartię(dgv[0, rowIdx].Value.ToString() == "X" ? 1 : -1);

                    MessageBox.Show(this, "Wygrał " + dgv[0, rowIdx].Value.ToString(), "Koniec gry", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
            }

            if (dgv[0, 0].Value.ToString() != "" &&
                dgv[0, 0].Value.ToString() == dgv[1, 1].Value.ToString() && dgv[0, 0].Value.ToString() == dgv[2, 2].Value.ToString())
            {
                ZapiszPartię(dgv[0, 0].Value.ToString() == "X" ? 1 : -1);

                MessageBox.Show(this, "Wygrał " + dgv[0, 0].Value.ToString(), "Koniec gry", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                return true;
            }

            if (dgv[2, 0].Value.ToString() != "" &&
                dgv[2, 0].Value.ToString() == dgv[1, 1].Value.ToString() && dgv[2, 0].Value.ToString() == dgv[0, 2].Value.ToString())
            {
                ZapiszPartię(dgv[2, 0].Value.ToString() == "X" ? 1 : -1);

                MessageBox.Show(this, "Wygrał " + dgv[2, 0].Value.ToString());
                
                return true;
            }

            return false;
        }

        private void Dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv[e.ColumnIndex, e.RowIndex].Value.ToString() == "")
            {
                OdnotujRuch(e.ColumnIndex, e.RowIndex);

                dgv[e.ColumnIndex, e.RowIndex].Value = ruchMaX ? "X" : "O";

                if (CzyKoniecGry())
                {
                    Reset();
                }
                else
                {
                    ruchMaX = !ruchMaX;
                    lKtoMaRuch.Text = "Tera ruch ma " + (ruchMaX ? "X" : "O");
                }
            }

            Unselect();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Unselect();
        }

        private void OdnotujRuchSamouczenieSie(int[,] table, int rowIndex, int columnIndex, int player)
        {
            String stan = NotacjaStanu(table);

            String ruch = "";

            int[,] tableMove = new int[table.GetLength(0), table.GetLength(1)];

            ResetTable(tableMove);

            tableMove[rowIndex, columnIndex] = player;

            for (int r = 0; r < tableMove.GetLength(0); r++)
            {
                for (int c = 0; c < tableMove.GetLength(1); c++)
                {
                    if (ruch.Length > 0) ruch += ";";

                    ruch += tableMove[r, c];
                }
            }

            stany.Add(stan);
            ruchy.Add(ruch);
        }

        private String NotacjaStanu(int[,] table)
        {
            String stan = "";
            for (int r = 0; r < table.GetLength(0); r++)
            {
                for (int c = 0; c < table.GetLength(1); c++)
                {
                    if (stan.Length > 0) stan += ";";

                    stan += table[r, c];
                }
            }

            return stan;
        }

        private void OdnotujRuch(int columnIndex, int rowIndex)
        {
            // przyjmuję, że wartości w pliku będą następujące:
            // pole 

            String stan = "";
            String ruch = "";

            // Stan przed:
            for (int rowIdx = 0; rowIdx < dgv.RowCount; rowIdx++)
            {
                for (int colIdx = 0; colIdx < dgv.ColumnCount; colIdx++)
                {
                    // -1 - przeciwnik, 
                    //  0 - puste pole, 
                    //  1 - gracz

                    if (ruchMaX)
                    {
                        stan += (dgv[colIdx, rowIdx].Value.ToString() == "" ? "0" :
                            dgv[colIdx, rowIdx].Value.ToString() == "X" ? "1" : "2") + ";";
                    }
                    else
                    {
                        stan += (dgv[colIdx, rowIdx].Value.ToString() == "" ? "0" :
                            dgv[colIdx, rowIdx].Value.ToString() == "X" ? "2" : "1") + ";";
                    }
                }
            }

            stan = stan.Substring(0, stan.Length - 1);

            // Ruch:
            int pozycjaRuchu = rowIndex * 3 + columnIndex;

            for (int i = 0; i < 9; i++)
            {
                ruch += ((i == pozycjaRuchu) ? (ruchMaX ? "X" : "O") : "+") + ";";
            }

            ruch = ruch.Substring(0, ruch.Length - 1);

            stany.Add(stan);
            ruchy.Add(ruch);
        }

        private void ZapiszPartię(int[,] table, int ktoWygrał)
        {
            StreamWriter sw = new StreamWriter("gomoku.csv", true);

            for (int idx = 0; idx < stany.Count; idx++)
            {
                if (idx % 2 == 0) // ruch ma Y
                {
                    // zamieniamy -1 na 1 i na odwrót
                    stany[idx] = stany[idx].Replace("-1", "O").Replace("1", "X").Replace("O", "1").Replace("X", "-1");
                }

                if (ktoWygrał == 0)
                {
                    ruchy[idx] = ruchy[idx].Replace(";-1", ";0,15").Replace(";1", ";0,15");
                } 
                else if (ktoWygrał == -1)
                {
                    if (idx % 2 == 0) // ruch ma X i X przegrał
                    {
                        ruchy[idx] = ruchy[idx].Replace(";-1", ";1");

                        // nic nie zmieniam, bo -1 jest OK
                        // ruchy[idx] = ruchy[idx].Replace(";-1", ";-1");
                    } 
                    else // ruch ma Y i wygrał
                    {
                        ruchy[idx] = ruchy[idx].Replace(";1", ";-1");
                        
                        // nic nie zmieniam, bo 1 jest OK
                        // ruchy[idx] = ruchy[idx].Replace(";1", ";1");

                    }
                }
                else if (ktoWygrał == 1)
                {
                    if (idx % 2 != 0) // ruch ma Y i Y przegrał
                    {
                        ruchy[idx] = ruchy[idx].Replace(";-1", ";1");
                    } 
                    else // ruch ma X i wygrał
                    {
                        ruchy[idx] = ruchy[idx].Replace(";1", ";-1");
                    }
                }

                /*if (idx % 2 == 0 && ktoWygrał == -1) // ruch ma X i X przegrał
                {
                    ruchy[idx] = ruchy[idx].Replace(";1", ";-1");
                }
                else if (idx % 2 != 0 && ktoWygrał == 1) // ruch ma Y i Y przegrał
                {
                    ruchy[idx] = ruchy[idx].Replace(";1", ";-1");
                } 
                else if (ktoWygrał == 0)// remis
                {
                    ruchy[idx] = ruchy[idx].Replace("-1", "0,15").Replace("1", "0,15");
                } else
                {
                    // forsujemy wartość 1, bo ruch ma ten, kto wygrał
                    ruchy[idx] = ruchy[idx].Replace(";-1", ";1");
                }*/

                sw.WriteLine(stany[idx] + ";" + ruchy[idx]);
            }

            sw.WriteLine();
            sw.WriteLine();

            sw.Close();
        }

        private void ZapiszPartię(int ktoWygrał, bool obracaj = true) // -1 = O wygrał, 0 - remis, 1 = X wygrał
        {
            String zamiennikX = null;
            String zamiennikO = null;

            switch (ktoWygrał)
            {
                case -1: // O wygrał
                    zamiennikX = wartoscRuchuNaPrzegrana.ToString();
                    zamiennikO = wartoscRuchuNaWygrana.ToString();

                    break;
                case 0: // remis
                    zamiennikX = wartoscRuchuNaRemis.ToString();
                    zamiennikO = wartoscRuchuNaRemis.ToString();

                    break;
                case 1: // X wygrał
                    zamiennikX = wartoscRuchuNaWygrana.ToString();
                    zamiennikO = wartoscRuchuNaPrzegrana.ToString();

                    break;
                default:
                    zamiennikX = "?";
                    zamiennikO = "?";

                    break;
            }

            StreamWriter sw = new StreamWriter(fileName, true);

            for (int idx = 0; idx < stany.Count; idx++)
            {
                String zamiennikPlus = "0";

                if (idx % 2 == 0 && ktoWygrał == -1) // ruch ma X i X przegrał
                {
                    zamiennikPlus = wartoscBrakuRuchuNaPrzegrana.ToString();
                }
                else if (idx % 2 != 0 && ktoWygrał == 1) // ruch ma Y i Y przegrał
                {
                    zamiennikPlus = wartoscBrakuRuchuNaPrzegrana.ToString();
                }

                sw.WriteLine(stany[idx].Replace("2", "-1") + ";" + 
                    ruchy[idx].Replace("X", zamiennikX).Replace("+", zamiennikPlus).Replace("O", zamiennikO));

                if (obracaj)
                {
                    sw.WriteLine(Obroc(90, stany[idx]).Replace("2", "-1") + ";" +
                        Obroc(90, ruchy[idx]).Replace("X", zamiennikX).Replace("+", zamiennikPlus).Replace("O", zamiennikO));

                    sw.WriteLine(Obroc(180, stany[idx]).Replace("2", "-1") + ";" +
                        Obroc(180, ruchy[idx]).Replace("X", zamiennikX).Replace("+", zamiennikPlus).Replace("O", zamiennikO));

                    sw.WriteLine(Obroc(270, stany[idx]).Replace("2", "-1") + ";" +
                        Obroc(270, ruchy[idx]).Replace("X", zamiennikX).Replace("+", zamiennikPlus).Replace("O", zamiennikO));
                }

                sw.WriteLine();
            }

            sw.WriteLine();
            sw.WriteLine();

            sw.Close();
        }

        private String Obroc(int stopien, String linia)
        {
            String nowaLinia = null;
            // -----------------------------------
            // 012345678901234567  89012345678901234
            //           1           2         3
            // ------------------  -----------------
            // 1;2;3;4;5;6;7;8;9;  1;2;3;4;5;6;7;8;9 - 0 deg
            // 7;4;1; 8;5;2; 9;6;3;     7;4;1; 8;5;2; 9;6;3 - 90 deg
            // 9;8;7; 6;5;4; 3;2;1;     9;8;7; 6;5;4; 3;2;1 - 180 deg
            // 3;6;9; 2;5;8; 1;4;7;     3;6;9; 2;5;8; 1;4;7 - 270 deg

            switch (stopien)
            {
                case 90:
                    nowaLinia = linia[12] + ";" + linia[6] + ";" + linia[0] + ";" +
                                linia[14] + ";" + linia[8] + ";" + linia[2] + ";" +
                                linia[16] + ";" + linia[10] + ";" + linia[4];
                    break;
                case 180:
                    nowaLinia = linia[16] + ";" + linia[14] + ";" + linia[12] + ";" +
                                linia[10] + ";" + linia[8] + ";" + linia[6] + ";" +
                                linia[4] + ";" + linia[2] + ";" + linia[0];
                    break;
                case 270:
                    nowaLinia = linia[4] + ";" + linia[10] + ";" + linia[16] + ";" +
                                linia[2] + ";" + linia[8] + ";" + linia[14] + ";" +
                                linia[0] + ";" + linia[6] + ";" + linia[12];
                    break;
                default:
                    nowaLinia = "[błąd: niepoprawny stopień obrotu]";
                    break;
            }

            return nowaLinia;
        }

        private void Unselect()
        {
            if (dgv.SelectedCells.Count == 1) dgv.SelectedCells[0].Selected = false;
        }

        private void bNauczSieSam_Click(object sender, EventArgs e)
        {
            switch (cbIleWRzedzie.SelectedIndex)
            {
                case 0:

                    break;

                case 1: // gomoku

                    int limitWygranych = 1000;
                    int cntWygranych = 0;

                    while (cntWygranych < limitWygranych)
                    {
                        int tableSize = 15;
                        int[,] table = new int[tableSize, tableSize];

                        stany.Clear();
                        ruchy.Clear();
                        ResetTable(table);

                        int c, r;
                        int player = -1;
                        int winner = 0;

                        int movesCnt = 0;

                        while (winner == 0)
                        {
                            MakeRandomMove(table, -1, out r, out c);

                            OdnotujRuchSamouczenieSie(table, r, c, player);

                            table[r, c] = player;

                            player = player == -1 ? 1 : -1;

                            movesCnt++;

                            winner = WhoWins(table);

                        }

                        if (winner != -2)
                        {
                            Console.WriteLine("Winner: " + winner + " po ilości ruchów: " + movesCnt);
                            cntWygranych++;
                        } 
                        else
                        {
                            Console.WriteLine("Remis: " + winner + " po ilości ruchów: " + movesCnt);
                        }

                        

                        ZapiszPartię(table, winner);

                        //PrintTable(table);
                    }

                    break;
            }
        }

        private void ResetTable(int[,] table)
        {
            for (int r = 0; r < table.GetLength(0); r++)
            {
                for (int c = 0; c < table.GetLength(1); c++)
                {
                    table[r, c] = 0;
                }
            }
        }

        private void PrintTable(int[,] table)
        {
            Console.WriteLine("************************************");

            for (int r = 0; r < table.GetLength(0); r++)
            {
                for (int c = 0; c < table.GetLength(1); c++)
                {
                    Console.Write(table[r, c] == -1 ? "O" : table[r, c] == 1 ? "X" : "+");
                }

                Console.WriteLine();
            }
        }

        private int WhoWins(int[,] table, int howManyInRowToWin = 5) // return -2 if there is no place to put stone
        {
            // 012345678901234 - len = 15, last index to check is 10, 15-5 = 10
            //0          xxxxx
            //1 
            //2         ------
            //3 
            //4 
            //5 
            //6 
            //7 
            //8 
            //9
            //0    x
            //1   x
            //2  x
            //3 x
            //4x

            // horizontal checking:
            for (int r = 0; r < table.GetLength(0); r++)
            {
                for (int c = 0; c <= table.GetLength(1) - howManyInRowToWin; c++)
                {
                    bool win1 = true;
                    bool win2 = true;

                    for (int a = 0; a < howManyInRowToWin; a++)
                    {
                        if (table[r, c + a] != -1)
                        {
                            win1 = false;
                        }

                        if (table[r, c + a] != 1)
                        {
                            win2 = false;
                        }

                        if (!win1 && !win2)
                        {
                            break;
                        }
                    }

                    if (win1) // werify if there is no 6 or more in row (it means that is not winning!)
                    {
                        if (c > 0 && table[r, c - 1] == -1) win1 = false;
                        if (c + howManyInRowToWin < table.GetLength(1) && table[r, c + howManyInRowToWin] == -1) win1 = false;
                    }
                    else if (win2)
                    {
                        if (c > 0 && table[r, c - 1] == 1) win2 = false;
                        if (c + howManyInRowToWin < table.GetLength(1) && table[r, c + howManyInRowToWin] == 1) win2 = false;
                    }

                    if (win1) return -1;
                    if (win2) 
                        return 1;
                }
            }

            // vertical checking:
            for (int c = 0; c < table.GetLength(0); c++)
            {
                for (int r = 0; r <= table.GetLength(0) - howManyInRowToWin; r++)
                {
                    bool win1 = true;
                    bool win2 = true;

                    for (int a = 0; a < howManyInRowToWin; a++)
                    {
                        if (table[r + a, c] != -1)
                        {
                            win1 = false;
                        }

                        if (table[r + a, c] != 1)
                        {
                            win2 = false;
                        }

                        if (!win1 && !win2)
                        {
                            break;
                        }
                    }

                    if (win1) // werify if there is no 6 or more in row (it means that is not winning!)
                    {
                        if (r > 0 && table[r - 1, c] == -1) win1 = false;
                        if (r + howManyInRowToWin < table.GetLength(0) && table[r + howManyInRowToWin, c] == -1) win1 = false;
                    }
                    else if (win2)
                    {
                        if (r > 0 && table[r - 1, c] == 1) win2 = false;
                        if (r + howManyInRowToWin < table.GetLength(0) && table[r + howManyInRowToWin, c] == 1) win2 = false;
                    }

                    if (win1) return -1;
                    if (win2) 
                        return 1;
                }
            }

            // "\" checking:
            for (int c = 0; c < table.GetLength(1) - howManyInRowToWin; c++)
            {
                for (int r = 0; r <= table.GetLength(0) - howManyInRowToWin; r++)
                {
                    bool win1 = true;
                    bool win2 = true;

                    for (int a = 0; a < howManyInRowToWin; a++)
                    {
                        if (table[r + a, c + a] != -1)
                        {
                            win1 = false;
                        }

                        if (table[r + a, c + a] != 1)
                        {
                            win2 = false;
                        }

                        if (!win1 && !win2)
                        {
                            break;
                        }
                    }

                    if (win1) // werify if there is no 6 or more in row (it means that is not winning!)
                    {
                        if (r > 0 && c > 0 && table[r - 1, c - 1] == -1) win1 = false;
                        if (r + howManyInRowToWin < table.GetLength(0) && c + howManyInRowToWin < table.GetLength(1) && 
                            table[r + howManyInRowToWin, c + howManyInRowToWin] == -1) win1 = false;
                    }
                    else if (win2)
                    {
                        if (r > 0 && c > 0 && table[r - 1, c - 1] == 1) win2 = false;
                        if (r + howManyInRowToWin < table.GetLength(0) && c + howManyInRowToWin < table.GetLength(1) &&
                            table[r + howManyInRowToWin, c + howManyInRowToWin] == 1) win2 = false;
                    }

                    if (win1) return -1;
                    if (win2) 
                        return 1;
                }
            }


            // "/" checking:
            for (int c = table.GetLength(0) - 1; c >= howManyInRowToWin - 1; c--)
            {       
                for (int r = 0; r <= table.GetLength(0) - howManyInRowToWin; r++)
                {
                    bool win1 = true;
                    bool win2 = true;

                    for (int a = 0; a < 5; a++)
                    {
                        if (table[r + a, c - a] != -1)
                        {
                            win1 = false;
                        }

                        if (table[r + a, c - a] != 1)
                        {
                            win2 = false;
                        }

                        if (!win1 && !win2)
                        {
                            break;
                        }
                    }

                    if (win1) // werify if there is no 6 or more in row (it means that is not winning!)
                    {
                        if (r > 0 && c + howManyInRowToWin < table.GetLength(1) && table[r - 1, c + 1] == -1) win1 = false;
                        if (r + howManyInRowToWin < table.GetLength(0) && c + howManyInRowToWin < table.GetLength(1) &&
                            table[r + howManyInRowToWin, c + howManyInRowToWin] == -1) win1 = false;
                    }
                    else if (win2)
                    {
                        if (r > 0 && c > 0 && table[r - 1, c - 1] == 1) win2 = false;
                        if (r + howManyInRowToWin < table.GetLength(0) && c + howManyInRowToWin < table.GetLength(1) &&
                            table[r + howManyInRowToWin, c + howManyInRowToWin] == 1) win2 = false;
                    }

                    if (win1) return -1;
                    if (win2) 
                        return 1;
                }
            }

            bool isEmptyPlace = false;

            for (int r = 0; r < table.GetLength(0); r++)
            {
                for (int c = 0; c < table.GetLength(1); c++)
                {
                    if (table[r, c] == 0)
                    {
                        isEmptyPlace = true;
                        break;
                    }

                    if (isEmptyPlace) break;
                }
            }

            return isEmptyPlace ? 0 : -2;
        }

        private void MakeRandomMove(int[,] table, int playerNo, out int r, out int c)
        {
            Random rand = new Random();

            r = rand.Next(0, table.GetLength(0));
            c = rand.Next(0, table.GetLength(1));

            while (table[r, c] != 0)
            {
                r = rand.Next(0, table.GetLength(0));
                c = rand.Next(0, table.GetLength(1));
            }
        }
    }
}
