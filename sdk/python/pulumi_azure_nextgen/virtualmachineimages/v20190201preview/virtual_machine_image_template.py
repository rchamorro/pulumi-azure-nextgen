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

__all__ = ['VirtualMachineImageTemplate']


class VirtualMachineImageTemplate(pulumi.CustomResource):
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 customize: Optional[pulumi.Input[Sequence[pulumi.Input[Union[pulumi.InputType['ImageTemplatePowerShellCustomizerArgs'], pulumi.InputType['ImageTemplateRestartCustomizerArgs'], pulumi.InputType['ImageTemplateShellCustomizerArgs']]]]]] = None,
                 distribute: Optional[pulumi.Input[Sequence[pulumi.Input[Union[pulumi.InputType['ImageTemplateManagedImageDistributorArgs'], pulumi.InputType['ImageTemplateSharedImageDistributorArgs'], pulumi.InputType['ImageTemplateVhdDistributorArgs']]]]]] = None,
                 image_template_name: Optional[pulumi.Input[str]] = None,
                 location: Optional[pulumi.Input[str]] = None,
                 resource_group_name: Optional[pulumi.Input[str]] = None,
                 source: Optional[pulumi.Input[Union[pulumi.InputType['ImageTemplateIsoSourceArgs'], pulumi.InputType['ImageTemplateManagedImageSourceArgs'], pulumi.InputType['ImageTemplatePlatformImageSourceArgs']]]] = None,
                 tags: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
                 __props__=None,
                 __name__=None,
                 __opts__=None):
        """
        Create a VirtualMachineImageTemplate resource with the given unique name, props, and options.
        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[Sequence[pulumi.Input[Union[pulumi.InputType['ImageTemplatePowerShellCustomizerArgs'], pulumi.InputType['ImageTemplateRestartCustomizerArgs'], pulumi.InputType['ImageTemplateShellCustomizerArgs']]]]] customize: Specifies the properties used to describe the customization steps of the image, like Image source etc
        :param pulumi.Input[Sequence[pulumi.Input[Union[pulumi.InputType['ImageTemplateManagedImageDistributorArgs'], pulumi.InputType['ImageTemplateSharedImageDistributorArgs'], pulumi.InputType['ImageTemplateVhdDistributorArgs']]]]] distribute: The distribution targets where the image output needs to go to.
        :param pulumi.Input[str] image_template_name: The name of the image Template
        :param pulumi.Input[str] location: Resource location
        :param pulumi.Input[str] resource_group_name: The name of the resource group.
        :param pulumi.Input[Union[pulumi.InputType['ImageTemplateIsoSourceArgs'], pulumi.InputType['ImageTemplateManagedImageSourceArgs'], pulumi.InputType['ImageTemplatePlatformImageSourceArgs']]] source: Specifies the properties used to describe the source image.
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

            __props__['customize'] = customize
            if distribute is None and not opts.urn:
                raise TypeError("Missing required property 'distribute'")
            __props__['distribute'] = distribute
            if image_template_name is None and not opts.urn:
                raise TypeError("Missing required property 'image_template_name'")
            __props__['image_template_name'] = image_template_name
            __props__['location'] = location
            if resource_group_name is None and not opts.urn:
                raise TypeError("Missing required property 'resource_group_name'")
            __props__['resource_group_name'] = resource_group_name
            if source is None and not opts.urn:
                raise TypeError("Missing required property 'source'")
            __props__['source'] = source
            __props__['tags'] = tags
            __props__['last_run_status'] = None
            __props__['name'] = None
            __props__['provisioning_error'] = None
            __props__['provisioning_state'] = None
            __props__['type'] = None
        alias_opts = pulumi.ResourceOptions(aliases=[pulumi.Alias(type_="azure-nextgen:virtualmachineimages/latest:VirtualMachineImageTemplate"), pulumi.Alias(type_="azure-nextgen:virtualmachineimages/v20180201preview:VirtualMachineImageTemplate"), pulumi.Alias(type_="azure-nextgen:virtualmachineimages/v20190501preview:VirtualMachineImageTemplate"), pulumi.Alias(type_="azure-nextgen:virtualmachineimages/v20200214:VirtualMachineImageTemplate")])
        opts = pulumi.ResourceOptions.merge(opts, alias_opts)
        super(VirtualMachineImageTemplate, __self__).__init__(
            'azure-nextgen:virtualmachineimages/v20190201preview:VirtualMachineImageTemplate',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None) -> 'VirtualMachineImageTemplate':
        """
        Get an existing VirtualMachineImageTemplate resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = dict()

        return VirtualMachineImageTemplate(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter
    def customize(self) -> pulumi.Output[Optional[Sequence[Any]]]:
        """
        Specifies the properties used to describe the customization steps of the image, like Image source etc
        """
        return pulumi.get(self, "customize")

    @property
    @pulumi.getter
    def distribute(self) -> pulumi.Output[Sequence[Any]]:
        """
        The distribution targets where the image output needs to go to.
        """
        return pulumi.get(self, "distribute")

    @property
    @pulumi.getter(name="lastRunStatus")
    def last_run_status(self) -> pulumi.Output['outputs.ImageTemplateLastRunStatusResponse']:
        """
        State of 'run' that is currently executing or was last executed.
        """
        return pulumi.get(self, "last_run_status")

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
    @pulumi.getter(name="provisioningError")
    def provisioning_error(self) -> pulumi.Output['outputs.ProvisioningErrorResponse']:
        """
        Provisioning error, if any
        """
        return pulumi.get(self, "provisioning_error")

    @property
    @pulumi.getter(name="provisioningState")
    def provisioning_state(self) -> pulumi.Output[str]:
        """
        Provisioning state of the resource
        """
        return pulumi.get(self, "provisioning_state")

    @property
    @pulumi.getter
    def source(self) -> pulumi.Output[Any]:
        """
        Specifies the properties used to describe the source image.
        """
        return pulumi.get(self, "source")

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

