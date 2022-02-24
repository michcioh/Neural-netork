using System;
using System.Collections.Generic;
using System.Text;

namespace RTadeusiewicz.NN.Example10c
{
    public class NewRandom: Random
    {
        private Random _rndGenerator = new Random();
        private double[] _prevGenetator;
        private bool _randmize = true;
        private int _currentNumber = 0;
        private int _elements = 0;


        internal int Elements
        {
            get { return _elements; }
        }

        public void Randomize(bool r)
        {
            _randmize=r;
        }

        public NewRandom(int size)
        {
             _prevGenetator = new double[size];
             _elements = size;
             _currentNumber = 0;
            for (int i=0; i<size;i++)
                _prevGenetator[i]=_rndGenerator.NextDouble();
        } 

        public override double NextDouble()
        {
                double _rnd;
                if (_randmize)
                {
                    _rnd = _rndGenerator.NextDouble();
                    if (_prevGenetator.Length > _currentNumber)
                        _prevGenetator[_currentNumber++] = _rnd;
                    return _rnd;
                }
                else
                {
                    if (_prevGenetator.Length > _currentNumber)                    
                        return _prevGenetator[_currentNumber++];
                    else
                        return _rndGenerator.NextDouble();
                }
            }

        public void RewindTable()
        {
                _currentNumber = 0;
        }
    }
}
