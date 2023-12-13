using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderAssignment.Models
{
    /// <summary>
    /// This class represents the final bowl of ramen
    /// It should have attributes like broth, type of noodle, toppings and extras
    /// </summary>
    public class RamenBowl
    {
        //TODO#1: Add attributes for each enum in IngredientEnums.cs file

        //TODO#2: Return description of finished bowl of ramen

        public BrothType Broth { get; set; }
        public NoodleType Noodles { get; set; }
        public Topping[] Toppings { get; set; }
        public Extra[] Extras { get; set; }
        public static string FinishedBowlOfRamen(RamenBowl ramen)
        {
            StringBuilder description = new StringBuilder();

            description.AppendLine($"Broth: {ramen.Broth}");
            description.AppendLine($"Noodles: {ramen.Noodles}");

            if (ramen.Toppings != null && ramen.Toppings.Length > 0)
            {
                description.AppendLine("Toppings: " + string.Join(", ", ramen.Toppings));
            }

            if (ramen.Extras != null && ramen.Extras.Length > 0)
            {
                description.AppendLine("Extras: " + string.Join(", ", ramen.Extras));
            }
            return description.ToString();
        }
    }
}
