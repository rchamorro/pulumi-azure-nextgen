import * as pulumi from "@pulumi/pulumi";
export declare function getWCFRelay(args: GetWCFRelayArgs, opts?: pulumi.InvokeOptions): Promise<GetWCFRelayResult>;
export interface GetWCFRelayArgs {
    /**
     * The namespace name
     */
    readonly namespaceName: string;
    /**
     * The relay name.
     */
    readonly relayName: string;
    /**
     * Name of the Resource group within the Azure subscription.
     */
    readonly resourceGroupName: string;
}
/**
 * Description of the WCF relay resource.
 */
export interface GetWCFRelayResult {
    /**
     * The time the WCF relay was created.
     */
    readonly createdAt: string;
    /**
     * Returns true if the relay is dynamic; otherwise, false.
     */
    readonly isDynamic: boolean;
    /**
     * The number of listeners for this relay. Note that min :1 and max:25 are supported.
     */
    readonly listenerCount: number;
    /**
     * Resource name.
     */
    readonly name: string;
    /**
     * WCF relay type.
     */
    readonly relayType?: string;
    /**
     * Returns true if client authorization is needed for this relay; otherwise, false.
     */
    readonly requiresClientAuthorization?: boolean;
    /**
     * Returns true if transport security is needed for this relay; otherwise, false.
     */
    readonly requiresTransportSecurity?: boolean;
    /**
     * Resource type.
     */
    readonly type: string;
    /**
     * The time the namespace was updated.
     */
    readonly updatedAt: string;
    /**
     * The usermetadata is a placeholder to store user-defined string data for the WCF Relay endpoint. For example, it can be used to store descriptive data, such as list of teams and their contact information. Also, user-defined configuration settings can be stored.
     */
    readonly userMetadata?: string;
}