using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Model
{
    public class Contract
    {
        private const double minFTE = 0.1;
        private const double maxFTE = 1;
        private double fte;

        public double FTE
        {
            get { return fte; }
            set 
            {
                if (value < minFTE || value > maxFTE)
                {
                    throw new ArgumentException("Invalid FTE value");
                }
                fte = value; 
            }
        }
        public bool IsTemporary { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime ExpirationDate { get; set; }
    }
}
