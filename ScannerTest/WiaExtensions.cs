using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Text;
using WIA;

namespace Cyotek.Demo.ScannerTest
{
  internal static class WiaExtensions
  {
    #region Public Methods

    public static string GetValueString(this Property property)
    {
      string value;

      if (property.IsVector)
      {
        value = ((Vector)property.get_Value()).ToSeparatedString();
      }
      else
      {
        switch ((WiaPropertyType)property.Type)
        {
          case WiaPropertyType.ClassIDPropertyType:
          case WiaPropertyType.StringPropertyType: // string
            value = (string)property.get_Value();
            break;

          case WiaPropertyType.LongPropertyType:
            value = ((int)property.get_Value()).ToString();
            break;

          default:
            value = property.get_Value().ToString();
            break;
        }
      }

      return value;
    }

    public static Bitmap ToBitmap(this ImageFile image)
    {
      Bitmap result;
      byte[] data;

      data = (byte[])image.FileData.get_BinaryData();

      using (MemoryStream stream = new MemoryStream(data))
      {
        using (Image scannedImage = Image.FromStream(stream))
        {
          result = new Bitmap(image.Width, image.Height, PixelFormat.Format32bppArgb);

          using (Graphics g = Graphics.FromImage(result))
          {
            g.Clear(Color.Transparent);
            g.PageUnit = GraphicsUnit.Pixel;
            g.DrawImage(scannedImage, new Rectangle(0, 0, image.Width, image.Height));
          }
        }
      }

      return result;
    }

    public static string ToSeparatedString(this Vector vector)
    {
      StringBuilder sb;

      sb = new StringBuilder();

      for (int i = 0; i < vector.Count; i++)
      {
        if (i > 0)
        {
          sb.Append(',').Append(' ');
        }

        sb.Append(vector.get_Item(i + 1).ToString());
      }

      return sb.ToString();
    }

    #endregion Public Methods
  }
}