using BuilderAssignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderAssignment.Builders
{

    /// - MisoRamenBuilder
    ///     Recepie: 
    ///     - Broth: Miso
    ///     - Noodles: Udon
    ///     - Toppings: Green Onions
    ///     - Extras: Corn <summary>
    /// - MisoRamenBuilder
 
    public class MisoRamenBuilder : IRamenBuilder
    {
        private RamenBowl ramen = new RamenBowl();

        public void SetBroth(BrothType broth)
        {
            ramen.Broth = BrothType.Miso;
        }

        public void SetNoodles(NoodleType noodles)
        {
            ramen.Noodles = NoodleType.Udon;
        }

        public void AddToppings(params Topping[] toppings)
        {
            ramen.Toppings = new Topping[] { Topping.GreenOnions };
        }

        public void AddExtras(params Extra[] extras)
        {
            ramen.Extras = new Extra[] { Extra.Corn };
        }

        public RamenBowl GetRamen()
        {
            return ramen;
        }
    }
}
