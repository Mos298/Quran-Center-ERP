using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

// ضعه داخل النيم سبيس الخاص بمشروعك
namespace النظام_النهائي
{
    public class OvalPanel : Panel
    {
        public OvalPanel()
        {
            this.DoubleBuffered = true;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            using (var path = new GraphicsPath())
            {
                path.AddEllipse(this.ClientRectangle);
                this.Region = new Region(path);
                using (var brush = new SolidBrush(this.BackColor))
                {
                    e.Graphics.FillPath(brush, path);
                }
            }
        }
    }
}