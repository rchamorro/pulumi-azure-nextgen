// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.DataFactory.V20170901Preview.Outputs
{

    [OutputType]
    public sealed class ExecuteSSISPackageActivityResponse
    {
        /// <summary>
        /// The integration runtime reference.
        /// </summary>
        public readonly Outputs.IntegrationRuntimeReferenceResponse ConnectVia;
        /// <summary>
        /// Activity depends on condition.
        /// </summary>
        public readonly ImmutableArray<Outputs.ActivityDependencyResponse> DependsOn;
        /// <summary>
        /// Activity description.
        /// </summary>
        public readonly string? Description;
        /// <summary>
        /// The environment path to execute the SSIS package. Type: string (or Expression with resultType string).
        /// </summary>
        public readonly object? EnvironmentPath;
        /// <summary>
        /// The package execution credential.
        /// </summary>
        public readonly Outputs.SSISExecutionCredentialResponse? ExecutionCredential;
        /// <summary>
        /// Linked service reference.
        /// </summary>
        public readonly Outputs.LinkedServiceReferenceResponse? LinkedServiceName;
        /// <summary>
        /// SSIS package execution log location.
        /// </summary>
        public readonly Outputs.SSISLogLocationResponse? LogLocation;
        /// <summary>
        /// The logging level of SSIS package execution. Type: string (or Expression with resultType string).
        /// </summary>
        public readonly object? LoggingLevel;
        /// <summary>
        /// Activity name.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// The package level connection managers to execute the SSIS package.
        /// </summary>
        public readonly ImmutableDictionary<string, ImmutableDictionary<string, Outputs.SSISExecutionParameterResponse>>? PackageConnectionManagers;
        /// <summary>
        /// SSIS package location.
        /// </summary>
        public readonly Outputs.SSISPackageLocationResponse PackageLocation;
        /// <summary>
        /// The package level parameters to execute the SSIS package.
        /// </summary>
        public readonly ImmutableDictionary<string, Outputs.SSISExecutionParameterResponse>? PackageParameters;
        /// <summary>
        /// Activity policy.
        /// </summary>
        public readonly Outputs.ActivityPolicyResponse? Policy;
        /// <summary>
        /// The project level connection managers to execute the SSIS package.
        /// </summary>
        public readonly ImmutableDictionary<string, ImmutableDictionary<string, Outputs.SSISExecutionParameterResponse>>? ProjectConnectionManagers;
        /// <summary>
        /// The project level parameters to execute the SSIS package.
        /// </summary>
        public readonly ImmutableDictionary<string, Outputs.SSISExecutionParameterResponse>? ProjectParameters;
        /// <summary>
        /// The property overrides to execute the SSIS package.
        /// </summary>
        public readonly ImmutableDictionary<string, Outputs.SSISPropertyOverrideResponse>? PropertyOverrides;
        /// <summary>
        /// Specifies the runtime to execute SSIS package. The value should be "x86" or "x64". Type: string (or Expression with resultType string).
        /// </summary>
        public readonly object? Runtime;
        /// <summary>
        /// Type of activity.
        /// Expected value is 'Execution'.
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private ExecuteSSISPackageActivityResponse(
            Outputs.IntegrationRuntimeReferenceResponse connectVia,

            ImmutableArray<Outputs.ActivityDependencyResponse> dependsOn,

            string? description,

            object? environmentPath,

            Outputs.SSISExecutionCredentialResponse? executionCredential,

            Outputs.LinkedServiceReferenceResponse? linkedServiceName,

            Outputs.SSISLogLocationResponse? logLocation,

            object? loggingLevel,

            string name,

            ImmutableDictionary<string, ImmutableDictionary<string, Outputs.SSISExecutionParameterResponse>>? packageConnectionManagers,

            Outputs.SSISPackageLocationResponse packageLocation,

            ImmutableDictionary<string, Outputs.SSISExecutionParameterResponse>? packageParameters,

            Outputs.ActivityPolicyResponse? policy,

            ImmutableDictionary<string, ImmutableDictionary<string, Outputs.SSISExecutionParameterResponse>>? projectConnectionManagers,

            ImmutableDictionary<string, Outputs.SSISExecutionParameterResponse>? projectParameters,

            ImmutableDictionary<string, Outputs.SSISPropertyOverrideResponse>? propertyOverrides,

            object? runtime,

            string type)
        {
            ConnectVia = connectVia;
            DependsOn = dependsOn;
            Description = description;
            EnvironmentPath = environmentPath;
            ExecutionCredential = executionCredential;
            LinkedServiceName = linkedServiceName;
            LogLocation = logLocation;
            LoggingLevel = loggingLevel;
            Name = name;
            PackageConnectionManagers = packageConnectionManagers;
            PackageLocation = packageLocation;
            PackageParameters = packageParameters;
            Policy = policy;
            ProjectConnectionManagers = projectConnectionManagers;
            ProjectParameters = projectParameters;
            PropertyOverrides = propertyOverrides;
            Runtime = runtime;
            Type = type;
        }
    }
}
