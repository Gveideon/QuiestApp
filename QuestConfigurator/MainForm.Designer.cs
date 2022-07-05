namespace QuestConfigurator
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.fieldPhrase = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonOpenFile = new System.Windows.Forms.Button();
            this.buttonSaveFile = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.fieldName = new System.Windows.Forms.TextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.fieldNumberPicture = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.fieldIsEnd = new System.Windows.Forms.CheckBox();
            this.buttonAddVariant = new System.Windows.Forms.Button();
            this.buttonOpenVariant = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.buttonSaveChange = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.listSteps = new System.Windows.Forms.ListBox();
            this.fieldVariants = new System.Windows.Forms.ComboBox();
            this.fieldAction = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.fieldNumberPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // fieldPhrase
            // 
            this.fieldPhrase.Location = new System.Drawing.Point(104, 111);
            this.fieldPhrase.Margin = new System.Windows.Forms.Padding(4);
            this.fieldPhrase.Multiline = true;
            this.fieldPhrase.Name = "fieldPhrase";
            this.fieldPhrase.Size = new System.Drawing.Size(432, 189);
            this.fieldPhrase.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 111);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Phrase";
            // 
            // buttonOpenFile
            // 
            this.buttonOpenFile.Location = new System.Drawing.Point(12, 12);
            this.buttonOpenFile.Name = "buttonOpenFile";
            this.buttonOpenFile.Size = new System.Drawing.Size(132, 39);
            this.buttonOpenFile.TabIndex = 2;
            this.buttonOpenFile.Text = "Open File";
            this.buttonOpenFile.UseVisualStyleBackColor = true;
            this.buttonOpenFile.Click += new System.EventHandler(this.buttonOpenFile_Click);
            // 
            // buttonSaveFile
            // 
            this.buttonSaveFile.Location = new System.Drawing.Point(150, 12);
            this.buttonSaveFile.Name = "buttonSaveFile";
            this.buttonSaveFile.Size = new System.Drawing.Size(132, 39);
            this.buttonSaveFile.TabIndex = 3;
            this.buttonSaveFile.Text = "Save File";
            this.buttonSaveFile.UseVisualStyleBackColor = true;
            this.buttonSaveFile.Click += new System.EventHandler(this.buttonSaveFile_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 72);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 28);
            this.label2.TabIndex = 5;
            this.label2.Text = "Name";
            // 
            // fieldName
            // 
            this.fieldName.Location = new System.Drawing.Point(104, 69);
            this.fieldName.Margin = new System.Windows.Forms.Padding(4);
            this.fieldName.Name = "fieldName";
            this.fieldName.Size = new System.Drawing.Size(432, 34);
            this.fieldName.TabIndex = 4;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "text.json";
            this.openFileDialog.Filter = "\"Json files(*.json)|*.json|All files(*.*)|*.*\"";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.FileName = "text.json";
            this.saveFileDialog.Filter = "\"Json files(*.json)|*.json|All files(*.*)|*.*\"";
            // 
            // fieldNumberPicture
            // 
            this.fieldNumberPicture.Location = new System.Drawing.Point(104, 307);
            this.fieldNumberPicture.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.fieldNumberPicture.Name = "fieldNumberPicture";
            this.fieldNumberPicture.Size = new System.Drawing.Size(432, 34);
            this.fieldNumberPicture.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 309);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 28);
            this.label3.TabIndex = 7;
            this.label3.Text = "Num pic";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 360);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 28);
            this.label4.TabIndex = 9;
            this.label4.Text = "Action";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 398);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 28);
            this.label5.TabIndex = 11;
            this.label5.Text = "Variants";
            // 
            // fieldIsEnd
            // 
            this.fieldIsEnd.AutoSize = true;
            this.fieldIsEnd.Location = new System.Drawing.Point(108, 432);
            this.fieldIsEnd.Name = "fieldIsEnd";
            this.fieldIsEnd.Size = new System.Drawing.Size(85, 32);
            this.fieldIsEnd.TabIndex = 12;
            this.fieldIsEnd.Text = "is end";
            this.fieldIsEnd.UseVisualStyleBackColor = true;
            // 
            // buttonAddVariant
            // 
            this.buttonAddVariant.Location = new System.Drawing.Point(542, 391);
            this.buttonAddVariant.Name = "buttonAddVariant";
            this.buttonAddVariant.Size = new System.Drawing.Size(142, 43);
            this.buttonAddVariant.TabIndex = 13;
            this.buttonAddVariant.Text = "Add varianrt";
            this.buttonAddVariant.UseVisualStyleBackColor = true;
            this.buttonAddVariant.Click += new System.EventHandler(this.buttonAddVariant_Click);
            // 
            // buttonOpenVariant
            // 
            this.buttonOpenVariant.Location = new System.Drawing.Point(690, 391);
            this.buttonOpenVariant.Name = "buttonOpenVariant";
            this.buttonOpenVariant.Size = new System.Drawing.Size(142, 43);
            this.buttonOpenVariant.TabIndex = 14;
            this.buttonOpenVariant.Text = "Open variant";
            this.buttonOpenVariant.UseVisualStyleBackColor = true;
            this.buttonOpenVariant.Click += new System.EventHandler(this.buttonOpenVariant_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(462, 17);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 28);
            this.label6.TabIndex = 17;
            this.label6.Text = "Steps";
            // 
            // buttonSaveChange
            // 
            this.buttonSaveChange.Location = new System.Drawing.Point(288, 12);
            this.buttonSaveChange.Name = "buttonSaveChange";
            this.buttonSaveChange.Size = new System.Drawing.Size(143, 39);
            this.buttonSaveChange.TabIndex = 18;
            this.buttonSaveChange.Text = "Save Change";
            this.buttonSaveChange.UseVisualStyleBackColor = true;
            this.buttonSaveChange.Click += new System.EventHandler(this.buttonSaveChange_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(838, 391);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(165, 43);
            this.buttonRemove.TabIndex = 20;
            this.buttonRemove.Text = "Remove variant";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // listSteps
            // 
            this.listSteps.FormattingEnabled = true;
            this.listSteps.ItemHeight = 28;
            this.listSteps.Location = new System.Drawing.Point(563, 12);
            this.listSteps.Name = "listSteps";
            this.listSteps.Size = new System.Drawing.Size(566, 144);
            this.listSteps.TabIndex = 21;
            this.listSteps.SelectedIndexChanged += new System.EventHandler(this.listSteps_SelectedIndexChanged);
            // 
            // fieldVariants
            // 
            this.fieldVariants.FormattingEnabled = true;
            this.fieldVariants.Location = new System.Drawing.Point(101, 398);
            this.fieldVariants.Name = "fieldVariants";
            this.fieldVariants.Size = new System.Drawing.Size(435, 36);
            this.fieldVariants.TabIndex = 23;
            // 
            // fieldAction
            // 
            this.fieldAction.FormattingEnabled = true;
            this.fieldAction.Items.AddRange(new object[] {
            "Agressive",
            "Friendly",
            "Ignore",
            "Empty"});
            this.fieldAction.Location = new System.Drawing.Point(101, 357);
            this.fieldAction.Name = "fieldAction";
            this.fieldAction.Size = new System.Drawing.Size(435, 36);
            this.fieldAction.TabIndex = 24;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 469);
            this.Controls.Add(this.fieldAction);
            this.Controls.Add(this.fieldVariants);
            this.Controls.Add(this.listSteps);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonSaveChange);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonOpenVariant);
            this.Controls.Add(this.buttonAddVariant);
            this.Controls.Add(this.fieldIsEnd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fieldNumberPicture);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fieldName);
            this.Controls.Add(this.buttonSaveFile);
            this.Controls.Add(this.buttonOpenFile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fieldPhrase);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Configurator";
            ((System.ComponentModel.ISupportInitialize)(this.fieldNumberPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox fieldPhrase;
        private Label label1;
        private Button buttonOpenFile;
        private Button buttonSaveFile;
        private Label label2;
        private TextBox fieldName;
        private OpenFileDialog openFileDialog;
        private SaveFileDialog saveFileDialog;
        private NumericUpDown fieldNumberPicture;
        private Label label3;
        private Label label4;
        private Label label5;
        private CheckBox fieldIsEnd;
        private Button buttonAddVariant;
        private Button buttonOpenVariant;
        private Label label6;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button buttonSaveChange;
        private Button buttonRemove;
        private ListBox listSteps;
        private ComboBox fieldVariants;
        private ComboBox fieldAction;
    }
}