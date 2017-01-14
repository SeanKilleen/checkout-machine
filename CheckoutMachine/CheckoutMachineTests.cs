using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace CheckoutMachine
{
    [TestFixture]
    public class CheckoutMachineTests
    {
        private CheckoutMachine checkoutMachine;

        [SetUp]
        public void Setup()
        {
            checkoutMachine = new CheckoutMachine();
        }

        [Test]
        public void Test_Scan_Chips_Expects_Total_200()
        {
            checkoutMachine.Scan("123");

            Assert.AreEqual(200, checkoutMachine.Total());
        }

        [Test]
        public void Test_Scan_Salsa_Expects_Total_100()
        {
            checkoutMachine.Scan("456");

            Assert.AreEqual(100, checkoutMachine.Total());
        }

        [Test]
        public void Test_Scan_Wine_Expects_Total_1000()
        {
            checkoutMachine.Scan("789");

            Assert.AreEqual(1000, checkoutMachine.Total());
        }

        [Test]
        public void Test_Scan_Cigarettes_Expects_Total_550()
        {
            checkoutMachine.Scan("111");

            Assert.AreEqual(550, checkoutMachine.Total());
        }

        [Test]
        public void Test_Scan_All_Products_Expects_Total_1850()
        {
            checkoutMachine.Scan("123");
            checkoutMachine.Scan("456");
            checkoutMachine.Scan("789");
            checkoutMachine.Scan("111");

            Assert.AreEqual(1850, checkoutMachine.Total());
        }

        [Test]
        public void Test_Scan_Chips_With_Bonus_Card_Expect_200()
        {
            checkoutMachine.Scan("123"); //chips

            checkoutMachine.Scan("000");

            Assert.AreEqual(200, checkoutMachine.Total());
        }

        [Test]
        public void Test_Scan_Salsa_With_Bonus_Card_Expects_50()
        {
            checkoutMachine.Scan("456"); // salsa

            checkoutMachine.Scan("000");

            Assert.AreEqual(50, checkoutMachine.Total());
        }

        [Test]
        public void Test_Scan_Three_Chips_With_Bonus_Card_Expects_400()
        {
            checkoutMachine.Scan("123");
            checkoutMachine.Scan("123");
            checkoutMachine.Scan("123");

            checkoutMachine.Scan("000");

            Assert.AreEqual(400, checkoutMachine.Total());
        }

        [Test]
        public void test_scan_four_chips_with_bonus_card_expects_600()
        {
            checkoutMachine.Scan("123");
            checkoutMachine.Scan("123");
            checkoutMachine.Scan("123");
            checkoutMachine.Scan("123");

            checkoutMachine.Scan("000");

            Assert.AreEqual(600, checkoutMachine.Total());
        }

        [Test]
        public void Test_scan_Seven_chips_WithBonusCard_Expects1000()
        {
            checkoutMachine.Scan("123");
            checkoutMachine.Scan("123");
            checkoutMachine.Scan("123");
            checkoutMachine.Scan("123");
            checkoutMachine.Scan("123");
            checkoutMachine.Scan("123");
            checkoutMachine.Scan("123");

            checkoutMachine.Scan("000");

            Assert.AreEqual(1000, checkoutMachine.Total());
        }
    }
}
