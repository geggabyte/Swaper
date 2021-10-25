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
    public partial class CreateEmptyForm : Form
    {
        Swaper swaper;

        public CreateEmptyForm(Swaper a)
        {
            InitializeComponent();
            swaper = a;
        }

        private void DoneButton_Click(object sender, EventArgs e)
        {
            if (nameBox.Text == null) return;
            swaper.CreateEmpty(nameBox.Text);
            this.Close();
        }
    }
}
