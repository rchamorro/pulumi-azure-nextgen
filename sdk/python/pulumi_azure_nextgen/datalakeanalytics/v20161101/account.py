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

__all__ = ['Account']


class Account(pulumi.CustomResource):
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 account_name: Optional[pulumi.Input[str]] = None,
                 compute_policies: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['CreateComputePolicyWithAccountParametersArgs']]]]] = None,
                 data_lake_store_accounts: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['AddDataLakeStoreWithAccountParametersArgs']]]]] = None,
                 default_data_lake_store_account: Optional[pulumi.Input[str]] = None,
                 firewall_allow_azure_ips: Optional[pulumi.Input['FirewallAllowAzureIpsState']] = None,
                 firewall_rules: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['CreateFirewallRuleWithAccountParametersArgs']]]]] = None,
                 firewall_state: Optional[pulumi.Input['FirewallState']] = None,
                 location: Optional[pulumi.Input[str]] = None,
                 max_degree_of_parallelism: Optional[pulumi.Input[int]] = None,
                 max_degree_of_parallelism_per_job: Optional[pulumi.Input[int]] = None,
                 max_job_count: Optional[pulumi.Input[int]] = None,
                 min_priority_per_job: Optional[pulumi.Input[int]] = None,
                 new_tier: Optional[pulumi.Input['TierType']] = None,
                 query_store_retention: Optional[pulumi.Input[int]] = None,
                 resource_group_name: Optional[pulumi.Input[str]] = None,
                 storage_accounts: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['AddStorageAccountWithAccountParametersArgs']]]]] = None,
                 tags: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
                 __props__=None,
                 __name__=None,
                 __opts__=None):
        """
        A Data Lake Analytics account object, containing all information associated with the named Data Lake Analytics account.

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] account_name: The name of the Data Lake Analytics account.
        :param pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['CreateComputePolicyWithAccountParametersArgs']]]] compute_policies: The list of compute policies associated with this account.
        :param pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['AddDataLakeStoreWithAccountParametersArgs']]]] data_lake_store_accounts: The list of Data Lake Store accounts associated with this account.
        :param pulumi.Input[str] default_data_lake_store_account: The default Data Lake Store account associated with this account.
        :param pulumi.Input['FirewallAllowAzureIpsState'] firewall_allow_azure_ips: The current state of allowing or disallowing IPs originating within Azure through the firewall. If the firewall is disabled, this is not enforced.
        :param pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['CreateFirewallRuleWithAccountParametersArgs']]]] firewall_rules: The list of firewall rules associated with this account.
        :param pulumi.Input['FirewallState'] firewall_state: The current state of the IP address firewall for this account.
        :param pulumi.Input[str] location: The resource location.
        :param pulumi.Input[int] max_degree_of_parallelism: The maximum supported degree of parallelism for this account.
        :param pulumi.Input[int] max_degree_of_parallelism_per_job: The maximum supported degree of parallelism per job for this account.
        :param pulumi.Input[int] max_job_count: The maximum supported jobs running under the account at the same time.
        :param pulumi.Input[int] min_priority_per_job: The minimum supported priority per job for this account.
        :param pulumi.Input['TierType'] new_tier: The commitment tier for the next month.
        :param pulumi.Input[int] query_store_retention: The number of days that job metadata is retained.
        :param pulumi.Input[str] resource_group_name: The name of the Azure resource group.
        :param pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['AddStorageAccountWithAccountParametersArgs']]]] storage_accounts: The list of Azure Blob Storage accounts associated with this account.
        :param pulumi.Input[Mapping[str, pulumi.Input[str]]] tags: The resource tags.
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
            __props__['compute_policies'] = compute_policies
            if data_lake_store_accounts is None and not opts.urn:
                raise TypeError("Missing required property 'data_lake_store_accounts'")
            __props__['data_lake_store_accounts'] = data_lake_store_accounts
            if default_data_lake_store_account is None and not opts.urn:
                raise TypeError("Missing required property 'default_data_lake_store_account'")
            __props__['default_data_lake_store_account'] = default_data_lake_store_account
            __props__['firewall_allow_azure_ips'] = firewall_allow_azure_ips
            __props__['firewall_rules'] = firewall_rules
            __props__['firewall_state'] = firewall_state
            __props__['location'] = location
            if max_degree_of_parallelism is None:
                max_degree_of_parallelism = 30
            __props__['max_degree_of_parallelism'] = max_degree_of_parallelism
            __props__['max_degree_of_parallelism_per_job'] = max_degree_of_parallelism_per_job
            if max_job_count is None:
                max_job_count = 3
            __props__['max_job_count'] = max_job_count
            __props__['min_priority_per_job'] = min_priority_per_job
            __props__['new_tier'] = new_tier
            if query_store_retention is None:
                query_store_retention = 30
            __props__['query_store_retention'] = query_store_retention
            if resource_group_name is None and not opts.urn:
                raise TypeError("Missing required property 'resource_group_name'")
            __props__['resource_group_name'] = resource_group_name
            __props__['storage_accounts'] = storage_accounts
            __props__['tags'] = tags
            __props__['account_id'] = None
            __props__['creation_time'] = None
            __props__['current_tier'] = None
            __props__['debug_data_access_level'] = None
            __props__['endpoint'] = None
            __props__['hive_metastores'] = None
            __props__['last_modified_time'] = None
            __props__['name'] = None
            __props__['provisioning_state'] = None
            __props__['state'] = None
            __props__['system_max_degree_of_parallelism'] = None
            __props__['system_max_job_count'] = None
            __props__['type'] = None
            __props__['virtual_network_rules'] = None
        alias_opts = pulumi.ResourceOptions(aliases=[pulumi.Alias(type_="azure-nextgen:datalakeanalytics/latest:Account"), pulumi.Alias(type_="azure-nextgen:datalakeanalytics/v20151001preview:Account")])
        opts = pulumi.ResourceOptions.merge(opts, alias_opts)
        super(Account, __self__).__init__(
            'azure-nextgen:datalakeanalytics/v20161101:Account',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None) -> 'Account':
        """
        Get an existing Account resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = dict()

        return Account(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="accountId")
    def account_id(self) -> pulumi.Output[str]:
        """
        The unique identifier associated with this Data Lake Analytics account.
        """
        return pulumi.get(self, "account_id")

    @property
    @pulumi.getter(name="computePolicies")
    def compute_policies(self) -> pulumi.Output[Sequence['outputs.ComputePolicyResponse']]:
        """
        The list of compute policies associated with this account.
        """
        return pulumi.get(self, "compute_policies")

    @property
    @pulumi.getter(name="creationTime")
    def creation_time(self) -> pulumi.Output[str]:
        """
        The account creation time.
        """
        return pulumi.get(self, "creation_time")

    @property
    @pulumi.getter(name="currentTier")
    def current_tier(self) -> pulumi.Output[str]:
        """
        The commitment tier in use for the current month.
        """
        return pulumi.get(self, "current_tier")

    @property
    @pulumi.getter(name="dataLakeStoreAccounts")
    def data_lake_store_accounts(self) -> pulumi.Output[Sequence['outputs.DataLakeStoreAccountInformationResponse']]:
        """
        The list of Data Lake Store accounts associated with this account.
        """
        return pulumi.get(self, "data_lake_store_accounts")

    @property
    @pulumi.getter(name="debugDataAccessLevel")
    def debug_data_access_level(self) -> pulumi.Output[str]:
        """
        The current state of the DebugDataAccessLevel for this account.
        """
        return pulumi.get(self, "debug_data_access_level")

    @property
    @pulumi.getter(name="defaultDataLakeStoreAccount")
    def default_data_lake_store_account(self) -> pulumi.Output[str]:
        """
        The default Data Lake Store account associated with this account.
        """
        return pulumi.get(self, "default_data_lake_store_account")

    @property
    @pulumi.getter
    def endpoint(self) -> pulumi.Output[str]:
        """
        The full CName endpoint for this account.
        """
        return pulumi.get(self, "endpoint")

    @property
    @pulumi.getter(name="firewallAllowAzureIps")
    def firewall_allow_azure_ips(self) -> pulumi.Output[str]:
        """
        The current state of allowing or disallowing IPs originating within Azure through the firewall. If the firewall is disabled, this is not enforced.
        """
        return pulumi.get(self, "firewall_allow_azure_ips")

    @property
    @pulumi.getter(name="firewallRules")
    def firewall_rules(self) -> pulumi.Output[Sequence['outputs.FirewallRuleResponse']]:
        """
        The list of firewall rules associated with this account.
        """
        return pulumi.get(self, "firewall_rules")

    @property
    @pulumi.getter(name="firewallState")
    def firewall_state(self) -> pulumi.Output[str]:
        """
        The current state of the IP address firewall for this account.
        """
        return pulumi.get(self, "firewall_state")

    @property
    @pulumi.getter(name="hiveMetastores")
    def hive_metastores(self) -> pulumi.Output[Sequence['outputs.HiveMetastoreResponse']]:
        """
        The list of hiveMetastores associated with this account.
        """
        return pulumi.get(self, "hive_metastores")

    @property
    @pulumi.getter(name="lastModifiedTime")
    def last_modified_time(self) -> pulumi.Output[str]:
        """
        The account last modified time.
        """
        return pulumi.get(self, "last_modified_time")

    @property
    @pulumi.getter
    def location(self) -> pulumi.Output[str]:
        """
        The resource location.
        """
        return pulumi.get(self, "location")

    @property
    @pulumi.getter(name="maxDegreeOfParallelism")
    def max_degree_of_parallelism(self) -> pulumi.Output[Optional[int]]:
        """
        The maximum supported degree of parallelism for this account.
        """
        return pulumi.get(self, "max_degree_of_parallelism")

    @property
    @pulumi.getter(name="maxDegreeOfParallelismPerJob")
    def max_degree_of_parallelism_per_job(self) -> pulumi.Output[int]:
        """
        The maximum supported degree of parallelism per job for this account.
        """
        return pulumi.get(self, "max_degree_of_parallelism_per_job")

    @property
    @pulumi.getter(name="maxJobCount")
    def max_job_count(self) -> pulumi.Output[Optional[int]]:
        """
        The maximum supported jobs running under the account at the same time.
        """
        return pulumi.get(self, "max_job_count")

    @property
    @pulumi.getter(name="minPriorityPerJob")
    def min_priority_per_job(self) -> pulumi.Output[int]:
        """
        The minimum supported priority per job for this account.
        """
        return pulumi.get(self, "min_priority_per_job")

    @property
    @pulumi.getter
    def name(self) -> pulumi.Output[str]:
        """
        The resource name.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="newTier")
    def new_tier(self) -> pulumi.Output[str]:
        """
        The commitment tier for the next month.
        """
        return pulumi.get(self, "new_tier")

    @property
    @pulumi.getter(name="provisioningState")
    def provisioning_state(self) -> pulumi.Output[str]:
        """
        The provisioning status of the Data Lake Analytics account.
        """
        return pulumi.get(self, "provisioning_state")

    @property
    @pulumi.getter(name="queryStoreRetention")
    def query_store_retention(self) -> pulumi.Output[Optional[int]]:
        """
        The number of days that job metadata is retained.
        """
        return pulumi.get(self, "query_store_retention")

    @property
    @pulumi.getter
    def state(self) -> pulumi.Output[str]:
        """
        The state of the Data Lake Analytics account.
        """
        return pulumi.get(self, "state")

    @property
    @pulumi.getter(name="storageAccounts")
    def storage_accounts(self) -> pulumi.Output[Sequence['outputs.StorageAccountInformationResponse']]:
        """
        The list of Azure Blob Storage accounts associated with this account.
        """
        return pulumi.get(self, "storage_accounts")

    @property
    @pulumi.getter(name="systemMaxDegreeOfParallelism")
    def system_max_degree_of_parallelism(self) -> pulumi.Output[int]:
        """
        The system defined maximum supported degree of parallelism for this account, which restricts the maximum value of parallelism the user can set for the account.
        """
        return pulumi.get(self, "system_max_degree_of_parallelism")

    @property
    @pulumi.getter(name="systemMaxJobCount")
    def system_max_job_count(self) -> pulumi.Output[int]:
        """
        The system defined maximum supported jobs running under the account at the same time, which restricts the maximum number of running jobs the user can set for the account.
        """
        return pulumi.get(self, "system_max_job_count")

    @property
    @pulumi.getter
    def tags(self) -> pulumi.Output[Mapping[str, str]]:
        """
        The resource tags.
        """
        return pulumi.get(self, "tags")

    @property
    @pulumi.getter
    def type(self) -> pulumi.Output[str]:
        """
        The resource type.
        """
        return pulumi.get(self, "type")

    @property
    @pulumi.getter(name="virtualNetworkRules")
    def virtual_network_rules(self) -> pulumi.Output[Sequence['outputs.VirtualNetworkRuleResponse']]:
        """
        The list of virtualNetwork rules associated with this account.
        """
        return pulumi.get(self, "virtual_network_rules")

    def translate_output_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return _tables.SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop

