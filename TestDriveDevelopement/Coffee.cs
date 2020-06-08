using System;
using System.Collections.Generic;
using System.Text;

namespace BreakfastTesting
{
    public class Coffee
    {
        private string temperature = "";

        public string Temperature
        {
            get
            {
                switch (temperature)
                {
                    case "":
                        temperature = "Hot"; break;
                    case "Hot":
                        temperature = "Quite hot"; break;
                    case "Quite hot":
                        temperature = "Not so hot"; break;
                    case "Not so hot":
                        temperature = "Cold"; break;
                }
                return temperature;
            }
            set => temperature = value;
        }


    }
}
