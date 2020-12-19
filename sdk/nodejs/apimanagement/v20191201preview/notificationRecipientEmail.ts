// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../../utilities";

/**
 * Recipient Email details.
 */
export class NotificationRecipientEmail extends pulumi.CustomResource {
    /**
     * Get an existing NotificationRecipientEmail resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): NotificationRecipientEmail {
        return new NotificationRecipientEmail(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure-nextgen:apimanagement/v20191201preview:NotificationRecipientEmail';

    /**
     * Returns true if the given object is an instance of NotificationRecipientEmail.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is NotificationRecipientEmail {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === NotificationRecipientEmail.__pulumiType;
    }

    /**
     * User Email subscribed to notification.
     */
    public readonly email!: pulumi.Output<string | undefined>;
    /**
     * Resource name.
     */
    public /*out*/ readonly name!: pulumi.Output<string>;
    /**
     * Resource type for API Management resource.
     */
    public /*out*/ readonly type!: pulumi.Output<string>;

    /**
     * Create a NotificationRecipientEmail resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: NotificationRecipientEmailArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (!(opts && opts.id)) {
            if ((!args || args.email === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'email'");
            }
            if ((!args || args.notificationName === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'notificationName'");
            }
            if ((!args || args.resourceGroupName === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            if ((!args || args.serviceName === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'serviceName'");
            }
            inputs["email"] = args ? args.email : undefined;
            inputs["notificationName"] = args ? args.notificationName : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            inputs["serviceName"] = args ? args.serviceName : undefined;
            inputs["name"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        } else {
            inputs["email"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        const aliasOpts = { aliases: [{ type: "azure-nextgen:apimanagement/latest:NotificationRecipientEmail" }, { type: "azure-nextgen:apimanagement/v20170301:NotificationRecipientEmail" }, { type: "azure-nextgen:apimanagement/v20180101:NotificationRecipientEmail" }, { type: "azure-nextgen:apimanagement/v20180601preview:NotificationRecipientEmail" }, { type: "azure-nextgen:apimanagement/v20190101:NotificationRecipientEmail" }, { type: "azure-nextgen:apimanagement/v20191201:NotificationRecipientEmail" }, { type: "azure-nextgen:apimanagement/v20200601preview:NotificationRecipientEmail" }] };
        opts = opts ? pulumi.mergeOptions(opts, aliasOpts) : aliasOpts;
        super(NotificationRecipientEmail.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a NotificationRecipientEmail resource.
 */
export interface NotificationRecipientEmailArgs {
    /**
     * Email identifier.
     */
    readonly email: pulumi.Input<string>;
    /**
     * Notification Name Identifier.
     */
    readonly notificationName: pulumi.Input<string>;
    /**
     * The name of the resource group.
     */
    readonly resourceGroupName: pulumi.Input<string>;
    /**
     * The name of the API Management service.
     */
    readonly serviceName: pulumi.Input<string>;
}
