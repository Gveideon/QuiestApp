namespace QuestWinForm
{
    using QuestEngine;

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
        }

        private void buttonAgressiveAction_Click(object sender, EventArgs e)
        {
            _gameController.MakeAggressiveAction();
        }

        private void buttonFriendlyAction_Click(object sender, EventArgs e)
        {
            _gameController.MakeFriendlyAction();
        }

        private void buttonIgnoreAction_Click(object sender, EventArgs e)
        {
            _gameController.MakeIgnoreAction();
        }

        private void UpdateBackground()
        {
            //BackgroundImage
        }
    }
}