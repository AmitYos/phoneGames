namespace TestGame
{
    public class GameMessageWriter
    {
        private ResponseWriter _writer;

        public GameMessageWriter(ResponseWriter responseWriter)
        {
            _writer = responseWriter;
        }

        public void WriteGameMessage(string name, string message)
        {
            _writer.WriteResponseToUser(name + ' ' + message[0].ToString().ToLower() + message.Substring(1));
        }

        public void WriteGameMessage(string message)
        {
            _writer.WriteResponseToUser(message);
        }
    }
}