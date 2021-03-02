using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;

namespace CleanUp_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            List<HardDrive> hardDriveList = ManagerSystem.GetHardDriveData();
            List<HardDrive> serialNumberList = ManagerSystem.GetHardDriveData("C");
            List<OSSystem> operatingSystems = ManagerSystem.GetOS();
            List<Memory> memories = ManagerSystem.GetMemory();
            List<BootDrive> bootDevices = ManagerSystem.GetBootDrives();
            List<string> disks = DalManager.PopulateDisk();
            List<CPUPower> cPUUsages = DalManager.CPUPower();
        }

    }

}

