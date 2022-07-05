﻿namespace QuestWinForm
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
            this.components = new System.ComponentModel.Container();
            this.buttonAgressiveAction = new System.Windows.Forms.Button();
            this.buttonFriendlyAction = new System.Windows.Forms.Button();
            this.buttonIgnoreAction = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.fieldBackground = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.fieldForPhrase = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.fieldBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAgressiveAction
            // 
            this.buttonAgressiveAction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAgressiveAction.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAgressiveAction.Location = new System.Drawing.Point(12, 544);
            this.buttonAgressiveAction.Name = "buttonAgressiveAction";
            this.buttonAgressiveAction.Size = new System.Drawing.Size(170, 47);
            this.buttonAgressiveAction.TabIndex = 0;
            this.buttonAgressiveAction.Text = "Агрессивно";
            this.buttonAgressiveAction.UseVisualStyleBackColor = true;
            this.buttonAgressiveAction.Click += new System.EventHandler(this.buttonAgressiveAction_Click);
            // 
            // buttonFriendlyAction
            // 
            this.buttonFriendlyAction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFriendlyAction.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonFriendlyAction.Location = new System.Drawing.Point(451, 544);
            this.buttonFriendlyAction.Name = "buttonFriendlyAction";
            this.buttonFriendlyAction.Size = new System.Drawing.Size(170, 47);
            this.buttonFriendlyAction.TabIndex = 1;
            this.buttonFriendlyAction.Text = "Дружелюбно";
            this.buttonFriendlyAction.UseVisualStyleBackColor = true;
            this.buttonFriendlyAction.Click += new System.EventHandler(this.buttonFriendlyAction_Click);
            // 
            // buttonIgnoreAction
            // 
            this.buttonIgnoreAction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonIgnoreAction.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonIgnoreAction.Location = new System.Drawing.Point(875, 544);
            this.buttonIgnoreAction.Name = "buttonIgnoreAction";
            this.buttonIgnoreAction.Size = new System.Drawing.Size(170, 47);
            this.buttonIgnoreAction.TabIndex = 2;
            this.buttonIgnoreAction.Text = "Игнорировать";
            this.buttonIgnoreAction.UseVisualStyleBackColor = true;
            this.buttonIgnoreAction.Click += new System.EventHandler(this.buttonIgnoreAction_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(451, 499);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Как вы поступите?";
            // 
            // fieldBackground
            // 
            this.fieldBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fieldBackground.Location = new System.Drawing.Point(0, 0);
            this.fieldBackground.Name = "fieldBackground";
            this.fieldBackground.Size = new System.Drawing.Size(1057, 603);
            this.fieldBackground.TabIndex = 5;
            this.fieldBackground.TabStop = false;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // fieldForPhrase
            // 
            this.fieldForPhrase.Location = new System.Drawing.Point(12, 345);
            this.fieldForPhrase.Name = "fieldForPhrase";
            this.fieldForPhrase.Size = new System.Drawing.Size(1033, 141);
            this.fieldForPhrase.TabIndex = 3;
            this.fieldForPhrase.Text = "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1057, 603);
            this.Controls.Add(this.buttonAgressiveAction);
            this.Controls.Add(this.buttonIgnoreAction);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonFriendlyAction);
            this.Controls.Add(this.fieldForPhrase);
            this.Controls.Add(this.fieldBackground);
            this.Name = "MainForm";
            this.Text = "Прогулка по знакомым равнинам";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fieldBackground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonAgressiveAction;
        private Button buttonFriendlyAction;
        private Button buttonIgnoreAction;
        private Label label1;
        private PictureBox fieldBackground;
        private System.Windows.Forms.Timer timer;
        private RichTextBox fieldForPhrase;
    }
}