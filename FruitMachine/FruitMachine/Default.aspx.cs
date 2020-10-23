using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FruitMachine
{
    public partial class Default : System.Web.UI.Page
    {
        string[] images = new string[12];

        protected void Page_Load(object sender, EventArgs e)
        {
            images[0] = "Bar";
            images[1] = "Bell";
            images[2] = "Cherry";
            images[3] = "Diamond";
            images[4] = "HorseShoe";
            images[5] = "Lemon";
        }
    }
}