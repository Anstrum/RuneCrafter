using System;
using System.Collections.Generic;
using System.Text;

namespace RuneCrafter.Project.Misc
{
    class Log
    {
        DateTime Date;
        string Content;

        public Log(DateTime Date, string Content)
        {
            this.Date = Date;
            this.Content = Content;
        }

        public DateTime GetDate()
        {
            return Date;
        }
        public string GetContent()
        {
            return Content;
        }
    }
}
