using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Design;
using System.Drawing;
using System.Drawing.Imaging;

class DiminuieSalvaimg
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
    static void Main(string[] args)
    {
        ComprimirImagem(Image.FromFile("C:/Users/Caique Santos/Pictures/Rk86o.jpg"), 60, "C:/Users/Caique Santos/Pictures/Rk86osaída.jpg");
    }
}

