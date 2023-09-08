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
    public partial class VentanaDeBusqueda : Form
    {
        string text_Searched = null; 
        List<int> index_list = new List<int>();
        int actual_index = 0;
        Principal principal = null;
        public VentanaDeBusqueda(Principal p)
        {
            InitializeComponent();
            principal = p;
        }

        private void Search_Button_Click(object sender, EventArgs e)
        {
            //buscar la seleccion
            principal.Update_Search(Search_TextBox.Text);
            //Reiniciar las caracteristicas que estaban seteadas a la anterior busqueda 
            actual_index = 0;
            Search_TextBox.Text = text_Searched;
            //Actualizar las coincidencias encontradas
            Result_Label.Text = "Coincidencias encontradas: " + index_list.Count;
        }

        private void Next_button_Click(object sender, EventArgs e)
        {
            //Actualizar el indice si aun se puede 
            if (index_list.Count > actual_index + 1)
            {
                //Actualizar el indice solo si aun cabe en el conte 
                actual_index++;
                principal.Illuminate_text(index_list[actual_index]);
            }
        }

        private void Prev_button_Click(object sender, EventArgs e)
        {
            //Actualizar indice si aun se puede
            if (actual_index - 1 >= 0)
            {
                actual_index--;
                principal.Illuminate_text(index_list[actual_index]);
            }
            
               
        }

        public void getDatas(string Text, List<int> index)
        {
            index_list = index;
            text_Searched = Text;
            //Actualizar el texto de la caja de texto
            Search_TextBox.Text = text_Searched;
            //Actualizar las coincidencias encontradas
            Result_Label.Text = "Coincidencias encontradas: "+index_list.Count;
            //Iluminar la seleccion
            principal.Illuminate_text(actual_index);
        }
    }
}
