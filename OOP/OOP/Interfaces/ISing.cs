using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Interfaces
{
    public interface ISing
    {
        // Interface property.
        int numberOfSongs
        {
            set;get;
        }
        // Abstract method by default, needs to be implemented in the child class.
        public bool Sing();
    }
}
