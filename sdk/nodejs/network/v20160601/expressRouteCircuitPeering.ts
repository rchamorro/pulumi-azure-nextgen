// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * Peering in a ExpressRouteCircuit resource
 */
export class ExpressRouteCircuitPeering extends pulumi.CustomResource {
    /**
     * Get an existing ExpressRouteCircuitPeering resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): ExpressRouteCircuitPeering {
        return new ExpressRouteCircuitPeering(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure-nextgen:network/v20160601:ExpressRouteCircuitPeering';

    /**
     * Returns true if the given object is an instance of ExpressRouteCircuitPeering.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is ExpressRouteCircuitPeering {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === ExpressRouteCircuitPeering.__pulumiType;
    }

    /**
     * Gets or sets the azure ASN
     */
    public readonly azureASN!: pulumi.Output<number | undefined>;
    /**
     * A unique read-only string that changes whenever the resource is updated
     */
    public readonly etag!: pulumi.Output<string | undefined>;
    /**
     * Gets or sets the GatewayManager Etag
     */
    public readonly gatewayManagerEtag!: pulumi.Output<string | undefined>;
    /**
     * Gets whether the provider or the customer last modified the peering
     */
    public readonly lastModifiedBy!: pulumi.Output<string | undefined>;
    /**
     * Gets or sets the Microsoft peering config
     */
    public readonly microsoftPeeringConfig!: pulumi.Output<outputs.network.v20160601.ExpressRouteCircuitPeeringConfigResponse | undefined>;
    /**
     * Gets name of the resource that is unique within a resource group. This name can be used to access the resource
     */
    public readonly name!: pulumi.Output<string | undefined>;
    /**
     * Gets or sets the peer ASN
     */
    public readonly peerASN!: pulumi.Output<number | undefined>;
    /**
     * Gets or sets PeeringType
     */
    public readonly peeringType!: pulumi.Output<string | undefined>;
    /**
     * Gets or sets the primary port
     */
    public readonly primaryAzurePort!: pulumi.Output<string | undefined>;
    /**
     * Gets or sets the primary address prefix
     */
    public readonly primaryPeerAddressPrefix!: pulumi.Output<string | undefined>;
    /**
     * Gets provisioning state of the PublicIP resource Updating/Deleting/Failed
     */
    public readonly provisioningState!: pulumi.Output<string | undefined>;
    /**
     * Gets or sets the secondary port
     */
    public readonly secondaryAzurePort!: pulumi.Output<string | undefined>;
    /**
     * Gets or sets the secondary address prefix
     */
    public readonly secondaryPeerAddressPrefix!: pulumi.Output<string | undefined>;
    /**
     * Gets or sets the shared key
     */
    public readonly sharedKey!: pulumi.Output<string | undefined>;
    /**
     * Gets or sets state of Peering
     */
    public readonly state!: pulumi.Output<string | undefined>;
    /**
     * Gets or peering stats
     */
    public readonly stats!: pulumi.Output<outputs.network.v20160601.ExpressRouteCircuitStatsResponse | undefined>;
    /**
     * Gets or sets the vlan id
     */
    public readonly vlanId!: pulumi.Output<number | undefined>;

