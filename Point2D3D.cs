using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Point2D3D
    {
        static void Main(string[] args)
        {
            Point2D point2D = new Point2D(2, 2);
            Console.WriteLine(point2D);
            Point3D point3D = new Point3D(2, 3, 5);
            Console.WriteLine(point3D);

        }
    }
    public class Point2D
    {
        private float x;
        private float y;
        public Point2D() { }
        public Point2D(float x, float y)
        {
            this.x = x;
            this.y = y;
        }
        public float getX()
        {
            return x;
        }
        public float getY()
        {
            return y;
        }
        public void setX(float x)
        {
            this.x = x;
        }
        public void setY(float y)
        {
            this.y = y;
        }
        public void setXY( float x,  float y)
        {
            this.x = x;
            this.y = y;
        }
        public float[] getXY()
        {
            return new float[] {this.x,this.y };
        }
        public override string ToString()
        {
            return"x,y: "+ $"{this.x},{this.y}";
        }

    }
    public class Point3D:Point2D
    {
        private float z;
        public Point3D() { }
        public Point3D(float x,float y, float z):base(x,y) {
        this.z = z;}
        public float getZ()
        {
            return z;
        }
        public void setZ(float z)
        {
            this.z = z;
        }
        public void setXYZ (float x,float y,float z)
        {
            setXY(x, y);
            this.z = z;
        }
        public float[] getXYZ()
        {
            return new float[] {getX(),getY(),getZ()};
        }
        public override string ToString()
        {
            return"x,y,z:" +$"{getX()},{getY()},{getZ()}";
        }
    }
    }

