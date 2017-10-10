using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGame
{
    class GamePlayer
    {
        private IInputReader _reader;
        private GameMessageWriter _writer;
        private RandomNumberSelector _randomNumberSelector;
        private UserNameRetriever _userNameRetriever;
        private DifficultyLevelChooser _difficultyLevelChooser;

        public GamePlayer(IInputReader reader,
                          GameMessageWriter writer, 
                          RandomNumberSelector randomNumberSelector, 
                          UserNameRetriever userNameRetriever,
                          DifficultyLevelChooser difficultyLevelChooser)
        {
            this._reader = reader;
            this._writer = writer;
            this._randomNumberSelector = randomNumberSelector;
            this._userNameRetriever = userNameRetriever;
            this._difficultyLevelChooser = difficultyLevelChooser;
        }

        public void StartNewGame()
        {
            string name = _userNameRetriever.GetUserName();
            
            string wantToPlay = "y";
            while (wantToPlay == "y") {
                string level = _difficultyLevelChooser.ChooseDifficultyLevel();
                int randNum = _randomNumberSelector.GenerateInitialNumber(level);
                int selectedNumber = -1;
                int stepNumber = 1;
                while (selectedNumber != randNum)
                {
                    _writer.WriteGameMessage(name, "Please insert a number:");
                    selectedNumber = int.Parse(_reader.ReadInput());
                    if (selectedNumber == -5)
                    {
                        _writer.WriteGameMessage(name, $"Shhh... the number is {randNum}");
                    }
                    else if (selectedNumber > randNum)
                    {
                        _writer.WriteGameMessage(name, "Your number is too big.");
                    }
                    else if (selectedNumber < randNum)
                    {
                        _writer.WriteGameMessage(name, "Your number is too small");
                    }
                    else
                    {
                        _writer.WriteGameMessage(name, $"boolllllll! it took you {stepNumber} steps!");
                    }

                    stepNumber++;
                }

                _writer.WriteGameMessage(name, "for your next game run me again by writing y to the console.");
                wantToPlay = _reader.ReadInput();
            }
        }
    }
}
