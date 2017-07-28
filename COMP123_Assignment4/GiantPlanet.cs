using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Student ID: 300921431
 Student Name: Mikang Kim 
 This class is 'GiantPlanet' that is a subclass of the Planet Abstract class.
 It will also implement both the IHasMoons and IHasRings interfaces. 
     */

namespace COMP123_Assignment4
{
    class GiantPlanet : Planet, IHasMoons, IHasRings
    {
        /// <summary>
        /// holdding a string that describes
        /// the type of Giant Planet (either “Gas” or “Ice”)
        /// </summary>
        private string _type;
        public GiantPlanet(string name, double diameter, double mass, string type)

        {
            if (type == "Gas")

                _type = "Gas";

            else if (type == "Ice")

                _type = "Ice";

        }

        /// <summary>
        /// return true if the MoonCount property is greater than zero
        /// </summary>
        public bool IHasMoons()
        {
            if (MoonCount > 0)
            {
                return true;
            }

            else
                return false;
        }

        /// <summary>
        /// return true if the RingCount property is greater than zero
        /// </summary>
        public bool IHasRings()
        {
            if (RingCount > 0)
            {
                return true;
            }

            else
                return false;
        }
    }
}
