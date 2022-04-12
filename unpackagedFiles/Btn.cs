using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace CandyCrush
{
    public class Btn : Button
    {
        public static Color[] colors = { Color.LightCoral, Color.Gold, Color.RoyalBlue,
            Color.PaleGreen, Color.BurlyWood, Color.BlueViolet };

        private static Random random = new Random();

        public static int size = 25;

        public int row { get; set; }
        public int col { get; set; }

        public Btn()
        {
            // Width and Height are from the parent
            Width = Height = size; // this is called a triple assignment; all of these values are now the same
            int initialColor = random.Next(0, colors.Length); // random number between 0 and colors.Length

            // set button color to a random color
            this.BackColor = colors[initialColor];
        }
    }
}
