namespace Tweetbook.Contracts
{
    public static class ApiRoutes
    {
        public const string Root = "api";
        public const string Version = "v1";

        public const string Base = Root + "/" + Version;
        public static class Posts
        {
            public const string GetAll = Base + "/posts";

            public const string Update = Base + "/posts/{postId}";

            public const string Delete = Base + "/posts/{postId}";

            public const string Get = Base + "/posts/{postId}";

            public const string Create = Base + "/posts";


        }

        public static class Identity
        {
            /** 
             * This way of naming endpoints "break" the RESTFul Principles by having verbs in it (login, register). 
             * But consider this identity section should be in a separate Identity server and does not really need to be a REST Api.
             * This is done here just for semplicity purposes during this tutorial.
             * */
            public const string Login = Base + "/identity/login";

            public const string Register = Base + "/identity/register";
        }
    }
}
