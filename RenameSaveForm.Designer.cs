namespace Swaper
{
    partial class RenameSaveForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.oldSaveNameLabel = new System.Windows.Forms.Label();
            this.newNameTextBox = new System.Windows.Forms.TextBox();
            this.renameButton = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Old name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "New name:";
            // 
            // oldSaveNameLabel
            // 
            this.oldSaveNameLabel.AutoSize = true;
            this.oldSaveNameLabel.Location = new System.Drawing.Point(114, 9);
            this.oldSaveNameLabel.Name = "oldSaveNameLabel";
            this.oldSaveNameLabel.Size = new System.Drawing.Size(41, 20);
            this.oldSaveNameLabel.TabIndex = 2;
            this.oldSaveNameLabel.Text = "TEST";
            // 
            // newNameTextBox
            // 
            this.newNameTextBox.Location = new System.Drawing.Point(114, 41);
            this.newNameTextBox.Name = "newNameTextBox";
            this.newNameTextBox.Size = new System.Drawing.Size(189, 27);
            this.newNameTextBox.TabIndex = 3;
            // 
            // renameButton
            // 
            this.renameButton.Location = new System.Drawing.Point(12, 109);
            this.renameButton.Name = "renameButton";
            this.renameButton.Size = new System.Drawing.Size(94, 29);
            this.renameButton.TabIndex = 4;
            this.renameButton.Text = "Rename";
            this.renameButton.UseVisualStyleBackColor = true;
            this.renameButton.Click += new System.EventHandler(this.renameButton_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(209, 109);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(94, 29);
            this.cancel.TabIndex = 5;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // RenameSaveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 150);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.renameButton);
            this.Controls.Add(this.newNameTextBox);
            this.Controls.Add(this.oldSaveNameLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RenameSaveForm";
            this.Text = "RenameSaveForm";
            this.Load += new System.EventHandler(this.RenameSaveForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label oldSaveNameLabel;
        private System.Windows.Forms.TextBox newNameTextBox;
        private System.Windows.Forms.Button renameButton;
        private System.Windows.Forms.Button cancel;
    }
}