// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../../types/input";
import * as outputs from "../../types/output";
import * as utilities from "../../utilities";

/**
 * ExpressRouteCircuit resource.
 */
export class ExpressRouteCircuit extends pulumi.CustomResource {
    /**
     * Get an existing ExpressRouteCircuit resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): ExpressRouteCircuit {
        return new ExpressRouteCircuit(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure-nextgen:network/v20190601:ExpressRouteCircuit';

    /**
     * Returns true if the given object is an instance of ExpressRouteCircuit.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is ExpressRouteCircuit {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === ExpressRouteCircuit.__pulumiType;
    }

    /**
     * Allow classic operations.
     */
    public readonly allowClassicOperations!: pulumi.Output<boolean | undefined>;
    /**
     * The list of authorizations.
     */
    public readonly authorizations!: pulumi.Output<outputs.network.v20190601.ExpressRouteCircuitAuthorizationResponse[] | undefined>;
    /**
     * The bandwidth of the circuit when the circuit is provisioned on an ExpressRoutePort resource.
     */
    public readonly bandwidthInGbps!: pulumi.Output<number | undefined>;
    /**
     * The CircuitProvisioningState state of the resource.
     */
    public readonly circuitProvisioningState!: pulumi.Output<string | undefined>;
    /**
     * Gets a unique read-only string that changes whenever the resource is updated.
     */
    public /*out*/ readonly etag!: pulumi.Output<string>;
    /**
     * The reference to the ExpressRoutePort resource when the circuit is provisioned on an ExpressRoutePort resource.
     */
    public readonly expressRoutePort!: pulumi.Output<outputs.network.v20190601.SubResourceResponse | undefined>;
    /**
     * The GatewayManager Etag.
     */
    public readonly gatewayManagerEtag!: pulumi.Output<string | undefined>;
    /**
     * Flag denoting Global reach status.
     */
    public readonly globalReachEnabled!: pulumi.Output<boolean | undefined>;
    /**
     * Resource location.
     */
    public readonly location!: pulumi.Output<string | undefined>;
    /**
     * Resource name.
     */
    public /*out*/ readonly name!: pulumi.Output<string>;
    /**
     * The list of peerings.
     */
    public readonly peerings!: pulumi.Output<outputs.network.v20190601.ExpressRouteCircuitPeeringResponse[] | undefined>;
    /**
     * Gets the provisioning state of the public IP resource. Possible values are: 'Updating', 'Deleting', and 'Failed'.
     */
    public readonly provisioningState!: pulumi.Output<string | undefined>;
    /**
     * The ServiceKey.
     */
    public readonly serviceKey!: pulumi.Output<string | undefined>;
    /**
     * The ServiceProviderNotes.
     */
    public readonly serviceProviderNotes!: pulumi.Output<string | undefined>;
    /**
     * The ServiceProviderProperties.
     */
    public readonly serviceProviderProperties!: pulumi.Output<outputs.network.v20190601.ExpressRouteCircuitServiceProviderPropertiesResponse | undefined>;
    /**
     * The ServiceProviderProvisioningState state of the resource.
     */
    public readonly serviceProviderProvisioningState!: pulumi.Output<string | undefined>;
    /**
     * The SKU.
     */
    public readonly sku!: pulumi.Output<outputs.network.v20190601.ExpressRouteCircuitSkuResponse | undefined>;
    /**
     * The identifier of the circuit traffic. Outer tag for QinQ encapsulation.
     */
    public /*out*/ readonly stag!: pulumi.Output<number>;
    /**
     * Resource tags.
     */
    public readonly tags!: pulumi.Output<{[key: string]: string} | undefined>;
    /**
     * Resource type.
     */
    public /*out*/ readonly type!: pulumi.Output<string>;

