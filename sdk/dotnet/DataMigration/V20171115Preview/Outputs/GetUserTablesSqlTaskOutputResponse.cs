// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.DataMigration.V20171115Preview.Outputs
{

    [OutputType]
    public sealed class GetUserTablesSqlTaskOutputResponse
    {
        /// <summary>
        /// Mapping from database name to list of tables
        /// </summary>
        public readonly ImmutableDictionary<string, ImmutableArray<Outputs.DatabaseTableResponse>> DatabasesToTables;
        /// <summary>
        /// Result identifier
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// Validation errors
        /// </summary>
        public readonly ImmutableArray<Outputs.ReportableExceptionResponse> ValidationErrors;

        [OutputConstructor]
        private GetUserTablesSqlTaskOutputResponse(
            ImmutableDictionary<string, ImmutableArray<Outputs.DatabaseTableResponse>> databasesToTables,

            string id,

            ImmutableArray<Outputs.ReportableExceptionResponse> validationErrors)
        {
            DatabasesToTables = databasesToTables;
            Id = id;
            ValidationErrors = validationErrors;
        }
    }
}
