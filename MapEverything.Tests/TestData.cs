﻿namespace MapEverything.Tests
{
    using System;

    using NUnit.Framework;

    public class TestData
    {
        /************************************************************************/
        /*                                                                      
        /*   String                                                              
        /*                                                                      
        /************************************************************************/

        public TestCaseData[] StringToStringData =
            {
                new TestCaseData(string.Empty).Returns(string.Empty),
                new TestCaseData(null).Returns(null),
                new TestCaseData("foo").Returns("foo"),
            };

        public TestCaseData[] StringToIntData =
            {
                new TestCaseData("0").Returns(0),
                new TestCaseData("10").Returns(10),
                new TestCaseData("10.0").Returns(0),
                new TestCaseData("10,0").Returns(0),
                new TestCaseData("10.5").Returns(0),
                new TestCaseData("10,5").Returns(0),
                new TestCaseData("-10").Returns(-10),
                new TestCaseData("1 000").Returns(0),
                new TestCaseData("1,000").Returns(0),
                new TestCaseData("1.000").Returns(0),
                new TestCaseData("1 000.00").Returns(0),
                new TestCaseData("2147483647").Returns(2147483647),
                new TestCaseData("2147483648").Returns(0),
                new TestCaseData("-2147483648").Returns(-2147483648),
                new TestCaseData("-2147483649").Returns(0),
                new TestCaseData("abc").Returns(0),
                new TestCaseData("123a").Returns(0),
            };

        // Use with decimalseperator = . and thousandseperator = [space]
        public TestCaseData[] StringToDecimalData =
            {
                new TestCaseData("0").Returns(0m),
                new TestCaseData("10").Returns(10m),
                new TestCaseData("10.0").Returns(10.0m),
                new TestCaseData("10,0").Returns(0m),
                new TestCaseData("10.5").Returns(10.5m),
                new TestCaseData("10,5").Returns(0m),
                new TestCaseData("-10").Returns(-10m),
                new TestCaseData("1000").Returns(1000m),
                new TestCaseData("1 000").Returns(1000m),
                new TestCaseData("1 000 000").Returns(1000000m),
                new TestCaseData("1,000").Returns(0m),
                new TestCaseData("1.000").Returns(1.000m),
                new TestCaseData("1 000.00").Returns(1000.00m),
                new TestCaseData("79228162514264337593543950335").Returns(decimal.MaxValue),
                new TestCaseData("79228162514264337593543950336").Returns(0m),
                new TestCaseData("-79228162514264337593543950335").Returns(decimal.MinValue),
                new TestCaseData("-79228162514264337593543950336").Returns(0m),
                new TestCaseData("abc").Returns(0m),
                new TestCaseData("123a").Returns(0m),
                new TestCaseData("123m").Returns(0m),
            };

        public TestCaseData[] StringToGuidData =
            {
                new TestCaseData("00000000-0000-0000-0000-000000000000").Returns(Guid.Empty),
                new TestCaseData("0cb6c00f-fc44-484f-8ddd-823709b74601").Returns(new Guid("0cb6c00f-fc44-484f-8ddd-823709b74601")),
                new TestCaseData("0cb6c00ffc44484f8ddd823709b74601").Returns(new Guid("0cb6c00f-fc44-484f-8ddd-823709b74601")),
                new TestCaseData("abc").Returns(Guid.Empty),
                new TestCaseData("123").Returns(Guid.Empty),
            };

        public TestCaseData[] StringToDateTimeData =
            {
                new TestCaseData("1977-03-04").Returns(new DateTime(1977, 03, 04)),
                new TestCaseData("1977-03-04 13:37").Returns(new DateTime(1977, 03, 04, 13, 37, 00)),
            };

        /************************************************************************/
        /*                                                                      
        /*   Decimal                                                              
        /*                                                                      
        /************************************************************************/

        public TestCaseData[] DecimalToDecimalData =
            {
                new TestCaseData(0m).Returns(0m),
                new TestCaseData(1.000m).Returns(1.000m),
                new TestCaseData(1000m).Returns(1000m),
                new TestCaseData(decimal.MaxValue).Returns(decimal.MaxValue),
                new TestCaseData(decimal.MinValue).Returns(decimal.MinValue),
            };

        public TestCaseData[] DecimalToIntData =
            {
                new TestCaseData(decimal.MaxValue).Returns(0),
                new TestCaseData(decimal.MinValue).Returns(0),
                new TestCaseData(123.5m).Returns(124),
                new TestCaseData(123.49m).Returns(123),
            };

        public TestCaseData[] DecimalToStringData =
            {
                new TestCaseData(decimal.MaxValue).Returns("79228162514264337593543950335"),
                new TestCaseData(decimal.MinValue).Returns("-79228162514264337593543950335"),
                new TestCaseData(0m).Returns("0"),
                new TestCaseData(123.5m).Returns("123.5"),
                new TestCaseData(123.49m).Returns("123.49"),
                new TestCaseData(1.00m).Returns("1.00"),
                new TestCaseData(1000m).Returns("1000"),
                new TestCaseData(1000000m).Returns("1000000"),
            };

        public TestCaseData[] DecimalToDoubleData =
            {
                new TestCaseData(decimal.MaxValue).Returns(7.9228162514264338E+28d),
                new TestCaseData(decimal.MinValue).Returns(-7.9228162514264338E+28d),
                new TestCaseData(123.5m).Returns(123.5),
                new TestCaseData(123.49m).Returns(123.49),
            };


        /************************************************************************/
        /*                                                                      
        /*   Double                                                              
        /*                                                                      
        /************************************************************************/


        public TestCaseData[] DoubleToIntData =
            {
                new TestCaseData(double.MaxValue).Returns(0),
                new TestCaseData(double.MinValue).Returns(0),
                new TestCaseData(123.5d).Returns(124),
                new TestCaseData(123.49d).Returns(123),
            };

        public TestCaseData[] DoubleToDecimalData =
            {
                new TestCaseData(double.MaxValue).Returns(0m),
                new TestCaseData(double.MinValue).Returns(0m),
                new TestCaseData((double)decimal.MaxValue).Returns(decimal.MaxValue),
                new TestCaseData((double)decimal.MinValue).Returns(decimal.MinValue),
                new TestCaseData(0.0).Returns(0.0m),
                new TestCaseData(123.5).Returns(123.5m),
                new TestCaseData(123.49).Returns(123.49m),
            };


        /************************************************************************/
        /*                                                                      
        /*   Long                                                              
        /*                                                                      
        /************************************************************************/

        public TestCaseData[] LongToIntData =
            {
                new TestCaseData(0).Returns(0),
                new TestCaseData(int.MaxValue).Returns(int.MaxValue),
                new TestCaseData(int.MinValue).Returns(int.MinValue),
                new TestCaseData(long.MaxValue).Returns(0),
                new TestCaseData(long.MinValue).Returns(0),
            };

        /************************************************************************/
        /*                                                                      
        /*   Int                                                              
        /*                                                                      
        /************************************************************************/
        
        public TestCaseData[] IntToLongData =
            {
                new TestCaseData(0).Returns(0),
                new TestCaseData(int.MaxValue).Returns(int.MaxValue),
                new TestCaseData(int.MinValue).Returns(int.MinValue),
            };

        public TestCaseData[] IntToIntData =
            {
                new TestCaseData(0).Returns(0),
                new TestCaseData(int.MaxValue).Returns(int.MaxValue),
                new TestCaseData(int.MinValue).Returns(int.MinValue),
            };

        public TestCaseData[] IntToStringData =
            {
                new TestCaseData(0).Returns("0"),
                new TestCaseData(int.MaxValue).Returns(int.MaxValue.ToString()),
                new TestCaseData(int.MinValue).Returns(int.MinValue.ToString()),
            };

        /************************************************************************/
        /*                                                                      
        /*   UInt                                                              
        /*                                                                      
        /************************************************************************/


        public TestCaseData[] UIntToIntData =
            {
                new TestCaseData((uint)0).Returns(0),
                new TestCaseData(uint.MaxValue).Returns(0),
                new TestCaseData((uint)int.MaxValue).Returns(int.MaxValue),
                new TestCaseData(uint.MinValue).Returns(0),
            };

        /************************************************************************/
        /*                                                                      
        /*   Guid                                                              
        /*                                                                      
        /************************************************************************/

        public TestCaseData[] GuidToStringData =
            {
                new TestCaseData(Guid.Empty).Returns("00000000-0000-0000-0000-000000000000"),
                new TestCaseData(new Guid("0cb6c00f-fc44-484f-8ddd-823709b74601")).Returns("0cb6c00f-fc44-484f-8ddd-823709b74601"),
                new TestCaseData(new Guid("0cb6c00ffc44484f8ddd823709b74601")).Returns("0cb6c00f-fc44-484f-8ddd-823709b74601"),
            };

        /************************************************************************/
        /*                                                                      
        /*   DateTime                                                              
        /*                                                                      
        /************************************************************************/

        public TestCaseData[] DateTimeToStringData =
            {
                new TestCaseData(new DateTime(1977, 03, 04)).Returns("1977-03-04 00:00:00"),
                new TestCaseData(new DateTime(1977, 03, 04, 13, 37, 00)).Returns("1977-03-04 13:37:00"),
            };

    }
}
