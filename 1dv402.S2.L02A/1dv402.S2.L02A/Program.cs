using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1dv402.S2.L02A
{
    class Program
    {
        static void Main(string[] args)
        {
           
            //Skriv ut ledtext
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" ╔═══════════════════════════════════════╗ ");
            Console.WriteLine(" ║             Väckarklockan             ║ ");
            Console.WriteLine(" ║                 VAKNA                 ║ ");
            Console.WriteLine(" ╚═══════════════════════════════════════╝ ");
            Console.ResetColor();

            //Initiera objektet ac
            AlarmClock ac = new AlarmClock();


            //Test 1: Test av standardkonstruktorn
            Console.WriteLine("═════════════════════════════════════════");
            AlarmClock testClock = new AlarmClock();
            ViewTestHeader("/nTest 1. /nTest av standardkonstruktorn");
            string time = testClock.ToString();
            Console.WriteLine(time);

            //Test 2. Test av konstruktorn med två parametrar
            Console.WriteLine("═════════════════════════════════════════");
            testClock = new AlarmClock(9, 42);
            ViewTestHeader("/nTest 2. /nTest av konstruktorn med två parametrar (9, 42)");
            time = testClock.ToString();
            Console.WriteLine(time);

            //Test 3. Test av konstruktorn med fyra parametrar
            Console.WriteLine("═════════════════════════════════════════");
            testClock = new AlarmClock(13, 24, 7, 35);
            ViewTestHeader("/nTest 3. /nTest av konstruktorn med fyra parametrar (13, 24, 7, 35)");
            time = testClock.ToString();
            Console.WriteLine(time);

            //Test 4. Test av metoden TickTock()
            Console.WriteLine("═════════════════════════════════════════");
            testClock = new AlarmClock(23, 58, 7, 35);
            ViewTestHeader("/nTest 4. /nTest av metoden TickTock(). Ställer befintligt AlarmClock-objekt till 23:58 och låter den gå 13 minuter.");
            Run(testClock, 13);

            //Test 5. Testar alarmfunktionen
            Console.WriteLine("═════════════════════════════════════════");
            testClock = new AlarmClock(6, 12, 6, 15);
            ViewTestHeader("/nTest 5. /nStäller tiden till 6:12 och alarmet till 6:15 och låter tiden gå 6 minuter");
            Run(testClock, 6);

            //Test 6. Test av egenskaperna så att undantag kastas då tid och alarmtid tilldelats felaktiga värden
            Console.WriteLine("═════════════════════════════════════════");
            testClock = new AlarmClock(24, 70, 24, 70);
            ViewTestHeader("/nTest 6. /nTestar egenskaperna så att undantag kastas då tid och alarmtid tilldelas felaktiga värden");
            ViewErrorMessage();

            //Test 7. Test av konstruktorer så att undantag kastas då tid och alarmtid tilldelas felaktiga värden.
            Console.WriteLine("═════════════════════════════════════════");
            testClock = new AlarmClock(24, 70, 24, 70);
            ViewTestHeader("/nTest 1. /nTestar konstruktorerna så att undantag kastas då tid och alarmtid tilldelas felaktiga värden");
            ViewErrorMessage();
        }
        
        private static void Run(AlarmClock ac, int minutes)
        {
            for (int i = 0; i < minutes; i++)
            {
                if (ac.TickTock() == true)
                {
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.WriteLine(ac.ToString() + "BEEP! BEEP! BEEP! BEEP!");
                    Console.ResetColor();
                }

                else
                {
                    Console.WriteLine(ac.ToString());
                }
            }
        }

        private static void ViewErrorMessage(string message)
        { 
        }

        private static void ViewTestHeader(string header)
        {
            Console.WriteLine(header);
        }
    }
}
