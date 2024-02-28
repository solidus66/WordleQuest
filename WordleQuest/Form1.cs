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
            LvlScreen lvlScreen = new LvlScreen("кусочек почты 1");
            Hide();
            lvlScreen.ShowDialog();
            Close();

        }

        private void lvl2_Click(object sender, EventArgs e)
        {
            LvlScreen lvlScreen = new LvlScreen("кусочек почты 2");
            Hide();
            lvlScreen.ShowDialog();
            Close();
        }

        private void lvl3_Click(object sender, EventArgs e)
        {
            LvlScreen lvlScreen = new LvlScreen("кусочек почты 3");
            Hide();
            lvlScreen.ShowDialog();
            Close();
        }

        private void lvl4_Click(object sender, EventArgs e)
        {
            LvlScreen lvlScreen = new LvlScreen("кусочек почты 4");
            Hide();
            lvlScreen.ShowDialog();
            Close();
        }

        private void lvl5_Click(object sender, EventArgs e)
        {
            LvlScreen lvlScreen = new LvlScreen("кусочек почты 5");
            Hide();
            lvlScreen.ShowDialog();
            Close();
        }
    }
}