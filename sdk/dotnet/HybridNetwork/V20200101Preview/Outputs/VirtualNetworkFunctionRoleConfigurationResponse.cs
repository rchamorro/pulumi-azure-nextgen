// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.HybridNetwork.V20200101Preview.Outputs
{

    [OutputType]
    public sealed class VirtualNetworkFunctionRoleConfigurationResponse
    {
        /// <summary>
        /// The definition of image reference.
        /// </summary>
        public readonly Outputs.ImageReferenceResponse? ImageReference;
        /// <summary>
        /// The network interface configurations.
        /// </summary>
        public readonly ImmutableArray<Outputs.NetworkInterfaceResponse> NetworkInterfaces;
        /// <summary>
        /// Specifies the operating system settings for the role instance. This value can be updated during the deployment of virtual network function.
        /// </summary>
        public readonly Outputs.OsProfileResponse? OsProfile;
        /// <summary>
        /// The name of the virtual network function role.
        /// </summary>
        public readonly string? RoleName;
        /// <summary>
        /// Role type.
        /// </summary>
        public readonly string? RoleType;
        /// <summary>
        /// The user parameters for customers. The format of user data parameters has to be matched with the provided user data template.
        /// </summary>
        public readonly object? UserDataParameters;
        /// <summary>
        /// The user data template for customers. This is json scheme template describing the format and data type of user data parameters.
        /// </summary>
        public readonly object? UserDataTemplate;
        /// <summary>
        /// The size of the virtual machine.
        /// </summary>
        public readonly string? VirtualMachineSize;

        [OutputConstructor]
        private VirtualNetworkFunctionRoleConfigurationResponse(
            Outputs.ImageReferenceResponse? imageReference,

            ImmutableArray<Outputs.NetworkInterfaceResponse> networkInterfaces,

            Outputs.OsProfileResponse? osProfile,

            string? roleName,

            string? roleType,

            object? userDataParameters,

            object? userDataTemplate,

            string? virtualMachineSize)
        {
            ImageReference = imageReference;
            NetworkInterfaces = networkInterfaces;
            OsProfile = osProfile;
            RoleName = roleName;
            RoleType = roleType;
            UserDataParameters = userDataParameters;
            UserDataTemplate = userDataTemplate;
            VirtualMachineSize = virtualMachineSize;
        }
    }
}
