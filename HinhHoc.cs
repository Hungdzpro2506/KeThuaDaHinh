using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class HinhHoc
    {
        static void Main(string[] args)
        {
            Shape shape = new Shape();
            Console.WriteLine(shape);
            shape = new Shape("red",false);
            Console.WriteLine(shape);
            Console.WriteLine("******************");
            Circle circle = new Circle();
            Console.WriteLine(circle);
            circle = new Circle(3.0);
            Console.WriteLine(circle);
            circle = new Circle("blue",true,2.0) ;
            Console.WriteLine(circle);
            Console.WriteLine("******************");
            Rectangle rectangle = new Rectangle();
            Console.WriteLine(rectangle);
            rectangle = new Rectangle(4.0,7.0);
            Console.WriteLine(rectangle);
            rectangle = new Rectangle("red",false,5.0,4.0);
            Console.WriteLine(rectangle);
            Console.WriteLine("******************");
            Square square = new Square();
            Console.WriteLine(square);
            square = new Square(4.5);
            Console.WriteLine(square);
            square = new Square("yellow", false, 4.0);
            Console.WriteLine(square);
            Console.WriteLine("******************");



        }
    }
    public class Shape
    {
        private String color = "green";
        private bool filled = true;
        public Shape() { }
        public Shape(String color,bool filled) {
        this.color = color;
        this.filled = filled;}

        public string GetColor()
        {
            return color;
        }
        public void SetColor(String color)
        {
            this.color = color;
        }
        public bool IsFilled() { return this.filled;}
        public void SetFilled(bool filled) {  this.filled = filled;}

        public override string ToString()
        {
            return "A Shape with color of "+ GetColor()+" and "+(IsFilled()?"filled":"not filled");
        }
        

    }
    public class Circle : Shape
    {
        private double radius = 1.0;
        public Circle() { }
        public Circle(double radius)
        {
            this.radius = radius;
        }

        public Circle(string color,bool filled,double radius):base(color,filled) {
        this.radius = radius;}
        public double GetRadius() { return radius;}
        public void SetRadius(double radius) { this.radius = radius; }
        public double GetChuVi()
        {
            return 2*radius*Math.PI;
        }
        public double GetDienTich()
        {
            return radius*radius*Math.PI;
        }
        public override string ToString()
        {
            return "A Circle with radius = " + GetRadius() + " La 1 lop con cua " +base.ToString();
        }


    }
    public class Rectangle : Shape
    {
        private double width = 1.0;
        private double height = 1.0;
        public Rectangle() { }
        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public Rectangle(string color, bool filled, double width, double height) : base(color, filled)
        {
            this.width = width;
            this.height = height;
        }
        public double GetWidth()
        {
            return width;
        }
        public virtual void SetWidth(double width) { this.width = width; }
        public double GetHeight()
        {
            return height;
        }
        public virtual void SetHeight(double height) { this.height = height; }
        public double GetChuVi()
        {
            return (width + height) * 2;
        }
        public double GetDienTic()
        {
            return width * height;
        }
        public override string ToString()
        {
            return "A Rectangle with width= " + GetWidth() 
                + " and height: " + GetHeight() 
                +"la lop con cua: "+ base.ToString();
        }


    }
    public class Square : Rectangle
    {
        public Square() { }
        public Square(double side):base(side, side) { }
        public Square( string color, bool filled, double side) :base(color,filled,side,side) { }
        public double GetSide()
        {
            return GetWidth();
        }
        public void SetSide(double side)
        {
            SetHeight(side);
            SetWidth(side);
            
        }
        public override void SetWidth(double width) { SetSide(width); }
        public override void SetHeight(double height)

        {

            SetSide(height);

        }

        public override string ToString()
        {
            return "A Square with side= "+GetSide()+" la lop con cua: "+base.ToString();
        }
    }
}
