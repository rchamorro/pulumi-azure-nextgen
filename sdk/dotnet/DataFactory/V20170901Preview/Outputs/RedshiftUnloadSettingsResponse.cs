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
    public sealed class RedshiftUnloadSettingsResponse
    {
        /// <summary>
        /// The bucket of the interim Amazon S3 which will be used to store the unloaded data from Amazon Redshift source. The bucket must be in the same region as the Amazon Redshift source. Type: string (or Expression with resultType string).
        /// </summary>
        public readonly object BucketName;
        /// <summary>
        /// The name of the Amazon S3 linked service which will be used for the unload operation when copying from the Amazon Redshift source.
        /// </summary>
        public readonly Outputs.LinkedServiceReferenceResponse S3LinkedServiceName;

        [OutputConstructor]
        private RedshiftUnloadSettingsResponse(
            object bucketName,

            Outputs.LinkedServiceReferenceResponse s3LinkedServiceName)
        {
            BucketName = bucketName;
            S3LinkedServiceName = s3LinkedServiceName;
        }
    }
}
