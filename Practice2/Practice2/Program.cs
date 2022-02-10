class FeetToCentimeter
{
    static void Main ()
    {
        //declare variables
        int feet = 5;
        int inches = 10;
        double centimeter;

        // 1 inch = 2.54 Centimeter
        const double CentermeterConversion = 2.54;

        //Convert feet into inches
        int heightInInches = (feet * 12 ) + inches;

        // Convert inches to centimeter
        centimeter = heightInInches * CentermeterConversion;

        // Display output
        System.Console.Write ("Conversion from 5 feet 10 inches into centermeter is: ");
        System.Console.Write(centimeter);
        System.Console.Write(" cm");
        System.Console.ReadKey();

        
    }
}
