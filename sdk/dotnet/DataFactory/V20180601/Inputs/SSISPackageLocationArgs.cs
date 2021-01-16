// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.DataFactory.V20180601.Inputs
{

    /// <summary>
    /// SSIS package location.
    /// </summary>
    public sealed class SSISPackageLocationArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The package access credential.
        /// </summary>
        [Input("accessCredential")]
        public Input<Inputs.SSISAccessCredentialArgs>? AccessCredential { get; set; }

        [Input("childPackages")]
        private InputList<Inputs.SSISChildPackageArgs>? _childPackages;

        /// <summary>
        /// The embedded child package list.
        /// </summary>
        public InputList<Inputs.SSISChildPackageArgs> ChildPackages
        {
            get => _childPackages ?? (_childPackages = new InputList<Inputs.SSISChildPackageArgs>());
            set => _childPackages = value;
        }

        /// <summary>
        /// The configuration file access credential.
        /// </summary>
        [Input("configurationAccessCredential")]
        public Input<Inputs.SSISAccessCredentialArgs>? ConfigurationAccessCredential { get; set; }

        /// <summary>
        /// The configuration file of the package execution. Type: string (or Expression with resultType string).
        /// </summary>
        [Input("configurationPath")]
        public Input<object>? ConfigurationPath { get; set; }

        /// <summary>
        /// The embedded package content. Type: string (or Expression with resultType string).
        /// </summary>
        [Input("packageContent")]
        public Input<object>? PackageContent { get; set; }

        /// <summary>
        /// The embedded package last modified date.
        /// </summary>
        [Input("packageLastModifiedDate")]
        public Input<string>? PackageLastModifiedDate { get; set; }

        /// <summary>
        /// The package name.
        /// </summary>
        [Input("packageName")]
        public Input<string>? PackageName { get; set; }

        /// <summary>
        /// Password of the package.
        /// </summary>
        [Input("packagePassword")]
        public InputUnion<Inputs.AzureKeyVaultSecretReferenceArgs, Inputs.SecureStringArgs>? PackagePassword { get; set; }

        /// <summary>
        /// The SSIS package path. Type: string (or Expression with resultType string).
        /// </summary>
        [Input("packagePath")]
        public Input<object>? PackagePath { get; set; }

        /// <summary>
        /// The type of SSIS package location.
        /// </summary>
        [Input("type")]
        public InputUnion<string, Pulumi.AzureNextGen.DataFactory.V20180601.SsisPackageLocationType>? Type { get; set; }

        public SSISPackageLocationArgs()
        {
        }
    }
}
