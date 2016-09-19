using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewList
{
    class StarEnter
    {
        private string _name;
        private string _range;
        private string _mass;
        private string _light;
        private string _class;
        private string _planetsAround;

        public string NameEnter
        {
            get { return _name; }

            set
            {
                _name = value;
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
                _mass = value;
            }
        }

        public string LightEnter
        {
            get { return _light; }

            set
            {
                _light = value;
            }
        }

        public string ClassEnter
        {
            get { return _class; }

            set
            {
                _class = value;
            }
        }

        public string PlanetsAroundStars
        {
            get { return _planetsAround; }

            set
            {
                _planetsAround = value;
            }
        }

    }

}
