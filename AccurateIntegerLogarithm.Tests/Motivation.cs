using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace AccurateIntegerLogarithm.Tests {
  [TestClass]
  public class Motivation 
  {
      [TestMethod]
      public virtual void Test001()
      {
        Assert.AreEqual(2L, (long)Math.Log(1000L, 10L));
      }
  }
}

