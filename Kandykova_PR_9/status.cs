using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace Kandykova_PR_9
{
    [Table(Name = "Status")]
    class status
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true, Name = "status_id")]
        public int status_id { get; set; }

        [Column(Name = "statuse_name")]
        public string statuse_name { get; set; }
        
        [Column(Name = "code")]
        public int code { get; set; }

        [Column(Name = "color_id")]
        public int color_id { get; set; }



    }
}

