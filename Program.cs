using System;

namespace Converter
{
    class Calculator //calculator class
    {
        public double centimetersToInches(double centimeters)  //function for calculating
        {
            return centimeters / 2.54; //returning calculation
        }

        public double inchesToCentimeteres(double centimeters) //function for calculating
        {
            return centimeters * 2.54; //returning calculation
        }

        public double gramsToOunces(double centimeters) //function for calculating
        {
            return centimeters / 28.35; //returning calculation
        }

        public double ouncesToGrams(double centimeters) //function for calculating
        { 
            return centimeters * 28.35; //returning calculation
        }

        public double litresToPints(double centimeters) //function for calculating
        {
            return centimeters * 1.76; //returning calculation
        }

        public double pintsToLitres(double centimeters) //function for calculating
        {
            return centimeters / 1.76; //returning calculation
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Initialise variables
                Double Choice = 0;
                Double InputNumber = 0;
                Double OutputNumber = 0;
                //Instructions
                Console.WriteLine("1. CM to INCH");
                Console.WriteLine("2. INCH to CM");
                Console.WriteLine("3. GRAMS to OUNCES");
                Console.WriteLine("4. OZ to G");
                Console.WriteLine("5. LITRES to PTS");
                Console.WriteLine("6. PTS to L");
                Console.WriteLine("Input your choice:");
                //More variables
                Choice = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Input the number to convert: ");
                InputNumber = Convert.ToDouble(Console.ReadLine());

                //new object calculator
                Calculator calc = new Calculator();

                switch (Choice) //switch statement for choices
                {
                    case 1://choice 1
                        OutputNumber = calc.centimetersToInches(InputNumber);
                        break;
                    case 2: //choice 2
                        OutputNumber = calc.inchesToCentimeteres(InputNumber);
                        break;
                    case 3: //choice 3
                        OutputNumber = calc.gramsToOunces(InputNumber);
                        break;
                    case 4: //choice 4
                        OutputNumber = calc.ouncesToGrams(InputNumber);
                        break;
                    case 5: //choice 5
                        OutputNumber = calc.litresToPints(InputNumber);
                        break;
                    case 6: //choice 6
                        OutputNumber = calc.pintsToLitres(InputNumber);
                        break;
                }

                Console.WriteLine("The answer is " + OutputNumber); //display answer

            }
            catch
            {
                Console.WriteLine("Something went wrong"); //Display error message
            }
        }
    }
}
