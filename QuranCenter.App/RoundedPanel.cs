using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace النظام_النهائي
{
    public class RoundedPanel : Panel
    {
        public int CornerRadius { get; set; } = 10;
        public Color BorderColor { get; set; } = Color.Transparent;
        public int BorderWidth { get; set; } = 0;

        public RoundedPanel()
        {
            this.DoubleBuffered = true;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            using (var path = new GraphicsPath())
            {
                var rect = new Rectangle(0, 0, this.Width, this.Height);
                if (CornerRadius > 0)
                {
                    path.AddArc(rect.X, rect.Y, CornerRadius * 2, CornerRadius * 2, 180, 90);
                    path.AddArc(rect.Right - (CornerRadius * 2), rect.Y, CornerRadius * 2, CornerRadius * 2, 270, 90);
                    path.AddArc(rect.Right - (CornerRadius * 2), rect.Bottom - (CornerRadius * 2), CornerRadius * 2, CornerRadius * 2, 0, 90);
                    path.AddArc(rect.X, rect.Bottom - (CornerRadius * 2), CornerRadius * 2, CornerRadius * 2, 90, 90);
                    path.CloseFigure();
                    this.Region = new Region(path);

                    // Draw border if width is greater than 0
                    if (BorderWidth > 0)
                    {
                        using (var pen = new Pen(BorderColor, BorderWidth))
                        {
                            // Adjust rectangle to draw border inside the panel bounds
                            var borderRect = new Rectangle(rect.X + BorderWidth / 2, rect.Y + BorderWidth / 2, rect.Width - BorderWidth, rect.Height - BorderWidth);
                            e.Graphics.DrawPath(pen, path);
                        }
                    }
                }
                else
                {
                    this.Region = new Region(rect);
                }
            }
        }
    }
}
