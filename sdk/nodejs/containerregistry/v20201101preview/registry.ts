// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../../types";
import * as utilities from "../../utilities";

/**
 * An object that represents a container registry.
 */
export class Registry extends pulumi.CustomResource {
    /**
     * Get an existing Registry resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): Registry {
        return new Registry(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure-nextgen:containerregistry/v20201101preview:Registry';

    /**
     * Returns true if the given object is an instance of Registry.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is Registry {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Registry.__pulumiType;
    }

    /**
     * The value that indicates whether the admin user is enabled.
     */
    public readonly adminUserEnabled!: pulumi.Output<boolean | undefined>;
    /**
     * The creation date of the container registry in ISO8601 format.
     */
    public /*out*/ readonly creationDate!: pulumi.Output<string>;
    /**
     * Enable a single data endpoint per region for serving data.
     */
    public readonly dataEndpointEnabled!: pulumi.Output<boolean | undefined>;
    /**
     * List of host names that will serve data when dataEndpointEnabled is true.
     */
    public /*out*/ readonly dataEndpointHostNames!: pulumi.Output<string[]>;
    /**
     * The encryption settings of container registry.
     */
    public readonly encryption!: pulumi.Output<outputs.containerregistry.v20201101preview.EncryptionPropertyResponse | undefined>;
    /**
     * The identity of the container registry.
     */
    public readonly identity!: pulumi.Output<outputs.containerregistry.v20201101preview.IdentityPropertiesResponse | undefined>;
    /**
     * The location of the resource. This cannot be changed after the resource is created.
     */
    public readonly location!: pulumi.Output<string>;
    /**
     * The URL that can be used to log into the container registry.
     */
    public /*out*/ readonly loginServer!: pulumi.Output<string>;
    /**
     * The name of the resource.
     */
    public /*out*/ readonly name!: pulumi.Output<string>;
    /**
     * Whether to allow trusted Azure services to access a network restricted registry.
     */
    public readonly networkRuleBypassOptions!: pulumi.Output<string | undefined>;
    /**
     * The network rule set for a container registry.
     */
    public readonly networkRuleSet!: pulumi.Output<outputs.containerregistry.v20201101preview.NetworkRuleSetResponse | undefined>;
    /**
     * The policies for a container registry.
     */
    public readonly policies!: pulumi.Output<outputs.containerregistry.v20201101preview.PoliciesResponse | undefined>;
    /**
     * List of private endpoint connections for a container registry.
     */
    public /*out*/ readonly privateEndpointConnections!: pulumi.Output<outputs.containerregistry.v20201101preview.PrivateEndpointConnectionResponse[]>;
    /**
     * The provisioning state of the container registry at the time the operation was called.
     */
    public /*out*/ readonly provisioningState!: pulumi.Output<string>;
    /**
     * Whether or not public network access is allowed for the container registry.
     */
    public readonly publicNetworkAccess!: pulumi.Output<string | undefined>;
    /**
     * The SKU of the container registry.
     */
    public readonly sku!: pulumi.Output<outputs.containerregistry.v20201101preview.SkuResponse>;
    /**
     * The status of the container registry at the time the operation was called.
     */
    public /*out*/ readonly status!: pulumi.Output<outputs.containerregistry.v20201101preview.StatusResponse>;
    /**
     * The properties of the storage account for the container registry. Only applicable to Classic SKU.
     */
    public readonly storageAccount!: pulumi.Output<outputs.containerregistry.v20201101preview.StorageAccountPropertiesResponse | undefined>;
    /**
     * Metadata pertaining to creation and last modification of the resource.
     */
    public /*out*/ readonly systemData!: pulumi.Output<outputs.containerregistry.v20201101preview.SystemDataResponse>;
    /**
     * The tags of the resource.
     */
    public readonly tags!: pulumi.Output<{[key: string]: string} | undefined>;
    /**
     * The type of the resource.
     */
    public /*out*/ readonly type!: pulumi.Output<string>;
    /**
     * Whether or not zone redundancy is enabled for this container registry
     */
    public readonly zoneRedundancy!: pulumi.Output<string | undefined>;

