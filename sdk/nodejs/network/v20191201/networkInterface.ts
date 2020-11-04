// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../../types/input";
import * as outputs from "../../types/output";
import * as utilities from "../../utilities";

/**
 * A network interface in a resource group.
 */
export class NetworkInterface extends pulumi.CustomResource {
    /**
     * Get an existing NetworkInterface resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): NetworkInterface {
        return new NetworkInterface(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure-nextgen:network/v20191201:NetworkInterface';

    /**
     * Returns true if the given object is an instance of NetworkInterface.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is NetworkInterface {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === NetworkInterface.__pulumiType;
    }

    /**
     * The DNS settings in network interface.
     */
    public readonly dnsSettings!: pulumi.Output<outputs.network.v20191201.NetworkInterfaceDnsSettingsResponse | undefined>;
    /**
     * If the network interface is accelerated networking enabled.
     */
    public readonly enableAcceleratedNetworking!: pulumi.Output<boolean | undefined>;
    /**
     * Indicates whether IP forwarding is enabled on this network interface.
     */
    public readonly enableIPForwarding!: pulumi.Output<boolean | undefined>;
    /**
     * A unique read-only string that changes whenever the resource is updated.
     */
    public /*out*/ readonly etag!: pulumi.Output<string>;
    /**
     * A list of references to linked BareMetal resources.
     */
    public /*out*/ readonly hostedWorkloads!: pulumi.Output<string[]>;
    /**
     * A list of IPConfigurations of the network interface.
     */
    public readonly ipConfigurations!: pulumi.Output<outputs.network.v20191201.NetworkInterfaceIPConfigurationResponse[] | undefined>;
    /**
     * Resource location.
     */
    public readonly location!: pulumi.Output<string | undefined>;
    /**
     * The MAC address of the network interface.
     */
    public /*out*/ readonly macAddress!: pulumi.Output<string>;
    /**
     * Resource name.
     */
    public /*out*/ readonly name!: pulumi.Output<string>;
    /**
     * The reference to the NetworkSecurityGroup resource.
     */
    public readonly networkSecurityGroup!: pulumi.Output<outputs.network.v20191201.NetworkSecurityGroupResponse | undefined>;
    /**
     * Whether this is a primary network interface on a virtual machine.
     */
    public /*out*/ readonly primary!: pulumi.Output<boolean>;
    /**
     * A reference to the private endpoint to which the network interface is linked.
     */
    public /*out*/ readonly privateEndpoint!: pulumi.Output<outputs.network.v20191201.PrivateEndpointResponse>;
    /**
     * The provisioning state of the network interface resource.
     */
    public /*out*/ readonly provisioningState!: pulumi.Output<string>;
    /**
     * The resource GUID property of the network interface resource.
     */
    public /*out*/ readonly resourceGuid!: pulumi.Output<string>;
    /**
     * Resource tags.
     */
    public readonly tags!: pulumi.Output<{[key: string]: string} | undefined>;
    /**
     * A list of TapConfigurations of the network interface.
     */
    public /*out*/ readonly tapConfigurations!: pulumi.Output<outputs.network.v20191201.NetworkInterfaceTapConfigurationResponse[]>;
    /**
     * Resource type.
     */
    public /*out*/ readonly type!: pulumi.Output<string>;
    /**
     * The reference to a virtual machine.
     */
    public /*out*/ readonly virtualMachine!: pulumi.Output<outputs.network.v20191201.SubResourceResponse>;

