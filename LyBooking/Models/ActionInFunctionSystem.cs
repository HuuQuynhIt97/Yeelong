using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LyBooking.Models
{
    public class ActionInFunctionSystem
    {
        public int FunctionSystemID { get; set; }
        public int ActionID { get; set; }
        public Action Action { get; set; }
        public FunctionSystem FunctionSystem { get; set; }
    }
}
