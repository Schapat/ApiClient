using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Steam
{
    public class DriverInfo
    {
        public List<String> drivers;

        public DriverInfo()
        {
            drivers = new List<String>();
            getDrives();
        }


        private void getDrives()
        {
            var allDrives = DriveInfo.GetDrives();

            foreach (DriveInfo d in allDrives)
            {
                drivers.Add(d.Name);
            }
        }
    }
}