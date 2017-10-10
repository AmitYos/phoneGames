namespace TestGame
{
    using System;

    public class UserInputReader : IInputReader
    {
        public string ReadInput()
        {
            return Console.ReadLine();
        }
    }
}