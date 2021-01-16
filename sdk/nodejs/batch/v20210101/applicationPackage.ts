// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../../utilities";

/**
 * An application package which represents a particular version of an application.
 */
export class ApplicationPackage extends pulumi.CustomResource {
    /**
     * Get an existing ApplicationPackage resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): ApplicationPackage {
        return new ApplicationPackage(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure-nextgen:batch/v20210101:ApplicationPackage';

    /**
     * Returns true if the given object is an instance of ApplicationPackage.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is ApplicationPackage {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === ApplicationPackage.__pulumiType;
    }

    /**
     * The ETag of the resource, used for concurrency statements.
     */
    public /*out*/ readonly etag!: pulumi.Output<string>;
    /**
     * The format of the application package, if the package is active.
     */
    public /*out*/ readonly format!: pulumi.Output<string>;
    /**
     * The time at which the package was last activated, if the package is active.
     */
    public /*out*/ readonly lastActivationTime!: pulumi.Output<string>;
    /**
     * The name of the resource.
     */
    public /*out*/ readonly name!: pulumi.Output<string>;
    /**
     * The current state of the application package.
     */
    public /*out*/ readonly state!: pulumi.Output<string>;
    /**
     * The URL for the application package in Azure Storage.
     */
    public /*out*/ readonly storageUrl!: pulumi.Output<string>;
    /**
     * The UTC time at which the Azure Storage URL will expire.
     */
    public /*out*/ readonly storageUrlExpiry!: pulumi.Output<string>;
    /**
     * The type of the resource.
     */
    public /*out*/ readonly type!: pulumi.Output<string>;

    /**
     * Create a ApplicationPackage resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: ApplicationPackageArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (!(opts && opts.id)) {
            if ((!args || args.accountName === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'accountName'");
            }
            if ((!args || args.applicationName === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'applicationName'");
            }
            if ((!args || args.resourceGroupName === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            if ((!args || args.versionName === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'versionName'");
            }
            inputs["accountName"] = args ? args.accountName : undefined;
            inputs["applicationName"] = args ? args.applicationName : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            inputs["versionName"] = args ? args.versionName : undefined;
            inputs["etag"] = undefined /*out*/;
            inputs["format"] = undefined /*out*/;
            inputs["lastActivationTime"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["state"] = undefined /*out*/;
            inputs["storageUrl"] = undefined /*out*/;
            inputs["storageUrlExpiry"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        } else {
            inputs["etag"] = undefined /*out*/;
            inputs["format"] = undefined /*out*/;
            inputs["lastActivationTime"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["state"] = undefined /*out*/;
            inputs["storageUrl"] = undefined /*out*/;
            inputs["storageUrlExpiry"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        const aliasOpts = { aliases: [{ type: "azure-nextgen:batch/latest:ApplicationPackage" }, { type: "azure-nextgen:batch/v20151201:ApplicationPackage" }, { type: "azure-nextgen:batch/v20170101:ApplicationPackage" }, { type: "azure-nextgen:batch/v20170501:ApplicationPackage" }, { type: "azure-nextgen:batch/v20170901:ApplicationPackage" }, { type: "azure-nextgen:batch/v20181201:ApplicationPackage" }, { type: "azure-nextgen:batch/v20190401:ApplicationPackage" }, { type: "azure-nextgen:batch/v20190801:ApplicationPackage" }, { type: "azure-nextgen:batch/v20200301:ApplicationPackage" }, { type: "azure-nextgen:batch/v20200501:ApplicationPackage" }, { type: "azure-nextgen:batch/v20200901:ApplicationPackage" }] };
        opts = opts ? pulumi.mergeOptions(opts, aliasOpts) : aliasOpts;
        super(ApplicationPackage.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a ApplicationPackage resource.
 */
export interface ApplicationPackageArgs {
    /**
     * The name of the Batch account.
     */
    readonly accountName: pulumi.Input<string>;
    /**
     * The name of the application. This must be unique within the account.
     */
    readonly applicationName: pulumi.Input<string>;
    /**
     * The name of the resource group that contains the Batch account.
     */
    readonly resourceGroupName: pulumi.Input<string>;
    /**
     * The version of the application.
     */
    readonly versionName: pulumi.Input<string>;
}
