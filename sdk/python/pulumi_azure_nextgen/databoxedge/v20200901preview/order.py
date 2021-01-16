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

__all__ = ['Order']


class Order(pulumi.CustomResource):
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 contact_information: Optional[pulumi.Input[pulumi.InputType['ContactDetailsArgs']]] = None,
                 current_status: Optional[pulumi.Input[pulumi.InputType['OrderStatusArgs']]] = None,
                 device_name: Optional[pulumi.Input[str]] = None,
                 resource_group_name: Optional[pulumi.Input[str]] = None,
                 shipment_type: Optional[pulumi.Input[Union[str, 'ShipmentType']]] = None,
                 shipping_address: Optional[pulumi.Input[pulumi.InputType['AddressArgs']]] = None,
                 __props__=None,
                 __name__=None,
                 __opts__=None):
        """
        The order details.

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[pulumi.InputType['ContactDetailsArgs']] contact_information: The contact details.
        :param pulumi.Input[pulumi.InputType['OrderStatusArgs']] current_status: Current status of the order.
        :param pulumi.Input[str] device_name: The order details of a device.
        :param pulumi.Input[str] resource_group_name: The resource group name.
        :param pulumi.Input[Union[str, 'ShipmentType']] shipment_type: ShipmentType of the order
        :param pulumi.Input[pulumi.InputType['AddressArgs']] shipping_address: The shipping address.
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

            if contact_information is None and not opts.urn:
                raise TypeError("Missing required property 'contact_information'")
            __props__['contact_information'] = contact_information
            __props__['current_status'] = current_status
            if device_name is None and not opts.urn:
                raise TypeError("Missing required property 'device_name'")
            __props__['device_name'] = device_name
            if resource_group_name is None and not opts.urn:
                raise TypeError("Missing required property 'resource_group_name'")
            __props__['resource_group_name'] = resource_group_name
            __props__['shipment_type'] = shipment_type
            __props__['shipping_address'] = shipping_address
            __props__['delivery_tracking_info'] = None
            __props__['name'] = None
            __props__['order_history'] = None
            __props__['return_tracking_info'] = None
            __props__['serial_number'] = None
            __props__['type'] = None
        alias_opts = pulumi.ResourceOptions(aliases=[pulumi.Alias(type_="azure-nextgen:databoxedge/latest:Order"), pulumi.Alias(type_="azure-nextgen:databoxedge/v20190301:Order"), pulumi.Alias(type_="azure-nextgen:databoxedge/v20190701:Order"), pulumi.Alias(type_="azure-nextgen:databoxedge/v20190801:Order"), pulumi.Alias(type_="azure-nextgen:databoxedge/v20200501preview:Order"), pulumi.Alias(type_="azure-nextgen:databoxedge/v20200901:Order")])
        opts = pulumi.ResourceOptions.merge(opts, alias_opts)
        super(Order, __self__).__init__(
            'azure-nextgen:databoxedge/v20200901preview:Order',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None) -> 'Order':
        """
        Get an existing Order resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = dict()

        return Order(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="contactInformation")
    def contact_information(self) -> pulumi.Output['outputs.ContactDetailsResponse']:
        """
        The contact details.
        """
        return pulumi.get(self, "contact_information")

    @property
    @pulumi.getter(name="currentStatus")
    def current_status(self) -> pulumi.Output[Optional['outputs.OrderStatusResponse']]:
        """
        Current status of the order.
        """
        return pulumi.get(self, "current_status")

    @property
    @pulumi.getter(name="deliveryTrackingInfo")
    def delivery_tracking_info(self) -> pulumi.Output[Sequence['outputs.TrackingInfoResponse']]:
        """
        Tracking information for the package delivered to the customer whether it has an original or a replacement device.
        """
        return pulumi.get(self, "delivery_tracking_info")

    @property
    @pulumi.getter
    def name(self) -> pulumi.Output[str]:
        """
        The object name.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="orderHistory")
    def order_history(self) -> pulumi.Output[Sequence['outputs.OrderStatusResponse']]:
        """
        List of status changes in the order.
        """
        return pulumi.get(self, "order_history")

    @property
    @pulumi.getter(name="returnTrackingInfo")
    def return_tracking_info(self) -> pulumi.Output[Sequence['outputs.TrackingInfoResponse']]:
        """
        Tracking information for the package returned from the customer whether it has an original or a replacement device.
        """
        return pulumi.get(self, "return_tracking_info")

    @property
    @pulumi.getter(name="serialNumber")
    def serial_number(self) -> pulumi.Output[str]:
        """
        Serial number of the device.
        """
        return pulumi.get(self, "serial_number")

    @property
    @pulumi.getter(name="shipmentType")
    def shipment_type(self) -> pulumi.Output[Optional[str]]:
        """
        ShipmentType of the order
        """
        return pulumi.get(self, "shipment_type")

    @property
    @pulumi.getter(name="shippingAddress")
    def shipping_address(self) -> pulumi.Output[Optional['outputs.AddressResponse']]:
        """
        The shipping address.
        """
        return pulumi.get(self, "shipping_address")

    @property
    @pulumi.getter
    def type(self) -> pulumi.Output[str]:
        """
        The hierarchical type of the object.
        """
        return pulumi.get(self, "type")

    def translate_output_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return _tables.SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop

