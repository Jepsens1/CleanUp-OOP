using System;
using System.Collections.Generic;
using System.Text;

namespace CleanUp_OOP
{
    class CPUPower
    {
        private int timeProcess;

        public int TimeProcess
        {
            get { return timeProcess; }
            set { timeProcess = value; }
        }
        private string cpuName;

        public string CpuName
        {
            get { return cpuName; }
            set { cpuName = value; }
        }
        public CPUPower()
        {

        }
        public CPUPower(int _timeProcess, string _CpuName)
        {
            TimeProcess = _timeProcess;
            CpuName = _CpuName;
        }


    }
}
