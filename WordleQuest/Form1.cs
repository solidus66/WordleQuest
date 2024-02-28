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
            LvlScreen lvlScreen = new LvlScreen("Ты умничка!\nЗапиши-ка куда-то вот это: *кусок почты*");
            Hide();
            lvlScreen.ShowDialog();
            Close();

        }

        private void lvl2_Click(object sender, EventArgs e)
        {
            LvlScreen lvlScreen = new LvlScreen("Так держать!\nУгадай, что надо сделать: *кусок почты*");
            Hide();
            lvlScreen.ShowDialog();
            Close();
        }

        private void lvl3_Click(object sender, EventArgs e)
        {
            LvlScreen lvlScreen = new LvlScreen("Жжёшь!\nА вот и третья часть: *кусок почты*");
            Hide();
            lvlScreen.ShowDialog();
            Close();
        }

        private void lvl4_Click(object sender, EventArgs e)
        {
            LvlScreen lvlScreen = new LvlScreen("Как ты это делаешь??\nДержи, это по праву твоё: *кусок почты*");
            Hide();
            lvlScreen.ShowDialog();
            Close();
        }

        private void lvl5_Click(object sender, EventArgs e)
        {
            LvlScreen lvlScreen = new LvlScreen("Слишком мощно....\nВот... используй это знание с умом: *кусок почты*");
            Hide();
            lvlScreen.ShowDialog();
            Close();
        }
    }
}