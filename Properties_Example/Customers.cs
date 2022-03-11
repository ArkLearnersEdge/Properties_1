using System;

namespace Properties_Example
{
    class Customers
    {
        int _CId;
        bool _Status;
        string _CName;
        string _Address;
        double _Balance;
        Cities _City;



        public Customers(int CId, string CName,string Address, bool Status, double Balance, Cities City)
        {

            _CId = CId;
            _CName = CName;
            _Address = Address;
           _Status = Status;
            _Balance = Balance;
            _City = City;

        }
       
        // getting values from instance read only property
        /*public int get_Cust_Id()
        {
            return CId;
        }
        public string get_Cust_Name()
        {
            return CName;
        }
        // setting values from instance write only property
        public void set_Cust_Id(int value)
        {
            CId = value;
        }
        public void set_Cust_Name(string Value)
        {
            CName = Value;
        }
        */
       
                public  int CId
                {
	                get{return _CId;} // Read only

                    set{ _CId = value; } // write only
            
                }
                 public string CName
                 {
                    get { return _CName; }
                    set { if(_Status == true)
                             _CName = value;
                        }
                 }
        public bool Status
        {
            get { return _Status; }
            set { _Status = value; }
        }
        public double Balance
        {
            get { return _Balance; }
            set {
                if (_Status == true)
                    _Balance = value; 
            }
        }
        public Cities City
        {
            get { return _City; }// read only

            set {if (_Status == true)
                
                    _City = value;
            }
        }




       // [<Modifier><Type> this[int index]
       // {
       //  [get{<statement>}]  Get Accessor
       //  [Set {<statement>}] set accessor
       // }
       /*
        public object this[int index]
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
                else if (index == 6)
                    return CName;

                return null;
            }


        }
        */


    }
}
