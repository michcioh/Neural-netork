using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Neural
{
    [Serializable]
    public class MappedValue
    {
        public String OriginalValue { get; set; }
        public String NewValue { get; set; }
    }
}
