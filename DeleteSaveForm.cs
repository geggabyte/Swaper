using System;
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
    public partial class DeleteSaveForm : Form
    {
        Swaper swaper;

        public DeleteSaveForm(Swaper a, string saveName)
        {
            InitializeComponent();
            swaper = a;
            SaveName.Text = saveName;
        }

        private void YesButton_Click(object sender, EventArgs e)
        {
            swaper.removeSave();
            this.Close();
        }

        private void NoButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
