import * as pulumi from "@pulumi/pulumi";
import * as outputs from "../../types/output";
export declare function getPrivateCloud(args: GetPrivateCloudArgs, opts?: pulumi.InvokeOptions): Promise<GetPrivateCloudResult>;
export interface GetPrivateCloudArgs {
    /**
     * Name of the private cloud
     */
    readonly privateCloudName: string;
    /**
     * The name of the resource group. The name is case insensitive.
     */
    readonly resourceGroupName: string;
}
/**
 * A private cloud resource
 */
export interface GetPrivateCloudResult {
    /**
     * An ExpressRoute Circuit
     */
    readonly circuit?: outputs.avs.v20200320.CircuitResponse;
    /**
     * The endpoints
     */
    readonly endpoints: outputs.avs.v20200320.EndpointsResponse;
    /**
     * vCenter Single Sign On Identity Sources
     */
    readonly identitySources?: outputs.avs.v20200320.IdentitySourceResponse[];
    /**
     * Connectivity to internet is enabled or disabled
     */
    readonly internet?: string;
    /**
     * Resource location
     */
    readonly location: string;
    /**
     * The default cluster used for management
     */
    readonly managementCluster: outputs.avs.v20200320.ManagementClusterResponse;
    /**
     * Network used to access vCenter Server and NSX-T Manager
     */
    readonly managementNetwork: string;
    /**
     * Resource name.
     */
    readonly name: string;
    /**
     * The block of addresses should be unique across VNet in your subscription as well as on-premise. Make sure the CIDR format is conformed to (A.B.C.D/X) where A,B,C,D are between 0 and 255, and X is between 0 and 22
     */
    readonly networkBlock: string;
    /**
     * Thumbprint of the NSX-T Manager SSL certificate
     */
    readonly nsxtCertificateThumbprint: string;
    /**
     * Optionally, set the NSX-T Manager password when the private cloud is created
     */
    readonly nsxtPassword?: string;
    /**
     * Used for virtual machine cold migration, cloning, and snapshot migration
     */
    readonly provisioningNetwork: string;
    /**
     * The provisioning state
     */
    readonly provisioningState: string;
    /**
     * The private cloud SKU
     */
    readonly sku: outputs.avs.v20200320.SkuResponse;
    /**
     * Resource tags
     */
    readonly tags?: {
        [key: string]: string;
    };
    /**
     * Resource type.
     */
    readonly type: string;
    /**
     * Thumbprint of the vCenter Server SSL certificate
     */
    readonly vcenterCertificateThumbprint: string;
    /**
     * Optionally, set the vCenter admin password when the private cloud is created
     */
    readonly vcenterPassword?: string;
    /**
     * Used for live migration of virtual machines
     */
    readonly vmotionNetwork: string;
}