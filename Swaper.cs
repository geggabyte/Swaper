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
    public partial class Swaper : Form
    {
        private FileSystem _FileSystem;

        public Swaper()
        {
            InitializeComponent();
            _FileSystem = new FileSystem();
            foreach(string a in _FileSystem.GamesList)
            {
                GameListBox.Items.Add(a);
            }
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddGame addGame = new AddGame(this);
            addGame.Show();
        }

        public void AddNewGame(string gameName, string saveFolder)
        {
            GameListBox.Items.Add(gameName);
            _FileSystem.AddGame(gameName, saveFolder);
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _FileSystem.Remove(GameListBox.SelectedItem.ToString());
            GameListBox.Items.RemoveAt(GameListBox.SelectedIndex);
        }

        private void Swaper_FormClosing(object sender, FormClosingEventArgs e)
        {
            _FileSystem.Save();
        }

        private void GameListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SaveListBox.Items.Clear();
            if (GameListBox.SelectedItem == null) return;
            foreach(string a in _FileSystem.ShowSaves(GameListBox.SelectedItem.ToString()))
            {
                SaveListBox.Items.Add(a);
            }
        }
    }
}
