namespace Constructor
{

    public class Car : Vehicle // when call car will call Vehicle first
    {
        public Car(string registrationNumber) // vehicle will initial first due to inhertance

            : base(registrationNumber)
        {
            Console.WriteLine("Car is been initialized. {0}", registrationNumber); // init this second
        }
    }

    public class Vehicle
    {
        private readonly string _registrationNumber;

        //        public Vehicle() // first constructor: defult, perm less
        //        {
        //            Console.WriteLine("Vehicle is been initialized."); // init this first
        //        }

        // second overriding constructor
        public Vehicle(string registrationNumber)
        {
            _registrationNumber = registrationNumber;
            Console.WriteLine("vehicle is being initialized, {0}", registrationNumber);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var car = new Car("asdasd");

        }
    }
}