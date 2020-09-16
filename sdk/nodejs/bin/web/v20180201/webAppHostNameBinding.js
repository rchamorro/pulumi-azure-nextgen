"use strict";
// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***
Object.defineProperty(exports, "__esModule", { value: true });
const pulumi = require("@pulumi/pulumi");
const utilities = require("../../utilities");
/**
 * A hostname binding object.
 */
class WebAppHostNameBinding extends pulumi.CustomResource {
    constructor(name, argsOrState, opts) {
        let inputs = {};
        if (!(opts && opts.id)) {
            const args = argsOrState;
            if (!args || args.hostName === undefined) {
                throw new Error("Missing required property 'hostName'");
            }
            if (!args || args.name === undefined) {
                throw new Error("Missing required property 'name'");
            }
            if (!args || args.resourceGroupName === undefined) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            inputs["azureResourceName"] = args ? args.azureResourceName : undefined;
            inputs["azureResourceType"] = args ? args.azureResourceType : undefined;
            inputs["customHostNameDnsRecordType"] = args ? args.customHostNameDnsRecordType : undefined;
            inputs["domainId"] = args ? args.domainId : undefined;
            inputs["hostName"] = args ? args.hostName : undefined;
            inputs["hostNameType"] = args ? args.hostNameType : undefined;
            inputs["kind"] = args ? args.kind : undefined;
            inputs["name"] = args ? args.name : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            inputs["siteName"] = args ? args.siteName : undefined;
            inputs["sslState"] = args ? args.sslState : undefined;
            inputs["thumbprint"] = args ? args.thumbprint : undefined;
            inputs["type"] = undefined /*out*/;
            inputs["virtualIP"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {};
        }
        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        const aliasOpts = { aliases: [{ type: "azurerm:web/v20150801:WebAppHostNameBinding" }, { type: "azurerm:web/v20160801:WebAppHostNameBinding" }, { type: "azurerm:web/v20181101:WebAppHostNameBinding" }, { type: "azurerm:web/v20190801:WebAppHostNameBinding" }, { type: "azurerm:web/v20200601:WebAppHostNameBinding" }] };
        opts = opts ? pulumi.mergeOptions(opts, aliasOpts) : aliasOpts;
        super(WebAppHostNameBinding.__pulumiType, name, inputs, opts);
    }
    /**
     * Get an existing WebAppHostNameBinding resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    static get(name, id, opts) {
        return new WebAppHostNameBinding(name, undefined, Object.assign(Object.assign({}, opts), { id: id }));
    }
    /**
     * Returns true if the given object is an instance of WebAppHostNameBinding.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    static isInstance(obj) {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === WebAppHostNameBinding.__pulumiType;
    }
}
exports.WebAppHostNameBinding = WebAppHostNameBinding;
/** @internal */
WebAppHostNameBinding.__pulumiType = 'azurerm:web/v20180201:WebAppHostNameBinding';
//# sourceMappingURL=webAppHostNameBinding.js.map