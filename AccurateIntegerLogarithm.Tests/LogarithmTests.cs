using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccurateIntegerLogarithm.Tests {
  [TestClass]
    public class LogarithmTests
    {
        [TestMethod]
        public virtual void Test001()
        {
          ulong b = 10;
          var table = new AccurateIntegerLogarithmTool((int)b);

          ulong i = (ulong)b;

          for (uint j = 1; j < table.MaxOutput; j++) {
            Assert.AreEqual(j, table.Log(i));
            i *= b;
          }
          
        }

        
        [TestMethod]
        public virtual void Test002()
        {
          ulong b = 2;
          var table = new AccurateIntegerLogarithmTool((int)b);

          ulong i = (ulong)b;

          for (uint j = 1; j < table.MaxOutput; j++) {
            Assert.AreEqual(j, table.Log(i));
            i *= b;
          }
          
        }

        
        [TestMethod]
        public virtual void Test003()
        {
          ulong b = 3;
          var table = new AccurateIntegerLogarithmTool((int)b);

          ulong i = (ulong)b;

          for (uint j = 1; j < table.MaxOutput; j++) {
            Assert.AreEqual(j, table.Log(i));
            i *= b;
          }
          
        }

        [TestMethod]
        public virtual void Test004()
        {
          ulong b = 4;
          var table = new AccurateIntegerLogarithmTool((int)b);

          ulong i = (ulong)b;

          for (uint j = 1; j < table.MaxOutput; j++) {
            Assert.AreEqual(j, table.Log(i));
            i *= b;
          }          
        }
        
        [TestMethod]
        public virtual void Test005()
        {
          ulong b = 5;
          var table = new AccurateIntegerLogarithmTool((int)b);

          ulong i = (ulong)b;

          for (uint j = 1; j < table.MaxOutput; j++) {
            Assert.AreEqual(j, table.Log(i));
            i *= b;
          }
          
        }
        [TestMethod]
        public virtual void Test006()
        {
          ulong b = 6;
          var table = new AccurateIntegerLogarithmTool((int)b);

          ulong i = (ulong)b;

          for (uint j = 1; j < table.MaxOutput; j++) {
            Assert.AreEqual(j, table.Log(i));
            i *= b;
          }
          
        }
        [TestMethod]
        public virtual void Test007()
        {
          ulong b = 7;
          var table = new AccurateIntegerLogarithmTool((int)b);

          ulong i = (ulong)b;

          for (uint j = 1; j < table.MaxOutput; j++) {
            Assert.AreEqual(j, table.Log(i));
            i *= b;
          }
          
        }
        [TestMethod]
        public virtual void Test008()
        {
          ulong b = 8;
          var table = new AccurateIntegerLogarithmTool((int)b);

          ulong i = (ulong)b;

          for (uint j = 1; j < table.MaxOutput; j++) {
            Assert.AreEqual(j, table.Log(i));
            i *= b;
          }
          
        }

        
        [TestMethod]
        public virtual void Test009()
        {
          ulong b = 9;
          var table = new AccurateIntegerLogarithmTool((int)b);

          ulong i = (ulong)b;

          for (uint j = 1; j < table.MaxOutput; j++) {
            Assert.AreEqual(j, table.Log(i));
            i *= b;
          }
          
        }

        [TestMethod]
        public virtual void Test011()
        {
          ulong b = 10;
          var table = new AccurateIntegerLogarithmTool((int)b);

          ulong i = (ulong)b;

          for (uint j = 1; j < table.MaxOutput; j++) {
            Assert.AreEqual(j, table.Log(i+b-1));
            i *= b;
          }
          
        }

        
        [TestMethod]
        public virtual void Test012()
        {
          ulong b = 2;
          var table = new AccurateIntegerLogarithmTool((int)b);

          ulong i = (ulong)b;

          for (uint j = 1; j < table.MaxOutput; j++) {
            Assert.AreEqual(j, table.Log(i+b-1));
            i *= b;
          }
          
        }

        
        [TestMethod]
        public virtual void Test013()
        {
          ulong b = 3;
          var table = new AccurateIntegerLogarithmTool((int)b);

          ulong i = (ulong)b;

          for (uint j = 1; j < table.MaxOutput; j++) {
            Assert.AreEqual(j, table.Log(i+b-1));
            i *= b;
          }
          
        }

        [TestMethod]
        public virtual void Test014()
        {
          ulong b = 4;
          var table = new AccurateIntegerLogarithmTool((int)b);

          ulong i = (ulong)b;

          for (uint j = 1; j < table.MaxOutput; j++) {
            Assert.AreEqual(j, table.Log(i+b-1));
            i *= b;
          }          
        }
        
        [TestMethod]
        public virtual void Test015()
        {
          ulong b = 5;
          var table = new AccurateIntegerLogarithmTool((int)b);

          ulong i = (ulong)b;

          for (uint j = 1; j < table.MaxOutput; j++) {
            Assert.AreEqual(j, table.Log(i+b-1));
            i *= b;
          }
          
        }
        [TestMethod]
        public virtual void Test016()
        {
          ulong b = 6;
          var table = new AccurateIntegerLogarithmTool((int)b);

          ulong i = (ulong)b;

          for (uint j = 1; j < table.MaxOutput; j++) {
            Assert.AreEqual(j, table.Log(i+b-1));
            i *= b;
          }
          
        }
        [TestMethod]
        public virtual void Test017()
        {
          ulong b = 7;
          var table = new AccurateIntegerLogarithmTool((int)b);

          ulong i = (ulong)b;

          for (uint j = 1; j < table.MaxOutput; j++) {
            Assert.AreEqual(j, table.Log(i+b-1));
            i *= b;
          }
          
        }
        [TestMethod]
        public virtual void Test018()
        {
          ulong b = 8;
          var table = new AccurateIntegerLogarithmTool((int)b);

          ulong i = (ulong)b;

          for (uint j = 1; j < table.MaxOutput; j++) {
            Assert.AreEqual(j, table.Log(i+b-1));
            i *= b;
          }
          
        }

        
        [TestMethod]
        public virtual void Test019()
        {
          ulong b = 9;
          var table = new AccurateIntegerLogarithmTool((int)b);

          ulong i = (ulong)b;

          for (uint j = 1; j < table.MaxOutput; j++) {
            Assert.AreEqual(j, table.Log(i+b-1));
            i *= b;
          }
          
        }

        [TestMethod]
        public virtual void Test021()
        {
          ulong b = 10;
          var table = new AccurateIntegerLogarithmTool((int)b);

          ulong i = (ulong)b;

          for (uint j = 1; j < table.MaxOutput; j++) {
            Assert.AreEqual(j, table.Log(i+1));
            i *= b;
          }
          
        }

        
        [TestMethod]
        public virtual void Test022()
        {
          ulong b = 2;
          var table = new AccurateIntegerLogarithmTool((int)b);

          ulong i = (ulong)b;

          for (uint j = 1; j < table.MaxOutput; j++) {
            Assert.AreEqual(j, table.Log(i+1));
            i *= b;
          }
          
        }

        
        [TestMethod]
        public virtual void Test023()
        {
          ulong b = 3;
          var table = new AccurateIntegerLogarithmTool((int)b);

          ulong i = (ulong)b;

          for (uint j = 1; j < table.MaxOutput; j++) {
            Assert.AreEqual(j, table.Log(i+1));
            i *= b;
          }
          
        }

        [TestMethod]
        public virtual void Test024()
        {
          ulong b = 4;
          var table = new AccurateIntegerLogarithmTool((int)b);

          ulong i = (ulong)b;

          for (uint j = 1; j < table.MaxOutput; j++) {
            Assert.AreEqual(j, table.Log(i+1));
            i *= b;
          }          
        }
        
        [TestMethod]
        public virtual void Test025()
        {
          ulong b = 5;
          var table = new AccurateIntegerLogarithmTool((int)b);

          ulong i = (ulong)b;

          for (uint j = 1; j < table.MaxOutput; j++) {
            Assert.AreEqual(j, table.Log(i+1));
            i *= b;
          }
          
        }
        [TestMethod]
        public virtual void Test026()
        {
          ulong b = 6;
          var table = new AccurateIntegerLogarithmTool((int)b);

          ulong i = (ulong)b;

          for (uint j = 1; j < table.MaxOutput; j++) {
            Assert.AreEqual(j, table.Log(i+1));
            i *= b;
          }
          
        }
        [TestMethod]
        public virtual void Test027()
        {
          ulong b = 7;
          var table = new AccurateIntegerLogarithmTool((int)b);

          ulong i = (ulong)b;

          for (uint j = 1; j < table.MaxOutput; j++) {
            Assert.AreEqual(j, table.Log(i+1));
            i *= b;
          }
          
        }
        [TestMethod]
        public virtual void Test028()
        {
          ulong b = 8;
          var table = new AccurateIntegerLogarithmTool((int)b);

          ulong i = (ulong)b;

          for (uint j = 1; j < table.MaxOutput; j++) {
            Assert.AreEqual(j, table.Log(i+1));
            i *= b;
          }
          
        }

        
        [TestMethod]
        public virtual void Test029()
        {
          ulong b = 9;
          var table = new AccurateIntegerLogarithmTool((int)b);

          ulong i = (ulong)b;

          for (uint j = 1; j < table.MaxOutput; j++) {
            Assert.AreEqual(j, table.Log(i+1));
            i *= b;
          }
          
        }

        [TestMethod]
        public virtual void Test031()
        {
          ulong b = 10;
          var table = new AccurateIntegerLogarithmTool((int)b);

          ulong i = (ulong)b;

          for (uint j = 1; j < table.MaxOutput; j++) {
            Assert.AreEqual(j, table.Log(i+b/2));
            i *= b;
          }
          
        }

        
        [TestMethod]
        public virtual void Test032()
        {
          ulong b = 2;
          var table = new AccurateIntegerLogarithmTool((int)b);

          ulong i = (ulong)b;

          for (uint j = 1; j < table.MaxOutput; j++) {
            Assert.AreEqual(j, table.Log(i+b/2));
            i *= b;
          }
          
        }

        
        [TestMethod]
        public virtual void Test033()
        {
          ulong b = 3;
          var table = new AccurateIntegerLogarithmTool((int)b);

          ulong i = (ulong)b;

          for (uint j = 1; j < table.MaxOutput; j++) {
            Assert.AreEqual(j, table.Log(i+b/2));
            i *= b;
          }
          
        }

        [TestMethod]
        public virtual void Test034()
        {
          ulong b = 4;
          var table = new AccurateIntegerLogarithmTool((int)b);

          ulong i = (ulong)b;

          for (uint j = 1; j < table.MaxOutput; j++) {
            Assert.AreEqual(j, table.Log(i+b/2));
            i *= b;
          }          
        }
        
        [TestMethod]
        public virtual void Test035()
        {
          ulong b = 5;
          var table = new AccurateIntegerLogarithmTool((int)b);

          ulong i = (ulong)b;

          for (uint j = 1; j < table.MaxOutput; j++) {
            Assert.AreEqual(j, table.Log(i+b/2));
            i *= b;
          }
          
        }
        [TestMethod]
        public virtual void Test036()
        {
          ulong b = 6;
          var table = new AccurateIntegerLogarithmTool((int)b);

          ulong i = (ulong)b;

          for (uint j = 1; j < table.MaxOutput; j++) {
            Assert.AreEqual(j, table.Log(i+b/2));
            i *= b;
          }
          
        }
        [TestMethod]
        public virtual void Test037()
        {
          ulong b = 7;
          var table = new AccurateIntegerLogarithmTool((int)b);

          ulong i = (ulong)b;

          for (uint j = 1; j < table.MaxOutput; j++) {
            Assert.AreEqual(j, table.Log(i+b/2));
            i *= b;
          }
          
        }
        [TestMethod]
        public virtual void Test038()
        {
          ulong b = 8;
          var table = new AccurateIntegerLogarithmTool((int)b);

          ulong i = (ulong)b;

          for (uint j = 1; j < table.MaxOutput; j++) {
            Assert.AreEqual(j, table.Log(i+b/2));
            i *= b;
          }
          
        }

        
        [TestMethod]
        public virtual void Test039()
        {
          ulong b = 9;
          var table = new AccurateIntegerLogarithmTool((int)b);

          ulong i = (ulong)b;

          for (uint j = 1; j < table.MaxOutput; j++) {
            Assert.AreEqual(j, table.Log(i+b/2));
            i *= b;
          }
          
        }
    }
}

