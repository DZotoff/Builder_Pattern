﻿using BuilderAssignment.Models;

namespace BuilderAssignment.Builders
{
    /// <summary>
    /// This is an interface represeting the steps to build the ramen bowl
    /// </summary>
    public interface IRamenBuilder
    {
        // TODO#1: Add methods for following steps
        // - Setting broth
        // - Setting noodles
        // - Adding toppings
        // - Adding Extras

        /// <summary>
        /// Returns the value of build RamenBowl
        /// </summary>
        /// <returns></returns>
        void SetBroth(BrothType broth);
        void SetNoodles(NoodleType noodles);
        void AddToppings(params Topping[] toppings);
        void AddExtras(params Extra[] extras);

        RamenBowl GetRamen();
    }
}
