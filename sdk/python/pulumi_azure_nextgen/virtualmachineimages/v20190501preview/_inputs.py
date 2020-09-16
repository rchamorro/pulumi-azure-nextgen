# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union
from ... import _utilities, _tables

__all__ = [
    'ImageTemplateFileCustomizerArgs',
    'ImageTemplateIdentityArgs',
    'ImageTemplateIsoSourceArgs',
    'ImageTemplateManagedImageDistributorArgs',
    'ImageTemplateManagedImageSourceArgs',
    'ImageTemplatePlatformImageSourceArgs',
    'ImageTemplatePowerShellCustomizerArgs',
    'ImageTemplateRestartCustomizerArgs',
    'ImageTemplateSharedImageDistributorArgs',
    'ImageTemplateSharedImageVersionSourceArgs',
    'ImageTemplateShellCustomizerArgs',
    'ImageTemplateVhdDistributorArgs',
    'ImageTemplateVmProfileArgs',
]

@pulumi.input_type
class ImageTemplateFileCustomizerArgs:
    def __init__(__self__, *,
                 type: pulumi.Input[str],
                 destination: Optional[pulumi.Input[str]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 sha256_checksum: Optional[pulumi.Input[str]] = None,
                 source_uri: Optional[pulumi.Input[str]] = None):
        """
        Uploads files to VMs (Linux, Windows). Corresponds to Packer file provisioner
        :param pulumi.Input[str] type: The type of customization tool you want to use on the Image. For example, "Shell" can be shell customizer
        :param pulumi.Input[str] destination: The absolute path to a file (with nested directory structures already created) where the file (from sourceUri) will be uploaded to in the VM
        :param pulumi.Input[str] name: Friendly Name to provide context on what this customization step does
        :param pulumi.Input[str] sha256_checksum: SHA256 checksum of the file provided in the sourceUri field above
        :param pulumi.Input[str] source_uri: The URI of the file to be uploaded for customizing the VM. It can be a github link, SAS URI for Azure Storage, etc
        """
        pulumi.set(__self__, "type", 'File')
        if destination is not None:
            pulumi.set(__self__, "destination", destination)
        if name is not None:
            pulumi.set(__self__, "name", name)
        if sha256_checksum is not None:
            pulumi.set(__self__, "sha256_checksum", sha256_checksum)
        if source_uri is not None:
            pulumi.set(__self__, "source_uri", source_uri)

    @property
    @pulumi.getter
    def type(self) -> pulumi.Input[str]:
        """
        The type of customization tool you want to use on the Image. For example, "Shell" can be shell customizer
        """
        return pulumi.get(self, "type")

    @type.setter
    def type(self, value: pulumi.Input[str]):
        pulumi.set(self, "type", value)

    @property
    @pulumi.getter
    def destination(self) -> Optional[pulumi.Input[str]]:
        """
        The absolute path to a file (with nested directory structures already created) where the file (from sourceUri) will be uploaded to in the VM
        """
        return pulumi.get(self, "destination")

    @destination.setter
    def destination(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "destination", value)

    @property
    @pulumi.getter
    def name(self) -> Optional[pulumi.Input[str]]:
        """
        Friendly Name to provide context on what this customization step does
        """
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "name", value)

    @property
    @pulumi.getter(name="sha256Checksum")
    def sha256_checksum(self) -> Optional[pulumi.Input[str]]:
        """
        SHA256 checksum of the file provided in the sourceUri field above
        """
        return pulumi.get(self, "sha256_checksum")

    @sha256_checksum.setter
    def sha256_checksum(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "sha256_checksum", value)

    @property
    @pulumi.getter(name="sourceUri")
    def source_uri(self) -> Optional[pulumi.Input[str]]:
        """
        The URI of the file to be uploaded for customizing the VM. It can be a github link, SAS URI for Azure Storage, etc
        """
        return pulumi.get(self, "source_uri")

    @source_uri.setter
    def source_uri(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "source_uri", value)


