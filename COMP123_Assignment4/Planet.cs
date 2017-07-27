using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace COMP123_Assignment4
{

    /*
     Student ID: 300921431
     Student Name: Mikang Kim 
     This is The Abstract Class 'Planet'
     includes Properties and Methods    
         */
    public abstract class Planet
    {
        /// <summary>
        /// Private Instance Variables
        /// </summary>
        private double _diameter;
        /// <summary>
        /// Private Instance Variables
        /// </summary>
        private double _mass;
        /// <summary>
        /// Private Instance Variables
        /// </summary>
        private int _moonCount;
        /// <summary>
        /// Private Instance Variables
        /// </summary>
        private string _name;
        /// <summary>
        /// Private Instance Variables
        /// </summary>
        private double _orbitalPeriod;
        /// <summary>
        /// Private Instance Variables
        /// </summary>
        private int _ringCount;
        /// <summary>
        /// Private Instance Variables
        /// </summary>
        private double _rotationPeriod;

        /// <summary>
        /// Read Only
        /// </summary>
        public double Diameter
        {
            get
            {
                return this._diameter;
            }
        }
        /// <summary>
        /// Read Only
        /// </summary>
        public double Mass
        {
            get
            {
                return this._mass;
            }
        }
        /// <summary></summary>
        public int MoonCount
        {
            get
            {
                return this._moonCount;
            }
            set
            {
                this._moonCount = value;
            }
        }
        /// <summary>
        /// Read Only
        /// </summary>
        public string Name
        {
            get
            {
                return this._name;
            }
        }
        public double OrbitalPeriod
        {
            get
            {
                return this._orbitalPeriod;
            }
            set
            {
                this._orbitalPeriod = value;
            }
        }
        public int RingCount
        {
            get
            {
                return this._ringCount;
            }
            set
            {
                this._ringCount = value;
            }
        }
        public double RotationPeriod
        {
            get
            {
                return this._rotationPeriod;
            }
            set
            {
                this._rotationPeriod = value;
            }
        }
        /// <summary>
        /// This Method constructor takes name, diameter and mass
        /// as local variables and set the related instance variables to their values
        /// </summary>
        public Planet(string name, double diameter, double mass)
        {
            this._name = name;
            this._diameter = diameter;
            this._mass = mass;
        }

        /// <summary>
        /// it outputs Name, Diameter and Mass to the Console
        /// </summary>
        public override string ToString()
        {
            string outputString = "";
            outputString += "Name of the Planet: " + this.Name + "\n";
            outputString += "Diameter of the Planet: " + this.Diameter + "\n";
            outputString += "Mass of the Planet: " + this.Mass + "\n";
            return outputString;

        }
    }
}
