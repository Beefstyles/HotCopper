using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotCopper
{
    public class HCDB_Threads
    {
        [Key]
        public long Identity { get; set; }
        public string Stock { get; set; }
        public string Tags { get; set; }
        public string Subject { get; set; }
        public string First_Poster { get; set; }
        public Nullable<long> Num_of_Views { get; set; }
        public Nullable<System.DateTime> Begin_Date { get; set; }
        public string Last_Poster { get; set; }
        public string Last_Post { get; set; }
        public Nullable<long> Num_of_Posts { get; set; }
    }
}
