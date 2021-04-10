using ARREGLOS.clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ARREGLOS
{
    public partial class Form1 : Form
    {
        private string[] arregloNotas;

        public Form1()
        {
            InitializeComponent();
        }


        private void buttonNombres_Click(object sender, EventArgs e)
        {
            ClsArchivo ar = new ClsArchivo();

            var archivo = @"C:\Users\13237\OneDrive\Desktop\archivoPlano.csv";
            string resultado = ar.leerTodoArchivo(archivo);

            arregloNotas = ar.leerArchivo(archivo); //retorna arreglo

            int contador = 0;

            foreach (string linea in arregloNotas)
            {
                if (contador != 0)
                {
                    string[] datos = linea.Split(';');
                    listBoxResultado.Items.Add(datos[1]); 
                }
                contador++;
            }
            
        }
        private void buttonArreglo_Click(object sender, EventArgs e)
        {
            ClsArchivo ar = new ClsArchivo();

            var archivo = @"C:\Users\13237\OneDrive\Desktop\archivoPlano.csv";
            string resultado = ar.leerTodoArchivo(archivo);

            arregloNotas = ar.leerArchivo(archivo); //retorna arreglo

            int contador = 0;

            foreach (string linea in arregloNotas)
            {
                if (contador != 0)
                {
                    string[] datos = linea.Split(';');
                    listBoxNota1.Items.Add(datos[2]);
                }
                contador++;
            }
        }
        private void buttonNota2_Click(object sender, EventArgs e)
        {
            ClsArchivo ar = new ClsArchivo();

            var archivo = @"C:\Users\13237\OneDrive\Desktop\archivoPlano.csv";
            string resultado = ar.leerTodoArchivo(archivo);

            arregloNotas = ar.leerArchivo(archivo); //retorna arreglo

            int contador = 0;

            foreach (string linea in arregloNotas)
            {
                if (contador != 0)
                {
                    string[] datos = linea.Split(';');
                    listBoxNota2.Items.Add(datos[3]);
                }
                contador++;
            }
        }

        private void buttonNota3_Click(object sender, EventArgs e)
        {
            ClsArchivo ar = new ClsArchivo();

            var archivo = @"C:\Users\13237\OneDrive\Desktop\archivoPlano.csv";
            string resultado = ar.leerTodoArchivo(archivo);

            arregloNotas = ar.leerArchivo(archivo); //retorna arreglo

            int contador = 0;
            foreach (string linea in arregloNotas)
            {
                if (contador != 0)
                {
                    string[] datos = linea.Split(';');
                    listBoxNota3.Items.Add(datos[4]);
                }
                contador++;
            }
        }

        private void buttonPromedio_Click(object sender, EventArgs e)
        {  

        }

    }
}
