
namespace Swaper
{
    partial class AddGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddGame));
            this.GameNameLabel = new System.Windows.Forms.Label();
            this.GameNameTextBox = new System.Windows.Forms.TextBox();
            this.saveFolderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.ChoseSaveFolder = new System.Windows.Forms.Button();
            this.Done = new System.Windows.Forms.Button();
            this.NotSelectedText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GameNameLabel
            // 
            this.GameNameLabel.AutoSize = true;
            this.GameNameLabel.Location = new System.Drawing.Point(12, 14);
            this.GameNameLabel.Name = "GameNameLabel";
            this.GameNameLabel.Size = new System.Drawing.Size(71, 15);
            this.GameNameLabel.TabIndex = 0;
            this.GameNameLabel.Text = "Game name";
            // 
            // GameNameTextBox
            // 
            this.GameNameTextBox.Location = new System.Drawing.Point(133, 11);
            this.GameNameTextBox.Name = "GameNameTextBox";
            this.GameNameTextBox.Size = new System.Drawing.Size(148, 23);
            this.GameNameTextBox.TabIndex = 1;
            // 
            // ChoseSaveFolder
            // 
            this.ChoseSaveFolder.Location = new System.Drawing.Point(12, 38);
            this.ChoseSaveFolder.Name = "ChoseSaveFolder";
            this.ChoseSaveFolder.Size = new System.Drawing.Size(109, 23);
            this.ChoseSaveFolder.TabIndex = 2;
            this.ChoseSaveFolder.Text = "Chose save folder";
            this.ChoseSaveFolder.UseVisualStyleBackColor = true;
            this.ChoseSaveFolder.Click += new System.EventHandler(this.ChoseSaveFolder_Click);
            // 
            // Done
            // 
            this.Done.Location = new System.Drawing.Point(12, 67);
            this.Done.Name = "Done";
            this.Done.Size = new System.Drawing.Size(75, 23);
            this.Done.TabIndex = 3;
            this.Done.Text = "Done";
            this.Done.UseVisualStyleBackColor = true;
            this.Done.Click += new System.EventHandler(this.Done_Click);
            // 
            // NotSelectedText
            // 
            this.NotSelectedText.AutoSize = true;
            this.NotSelectedText.Location = new System.Drawing.Point(133, 42);
            this.NotSelectedText.Name = "NotSelectedText";
            this.NotSelectedText.Size = new System.Drawing.Size(136, 15);
            this.NotSelectedText.TabIndex = 4;
            this.NotSelectedText.Text = "Save folder isn\'t selected";
            // 
            // AddGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 102);
            this.Controls.Add(this.NotSelectedText);
            this.Controls.Add(this.Done);
            this.Controls.Add(this.ChoseSaveFolder);
            this.Controls.Add(this.GameNameTextBox);
            this.Controls.Add(this.GameNameLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddGame";
            this.Text = "AddGame";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label GameNameLabel;
        private System.Windows.Forms.TextBox GameNameTextBox;
        private System.Windows.Forms.FolderBrowserDialog saveFolderDialog;
        private System.Windows.Forms.Button ChoseSaveFolder;
        private System.Windows.Forms.Button Done;
        private System.Windows.Forms.Label NotSelectedText;
    }
}