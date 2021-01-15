// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Web.V20181101.Inputs
{

    /// <summary>
    /// Configuration of an App Service app.
    /// </summary>
    public sealed class SiteConfigArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// &lt;code&gt;true&lt;/code&gt; if Always On is enabled; otherwise, &lt;code&gt;false&lt;/code&gt;.
        /// </summary>
        [Input("alwaysOn")]
        public Input<bool>? AlwaysOn { get; set; }

        /// <summary>
        /// Information about the formal API definition for the app.
        /// </summary>
        [Input("apiDefinition")]
        public Input<Inputs.ApiDefinitionInfoArgs>? ApiDefinition { get; set; }

        /// <summary>
        /// App command line to launch.
        /// </summary>
        [Input("appCommandLine")]
        public Input<string>? AppCommandLine { get; set; }

        [Input("appSettings")]
        private InputList<Inputs.NameValuePairArgs>? _appSettings;

        /// <summary>
        /// Application settings.
        /// </summary>
        public InputList<Inputs.NameValuePairArgs> AppSettings
        {
            get => _appSettings ?? (_appSettings = new InputList<Inputs.NameValuePairArgs>());
            set => _appSettings = value;
        }

        /// <summary>
        /// &lt;code&gt;true&lt;/code&gt; if Auto Heal is enabled; otherwise, &lt;code&gt;false&lt;/code&gt;.
        /// </summary>
        [Input("autoHealEnabled")]
        public Input<bool>? AutoHealEnabled { get; set; }

        /// <summary>
        /// Auto Heal rules.
        /// </summary>
        [Input("autoHealRules")]
        public Input<Inputs.AutoHealRulesArgs>? AutoHealRules { get; set; }

        /// <summary>
        /// Auto-swap slot name.
        /// </summary>
        [Input("autoSwapSlotName")]
        public Input<string>? AutoSwapSlotName { get; set; }

        [Input("azureStorageAccounts")]
        private InputMap<Inputs.AzureStorageInfoValueArgs>? _azureStorageAccounts;

        /// <summary>
        /// User-provided Azure storage accounts.
        /// </summary>
        public InputMap<Inputs.AzureStorageInfoValueArgs> AzureStorageAccounts
        {
            get => _azureStorageAccounts ?? (_azureStorageAccounts = new InputMap<Inputs.AzureStorageInfoValueArgs>());
            set => _azureStorageAccounts = value;
        }

        [Input("connectionStrings")]
        private InputList<Inputs.ConnStringInfoArgs>? _connectionStrings;

        /// <summary>
        /// Connection strings.
        /// </summary>
        public InputList<Inputs.ConnStringInfoArgs> ConnectionStrings
        {
            get => _connectionStrings ?? (_connectionStrings = new InputList<Inputs.ConnStringInfoArgs>());
            set => _connectionStrings = value;
        }

        /// <summary>
        /// Cross-Origin Resource Sharing (CORS) settings.
        /// </summary>
        [Input("cors")]
        public Input<Inputs.CorsSettingsArgs>? Cors { get; set; }

        [Input("defaultDocuments")]
        private InputList<string>? _defaultDocuments;

        /// <summary>
        /// Default documents.
        /// </summary>
        public InputList<string> DefaultDocuments
        {
            get => _defaultDocuments ?? (_defaultDocuments = new InputList<string>());
            set => _defaultDocuments = value;
        }

        /// <summary>
        /// &lt;code&gt;true&lt;/code&gt; if detailed error logging is enabled; otherwise, &lt;code&gt;false&lt;/code&gt;.
        /// </summary>
        [Input("detailedErrorLoggingEnabled")]
        public Input<bool>? DetailedErrorLoggingEnabled { get; set; }

        /// <summary>
        /// Document root.
        /// </summary>
        [Input("documentRoot")]
        public Input<string>? DocumentRoot { get; set; }

        /// <summary>
        /// This is work around for polymorphic types.
        /// </summary>
        [Input("experiments")]
        public Input<Inputs.ExperimentsArgs>? Experiments { get; set; }

        /// <summary>
        /// State of FTP / FTPS service
        /// </summary>
        [Input("ftpsState")]
        public InputUnion<string, Pulumi.AzureNextGen.Web.V20181101.FtpsState>? FtpsState { get; set; }

        [Input("handlerMappings")]
        private InputList<Inputs.HandlerMappingArgs>? _handlerMappings;

        /// <summary>
        /// Handler mappings.
        /// </summary>
        public InputList<Inputs.HandlerMappingArgs> HandlerMappings
        {
            get => _handlerMappings ?? (_handlerMappings = new InputList<Inputs.HandlerMappingArgs>());
            set => _handlerMappings = value;
        }

        /// <summary>
        /// Http20Enabled: configures a web site to allow clients to connect over http2.0
        /// </summary>
        [Input("http20Enabled")]
        public Input<bool>? Http20Enabled { get; set; }

        /// <summary>
        /// &lt;code&gt;true&lt;/code&gt; if HTTP logging is enabled; otherwise, &lt;code&gt;false&lt;/code&gt;.
        /// </summary>
        [Input("httpLoggingEnabled")]
        public Input<bool>? HttpLoggingEnabled { get; set; }

        [Input("ipSecurityRestrictions")]
        private InputList<Inputs.IpSecurityRestrictionArgs>? _ipSecurityRestrictions;

        /// <summary>
        /// IP security restrictions for main.
        /// </summary>
        public InputList<Inputs.IpSecurityRestrictionArgs> IpSecurityRestrictions
        {
            get => _ipSecurityRestrictions ?? (_ipSecurityRestrictions = new InputList<Inputs.IpSecurityRestrictionArgs>());
            set => _ipSecurityRestrictions = value;
        }

        /// <summary>
        /// Java container.
        /// </summary>
        [Input("javaContainer")]
        public Input<string>? JavaContainer { get; set; }

        /// <summary>
        /// Java container version.
        /// </summary>
        [Input("javaContainerVersion")]
        public Input<string>? JavaContainerVersion { get; set; }

        /// <summary>
        /// Java version.
        /// </summary>
        [Input("javaVersion")]
        public Input<string>? JavaVersion { get; set; }

        /// <summary>
        /// Site limits.
        /// </summary>
        [Input("limits")]
        public Input<Inputs.SiteLimitsArgs>? Limits { get; set; }

        /// <summary>
        /// Linux App Framework and version
        /// </summary>
        [Input("linuxFxVersion")]
        public Input<string>? LinuxFxVersion { get; set; }

        /// <summary>
        /// Site load balancing.
        /// </summary>
        [Input("loadBalancing")]
        public Input<Pulumi.AzureNextGen.Web.V20181101.SiteLoadBalancing>? LoadBalancing { get; set; }

        /// <summary>
        /// &lt;code&gt;true&lt;/code&gt; to enable local MySQL; otherwise, &lt;code&gt;false&lt;/code&gt;.
        /// </summary>
        [Input("localMySqlEnabled")]
        public Input<bool>? LocalMySqlEnabled { get; set; }

        /// <summary>
        /// HTTP logs directory size limit.
        /// </summary>
        [Input("logsDirectorySizeLimit")]
        public Input<int>? LogsDirectorySizeLimit { get; set; }

        /// <summary>
        /// Managed pipeline mode.
        /// </summary>
        [Input("managedPipelineMode")]
        public Input<Pulumi.AzureNextGen.Web.V20181101.ManagedPipelineMode>? ManagedPipelineMode { get; set; }

        /// <summary>
        /// Managed Service Identity Id
        /// </summary>
        [Input("managedServiceIdentityId")]
        public Input<int>? ManagedServiceIdentityId { get; set; }

        /// <summary>
        /// MinTlsVersion: configures the minimum version of TLS required for SSL requests
        /// </summary>
        [Input("minTlsVersion")]
        public InputUnion<string, Pulumi.AzureNextGen.Web.V20181101.SupportedTlsVersions>? MinTlsVersion { get; set; }

        /// <summary>
        /// .NET Framework version.
        /// </summary>
        [Input("netFrameworkVersion")]
        public Input<string>? NetFrameworkVersion { get; set; }

        /// <summary>
        /// Version of Node.js.
        /// </summary>
        [Input("nodeVersion")]
        public Input<string>? NodeVersion { get; set; }

        /// <summary>
        /// Number of workers.
        /// </summary>
        [Input("numberOfWorkers")]
        public Input<int>? NumberOfWorkers { get; set; }

        /// <summary>
        /// Version of PHP.
        /// </summary>
        [Input("phpVersion")]
        public Input<string>? PhpVersion { get; set; }

        /// <summary>
        /// Publishing user name.
        /// </summary>
        [Input("publishingUsername")]
        public Input<string>? PublishingUsername { get; set; }

        /// <summary>
        /// Push endpoint settings.
        /// </summary>
        [Input("push")]
        public Input<Inputs.PushSettingsArgs>? Push { get; set; }

        /// <summary>
        /// Version of Python.
        /// </summary>
        [Input("pythonVersion")]
        public Input<string>? PythonVersion { get; set; }

        /// <summary>
        /// &lt;code&gt;true&lt;/code&gt; if remote debugging is enabled; otherwise, &lt;code&gt;false&lt;/code&gt;.
        /// </summary>
        [Input("remoteDebuggingEnabled")]
        public Input<bool>? RemoteDebuggingEnabled { get; set; }

        /// <summary>
        /// Remote debugging version.
        /// </summary>
        [Input("remoteDebuggingVersion")]
        public Input<string>? RemoteDebuggingVersion { get; set; }

        /// <summary>
        /// &lt;code&gt;true&lt;/code&gt; if request tracing is enabled; otherwise, &lt;code&gt;false&lt;/code&gt;.
        /// </summary>
        [Input("requestTracingEnabled")]
        public Input<bool>? RequestTracingEnabled { get; set; }

        /// <summary>
        /// Request tracing expiration time.
        /// </summary>
        [Input("requestTracingExpirationTime")]
        public Input<string>? RequestTracingExpirationTime { get; set; }

        /// <summary>
        /// Number of reserved instances.
        /// This setting only applies to the Consumption Plan
        /// </summary>
        [Input("reservedInstanceCount")]
        public Input<int>? ReservedInstanceCount { get; set; }

        [Input("scmIpSecurityRestrictions")]
        private InputList<Inputs.IpSecurityRestrictionArgs>? _scmIpSecurityRestrictions;

        /// <summary>
        /// IP security restrictions for scm.
        /// </summary>
        public InputList<Inputs.IpSecurityRestrictionArgs> ScmIpSecurityRestrictions
        {
            get => _scmIpSecurityRestrictions ?? (_scmIpSecurityRestrictions = new InputList<Inputs.IpSecurityRestrictionArgs>());
            set => _scmIpSecurityRestrictions = value;
        }

        /// <summary>
        /// IP security restrictions for scm to use main.
        /// </summary>
        [Input("scmIpSecurityRestrictionsUseMain")]
        public Input<bool>? ScmIpSecurityRestrictionsUseMain { get; set; }

        /// <summary>
        /// SCM type.
        /// </summary>
        [Input("scmType")]
        public InputUnion<string, Pulumi.AzureNextGen.Web.V20181101.ScmType>? ScmType { get; set; }

        /// <summary>
        /// Tracing options.
        /// </summary>
        [Input("tracingOptions")]
        public Input<string>? TracingOptions { get; set; }

        /// <summary>
        /// &lt;code&gt;true&lt;/code&gt; to use 32-bit worker process; otherwise, &lt;code&gt;false&lt;/code&gt;.
        /// </summary>
        [Input("use32BitWorkerProcess")]
        public Input<bool>? Use32BitWorkerProcess { get; set; }

        [Input("virtualApplications")]
        private InputList<Inputs.VirtualApplicationArgs>? _virtualApplications;

        /// <summary>
        /// Virtual applications.
        /// </summary>
        public InputList<Inputs.VirtualApplicationArgs> VirtualApplications
        {
            get => _virtualApplications ?? (_virtualApplications = new InputList<Inputs.VirtualApplicationArgs>());
            set => _virtualApplications = value;
        }

        /// <summary>
        /// Virtual Network name.
        /// </summary>
        [Input("vnetName")]
        public Input<string>? VnetName { get; set; }

        /// <summary>
        /// &lt;code&gt;true&lt;/code&gt; if WebSocket is enabled; otherwise, &lt;code&gt;false&lt;/code&gt;.
        /// </summary>
        [Input("webSocketsEnabled")]
        public Input<bool>? WebSocketsEnabled { get; set; }

        /// <summary>
        /// Xenon App Framework and version
        /// </summary>
        [Input("windowsFxVersion")]
        public Input<string>? WindowsFxVersion { get; set; }

        /// <summary>
        /// Explicit Managed Service Identity Id
        /// </summary>
        [Input("xManagedServiceIdentityId")]
        public Input<int>? XManagedServiceIdentityId { get; set; }

        public SiteConfigArgs()
        {
            Http20Enabled = true;
            LocalMySqlEnabled = false;
            NetFrameworkVersion = "v4.6";
        }
    }
}
