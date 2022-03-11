using System;

namespace Indexers
{
    class Customers
    {
        int CId;
        bool Status;
        string CName;
        string Address;
        double Balance;
        Cities City;



        public Customers(int CId, string CName, string Address, bool Status, double Balance, Cities City)
        {

            this.CId = CId;
            this.CName = CName;
            this.Address = Address;
            this.Status = Status;
            this.Balance = Balance;
           this.City = City;

        }

        public object  this[int index]
        {
            get
            {
                if (index == 0)
                    return CId;
                else if (index == 1)
                    return CName;
                else if (index == 2)
                    return Address;
                else if (index == 3)
                    return Status;
                else if (index == 4)
                    return Balance;
                else if (index == 5)
                    return City;
                return null;
            }

            set
            {
                if (index == 0)
                    CId = (int)value;
                if (index == 1)
                    CName = (string)value;
                if (index == 2)
                    Address = (string)value;
                if (index == 3)
                    Status = (bool)value;
                if (index == 4)
                    Balance = (int)value;
                if (index == 5)
                    City = (Cities)value;
            }
        }



    }
}
