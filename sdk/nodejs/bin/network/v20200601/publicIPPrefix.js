"use strict";
// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***
Object.defineProperty(exports, "__esModule", { value: true });
const pulumi = require("@pulumi/pulumi");
const utilities = require("../../utilities");
/**
 * Public IP prefix resource.
 */
class PublicIPPrefix extends pulumi.CustomResource {
    constructor(name, argsOrState, opts) {
        let inputs = {};
        if (!(opts && opts.id)) {
            const args = argsOrState;
            if (!args || args.publicIpPrefixName === undefined) {
                throw new Error("Missing required property 'publicIpPrefixName'");
            }
            if (!args || args.resourceGroupName === undefined) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            inputs["customIPPrefix"] = args ? args.customIPPrefix : undefined;
            inputs["id"] = args ? args.id : undefined;
            inputs["ipTags"] = args ? args.ipTags : undefined;
            inputs["location"] = args ? args.location : undefined;
            inputs["prefixLength"] = args ? args.prefixLength : undefined;
            inputs["publicIPAddressVersion"] = args ? args.publicIPAddressVersion : undefined;
            inputs["publicIpPrefixName"] = args ? args.publicIpPrefixName : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            inputs["sku"] = args ? args.sku : undefined;
            inputs["tags"] = args ? args.tags : undefined;
            inputs["zones"] = args ? args.zones : undefined;
            inputs["etag"] = undefined /*out*/;
            inputs["ipPrefix"] = undefined /*out*/;
            inputs["loadBalancerFrontendIpConfiguration"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["provisioningState"] = undefined /*out*/;
            inputs["publicIPAddresses"] = undefined /*out*/;
            inputs["resourceGuid"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {};
        }
        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        const aliasOpts = { aliases: [{ type: "azurerm:network/v20180701:PublicIPPrefix" }, { type: "azurerm:network/v20180801:PublicIPPrefix" }, { type: "azurerm:network/v20181001:PublicIPPrefix" }, { type: "azurerm:network/v20181101:PublicIPPrefix" }, { type: "azurerm:network/v20181201:PublicIPPrefix" }, { type: "azurerm:network/v20190201:PublicIPPrefix" }, { type: "azurerm:network/v20190401:PublicIPPrefix" }, { type: "azurerm:network/v20190601:PublicIPPrefix" }, { type: "azurerm:network/v20190701:PublicIPPrefix" }, { type: "azurerm:network/v20190801:PublicIPPrefix" }, { type: "azurerm:network/v20190901:PublicIPPrefix" }, { type: "azurerm:network/v20191101:PublicIPPrefix" }, { type: "azurerm:network/v20191201:PublicIPPrefix" }, { type: "azurerm:network/v20200301:PublicIPPrefix" }, { type: "azurerm:network/v20200401:PublicIPPrefix" }, { type: "azurerm:network/v20200501:PublicIPPrefix" }] };
        opts = opts ? pulumi.mergeOptions(opts, aliasOpts) : aliasOpts;
        super(PublicIPPrefix.__pulumiType, name, inputs, opts);
    }
    /**
     * Get an existing PublicIPPrefix resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    static get(name, id, opts) {
        return new PublicIPPrefix(name, undefined, Object.assign(Object.assign({}, opts), { id: id }));
    }
    /**
     * Returns true if the given object is an instance of PublicIPPrefix.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    static isInstance(obj) {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === PublicIPPrefix.__pulumiType;
    }
}
exports.PublicIPPrefix = PublicIPPrefix;
/** @internal */
PublicIPPrefix.__pulumiType = 'azurerm:network/v20200601:PublicIPPrefix';
//# sourceMappingURL=publicIPPrefix.js.map