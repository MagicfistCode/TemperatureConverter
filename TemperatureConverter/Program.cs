namespace TemperatureConverter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declaring temperature & result as decimal values
            decimal temperature, result;
            //making the user choice an int
            int choice;
            //data type checker boolean
            bool typeCheck;

            //a do-while loop to ensure the user enters a valid decimal value
            do
            {
                Console.WriteLine("Enter a Temperature Value:");
                typeCheck = decimal.TryParse(Console.ReadLine(), out temperature);

                if (!typeCheck)
                {
                    Console.WriteLine("Please enter a valid decimal value...");
                }

            } while (!typeCheck);

            //a do-while loop to ensure the user enters a valid integer value
            do
            {
                Console.WriteLine("Choose Conversion Option: \n" +
                "1) Fahrenheit -> Celsius \n" +
                "2) Celsius -> Fahrenheit \n" +
                "3) Fahrenheit -> Kelvin \n" +
                "4) Kelvin -> Fahrenheit \n" +
                "5) Kelvin -> Celsius \n" +
                "6) Celsius -> Kelvin");
                typeCheck = int.TryParse(Console.ReadLine(), out choice);

                if (!typeCheck)
                {
                    Console.WriteLine("Please enter a valid integer..");
                }

            } while (!typeCheck);

            //switch statement whereby each case is specific conversion
            switch (choice)
            {
                case 1:
                    result = (temperature - 32) * (5 / 9);
                    Console.WriteLine("The temperature is " + result + "°C");
                    break;

                case 2:
                    result = (temperature * (9 / 5)) + 32;
                    Console.WriteLine("The temperature is " + result + "°F");
                    break;
                case 3:
                    result = (temperature - 32) * (5 / 9) + Convert.ToDecimal(273.15);
                    Console.WriteLine("The temperature is " + result + "°K");
                    break;
                case 4:
                    result = (temperature - Convert.ToDecimal(273.15)) * (9 / 5) + 32;
                    Console.WriteLine("The temperature is " + result + "°F");
                    break;
                case 5:
                    result = temperature - Convert.ToDecimal(273.15);
                    Console.WriteLine("The temperature is " + result + "°C");
                    break;
                case 6:
                    result = temperature + Convert.ToDecimal(273.15);
                    Console.WriteLine("The temperature is " + result + "°K");
                    break;
                //default statement is the system giving up...
                default:
                    Console.WriteLine("Man... that was NOT one of the options!");
                    break;
            }

            Console.ReadLine();
        }
    }
}