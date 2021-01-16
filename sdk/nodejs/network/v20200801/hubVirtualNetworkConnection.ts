// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * HubVirtualNetworkConnection Resource.
 */
export class HubVirtualNetworkConnection extends pulumi.CustomResource {
    /**
     * Get an existing HubVirtualNetworkConnection resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): HubVirtualNetworkConnection {
        return new HubVirtualNetworkConnection(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure-nextgen:network/v20200801:HubVirtualNetworkConnection';

    /**
     * Returns true if the given object is an instance of HubVirtualNetworkConnection.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is HubVirtualNetworkConnection {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === HubVirtualNetworkConnection.__pulumiType;
    }

    /**
     * Deprecated: VirtualHub to RemoteVnet transit to enabled or not.
     */
    public readonly allowHubToRemoteVnetTransit!: pulumi.Output<boolean | undefined>;
    /**
     * Deprecated: Allow RemoteVnet to use Virtual Hub's gateways.
     */
    public readonly allowRemoteVnetToUseHubVnetGateways!: pulumi.Output<boolean | undefined>;
    /**
     * Enable internet security.
     */
    public readonly enableInternetSecurity!: pulumi.Output<boolean | undefined>;
    /**
     * A unique read-only string that changes whenever the resource is updated.
     */
    public /*out*/ readonly etag!: pulumi.Output<string>;
    /**
     * The name of the resource that is unique within a resource group. This name can be used to access the resource.
     */
    public readonly name!: pulumi.Output<string | undefined>;
    /**
     * The provisioning state of the hub virtual network connection resource.
     */
    public /*out*/ readonly provisioningState!: pulumi.Output<string>;
    /**
     * Reference to the remote virtual network.
     */
    public readonly remoteVirtualNetwork!: pulumi.Output<outputs.network.v20200801.SubResourceResponse | undefined>;
    /**
     * The Routing Configuration indicating the associated and propagated route tables on this connection.
     */
    public readonly routingConfiguration!: pulumi.Output<outputs.network.v20200801.RoutingConfigurationResponse | undefined>;

    /**
     * Create a HubVirtualNetworkConnection resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: HubVirtualNetworkConnectionArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (!(opts && opts.id)) {
            if ((!args || args.connectionName === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'connectionName'");
            }
            if ((!args || args.resourceGroupName === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            if ((!args || args.virtualHubName === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'virtualHubName'");
            }
            inputs["allowHubToRemoteVnetTransit"] = args ? args.allowHubToRemoteVnetTransit : undefined;
            inputs["allowRemoteVnetToUseHubVnetGateways"] = args ? args.allowRemoteVnetToUseHubVnetGateways : undefined;
            inputs["connectionName"] = args ? args.connectionName : undefined;
            inputs["enableInternetSecurity"] = args ? args.enableInternetSecurity : undefined;
            inputs["id"] = args ? args.id : undefined;
            inputs["name"] = args ? args.name : undefined;
            inputs["remoteVirtualNetwork"] = args ? args.remoteVirtualNetwork : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            inputs["routingConfiguration"] = args ? args.routingConfiguration : undefined;
            inputs["virtualHubName"] = args ? args.virtualHubName : undefined;
            inputs["etag"] = undefined /*out*/;
            inputs["provisioningState"] = undefined /*out*/;
        } else {
            inputs["allowHubToRemoteVnetTransit"] = undefined /*out*/;
            inputs["allowRemoteVnetToUseHubVnetGateways"] = undefined /*out*/;
            inputs["enableInternetSecurity"] = undefined /*out*/;
            inputs["etag"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["provisioningState"] = undefined /*out*/;
            inputs["remoteVirtualNetwork"] = undefined /*out*/;
            inputs["routingConfiguration"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        const aliasOpts = { aliases: [{ type: "azure-nextgen:network/latest:HubVirtualNetworkConnection" }, { type: "azure-nextgen:network/v20200501:HubVirtualNetworkConnection" }, { type: "azure-nextgen:network/v20200601:HubVirtualNetworkConnection" }, { type: "azure-nextgen:network/v20200701:HubVirtualNetworkConnection" }] };
        opts = opts ? pulumi.mergeOptions(opts, aliasOpts) : aliasOpts;
        super(HubVirtualNetworkConnection.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a HubVirtualNetworkConnection resource.
 */
export interface HubVirtualNetworkConnectionArgs {
    /**
     * Deprecated: VirtualHub to RemoteVnet transit to enabled or not.
     */
    readonly allowHubToRemoteVnetTransit?: pulumi.Input<boolean>;
    /**
     * Deprecated: Allow RemoteVnet to use Virtual Hub's gateways.
     */
    readonly allowRemoteVnetToUseHubVnetGateways?: pulumi.Input<boolean>;
    /**
     * The name of the HubVirtualNetworkConnection.
     */
    readonly connectionName: pulumi.Input<string>;
    /**
     * Enable internet security.
     */
    readonly enableInternetSecurity?: pulumi.Input<boolean>;
    /**
     * Resource ID.
     */
    readonly id?: pulumi.Input<string>;
    /**
     * The name of the resource that is unique within a resource group. This name can be used to access the resource.
     */
    readonly name?: pulumi.Input<string>;
    /**
     * Reference to the remote virtual network.
     */
    readonly remoteVirtualNetwork?: pulumi.Input<inputs.network.v20200801.SubResource>;
    /**
     * The resource group name of the HubVirtualNetworkConnection.
     */
    readonly resourceGroupName: pulumi.Input<string>;
    /**
     * The Routing Configuration indicating the associated and propagated route tables on this connection.
     */
    readonly routingConfiguration?: pulumi.Input<inputs.network.v20200801.RoutingConfiguration>;
    /**
     * The name of the VirtualHub.
     */
    readonly virtualHubName: pulumi.Input<string>;
}
