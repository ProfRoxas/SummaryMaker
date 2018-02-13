using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SummaryMaker
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void CardSelect(object sender, EventArgs e)
        {
            int n;
            if (!int.TryParse(sender.ToString(), out n))
                return;
            for(int i = 0; i<n; i++)
            {
                tabControl2.TabPages.Add(createTabPage("Card"+i));
            }
        }
        private TabPage createTabPage(string param)
        {
            TabPage template = new TabPage("a");
            template.Controls.Add(new Label() { Text = param });

            return template;
        }
    }
}
