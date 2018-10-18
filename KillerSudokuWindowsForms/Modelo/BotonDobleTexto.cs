using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace KillerSudokuWindowsForms.Modelo
{
    class BotonDobleTexto : Button
    {
        public BotonDobleTexto()
        {
            UseVisualStyleBackColor = false;

            TextImageRelation = TextImageRelation.ImageAboveText;
        }
        public override string Text
        {
            get { return ""; }
            set { RightText = value; }
        }
        public string LeftText { get; set; }
        public string RightText { get; set; }
        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            Rectangle rect = ClientRectangle;
            rect.Inflate(-5, -20);

            using (StringFormat sf = new StringFormat() { Alignment = StringAlignment.Near, LineAlignment = StringAlignment.Far })
            {
                using (Brush brush = new SolidBrush(ForeColor))
                {
                    Font fontOperaciones = new Font(FontFamily.GenericSansSerif, 6.0f, FontStyle.Bold);
                    pevent.Graphics.DrawString(LeftText, fontOperaciones, brush, rect, sf);
                    sf.Alignment = StringAlignment.Far;
                    pevent.Graphics.DrawString(RightText, Font, brush, rect, sf);
                }
            }
        }
    }
}
