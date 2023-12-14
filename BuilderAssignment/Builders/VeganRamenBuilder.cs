using BuilderAssignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderAssignment.Builders
{
    /// - VeganRamenBuilder
    ///     Recepie: 
    ///     - Broth: Vegan
    ///     - Noodles: Soba
    ///     - Toppings: Bambo Shoots & Seaweed
    ///     - Extras: no extras
    public class VeganRamenBuilder : IRamenBuilder
    {
        private RamenBowl ramen = new RamenBowl();

        public void SetBroth(BrothType broth)
        {
            ramen.Broth = BrothType.Vegan;
        }

        public void SetNoodles(NoodleType noodles)
        {
            ramen.Noodles = NoodleType.Soba;
        }

        public void AddToppings(params Topping[] toppings)
        {
            ramen.Toppings = new Topping[] { Topping.BambooShoots, Topping.Seaweed };
        }

        public void AddExtras(params Extra[] extras)
        {
            ramen.Extras = new Extra[] { };
        }

        public RamenBowl GetRamen()
        {
            return ramen;
        }
    }
}
