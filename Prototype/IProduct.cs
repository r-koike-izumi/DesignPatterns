﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype_Framework
{
    public interface IProduct : ICloneable
    {
        void Use(string s);
        IProduct CreateClone();
    }
}
