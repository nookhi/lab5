using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace client2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        localhost.SushiServiceService service = new localhost.SushiServiceService();

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.Show();

            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        public void output(localhost.sushi[] arrSushi)
        {
            int i = 1;

            arrSushi = service.getAllSushi();

            dataGridView1.Rows.Clear();

            foreach (localhost.sushi el in arrSushi)
            {

                object[] buffer = new object[5];

                buffer[0] = i++;

                buffer[1] = el.name;

                buffer[2] = el.quantity;

                buffer[3] = el.weight;

                buffer[4] = el.price;

                dataGridView1.Rows.Add(buffer);

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
