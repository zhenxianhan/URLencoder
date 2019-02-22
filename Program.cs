using System;
using System.Collections.Generic;

namespace URLEncoder
{
    class Program
    {


        static void Main(string[] args)
        {
            Console.WriteLine("URL Encoder");

            do
            {
                 
                Console.Write("\nProject name: ");
                string projectName = GetUserInput();
                Console.Write("Activity name: ");
                string activityName = GetUserInput();
                projectName = projectName.Replace(" ", "%20");
                projectName = projectName.Replace("<", "%3C");
                projectName = projectName.Replace(">", "%3E");
                projectName = projectName.Replace("#", "%24");
                projectName = projectName.Replace("\"", "%22");
                projectName = projectName.Replace("!", "%21");
                projectName = projectName.Replace("&", "%26");
                projectName = projectName.Replace("*", "%2A");
                projectName = projectName.Replace("+", "%2B");
                projectName = projectName.Replace("/", "%2F");
                projectName = projectName.Replace("-", "%2D");
                projectName = projectName.Replace("$", "%24");
                projectName = projectName.Replace("=", "%3D");
                projectName = projectName.Replace("?", "%3F");
                projectName = projectName.Replace("@", "%40");
                projectName = projectName.Replace(",", "%2C");
                projectName = projectName.Replace("[", "%5B");
                projectName = projectName.Replace("]", "%5D");
                activityName = activityName.Replace(" ", "%20");
                activityName = activityName.Replace("<", "%3C");
                activityName = activityName.Replace(">", "%3E");
                activityName = activityName.Replace("#", "%24");
                activityName = activityName.Replace("\"", "%22");
                activityName = activityName.Replace("!", "%21");
                activityName = activityName.Replace("&", "%26");
                activityName = activityName.Replace("*", "%2A");
                activityName = activityName.Replace("+", "%2B");
                activityName = activityName.Replace("/", "%2F");
                activityName = activityName.Replace("-", "%2D");
                activityName = activityName.Replace("$", "%24");
                activityName = activityName.Replace("=", "%3D");
                activityName = activityName.Replace("?", "%3F");
                activityName = activityName.Replace("@", "%40");
                activityName = activityName.Replace(",", "%2C");
                activityName = activityName.Replace("[", "%5B");
                activityName = activityName.Replace("]", "%5D");
                Console.WriteLine(CreateURL(projectName, activityName));



                Console.Write("Would you like to do another? (y/n): ");
            } while (Console.ReadLine().ToLower().Equals("y"));
        }

        static string CreateURL(string projectName, string activityName)
        {
            string URL ="https://companyserver.com/content/" + projectName+ "/files/" + activityName + "/" + activityName + "Report.pdf";
            return URL; //
        }


        static string GetUserInput()
        {
            string input = "";
           
           
            do
            {
                input = Console.ReadLine();
                if (IsValid(input)) return input;
                Console.Write("The input contains invalid characters. Enter again: ");
            } while (true);
           
            }

        static bool IsValid(string input)
        {

            foreach (char character in input.ToCharArray())
            {
                if (character >= 0x00 && character <= 0x1F)
                {
                    return false; 
                }
                if (character == 0x7F)
                {
                    return false;
                }
            }

            return true;  
        }

       
    }
}