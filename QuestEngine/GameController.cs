using System.Text.Json;
using System.IO;

namespace QuestEngine
{
    public class GameController
    {
        public string CurrentPhrase { get; private set; }

        public int CurrentNumberBackground { get; private set; }

        public bool IsEnd { get; private set; }

        private string path = "text.json";

        private Step currentStep;

        public GameController() 
        {
            LoadQuest();
        }

        public void Init() { }

        public void Reset() 
        {
            LoadQuest();
        }

        public void MakeAggressiveAction()
        {
            currentStep = currentStep.VariantTransition.Where(x => x.Action == TypeAction.Agressive).First();
            Update();
        }

        public void MakeFriendlyAction() 
        {
            currentStep = currentStep.VariantTransition.Where(x => x.Action == TypeAction.Friendly).First();
            Update();
        }

        public void MakeIgnoreAction() 
        {
            currentStep = currentStep.VariantTransition.Where(x => x.Action == TypeAction.Ignore).First();
            Update();
        }
        private void LoadQuest() 
        {
            currentStep = FileProvider<Step>.ReadObject(path); 
            Update();

        }

        private void Update() 
        {
            if (currentStep != null)
            {
                CurrentPhrase = currentStep.Phrase;
                CurrentNumberBackground = currentStep.NumberPicture;
                IsEnd = currentStep.IsEndStep;
            }
        }
    }

}