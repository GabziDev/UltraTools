using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltraTools.Styles
{
    internal class ButtonStyle
    {
        public static void StyleBtn(Button button)
        {
            button.BackColor = Color.FromArgb(46, 46, 83);
            button.FlatAppearance.BorderSize = 0;
            button.FlatStyle = FlatStyle.Flat;
            button.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button.ForeColor = SystemColors.Control;
            button.UseVisualStyleBackColor = false;

            button.Region = Region.FromHrgn(RoundCreator.CreateRoundRectRgn(0, 0, button.Width, button.Height, 7, 7));
        }
    }
}
