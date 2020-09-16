// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Web.Latest.Outputs
{

    [OutputType]
    public sealed class StaticSiteUserARMResourceResponseResult
    {
        /// <summary>
        /// The display name for the static site user.
        /// </summary>
        public readonly string DisplayName;
        /// <summary>
        /// Resource Id.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// Kind of resource.
        /// </summary>
        public readonly string? Kind;
        /// <summary>
        /// Resource Name.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// The identity provider for the static site user.
        /// </summary>
        public readonly string Provider;
        /// <summary>
        /// The roles for the static site user, in free-form string format
        /// </summary>
        public readonly string? Roles;
        /// <summary>
        /// Resource type.
        /// </summary>
        public readonly string Type;
        /// <summary>
        /// The user id for the static site user.
        /// </summary>
        public readonly string UserId;

        [OutputConstructor]
        private StaticSiteUserARMResourceResponseResult(
            string displayName,

            string id,

            string? kind,

            string name,

            string provider,

            string? roles,

            string type,

            string userId)
        {
            DisplayName = displayName;
            Id = id;
            Kind = kind;
            Name = name;
            Provider = provider;
            Roles = roles;
            Type = type;
            UserId = userId;
        }
    }
}