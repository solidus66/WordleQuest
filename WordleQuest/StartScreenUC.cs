using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordleQuest
{
    public partial class StartScreenUC : UserControl
    {
        public StartScreenUC()
        {
            InitializeComponent();
        }

        private void lvl1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("opened lvl 1"); // попап с сообщением
        }

        private void lvl2_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("opened lvl 2");
        }

        private void lvl3_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("opened lvl 3");
        }

        private void lvl4_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("opened lvl 4");
        }

        private void lvl5_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("opened lvl 5");
        }
    }
}