@pulumi.input_type
class ImageTemplateIdentityArgs:
    def __init__(__self__, *,
                 type: Optional[pulumi.Input[str]] = None):
        """
        Identity for the image template.
        :param pulumi.Input[str] type: The type of identity used for the image template. The type 'None' will remove any identities from the image template.
        """
        if type is not None:
            pulumi.set(__self__, "type", type)

    @property
    @pulumi.getter
    def type(self) -> Optional[pulumi.Input[str]]:
        """
        The type of identity used for the image template. The type 'None' will remove any identities from the image template.
        """
        return pulumi.get(self, "type")

    @type.setter
    def type(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "type", value)


@pulumi.input_type
class ImageTemplateIsoSourceArgs:
    def __init__(__self__, *,
                 sha256_checksum: pulumi.Input[str],
                 source_uri: pulumi.Input[str],
                 type: pulumi.Input[str]):
        """
        Describes an image source that is an installation ISO. Currently only supports Red Hat Enterprise Linux 7.2-7.5 ISO's.
        :param pulumi.Input[str] sha256_checksum: SHA256 Checksum of the ISO image.
        :param pulumi.Input[str] source_uri: URI to get the ISO image. This URI has to be accessible to the resource provider at the time of the image template creation.
        :param pulumi.Input[str] type: Specifies the type of source image you want to start with.
        """
        pulumi.set(__self__, "sha256_checksum", sha256_checksum)
        pulumi.set(__self__, "source_uri", source_uri)
        pulumi.set(__self__, "type", 'ISO')

    @property
    @pulumi.getter(name="sha256Checksum")
    def sha256_checksum(self) -> pulumi.Input[str]:
        """
        SHA256 Checksum of the ISO image.
        """
        return pulumi.get(self, "sha256_checksum")

    @sha256_checksum.setter
    def sha256_checksum(self, value: pulumi.Input[str]):
        pulumi.set(self, "sha256_checksum", value)

    @property
    @pulumi.getter(name="sourceUri")
    def source_uri(self) -> pulumi.Input[str]:
        """
        URI to get the ISO image. This URI has to be accessible to the resource provider at the time of the image template creation.
        """
        return pulumi.get(self, "source_uri")

    @source_uri.setter
    def source_uri(self, value: pulumi.Input[str]):
        pulumi.set(self, "source_uri", value)

    @property
    @pulumi.getter
    def type(self) -> pulumi.Input[str]:
        """
        Specifies the type of source image you want to start with.
        """
        return pulumi.get(self, "type")

    @type.setter
    def type(self, value: pulumi.Input[str]):
        pulumi.set(self, "type", value)


