using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing5
{
    [TestClass]
   
    public class tstBranch
    {
        [TestMethod]
      
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsBranch aBranch = new clsBranch();
            //test to see that it exists 
            Assert.IsNotNull(aBranch);
        }
    }
}
