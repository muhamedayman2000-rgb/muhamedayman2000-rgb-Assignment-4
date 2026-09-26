using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Running;
using BenchmarkDotNet.Toolchains.InProcess.Emit;
using Perfolizer.Horology;
using System.Globalization;
using System.Text;
using System.Threading.Channels;
namespace assignment_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] sessionNames =
            {
                 "C# Basics",
                 "Arrays",
                 "Functions",
                 "Date and Time",
                 "Exception Handling",
              
            };
            DateTime[] sessionDates =
            {
                  new DateTime(2026, 9, 10, 18, 0, 0),
                  new DateTime(2026, 9, 13, 18, 0, 0),
                  new DateTime(2026, 9, 17, 18, 0, 0),
                  new DateTime(2026, 9, 20, 18, 0, 0),
                  new DateTime(2026, 9, 24, 18, 0, 0),
               
            };
            int[] sessionDurations =
              {
                   180,
                   240,
                   180,
                   240,
                   180
            };
            #region Part 02
            //DisplaySessions(sessionNames, sessionDates, sessionDurations); 
            #endregion

            #region Part 03
            //Console.WriteLine("Enter the session name to view details:");
            //string? userInput = Console.ReadLine();
            //int index = SearchForSession(sessionNames, userInput);
            //Console.WriteLine(index);
            //if (index != -1)
            //{
            //    DisplaySessions(index, sessionNames, sessionDates, sessionDurations);
            //}
            //else
            //{
            //    Console.WriteLine("Session not found.");
            //}
            #endregion

            #region Part 04
            string[] sessionNamesCopy = new string[sessionNames.Length];


            //4.1
            //Array.Copy(sessionNames, sessionNamesCopy, sessionNames.Length);
            //Array.Sort(sessionNamesCopy);
            //foreach (var session in sessionNamesCopy)
            //{
            //    Console.WriteLine(session);
            //}

            //4.2
            //Array.Copy(sessionNames, sessionNamesCopy, sessionNames.Length);
            //Array.Reverse(sessionNamesCopy);
            //foreach (var session in sessionNamesCopy)
            //{
            //    Console.WriteLine(session);
            //}

            //4.3
            //Console.Write("Enter session name: ");
            //string? sessionName = Console.ReadLine();
            //Console.WriteLine($"Index: {SearchForSession(sessionNames, sessionName)}");

            //4.4
            //Console.Write("Enter session name: ");
            //string? sessionName = Console.ReadLine();
            //if(string.IsNullOrEmpty(sessionName))
            //{
            //    Console.WriteLine("Please enter a valid session name.");
            //}
            //else if (Array.Exists(sessionNames, name => string.Equals(name, sessionName, StringComparison.OrdinalIgnoreCase)))
            //{
            //    Console.WriteLine($"Session exists.");
            //}
            //else
            //{
            //    Console.WriteLine("Session does not exist.");
            //}

            //4.5
            //Console.WriteLine( Array.Find(sessionNames, name => (name.Length > 10)));

            //4.6
            //Console.WriteLine(Array.FindIndex(sessionNames, name => name.Length > 10));

            //4.7
            //Array.Copy(sessionNames, sessionNamesCopy, sessionNames.Length);
            //sessionNamesCopy[0] = "OOP";
            //Console.WriteLine("Original Array:");
            //foreach (var session1 in sessionNames)
            //{
            //    Console.WriteLine(session1);
            //}
            //Console.WriteLine("---------------------------------");
            //Console.WriteLine("Modified Array:");
            //foreach (var session in sessionNamesCopy)
            //{
            //    Console.WriteLine(session);
            //} 
            #endregion

            #region Part 05
            //Console.WriteLine($"Total Duration: {GetTotalDuration(sessionDurations)} minutes");
            //Console.WriteLine($"Average Duration: {GetAverageDuration(sessionDurations)} minutes");
            //Console.WriteLine($"Shortest Duration: {GetShortestDuration(sessionDurations)} minutes");
            //Console.WriteLine($"Longest Duration: {GetLongestDuration(sessionDurations)} minutes");

            //int[] sessionDurationsCopy = new int[sessionDurations.Length];
            //Array.Copy(sessionDurations, sessionDurationsCopy, sessionDurations.Length);
            //Array.Sort(sessionDurationsCopy);
            //foreach (int duration in sessionDurationsCopy)
            //{
            //    Console.WriteLine(duration);
            //} 
            #endregion

            #region Part 07 
            //7.1
            //int number = 15;
            //Console.WriteLine("Before calling the function");
            //Console.WriteLine(number);
            //Console.WriteLine("After calling the function");
            //ChangeNumber(ref number);
            //Console.WriteLine(number);

            //7.2
            //int index;
            //int duration;
            //GetIndexAndDuration(sessionNames, sessionDates, sessionDurations, "arRaYs", out index, out duration);
            //Console.WriteLine($"Index: {index}");
            //Console.WriteLine($"Duration: {duration} minutes");

            //7.3
            //int[] numbers = { 5, 10, 15, 20, 25 };
            //ChangeNumberInArray(numbers);
            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //} 
            #endregion

            #region Part 08
            //Console.WriteLine(CalculateTotalDuration(120,180));
            //Console.WriteLine(CalculateTotalDuration(120,180,240));
            //Console.WriteLine(CalculateTotalDuration(60,90,120,180,240)); 
            #endregion

            #region Part 09
            //Console.Write("Enter session name: ");
            //string? sessionName = Console.ReadLine();
            //SessionDateDetails(sessionNames, sessionName, sessionDurations, sessionDates); 
            #endregion

            #region Part 10
            //string firstSessionName = "C# Basics";

            //string secondSessionName = "Arrays";

            //TimeSpan DateDifference = sessionDates[SearchForSession(sessionNames, secondSessionName)] - (sessionDates[SearchForSession(sessionNames, firstSessionName)]);
            //Console.WriteLine("Difference");
            //Console.WriteLine($"{DateDifference.Days} Days");
            //Console.WriteLine($"{DateDifference.TotalHours} Hours"); 
            #endregion

            #region Part 11
            //for (int i = 0; i < sessionDates.Length; i++)
            //{
            //    TimeSpan difference = sessionDates[i] - DateTime.Now;
            //    if (difference.TotalHours < 0)
            //        Console.WriteLine($"{sessionNames[i]} Past");
            //    else
            //        Console.WriteLine($"{sessionNames[i]} Upcoming");
            //} 


            #endregion

            #region Part 12
            //for (int i = 0; i < sessionDates.Length; i++)
            //{
            //    TimeSpan difference = sessionDates[i] - DateTime.Now;
            //    if (difference.TotalHours < 0)
            //        continue;
            //    else
            //        Console.WriteLine("Next Session:");
            //        Console.WriteLine(sessionNames[i]);
            //    Console.WriteLine($"{sessionDates[i].Date:dd MMMM yyyy}");
            //    Console.WriteLine(TimeOnly.FromDateTime(sessionDates[i]));
            //    break;
            //} 
            #endregion

            #region Part 13
            //Console.WriteLine($"{sessionDates[1].Date:yyyy-MM-dd}");
            //Console.WriteLine($"{sessionDates[1].Date:dd/MM/yyyy}");
            //Console.WriteLine($"{sessionDates[1].Date:dd MMMM yyyy}");
            //Console.WriteLine($"{sessionDates[1].Date:dddd, dd MMMM yyyy}");
            //Console.WriteLine(TimeOnly.FromDateTime(sessionDates[1])); 
            #endregion

            #region Part 14
            //bool isValidInput = DateTime.TryParseExact
            //    (
            //    Console.ReadLine(),
            //    "yyyy-MM-dd HH:mm",
            //     CultureInfo.InvariantCulture,
            //     DateTimeStyles.None,
            //    out DateTime parsedDate
            //    );
            //if (isValidInput)
            //{
            //    Console.WriteLine("hello");
            //    Console.WriteLine(parsedDate);
            //}
            //else
            //    Console.WriteLine("Invalid input. Please enter a valid date and time in the format 'yyyy-MM-dd HH:mm'."); 
            #endregion

            #region Part 15
            //ReadNumericInput(); 
            #endregion

            #region Part 16

            //try
            //{
            //    Console.Write("Enter session index: ");
            //    int Index = int.Parse(Console.ReadLine());
            //    Console.WriteLine($"Session: {sessionNames[Index]}");
            //}
            //catch (IndexOutOfRangeException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //} 
            #endregion

            #region Part 17
            //ValidDurationInput(); 
            #endregion

            #region Part 18
            //ValidDurationInputWithFinally(); 
            #endregion

            #region Part 19
            //string report = StringConcatenation(sessionNames, sessionDates, sessionDurations);
            //Console.WriteLine(report); 
            #endregion

            #region Part 20
            //string report= StringBuilderConcatenation(sessionNames, sessionDates, sessionDurations);
            //Console.WriteLine(report); 
            #endregion

            #region Part 20
            // BenchmarkRunner.Run<ScheduleBenchmark>(); 
            #endregion

            #region Part 22&23&24

            // var config = ManualConfig.Create(DefaultConfig.Instance)
            //.AddJob(BenchmarkDotNet.Jobs.Job.Default
            //    .WithToolchain(InProcessEmitToolchain.Instance));

            // BenchmarkRunner.Run<ScheduleBenchmark>(config); 
            #endregion


            //Console.Write("First session : ");
            //string? firstSessionName = Console.ReadLine();
            //Console.Write("Second session : ");
            //string? secondSessionName = Console.ReadLine();
            //DateDifference(sessionNames, sessionDates, firstSessionName, secondSessionName);
        }

        public static void DisplaySessions(string[] sessionNames, DateTime[] sessionDates, int[] sessionDurations)
        {
            for (int i = 0; i < sessionNames.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {sessionNames[i]}");
                Console.WriteLine($"Date: {DateOnly.FromDateTime(sessionDates[i]):dd MMMM yyyy}");
                Console.WriteLine($"Start Time: {TimeOnly.FromDateTime(sessionDates[i])}");
                Console.WriteLine($"Session Duration: {sessionDurations[i]} minutes");
                Console.WriteLine();
            }


        }
        public static void DisplaySessions(int index, string[] sessionNames, DateTime[] sessionDates, int[] sessionDurations)
        {
            Console.WriteLine($"{index + 1}. {sessionNames[index]}");
            Console.WriteLine($"Date: {DateOnly.FromDateTime(sessionDates[index]):dd MMMM yyyy}");
            Console.WriteLine($"Start Time: {TimeOnly.FromDateTime(sessionDates[index])}");
            Console.WriteLine($"Session Duration: {sessionDurations[index]} minutes");
            Console.WriteLine();
        }
        public static int SearchForSession(string[] sessionNames, string sessionName)
        {
            if (string.IsNullOrEmpty(sessionName))
                return -1;
            return Array.FindIndex(sessionNames, name => string.Equals(name, sessionName, StringComparison.OrdinalIgnoreCase));
        }
        public static int GetTotalDuration(int[] sessionDurations)
        {
            int total = 0;
            foreach (int duration in sessionDurations)
            {
                total += duration;
            }
            return total;
        }
        public static int GetAverageDuration(int[] sessionDurations)
        {
            if (sessionDurations.Length <= 0)
                return 0;

            int total = GetTotalDuration(sessionDurations);
            return total / sessionDurations.Length;
        }
        public static int GetShortestDuration(int[] sessionDurations)
        {
            if (sessionDurations.Length <= 0)
                return 0;
            int shortest = sessionDurations[0];
            for (int i = 0; i < sessionDurations.Length; i++)
            {
                if (sessionDurations[i] < shortest)
                    shortest = sessionDurations[i];
            }
            return shortest;
        }
        public static int GetLongestDuration(int[] sessionDurations)
        {
            if (sessionDurations.Length <= 0)
                return 0;
            int longest = sessionDurations[0];
            for (int i = 0; i < sessionDurations.Length; i++)
            {
                if (sessionDurations[i] > longest)
                    longest = sessionDurations[i];
            }
            return longest;
        }
        public static TimeOnly GetSessionEndTime(DateTime sessionDate, int sessionDuration)
        {
            return TimeOnly.FromDateTime(sessionDate.AddMinutes(sessionDuration));
        }
        public static void ChangeNumber(ref int number)
        {
            number = 20;
        }
        public static void GetIndexAndDuration(string[] sessionNames, DateTime[] sessionDates, int[] sessionDurations, string sessionName, out int index, out int duration)
        {

            if (string.IsNullOrWhiteSpace(sessionName))
            {
                index = -1;
                duration = 0;
                return;
            }

            index = Array.FindIndex(sessionNames, name => string.Equals(name, sessionName, StringComparison.OrdinalIgnoreCase));
            if (index >= 0)
            {
                duration = sessionDurations[index];
            }
            else
            {
                index = -1;
                duration = 0;
            }
        }
        public static void ChangeNumberInArray(int[] numbers)
        {
            numbers[0] = 100;
        }
        public static int CalculateTotalDuration(params int[] sessionDurations)
        {
            int total = 0;
            foreach (int duration in sessionDurations)
            {
                total += duration;
            }
            return total;
        }

        public static void SessionDateDetails(string[] sessionNames, string sessionName, int[] sessionDurations, DateTime[] sessionDates)
        {
            int index = SearchForSession(sessionNames, sessionName);
            if (index < 0)
                Console.WriteLine("Session not found.");

            Console.WriteLine($"Date: {sessionDates[index]:dd MMMM yyyy}");
            Console.WriteLine($"Day: {sessionDates[index].DayOfWeek}");
            Console.WriteLine($"Year: {sessionDates[index].Year}");
            Console.WriteLine($"Month: {sessionDates[index].Month}");
            Console.WriteLine($"Start Time: {TimeOnly.FromDateTime(sessionDates[index])}");
            Console.WriteLine($"Duration: {sessionDurations[index]} minutes");
            Console.WriteLine($"End Time: {GetSessionEndTime(sessionDates[index], sessionDurations[index])}");




        }

        public static void DateDifference(string[] sessionNames, DateTime[] sessionDates, string firstSessionName, string secondSessionName)
        {
            int indexOfFirstSession = SearchForSession(sessionNames, firstSessionName);
            int indexOfSecondSession = SearchForSession(sessionNames, secondSessionName);
            TimeSpan differenceInDays = sessionDates[indexOfSecondSession] - sessionDates[indexOfFirstSession];
            TimeSpan differenceInhours = sessionDates[indexOfSecondSession] - sessionDates[indexOfFirstSession];
            Console.WriteLine("Difference: ");
            Console.WriteLine($"{differenceInDays.Days} days");
            Console.WriteLine($"{differenceInhours.TotalHours} hours");

        }

        public static string StringConcatenation(string[] sessionNames, DateTime[] sessionDates, int[] sessionDurations)
        {
            string result = "";
            for (int i = 0; i < sessionNames.Length; i++)
            {
                result += $"{sessionNames[i]} - {sessionDates[i]:dd MMMM yyyy} - {TimeOnly.FromDateTime(sessionDates[i])} - {sessionDurations[i]} minutes\n";

            }
            return result;
        }
        public static string StringBuilderConcatenation(string[] sessionNames, DateTime[] sessionDates, int[] sessionDurations)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < sessionNames.Length; i++)
            {
                result.AppendLine($"{sessionNames[i]} - {sessionDates[i]:dd MMMM yyyy} - {TimeOnly.FromDateTime(sessionDates[i])} - {sessionDurations[i]} minutes");
            }
            return result.ToString();
        }

        public static void ReadNumericInput()
        {
            Console.Write("Choose an option: ");
            try
            {
                
                int? userInput = int.Parse(Console.ReadLine());

            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                ReadNumericInput();
            }
        }

        public static void ValidDurationInput()
        {
            Console.Write("Enter session duration: ");
            try
            {
                int? userInput = int.Parse(Console.ReadLine());
                if (userInput < 0)
                    throw new ArgumentOutOfRangeException("Duration cannot be negative.");
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                ValidDurationInput();
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("Duration must be greater than zero.");
                ValidDurationInput();
            }
        }

        public static void ValidDurationInputWithFinally()
        {
            Console.Write("Enter session duration: ");
            try
            {
                int? userInput = int.Parse(Console.ReadLine());
                if (userInput < 0)
                    throw new ArgumentOutOfRangeException("Duration cannot be negative.");
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                ValidDurationInputWithFinally();
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("Duration must be greater than zero.");
                ValidDurationInputWithFinally();
            }
            finally
            {
                Console.WriteLine("Input operation finished.");
            }
        }
    }
}
        

