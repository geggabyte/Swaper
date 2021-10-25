
namespace Swaper
{
    partial class Swaper
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Swaper));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createEmptyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.copyCurrentToSelectedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GameListBox = new System.Windows.Forms.ListBox();
            this.SaveListBox = new System.Windows.Forms.ListBox();
            this.selectButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(356, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.removeToolStripMenuItem});
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.gameToolStripMenuItem.Text = "Game";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.removeToolStripMenuItem.Text = "Remove";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createEmptyToolStripMenuItem1,
            this.removeToolStripMenuItem1,
            this.copyCurrentToSelectedToolStripMenuItem});
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // createEmptyToolStripMenuItem1
            // 
            this.createEmptyToolStripMenuItem1.Name = "createEmptyToolStripMenuItem1";
            this.createEmptyToolStripMenuItem1.Size = new System.Drawing.Size(203, 22);
            this.createEmptyToolStripMenuItem1.Text = "Create empty";
            this.createEmptyToolStripMenuItem1.Click += new System.EventHandler(this.createEmptyToolStripMenuItem1_Click);
            // 
            // removeToolStripMenuItem1
            // 
            this.removeToolStripMenuItem1.Name = "removeToolStripMenuItem1";
            this.removeToolStripMenuItem1.Size = new System.Drawing.Size(203, 22);
            this.removeToolStripMenuItem1.Text = "Remove";
            this.removeToolStripMenuItem1.Click += new System.EventHandler(this.removeToolStripMenuItem1_Click);
            // 
            // copyCurrentToSelectedToolStripMenuItem
            // 
            this.copyCurrentToSelectedToolStripMenuItem.Name = "copyCurrentToSelectedToolStripMenuItem";
            this.copyCurrentToSelectedToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.copyCurrentToSelectedToolStripMenuItem.Text = "Copy current to selected";
            this.copyCurrentToSelectedToolStripMenuItem.Click += new System.EventHandler(this.copyCurrentToSelectedToolStripMenuItem_Click);
            // 
            // GameListBox
            // 
            this.GameListBox.FormattingEnabled = true;
            this.GameListBox.ItemHeight = 15;
            this.GameListBox.Location = new System.Drawing.Point(12, 27);
            this.GameListBox.Name = "GameListBox";
            this.GameListBox.Size = new System.Drawing.Size(120, 184);
            this.GameListBox.TabIndex = 1;
            this.GameListBox.SelectedIndexChanged += new System.EventHandler(this.GameListBox_SelectedIndexChanged);
            // 
            // SaveListBox
            // 
            this.SaveListBox.FormattingEnabled = true;
            this.SaveListBox.ItemHeight = 15;
            this.SaveListBox.Location = new System.Drawing.Point(220, 27);
            this.SaveListBox.Name = "SaveListBox";
            this.SaveListBox.Size = new System.Drawing.Size(120, 184);
            this.SaveListBox.TabIndex = 2;
            // 
            // selectButton
            // 
            this.selectButton.Location = new System.Drawing.Point(138, 92);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(75, 23);
            this.selectButton.TabIndex = 3;
            this.selectButton.Text = "Select";
            this.selectButton.UseVisualStyleBackColor = true;
            this.selectButton.Click += new System.EventHandler(this.selectButton_Click);
            // 
            // Swaper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 223);
            this.Controls.Add(this.selectButton);
            this.Controls.Add(this.SaveListBox);
            this.Controls.Add(this.GameListBox);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Swaper";
            this.Text = "Swaper";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Swaper_FormClosing);
            this.Load += new System.EventHandler(this.Swaper_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.ListBox GameListBox;
        private System.Windows.Forms.ListBox SaveListBox;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createEmptyToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem copyCurrentToSelectedToolStripMenuItem;
        private System.Windows.Forms.Button selectButton;
    }
}

