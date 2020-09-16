// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.MachineLearningServices.V20200515Preview.Outputs
{

    [OutputType]
    public sealed class ModelEnvironmentDefinitionResponseResponsePython
    {
        public readonly string? BaseCondaEnvironment;
        /// <summary>
        /// A JObject containing Conda dependencies.
        /// </summary>
        public readonly ImmutableDictionary<string, object>? CondaDependencies;
        /// <summary>
        /// The python interpreter path to use if an environment build is not required. The path specified gets used to call the user script.
        /// </summary>
        public readonly string? InterpreterPath;
        /// <summary>
        /// True means that AzureML reuses an existing python environment; False means that AzureML will create a python environment based on the Conda dependencies specification.
        /// </summary>
        public readonly bool? UserManagedDependencies;

        [OutputConstructor]
        private ModelEnvironmentDefinitionResponseResponsePython(
            string? baseCondaEnvironment,

            ImmutableDictionary<string, object>? condaDependencies,

            string? interpreterPath,

            bool? userManagedDependencies)
        {
            BaseCondaEnvironment = baseCondaEnvironment;
            CondaDependencies = condaDependencies;
            InterpreterPath = interpreterPath;
            UserManagedDependencies = userManagedDependencies;
        }
    }
}