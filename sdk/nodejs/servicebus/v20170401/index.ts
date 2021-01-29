// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../../utilities";

// Export members:
export * from "./disasterRecoveryConfig";
export * from "./getDisasterRecoveryConfig";
export * from "./getMigrationConfig";
export * from "./getNamespace";
export * from "./getNamespaceAuthorizationRule";
export * from "./getNamespaceNetworkRuleSet";
export * from "./getQueue";
export * from "./getQueueAuthorizationRule";
export * from "./getRule";
export * from "./getSubscription";
export * from "./getTopic";
export * from "./getTopicAuthorizationRule";
export * from "./listDisasterRecoveryConfigKeys";
export * from "./listNamespaceKeys";
export * from "./listQueueKeys";
export * from "./listTopicKeys";
export * from "./migrationConfig";
export * from "./namespace";
export * from "./namespaceAuthorizationRule";
export * from "./namespaceNetworkRuleSet";
export * from "./queue";
export * from "./queueAuthorizationRule";
export * from "./rule";
export * from "./subscription";
export * from "./topic";
export * from "./topicAuthorizationRule";

// Export enums:
export * from "../../types/enums/servicebus/v20170401";

// Import resources to register:
import { DisasterRecoveryConfig } from "./disasterRecoveryConfig";
import { MigrationConfig } from "./migrationConfig";
import { Namespace } from "./namespace";
import { NamespaceAuthorizationRule } from "./namespaceAuthorizationRule";
import { NamespaceNetworkRuleSet } from "./namespaceNetworkRuleSet";
import { Queue } from "./queue";
import { QueueAuthorizationRule } from "./queueAuthorizationRule";
import { Rule } from "./rule";
import { Subscription } from "./subscription";
import { Topic } from "./topic";
import { TopicAuthorizationRule } from "./topicAuthorizationRule";

const _module = {
    version: utilities.getVersion(),
    construct: (name: string, type: string, urn: string): pulumi.Resource => {
        switch (type) {
            case "azure-nextgen:servicebus/v20170401:DisasterRecoveryConfig":
                return new DisasterRecoveryConfig(name, <any>undefined, { urn })
            case "azure-nextgen:servicebus/v20170401:MigrationConfig":
                return new MigrationConfig(name, <any>undefined, { urn })
            case "azure-nextgen:servicebus/v20170401:Namespace":
                return new Namespace(name, <any>undefined, { urn })
            case "azure-nextgen:servicebus/v20170401:NamespaceAuthorizationRule":
                return new NamespaceAuthorizationRule(name, <any>undefined, { urn })
            case "azure-nextgen:servicebus/v20170401:NamespaceNetworkRuleSet":
                return new NamespaceNetworkRuleSet(name, <any>undefined, { urn })
            case "azure-nextgen:servicebus/v20170401:Queue":
                return new Queue(name, <any>undefined, { urn })
            case "azure-nextgen:servicebus/v20170401:QueueAuthorizationRule":
                return new QueueAuthorizationRule(name, <any>undefined, { urn })
            case "azure-nextgen:servicebus/v20170401:Rule":
                return new Rule(name, <any>undefined, { urn })
            case "azure-nextgen:servicebus/v20170401:Subscription":
                return new Subscription(name, <any>undefined, { urn })
            case "azure-nextgen:servicebus/v20170401:Topic":
                return new Topic(name, <any>undefined, { urn })
            case "azure-nextgen:servicebus/v20170401:TopicAuthorizationRule":
                return new TopicAuthorizationRule(name, <any>undefined, { urn })
            default:
                throw new Error(`unknown resource type ${type}`);
        }
    },
};
pulumi.runtime.registerResourceModule("azure-nextgen", "servicebus/v20170401", _module)
