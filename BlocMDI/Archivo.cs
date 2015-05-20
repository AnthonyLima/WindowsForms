using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BlocMDI
{
    public class Archivo
    {
        public static void GuardarArchivo(string NombreArchivo, string Contenido){
            StreamWriter SwArchivo;
            SwArchivo = new StreamWriter(NombreArchivo,false, System.Text.Encoding.Default);
            SwArchivo.Write(Contenido);
            SwArchivo.Close();
        }
    }
}
