using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    public static class IntegerMath
    {


        public static int IntegerIncrementBeforeAssignment()
        {
            int counter=0;
            int returnValue;
            counter++;
            returnValue = counter;

            return returnValue;
        }

        public static int IntegerIncrementDuringAssignment()
        {
            int counter = 0;
            int returnValue;
            returnValue = counter++;

            return returnValue;
        }

        public static int IntegerLeftSideOperatorDuringAssignmet()
        {
            int counter = 0;
            int returnValue;
            returnValue = ++counter;

            return returnValue;
        }
        /// <summary>
        /// The following method will divide a numerator by denominator without usingdivision or mod
        /// </summary>
        /// <param name="numerator"></param>
        /// <param name="denominator"></param>
        /// <returns></returns>
        public static int DivideWithoutDivisionOrModOperator(int numerator, int denominator)
        {
            //if denominator is zero throw and exception
            if (denominator == 0)
                throw new Exception("Divide by Zero Error");

            //create return value the size of numerator and return it if denominator equal 1
            int returnValue = numerator;
            if ( denominator ==  1)
                return returnValue;
            ///create a return value and test for scenarios where zero is returned
            returnValue = 0;
            if (numerator < denominator)
                return returnValue;

            //set the returnValue to 1 and test for scenarios where 1 is returned
            returnValue = 1;
            if (numerator == denominator)
                return returnValue;

            //create a value enumerator the denominator value up to the numerator
            int denominatorTracker = denominator;


            while(denominatorTracker < numerator)
            {
                denominatorTracker += denominator;
                returnValue++;

            }

            return returnValue;
                
        }
    }
}
