using System;
using System.Collections.Generic;
using System.Text;

namespace CleanUp_OOP
{
    class Memory
    {
        private double memorySize;

        public double MemorySize
        {
            get { return memorySize; }
            set { memorySize = value; }
        }

        private double physicalMemory;

        public double PhysicalMemory
        {
            get { return physicalMemory; }
            set { physicalMemory = value; }
        }

        private double virtualSize;

        public double VirtualSize
        {
            get { return virtualSize; }
            set { virtualSize = value; }
        }

        private double virtualMemory;

        public double VirtualMemory
        {
            get { return virtualMemory; }
            set { virtualMemory = value; }
        }
        public Memory()
        {

        }

        public Memory(double _visibleMemorySize, double _physicalMemory, double _virtualMemorySize, double _virtualMemory)
        {
            MemorySize = _visibleMemorySize;
            PhysicalMemory = _physicalMemory;
            VirtualSize = _virtualMemorySize;
            VirtualMemory = _virtualMemory;
        }

    }
}
