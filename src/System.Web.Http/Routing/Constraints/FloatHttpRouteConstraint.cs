// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved. See License.txt in the project root for license information.

using System.Collections.Generic;
using System.Net.Http;

namespace System.Web.Http.Routing.Constraints
{
    public class FloatHttpRouteConstraint : IHttpRouteConstraint
    {
        public bool Match(HttpRequestMessage request, IHttpRoute route, string parameterName, IDictionary<string, object> values, HttpRouteDirection routeDirection)
        {
            object value = values[parameterName];
            if (value == null)
            {
                return false;
            }

            if (value is float)
            {
                return true;
            }

            float result;
            return Single.TryParse(value.ToString(), out result);
        }
    }
}