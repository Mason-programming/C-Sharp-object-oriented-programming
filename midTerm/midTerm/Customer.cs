using System;
using System.Collections.Generic;
using System.Text;

namespace midTerm
{
    // creates customer subclass 
    class Customer: Person

    {
        public int CustomerNum;
        public bool onList; 
        public Customer(int CN, bool l, string n, string a, string TN): base(n, a, TN)
        {
            CustomerNum = CN;
            onList = l;
            name = n;
            Address = a;
            TelephoneNumber = TN;
        }

    }
}
