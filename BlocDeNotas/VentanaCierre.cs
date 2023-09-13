using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlocDeNotas
{
    public partial class VentanaCierre : Form

    {
        Principal principal;
        public VentanaCierre(Principal p)
        {
            InitializeComponent();
            principal = p;
        }

        private void VentanaCierre_Load(object sender, EventArgs e)
        {

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            //Guarda el archivo
            this.DialogResult = DialogResult.Yes;
            this.Close();
        }

        private void UnsaveButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }
    }
}
