﻿using Model.Other;

namespace WebAppi_Test.Config
{
    public class ResultHelper
    {
        public static ApiResult Success(object res)
        {
            return new ApiResult() { IsSuccess = true, Result = res };
        }
        public static ApiResult Error(string message)
        {
            return new ApiResult() { IsSuccess = false, Msg = message };
        }
    }
}
