import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../../types/input";
import * as outputs from "../../types/output";
/**
 * ExpressRouteCircuit resource
 */
export declare class ExpressRouteCircuit extends pulumi.CustomResource {
    /**
     * Get an existing ExpressRouteCircuit resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): ExpressRouteCircuit;
    /**
     * Returns true if the given object is an instance of ExpressRouteCircuit.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    static isInstance(obj: any): obj is ExpressRouteCircuit;
    /**
     * allow classic operations
     */
    readonly allowClassicOperations: pulumi.Output<boolean | undefined>;
    /**
     * Gets or sets list of authorizations
     */
    readonly authorizations: pulumi.Output<outputs.network.v20160601.ExpressRouteCircuitAuthorizationResponse[] | undefined>;
    /**
     * Gets or sets CircuitProvisioningState state of the resource
     */
    readonly circuitProvisioningState: pulumi.Output<string | undefined>;
    /**
     * Gets a unique read-only string that changes whenever the resource is updated
     */
    readonly etag: pulumi.Output<string | undefined>;
    /**
     * Gets or sets the GatewayManager Etag
     */
    readonly gatewayManagerEtag: pulumi.Output<string | undefined>;
    /**
     * Resource location
     */
    readonly location: pulumi.Output<string | undefined>;
    /**
     * Resource name
     */
    readonly name: pulumi.Output<string>;
    /**
     * Gets or sets list of peerings
     */
    readonly peerings: pulumi.Output<outputs.network.v20160601.ExpressRouteCircuitPeeringResponse[] | undefined>;
    /**
     * Gets provisioning state of the PublicIP resource Updating/Deleting/Failed
     */
    readonly provisioningState: pulumi.Output<string | undefined>;
    /**
     * Gets or sets ServiceKey
     */
    readonly serviceKey: pulumi.Output<string | undefined>;
    /**
     * Gets or sets ServiceProviderNotes
     */
    readonly serviceProviderNotes: pulumi.Output<string | undefined>;
    /**
     * Gets or sets ServiceProviderProperties
     */
    readonly serviceProviderProperties: pulumi.Output<outputs.network.v20160601.ExpressRouteCircuitServiceProviderPropertiesResponse | undefined>;
    /**
     * Gets or sets ServiceProviderProvisioningState state of the resource
     */
    readonly serviceProviderProvisioningState: pulumi.Output<string | undefined>;
    /**
     * Gets or sets sku
     */
    readonly sku: pulumi.Output<outputs.network.v20160601.ExpressRouteCircuitSkuResponse | undefined>;
    /**
     * Resource tags
     */
    readonly tags: pulumi.Output<{
        [key: string]: string;
    } | undefined>;
    /**
     * Resource type
     */
    readonly type: pulumi.Output<string>;
    /**
     * Create a ExpressRouteCircuit resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: ExpressRouteCircuitArgs, opts?: pulumi.CustomResourceOptions);
    constructor(name: string, state: undefined, opts: pulumi.CustomResourceOptions);
}
/**
 * The set of arguments for constructing a ExpressRouteCircuit resource.
 */
export interface ExpressRouteCircuitArgs {
    /**
     * allow classic operations
     */
    readonly allowClassicOperations?: pulumi.Input<boolean>;
    /**
     * Gets or sets list of authorizations
     */
    readonly authorizations?: pulumi.Input<pulumi.Input<inputs.network.v20160601.ExpressRouteCircuitAuthorization>[]>;
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
     * Gets or sets the GatewayManager Etag
     */
    readonly gatewayManagerEtag?: pulumi.Input<string>;
    /**
     * Resource Id
     */
    readonly id?: pulumi.Input<string>;
    /**
     * Resource location
     */
    readonly location?: pulumi.Input<string>;
    /**
     * Gets or sets list of peerings
     */
    readonly peerings?: pulumi.Input<pulumi.Input<inputs.network.v20160601.ExpressRouteCircuitPeering>[]>;
    /**
     * Gets provisioning state of the PublicIP resource Updating/Deleting/Failed
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
    readonly serviceProviderProperties?: pulumi.Input<inputs.network.v20160601.ExpressRouteCircuitServiceProviderProperties>;
    /**
     * Gets or sets ServiceProviderProvisioningState state of the resource
     */
    readonly serviceProviderProvisioningState?: pulumi.Input<string>;
    /**
     * Gets or sets sku
     */
    readonly sku?: pulumi.Input<inputs.network.v20160601.ExpressRouteCircuitSku>;
    /**
     * Resource tags
     */
    readonly tags?: pulumi.Input<{
        [key: string]: pulumi.Input<string>;
    }>;
}