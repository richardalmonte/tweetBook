using System;

namespace Tweetbook.Contracts.V1.Requests
{
    public class CreatePostRequest
    {
        public Guid Id { get; set; }
    }

    public class UpdatePostRequest
    {
        public string Name { get; set; }
    }
}
