using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace CircularProgressBarExample
{
    public class CircularProgressBar : Control
    {
        static CircularProgressBar()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(CircularProgressBar), new FrameworkPropertyMetadata(typeof(CircularProgressBar)));
        }

        public static readonly DependencyProperty ValueProperty =
            DependencyProperty.Register("Value", typeof(double), typeof(CircularProgressBar), new PropertyMetadata(0.0, OnValueChanged));

        public double Value
        {
            get { return (double)GetValue(ValueProperty); }
            set { SetValue(ValueProperty, value); }
        }

        private static void OnValueChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            CircularProgressBar cpb = d as CircularProgressBar;
            cpb.InvalidateVisual();
        }

        public double StrokeThickness
        {
            get { return (double)GetValue(StrokeThicknessProperty); }
            set { SetValue(StrokeThicknessProperty, value); }
        }

        public static readonly DependencyProperty StrokeThicknessProperty =
            DependencyProperty.Register("StrokeThickness", typeof(double), typeof(CircularProgressBar), new PropertyMetadata(5.0));

        protected override void OnRender(DrawingContext drawingContext)
        {
            base.OnRender(drawingContext);

            double angle = 360 * (Value / 100);

            Point center = new Point(RenderSize.Width / 2, RenderSize.Height / 2);
            double radius = (RenderSize.Width / 2) - (StrokeThickness / 2);

            drawingContext.DrawEllipse(null, new Pen(Background, StrokeThickness), center, radius, radius);

            drawingContext.DrawGeometry(null, new Pen(Foreground, StrokeThickness),
                CreateArcGeometry(center, radius, angle));
        }

        private Geometry CreateArcGeometry(Point center, double radius, double angle)
        {
            bool isLargeArc = angle >= 180.0;

            double radians = (Math.PI / 180) * angle;
            Point arcEndPoint = new Point(
                center.X + radius * Math.Cos(radians - Math.PI / 2),
                center.Y + radius * Math.Sin(radians - Math.PI / 2));

            Size arcSize = new Size(radius, radius);

            StreamGeometry streamGeometry = new StreamGeometry();
            using (StreamGeometryContext ctx = streamGeometry.Open())
            {
                ctx.BeginFigure(new Point(center.X, center.Y - radius), false, false);
                ctx.ArcTo(arcEndPoint, arcSize, 0, isLargeArc, SweepDirection.Clockwise, true, false);
            }

            return streamGeometry;
        }
    }
}
