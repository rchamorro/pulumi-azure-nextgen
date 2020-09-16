import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../../types/input";
import * as outputs from "../../types/output";
/**
 * Class representing a Kusto cluster.
 */
export declare class Cluster extends pulumi.CustomResource {
    /**
     * Get an existing Cluster resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): Cluster;
    /**
     * Returns true if the given object is an instance of Cluster.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    static isInstance(obj: any): obj is Cluster;
    /**
     * The cluster data ingestion URI.
     */
    readonly dataIngestionUri: pulumi.Output<string>;
    /**
     * A boolean value that indicates if the cluster's disks are encrypted.
     */
    readonly enableDiskEncryption: pulumi.Output<boolean | undefined>;
    /**
     * A boolean value that indicates if the streaming ingest is enabled.
     */
    readonly enableStreamingIngest: pulumi.Output<boolean | undefined>;
    /**
     * The identity of the cluster, if configured.
     */
    readonly identity: pulumi.Output<outputs.kusto.v20191109.IdentityResponse | undefined>;
    /**
     * KeyVault properties for the cluster encryption.
     */
    readonly keyVaultProperties: pulumi.Output<outputs.kusto.v20191109.KeyVaultPropertiesResponse | undefined>;
    /**
     * The geo-location where the resource lives
     */
    readonly location: pulumi.Output<string>;
    /**
     * The name of the resource
     */
    readonly name: pulumi.Output<string>;
    /**
     * Optimized auto scale definition.
     */
    readonly optimizedAutoscale: pulumi.Output<outputs.kusto.v20191109.OptimizedAutoscaleResponse | undefined>;
    /**
     * The provisioned state of the resource.
     */
    readonly provisioningState: pulumi.Output<string>;
    /**
     * The SKU of the cluster.
     */
    readonly sku: pulumi.Output<outputs.kusto.v20191109.AzureSkuResponse>;
    /**
     * The state of the resource.
     */
    readonly state: pulumi.Output<string>;
    /**
     * The reason for the cluster's current state.
     */
    readonly stateReason: pulumi.Output<string>;
    /**
     * Resource tags.
     */
    readonly tags: pulumi.Output<{
        [key: string]: string;
    } | undefined>;
    /**
     * The cluster's external tenants.
     */
    readonly trustedExternalTenants: pulumi.Output<outputs.kusto.v20191109.TrustedExternalTenantResponse[] | undefined>;
    /**
     * The type of the resource. Ex- Microsoft.Compute/virtualMachines or Microsoft.Storage/storageAccounts.
     */
    readonly type: pulumi.Output<string>;
    /**
     * The cluster URI.
     */
    readonly uri: pulumi.Output<string>;
    /**
     * Virtual network definition.
     */
    readonly virtualNetworkConfiguration: pulumi.Output<outputs.kusto.v20191109.VirtualNetworkConfigurationResponse | undefined>;
    /**
     * The availability zones of the cluster.
     */
    readonly zones: pulumi.Output<string[] | undefined>;
    /**
     * Create a Cluster resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: ClusterArgs, opts?: pulumi.CustomResourceOptions);
    constructor(name: string, state: undefined, opts: pulumi.CustomResourceOptions);
}
/**
 * The set of arguments for constructing a Cluster resource.
 */
export interface ClusterArgs {
    /**
     * The name of the Kusto cluster.
     */
    readonly clusterName: pulumi.Input<string>;
    /**
     * A boolean value that indicates if the cluster's disks are encrypted.
     */
    readonly enableDiskEncryption?: pulumi.Input<boolean>;
    /**
     * A boolean value that indicates if the streaming ingest is enabled.
     */
    readonly enableStreamingIngest?: pulumi.Input<boolean>;
    /**
     * The identity of the cluster, if configured.
     */
    readonly identity?: pulumi.Input<inputs.kusto.v20191109.Identity>;
    /**
     * KeyVault properties for the cluster encryption.
     */
    readonly keyVaultProperties?: pulumi.Input<inputs.kusto.v20191109.KeyVaultProperties>;
    /**
     * The geo-location where the resource lives
     */
    readonly location: pulumi.Input<string>;
    /**
     * Optimized auto scale definition.
     */
    readonly optimizedAutoscale?: pulumi.Input<inputs.kusto.v20191109.OptimizedAutoscale>;
    /**
     * The name of the resource group containing the Kusto cluster.
     */
    readonly resourceGroupName: pulumi.Input<string>;
    /**
     * The SKU of the cluster.
     */
    readonly sku: pulumi.Input<inputs.kusto.v20191109.AzureSku>;
    /**
     * Resource tags.
     */
    readonly tags?: pulumi.Input<{
        [key: string]: pulumi.Input<string>;
    }>;
    /**
     * The cluster's external tenants.
     */
    readonly trustedExternalTenants?: pulumi.Input<pulumi.Input<inputs.kusto.v20191109.TrustedExternalTenant>[]>;
    /**
     * Virtual network definition.
     */
    readonly virtualNetworkConfiguration?: pulumi.Input<inputs.kusto.v20191109.VirtualNetworkConfiguration>;
    /**
     * The availability zones of the cluster.
     */
    readonly zones?: pulumi.Input<pulumi.Input<string>[]>;
}