    /**
     * Create a Registry resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: RegistryArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (!(opts && opts.id)) {
            if (!args || args.location === undefined) {
                throw new Error("Missing required property 'location'");
            }
            if (!args || args.registryName === undefined) {
                throw new Error("Missing required property 'registryName'");
            }
            if (!args || args.resourceGroupName === undefined) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            if (!args || args.sku === undefined) {
                throw new Error("Missing required property 'sku'");
            }
            inputs["adminUserEnabled"] = args ? args.adminUserEnabled : undefined;
            inputs["dataEndpointEnabled"] = args ? args.dataEndpointEnabled : undefined;
            inputs["encryption"] = args ? args.encryption : undefined;
            inputs["identity"] = args ? args.identity : undefined;
            inputs["location"] = args ? args.location : undefined;
            inputs["networkRuleBypassOptions"] = args ? args.networkRuleBypassOptions : undefined;
            inputs["networkRuleSet"] = args ? args.networkRuleSet : undefined;
            inputs["policies"] = args ? args.policies : undefined;
            inputs["publicNetworkAccess"] = args ? args.publicNetworkAccess : undefined;
            inputs["registryName"] = args ? args.registryName : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            inputs["sku"] = args ? args.sku : undefined;
            inputs["storageAccount"] = args ? args.storageAccount : undefined;
            inputs["tags"] = args ? args.tags : undefined;
            inputs["zoneRedundancy"] = args ? args.zoneRedundancy : undefined;
            inputs["creationDate"] = undefined /*out*/;
            inputs["dataEndpointHostNames"] = undefined /*out*/;
            inputs["loginServer"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["privateEndpointConnections"] = undefined /*out*/;
            inputs["provisioningState"] = undefined /*out*/;
            inputs["status"] = undefined /*out*/;
            inputs["systemData"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        } else {
            inputs["adminUserEnabled"] = undefined /*out*/;
            inputs["creationDate"] = undefined /*out*/;
            inputs["dataEndpointEnabled"] = undefined /*out*/;
            inputs["dataEndpointHostNames"] = undefined /*out*/;
            inputs["encryption"] = undefined /*out*/;
            inputs["identity"] = undefined /*out*/;
            inputs["location"] = undefined /*out*/;
            inputs["loginServer"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["networkRuleBypassOptions"] = undefined /*out*/;
            inputs["networkRuleSet"] = undefined /*out*/;
            inputs["policies"] = undefined /*out*/;
            inputs["privateEndpointConnections"] = undefined /*out*/;
            inputs["provisioningState"] = undefined /*out*/;
            inputs["publicNetworkAccess"] = undefined /*out*/;
            inputs["sku"] = undefined /*out*/;
            inputs["status"] = undefined /*out*/;
            inputs["storageAccount"] = undefined /*out*/;
            inputs["systemData"] = undefined /*out*/;
            inputs["tags"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
            inputs["zoneRedundancy"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        const aliasOpts = { aliases: [{ type: "azure-nextgen:containerregistry/latest:Registry" }, { type: "azure-nextgen:containerregistry/v20160627preview:Registry" }, { type: "azure-nextgen:containerregistry/v20170301:Registry" }, { type: "azure-nextgen:containerregistry/v20170601preview:Registry" }, { type: "azure-nextgen:containerregistry/v20171001:Registry" }, { type: "azure-nextgen:containerregistry/v20190501:Registry" }, { type: "azure-nextgen:containerregistry/v20191201preview:Registry" }] };
        opts = opts ? pulumi.mergeOptions(opts, aliasOpts) : aliasOpts;
        super(Registry.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a Registry resource.
 */
export interface RegistryArgs {
    /**
     * The value that indicates whether the admin user is enabled.
     */
    readonly adminUserEnabled?: pulumi.Input<boolean>;
    /**
     * Enable a single data endpoint per region for serving data.
     */
    readonly dataEndpointEnabled?: pulumi.Input<boolean>;
    /**
     * The encryption settings of container registry.
     */
    readonly encryption?: pulumi.Input<inputs.containerregistry.v20201101preview.EncryptionProperty>;
    /**
     * The identity of the container registry.
     */
    readonly identity?: pulumi.Input<inputs.containerregistry.v20201101preview.IdentityProperties>;
    /**
     * The location of the resource. This cannot be changed after the resource is created.
     */
    readonly location: pulumi.Input<string>;
    /**
     * Whether to allow trusted Azure services to access a network restricted registry.
     */
    readonly networkRuleBypassOptions?: pulumi.Input<string>;
    /**
     * The network rule set for a container registry.
     */
    readonly networkRuleSet?: pulumi.Input<inputs.containerregistry.v20201101preview.NetworkRuleSet>;
    /**
     * The policies for a container registry.
     */
    readonly policies?: pulumi.Input<inputs.containerregistry.v20201101preview.Policies>;
    /**
     * Whether or not public network access is allowed for the container registry.
     */
    readonly publicNetworkAccess?: pulumi.Input<string>;
    /**
     * The name of the container registry.
     */
    readonly registryName: pulumi.Input<string>;
    /**
     * The name of the resource group to which the container registry belongs.
     */
    readonly resourceGroupName: pulumi.Input<string>;
    /**
     * The SKU of the container registry.
     */
    readonly sku: pulumi.Input<inputs.containerregistry.v20201101preview.Sku>;
    /**
     * The properties of the storage account for the container registry. Only applicable to Classic SKU.
     */
    readonly storageAccount?: pulumi.Input<inputs.containerregistry.v20201101preview.StorageAccountProperties>;
    /**
     * The tags of the resource.
     */
    readonly tags?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    /**
     * Whether or not zone redundancy is enabled for this container registry
     */
    readonly zoneRedundancy?: pulumi.Input<string>;
}