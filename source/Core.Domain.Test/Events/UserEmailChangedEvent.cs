﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Domain.Test.Events
{
    public class UserEmailChangedEvent : Event
    {
        public String UserId { get; set; }
        public String Email { get; set; }
    }
}
