using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjetAeroport.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetAeroport.Models.Tests
{
    [TestClass()]
    public class VolDAOTests
    {
        [TestMethod()]
        public void FetchByTypeTest()
        {
           var x =  VolDAO.FetchByType("Entrant", "2018-08-23");
            Console.Write(x[1].Destination);
            Assert.Fail();
        }
    }
}