    /**
     * Create a NetworkInterface resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: NetworkInterfaceArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (!(opts && opts.id)) {
            if (!args || args.networkInterfaceName === undefined) {
                throw new Error("Missing required property 'networkInterfaceName'");
            }
            if (!args || args.resourceGroupName === undefined) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            inputs["dnsSettings"] = args ? args.dnsSettings : undefined;
            inputs["enableAcceleratedNetworking"] = args ? args.enableAcceleratedNetworking : undefined;
            inputs["enableIPForwarding"] = args ? args.enableIPForwarding : undefined;
            inputs["id"] = args ? args.id : undefined;
            inputs["ipConfigurations"] = args ? args.ipConfigurations : undefined;
            inputs["location"] = args ? args.location : undefined;
            inputs["networkInterfaceName"] = args ? args.networkInterfaceName : undefined;
            inputs["networkSecurityGroup"] = args ? args.networkSecurityGroup : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            inputs["tags"] = args ? args.tags : undefined;
            inputs["etag"] = undefined /*out*/;
            inputs["hostedWorkloads"] = undefined /*out*/;
            inputs["macAddress"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["primary"] = undefined /*out*/;
            inputs["privateEndpoint"] = undefined /*out*/;
            inputs["provisioningState"] = undefined /*out*/;
            inputs["resourceGuid"] = undefined /*out*/;
            inputs["tapConfigurations"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
            inputs["virtualMachine"] = undefined /*out*/;
        } else {
            inputs["dnsSettings"] = undefined /*out*/;
            inputs["enableAcceleratedNetworking"] = undefined /*out*/;
            inputs["enableIPForwarding"] = undefined /*out*/;
            inputs["etag"] = undefined /*out*/;
            inputs["hostedWorkloads"] = undefined /*out*/;
            inputs["ipConfigurations"] = undefined /*out*/;
            inputs["location"] = undefined /*out*/;
            inputs["macAddress"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["networkSecurityGroup"] = undefined /*out*/;
            inputs["primary"] = undefined /*out*/;
            inputs["privateEndpoint"] = undefined /*out*/;
            inputs["provisioningState"] = undefined /*out*/;
            inputs["resourceGuid"] = undefined /*out*/;
            inputs["tags"] = undefined /*out*/;
            inputs["tapConfigurations"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
            inputs["virtualMachine"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        const aliasOpts = { aliases: [{ type: "azure-nextgen:network/latest:NetworkInterface" }, { type: "azure-nextgen:network/v20150501preview:NetworkInterface" }, { type: "azure-nextgen:network/v20150615:NetworkInterface" }, { type: "azure-nextgen:network/v20160330:NetworkInterface" }, { type: "azure-nextgen:network/v20160601:NetworkInterface" }, { type: "azure-nextgen:network/v20160901:NetworkInterface" }, { type: "azure-nextgen:network/v20161201:NetworkInterface" }, { type: "azure-nextgen:network/v20170301:NetworkInterface" }, { type: "azure-nextgen:network/v20170601:NetworkInterface" }, { type: "azure-nextgen:network/v20170801:NetworkInterface" }, { type: "azure-nextgen:network/v20170901:NetworkInterface" }, { type: "azure-nextgen:network/v20171001:NetworkInterface" }, { type: "azure-nextgen:network/v20171101:NetworkInterface" }, { type: "azure-nextgen:network/v20180101:NetworkInterface" }, { type: "azure-nextgen:network/v20180201:NetworkInterface" }, { type: "azure-nextgen:network/v20180401:NetworkInterface" }, { type: "azure-nextgen:network/v20180601:NetworkInterface" }, { type: "azure-nextgen:network/v20180701:NetworkInterface" }, { type: "azure-nextgen:network/v20180801:NetworkInterface" }, { type: "azure-nextgen:network/v20181001:NetworkInterface" }, { type: "azure-nextgen:network/v20181101:NetworkInterface" }, { type: "azure-nextgen:network/v20181201:NetworkInterface" }, { type: "azure-nextgen:network/v20190201:NetworkInterface" }, { type: "azure-nextgen:network/v20190401:NetworkInterface" }, { type: "azure-nextgen:network/v20190601:NetworkInterface" }, { type: "azure-nextgen:network/v20190701:NetworkInterface" }, { type: "azure-nextgen:network/v20190801:NetworkInterface" }, { type: "azure-nextgen:network/v20190901:NetworkInterface" }, { type: "azure-nextgen:network/v20191101:NetworkInterface" }, { type: "azure-nextgen:network/v20200301:NetworkInterface" }, { type: "azure-nextgen:network/v20200401:NetworkInterface" }, { type: "azure-nextgen:network/v20200501:NetworkInterface" }, { type: "azure-nextgen:network/v20200601:NetworkInterface" }, { type: "azure-nextgen:network/v20200701:NetworkInterface" }] };
        opts = opts ? pulumi.mergeOptions(opts, aliasOpts) : aliasOpts;
        super(NetworkInterface.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a NetworkInterface resource.
 */
export interface NetworkInterfaceArgs {
    /**
     * The DNS settings in network interface.
     */
    readonly dnsSettings?: pulumi.Input<inputs.network.v20191201.NetworkInterfaceDnsSettings>;
    /**
     * If the network interface is accelerated networking enabled.
     */
    readonly enableAcceleratedNetworking?: pulumi.Input<boolean>;
    /**
     * Indicates whether IP forwarding is enabled on this network interface.
     */
    readonly enableIPForwarding?: pulumi.Input<boolean>;
    /**
     * Resource ID.
     */
    readonly id?: pulumi.Input<string>;
    /**
     * A list of IPConfigurations of the network interface.
     */
    readonly ipConfigurations?: pulumi.Input<pulumi.Input<inputs.network.v20191201.NetworkInterfaceIPConfiguration>[]>;
    /**
     * Resource location.
     */
    readonly location?: pulumi.Input<string>;
    /**
     * The name of the network interface.
     */
    readonly networkInterfaceName: pulumi.Input<string>;
    /**
     * The reference to the NetworkSecurityGroup resource.
     */
    readonly networkSecurityGroup?: pulumi.Input<inputs.network.v20191201.NetworkSecurityGroup>;
    /**
     * The name of the resource group.
     */
    readonly resourceGroupName: pulumi.Input<string>;
    /**
     * Resource tags.
     */
    readonly tags?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
}
