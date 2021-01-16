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
    /// SSIS package execution credential.
    /// </summary>
    public sealed class SSISExecutionCredentialArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Domain for windows authentication.
        /// </summary>
        [Input("domain", required: true)]
        public Input<object> Domain { get; set; } = null!;

        /// <summary>
        /// Password for windows authentication.
        /// </summary>
        [Input("password", required: true)]
        public Input<Inputs.SecureStringArgs> Password { get; set; } = null!;

        /// <summary>
        /// UseName for windows authentication.
        /// </summary>
        [Input("userName", required: true)]
        public Input<object> UserName { get; set; } = null!;

        public SSISExecutionCredentialArgs()
        {
        }
    }
}
