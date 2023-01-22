using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MegaDesk_Raleigh
{
    public class DeskQuote
    {
        [Required]
        [MinLength(2)]
        [DataType(DataType.Text)]
        public string CustomerNameLast { get; set; }
        [Required]
        [MinLength(2)]
        [DataType(DataType.Text)]
        public string CustomerNameFirst { get; set;}
        public Desk DeskOrderd { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime QuoteDate { get; set; }
        
        public int DaysToComplete { get; set; }

        public DeskQuote()
        {
            CustomerNameLast = string.Empty;
            CustomerNameFirst = string.Empty;
            DeskOrderd = null;
            QuoteDate = DateTime.Now;
            DaysToComplete = 14;
        }

        public DeskQuote(
            string customerNameLast,
            string customerNameFirst,
            Desk deskOrderd,
            DateTime quoteDate,
            int daysToComplete)
        {
            CustomerNameLast = customerNameLast;
            CustomerNameFirst = customerNameFirst;
            DeskOrderd = deskOrderd;
            QuoteDate = quoteDate;
            DaysToComplete = daysToComplete;
        }

        public float GetPrice()
        {
            double surfaceArea = DeskOrderd.width * DeskOrderd.depth;
            float price = 200;

            // add in surface area cost
            if (surfaceArea > 1000)
            {
                price += (float)(surfaceArea - 1000) * 1;
            }

            // add in cost of drawers
            price += (DeskOrderd.drawers * 50);

            // add in cost of desk top material
            Dictionary<string, int> MaterialList = new Dictionary<string, int>();
            MaterialList.Add("Oak", 200);
            MaterialList.Add("Laminate", 100);
            MaterialList.Add("Pine", 50);
            MaterialList.Add("Rosewood", 300);
            MaterialList.Add("Veneer", 125);

            price += (MaterialList[DeskOrderd.surfaceMaterial]);

            // add in rush order cost
            switch (DaysToComplete)
            {
                case 3:
                    if (surfaceArea > 2000)
                        price += 80;
                    else if (surfaceArea > 1000)
                        price += 70;
                    else price += 60;
                    break;
                case 5:
                    if (surfaceArea > 2000)
                        price += 60;
                    else if (surfaceArea > 1000)
                        price += 50;
                    else price += 40;
                    break;
                case 7:
                    if (surfaceArea > 2000)
                        price += 40;
                    else if (surfaceArea > 1000)
                        price += 35;
                    else price += 30;
                    break;
            }

            return price;
        }

        private double GetSurfaceArea()
        {
            return DeskOrderd.width * DeskOrderd.depth;
        }
    }
}
