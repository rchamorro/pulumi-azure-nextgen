"use strict";
// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***
Object.defineProperty(exports, "__esModule", { value: true });
const pulumi = require("@pulumi/pulumi");
const utilities = require("../../utilities");
/**
 * SSL certificate for an app.
 */
class Certificate extends pulumi.CustomResource {
    constructor(name, argsOrState, opts) {
        let inputs = {};
        if (!(opts && opts.id)) {
            const args = argsOrState;
            if (!args || args.location === undefined) {
                throw new Error("Missing required property 'location'");
            }
            if (!args || args.name === undefined) {
                throw new Error("Missing required property 'name'");
            }
            if (!args || args.password === undefined) {
                throw new Error("Missing required property 'password'");
            }
            if (!args || args.resourceGroupName === undefined) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            inputs["canonicalName"] = args ? args.canonicalName : undefined;
            inputs["hostNames"] = args ? args.hostNames : undefined;
            inputs["keyVaultId"] = args ? args.keyVaultId : undefined;
            inputs["keyVaultSecretName"] = args ? args.keyVaultSecretName : undefined;
            inputs["kind"] = args ? args.kind : undefined;
            inputs["location"] = args ? args.location : undefined;
            inputs["name"] = args ? args.name : undefined;
            inputs["password"] = args ? args.password : undefined;
            inputs["pfxBlob"] = args ? args.pfxBlob : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            inputs["serverFarmId"] = args ? args.serverFarmId : undefined;
            inputs["tags"] = args ? args.tags : undefined;
            inputs["cerBlob"] = undefined /*out*/;
            inputs["expirationDate"] = undefined /*out*/;
            inputs["friendlyName"] = undefined /*out*/;
            inputs["hostingEnvironmentProfile"] = undefined /*out*/;
            inputs["issueDate"] = undefined /*out*/;
            inputs["issuer"] = undefined /*out*/;
            inputs["keyVaultSecretStatus"] = undefined /*out*/;
            inputs["publicKeyHash"] = undefined /*out*/;
            inputs["selfLink"] = undefined /*out*/;
            inputs["siteName"] = undefined /*out*/;
            inputs["subjectName"] = undefined /*out*/;
            inputs["thumbprint"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
            inputs["valid"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {};
        }
        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        const aliasOpts = { aliases: [{ type: "azurerm:web/v20150801:Certificate" }, { type: "azurerm:web/v20160301:Certificate" }, { type: "azurerm:web/v20180201:Certificate" }, { type: "azurerm:web/v20181101:Certificate" }, { type: "azurerm:web/v20190801:Certificate" }] };
        opts = opts ? pulumi.mergeOptions(opts, aliasOpts) : aliasOpts;
        super(Certificate.__pulumiType, name, inputs, opts);
    }
    /**
     * Get an existing Certificate resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    static get(name, id, opts) {
        return new Certificate(name, undefined, Object.assign(Object.assign({}, opts), { id: id }));
    }
    /**
     * Returns true if the given object is an instance of Certificate.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    static isInstance(obj) {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Certificate.__pulumiType;
    }
}
exports.Certificate = Certificate;
/** @internal */
Certificate.__pulumiType = 'azurerm:web/v20200601:Certificate';
//# sourceMappingURL=certificate.js.map