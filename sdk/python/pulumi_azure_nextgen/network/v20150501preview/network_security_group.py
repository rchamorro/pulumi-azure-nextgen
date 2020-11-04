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

__all__ = ['NetworkSecurityGroup']


class NetworkSecurityGroup(pulumi.CustomResource):
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 default_security_rules: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['SecurityRuleArgs']]]]] = None,
                 etag: Optional[pulumi.Input[str]] = None,
                 location: Optional[pulumi.Input[str]] = None,
                 network_interfaces: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['SubResourceArgs']]]]] = None,
                 network_security_group_name: Optional[pulumi.Input[str]] = None,
                 provisioning_state: Optional[pulumi.Input[str]] = None,
                 resource_group_name: Optional[pulumi.Input[str]] = None,
                 resource_guid: Optional[pulumi.Input[str]] = None,
                 security_rules: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['SecurityRuleArgs']]]]] = None,
                 subnets: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['SubResourceArgs']]]]] = None,
                 tags: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
                 __props__=None,
                 __name__=None,
                 __opts__=None):
        """
        NetworkSecurityGroup resource

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['SecurityRuleArgs']]]] default_security_rules: Gets or sets Default security rules of network security group
        :param pulumi.Input[str] etag: Gets a unique read-only string that changes whenever the resource is updated
        :param pulumi.Input[str] location: Resource location
        :param pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['SubResourceArgs']]]] network_interfaces: Gets collection of references to Network Interfaces
        :param pulumi.Input[str] network_security_group_name: The name of the network security group.
        :param pulumi.Input[str] provisioning_state: Gets or sets Provisioning state of the PublicIP resource Updating/Deleting/Failed
        :param pulumi.Input[str] resource_group_name: The name of the resource group.
        :param pulumi.Input[str] resource_guid: Gets or sets resource guid property of the network security group resource
        :param pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['SecurityRuleArgs']]]] security_rules: Gets or sets Security rules of network security group
        :param pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['SubResourceArgs']]]] subnets: Gets collection of references to subnets
        :param pulumi.Input[Mapping[str, pulumi.Input[str]]] tags: Resource tags
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

            __props__['default_security_rules'] = default_security_rules
            __props__['etag'] = etag
            if location is None:
                raise TypeError("Missing required property 'location'")
            __props__['location'] = location
            __props__['network_interfaces'] = network_interfaces
            if network_security_group_name is None:
                raise TypeError("Missing required property 'network_security_group_name'")
            __props__['network_security_group_name'] = network_security_group_name
            __props__['provisioning_state'] = provisioning_state
            if resource_group_name is None:
                raise TypeError("Missing required property 'resource_group_name'")
            __props__['resource_group_name'] = resource_group_name
            __props__['resource_guid'] = resource_guid
            __props__['security_rules'] = security_rules
            __props__['subnets'] = subnets
            __props__['tags'] = tags
            __props__['name'] = None
            __props__['type'] = None
        alias_opts = pulumi.ResourceOptions(aliases=[pulumi.Alias(type_="azure-nextgen:network/latest:NetworkSecurityGroup"), pulumi.Alias(type_="azure-nextgen:network/v20150615:NetworkSecurityGroup"), pulumi.Alias(type_="azure-nextgen:network/v20160330:NetworkSecurityGroup"), pulumi.Alias(type_="azure-nextgen:network/v20160601:NetworkSecurityGroup"), pulumi.Alias(type_="azure-nextgen:network/v20160901:NetworkSecurityGroup"), pulumi.Alias(type_="azure-nextgen:network/v20161201:NetworkSecurityGroup"), pulumi.Alias(type_="azure-nextgen:network/v20170301:NetworkSecurityGroup"), pulumi.Alias(type_="azure-nextgen:network/v20170601:NetworkSecurityGroup"), pulumi.Alias(type_="azure-nextgen:network/v20170801:NetworkSecurityGroup"), pulumi.Alias(type_="azure-nextgen:network/v20170901:NetworkSecurityGroup"), pulumi.Alias(type_="azure-nextgen:network/v20171001:NetworkSecurityGroup"), pulumi.Alias(type_="azure-nextgen:network/v20171101:NetworkSecurityGroup"), pulumi.Alias(type_="azure-nextgen:network/v20180101:NetworkSecurityGroup"), pulumi.Alias(type_="azure-nextgen:network/v20180201:NetworkSecurityGroup"), pulumi.Alias(type_="azure-nextgen:network/v20180401:NetworkSecurityGroup"), pulumi.Alias(type_="azure-nextgen:network/v20180601:NetworkSecurityGroup"), pulumi.Alias(type_="azure-nextgen:network/v20180701:NetworkSecurityGroup"), pulumi.Alias(type_="azure-nextgen:network/v20180801:NetworkSecurityGroup"), pulumi.Alias(type_="azure-nextgen:network/v20181001:NetworkSecurityGroup"), pulumi.Alias(type_="azure-nextgen:network/v20181101:NetworkSecurityGroup"), pulumi.Alias(type_="azure-nextgen:network/v20181201:NetworkSecurityGroup"), pulumi.Alias(type_="azure-nextgen:network/v20190201:NetworkSecurityGroup"), pulumi.Alias(type_="azure-nextgen:network/v20190401:NetworkSecurityGroup"), pulumi.Alias(type_="azure-nextgen:network/v20190601:NetworkSecurityGroup"), pulumi.Alias(type_="azure-nextgen:network/v20190701:NetworkSecurityGroup"), pulumi.Alias(type_="azure-nextgen:network/v20190801:NetworkSecurityGroup"), pulumi.Alias(type_="azure-nextgen:network/v20190901:NetworkSecurityGroup"), pulumi.Alias(type_="azure-nextgen:network/v20191101:NetworkSecurityGroup"), pulumi.Alias(type_="azure-nextgen:network/v20191201:NetworkSecurityGroup"), pulumi.Alias(type_="azure-nextgen:network/v20200301:NetworkSecurityGroup"), pulumi.Alias(type_="azure-nextgen:network/v20200401:NetworkSecurityGroup"), pulumi.Alias(type_="azure-nextgen:network/v20200501:NetworkSecurityGroup"), pulumi.Alias(type_="azure-nextgen:network/v20200601:NetworkSecurityGroup"), pulumi.Alias(type_="azure-nextgen:network/v20200701:NetworkSecurityGroup")])
        opts = pulumi.ResourceOptions.merge(opts, alias_opts)
        super(NetworkSecurityGroup, __self__).__init__(
            'azure-nextgen:network/v20150501preview:NetworkSecurityGroup',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None) -> 'NetworkSecurityGroup':
        """
        Get an existing NetworkSecurityGroup resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = dict()

        return NetworkSecurityGroup(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="defaultSecurityRules")
    def default_security_rules(self) -> pulumi.Output[Optional[Sequence['outputs.SecurityRuleResponse']]]:
        """
        Gets or sets Default security rules of network security group
        """
        return pulumi.get(self, "default_security_rules")

    @property
    @pulumi.getter
    def etag(self) -> pulumi.Output[Optional[str]]:
        """
        Gets a unique read-only string that changes whenever the resource is updated
        """
        return pulumi.get(self, "etag")

    @property
    @pulumi.getter
    def location(self) -> pulumi.Output[str]:
        """
        Resource location
        """
        return pulumi.get(self, "location")

    @property
    @pulumi.getter
    def name(self) -> pulumi.Output[str]:
        """
        Resource name
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="networkInterfaces")
    def network_interfaces(self) -> pulumi.Output[Optional[Sequence['outputs.SubResourceResponse']]]:
        """
        Gets collection of references to Network Interfaces
        """
        return pulumi.get(self, "network_interfaces")

    @property
    @pulumi.getter(name="provisioningState")
    def provisioning_state(self) -> pulumi.Output[Optional[str]]:
        """
        Gets or sets Provisioning state of the PublicIP resource Updating/Deleting/Failed
        """
        return pulumi.get(self, "provisioning_state")

    @property
    @pulumi.getter(name="resourceGuid")
    def resource_guid(self) -> pulumi.Output[Optional[str]]:
        """
        Gets or sets resource guid property of the network security group resource
        """
        return pulumi.get(self, "resource_guid")

    @property
    @pulumi.getter(name="securityRules")
    def security_rules(self) -> pulumi.Output[Optional[Sequence['outputs.SecurityRuleResponse']]]:
        """
        Gets or sets Security rules of network security group
        """
        return pulumi.get(self, "security_rules")

    @property
    @pulumi.getter
    def subnets(self) -> pulumi.Output[Optional[Sequence['outputs.SubResourceResponse']]]:
        """
        Gets collection of references to subnets
        """
        return pulumi.get(self, "subnets")

    @property
    @pulumi.getter
    def tags(self) -> pulumi.Output[Optional[Mapping[str, str]]]:
        """
        Resource tags
        """
        return pulumi.get(self, "tags")

    @property
    @pulumi.getter
    def type(self) -> pulumi.Output[str]:
        """
        Resource type
        """
        return pulumi.get(self, "type")

    def translate_output_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return _tables.SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop

