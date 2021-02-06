// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../../utilities";

/**
 * A share subscription data transfer object.
 */
export class ShareSubscription extends pulumi.CustomResource {
    /**
     * Get an existing ShareSubscription resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): ShareSubscription {
        return new ShareSubscription(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure-nextgen:datashare/v20181101preview:ShareSubscription';

    /**
     * Returns true if the given object is an instance of ShareSubscription.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is ShareSubscription {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === ShareSubscription.__pulumiType;
    }

    /**
     * Time at which the share subscription was created.
     */
    public /*out*/ readonly createdAt!: pulumi.Output<string>;
    /**
     * The invitation id.
     */
    public readonly invitationId!: pulumi.Output<string>;
    /**
     * Name of the azure resource
     */
    public /*out*/ readonly name!: pulumi.Output<string>;
    /**
     * Email of the provider who created the resource
     */
    public /*out*/ readonly providerEmail!: pulumi.Output<string>;
    /**
     * Name of the provider who created the resource
     */
    public /*out*/ readonly providerName!: pulumi.Output<string>;
    /**
     * Tenant name of the provider who created the resource
     */
    public /*out*/ readonly providerTenantName!: pulumi.Output<string>;
    /**
     * Provisioning state of the share subscription
     */
    public /*out*/ readonly provisioningState!: pulumi.Output<string>;
    /**
     * Description of share
     */
    public /*out*/ readonly shareDescription!: pulumi.Output<string>;
    /**
     * Kind of share
     */
    public /*out*/ readonly shareKind!: pulumi.Output<string>;
    /**
     * Name of the share
     */
    public /*out*/ readonly shareName!: pulumi.Output<string>;
    /**
     * Gets the current status of share subscription.
     */
    public /*out*/ readonly shareSubscriptionStatus!: pulumi.Output<string>;
    /**
     * Terms of a share
     */
    public /*out*/ readonly shareTerms!: pulumi.Output<string>;
    /**
     * Type of the azure resource
     */
    public /*out*/ readonly type!: pulumi.Output<string>;
    /**
     * Email of the user who created the resource
     */
    public /*out*/ readonly userEmail!: pulumi.Output<string>;
    /**
     * Name of the user who created the resource
     */
    public /*out*/ readonly userName!: pulumi.Output<string>;

    /**
     * Create a ShareSubscription resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: ShareSubscriptionArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (!(opts && opts.id)) {
            if ((!args || args.accountName === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'accountName'");
            }
            if ((!args || args.invitationId === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'invitationId'");
            }
            if ((!args || args.resourceGroupName === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            if ((!args || args.shareSubscriptionName === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'shareSubscriptionName'");
            }
            inputs["accountName"] = args ? args.accountName : undefined;
            inputs["invitationId"] = args ? args.invitationId : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            inputs["shareSubscriptionName"] = args ? args.shareSubscriptionName : undefined;
            inputs["createdAt"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["providerEmail"] = undefined /*out*/;
            inputs["providerName"] = undefined /*out*/;
            inputs["providerTenantName"] = undefined /*out*/;
            inputs["provisioningState"] = undefined /*out*/;
            inputs["shareDescription"] = undefined /*out*/;
            inputs["shareKind"] = undefined /*out*/;
            inputs["shareName"] = undefined /*out*/;
            inputs["shareSubscriptionStatus"] = undefined /*out*/;
            inputs["shareTerms"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
            inputs["userEmail"] = undefined /*out*/;
            inputs["userName"] = undefined /*out*/;
        } else {
            inputs["createdAt"] = undefined /*out*/;
            inputs["invitationId"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["providerEmail"] = undefined /*out*/;
            inputs["providerName"] = undefined /*out*/;
            inputs["providerTenantName"] = undefined /*out*/;
            inputs["provisioningState"] = undefined /*out*/;
            inputs["shareDescription"] = undefined /*out*/;
            inputs["shareKind"] = undefined /*out*/;
            inputs["shareName"] = undefined /*out*/;
            inputs["shareSubscriptionStatus"] = undefined /*out*/;
            inputs["shareTerms"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
            inputs["userEmail"] = undefined /*out*/;
            inputs["userName"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        const aliasOpts = { aliases: [{ type: "azure-nextgen:datashare/latest:ShareSubscription" }, { type: "azure-nextgen:datashare/v20191101:ShareSubscription" }, { type: "azure-nextgen:datashare/v20200901:ShareSubscription" }] };
        opts = opts ? pulumi.mergeOptions(opts, aliasOpts) : aliasOpts;
        super(ShareSubscription.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a ShareSubscription resource.
 */
export interface ShareSubscriptionArgs {
    /**
     * The name of the share account.
     */
    readonly accountName: pulumi.Input<string>;
    /**
     * The invitation id.
     */
    readonly invitationId: pulumi.Input<string>;
    /**
     * The resource group name.
     */
    readonly resourceGroupName: pulumi.Input<string>;
    /**
     * The name of the shareSubscription.
     */
    readonly shareSubscriptionName: pulumi.Input<string>;
}
