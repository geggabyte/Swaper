﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Swaper
{
    public partial class RenameSaveForm : Form
    {
        Swaper swaper;
        public RenameSaveForm(Swaper swaper, string oldSaveName)
        {
            this.swaper = swaper;
            InitializeComponent();
            oldSaveNameLabel.Text = oldSaveName;
        }

        private void RenameSaveForm_Load(object sender, EventArgs e)
        {

        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void renameButton_Click(object sender, EventArgs e)
        {
            swaper.renameSave(newNameTextBox.Text);
            this.Close();
        }
    }
}
