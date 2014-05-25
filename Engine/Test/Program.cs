
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenGlobe.Core;
using Engine.Core;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Matrix4D derp = Matrix4D.Identity;

            Stopwatch watch = new Stopwatch();
            watch.Start();
                for (int i = 0; i < 100; i++)
                {
                    derp = derp * derp;
                }
            watch.Stop();
            Console.WriteLine(watch.ElapsedMilliseconds);
        }
    }
}
