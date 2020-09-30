// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.DataMigration.V20180715Preview.Outputs
{

    [OutputType]
    public sealed class StartMigrationScenarioServerRoleResultResponse
    {
        /// <summary>
        /// Migration exceptions and warnings.
        /// </summary>
        public readonly ImmutableArray<Outputs.ReportableExceptionResponse> ExceptionsAndWarnings;
        /// <summary>
        /// Name of server role.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// Current state of migration
        /// </summary>
        public readonly string State;

        [OutputConstructor]
        private StartMigrationScenarioServerRoleResultResponse(
            ImmutableArray<Outputs.ReportableExceptionResponse> exceptionsAndWarnings,

            string name,

            string state)
        {
            ExceptionsAndWarnings = exceptionsAndWarnings;
            Name = name;
            State = state;
        }
    }
}
