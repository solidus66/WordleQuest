namespace WordleQuest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lvl1_Click(object sender, EventArgs e)
        {
            //System.Windows.Forms.MessageBox.Show("lvl-1 will be opened here");
            LvlScreen lvlScreen = new LvlScreen();
            Hide();
            lvlScreen.ShowDialog();
            Close();

        }

        private void lvl2_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("lvl-2 will be opened here");
        }

        private void lvl3_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("lvl-3 will be opened here");
        }

        private void lvl4_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("lvl-4 will be opened here");
        }

        private void lvl5_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("lvl-5 will be opened here");
        }
    }
}