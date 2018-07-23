using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoEStreamLootOverlay
{
    public class ImageBuilder
    {
        private static ImageBuilder instance;

        /// <summary>
        /// Too many magic numbers : /
        /// </summary>
        /// <param name="data"></param>
        public void MakeImage(Dictionary<string, Currency> data)
        {

            data = data.Where(item => item.Value.Enabled).ToDictionary(item => item.Key, item => item.Value);


            if(data.Count == 0)
            {
                return;
            }

            int margin = 5, multiplier = 100;
            int nWidth = (data.Count * multiplier + 10), nHeight = 150;

            Image newImage = new Bitmap(nWidth, nHeight);
            Graphics g = Graphics.FromImage(newImage);

            // Creating Background
            Rectangle rect = new Rectangle(0, 0, 120*data.Count, 150);
            SolidBrush blueBrush = new SolidBrush(Color.FromArgb(125,0,0,0));
            g.FillRectangle(blueBrush, rect);


            // Draw icons and text
            int count = 0;
            foreach(KeyValuePair<string, Currency> entry in data)
            {
                Image tmpImage = Image.FromFile(entry.Value.Icon);
                g.DrawImage(tmpImage, new Point((count * multiplier) + margin, margin));

                // CHANGE THIS: Calculate string width and center it in a rectangle 
                g.DrawString(entry.Value.Count.ToString(), new Font("Verdana", 24), new SolidBrush(Color.White)
                    , new Point(22 + (count * 100), 100)
                );

                count++;          
            }



            newImage.Save(@"C:\tmp\i1.jpg");// save the bitmap  
        }

        public static ImageBuilder Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new ImageBuilder();
                }

                return instance;
            }
        }

    }


}
