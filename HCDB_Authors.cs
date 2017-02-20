using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace HotCopper
{

    public class HCDB_Authors
    {
        [Key]
        public long Identity { get; set; }
        public string Name { get; set; }
        public Nullable<long> Num_of_Posts { get; set; }
        public Nullable<long> Likes_Received { get; set; }
        public Nullable<long> Following { get; set; }
        public Nullable<long> Followers { get; set; }
        public string Following_List { get; set; }
        public string Followers_List { get; set; }
        public Nullable<long> Num_of_Posts_in_calendar_month { get; set; }
        public string Following_Stocks { get; set; }
    }
}
