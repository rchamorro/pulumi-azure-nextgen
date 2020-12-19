// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../../utilities";

/**
 * Contract details.
 */
export class ProductGroup extends pulumi.CustomResource {
    /**
     * Get an existing ProductGroup resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): ProductGroup {
        return new ProductGroup(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure-nextgen:apimanagement/v20170301:ProductGroup';

    /**
     * Returns true if the given object is an instance of ProductGroup.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is ProductGroup {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === ProductGroup.__pulumiType;
    }

    /**
     * true if the group is one of the three system groups (Administrators, Developers, or Guests); otherwise false.
     */
    public /*out*/ readonly builtIn!: pulumi.Output<boolean>;
    /**
     * Group description. Can contain HTML formatting tags.
     */
    public /*out*/ readonly description!: pulumi.Output<string | undefined>;
    /**
     * Group name.
     */
    public /*out*/ readonly displayName!: pulumi.Output<string>;
    /**
     * For external groups, this property contains the id of the group from the external identity provider, e.g. for Azure Active Directory aad://<tenant>.onmicrosoft.com/groups/<group object id>; otherwise the value is null.
     */
    public /*out*/ readonly externalId!: pulumi.Output<string | undefined>;
    /**
     * Resource name.
     */
    public /*out*/ readonly name!: pulumi.Output<string>;
    /**
     * Resource type for API Management resource.
     */
    public /*out*/ readonly type!: pulumi.Output<string>;

    /**
     * Create a ProductGroup resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: ProductGroupArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (!(opts && opts.id)) {
            if ((!args || args.groupId === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'groupId'");
            }
            if ((!args || args.productId === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'productId'");
            }
            if ((!args || args.resourceGroupName === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            if ((!args || args.serviceName === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'serviceName'");
            }
            inputs["groupId"] = args ? args.groupId : undefined;
            inputs["productId"] = args ? args.productId : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            inputs["serviceName"] = args ? args.serviceName : undefined;
            inputs["builtIn"] = undefined /*out*/;
            inputs["description"] = undefined /*out*/;
            inputs["displayName"] = undefined /*out*/;
            inputs["externalId"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        } else {
            inputs["builtIn"] = undefined /*out*/;
            inputs["description"] = undefined /*out*/;
            inputs["displayName"] = undefined /*out*/;
            inputs["externalId"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        const aliasOpts = { aliases: [{ type: "azure-nextgen:apimanagement/latest:ProductGroup" }, { type: "azure-nextgen:apimanagement/v20180101:ProductGroup" }, { type: "azure-nextgen:apimanagement/v20180601preview:ProductGroup" }, { type: "azure-nextgen:apimanagement/v20190101:ProductGroup" }, { type: "azure-nextgen:apimanagement/v20191201:ProductGroup" }, { type: "azure-nextgen:apimanagement/v20191201preview:ProductGroup" }, { type: "azure-nextgen:apimanagement/v20200601preview:ProductGroup" }] };
        opts = opts ? pulumi.mergeOptions(opts, aliasOpts) : aliasOpts;
        super(ProductGroup.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a ProductGroup resource.
 */
export interface ProductGroupArgs {
    /**
     * Group identifier. Must be unique in the current API Management service instance.
     */
    readonly groupId: pulumi.Input<string>;
    /**
     * Product identifier. Must be unique in the current API Management service instance.
     */
    readonly productId: pulumi.Input<string>;
    /**
     * The name of the resource group.
     */
    readonly resourceGroupName: pulumi.Input<string>;
    /**
     * The name of the API Management service.
     */
    readonly serviceName: pulumi.Input<string>;
}
