﻿using System.Windows.Media;

namespace SVGImage.SVG.PaintServer
{
    internal class SolidColorPaintServer : PaintServer
    {
        public Color Color { get; set; }

        public SolidColorPaintServer(PaintServerManager owner, Color c)
            : base(owner)
        {
            this.Color = c;
        }

        public override Brush GetBrush(double opacity, SVG svg)
        {
            byte a = (byte)(255 * opacity / 100);
            Color c = this.Color;
            Color newcol = System.Windows.Media.Color.FromArgb(a, c.R, c.G, c.B);
            return new SolidColorBrush(newcol);
        }
    }
}
