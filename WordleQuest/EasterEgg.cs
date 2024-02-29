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
    public partial class EasterEgg : Form
    {
        private string EasterEggImage;
        public EasterEgg(string easterEggImage)
        {
            InitializeComponent();
            EasterEggImage = easterEggImage;
            pictureBox1.Image = Image.FromFile(EasterEggImage);
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
