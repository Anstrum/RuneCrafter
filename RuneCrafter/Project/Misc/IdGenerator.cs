using System;
using System.Collections.Generic;
using System.Text;

namespace RuneCrafter.Project.Misc
{
    static class IdGenerator
    {
        private static List<Id> GeneratedIds = new List<Id>();
        private static string CharList = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        private static Random Random;
        public static Id GenerateId()
        {
            SetSeed();
            Random Random = new Random(DateTime.Now.Millisecond);
            Id Id;
            string IdString = "";
            do
            {
                IdString = "";
                while (IdString.Length < 20)
                {
                    IdString += GetRandomChar(Random);
                }
            } while (AlreadyGenerated(IdString));
            Id = new Id(IdString);
            GeneratedIds.Add(Id);
            return Id;
        }
        private static bool AlreadyGenerated(string IdString)
        {
            foreach (Id Id in GeneratedIds)
            {
                if(Id.ToString() == IdString)
                {
                    return true;
                }
            }
            return false;
        }
        private static char GetRandomChar(Random Random)
        {
            return CharList[Random.Next(CharList.Length)];
        }
        private static void SetSeed()
        {
            if(GeneratedIds.Count > 0)
            {
                Random = new Random(IdToInt(GeneratedIds[GeneratedIds.Count - 1]));
                return;
            }
            Random = new Random(DateTime.Now.Second);
        }
        private static int IdToInt(Id Id)
        {
            int Number = 0;
            foreach(char C in Id.ToString())
            {
                Number += (int)C;
            }
            return Number;
        }
    }
}
