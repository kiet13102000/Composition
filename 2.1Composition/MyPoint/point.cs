using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPoint
{
    class point
    {
        private int x = 0;
        private int y = 0;

        public point()
        {
            this.x = this.y = 0;
        }
        public point(int x , int y)
        {
            this.x = x;
            this.y = y;
        }
        public int getX()
        {
            return x;
        }
        public int getY()
        {
            return y;
        }
        public void setX(int x)
        {
            this.x = x;
        }
        public void setY(int y)
        {
            this.y = y;
        }
        public int[] getXY()
        {
            int[] xy = new int[2];
            xy[0] = this.x;
            xy[1] = this.y;
            return xy;
            //or return new int[] {this.x , this.y};
        }
        public void setxy(int x , int y)
        {
            this.x = x;
            this.y = y;
        }
        public override string ToString()
        {
            return String.Format("({0},{1}", this.x, this.y);
        }
        public double distance( int x , int y)
        {
            return Math.Sqrt(Math.Pow(this.x - x, 2) + Math.Pow(this.y = y, 2));
        }

        public double distance (point point)
        {
            return distance(point.getX(), point.getY());
        }
        public  double distance()
        {
            return distance(0, 0);
        }
    }
}
