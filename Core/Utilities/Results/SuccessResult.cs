using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    //base = Result
    public class SuccessResult : Result
    {
        public SuccessResult(string message) : base(true, message) //parametreleri Result'a gönder.
        {

        }

        public SuccessResult() : base(true)
        {

        }
    }
}
