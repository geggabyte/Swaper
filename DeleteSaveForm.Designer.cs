
namespace Swaper
{
    partial class DeleteSaveForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteSaveForm));
            this.YesButton = new System.Windows.Forms.Button();
            this.NoButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SaveName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // YesButton
            // 
            this.YesButton.Location = new System.Drawing.Point(31, 73);
            this.YesButton.Name = "YesButton";
            this.YesButton.Size = new System.Drawing.Size(75, 23);
            this.YesButton.TabIndex = 0;
            this.YesButton.Text = "Yes";
            this.YesButton.UseVisualStyleBackColor = true;
            this.YesButton.Click += new System.EventHandler(this.YesButton_Click);
            // 
            // NoButton
            // 
            this.NoButton.Location = new System.Drawing.Point(198, 73);
            this.NoButton.Name = "NoButton";
            this.NoButton.Size = new System.Drawing.Size(75, 23);
            this.NoButton.TabIndex = 1;
            this.NoButton.Text = "No";
            this.NoButton.UseVisualStyleBackColor = true;
            this.NoButton.Click += new System.EventHandler(this.NoButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Are you shure you want to remove this save?";
            // 
            // SaveName
            // 
            this.SaveName.AutoSize = true;
            this.SaveName.Location = new System.Drawing.Point(31, 35);
            this.SaveName.Name = "SaveName";
            this.SaveName.Size = new System.Drawing.Size(0, 15);
            this.SaveName.TabIndex = 3;
            // 
            // DeleteSaveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 122);
            this.Controls.Add(this.SaveName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NoButton);
            this.Controls.Add(this.YesButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DeleteSaveForm";
            this.Text = "DeleteSaveForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button YesButton;
        private System.Windows.Forms.Button NoButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label SaveName;
    }
}