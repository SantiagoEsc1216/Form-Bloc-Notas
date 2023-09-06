using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace BlocDeNotas
{
    public partial class Principal : Form
    {
        OpenFileDialog OFD= new OpenFileDialog(); //Nos ayudara abrir un archivo 
        SaveFileDialog SFD = new SaveFileDialog(); //Nos ayudara a guardar como un archivo

        string FileName; //Guardara el nombre del archivo que este abierto
        public Principal()
        {
            InitializeComponent();
            OFD.Filter = "Archivos de texto | *.txt"; //Filtro para que solo nos aparezcan archivos de texto
            SFD.Filter = OFD.Filter;
            SFD.AddExtension = true;
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void ediciónToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tool_UndoButton_Click(object sender, EventArgs e)
        {
        }

        private void tool_SaveButton_Click(object sender, EventArgs e)
        {
            Save();
        }
        private void Open()
        {
            if(OFD.ShowDialog() == DialogResult.OK)
            {
                textBox.Text= File.ReadAllText(OFD.FileName);
                FileName=OFD.FileName;
                FileName_Text.Text = "Dirección del archivo: " + FileName;
                
            }
                 
        }
        
        private void Save()
        {
            if(FileName == null)
            {
                //Si el nombre es nulo mandaremos a llamar SaveAs, debido a que se comenzo a escribir en el archivo en blanco
                SaveAs();
            }
            else
            {
                File.WriteAllText(FileName, textBox.Text);
            }
        }
        private void SaveAs()
        {
            //Guardar como 
            if (SFD.ShowDialog() == DialogResult.OK)
                File.WriteAllText(SFD.FileName, textBox.Text);
                FileName = SFD.FileName;
                FileName_Text.Text = "Dirección del archivo: " + FileName;
        }

        private void tool_SaveAsButton_Click(object sender, EventArgs e)
        {
            SaveAs();
        }

        private void Menu_SaveAsButton_Click(object sender, EventArgs e)
        {
            SaveAs();
        }

        private void menu_OpenButton_Click(object sender, EventArgs e)
        {
            Open();
        }

        private void Menu_SaveButton_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void tool_OpenButton_Click(object sender, EventArgs e)
        {
            Open();
        }

        private void Menu_ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
