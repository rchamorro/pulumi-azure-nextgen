// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.OperationalInsights.V20200101.Outputs
{

    [OutputType]
    public sealed class UserInfoResponse
    {
        /// <summary>
        /// The email of the user.
        /// </summary>
        public readonly string Email;
        /// <summary>
        /// The name of the user.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// The object id of the user.
        /// </summary>
        public readonly string ObjectId;

        [OutputConstructor]
        private UserInfoResponse(
            string email,

            string name,

            string objectId)
        {
            Email = email;
            Name = name;
            ObjectId = objectId;
        }
    }
}