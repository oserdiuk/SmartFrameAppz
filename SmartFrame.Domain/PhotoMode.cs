﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartFrame.Domain
{
    public class PhotoMode
    {
        public virtual ICollection<User> Users{ get; set; }
    }
}