﻿// Copyright (c) 2012-2020 Vaughn Vernon. All rights reserved.
//
// This Source Code Form is subject to the terms of the
// Mozilla Public License, v. 2.0. If a copy of the MPL
// was not distributed with this file, You can obtain
// one at https://mozilla.org/MPL/2.0/.

using System;
using System.IO;
using Vlingo.Common;

namespace Vlingo.Actors
{
    public sealed class Properties: ConfigurationProperties
    {
        private static Func<Properties> Factory = () =>
        {
            var props = new Properties();
            props.Load(new FileInfo("vlingo-actors.json"));
            return props;
        };

        private static Lazy<Properties> SingleInstance => new Lazy<Properties>(Factory, true);

        public static Properties Instance => SingleInstance.Value;
    }
}
