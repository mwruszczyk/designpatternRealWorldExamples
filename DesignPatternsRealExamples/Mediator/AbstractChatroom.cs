﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsRealExamples.Mediator
{
    public abstract class AbstractChatroom
    {
        public abstract void Register(Participant participant);
        public abstract void Send(
            string from, string to, string message);
    }
}