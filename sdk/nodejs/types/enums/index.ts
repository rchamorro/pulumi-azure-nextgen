// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

// Export sub-modules:
import * as aad from "./aad";
import * as aadiam from "./aadiam";
import * as alertsmanagement from "./alertsmanagement";
import * as analysisservices from "./analysisservices";
import * as apimanagement from "./apimanagement";
import * as appconfiguration from "./appconfiguration";
import * as appplatform from "./appplatform";
import * as attestation from "./attestation";
import * as authorization from "./authorization";
import * as automanage from "./automanage";
import * as automation from "./automation";
import * as avs from "./avs";
import * as azureactivedirectory from "./azureactivedirectory";
import * as azurestack from "./azurestack";
import * as batch from "./batch";
import * as batchai from "./batchai";
import * as billing from "./billing";
import * as blockchain from "./blockchain";
import * as blueprint from "./blueprint";
import * as botservice from "./botservice";
import * as cache from "./cache";
import * as cdn from "./cdn";
import * as certificateregistration from "./certificateregistration";
import * as changeanalysis from "./changeanalysis";
import * as cognitiveservices from "./cognitiveservices";
import * as compute from "./compute";
import * as confluent from "./confluent";
import * as consumption from "./consumption";
import * as containerinstance from "./containerinstance";
import * as containerregistry from "./containerregistry";
import * as containerservice from "./containerservice";
import * as costmanagement from "./costmanagement";
import * as customerinsights from "./customerinsights";
import * as customproviders from "./customproviders";
import * as databox from "./databox";
import * as databoxedge from "./databoxedge";
import * as databricks from "./databricks";
import * as datacatalog from "./datacatalog";
import * as datadog from "./datadog";
import * as datafactory from "./datafactory";
import * as datalakeanalytics from "./datalakeanalytics";
import * as datalakestore from "./datalakestore";
import * as datamigration from "./datamigration";
import * as datashare from "./datashare";
import * as dbformariadb from "./dbformariadb";
import * as dbformysql from "./dbformysql";
import * as dbforpostgresql from "./dbforpostgresql";
import * as delegatednetwork from "./delegatednetwork";
import * as deploymentmanager from "./deploymentmanager";
import * as desktopvirtualization from "./desktopvirtualization";
import * as devices from "./devices";
import * as devops from "./devops";
import * as devspaces from "./devspaces";
import * as devtestlab from "./devtestlab";
import * as digitaltwins from "./digitaltwins";
import * as documentdb from "./documentdb";
import * as domainregistration from "./domainregistration";
import * as enterpriseknowledgegraph from "./enterpriseknowledgegraph";
import * as eventgrid from "./eventgrid";
import * as eventhub from "./eventhub";
import * as hdinsight from "./hdinsight";
import * as healthbot from "./healthbot";
import * as healthcareapis from "./healthcareapis";
import * as hybridcompute from "./hybridcompute";
import * as hybriddata from "./hybriddata";
import * as hybridnetwork from "./hybridnetwork";
import * as importexport from "./importexport";
import * as insights from "./insights";
import * as iotcentral from "./iotcentral";
import * as iotspaces from "./iotspaces";
import * as keyvault from "./keyvault";
import * as kubernetes from "./kubernetes";
import * as kubernetesconfiguration from "./kubernetesconfiguration";
import * as kusto from "./kusto";
import * as labservices from "./labservices";
import * as logic from "./logic";
import * as machinelearning from "./machinelearning";
import * as machinelearningcompute from "./machinelearningcompute";
import * as machinelearningservices from "./machinelearningservices";
import * as maintenance from "./maintenance";
import * as managednetwork from "./managednetwork";
import * as managedservices from "./managedservices";
import * as management from "./management";
import * as marketplace from "./marketplace";
import * as media from "./media";
import * as migrate from "./migrate";
import * as mixedreality from "./mixedreality";
import * as netapp from "./netapp";
import * as network from "./network";
import * as notificationhubs from "./notificationhubs";
import * as operationalinsights from "./operationalinsights";
import * as peering from "./peering";
import * as policyinsights from "./policyinsights";
import * as portal from "./portal";
import * as powerbi from "./powerbi";
import * as powerbidedicated from "./powerbidedicated";
import * as powerplatform from "./powerplatform";
import * as purview from "./purview";
import * as recoveryservices from "./recoveryservices";
import * as redhatopenshift from "./redhatopenshift";
import * as relay from "./relay";
import * as resources from "./resources";
import * as saas from "./saas";
import * as scheduler from "./scheduler";
import * as search from "./search";
import * as security from "./security";
import * as securityinsights from "./securityinsights";
import * as serialconsole from "./serialconsole";
import * as servicebus from "./servicebus";
import * as servicefabric from "./servicefabric";
import * as servicefabricmesh from "./servicefabricmesh";
import * as signalrservice from "./signalrservice";
import * as solutions from "./solutions";
import * as sql from "./sql";
import * as sqlvirtualmachine from "./sqlvirtualmachine";
import * as storage from "./storage";
import * as storagecache from "./storagecache";
import * as storagepool from "./storagepool";
import * as storagesync from "./storagesync";
import * as storsimple from "./storsimple";
import * as streamanalytics from "./streamanalytics";
import * as subscription from "./subscription";
import * as synapse from "./synapse";
import * as timeseriesinsights from "./timeseriesinsights";
import * as virtualmachineimages from "./virtualmachineimages";
import * as visualstudio from "./visualstudio";
import * as vmwarecloudsimple from "./vmwarecloudsimple";
import * as web from "./web";
import * as windowsesu from "./windowsesu";

