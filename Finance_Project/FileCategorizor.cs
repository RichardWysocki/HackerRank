using System;
using System.Collections.Generic;
using System.Text;

namespace Finance_Project
{
    public class FileCategorizor
    {
        public FileCategorizor()
        {
            
        }

        public DataRecord Execute(DataRecord record)
        {
            if (record.CreditCard.Contains("CRICKET WIRELESS"))
            {
                record.Category = "Phone";
            }
            if (record.CreditCard.Contains("DIRECTV*NOW"))
            {
                record.Category = "TV";
            }
            if (record.CreditCard.Contains("ALLSTATE *PAYMENT"))
            {
                record.Category = "Insurance";
            }
            if (record.CreditCard.Contains("ALLSTATE *PAYMENT"))
            {
                record.Category = "Insurance";
            }
            if (record.CreditCard.Contains("Woodward Camp") || record.CreditCard.Contains("OMNI CHEER") || record.CreditCard.Contains("PAYPAL *UMDGC UMAS") || record.CreditCard.Contains("UDJUPPER DUBLIN JR"))
            {
                record.Category = "Cheer";
            }

            return record;

        }

    }
}
