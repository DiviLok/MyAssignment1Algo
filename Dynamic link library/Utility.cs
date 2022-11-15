using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic_link_library
{
    public class Utility
    {
        public static void ElapseTime(Stopwatch sp, String msg)
        {
           TimeSpan ts = sp.Elapsed;

            String elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);
            Console.WriteLine("\n"+ msg + elapsedTime);

        }
    }
}