@pulumi.input_type
class ImageTemplateManagedImageDistributorArgs:
    def __init__(__self__, *,
                 image_id: pulumi.Input[str],
                 location: pulumi.Input[str],
                 run_output_name: pulumi.Input[str],
                 type: pulumi.Input[str],
                 artifact_tags: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None):
        """
        Distribute as a Managed Disk Image.
        :param pulumi.Input[str] image_id: Resource Id of the Managed Disk Image
        :param pulumi.Input[str] location: Azure location for the image, should match if image already exists
        :param pulumi.Input[str] run_output_name: The name to be used for the associated RunOutput.
        :param pulumi.Input[str] type: Type of distribution.
        :param pulumi.Input[Mapping[str, pulumi.Input[str]]] artifact_tags: Tags that will be applied to the artifact once it has been created/updated by the distributor.
        """
        pulumi.set(__self__, "image_id", image_id)
        pulumi.set(__self__, "location", location)
        pulumi.set(__self__, "run_output_name", run_output_name)
        pulumi.set(__self__, "type", 'ManagedImage')
        if artifact_tags is not None:
            pulumi.set(__self__, "artifact_tags", artifact_tags)

    @property
    @pulumi.getter(name="imageId")
    def image_id(self) -> pulumi.Input[str]:
        """
        Resource Id of the Managed Disk Image
        """
        return pulumi.get(self, "image_id")

    @image_id.setter
    def image_id(self, value: pulumi.Input[str]):
        pulumi.set(self, "image_id", value)

    @property
    @pulumi.getter
    def location(self) -> pulumi.Input[str]:
        """
        Azure location for the image, should match if image already exists
        """
        return pulumi.get(self, "location")

    @location.setter
    def location(self, value: pulumi.Input[str]):
        pulumi.set(self, "location", value)

    @property
    @pulumi.getter(name="runOutputName")
    def run_output_name(self) -> pulumi.Input[str]:
        """
        The name to be used for the associated RunOutput.
        """
        return pulumi.get(self, "run_output_name")

    @run_output_name.setter
    def run_output_name(self, value: pulumi.Input[str]):
        pulumi.set(self, "run_output_name", value)

    @property
    @pulumi.getter
    def type(self) -> pulumi.Input[str]:
        """
        Type of distribution.
        """
        return pulumi.get(self, "type")

    @type.setter
    def type(self, value: pulumi.Input[str]):
        pulumi.set(self, "type", value)

    @property
    @pulumi.getter(name="artifactTags")
    def artifact_tags(self) -> Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]]:
        """
        Tags that will be applied to the artifact once it has been created/updated by the distributor.
        """
        return pulumi.get(self, "artifact_tags")

    @artifact_tags.setter
    def artifact_tags(self, value: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]]):
        pulumi.set(self, "artifact_tags", value)


@pulumi.input_type
class ImageTemplateManagedImageSourceArgs:
    def __init__(__self__, *,
                 image_id: pulumi.Input[str],
                 type: pulumi.Input[str]):
        """
        Describes an image source that is a managed image in customer subscription.
        :param pulumi.Input[str] image_id: ARM resource id of the managed image in customer subscription
        :param pulumi.Input[str] type: Specifies the type of source image you want to start with.
        """
        pulumi.set(__self__, "image_id", image_id)
        pulumi.set(__self__, "type", 'ManagedImage')

    @property
    @pulumi.getter(name="imageId")
    def image_id(self) -> pulumi.Input[str]:
        """
        ARM resource id of the managed image in customer subscription
        """
        return pulumi.get(self, "image_id")

    @image_id.setter
    def image_id(self, value: pulumi.Input[str]):
        pulumi.set(self, "image_id", value)

    @property
    @pulumi.getter
    def type(self) -> pulumi.Input[str]:
        """
        Specifies the type of source image you want to start with.
        """
        return pulumi.get(self, "type")

    @type.setter
    def type(self, value: pulumi.Input[str]):
        pulumi.set(self, "type", value)


