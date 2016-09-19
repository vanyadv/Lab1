using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewList
{
    public class MyPlanet
    {
        private string _name;
        private string _range;
        private string _mass;

        public string NameEnter
        {
            get { return _name; }

            set
            {
                _name= value;
            }
        }

        public string RangeEnter
        {
            get { return _range; }

            set
            {
                _range = value;
            }
        }

        public string MassEnter
        {
            get { return _mass; }

            set
            {
                _mass= value;
            }
        }
    }
}
