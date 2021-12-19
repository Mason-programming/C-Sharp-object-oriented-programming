using System;
using System.Collections.Generic;
using System.Text;

namespace midTerm
{
    class PerferredCustomer: Customer
    {
        //declare private varibles 
        private float AmountPurchased;
        private double Discount; 
        
        public PerferredCustomer( int CN, bool l, string n, string a, string TN) : base(CN,l,n,a,TN)
        {
         
            CustomerNum = CN;
            onList = l; 
            name = n;
            Address = a;
            TelephoneNumber = TN;
        }

        // get and set method for privatet amountPurchased propertie
        public float amountPurchased
        {
            get
            {
                return AmountPurchased; 
            }
            set
            {
                AmountPurchased = value; 
            }
          
        }
        // get and set method for privatet discount propertie
        public double discount
        {
            get
            {
                return Discount * 100; 
            }
            set
            {
                if(AmountPurchased >= 500 && AmountPurchased <= 1000)
                {
                    Discount = 0.05;
                }else if(AmountPurchased >= 1001 && AmountPurchased <= 1499)
                {
                    Discount = 0.06;
                }else if(AmountPurchased >= 1500 && AmountPurchased <= 5000)
                {
                    Discount = 0.07;
                }
                else
                {
                    Discount = 0.04; 
                }
            }
        }

        
    }
}
