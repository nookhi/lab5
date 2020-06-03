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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        localhost2.SushiDirectoryServiceService service = new localhost2.SushiDirectoryServiceService();

        private void Form3_Load(object sender, EventArgs e)
        {
            output(service.getAllSushiDirectory());
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void output(localhost2.sushiDirectory[] arrSushiDirectory)
        {
            arrSushiDirectory = service.getAllSushiDirectory();

            dataGridView1.Rows.Clear();

            foreach (localhost2.sushiDirectory el in arrSushiDirectory)
            {

                object[] buffer = new object[3];

                buffer[0] = el.itemName;

                buffer[1] = el.itemType;

                buffer[2] = el.itemDescription;

                dataGridView1.Rows.Add(buffer);

            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
            this.Close();
        }
    }
}
