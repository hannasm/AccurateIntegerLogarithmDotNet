using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace AccurateIntegerLogarithm.Tests {
  [TestClass]
    public class PerfTests
    {
        [TestMethod]
        public virtual void Test001()
        {
          var b = 10;
          var iterations = 10000;
          var table = new AccurateIntegerLogarithmTool(b);
          var rndMth = new Random(1024);
          var rndAcc = new Random(1024);

          var timerMth = Stopwatch.StartNew();
          for (int sm = 0; sm < iterations; sm++) {
            var x = Math.Log(rndMth.Next(), b);
          }
          timerMth.Stop();

          var timerAcc = Stopwatch.StartNew();
          for (int sa = 0; sa < iterations; sa++) {
            var x = table.Log(rndAcc.Next());
          }
          timerAcc.Stop();

          Console.WriteLine("Math.Log completed in {0} ticks", timerMth.ElapsedTicks);
          Console.WriteLine("Accurate Integer Logarithm completed in {0} ticks", timerAcc.ElapsedTicks);
        }
        [TestMethod]
        public virtual void Test002()
        {
          var b = 10;
          var iterations = 10000;
          var table = new AccurateIntegerLogarithmTool(b);
          var rndMth = new Random();
          var rndAcc = new Random();

          var timerMth = Stopwatch.StartNew();
          for (int sm = 0; sm < iterations; sm++) {
            var x = Math.Log(rndMth.Next(), b);
          }
          timerMth.Stop();

          var timerAcc = Stopwatch.StartNew();
          for (int sa = 0; sa < iterations; sa++) {
            var x = table.Log(rndAcc.Next());
          }
          timerAcc.Stop();

          Console.WriteLine("Math.Log completed in {0} ticks", timerMth.ElapsedTicks);
          Console.WriteLine("Accurate Integer Logarithm completed in {0} ticks", timerAcc.ElapsedTicks);
        }
    }
}

