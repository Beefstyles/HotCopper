using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace HotCopper
{
    public class HCDB_MarketData
    {
        [Key]
        public long Identity { get; set; }
        public string Tag { get; set; }
        public System.DateTime Date { get; set; }
        public Nullable<decimal> High { get; set; }
        public Nullable<decimal> Low { get; set; }
        public Nullable<decimal> Open { get; set; }
        public Nullable<decimal> Last { get; set; }
        public Nullable<decimal> Market_Price { get; set; }
        public Nullable<decimal> Volume__Millions_ { get; set; }
        public Nullable<decimal> Value__Millions_ { get; set; }
        public Nullable<decimal> Market_Cap__Billions_ { get; set; }
    }
}