    /**
     * Create a ExpressRouteCircuitPeering resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: ExpressRouteCircuitPeeringArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (!(opts && opts.id)) {
            if ((!args || args.circuitName === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'circuitName'");
            }
            if ((!args || args.peeringName === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'peeringName'");
            }
            if ((!args || args.resourceGroupName === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            inputs["azureASN"] = args ? args.azureASN : undefined;
            inputs["circuitName"] = args ? args.circuitName : undefined;
            inputs["etag"] = args ? args.etag : undefined;
            inputs["gatewayManagerEtag"] = args ? args.gatewayManagerEtag : undefined;
            inputs["id"] = args ? args.id : undefined;
            inputs["lastModifiedBy"] = args ? args.lastModifiedBy : undefined;
            inputs["microsoftPeeringConfig"] = args ? args.microsoftPeeringConfig : undefined;
            inputs["name"] = args ? args.name : undefined;
            inputs["peerASN"] = args ? args.peerASN : undefined;
            inputs["peeringName"] = args ? args.peeringName : undefined;
            inputs["peeringType"] = args ? args.peeringType : undefined;
            inputs["primaryAzurePort"] = args ? args.primaryAzurePort : undefined;
            inputs["primaryPeerAddressPrefix"] = args ? args.primaryPeerAddressPrefix : undefined;
            inputs["provisioningState"] = args ? args.provisioningState : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            inputs["secondaryAzurePort"] = args ? args.secondaryAzurePort : undefined;
            inputs["secondaryPeerAddressPrefix"] = args ? args.secondaryPeerAddressPrefix : undefined;
            inputs["sharedKey"] = args ? args.sharedKey : undefined;
            inputs["state"] = args ? args.state : undefined;
            inputs["stats"] = args ? args.stats : undefined;
            inputs["vlanId"] = args ? args.vlanId : undefined;
        } else {
            inputs["azureASN"] = undefined /*out*/;
            inputs["etag"] = undefined /*out*/;
            inputs["gatewayManagerEtag"] = undefined /*out*/;
            inputs["lastModifiedBy"] = undefined /*out*/;
            inputs["microsoftPeeringConfig"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["peerASN"] = undefined /*out*/;
            inputs["peeringType"] = undefined /*out*/;
            inputs["primaryAzurePort"] = undefined /*out*/;
            inputs["primaryPeerAddressPrefix"] = undefined /*out*/;
            inputs["provisioningState"] = undefined /*out*/;
            inputs["secondaryAzurePort"] = undefined /*out*/;
            inputs["secondaryPeerAddressPrefix"] = undefined /*out*/;
            inputs["sharedKey"] = undefined /*out*/;
            inputs["state"] = undefined /*out*/;
            inputs["stats"] = undefined /*out*/;
            inputs["vlanId"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        const aliasOpts = { aliases: [{ type: "azure-nextgen:network/latest:ExpressRouteCircuitPeering" }, { type: "azure-nextgen:network/v20150501preview:ExpressRouteCircuitPeering" }, { type: "azure-nextgen:network/v20150615:ExpressRouteCircuitPeering" }, { type: "azure-nextgen:network/v20160330:ExpressRouteCircuitPeering" }, { type: "azure-nextgen:network/v20160901:ExpressRouteCircuitPeering" }, { type: "azure-nextgen:network/v20161201:ExpressRouteCircuitPeering" }, { type: "azure-nextgen:network/v20170301:ExpressRouteCircuitPeering" }, { type: "azure-nextgen:network/v20170601:ExpressRouteCircuitPeering" }, { type: "azure-nextgen:network/v20170801:ExpressRouteCircuitPeering" }, { type: "azure-nextgen:network/v20170901:ExpressRouteCircuitPeering" }, { type: "azure-nextgen:network/v20171001:ExpressRouteCircuitPeering" }, { type: "azure-nextgen:network/v20171101:ExpressRouteCircuitPeering" }, { type: "azure-nextgen:network/v20180101:ExpressRouteCircuitPeering" }, { type: "azure-nextgen:network/v20180201:ExpressRouteCircuitPeering" }, { type: "azure-nextgen:network/v20180401:ExpressRouteCircuitPeering" }, { type: "azure-nextgen:network/v20180601:ExpressRouteCircuitPeering" }, { type: "azure-nextgen:network/v20180701:ExpressRouteCircuitPeering" }, { type: "azure-nextgen:network/v20180801:ExpressRouteCircuitPeering" }, { type: "azure-nextgen:network/v20181001:ExpressRouteCircuitPeering" }, { type: "azure-nextgen:network/v20181101:ExpressRouteCircuitPeering" }, { type: "azure-nextgen:network/v20181201:ExpressRouteCircuitPeering" }, { type: "azure-nextgen:network/v20190201:ExpressRouteCircuitPeering" }, { type: "azure-nextgen:network/v20190401:ExpressRouteCircuitPeering" }, { type: "azure-nextgen:network/v20190601:ExpressRouteCircuitPeering" }, { type: "azure-nextgen:network/v20190701:ExpressRouteCircuitPeering" }, { type: "azure-nextgen:network/v20190801:ExpressRouteCircuitPeering" }, { type: "azure-nextgen:network/v20190901:ExpressRouteCircuitPeering" }, { type: "azure-nextgen:network/v20191101:ExpressRouteCircuitPeering" }, { type: "azure-nextgen:network/v20191201:ExpressRouteCircuitPeering" }, { type: "azure-nextgen:network/v20200301:ExpressRouteCircuitPeering" }, { type: "azure-nextgen:network/v20200401:ExpressRouteCircuitPeering" }, { type: "azure-nextgen:network/v20200501:ExpressRouteCircuitPeering" }, { type: "azure-nextgen:network/v20200601:ExpressRouteCircuitPeering" }, { type: "azure-nextgen:network/v20200701:ExpressRouteCircuitPeering" }, { type: "azure-nextgen:network/v20200801:ExpressRouteCircuitPeering" }] };
        opts = opts ? pulumi.mergeOptions(opts, aliasOpts) : aliasOpts;
        super(ExpressRouteCircuitPeering.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a ExpressRouteCircuitPeering resource.
 */
export interface ExpressRouteCircuitPeeringArgs {
    /**
     * Gets or sets the azure ASN
     */
    readonly azureASN?: pulumi.Input<number>;
    /**
     * The name of the express route circuit.
     */
    readonly circuitName: pulumi.Input<string>;
    /**
     * A unique read-only string that changes whenever the resource is updated
     */
    readonly etag?: pulumi.Input<string>;
    /**
     * Gets or sets the GatewayManager Etag
     */
    readonly gatewayManagerEtag?: pulumi.Input<string>;
    /**
     * Resource Id
     */
    readonly id?: pulumi.Input<string>;
    /**
     * Gets whether the provider or the customer last modified the peering
     */
    readonly lastModifiedBy?: pulumi.Input<string>;
    /**
     * Gets or sets the Microsoft peering config
     */
    readonly microsoftPeeringConfig?: pulumi.Input<inputs.network.v20160601.ExpressRouteCircuitPeeringConfig>;
    /**
     * Gets name of the resource that is unique within a resource group. This name can be used to access the resource
     */
    readonly name?: pulumi.Input<string>;
    /**
     * Gets or sets the peer ASN
     */
    readonly peerASN?: pulumi.Input<number>;
    /**
     * The name of the peering.
     */
    readonly peeringName: pulumi.Input<string>;
    /**
     * Gets or sets PeeringType
     */
    readonly peeringType?: pulumi.Input<string | enums.network.v20160601.ExpressRouteCircuitPeeringType>;
    /**
     * Gets or sets the primary port
     */
    readonly primaryAzurePort?: pulumi.Input<string>;
    /**
     * Gets or sets the primary address prefix
     */
    readonly primaryPeerAddressPrefix?: pulumi.Input<string>;
    /**
     * Gets provisioning state of the PublicIP resource Updating/Deleting/Failed
     */
    readonly provisioningState?: pulumi.Input<string>;
    /**
     * The name of the resource group.
     */
    readonly resourceGroupName: pulumi.Input<string>;
    /**
     * Gets or sets the secondary port
     */
    readonly secondaryAzurePort?: pulumi.Input<string>;
    /**
     * Gets or sets the secondary address prefix
     */
    readonly secondaryPeerAddressPrefix?: pulumi.Input<string>;
    /**
     * Gets or sets the shared key
     */
    readonly sharedKey?: pulumi.Input<string>;
    /**
     * Gets or sets state of Peering
     */
    readonly state?: pulumi.Input<string | enums.network.v20160601.ExpressRouteCircuitPeeringState>;
    /**
     * Gets or peering stats
     */
    readonly stats?: pulumi.Input<inputs.network.v20160601.ExpressRouteCircuitStats>;
    /**
     * Gets or sets the vlan id
     */
    readonly vlanId?: pulumi.Input<number>;
}
