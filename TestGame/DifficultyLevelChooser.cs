using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGame
{
    class DifficultyLevelChooser
    {
        private IInputReader _reader;
        private GameMessageWriter _writer;
        private LevelChecker _levelChecker;

        public DifficultyLevelChooser(IInputReader reader,
                                      GameMessageWriter writer,
                                      LevelChecker levelChecker)
        {
            this._reader = reader;
            this._writer = writer;
            this._levelChecker = levelChecker;
        }

        public string ChooseDifficultyLevel()
        {
            var difficultyLevel = "a";
            _writer.WriteGameMessage("Please choose difficulty level\nl: Low, m: Medium, h: High");

            bool levelIsGood = false;
            while (!levelIsGood)
            {
                difficultyLevel = _reader.ReadInput();
                levelIsGood = _levelChecker.CheckLevelFromUser(difficultyLevel);
            }

            return difficultyLevel;    
            
        }


    }
}
