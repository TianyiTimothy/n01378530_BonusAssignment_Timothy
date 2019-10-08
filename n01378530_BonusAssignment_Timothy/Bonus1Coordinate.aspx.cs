using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace n01378530_BonusAssignment_Timothy
{
    public partial class Coordinate : System.Web.UI.Page
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
                    int XAxis = Convert.ToInt32(x_axis.Text);
                    int YAxis = Convert.ToInt32(y_axis.Text);

                    bool IsXGreaterThanZero = XAxis > 0;
                    bool IsXLessThanZero = XAxis < 0;
                    bool IsXZero = XAxis == 0;
                    bool IsYGreaterThanZero = YAxis > 0;
                    bool IsYLessThanZero = YAxis < 0;
                    bool IsYZero = YAxis == 0;

                    string QuadrantString;

                    // start from quadrant, counterclockwise, put conclusion to QuadrantString
                    if (IsXGreaterThanZero && IsYGreaterThanZero)
                    {
                        QuadrantString = "quadrant 1";
                    }
                    else if (IsXZero && IsYGreaterThanZero)
                    {
                        QuadrantString = "positive y axis";
                    }
                    else if (IsXLessThanZero && IsYGreaterThanZero)
                    {
                        QuadrantString = "quadrant 2";
                    }
                    else if (IsXLessThanZero && IsYZero)
                    {
                        QuadrantString = "negative x axis";
                    }
                    else if (IsXLessThanZero && IsYLessThanZero)
                    {
                        QuadrantString = "quadrant 3";
                    }
                    else if (IsXZero && IsYLessThanZero)
                    {
                        QuadrantString = "negative y axis";
                    }
                    else if (IsXGreaterThanZero && IsYLessThanZero)
                    {
                        QuadrantString = "quadrant 4";
                    }
                    else if (IsXGreaterThanZero && IsYZero)
                    {
                        QuadrantString = "positive x axis";
                    }
                    else
                    {
                        QuadrantString = "none of the quadrants";
                    }

                    // draw the conclusion with QuadrantString
                    result_summary.InnerHtml = "(" + XAxis + ", " + YAxis + ")" + " falls in " + QuadrantString;

                }
            }

        }
    }
}