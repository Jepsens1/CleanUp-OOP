using System;
using System.Collections.Generic;
using System.Text;

namespace CleanUp_OOP
{
    class ManagerSystem
    {
        public static List<BootDrive> GetBootDrives()
        {
            return DalManager.GetBootDrives();
        }

        public static string GetServices()
        {
            return DalManager.GetServices();
        }

        public static List<string> PopulateDisk()
        {
            return DalManager.PopulateDisk();
        }
        public static List<CPUPower> CpuPower()
        {
            return DalManager.CPUPower();
        }
        public static List<HardDrive> GetHardDriveData()
        {
            return DalManager.GetHardDriveData();
        }

        public static List<HardDrive> GetHardDriveData(string drive)
        {
            return DalManager.GetHardDiskSerialNumber(drive);
        }

        public static List<OSSystem> GetOS()
        {
            return DalManager.GetOS();
        }

        public static List<Memory> GetMemory()
        {
            return DalManager.GetMemory();
        }

     
    }
}
