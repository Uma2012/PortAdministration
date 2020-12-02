using System;
using System.Collections.Generic;
using System.Text;

namespace PortAdministration.Methods
{
    public class GenerateRandomBoat
    {
         

        // Instantiate random number generator.  
        private static readonly Random _random = new Random();

        //// Generates a random number within a range.      
        //public int RandomNumber(int min, int max)
        //{
        //    return _random.Next(min, max);
        //}
        //// Generates a random string with a given size.    
        //public string RandomString(int size, bool lowerCase = false)
        //{
        //    var builder = new StringBuilder(size);

        //    // Unicode/ASCII Letters are divided into two blocks
        //    // (Letters 65–90 / 97–122):   
        //    // The first group containing the uppercase letters and
        //    // the second group containing the lowercase.  

        //    // char is a single Unicode character  
        //    char offset = lowerCase ? 'a' : 'A';
        //    const int lettersOffset = 26; // A...Z or a..z: length = 26  

        //    for (var i = 0; i < size; i++)
        //    {
        //        var @char = (char)_random.Next(offset, offset + lettersOffset);
        //        builder.Append(@char);
        //    }

        //    return lowerCase ? builder.ToString().ToLower() : builder.ToString();
        //}

        //this method generates boat names with prefixes.
        // 1 for MotorBoat
        //2 for sailBoat
        //3 for CargoShip
        public static string GenerateBoatNameWithPrefix()
        {
            int generateNumber = _random.Next(1, 5);
           // generateNumber = 4;

            //generate randomstring
            var builder = new StringBuilder(3);
            if (generateNumber == 1)
            {
                builder.Append("M-");
            }
            else if (generateNumber == 2)
            {
                builder.Append("S-");

            }
            else if (generateNumber == 3)
                builder.Append("C-");
            else
                builder.Append("R-");

            char offset = 'A';
            const int letterOffset = 26;
            for (int i = 0; i < 3; i++)
            {
                var @char = (char)_random.Next(offset, offset + letterOffset);
                builder.Append(@char);
            }

            return builder.ToString();
        }

    }

}
