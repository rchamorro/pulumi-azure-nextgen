// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.HanaOnAzure.V20171103Preview
{
    /// <summary>
    /// SAP monitor info on Azure (ARM properties and SAP monitor properties)
    /// </summary>
    [AzureNextGenResourceType("azure-nextgen:hanaonazure/v20171103preview:SapMonitor")]
    public partial class SapMonitor : Pulumi.CustomResource
    {
        /// <summary>
        /// The value indicating whether to send analytics to Microsoft
        /// </summary>
        [Output("enableCustomerAnalytics")]
        public Output<bool?> EnableCustomerAnalytics { get; private set; } = null!;

        /// <summary>
        /// MSI ID passed by customer which has access to customer's KeyVault and to be assigned to the Collector VM.
        /// </summary>
        [Output("hanaDbCredentialsMsiId")]
        public Output<string?> HanaDbCredentialsMsiId { get; private set; } = null!;

        /// <summary>
        /// Database name of the HANA instance.
        /// </summary>
        [Output("hanaDbName")]
        public Output<string?> HanaDbName { get; private set; } = null!;

        /// <summary>
        /// Database password of the HANA instance.
        /// </summary>
        [Output("hanaDbPassword")]
        public Output<string?> HanaDbPassword { get; private set; } = null!;

        /// <summary>
        /// KeyVault URL link to the password for the HANA database.
        /// </summary>
        [Output("hanaDbPasswordKeyVaultUrl")]
        public Output<string?> HanaDbPasswordKeyVaultUrl { get; private set; } = null!;

        /// <summary>
        /// Database port of the HANA instance.
        /// </summary>
        [Output("hanaDbSqlPort")]
        public Output<int?> HanaDbSqlPort { get; private set; } = null!;

        /// <summary>
        /// Database username of the HANA instance.
        /// </summary>
        [Output("hanaDbUsername")]
        public Output<string?> HanaDbUsername { get; private set; } = null!;

        /// <summary>
        /// Hostname of the HANA instance.
        /// </summary>
        [Output("hanaHostname")]
        public Output<string?> HanaHostname { get; private set; } = null!;

        /// <summary>
        /// Specifies the SAP monitor unique ID.
        /// </summary>
        [Output("hanaSubnet")]
        public Output<string?> HanaSubnet { get; private set; } = null!;

        /// <summary>
        /// Key Vault ID containing customer's HANA credentials.
        /// </summary>
        [Output("keyVaultId")]
        public Output<string?> KeyVaultId { get; private set; } = null!;

        /// <summary>
        /// Resource location
        /// </summary>
        [Output("location")]
        public Output<string?> Location { get; private set; } = null!;

        /// <summary>
        /// The ARM ID of the Log Analytics Workspace that is used for monitoring
        /// </summary>
        [Output("logAnalyticsWorkspaceArmId")]
        public Output<string?> LogAnalyticsWorkspaceArmId { get; private set; } = null!;

        /// <summary>
        /// The workspace ID of the log analytics workspace to be used for monitoring
        /// </summary>
        [Output("logAnalyticsWorkspaceId")]
        public Output<string?> LogAnalyticsWorkspaceId { get; private set; } = null!;

        /// <summary>
        /// The shared key of the log analytics workspace that is used for monitoring
        /// </summary>
        [Output("logAnalyticsWorkspaceSharedKey")]
        public Output<string?> LogAnalyticsWorkspaceSharedKey { get; private set; } = null!;

        /// <summary>
        /// The name of the resource group the SAP Monitor resources get deployed into.
        /// </summary>
        [Output("managedResourceGroupName")]
        public Output<string> ManagedResourceGroupName { get; private set; } = null!;

        /// <summary>
        /// Resource name
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// State of provisioning of the HanaInstance
        /// </summary>
        [Output("provisioningState")]
        public Output<string> ProvisioningState { get; private set; } = null!;

        /// <summary>
        /// Resource tags
        /// </summary>
        [Output("tags")]
        public Output<ImmutableDictionary<string, string>> Tags { get; private set; } = null!;

        /// <summary>
        /// Resource type
        /// </summary>
        [Output("type")]
        public Output<string> Type { get; private set; } = null!;


        /// <summary>
        /// Create a SapMonitor resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public SapMonitor(string name, SapMonitorArgs args, CustomResourceOptions? options = null)
            : base("azure-nextgen:hanaonazure/v20171103preview:SapMonitor", name, args ?? new SapMonitorArgs(), MakeResourceOptions(options, ""))
        {
        }

        private SapMonitor(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("azure-nextgen:hanaonazure/v20171103preview:SapMonitor", name, null, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                Aliases =
                {
                    new Pulumi.Alias { Type = "azure-nextgen:hanaonazure/v20200207preview:SapMonitor"},
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing SapMonitor resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static SapMonitor Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new SapMonitor(name, id, options);
        }
    }

    public sealed class SapMonitorArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The value indicating whether to send analytics to Microsoft
        /// </summary>
        [Input("enableCustomerAnalytics")]
        public Input<bool>? EnableCustomerAnalytics { get; set; }

        /// <summary>
        /// MSI ID passed by customer which has access to customer's KeyVault and to be assigned to the Collector VM.
        /// </summary>
        [Input("hanaDbCredentialsMsiId")]
        public Input<string>? HanaDbCredentialsMsiId { get; set; }

        /// <summary>
        /// Database name of the HANA instance.
        /// </summary>
        [Input("hanaDbName")]
        public Input<string>? HanaDbName { get; set; }

        /// <summary>
        /// Database password of the HANA instance.
        /// </summary>
        [Input("hanaDbPassword")]
        public Input<string>? HanaDbPassword { get; set; }

        /// <summary>
        /// KeyVault URL link to the password for the HANA database.
        /// </summary>
        [Input("hanaDbPasswordKeyVaultUrl")]
        public Input<string>? HanaDbPasswordKeyVaultUrl { get; set; }

        /// <summary>
        /// Database port of the HANA instance.
        /// </summary>
        [Input("hanaDbSqlPort")]
        public Input<int>? HanaDbSqlPort { get; set; }

        /// <summary>
        /// Database username of the HANA instance.
        /// </summary>
        [Input("hanaDbUsername")]
        public Input<string>? HanaDbUsername { get; set; }

        /// <summary>
        /// Hostname of the HANA instance.
        /// </summary>
        [Input("hanaHostname")]
        public Input<string>? HanaHostname { get; set; }

        /// <summary>
        /// Specifies the SAP monitor unique ID.
        /// </summary>
        [Input("hanaSubnet")]
        public Input<string>? HanaSubnet { get; set; }

        /// <summary>
        /// Key Vault ID containing customer's HANA credentials.
        /// </summary>
        [Input("keyVaultId")]
        public Input<string>? KeyVaultId { get; set; }

        /// <summary>
        /// Resource location
        /// </summary>
        [Input("location")]
        public Input<string>? Location { get; set; }

        /// <summary>
        /// The ARM ID of the Log Analytics Workspace that is used for monitoring
        /// </summary>
        [Input("logAnalyticsWorkspaceArmId")]
        public Input<string>? LogAnalyticsWorkspaceArmId { get; set; }

        /// <summary>
        /// The workspace ID of the log analytics workspace to be used for monitoring
        /// </summary>
        [Input("logAnalyticsWorkspaceId")]
        public Input<string>? LogAnalyticsWorkspaceId { get; set; }

        /// <summary>
        /// The shared key of the log analytics workspace that is used for monitoring
        /// </summary>
        [Input("logAnalyticsWorkspaceSharedKey")]
        public Input<string>? LogAnalyticsWorkspaceSharedKey { get; set; }

        /// <summary>
        /// Name of the resource group.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// Name of the SAP monitor resource.
        /// </summary>
        [Input("sapMonitorName", required: true)]
        public Input<string> SapMonitorName { get; set; } = null!;

        public SapMonitorArgs()
        {
        }
    }
}
