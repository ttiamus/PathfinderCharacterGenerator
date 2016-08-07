using System;
using System.Collections.Generic;

namespace Common.Results
{
    public class Result<T>
    {
        public T Data { get; set; }

        public bool Success { get; set; }

        public List<string> Messages { get; set; }

        public List<Exception> Exceptions { get; set; }

        public Result(T data)
        {
            this.Data = data;
            this.Success = true;
        }

        public Result(string message)
        {
            this.Success = false;
            this.Messages = new List<string> { message };
            this.Exceptions = new List<Exception>();
        }

        public Result(List<string> messages)
        {
            this.Success = false;
            this.Messages = messages;
            this.Exceptions = new List<Exception>();
        }

        public Result(Exception exception)
        {
            this.Success = false;
            this.Messages = new List<string>();
            this.Exceptions = new List<Exception> { exception };
        }
    }
}
