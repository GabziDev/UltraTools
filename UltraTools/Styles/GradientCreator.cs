using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace UltraTools.Styles
{
    public class GradientCreator
    {
        public static void GradientText(Label label, Color startColor, Color endColor)
        {
            label.Paint += (sender, e) =>
            {
                SizeF textSize = e.Graphics.MeasureString(label.Text, label.Font);

                float x = (label.Width - textSize.Width) / 2;
                float y = (label.Height - textSize.Height) / 2;

                y += (textSize.Height - label.Font.GetHeight()) / 2;

                PointF textLocation = new PointF(x, y);

                RectangleF rect = new RectangleF(textLocation, textSize);

                LinearGradientBrush textBrush = new LinearGradientBrush(
                    rect,
                    startColor,
                    endColor,
                    LinearGradientMode.Horizontal);

                Font labelFont = new Font(label.Font.FontFamily, label.Font.Size, label.Font.Style);

                e.Graphics.DrawString(label.Text, labelFont, textBrush, textLocation);

                label.ForeColor = SystemColors.ControlText;
            };
        }
    }
}
