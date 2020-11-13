// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../../types";
import * as utilities from "../../utilities";

/**
 * Instance of an Azure ML Operationalization Cluster resource.
 */
export class OperationalizationCluster extends pulumi.CustomResource {
    /**
     * Get an existing OperationalizationCluster resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): OperationalizationCluster {
        return new OperationalizationCluster(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure-nextgen:machinelearningcompute/v20170601preview:OperationalizationCluster';

    /**
     * Returns true if the given object is an instance of OperationalizationCluster.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is OperationalizationCluster {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === OperationalizationCluster.__pulumiType;
    }

    /**
     * AppInsights configuration
     */
    public readonly appInsights!: pulumi.Output<outputs.machinelearningcompute.v20170601preview.AppInsightsCredentialsResponse | undefined>;
    /**
     * The cluster type.
     */
    public readonly clusterType!: pulumi.Output<string>;
    /**
     * Container Registry properties.
     */
    public readonly containerRegistry!: pulumi.Output<outputs.machinelearningcompute.v20170601preview.ContainerRegistryPropertiesResponse | undefined>;
    /**
     * Parameters for the Azure Container Service cluster.
     */
    public readonly containerService!: pulumi.Output<outputs.machinelearningcompute.v20170601preview.AcsClusterPropertiesResponse>;
    /**
     * The date and time when the cluster was created.
     */
    public /*out*/ readonly createdOn!: pulumi.Output<string>;
    /**
     * The description of the cluster.
     */
    public readonly description!: pulumi.Output<string | undefined>;
    /**
     * Contains global configuration for the web services in the cluster.
     */
    public readonly globalServiceConfiguration!: pulumi.Output<outputs.machinelearningcompute.v20170601preview.GlobalServiceConfigurationResponse | undefined>;
    /**
     * Specifies the location of the resource.
     */
    public readonly location!: pulumi.Output<string>;
    /**
     * The date and time when the cluster was last modified.
     */
    public /*out*/ readonly modifiedOn!: pulumi.Output<string>;
    /**
     * Specifies the name of the resource.
     */
    public /*out*/ readonly name!: pulumi.Output<string>;
    /**
     * The provision state of the cluster. Valid values are Unknown, Updating, Provisioning, Succeeded, and Failed.
     */
    public /*out*/ readonly provisioningState!: pulumi.Output<string>;
    /**
     * Storage Account properties.
     */
    public readonly storageAccount!: pulumi.Output<outputs.machinelearningcompute.v20170601preview.StorageAccountPropertiesResponse | undefined>;
    /**
     * Contains resource tags defined as key/value pairs.
     */
    public readonly tags!: pulumi.Output<{[key: string]: string} | undefined>;
    /**
     * Specifies the type of the resource.
     */
    public /*out*/ readonly type!: pulumi.Output<string>;

    /**
     * Create a OperationalizationCluster resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: OperationalizationClusterArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (!(opts && opts.id)) {
            if (!args || args.clusterName === undefined) {
                throw new Error("Missing required property 'clusterName'");
            }
            if (!args || args.clusterType === undefined) {
                throw new Error("Missing required property 'clusterType'");
            }
            if (!args || args.containerService === undefined) {
                throw new Error("Missing required property 'containerService'");
            }
            if (!args || args.location === undefined) {
                throw new Error("Missing required property 'location'");
            }
            if (!args || args.resourceGroupName === undefined) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            inputs["appInsights"] = args ? args.appInsights : undefined;
            inputs["clusterName"] = args ? args.clusterName : undefined;
            inputs["clusterType"] = args ? args.clusterType : undefined;
            inputs["containerRegistry"] = args ? args.containerRegistry : undefined;
            inputs["containerService"] = args ? args.containerService : undefined;
            inputs["description"] = args ? args.description : undefined;
            inputs["globalServiceConfiguration"] = args ? args.globalServiceConfiguration : undefined;
            inputs["location"] = args ? args.location : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            inputs["storageAccount"] = args ? args.storageAccount : undefined;
            inputs["tags"] = args ? args.tags : undefined;
            inputs["createdOn"] = undefined /*out*/;
            inputs["modifiedOn"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["provisioningState"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        } else {
            inputs["appInsights"] = undefined /*out*/;
            inputs["clusterType"] = undefined /*out*/;
            inputs["containerRegistry"] = undefined /*out*/;
            inputs["containerService"] = undefined /*out*/;
            inputs["createdOn"] = undefined /*out*/;
            inputs["description"] = undefined /*out*/;
            inputs["globalServiceConfiguration"] = undefined /*out*/;
            inputs["location"] = undefined /*out*/;
            inputs["modifiedOn"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["provisioningState"] = undefined /*out*/;
            inputs["storageAccount"] = undefined /*out*/;
            inputs["tags"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        const aliasOpts = { aliases: [{ type: "azure-nextgen:machinelearningcompute/v20170801preview:OperationalizationCluster" }] };
        opts = opts ? pulumi.mergeOptions(opts, aliasOpts) : aliasOpts;
        super(OperationalizationCluster.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a OperationalizationCluster resource.
 */
export interface OperationalizationClusterArgs {
    /**
     * AppInsights configuration
     */
    readonly appInsights?: pulumi.Input<inputs.machinelearningcompute.v20170601preview.AppInsightsCredentials>;
    /**
     * The name of the cluster.
     */
    readonly clusterName: pulumi.Input<string>;
    /**
     * The cluster type.
     */
    readonly clusterType: pulumi.Input<string>;
    /**
     * Container Registry properties.
     */
    readonly containerRegistry?: pulumi.Input<inputs.machinelearningcompute.v20170601preview.ContainerRegistryProperties>;
    /**
     * Parameters for the Azure Container Service cluster.
     */
    readonly containerService: pulumi.Input<inputs.machinelearningcompute.v20170601preview.AcsClusterProperties>;
    /**
     * The description of the cluster.
     */
    readonly description?: pulumi.Input<string>;
    /**
     * Contains global configuration for the web services in the cluster.
     */
    readonly globalServiceConfiguration?: pulumi.Input<inputs.machinelearningcompute.v20170601preview.GlobalServiceConfiguration>;
    /**
     * Specifies the location of the resource.
     */
    readonly location: pulumi.Input<string>;
    /**
     * Name of the resource group in which the cluster is located.
     */
    readonly resourceGroupName: pulumi.Input<string>;
    /**
     * Storage Account properties.
     */
    readonly storageAccount?: pulumi.Input<inputs.machinelearningcompute.v20170601preview.StorageAccountProperties>;
    /**
     * Contains resource tags defined as key/value pairs.
     */
    readonly tags?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
}
