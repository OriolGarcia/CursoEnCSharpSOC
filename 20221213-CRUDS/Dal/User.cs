﻿using System;
using System.Collections.Generic;

#nullable disable

namespace _20221213_CRUDS.Dal
{
    public partial class User
    {
        public int UserId { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Nombre { get; set; }
    }
}
