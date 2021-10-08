using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace Kandykova_PR_9
{
    [Table(Name = "Costumer")]
    class Costumer
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true, Name = "costumer_id")]
        public int costumer_id { get; set; }

        [Column(Name = "costumer_name")]
        public string costumer_name { get; set; }

        [Column(Name = "firs_name")]
        public string firs_name { get; set; }

        [Column(Name = "last_name")]
        public string last_name { get; set; }

        [Column(Name = "created")]
        public DateTime created { get; set; }

        [Column(Name = "phone")]
        public string phone { get; set; }

        [Column(Name = "email")]
        public string email { get; set; }
    }
}
