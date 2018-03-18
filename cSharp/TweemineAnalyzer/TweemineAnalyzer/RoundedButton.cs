using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace TweemineAnalyzer
{
    class CircleButton : Button
    {
        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            GraphicsPath graphicsPath = new GraphicsPath();
            graphicsPath.AddEllipse(ClientRectangle.X+2,ClientRectangle.Y+2,ClientSize.Width-4,ClientSize.Height-4);
            Region = new System.Drawing.Region(graphicsPath);
        }
    }
}
