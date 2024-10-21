using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_pattern
{
    public class ComputerGame
    {
        private string name;
        private PegiAgeRating pegiAgeRating;
        private double budgetInMillionsOfDollars;
        private int minimumGpuMemoryInMegabytes;
        private int diskSpaceNeededInGB;
        private int ramNeededInGb;
        private int coresNeeded;
        private double coreSpeedInGhz;

        public ComputerGame(string name,
                            PegiAgeRating pegiAgeRating,
                            double budgetInMillionsOfDollars,
                            int minimumGpuMemoryInMegabytes,
                            int diskSpaceNeededInGB,
                            int ramNeededInGb,
                            int coresNeeded,
                            double coreSpeedInGhz)
        {
            this.name = name;
            this.pegiAgeRating = pegiAgeRating;
            this.budgetInMillionsOfDollars = budgetInMillionsOfDollars;
            this.minimumGpuMemoryInMegabytes = minimumGpuMemoryInMegabytes;
            this.diskSpaceNeededInGB = diskSpaceNeededInGB;
            this.ramNeededInGb = ramNeededInGb;
            this.coresNeeded = coresNeeded;
            this.coreSpeedInGhz = coreSpeedInGhz;
        }

        public string Name()
        {
            return name;
        }

        public PegiAgeRating PegiAgeRating()
        {
            return pegiAgeRating;
        }

        public double BudgetInMillionsOfDollars()
        {
            return budgetInMillionsOfDollars;
        }

        public int MinimumGpuMemoryInMegabytes()
        {
            return minimumGpuMemoryInMegabytes;
        }

        public int DiskSpaceNeededInGB()
        {
            return diskSpaceNeededInGB;
        }

        public int RamNeededInGb()
        {
            return ramNeededInGb;
        }

        public int CoresNeeded()
        {
            return coresNeeded;
        }

        public double CoreSpeedInGhz()
        {
            return coreSpeedInGhz;
        }
    }

    public enum PegiAgeRating
    {
        P3 = 3, P7 = 7, P12 = 12, P16 = 16, P18 =18
    }

}
