using QuestEngine;
using System.ComponentModel;

namespace QuestConfigurator
{
    public partial class MainForm : Form
    {
        private Step currentStep;
        private List<Step> steps;
        private BindingList<Step> stepsData;
        private string path = "text.json";
        private int currentIndex = 0;
        private Dictionary<string, int> actionsToIndex = new Dictionary<string, int> {
            ["Agressive"] = 1,
            ["Friendly"] = 2,
            ["Ignore"] = 3,
            ["Empty"] = 0 };
        private Dictionary<int,string > indexToActions = new Dictionary<int,string >
        {
            [1] = "Agressive",
            [2] ="Friendly" ,
            [3] = "Ignore",
            [0] ="Empty" 
        };
        public MainForm()
        {
            InitializeComponent();
            currentStep = new Step();
            steps = new List<Step>();
            steps.Add(currentStep);
            stepsData = new BindingList<Step>();
            stepsData.Add(currentStep);
            listSteps.DataSource = stepsData;
            ShowData();
        }
        private void SaveData() 
        {
            if (currentStep == null) currentStep = new Step();
            currentStep.Name = fieldName.Text;
            currentStep.NumberPicture = (int)fieldNumberPicture.Value;
            currentStep.Phrase = fieldPhrase.Text;
            currentStep.IsEndStep = fieldIsEnd.Checked;
            if (fieldAction.Text == TypeAction.Agressive.ToString())
                currentStep.Action = TypeAction.Agressive;
            if (fieldAction.Text == TypeAction.Ignore.ToString())
                currentStep.Action = TypeAction.Ignore;
            if (fieldAction.Text == TypeAction.Friendly.ToString())
                currentStep.Action = TypeAction.Friendly;
            if (fieldAction.Text == TypeAction.Empty.ToString())
                currentStep.Action = TypeAction.Empty;
            if (currentStep.VariantTransition == null) currentStep.VariantTransition = new List<Step>();
            foreach (var item in fieldVariants.Items)
            {
                bool isNew = true;
                foreach (var variant in currentStep.VariantTransition)
                {
                    if (item.ToString() == variant.Name)
                        isNew = false;
                }
                if (isNew) 
                {
                    var variant = new Step();
                    variant.Name = item.ToString();
                    currentStep.VariantTransition.Add(variant);
                    steps.Add(variant);
                }
            }
            stepsData.Clear();
            foreach (var item in steps)
                stepsData.Add(item);
            listSteps.DataSource = stepsData;
            MessageBox.Show(" changes saved");
        }
        private void ShowData()
        {
            if (currentStep == null) currentStep = new Step();
            fieldName.Text = currentStep.Name;
            fieldNumberPicture.Value = currentStep.NumberPicture;
            fieldPhrase.Text = currentStep.Phrase;
            fieldIsEnd.Checked = currentStep.IsEndStep;
            var strin = currentStep.Action.ToString();
            fieldAction.SelectedIndex = actionsToIndex[currentStep.Action.ToString()];
            fieldVariants.Items.Clear();
            fieldVariants.Text = "";
            if (currentStep.VariantTransition != null)
            {
                foreach (var item in currentStep.VariantTransition)
                {
                    fieldVariants.Items.Add(item);
                }
            }

        }
        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            path = openFileDialog.FileName;
            currentStep = FileProvider<Step>.ReadObject(path);
            steps = new List<Step>();
            steps.Add(currentStep);
            stepsData = new BindingList<Step>();
            stepsData.Add(currentStep);
            listSteps.DataSource = stepsData;
            ShowData();
            MessageBox.Show("Файл открыт");
        }
        
        private void buttonSaveFile_Click(object sender, EventArgs e)
        {
            SaveData();
            if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            path = saveFileDialog.FileName;
            _ = FileProvider<Step>.WriteObject(currentStep, path);
            MessageBox.Show("Файл сохранен");
        }

        private void buttonSaveChange_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        private void buttonAddVariant_Click(object sender, EventArgs e)
        {
            var currentName = fieldVariants.Text;
            var isNew = true;
            foreach (var variant in currentStep.VariantTransition)
            {
                if (currentName == variant.Name)
                    isNew = false;
            }
            if (isNew)
            {
                var variant = new Step();
                variant.Name = currentName;
                currentStep.VariantTransition.Add(variant);
                stepsData.Add(variant);
                steps.Add(variant);
            }
            SaveData();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            SaveData();
            if (currentStep.VariantTransition == null) return;
            var target = fieldVariants.Text;
            Step? checkStep;
            checkStep = currentStep.VariantTransition.Where(variant => variant.Name == target).FirstOrDefault();
            if (checkStep == null) return;
            Step? targetStep;
            targetStep = steps.Where(variant => variant.Name == target).FirstOrDefault();
            if (targetStep == null) return;
            steps.Remove(targetStep);
            currentStep.VariantTransition.Remove(checkStep);
            fieldVariants.Items.Clear();
            fieldVariants.Text = "";
            SaveData();
            ShowData();

            //if (fieldVariants.SelectedIndex != -1 && currentStep.VariantTransition[fieldVariants.SelectedIndex].Name == fieldVariants.Text)
            //{
            //    currentStep.VariantTransition.RemoveAt(fieldVariants.SelectedIndex); 
            //    ShowData();
            //}

        }

        private void buttonOpenVariant_Click(object sender, EventArgs e)
        {
            if (fieldVariants.SelectedIndex != -1)
            {
                currentStep = currentStep.VariantTransition[fieldVariants.SelectedIndex];
                ShowData();
            }
            
        }

        private void listSteps_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (listSteps.SelectedIndex != -1 && steps[listSteps.SelectedIndex] != currentStep)
            {
                currentStep = steps[listSteps.SelectedIndex];
                ShowData();
            }
            
        }

        private void fieldVariants_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (fieldVariants.SelectedIndex != -1)
            {
                currentStep = currentStep.VariantTransition[fieldVariants.SelectedIndex];
                ShowData();
            }
        }
    }
}