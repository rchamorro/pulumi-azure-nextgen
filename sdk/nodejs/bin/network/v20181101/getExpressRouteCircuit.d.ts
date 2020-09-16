import * as pulumi from "@pulumi/pulumi";
import * as outputs from "../../types/output";
export declare function getExpressRouteCircuit(args: GetExpressRouteCircuitArgs, opts?: pulumi.InvokeOptions): Promise<GetExpressRouteCircuitResult>;
export interface GetExpressRouteCircuitArgs {
    /**
     * The name of express route circuit.
     */
    readonly circuitName: string;
    /**
     * The name of the resource group.
     */
    readonly resourceGroupName: string;
}
/**
 * ExpressRouteCircuit resource
 */
export interface GetExpressRouteCircuitResult {
    /**
     * Allow classic operations
     */
    readonly allowClassicOperations?: boolean;
    /**
     * Flag to enable Global Reach on the circuit.
     */
    readonly allowGlobalReach?: boolean;
    /**
     * The list of authorizations.
     */
    readonly authorizations?: outputs.network.v20181101.ExpressRouteCircuitAuthorizationResponse[];
    /**
     * The bandwidth of the circuit when the circuit is provisioned on an ExpressRoutePort resource.
     */
    readonly bandwidthInGbps?: number;
    /**
     * The CircuitProvisioningState state of the resource.
     */
    readonly circuitProvisioningState?: string;
    /**
     * Gets a unique read-only string that changes whenever the resource is updated.
     */
    readonly etag: string;
    /**
     * The reference to the ExpressRoutePort resource when the circuit is provisioned on an ExpressRoutePort resource.
     */
    readonly expressRoutePort?: outputs.network.v20181101.SubResourceResponse;
    /**
     * The GatewayManager Etag.
     */
    readonly gatewayManagerEtag?: string;
    /**
     * Resource location.
     */
    readonly location?: string;
    /**
     * Resource name.
     */
    readonly name: string;
    /**
     * The list of peerings.
     */
    readonly peerings?: outputs.network.v20181101.ExpressRouteCircuitPeeringResponse[];
    /**
     * Gets the provisioning state of the public IP resource. Possible values are: 'Updating', 'Deleting', and 'Failed'.
     */
    readonly provisioningState?: string;
    /**
     * The ServiceKey.
     */
    readonly serviceKey?: string;
    /**
     * The ServiceProviderNotes.
     */
    readonly serviceProviderNotes?: string;
    /**
     * The ServiceProviderProperties.
     */
    readonly serviceProviderProperties?: outputs.network.v20181101.ExpressRouteCircuitServiceProviderPropertiesResponse;
    /**
     * The ServiceProviderProvisioningState state of the resource. Possible values are 'NotProvisioned', 'Provisioning', 'Provisioned', and 'Deprovisioning'.
     */
    readonly serviceProviderProvisioningState?: string;
    /**
     * The SKU.
     */
    readonly sku?: outputs.network.v20181101.ExpressRouteCircuitSkuResponse;
    /**
     * The identifier of the circuit traffic. Outer tag for QinQ encapsulation.
     */
    readonly stag: number;
    /**
     * Resource tags.
     */
    readonly tags?: {
        [key: string]: string;
    };
    /**
     * Resource type.
     */
    readonly type: string;
}