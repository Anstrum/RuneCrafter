using System;
using System.Collections.Generic;
using System.Text;

namespace RuneCrafter.Project.Misc
{
    class Id
    {
        private string ObjectId;

        public Id(string ObjectId)
        {
            this.ObjectId = ObjectId;
        }

        public override string ToString()
        {
            return ObjectId;
        }
    }
}