using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Globalization;

namespace RTadeusiewicz.NN.NeuralNetworks
{
    /// <summary>
    /// Ta klasa reprezentuje zbi�r ucz�cy, u�ywany do uczenia sieci.
    /// </summary>
    /// <remarks>
    /// Klasa ta jest po prostu list� element�w ucz�cych, wzbogacon� o kilka
    /// u�ytecznych metod pomocniczych.
    /// 
    /// Zbi�r ucz�cy mo�e zosta� wczytany z pliku. Plik ten musi mie� nast�puj�cy
    /// format:
    /// 
    /// <code>
    /// 3, 2
    /// pierwszy obiekt
    /// 3, 4.5, 6.3
    /// 0.5, 0.23
    /// drugi obiekt
    /// 3, 2, 1
    /// 0, 0
    /// </code>
    /// 
    /// Pierwszy wiersz pliku zawiera kolejno ilo�� wej�� i wyj�� sieci neuronowej,
    /// dla kt�rej przeznaczony jest dany zbi�r ucz�cy. Kolejne linie opisuj�
    /// poszczeg�lne obiekty ci�gu ucz�cego. Opis ka�dego obiektu sk�ada si� z:
    /// 
    /// <list type="bullet">
    /// <item><description>komentarza (nazwy obiektu)</description></item>
    /// <item><description>warto�ci wej��</description></item>
    /// <item><description>prawid�owych warto�ci wyj��</description></item>
    /// </list>
    /// 
    /// Ilo�� warto�ci wej�� i wyj�� dla ka�dego obiektu musi by� zgodna z wymiarami
    /// sieci podanymi w pierwszej linii.
    /// </remarks>
    public class TeachingSet : List<TeachingSet.Element>
    {
        /// <summary>
        /// Element ci�gu ucz�cego. Zawiera wej�cia, prawid�owe wyj�cie i komentarz
        /// (nazw� obiektu opisywanego przez wej�cia).
        /// </summary>
        public struct Element
        {
            /// <summary>
            /// Warto�ci sygna��w, jakie powinny zosta� podane na wej�cia sieci
            /// neuronowej. Mog� wymaga� normalizacji.
            /// </summary>
            public double[] Inputs;

            /// <summary>
            /// Warto�ci, jakich oczekujemy na wyj�ciu sieci neuronowej.
            /// </summary>
            public double[] ExpectedOutputs;

            /// <summary>
            /// Komentarz. Mo�e by� to nazwa obiektu reprezentowanego przez ten
            /// element.
            /// </summary>
            public string Comment;
            
            public Element Clone()
            {
                Element ret = this;
                ret.Inputs = (double[])Inputs.Clone();
                ret.ExpectedOutputs = (double[])ExpectedOutputs.Clone();
                return ret;
            }
        }

        /// <summary>
        /// Tworzy nowy zbi�r ucz�cy.
        /// </summary>
        /// <param name="inputCount">Ilo�� wej�� sieci neuronowej, dla kt�rej
        /// przeznaczony jest ten zbi�r.</param>
        /// <param name="outputCount">Ilo�� wyj�� sieci neuronowej, dla kt�rej
        /// przeznaczony jest ten zbi�r.</param>
        public TeachingSet(int inputCount, int outputCount)
        {
            _inputCount = inputCount;
            _outputCount = outputCount;
        }

        public TeachingSet(TeachingSet set): base(set.Count)
        {
            _inputCount = set._inputCount;
            _outputCount = set._outputCount;
            foreach (Element elem in set)
                Add(elem.Clone());
        }

        // Przechowuje warto�� w�asno�ci InputCount
        private int _inputCount;

        /// <summary>
        /// Ilo�� wej�� sieci neuronowej, dla kt�rej przeznaczony jest ten zbi�r.
        /// W�asno�� ta ma jedynie charakter informacyjny i wcale nie musi
        /// odzwierciedla� stanu faktycznego, sczeg�lnie je�li zosta�a zmieniona.
        /// Istnieje jedynie gwarancja, �e po odczytaniu zbioru z pliku w�asno��
        /// ta b�dzie mia�a prawid�ow� warto��.
        /// </summary>
        public int InputCount
        {
            get { return _inputCount; }
            set { _inputCount = value; }
        }

        // Przechowuje warto�� w�asno�ci OutputCount.
        private int _outputCount;

