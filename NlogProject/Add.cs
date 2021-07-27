using System;
using System.Collections.Generic;
using System.Text;

namespace NlogProject
{
    class Add
    {
        static NLog nlog = new NLog();

        public void sum(int no1,int no2)
        {
            if (no1 == 0 || no2 == 0)
            {
                nlog.LogInfo("Sub method");
                nlog.LogDebug("Debug Successful");
                nlog.LogError("First Number or Second Number is zero.");

            }
            else
            {
                int sum = no1 + no2;
                nlog.LogInfo("Sub method");
                nlog.LogDebug("Debug Successful");
                nlog.LogWarn("First Number or Second Number is zero.");
                Console.WriteLine("sum :" + sum);
            }
        }
    }
}
