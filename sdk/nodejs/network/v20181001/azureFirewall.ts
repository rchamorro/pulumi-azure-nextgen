// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * Azure Firewall resource
 */
export class AzureFirewall extends pulumi.CustomResource {
    /**
     * Get an existing AzureFirewall resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): AzureFirewall {
        return new AzureFirewall(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure-nextgen:network/v20181001:AzureFirewall';

    /**
     * Returns true if the given object is an instance of AzureFirewall.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is AzureFirewall {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === AzureFirewall.__pulumiType;
    }

    /**
     * Collection of application rule collections used by Azure Firewall.
     */
    public readonly applicationRuleCollections!: pulumi.Output<outputs.network.v20181001.AzureFirewallApplicationRuleCollectionResponse[] | undefined>;
    /**
     * Gets a unique read-only string that changes whenever the resource is updated.
     */
    public /*out*/ readonly etag!: pulumi.Output<string>;
    /**
     * IP configuration of the Azure Firewall resource.
     */
    public readonly ipConfigurations!: pulumi.Output<outputs.network.v20181001.AzureFirewallIPConfigurationResponse[] | undefined>;
    /**
     * Resource location.
     */
    public readonly location!: pulumi.Output<string | undefined>;
    /**
     * Resource name.
     */
    public /*out*/ readonly name!: pulumi.Output<string>;
    /**
     * Collection of NAT rule collections used by Azure Firewall.
     */
    public readonly natRuleCollections!: pulumi.Output<outputs.network.v20181001.AzureFirewallNatRuleCollectionResponse[] | undefined>;
    /**
     * Collection of network rule collections used by Azure Firewall.
     */
    public readonly networkRuleCollections!: pulumi.Output<outputs.network.v20181001.AzureFirewallNetworkRuleCollectionResponse[] | undefined>;
    /**
     * The provisioning state of the resource.
     */
    public /*out*/ readonly provisioningState!: pulumi.Output<string>;
    /**
     * Resource tags.
     */
    public readonly tags!: pulumi.Output<{[key: string]: string} | undefined>;
    /**
     * Resource type.
     */
    public /*out*/ readonly type!: pulumi.Output<string>;

    /**
     * Create a AzureFirewall resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: AzureFirewallArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (!(opts && opts.id)) {
            if ((!args || args.azureFirewallName === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'azureFirewallName'");
            }
            if ((!args || args.resourceGroupName === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            inputs["applicationRuleCollections"] = args ? args.applicationRuleCollections : undefined;
            inputs["azureFirewallName"] = args ? args.azureFirewallName : undefined;
            inputs["id"] = args ? args.id : undefined;
            inputs["ipConfigurations"] = args ? args.ipConfigurations : undefined;
            inputs["location"] = args ? args.location : undefined;
            inputs["natRuleCollections"] = args ? args.natRuleCollections : undefined;
            inputs["networkRuleCollections"] = args ? args.networkRuleCollections : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            inputs["tags"] = args ? args.tags : undefined;
            inputs["etag"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["provisioningState"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        } else {
            inputs["applicationRuleCollections"] = undefined /*out*/;
            inputs["etag"] = undefined /*out*/;
            inputs["ipConfigurations"] = undefined /*out*/;
            inputs["location"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["natRuleCollections"] = undefined /*out*/;
            inputs["networkRuleCollections"] = undefined /*out*/;
            inputs["provisioningState"] = undefined /*out*/;
            inputs["tags"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        const aliasOpts = { aliases: [{ type: "azure-nextgen:network/latest:AzureFirewall" }, { type: "azure-nextgen:network/v20180401:AzureFirewall" }, { type: "azure-nextgen:network/v20180601:AzureFirewall" }, { type: "azure-nextgen:network/v20180701:AzureFirewall" }, { type: "azure-nextgen:network/v20180801:AzureFirewall" }, { type: "azure-nextgen:network/v20181101:AzureFirewall" }, { type: "azure-nextgen:network/v20181201:AzureFirewall" }, { type: "azure-nextgen:network/v20190201:AzureFirewall" }, { type: "azure-nextgen:network/v20190401:AzureFirewall" }, { type: "azure-nextgen:network/v20190601:AzureFirewall" }, { type: "azure-nextgen:network/v20190701:AzureFirewall" }, { type: "azure-nextgen:network/v20190801:AzureFirewall" }, { type: "azure-nextgen:network/v20190901:AzureFirewall" }, { type: "azure-nextgen:network/v20191101:AzureFirewall" }, { type: "azure-nextgen:network/v20191201:AzureFirewall" }, { type: "azure-nextgen:network/v20200301:AzureFirewall" }, { type: "azure-nextgen:network/v20200401:AzureFirewall" }, { type: "azure-nextgen:network/v20200501:AzureFirewall" }, { type: "azure-nextgen:network/v20200601:AzureFirewall" }, { type: "azure-nextgen:network/v20200701:AzureFirewall" }, { type: "azure-nextgen:network/v20200801:AzureFirewall" }] };
        opts = opts ? pulumi.mergeOptions(opts, aliasOpts) : aliasOpts;
        super(AzureFirewall.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a AzureFirewall resource.
 */
export interface AzureFirewallArgs {
    /**
     * Collection of application rule collections used by Azure Firewall.
     */
    readonly applicationRuleCollections?: pulumi.Input<pulumi.Input<inputs.network.v20181001.AzureFirewallApplicationRuleCollection>[]>;
    /**
     * The name of the Azure Firewall.
     */
    readonly azureFirewallName: pulumi.Input<string>;
    /**
     * Resource ID.
     */
    readonly id?: pulumi.Input<string>;
    /**
     * IP configuration of the Azure Firewall resource.
     */
    readonly ipConfigurations?: pulumi.Input<pulumi.Input<inputs.network.v20181001.AzureFirewallIPConfiguration>[]>;
    /**
     * Resource location.
     */
    readonly location?: pulumi.Input<string>;
    /**
     * Collection of NAT rule collections used by Azure Firewall.
     */
    readonly natRuleCollections?: pulumi.Input<pulumi.Input<inputs.network.v20181001.AzureFirewallNatRuleCollection>[]>;
    /**
     * Collection of network rule collections used by Azure Firewall.
     */
    readonly networkRuleCollections?: pulumi.Input<pulumi.Input<inputs.network.v20181001.AzureFirewallNetworkRuleCollection>[]>;
    /**
     * The name of the resource group.
     */
    readonly resourceGroupName: pulumi.Input<string>;
    /**
     * Resource tags.
     */
    readonly tags?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
}
