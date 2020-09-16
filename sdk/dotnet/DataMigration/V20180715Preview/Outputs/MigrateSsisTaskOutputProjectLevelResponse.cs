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
    public sealed class MigrateSsisTaskOutputProjectLevelResponse
    {
        /// <summary>
        /// Migration end time
        /// </summary>
        public readonly string EndedOn;
        /// <summary>
        /// Migration exceptions and warnings
        /// </summary>
        public readonly ImmutableArray<Outputs.ReportableExceptionResponse> ExceptionsAndWarnings;
        /// <summary>
        /// Name of the folder
        /// </summary>
        public readonly string FolderName;
        /// <summary>
        /// Result identifier
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// Migration progress message
        /// </summary>
        public readonly string Message;
        /// <summary>
        /// Name of the project
        /// </summary>
        public readonly string ProjectName;
        /// <summary>
        /// Result type
        /// </summary>
        public readonly string ResultType;
        /// <summary>
        /// Stage of SSIS migration.
        /// </summary>
        public readonly string Stage;
        /// <summary>
        /// Migration start time
        /// </summary>
        public readonly string StartedOn;
        /// <summary>
        /// Current state of migration
        /// </summary>
        public readonly string State;

        [OutputConstructor]
        private MigrateSsisTaskOutputProjectLevelResponse(
            string endedOn,

            ImmutableArray<Outputs.ReportableExceptionResponse> exceptionsAndWarnings,

            string folderName,

            string id,

            string message,

            string projectName,

            string resultType,

            string stage,

            string startedOn,

            string state)
        {
            EndedOn = endedOn;
            ExceptionsAndWarnings = exceptionsAndWarnings;
            FolderName = folderName;
            Id = id;
            Message = message;
            ProjectName = projectName;
            ResultType = resultType;
            Stage = stage;
            StartedOn = startedOn;
            State = state;
        }
    }
}