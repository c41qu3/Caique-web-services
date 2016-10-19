using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Drawing;
using System.Drawing.Imaging;
namespace WebApplication1.Metodo
{
    public class DiminuiImagem
    {
        public static void ComprimirImagem(Image imagem, long qualidade, string filepath)
        {
            var param = new EncoderParameters(1);
            param.Param[0] = new EncoderParameter(System.Drawing.Imaging.Encoder.Quality, qualidade);
            var codec = ObterCodec(imagem.RawFormat);
            imagem.Save(filepath, codec, param);
        }

        private static ImageCodecInfo ObterCodec(ImageFormat formato)
        {
            var codec = ImageCodecInfo.GetImageDecoders().FirstOrDefault(c => c.FormatID == formato.Guid);
            if (codec == null) throw new NotSupportedException();
            return codec;
        }
    }
}