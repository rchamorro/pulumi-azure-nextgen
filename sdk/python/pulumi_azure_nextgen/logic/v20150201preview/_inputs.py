# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union
from ... import _utilities, _tables

__all__ = [
    'ContentHashArgs',
    'ContentLinkArgs',
    'ResourceReferenceArgs',
    'SkuArgs',
    'WorkflowParameterArgs',
]

@pulumi.input_type
class ContentHashArgs:
    def __init__(__self__, *,
                 algorithm: Optional[pulumi.Input[str]] = None,
                 value: Optional[pulumi.Input[str]] = None):
        """
        :param pulumi.Input[str] algorithm: Gets or sets the algorithm.
        :param pulumi.Input[str] value: Gets or sets the value.
        """
        if algorithm is not None:
            pulumi.set(__self__, "algorithm", algorithm)
        if value is not None:
            pulumi.set(__self__, "value", value)

    @property
    @pulumi.getter
    def algorithm(self) -> Optional[pulumi.Input[str]]:
        """
        Gets or sets the algorithm.
        """
        return pulumi.get(self, "algorithm")

    @algorithm.setter
    def algorithm(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "algorithm", value)

    @property
    @pulumi.getter
    def value(self) -> Optional[pulumi.Input[str]]:
        """
        Gets or sets the value.
        """
        return pulumi.get(self, "value")

    @value.setter
    def value(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "value", value)


@pulumi.input_type
class ContentLinkArgs:
    def __init__(__self__, *,
                 content_hash: Optional[pulumi.Input['ContentHashArgs']] = None,
                 content_size: Optional[pulumi.Input[int]] = None,
                 content_version: Optional[pulumi.Input[str]] = None,
                 metadata: Optional[Any] = None,
                 uri: Optional[pulumi.Input[str]] = None):
        """
        :param pulumi.Input['ContentHashArgs'] content_hash: Gets or sets the content hash.
        :param pulumi.Input[int] content_size: Gets or sets the content size.
        :param pulumi.Input[str] content_version: Gets or sets the content version.
        :param Any metadata: Gets or sets the metadata.
        :param pulumi.Input[str] uri: Gets or sets the content link URI.
        """
        if content_hash is not None:
            pulumi.set(__self__, "content_hash", content_hash)
        if content_size is not None:
            pulumi.set(__self__, "content_size", content_size)
        if content_version is not None:
            pulumi.set(__self__, "content_version", content_version)
        if metadata is not None:
            pulumi.set(__self__, "metadata", metadata)
        if uri is not None:
            pulumi.set(__self__, "uri", uri)

    @property
    @pulumi.getter(name="contentHash")
    def content_hash(self) -> Optional[pulumi.Input['ContentHashArgs']]:
        """
        Gets or sets the content hash.
        """
        return pulumi.get(self, "content_hash")

    @content_hash.setter
    def content_hash(self, value: Optional[pulumi.Input['ContentHashArgs']]):
        pulumi.set(self, "content_hash", value)

    @property
    @pulumi.getter(name="contentSize")
    def content_size(self) -> Optional[pulumi.Input[int]]:
        """
        Gets or sets the content size.
        """
        return pulumi.get(self, "content_size")

    @content_size.setter
    def content_size(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "content_size", value)

    @property
    @pulumi.getter(name="contentVersion")
    def content_version(self) -> Optional[pulumi.Input[str]]:
        """
        Gets or sets the content version.
        """
        return pulumi.get(self, "content_version")

    @content_version.setter
    def content_version(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "content_version", value)

    @property
    @pulumi.getter
    def metadata(self) -> Optional[Any]:
        """
        Gets or sets the metadata.
        """
        return pulumi.get(self, "metadata")

    @metadata.setter
    def metadata(self, value: Optional[Any]):
        pulumi.set(self, "metadata", value)

    @property
    @pulumi.getter
    def uri(self) -> Optional[pulumi.Input[str]]:
        """
        Gets or sets the content link URI.
        """
        return pulumi.get(self, "uri")

    @uri.setter
    def uri(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "uri", value)


@pulumi.input_type
class ResourceReferenceArgs:
    def __init__(__self__, *,
                 id: Optional[pulumi.Input[str]] = None):
        """
        :param pulumi.Input[str] id: Gets or sets the resource id.
        """
        if id is not None:
            pulumi.set(__self__, "id", id)

    @property
    @pulumi.getter
    def id(self) -> Optional[pulumi.Input[str]]:
        """
        Gets or sets the resource id.
        """
        return pulumi.get(self, "id")

    @id.setter
    def id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "id", value)


@pulumi.input_type
class SkuArgs:
    def __init__(__self__, *,
                 name: Optional[pulumi.Input[str]] = None,
                 plan: Optional[pulumi.Input['ResourceReferenceArgs']] = None):
        """
        :param pulumi.Input[str] name: Gets or sets the name.
        :param pulumi.Input['ResourceReferenceArgs'] plan: Gets or sets the reference to plan.
        """
        if name is not None:
            pulumi.set(__self__, "name", name)
        if plan is not None:
            pulumi.set(__self__, "plan", plan)

    @property
    @pulumi.getter
    def name(self) -> Optional[pulumi.Input[str]]:
        """
        Gets or sets the name.
        """
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "name", value)

    @property
    @pulumi.getter
    def plan(self) -> Optional[pulumi.Input['ResourceReferenceArgs']]:
        """
        Gets or sets the reference to plan.
        """
        return pulumi.get(self, "plan")

    @plan.setter
    def plan(self, value: Optional[pulumi.Input['ResourceReferenceArgs']]):
        pulumi.set(self, "plan", value)


@pulumi.input_type
class WorkflowParameterArgs:
    def __init__(__self__, *,
                 metadata: Optional[Any] = None,
                 type: Optional[pulumi.Input[str]] = None,
                 value: Optional[Any] = None):
        """
        :param Any metadata: Gets or sets the metadata.
        :param pulumi.Input[str] type: Gets or sets the type.
        :param Any value: Gets or sets the value.
        """
        if metadata is not None:
            pulumi.set(__self__, "metadata", metadata)
        if type is not None:
            pulumi.set(__self__, "type", type)
        if value is not None:
            pulumi.set(__self__, "value", value)

    @property
    @pulumi.getter
    def metadata(self) -> Optional[Any]:
        """
        Gets or sets the metadata.
        """
        return pulumi.get(self, "metadata")

    @metadata.setter
    def metadata(self, value: Optional[Any]):
        pulumi.set(self, "metadata", value)

    @property
    @pulumi.getter
    def type(self) -> Optional[pulumi.Input[str]]:
        """
        Gets or sets the type.
        """
        return pulumi.get(self, "type")

    @type.setter
    def type(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "type", value)

    @property
    @pulumi.getter
    def value(self) -> Optional[Any]:
        """
        Gets or sets the value.
        """
        return pulumi.get(self, "value")

    @value.setter
    def value(self, value: Optional[Any]):
        pulumi.set(self, "value", value)


