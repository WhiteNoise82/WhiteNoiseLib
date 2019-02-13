using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WhiteNoise.Tools;
using WhiteNoise.Extensions;

namespace WhiteNoiseTest
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 
            //int sum = MathStd.Sum(1, 2, 3, 4, 5, 6, 7, 8, 9, 10); // Math.Sum(쉽표(,)로 구분된 수를 나열)
            //Console.WriteLine(sum);
            #endregion

            #region MathStdEx
            //int x = 20;
            //int y = 3;

            //Console.WriteLine($"x: {x}, y: {y}");

            //MathStd.Swap(ref x, ref y);
            //Console.WriteLine("x: {0}, y: {1}", x, y);

            //MathStd.Devide(num2:x, num1:y, quotient:out int quotient, reminder:out int reminder);
            //Console.WriteLine("quotient: {0}, reminder: {1}", quotient, reminder);

            //MathStd.Devide(x, y, out quotient, out reminder);
            //Console.WriteLine("quotient: {0}, reminder: {1}", quotient, reminder);
            #endregion

            #region MailManagerEx
            //string contents = "Hello there, <br />This is OH SOUNG.<br />This is a test email";

            #region Static Method
            //EmailManager.Send("receiver@test.com", "Hi...", contents);

            //EmailManager.Send("crystals8960@gmail.com", "crystals8960@gmail.com", "Hi...", contents);

            //EmailManager.Send("from@test.com", "receiver@test.com", "Hi...", contents, "cc@test.com", "bcc@test.com");
            #endregion

            //EmailManager email = new EmailManager("smtp.gmail.com", 587, "crystals8960@gmail.com", "Ohsoung6450!");
            //email.To.Clear();
            //email.From = "crystals8960@gmail.com";
            //email.To.Add("crystals8960@gmail.com");
            //email.Subject = "Test Email";
            //email.Body = contents;
            //email.Send();

            //email.To.Add("receiver2@test.com");
            //email.Subject = "Hi Kwon";
            //email.Send();
            #endregion

            #region StringExtensionsEx
            //string temp = "12/8/2015 10:10";

            //Console.WriteLine(temp.IsNumeric());
            //Console.WriteLine(temp.IsDateTime());            
            #endregion

            #region LogManagerEx
            //LogManager log = new LogManager(null, "_WhiteNoiseTest");

            //log.WriteLine("[Begin Processing]-----");

            //for (int i = 0; i < 10; i++)
            //{
            //    log.WriteLine("Processing: " + i);
            //    log.WriteConsole("test" + Environment.NewLine);

            //    System.Threading.Thread.Sleep(500);

            //    log.WriteLine("Done: " + i);
            //}

            //log.WriteLine("[End Processing]-----");
            #endregion

            #region ProcessLoggerEx
            ClimateMonitor monitor = new ClimateMonitor(new FileLogger("MyLog.txt"));

            int i = 0;
            while (true)
            {
                Console.Write("온도를 올려주세요.");
                string temperature = Console.ReadLine();
                if (temperature == "")
                    break;

                monitor.LogStart("현재온도:", i, temperature);
                i++;
            }
            #endregion

            #region ReadProgramDirectory
            //Console.WriteLine(AppRoot.Root);
            //Console.ReadLine();
            #endregion
        }
    }

    //public static class ExtensionTest
    //{
    //    public static void WriteConsole(this LogManager log, string data)
    //    {
    //        log.Write(data);
    //        Console.Write(data);
    //    }
    //}
}
