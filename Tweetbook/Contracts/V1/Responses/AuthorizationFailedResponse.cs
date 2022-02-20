using System.Collections;
using System.Collections.Generic;

namespace Tweetbook.Contracts.V1.Responses
{
    public class AuthorizationFailedResponse
    {
        public IEnumerable<string> Errors { get; set; }
    }
}
