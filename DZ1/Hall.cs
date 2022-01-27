using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ1
{
    internal class Hall
    {
        int Rows
        {
            get
            {
                return Rows;
            }
            set
            {
                if (value > 0)
                {
                    Rows = value;
                }
            }
        }
        int SeatsInRow
        {
            get
            {
                return SeatsInRow;
            }
            set
            {
                if (value > 0)
                {
                    SeatsInRow = value;
                }
            }
        }
    }
}
