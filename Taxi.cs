class Taxi
{
	static void Main(String[] args)
	{
		   Taxi taxi = new()
   

            taxi.DriveName = "Jono";
            taxi.OnDuty = true;
            taxi.NumPassenger = 10;

            taxi.TaxiInfo();
            taxi.PickUpPassenger();
            taxi.DropOffPassenger();

            Console.ReadKey();
	}
}