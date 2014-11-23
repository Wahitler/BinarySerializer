﻿using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BinarySerializer.Test.Converters
{
    [TestClass]
    public class ConverterTests : TestBase
    {
        [TestMethod]
        public void ConverterTest()
        {
            var expected = new ConverterClass {Field = "FieldValue"};
            var actual = Roundtrip(expected);
            Assert.AreEqual(((double)expected.Field.Length + 1)/2, actual.HalfFieldLength);
            Assert.AreEqual(expected.Field, actual.Field);
        }
    }
}