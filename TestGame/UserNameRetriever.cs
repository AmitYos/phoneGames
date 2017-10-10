namespace TestGame
{
    public class UserNameRetriever
    {
        private IInputReader _reader;
        private GameMessageWriter _writer;
        private NameChecker _nameChecker;

        public UserNameRetriever(IInputReader userInputReader, 
                                 GameMessageWriter gameMessageWriter,
                                 NameChecker nameChecker)
        {
            this._reader = userInputReader;
            this._writer = gameMessageWriter;
            this._nameChecker = nameChecker;
        }

        public string GetUserName()
        {
            _writer.WriteGameMessage("Hello, please enter your name:");
            string name = "";

            bool nameIsGood = false;
            while (!nameIsGood)
            {
                name = _reader.ReadInput();
                nameIsGood = this._nameChecker.CheckNameFromUser(name);
            }

            return name;
        }
    }
}