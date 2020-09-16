# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Dict, List, Mapping, Optional, Tuple, Union
from ... import _utilities, _tables

__all__ = [
    'ContentHashArgs',
    'ContentLinkArgs',
    'RunbookDraftArgs',
    'RunbookParameterArgs',
]

@pulumi.input_type
class ContentHashArgs:
    def __init__(__self__, *,
                 algorithm: pulumi.Input[str],
                 value: pulumi.Input[str]):
        """
        Definition of the runbook property type.
        :param pulumi.Input[str] algorithm: Gets or sets the content hash algorithm used to hash the content.
        :param pulumi.Input[str] value: Gets or sets expected hash value of the content.
        """
        pulumi.set(__self__, "algorithm", algorithm)
        pulumi.set(__self__, "value", value)

    @property
    @pulumi.getter
    def algorithm(self) -> pulumi.Input[str]:
        """
        Gets or sets the content hash algorithm used to hash the content.
        """
        return pulumi.get(self, "algorithm")

    @algorithm.setter
    def algorithm(self, value: pulumi.Input[str]):
        pulumi.set(self, "algorithm", value)

    @property
    @pulumi.getter
    def value(self) -> pulumi.Input[str]:
        """
        Gets or sets expected hash value of the content.
        """
        return pulumi.get(self, "value")

    @value.setter
    def value(self, value: pulumi.Input[str]):
        pulumi.set(self, "value", value)


@pulumi.input_type
class ContentLinkArgs:
    def __init__(__self__, *,
                 content_hash: Optional[pulumi.Input['ContentHashArgs']] = None,
                 uri: Optional[pulumi.Input[str]] = None,
                 version: Optional[pulumi.Input[str]] = None):
        """
        Definition of the content link.
        :param pulumi.Input['ContentHashArgs'] content_hash: Gets or sets the hash.
        :param pulumi.Input[str] uri: Gets or sets the uri of the runbook content.
        :param pulumi.Input[str] version: Gets or sets the version of the content.
        """
        if content_hash is not None:
            pulumi.set(__self__, "content_hash", content_hash)
        if uri is not None:
            pulumi.set(__self__, "uri", uri)
        if version is not None:
            pulumi.set(__self__, "version", version)

    @property
    @pulumi.getter(name="contentHash")
    def content_hash(self) -> Optional[pulumi.Input['ContentHashArgs']]:
        """
        Gets or sets the hash.
        """
        return pulumi.get(self, "content_hash")

    @content_hash.setter
    def content_hash(self, value: Optional[pulumi.Input['ContentHashArgs']]):
        pulumi.set(self, "content_hash", value)

    @property
    @pulumi.getter
    def uri(self) -> Optional[pulumi.Input[str]]:
        """
        Gets or sets the uri of the runbook content.
        """
        return pulumi.get(self, "uri")

    @uri.setter
    def uri(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "uri", value)

    @property
    @pulumi.getter
    def version(self) -> Optional[pulumi.Input[str]]:
        """
        Gets or sets the version of the content.
        """
        return pulumi.get(self, "version")

    @version.setter
    def version(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "version", value)


