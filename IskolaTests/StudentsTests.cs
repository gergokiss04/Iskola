using Microsoft.VisualStudio.TestTools.UnitTesting;
using Iskola;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iskola.Tests
{
    [TestClass()]
    public class StudentsTests
    {

        //Tesztesetek elkészítése helyes és helytelen sorokra
        [TestMethod()]
        public void azonositoTest()
        {
            Students st = new Students("2006;c;Bodnar Szilvia");
            Assert.AreEqual("6cbodszi",st.azonosito());

            Students st2 = new Students("2004;b;Denes Anna");
            Assert.AreEqual("4bdenann", st2.azonosito());

            Students st3 = new Students("2004;b;Denes Anna");
            Assert.AreNotEqual("4bnesnna", st2.azonosito());
        }
    }
}