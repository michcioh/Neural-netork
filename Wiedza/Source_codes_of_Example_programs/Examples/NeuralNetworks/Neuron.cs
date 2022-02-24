using System;

namespace RTadeusiewicz.NN.NeuralNetworks
{
    /// <summary>
    /// This class represents a linear neuron.
    /// </summary>
    /// <remarks>
    /// A neuron is the basic component of a neural network. It's analogous to the
    /// biological neuron. Its basic property is a set (or a vector, from the
    /// mathematical point of view) of the remembered weights. Each weight is a number
    /// assigned to a particular input, describing how strongly (positively or
    /// negatively) the signal given to that input influences the neuron's response.
    /// </remarks>
    public class Neuron
    {
        /// <summary>
        /// Creates a neuron containing the given number of inputs.
        /// </summary>
        /// <param name="inputCount">The number of neuron's inputs. The weights array
        /// will have the size equal to the given number of inputs.</param>
        public Neuron(int inputCount)
        {
            _weights = new double[inputCount];
            _prevWeights = new double[inputCount];
        }

        // Stores the value of the Weights property.
        private double[] _weights;

        /// Przechowuje poprzednie warto�� w�asno�ci Weights.
        private double[] _prevWeights;

        /// <summary>
        /// Returns an array containing the weights of each of this neuron's inputs.
        /// </summary>
        public double[] Weights
        {
            get
            {
                return _weights;
            }
        }

        /// <summary>
        /// Tablica zawieraj�ca poprzednie wagi poszczeg�lnych wej�� neuronu.
        /// </summary>
        public double[] PrevWeights
        {
            get
            {
                return _prevWeights;
            }
        }

        /// <summary>
        /// Computes the response of this neuron to the given signal.
        /// <remarks>
        /// To compute the response of a linear network, we need to calculate the
        /// product of each input signal component and its corresponding input weight.
        /// The sum of these products is our response. In practice it turns out that
        /// the more the signal is "similar" to the weights remembered by the neuron,
        /// the more positive the neuron's response will be.
        /// </remarks>
        /// <param name="inputSignals">The signal provided to the neuron inputs. Each
        /// element of the array corresponds to an individual input, so the array's
        /// length should math the number of inputs.</param>
        /// <returns>The neuron's response to the given signal.</returns>
        public virtual double Response(double[] inputSignals)
        {
            // Check if the argument is correct.
            if (inputSignals == null || inputSignals.Length != _weights.Length)
                throw new ArgumentException(
                    "The signal array must have the same length as the weight array.");

            // Calculate the output as the sum of products.
            double result = 0.0;
            for (int i = 0; i < _weights.Length; i++)
                result += _weights[i] * inputSignals[i];
            return result;
        }

        // response neuronu dla exampla 10c white
        public virtual double Response(double[] inputSignals, out double odl)
        {
            // Sprawdzamy, czy argument jest poprawny.
            if (inputSignals == null || inputSignals.Length != _weights.Length)
                throw new ArgumentException(
                    "The signal array must have the same length as the weight array.");

            // Obliczamy wyj�cie.
            double result = 0.0;
            odl = 0;
            for (int i = 0; i < _weights.Length; i++)
                odl += Math.Pow(_weights[i] - inputSignals[i], 2);

            result = 1 / (1E-10 + odl);
            return result;
        }

        /// <summary>
        /// Oblicza moc podanego sygna�u, u�ywaj�c zadanej miary.
        /// </summary>
        /// <param name="signals">Sygna�, kt�rego moc obliczamy</param>
        /// <param name="norm">Norma, jak� mierzymy moc (euklidesowa lub manhatta�ska)
        /// </param>
        /// <returns>Obliczona moc</returns>
        /// <remarks>
        /// Moc sygna�u wp�ywa na to, jak bardzo "istotny" jest on dla neuronu.
        /// Je�li zamiast sygna�u podamy warto�ci wsp�czynnik�w wag, dostaniemy
        /// moc �ladu pami�ciowego - czyli warto�� okre�laj�c�, jak bardzo
        /// "zdecydowany" jest dany neuron.
        /// </remarks>
        /// <seealso cref="MemoryTraceStrength(StrengthNorm)"/>
        public static double Strength(double[] signals, StrengthNorm norm)
        {
            double strength = 0;
            switch (norm)
            {
                case StrengthNorm.Manhattan:
                    foreach (double s in signals)
                        strength += Math.Abs(s);
                    return strength;

                case StrengthNorm.Euclidean:
                    foreach (double s in signals)
                        strength += s * s;
                    return Math.Sqrt(strength);

                default:
                    return 0.0;
            }
        }

        /// <summary>
        /// Oblicza moc �ladu pami�ciowego.
        /// </summary>
        /// <param name="norm">Norma, jak� mierzymy moc (euklidesowa lub manhatta�ska)
        /// </param>
        /// <returns>Obliczona moc �ladu pami�ciowego</returns>
        /// <remarks>
        /// Moc �ladu pami�ciowego okre�la, jak bardzo "zdecydowany" jest
        /// neuron. Im wi�ksza moc �ladu pami�ciowego, tym bardziej radykalne b�d�
        /// jego "opinie".
        /// </remarks>
        public double MemoryTraceStrength(StrengthNorm norm)
        {
            return Strength(_weights, norm);
        }

