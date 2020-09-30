# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union
from ... import _utilities, _tables

__all__ = [
    'DataCollectionRuleDataSourcesArgs',
    'DataCollectionRuleDestinationsArgs',
    'DataFlowArgs',
    'DestinationsSpecAzureMonitorMetricsArgs',
    'ExtensionDataSourceArgs',
    'LogAnalyticsDestinationArgs',
    'PerfCounterDataSourceArgs',
    'SyslogDataSourceArgs',
    'WindowsEventLogDataSourceArgs',
]

@pulumi.input_type
class DataCollectionRuleDataSourcesArgs:
    def __init__(__self__, *,
                 extensions: Optional[pulumi.Input[Sequence[pulumi.Input['ExtensionDataSourceArgs']]]] = None,
                 performance_counters: Optional[pulumi.Input[Sequence[pulumi.Input['PerfCounterDataSourceArgs']]]] = None,
                 syslog: Optional[pulumi.Input[Sequence[pulumi.Input['SyslogDataSourceArgs']]]] = None,
                 windows_event_logs: Optional[pulumi.Input[Sequence[pulumi.Input['WindowsEventLogDataSourceArgs']]]] = None):
        """
        The specification of data sources. 
        This property is optional and can be omitted if the rule is meant to be used via direct calls to the provisioned endpoint.
        :param pulumi.Input[Sequence[pulumi.Input['ExtensionDataSourceArgs']]] extensions: The list of Azure VM extension data source configurations.
        :param pulumi.Input[Sequence[pulumi.Input['PerfCounterDataSourceArgs']]] performance_counters: The list of performance counter data source configurations.
        :param pulumi.Input[Sequence[pulumi.Input['SyslogDataSourceArgs']]] syslog: The list of Syslog data source configurations.
        :param pulumi.Input[Sequence[pulumi.Input['WindowsEventLogDataSourceArgs']]] windows_event_logs: The list of Windows Event Log data source configurations.
        """
        if extensions is not None:
            pulumi.set(__self__, "extensions", extensions)
        if performance_counters is not None:
            pulumi.set(__self__, "performance_counters", performance_counters)
        if syslog is not None:
            pulumi.set(__self__, "syslog", syslog)
        if windows_event_logs is not None:
            pulumi.set(__self__, "windows_event_logs", windows_event_logs)

    @property
    @pulumi.getter
    def extensions(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['ExtensionDataSourceArgs']]]]:
        """
        The list of Azure VM extension data source configurations.
        """
        return pulumi.get(self, "extensions")

    @extensions.setter
    def extensions(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['ExtensionDataSourceArgs']]]]):
        pulumi.set(self, "extensions", value)

    @property
    @pulumi.getter(name="performanceCounters")
    def performance_counters(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['PerfCounterDataSourceArgs']]]]:
        """
        The list of performance counter data source configurations.
        """
        return pulumi.get(self, "performance_counters")

    @performance_counters.setter
    def performance_counters(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['PerfCounterDataSourceArgs']]]]):
        pulumi.set(self, "performance_counters", value)

    @property
    @pulumi.getter
    def syslog(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['SyslogDataSourceArgs']]]]:
        """
        The list of Syslog data source configurations.
        """
        return pulumi.get(self, "syslog")

    @syslog.setter
    def syslog(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['SyslogDataSourceArgs']]]]):
        pulumi.set(self, "syslog", value)

    @property
    @pulumi.getter(name="windowsEventLogs")
    def windows_event_logs(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['WindowsEventLogDataSourceArgs']]]]:
        """
        The list of Windows Event Log data source configurations.
        """
        return pulumi.get(self, "windows_event_logs")

    @windows_event_logs.setter
    def windows_event_logs(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['WindowsEventLogDataSourceArgs']]]]):
        pulumi.set(self, "windows_event_logs", value)