@pulumi.input_type
class ImageTemplatePlatformImageSourceArgs:
    def __init__(__self__, *,
                 type: pulumi.Input[str],
                 offer: Optional[pulumi.Input[str]] = None,
                 publisher: Optional[pulumi.Input[str]] = None,
                 sku: Optional[pulumi.Input[str]] = None,
                 version: Optional[pulumi.Input[str]] = None):
        """
        Describes an image source from [Azure Gallery Images](https://docs.microsoft.com/en-us/rest/api/compute/virtualmachineimages).
        :param pulumi.Input[str] type: Specifies the type of source image you want to start with.
        :param pulumi.Input[str] offer: Image offer from the [Azure Gallery Images](https://docs.microsoft.com/en-us/rest/api/compute/virtualmachineimages).
        :param pulumi.Input[str] publisher: Image Publisher in [Azure Gallery Images](https://docs.microsoft.com/en-us/rest/api/compute/virtualmachineimages).
        :param pulumi.Input[str] sku: Image sku from the [Azure Gallery Images](https://docs.microsoft.com/en-us/rest/api/compute/virtualmachineimages).
        :param pulumi.Input[str] version: Image version from the [Azure Gallery Images](https://docs.microsoft.com/en-us/rest/api/compute/virtualmachineimages).
        """
        pulumi.set(__self__, "type", 'PlatformImage')
        if offer is not None:
            pulumi.set(__self__, "offer", offer)
        if publisher is not None:
            pulumi.set(__self__, "publisher", publisher)
        if sku is not None:
            pulumi.set(__self__, "sku", sku)
        if version is not None:
            pulumi.set(__self__, "version", version)

    @property
    @pulumi.getter
    def type(self) -> pulumi.Input[str]:
        """
        Specifies the type of source image you want to start with.
        """
        return pulumi.get(self, "type")

    @type.setter
    def type(self, value: pulumi.Input[str]):
        pulumi.set(self, "type", value)

    @property
    @pulumi.getter
    def offer(self) -> Optional[pulumi.Input[str]]:
        """
        Image offer from the [Azure Gallery Images](https://docs.microsoft.com/en-us/rest/api/compute/virtualmachineimages).
        """
        return pulumi.get(self, "offer")

    @offer.setter
    def offer(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "offer", value)

    @property
    @pulumi.getter
    def publisher(self) -> Optional[pulumi.Input[str]]:
        """
        Image Publisher in [Azure Gallery Images](https://docs.microsoft.com/en-us/rest/api/compute/virtualmachineimages).
        """
        return pulumi.get(self, "publisher")

    @publisher.setter
    def publisher(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "publisher", value)

    @property
    @pulumi.getter
    def sku(self) -> Optional[pulumi.Input[str]]:
        """
        Image sku from the [Azure Gallery Images](https://docs.microsoft.com/en-us/rest/api/compute/virtualmachineimages).
        """
        return pulumi.get(self, "sku")

    @sku.setter
    def sku(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "sku", value)

    @property
    @pulumi.getter
    def version(self) -> Optional[pulumi.Input[str]]:
        """
        Image version from the [Azure Gallery Images](https://docs.microsoft.com/en-us/rest/api/compute/virtualmachineimages).
        """
        return pulumi.get(self, "version")

    @version.setter
    def version(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "version", value)


