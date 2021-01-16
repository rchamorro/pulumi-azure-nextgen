// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.DataFactory.V20180601.Inputs
{

    /// <summary>
    /// Execute SSIS package activity.
    /// </summary>
    public sealed class ExecuteSSISPackageActivityArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The integration runtime reference.
        /// </summary>
        [Input("connectVia", required: true)]
        public Input<Inputs.IntegrationRuntimeReferenceArgs> ConnectVia { get; set; } = null!;

        [Input("dependsOn")]
        private InputList<Inputs.ActivityDependencyArgs>? _dependsOn;

        /// <summary>
        /// Activity depends on condition.
        /// </summary>
        public InputList<Inputs.ActivityDependencyArgs> DependsOn
        {
            get => _dependsOn ?? (_dependsOn = new InputList<Inputs.ActivityDependencyArgs>());
            set => _dependsOn = value;
        }

        /// <summary>
        /// Activity description.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// The environment path to execute the SSIS package. Type: string (or Expression with resultType string).
        /// </summary>
        [Input("environmentPath")]
        public Input<object>? EnvironmentPath { get; set; }

        /// <summary>
        /// The package execution credential.
        /// </summary>
        [Input("executionCredential")]
        public Input<Inputs.SSISExecutionCredentialArgs>? ExecutionCredential { get; set; }

        /// <summary>
        /// Linked service reference.
        /// </summary>
        [Input("linkedServiceName")]
        public Input<Inputs.LinkedServiceReferenceArgs>? LinkedServiceName { get; set; }

        /// <summary>
        /// SSIS package execution log location.
        /// </summary>
        [Input("logLocation")]
        public Input<Inputs.SSISLogLocationArgs>? LogLocation { get; set; }

        /// <summary>
        /// The logging level of SSIS package execution. Type: string (or Expression with resultType string).
        /// </summary>
        [Input("loggingLevel")]
        public Input<object>? LoggingLevel { get; set; }

        /// <summary>
        /// Activity name.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        [Input("packageConnectionManagers")]
        private InputMap<ImmutableDictionary<string, Inputs.SSISExecutionParameterArgs>>? _packageConnectionManagers;

        /// <summary>
        /// The package level connection managers to execute the SSIS package.
        /// </summary>
        public InputMap<ImmutableDictionary<string, Inputs.SSISExecutionParameterArgs>> PackageConnectionManagers
        {
            get => _packageConnectionManagers ?? (_packageConnectionManagers = new InputMap<ImmutableDictionary<string, Inputs.SSISExecutionParameterArgs>>());
            set => _packageConnectionManagers = value;
        }

        /// <summary>
        /// SSIS package location.
        /// </summary>
        [Input("packageLocation", required: true)]
        public Input<Inputs.SSISPackageLocationArgs> PackageLocation { get; set; } = null!;

        [Input("packageParameters")]
        private InputMap<Inputs.SSISExecutionParameterArgs>? _packageParameters;

        /// <summary>
        /// The package level parameters to execute the SSIS package.
        /// </summary>
        public InputMap<Inputs.SSISExecutionParameterArgs> PackageParameters
        {
            get => _packageParameters ?? (_packageParameters = new InputMap<Inputs.SSISExecutionParameterArgs>());
            set => _packageParameters = value;
        }

        /// <summary>
        /// Activity policy.
        /// </summary>
        [Input("policy")]
        public Input<Inputs.ActivityPolicyArgs>? Policy { get; set; }

        [Input("projectConnectionManagers")]
        private InputMap<ImmutableDictionary<string, Inputs.SSISExecutionParameterArgs>>? _projectConnectionManagers;

        /// <summary>
        /// The project level connection managers to execute the SSIS package.
        /// </summary>
        public InputMap<ImmutableDictionary<string, Inputs.SSISExecutionParameterArgs>> ProjectConnectionManagers
        {
            get => _projectConnectionManagers ?? (_projectConnectionManagers = new InputMap<ImmutableDictionary<string, Inputs.SSISExecutionParameterArgs>>());
            set => _projectConnectionManagers = value;
        }

        [Input("projectParameters")]
        private InputMap<Inputs.SSISExecutionParameterArgs>? _projectParameters;

        /// <summary>
        /// The project level parameters to execute the SSIS package.
        /// </summary>
        public InputMap<Inputs.SSISExecutionParameterArgs> ProjectParameters
        {
            get => _projectParameters ?? (_projectParameters = new InputMap<Inputs.SSISExecutionParameterArgs>());
            set => _projectParameters = value;
        }

        [Input("propertyOverrides")]
        private InputMap<Inputs.SSISPropertyOverrideArgs>? _propertyOverrides;

        /// <summary>
        /// The property overrides to execute the SSIS package.
        /// </summary>
        public InputMap<Inputs.SSISPropertyOverrideArgs> PropertyOverrides
        {
            get => _propertyOverrides ?? (_propertyOverrides = new InputMap<Inputs.SSISPropertyOverrideArgs>());
            set => _propertyOverrides = value;
        }

        /// <summary>
        /// Specifies the runtime to execute SSIS package. The value should be "x86" or "x64". Type: string (or Expression with resultType string).
        /// </summary>
        [Input("runtime")]
        public Input<object>? Runtime { get; set; }

        /// <summary>
        /// Type of activity.
        /// Expected value is 'Execution'.
        /// </summary>
        [Input("type", required: true)]
        public Input<string> Type { get; set; } = null!;

        [Input("userProperties")]
        private InputList<Inputs.UserPropertyArgs>? _userProperties;

        /// <summary>
        /// Activity user properties.
        /// </summary>
        public InputList<Inputs.UserPropertyArgs> UserProperties
        {
            get => _userProperties ?? (_userProperties = new InputList<Inputs.UserPropertyArgs>());
            set => _userProperties = value;
        }

        public ExecuteSSISPackageActivityArgs()
        {
        }
    }
}
