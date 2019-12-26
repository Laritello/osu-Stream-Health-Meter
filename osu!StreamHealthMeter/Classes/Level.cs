using Newtonsoft.Json;
using SFML.Graphics;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace OsuStreamHealthMeter.Classes
{
    public class Level
    {
        public string Name { get; set; }
        public int Minimum { get; set; }
        public int Maximum { get; set; }
        public string ImagePath { get; set; }

        [JsonIgnore]
        public List<Sprite> Sprites { get; set; }

        public void Load()
        {
            if (!System.IO.File.Exists(ImagePath))
                throw new System.IO.FileNotFoundException("Image file doesn't found.");

            Bitmap image = new Bitmap(ImagePath);
            Sprites = Utility.ImageConverter.ImageToSprites(image);
            image.Dispose();

        }
    }
}
