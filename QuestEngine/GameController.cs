using System.Text.Json;
using System.IO;
namespace QuestEngine
{
    public class GameController
    {
        public string CurrentPhrase { get; private set; }
        public string CurrentNumberbacground { get; private set; }
        public bool IsEnd { get; private set; }
        public GameController() { }
        public void Init() { }
        public void Reset() { }
        public void MakeAggressiveAction() { }
        public void MakeFriendlyAction() { }
        public void MakeIgnoreAction() { }

    }

}