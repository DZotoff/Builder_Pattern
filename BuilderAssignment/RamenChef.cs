using BuilderAssignment.Builders;
using BuilderAssignment.Models;

namespace BuilderAssignment
{
    public class RamenChef
    {
        public RamenBowl PrepareRamen(IRamenBuilder builder)
        {
            //TODO#1: Call each builder step declared in RamenBuilder class

            builder.SetBroth(BrothType.Tonkotsu); // Default values, you can change these
            builder.SetNoodles(NoodleType.Thin);

            // Customize the bowl using the builder's methods
            builder.AddToppings(Topping.ChashuPork, Topping.GreenOnions);
            builder.AddExtras(Extra.ExtraSpice);

            return builder.GetRamen(); //TODO#2: Finaly return build bowl of ramen
        }
    }
}
