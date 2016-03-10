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
            get; set;
        }

        int AbilityModifier
        {
            get; set;
        }

        int TempAdjustment
        {
            get; set;
        }

        int TempModifier
        {
            get; set;
        }
    }
}
