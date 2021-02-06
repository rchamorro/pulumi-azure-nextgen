# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union
from ... import _utilities, _tables

__all__ = ['Invitation']


class Invitation(pulumi.CustomResource):
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 account_name: Optional[pulumi.Input[str]] = None,
                 invitation_name: Optional[pulumi.Input[str]] = None,
                 resource_group_name: Optional[pulumi.Input[str]] = None,
                 share_name: Optional[pulumi.Input[str]] = None,
                 target_active_directory_id: Optional[pulumi.Input[str]] = None,
                 target_email: Optional[pulumi.Input[str]] = None,
                 target_object_id: Optional[pulumi.Input[str]] = None,
                 __props__=None,
                 __name__=None,
                 __opts__=None):
        """
        A Invitation data transfer object.

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] account_name: The name of the share account.
        :param pulumi.Input[str] invitation_name: The name of the invitation.
        :param pulumi.Input[str] resource_group_name: The resource group name.
        :param pulumi.Input[str] share_name: The name of the share to send the invitation for.
        :param pulumi.Input[str] target_active_directory_id: The target Azure AD Id. Can't be combined with email.
        :param pulumi.Input[str] target_email: The email the invitation is directed to.
        :param pulumi.Input[str] target_object_id: The target user or application Id that invitation is being sent to.
               Must be specified along TargetActiveDirectoryId. This enables sending
               invitations to specific users or applications in an AD tenant.
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

            if account_name is None and not opts.urn:
                raise TypeError("Missing required property 'account_name'")
            __props__['account_name'] = account_name
            if invitation_name is None and not opts.urn:
                raise TypeError("Missing required property 'invitation_name'")
            __props__['invitation_name'] = invitation_name
            if resource_group_name is None and not opts.urn:
                raise TypeError("Missing required property 'resource_group_name'")
            __props__['resource_group_name'] = resource_group_name
            if share_name is None and not opts.urn:
                raise TypeError("Missing required property 'share_name'")
            __props__['share_name'] = share_name
            __props__['target_active_directory_id'] = target_active_directory_id
            __props__['target_email'] = target_email
            __props__['target_object_id'] = target_object_id
            __props__['invitation_id'] = None
            __props__['invitation_status'] = None
            __props__['name'] = None
            __props__['responded_at'] = None
            __props__['sent_at'] = None
            __props__['type'] = None
            __props__['user_email'] = None
            __props__['user_name'] = None
        alias_opts = pulumi.ResourceOptions(aliases=[pulumi.Alias(type_="azure-nextgen:datashare/latest:Invitation"), pulumi.Alias(type_="azure-nextgen:datashare/v20181101preview:Invitation"), pulumi.Alias(type_="azure-nextgen:datashare/v20200901:Invitation")])
        opts = pulumi.ResourceOptions.merge(opts, alias_opts)
        super(Invitation, __self__).__init__(
            'azure-nextgen:datashare/v20191101:Invitation',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None) -> 'Invitation':
        """
        Get an existing Invitation resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = dict()

        return Invitation(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="invitationId")
    def invitation_id(self) -> pulumi.Output[str]:
        """
        unique invitation id
        """
        return pulumi.get(self, "invitation_id")

    @property
    @pulumi.getter(name="invitationStatus")
    def invitation_status(self) -> pulumi.Output[str]:
        """
        The status of the invitation.
        """
        return pulumi.get(self, "invitation_status")

    @property
    @pulumi.getter
    def name(self) -> pulumi.Output[str]:
        """
        Name of the azure resource
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="respondedAt")
    def responded_at(self) -> pulumi.Output[str]:
        """
        The time the recipient responded to the invitation.
        """
        return pulumi.get(self, "responded_at")

    @property
    @pulumi.getter(name="sentAt")
    def sent_at(self) -> pulumi.Output[str]:
        """
        Gets the time at which the invitation was sent.
        """
        return pulumi.get(self, "sent_at")

    @property
    @pulumi.getter(name="targetActiveDirectoryId")
    def target_active_directory_id(self) -> pulumi.Output[Optional[str]]:
        """
        The target Azure AD Id. Can't be combined with email.
        """
        return pulumi.get(self, "target_active_directory_id")

    @property
    @pulumi.getter(name="targetEmail")
    def target_email(self) -> pulumi.Output[Optional[str]]:
        """
        The email the invitation is directed to.
        """
        return pulumi.get(self, "target_email")

    @property
    @pulumi.getter(name="targetObjectId")
    def target_object_id(self) -> pulumi.Output[Optional[str]]:
        """
        The target user or application Id that invitation is being sent to.
        Must be specified along TargetActiveDirectoryId. This enables sending
        invitations to specific users or applications in an AD tenant.
        """
        return pulumi.get(self, "target_object_id")

    @property
    @pulumi.getter
    def type(self) -> pulumi.Output[str]:
        """
        Type of the azure resource
        """
        return pulumi.get(self, "type")

    @property
    @pulumi.getter(name="userEmail")
    def user_email(self) -> pulumi.Output[str]:
        """
        Email of the user who created the resource
        """
        return pulumi.get(self, "user_email")

    @property
    @pulumi.getter(name="userName")
    def user_name(self) -> pulumi.Output[str]:
        """
        Name of the user who created the resource
        """
        return pulumi.get(self, "user_name")

    def translate_output_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return _tables.SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop

