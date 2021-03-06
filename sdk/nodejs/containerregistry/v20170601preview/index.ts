// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../../utilities";

// Export members:
export * from "./getRegistry";
export * from "./getReplication";
export * from "./getWebhook";
export * from "./getWebhookCallbackConfig";
export * from "./listRegistryCredentials";
export * from "./listWebhookEvents";
export * from "./registry";
export * from "./replication";
export * from "./webhook";

// Export enums:
export * from "../../types/enums/containerregistry/v20170601preview";

// Import resources to register:
import { Registry } from "./registry";
import { Replication } from "./replication";
import { Webhook } from "./webhook";

const _module = {
    version: utilities.getVersion(),
    construct: (name: string, type: string, urn: string): pulumi.Resource => {
        switch (type) {
            case "azure-nextgen:containerregistry/v20170601preview:Registry":
                return new Registry(name, <any>undefined, { urn })
            case "azure-nextgen:containerregistry/v20170601preview:Replication":
                return new Replication(name, <any>undefined, { urn })
            case "azure-nextgen:containerregistry/v20170601preview:Webhook":
                return new Webhook(name, <any>undefined, { urn })
            default:
                throw new Error(`unknown resource type ${type}`);
        }
    },
};
pulumi.runtime.registerResourceModule("azure-nextgen", "containerregistry/v20170601preview", _module)
