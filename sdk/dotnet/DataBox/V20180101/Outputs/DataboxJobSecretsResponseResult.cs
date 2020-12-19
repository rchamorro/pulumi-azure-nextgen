// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.DataBox.V20180101.Outputs
{

    [OutputType]
    public sealed class DataboxJobSecretsResponseResult
    {
        /// <summary>
        /// Used to indicate what type of job secrets object.
        /// Expected value is 'DataBox'.
        /// </summary>
        public readonly string JobSecretsType;
        /// <summary>
        /// Contains the list of secret objects for a job.
        /// </summary>
        public readonly ImmutableArray<Outputs.DataBoxSecretResponseResult> PodSecrets;

        [OutputConstructor]
        private DataboxJobSecretsResponseResult(
            string jobSecretsType,

            ImmutableArray<Outputs.DataBoxSecretResponseResult> podSecrets)
        {
            JobSecretsType = jobSecretsType;
            PodSecrets = podSecrets;
        }
    }
}
