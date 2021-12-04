/*
######### Abstract Modifier ############


 out to use out
*/

namespace Abstract
{
    public class Program
    {

        public abstract class Shape // abstract class required
        {
            public int Width { get; set; }
            public int Height { get; set; }
            

            // issiue: it is hard to define how to draw an shape !
            // because the consept of shape is too abstract.
            // bastract type means this method is missing implementation, and leave the derivate of this method to do the implementation
            public abstract void Draw(); // example of abstract method without implementation

            // Rule: abstract can not include implementation.
            // if member is declared as abstract, the containing class needs to be an abstract too
            // must include all abstract method
            // can not be instantiated
            
            public void Copy()
            {
                Console.WriteLine("Copy the shape");
            }
        }

        public class Circle: Shape
        {
            public override void Draw()
            {
                Console.WriteLine("Drawing a circle");
            }
        }

        public class Rectangle: Shape
        {
            // Error here!
        }

        // -------------------- Main Method ---------------------------
        static void Main(string[] args)
        {
            var shape = new Shape(); // abstract class can not be instanced!

            var circle = new Circle();
            circle.Draw();
            circle.Copy();

            var rectangle = new Rectangle();
            rectangle.Draw();

        }
    }
}