@pulumi.input_type
class DataCollectionRuleDestinationsArgs:
    def __init__(__self__, *,
                 azure_monitor_metrics: Optional[pulumi.Input['DestinationsSpecAzureMonitorMetricsArgs']] = None,
                 log_analytics: Optional[pulumi.Input[Sequence[pulumi.Input['LogAnalyticsDestinationArgs']]]] = None):
        """
        The specification of destinations.
        :param pulumi.Input['DestinationsSpecAzureMonitorMetricsArgs'] azure_monitor_metrics: Azure Monitor Metrics destination.
        :param pulumi.Input[Sequence[pulumi.Input['LogAnalyticsDestinationArgs']]] log_analytics: List of Log Analytics destinations.
        """
        if azure_monitor_metrics is not None:
            pulumi.set(__self__, "azure_monitor_metrics", azure_monitor_metrics)
        if log_analytics is not None:
            pulumi.set(__self__, "log_analytics", log_analytics)

    @property
    @pulumi.getter(name="azureMonitorMetrics")
    def azure_monitor_metrics(self) -> Optional[pulumi.Input['DestinationsSpecAzureMonitorMetricsArgs']]:
        """
        Azure Monitor Metrics destination.
        """
        return pulumi.get(self, "azure_monitor_metrics")

    @azure_monitor_metrics.setter
    def azure_monitor_metrics(self, value: Optional[pulumi.Input['DestinationsSpecAzureMonitorMetricsArgs']]):
        pulumi.set(self, "azure_monitor_metrics", value)

    @property
    @pulumi.getter(name="logAnalytics")
    def log_analytics(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['LogAnalyticsDestinationArgs']]]]:
        """
        List of Log Analytics destinations.
        """
        return pulumi.get(self, "log_analytics")

    @log_analytics.setter
    def log_analytics(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['LogAnalyticsDestinationArgs']]]]):
        pulumi.set(self, "log_analytics", value)


@pulumi.input_type
class DataFlowArgs:
    def __init__(__self__, *,
                 destinations: pulumi.Input[Sequence[pulumi.Input[str]]],
                 streams: pulumi.Input[Sequence[pulumi.Input[str]]]):
        """
        Definition of which streams are sent to which destinations.
        :param pulumi.Input[Sequence[pulumi.Input[str]]] destinations: List of destinations for this data flow.
        :param pulumi.Input[Sequence[pulumi.Input[str]]] streams: List of streams for this data flow.
        """
        pulumi.set(__self__, "destinations", destinations)
        pulumi.set(__self__, "streams", streams)

    @property
    @pulumi.getter
    def destinations(self) -> pulumi.Input[Sequence[pulumi.Input[str]]]:
        """
        List of destinations for this data flow.
        """
        return pulumi.get(self, "destinations")

    @destinations.setter
    def destinations(self, value: pulumi.Input[Sequence[pulumi.Input[str]]]):
        pulumi.set(self, "destinations", value)

    @property
    @pulumi.getter
    def streams(self) -> pulumi.Input[Sequence[pulumi.Input[str]]]:
        """
        List of streams for this data flow.
        """
        return pulumi.get(self, "streams")

    @streams.setter
    def streams(self, value: pulumi.Input[Sequence[pulumi.Input[str]]]):
        pulumi.set(self, "streams", value)


@pulumi.input_type
class DestinationsSpecAzureMonitorMetricsArgs:
    def __init__(__self__, *,
                 name: pulumi.Input[str]):
        """
        Azure Monitor Metrics destination.
        :param pulumi.Input[str] name: A friendly name for the destination. 
               This name should be unique across all destinations (regardless of type) within the data collection rule.
        """
        pulumi.set(__self__, "name", name)

    @property
    @pulumi.getter
    def name(self) -> pulumi.Input[str]:
        """
        A friendly name for the destination. 
        This name should be unique across all destinations (regardless of type) within the data collection rule.
        """
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: pulumi.Input[str]):
        pulumi.set(self, "name", value)


