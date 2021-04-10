using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARREGLOS.clases
{
    class ClsArreglos
    {
        private int[] ArregloTemporal;
        private int[] datos;
        private int i, j, datoTemnporal;
        private int tamanoArreglo =0;
        private string[] arregloNotas;

        public int TamañoArreglo()
        {
            return datos.Length;
        }

        public ClsArreglos(int[] arreglo)
        {
            datos = arreglo;
            tamanoArreglo = datos.Length; //numero de datos
        }

        public ClsArreglos(string[] arregloNotas)
        {
            this.arregloNotas = arregloNotas;
        }

        public int[] MetodoBurbuja()
        {
            ArregloTemporal = datos;
            for(i=0; i <tamanoArreglo -1; i++)
            {
                for(j=i+1; j <tamanoArreglo; j++)
                {
                    if (ArregloTemporal[i].CompareTo(ArregloTemporal[j]) >0)
                    {
                        datoTemnporal = ArregloTemporal[i];
                        ArregloTemporal[i] = ArregloTemporal[j];
                        ArregloTemporal[j] = datoTemnporal;
                    }
                    
                }
            }
            return ArregloTemporal;
        }
    }
}
