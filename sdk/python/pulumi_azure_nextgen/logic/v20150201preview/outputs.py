# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union
from ... import _utilities, _tables
from . import outputs
from ._enums import *

__all__ = [
    'ContentHashResponse',
    'ContentLinkResponse',
    'ResourceReferenceResponse',
    'SkuResponse',
    'WorkflowParameterResponse',
]

@pulumi.output_type
class ContentHashResponse(dict):
    def __init__(__self__, *,
                 algorithm: Optional[str] = None,
                 value: Optional[str] = None):
        """
        :param str algorithm: Gets or sets the algorithm.
        :param str value: Gets or sets the value.
        """
        if algorithm is not None:
            pulumi.set(__self__, "algorithm", algorithm)
        if value is not None:
            pulumi.set(__self__, "value", value)

    @property
    @pulumi.getter
    def algorithm(self) -> Optional[str]:
        """
        Gets or sets the algorithm.
        """
        return pulumi.get(self, "algorithm")

    @property
    @pulumi.getter
    def value(self) -> Optional[str]:
        """
        Gets or sets the value.
        """
        return pulumi.get(self, "value")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class ContentLinkResponse(dict):
    def __init__(__self__, *,
                 content_hash: Optional['outputs.ContentHashResponse'] = None,
                 content_size: Optional[float] = None,
                 content_version: Optional[str] = None,
                 metadata: Optional[Any] = None,
                 uri: Optional[str] = None):
        """
        :param 'ContentHashResponseArgs' content_hash: Gets or sets the content hash.
        :param float content_size: Gets or sets the content size.
        :param str content_version: Gets or sets the content version.
        :param Any metadata: Gets or sets the metadata.
        :param str uri: Gets or sets the content link URI.
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
    def content_hash(self) -> Optional['outputs.ContentHashResponse']:
        """
        Gets or sets the content hash.
        """
        return pulumi.get(self, "content_hash")

    @property
    @pulumi.getter(name="contentSize")
    def content_size(self) -> Optional[float]:
        """
        Gets or sets the content size.
        """
        return pulumi.get(self, "content_size")

    @property
    @pulumi.getter(name="contentVersion")
    def content_version(self) -> Optional[str]:
        """
        Gets or sets the content version.
        """
        return pulumi.get(self, "content_version")

    @property
    @pulumi.getter
    def metadata(self) -> Optional[Any]:
        """
        Gets or sets the metadata.
        """
        return pulumi.get(self, "metadata")

    @property
    @pulumi.getter
    def uri(self) -> Optional[str]:
        """
        Gets or sets the content link URI.
        """
        return pulumi.get(self, "uri")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class ResourceReferenceResponse(dict):
    def __init__(__self__, *,
                 name: str,
                 type: str,
                 id: Optional[str] = None):
        """
        :param str name: Gets the resource name.
        :param str type: Gets the resource type.
        :param str id: Gets or sets the resource id.
        """
        pulumi.set(__self__, "name", name)
        pulumi.set(__self__, "type", type)
        if id is not None:
            pulumi.set(__self__, "id", id)

    @property
    @pulumi.getter
    def name(self) -> str:
        """
        Gets the resource name.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter
    def type(self) -> str:
        """
        Gets the resource type.
        """
        return pulumi.get(self, "type")

    @property
    @pulumi.getter
    def id(self) -> Optional[str]:
        """
        Gets or sets the resource id.
        """
        return pulumi.get(self, "id")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class SkuResponse(dict):
    def __init__(__self__, *,
                 name: Optional[str] = None,
                 plan: Optional['outputs.ResourceReferenceResponse'] = None):
        """
        :param str name: Gets or sets the name.
        :param 'ResourceReferenceResponseArgs' plan: Gets or sets the reference to plan.
        """
        if name is not None:
            pulumi.set(__self__, "name", name)
        if plan is not None:
            pulumi.set(__self__, "plan", plan)

    @property
    @pulumi.getter
    def name(self) -> Optional[str]:
        """
        Gets or sets the name.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter
    def plan(self) -> Optional['outputs.ResourceReferenceResponse']:
        """
        Gets or sets the reference to plan.
        """
        return pulumi.get(self, "plan")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


@pulumi.output_type
class WorkflowParameterResponse(dict):
    def __init__(__self__, *,
                 metadata: Optional[Any] = None,
                 type: Optional[str] = None,
                 value: Optional[Any] = None):
        """
        :param Any metadata: Gets or sets the metadata.
        :param str type: Gets or sets the type.
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

    @property
    @pulumi.getter
    def type(self) -> Optional[str]:
        """
        Gets or sets the type.
        """
        return pulumi.get(self, "type")

    @property
    @pulumi.getter
    def value(self) -> Optional[Any]:
        """
        Gets or sets the value.
        """
        return pulumi.get(self, "value")

    def _translate_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop


