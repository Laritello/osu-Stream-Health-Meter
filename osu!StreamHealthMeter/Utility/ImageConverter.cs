using SFML.Graphics;
using System.Collections.Generic;
using System.Drawing.Imaging;

namespace OsuStreamHealthMeter.Utility
{
    // Source:
    // https://en.sfml-dev.org/forums/index.php?topic=14862.0
    class ImageConverter
    {
        public static Image ToSFMLImage(System.Drawing.Bitmap source)
        {
            Color[,] sfmlcolorarray = new Color[source.Width, source.Height];

            for (int x = 0; x < source.Width; x++)
            {
                for (int y = 0; y < source.Height; y++)
                {
                    System.Drawing.Color csharpcolor = source.GetPixel(x, y);
                    sfmlcolorarray[x, y] = new Color(csharpcolor.R, csharpcolor.G, csharpcolor.B, csharpcolor.A);
                }
            }

            return new Image(sfmlcolorarray);
        }

        public static Texture ToSFMLTexture(System.Drawing.Bitmap source)
        {
            return new Texture(ToSFMLImage(source));
        }

        public static List<Sprite> ImageToSprites(System.Drawing.Bitmap image)
        {
            List<Sprite> result = new List<Sprite>();

            if (image != null)
            {
                FrameDimension _imageFrameDimension = new FrameDimension(image.FrameDimensionsList[0]);
                int _imageFrameCount = image.GetFrameCount(_imageFrameDimension);

                for (int i = 0; i < _imageFrameCount; i++)
                {
                    image.SelectActiveFrame(_imageFrameDimension, i);
                    result.Add(GetSprite(image));
                }
            }

            return result;
        }

        public static Sprite GetSprite(System.Drawing.Bitmap image)
        {
            if (image == null)
                return null;

            Texture _texture = ToSFMLTexture(image);

            return new Sprite(_texture);
        }
    }
}
