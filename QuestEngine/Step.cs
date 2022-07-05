using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestEngine
{
    public class Step
    {
        public string Name { get; set; } = "step";
        public string Phrase { get;  set; } = "base phrase";
        public List<Step> VariantTransition { get; set; } = new List<Step>();
        public int NumberPicture { get; set; } = 1;
        public TypeAction Action { get; set; } = TypeAction.Empty;

        public bool IsEndStep { get; set; } = false;
        public override string ToString()
        {
            return Name.ToString();
        }
    }
}
