# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union
from ... import _utilities, _tables

__all__ = [
    'ARecordArgs',
    'AaaaRecordArgs',
    'CnameRecordArgs',
    'MxRecordArgs',
    'NsRecordArgs',
    'PtrRecordArgs',
    'RecordSetPropertiesArgs',
    'SoaRecordArgs',
    'SrvRecordArgs',
    'TxtRecordArgs',
    'ZonePropertiesArgs',
]

@pulumi.input_type
class ARecordArgs:
    def __init__(__self__, *,
                 ipv4_address: Optional[pulumi.Input[str]] = None):
        """
        An A record.
        :param pulumi.Input[str] ipv4_address: Gets or sets the IPv4 address of this A record in string notation.
        """
        if ipv4_address is not None:
            pulumi.set(__self__, "ipv4_address", ipv4_address)

    @property
    @pulumi.getter(name="ipv4Address")
    def ipv4_address(self) -> Optional[pulumi.Input[str]]:
        """
        Gets or sets the IPv4 address of this A record in string notation.
        """
        return pulumi.get(self, "ipv4_address")

    @ipv4_address.setter
    def ipv4_address(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "ipv4_address", value)


@pulumi.input_type
class AaaaRecordArgs:
    def __init__(__self__, *,
                 ipv6_address: Optional[pulumi.Input[str]] = None):
        """
        An AAAA record.
        :param pulumi.Input[str] ipv6_address: Gets or sets the IPv6 address of this AAAA record in string notation.
        """
        if ipv6_address is not None:
            pulumi.set(__self__, "ipv6_address", ipv6_address)

    @property
    @pulumi.getter(name="ipv6Address")
    def ipv6_address(self) -> Optional[pulumi.Input[str]]:
        """
        Gets or sets the IPv6 address of this AAAA record in string notation.
        """
        return pulumi.get(self, "ipv6_address")

    @ipv6_address.setter
    def ipv6_address(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "ipv6_address", value)


@pulumi.input_type
class CnameRecordArgs:
    def __init__(__self__, *,
                 cname: Optional[pulumi.Input[str]] = None):
        """
        A CNAME record.
        :param pulumi.Input[str] cname: Gets or sets the canonical name for this record without a terminating dot.
        """
        if cname is not None:
            pulumi.set(__self__, "cname", cname)

    @property
    @pulumi.getter
    def cname(self) -> Optional[pulumi.Input[str]]:
        """
        Gets or sets the canonical name for this record without a terminating dot.
        """
        return pulumi.get(self, "cname")

    @cname.setter
    def cname(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "cname", value)


@pulumi.input_type
class MxRecordArgs:
    def __init__(__self__, *,
                 exchange: Optional[pulumi.Input[str]] = None,
                 preference: Optional[pulumi.Input[int]] = None):
        """
        An MX record.
        :param pulumi.Input[str] exchange: Gets or sets the domain name of the mail host, without a terminating dot.
        :param pulumi.Input[int] preference: Gets or sets the preference metric for this record.
        """
        if exchange is not None:
            pulumi.set(__self__, "exchange", exchange)
        if preference is not None:
            pulumi.set(__self__, "preference", preference)

    @property
    @pulumi.getter
    def exchange(self) -> Optional[pulumi.Input[str]]:
        """
        Gets or sets the domain name of the mail host, without a terminating dot.
        """
        return pulumi.get(self, "exchange")

    @exchange.setter
    def exchange(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "exchange", value)

    @property
    @pulumi.getter
    def preference(self) -> Optional[pulumi.Input[int]]:
        """
        Gets or sets the preference metric for this record.
        """
        return pulumi.get(self, "preference")

    @preference.setter
    def preference(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "preference", value)


@pulumi.input_type
class NsRecordArgs:
    def __init__(__self__, *,
                 nsdname: Optional[pulumi.Input[str]] = None):
        """
        An NS record.
        :param pulumi.Input[str] nsdname: Gets or sets the name server name for this record, without a terminating dot.
        """
        if nsdname is not None:
            pulumi.set(__self__, "nsdname", nsdname)

    @property
    @pulumi.getter
    def nsdname(self) -> Optional[pulumi.Input[str]]:
        """
        Gets or sets the name server name for this record, without a terminating dot.
        """
        return pulumi.get(self, "nsdname")

    @nsdname.setter
    def nsdname(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "nsdname", value)


