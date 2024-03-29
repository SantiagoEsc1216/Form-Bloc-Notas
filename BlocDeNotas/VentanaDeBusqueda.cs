﻿using System;
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
            else
            {
                iluminateText(index_list, actual_index);
            }
        }

        private void Prev_button_Click(object sender, EventArgs e)
        {
            //Actualizar indice si aun se puede

            if (actual_index > 0)
            {
                actual_index--;
                iluminateText(index_list, actual_index);
            }
            else
            {
                iluminateText(index_list, actual_index);
            }

        }

        public void getDatas(string Text, List<int> index)
        {
            index_list = index;
            text_Searched = Text;
            //Actualizar el texto de la caja de texto
            if (Text != null)
            {
                Search_TextBox.Text = text_Searched;
            }
            //Actualizar las coincidencias encontradas
            Result_Label.Text = "Coincidencias encontradas: " + index_list.Count;
            //Iluminar la seleccion
            iluminateText(index_list, 0);
           
           
        }

        private void VentanaDeBusqueda_FormClosed(object sender, FormClosedEventArgs e)
        {
          /*  principal.Delete_SearchDatas();
            text_Searched = null;
            index_list.Clear();
            actual_index = 0;*/

        }

        private void VentanaDeBusqueda_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
            principal.Update_Search(Search_TextBox.Text);
        }

        private void iluminateText(List<int> list, int index)
        {
            if (index_list.Count > index)
            {
                principal.Illuminate_text(list[index]);
            }
        }
    }
}
