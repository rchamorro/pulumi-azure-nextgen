# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union
from ... import _utilities, _tables
from . import outputs
from ._inputs import *

__all__ = ['Blueprint']


class Blueprint(pulumi.CustomResource):
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 blueprint_name: Optional[pulumi.Input[str]] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 display_name: Optional[pulumi.Input[str]] = None,
                 layout: Optional[Any] = None,
                 management_group_name: Optional[pulumi.Input[str]] = None,
                 parameters: Optional[pulumi.Input[Mapping[str, pulumi.Input[pulumi.InputType['ParameterDefinitionArgs']]]]] = None,
                 resource_groups: Optional[pulumi.Input[Mapping[str, pulumi.Input[pulumi.InputType['ResourceGroupDefinitionArgs']]]]] = None,
                 target_scope: Optional[pulumi.Input[str]] = None,
                 versions: Optional[Any] = None,
                 __props__=None,
                 __name__=None,
                 __opts__=None):
        """
        Represents a Blueprint definition.

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] blueprint_name: name of the blueprint.
        :param pulumi.Input[str] description: Multi-line explain this resource.
        :param pulumi.Input[str] display_name: One-liner string explain this resource.
        :param Any layout: Layout view of the blueprint, for UI reference.
        :param pulumi.Input[str] management_group_name: ManagementGroup where blueprint stores.
        :param pulumi.Input[Mapping[str, pulumi.Input[pulumi.InputType['ParameterDefinitionArgs']]]] parameters: Parameters required by this Blueprint definition.
        :param pulumi.Input[Mapping[str, pulumi.Input[pulumi.InputType['ResourceGroupDefinitionArgs']]]] resource_groups: Resource group placeholders defined by this Blueprint definition.
        :param pulumi.Input[str] target_scope: The scope where this Blueprint can be applied.
        :param Any versions: Published versions of this blueprint.
        """
        if __name__ is not None:
            warnings.warn("explicit use of __name__ is deprecated", DeprecationWarning)
            resource_name = __name__
        if __opts__ is not None:
            warnings.warn("explicit use of __opts__ is deprecated, use 'opts' instead", DeprecationWarning)
            opts = __opts__
        if opts is None:
            opts = pulumi.ResourceOptions()
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.version is None:
            opts.version = _utilities.get_version()
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = dict()

            if blueprint_name is None:
                raise TypeError("Missing required property 'blueprint_name'")
            __props__['blueprint_name'] = blueprint_name
            __props__['description'] = description
            __props__['display_name'] = display_name
            __props__['layout'] = layout
            if management_group_name is None:
                raise TypeError("Missing required property 'management_group_name'")
            __props__['management_group_name'] = management_group_name
            __props__['parameters'] = parameters
            __props__['resource_groups'] = resource_groups
            if target_scope is None:
                raise TypeError("Missing required property 'target_scope'")
            __props__['target_scope'] = target_scope
            __props__['versions'] = versions
            __props__['name'] = None
            __props__['status'] = None
            __props__['type'] = None
        super(Blueprint, __self__).__init__(
            'azure-nextgen:management/v20171111preview:Blueprint',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None) -> 'Blueprint':
        """
        Get an existing Blueprint resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = dict()

        return Blueprint(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter
    def description(self) -> pulumi.Output[Optional[str]]:
        """
        Multi-line explain this resource.
        """
        return pulumi.get(self, "description")

    @property
    @pulumi.getter(name="displayName")
    def display_name(self) -> pulumi.Output[Optional[str]]:
        """
        One-liner string explain this resource.
        """
        return pulumi.get(self, "display_name")

    @property
    @pulumi.getter
    def layout(self) -> pulumi.Output[Optional[Any]]:
        """
        Layout view of the blueprint, for UI reference.
        """
        return pulumi.get(self, "layout")

    @property
    @pulumi.getter
    def name(self) -> pulumi.Output[str]:
        """
        Name of this resource.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter
    def parameters(self) -> pulumi.Output[Optional[Mapping[str, 'outputs.ParameterDefinitionResponse']]]:
        """
        Parameters required by this Blueprint definition.
        """
        return pulumi.get(self, "parameters")

    @property
    @pulumi.getter(name="resourceGroups")
    def resource_groups(self) -> pulumi.Output[Optional[Mapping[str, 'outputs.ResourceGroupDefinitionResponse']]]:
        """
        Resource group placeholders defined by this Blueprint definition.
        """
        return pulumi.get(self, "resource_groups")

    @property
    @pulumi.getter
    def status(self) -> pulumi.Output['outputs.BlueprintStatusResponse']:
        """
        Status of the Blueprint. This field is readonly.
        """
        return pulumi.get(self, "status")

    @property
    @pulumi.getter(name="targetScope")
    def target_scope(self) -> pulumi.Output[str]:
        """
        The scope where this Blueprint can be applied.
        """
        return pulumi.get(self, "target_scope")

    @property
    @pulumi.getter
    def type(self) -> pulumi.Output[str]:
        """
        Type of this resource.
        """
        return pulumi.get(self, "type")

    @property
    @pulumi.getter
    def versions(self) -> pulumi.Output[Optional[Any]]:
        """
        Published versions of this blueprint.
        """
        return pulumi.get(self, "versions")

    def translate_output_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return _tables.SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop

