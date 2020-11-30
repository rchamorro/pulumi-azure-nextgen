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

__all__ = ['BlobServiceProperties']


class BlobServiceProperties(pulumi.CustomResource):
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 account_name: Optional[pulumi.Input[str]] = None,
                 automatic_snapshot_policy_enabled: Optional[pulumi.Input[bool]] = None,
                 blob_services_name: Optional[pulumi.Input[str]] = None,
                 change_feed: Optional[pulumi.Input[pulumi.InputType['ChangeFeedArgs']]] = None,
                 container_delete_retention_policy: Optional[pulumi.Input[pulumi.InputType['DeleteRetentionPolicyArgs']]] = None,
                 cors: Optional[pulumi.Input[pulumi.InputType['CorsRulesArgs']]] = None,
                 default_service_version: Optional[pulumi.Input[str]] = None,
                 delete_retention_policy: Optional[pulumi.Input[pulumi.InputType['DeleteRetentionPolicyArgs']]] = None,
                 is_versioning_enabled: Optional[pulumi.Input[bool]] = None,
                 resource_group_name: Optional[pulumi.Input[str]] = None,
                 restore_policy: Optional[pulumi.Input[pulumi.InputType['RestorePolicyPropertiesArgs']]] = None,
                 __props__=None,
                 __name__=None,
                 __opts__=None):
        """
        The properties of a storage account’s Blob service.

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] account_name: The name of the storage account within the specified resource group. Storage account names must be between 3 and 24 characters in length and use numbers and lower-case letters only.
        :param pulumi.Input[bool] automatic_snapshot_policy_enabled: Deprecated in favor of isVersioningEnabled property.
        :param pulumi.Input[str] blob_services_name: The name of the blob Service within the specified storage account. Blob Service Name must be 'default'
        :param pulumi.Input[pulumi.InputType['ChangeFeedArgs']] change_feed: The blob service properties for change feed events.
        :param pulumi.Input[pulumi.InputType['DeleteRetentionPolicyArgs']] container_delete_retention_policy: The blob service properties for container soft delete.
        :param pulumi.Input[pulumi.InputType['CorsRulesArgs']] cors: Specifies CORS rules for the Blob service. You can include up to five CorsRule elements in the request. If no CorsRule elements are included in the request body, all CORS rules will be deleted, and CORS will be disabled for the Blob service.
        :param pulumi.Input[str] default_service_version: DefaultServiceVersion indicates the default version to use for requests to the Blob service if an incoming request’s version is not specified. Possible values include version 2008-10-27 and all more recent versions.
        :param pulumi.Input[pulumi.InputType['DeleteRetentionPolicyArgs']] delete_retention_policy: The blob service properties for blob soft delete.
        :param pulumi.Input[bool] is_versioning_enabled: Versioning is enabled if set to true.
        :param pulumi.Input[str] resource_group_name: The name of the resource group within the user's subscription. The name is case insensitive.
        :param pulumi.Input[pulumi.InputType['RestorePolicyPropertiesArgs']] restore_policy: The blob service properties for blob restore policy.
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

            if account_name is None:
                raise TypeError("Missing required property 'account_name'")
            __props__['account_name'] = account_name
            __props__['automatic_snapshot_policy_enabled'] = automatic_snapshot_policy_enabled
            if blob_services_name is None:
                raise TypeError("Missing required property 'blob_services_name'")
            __props__['blob_services_name'] = blob_services_name
            __props__['change_feed'] = change_feed
            __props__['container_delete_retention_policy'] = container_delete_retention_policy
            __props__['cors'] = cors
            __props__['default_service_version'] = default_service_version
            __props__['delete_retention_policy'] = delete_retention_policy
            __props__['is_versioning_enabled'] = is_versioning_enabled
            if resource_group_name is None:
                raise TypeError("Missing required property 'resource_group_name'")
            __props__['resource_group_name'] = resource_group_name
            __props__['restore_policy'] = restore_policy
            __props__['name'] = None
            __props__['sku'] = None
            __props__['type'] = None
        alias_opts = pulumi.ResourceOptions(aliases=[pulumi.Alias(type_="azure-nextgen:storage/latest:BlobServiceProperties"), pulumi.Alias(type_="azure-nextgen:storage/v20180701:BlobServiceProperties"), pulumi.Alias(type_="azure-nextgen:storage/v20181101:BlobServiceProperties"), pulumi.Alias(type_="azure-nextgen:storage/v20190401:BlobServiceProperties"), pulumi.Alias(type_="azure-nextgen:storage/v20200801preview:BlobServiceProperties")])
        opts = pulumi.ResourceOptions.merge(opts, alias_opts)
        super(BlobServiceProperties, __self__).__init__(
            'azure-nextgen:storage/v20190601:BlobServiceProperties',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None) -> 'BlobServiceProperties':
        """
        Get an existing BlobServiceProperties resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = dict()

        return BlobServiceProperties(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="automaticSnapshotPolicyEnabled")
    def automatic_snapshot_policy_enabled(self) -> pulumi.Output[Optional[bool]]:
        """
        Deprecated in favor of isVersioningEnabled property.
        """
        return pulumi.get(self, "automatic_snapshot_policy_enabled")

    @property
    @pulumi.getter(name="changeFeed")
    def change_feed(self) -> pulumi.Output[Optional['outputs.ChangeFeedResponse']]:
        """
        The blob service properties for change feed events.
        """
        return pulumi.get(self, "change_feed")

    @property
    @pulumi.getter(name="containerDeleteRetentionPolicy")
    def container_delete_retention_policy(self) -> pulumi.Output[Optional['outputs.DeleteRetentionPolicyResponse']]:
        """
        The blob service properties for container soft delete.
        """
        return pulumi.get(self, "container_delete_retention_policy")

    @property
    @pulumi.getter
    def cors(self) -> pulumi.Output[Optional['outputs.CorsRulesResponse']]:
        """
        Specifies CORS rules for the Blob service. You can include up to five CorsRule elements in the request. If no CorsRule elements are included in the request body, all CORS rules will be deleted, and CORS will be disabled for the Blob service.
        """
        return pulumi.get(self, "cors")

    @property
    @pulumi.getter(name="defaultServiceVersion")
    def default_service_version(self) -> pulumi.Output[Optional[str]]:
        """
        DefaultServiceVersion indicates the default version to use for requests to the Blob service if an incoming request’s version is not specified. Possible values include version 2008-10-27 and all more recent versions.
        """
        return pulumi.get(self, "default_service_version")

    @property
    @pulumi.getter(name="deleteRetentionPolicy")
    def delete_retention_policy(self) -> pulumi.Output[Optional['outputs.DeleteRetentionPolicyResponse']]:
        """
        The blob service properties for blob soft delete.
        """
        return pulumi.get(self, "delete_retention_policy")

    @property
    @pulumi.getter(name="isVersioningEnabled")
    def is_versioning_enabled(self) -> pulumi.Output[Optional[bool]]:
        """
        Versioning is enabled if set to true.
        """
        return pulumi.get(self, "is_versioning_enabled")

    @property
    @pulumi.getter
    def name(self) -> pulumi.Output[str]:
        """
        The name of the resource
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="restorePolicy")
    def restore_policy(self) -> pulumi.Output[Optional['outputs.RestorePolicyPropertiesResponse']]:
        """
        The blob service properties for blob restore policy.
        """
        return pulumi.get(self, "restore_policy")

    @property
    @pulumi.getter
    def sku(self) -> pulumi.Output['outputs.SkuResponse']:
        """
        Sku name and tier.
        """
        return pulumi.get(self, "sku")

    @property
    @pulumi.getter
    def type(self) -> pulumi.Output[str]:
        """
        The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        """
        return pulumi.get(self, "type")

    def translate_output_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return _tables.SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop
