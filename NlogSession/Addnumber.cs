using System;
using System.Collections.Generic;
using System.Text;
using NLog;

namespace NlogSession
{
    class Addnumber
    {
        private readonly Nlog nLog = new Nlog();
        public int Sum(int firstNumber, int secondNumber)
        {
            if (firstNumber == 0 || secondNumber == 0)
            {
                nLog.LogDebug("Debug Successfull : Sum()");
                nLog.LogError("Expecting null values");
                nLog.LogWarn("firstNumber or secondNumber should not equal to 0");
            }
            int result = firstNumber + secondNumber;
            nLog.LogDebug("Debug Successfull : Sum()");
            nLog.LogInfo("Sum Method passed, Result" + result);
            return result;
        }


    }
}

