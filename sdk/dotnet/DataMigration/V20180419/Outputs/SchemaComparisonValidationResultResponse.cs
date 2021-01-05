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
    public sealed class SchemaComparisonValidationResultResponse
    {
        /// <summary>
        /// List of schema differences between the source and target databases
        /// </summary>
        public readonly Outputs.SchemaComparisonValidationResultTypeResponse SchemaDifferences;
        /// <summary>
        /// Count of source database objects
        /// </summary>
        public readonly ImmutableDictionary<string, double>? SourceDatabaseObjectCount;
        /// <summary>
        /// Count of target database objects
        /// </summary>
        public readonly ImmutableDictionary<string, double>? TargetDatabaseObjectCount;
        /// <summary>
        /// List of errors that happened while performing schema compare validation
        /// </summary>
        public readonly Outputs.ValidationErrorResponse ValidationErrors;

        [OutputConstructor]
        private SchemaComparisonValidationResultResponse(
            Outputs.SchemaComparisonValidationResultTypeResponse schemaDifferences,

            ImmutableDictionary<string, double>? sourceDatabaseObjectCount,

            ImmutableDictionary<string, double>? targetDatabaseObjectCount,

            Outputs.ValidationErrorResponse validationErrors)
        {
            SchemaDifferences = schemaDifferences;
            SourceDatabaseObjectCount = sourceDatabaseObjectCount;
            TargetDatabaseObjectCount = targetDatabaseObjectCount;
            ValidationErrors = validationErrors;
        }
    }
}
