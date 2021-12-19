using System;
using System.Collections.Generic;
using System.Text;
using RuneCrafter.Project.Misc;
namespace RuneCrafter.Project
{
    class Game
    {
        public Game()
        {
        }

        public void Run()
        {
            Console.WriteLine(IdGenerator.GenerateId().ToString());
            Console.WriteLine(IdGenerator.GenerateId().ToString());
            Console.WriteLine(IdGenerator.GenerateId().ToString());
            Console.WriteLine(IdGenerator.GenerateId().ToString());
        }
    }
}
