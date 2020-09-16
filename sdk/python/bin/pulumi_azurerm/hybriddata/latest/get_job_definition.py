# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Dict, List, Mapping, Optional, Tuple, Union
from ... import _utilities, _tables
from . import outputs

__all__ = [
    'GetJobDefinitionResult',
    'AwaitableGetJobDefinitionResult',
    'get_job_definition',
]

@pulumi.output_type
class GetJobDefinitionResult:
    """
    Job Definition.
    """
    def __init__(__self__, customer_secrets=None, data_service_input=None, data_sink_id=None, data_source_id=None, last_modified_time=None, name=None, run_location=None, schedules=None, state=None, type=None, user_confirmation=None):
        if customer_secrets and not isinstance(customer_secrets, list):
            raise TypeError("Expected argument 'customer_secrets' to be a list")
        pulumi.set(__self__, "customer_secrets", customer_secrets)
        if data_service_input and not isinstance(data_service_input, dict):
            raise TypeError("Expected argument 'data_service_input' to be a dict")
        pulumi.set(__self__, "data_service_input", data_service_input)
        if data_sink_id and not isinstance(data_sink_id, str):
            raise TypeError("Expected argument 'data_sink_id' to be a str")
        pulumi.set(__self__, "data_sink_id", data_sink_id)
        if data_source_id and not isinstance(data_source_id, str):
            raise TypeError("Expected argument 'data_source_id' to be a str")
        pulumi.set(__self__, "data_source_id", data_source_id)
        if last_modified_time and not isinstance(last_modified_time, str):
            raise TypeError("Expected argument 'last_modified_time' to be a str")
        pulumi.set(__self__, "last_modified_time", last_modified_time)
        if name and not isinstance(name, str):
            raise TypeError("Expected argument 'name' to be a str")
        pulumi.set(__self__, "name", name)
        if run_location and not isinstance(run_location, str):
            raise TypeError("Expected argument 'run_location' to be a str")
        pulumi.set(__self__, "run_location", run_location)
        if schedules and not isinstance(schedules, list):
            raise TypeError("Expected argument 'schedules' to be a list")
        pulumi.set(__self__, "schedules", schedules)
        if state and not isinstance(state, str):
            raise TypeError("Expected argument 'state' to be a str")
        pulumi.set(__self__, "state", state)
        if type and not isinstance(type, str):
            raise TypeError("Expected argument 'type' to be a str")
        pulumi.set(__self__, "type", type)
        if user_confirmation and not isinstance(user_confirmation, str):
            raise TypeError("Expected argument 'user_confirmation' to be a str")
        pulumi.set(__self__, "user_confirmation", user_confirmation)

    @property
    @pulumi.getter(name="customerSecrets")
    def customer_secrets(self) -> Optional[List['outputs.CustomerSecretResponse']]:
        """
        List of customer secrets containing a key identifier and key value. The key identifier is a way for the specific data source to understand the key. Value contains customer secret encrypted by the encryptionKeys.
        """
        return pulumi.get(self, "customer_secrets")

    @property
    @pulumi.getter(name="dataServiceInput")
    def data_service_input(self) -> Optional[Mapping[str, Any]]:
        """
        A generic json used differently by each data service type.
        """
        return pulumi.get(self, "data_service_input")

    @property
    @pulumi.getter(name="dataSinkId")
    def data_sink_id(self) -> str:
        """
        Data Sink Id associated to the job definition.
        """
        return pulumi.get(self, "data_sink_id")

    @property
    @pulumi.getter(name="dataSourceId")
    def data_source_id(self) -> str:
        """
        Data Source Id associated to the job definition.
        """
        return pulumi.get(self, "data_source_id")

    @property
    @pulumi.getter(name="lastModifiedTime")
    def last_modified_time(self) -> Optional[str]:
        """
        Last modified time of the job definition.
        """
        return pulumi.get(self, "last_modified_time")

    @property
    @pulumi.getter
    def name(self) -> str:
        """
        Name of the object.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="runLocation")
    def run_location(self) -> Optional[str]:
        """
        This is the preferred geo location for the job to run.
        """
        return pulumi.get(self, "run_location")

    @property
    @pulumi.getter
    def schedules(self) -> Optional[List['outputs.ScheduleResponse']]:
        """
        Schedule for running the job definition
        """
        return pulumi.get(self, "schedules")

    @property
    @pulumi.getter
    def state(self) -> str:
        """
        State of the job definition.
        """
        return pulumi.get(self, "state")

    @property
    @pulumi.getter
    def type(self) -> str:
        """
        Type of the object.
        """
        return pulumi.get(self, "type")

    @property
    @pulumi.getter(name="userConfirmation")
    def user_confirmation(self) -> Optional[str]:
        """
        Enum to detect if user confirmation is required. If not passed will default to NotRequired.
        """
        return pulumi.get(self, "user_confirmation")


class AwaitableGetJobDefinitionResult(GetJobDefinitionResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetJobDefinitionResult(
            customer_secrets=self.customer_secrets,
            data_service_input=self.data_service_input,
            data_sink_id=self.data_sink_id,
            data_source_id=self.data_source_id,
            last_modified_time=self.last_modified_time,
            name=self.name,
            run_location=self.run_location,
            schedules=self.schedules,
            state=self.state,
            type=self.type,
            user_confirmation=self.user_confirmation)


def get_job_definition(data_manager_name: Optional[str] = None,
                       data_service_name: Optional[str] = None,
                       job_definition_name: Optional[str] = None,
                       resource_group_name: Optional[str] = None,
                       opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetJobDefinitionResult:
    """
    Use this data source to access information about an existing resource.

    :param str data_manager_name: The name of the DataManager Resource within the specified resource group. DataManager names must be between 3 and 24 characters in length and use any alphanumeric and underscore only
    :param str data_service_name: The data service name of the job definition
    :param str job_definition_name: The job definition name that is being queried.
    :param str resource_group_name: The Resource Group Name
    """
    __args__ = dict()
    __args__['dataManagerName'] = data_manager_name
    __args__['dataServiceName'] = data_service_name
    __args__['jobDefinitionName'] = job_definition_name
    __args__['resourceGroupName'] = resource_group_name
    if opts is None:
        opts = pulumi.InvokeOptions()
    if opts.version is None:
        opts.version = _utilities.get_version()
    __ret__ = pulumi.runtime.invoke('azurerm:hybriddata/latest:getJobDefinition', __args__, opts=opts, typ=GetJobDefinitionResult).value

    return AwaitableGetJobDefinitionResult(
        customer_secrets=__ret__.customer_secrets,
        data_service_input=__ret__.data_service_input,
        data_sink_id=__ret__.data_sink_id,
        data_source_id=__ret__.data_source_id,
        last_modified_time=__ret__.last_modified_time,
        name=__ret__.name,
        run_location=__ret__.run_location,
        schedules=__ret__.schedules,
        state=__ret__.state,
        type=__ret__.type,
        user_confirmation=__ret__.user_confirmation)