@pulumi.input_type
class ImageTemplatePowerShellCustomizerArgs:
    def __init__(__self__, *,
                 type: pulumi.Input[str],
                 inline: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 run_elevated: Optional[pulumi.Input[bool]] = None,
                 script_uri: Optional[pulumi.Input[str]] = None,
                 sha256_checksum: Optional[pulumi.Input[str]] = None,
                 valid_exit_codes: Optional[pulumi.Input[Sequence[pulumi.Input[int]]]] = None):
        """
        Runs the specified PowerShell on the VM (Windows). Corresponds to Packer powershell provisioner. Exactly one of 'scriptUri' or 'inline' can be specified.
        :param pulumi.Input[str] type: The type of customization tool you want to use on the Image. For example, "Shell" can be shell customizer
        :param pulumi.Input[Sequence[pulumi.Input[str]]] inline: Array of PowerShell commands to execute
        :param pulumi.Input[str] name: Friendly Name to provide context on what this customization step does
        :param pulumi.Input[bool] run_elevated: If specified, the PowerShell script will be run with elevated privileges
        :param pulumi.Input[str] script_uri: URI of the PowerShell script to be run for customizing. It can be a github link, SAS URI for Azure Storage, etc
        :param pulumi.Input[str] sha256_checksum: SHA256 checksum of the power shell script provided in the scriptUri field above
        :param pulumi.Input[Sequence[pulumi.Input[int]]] valid_exit_codes: Valid exit codes for the PowerShell script. [Default: 0]
        """
        pulumi.set(__self__, "type", 'PowerShell')
        if inline is not None:
            pulumi.set(__self__, "inline", inline)
        if name is not None:
            pulumi.set(__self__, "name", name)
        if run_elevated is not None:
            pulumi.set(__self__, "run_elevated", run_elevated)
        if script_uri is not None:
            pulumi.set(__self__, "script_uri", script_uri)
        if sha256_checksum is not None:
            pulumi.set(__self__, "sha256_checksum", sha256_checksum)
        if valid_exit_codes is not None:
            pulumi.set(__self__, "valid_exit_codes", valid_exit_codes)

    @property
    @pulumi.getter
    def type(self) -> pulumi.Input[str]:
        """
        The type of customization tool you want to use on the Image. For example, "Shell" can be shell customizer
        """
        return pulumi.get(self, "type")

    @type.setter
    def type(self, value: pulumi.Input[str]):
        pulumi.set(self, "type", value)

    @property
    @pulumi.getter
    def inline(self) -> Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]:
        """
        Array of PowerShell commands to execute
        """
        return pulumi.get(self, "inline")

    @inline.setter
    def inline(self, value: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]):
        pulumi.set(self, "inline", value)

    @property
    @pulumi.getter
    def name(self) -> Optional[pulumi.Input[str]]:
        """
        Friendly Name to provide context on what this customization step does
        """
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "name", value)

    @property
    @pulumi.getter(name="runElevated")
    def run_elevated(self) -> Optional[pulumi.Input[bool]]:
        """
        If specified, the PowerShell script will be run with elevated privileges
        """
        return pulumi.get(self, "run_elevated")

    @run_elevated.setter
    def run_elevated(self, value: Optional[pulumi.Input[bool]]):
        pulumi.set(self, "run_elevated", value)

    @property
    @pulumi.getter(name="scriptUri")
    def script_uri(self) -> Optional[pulumi.Input[str]]:
        """
        URI of the PowerShell script to be run for customizing. It can be a github link, SAS URI for Azure Storage, etc
        """
        return pulumi.get(self, "script_uri")

    @script_uri.setter
    def script_uri(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "script_uri", value)

    @property
    @pulumi.getter(name="sha256Checksum")
    def sha256_checksum(self) -> Optional[pulumi.Input[str]]:
        """
        SHA256 checksum of the power shell script provided in the scriptUri field above
        """
        return pulumi.get(self, "sha256_checksum")

    @sha256_checksum.setter
    def sha256_checksum(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "sha256_checksum", value)

    @property
    @pulumi.getter(name="validExitCodes")
    def valid_exit_codes(self) -> Optional[pulumi.Input[Sequence[pulumi.Input[int]]]]:
        """
        Valid exit codes for the PowerShell script. [Default: 0]
        """
        return pulumi.get(self, "valid_exit_codes")

    @valid_exit_codes.setter
    def valid_exit_codes(self, value: Optional[pulumi.Input[Sequence[pulumi.Input[int]]]]):
        pulumi.set(self, "valid_exit_codes", value)


