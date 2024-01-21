namespace Section_5._1___Class_intro
{
    internal class Car
    {
        // constructor - shortcut (ctor)
        // En constructor kaldes automatisk når et objekt af samme type som class istancieres
        public Car()
        {
            Console.WriteLine("Car was created");
        }

        // access modifier angives til public, så den kan tilgåes udefra class
        public void Drive()
        {
            Console.WriteLine("Car is driving");
        }

        public void Stop()
        {
            Console.WriteLine("Car Stopped!");
        }
    }
}
