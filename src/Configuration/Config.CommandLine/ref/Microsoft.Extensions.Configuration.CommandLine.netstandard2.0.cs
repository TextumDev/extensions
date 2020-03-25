// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace Microsoft.Extensions.Configuration
{
    public static partial class CommandLineConfigurationExtensions
    {
        public static Microsoft.Extensions.Configuration.IConfigurationBuilder AddCommandLine(this Microsoft.Extensions.Configuration.IConfigurationBuilder builder, System.Action<Microsoft.Extensions.Configuration.CommandLine.CommandLineConfigurationSource> configureSource) { throw null; }
        public static Microsoft.Extensions.Configuration.IConfigurationBuilder AddCommandLine(this Microsoft.Extensions.Configuration.IConfigurationBuilder configurationBuilder, string[] args) { throw null; }
        public static Microsoft.Extensions.Configuration.IConfigurationBuilder AddCommandLine(this Microsoft.Extensions.Configuration.IConfigurationBuilder configurationBuilder, string[] args, System.Collections.Generic.IDictionary<string, string> switchMappings) { throw null; }
    }
}
namespace Microsoft.Extensions.Configuration.CommandLine
{
    public partial class CommandLineConfigurationProvider : Microsoft.Extensions.Configuration.ConfigurationProvider
    {
        public CommandLineConfigurationProvider(System.Collections.Generic.IEnumerable<string> args, System.Collections.Generic.IDictionary<string, string> switchMappings = null) { }
        protected System.Collections.Generic.IEnumerable<string> Args { [System.Runtime.CompilerServices.CompilerGeneratedAttribute] get { throw null; } }
        public override void Load() { }
    }
    public partial class CommandLineConfigurationSource : Microsoft.Extensions.Configuration.IConfigurationSource
    {
        public CommandLineConfigurationSource() { }
        public System.Collections.Generic.IEnumerable<string> Args { [System.Runtime.CompilerServices.CompilerGeneratedAttribute] get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute] set { } }
        public System.Collections.Generic.IDictionary<string, string> SwitchMappings { [System.Runtime.CompilerServices.CompilerGeneratedAttribute] get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute] set { } }
        public Microsoft.Extensions.Configuration.IConfigurationProvider Build(Microsoft.Extensions.Configuration.IConfigurationBuilder builder) { throw null; }
    }
}
