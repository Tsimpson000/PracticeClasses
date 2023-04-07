namespace PracticeClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("Kia", "Rio", 2016, "Black", 81000);
            Bike bike = new Bike("Sledgehammer", "BMX", "Orange", 2);
            Musician musician = new Musician("Dave", "Tipper", 50000, "TipHop");

            Console.WriteLine($"Car - {car.Make}, {car.Model}, {car.Year}, {car.Color}, {car.Mileage}");
            Console.WriteLine($"Bike - {bike.Brand}, {bike.Type}, {bike.Color}, {bike.NumberOfWheels}");
            Console.WriteLine($"Musician - {musician.Name}, {musician.StageName}, {musician.BookingFee}, {musician.Genre}");
        }
    }
}