using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeTest
{
    [TestClass]
    public class IntegerMathUnitTest
    {
        [TestMethod]
        public void IntegerIncrementBeforeAssignmentTest()
        {
            int assert = 1;
            int actual = CSharp.IntegerMath.IntegerIncrementBeforeAssignment();

            Assert.AreEqual(assert, actual, string.Format("IntegerIncrementDuringAssignment: assert{0}, actual{1}", assert, actual));

        }
        [TestMethod]
        public void IntegerIncrementDuringAssignmetTest()
        {
            int assert = 1;
            int actual = CSharp.IntegerMath.IntegerIncrementDuringAssignment();
            //This will always fail because the integer incmentation operator value++ change the value after it assigns it to the left side.

            Assert.AreNotEqual(assert, actual, string.Format("IntegerIncrementDuringAssignment: assert{0}, actual{1}", assert, actual));


        }
        [TestMethod]
        public void IntegerLeftSideOperatorDuringAssignmetTest()
        {
            int assert = 1;
            int actual = CSharp.IntegerMath.IntegerLeftSideOperatorDuringAssignmet();
            //This will pass because the operator is not left side of the operand ++value change the value after it assigns it to the left side.

            Assert.AreEqual(assert, actual, string.Format("IntegerLeftSideOperatorDuringAssignmet: assert{0}, actual{1}", assert, actual));


        }
        /// <summary>
        /// This test methods test multiple values of one test. If any of them faile the whole test failes.
        /// </summary>
        [TestMethod]
        public void DivideWithoutDivisionOrModOperatorTest()
        {
            
            // use named parameters to make code easier to read
            DivideWithoutDivisionOrModOperatorTest(numerator: 18, denominator:18, assert: 1);
            DivideWithoutDivisionOrModOperatorCatchExceptionTest();
            DivideWithoutDivisionOrModOperatorTest(numerator: 3, denominator: 18, assert: 0);
            DivideWithoutDivisionOrModOperatorTest(numerator: 6, denominator: 3, assert: 2);
            DivideWithoutDivisionOrModOperatorTest(numerator: 18, denominator: 3, assert: 6);
            // how do make this faster. The following can take up to 7 seconds 
            DivideWithoutDivisionOrModOperatorTest(numerator: 1800000000, denominator: 1, assert: 1800000000);


        }
        /// <summary>
        /// Overload  the test method to group the methods and test multiple values. 
        /// </summary>
        /// <param name="numerator"></param>
        /// <param name="denominator"></param>
        /// <param name="assert"></param>
        private void DivideWithoutDivisionOrModOperatorTest(int numerator, int denominator, int assert)
        {
            int actual = CSharp.IntegerMath.DivideWithoutDivisionOrModOperator(numerator, denominator);
            Assert.AreEqual(assert, actual, string.Format("DivideWithoutDivisionOrModOperator: numerator:{3}, denominator:{2}, assert:{0}, actual{1}", assert, actual, numerator, denominator));

        }
       /// <summary>
       /// This test confirms a divide by zero error is thrown.
       /// </summary>
       /// <param name="numerator"></param>
       /// <param name="denominator"></param>
        private void DivideWithoutDivisionOrModOperatorCatchExceptionTest()
        {
                //This test must run with the denominator set 0;
            int numerator = 3, denominator = 0;
            try{
                int actual = CSharp.IntegerMath.DivideWithoutDivisionOrModOperator(numerator, denominator);
                }
            catch(Exception ex){
                string assertException = "Divide by Zero Error";
                Assert.AreEqual(assertException, ex.Message, string.Format("DivideWithoutDivisionOrModOperator: numerator:{3}, denominator:{2}, assert:{0}, actual{1}", assertException, ex, numerator, denominator));
                return;
            }

            Assert.Fail("An exception was not thrown");
        }


    }
}
