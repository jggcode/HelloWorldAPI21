using System;

namespace HelloWorld.API.DotNetCore21
{
    public class Greeting
    {
        private DateTime greetingDateTime;

        public Greeting(DateTime greetingDateTime)
        {
            this.greetingDateTime = greetingDateTime;
        }

        public string GetGreeting()
        {
            if (greetingDateTime == null)
            {
                return "Hello from .Net Core 2.1!";
            }

            if (greetingDateTime.Hour < 12)
            {
                return "Good morning from .Net Core 2.1!";
            }

            if (greetingDateTime.Hour < 18)
            {
                return "Good afternoon from .Net Core 2.1!";
            }

            return "Good evening from .Net Core 2.1!";
        }

    }
}