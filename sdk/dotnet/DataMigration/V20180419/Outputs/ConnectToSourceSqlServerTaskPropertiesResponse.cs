// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.DataMigration.V20180419.Outputs
{

    [OutputType]
    public sealed class ConnectToSourceSqlServerTaskPropertiesResponse
    {
        /// <summary>
        /// Array of command properties.
        /// </summary>
        public readonly ImmutableArray<Union<Outputs.MigrateMISyncCompleteCommandPropertiesResponse, Outputs.MigrateSyncCompleteCommandPropertiesResponse>> Commands;
        /// <summary>
        /// Array of errors. This is ignored if submitted.
        /// </summary>
        public readonly ImmutableArray<Outputs.ODataErrorResponse> Errors;
        /// <summary>
        /// Task input
        /// </summary>
        public readonly Outputs.ConnectToSourceSqlServerTaskInputResponse? Input;
        /// <summary>
        /// Task output. This is ignored if submitted.
        /// </summary>
        public readonly ImmutableArray<Union<Outputs.ConnectToSourceSqlServerTaskOutputAgentJobLevelResponse, Union<Outputs.ConnectToSourceSqlServerTaskOutputDatabaseLevelResponse, Union<Outputs.ConnectToSourceSqlServerTaskOutputLoginLevelResponse, Outputs.ConnectToSourceSqlServerTaskOutputTaskLevelResponse>>>> Output;
        /// <summary>
        /// The state of the task. This is ignored if submitted.
        /// </summary>
        public readonly string State;
        /// <summary>
        /// Task type.
        /// Expected value is 'ConnectToSource.SqlServer'.
        /// </summary>
        public readonly string TaskType;

        [OutputConstructor]
        private ConnectToSourceSqlServerTaskPropertiesResponse(
            ImmutableArray<Union<Outputs.MigrateMISyncCompleteCommandPropertiesResponse, Outputs.MigrateSyncCompleteCommandPropertiesResponse>> commands,

            ImmutableArray<Outputs.ODataErrorResponse> errors,

            Outputs.ConnectToSourceSqlServerTaskInputResponse? input,

            ImmutableArray<Union<Outputs.ConnectToSourceSqlServerTaskOutputAgentJobLevelResponse, Union<Outputs.ConnectToSourceSqlServerTaskOutputDatabaseLevelResponse, Union<Outputs.ConnectToSourceSqlServerTaskOutputLoginLevelResponse, Outputs.ConnectToSourceSqlServerTaskOutputTaskLevelResponse>>>> output,

            string state,

            string taskType)
        {
            Commands = commands;
            Errors = errors;
            Input = input;
            Output = output;
            State = state;
            TaskType = taskType;
        }
    }
}
