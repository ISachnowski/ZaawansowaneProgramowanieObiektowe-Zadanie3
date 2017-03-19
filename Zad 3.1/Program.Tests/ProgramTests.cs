using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Program.Tests
{
    [TestFixture]
    public class ProgramTests
    {
        [Test]
        public void DivideNumbers_DivideTwoSameNumbers_Calculated()
        {
            var prog = new Program();
            double result = prog.DivideNumbers(2, 2);
            Assert.AreEqual(1.0, result);
        }

        [Test]
        public void DivideNumbers_DivideHigherLowerNumber_Calculated()
        {
            var prog = new Program();
            double result = prog.DivideNumbers(3, 2);
            Assert.AreEqual(1.5, result);
        }

        [Test]
        public void DivideNumbers_DivideLowerHigherNumber_Calculated()
        {
            var prog = new Program();
            double result = prog.DivideNumbers(2, 4);
            Assert.AreEqual(0.5, result);
        }

        [Test]
        public void DivideNumbers_DivideByZero_Calculated()
        {
            var prog = new Program();
            double result = prog.DivideNumbers(2, 0);
            Assert.AreEqual(2, result);
        }

    }
}
