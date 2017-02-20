using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotCopper
{
    public class HCDB_Posts
    {
        [Key]
        public long Identity { get; set; }
        public string Stock { get; set; }
        public string Subject { get; set; }
        public long PageNum { get; set; }
        public string Content { get; set; }
        public Nullable<long> NegWords { get; set; }
        public Nullable<long> PosWords { get; set; }
        public Nullable<long> Likes { get; set; }
        public Nullable<decimal> Price_at_Posting { get; set; }
        public string Sentiment { get; set; }
        public string Disclosure { get; set; }
        public string Author { get; set; }
        public Nullable<System.DateTime> DateTime { get; set; }
        public Nullable<long> Post_ID { get; set; }
        public string IP { get; set; }
        public Nullable<long> Length_of_Post { get; set; }
    }
}
