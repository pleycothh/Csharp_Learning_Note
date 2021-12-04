using System;
using System.IO;

namespace Upcasting
{

    public class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        public void Drow()
        {

        }
    }

    public class Text : Shape
    {
        public int FontSize { get; set; }
        public string FontName { get; set; }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Shape shape = new Text();
            Text text = (Text)shape; // down cast
            text.FontName = "abs";

            /*
            Text text = new Text(); // assing text as Text object. which has Shape and Text
            Shape shape = text; //  assing shape object with text object, since text has shape, no convertion requried.

            text.Width = 200;
            shape.Width = 100;
            Console.WriteLine(text.Width);

            StreamReader reader = new StreamReader(new MemoryStream());

            ArrayList list = new ArrayList();
            list.Add("Mosh");

            */
        }
    }
}