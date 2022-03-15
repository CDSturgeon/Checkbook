using System;
namespace CheckbookRegister.Misc
{
    public class Validation
    {
        public static DateOnly Date(string input)
        {
            while (true)
            {
                if (String.IsNullOrEmpty(input))
                    return DateOnly.FromDateTime(DateTime.Now);
                else if (DateOnly.TryParse(input, out DateOnly date))
                    return date;
                else
                {
                    Console.WriteLine("Invalid entry. Try again. mm/dd/yyy\n=> ");
                    input = Console.ReadLine();
                }
            }
        }
    }
}