@pulumi.input_type
class ImageTemplateRestartCustomizerArgs:
    def __init__(__self__, *,
                 type: pulumi.Input[str],
                 name: Optional[pulumi.Input[str]] = None,
                 restart_check_command: Optional[pulumi.Input[str]] = None,
                 restart_command: Optional[pulumi.Input[str]] = None,
                 restart_timeout: Optional[pulumi.Input[str]] = None):
        """
        Reboots a VM and waits for it to come back online (Windows). Corresponds to Packer windows-restart provisioner
        :param pulumi.Input[str] type: The type of customization tool you want to use on the Image. For example, "Shell" can be shell customizer
        :param pulumi.Input[str] name: Friendly Name to provide context on what this customization step does
        :param pulumi.Input[str] restart_check_command: Command to check if restart succeeded [Default: '']
        :param pulumi.Input[str] restart_command: Command to execute the restart [Default: 'shutdown /r /f /t 0 /c "packer restart"']
        :param pulumi.Input[str] restart_timeout: Restart timeout specified as a string of magnitude and unit, e.g. '5m' (5 minutes) or '2h' (2 hours) [Default: '5m']
        """
        pulumi.set(__self__, "type", 'WindowsRestart')
        if name is not None:
            pulumi.set(__self__, "name", name)
        if restart_check_command is not None:
            pulumi.set(__self__, "restart_check_command", restart_check_command)
        if restart_command is not None:
            pulumi.set(__self__, "restart_command", restart_command)
        if restart_timeout is not None:
            pulumi.set(__self__, "restart_timeout", restart_timeout)

    @property
    @pulumi.getter
    def type(self) -> pulumi.Input[str]:
        """
        The type of customization tool you want to use on the Image. For example, "Shell" can be shell customizer
        """
        return pulumi.get(self, "type")

    @type.setter
    def type(self, value: pulumi.Input[str]):
        pulumi.set(self, "type", value)

    @property
    @pulumi.getter
    def name(self) -> Optional[pulumi.Input[str]]:
        """
        Friendly Name to provide context on what this customization step does
        """
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "name", value)

    @property
    @pulumi.getter(name="restartCheckCommand")
    def restart_check_command(self) -> Optional[pulumi.Input[str]]:
        """
        Command to check if restart succeeded [Default: '']
        """
        return pulumi.get(self, "restart_check_command")

    @restart_check_command.setter
    def restart_check_command(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "restart_check_command", value)

    @property
    @pulumi.getter(name="restartCommand")
    def restart_command(self) -> Optional[pulumi.Input[str]]:
        """
        Command to execute the restart [Default: 'shutdown /r /f /t 0 /c "packer restart"']
        """
        return pulumi.get(self, "restart_command")

    @restart_command.setter
    def restart_command(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "restart_command", value)

    @property
    @pulumi.getter(name="restartTimeout")
    def restart_timeout(self) -> Optional[pulumi.Input[str]]:
        """
        Restart timeout specified as a string of magnitude and unit, e.g. '5m' (5 minutes) or '2h' (2 hours) [Default: '5m']
        """
        return pulumi.get(self, "restart_timeout")

    @restart_timeout.setter
    def restart_timeout(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "restart_timeout", value)


@pulumi.input_type
class ImageTemplateSharedImageDistributorArgs:
    def __init__(__self__, *,
                 gallery_image_id: pulumi.Input[str],
                 replication_regions: pulumi.Input[Sequence[pulumi.Input[str]]],
                 run_output_name: pulumi.Input[str],
                 type: pulumi.Input[str],
                 artifact_tags: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None):
        """
        Distribute via Shared Image Gallery.
        :param pulumi.Input[str] gallery_image_id: Resource Id of the Shared Image Gallery image
        :param pulumi.Input[Sequence[pulumi.Input[str]]] replication_regions: A list of regions that the image will be replicated to
        :param pulumi.Input[str] run_output_name: The name to be used for the associated RunOutput.
        :param pulumi.Input[str] type: Type of distribution.
        :param pulumi.Input[Mapping[str, pulumi.Input[str]]] artifact_tags: Tags that will be applied to the artifact once it has been created/updated by the distributor.
        """
        pulumi.set(__self__, "gallery_image_id", gallery_image_id)
        pulumi.set(__self__, "replication_regions", replication_regions)
        pulumi.set(__self__, "run_output_name", run_output_name)
        pulumi.set(__self__, "type", 'SharedImage')
        if artifact_tags is not None:
            pulumi.set(__self__, "artifact_tags", artifact_tags)

    @property
    @pulumi.getter(name="galleryImageId")
    def gallery_image_id(self) -> pulumi.Input[str]:
        """
        Resource Id of the Shared Image Gallery image
        """
        return pulumi.get(self, "gallery_image_id")

    @gallery_image_id.setter
    def gallery_image_id(self, value: pulumi.Input[str]):
        pulumi.set(self, "gallery_image_id", value)

    @property
    @pulumi.getter(name="replicationRegions")
    def replication_regions(self) -> pulumi.Input[Sequence[pulumi.Input[str]]]:
        """
        A list of regions that the image will be replicated to
        """
        return pulumi.get(self, "replication_regions")

    @replication_regions.setter
    def replication_regions(self, value: pulumi.Input[Sequence[pulumi.Input[str]]]):
        pulumi.set(self, "replication_regions", value)

    @property
    @pulumi.getter(name="runOutputName")
    def run_output_name(self) -> pulumi.Input[str]:
        """
        The name to be used for the associated RunOutput.
        """
        return pulumi.get(self, "run_output_name")

    @run_output_name.setter
    def run_output_name(self, value: pulumi.Input[str]):
        pulumi.set(self, "run_output_name", value)

    @property
    @pulumi.getter
    def type(self) -> pulumi.Input[str]:
        """
        Type of distribution.
        """
        return pulumi.get(self, "type")

    @type.setter
    def type(self, value: pulumi.Input[str]):
        pulumi.set(self, "type", value)

    @property
    @pulumi.getter(name="artifactTags")
    def artifact_tags(self) -> Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]]:
        """
        Tags that will be applied to the artifact once it has been created/updated by the distributor.
        """
        return pulumi.get(self, "artifact_tags")

    @artifact_tags.setter
    def artifact_tags(self, value: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]]):
        pulumi.set(self, "artifact_tags", value)


