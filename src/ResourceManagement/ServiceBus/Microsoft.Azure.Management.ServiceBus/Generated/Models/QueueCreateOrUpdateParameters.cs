// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.ServiceBus.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Parameters supplied to the CreateOrUpdate Queue operation.
    /// </summary>
    [JsonTransformation]
    public partial class QueueCreateOrUpdateParameters
    {
        /// <summary>
        /// Initializes a new instance of the QueueCreateOrUpdateParameters
        /// class.
        /// </summary>
        public QueueCreateOrUpdateParameters() { }

        /// <summary>
        /// Initializes a new instance of the QueueCreateOrUpdateParameters
        /// class.
        /// </summary>
        public QueueCreateOrUpdateParameters(string location, string name = default(string), string lockDuration = default(string), DateTime? accessedAt = default(DateTime?), string autoDeleteOnIdle = default(string), EntityAvailabilityStatus? entityAvailabilityStatus = default(EntityAvailabilityStatus?), DateTime? createdAt = default(DateTime?), string defaultMessageTimeToLive = default(string), string duplicateDetectionHistoryTimeWindow = default(string), bool? enableBatchedOperations = default(bool?), bool? deadLetteringOnMessageExpiration = default(bool?), bool? enableExpress = default(bool?), bool? enablePartitioning = default(bool?), bool? isAnonymousAccessible = default(bool?), int? maxDeliveryCount = default(int?), long? maxSizeInMegabytes = default(long?), long? messageCount = default(long?), MessageCountDetails countDetails = default(MessageCountDetails), bool? requiresDuplicateDetection = default(bool?), bool? requiresSession = default(bool?), long? sizeInBytes = default(long?), EntityStatus? status = default(EntityStatus?), bool? supportOrdering = default(bool?), DateTime? updatedAt = default(DateTime?))
        {
            Name = name;
            Location = location;
            LockDuration = lockDuration;
            AccessedAt = accessedAt;
            AutoDeleteOnIdle = autoDeleteOnIdle;
            EntityAvailabilityStatus = entityAvailabilityStatus;
            CreatedAt = createdAt;
            DefaultMessageTimeToLive = defaultMessageTimeToLive;
            DuplicateDetectionHistoryTimeWindow = duplicateDetectionHistoryTimeWindow;
            EnableBatchedOperations = enableBatchedOperations;
            DeadLetteringOnMessageExpiration = deadLetteringOnMessageExpiration;
            EnableExpress = enableExpress;
            EnablePartitioning = enablePartitioning;
            IsAnonymousAccessible = isAnonymousAccessible;
            MaxDeliveryCount = maxDeliveryCount;
            MaxSizeInMegabytes = maxSizeInMegabytes;
            MessageCount = messageCount;
            CountDetails = countDetails;
            RequiresDuplicateDetection = requiresDuplicateDetection;
            RequiresSession = requiresSession;
            SizeInBytes = sizeInBytes;
            Status = status;
            SupportOrdering = supportOrdering;
            UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Queue name.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// location of the resource.
        /// </summary>
        [JsonProperty(PropertyName = "location")]
        public string Location { get; set; }

        /// <summary>
        /// the duration of a peek lock; that is, the amount of time that the
        /// message is locked for other receivers. The maximum value for
        /// LockDuration is 5 minutes; the default value is 1 minute.
        /// </summary>
        [JsonProperty(PropertyName = "properties.lockDuration ")]
        public string LockDuration { get; set; }

        /// <summary>
        /// Last time a message was sent, or the last time there was a receive
        /// request to this queue.
        /// </summary>
        [JsonProperty(PropertyName = "properties.accessedAt")]
        public DateTime? AccessedAt { get; set; }

        /// <summary>
        /// the TimeSpan idle interval after which the queue is automatically
        /// deleted. The minimum duration is 5 minutes.
        /// </summary>
        [JsonProperty(PropertyName = "properties.autoDeleteOnIdle")]
        public string AutoDeleteOnIdle { get; set; }

        /// <summary>
        /// Entity availability status for the queue. Possible values include:
        /// 'Available', 'Limited', 'Renaming', 'Restoring', 'Unknown'
        /// </summary>
        [JsonProperty(PropertyName = "properties.entityAvailabilityStatus ")]
        public EntityAvailabilityStatus? EntityAvailabilityStatus { get; set; }

        /// <summary>
        /// the exact time the message was created.
        /// </summary>
        [JsonProperty(PropertyName = "properties.createdAt")]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// the default message time to live value. This is the duration after
        /// which the message expires, starting from when the message is sent
        /// to Service Bus. This is the default value used when TimeToLive is
        /// not set on a message itself.
        /// </summary>
        [JsonProperty(PropertyName = "properties.defaultMessageTimeToLive")]
        public string DefaultMessageTimeToLive { get; set; }

        /// <summary>
        /// TimeSpan structure that defines the duration of the duplicate
        /// detection history. The default value is 10 minutes..
        /// </summary>
        [JsonProperty(PropertyName = "properties.duplicateDetectionHistoryTimeWindow ")]
        public string DuplicateDetectionHistoryTimeWindow { get; set; }

        /// <summary>
        /// value that indicates whether server-side batched operations are
        /// enabled..
        /// </summary>
        [JsonProperty(PropertyName = "properties.enableBatchedOperations")]
        public bool? EnableBatchedOperations { get; set; }

        /// <summary>
        /// a value that indicates whether this queue has dead letter support
        /// when a message expires.
        /// </summary>
        [JsonProperty(PropertyName = "properties.deadLetteringOnMessageExpiration")]
        public bool? DeadLetteringOnMessageExpiration { get; set; }

        /// <summary>
        /// a value that indicates whether Express Entities are enabled. An
        /// express queue holds a message in memory temporarily before
        /// writing it to persistent storage.
        /// </summary>
        [JsonProperty(PropertyName = "properties.enableExpress")]
        public bool? EnableExpress { get; set; }

        /// <summary>
        /// value that indicates whether the queue to be partitioned across
        /// multiple message brokers is enabled.
        /// </summary>
        [JsonProperty(PropertyName = "properties.enablePartitioning")]
        public bool? EnablePartitioning { get; set; }

        /// <summary>
        /// a value that indicates whether the message is anonymous accessible.
        /// </summary>
        [JsonProperty(PropertyName = "properties.isAnonymousAccessible")]
        public bool? IsAnonymousAccessible { get; set; }

        /// <summary>
        /// the maximum delivery count. A message is automatically
        /// deadlettered after this number of deliveries.
        /// </summary>
        [JsonProperty(PropertyName = "properties.maxDeliveryCount ")]
        public int? MaxDeliveryCount { get; set; }

        /// <summary>
        /// the maximum size of the queue in megabytes, which is the size of
        /// memory allocated for the queue.
        /// </summary>
        [JsonProperty(PropertyName = "properties.maxSizeInMegabytes")]
        public long? MaxSizeInMegabytes { get; set; }

        /// <summary>
        /// the number of messages in the queue.
        /// </summary>
        [JsonProperty(PropertyName = "properties.messageCount ")]
        public long? MessageCount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "properties.countDetails")]
        public MessageCountDetails CountDetails { get; set; }

        /// <summary>
        /// the value indicating if this queue requires duplicate detection.
        /// </summary>
        [JsonProperty(PropertyName = "properties.requiresDuplicateDetection")]
        public bool? RequiresDuplicateDetection { get; set; }

        /// <summary>
        /// a value that indicates whether the queue supports the concept of
        /// session.
        /// </summary>
        [JsonProperty(PropertyName = "properties.requiresSession")]
        public bool? RequiresSession { get; set; }

        /// <summary>
        /// the size of the queue in bytes.
        /// </summary>
        [JsonProperty(PropertyName = "properties.sizeInBytes ")]
        public long? SizeInBytes { get; set; }

        /// <summary>
        /// Enumerates the possible values for the status of a messaging
        /// entity. Possible values include: 'Active', 'Creating',
        /// 'Deleting', 'Disabled', 'ReceiveDisabled', 'Renaming',
        /// 'Restoring', 'SendDisabled', 'Unknown'
        /// </summary>
        [JsonProperty(PropertyName = "properties.status")]
        public EntityStatus? Status { get; set; }

        /// <summary>
        /// a value that indicates whether the queue supports ordering.
        /// </summary>
        [JsonProperty(PropertyName = "properties.supportOrdering")]
        public bool? SupportOrdering { get; set; }

        /// <summary>
        /// the exact time the message has been updated.
        /// </summary>
        [JsonProperty(PropertyName = "properties.updatedAt")]
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (Location == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Location");
            }
        }
    }
}