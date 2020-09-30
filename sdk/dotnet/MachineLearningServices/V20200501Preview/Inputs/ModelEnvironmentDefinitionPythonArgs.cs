// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.MachineLearningServices.V20200501Preview.Inputs
{

    /// <summary>
    /// Settings for a Python environment.
    /// </summary>
    public sealed class ModelEnvironmentDefinitionPythonArgs : Pulumi.ResourceArgs
    {
        [Input("baseCondaEnvironment")]
        public Input<string>? BaseCondaEnvironment { get; set; }

        /// <summary>
        /// A JObject containing Conda dependencies.
        /// </summary>
        [Input("condaDependencies")]
        public Input<object>? CondaDependencies { get; set; }

        /// <summary>
        /// The python interpreter path to use if an environment build is not required. The path specified gets used to call the user script.
        /// </summary>
        [Input("interpreterPath")]
        public Input<string>? InterpreterPath { get; set; }

        /// <summary>
        /// True means that AzureML reuses an existing python environment; False means that AzureML will create a python environment based on the Conda dependencies specification.
        /// </summary>
        [Input("userManagedDependencies")]
        public Input<bool>? UserManagedDependencies { get; set; }

        public ModelEnvironmentDefinitionPythonArgs()
        {
        }
    }
}
