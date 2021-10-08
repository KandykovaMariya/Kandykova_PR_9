using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace Kandykova_PR_9
{
    [Table(Name ="Order")]
    class Order
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true, Name = "order_id")]
        public int order_id { get; set; }

        [Column(Name = "created")]
        public DateTime created { get; set; }

        [Column(Name = "customer_id")]
        public int customer_id { get; set; }

        [Column(Name = "point_id")]
        public int point_id { get; set; }

        [Column(Name = "sum")]
        public decimal sum { get; set; }

        [Column(Name = "status_id")]
        public int status_id { get; set; }

        [Column(Name = "deliveryService_id")]
        public int deliveryService_id { get; set; }
    }
}
