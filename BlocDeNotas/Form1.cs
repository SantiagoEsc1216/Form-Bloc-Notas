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
        Queue<string> Text_History = new Queue<string>(); //Nos ayudara a almacenar el historial de versiones

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
            Undo();
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
        private void Cut()
        {
            textBox.Cut();
        }
        private void Paste()
        {
            textBox.Paste();
        }
        private void Copy()
        {
            textBox.Copy();
        }
        private void Undo()
        {
            //Verificar si hay elementos en la cola
            if(Text_History.Count > 0)
            {
                //Sacar el ultimo cambio de la cola 
                 string lastText = Text_History.Dequeue(); 
                //Aplicar el ultimo cambio
                 textBox.Text = lastText;   
            }
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

        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {

        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            //Obtener el texto actual
            string text = textBox.Text;
            //Almacenar en el historial
            Text_History.Enqueue(text);
            if(Text_History != null)
            {
                tool_UndoButton.Enabled = true;
                Menu_UndoButton.Enabled = true; 
            }
        }

        private void Menu_UndoButton_Click(object sender, EventArgs e)
        {
            Undo();
        }
    }
}
