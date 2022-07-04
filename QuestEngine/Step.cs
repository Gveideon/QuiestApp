using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestEngine
{
    public class Step
    {
        public string Name { get; private set; } = "step";
        public string Phrase { get; private set; } = "base phrase";
        public List<Step> VariantTransition { get; private set; } = new List<Step>();
        public int NumberPicture { get; private set; } = 0;
        public TypeAction Action { get; private set; }

        public bool IsEndStep = false;  
    }
}
