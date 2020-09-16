// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.DevTestLab.V20150521Preview
{
    public static class GetVirtualMachineResource
    {
        public static Task<GetVirtualMachineResourceResult> InvokeAsync(GetVirtualMachineResourceArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetVirtualMachineResourceResult>("azure-nextgen:devtestlab/v20150521preview:getVirtualMachineResource", args ?? new GetVirtualMachineResourceArgs(), options.WithVersion());
    }


    public sealed class GetVirtualMachineResourceArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the lab.
        /// </summary>
        [Input("labName", required: true)]
        public string LabName { get; set; } = null!;

        /// <summary>
        /// The name of the virtual Machine.
        /// </summary>
        [Input("name", required: true)]
        public string Name { get; set; } = null!;

        /// <summary>
        /// The name of the resource group.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        public GetVirtualMachineResourceArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetVirtualMachineResourceResult
    {
        /// <summary>
        /// The artifact deployment status for the virtual machine.
        /// </summary>
        public readonly Outputs.ArtifactDeploymentStatusPropertiesResponse? ArtifactDeploymentStatus;
        /// <summary>
        /// The artifacts to be installed on the virtual machine.
        /// </summary>
        public readonly ImmutableArray<Outputs.ArtifactInstallPropertiesResponse> Artifacts;
        /// <summary>
        /// The resource identifier (Microsoft.Compute) of the virtual machine.
        /// </summary>
        public readonly string? ComputeId;
        /// <summary>
        /// The email address of creator of the virtual machine.
        /// </summary>
        public readonly string? CreatedByUser;
        /// <summary>
        /// The object identifier of the creator of the virtual machine.
        /// </summary>
        public readonly string? CreatedByUserId;
        /// <summary>
        /// The custom image identifier of the virtual machine.
        /// </summary>
        public readonly string? CustomImageId;
        /// <summary>
        /// Indicates whether the virtual machine is to be created without a public IP address.
        /// </summary>
        public readonly bool? DisallowPublicIpAddress;
        /// <summary>
        /// The fully-qualified domain name of the virtual machine.
        /// </summary>
        public readonly string? Fqdn;
        /// <summary>
        /// The Microsoft Azure Marketplace image reference of the virtual machine.
        /// </summary>
        public readonly Outputs.GalleryImageReferenceResponse? GalleryImageReference;
        /// <summary>
        /// A value indicating whether this virtual machine uses an SSH key for authentication.
        /// </summary>
        public readonly bool? IsAuthenticationWithSshKey;
        /// <summary>
        /// The lab subnet name of the virtual machine.
        /// </summary>
        public readonly string? LabSubnetName;
        /// <summary>
        /// The lab virtual network identifier of the virtual machine.
        /// </summary>
        public readonly string? LabVirtualNetworkId;
        /// <summary>
        /// The location of the resource.
        /// </summary>
        public readonly string? Location;
        /// <summary>
        /// The name of the resource.
        /// </summary>
        public readonly string? Name;
        /// <summary>
        /// The notes of the virtual machine.
        /// </summary>
        public readonly string? Notes;
        /// <summary>
        /// The OS type of the virtual machine.
        /// </summary>
        public readonly string? OsType;
        /// <summary>
        /// The object identifier of the owner of the virtual machine.
        /// </summary>
        public readonly string? OwnerObjectId;
        /// <summary>
        /// The password of the virtual machine administrator.
        /// </summary>
        public readonly string? Password;
        /// <summary>
        /// The provisioning status of the resource.
        /// </summary>
        public readonly string? ProvisioningState;
        /// <summary>
        /// The size of the virtual machine.
        /// </summary>
        public readonly string? Size;
        /// <summary>
        /// The SSH key of the virtual machine administrator.
        /// </summary>
        public readonly string? SshKey;
        /// <summary>
        /// The tags of the resource.
        /// </summary>
        public readonly ImmutableDictionary<string, string>? Tags;
        /// <summary>
        /// The type of the resource.
        /// </summary>
        public readonly string? Type;
        /// <summary>
        /// The user name of the virtual machine.
        /// </summary>
        public readonly string? UserName;

        [OutputConstructor]
        private GetVirtualMachineResourceResult(
            Outputs.ArtifactDeploymentStatusPropertiesResponse? artifactDeploymentStatus,

            ImmutableArray<Outputs.ArtifactInstallPropertiesResponse> artifacts,

            string? computeId,

            string? createdByUser,

            string? createdByUserId,

            string? customImageId,

            bool? disallowPublicIpAddress,

            string? fqdn,

            Outputs.GalleryImageReferenceResponse? galleryImageReference,

            bool? isAuthenticationWithSshKey,

            string? labSubnetName,

            string? labVirtualNetworkId,

            string? location,

            string? name,

            string? notes,

            string? osType,

            string? ownerObjectId,

            string? password,

            string? provisioningState,

            string? size,

            string? sshKey,

            ImmutableDictionary<string, string>? tags,

            string? type,

            string? userName)
        {
            ArtifactDeploymentStatus = artifactDeploymentStatus;
            Artifacts = artifacts;
            ComputeId = computeId;
            CreatedByUser = createdByUser;
            CreatedByUserId = createdByUserId;
            CustomImageId = customImageId;
            DisallowPublicIpAddress = disallowPublicIpAddress;
            Fqdn = fqdn;
            GalleryImageReference = galleryImageReference;
            IsAuthenticationWithSshKey = isAuthenticationWithSshKey;
            LabSubnetName = labSubnetName;
            LabVirtualNetworkId = labVirtualNetworkId;
            Location = location;
            Name = name;
            Notes = notes;
            OsType = osType;
            OwnerObjectId = ownerObjectId;
            Password = password;
            ProvisioningState = provisioningState;
            Size = size;
            SshKey = sshKey;
            Tags = tags;
            Type = type;
            UserName = userName;
        }
    }
}