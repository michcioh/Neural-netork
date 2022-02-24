using System;
using System.Collections.Generic;
using System.Text;

namespace RTadeusiewicz.NN.Controls
{
    public class NotifyingList<T> : IList<T>
    {
        public NotifyingList(int capacity)
        {
            _impl = new List<T>(capacity);
        }

        public NotifyingList() : this(0) { }

        private IList<T> _impl;

        private void onChange()
        {
            if (_change != null)
                _change(this, EventArgs.Empty);
        }

        private EventHandler _change;

        public event EventHandler Change
        {
            add { _change += value; }
            remove { _change -= value; }
        }

        #region IList<T> Members

        public int IndexOf(T item)
        {
            return _impl.IndexOf(item);
        }

        public void Insert(int index, T item)
        {
            _impl.Insert(index, item);
            onChange();
        }

        public void RemoveAt(int index)
        {
            _impl.RemoveAt(index);
            onChange();
        }

        public T this[int index]
        {
            get
            {
                return _impl[index];
            }
            set
            {
                _impl[index] = value;
                onChange();
            }
        }

        #endregion

        #region ICollection<T> Members

        public void Add(T item)
        {
            _impl.Add(item);
            onChange();
        }

        public void Clear()
        {
            _impl.Clear();
            onChange();
        }

        public bool Contains(T item)
        {
            return _impl.Contains(item);
        }

        public void CopyTo(T[] array, int arrayIndex)
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

        public bool Remove(T item)
        {
            bool ret = _impl.Remove(item);
            onChange();
            return ret;
        }

        #endregion

        #region IEnumerable<T> Members

        public IEnumerator<T> GetEnumerator()
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
