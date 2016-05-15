using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.CQRS
{
    public class EmptyResult
    {
        public bool Success { get; set; }
        public List<Exception> Errors { get; set; }

        public EmptyResult()
        {
            this.Success = true;
            this.Errors = new List<Exception>();
        }

        public EmptyResult(Exception e)
        {
            this.Success = false;
            this.Errors.Add(e);
        }
    }
}
