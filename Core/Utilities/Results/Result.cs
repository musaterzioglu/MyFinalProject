using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        //Getter ReadOnly'dir. Bu yüzden constructor da set edilebilir.
        //Constructor dışında set etmeyeceğiz.
        //Overloading - aşırı yükleme
        //this demek class'ın kendisi demek

        public Result(bool success, string message):this(success)
        {
            Message = message;
        }
        public Result(bool success)
        {
            Success = success;
        }

        public bool Success { get; }

        public string Message { get; }
    }
}
