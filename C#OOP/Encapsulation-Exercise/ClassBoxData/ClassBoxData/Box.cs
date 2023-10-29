using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBoxData
{
    public class Box
    {
        private double length;
        private double width;
        private double height;

        public Box(double length, double width, double height)
        {
            this.Length = length;
            this.Width = width;
            this.Height = height;
        }

        public double Length
        {
            get => this.length;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException($"{nameof(Length)} cannot be zero or negative.");
                }
                this.length = value;
            }
        }

        public double Width
        {
            get => this.width;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException($"{nameof(Width)} cannot be zero or negative.");
                }
                this.width = value;
            }
        }
        public double Height
        {
            get => this.height;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException($"{nameof(Height)} cannot be zero or negative.");
                }
                this.height = value;
            }
        }
        public double Volume()=> this.length * this.Width * this.Height;

        public double SurfaceArea() => 2 * (Length * Width + Width * Height + Height * Length);

        public double LateralArea() => 2 * Height * (Length + Width);
    }
}
