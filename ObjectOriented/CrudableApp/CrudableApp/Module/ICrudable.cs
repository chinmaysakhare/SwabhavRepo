﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudableApp.Module
{
    interface ICrudable
    {
        void Create();
        void Read();
        void Update();
        void Delete();
    }
}
