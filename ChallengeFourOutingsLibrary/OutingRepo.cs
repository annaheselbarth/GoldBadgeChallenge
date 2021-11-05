using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeFourOutingsLibrary
{
    
    public class OutingRepo
    {

        private List<Outing> _outingRepo = new List<Outing>();

        public bool AddOuting(Outing newOuting)
        {
            int startingCount = _outingRepo.Count;
            _outingRepo.Add(newOuting);
            bool wasAdded = _outingRepo.Count > startingCount;
            return wasAdded;
        }

        public List<Outing> OutingList()
        {
            return _outingRepo;
        }



    }
}
