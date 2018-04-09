using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace suivA.test
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestLogin()
        {
            BddRequest testLogin = new BddRequest();
            string resultat = testLogin.loginRequest("j","j");
            Assert.AreEqual("103", resultat);
        }

        [TestMethod]
        public void testGetVisiteur()
        {
            BddRequest testduGetVisiteur = new BddRequest();
            Visiteur resultat = testduGetVisiteur.getVisiteur("97");
            Assert.AreEqual("Berg", resultat.name);
            Assert.AreEqual("Brian", resultat.surname);
            Assert.AreEqual("97", resultat.id);
            Assert.AreEqual("3", resultat.id_medecin);
            Assert.AreEqual("1", resultat.id_role);
            Assert.AreEqual("Schroeder", resultat.medecin_name);
            Assert.AreEqual("Claudia", resultat.medecin_surname);
            Assert.AreEqual("911-5810 Donec Av.", resultat.medecin_cabinet);
        }
    }
}