@pulumi.input_type
class ImageTemplateSharedImageVersionSourceArgs:
    def __init__(__self__, *,
                 image_version_id: pulumi.Input[str],
                 type: pulumi.Input[str]):
        """
        Describes an image source that is an image version in a shared image gallery.
        :param pulumi.Input[str] image_version_id: ARM resource id of the image version in the shared image gallery
        :param pulumi.Input[str] type: Specifies the type of source image you want to start with.
        """
        pulumi.set(__self__, "image_version_id", image_version_id)
        pulumi.set(__self__, "type", 'SharedImageVersion')

    @property
    @pulumi.getter(name="imageVersionId")
    def image_version_id(self) -> pulumi.Input[str]:
        """
        ARM resource id of the image version in the shared image gallery
        """
        return pulumi.get(self, "image_version_id")

    @image_version_id.setter
    def image_version_id(self, value: pulumi.Input[str]):
        pulumi.set(self, "image_version_id", value)

    @property
    @pulumi.getter
    def type(self) -> pulumi.Input[str]:
        """
        Specifies the type of source image you want to start with.
        """
        return pulumi.get(self, "type")

    @type.setter
    def type(self, value: pulumi.Input[str]):
        pulumi.set(self, "type", value)


@pulumi.input_type
class ImageTemplateShellCustomizerArgs:
    def __init__(__self__, *,
                 type: pulumi.Input[str],
                 inline: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 script_uri: Optional[pulumi.Input[str]] = None,
                 sha256_checksum: Optional[pulumi.Input[str]] = None):
        """
        Runs a shell script during the customization phase (Linux). Corresponds to Packer shell provisioner. Exactly one of 'scriptUri' or 'inline' can be specified.
        :param pulumi.Input[str] type: The type of customization tool you want to use on the Image. For example, "Shell" can be shell customizer
        :param pulumi.Input[Sequence[pulumi.Input[str]]] inline: Array of shell commands to execute
        :param pulumi.Input[str] name: Friendly Name to provide context on what this customization step does
        :param pulumi.Input[str] script_uri: URI of the shell script to be run for customizing. It can be a github link, SAS URI for Azure Storage, etc
        :param pulumi.Input[str] sha256_checksum: SHA256 checksum of the shell script provided in the scriptUri field
        """
        pulumi.set(__self__, "type", 'Shell')
        if inline is not None:
            pulumi.set(__self__, "inline", inline)
        if name is not None:
            pulumi.set(__self__, "name", name)
        if script_uri is not None:
            pulumi.set(__self__, "script_uri", script_uri)
        if sha256_checksum is not None:
            pulumi.set(__self__, "sha256_checksum", sha256_checksum)

    @property
    @pulumi.getter
    def type(self) -> pulumi.Input[str]:
        """
        The type of customization tool you want to use on the Image. For example, "Shell" can be shell customizer
        """
        return pulumi.get(self, "type")

    @type.setter
    def type(self, value: pulumi.Input[str]):
        pulumi.set(self, "type", value)

    @property
    @pulumi.getter
    def inline(self) -> Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]:
        """
        Array of shell commands to execute
        """
        return pulumi.get(self, "inline")

    @inline.setter
    def inline(self, value: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]):
        pulumi.set(self, "inline", value)

    @property
    @pulumi.getter
    def name(self) -> Optional[pulumi.Input[str]]:
        """
        Friendly Name to provide context on what this customization step does
        """
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "name", value)

    @property
    @pulumi.getter(name="scriptUri")
    def script_uri(self) -> Optional[pulumi.Input[str]]:
        """
        URI of the shell script to be run for customizing. It can be a github link, SAS URI for Azure Storage, etc
        """
        return pulumi.get(self, "script_uri")

    @script_uri.setter
    def script_uri(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "script_uri", value)

    @property
    @pulumi.getter(name="sha256Checksum")
    def sha256_checksum(self) -> Optional[pulumi.Input[str]]:
        """
        SHA256 checksum of the shell script provided in the scriptUri field
        """
        return pulumi.get(self, "sha256_checksum")

    @sha256_checksum.setter
    def sha256_checksum(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "sha256_checksum", value)


