using QuestEngine;

namespace QuestWinForm
{
    public partial class MainForm : Form
    {
        private GameController _gameController;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            _gameController = new GameController();
            fieldForPhrase.BackColor = Color.FromArgb(214, 243, 101);
            label1.Parent = fieldBackground;
            label1.BackColor = Color.Transparent;
            //fieldForPhrase.Text = _gameController.CurrentPhrase;
            UpdateBackground();
            //timer.Start();

        }

        private void buttonAgressiveAction_Click(object sender, EventArgs e)
        {
            var flag = _gameController.MakeAggressiveAction();
            UpdateBackground();
            if(!flag)
            {
                fieldForPhrase.Text = "ты не можешь так поступить";
            }
            if (_gameController.IsEnd)
                fieldForPhrase.Text = "конец игры попробуй еще !)";
        }

        private void buttonFriendlyAction_Click(object sender, EventArgs e)
        {
            var flag = _gameController.MakeFriendlyAction();
            UpdateBackground();
            if (!flag)
            {
                fieldForPhrase.Text = "ты не можешь так поступить";
            }
            if (_gameController.IsEnd)
                fieldForPhrase.Text = "конец игры попробуй еще !)";
        }

        private void buttonIgnoreAction_Click(object sender, EventArgs e)
        {
            var flag = _gameController.MakeIgnoreAction();
            UpdateBackground();
            if (!flag)
            {
                fieldForPhrase.Text = "ты не можешь так поступить";
            }
            if (_gameController.IsEnd)
                fieldForPhrase.Text = "конец игры попробуй еще !)";
        }

        private void UpdateBackground()
        {
            var number = _gameController.CurrentNumberBackground;
            //BackgroundImage = ChangeImage(number);
            fieldBackground.Image = ChangeImage(number);
            fieldForPhrase.Text = _gameController.CurrentPhrase;
        }

        private Bitmap? ChangeImage(int number)
        {
            string name = $"Image_{number}";
            var resource = ResourceQuest.ResourceManager.GetObject(name);
            if (resource == null) return null;
            return resource as Bitmap;
        }

        private void Waiting()
        {

        }

        private void timer_Tick(object sender, EventArgs e)
        {

        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            _gameController.Reset();
            UpdateBackground();
        }
    }
}