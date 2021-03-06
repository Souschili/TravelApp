﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace TravelApp.Services
{
    public interface IPasswordSupplier
    {
        SecureString GetPassword { get; }
        bool ConfirmPassword();
    }
}
