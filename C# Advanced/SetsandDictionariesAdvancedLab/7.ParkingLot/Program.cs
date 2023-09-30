namespace _7.ParkingLot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> carRegistration = new();
            string input;
            while ((input = Console.ReadLine()) != "END")
            {
                string command = input.Split(", ")[0];
                string regNumber = input.Split(", ")[1];

                if (command == "IN")
                {
                    carRegistration.Add(regNumber);
                }
                else if (command == "OUT")
                {
                    carRegistration.Remove(regNumber);
                }
            }

            if (carRegistration.Count > 0)
            {
                foreach (var num in carRegistration)
                {
                    Console.WriteLine(num);
                }
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
        }
    }
}