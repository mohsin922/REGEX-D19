using Microsoft.VisualStudio.TestTools.UnitTesting;
using REGEX;

namespace REGEXMSTest
{
    [TestClass]
    public class UnitTest1
    {//validation for first Name
        [TestMethod]
        [DataRow("Mohsin", "Mohsin")]
        [DataRow("Mo", "Mo")]
        [DataRow("m", null)]
        [DataRow("Moh06", null)]

        public void ValidateFirstname(string a, string expected)
        {

            try
            {

                var actual = RegexSample.ValidatingFirstName(a);
                Assert.AreEqual(expected, actual);
            }
            catch (CustomException actual)
            {
                Assert.AreEqual(expected, actual.message);
            }
        }
        //Validating for Last Name
        [TestMethod]
        [DataRow("Zahoor", "Zahoor")]
        [DataRow("Zahoor", null)]
        [DataRow("MohsinZahoor", "MohsinZahoor")]
        [DataRow("Mohsin06", null)]
        public void ValidateUserLastname(string a, string expected)
        {
            try
            {
                var actual = RegexSample.ValidatingLastName(a);
                Assert.AreEqual(expected, actual);
            }
            catch (CustomException actual)
            {
                Assert.AreEqual(expected, actual.message);
            }
        }
        //Validation for Email
        [TestMethod]
        [DataRow("abc@gmail.com", "abc@gmail.com")]
        [DataRow("abc-100@yahoo.com", "abc-100@yahoo.com")]
        [DataRow("abc.100@yahoo.com", "abc.100@yahoo.com")]
        [DataRow("abc111@yahoo.com", "abc111@yahoo.com")]
        [DataRow("abc111@abc.com", "abc111@abc.com")]
        [DataRow("abc-100@abc.net", "abc-100@abc.net")]
        [DataRow("abc.100@abc.com.au", "abc.100@abc.com.au")]
        [DataRow("abc@1.com", "abc@1.com")]
        [DataRow("abc@gmail.com.com", "abc@gmail.com.com")]
        [DataRow("abc+100@gmail.com", "abc+100@gmail.com")]
        [DataRow("abc", null)]
        [DataRow("abc@.com.my", null)]
        [DataRow("abc123@.com", null)]
        [DataRow("abc123@.com.com", null)]
        [DataRow("abc()*@gmail.com", null)]
        [DataRow(".abc@abc.com", null)]
        [DataRow("abc@%*.com", null)]
        [DataRow("abc..2002@gmail.com", null)]
        [DataRow("abc.@gmail.com", null)]
        [DataRow("abc@abc@gmail.com", null)]
        [DataRow("abc@gmail.com.1a", null)]
        [DataRow("abc@gmail.com.aa.au", null)]

        public void ValidateUserEmail(string a, string expected)
        {
            try
            {
                var actual = RegexSample.ValidatingEmailId(a);
                Assert.AreEqual(expected, actual);
            }
            catch (CustomException actual)
            {
                Assert.AreEqual(expected, actual.message);
            }
        }

        //Validation for Phone Number
        [TestMethod]
        [DataRow("1 1000987267", "1 1000987267")]
        [DataRow("91 9842905050", "91 9842905050")]
        [DataRow("100 9842905050", "100 9842905050")]
        [DataRow("919842905050", null)]
        [DataRow("919842905", null)]
        [DataRow("91 984290", null)]
        [DataRow("91 984290505000000", null)]
        public void ValidateUserPhoneNumber(string a, string expected)
        {
            try
            {
                var actual = RegexSample.ValidatingPhoneNum(a);
                Assert.AreEqual(expected, actual);
            }
            catch (CustomException actual)
            {
                Assert.AreEqual(expected, actual.message);
            }
        }

        ////Validation for Password
        [TestMethod]
        [DataRow("Moh@123", "Moh@123")]
        [DataRow("Moh#123", "Moh#123")]
        [DataRow("Moh@1S ", "Moh@1S")]
        [DataRow("@Moh129", "@Moh129")]
        [DataRow("Mo-h123", "Mo-h123")]
        [DataRow("Moh123)@1234", null)]
        [DataRow("Moh@aha", null)]
        [DataRow("Moh123", null)]
        [DataRow("Moh@123", null)]
        [DataRow("@Moh#12Moh", null)]
        [DataRow(")Moh12", null)]
        [DataRow(")Moh12", null)]
        [DataRow("Mo-h@12S", null)]
        [DataRow("Moh@s", null)]

        public void ValidateUserPassword(string a, string expected)
        {
            try
            {
                var actual = RegexSample.ValidatingPassWord(a);
                Assert.AreEqual(expected, actual);
            }
            catch (CustomException actual)
            {
                Assert.AreEqual(expected, actual.message);
            }
        }

    }
}