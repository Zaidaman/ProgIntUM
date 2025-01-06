using System;

namespace Progetto_UI.Infrastructure
{
    public class LoginException : Exception
    {
        public LoginException(string message) : base(message) { }
    }
}
