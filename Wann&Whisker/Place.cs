
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wann_Whiskey
{
    public class Place
    {

        public string NamePlace { get; set; }
        public string Description { get; set; }
        public bool Accessible { get; set; }


        public Place(string nameplace, string description, bool accesible)
        {
            NamePlace = nameplace;
            Description = description;
            Accessible = accesible;

        }
    }
}
