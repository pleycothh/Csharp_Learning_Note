using System.Collections;

namespace Boxing
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new ArrayList();

            list.Add(1); // boxing
            list.Add("asdasd"); // no boxing
            list.Add(DateTime.Now); // value type, boxing happend

            var number = (int)list[1];

            var anotherList = new List<int>(); // gniraic list
            anotherList.Add(2); // integer only, type safely , no boxing, lis of integers not object

            var name = new List<string>(); // geniric list of string
            // list of stirng, and noboxing
            //type valuetype, boxing happend, performance panoty 







        }
    }
}