@pulumi.input_type
class PtrRecordArgs:
    def __init__(__self__, *,
                 ptrdname: Optional[pulumi.Input[str]] = None):
        """
        A PTR record.
        :param pulumi.Input[str] ptrdname: Gets or sets the PTR target domain name for this record without a terminating dot.
        """
        if ptrdname is not None:
            pulumi.set(__self__, "ptrdname", ptrdname)

    @property
    @pulumi.getter
    def ptrdname(self) -> Optional[pulumi.Input[str]]:
        """
        Gets or sets the PTR target domain name for this record without a terminating dot.
        """
        return pulumi.get(self, "ptrdname")

    @ptrdname.setter
    def ptrdname(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "ptrdname", value)


@pulumi.input_type
class RecordSetPropertiesArgs:
    def __init__(__self__, *,
                 a_aaa_records: Optional[pulumi.Input[Sequence[pulumi.Input['AaaaRecordArgs']]]] = None,
                 a_records: Optional[pulumi.Input[Sequence[pulumi.Input['ARecordArgs']]]] = None,
                 c_name_record: Optional[pulumi.Input['CnameRecordArgs']] = None,
                 m_x_records: Optional[pulumi.Input[Sequence[pulumi.Input['MxRecordArgs']]]] = None,
                 n_s_records: Optional[pulumi.Input[Sequence[pulumi.Input['NsRecordArgs']]]] = None,
                 p_tr_records: Optional[pulumi.Input[Sequence[pulumi.Input['PtrRecordArgs']]]] = None,
                 s_oa_record: Optional[pulumi.Input['SoaRecordArgs']] = None,
                 s_rv_records: Optional[pulumi.Input[Sequence[pulumi.Input['SrvRecordArgs']]]] = None,
                 t_xt_records: Optional[pulumi.Input[Sequence[pulumi.Input['TxtRecordArgs']]]] = None,
                 ttl: Optional[pulumi.Input[float]] = None):
        """
        Represents the properties of the records in the RecordSet.
        :param pulumi.Input[Sequence[pulumi.Input['AaaaRecordArgs']]] a_aaa_records: Gets or sets the list of AAAA records in the RecordSet.
        :param pulumi.Input[Sequence[pulumi.Input['ARecordArgs']]] a_records: Gets or sets the list of A records in the RecordSet.
        :param pulumi.Input['CnameRecordArgs'] c_name_record: Gets or sets the CNAME record in the RecordSet.
        :param pulumi.Input[Sequence[pulumi.Input['MxRecordArgs']]] m_x_records: Gets or sets the list of MX records in the RecordSet.
        :param pulumi.Input[Sequence[pulumi.Input['NsRecordArgs']]] n_s_records: Gets or sets the list of NS records in the RecordSet.
        :param pulumi.Input[Sequence[pulumi.Input['PtrRecordArgs']]] p_tr_records: Gets or sets the list of PTR records in the RecordSet.
        :param pulumi.Input['SoaRecordArgs'] s_oa_record: Gets or sets the SOA record in the RecordSet.
        :param pulumi.Input[Sequence[pulumi.Input['SrvRecordArgs']]] s_rv_records: Gets or sets the list of SRV records in the RecordSet.
        :param pulumi.Input[Sequence[pulumi.Input['TxtRecordArgs']]] t_xt_records: Gets or sets the list of TXT records in the RecordSet.
        :param pulumi.Input[float] ttl: Gets or sets the TTL of the records in the RecordSet.
        """
        if a_aaa_records is not None:
            pulumi.set(__self__, "a_aaa_records", a_aaa_records)
        if a_records is not None:
            pulumi.set(__self__, "a_records", a_records)
        if c_name_record is not None:
            pulumi.set(__self__, "c_name_record", c_name_record)
        if m_x_records is not None:
            pulumi.set(__self__, "m_x_records", m_x_records)
        if n_s_records is not None:
            pulumi.set(__self__, "n_s_records", n_s_records)
        if p_tr_records is not None:
            pulumi.set(__self__, "p_tr_records", p_tr_records)
        if s_oa_record is not None:
            pulumi.set(__self__, "s_oa_record", s_oa_record)
        if s_rv_records is not None:
            pulumi.set(__self__, "s_rv_records", s_rv_records)
        if t_xt_records is not None:
            pulumi.set(__self__, "t_xt_records", t_xt_records)
        if ttl is not None:
            pulumi.set(__self__, "ttl", ttl)

    @property
    @pulumi.getter(name="aAAARecords")
    def a_aaa_records(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['AaaaRecordArgs']]]]:
        """
        Gets or sets the list of AAAA records in the RecordSet.
        """
        return pulumi.get(self, "a_aaa_records")

    @a_aaa_records.setter
    def a_aaa_records(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['AaaaRecordArgs']]]]):
        pulumi.set(self, "a_aaa_records", value)

    @property
    @pulumi.getter(name="aRecords")
    def a_records(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['ARecordArgs']]]]:
        """
        Gets or sets the list of A records in the RecordSet.
        """
        return pulumi.get(self, "a_records")

    @a_records.setter
    def a_records(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['ARecordArgs']]]]):
        pulumi.set(self, "a_records", value)

    @property
    @pulumi.getter(name="cNAMERecord")
    def c_name_record(self) -> Optional[pulumi.Input['CnameRecordArgs']]:
        """
        Gets or sets the CNAME record in the RecordSet.
        """
        return pulumi.get(self, "c_name_record")

    @c_name_record.setter
    def c_name_record(self, value: Optional[pulumi.Input['CnameRecordArgs']]):
        pulumi.set(self, "c_name_record", value)

    @property
    @pulumi.getter(name="mXRecords")
    def m_x_records(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['MxRecordArgs']]]]:
        """
        Gets or sets the list of MX records in the RecordSet.
        """
        return pulumi.get(self, "m_x_records")

    @m_x_records.setter
    def m_x_records(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['MxRecordArgs']]]]):
        pulumi.set(self, "m_x_records", value)

    @property
    @pulumi.getter(name="nSRecords")
    def n_s_records(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['NsRecordArgs']]]]:
        """
        Gets or sets the list of NS records in the RecordSet.
        """
        return pulumi.get(self, "n_s_records")

    @n_s_records.setter
    def n_s_records(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['NsRecordArgs']]]]):
        pulumi.set(self, "n_s_records", value)

    @property
    @pulumi.getter(name="pTRRecords")
    def p_tr_records(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['PtrRecordArgs']]]]:
        """
        Gets or sets the list of PTR records in the RecordSet.
        """
        return pulumi.get(self, "p_tr_records")

    @p_tr_records.setter
    def p_tr_records(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['PtrRecordArgs']]]]):
        pulumi.set(self, "p_tr_records", value)

    @property
    @pulumi.getter(name="sOARecord")
    def s_oa_record(self) -> Optional[pulumi.Input['SoaRecordArgs']]:
        """
        Gets or sets the SOA record in the RecordSet.
        """
        return pulumi.get(self, "s_oa_record")

    @s_oa_record.setter
    def s_oa_record(self, value: Optional[pulumi.Input['SoaRecordArgs']]):
        pulumi.set(self, "s_oa_record", value)

    @property
    @pulumi.getter(name="sRVRecords")
    def s_rv_records(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['SrvRecordArgs']]]]:
        """
        Gets or sets the list of SRV records in the RecordSet.
        """
        return pulumi.get(self, "s_rv_records")

    @s_rv_records.setter
    def s_rv_records(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['SrvRecordArgs']]]]):
        pulumi.set(self, "s_rv_records", value)

    @property
    @pulumi.getter(name="tXTRecords")
    def t_xt_records(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['TxtRecordArgs']]]]:
        """
        Gets or sets the list of TXT records in the RecordSet.
        """
        return pulumi.get(self, "t_xt_records")

    @t_xt_records.setter
    def t_xt_records(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['TxtRecordArgs']]]]):
        pulumi.set(self, "t_xt_records", value)

    @property
    @pulumi.getter
    def ttl(self) -> Optional[pulumi.Input[float]]:
        """
        Gets or sets the TTL of the records in the RecordSet.
        """
        return pulumi.get(self, "ttl")

    @ttl.setter
    def ttl(self, value: Optional[pulumi.Input[float]]):
        pulumi.set(self, "ttl", value)


