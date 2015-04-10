using System;

class NextDate
{
    static void Main()
    {
        string days = Console.ReadLine();
        string months = Console.ReadLine();
        string years = Console.ReadLine();
        switch (months)
        {
            case "1": months = "Jan"; break;
            case "2": months = "Feb"; break;
            case "3": months = "March"; break;
            case "4": months = "Apr"; break;
            case "5": months = "May"; break;
            case "6": months = "June"; break;
            case "7": months = "July"; break;
            case "8": months = "August"; break;
            case "9": months = "September"; break;
            case "10": months = "October"; break;
            case "11": months = "Nov"; break;
            case "12": months = "Dec"; break;
            default:
                break;
        }
        DateTime theDate = DateTime.Parse(days + months + years);
        theDate = theDate.AddDays(1);

        Console.WriteLine("{0}.{1}.{2}", theDate.Day, theDate.Month, theDate.Year);

    }
}