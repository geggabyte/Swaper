
namespace Swaper
{
    partial class CreateEmptyForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateEmptyForm));
            this.DoneButton = new System.Windows.Forms.Button();
            this.ChoseNameText = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // DoneButton
            // 
            this.DoneButton.Location = new System.Drawing.Point(121, 53);
            this.DoneButton.Name = "DoneButton";
            this.DoneButton.Size = new System.Drawing.Size(65, 23);
            this.DoneButton.TabIndex = 0;
            this.DoneButton.Text = "Done";
            this.DoneButton.UseVisualStyleBackColor = true;
            this.DoneButton.Click += new System.EventHandler(this.DoneButton_Click);
            // 
            // ChoseNameText
            // 
            this.ChoseNameText.AutoSize = true;
            this.ChoseNameText.Location = new System.Drawing.Point(12, 13);
            this.ChoseNameText.Name = "ChoseNameText";
            this.ChoseNameText.Size = new System.Drawing.Size(42, 15);
            this.ChoseNameText.TabIndex = 1;
            this.ChoseNameText.Text = "Name:";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(86, 10);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(100, 23);
            this.nameBox.TabIndex = 2;
            // 
            // CreateEmptyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(202, 91);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.ChoseNameText);
            this.Controls.Add(this.DoneButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CreateEmptyForm";
            this.Text = "CreateEmptyForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DoneButton;
        private System.Windows.Forms.Label ChoseNameText;
        private System.Windows.Forms.TextBox nameBox;
    }
}