@pulumi.input_type
class SoaRecordArgs:
    def __init__(__self__, *,
                 email: Optional[pulumi.Input[str]] = None,
                 expire_time: Optional[pulumi.Input[float]] = None,
                 host: Optional[pulumi.Input[str]] = None,
                 minimum_ttl: Optional[pulumi.Input[float]] = None,
                 refresh_time: Optional[pulumi.Input[float]] = None,
                 retry_time: Optional[pulumi.Input[float]] = None,
                 serial_number: Optional[pulumi.Input[float]] = None):
        """
        An SOA record.
        :param pulumi.Input[str] email: Gets or sets the email for this record.
        :param pulumi.Input[float] expire_time: Gets or sets the expire time for this record.
        :param pulumi.Input[str] host: Gets or sets the domain name of the authoritative name server, without a terminating dot.
        :param pulumi.Input[float] minimum_ttl: Gets or sets the minimum TTL value for this record.
        :param pulumi.Input[float] refresh_time: Gets or sets the refresh value for this record.
        :param pulumi.Input[float] retry_time: Gets or sets the retry time for this record.
        :param pulumi.Input[float] serial_number: Gets or sets the serial number for this record.
        """
        if email is not None:
            pulumi.set(__self__, "email", email)
        if expire_time is not None:
            pulumi.set(__self__, "expire_time", expire_time)
        if host is not None:
            pulumi.set(__self__, "host", host)
        if minimum_ttl is not None:
            pulumi.set(__self__, "minimum_ttl", minimum_ttl)
        if refresh_time is not None:
            pulumi.set(__self__, "refresh_time", refresh_time)
        if retry_time is not None:
            pulumi.set(__self__, "retry_time", retry_time)
        if serial_number is not None:
            pulumi.set(__self__, "serial_number", serial_number)

    @property
    @pulumi.getter
    def email(self) -> Optional[pulumi.Input[str]]:
        """
        Gets or sets the email for this record.
        """
        return pulumi.get(self, "email")

    @email.setter
    def email(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "email", value)

    @property
    @pulumi.getter(name="expireTime")
    def expire_time(self) -> Optional[pulumi.Input[float]]:
        """
        Gets or sets the expire time for this record.
        """
        return pulumi.get(self, "expire_time")

    @expire_time.setter
    def expire_time(self, value: Optional[pulumi.Input[float]]):
        pulumi.set(self, "expire_time", value)

    @property
    @pulumi.getter
    def host(self) -> Optional[pulumi.Input[str]]:
        """
        Gets or sets the domain name of the authoritative name server, without a terminating dot.
        """
        return pulumi.get(self, "host")

    @host.setter
    def host(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "host", value)

    @property
    @pulumi.getter(name="minimumTTL")
    def minimum_ttl(self) -> Optional[pulumi.Input[float]]:
        """
        Gets or sets the minimum TTL value for this record.
        """
        return pulumi.get(self, "minimum_ttl")

    @minimum_ttl.setter
    def minimum_ttl(self, value: Optional[pulumi.Input[float]]):
        pulumi.set(self, "minimum_ttl", value)

    @property
    @pulumi.getter(name="refreshTime")
    def refresh_time(self) -> Optional[pulumi.Input[float]]:
        """
        Gets or sets the refresh value for this record.
        """
        return pulumi.get(self, "refresh_time")

    @refresh_time.setter
    def refresh_time(self, value: Optional[pulumi.Input[float]]):
        pulumi.set(self, "refresh_time", value)

    @property
    @pulumi.getter(name="retryTime")
    def retry_time(self) -> Optional[pulumi.Input[float]]:
        """
        Gets or sets the retry time for this record.
        """
        return pulumi.get(self, "retry_time")

    @retry_time.setter
    def retry_time(self, value: Optional[pulumi.Input[float]]):
        pulumi.set(self, "retry_time", value)

    @property
    @pulumi.getter(name="serialNumber")
    def serial_number(self) -> Optional[pulumi.Input[float]]:
        """
        Gets or sets the serial number for this record.
        """
        return pulumi.get(self, "serial_number")

    @serial_number.setter
    def serial_number(self, value: Optional[pulumi.Input[float]]):
        pulumi.set(self, "serial_number", value)


