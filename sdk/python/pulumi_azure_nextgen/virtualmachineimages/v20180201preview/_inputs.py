# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union
from ... import _utilities, _tables

__all__ = [
    'ImageTemplateIsoSourceArgs',
    'ImageTemplateManagedImageDistributorArgs',
    'ImageTemplatePlatformImageSourceArgs',
    'ImageTemplateSharedImageDistributorArgs',
    'ImageTemplateShellCustomizerArgs',
]

@pulumi.input_type
class ImageTemplateIsoSourceArgs:
    def __init__(__self__, *,
                 sha256_checksum: pulumi.Input[str],
                 source_uri: pulumi.Input[str],
                 type: pulumi.Input[str]):
        """
        Describes an image source that is an installation ISO. Currently only supports Red Hat Enterprise Linux 7.2-7.5 ISO's.
        :param pulumi.Input[str] sha256_checksum: SHA256 Checksum of the ISO image.
        :param pulumi.Input[str] source_uri: URL to get the ISO image. This URL has to be accessible to the resource provider at the time of the imageTemplate creation.
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
    @pulumi.getter(name="sourceURI")
    def source_uri(self) -> pulumi.Input[str]:
        """
        URL to get the ISO image. This URL has to be accessible to the resource provider at the time of the imageTemplate creation.
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
        pulumi.set(__self__, "type", 'managedImage')
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
        :param pulumi.Input[str] run_output_name: The name to be used for the associated RunOutput.
        :param pulumi.Input[str] type: Type of distribution.
        :param pulumi.Input[Mapping[str, pulumi.Input[str]]] artifact_tags: Tags that will be applied to the artifact once it has been created/updated by the distributor.
        """
        pulumi.set(__self__, "gallery_image_id", gallery_image_id)
        pulumi.set(__self__, "replication_regions", replication_regions)
        pulumi.set(__self__, "run_output_name", run_output_name)
        pulumi.set(__self__, "type", 'sharedImage')
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
class ImageTemplateShellCustomizerArgs:
    def __init__(__self__, *,
                 type: pulumi.Input[str],
                 name: Optional[pulumi.Input[str]] = None,
                 script: Optional[pulumi.Input[str]] = None):
        """
        Runs a shell script during the customization phase
        :param pulumi.Input[str] type: The type of customization tool you want to use on the Image. For example, "shell" can be shellCustomizer
        :param pulumi.Input[str] name: Friendly Name to provide context on what this customization step does
        :param pulumi.Input[str] script: The shell script to be run for customizing. It can be a github link, SAS URI for Azure Storage, etc
        """
        pulumi.set(__self__, "type", 'shell')
        if name is not None:
            pulumi.set(__self__, "name", name)
        if script is not None:
            pulumi.set(__self__, "script", script)

    @property
    @pulumi.getter
    def type(self) -> pulumi.Input[str]:
        """
        The type of customization tool you want to use on the Image. For example, "shell" can be shellCustomizer
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
    @pulumi.getter
    def script(self) -> Optional[pulumi.Input[str]]:
        """
        The shell script to be run for customizing. It can be a github link, SAS URI for Azure Storage, etc
        """
        return pulumi.get(self, "script")

    @script.setter
    def script(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "script", value)

