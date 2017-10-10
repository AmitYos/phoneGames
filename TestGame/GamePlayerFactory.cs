using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGame
{
    class GamePlayerFactory
    {
        
        public GamePlayer createGamePlayer()
        {
            IInputReader reader = new UserInputReader();
            NameChecker nameChecker = new NameChecker();
            LevelChecker levelChecker = new LevelChecker();
            ResponseWriter responseWriter = new ResponseWriter();
            GameMessageWriter writer = new GameMessageWriter(responseWriter);
            DifficultyLevelChooser difficultyLevelChooser = new DifficultyLevelChooser(reader, writer, levelChecker);
            RandomNumberSelector randomNumberSelector = new RandomNumberSelector();
            UserNameRetriever userNameRetriever = new UserNameRetriever(reader, writer, nameChecker);
            GamePlayer gamePlayer = new GamePlayer(reader,
                                                   writer,
                                                   randomNumberSelector,
                                                   userNameRetriever,
                                                   difficultyLevelChooser);
            return gamePlayer;
        }

    }
}