@pulumi.input_type
class SrvRecordArgs:
    def __init__(__self__, *,
                 port: Optional[pulumi.Input[int]] = None,
                 priority: Optional[pulumi.Input[int]] = None,
                 target: Optional[pulumi.Input[str]] = None,
                 weight: Optional[pulumi.Input[int]] = None):
        """
        An SRV record.
        :param pulumi.Input[int] port: Gets or sets the port of the service for this record.
        :param pulumi.Input[int] priority: Gets or sets the priority metric for this record.
        :param pulumi.Input[str] target: Gets or sets the domain name of the target for this record, without a terminating dot.
        :param pulumi.Input[int] weight: Gets or sets the weight metric for this record.
        """
        if port is not None:
            pulumi.set(__self__, "port", port)
        if priority is not None:
            pulumi.set(__self__, "priority", priority)
        if target is not None:
            pulumi.set(__self__, "target", target)
        if weight is not None:
            pulumi.set(__self__, "weight", weight)

    @property
    @pulumi.getter
    def port(self) -> Optional[pulumi.Input[int]]:
        """
        Gets or sets the port of the service for this record.
        """
        return pulumi.get(self, "port")

    @port.setter
    def port(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "port", value)

    @property
    @pulumi.getter
    def priority(self) -> Optional[pulumi.Input[int]]:
        """
        Gets or sets the priority metric for this record.
        """
        return pulumi.get(self, "priority")

    @priority.setter
    def priority(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "priority", value)

    @property
    @pulumi.getter
    def target(self) -> Optional[pulumi.Input[str]]:
        """
        Gets or sets the domain name of the target for this record, without a terminating dot.
        """
        return pulumi.get(self, "target")

    @target.setter
    def target(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "target", value)

    @property
    @pulumi.getter
    def weight(self) -> Optional[pulumi.Input[int]]:
        """
        Gets or sets the weight metric for this record.
        """
        return pulumi.get(self, "weight")

    @weight.setter
    def weight(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "weight", value)


