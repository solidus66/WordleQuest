namespace WordleQuest
{
    public partial class StartScreen : Form
    {
        public StartScreen()
        {
            InitializeComponent();
        }

        private void lvl1_Click(object sender, EventArgs e)
        {
            LvlScreen lvlScreen = new LvlScreen("Ты умничка!\nЗапиши-ка куда-то вот это: 73203820", "resx/img/cat.png");
            Hide();
            lvlScreen.ShowDialog();
            Close();

        }

        private void lvl2_Click(object sender, EventArgs e)
        {
            LvlScreen lvlScreen = new LvlScreen("Так держать!\nУгадай, что надо сделать: 6d617274", "resx/img/cat2.png");
            Hide();
            lvlScreen.ShowDialog();
            Close();
        }

        private void lvl3_Click(object sender, EventArgs e)
        {
            LvlScreen lvlScreen = new LvlScreen("Жжёшь!\nА вот и третья часть: 612c2063", "resx/img/cat3.png");
            Hide();
            lvlScreen.ShowDialog();
            Close();
        }

        private void lvl4_Click(object sender, EventArgs e)
        {
            LvlScreen lvlScreen = new LvlScreen("Как ты это делаешь??\nДержи, это по праву твоё: 6875646f", "resx/img/cat4.png");
            Hide();
            lvlScreen.ShowDialog();
            Close();
        }

        private void lvl5_Click(object sender, EventArgs e)
        {
            LvlScreen lvlScreen = new LvlScreen("Слишком мощно....\nВот... используй это знание с умом: @rambler.ru", "resx/img/cat5.png");
            Hide();
            lvlScreen.ShowDialog();
            Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            EasterEgg easterEgg = new EasterEgg("resx/img/1.gif");
            easterEgg.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            EasterEgg easterEgg = new EasterEgg("resx/img/2.gif");
            easterEgg.ShowDialog();
        }
    }
}


