using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace n01378530_BonusAssignment_Timothy
{
    public partial class Bonus3RaffleBundle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // if post back
            if (IsPostBack)
            {
                // validate again
                Page.Validate();

                // if validated
                if (Page.IsValid)
                {

                    // == variables ==
                    int ClientTicketsTotal = Convert.ToInt32(client_tickets_total.Text);

                    /* Four conditions:
                     * x <= 50: individually
                     * 51 <= x <= 150: sets of 2
                     * 151 <= x <= 300: sets of 3
                     * 300 <= x: sets of 5
                     */
                    if (ClientTicketsTotal <= 50 && ClientTicketsTotal >= 1)
                    {
                        Output(ClientTicketsTotal, 1);
                    }
                    else if (ClientTicketsTotal >= 51 && ClientTicketsTotal <= 150)
                    {
                        Output(ClientTicketsTotal, 2);
                    }
                    else if (ClientTicketsTotal >= 151 && ClientTicketsTotal <= 300)
                    {
                        Output(ClientTicketsTotal, 3);
                    }
                    else if (ClientTicketsTotal >= 300)
                    {
                        Output(ClientTicketsTotal, 5);
                    }
                }
            }
        }
        /// <summary>
        /// output the result
        /// </summary>
        /// <param name="sets"></param>
        private void Output(int ClientTicketsTotal, int Sets)
        {
            // these show the user input, but not necessary
            bundle_summary.InnerHtml = "Input" + "<br>";
            bundle_summary.InnerHtml += "Number of tickets ordered: " + ClientTicketsTotal + "<br>" + "<br>";
            bundle_summary.InnerHtml += "Output" + "<br>";

            // the leftover
            int ClientTicketsLeft = ClientTicketsTotal;
            // price
            double Price = 0.25;
            // total price
            double TotalPrice = ClientTicketsTotal * Price;

            // loop breaks when the number of client tickets left is less then sets
            while (true)
            {

                bundle_summary.InnerHtml += "You received a bundle of " + Sets + "! That’s " + (ClientTicketsTotal - ClientTicketsLeft + Sets) + " ticket(s)!" + "<br>";
                ClientTicketsLeft -= Sets;

                if (ClientTicketsLeft < Sets)
                {
                    if (ClientTicketsLeft != 0)
                    {
                        bundle_summary.InnerHtml += "Your leftover is " + ClientTicketsLeft + " ticket(s). That’s " + ClientTicketsTotal + " ticket(s)!" + "<br>";
                    }
                    break;
                }
            }
            bundle_summary.InnerHtml += "<br>" + "Your total ticket(s) is " + ClientTicketsTotal + " and your cost is " + TotalPrice.ToString("c") + "cad!";

        }
    }
}