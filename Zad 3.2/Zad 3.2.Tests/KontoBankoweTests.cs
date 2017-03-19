using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Zad_3._2.Tests
{
    [TestFixture]
    public class KontoBankoweTests
    {
        [Test]
        public void AktualnyStanKonta_GetAccountBalance_Equal()
        {
            var konto = new KontoBankowe("test", "test", "13", 1234.56);
            Assert.AreEqual(konto.AktualnyStanKonta(), 1234.56);
        }

        [Test]
        public void WyplacPieniadze_WithdrawLessThanInAccount_Withdrawed(){
            var konto = new KontoBankowe("test", "test", "13", 1234.56);
            konto.WyplacPieniadze(234.56);
            Assert.AreEqual(konto.AktualnyStanKonta(), 1000.00);
        }

        [Test]
        public void WyplacPieniadze_WithdrawMoreThanInAccount_NotWithdrawed()
        {
            var konto = new KontoBankowe("test", "test", "13", 1234.56);
            konto.WyplacPieniadze(2345.67);
            Assert.AreEqual(konto.AktualnyStanKonta(), 1234.56);
        }

        [Test]
        public void WplacPieniadze_PaymentOnAccount_Paid()
        {
            var konto = new KontoBankowe("test", "test", "13", 1000.00);
            konto.WplacPieniadze(234.56);
            Assert.AreEqual(konto.AktualnyStanKonta(), 1234.56);
        }

        [Test]
        public void TransferujKwote_LessThanAccount1_Acc1NotUpdated()
        {
            var konto1 = new KontoBankowe("test", "test", "13", 1234.56);
            var konto2 = new KontoBankowe("test", "test", "13", 1234.56);
            konto1.TransferujKwote(2345.67, konto2);
            Assert.AreEqual(konto1.AktualnyStanKonta(), 1234.56);
        }

        [Test]
        public void TransferujKwote_LessThanAccount1_Acc2NotUpdated()
        {
            var konto1 = new KontoBankowe("test", "test", "13", 1234.56);
            var konto2 = new KontoBankowe("test", "test", "13", 1234.56);
            konto1.TransferujKwote(2345.67, konto2);
            Assert.AreEqual(konto2.AktualnyStanKonta(), 1234.56);
        }

        [Test]
        public void TransferujKwote_FromOneAccountToAnother_Acc1Updated()
        {
            var konto1 = new KontoBankowe("test", "test", "13", 1234.56);
            var konto2 = new KontoBankowe("test", "test", "13", 1234.56);
            konto1.TransferujKwote(234.56, konto2);
            Assert.AreEqual(konto1.AktualnyStanKonta(), 1000.00);
        }

        [Test]
        public void TransferujKwote_FromOneAccountToAnother_Acc2Updated()
        {
            var konto1 = new KontoBankowe("test", "test", "13", 1234.56);
            var konto2 = new KontoBankowe("test", "test", "13", 1234.56);
            konto1.TransferujKwote(234.56, konto2);
            Assert.AreEqual(konto2.AktualnyStanKonta(), 1469.12);
        }

    }
}
