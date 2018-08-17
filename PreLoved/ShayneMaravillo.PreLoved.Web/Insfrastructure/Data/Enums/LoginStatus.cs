using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShayneMaravillo.PreLoved.Web.Insfrastructure.Data.Enums
{
    public enum LoginStatus
    {
        Unverified, 
        Active,
        Locked,
        NeedsToChangePassword
    }
}
