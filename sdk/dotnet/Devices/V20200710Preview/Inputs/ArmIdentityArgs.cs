// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Devices.V20200710Preview.Inputs
{

    public sealed class ArmIdentityArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Identity type. Only allowed values are SystemAssigned and UserAssigned. Comma separated if both for ex: SystemAssigned,UserAssigned
        /// </summary>
        [Input("identityType")]
        public Input<string>? IdentityType { get; set; }

        [Input("userAssignedIdentities")]
        private InputMap<object>? _userAssignedIdentities;
        public InputMap<object> UserAssignedIdentities
        {
            get => _userAssignedIdentities ?? (_userAssignedIdentities = new InputMap<object>());
            set => _userAssignedIdentities = value;
        }

        public ArmIdentityArgs()
        {
        }
    }
}
