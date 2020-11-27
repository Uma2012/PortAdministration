using System;
using System.Collections.Generic;
using System.Text;

namespace PortAdministration.Methods
{
   public class ClearBoatMethod
    {
        
        public static Tuple<string[],string[]> clearTheExpiredBoats(string[] haltedBoat,int currentDay,int[] dayOut,int[] dayIn, string[] boatType)
        {
            
            for (int i = 0; i < 24; i++)
            {
                if(dayOut[i]==currentDay)
                {
                    haltedBoat[i] =" ";
                    dayIn[i] = 0;
                    dayOut[i] = 0;
                    boatType[i] = " ";
                }

            }
            var tuple = new Tuple<string[], string[]>(haltedBoat, boatType);
            return tuple;
            
        }
    }
}
