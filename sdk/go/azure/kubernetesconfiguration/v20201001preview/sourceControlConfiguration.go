// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20201001preview

import (
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// The SourceControl Configuration object returned in Get & Put response.
type SourceControlConfiguration struct {
	pulumi.CustomResourceState

	// Compliance Status of the Configuration
	ComplianceStatus ComplianceStatusResponseOutput `pulumi:"complianceStatus"`
	// Name-value pairs of protected configuration settings for the configuration
	ConfigurationProtectedSettings pulumi.StringMapOutput `pulumi:"configurationProtectedSettings"`
	// Option to enable Helm Operator for this git configuration.
	EnableHelmOperator pulumi.BoolPtrOutput `pulumi:"enableHelmOperator"`
	// Properties for Helm operator.
	HelmOperatorProperties HelmOperatorPropertiesResponsePtrOutput `pulumi:"helmOperatorProperties"`
	// Resource name
	Name pulumi.StringOutput `pulumi:"name"`
	// Instance name of the operator - identifying the specific configuration.
	OperatorInstanceName pulumi.StringPtrOutput `pulumi:"operatorInstanceName"`
	// The namespace to which this operator is installed to. Maximum of 253 lower case alphanumeric characters, hyphen and period only.
	OperatorNamespace pulumi.StringPtrOutput `pulumi:"operatorNamespace"`
	// Any Parameters for the Operator instance in string format.
	OperatorParams pulumi.StringPtrOutput `pulumi:"operatorParams"`
	// Scope at which the operator will be installed.
	OperatorScope pulumi.StringPtrOutput `pulumi:"operatorScope"`
	// Type of the operator
	OperatorType pulumi.StringPtrOutput `pulumi:"operatorType"`
	// The provisioning state of the resource provider.
	ProvisioningState pulumi.StringOutput `pulumi:"provisioningState"`
	// Public Key associated with this SourceControl configuration (either generated within the cluster or provided by the user).
	RepositoryPublicKey pulumi.StringOutput `pulumi:"repositoryPublicKey"`
	// Url of the SourceControl Repository.
	RepositoryUrl pulumi.StringPtrOutput `pulumi:"repositoryUrl"`
	// Base64-encoded known_hosts contents containing public SSH keys required to access private Git instances
	SshKnownHostsContents pulumi.StringPtrOutput `pulumi:"sshKnownHostsContents"`
	// Top level metadata https://github.com/Azure/azure-resource-manager-rpc/blob/master/v1.0/common-api-contracts.md#system-metadata-for-all-azure-resources
	SystemData SystemDataResponsePtrOutput `pulumi:"systemData"`
	// Resource type
	Type pulumi.StringOutput `pulumi:"type"`
}

// NewSourceControlConfiguration registers a new resource with the given unique name, arguments, and options.
func NewSourceControlConfiguration(ctx *pulumi.Context,
	name string, args *SourceControlConfigurationArgs, opts ...pulumi.ResourceOption) (*SourceControlConfiguration, error) {
	if args == nil || args.ClusterName == nil {
		return nil, errors.New("missing required argument 'ClusterName'")
	}
	if args == nil || args.ClusterResourceName == nil {
		return nil, errors.New("missing required argument 'ClusterResourceName'")
	}
	if args == nil || args.ClusterRp == nil {
		return nil, errors.New("missing required argument 'ClusterRp'")
	}
	if args == nil || args.ResourceGroupName == nil {
		return nil, errors.New("missing required argument 'ResourceGroupName'")
	}
	if args == nil || args.SourceControlConfigurationName == nil {
		return nil, errors.New("missing required argument 'SourceControlConfigurationName'")
	}
	if args == nil {
		args = &SourceControlConfigurationArgs{}
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("azure-nextgen:kubernetesconfiguration/v20191101preview:SourceControlConfiguration"),
		},
	})
	opts = append(opts, aliases)
	var resource SourceControlConfiguration
	err := ctx.RegisterResource("azure-nextgen:kubernetesconfiguration/v20201001preview:SourceControlConfiguration", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetSourceControlConfiguration gets an existing SourceControlConfiguration resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetSourceControlConfiguration(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *SourceControlConfigurationState, opts ...pulumi.ResourceOption) (*SourceControlConfiguration, error) {
	var resource SourceControlConfiguration
	err := ctx.ReadResource("azure-nextgen:kubernetesconfiguration/v20201001preview:SourceControlConfiguration", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering SourceControlConfiguration resources.
type sourceControlConfigurationState struct {
	// Compliance Status of the Configuration
	ComplianceStatus *ComplianceStatusResponse `pulumi:"complianceStatus"`
	// Name-value pairs of protected configuration settings for the configuration
	ConfigurationProtectedSettings map[string]string `pulumi:"configurationProtectedSettings"`
	// Option to enable Helm Operator for this git configuration.
	EnableHelmOperator *bool `pulumi:"enableHelmOperator"`
	// Properties for Helm operator.
	HelmOperatorProperties *HelmOperatorPropertiesResponse `pulumi:"helmOperatorProperties"`
	// Resource name
	Name *string `pulumi:"name"`
	// Instance name of the operator - identifying the specific configuration.
	OperatorInstanceName *string `pulumi:"operatorInstanceName"`
	// The namespace to which this operator is installed to. Maximum of 253 lower case alphanumeric characters, hyphen and period only.
	OperatorNamespace *string `pulumi:"operatorNamespace"`
	// Any Parameters for the Operator instance in string format.
	OperatorParams *string `pulumi:"operatorParams"`
	// Scope at which the operator will be installed.
	OperatorScope *string `pulumi:"operatorScope"`
	// Type of the operator
	OperatorType *string `pulumi:"operatorType"`
	// The provisioning state of the resource provider.
	ProvisioningState *string `pulumi:"provisioningState"`
	// Public Key associated with this SourceControl configuration (either generated within the cluster or provided by the user).
	RepositoryPublicKey *string `pulumi:"repositoryPublicKey"`
	// Url of the SourceControl Repository.
	RepositoryUrl *string `pulumi:"repositoryUrl"`
	// Base64-encoded known_hosts contents containing public SSH keys required to access private Git instances
	SshKnownHostsContents *string `pulumi:"sshKnownHostsContents"`
	// Top level metadata https://github.com/Azure/azure-resource-manager-rpc/blob/master/v1.0/common-api-contracts.md#system-metadata-for-all-azure-resources
	SystemData *SystemDataResponse `pulumi:"systemData"`
	// Resource type
	Type *string `pulumi:"type"`
}

type SourceControlConfigurationState struct {
	// Compliance Status of the Configuration
	ComplianceStatus ComplianceStatusResponsePtrInput
	// Name-value pairs of protected configuration settings for the configuration
	ConfigurationProtectedSettings pulumi.StringMapInput
	// Option to enable Helm Operator for this git configuration.
	EnableHelmOperator pulumi.BoolPtrInput
	// Properties for Helm operator.
	HelmOperatorProperties HelmOperatorPropertiesResponsePtrInput
	// Resource name
	Name pulumi.StringPtrInput
	// Instance name of the operator - identifying the specific configuration.
	OperatorInstanceName pulumi.StringPtrInput
	// The namespace to which this operator is installed to. Maximum of 253 lower case alphanumeric characters, hyphen and period only.
	OperatorNamespace pulumi.StringPtrInput
	// Any Parameters for the Operator instance in string format.
	OperatorParams pulumi.StringPtrInput
	// Scope at which the operator will be installed.
	OperatorScope pulumi.StringPtrInput
	// Type of the operator
	OperatorType pulumi.StringPtrInput
	// The provisioning state of the resource provider.
	ProvisioningState pulumi.StringPtrInput
	// Public Key associated with this SourceControl configuration (either generated within the cluster or provided by the user).
	RepositoryPublicKey pulumi.StringPtrInput
	// Url of the SourceControl Repository.
	RepositoryUrl pulumi.StringPtrInput
	// Base64-encoded known_hosts contents containing public SSH keys required to access private Git instances
	SshKnownHostsContents pulumi.StringPtrInput
	// Top level metadata https://github.com/Azure/azure-resource-manager-rpc/blob/master/v1.0/common-api-contracts.md#system-metadata-for-all-azure-resources
	SystemData SystemDataResponsePtrInput
	// Resource type
	Type pulumi.StringPtrInput
}

func (SourceControlConfigurationState) ElementType() reflect.Type {
	return reflect.TypeOf((*sourceControlConfigurationState)(nil)).Elem()
}

type sourceControlConfigurationArgs struct {
	// The name of the kubernetes cluster.
	ClusterName string `pulumi:"clusterName"`
	// The Kubernetes cluster resource name - either managedClusters (for AKS clusters) or connectedClusters (for OnPrem K8S clusters).
	ClusterResourceName string `pulumi:"clusterResourceName"`
	// The Kubernetes cluster RP - either Microsoft.ContainerService (for AKS clusters) or Microsoft.Kubernetes (for OnPrem K8S clusters).
	ClusterRp string `pulumi:"clusterRp"`
	// Name-value pairs of protected configuration settings for the configuration
	ConfigurationProtectedSettings map[string]string `pulumi:"configurationProtectedSettings"`
	// Option to enable Helm Operator for this git configuration.
	EnableHelmOperator *bool `pulumi:"enableHelmOperator"`
	// Properties for Helm operator.
	HelmOperatorProperties *HelmOperatorProperties `pulumi:"helmOperatorProperties"`
	// Instance name of the operator - identifying the specific configuration.
	OperatorInstanceName *string `pulumi:"operatorInstanceName"`
	// The namespace to which this operator is installed to. Maximum of 253 lower case alphanumeric characters, hyphen and period only.
	OperatorNamespace *string `pulumi:"operatorNamespace"`
	// Any Parameters for the Operator instance in string format.
	OperatorParams *string `pulumi:"operatorParams"`
	// Scope at which the operator will be installed.
	OperatorScope *string `pulumi:"operatorScope"`
	// Type of the operator
	OperatorType *string `pulumi:"operatorType"`
	// Url of the SourceControl Repository.
	RepositoryUrl *string `pulumi:"repositoryUrl"`
	// The name of the resource group.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// Name of the Source Control Configuration.
	SourceControlConfigurationName string `pulumi:"sourceControlConfigurationName"`
	// Base64-encoded known_hosts contents containing public SSH keys required to access private Git instances
	SshKnownHostsContents *string `pulumi:"sshKnownHostsContents"`
}

// The set of arguments for constructing a SourceControlConfiguration resource.
type SourceControlConfigurationArgs struct {
	// The name of the kubernetes cluster.
	ClusterName pulumi.StringInput
	// The Kubernetes cluster resource name - either managedClusters (for AKS clusters) or connectedClusters (for OnPrem K8S clusters).
	ClusterResourceName pulumi.StringInput
	// The Kubernetes cluster RP - either Microsoft.ContainerService (for AKS clusters) or Microsoft.Kubernetes (for OnPrem K8S clusters).
	ClusterRp pulumi.StringInput
	// Name-value pairs of protected configuration settings for the configuration
	ConfigurationProtectedSettings pulumi.StringMapInput
	// Option to enable Helm Operator for this git configuration.
	EnableHelmOperator pulumi.BoolPtrInput
	// Properties for Helm operator.
	HelmOperatorProperties HelmOperatorPropertiesPtrInput
	// Instance name of the operator - identifying the specific configuration.
	OperatorInstanceName pulumi.StringPtrInput
	// The namespace to which this operator is installed to. Maximum of 253 lower case alphanumeric characters, hyphen and period only.
	OperatorNamespace pulumi.StringPtrInput
	// Any Parameters for the Operator instance in string format.
	OperatorParams pulumi.StringPtrInput
	// Scope at which the operator will be installed.
	OperatorScope pulumi.StringPtrInput
	// Type of the operator
	OperatorType pulumi.StringPtrInput
	// Url of the SourceControl Repository.
	RepositoryUrl pulumi.StringPtrInput
	// The name of the resource group.
	ResourceGroupName pulumi.StringInput
	// Name of the Source Control Configuration.
	SourceControlConfigurationName pulumi.StringInput
	// Base64-encoded known_hosts contents containing public SSH keys required to access private Git instances
	SshKnownHostsContents pulumi.StringPtrInput
}

func (SourceControlConfigurationArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*sourceControlConfigurationArgs)(nil)).Elem()
}