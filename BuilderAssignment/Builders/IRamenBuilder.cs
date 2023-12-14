using BuilderAssignment.Models;

namespace BuilderAssignment.Builders
{
    /// <summary>
    /// This is an interface represeting the steps to build the ramen bowl
    /// </summary>
    public interface IRamenBuilder
    {
        // TODO#1: Add methods for following steps
        // - Setting broth
        void SetBroth(BrothType broth);
        // - Setting noodles
        void SetNoodles(NoodleType noodles);
        // - Adding toppings
        void AddToppings(params Topping[] toppings);
        // - Adding Extras
        void AddExtras(params Extra[] extras);


        /// <summary>
        /// Returns the value of build RamenBowl
        /// </summary>
        RamenBowl GetRamen();
    }
}
