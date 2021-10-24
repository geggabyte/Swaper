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
    public partial class AddGame : Form
    {
        Swaper sw;

        public AddGame(Swaper a)
        {
            InitializeComponent();
            sw = a;
        }

        private void ChoseSaveFolder_Click(object sender, EventArgs e)
        {
            saveFolderDialog.ShowDialog();
        }

        private void Done_Click(object sender, EventArgs e)
        {
            sw.AddNewGame(GameNameTextBox.Text, saveFolderDialog.SelectedPath);
            this.Close();
        }
    }
}
