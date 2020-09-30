# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union
from ... import _utilities, _tables

__all__ = [
    'DashboardLensArgs',
    'DashboardPartsArgs',
    'DashboardPartsPositionArgs',
    'MarkdownPartMetadataArgs',
    'MarkdownPartMetadataContentArgs',
    'MarkdownPartMetadataSettingsArgs',
]

@pulumi.input_type
class DashboardLensArgs:
    def __init__(__self__, *,
                 order: pulumi.Input[int],
                 parts: pulumi.Input[Sequence[pulumi.Input['DashboardPartsArgs']]],
                 metadata: Optional[pulumi.Input[Mapping[str, Any]]] = None):
        """
        A dashboard lens.
        :param pulumi.Input[int] order: The lens order.
        :param pulumi.Input[Sequence[pulumi.Input['DashboardPartsArgs']]] parts: The dashboard parts.
        :param pulumi.Input[Mapping[str, Any]] metadata: The dashboard len's metadata.
        """
        pulumi.set(__self__, "order", order)
        pulumi.set(__self__, "parts", parts)
        if metadata is not None:
            pulumi.set(__self__, "metadata", metadata)

    @property
    @pulumi.getter
    def order(self) -> pulumi.Input[int]:
        """
        The lens order.
        """
        return pulumi.get(self, "order")

    @order.setter
    def order(self, value: pulumi.Input[int]):
        pulumi.set(self, "order", value)

    @property
    @pulumi.getter
    def parts(self) -> pulumi.Input[Sequence[pulumi.Input['DashboardPartsArgs']]]:
        """
        The dashboard parts.
        """
        return pulumi.get(self, "parts")

    @parts.setter
    def parts(self, value: pulumi.Input[Sequence[pulumi.Input['DashboardPartsArgs']]]):
        pulumi.set(self, "parts", value)

    @property
    @pulumi.getter
    def metadata(self) -> Optional[pulumi.Input[Mapping[str, Any]]]:
        """
        The dashboard len's metadata.
        """
        return pulumi.get(self, "metadata")

    @metadata.setter
    def metadata(self, value: Optional[pulumi.Input[Mapping[str, Any]]]):
        pulumi.set(self, "metadata", value)


@pulumi.input_type
class DashboardPartsArgs:
    def __init__(__self__, *,
                 position: pulumi.Input['DashboardPartsPositionArgs'],
                 metadata: Optional[pulumi.Input['MarkdownPartMetadataArgs']] = None):
        """
        A dashboard part.
        :param pulumi.Input['DashboardPartsPositionArgs'] position: The dashboard's part position.
        :param pulumi.Input['MarkdownPartMetadataArgs'] metadata: The dashboard part's metadata.
        """
        pulumi.set(__self__, "position", position)
        if metadata is not None:
            pulumi.set(__self__, "metadata", metadata)

    @property
    @pulumi.getter
    def position(self) -> pulumi.Input['DashboardPartsPositionArgs']:
        """
        The dashboard's part position.
        """
        return pulumi.get(self, "position")

    @position.setter
    def position(self, value: pulumi.Input['DashboardPartsPositionArgs']):
        pulumi.set(self, "position", value)

    @property
    @pulumi.getter
    def metadata(self) -> Optional[pulumi.Input['MarkdownPartMetadataArgs']]:
        """
        The dashboard part's metadata.
        """
        return pulumi.get(self, "metadata")

    @metadata.setter
    def metadata(self, value: Optional[pulumi.Input['MarkdownPartMetadataArgs']]):
        pulumi.set(self, "metadata", value)


