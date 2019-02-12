using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestSYS
{
    class FoodTypes
    {
        //Instance variables
        private char foodType;
        private string description;

        //no argument constructor
        public FoodTypes()
        {
            foodType = 'M';
            description = "Main dish";
        }

        //argument constructor
        public FoodTypes(char foodType , string description)
        {
            this.foodType = foodType;
            this.description = description;
        }

        //Define setters


    }
}
