using System;
using Xunit;
using CSV.Gmail.Contacts.Editor;

namespace CSV.Gmail.Contacts.Editor.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test987653456()
        {
            var formatedNumber = CellphoneNumberFormater.FormatNumber("987653456", "21", "+5521");
            Assert.Equal("+5531987653456", formatedNumber);
        }

        [Fact]
        public void Test31997963123()
        {
            var formatedNumber = CellphoneNumberFormater.FormatNumber("31997963123", "31", "+5531");
            Assert.Equal("+5531997963123", formatedNumber);
        }

        [Fact]
        public void Test031997963123()
        {
            var formatedNumber = CellphoneNumberFormater.FormatNumber("031997963123", "31", "+5531");
            Assert.Equal("+5531997963123", formatedNumber);
        }

        [Fact]
        public void Test97963123()
        {
            var formatedNumber = CellphoneNumberFormater.FormatNumber("97963123", "31", "+5531");
            Assert.Equal("+5531997963123", formatedNumber);
        }

        [Fact]
        public void Test33928745()
        {
            var formatedNumber = CellphoneNumberFormater.FormatNumber("33928745", "31", "+5531");
            Assert.Equal("33928745", formatedNumber);
        }
        
        [Fact]
        public void Test08007215000()
        {
            var formatedNumber = CellphoneNumberFormater.FormatNumber("08007215000", "31", "+5531");
            Assert.Equal("08007215000", formatedNumber);
        }

        [Fact]
        public void TestFormatedNumberSpaces()
        {
            var formatedNumber = CellphoneNumberFormater.FormatNumber("+55 (31) 98705-9657", "31", "+5531");
            Assert.Equal("+55 (31) 98705-9657", formatedNumber);
        }

        [Fact]
        public void TestFormatedNumberNoSpaces()
        {
            var formatedNumber = CellphoneNumberFormater.FormatNumber("+55(31)987059657", "31", "+5531");
            Assert.Equal("+55(31)987059657", formatedNumber);
        }

        [Fact]
        public void TestFormatedNumberNoCharactersSpaces()
        {
            var formatedNumber = CellphoneNumberFormater.FormatNumber("+5531987059657", "31", "+5531");
            Assert.Equal("+5531987059657", formatedNumber);
        }

        [Fact]
        public void TestFormatedDdd21AndParameter31()
        {
            var formatedNumber = CellphoneNumberFormater.FormatNumber("021974556490", "31", "+5531");
            Assert.Equal("021974556490", formatedNumber);
        }

        [Fact]
        public void TestFormatedDdd21AndParameter21()
        {
            var formatedNumber = CellphoneNumberFormater.FormatNumber("021974556490", "21", "+5521");
            Assert.Equal("+5521974556490", formatedNumber);
        }

        [Fact]
        public void TestFormatedCarrierCodeDdd()
        {
            var formatedNumber = CellphoneNumberFormater.FormatNumber("01535998557111", "35", "+5535");
            Assert.Equal("+5535998557111", formatedNumber);
        }
    }
}
