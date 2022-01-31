using System;
using System.Collections;

namespace CompareDates
{
    public class Validation
    {
        public bool IsValid(string DateString)
        {
            const int MaxNoOfDays = 31;
            const int MaxNoOfMonths = 12;
            if(DateString.Length != 8) return false;
            for(int i = 0; i < DateString.Length; i++)
            {
                if(!Char.IsNumber(DateString[i])) return false;
            }
            int Day = int.Parse(DateString.Substring(0, 2));
            int Month = int.Parse(DateString.Substring(2, 2));
            int Year = int.Parse(DateString.Substring(4));
            if(Day > MaxNoOfDays) return false;
            if(Month > MaxNoOfMonths) return false;
            return true;
        }
    }

    public class Comparision
    {
        static string[] Months = new string[12] { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };
        public string CompareDates(string Date1, string Date2)
        {
            int[] Date1Details = new int[3]; // array to store details of Date1 like arr[0] = Day, arr[1] = month, arr[2] = year;
            Date1Details = GetDetails(Date1);
            int[] Date2Details = new int[3];
            Date2Details = GetDetails(Date2); // array to store details of Date2 like arr[0] = Day, arr[1] = month, arr[2] = year;
            string Date2IsEarlierMsg = $"Date : {Date2Details[0]}-{Months[Date2Details[1]-1]}-{Date2Details[2]} is earlier than Date :  {Date1Details[0]}-{Months[Date1Details[1]-1]}-{Date1Details[2]}";
            string Date1IsEarlierMsg = $"Date : {Date1Details[0]}-{Months[Date1Details[1]-1]}-{Date1Details[2]} is earlier than Date : {Date2Details[0]}-{Months[Date2Details[1]-1]}-{Date2Details[2]}";

            if (Date1Details[2] > Date2Details[2])
            {
                return Date2IsEarlierMsg;
            }
            else if (Date1Details[2] < Date2Details[2])
            {
                return Date1IsEarlierMsg;
            }
            else if (Date1Details[1] > Date2Details[1])
            {
                return Date2IsEarlierMsg;
            }
            else if (Date1Details[1] < Date2Details[1])
            {
                return Date1IsEarlierMsg;
            }
            else if (Date1Details[1] > Date2Details[1])
            {
                return Date2IsEarlierMsg;
            }
            else if (Date1Details[1] < Date2Details[1])
            {
                return Date1IsEarlierMsg;
            }
            else
            {
                return $"Date : {Date1Details[0]}-{Months[Date1Details[1]-1]}-{Date1Details[2]} And Date : {Date2Details[0]}-{Months[Date2Details[1]-1]}-{Date2Details[2]} Both are same";
            }
        }

        private int[] GetDetails(string DateString)
        {
            int[] details = new int[3]; // details array is to store the day, month, and year to return deatils of date string  
            int Day = int.Parse(DateString.Substring(0, 2));
            int Month = int.Parse(DateString.Substring(2, 2));
            int Year = int.Parse(DateString.Substring(4));
            details[0] = Day;
            details[1] = Month;
            details[2] = Year;
            return details;
        }
    } 

    public class program
    {
        public static void Main(String[] args)
        {
            Validation validation= new Validation();
            string Date1, Date2;
            while (true)
            {
                Console.WriteLine("Enter first date in format like DDMMYYYY : ");
                Date1 = Console.ReadLine();
                if (validation.IsValid(Date1))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("You have entered the Date in wrong format plz enter in a correct format :-");
                }
            }
            while (true)
            {                 
                Console.WriteLine("Enter Second date in format like DDMMYYYY : ");
                Date2 = Console.ReadLine();
                if (validation.IsValid(Date2))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("You have entered the Date in wrong format plz enter in a correct format :-");
                }
            }
            Comparision comparision = new Comparision();
            string msg = comparision.CompareDates(Date1, Date2);
            Console.WriteLine(msg);
        }
    }
}