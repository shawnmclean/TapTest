﻿using System;
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
      TAP.Ok(true, "hello");
      TAP.Fail("ouch");
      TAP.Ok(false);
    }
  }
}
