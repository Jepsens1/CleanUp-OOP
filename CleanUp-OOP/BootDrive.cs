using System;
using System.Collections.Generic;
using System.Text;

namespace CleanUp_OOP
{
    class BootDrive
    {
        private string device;

        public string Device
        {
            get { return device; }
            set { device = value; }
        }
        public BootDrive()
        {

        }

        public BootDrive(string _device)
        {
            Device = _device;
        }
      
    }
}