@pulumi.input_type
class ImageTemplateVhdDistributorArgs:
    def __init__(__self__, *,
                 run_output_name: pulumi.Input[str],
                 type: pulumi.Input[str],
                 artifact_tags: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None):
        """
        Distribute via VHD in a storage account.
        :param pulumi.Input[str] run_output_name: The name to be used for the associated RunOutput.
        :param pulumi.Input[str] type: Type of distribution.
        :param pulumi.Input[Mapping[str, pulumi.Input[str]]] artifact_tags: Tags that will be applied to the artifact once it has been created/updated by the distributor.
        """
        pulumi.set(__self__, "run_output_name", run_output_name)
        pulumi.set(__self__, "type", 'VHD')
        if artifact_tags is not None:
            pulumi.set(__self__, "artifact_tags", artifact_tags)

    @property
    @pulumi.getter(name="runOutputName")
    def run_output_name(self) -> pulumi.Input[str]:
        """
        The name to be used for the associated RunOutput.
        """
        return pulumi.get(self, "run_output_name")

    @run_output_name.setter
    def run_output_name(self, value: pulumi.Input[str]):
        pulumi.set(self, "run_output_name", value)

    @property
    @pulumi.getter
    def type(self) -> pulumi.Input[str]:
        """
        Type of distribution.
        """
        return pulumi.get(self, "type")

    @type.setter
    def type(self, value: pulumi.Input[str]):
        pulumi.set(self, "type", value)

    @property
    @pulumi.getter(name="artifactTags")
    def artifact_tags(self) -> Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]]:
        """
        Tags that will be applied to the artifact once it has been created/updated by the distributor.
        """
        return pulumi.get(self, "artifact_tags")

    @artifact_tags.setter
    def artifact_tags(self, value: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]]):
        pulumi.set(self, "artifact_tags", value)


@pulumi.input_type
class ImageTemplateVmProfileArgs:
    def __init__(__self__, *,
                 vm_size: Optional[pulumi.Input[str]] = None):
        """
        Describes the virtual machine used to build, customize and capture images
        :param pulumi.Input[str] vm_size: Size of the virtual machine used to build, customize and capture images. Omit or specify empty string to use the default (Standard_D1_v2).
        """
        if vm_size is not None:
            pulumi.set(__self__, "vm_size", vm_size)

    @property
    @pulumi.getter(name="vmSize")
    def vm_size(self) -> Optional[pulumi.Input[str]]:
        """
        Size of the virtual machine used to build, customize and capture images. Omit or specify empty string to use the default (Standard_D1_v2).
        """
        return pulumi.get(self, "vm_size")

    @vm_size.setter
    def vm_size(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "vm_size", value)