        /// <summary>
        /// Ilo�� wyj�� sieci neuronowej, dla kt�rej przeznaczony jest ten zbi�r.
        /// W�asno�� ta ma jedynie charakter informacyjny i wcale nie musi
        /// odzwierciedla� stanu faktycznego, sczeg�lnie je�li zosta�a zmieniona.
        /// Istnieje jedynie gwarancja, �e po odczytaniu zbioru z pliku w�asno��
        /// ta b�dzie mia�a prawid�ow� warto��.
        /// </summary>
        public int OutputCount
        {
            get { return _outputCount; }
            set { _outputCount = value; }
        }

        // Przetwarza pojedyncz� lini� z pliku opisuj�cego zbi�r ucz�cy. Zwraca
        // tablic� liczb zawartych w tej linii lub wyrzuca wyj�tek o podanej tre�ci,
        // je�li ich ilo�� nie zgadza si� z oczekiwaniami.
        private static double[] ParseLine(TextReader reader, int expectedLength,
            string exceptionString)
        {
            /* Musimy to zrobi�, aby format pliku by� uniwersalny (r�ne narody
             * w r�ny spos�b zapisuj� liczby dziesi�tne). */
            NumberFormatInfo invariantFormat =
                CultureInfo.InvariantCulture.NumberFormat;

            String line = reader.ReadLine();
            if (line == null)
                return null;
            if (line == "")
                throw new ApplicationException(
                    "Empty line encountered where the numbers were expected.");

            /* Rozbijamy lini� na liczby rozdzielone przecinkami. Spacje nam nie
             * przeszkadzaj�. */
            string[] fields = line.Split(',');
            if (fields.Length != expectedLength)
                throw new ApplicationException(exceptionString);
            double[] ret = new double[expectedLength];
            for (int i = 0; i < fields.Length; i++)
                ret[i] = double.Parse(fields[i], invariantFormat);
            return ret;
        }

        /// <summary>
        /// Wczytuje zbi�r ucz�cy z pliku.
        /// </summary>
        /// <param name="fileName">Nazwa pliku.</param>
        /// <exception cref="ApplicationException">Plik ma nieprawid�owy format.
        /// </exception>
        /// <returns>Wczytany zbi�r ucz�cy lub <c>null</c>, je�li plik jest pusty.
        /// </returns>
        public static TeachingSet FromFile(string fileName)
        {
            using (StreamReader sr = new StreamReader(fileName))
            {
                return TeachingSet.FromText(sr);
            }
        }

        /// <summary>
        /// Wczytuje zbi�r ucz�cy ze strumienia.
        /// </summary>
        /// <param name="stream">Strumie� zawieraj�cy zbi�r ucz�cy</param>
        /// <exception cref="ApplicationException">Strumie� ma nieprawid�owy format.
        /// </exception>
        /// <returns>Wczytany zbi�r ucz�cy lub <c>null</c>, je�li strumie� jest pusty.
        /// </returns>
        public static TeachingSet FromStream(Stream stream)
        {
            using (StreamReader sr = new StreamReader(stream))
            {
                return TeachingSet.FromText(sr);
            }
        }

        /// <summary>
        /// Interpretuje podany tekst jako opis zbioru ucz�cego.
        /// </summary>
        /// <param name="reader">Obiekt odczytuj�cy tekst.</param>
        /// <exception cref="ApplicationException">Tekst ma nieprawid�owy format.
        /// </exception>
        /// <returns>Wczytany zbi�r ucz�cy lub <c>null</c>, je�li tekst jest pusty.
        /// </returns>
        public static TeachingSet FromText(TextReader reader)
        {
            try
            {
                // Pierwsza linia - wymiary sieci.
                string line = reader.ReadLine();
                if (line == null)
                    return null;

                string[] fields = line.Split(',');
                if (fields.Length != 2)
                    throw new ApplicationException("First line must contain two numbers.");
                int inputCount = int.Parse(fields[0]);
                int outputCount = int.Parse(fields[1]);

                TeachingSet ret = new TeachingSet(inputCount, outputCount);

                // Poszczeg�lne obiekty.
                while ((line = reader.ReadLine()) != null)
                {
                    Element elem;
                    elem.Comment = line;

                    elem.Inputs =
                        ParseLine(reader, inputCount, "Invalid number of inputs.");
                    if (elem.Inputs == null)
                        break;

                    elem.ExpectedOutputs =
                        ParseLine(reader, outputCount, "Invalid number of outputs.");
                    if (elem.ExpectedOutputs == null)
                        break;

                    ret.Add(elem);
                }
                return ret;
            }
            catch (ApplicationException) { throw; }
            catch (Exception ex)
            {
                throw new ApplicationException("The file is corrupted.", ex);
            }
        }

        public void Normalize()
        {
            foreach (Element elem in this)
                Neuron.Normalize(elem.Inputs);
        }
    }
}
