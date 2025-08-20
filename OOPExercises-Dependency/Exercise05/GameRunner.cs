using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExercises_Dependency.Exercise05
{
    internal class GameRunner : IGameEngine
    {
        private readonly IGameEngine _gameEngine;
        public GameRunner(IGameEngine gameEngine)
        {
            _gameEngine = gameEngine;
        }
        public void Play()
        {
            _gameEngine.Play();
        }
    }
}
