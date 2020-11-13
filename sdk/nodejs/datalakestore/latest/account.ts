// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../../types";
import * as utilities from "../../utilities";

/**
 * Data Lake Store account information.
 */
export class Account extends pulumi.CustomResource {
    /**
     * Get an existing Account resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): Account {
        return new Account(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure-nextgen:datalakestore/latest:Account';

    /**
     * Returns true if the given object is an instance of Account.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is Account {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Account.__pulumiType;
    }

    /**
     * The unique identifier associated with this Data Lake Store account.
     */
    public /*out*/ readonly accountId!: pulumi.Output<string>;
    /**
     * The account creation time.
     */
    public /*out*/ readonly creationTime!: pulumi.Output<string>;
    /**
     * The commitment tier in use for the current month.
     */
    public /*out*/ readonly currentTier!: pulumi.Output<string>;
    /**
     * The default owner group for all new folders and files created in the Data Lake Store account.
     */
    public readonly defaultGroup!: pulumi.Output<string>;
    /**
     * The Key Vault encryption configuration.
     */
    public readonly encryptionConfig!: pulumi.Output<outputs.datalakestore.latest.EncryptionConfigResponse>;
    /**
     * The current state of encryption provisioning for this Data Lake Store account.
     */
    public /*out*/ readonly encryptionProvisioningState!: pulumi.Output<string>;
    /**
     * The current state of encryption for this Data Lake Store account.
     */
    public readonly encryptionState!: pulumi.Output<string>;
    /**
     * The full CName endpoint for this account.
     */
    public /*out*/ readonly endpoint!: pulumi.Output<string>;
    /**
     * The current state of allowing or disallowing IPs originating within Azure through the firewall. If the firewall is disabled, this is not enforced.
     */
    public readonly firewallAllowAzureIps!: pulumi.Output<string>;
    /**
     * The list of firewall rules associated with this Data Lake Store account.
     */
    public readonly firewallRules!: pulumi.Output<outputs.datalakestore.latest.FirewallRuleResponse[]>;
    /**
     * The current state of the IP address firewall for this Data Lake Store account.
     */
    public readonly firewallState!: pulumi.Output<string>;
    /**
     * The Key Vault encryption identity, if any.
     */
    public readonly identity!: pulumi.Output<outputs.datalakestore.latest.EncryptionIdentityResponse>;
    /**
     * The account last modified time.
     */
    public /*out*/ readonly lastModifiedTime!: pulumi.Output<string>;
    /**
     * The resource location.
     */
    public readonly location!: pulumi.Output<string>;
    /**
     * The resource name.
     */
    public /*out*/ readonly name!: pulumi.Output<string>;
    /**
     * The commitment tier to use for next month.
     */
    public readonly newTier!: pulumi.Output<string>;
    /**
     * The provisioning status of the Data Lake Store account.
     */
    public /*out*/ readonly provisioningState!: pulumi.Output<string>;
    /**
     * The state of the Data Lake Store account.
     */
    public /*out*/ readonly state!: pulumi.Output<string>;
    /**
     * The resource tags.
     */
    public readonly tags!: pulumi.Output<{[key: string]: string}>;
    /**
     * The current state of the trusted identity provider feature for this Data Lake Store account.
     */
    public readonly trustedIdProviderState!: pulumi.Output<string>;
    /**
     * The list of trusted identity providers associated with this Data Lake Store account.
     */
    public readonly trustedIdProviders!: pulumi.Output<outputs.datalakestore.latest.TrustedIdProviderResponse[]>;
    /**
     * The resource type.
     */
    public /*out*/ readonly type!: pulumi.Output<string>;
    /**
     * The list of virtual network rules associated with this Data Lake Store account.
     */
    public readonly virtualNetworkRules!: pulumi.Output<outputs.datalakestore.latest.VirtualNetworkRuleResponse[]>;

