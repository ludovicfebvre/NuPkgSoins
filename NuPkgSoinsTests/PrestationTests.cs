﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using TpSoins;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpSoins
{
    [TestClass()]
    public class PrestationTests
    {

        [TestMethod()]
        public void CompareToTest()
        {
            Prestation unePrestation = new Prestation("XX", new DateTime(2015, 9, 10, 12, 0, 0), new Intervenant("Dupont", "Jean"));
            Prestation uneAutrePrestation = new Prestation("XX", new DateTime(2015, 9, 10, 12, 0, 0), new Intervenant("Dupont", "Jean"));
            Assert.AreEqual(0, unePrestation.CompareTo(uneAutrePrestation), "La somme doit être égal à 0");

        }

        [TestMethod()]
        public void CompareToTest1()
        {
            Prestation unePrestation = new Prestation("XIX", new DateTime(2015, 9, 10, 12, 0, 0), new Intervenant("Dupont", "Jean"));
            Prestation uneAutrePrestation = new Prestation("XX", new DateTime(2017, 9, 10, 12, 0, 0), new Intervenant("Dupont", "Jean"));

            Assert.IsTrue(unePrestation.CompareTo(uneAutrePrestation) < 0);
        }

        [TestMethod()]
        public void CompareToTest2()
        {
            Prestation unePrestation = new Prestation("XIX", new DateTime(2017, 9, 10, 12, 0, 0), new Intervenant("Dupont", "Jean"));
            Prestation uneAutrePrestation = new Prestation("XX", new DateTime(2015, 9, 10, 12, 0, 0), new Intervenant("Dupont", "Jean"));

            Assert.IsTrue(unePrestation.CompareTo(uneAutrePrestation) > 0);
        }
    }
}