using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing_clsGame
{
    [TestClass]
    public class tstTesting
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class
            clsTesting ATest = new clsTesting();
            //check to see if the class is not null
            Assert.IsNotNull(ATest);
        }
    }
}