    /**
     * Create a ExpressRouteCircuit resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: ExpressRouteCircuitArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (!(opts && opts.id)) {
            if (!args || args.circuitName === undefined) {
                throw new Error("Missing required property 'circuitName'");
            }
            if (!args || args.resourceGroupName === undefined) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            inputs["allowClassicOperations"] = args ? args.allowClassicOperations : undefined;
            inputs["authorizations"] = args ? args.authorizations : undefined;
            inputs["bandwidthInGbps"] = args ? args.bandwidthInGbps : undefined;
            inputs["circuitName"] = args ? args.circuitName : undefined;
            inputs["circuitProvisioningState"] = args ? args.circuitProvisioningState : undefined;
            inputs["expressRoutePort"] = args ? args.expressRoutePort : undefined;
            inputs["gatewayManagerEtag"] = args ? args.gatewayManagerEtag : undefined;
            inputs["globalReachEnabled"] = args ? args.globalReachEnabled : undefined;
            inputs["id"] = args ? args.id : undefined;
            inputs["location"] = args ? args.location : undefined;
            inputs["peerings"] = args ? args.peerings : undefined;
            inputs["provisioningState"] = args ? args.provisioningState : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            inputs["serviceKey"] = args ? args.serviceKey : undefined;
            inputs["serviceProviderNotes"] = args ? args.serviceProviderNotes : undefined;
            inputs["serviceProviderProperties"] = args ? args.serviceProviderProperties : undefined;
            inputs["serviceProviderProvisioningState"] = args ? args.serviceProviderProvisioningState : undefined;
            inputs["sku"] = args ? args.sku : undefined;
            inputs["tags"] = args ? args.tags : undefined;
            inputs["etag"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["stag"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        } else {
            inputs["allowClassicOperations"] = undefined /*out*/;
            inputs["authorizations"] = undefined /*out*/;
            inputs["bandwidthInGbps"] = undefined /*out*/;
            inputs["circuitProvisioningState"] = undefined /*out*/;
            inputs["etag"] = undefined /*out*/;
            inputs["expressRoutePort"] = undefined /*out*/;
            inputs["gatewayManagerEtag"] = undefined /*out*/;
            inputs["globalReachEnabled"] = undefined /*out*/;
            inputs["location"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["peerings"] = undefined /*out*/;
            inputs["provisioningState"] = undefined /*out*/;
            inputs["serviceKey"] = undefined /*out*/;
            inputs["serviceProviderNotes"] = undefined /*out*/;
            inputs["serviceProviderProperties"] = undefined /*out*/;
            inputs["serviceProviderProvisioningState"] = undefined /*out*/;
            inputs["sku"] = undefined /*out*/;
            inputs["stag"] = undefined /*out*/;
            inputs["tags"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        const aliasOpts = { aliases: [{ type: "azure-nextgen:network/latest:ExpressRouteCircuit" }, { type: "azure-nextgen:network/v20150501preview:ExpressRouteCircuit" }, { type: "azure-nextgen:network/v20150615:ExpressRouteCircuit" }, { type: "azure-nextgen:network/v20160330:ExpressRouteCircuit" }, { type: "azure-nextgen:network/v20160601:ExpressRouteCircuit" }, { type: "azure-nextgen:network/v20160901:ExpressRouteCircuit" }, { type: "azure-nextgen:network/v20161201:ExpressRouteCircuit" }, { type: "azure-nextgen:network/v20170301:ExpressRouteCircuit" }, { type: "azure-nextgen:network/v20170601:ExpressRouteCircuit" }, { type: "azure-nextgen:network/v20170801:ExpressRouteCircuit" }, { type: "azure-nextgen:network/v20170901:ExpressRouteCircuit" }, { type: "azure-nextgen:network/v20171001:ExpressRouteCircuit" }, { type: "azure-nextgen:network/v20171101:ExpressRouteCircuit" }, { type: "azure-nextgen:network/v20180101:ExpressRouteCircuit" }, { type: "azure-nextgen:network/v20180201:ExpressRouteCircuit" }, { type: "azure-nextgen:network/v20180401:ExpressRouteCircuit" }, { type: "azure-nextgen:network/v20180601:ExpressRouteCircuit" }, { type: "azure-nextgen:network/v20180701:ExpressRouteCircuit" }, { type: "azure-nextgen:network/v20180801:ExpressRouteCircuit" }, { type: "azure-nextgen:network/v20181001:ExpressRouteCircuit" }, { type: "azure-nextgen:network/v20181101:ExpressRouteCircuit" }, { type: "azure-nextgen:network/v20181201:ExpressRouteCircuit" }, { type: "azure-nextgen:network/v20190201:ExpressRouteCircuit" }, { type: "azure-nextgen:network/v20190401:ExpressRouteCircuit" }, { type: "azure-nextgen:network/v20190701:ExpressRouteCircuit" }, { type: "azure-nextgen:network/v20190801:ExpressRouteCircuit" }, { type: "azure-nextgen:network/v20190901:ExpressRouteCircuit" }, { type: "azure-nextgen:network/v20191101:ExpressRouteCircuit" }, { type: "azure-nextgen:network/v20191201:ExpressRouteCircuit" }, { type: "azure-nextgen:network/v20200301:ExpressRouteCircuit" }, { type: "azure-nextgen:network/v20200401:ExpressRouteCircuit" }, { type: "azure-nextgen:network/v20200501:ExpressRouteCircuit" }, { type: "azure-nextgen:network/v20200601:ExpressRouteCircuit" }, { type: "azure-nextgen:network/v20200701:ExpressRouteCircuit" }] };
        opts = opts ? pulumi.mergeOptions(opts, aliasOpts) : aliasOpts;
        super(ExpressRouteCircuit.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a ExpressRouteCircuit resource.
 */
export interface ExpressRouteCircuitArgs {
    /**
     * Allow classic operations.
     */
    readonly allowClassicOperations?: pulumi.Input<boolean>;
    /**
     * The list of authorizations.
     */
    readonly authorizations?: pulumi.Input<pulumi.Input<inputs.network.v20190601.ExpressRouteCircuitAuthorization>[]>;
    /**
     * The bandwidth of the circuit when the circuit is provisioned on an ExpressRoutePort resource.
     */
    readonly bandwidthInGbps?: pulumi.Input<number>;
    /**
     * The name of the circuit.
     */
    readonly circuitName: pulumi.Input<string>;
    /**
     * The CircuitProvisioningState state of the resource.
     */
    readonly circuitProvisioningState?: pulumi.Input<string>;
    /**
     * The reference to the ExpressRoutePort resource when the circuit is provisioned on an ExpressRoutePort resource.
     */
    readonly expressRoutePort?: pulumi.Input<inputs.network.v20190601.SubResource>;
    /**
     * The GatewayManager Etag.
     */
    readonly gatewayManagerEtag?: pulumi.Input<string>;
    /**
     * Flag denoting Global reach status.
     */
    readonly globalReachEnabled?: pulumi.Input<boolean>;
    /**
     * Resource ID.
     */
    readonly id?: pulumi.Input<string>;
    /**
     * Resource location.
     */
    readonly location?: pulumi.Input<string>;
    /**
     * The list of peerings.
     */
    readonly peerings?: pulumi.Input<pulumi.Input<inputs.network.v20190601.ExpressRouteCircuitPeering>[]>;
    /**
     * Gets the provisioning state of the public IP resource. Possible values are: 'Updating', 'Deleting', and 'Failed'.
     */
    readonly provisioningState?: pulumi.Input<string>;
    /**
     * The name of the resource group.
     */
    readonly resourceGroupName: pulumi.Input<string>;
    /**
     * The ServiceKey.
     */
    readonly serviceKey?: pulumi.Input<string>;
    /**
     * The ServiceProviderNotes.
     */
    readonly serviceProviderNotes?: pulumi.Input<string>;
    /**
     * The ServiceProviderProperties.
     */
    readonly serviceProviderProperties?: pulumi.Input<inputs.network.v20190601.ExpressRouteCircuitServiceProviderProperties>;
    /**
     * The ServiceProviderProvisioningState state of the resource.
     */
    readonly serviceProviderProvisioningState?: pulumi.Input<string>;
    /**
     * The SKU.
     */
    readonly sku?: pulumi.Input<inputs.network.v20190601.ExpressRouteCircuitSku>;
    /**
     * Resource tags.
     */
    readonly tags?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
}
