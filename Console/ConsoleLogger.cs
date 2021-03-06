﻿using System;

namespace nsLogger
{
    public class ConsoleLogger : Logger
    {
        public ConsoleLogger(LogLevel mask)
        : base(mask)
        {}

        protected override void WriteMessage(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}