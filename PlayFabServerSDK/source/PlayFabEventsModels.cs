using PlayFab.Internal;
using System;
using System.Collections.Generic;

namespace PlayFab.EventsModels
{
    /// <summary>
    /// Entity identifier class that contains both the ID and type.
    /// </summary>
    public class EntityKey
    {
        /// <summary>
        /// Entity profile ID.
        /// </summary>
        public string Id;

        /// <summary>
        /// Entity type. Optional to be used but one of EntityType or EntityTypeString must be set.
        /// </summary>
        public EntityTypes? Type;

        /// <summary>
        /// Entity type. Optional to be used but one of EntityType or EntityTypeString must be set.
        /// </summary>
        public string TypeString;

    }

    public enum EntityTypes
    {
        title,
        master_player_account,
        title_player_account,
        character,
        group,
        service
    }

    public class EventContents
    {
        /// <summary>
        /// Entity associated with the event
        /// </summary>
        public EntityKey Entity;

        /// <summary>
        /// The namespace in which the event is defined. It must be prepended with 'com.playfab.events.'
        /// </summary>
        public string EventNamespace;

        /// <summary>
        /// The name of this event.
        /// </summary>
        public string Name;

        /// <summary>
        /// The original unique identifier associated with this event before it was posted to PlayFab. The value might differ from
        /// the EventId value, which is assigned when the event is received by the server.
        /// </summary>
        public string OriginalId;

        /// <summary>
        /// The time (in UTC) associated with this event when it occurred. If specified, this value is stored in the
        /// OriginalTimestamp property of the PlayStream event.
        /// </summary>
        public DateTime? OriginalTimestamp;

        /// <summary>
        /// Arbitrary data associated with the event. Only one of Payload or PayloadJSON is allowed.
        /// </summary>
        public object Payload;

        /// <summary>
        /// Arbitrary data associated with the event, represented as a JSON serialized string. Only one of Payload or PayloadJSON is
        /// allowed.
        /// </summary>
        public string PayloadJSON;

    }

    public class WriteEventsRequest : PlayFabRequestCommon
    {
        /// <summary>
        /// Collection of events to write to PlayStream.
        /// </summary>
        public List<EventContents> Events;

    }

    public class WriteEventsResponse : PlayFabResultCommon
    {
        /// <summary>
        /// The unique identifiers assigned by the server to the events, in the same order as the events in the request. Only
        /// returned if FlushToPlayStream option is true.
        /// </summary>
        public List<string> AssignedEventIds;

    }
}