@pulumi.input_type
class ExtensionDataSourceArgs:
    def __init__(__self__, *,
                 extension_name: pulumi.Input[str],
                 name: pulumi.Input[str],
                 streams: pulumi.Input[Sequence[pulumi.Input[str]]],
                 extension_settings: Optional[Any] = None):
        """
        Definition of which data will be collected from a separate VM extension that integrates with the Azure Monitor Agent.
        Collected from either Windows and Linux machines, depending on which extension is defined.
        :param pulumi.Input[str] extension_name: The name of the VM extension.
        :param pulumi.Input[str] name: A friendly name for the data source. 
               This name should be unique across all data sources (regardless of type) within the data collection rule.
        :param pulumi.Input[Sequence[pulumi.Input[str]]] streams: List of streams that this data source will be sent to.
               A stream indicates what schema will be used for this data and usually what table in Log Analytics the data will be sent to.
        :param Any extension_settings: The extension settings. The format is specific for particular extension.
        """
        pulumi.set(__self__, "extension_name", extension_name)
        pulumi.set(__self__, "name", name)
        pulumi.set(__self__, "streams", streams)
        if extension_settings is not None:
            pulumi.set(__self__, "extension_settings", extension_settings)

    @property
    @pulumi.getter(name="extensionName")
    def extension_name(self) -> pulumi.Input[str]:
        """
        The name of the VM extension.
        """
        return pulumi.get(self, "extension_name")

    @extension_name.setter
    def extension_name(self, value: pulumi.Input[str]):
        pulumi.set(self, "extension_name", value)

    @property
    @pulumi.getter
    def name(self) -> pulumi.Input[str]:
        """
        A friendly name for the data source. 
        This name should be unique across all data sources (regardless of type) within the data collection rule.
        """
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: pulumi.Input[str]):
        pulumi.set(self, "name", value)

    @property
    @pulumi.getter
    def streams(self) -> pulumi.Input[Sequence[pulumi.Input[str]]]:
        """
        List of streams that this data source will be sent to.
        A stream indicates what schema will be used for this data and usually what table in Log Analytics the data will be sent to.
        """
        return pulumi.get(self, "streams")

    @streams.setter
    def streams(self, value: pulumi.Input[Sequence[pulumi.Input[str]]]):
        pulumi.set(self, "streams", value)

    @property
    @pulumi.getter(name="extensionSettings")
    def extension_settings(self) -> Optional[Any]:
        """
        The extension settings. The format is specific for particular extension.
        """
        return pulumi.get(self, "extension_settings")

    @extension_settings.setter
    def extension_settings(self, value: Optional[Any]):
        pulumi.set(self, "extension_settings", value)


@pulumi.input_type
class LogAnalyticsDestinationArgs:
    def __init__(__self__, *,
                 name: pulumi.Input[str],
                 workspace_resource_id: pulumi.Input[str]):
        """
        Log Analytics destination.
        :param pulumi.Input[str] name: A friendly name for the destination. 
               This name should be unique across all destinations (regardless of type) within the data collection rule.
        :param pulumi.Input[str] workspace_resource_id: The resource ID of the Log Analytics workspace.
        """
        pulumi.set(__self__, "name", name)
        pulumi.set(__self__, "workspace_resource_id", workspace_resource_id)

    @property
    @pulumi.getter
    def name(self) -> pulumi.Input[str]:
        """
        A friendly name for the destination. 
        This name should be unique across all destinations (regardless of type) within the data collection rule.
        """
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: pulumi.Input[str]):
        pulumi.set(self, "name", value)

    @property
    @pulumi.getter(name="workspaceResourceId")
    def workspace_resource_id(self) -> pulumi.Input[str]:
        """
        The resource ID of the Log Analytics workspace.
        """
        return pulumi.get(self, "workspace_resource_id")

    @workspace_resource_id.setter
    def workspace_resource_id(self, value: pulumi.Input[str]):
        pulumi.set(self, "workspace_resource_id", value)


