﻿// Copyright (c) .NET Foundation and contributors. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Microsoft.DotNet.Internal.ProjectModel
{
    internal class ResourceFile
    {
        public string Path { get; }
        public string Locale { get; }

        public ResourceFile(string path, string locale)
        {
            Path = path;
            Locale = locale;
        }
    }
}
