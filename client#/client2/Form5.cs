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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        localhost.SushiServiceService service = new localhost.SushiServiceService();
        private void hScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {
            label6.Text = hScrollBar2.Value.ToString();
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            label5.Text = hScrollBar1.Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

            localhost.sushi el = new localhost.sushi();

            el.name = comboBox1.SelectedItem.ToString();

            el.quantity = Convert.ToInt32(numericUpDown1.Value);

            el.weight = hScrollBar1.Value;

            el.price = hScrollBar2.Value;

            Form2 f2 = new Form2();

            service.setNewSushi(el);

            f2.output(service.getAllSushi());

            f2.Show();
        }

        private void Отменить_Click(object sender, EventArgs e)
        {
            this.Close();
            Form2 f2 = new Form2();
            f2.Show();
        }
    }
}