    /**
     * Create a Account resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: AccountArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (!(opts && opts.id)) {
            if (!args || args.accountName === undefined) {
                throw new Error("Missing required property 'accountName'");
            }
            if (!args || args.location === undefined) {
                throw new Error("Missing required property 'location'");
            }
            if (!args || args.resourceGroupName === undefined) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            inputs["accountName"] = args ? args.accountName : undefined;
            inputs["defaultGroup"] = args ? args.defaultGroup : undefined;
            inputs["encryptionConfig"] = args ? args.encryptionConfig : undefined;
            inputs["encryptionState"] = args ? args.encryptionState : undefined;
            inputs["firewallAllowAzureIps"] = args ? args.firewallAllowAzureIps : undefined;
            inputs["firewallRules"] = args ? args.firewallRules : undefined;
            inputs["firewallState"] = args ? args.firewallState : undefined;
            inputs["identity"] = args ? args.identity : undefined;
            inputs["location"] = args ? args.location : undefined;
            inputs["newTier"] = args ? args.newTier : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            inputs["tags"] = args ? args.tags : undefined;
            inputs["trustedIdProviderState"] = args ? args.trustedIdProviderState : undefined;
            inputs["trustedIdProviders"] = args ? args.trustedIdProviders : undefined;
            inputs["virtualNetworkRules"] = args ? args.virtualNetworkRules : undefined;
            inputs["accountId"] = undefined /*out*/;
            inputs["creationTime"] = undefined /*out*/;
            inputs["currentTier"] = undefined /*out*/;
            inputs["encryptionProvisioningState"] = undefined /*out*/;
            inputs["endpoint"] = undefined /*out*/;
            inputs["lastModifiedTime"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["provisioningState"] = undefined /*out*/;
            inputs["state"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        } else {
            inputs["accountId"] = undefined /*out*/;
            inputs["creationTime"] = undefined /*out*/;
            inputs["currentTier"] = undefined /*out*/;
            inputs["defaultGroup"] = undefined /*out*/;
            inputs["encryptionConfig"] = undefined /*out*/;
            inputs["encryptionProvisioningState"] = undefined /*out*/;
            inputs["encryptionState"] = undefined /*out*/;
            inputs["endpoint"] = undefined /*out*/;
            inputs["firewallAllowAzureIps"] = undefined /*out*/;
            inputs["firewallRules"] = undefined /*out*/;
            inputs["firewallState"] = undefined /*out*/;
            inputs["identity"] = undefined /*out*/;
            inputs["lastModifiedTime"] = undefined /*out*/;
            inputs["location"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["newTier"] = undefined /*out*/;
            inputs["provisioningState"] = undefined /*out*/;
            inputs["state"] = undefined /*out*/;
            inputs["tags"] = undefined /*out*/;
            inputs["trustedIdProviderState"] = undefined /*out*/;
            inputs["trustedIdProviders"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
            inputs["virtualNetworkRules"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        const aliasOpts = { aliases: [{ type: "azure-nextgen:datalakestore/v20161101:Account" }] };
        opts = opts ? pulumi.mergeOptions(opts, aliasOpts) : aliasOpts;
        super(Account.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a Account resource.
 */
export interface AccountArgs {
    /**
     * The name of the Data Lake Store account.
     */
    readonly accountName: pulumi.Input<string>;
    /**
     * The default owner group for all new folders and files created in the Data Lake Store account.
     */
    readonly defaultGroup?: pulumi.Input<string>;
    /**
     * The Key Vault encryption configuration.
     */
    readonly encryptionConfig?: pulumi.Input<inputs.datalakestore.latest.EncryptionConfig>;
    /**
     * The current state of encryption for this Data Lake Store account.
     */
    readonly encryptionState?: pulumi.Input<string>;
    /**
     * The current state of allowing or disallowing IPs originating within Azure through the firewall. If the firewall is disabled, this is not enforced.
     */
    readonly firewallAllowAzureIps?: pulumi.Input<string>;
    /**
     * The list of firewall rules associated with this Data Lake Store account.
     */
    readonly firewallRules?: pulumi.Input<pulumi.Input<inputs.datalakestore.latest.CreateFirewallRuleWithAccountParameters>[]>;
    /**
     * The current state of the IP address firewall for this Data Lake Store account.
     */
    readonly firewallState?: pulumi.Input<string>;
    /**
     * The Key Vault encryption identity, if any.
     */
    readonly identity?: pulumi.Input<inputs.datalakestore.latest.EncryptionIdentity>;
    /**
     * The resource location.
     */
    readonly location: pulumi.Input<string>;
    /**
     * The commitment tier to use for next month.
     */
    readonly newTier?: pulumi.Input<string>;
    /**
     * The name of the Azure resource group.
     */
    readonly resourceGroupName: pulumi.Input<string>;
    /**
     * The resource tags.
     */
    readonly tags?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    /**
     * The current state of the trusted identity provider feature for this Data Lake Store account.
     */
    readonly trustedIdProviderState?: pulumi.Input<string>;
    /**
     * The list of trusted identity providers associated with this Data Lake Store account.
     */
    readonly trustedIdProviders?: pulumi.Input<pulumi.Input<inputs.datalakestore.latest.CreateTrustedIdProviderWithAccountParameters>[]>;
    /**
     * The list of virtual network rules associated with this Data Lake Store account.
     */
    readonly virtualNetworkRules?: pulumi.Input<pulumi.Input<inputs.datalakestore.latest.CreateVirtualNetworkRuleWithAccountParameters>[]>;
}
