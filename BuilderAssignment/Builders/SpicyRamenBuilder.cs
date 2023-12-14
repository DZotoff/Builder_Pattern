using BuilderAssignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderAssignment.Builders
{
    /// - SpicyRamenBuilder
    ///     Recepie: 
    ///     - Broth: SpicyTonkotsu
    ///     - Noodles: Thin
    ///     - Toppings: Gashu Pork & Green Onions
    ///     - Extras: Extra Spice
    public class SpicyRamenBuilder : IRamenBuilder
    {
        private RamenBowl ramen = new RamenBowl();

        public void SetBroth(BrothType broth)
        {
            ramen.Broth = BrothType.SpicyTonkotsu;
        }

        public void SetNoodles(NoodleType noodles)
        {
            ramen.Noodles = NoodleType.Thin;
        }

        public void AddToppings(params Topping[] toppings)
        {
            ramen.Toppings = new Topping[] { Topping.ChashuPork, Topping.GreenOnions };
        }

        public void AddExtras(params Extra[] extras)
        {
            ramen.Extras = new Extra[] { Extra.ExtraSpice };
        }

        public RamenBowl GetRamen()
        {
            return ramen;
        }
    }
}
