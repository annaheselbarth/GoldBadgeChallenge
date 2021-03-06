using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeTwoClaimsLibrary
{
    public enum ClaimType { Car = 1, Home, Theft}
    public class Claim
    {
        public int ClaimID { get; set; }
        public ClaimType TypeOfClaim { get; set; }
        public string ClaimDescription { get; set; }
        public decimal ClaimAmount { get; set; }
        public DateTime DateOfIncident { get; set; }
        public DateTime DateOfClaim { get; set; }
        public bool IsValid
        {
            get
            {
                double numberOfDays = (DateOfClaim - DateOfIncident).TotalDays;
                if (numberOfDays > 30d)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }
        public Claim()
        {

        }
        public Claim(int claimID, ClaimType claimType, string descriptionOfClaim, decimal claimAmount, DateTime dateOfIncident, DateTime dateOfClaim)
        {
            ClaimID = claimID;
            TypeOfClaim = claimType;
            ClaimDescription = descriptionOfClaim;
            ClaimAmount = claimAmount;
            DateOfIncident = dateOfIncident;
            DateOfClaim = dateOfClaim;
        }
    }
}
