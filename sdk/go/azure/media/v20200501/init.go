// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package v20200501

import (
	"fmt"

	"github.com/blang/semver"
	"github.com/pulumi/pulumi-azure-nextgen/sdk/go/azure"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

type module struct {
	version semver.Version
}

func (m *module) Version() semver.Version {
	return m.version
}

func (m *module) Construct(ctx *pulumi.Context, name, typ, urn string) (r pulumi.Resource, err error) {
	switch typ {
	case "azure-nextgen:media/v20200501:AccountFilter":
		r, err = NewAccountFilter(ctx, name, nil, pulumi.URN_(urn))
	case "azure-nextgen:media/v20200501:Asset":
		r, err = NewAsset(ctx, name, nil, pulumi.URN_(urn))
	case "azure-nextgen:media/v20200501:AssetFilter":
		r, err = NewAssetFilter(ctx, name, nil, pulumi.URN_(urn))
	case "azure-nextgen:media/v20200501:ContentKeyPolicy":
		r, err = NewContentKeyPolicy(ctx, name, nil, pulumi.URN_(urn))
	case "azure-nextgen:media/v20200501:Job":
		r, err = NewJob(ctx, name, nil, pulumi.URN_(urn))
	case "azure-nextgen:media/v20200501:LiveEvent":
		r, err = NewLiveEvent(ctx, name, nil, pulumi.URN_(urn))
	case "azure-nextgen:media/v20200501:LiveOutput":
		r, err = NewLiveOutput(ctx, name, nil, pulumi.URN_(urn))
	case "azure-nextgen:media/v20200501:MediaService":
		r, err = NewMediaService(ctx, name, nil, pulumi.URN_(urn))
	case "azure-nextgen:media/v20200501:PrivateEndpointConnection":
		r, err = NewPrivateEndpointConnection(ctx, name, nil, pulumi.URN_(urn))
	case "azure-nextgen:media/v20200501:StreamingEndpoint":
		r, err = NewStreamingEndpoint(ctx, name, nil, pulumi.URN_(urn))
	case "azure-nextgen:media/v20200501:StreamingLocator":
		r, err = NewStreamingLocator(ctx, name, nil, pulumi.URN_(urn))
	case "azure-nextgen:media/v20200501:StreamingPolicy":
		r, err = NewStreamingPolicy(ctx, name, nil, pulumi.URN_(urn))
	case "azure-nextgen:media/v20200501:Transform":
		r, err = NewTransform(ctx, name, nil, pulumi.URN_(urn))
	default:
		return nil, fmt.Errorf("unknown resource type: %s", typ)
	}

	return
}

func init() {
	version, err := azure.PkgVersion()
	if err != nil {
		fmt.Println("failed to determine package version. defaulting to v1: %v", err)
	}
	pulumi.RegisterResourceModule(
		"azure-nextgen",
		"media/v20200501",
		&module{version},
	)
}
