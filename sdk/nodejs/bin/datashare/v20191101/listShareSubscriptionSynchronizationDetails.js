"use strict";
// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***
Object.defineProperty(exports, "__esModule", { value: true });
const pulumi = require("@pulumi/pulumi");
const utilities = require("../../utilities");
function listShareSubscriptionSynchronizationDetails(args, opts) {
    if (!opts) {
        opts = {};
    }
    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azurerm:datashare/v20191101:listShareSubscriptionSynchronizationDetails", {
        "accountName": args.accountName,
        "filter": args.filter,
        "orderby": args.orderby,
        "resourceGroupName": args.resourceGroupName,
        "shareSubscriptionName": args.shareSubscriptionName,
        "skipToken": args.skipToken,
        "synchronizationId": args.synchronizationId,
    }, opts);
}
exports.listShareSubscriptionSynchronizationDetails = listShareSubscriptionSynchronizationDetails;
//# sourceMappingURL=listShareSubscriptionSynchronizationDetails.js.map