@pulumi.input_type
class PerfCounterDataSourceArgs:
    def __init__(__self__, *,
                 counter_specifiers: pulumi.Input[Sequence[pulumi.Input[str]]],
                 name: pulumi.Input[str],
                 sampling_frequency_in_seconds: pulumi.Input[int],
                 scheduled_transfer_period: pulumi.Input[str],
                 streams: pulumi.Input[Sequence[pulumi.Input[str]]]):
        """
        Definition of which performance counters will be collected and how they will be collected by this data collection rule.
        Collected from both Windows and Linux machines where the counter is present.
        :param pulumi.Input[Sequence[pulumi.Input[str]]] counter_specifiers: A list of specifier names of the performance counters you want to collect.
               Use a wildcard (*) to collect a counter for all instances.
               To get a list of performance counters on Windows, run the command 'typeperf'.
        :param pulumi.Input[str] name: A friendly name for the data source. 
               This name should be unique across all data sources (regardless of type) within the data collection rule.
        :param pulumi.Input[int] sampling_frequency_in_seconds: The number of seconds between consecutive counter measurements (samples).
        :param pulumi.Input[str] scheduled_transfer_period: The interval between data uploads (scheduled transfers), rounded up to the nearest minute.
        :param pulumi.Input[Sequence[pulumi.Input[str]]] streams: List of streams that this data source will be sent to.
               A stream indicates what schema will be used for this data and usually what table in Log Analytics the data will be sent to.
        """
        pulumi.set(__self__, "counter_specifiers", counter_specifiers)
        pulumi.set(__self__, "name", name)
        pulumi.set(__self__, "sampling_frequency_in_seconds", sampling_frequency_in_seconds)
        pulumi.set(__self__, "scheduled_transfer_period", scheduled_transfer_period)
        pulumi.set(__self__, "streams", streams)

    @property
    @pulumi.getter(name="counterSpecifiers")
    def counter_specifiers(self) -> pulumi.Input[Sequence[pulumi.Input[str]]]:
        """
        A list of specifier names of the performance counters you want to collect.
        Use a wildcard (*) to collect a counter for all instances.
        To get a list of performance counters on Windows, run the command 'typeperf'.
        """
        return pulumi.get(self, "counter_specifiers")

    @counter_specifiers.setter
    def counter_specifiers(self, value: pulumi.Input[Sequence[pulumi.Input[str]]]):
        pulumi.set(self, "counter_specifiers", value)

    @property
    @pulumi.getter
    def name(self) -> pulumi.Input[str]:
        """
        A friendly name for the data source. 
        This name should be unique across all data sources (regardless of type) within the data collection rule.
        """
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: pulumi.Input[str]):
        pulumi.set(self, "name", value)

    @property
    @pulumi.getter(name="samplingFrequencyInSeconds")
    def sampling_frequency_in_seconds(self) -> pulumi.Input[int]:
        """
        The number of seconds between consecutive counter measurements (samples).
        """
        return pulumi.get(self, "sampling_frequency_in_seconds")

    @sampling_frequency_in_seconds.setter
    def sampling_frequency_in_seconds(self, value: pulumi.Input[int]):
        pulumi.set(self, "sampling_frequency_in_seconds", value)

    @property
    @pulumi.getter(name="scheduledTransferPeriod")
    def scheduled_transfer_period(self) -> pulumi.Input[str]:
        """
        The interval between data uploads (scheduled transfers), rounded up to the nearest minute.
        """
        return pulumi.get(self, "scheduled_transfer_period")

    @scheduled_transfer_period.setter
    def scheduled_transfer_period(self, value: pulumi.Input[str]):
        pulumi.set(self, "scheduled_transfer_period", value)

    @property
    @pulumi.getter
    def streams(self) -> pulumi.Input[Sequence[pulumi.Input[str]]]:
        """
        List of streams that this data source will be sent to.
        A stream indicates what schema will be used for this data and usually what table in Log Analytics the data will be sent to.
        """
        return pulumi.get(self, "streams")

    @streams.setter
    def streams(self, value: pulumi.Input[Sequence[pulumi.Input[str]]]):
        pulumi.set(self, "streams", value)


@pulumi.input_type
class SyslogDataSourceArgs:
    def __init__(__self__, *,
                 facility_names: pulumi.Input[Sequence[pulumi.Input[str]]],
                 name: pulumi.Input[str],
                 streams: pulumi.Input[Sequence[pulumi.Input[str]]],
                 log_levels: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None):
        """
        Definition of which syslog data will be collected and how it will be collected.
        Only collected from Linux machines.
        :param pulumi.Input[Sequence[pulumi.Input[str]]] facility_names: The list of facility names.
        :param pulumi.Input[str] name: A friendly name for the data source. 
               This name should be unique across all data sources (regardless of type) within the data collection rule.
        :param pulumi.Input[Sequence[pulumi.Input[str]]] streams: List of streams that this data source will be sent to.
               A stream indicates what schema will be used for this data and usually what table in Log Analytics the data will be sent to.
        :param pulumi.Input[Sequence[pulumi.Input[str]]] log_levels: The log levels to collect.
        """
        pulumi.set(__self__, "facility_names", facility_names)
        pulumi.set(__self__, "name", name)
        pulumi.set(__self__, "streams", streams)
        if log_levels is not None:
            pulumi.set(__self__, "log_levels", log_levels)

    @property
    @pulumi.getter(name="facilityNames")
    def facility_names(self) -> pulumi.Input[Sequence[pulumi.Input[str]]]:
        """
        The list of facility names.
        """
        return pulumi.get(self, "facility_names")

    @facility_names.setter
    def facility_names(self, value: pulumi.Input[Sequence[pulumi.Input[str]]]):
        pulumi.set(self, "facility_names", value)

    @property
    @pulumi.getter
    def name(self) -> pulumi.Input[str]:
        """
        A friendly name for the data source. 
        This name should be unique across all data sources (regardless of type) within the data collection rule.
        """
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: pulumi.Input[str]):
        pulumi.set(self, "name", value)

    @property
    @pulumi.getter
    def streams(self) -> pulumi.Input[Sequence[pulumi.Input[str]]]:
        """
        List of streams that this data source will be sent to.
        A stream indicates what schema will be used for this data and usually what table in Log Analytics the data will be sent to.
        """
        return pulumi.get(self, "streams")

    @streams.setter
    def streams(self, value: pulumi.Input[Sequence[pulumi.Input[str]]]):
        pulumi.set(self, "streams", value)

    @property
    @pulumi.getter(name="logLevels")
    def log_levels(self) -> Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]:
        """
        The log levels to collect.
        """
        return pulumi.get(self, "log_levels")

    @log_levels.setter
    def log_levels(self, value: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]):
        pulumi.set(self, "log_levels", value)


