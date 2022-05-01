using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Steam
{
    public class HddInfo
    {
        public List<String> drives;

        public HddInfo()
        {
            drives = new List<String>();
            getDrives();
        }


        private void getDrives()
        {
            var allDrives = DriveInfo.GetDrives();

            foreach (DriveInfo d in allDrives)
            {
                drives.Add(d.Name);
            }
        }
    }
}