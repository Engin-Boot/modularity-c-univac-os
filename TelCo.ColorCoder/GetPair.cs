using System;
using System.Diagnostics;
using System.Drawing;
using System.Threading.Tasks;
using System.Collections.Generic; 

namespace TelCo.ColorCoder
{
  public class GetPair
    {
      internal static int GetPairNumberFromColor(TelColorPair.ColorPair pair)
        {
            // Find the major color in the array and get the index
            int majorIndex = -1;
            for (int i = 0; i < TelColorPair.colorMapMajor.Length; i++)
            {
                if (TelColorPair.colorMapMajor[i] == pair.majorColor)
                {
                    majorIndex = i;
                    break;
                }
            }

            // Find the minor color in the array and get the index
            int minorIndex = -1;
            for (int i = 0; i < TelColorPair.colorMapMinor.Length; i++)
            {
                if (TelColorPair.colorMapMinor[i] == pair.minorColor)
                {
                    minorIndex = i;
                    break;
                }
            }
            // If colors can not be found throw an exception
            if (majorIndex == -1 || minorIndex == -1)
            {
                throw new ArgumentException(
                    string.Format("Unknown Colors: {0}", pair.ToString()));
            }

            // Compute pair number and Return  
            // (Note: +1 in compute is because pair number is 1 based, not zero)
            return (majorIndex * TelColorPair.colorMapMinor.Length) + (minorIndex + 1);
        }
        /// <summary>
        /// Test code for the class
        /// </summary>
        /// <param name="args"></param>
   }
}
