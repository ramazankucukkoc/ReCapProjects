using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.Utilities.Results
{
    public class Result : IResult
    {
        public Result(bool success, string message) : this(success)
        {
            message = message;
        }
        public Result(bool success)
        {

            success = success;
        }
        public bool success { get; }

        public string message { get; }

    }
}
