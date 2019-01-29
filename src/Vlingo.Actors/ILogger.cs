﻿// Copyright (c) 2012-2019 Vaughn Vernon. All rights reserved.
//
// This Source Code Form is subject to the terms of the
// Mozilla Public License, v. 2.0. If a copy of the MPL
// was not distributed with this file, You can obtain
// one at https://mozilla.org/MPL/2.0/.

using System;

namespace Vlingo.Actors
{
    public interface ILogger
    {
        bool IsEnabled { get; }
        string Name { get; }
        void Log(string message);
        void Log(string message, Exception ex);
        void Close();
    }
}