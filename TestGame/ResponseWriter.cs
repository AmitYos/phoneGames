namespace TestGame
{
    using System;

    public class ResponseWriter
    {
        public ResponseWriter()
        {
            Console.ForegroundColor = ConsoleColor.Green;
        }

        public void WriteResponseToUser(string response)
        {
            Console.WriteLine(response);
        }
    }
}