using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeForXmenBattleCount
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Wolverine fewest battles
            // Pheonix most battles

            string[] names = new string[] { "Professor X", "Iceman", "Angel", "Beast", "Pheonix", "Cyclops", "Wolverine", "Nightcrawler", "Storm", "Colossus" };
            int[] numbers = new int[] { 7, 9, 12, 15, 17, 13, 2, 6, 8, 13 };

            string result = "";


            int mostBattles = 0;
            int leastBattles = 0;
            //Determine most and least battles
            for (int i = 0; i < names.Length; i++)
            {
                //is this the most battles so far?
                if (numbers[i] > numbers[mostBattles])
                {
                    mostBattles = i;
                }

                if (numbers[i] < numbers[leastBattles])
                {
                    leastBattles = i;
                }
                //is this the least battles so far?

            }

            //Output results
            resultLabel.Text = "Most battles belongs to: " + names[mostBattles] + " (Value: " + numbers[mostBattles] + ").<br >" +
            "Least battles belongs to: " + names[leastBattles] + " (Value: " + numbers[leastBattles] + ").";
        }
    }
}