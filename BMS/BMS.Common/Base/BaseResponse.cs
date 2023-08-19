using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMS.Common.Base
{
    public class BaseResponse
    {
        public BaseResponse()
        {
            this.Message = new List<string>();
            this.Response = null;
            this.IsSuccess = true;
        }
        public bool IsSuccess { get; set; }
        public List<string> Message { get; set; }
        public object Response { get; set; }
    }
}
