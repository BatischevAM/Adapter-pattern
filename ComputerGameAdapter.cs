using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_pattern
{
    public class ComputerGameAdapter : PCGame
    {
        private readonly ComputerGame _computerGame;

        public ComputerGameAdapter(ComputerGame computerGame)
        {
            _computerGame = computerGame;
        }

        public string Title()
        {
            return _computerGame.Name();
        }

        public int PegiAllowedAge()
        {
            
            return (int)_computerGame.PegiAgeRating();
        }

        public bool isTripleAGame()
        {
           
            return _computerGame.BudgetInMillionsOfDollars() >= 50;
        }

        public Requirements Requirements()
        {
           
            return new Requirements
            (
                _computerGame.MinimumGpuMemoryInMegabytes() / 1024,
                _computerGame.DiskSpaceNeededInGB(),
                _computerGame.RamNeededInGb(),
                _computerGame.CoreSpeedInGhz(),
                _computerGame.CoresNeeded()
            );
        }
    }
}
