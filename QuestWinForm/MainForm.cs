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
            timer.Start();
            
        }

        private void buttonAgressiveAction_Click(object sender, EventArgs e)
        {
            _gameController.MakeAggressiveAction();
            UpdateBackground();
        }

        private void buttonFriendlyAction_Click(object sender, EventArgs e)
        {
            _gameController.MakeFriendlyAction();
            UpdateBackground();
        }

        private void buttonIgnoreAction_Click(object sender, EventArgs e)
        {
            _gameController.MakeIgnoreAction();
            UpdateBackground();
        }

        private void UpdateBackground()
        {
            var number = _gameController.CurrentNumberBackground;
            BackgroundImage = ChangeImage(number);
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
    }
}