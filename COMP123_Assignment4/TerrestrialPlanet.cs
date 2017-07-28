using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Student ID: 300921431
 Student Name: Mikang Kim 
 This class TerrestrialPlanet that is a subclass of the Planet Abstract class.
 It will also implement both the IHasMoons and IHabitable interfaces.
     */

namespace COMP123_Assignment4
{
    class TerrestrialPlanet
    {
        private bool _oxygen;

        public TerrestrialPlanet(bool oxygen, string name, double diameter, double mass)
           
        {
            this._oxygen = oxygen;
        }
        /// <summary>
        /// will return true if the oxygen instance variable is set to true
        /// <summary>
        public bool IHabitable()
        {
            if (_oxygen == true)
            {
                return true;
            }
        
            else
                return false;
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
    }
}
