// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Automation
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using Newtonsoft.Json;

    /// <summary>
    /// Automation Client
    /// </summary>
    public partial interface IAutomationClient : System.IDisposable
    {
        /// <summary>
        /// The base URI of the service.
        /// </summary>
        System.Uri BaseUri { get; set; }

        /// <summary>
        /// Gets or sets json serialization settings.
        /// </summary>
        JsonSerializerSettings SerializationSettings { get; }

        /// <summary>
        /// Gets or sets json deserialization settings.
        /// </summary>
        JsonSerializerSettings DeserializationSettings { get; }

        /// <summary>
        /// Credentials needed for the client to connect to Azure.
        /// </summary>
        ServiceClientCredentials Credentials { get; }

        /// <summary>
        /// Gets subscription credentials which uniquely identify Microsoft
        /// Azure subscription. The subscription ID forms part of the URI for
        /// every service call.
        /// </summary>
        string SubscriptionId { get; set; }

        /// <summary>
        /// Gets or sets the preferred language for the response.
        /// </summary>
        string AcceptLanguage { get; set; }

        /// <summary>
        /// Gets or sets the retry timeout in seconds for Long Running
        /// Operations. Default value is 30.
        /// </summary>
        int? LongRunningOperationRetryTimeout { get; set; }

        /// <summary>
        /// When set to true a unique x-ms-client-request-id value is generated
        /// and included in each request. Default is true.
        /// </summary>
        bool? GenerateClientRequestId { get; set; }


        /// <summary>
        /// Gets the IAutomationAccountOperations.
        /// </summary>
        IAutomationAccountOperations AutomationAccount { get; }

        /// <summary>
        /// Gets the IOperations.
        /// </summary>
        IOperations Operations { get; }

        /// <summary>
        /// Gets the IStatisticsOperations.
        /// </summary>
        IStatisticsOperations Statistics { get; }

        /// <summary>
        /// Gets the IUsagesOperations.
        /// </summary>
        IUsagesOperations Usages { get; }

        /// <summary>
        /// Gets the IKeysOperations.
        /// </summary>
        IKeysOperations Keys { get; }

        /// <summary>
        /// Gets the ICertificateOperations.
        /// </summary>
        ICertificateOperations Certificate { get; }

        /// <summary>
        /// Gets the IConnectionOperations.
        /// </summary>
        IConnectionOperations Connection { get; }

        /// <summary>
        /// Gets the IConnectionTypeOperations.
        /// </summary>
        IConnectionTypeOperations ConnectionType { get; }

        /// <summary>
        /// Gets the ICredentialOperations.
        /// </summary>
        ICredentialOperations Credential { get; }

        /// <summary>
        /// Gets the IDscConfigurationOperations.
        /// </summary>
        IDscConfigurationOperations DscConfiguration { get; }

        /// <summary>
        /// Gets the IHybridRunbookWorkerGroupOperations.
        /// </summary>
        IHybridRunbookWorkerGroupOperations HybridRunbookWorkerGroup { get; }

        /// <summary>
        /// Gets the IJobScheduleOperations.
        /// </summary>
        IJobScheduleOperations JobSchedule { get; }

        /// <summary>
        /// Gets the ILinkedWorkspaceOperations.
        /// </summary>
        ILinkedWorkspaceOperations LinkedWorkspace { get; }

        /// <summary>
        /// Gets the IActivityOperations.
        /// </summary>
        IActivityOperations Activity { get; }

        /// <summary>
        /// Gets the IModuleOperations.
        /// </summary>
        IModuleOperations Module { get; }

        /// <summary>
        /// Gets the IObjectDataTypesOperations.
        /// </summary>
        IObjectDataTypesOperations ObjectDataTypes { get; }

        /// <summary>
        /// Gets the IFieldsOperations.
        /// </summary>
        IFieldsOperations Fields { get; }

        /// <summary>
        /// Gets the IRunbookDraftOperations.
        /// </summary>
        IRunbookDraftOperations RunbookDraft { get; }

        /// <summary>
        /// Gets the IRunbookOperations.
        /// </summary>
        IRunbookOperations Runbook { get; }

        /// <summary>
        /// Gets the ITestJobStreamsOperations.
        /// </summary>
        ITestJobStreamsOperations TestJobStreams { get; }

        /// <summary>
        /// Gets the ITestJobOperations.
        /// </summary>
        ITestJobOperations TestJob { get; }

        /// <summary>
        /// Gets the IScheduleOperations.
        /// </summary>
        IScheduleOperations Schedule { get; }

        /// <summary>
        /// Gets the IVariableOperations.
        /// </summary>
        IVariableOperations Variable { get; }

        /// <summary>
        /// Gets the IWebhookOperations.
        /// </summary>
        IWebhookOperations Webhook { get; }

        /// <summary>
        /// Gets the ISoftwareUpdateConfigurationsOperations.
        /// </summary>
        ISoftwareUpdateConfigurationsOperations SoftwareUpdateConfigurations { get; }

        /// <summary>
        /// Gets the ISoftwareUpdateConfigurationRunsOperations.
        /// </summary>
        ISoftwareUpdateConfigurationRunsOperations SoftwareUpdateConfigurationRuns { get; }

        /// <summary>
        /// Gets the ISoftwareUpdateConfigurationMachineRunsOperations.
        /// </summary>
        ISoftwareUpdateConfigurationMachineRunsOperations SoftwareUpdateConfigurationMachineRuns { get; }

        /// <summary>
        /// Gets the ISourceControlOperations.
        /// </summary>
        ISourceControlOperations SourceControl { get; }

        /// <summary>
        /// Gets the ISourceControlSyncJobOperations.
        /// </summary>
        ISourceControlSyncJobOperations SourceControlSyncJob { get; }

        /// <summary>
        /// Gets the ISourceControlSyncJobStreamsOperations.
        /// </summary>
        ISourceControlSyncJobStreamsOperations SourceControlSyncJobStreams { get; }

        /// <summary>
        /// Gets the IJobOperations.
        /// </summary>
        IJobOperations Job { get; }

        /// <summary>
        /// Gets the IJobStreamOperations.
        /// </summary>
        IJobStreamOperations JobStream { get; }

        /// <summary>
        /// Gets the IAgentRegistrationInformationOperations.
        /// </summary>
        IAgentRegistrationInformationOperations AgentRegistrationInformation { get; }

        /// <summary>
        /// Gets the IDscNodeOperations.
        /// </summary>
        IDscNodeOperations DscNode { get; }

        /// <summary>
        /// Gets the INodeReportsOperations.
        /// </summary>
        INodeReportsOperations NodeReports { get; }

        /// <summary>
        /// Gets the IDscCompilationJobOperations.
        /// </summary>
        IDscCompilationJobOperations DscCompilationJob { get; }

        /// <summary>
        /// Gets the IDscCompilationJobStreamOperations.
        /// </summary>
        IDscCompilationJobStreamOperations DscCompilationJobStream { get; }

        /// <summary>
        /// Gets the IDscNodeConfigurationOperations.
        /// </summary>
        IDscNodeConfigurationOperations DscNodeConfiguration { get; }

    }
}
