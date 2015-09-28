using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taps;

namespace Test
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("TAP version 13");
      TAP.Ok(true, "This should Pass: Tap.Ok(true)");
      TAP.Fail("This should Fail: Tap.Fail()");
      TAP.Ok(false, "This should fail: Tap.Ok(false)");
    }
  }
}
