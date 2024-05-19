using System;
using System.Drawing;
using System.Windows.Forms;

namespace Login
{
    public class CircularProgressBar : Control
    {
        private int progressValue;
        private Color progressColor = Color.Blue;
        private Color backColor = Color.Gray;
        private int lineWidth = 10;

        public int ProgressValue
        {
            get { return progressValue; }
            set
            {
                progressValue = value;
                Invalidate(); // Redraw control when progress value changes
            }
        }

        public Color ProgressColor
        {
            get { return progressColor; }
            set
            {
                progressColor = value;
                Invalidate(); // Redraw control when color changes
            }
        }

        public new Color BackColor
        {
            get { return backColor; }
            set
            {
                backColor = value;
                Invalidate(); // Redraw control when background color changes
            }
        }

        public int LineWidth
        {
            get { return lineWidth; }
            set
            {
                lineWidth = value;
                Invalidate(); // Redraw control when line width changes
            }
        }

        public int TotalCases { get; set; } = 0;

        public CircularProgressBar()
        {
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            Rectangle rect = new Rectangle(0, 0, this.Width, this.Height);
            rect.Inflate(-lineWidth, -lineWidth);

            using (Pen backPen = new Pen(backColor, lineWidth))
            using (Pen progressPen = new Pen(progressColor, lineWidth))
            {
                // Draw the background circle
                e.Graphics.DrawArc(backPen, rect, 0, 360);

                // Draw the progress circle
                float sweepAngle = 360f * progressValue / 100;
                e.Graphics.DrawArc(progressPen, rect, -90, sweepAngle);
            }

            // Draw the total cases inside the circle
            string totalCasesText = TotalCases.ToString();
            string percentageText = progressValue + "%";
            using (Font font = new Font("Arial", 24, FontStyle.Bold))
            using (Brush brush = new SolidBrush(progressColor))
            {
                SizeF textSize = e.Graphics.MeasureString(totalCasesText, font);
                PointF location = new PointF((this.Width - textSize.Width) / 2, (this.Height - textSize.Height) / 2);
                e.Graphics.DrawString(totalCasesText, font, brush, location);
            }

            using (Font font = new Font("Arial", 14, FontStyle.Regular))
            using (Brush brush = new SolidBrush(progressColor))
            {
                SizeF textSize = e.Graphics.MeasureString(percentageText, font);
                PointF location = new PointF((this.Width - textSize.Width) / 2, (this.Height - textSize.Height) / 2 + 30);
                e.Graphics.DrawString(percentageText, font, brush, location);
            }
        }
    }
}
