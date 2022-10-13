using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PinBreaker
{
    public class TemporaryBrutForce
    {
        private long attackcounter = 0;
        private List<string> charlist(int firstascii, int lastascii)
        {
            List<string> passchars = new List<string>();
            for (int i = firstascii; i <= lastascii; i++)
            {
                passchars.Add(Char.ConvertFromUtf32(i));
            }
            return passchars;
        }
        private List<string> charlist(int firstascii, int lastascii, int secondascii, int secondlastascii)
        {
            List<string> passchars = new List<string>();
            for (int i = firstascii; i <= lastascii; i++)
            {
                passchars.Add(Char.ConvertFromUtf32(i));
            }
            for (int i = secondascii; i <= secondlastascii; i++)
            {
                passchars.Add(Char.ConvertFromUtf32(i));
            }
            return passchars;
        }
        private List<string> charlist(int firstascii, int lastascii, int secondascii, int secondlastascii, int thirdascii, int thirdlastascii)
        {
            List<string> passchars = new List<string>();
            for (int i = firstascii; i <= lastascii; i++)
            {
                passchars.Add(Char.ConvertFromUtf32(i));
            }
            for (int i = secondascii; i <= secondlastascii; i++)
            {
                passchars.Add(Char.ConvertFromUtf32(i));
            }
            for (int i = thirdascii; i <= thirdlastascii; i++)
            {
                passchars.Add(Char.ConvertFromUtf32(i));
            }
            return passchars;
        }
        public void timeconverter(int seconds)
        {
            int min = 0;
            int hour = 0;
            if (seconds > 60)
            {                
                min = seconds / 60;
                seconds = seconds % 60;
            }
            if (min > 60)
            {                
                hour = min / 60;
                min = min % 60;
            }
            Console.WriteLine($"Your password has been broken after {hour} hours {min} minutes {seconds} seconds");
        }
        private string loopandchars(List<string> chars,string pass)
        {
            string password = "";
            int char1 = 0;
            chars[char1] = null;
            int char2 = 0;
            chars[char2] = null;
            int char3 = 0;
            chars[char3] = null;
            int char4 = 0;
            chars[char4] = null;
            int char5 = 0;
            chars[char5] = null;
            int char6 = 0;
            chars[char6] = null;
            int char7 = 0;
            chars[char7] = null;
            attackcounter = 0;
            for (int i = 1; i <= chars.Count(); i++)
            {
                if (i == chars.Count())
                {
                    char1++;
                    i = 0;
                }
                if (char1 == chars.Count())
                {
                    char2++;
                    char1 = 0;
                }
                if (char2 == chars.Count())
                {
                    char3++;
                    char2 = 0;
                }
                if (char3 == chars.Count())
                {
                    char4++;
                    char3 = 0;
                }
                if (char4 == chars.Count())
                {
                    char5++;
                    char4 = 0;
                }
                if (char5 == chars.Count())
                {
                    char6++;
                    char5 = 0;
                }
                if (char6 == chars.Count())
                {
                    char7++;
                    char6 = 0;
                }
                if (char7 == chars.Count())
                {
                    password = "Your password has not been hacked";
                    break;
                }
                password = chars[i] + chars[char1] + chars[char2] + chars[char3] + chars[char4] + chars[char5] + chars[char6] + chars[char7];
                attackcounter++;
                if (pass.Equals(password))
                {
                    break;
                }
            }
            return password;
        }
        private void message(string password, long counter)
        {
            Console.WriteLine("Your password is {0} and has been broken after {1} attacks", password, counter);
        }
        public void bruteforcewithspecialcharacters(string pass)
        {
            message(loopandchars(charlist(31, 126), pass),attackcounter);
        }
        public void bruteforceeasy(string pass)
        {
            message(loopandchars(charlist(96, 122), pass), attackcounter);
        }
        public void bruteforcesmallandlarge(string pass)
        {
            message(loopandchars(charlist(64, 90,96,122), pass), attackcounter);
        }
        public void bruteforcesmalllargeandnumbers(string pass)
        {
            message(loopandchars(charlist(64, 90, 96, 122,47,57), pass), attackcounter);
        }
        public void pinbreaker(string pin)
        {
            int maxpinlength = 4;
            while (pin.Length > maxpinlength || pin.Length < maxpinlength)
            {
                Console.WriteLine("Your pin number is too long. Pin length is 4 characters.");
                pin = Console.ReadLine();
            }
            string pin1 = "-0001";
            do
            {
                int tmp = Convert.ToInt32(pin1);
                tmp++;
                pin1 = tmp.ToString("0000");
            } while (pin != pin1);
            Console.WriteLine($"Your pin is {pin1}");
        }
    }
}