@pulumi.input_type
class DashboardPartsPositionArgs:
    def __init__(__self__, *,
                 col_span: pulumi.Input[int],
                 row_span: pulumi.Input[int],
                 x: pulumi.Input[int],
                 y: pulumi.Input[int],
                 metadata: Optional[pulumi.Input[Mapping[str, Any]]] = None):
        """
        The dashboard's part position.
        :param pulumi.Input[int] col_span: The dashboard's part column span.
        :param pulumi.Input[int] row_span: The dashboard's part row span.
        :param pulumi.Input[int] x: The dashboard's part x coordinate.
        :param pulumi.Input[int] y: The dashboard's part y coordinate.
        :param pulumi.Input[Mapping[str, Any]] metadata: The dashboard part's metadata.
        """
        pulumi.set(__self__, "col_span", col_span)
        pulumi.set(__self__, "row_span", row_span)
        pulumi.set(__self__, "x", x)
        pulumi.set(__self__, "y", y)
        if metadata is not None:
            pulumi.set(__self__, "metadata", metadata)

    @property
    @pulumi.getter(name="colSpan")
    def col_span(self) -> pulumi.Input[int]:
        """
        The dashboard's part column span.
        """
        return pulumi.get(self, "col_span")

    @col_span.setter
    def col_span(self, value: pulumi.Input[int]):
        pulumi.set(self, "col_span", value)

    @property
    @pulumi.getter(name="rowSpan")
    def row_span(self) -> pulumi.Input[int]:
        """
        The dashboard's part row span.
        """
        return pulumi.get(self, "row_span")

    @row_span.setter
    def row_span(self, value: pulumi.Input[int]):
        pulumi.set(self, "row_span", value)

    @property
    @pulumi.getter
    def x(self) -> pulumi.Input[int]:
        """
        The dashboard's part x coordinate.
        """
        return pulumi.get(self, "x")

    @x.setter
    def x(self, value: pulumi.Input[int]):
        pulumi.set(self, "x", value)

    @property
    @pulumi.getter
    def y(self) -> pulumi.Input[int]:
        """
        The dashboard's part y coordinate.
        """
        return pulumi.get(self, "y")

    @y.setter
    def y(self, value: pulumi.Input[int]):
        pulumi.set(self, "y", value)

    @property
    @pulumi.getter
    def metadata(self) -> Optional[pulumi.Input[Mapping[str, Any]]]:
        """
        The dashboard part's metadata.
        """
        return pulumi.get(self, "metadata")

    @metadata.setter
    def metadata(self, value: Optional[pulumi.Input[Mapping[str, Any]]]):
        pulumi.set(self, "metadata", value)


@pulumi.input_type
class MarkdownPartMetadataArgs:
    def __init__(__self__, *,
                 type: pulumi.Input[str],
                 inputs: Optional[pulumi.Input[Sequence[Any]]] = None,
                 settings: Optional[pulumi.Input['MarkdownPartMetadataSettingsArgs']] = None):
        """
        Markdown part metadata.
        :param pulumi.Input[str] type: The type of dashboard part.
        :param pulumi.Input[Sequence[Any]] inputs: Input to dashboard part.
        :param pulumi.Input['MarkdownPartMetadataSettingsArgs'] settings: Markdown part settings.
        """
        pulumi.set(__self__, "type", 'Extension/HubsExtension/PartType/MarkdownPart')
        if inputs is not None:
            pulumi.set(__self__, "inputs", inputs)
        if settings is not None:
            pulumi.set(__self__, "settings", settings)

    @property
    @pulumi.getter
    def type(self) -> pulumi.Input[str]:
        """
        The type of dashboard part.
        """
        return pulumi.get(self, "type")

    @type.setter
    def type(self, value: pulumi.Input[str]):
        pulumi.set(self, "type", value)

    @property
    @pulumi.getter
    def inputs(self) -> Optional[pulumi.Input[Sequence[Any]]]:
        """
        Input to dashboard part.
        """
        return pulumi.get(self, "inputs")

    @inputs.setter
    def inputs(self, value: Optional[pulumi.Input[Sequence[Any]]]):
        pulumi.set(self, "inputs", value)

    @property
    @pulumi.getter
    def settings(self) -> Optional[pulumi.Input['MarkdownPartMetadataSettingsArgs']]:
        """
        Markdown part settings.
        """
        return pulumi.get(self, "settings")

    @settings.setter
    def settings(self, value: Optional[pulumi.Input['MarkdownPartMetadataSettingsArgs']]):
        pulumi.set(self, "settings", value)


@pulumi.input_type
class MarkdownPartMetadataContentArgs:
    def __init__(__self__, *,
                 settings: Optional[pulumi.Input['MarkdownPartMetadataSettingsArgs']] = None):
        """
        The content of markdown part.
        :param pulumi.Input['MarkdownPartMetadataSettingsArgs'] settings: The setting of the content of markdown part.
        """
        if settings is not None:
            pulumi.set(__self__, "settings", settings)

    @property
    @pulumi.getter
    def settings(self) -> Optional[pulumi.Input['MarkdownPartMetadataSettingsArgs']]:
        """
        The setting of the content of markdown part.
        """
        return pulumi.get(self, "settings")

    @settings.setter
    def settings(self, value: Optional[pulumi.Input['MarkdownPartMetadataSettingsArgs']]):
        pulumi.set(self, "settings", value)


@pulumi.input_type
class MarkdownPartMetadataSettingsArgs:
    def __init__(__self__, *,
                 content: Optional[pulumi.Input['MarkdownPartMetadataContentArgs']] = None):
        """
        Markdown part settings.
        :param pulumi.Input['MarkdownPartMetadataContentArgs'] content: The content of markdown part.
        """
        if content is not None:
            pulumi.set(__self__, "content", content)

    @property
    @pulumi.getter
    def content(self) -> Optional[pulumi.Input['MarkdownPartMetadataContentArgs']]:
        """
        The content of markdown part.
        """
        return pulumi.get(self, "content")

    @content.setter
    def content(self, value: Optional[pulumi.Input['MarkdownPartMetadataContentArgs']]):
        pulumi.set(self, "content", value)


