using System;
namespace InterfacesTask3
{
    class Vehicle
    {
        public string Name = "Загальний транспорт";
    }
    class Car : Vehicle
    {
        public string Model = "Легковий автомобіль";
    }
    interface IFactory<out T>
    {
        T Create();
    }
    class CarFactory : IFactory<Car>
    {
        public Car Create()
        {
            return new Car();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            IFactory<Vehicle> vehicleFactory = new CarFactory();
            Vehicle vehicle = vehicleFactory.Create();

            Console.WriteLine("Об'єкт створено: " + vehicle.Name);

            Console.ReadLine();
        }
    }
}
