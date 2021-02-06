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
from ._inputs import *

__all__ = ['DeploymentScript']


class DeploymentScript(pulumi.CustomResource):
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 identity: Optional[pulumi.Input[pulumi.InputType['ManagedServiceIdentityArgs']]] = None,
                 kind: Optional[pulumi.Input[Union[str, 'ScriptType']]] = None,
                 location: Optional[pulumi.Input[str]] = None,
                 resource_group_name: Optional[pulumi.Input[str]] = None,
                 script_name: Optional[pulumi.Input[str]] = None,
                 tags: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
                 __props__=None,
                 __name__=None,
                 __opts__=None):
        """
        Deployment script object.

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[pulumi.InputType['ManagedServiceIdentityArgs']] identity: Optional property. Managed identity to be used for this deployment script. Currently, only user-assigned MSI is supported.
        :param pulumi.Input[Union[str, 'ScriptType']] kind: Type of the script.
        :param pulumi.Input[str] location: The location of the ACI and the storage account for the deployment script.
        :param pulumi.Input[str] resource_group_name: The name of the resource group. The name is case insensitive.
        :param pulumi.Input[str] script_name: Name of the deployment script.
        :param pulumi.Input[Mapping[str, pulumi.Input[str]]] tags: Resource tags.
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

            __props__['identity'] = identity
            if kind is None and not opts.urn:
                raise TypeError("Missing required property 'kind'")
            __props__['kind'] = kind
            __props__['location'] = location
            if resource_group_name is None and not opts.urn:
                raise TypeError("Missing required property 'resource_group_name'")
            __props__['resource_group_name'] = resource_group_name
            if script_name is None and not opts.urn:
                raise TypeError("Missing required property 'script_name'")
            __props__['script_name'] = script_name
            __props__['tags'] = tags
            __props__['name'] = None
            __props__['system_data'] = None
            __props__['type'] = None
        alias_opts = pulumi.ResourceOptions(aliases=[pulumi.Alias(type_="azure-nextgen:resources/latest:DeploymentScript"), pulumi.Alias(type_="azure-nextgen:resources/v20191001preview:DeploymentScript")])
        opts = pulumi.ResourceOptions.merge(opts, alias_opts)
        super(DeploymentScript, __self__).__init__(
            'azure-nextgen:resources/v20201001:DeploymentScript',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None) -> 'DeploymentScript':
        """
        Get an existing DeploymentScript resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = dict()

        return DeploymentScript(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter
    def identity(self) -> pulumi.Output[Optional['outputs.ManagedServiceIdentityResponse']]:
        """
        Optional property. Managed identity to be used for this deployment script. Currently, only user-assigned MSI is supported.
        """
        return pulumi.get(self, "identity")

    @property
    @pulumi.getter
    def kind(self) -> pulumi.Output[str]:
        """
        Type of the script.
        """
        return pulumi.get(self, "kind")

    @property
    @pulumi.getter
    def location(self) -> pulumi.Output[str]:
        """
        The location of the ACI and the storage account for the deployment script.
        """
        return pulumi.get(self, "location")

    @property
    @pulumi.getter
    def name(self) -> pulumi.Output[str]:
        """
        Name of this resource.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="systemData")
    def system_data(self) -> pulumi.Output['outputs.SystemDataResponse']:
        """
        The system metadata related to this resource.
        """
        return pulumi.get(self, "system_data")

    @property
    @pulumi.getter
    def tags(self) -> pulumi.Output[Optional[Mapping[str, str]]]:
        """
        Resource tags.
        """
        return pulumi.get(self, "tags")

    @property
    @pulumi.getter
    def type(self) -> pulumi.Output[str]:
        """
        Type of this resource.
        """
        return pulumi.get(self, "type")

    def translate_output_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return _tables.SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop

