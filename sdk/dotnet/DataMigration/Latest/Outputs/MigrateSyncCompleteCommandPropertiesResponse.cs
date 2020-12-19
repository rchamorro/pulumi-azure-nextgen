// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.DataMigration.Latest.Outputs
{

    [OutputType]
    public sealed class MigrateSyncCompleteCommandPropertiesResponse
    {
        /// <summary>
        /// Command type.
        /// Expected value is 'Migrate.Sync.Complete.Database'.
        /// </summary>
        public readonly string CommandType;
        /// <summary>
        /// Array of errors. This is ignored if submitted.
        /// </summary>
        public readonly ImmutableArray<Outputs.ODataErrorResponse> Errors;
        /// <summary>
        /// Command input
        /// </summary>
        public readonly Outputs.MigrateSyncCompleteCommandInputResponse? Input;
        /// <summary>
        /// Command output. This is ignored if submitted.
        /// </summary>
        public readonly Outputs.MigrateSyncCompleteCommandOutputResponse Output;
        /// <summary>
        /// The state of the command. This is ignored if submitted.
        /// </summary>
        public readonly string State;

        [OutputConstructor]
        private MigrateSyncCompleteCommandPropertiesResponse(
            string commandType,

            ImmutableArray<Outputs.ODataErrorResponse> errors,

            Outputs.MigrateSyncCompleteCommandInputResponse? input,

            Outputs.MigrateSyncCompleteCommandOutputResponse output,

            string state)
        {
            CommandType = commandType;
            Errors = errors;
            Input = input;
            Output = output;
            State = state;
        }
    }
}
