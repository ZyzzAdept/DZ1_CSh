using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ1
{
    internal class UserInterface
    {
        abstract class Actions
        {
            internal abstract void ActionsList();
            internal abstract void Exit();
            internal abstract void SeatsView();
        }

        class UnauthorizedActions : Actions
        {

        }


    }
}
