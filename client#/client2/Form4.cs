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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        localhost2.SushiDirectoryServiceService service = new localhost2.SushiDirectoryServiceService();

        localhost2.sushiDirectory[] arrSushiDirectory;

        

    private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();

            this.Close();

            localhost2.sushiDirectory el = new localhost2.sushiDirectory();

            el.itemName = textBox1.Text;

            el.itemType = comboBox1.SelectedItem.ToString();

            el.itemDescription = richTextBox1.Text;

            service.setNewSushiDirectory(el);

            f3.output(service.getAllSushiDirectory());

            f3.Show();
        }
    }
}
