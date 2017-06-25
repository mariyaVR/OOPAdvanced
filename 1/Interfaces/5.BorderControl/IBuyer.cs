using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.BorderControl
{
    interface IBuyer: IName
    {
        int Food { get; }
        void BuyFood();
    }
}
