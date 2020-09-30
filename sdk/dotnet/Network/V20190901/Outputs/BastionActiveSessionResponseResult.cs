// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Network.V20190901.Outputs
{

    [OutputType]
    public sealed class BastionActiveSessionResponseResult
    {
        /// <summary>
        /// The protocol used to connect to the target.
        /// </summary>
        public readonly string Protocol;
        /// <summary>
        /// The type of the resource.
        /// </summary>
        public readonly string ResourceType;
        /// <summary>
        /// Duration in mins the session has been active.
        /// </summary>
        public readonly double SessionDurationInMins;
        /// <summary>
        /// A unique id for the session.
        /// </summary>
        public readonly string SessionId;
        /// <summary>
        /// The time when the session started.
        /// </summary>
        public readonly object StartTime;
        /// <summary>
        /// The host name of the target.
        /// </summary>
        public readonly string TargetHostName;
        /// <summary>
        /// The IP Address of the target.
        /// </summary>
        public readonly string TargetIpAddress;
        /// <summary>
        /// The resource group of the target.
        /// </summary>
        public readonly string TargetResourceGroup;
        /// <summary>
        /// The resource id of the target.
        /// </summary>
        public readonly string TargetResourceId;
        /// <summary>
        /// The subscription id for the target virtual machine.
        /// </summary>
        public readonly string TargetSubscriptionId;
        /// <summary>
        /// The user name who is active on this session.
        /// </summary>
        public readonly string UserName;

        [OutputConstructor]
        private BastionActiveSessionResponseResult(
            string protocol,

            string resourceType,

            double sessionDurationInMins,

            string sessionId,

            object startTime,

            string targetHostName,

            string targetIpAddress,

            string targetResourceGroup,

            string targetResourceId,

            string targetSubscriptionId,

            string userName)
        {
            Protocol = protocol;
            ResourceType = resourceType;
            SessionDurationInMins = sessionDurationInMins;
            SessionId = sessionId;
            StartTime = startTime;
            TargetHostName = targetHostName;
            TargetIpAddress = targetIpAddress;
            TargetResourceGroup = targetResourceGroup;
            TargetResourceId = targetResourceId;
            TargetSubscriptionId = targetSubscriptionId;
            UserName = userName;
        }
    }
}
