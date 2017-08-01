using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Web;

namespace Bogoraz.Utils
{
    public class ImageConverter
    {
        public string SaveByteArrayAsImage(string outputPath, string base64String)
        {
            base64String = base64String.Replace("data:image/png;base64,", "");
            byte[] bytes = Convert.FromBase64String(base64String);
            Guid gid = Guid.NewGuid();
            string imageName = "\\signature-" + gid + ".png";

            Image image;
            using (MemoryStream ms = new MemoryStream(bytes))
            {
                image = Image.FromStream(ms);
            }

            image.Save(outputPath + imageName, System.Drawing.Imaging.ImageFormat.Png);

            return imageName;
        }
    }
}