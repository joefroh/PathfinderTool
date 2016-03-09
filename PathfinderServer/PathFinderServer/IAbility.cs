using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathFinderServer
{
    interface IAbility
    {
        int AbilityScore
        {
            get;
        }

        int AbilityModifier
        {
            get;
        }

        int TempAdjustment
        {
            get;
        }

        int TempModifier
        {
            get;
        }
    }
}
