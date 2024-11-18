namespace Assignment_3._1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine(IsLeapYear(2016)); 
            Console.WriteLine(IsLeapYear(2018));

		} 
        static bool IsLeapYear(int year) 
        {
            if (year % 4 == 0) 
            { 
                if (year % 100 == 0) 
                { 
                    if (year % 400 == 0) 
                    {
						return true; 
                    } 
                    return false;
                }
				Console.WriteLine("Is " + year + " a leap year?");
				return true;
            }
            Console.WriteLine("Is " + year + " a leap year?");
            return false;
           
		}
    }
}
