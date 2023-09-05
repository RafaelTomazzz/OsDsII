using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OsDsII.api.Exceptions
{
    public class NotFoundException : BaseException
    {
        public NotFoundException(string message) : 
        base(
            "ERROR: 001",
            $"{resource} not found",
            HttpStatusCode.NotFound,
            StatusCodes.Status404NotFound,
            DateTimeOffset.UtcNow,
            null
        )
        { }

        public NotFoundException (string message, Exception ex)
        :base(
            "ERROR :001",
            message,
            HttpStatusCode.NotFound,
            StatusCodes.Status404NotFound,
            DateTimeOffset.UtcNow,
            ex
        )
        {}
    }
}