using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.CQRS
{
    public class Result<T>
    {
        public T Data { get; set; }
        public bool Success { get; set; }
        public List<Exception> Errors { get; set; }

        public Result(T data)
        {
            this.Data = data;
            this.Success = true;
            this.Errors = new List<Exception>();
        } 

        public Result(Exception e)
        {
            this.Success = false;
            this.Errors.Add(e);
        } 
    }
}