export {
    aad,
    aadiam,
    alertsmanagement,
    analysisservices,
    apimanagement,
    appconfiguration,
    appplatform,
    attestation,
    authorization,
    automanage,
    automation,
    avs,
    azureactivedirectory,
    azurestack,
    batch,
    batchai,
    billing,
    blockchain,
    blueprint,
    botservice,
    cache,
    cdn,
    certificateregistration,
    changeanalysis,
    cognitiveservices,
    compute,
    confluent,
    consumption,
    containerinstance,
    containerregistry,
    containerservice,
    costmanagement,
    customerinsights,
    customproviders,
    databox,
    databoxedge,
    databricks,
    datacatalog,
    datadog,
    datafactory,
    datalakeanalytics,
    datalakestore,
    datamigration,
    datashare,
    dbformariadb,
    dbformysql,
    dbforpostgresql,
    delegatednetwork,
    deploymentmanager,
    desktopvirtualization,
    devices,
    devops,
    devspaces,
    devtestlab,
    digitaltwins,
    documentdb,
    domainregistration,
    enterpriseknowledgegraph,
    eventgrid,
    eventhub,
    hdinsight,
    healthbot,
    healthcareapis,
    hybridcompute,
    hybriddata,
    hybridnetwork,
    importexport,
    insights,
    iotcentral,
    iotspaces,
    keyvault,
    kubernetes,
    kubernetesconfiguration,
    kusto,
    labservices,
    logic,
    machinelearning,
    machinelearningcompute,
    machinelearningservices,
    maintenance,
    managednetwork,
    managedservices,
    management,
    marketplace,
    media,
    migrate,
    mixedreality,
    netapp,
    network,
    notificationhubs,
    operationalinsights,
    peering,
    policyinsights,
    portal,
    powerbi,
    powerbidedicated,
    powerplatform,
    purview,
    recoveryservices,
    redhatopenshift,
    relay,
    resources,
    saas,
    scheduler,
    search,
    security,
    securityinsights,
    serialconsole,
    servicebus,
    servicefabric,
    servicefabricmesh,
    signalrservice,
    solutions,
    sql,
    sqlvirtualmachine,
    storage,
    storagecache,
    storagepool,
    storagesync,
    storsimple,
    streamanalytics,
    subscription,
    synapse,
    timeseriesinsights,
    virtualmachineimages,
    visualstudio,
    vmwarecloudsimple,
    web,
    windowsesu,
};
