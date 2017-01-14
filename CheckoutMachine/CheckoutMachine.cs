using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckoutMachine
{
    public class CheckoutMachine
    {
        int balance = 0;
        bool bonusCardScanned = false;
        int salsaCounter = 0;
        int chipCoutner = 0;

        public void Scan(string sku)
        {
            if (sku == "123")
            {
                chipCoutner ++;
                balance = balance + 200;
            }
            if (sku == "456")
            {
                salsaCounter ++;
                balance = balance + 100;
            }
            if (sku == "789")
            {
                balance = balance + 1000;
            }
            if (sku == "111")
            {
                balance = balance + 550;
            }

            if (sku == "000")
            {
                bonusCardScanned = true;
            }
        }

        public int Total()
        {
            if (bonusCardScanned)
            {
                balance = balance - (50 * salsaCounter);

                int chipDeals = Convert.ToInt32(Math.Floor(chipCoutner / (double)3));
                balance = balance - 200 * chipDeals;
            }
            return balance;
        }
    }
}
