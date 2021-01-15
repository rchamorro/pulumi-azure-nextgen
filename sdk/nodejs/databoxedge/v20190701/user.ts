// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * Represents a user who has access to one or more shares on the Data Box Edge/Gateway device.
 */
export class User extends pulumi.CustomResource {
    /**
     * Get an existing User resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): User {
        return new User(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure-nextgen:databoxedge/v20190701:User';

    /**
     * Returns true if the given object is an instance of User.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is User {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === User.__pulumiType;
    }

    /**
     * The password details.
     */
    public readonly encryptedPassword!: pulumi.Output<outputs.databoxedge.v20190701.AsymmetricEncryptedSecretResponse | undefined>;
    /**
     * The object name.
     */
    public readonly name!: pulumi.Output<string>;
    /**
     * List of shares that the user has rights on. This field should not be specified during user creation.
     */
    public readonly shareAccessRights!: pulumi.Output<outputs.databoxedge.v20190701.ShareAccessRightResponse[] | undefined>;
    /**
     * The hierarchical type of the object.
     */
    public /*out*/ readonly type!: pulumi.Output<string>;

    /**
     * Create a User resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: UserArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (!(opts && opts.id)) {
            if ((!args || args.deviceName === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'deviceName'");
            }
            if ((!args || args.name === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'name'");
            }
            if ((!args || args.resourceGroupName === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            inputs["deviceName"] = args ? args.deviceName : undefined;
            inputs["encryptedPassword"] = args ? args.encryptedPassword : undefined;
            inputs["name"] = args ? args.name : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            inputs["shareAccessRights"] = args ? args.shareAccessRights : undefined;
            inputs["type"] = undefined /*out*/;
        } else {
            inputs["encryptedPassword"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["shareAccessRights"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        const aliasOpts = { aliases: [{ type: "azure-nextgen:databoxedge/latest:User" }, { type: "azure-nextgen:databoxedge/v20190301:User" }, { type: "azure-nextgen:databoxedge/v20190801:User" }, { type: "azure-nextgen:databoxedge/v20200501preview:User" }, { type: "azure-nextgen:databoxedge/v20200901:User" }, { type: "azure-nextgen:databoxedge/v20200901preview:User" }] };
        opts = opts ? pulumi.mergeOptions(opts, aliasOpts) : aliasOpts;
        super(User.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a User resource.
 */
export interface UserArgs {
    /**
     * The device name.
     */
    readonly deviceName: pulumi.Input<string>;
    /**
     * The password details.
     */
    readonly encryptedPassword?: pulumi.Input<inputs.databoxedge.v20190701.AsymmetricEncryptedSecret>;
    /**
     * The user name.
     */
    readonly name: pulumi.Input<string>;
    /**
     * The resource group name.
     */
    readonly resourceGroupName: pulumi.Input<string>;
    /**
     * List of shares that the user has rights on. This field should not be specified during user creation.
     */
    readonly shareAccessRights?: pulumi.Input<pulumi.Input<inputs.databoxedge.v20190701.ShareAccessRight>[]>;
}
