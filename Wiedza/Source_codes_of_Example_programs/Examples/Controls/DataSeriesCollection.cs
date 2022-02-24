using System;
using System.Collections.Generic;
using System.Text;

namespace RTadeusiewicz.NN.Controls
{
    public class DataSeriesCollection : IList<DataSeries>
    {
        private IList<DataSeries> _impl = new List<DataSeries>();

        private ChartPlotter _plotterControl;

        public ChartPlotter PlotterControl
        {
            get { return _plotterControl; }
        }

        public DataSeriesCollection(ChartPlotter plotterControl)
        {
            if (plotterControl == null)
                throw new ArgumentNullException("plotterControl");
            _plotterControl = plotterControl;
        }

        #region IList<DataSeries> Members

        public int IndexOf(DataSeries item)
        {
            return _impl.IndexOf(item);
        }

        public void Insert(int index, DataSeries item)
        {
            _impl.Insert(index, item);
            if (item != null)
            {
                item.PlotterControl = _plotterControl;
                _plotterControl.Invalidate();
            }
        }

        public void RemoveAt(int index)
        {
            DataSeries ds = _impl[index];
            if (ds != null)
                ds.PlotterControl = null;
            _impl.RemoveAt(index);
            _plotterControl.Invalidate();
        }

        public DataSeries this[int index]
        {
            get
            {
                return _impl[index];
            }
            set
            {
                DataSeries ds = _impl[index];
                if (ds != value)
                {
                    _impl[index] = value;
                    if (ds != null)
                        ds.PlotterControl = null;
                    if (value != null)
                        value.PlotterControl = _plotterControl;
                    _plotterControl.Invalidate();
                }
            }
        }

        #endregion

        #region ICollection<DataSeries> Members

        public void Add(DataSeries item)
        {
            _impl.Add(item);
            if (item != null)
            {
                item.PlotterControl = _plotterControl;
                _plotterControl.Invalidate();
            }
        }

        public void Clear()
        {
            foreach (DataSeries ds in _impl)
            {
                if (ds != null)
                    ds.PlotterControl = null;
            }
            _impl.Clear();
            _plotterControl.Invalidate();
        }

        public bool Contains(DataSeries item)
        {
            return _impl.Contains(item);
        }

        public void CopyTo(DataSeries[] array, int arrayIndex)
        {
            _impl.CopyTo(array, arrayIndex);
        }

        public int Count
        {
            get { return _impl.Count; }
        }

        public bool IsReadOnly
        {
            get { return _impl.IsReadOnly; }
        }

        public bool Remove(DataSeries item)
        {
            if (_impl.Remove(item))
            {
                if (item != null)
                    item.PlotterControl = null;
                _plotterControl.Invalidate();
                return true;
            }
            else
                return false;
        }

        #endregion

        #region IEnumerable<DataSeries> Members

        public IEnumerator<DataSeries> GetEnumerator()
        {
            return _impl.GetEnumerator();
        }

        #endregion

        #region IEnumerable Members

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return (_impl as System.Collections.IEnumerable).GetEnumerator();
        }

        #endregion
    }
}
