// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.DataBoxEdge.V20200901Preview.Outputs
{

    [OutputType]
    public sealed class UserAccessRightResponse
    {
        /// <summary>
        /// Type of access to be allowed for the user.
        /// </summary>
        public readonly string AccessType;
        /// <summary>
        /// User ID (already existing in the device).
        /// </summary>
        public readonly string UserId;

        [OutputConstructor]
        private UserAccessRightResponse(
            string accessType,

            string userId)
        {
            AccessType = accessType;
            UserId = userId;
        }
    }
}
