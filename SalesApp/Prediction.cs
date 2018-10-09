using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesApp
{
    class Prediction
    {
        public void GetSalesProjection(int monthsPast, int monthsAhead)
        {
            // Collect all of the differences in sales over monthsPast

            //// Collection of sales over monthsPast
            List<float> differences = new List<float>();    // Was array, but list seemed easier due to .Add()

            for (int i = 1; i < monthsPast; i++)
            {
                ////differences.Add(months[i] - months[i-1]);
            }

            // Calculate the average differences in the last 3 months

            float modifier = differences.Average();

            // Project sales over monthsAhead

            List<float> projections = new List<float>();

            for (int i = 0; i < monthsAhead; i++)
            {
                //projections.Add(months[months.Length] + modifier);    // This might need to be redone
            }
        }

        /* Drew's notes
        // Collect all of the differences in sales over the alst X months
        float[] differences;

        for (int i = 1; i < months.length; i++)
	        differences.Add(months[i] - months[i-1]);
	
        // Calculate the average differences in the last 3 months
        float modifier = Sum(differences);

        modifier /= differences.Length;

        float[] projections;

        for (int i = 0; i < projectAmt; i++)
	        projections.Add(months[months.Length] + modifier);	// This might need to be redone
	
	
	
	
        16 13 18 20

        13 - 16 = -3
        18 - 13 = 5
        20 = 18 = 2

        Avg = 2

        20 + 2 = 22
        22 + 2 = 24
        24 + 2 = 26
        26 + 2 = 28


        for (int i = 0; i < numMonths; i++)
	        months.Add(GETMONTH[i]);
        */

        /*  Brock's stuff
        
        public void PopulateMonthsArray(int year, int month) {


        }

        public void GetLastMonths(int amount)
        {

            
        }
        */
    }
}
