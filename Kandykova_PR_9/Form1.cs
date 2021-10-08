using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Linq;
using System.Data.Linq.Mapping;


namespace Kandykova_PR_9
{
    public partial class Form1 : Form
    {
        static string conStr = "Data Source=10.10.1.24;Initial Catalog = PR_9_Kan; Persist Security Info=True;User ID = pro-41; Password=IsPro-41";
        DataContext context = new DataContext(conStr);

        public Form1()
        {
            InitializeComponent();

            Table<Order> order = context.GetTable<Order>();
            dataGridView1.DataSource = order.ToList();

            Table<status> status1 = context.GetTable<status>();
            dataGridView2.DataSource = status1.ToList();

            Table<Costumer> costumer = context.GetTable<Costumer>();
            dataGridView3.DataSource = costumer.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Order newOrder = new Order
            {
                created = Convert.ToDateTime(textBox3.Text),
                customer_id = Convert.ToInt32(textBox4.Text),
                point_id = Convert.ToInt32(textBox5.Text),
                sum = Convert.ToDecimal(textBox6.Text),
                status_id=Convert.ToInt32(textBox7.Text),
                deliveryService_id=Convert.ToInt32(textBox8.Text),

            };

            context.GetTable<Order>().InsertOnSubmit(newOrder);
            context.SubmitChanges();
            Table<Order> order = context.GetTable<Order>();
            dataGridView1.DataSource = order.ToList();


        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Costumer newCostumer = new Costumer
            {
                costumer_name = textBox9.Text,
                firs_name = textBox10.Text,
                last_name = textBox11.Text,
                created = Convert.ToDateTime(textBox12.Text),
                phone = textBox13.Text,
                email = textBox14.Text,
            };
            context.GetTable<Costumer>().InsertOnSubmit(newCostumer);
            context.SubmitChanges();
            Table<Costumer> costumers = context.GetTable<Costumer>();
            dataGridView3.DataSource = costumers.ToList();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Costumer costumer = context.GetTable<Costumer>().FirstOrDefault(
               x => x.costumer_id == Convert.ToInt32(dataGridView3.CurrentRow.Cells[0].Value));

            costumer.costumer_name = textBox9.Text;
            costumer.firs_name = textBox10.Text;
            costumer.last_name = textBox11.Text;
            costumer.created = Convert.ToDateTime(textBox12.Text);
            costumer.phone = Convert.ToString(textBox13.Text);
            costumer.email = Convert.ToString(textBox14.Text);
            context.SubmitChanges();
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Costumer costumer = context.GetTable<Costumer>().FirstOrDefault(
                x => x.costumer_id == Convert.ToInt32(dataGridView3.CurrentRow.Cells[0].Value));
            textBox9.Text = costumer.costumer_name;
            textBox10.Text = costumer.firs_name;
            textBox11.Text = costumer.last_name;
            textBox12.Text = costumer.created.ToLongDateString();
            textBox13.Text = costumer.phone.ToString();
            textBox14.Text = costumer.email.ToString();
               
        }
        
        private void button6_Click(object sender, EventArgs e)
        {
            //Преждставленный ниже код, не осуществляет поиск пользователя
            string[] costumer = {"@costumer_name"};
            IEnumerable<string> sequence = costumer.Where(p => p.StartsWith(textBox1.Text));
            foreach (string s in sequence)
               Console.WriteLine(s);


        }
    }
}
