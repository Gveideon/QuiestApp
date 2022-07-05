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
            //tried
            Step? temp = currentStep.VariantTransition.Where(x => x.Action == TypeAction.Agressive).FirstOrDefault();
            currentStep = temp != null ? temp : currentStep;
            Update();
            if (currentStep == temp) return true;
            else return false;
        }


        public void MakeFriendlyAction() 
        {
            Step? temp = currentStep.VariantTransition.Where(x => x.Action == TypeAction.Friendly).FirstOrDefault();
            currentStep = temp !=null ? temp: currentStep;
            Update();
            if (currentStep == temp) return true;
            else return false;
        }


        public void MakeIgnoreAction() 
        {
            Step? temp = currentStep.VariantTransition.Where(x => x.Action == TypeAction.Ignore).FirstOrDefault();
            currentStep = temp != null ? temp : currentStep;
            Update();
            if (currentStep == temp) return true;
            else return false;
        }
        private void LoadQuest() 
        {
            currentStep = FileProvider<Step>.ReadObject(path);
            if (currentStep == null)
            {
                return;
            }
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