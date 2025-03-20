namespace insuranceApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //global variables
            int userChoice= 0;
            int deviceType = 0;
            int laptop = 1; int desktop = 2; int other = 3;
            int deviceAmount = 0;
            int devicesCost = 0;
            int finalDeviceInsurance = 0;
            double insuranceDiscount = 0.90;


            List<string> devices = new List<string>();

            Console.WriteLine("Enter Device Name");
            string deviceName = Console.ReadLine();

            Console.WriteLine("Choose your devices type");
            Console.WriteLine("1.Laptop");
            Console.WriteLine("2.Desktop");
            Console.WriteLine("3.Other");
            userChoice = Convert.ToInt32(Console.ReadLine());

            if (userChoice == 1)
                deviceType = laptop;

            else if (userChoice == 2)
                deviceType = desktop;

            else if (userChoice == 3)
                deviceType = other;
            
           
            Console.WriteLine("How many of the device do you have");
            deviceAmount = int.Parse(Console.ReadLine());


            Console.WriteLine("Enter the cost of device");
            devicesCost = Convert.ToInt32(Console.ReadLine());



            if (deviceAmount > 5)

                finalDeviceInsurance = deviceAmount * devicesCost;

            else
                finalDeviceInsurance = (int)((deviceAmount - 5) * (devicesCost * insuranceDiscount));
                finalDeviceInsurance += devicesCost * 5;
                


            Console.WriteLine($"Device name is {deviceName}");
            Console.WriteLine($"Device type is {deviceType}");
            Console.WriteLine($"Device Amount is {deviceAmount}");
            Console.WriteLine($"Cost per amount of device is ${devicesCost}");
            Console.WriteLine($"Cost of device iusrance is ${finalDeviceInsurance}");










        }

    }
}
