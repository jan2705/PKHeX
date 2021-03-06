﻿using System.Collections.Generic;

namespace PKHeX.Core
{
    public sealed class EventVarGroup
    {
        public readonly EventVarType Type;
        public readonly List<EventVar> Vars = new List<EventVar>();

        public EventVarGroup(EventVarType type) => Type = type;
    }
}