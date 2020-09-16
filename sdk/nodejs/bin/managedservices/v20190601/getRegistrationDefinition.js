"use strict";
// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***
Object.defineProperty(exports, "__esModule", { value: true });
const pulumi = require("@pulumi/pulumi");
const utilities = require("../../utilities");
function getRegistrationDefinition(args, opts) {
    if (!opts) {
        opts = {};
    }
    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azurerm:managedservices/v20190601:getRegistrationDefinition", {
        "registrationDefinitionId": args.registrationDefinitionId,
        "scope": args.scope,
    }, opts);
}
exports.getRegistrationDefinition = getRegistrationDefinition;
//# sourceMappingURL=getRegistrationDefinition.js.map