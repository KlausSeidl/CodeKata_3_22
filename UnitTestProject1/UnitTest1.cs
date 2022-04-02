using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Calculator;
using FluentAssertions;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace UnitTestProject1
{
    [TestClass]
    public class FieldAxiomTests
    {
        [TestMethod]
        public void Add_should_respect_neutral_element_off_addition()
        {
            var result = SimpleCalculator.Add(1, 0);
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void Diff_should_respect_inverse_element_off_addition()
        {
            var result = SimpleCalculator.Diff(1, 1);
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void Mult_should_respect_neutral_element_off_multiplication()
        {
            var result = SimpleCalculator.Mult(5, 1);
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void Div_should_respect_inverse_element_off_multiplication()
        {
            var result = SimpleCalculator.Div(5, 5);
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void Div_by_zero_should_throw_exception()
        {
            Action action = () => SimpleCalculator.Div(5, 0);
            Assert.ThrowsException<DivideByZeroException>(action);
        }
    }
}
