using ImageMagick;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppToTeste
{
    public static class ImagemConverter
    {
        public static MemoryStream CreateMemoryImage()
        {
            MemoryStream imageStream = new();
            MagickImage image = new MagickImage();
            MagickReadSettings readSettings = new MagickReadSettings()
            {
                Width = 500,
                Height = 500,
                Font = "Arial",
                BackgroundColor = MagickColors.Red// new MagickColor(240, 240, 240),
            };
            image.Read("caption: test", readSettings);
            image.Write(imageStream, ImageMagick.MagickFormat.WebP);
            return imageStream;
            //image.Write("escrito.jpg", ImageMagick.MagickFormat.Jpg);
            //imageStream.Position = 0;




            //var file = new FormFile(imageStream, 0, imageStream.Length, "teste.jpg", "teste.jpg") { 
            //    Headers = new HeaderDictionary(),
            //    ContentType = "image/jpg"
            //};
            
            

            //FileStream fs = new FileStream(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures) + "\\" + "teste.jpg", FileMode.OpenOrCreate, FileAccess.ReadWrite,FileShare.ReadWrite);
            //file.CopyTo(fs);
            
        }


        public static void createPhysicalImagem(MemoryStream stream)
        {
            stream.Position = 0;
            MagickImage image = new MagickImage(stream);
            image.Write("criado.webp", ImageMagick.MagickFormat.WebP);
        }
    }
}
