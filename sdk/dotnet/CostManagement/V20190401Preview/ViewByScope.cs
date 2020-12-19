// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.CostManagement.V20190401Preview
{
    /// <summary>
    /// States and configurations of Cost Analysis.
    /// </summary>
    [AzureNextGenResourceType("azure-nextgen:costmanagement/v20190401preview:ViewByScope")]
    public partial class ViewByScope : Pulumi.CustomResource
    {
        /// <summary>
        /// Show costs accumulated over time.
        /// </summary>
        [Output("accumulated")]
        public Output<string?> Accumulated { get; private set; } = null!;

        /// <summary>
        /// Chart type of the main view in Cost Analysis. Required.
        /// </summary>
        [Output("chart")]
        public Output<string?> Chart { get; private set; } = null!;

        /// <summary>
        /// Date the user created this view.
        /// </summary>
        [Output("createdOn")]
        public Output<string> CreatedOn { get; private set; } = null!;

        /// <summary>
        /// Has definition for data in this report config.
        /// </summary>
        [Output("dataset")]
        public Output<Outputs.ReportConfigDatasetResponse?> Dataset { get; private set; } = null!;

        /// <summary>
        /// User input name of the view. Required.
        /// </summary>
        [Output("displayName")]
        public Output<string?> DisplayName { get; private set; } = null!;

        /// <summary>
        /// eTag of the resource. To handle concurrent update scenario, this field will be used to determine whether the user is updating the latest version or not.
        /// </summary>
        [Output("eTag")]
        public Output<string?> ETag { get; private set; } = null!;

        /// <summary>
        /// List of KPIs to show in Cost Analysis UI.
        /// </summary>
        [Output("kpis")]
        public Output<ImmutableArray<Outputs.KpiPropertiesResponse>> Kpis { get; private set; } = null!;

        /// <summary>
        /// Metric to use when displaying costs.
        /// </summary>
        [Output("metric")]
        public Output<string?> Metric { get; private set; } = null!;

        /// <summary>
        /// Date when the user last modified this view.
        /// </summary>
        [Output("modifiedOn")]
        public Output<string> ModifiedOn { get; private set; } = null!;

        /// <summary>
        /// Resource name.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// Configuration of 3 sub-views in the Cost Analysis UI.
        /// </summary>
        [Output("pivots")]
        public Output<ImmutableArray<Outputs.PivotPropertiesResponse>> Pivots { get; private set; } = null!;

        /// <summary>
        /// Cost Management scope to save the view on. This includes 'subscriptions/{subscriptionId}' for subscription scope, 'subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}' for resourceGroup scope, 'providers/Microsoft.Billing/billingAccounts/{billingAccountId}' for Billing Account scope, 'providers/Microsoft.Billing/billingAccounts/{billingAccountId}/departments/{departmentId}' for Department scope, 'providers/Microsoft.Billing/billingAccounts/{billingAccountId}/enrollmentAccounts/{enrollmentAccountId}' for EnrollmentAccount scope, 'providers/Microsoft.Billing/billingAccounts/{billingAccountId}/billingProfiles/{billingProfileId}' for BillingProfile scope, 'providers/Microsoft.Billing/billingAccounts/{billingAccountId}/invoiceSections/{invoiceSectionId}' for InvoiceSection scope, 'providers/Microsoft.Management/managementGroups/{managementGroupId}' for Management Group scope, '/providers/Microsoft.CostManagement/externalBillingAccounts/{externalBillingAccountName}' for ExternalBillingAccount scope, and '/providers/Microsoft.CostManagement/externalSubscriptions/{externalSubscriptionName}' for ExternalSubscription scope.
        /// </summary>
        [Output("scope")]
        public Output<string?> Scope { get; private set; } = null!;

        /// <summary>
        /// Has time period for pulling data for the report.
        /// </summary>
        [Output("timePeriod")]
        public Output<Outputs.ReportConfigTimePeriodResponse?> TimePeriod { get; private set; } = null!;

        /// <summary>
        /// The time frame for pulling data for the report. If custom, then a specific time period must be provided.
        /// </summary>
        [Output("timeframe")]
        public Output<string> Timeframe { get; private set; } = null!;

        /// <summary>
        /// Resource type.
        /// </summary>
        [Output("type")]
        public Output<string> Type { get; private set; } = null!;


        /// <summary>
        /// Create a ViewByScope resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public ViewByScope(string name, ViewByScopeArgs args, CustomResourceOptions? options = null)
            : base("azure-nextgen:costmanagement/v20190401preview:ViewByScope", name, args ?? new ViewByScopeArgs(), MakeResourceOptions(options, ""))
        {
        }

        private ViewByScope(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("azure-nextgen:costmanagement/v20190401preview:ViewByScope", name, null, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                Aliases =
                {
                    new Pulumi.Alias { Type = "azure-nextgen:costmanagement/latest:ViewByScope"},
                    new Pulumi.Alias { Type = "azure-nextgen:costmanagement/v20191101:ViewByScope"},
                    new Pulumi.Alias { Type = "azure-nextgen:costmanagement/v20200601:ViewByScope"},
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing ViewByScope resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static ViewByScope Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new ViewByScope(name, id, options);
        }
    }

    public sealed class ViewByScopeArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Show costs accumulated over time.
        /// </summary>
        [Input("accumulated")]
        public InputUnion<string, Pulumi.AzureNextGen.CostManagement.V20190401Preview.AccumulatedType>? Accumulated { get; set; }

        /// <summary>
        /// Chart type of the main view in Cost Analysis. Required.
        /// </summary>
        [Input("chart")]
        public InputUnion<string, Pulumi.AzureNextGen.CostManagement.V20190401Preview.ChartType>? Chart { get; set; }

        /// <summary>
        /// Has definition for data in this report config.
        /// </summary>
        [Input("dataset")]
        public Input<Inputs.ReportConfigDatasetArgs>? Dataset { get; set; }

        /// <summary>
        /// User input name of the view. Required.
        /// </summary>
        [Input("displayName")]
        public Input<string>? DisplayName { get; set; }

        /// <summary>
        /// eTag of the resource. To handle concurrent update scenario, this field will be used to determine whether the user is updating the latest version or not.
        /// </summary>
        [Input("eTag")]
        public Input<string>? ETag { get; set; }

        [Input("kpis")]
        private InputList<Inputs.KpiPropertiesArgs>? _kpis;

        /// <summary>
        /// List of KPIs to show in Cost Analysis UI.
        /// </summary>
        public InputList<Inputs.KpiPropertiesArgs> Kpis
        {
            get => _kpis ?? (_kpis = new InputList<Inputs.KpiPropertiesArgs>());
            set => _kpis = value;
        }

        /// <summary>
        /// Metric to use when displaying costs.
        /// </summary>
        [Input("metric")]
        public InputUnion<string, Pulumi.AzureNextGen.CostManagement.V20190401Preview.MetricType>? Metric { get; set; }

        [Input("pivots")]
        private InputList<Inputs.PivotPropertiesArgs>? _pivots;

        /// <summary>
        /// Configuration of 3 sub-views in the Cost Analysis UI.
        /// </summary>
        public InputList<Inputs.PivotPropertiesArgs> Pivots
        {
            get => _pivots ?? (_pivots = new InputList<Inputs.PivotPropertiesArgs>());
            set => _pivots = value;
        }

        /// <summary>
        /// Cost Management scope to save the view on. This includes 'subscriptions/{subscriptionId}' for subscription scope, 'subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}' for resourceGroup scope, 'providers/Microsoft.Billing/billingAccounts/{billingAccountId}' for Billing Account scope, 'providers/Microsoft.Billing/billingAccounts/{billingAccountId}/departments/{departmentId}' for Department scope, 'providers/Microsoft.Billing/billingAccounts/{billingAccountId}/enrollmentAccounts/{enrollmentAccountId}' for EnrollmentAccount scope, 'providers/Microsoft.Billing/billingAccounts/{billingAccountId}/billingProfiles/{billingProfileId}' for BillingProfile scope, 'providers/Microsoft.Billing/billingAccounts/{billingAccountId}/invoiceSections/{invoiceSectionId}' for InvoiceSection scope, 'providers/Microsoft.Management/managementGroups/{managementGroupId}' for Management Group scope, '/providers/Microsoft.CostManagement/externalBillingAccounts/{externalBillingAccountName}' for ExternalBillingAccount scope, and '/providers/Microsoft.CostManagement/externalSubscriptions/{externalSubscriptionName}' for ExternalSubscription scope.
        /// </summary>
        [Input("scope", required: true)]
        public Input<string> Scope { get; set; } = null!;

        /// <summary>
        /// Has time period for pulling data for the report.
        /// </summary>
        [Input("timePeriod")]
        public Input<Inputs.ReportConfigTimePeriodArgs>? TimePeriod { get; set; }

        /// <summary>
        /// The time frame for pulling data for the report. If custom, then a specific time period must be provided.
        /// </summary>
        [Input("timeframe", required: true)]
        public InputUnion<string, Pulumi.AzureNextGen.CostManagement.V20190401Preview.TimeframeType> Timeframe { get; set; } = null!;

        /// <summary>
        /// The type of the report. Usage represents actual usage, forecast represents forecasted data and UsageAndForecast represents both usage and forecasted data. Actual usage and forecasted data can be differentiated based on dates.
        /// </summary>
        [Input("type", required: true)]
        public InputUnion<string, Pulumi.AzureNextGen.CostManagement.V20190401Preview.ReportType> Type { get; set; } = null!;

        /// <summary>
        /// View name
        /// </summary>
        [Input("viewName", required: true)]
        public Input<string> ViewName { get; set; } = null!;

        public ViewByScopeArgs()
        {
        }
    }
}