        /// <summary>
        /// Normalizuje podany sygna�.
        /// </summary>
        /// <param name="signals">Sygna� do normalizacji. Metoda zmienia zawarto��
        /// tej tablicy, wi�c aby zachowa� orygina�, trzeba go najpierw gdzie�
        /// skopiowa�.</param>
        /// <remarks>
        /// Normalizacja polega na tym, �e wszystkie sk�adowe s� zmieniane tak, aby
        /// nie uleg�y zmianie ich proporcje, za to moc sygna�u wynios�a dok�adnie 1.
        /// Innymi s�owy, wektor sygna�u jest skalowany tak, aby mia� d�ugo�� 1 (wg
        /// normy Euklidesowej).
        /// </remarks>
        public static void Normalize(double[] signals)
        {
            double strength = Strength(signals, StrengthNorm.Euclidean);
            for (int i = 0; i < signals.Length; i++)
                signals[i] /= strength;
        }

        /// <summary>
        /// Uczy neuron reakcji na dany sygna�. Jest to "uczenie z nauczycielem".
        /// </summary>
        /// <param name="signals">Sygna�, na kt�ry neuron ma zareagowa�.</param>
        /// <param name="expectedOutput">Prawid�owa odpowied� neuronu.</param>
        /// <param name="ratio">Wsp�czynnik uczenia. Im wi�kszy, tym szybszy b�dzie
        /// proces uczenia, lecz mniejsza jego stabilno��.</param>
        /// <param name="previousResponse">Parametr wyj�ciowy; metoda umieszcza
        /// w nim odpowied� neuronu na zadany sygna� przed uczeniem.</param>
        /// <param name="previousError">Parametr wyj�ciowy; metoda umieszcza w nim
        /// wielko�� b��du pope�nianego przez neuron przed uczeniem.</param>
        public void Learn(double[] signals, double expectedOutput, double ratio,
            out double previousResponse, out double previousError)
        {
            /* Nie sprawdzamy rozmiaru tablicy sygna��w - Response() zrobi to
             * za nas. */
            previousResponse = Response(signals);
            previousError = expectedOutput - previousResponse;
            for (int i = 0; i < _weights.Length; i++)
                _weights[i] += ratio * previousError * signals[i];
        }

        public void Learn(double[] signals, double[] previous_weights, double sigma_gradient, double ratio, double momentum)
        {
            for (int i = 0; i < _weights.Length; i++)
                _weights[i] += ratio * sigma_gradient * signals[i] - momentum * (_weights[i] - previous_weights[i]);
        }

        public void Randomize(Random randomGenerator, double min, double max)
        {
            double length = max - min;
            for (int i = 0; i < _weights.Length; i++)
                _weights[i] = min + length * randomGenerator.NextDouble();
        }

        /* dodane dla przykladu 10a,ax,b */
        public void Learn(double[] signals, double etha, double max)
        {

            double previous_response = Response(signals);

            if (previous_response < 0.2 * max)
                previous_response *= 0.3;
            if (previous_response < 0)
                previous_response *= 0.1;

            for (int i = 0; i < _weights.Length; i++)
            {
                _prevWeights[i] = _weights[i];
                _weights[i] += etha * previous_response * (signals[i] - _weights[i]);
            }
        }

        /* dodane dla przykladu 10c samouczenie z konkurencja */
        public void LearnSelf(double[] signals, double etha)
        {
            for (int i = 0; i < _weights.Length; i++)
            {
                _prevWeights[i] = _weights[i];
                _weights[i] += etha * (signals[i] - _weights[i]);
            }
        }

        public void Randomize(Random randomGenerator, double min, double max, double epsilon)
        {
            double length = max - min;
            for (int i = 0; i < _weights.Length; i++)
            {
                _weights[i] = min + length * randomGenerator.NextDouble();
                if (Math.Abs(_weights[i]) < epsilon)
                    _weights[i] = epsilon;
            }
        }

    }

    /// <summary>
    /// Rodzaje miar mocy sygna�u.
    /// </summary>
    public enum StrengthNorm
    { 

        /// <summary>
        /// Moc obliczana jako suma warto�ci bezwzgl�dnych poszczeg�lnych sk�adnik�w
        /// sygna�u. Jej nazwa wzi�a si� st�d, �e mo�e ona s�u�y� do okre�lania
        /// d�ugo�ci, jak� nale�y przejecha� w wielkim mie�cie mi�dzy dwoma punktami,
        /// ale nie w linii prostej, tylko po prostopad�ych do siebie ulicach.
        /// </summary>
        Manhattan,

        /// <summary>
        /// Moc obliczana jako pierwiastek kwadratowy sumy kwadrat�w poszczeg�lnych
        /// sk�adnik�w sygna�u. Innymi s�owy - jest to odleg�o�� w przestrzeni mi�dzy
        /// pocz�tkiem uk�adu wsp�rz�dnych a punktem o wsp�rz�dnych odpowiadaj�cych
        /// sk�adnikom sygna�u.
        /// </summary>
        Euclidean
    }
}
