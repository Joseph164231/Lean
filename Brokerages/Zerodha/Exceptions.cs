﻿/*
 * QUANTCONNECT.COM - Democratizing Finance, Empowering Individuals.
 * Lean Algorithmic Trading Engine v2.0. Copyright 2014 QuantConnect Corporation.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
*/

using System;
using System.Net;

namespace QuantConnect.Brokerages.Zerodha
{
    public class KiteException : Exception
    {
        HttpStatusCode status;
        public KiteException(string message, HttpStatusCode httpStatus, Exception innerException = null) : base(message, innerException) { status = httpStatus; }
    }

    public class GeneralException : KiteException
    {
        public GeneralException(string message, HttpStatusCode httpStatus = HttpStatusCode.InternalServerError, Exception innerException = null) : base(message, httpStatus, innerException) { }
    }

    public class TokenException : KiteException
    {
        public TokenException(string message, HttpStatusCode httpStatus = HttpStatusCode.Forbidden, Exception innerException = null) : base(message, httpStatus, innerException) { }
    }


    public class PermissionException : KiteException
    {
        public PermissionException(string message, HttpStatusCode httpStatus = HttpStatusCode.Forbidden, Exception innerException = null) : base(message, httpStatus, innerException) { }
    }

    public class OrderException : KiteException
    {
        public OrderException(string message, HttpStatusCode httpStatus = HttpStatusCode.BadRequest, Exception innerException = null) : base(message, httpStatus, innerException) { }
    }

    public class InputException : KiteException
    {
        public InputException(string message, HttpStatusCode httpStatus = HttpStatusCode.BadRequest, Exception innerException = null) : base(message, httpStatus, innerException) { }
    }

    public class DataException : KiteException
    {
        public DataException(string message, HttpStatusCode httpStatus = HttpStatusCode.BadGateway, Exception innerException = null) : base(message, httpStatus, innerException) { }
    }

    public class NetworkException : KiteException
    {
        public NetworkException(string message, HttpStatusCode httpStatus = HttpStatusCode.ServiceUnavailable, Exception innerException = null) : base(message, httpStatus, innerException) { }
    }

}