@pulumi.input_type
class RunbookDraftArgs:
    def __init__(__self__, *,
                 creation_time: Optional[pulumi.Input[str]] = None,
                 draft_content_link: Optional[pulumi.Input['ContentLinkArgs']] = None,
                 in_edit: Optional[pulumi.Input[bool]] = None,
                 last_modified_time: Optional[pulumi.Input[str]] = None,
                 output_types: Optional[pulumi.Input[List[pulumi.Input[str]]]] = None,
                 parameters: Optional[pulumi.Input[Mapping[str, pulumi.Input['RunbookParameterArgs']]]] = None):
        """
        :param pulumi.Input[str] creation_time: Gets or sets the creation time of the runbook draft.
        :param pulumi.Input['ContentLinkArgs'] draft_content_link: Gets or sets the draft runbook content link.
        :param pulumi.Input[bool] in_edit: Gets or sets whether runbook is in edit mode.
        :param pulumi.Input[str] last_modified_time: Gets or sets the last modified time of the runbook draft.
        :param pulumi.Input[List[pulumi.Input[str]]] output_types: Gets or sets the runbook output types.
        :param pulumi.Input[Mapping[str, pulumi.Input['RunbookParameterArgs']]] parameters: Gets or sets the runbook draft parameters.
        """
        if creation_time is not None:
            pulumi.set(__self__, "creation_time", creation_time)
        if draft_content_link is not None:
            pulumi.set(__self__, "draft_content_link", draft_content_link)
        if in_edit is not None:
            pulumi.set(__self__, "in_edit", in_edit)
        if last_modified_time is not None:
            pulumi.set(__self__, "last_modified_time", last_modified_time)
        if output_types is not None:
            pulumi.set(__self__, "output_types", output_types)
        if parameters is not None:
            pulumi.set(__self__, "parameters", parameters)

    @property
    @pulumi.getter(name="creationTime")
    def creation_time(self) -> Optional[pulumi.Input[str]]:
        """
        Gets or sets the creation time of the runbook draft.
        """
        return pulumi.get(self, "creation_time")

    @creation_time.setter
    def creation_time(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "creation_time", value)

    @property
    @pulumi.getter(name="draftContentLink")
    def draft_content_link(self) -> Optional[pulumi.Input['ContentLinkArgs']]:
        """
        Gets or sets the draft runbook content link.
        """
        return pulumi.get(self, "draft_content_link")

    @draft_content_link.setter
    def draft_content_link(self, value: Optional[pulumi.Input['ContentLinkArgs']]):
        pulumi.set(self, "draft_content_link", value)

    @property
    @pulumi.getter(name="inEdit")
    def in_edit(self) -> Optional[pulumi.Input[bool]]:
        """
        Gets or sets whether runbook is in edit mode.
        """
        return pulumi.get(self, "in_edit")

    @in_edit.setter
    def in_edit(self, value: Optional[pulumi.Input[bool]]):
        pulumi.set(self, "in_edit", value)

    @property
    @pulumi.getter(name="lastModifiedTime")
    def last_modified_time(self) -> Optional[pulumi.Input[str]]:
        """
        Gets or sets the last modified time of the runbook draft.
        """
        return pulumi.get(self, "last_modified_time")

    @last_modified_time.setter
    def last_modified_time(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "last_modified_time", value)

    @property
    @pulumi.getter(name="outputTypes")
    def output_types(self) -> Optional[pulumi.Input[List[pulumi.Input[str]]]]:
        """
        Gets or sets the runbook output types.
        """
        return pulumi.get(self, "output_types")

    @output_types.setter
    def output_types(self, value: Optional[pulumi.Input[List[pulumi.Input[str]]]]):
        pulumi.set(self, "output_types", value)

    @property
    @pulumi.getter
    def parameters(self) -> Optional[pulumi.Input[Mapping[str, pulumi.Input['RunbookParameterArgs']]]]:
        """
        Gets or sets the runbook draft parameters.
        """
        return pulumi.get(self, "parameters")

    @parameters.setter
    def parameters(self, value: Optional[pulumi.Input[Mapping[str, pulumi.Input['RunbookParameterArgs']]]]):
        pulumi.set(self, "parameters", value)


@pulumi.input_type
class RunbookParameterArgs:
    def __init__(__self__, *,
                 default_value: Optional[pulumi.Input[str]] = None,
                 is_mandatory: Optional[pulumi.Input[bool]] = None,
                 position: Optional[pulumi.Input[float]] = None,
                 type: Optional[pulumi.Input[str]] = None):
        """
        Definition of the runbook parameter type.
        :param pulumi.Input[str] default_value: Gets or sets the default value of parameter.
        :param pulumi.Input[bool] is_mandatory: Gets or sets a Boolean value to indicate whether the parameter is mandatory or not.
        :param pulumi.Input[float] position: Get or sets the position of the parameter.
        :param pulumi.Input[str] type: Gets or sets the type of the parameter.
        """
        if default_value is not None:
            pulumi.set(__self__, "default_value", default_value)
        if is_mandatory is not None:
            pulumi.set(__self__, "is_mandatory", is_mandatory)
        if position is not None:
            pulumi.set(__self__, "position", position)
        if type is not None:
            pulumi.set(__self__, "type", type)

    @property
    @pulumi.getter(name="defaultValue")
    def default_value(self) -> Optional[pulumi.Input[str]]:
        """
        Gets or sets the default value of parameter.
        """
        return pulumi.get(self, "default_value")

    @default_value.setter
    def default_value(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "default_value", value)

    @property
    @pulumi.getter(name="isMandatory")
    def is_mandatory(self) -> Optional[pulumi.Input[bool]]:
        """
        Gets or sets a Boolean value to indicate whether the parameter is mandatory or not.
        """
        return pulumi.get(self, "is_mandatory")

    @is_mandatory.setter
    def is_mandatory(self, value: Optional[pulumi.Input[bool]]):
        pulumi.set(self, "is_mandatory", value)

    @property
    @pulumi.getter
    def position(self) -> Optional[pulumi.Input[float]]:
        """
        Get or sets the position of the parameter.
        """
        return pulumi.get(self, "position")

    @position.setter
    def position(self, value: Optional[pulumi.Input[float]]):
        pulumi.set(self, "position", value)

    @property
    @pulumi.getter
    def type(self) -> Optional[pulumi.Input[str]]:
        """
        Gets or sets the type of the parameter.
        """
        return pulumi.get(self, "type")

    @type.setter
    def type(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "type", value)

