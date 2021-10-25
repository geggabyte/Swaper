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
        Swaper swaper;

        public AddGame(Swaper a)
        {
            InitializeComponent();
            swaper = a;
        }

        private void ChoseSaveFolder_Click(object sender, EventArgs e)
        {
            saveFolderDialog.ShowDialog();
            NotSelectedText.Text = "";
        }

        private void Done_Click(object sender, EventArgs e)
        {
            swaper.AddNewGame(GameNameTextBox.Text, saveFolderDialog.SelectedPath, GetSaveFolderName(saveFolderDialog.SelectedPath));
            this.Close();
        }

        private string GetSaveFolderName(string path)
        {
            string result = "";
            foreach(char a in path)
            {
                if (a == '\\')
                {
                    result = "";
                    continue;
                }
                result += a;
            }
                
            return result;
        }
    }
}
