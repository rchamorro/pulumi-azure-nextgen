// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.VirtualMachineImages.V20200214.Outputs
{

    [OutputType]
    public sealed class ImageTemplateRestartCustomizerResponse
    {
        /// <summary>
        /// Friendly Name to provide context on what this customization step does
        /// </summary>
        public readonly string? Name;
        /// <summary>
        /// Command to check if restart succeeded [Default: '']
        /// </summary>
        public readonly string? RestartCheckCommand;
        /// <summary>
        /// Command to execute the restart [Default: 'shutdown /r /f /t 0 /c "packer restart"']
        /// </summary>
        public readonly string? RestartCommand;
        /// <summary>
        /// Restart timeout specified as a string of magnitude and unit, e.g. '5m' (5 minutes) or '2h' (2 hours) [Default: '5m']
        /// </summary>
        public readonly string? RestartTimeout;
        /// <summary>
        /// The type of customization tool you want to use on the Image. For example, "Shell" can be shell customizer
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private ImageTemplateRestartCustomizerResponse(
            string? name,

            string? restartCheckCommand,

            string? restartCommand,

            string? restartTimeout,

            string type)
        {
            Name = name;
            RestartCheckCommand = restartCheckCommand;
            RestartCommand = restartCommand;
            RestartTimeout = restartTimeout;
            Type = type;
        }
    }
}