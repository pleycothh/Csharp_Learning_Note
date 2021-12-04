using System;
using System.Collections.Generic;

namespace Overriding
{
    public class Circle : Shape
    {
        public override void Draw()
        {

            //base.Draw(); // reference to parent class

            Console.WriteLine("Draw an circle");
        }
    }

    //------------------------- solution above ------------------
    public class Shape // parent class, suber class
    {
        public int Width { get; set; }
        public int Height { get; set; }
        //public ShapeType Type { get; set; }



        public virtual void Draw()
        {
            // default implementation
            Console.WriteLine("Draw a shape");
        }
    }

    /*
    public enum ShapeType
    {
        Circle, Rectangle
    }
    */

    public class Canvas
    {
        public void DrawShape(List<Shape> shapes) // list of Shape object
        {
            foreach (var shape in shapes) // for each object in list of Shape are: child classes
            {
                shape.Draw(); // see note
            }
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            var shapes = new List<Shape>();
            //shapes.Add(new Shape { Width = 100, Height = 100, Type = ShapeType.Circle });
            shapes.Add(new Circle()); // add new child class in shapes

            var canvas = new Canvas();
            canvas.DrawShape(shapes); // for each shape in shapes, draw shape
        }
    }
}


/* Note:
 * 
 The parent class Shape has many child class.
when I call list of Shape, it means list of child class of shape.
so child class can be act as direvtive.

hence, when I call method in parent class, it run as defult method.
However, When I run list of parent class, for each child class, it run override class.

I am still calling the Draw class, from child class from parent class.

every child class has the method of the same name which is from parent virtual method.

To sum up, by using polimorphisim, create new shape, can be done by simply create new class.
This action have no impact to Shape class, Canvas Class, etc. = loss coupling applicaition
 */