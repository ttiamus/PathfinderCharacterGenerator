using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Results
{
    public class CommandResult
    {
        public bool Success { get; set; }

        //Maybe this will be a messages class instead of string
        //Messages have a string with a type like info or exception
        public List<string> Messages { get; set; }

        public CommandResult()
        {
            Success = true;
            this.Messages = new List<string>();
        }

        public CommandResult(string message)
        {
            this.Messages = new List<string> {message};
        }

        public CommandResult(List<string> messages)
        {
            this.Messages = messages;
            this.Success = false;
        }
    }
}
