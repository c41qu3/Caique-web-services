using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web.Hosting;
namespace WebApplication1.Metodo
{
  public static class ListarDir
    {
        public static List<String>  Listar()
        {
            string path = (System.Web.HttpContext.Current.Server.MapPath("~/FotosLayout") );
            DirectoryInfo Dir = new DirectoryInfo(path);
            // Busca automaticamente todos os arquivos em todos os subdiretórios
            FileInfo[] Files = Dir.GetFiles("*", SearchOption.AllDirectories);
            List<String> lista = new List<String>();
            foreach (FileInfo File in Files)
            {
                String nome = File.FullName;

                if (nome.Equals("C:\\Users\\Caique Santos\\Desktop\\Trabalhos sites\\site paulinho\\ClassLibrary1\\WebApplication1\\FotosLayout\\Thumbs.db"))
                {
                   
                }
                else
                {
                    lista.Add(File.FullName);
                } 
            
               
            }
            return lista;
        }
    }
}