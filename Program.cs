namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Введите первую дату в формате dd.MM.yyyy:");
            DateTime date1 = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", null);

            Console.WriteLine("Введите вторую дату в формате dd.MM.yyyy:");
            DateTime date2 = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", null);

            TimeSpan daysDifference = date2 - date1;
            Console.WriteLine($"Разница между датами: {daysDifference.TotalDays} дней");

            
            DateTime today = DateTime.Today;
            DateTime lastDayOfMonth = new DateTime(today.Year, today.Month, DateTime.DaysInMonth(today.Year, today.Month));
            TimeSpan daysUntilEndOfMonth = lastDayOfMonth - today;
            Console.WriteLine($"Дней до конца месяца: {daysUntilEndOfMonth.Days} дней");

            
            Console.WriteLine("Введите дату рождения в формате dd.MM.yyyy:");
            DateTime birthday = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", null) ;
           
            Console.WriteLine($"a) День недели рождения: {birthday.ToString("dddd")}");

            
            int dayOfYear = birthday.DayOfYear;
            Console.WriteLine($"b) Порядковый номер дня в году: {dayOfYear}");

            bool isLeapYear = DateTime.IsLeapYear(birthday.Year);
            Console.WriteLine($"c) Год рождения високосный: {isLeapYear}");

            
            DateTime nextBirthday = new DateTime(today.Year, birthday.Month, birthday.Day);
            if (today > nextBirthday)
            {
                nextBirthday = nextBirthday.AddYears(1);
            }
            Console.WriteLine($"d) Ближайшее день рождения: {nextBirthday.ToString("dddd, dd MMMM yyyy")}");

            
            int age = today.Year - birthday.Year;
            if (today < birthday.AddYears(age))
            {
                age--;
            }
            Console.WriteLine($"e) Возраст: {age} лет");

            
            TimeSpan daysUntilNextBirthday = nextBirthday - today;
            Console.WriteLine($"f) Дней до ближайшего дня рождения: {daysUntilNextBirthday.Days} дней");
            Console.ReadKey();  
        }
    }
}
    