@pulumi.input_type
class WindowsEventLogDataSourceArgs:
    def __init__(__self__, *,
                 name: pulumi.Input[str],
                 scheduled_transfer_period: pulumi.Input[str],
                 streams: pulumi.Input[Sequence[pulumi.Input[str]]],
                 x_path_queries: pulumi.Input[Sequence[pulumi.Input[str]]]):
        """
        Definition of which Windows Event Log events will be collected and how they will be collected.
        Only collected from Windows machines.
        :param pulumi.Input[str] name: A friendly name for the data source. 
               This name should be unique across all data sources (regardless of type) within the data collection rule.
        :param pulumi.Input[str] scheduled_transfer_period: The interval between data uploads (scheduled transfers), rounded up to the nearest minute.
        :param pulumi.Input[Sequence[pulumi.Input[str]]] streams: List of streams that this data source will be sent to.
               A stream indicates what schema will be used for this data and usually what table in Log Analytics the data will be sent to.
        :param pulumi.Input[Sequence[pulumi.Input[str]]] x_path_queries: A list of Windows Event Log queries in XPATH format.
        """
        pulumi.set(__self__, "name", name)
        pulumi.set(__self__, "scheduled_transfer_period", scheduled_transfer_period)
        pulumi.set(__self__, "streams", streams)
        pulumi.set(__self__, "x_path_queries", x_path_queries)

    @property
    @pulumi.getter
    def name(self) -> pulumi.Input[str]:
        """
        A friendly name for the data source. 
        This name should be unique across all data sources (regardless of type) within the data collection rule.
        """
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: pulumi.Input[str]):
        pulumi.set(self, "name", value)

    @property
    @pulumi.getter(name="scheduledTransferPeriod")
    def scheduled_transfer_period(self) -> pulumi.Input[str]:
        """
        The interval between data uploads (scheduled transfers), rounded up to the nearest minute.
        """
        return pulumi.get(self, "scheduled_transfer_period")

    @scheduled_transfer_period.setter
    def scheduled_transfer_period(self, value: pulumi.Input[str]):
        pulumi.set(self, "scheduled_transfer_period", value)

    @property
    @pulumi.getter
    def streams(self) -> pulumi.Input[Sequence[pulumi.Input[str]]]:
        """
        List of streams that this data source will be sent to.
        A stream indicates what schema will be used for this data and usually what table in Log Analytics the data will be sent to.
        """
        return pulumi.get(self, "streams")

    @streams.setter
    def streams(self, value: pulumi.Input[Sequence[pulumi.Input[str]]]):
        pulumi.set(self, "streams", value)

    @property
    @pulumi.getter(name="xPathQueries")
    def x_path_queries(self) -> pulumi.Input[Sequence[pulumi.Input[str]]]:
        """
        A list of Windows Event Log queries in XPATH format.
        """
        return pulumi.get(self, "x_path_queries")

    @x_path_queries.setter
    def x_path_queries(self, value: pulumi.Input[Sequence[pulumi.Input[str]]]):
        pulumi.set(self, "x_path_queries", value)


