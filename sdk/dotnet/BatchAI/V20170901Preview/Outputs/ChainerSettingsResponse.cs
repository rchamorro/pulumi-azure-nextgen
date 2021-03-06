// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.BatchAI.V20170901Preview.Outputs
{

    [OutputType]
    public sealed class ChainerSettingsResponse
    {
        public readonly string? CommandLineArgs;
        /// <summary>
        /// The default value for this property is equal to nodeCount property
        /// </summary>
        public readonly int? ProcessCount;
        public readonly string? PythonInterpreterPath;
        public readonly string PythonScriptFilePath;

        [OutputConstructor]
        private ChainerSettingsResponse(
            string? commandLineArgs,

            int? processCount,

            string? pythonInterpreterPath,

            string pythonScriptFilePath)
        {
            CommandLineArgs = commandLineArgs;
            ProcessCount = processCount;
            PythonInterpreterPath = pythonInterpreterPath;
            PythonScriptFilePath = pythonScriptFilePath;
        }
    }
}
