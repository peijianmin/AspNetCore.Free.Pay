﻿using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace Free.Pay.Core.Hosting
{
    public interface IEndpointHandler
    {
        /// <summary>
        ///      Processes the request
        /// </summary>
        /// <param name="context">The HTTP context.</param>
        /// <returns></returns>
        Task<IEndpointResult> ProcessAsync(HttpContext context);
    }
}
