using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Drawing;
namespace WebApplication1.Metodo
{
    public static class Converter
    {
        public static byte[] ImageToByteArray(Stream caminhoImagem)
        {
            byte[] arraybytes = null;

            //var informacoesFicnheiro = new FileInfo(caminhoImagem);
            //long numeroBytes = informacoesFicnheiro.Length;

            //var fStream = new FileStream(caminhoImagem, FileMode.Open, FileAccess.Read);

            //var br = new BinaryReader()

            //arraybytes = br.ReadBytes((int)numeroBytes);
            MemoryStream ms = caminhoImagem as MemoryStream;
            if (ms == null)
            {
                ms = new MemoryStream();
                caminhoImagem.CopyTo(ms);
            }
            arraybytes = ms.ToArray();

            return arraybytes;
        }

        public static Image ByteArrayToImage(byte[] imageByte)
        {
            var ms = new MemoryStream(imageByte);
            var image = Image.FromStream(ms);
            return image;
        }

        public static byte[] imageToByteArray(Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            return ms.ToArray();
        }

    }
}