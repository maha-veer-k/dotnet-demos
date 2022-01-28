using System;
using System.Collections;

namespace CompareDates
{
    public class Validation
    {
        public bool IsValid(string str)
        {
            if(str.Length != 8) return false;
            for(int i = 0; i < str.Length; i++)
            {
                if(!Char.IsNumber(str[i])) return false;
            }
            int Day = int.Parse(str.Substring(0, 2));
            int Month = int.Parse(str.Substring(2, 2));
            int Year = int.Parse(str.Substring(4));
            if(Day > 31) return false;
            if(Month > 12) return false;
            return true;
        }
    }

    public class Compare
    {
        string[] Months = new string[12] { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };
        public string CompareDates(string Date1, string Date2)
        {
            int[] date1_details = new int[3];
            date1_details = GetDetails(Date1);
            int[] date2_details = new int[3];
            date2_details = GetDetails(Date2);
            string Msg1 = $"Date : {date2_details[0]}-{Months[date2_details[1]]}-{date2_details[2]} is earlier than Date :  {date1_details[0]}-{Months[date1_details[1]]}-{date1_details[2]}";
            string Msg2 = $"Date : {date1_details[0]}-{Months[date1_details[1]]}-{date1_details[2]} is earlier than Date : {date2_details[0]}-{Months[date2_details[1]]}-{date2_details[2]}";

            if (date1_details[2] > date2_details[2])
            {
                return Msg1;
            }
            else if (date1_details[2] < date2_details[2])
            {
                return Msg2;
            }
            else if (date1_details[1] > date2_details[1])
            {
                return Msg1;
            }
            else if (date1_details[1] < date2_details[1])
            {
                return Msg2;
            }
            else if (date1_details[1] > date2_details[1])
            {
                return Msg1;
            }
            else if (date1_details[1] < date2_details[1])
            {
                return Msg2;
            }
            else
            {
                return $"Date : {date1_details[0]}-{Months[date1_details[1]]}-{date1_details[2]} And Date : {date2_details[0]}-{Months[date2_details[1]]}-{date2_details[2]} Both are same";
            }
        }

        public int[] GetDetails(string str)
        {
            int[] details = new int[3];
            int Day = int.Parse(str.Substring(0, 2));
            int Month = int.Parse(str.Substring(2, 2));
            int Year = int.Parse(str.Substring(4));
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
            bool flag;
            string Date1, Date2;
            while (true)
            {
                Console.WriteLine("Enter first date  : ");
                Date1 = Console.ReadLine();
                flag = validation.IsValid(Date1);
                if (flag) break; 
            }
            while (true)
            {                 
                Console.WriteLine("Enter Second date : ");
                Date2 = Console.ReadLine();
                flag = validation.IsValid(Date2);
                if (flag) break;
            }
            Compare compare = new Compare();
            string msg = compare.CompareDates(Date1, Date2);
            Console.WriteLine(msg);
        }
    }
}