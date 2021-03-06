using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeTwoClaimsLibrary
{
    
    public class ClaimRepo
    {

        
        private Queue<Claim> _claimRepo = new Queue<Claim>();
        

        //Create
        public bool AddNewClaim(Claim newClaim)
        {
            int startingCount = _claimRepo.Count;
            _claimRepo.Enqueue(newClaim);
            bool wasAdded = _claimRepo.Count > startingCount; 
            return wasAdded;
        }

        //Read

        public Queue<Claim> ClaimList()
        {
            return _claimRepo;
        }

        //Update

        public Claim GetNextClaim()
        {
            return _claimRepo.Peek();
        }

        //Delete

        public bool DequeueClaim(Claim _testClaim)
        {
            int startingCount = _claimRepo.Count;
            _claimRepo.Dequeue();

            if (startingCount > _claimRepo.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }




    }
}
