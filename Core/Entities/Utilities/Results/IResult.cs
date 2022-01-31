using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.Utilities.Results
{
   public interface IResult
    {
        bool success { get; }
        string message { get; }
    }
}
