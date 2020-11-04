// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../../types/input";
import * as outputs from "../../types/output";
import * as utilities from "../../utilities";

/**
 * ExpressRouteCircuit resource
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
    public static readonly __pulumiType = 'azure-nextgen:network/v20150501preview:ExpressRouteCircuit';

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
     * Gets or sets list of authorizations
     */
    public readonly authorizations!: pulumi.Output<outputs.network.v20150501preview.ExpressRouteCircuitAuthorizationResponse[] | undefined>;
    /**
     * Gets or sets CircuitProvisioningState state of the resource 
     */
    public readonly circuitProvisioningState!: pulumi.Output<string | undefined>;
    /**
     * Gets a unique read-only string that changes whenever the resource is updated
     */
    public readonly etag!: pulumi.Output<string | undefined>;
    /**
     * Resource location
     */
    public readonly location!: pulumi.Output<string>;
    /**
     * Resource name
     */
    public /*out*/ readonly name!: pulumi.Output<string>;
    /**
     * Gets or sets list of peerings
     */
    public readonly peerings!: pulumi.Output<outputs.network.v20150501preview.ExpressRouteCircuitPeeringResponse[] | undefined>;
    /**
     * Gets or sets Provisioning state of the PublicIP resource Updating/Deleting/Failed
     */
    public readonly provisioningState!: pulumi.Output<string | undefined>;
    /**
     * Gets or sets ServiceKey
     */
    public readonly serviceKey!: pulumi.Output<string | undefined>;
    /**
     * Gets or sets ServiceProviderNotes
     */
    public readonly serviceProviderNotes!: pulumi.Output<string | undefined>;
    /**
     * Gets or sets ServiceProviderProperties
     */
    public readonly serviceProviderProperties!: pulumi.Output<outputs.network.v20150501preview.ExpressRouteCircuitServiceProviderPropertiesResponse | undefined>;
    /**
     * Gets or sets ServiceProviderProvisioningState state of the resource 
     */
    public readonly serviceProviderProvisioningState!: pulumi.Output<string | undefined>;
    /**
     * Gets or sets sku
     */
    public readonly sku!: pulumi.Output<outputs.network.v20150501preview.ExpressRouteCircuitSkuResponse | undefined>;
    /**
     * Resource tags
     */
    public readonly tags!: pulumi.Output<{[key: string]: string} | undefined>;
    /**
     * Resource type
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
            if (!args || args.location === undefined) {
                throw new Error("Missing required property 'location'");
            }
            if (!args || args.resourceGroupName === undefined) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            inputs["authorizations"] = args ? args.authorizations : undefined;
            inputs["circuitName"] = args ? args.circuitName : undefined;
            inputs["circuitProvisioningState"] = args ? args.circuitProvisioningState : undefined;
            inputs["etag"] = args ? args.etag : undefined;
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
            inputs["name"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        } else {
            inputs["authorizations"] = undefined /*out*/;
            inputs["circuitProvisioningState"] = undefined /*out*/;
            inputs["etag"] = undefined /*out*/;
            inputs["location"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["peerings"] = undefined /*out*/;
            inputs["provisioningState"] = undefined /*out*/;
            inputs["serviceKey"] = undefined /*out*/;
            inputs["serviceProviderNotes"] = undefined /*out*/;
            inputs["serviceProviderProperties"] = undefined /*out*/;
            inputs["serviceProviderProvisioningState"] = undefined /*out*/;
            inputs["sku"] = undefined /*out*/;
            inputs["tags"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        const aliasOpts = { aliases: [{ type: "azure-nextgen:network/latest:ExpressRouteCircuit" }, { type: "azure-nextgen:network/v20150615:ExpressRouteCircuit" }, { type: "azure-nextgen:network/v20160330:ExpressRouteCircuit" }, { type: "azure-nextgen:network/v20160601:ExpressRouteCircuit" }, { type: "azure-nextgen:network/v20160901:ExpressRouteCircuit" }, { type: "azure-nextgen:network/v20161201:ExpressRouteCircuit" }, { type: "azure-nextgen:network/v20170301:ExpressRouteCircuit" }, { type: "azure-nextgen:network/v20170601:ExpressRouteCircuit" }, { type: "azure-nextgen:network/v20170801:ExpressRouteCircuit" }, { type: "azure-nextgen:network/v20170901:ExpressRouteCircuit" }, { type: "azure-nextgen:network/v20171001:ExpressRouteCircuit" }, { type: "azure-nextgen:network/v20171101:ExpressRouteCircuit" }, { type: "azure-nextgen:network/v20180101:ExpressRouteCircuit" }, { type: "azure-nextgen:network/v20180201:ExpressRouteCircuit" }, { type: "azure-nextgen:network/v20180401:ExpressRouteCircuit" }, { type: "azure-nextgen:network/v20180601:ExpressRouteCircuit" }, { type: "azure-nextgen:network/v20180701:ExpressRouteCircuit" }, { type: "azure-nextgen:network/v20180801:ExpressRouteCircuit" }, { type: "azure-nextgen:network/v20181001:ExpressRouteCircuit" }, { type: "azure-nextgen:network/v20181101:ExpressRouteCircuit" }, { type: "azure-nextgen:network/v20181201:ExpressRouteCircuit" }, { type: "azure-nextgen:network/v20190201:ExpressRouteCircuit" }, { type: "azure-nextgen:network/v20190401:ExpressRouteCircuit" }, { type: "azure-nextgen:network/v20190601:ExpressRouteCircuit" }, { type: "azure-nextgen:network/v20190701:ExpressRouteCircuit" }, { type: "azure-nextgen:network/v20190801:ExpressRouteCircuit" }, { type: "azure-nextgen:network/v20190901:ExpressRouteCircuit" }, { type: "azure-nextgen:network/v20191101:ExpressRouteCircuit" }, { type: "azure-nextgen:network/v20191201:ExpressRouteCircuit" }, { type: "azure-nextgen:network/v20200301:ExpressRouteCircuit" }, { type: "azure-nextgen:network/v20200401:ExpressRouteCircuit" }, { type: "azure-nextgen:network/v20200501:ExpressRouteCircuit" }, { type: "azure-nextgen:network/v20200601:ExpressRouteCircuit" }, { type: "azure-nextgen:network/v20200701:ExpressRouteCircuit" }] };
        opts = opts ? pulumi.mergeOptions(opts, aliasOpts) : aliasOpts;
        super(ExpressRouteCircuit.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a ExpressRouteCircuit resource.
 */
export interface ExpressRouteCircuitArgs {
    /**
     * Gets or sets list of authorizations
     */
    readonly authorizations?: pulumi.Input<pulumi.Input<inputs.network.v20150501preview.ExpressRouteCircuitAuthorization>[]>;
    /**
     * The name of the circuit.
     */
    readonly circuitName: pulumi.Input<string>;
    /**
     * Gets or sets CircuitProvisioningState state of the resource 
     */
    readonly circuitProvisioningState?: pulumi.Input<string>;
    /**
     * Gets a unique read-only string that changes whenever the resource is updated
     */
    readonly etag?: pulumi.Input<string>;
    /**
     * Resource location
     */
    readonly location: pulumi.Input<string>;
    /**
     * Gets or sets list of peerings
     */
    readonly peerings?: pulumi.Input<pulumi.Input<inputs.network.v20150501preview.ExpressRouteCircuitPeering>[]>;
    /**
     * Gets or sets Provisioning state of the PublicIP resource Updating/Deleting/Failed
     */
    readonly provisioningState?: pulumi.Input<string>;
    /**
     * The name of the resource group.
     */
    readonly resourceGroupName: pulumi.Input<string>;
    /**
     * Gets or sets ServiceKey
     */
    readonly serviceKey?: pulumi.Input<string>;
    /**
     * Gets or sets ServiceProviderNotes
     */
    readonly serviceProviderNotes?: pulumi.Input<string>;
    /**
     * Gets or sets ServiceProviderProperties
     */
    readonly serviceProviderProperties?: pulumi.Input<inputs.network.v20150501preview.ExpressRouteCircuitServiceProviderProperties>;
    /**
     * Gets or sets ServiceProviderProvisioningState state of the resource 
     */
    readonly serviceProviderProvisioningState?: pulumi.Input<string>;
    /**
     * Gets or sets sku
     */
    readonly sku?: pulumi.Input<inputs.network.v20150501preview.ExpressRouteCircuitSku>;
    /**
     * Resource tags
     */
    readonly tags?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
}
