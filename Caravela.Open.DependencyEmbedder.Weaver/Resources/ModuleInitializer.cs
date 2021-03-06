﻿using System;
using System.Runtime.CompilerServices;

namespace System.Runtime.CompilerServices
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
    public sealed class ModuleInitializerAttribute : Attribute { }
}

namespace Caravela.Open.DependencyEmbedder.Weaver.Templates
{
    static class ModuleInitializer
    {
        [ModuleInitializer]
        internal static void Initialize()
        {
            TEMPLATE.Attach();
        }
    }
}