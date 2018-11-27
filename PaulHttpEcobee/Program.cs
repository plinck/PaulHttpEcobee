using System;
using System.Collections;
using System.Collections.Generic;

namespace PaulHttpEcobee
{
    public class Thermostat
    {
        private string _name;
        private int _ID;

        public Thermostat()
        {

        }

        public string name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int ID
        {
            get { return _ID; }
            set { _ID = value; }
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Thermostat[] thermostats = new Thermostat[2];

            Console.WriteLine("Hello World from paul new!");

            Thermostat paulThermostat = new Thermostat();
            paulThermostat.name = "Paul";
            paulThermostat.ID = 1;
            thermostats[0] = paulThermostat;

            Thermostat jimThermostat = new Thermostat();
            jimThermostat.name = "Jim";
            jimThermostat.ID = 2;
            thermostats[1] = jimThermostat; 
 
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Name:{0} ID: {1}", thermostats[i].name, thermostats[i].ID);

            }

            // Try with Generics
            // List<int> intList = new List<int>();

            List<Thermostat> genTstats = new List<Thermostat>();

            Thermostat oneThermostat = new Thermostat();
            oneThermostat.name = "Paul";
            oneThermostat.ID = 1;
            genTstats.Add(oneThermostat);

            Thermostat twoThermostat = new Thermostat();
            twoThermostat.name = "Jim";
            twoThermostat.ID = 2;
            genTstats.Add(twoThermostat);

            foreach (var myTstat in genTstats)
            {
                Console.WriteLine("Name:{0} ID: {1}", myTstat.name, myTstat.ID);
            }
        }
    }

 
}
