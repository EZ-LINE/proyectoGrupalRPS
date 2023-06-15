using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms
{
    public partial class OnsetForm : Form
    {
        MainForm mainForm;

        public OnsetForm(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void botonIniciar_Click(object sender, EventArgs e)
        {
            mainForm.OpenChildForms(new RPS_3Form());
        }
    }
}
