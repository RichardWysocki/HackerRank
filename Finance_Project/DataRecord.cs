using System;
using System.Collections.Generic;
using System.Text;

namespace Finance_Project
{
    public class DataRecord
    {
        //Should have properties which correspond to the Column Names in the file
        //i.e. CommonName,FormalName,TelephoneCode,CountryCode
        public DateTime Date { get; set; }
        public Decimal Charge { get; set; }
        public String Miss { get; set; }
        public String Category { get; set; }
        public String CreditCard { get; set; }

    }
}