@pulumi.input_type
class TxtRecordArgs:
    def __init__(__self__, *,
                 value: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None):
        """
        A TXT record.
        :param pulumi.Input[Sequence[pulumi.Input[str]]] value: Gets or sets the text value of this record.
        """
        if value is not None:
            pulumi.set(__self__, "value", value)

    @property
    @pulumi.getter
    def value(self) -> Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]:
        """
        Gets or sets the text value of this record.
        """
        return pulumi.get(self, "value")

    @value.setter
    def value(self, value: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]):
        pulumi.set(self, "value", value)


@pulumi.input_type
class ZonePropertiesArgs:
    def __init__(__self__, *,
                 max_number_of_record_sets: Optional[pulumi.Input[float]] = None,
                 number_of_record_sets: Optional[pulumi.Input[float]] = None):
        """
        Represents the properties of the zone.
        :param pulumi.Input[float] max_number_of_record_sets: Gets or sets the maximum number of record sets that can be created in this zone.
        :param pulumi.Input[float] number_of_record_sets: Gets or sets the current number of record sets in this zone.
        """
        if max_number_of_record_sets is not None:
            pulumi.set(__self__, "max_number_of_record_sets", max_number_of_record_sets)
        if number_of_record_sets is not None:
            pulumi.set(__self__, "number_of_record_sets", number_of_record_sets)

    @property
    @pulumi.getter(name="maxNumberOfRecordSets")
    def max_number_of_record_sets(self) -> Optional[pulumi.Input[float]]:
        """
        Gets or sets the maximum number of record sets that can be created in this zone.
        """
        return pulumi.get(self, "max_number_of_record_sets")

    @max_number_of_record_sets.setter
    def max_number_of_record_sets(self, value: Optional[pulumi.Input[float]]):
        pulumi.set(self, "max_number_of_record_sets", value)

    @property
    @pulumi.getter(name="numberOfRecordSets")
    def number_of_record_sets(self) -> Optional[pulumi.Input[float]]:
        """
        Gets or sets the current number of record sets in this zone.
        """
        return pulumi.get(self, "number_of_record_sets")

    @number_of_record_sets.setter
    def number_of_record_sets(self, value: Optional[pulumi.Input[float]]):
        pulumi.set(self, "number_of_record_sets", value)


