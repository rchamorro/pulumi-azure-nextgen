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

__all__ = ['RecordSet']


class RecordSet(pulumi.CustomResource):
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 a_records: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['ARecordArgs']]]]] = None,
                 aaaa_records: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['AaaaRecordArgs']]]]] = None,
                 caa_records: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['CaaRecordArgs']]]]] = None,
                 cname_record: Optional[pulumi.Input[pulumi.InputType['CnameRecordArgs']]] = None,
                 etag: Optional[pulumi.Input[str]] = None,
                 metadata: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
                 mx_records: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['MxRecordArgs']]]]] = None,
                 ns_records: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['NsRecordArgs']]]]] = None,
                 ptr_records: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['PtrRecordArgs']]]]] = None,
                 record_type: Optional[pulumi.Input[str]] = None,
                 relative_record_set_name: Optional[pulumi.Input[str]] = None,
                 resource_group_name: Optional[pulumi.Input[str]] = None,
                 soa_record: Optional[pulumi.Input[pulumi.InputType['SoaRecordArgs']]] = None,
                 srv_records: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['SrvRecordArgs']]]]] = None,
                 ttl: Optional[pulumi.Input[float]] = None,
                 txt_records: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['TxtRecordArgs']]]]] = None,
                 zone_name: Optional[pulumi.Input[str]] = None,
                 __props__=None,
                 __name__=None,
                 __opts__=None):
        """
        Describes a DNS record set (a collection of DNS records with the same name and type).

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['ARecordArgs']]]] a_records: The list of A records in the record set.
        :param pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['AaaaRecordArgs']]]] aaaa_records: The list of AAAA records in the record set.
        :param pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['CaaRecordArgs']]]] caa_records: The list of CAA records in the record set.
        :param pulumi.Input[pulumi.InputType['CnameRecordArgs']] cname_record: The CNAME record in the  record set.
        :param pulumi.Input[str] etag: The etag of the record set.
        :param pulumi.Input[Mapping[str, pulumi.Input[str]]] metadata: The metadata attached to the record set.
        :param pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['MxRecordArgs']]]] mx_records: The list of MX records in the record set.
        :param pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['NsRecordArgs']]]] ns_records: The list of NS records in the record set.
        :param pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['PtrRecordArgs']]]] ptr_records: The list of PTR records in the record set.
        :param pulumi.Input[str] record_type: The type of DNS record in this record set. Record sets of type SOA can be updated but not created (they are created when the DNS zone is created).
        :param pulumi.Input[str] relative_record_set_name: The name of the record set, relative to the name of the zone.
        :param pulumi.Input[str] resource_group_name: The name of the resource group. The name is case insensitive.
        :param pulumi.Input[pulumi.InputType['SoaRecordArgs']] soa_record: The SOA record in the record set.
        :param pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['SrvRecordArgs']]]] srv_records: The list of SRV records in the record set.
        :param pulumi.Input[float] ttl: The TTL (time-to-live) of the records in the record set.
        :param pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['TxtRecordArgs']]]] txt_records: The list of TXT records in the record set.
        :param pulumi.Input[str] zone_name: The name of the DNS zone (without a terminating dot).
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

            __props__['a_records'] = a_records
            __props__['aaaa_records'] = aaaa_records
            __props__['caa_records'] = caa_records
            __props__['cname_record'] = cname_record
            __props__['etag'] = etag
            __props__['metadata'] = metadata
            __props__['mx_records'] = mx_records
            __props__['ns_records'] = ns_records
            __props__['ptr_records'] = ptr_records
            if record_type is None and not opts.urn:
                raise TypeError("Missing required property 'record_type'")
            __props__['record_type'] = record_type
            if relative_record_set_name is None and not opts.urn:
                raise TypeError("Missing required property 'relative_record_set_name'")
            __props__['relative_record_set_name'] = relative_record_set_name
            if resource_group_name is None and not opts.urn:
                raise TypeError("Missing required property 'resource_group_name'")
            __props__['resource_group_name'] = resource_group_name
            __props__['soa_record'] = soa_record
            __props__['srv_records'] = srv_records
            __props__['ttl'] = ttl
            __props__['txt_records'] = txt_records
            if zone_name is None and not opts.urn:
                raise TypeError("Missing required property 'zone_name'")
            __props__['zone_name'] = zone_name
            __props__['fqdn'] = None
            __props__['name'] = None
            __props__['type'] = None
        alias_opts = pulumi.ResourceOptions(aliases=[pulumi.Alias(type_="azure-nextgen:network/v20150504preview:RecordSet"), pulumi.Alias(type_="azure-nextgen:network/v20160401:RecordSet"), pulumi.Alias(type_="azure-nextgen:network/v20170901:RecordSet"), pulumi.Alias(type_="azure-nextgen:network/v20171001:RecordSet"), pulumi.Alias(type_="azure-nextgen:network/v20180501:RecordSet")])
        opts = pulumi.ResourceOptions.merge(opts, alias_opts)
        super(RecordSet, __self__).__init__(
            'azure-nextgen:network/v20180301preview:RecordSet',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None) -> 'RecordSet':
        """
        Get an existing RecordSet resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = dict()

        return RecordSet(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="aRecords")
    def a_records(self) -> pulumi.Output[Optional[Sequence['outputs.ARecordResponse']]]:
        """
        The list of A records in the record set.
        """
        return pulumi.get(self, "a_records")

    @property
    @pulumi.getter(name="aaaaRecords")
    def aaaa_records(self) -> pulumi.Output[Optional[Sequence['outputs.AaaaRecordResponse']]]:
        """
        The list of AAAA records in the record set.
        """
        return pulumi.get(self, "aaaa_records")

    @property
    @pulumi.getter(name="caaRecords")
    def caa_records(self) -> pulumi.Output[Optional[Sequence['outputs.CaaRecordResponse']]]:
        """
        The list of CAA records in the record set.
        """
        return pulumi.get(self, "caa_records")

    @property
    @pulumi.getter(name="cnameRecord")
    def cname_record(self) -> pulumi.Output[Optional['outputs.CnameRecordResponse']]:
        """
        The CNAME record in the  record set.
        """
        return pulumi.get(self, "cname_record")

    @property
    @pulumi.getter
    def etag(self) -> pulumi.Output[Optional[str]]:
        """
        The etag of the record set.
        """
        return pulumi.get(self, "etag")

    @property
    @pulumi.getter
    def fqdn(self) -> pulumi.Output[str]:
        """
        Fully qualified domain name of the record set.
        """
        return pulumi.get(self, "fqdn")

    @property
    @pulumi.getter
    def metadata(self) -> pulumi.Output[Optional[Mapping[str, str]]]:
        """
        The metadata attached to the record set.
        """
        return pulumi.get(self, "metadata")

    @property
    @pulumi.getter(name="mxRecords")
    def mx_records(self) -> pulumi.Output[Optional[Sequence['outputs.MxRecordResponse']]]:
        """
        The list of MX records in the record set.
        """
        return pulumi.get(self, "mx_records")

    @property
    @pulumi.getter
    def name(self) -> pulumi.Output[str]:
        """
        The name of the record set.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="nsRecords")
    def ns_records(self) -> pulumi.Output[Optional[Sequence['outputs.NsRecordResponse']]]:
        """
        The list of NS records in the record set.
        """
        return pulumi.get(self, "ns_records")

    @property
    @pulumi.getter(name="ptrRecords")
    def ptr_records(self) -> pulumi.Output[Optional[Sequence['outputs.PtrRecordResponse']]]:
        """
        The list of PTR records in the record set.
        """
        return pulumi.get(self, "ptr_records")

    @property
    @pulumi.getter(name="soaRecord")
    def soa_record(self) -> pulumi.Output[Optional['outputs.SoaRecordResponse']]:
        """
        The SOA record in the record set.
        """
        return pulumi.get(self, "soa_record")

    @property
    @pulumi.getter(name="srvRecords")
    def srv_records(self) -> pulumi.Output[Optional[Sequence['outputs.SrvRecordResponse']]]:
        """
        The list of SRV records in the record set.
        """
        return pulumi.get(self, "srv_records")

    @property
    @pulumi.getter
    def ttl(self) -> pulumi.Output[Optional[float]]:
        """
        The TTL (time-to-live) of the records in the record set.
        """
        return pulumi.get(self, "ttl")

    @property
    @pulumi.getter(name="txtRecords")
    def txt_records(self) -> pulumi.Output[Optional[Sequence['outputs.TxtRecordResponse']]]:
        """
        The list of TXT records in the record set.
        """
        return pulumi.get(self, "txt_records")

    @property
    @pulumi.getter
    def type(self) -> pulumi.Output[str]:
        """
        The type of the record set.
        """
        return pulumi.get(self, "type")

    def translate_output_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return _tables.SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop

