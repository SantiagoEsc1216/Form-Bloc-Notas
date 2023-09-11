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
        VentanaDeBusqueda Search_Windows; //La otra ventana
        List<int> index_of_Searchs = new List<int>();
        string Search_String = null; 
        public Principal()
        {
            InitializeComponent();
            OFD.Filter = "Archivos de texto | *.txt"; //Filtro para que solo nos aparezcan archivos de texto
            SFD.Filter = OFD.Filter;
            SFD.AddExtension = true;
            if (Clipboard.ContainsText())
            {
                tool_PasteButton.Enabled = true;
                Menu_PasteButton.Enabled = true;
            }
            else
            {
                tool_PasteButton.Enabled = false;
                Menu_PasteButton.Enabled = false;
            }

             Search_Windows = new VentanaDeBusqueda(this);
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
                Change_StatusLabel();
            }
        }
        private void SaveAs()
        {
            //Guardar como 
            if (SFD.ShowDialog() == DialogResult.OK)
                File.WriteAllText(SFD.FileName, textBox.Text);
                FileName = SFD.FileName;
                FileName_Text.Text = "Dirección del archivo: " + FileName;
            Change_StatusLabel();
        }
        private void Change_StatusLabel()
        {
            tool_StatusTag.Text = "Estado: Guardado";
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
            if (textBox.CanUndo)
            {
                textBox.Undo();
                textBox.ClearUndo();
            }
            if (textBox.Text == null)
            {
                tool_UndoButton.Enabled = false;
                Menu_UndoButton.Enabled = false;
                //Botones de cortar
                tool_CutButton.Enabled = false;
                Menu_CutButton.Enabled = false;
                //Botones de copiar
                tool_CopyButton.Enabled = false;
                Menu_CopyButton.Enabled = false;
                //Botones de buscar
                tool_SearchBox.Enabled = false;
                Menu_SearchBox.Enabled = false;
                //Botones de guardar como
                tool_SaveAsButton.Enabled = false;
                Menu_SaveAsButton.Enabled = false;
                //Botones de guardar
                tool_SaveButton.Enabled = false;
                Menu_SaveButton.Enabled = false;

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
 
            if(text != null)
            {
                //activar botones cuando se ingresa texto, debido a que deshacer necesita que haya texto
                //tambien cortar, pues necesita que cortar, al igual que copiar
                //Tambien la caja de texto de buscar, pues necesita que exista texto para poder buscar 
                //Botones de deshacer
                tool_UndoButton.Enabled = true;
                Menu_UndoButton.Enabled = true; 
                //Botones de cortar
                tool_CutButton.Enabled = true;
                Menu_CutButton.Enabled = true;
                //Botones de copiar
                tool_CopyButton.Enabled = true;
                Menu_CopyButton.Enabled = true; 
                //Botones de buscar
                tool_SearchBox.Enabled = true;
                Menu_SearchBox.Enabled = true;
                //Botones de guardar como
                tool_SaveAsButton.Enabled = true;
                Menu_SaveAsButton.Enabled = true;
                //Botones de guardar
                tool_SaveButton.Enabled = true;
                Menu_SaveButton.Enabled = true;
            }
            //Si el portapapeles contiene texto se activa el boton 
            /*if (Clipboard.ContainsText())
            {
                tool_PasteButton.Enabled = true;
                Menu_PasteButton.Enabled = true;
            }*/
            try
            {
                if (Clipboard.ContainsText())
                {
                    tool_PasteButton.Enabled = true;
                    Menu_PasteButton.Enabled = true;
                }
            }
            catch (System.Runtime.InteropServices.ExternalException)
            {
                // Manejar la excepción aquí
                // Por ejemplo, puedes mostrar un mensaje de error al usuario
                MessageBox.Show("No se pudo acceder al portapapeles. Inténtalo de nuevo más tarde.");
            }

            tool_StatusTag.Text = "Estado: Sin guardar";

        }

        private void Menu_UndoButton_Click(object sender, EventArgs e)
        {
            Undo();
        }

        private void tool_SearchBox_Click(object sender, EventArgs e)
        {
            tool_SearchBox.Clear();
        }

        private void tool_SearchBox_TextChanged(object sender, EventArgs e)
        {
            //Activar boton cuando se ingrese texto al campo
            tool_SearchButton.Enabled = true;
        }

        private void Menu_SearchBox_TextChanged(object sender, EventArgs e)
        {
            Menu_SearchButton.Enabled = true;
        }

        private void tool_CutButton_Click(object sender, EventArgs e)
        {
            Cut();
        }

        private void tool_CopyButton_Click(object sender, EventArgs e)
        {
            Copy();
        }

        private void tool_PasteButton_Click(object sender, EventArgs e)
        {
            Paste();
        }

        private void Menu_PasteButton_Click(object sender, EventArgs e)
        {
            Paste();
        }

        private void Menu_CopyButton_Click(object sender, EventArgs e)
        {
            Copy();
        }

        private void Menu_CutButton_Click(object sender, EventArgs e)
        {
            Cut();
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        
        private List<int> Index_Generator(string data)
        {
            //Lista que guardara los indices de la palabra encontrada 
            List<int> index_list = new List<int>();
            bool end_Signal = true; //Sirve para controlar el fin del ciclo While
            int actual_index = -1;
            int index;
            while (end_Signal && actual_index < textBox.TextLength)
            {
                index = textBox.Text.IndexOf(data,actual_index+1);
                
                if(index == -1) //no encontro la palabra
                {
                    //mandar señal para terminar ciclo 
                    end_Signal = false;
                }
                else
                {
                    //Añadir el indice a la lista 
                    index_list.Add(index); 
                    //Actualizar indices 
                    actual_index = index;
                }
            }

            return index_list;
        }

        public void Illuminate_text(int index)
        {
            //Iliminar la seleccion actual 
            textBox.SelectionStart = index;
            textBox.SelectionLength = Search_String.Length;
            //textBox.Focus();
            this.Focus();
        }

        private void Menu_SearchButton_Click(object sender, EventArgs e)
        {
            Search_String = Menu_SearchBox.Text;
            //Generar la lista de indices
            index_of_Searchs = Index_Generator(Menu_SearchBox.Text);
            //Mandar los datos a la otra ventana
            Search_Windows.getDatas(Menu_SearchBox.Text, index_of_Searchs);
            //Abrir la ventana
            Search_Windows.Show(this);
            this.Focus();
            //Search_Windows.Focus();
        }
        private void tool_SearchButton_Click(object sender, EventArgs e)
        {
            Search_String = tool_SearchBox.Text;
            //Generar la lista de indices
            index_of_Searchs = Index_Generator(tool_SearchBox.Text);
            //Mandar los datos a la otra ventana
            Search_Windows.getDatas(tool_SearchBox.Text, index_of_Searchs);
            //Abrir la ventana
            Search_Windows.Show(this);
            this.Focus();
            //Search_Windows.Focus();


        }

        public void Update_Search(string Text)
        {
            Search_String = Text;
            index_of_Searchs = Index_Generator(Text);
            Search_Windows.getDatas(Search_String,index_of_Searchs);
            if (index_of_Searchs.Count > 0)
            {
                Illuminate_text(index_of_Searchs[0]);
            }
            
        }
        public void Delete_SearchDatas()
        {
            Search_String = "";
            Menu_SearchBox.Text = null;
            tool_SearchBox.Text = null;
            index_of_Searchs.Clear();
        }

        private void Menu_SearchBox_Click(object sender, EventArgs e)
        {
            Menu_SearchBox.Clear();
        }

        private void Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Search_Windows.Dispose();
            Application.Exit();
        }
    }
}
