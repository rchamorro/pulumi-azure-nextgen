import * as pulumi from "@pulumi/pulumi";
import * as outputs from "../../types/output";
export declare function getDedicatedHost(args: GetDedicatedHostArgs, opts?: pulumi.InvokeOptions): Promise<GetDedicatedHostResult>;
export interface GetDedicatedHostArgs {
    /**
     * The expand expression to apply on the operation.
     */
    readonly expand?: string;
    /**
     * The name of the dedicated host group.
     */
    readonly hostGroupName: string;
    /**
     * The name of the dedicated host.
     */
    readonly hostName: string;
    /**
     * The name of the resource group.
     */
    readonly resourceGroupName: string;
}
/**
 * Specifies information about the Dedicated host.
 */
export interface GetDedicatedHostResult {
    /**
     * Specifies whether the dedicated host should be replaced automatically in case of a failure. The value is defaulted to 'true' when not provided.
     */
    readonly autoReplaceOnFailure?: boolean;
    /**
     * A unique id generated and assigned to the dedicated host by the platform. <br><br> Does not change throughout the lifetime of the host.
     */
    readonly hostId: string;
    /**
     * The dedicated host instance view.
     */
    readonly instanceView: outputs.compute.v20200601.DedicatedHostInstanceViewResponse;
    /**
     * Specifies the software license type that will be applied to the VMs deployed on the dedicated host. <br><br> Possible values are: <br><br> **None** <br><br> **Windows_Server_Hybrid** <br><br> **Windows_Server_Perpetual** <br><br> Default: **None**
     */
    readonly licenseType?: string;
    /**
     * Resource location
     */
    readonly location: string;
    /**
     * Resource name
     */
    readonly name: string;
    /**
     * Fault domain of the dedicated host within a dedicated host group.
     */
    readonly platformFaultDomain?: number;
    /**
     * The provisioning state, which only appears in the response.
     */
    readonly provisioningState: string;
    /**
     * The date when the host was first provisioned.
     */
    readonly provisioningTime: string;
    /**
     * SKU of the dedicated host for Hardware Generation and VM family. Only name is required to be set. List Microsoft.Compute SKUs for a list of possible values.
     */
    readonly sku: outputs.compute.v20200601.SkuResponse;
    /**
     * Resource tags
     */
    readonly tags?: {
        [key: string]: string;
    };
    /**
     * Resource type
     */
    readonly type: string;
    /**
     * A list of references to all virtual machines in the Dedicated Host.
     */
    readonly virtualMachines: outputs.compute.v20200601.SubResourceReadOnlyResponse[];
}