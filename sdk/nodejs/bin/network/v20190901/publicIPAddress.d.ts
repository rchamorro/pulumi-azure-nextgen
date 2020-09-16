import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../../types/input";
import * as outputs from "../../types/output";
/**
 * Public IP address resource.
 */
export declare class PublicIPAddress extends pulumi.CustomResource {
    /**
     * Get an existing PublicIPAddress resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): PublicIPAddress;
    /**
     * Returns true if the given object is an instance of PublicIPAddress.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    static isInstance(obj: any): obj is PublicIPAddress;
    /**
     * The DDoS protection custom policy associated with the public IP address.
     */
    readonly ddosSettings: pulumi.Output<outputs.network.v20190901.DdosSettingsResponse | undefined>;
    /**
     * The FQDN of the DNS record associated with the public IP address.
     */
    readonly dnsSettings: pulumi.Output<outputs.network.v20190901.PublicIPAddressDnsSettingsResponse | undefined>;
    /**
     * A unique read-only string that changes whenever the resource is updated.
     */
    readonly etag: pulumi.Output<string>;
    /**
     * The idle timeout of the public IP address.
     */
    readonly idleTimeoutInMinutes: pulumi.Output<number | undefined>;
    /**
     * The IP address associated with the public IP address resource.
     */
    readonly ipAddress: pulumi.Output<string | undefined>;
    /**
     * The IP configuration associated with the public IP address.
     */
    readonly ipConfiguration: pulumi.Output<outputs.network.v20190901.IPConfigurationResponse>;
    /**
     * The list of tags associated with the public IP address.
     */
    readonly ipTags: pulumi.Output<outputs.network.v20190901.IpTagResponse[] | undefined>;
    /**
     * Resource location.
     */
    readonly location: pulumi.Output<string | undefined>;
    /**
     * Resource name.
     */
    readonly name: pulumi.Output<string>;
    /**
     * The provisioning state of the public IP address resource.
     */
    readonly provisioningState: pulumi.Output<string>;
    /**
     * The public IP address version.
     */
    readonly publicIPAddressVersion: pulumi.Output<string | undefined>;
    /**
     * The public IP address allocation method.
     */
    readonly publicIPAllocationMethod: pulumi.Output<string | undefined>;
    /**
     * The Public IP Prefix this Public IP Address should be allocated from.
     */
    readonly publicIPPrefix: pulumi.Output<outputs.network.v20190901.SubResourceResponse | undefined>;
    /**
     * The resource GUID property of the public IP address resource.
     */
    readonly resourceGuid: pulumi.Output<string>;
    /**
     * The public IP address SKU.
     */
    readonly sku: pulumi.Output<outputs.network.v20190901.PublicIPAddressSkuResponse | undefined>;
    /**
     * Resource tags.
     */
    readonly tags: pulumi.Output<{
        [key: string]: string;
    } | undefined>;
    /**
     * Resource type.
     */
    readonly type: pulumi.Output<string>;
    /**
     * A list of availability zones denoting the IP allocated for the resource needs to come from.
     */
    readonly zones: pulumi.Output<string[] | undefined>;
    /**
     * Create a PublicIPAddress resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: PublicIPAddressArgs, opts?: pulumi.CustomResourceOptions);
    constructor(name: string, state: undefined, opts: pulumi.CustomResourceOptions);
}
/**
 * The set of arguments for constructing a PublicIPAddress resource.
 */
export interface PublicIPAddressArgs {
    /**
     * The DDoS protection custom policy associated with the public IP address.
     */
    readonly ddosSettings?: pulumi.Input<inputs.network.v20190901.DdosSettings>;
    /**
     * The FQDN of the DNS record associated with the public IP address.
     */
    readonly dnsSettings?: pulumi.Input<inputs.network.v20190901.PublicIPAddressDnsSettings>;
    /**
     * Resource ID.
     */
    readonly id?: pulumi.Input<string>;
    /**
     * The idle timeout of the public IP address.
     */
    readonly idleTimeoutInMinutes?: pulumi.Input<number>;
    /**
     * The IP address associated with the public IP address resource.
     */
    readonly ipAddress?: pulumi.Input<string>;
    /**
     * The list of tags associated with the public IP address.
     */
    readonly ipTags?: pulumi.Input<pulumi.Input<inputs.network.v20190901.IpTag>[]>;
    /**
     * Resource location.
     */
    readonly location?: pulumi.Input<string>;
    /**
     * The public IP address version.
     */
    readonly publicIPAddressVersion?: pulumi.Input<string>;
    /**
     * The public IP address allocation method.
     */
    readonly publicIPAllocationMethod?: pulumi.Input<string>;
    /**
     * The Public IP Prefix this Public IP Address should be allocated from.
     */
    readonly publicIPPrefix?: pulumi.Input<inputs.network.v20190901.SubResource>;
    /**
     * The name of the public IP address.
     */
    readonly publicIpAddressName: pulumi.Input<string>;
    /**
     * The name of the resource group.
     */
    readonly resourceGroupName: pulumi.Input<string>;
    /**
     * The public IP address SKU.
     */
    readonly sku?: pulumi.Input<inputs.network.v20190901.PublicIPAddressSku>;
    /**
     * Resource tags.
     */
    readonly tags?: pulumi.Input<{
        [key: string]: pulumi.Input<string>;
    }>;
    /**
     * A list of availability zones denoting the IP allocated for the resource needs to come from.
     */
    readonly zones?: pulumi.Input<pulumi.Input<string>[]>;
}