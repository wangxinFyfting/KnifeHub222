﻿using System;
using System.Collections.Generic;
using System.Text;

namespace EleChoPlugin.ResponseModels
{
    public class BaseResponseModel
    {
        public int Code { get; set; }

        public string Message { get; set; }

        public object Data { get; set; }
    }
}
