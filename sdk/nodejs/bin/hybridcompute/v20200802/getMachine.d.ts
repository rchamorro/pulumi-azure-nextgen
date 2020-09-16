import * as pulumi from "@pulumi/pulumi";
import * as outputs from "../../types/output";
export declare function getMachine(args: GetMachineArgs, opts?: pulumi.InvokeOptions): Promise<GetMachineResult>;
export interface GetMachineArgs {
    /**
     * The expand expression to apply on the operation.
     */
    readonly expand?: string;
    /**
     * The name of the hybrid machine.
     */
    readonly name: string;
    /**
     * The name of the resource group.
     */
    readonly resourceGroupName: string;
}
/**
 * Describes a hybrid machine.
 */
export interface GetMachineResult {
    /**
     * Specifies the AD fully qualified display name.
     */
    readonly adFqdn: string;
    /**
     * The hybrid machine agent full version.
     */
    readonly agentVersion: string;
    /**
     * Public Key that the client provides to be used during initial resource onboarding
     */
    readonly clientPublicKey?: string;
    /**
     * Specifies the hybrid machine display name.
     */
    readonly displayName: string;
    /**
     * Specifies the DNS fully qualified display name.
     */
    readonly dnsFqdn: string;
    /**
     * Specifies the Windows domain name.
     */
    readonly domainName: string;
    /**
     * Details about the error state.
     */
    readonly errorDetails: outputs.hybridcompute.v20200802.ErrorDetailResponse[];
    /**
     * Machine Extensions information
     */
    readonly extensions?: outputs.hybridcompute.v20200802.MachineExtensionInstanceViewResponse[];
    readonly identity?: outputs.hybridcompute.v20200802.MachineResponseIdentity;
    /**
     * The time of the last status change.
     */
    readonly lastStatusChange: string;
    /**
     * The geo-location where the resource lives
     */
    readonly location: string;
    /**
     * Metadata pertaining to the geographic location of the resource.
     */
    readonly locationData?: outputs.hybridcompute.v20200802.LocationDataResponse;
    /**
     * Specifies the hybrid machine FQDN.
     */
    readonly machineFqdn: string;
    /**
     * The name of the resource
     */
    readonly name: string;
    /**
     * The Operating System running on the hybrid machine.
     */
    readonly osName: string;
    /**
     * Specifies the operating system settings for the hybrid machine.
     */
    readonly osProfile?: outputs.hybridcompute.v20200802.MachinePropertiesResponseOsProfile;
    /**
     * Specifies the Operating System product SKU.
     */
    readonly osSku: string;
    /**
     * The version of Operating System running on the hybrid machine.
     */
    readonly osVersion: string;
    /**
     * The provisioning state, which only appears in the response.
     */
    readonly provisioningState: string;
    /**
     * The status of the hybrid machine agent.
     */
    readonly status: string;
    /**
     * Resource tags.
     */
    readonly tags?: {
        [key: string]: string;
    };
    /**
     * The type of the resource. Ex- Microsoft.Compute/virtualMachines or Microsoft.Storage/storageAccounts.
     */
    readonly type: string;
    /**
     * Specifies the hybrid machine unique ID.
     */
    readonly vmId?: string;
    /**
     * Specifies the Arc Machine's unique SMBIOS ID
     */
    readonly vmUuid: string;
}