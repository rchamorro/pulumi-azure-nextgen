// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package latest

import (
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

func LookupWatcher(ctx *pulumi.Context, args *LookupWatcherArgs, opts ...pulumi.InvokeOption) (*LookupWatcherResult, error) {
	var rv LookupWatcherResult
	err := ctx.Invoke("azure-nextgen:automation/latest:getWatcher", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

type LookupWatcherArgs struct {
	// The name of the automation account.
	AutomationAccountName string `pulumi:"automationAccountName"`
	// Name of an Azure Resource group.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// The watcher name.
	WatcherName string `pulumi:"watcherName"`
}

// Definition of the watcher type.
type LookupWatcherResult struct {
	// Gets or sets the creation time.
	CreationTime string `pulumi:"creationTime"`
	// Gets or sets the description.
	Description *string `pulumi:"description"`
	// Gets or sets the etag of the resource.
	Etag *string `pulumi:"etag"`
	// Gets or sets the frequency at which the watcher is invoked.
	ExecutionFrequencyInSeconds *float64 `pulumi:"executionFrequencyInSeconds"`
	// Fully qualified resource Id for the resource
	Id string `pulumi:"id"`
	// Details of the user who last modified the watcher.
	LastModifiedBy string `pulumi:"lastModifiedBy"`
	// Gets or sets the last modified time.
	LastModifiedTime string `pulumi:"lastModifiedTime"`
	// The geo-location where the resource lives
	Location *string `pulumi:"location"`
	// The name of the resource
	Name string `pulumi:"name"`
	// Gets or sets the name of the script the watcher is attached to, i.e. the name of an existing runbook.
	ScriptName *string `pulumi:"scriptName"`
	// Gets or sets the parameters of the script.
	ScriptParameters map[string]string `pulumi:"scriptParameters"`
	// Gets or sets the name of the hybrid worker group the watcher will run on.
	ScriptRunOn *string `pulumi:"scriptRunOn"`
	// Gets the current status of the watcher.
	Status string `pulumi:"status"`
	// Resource tags.
	Tags map[string]string `pulumi:"tags"`
	// The type of the resource.
	Type string `pulumi:"type"`
}
