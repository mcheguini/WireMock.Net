﻿using System;

namespace WireMock.Admin.Requests
{
    /// <summary>
    /// Request Log Model
    /// </summary>
    [FluentBuilder.AutoGenerateBuilder]
    public class LogEntryModel
    {
        /// <summary>
        /// The unique identifier.
        /// </summary>
        public Guid Guid { get; set; }

        /// <summary>
        /// The request.
        /// </summary>
        public LogRequestModel Request { get; set; }

        /// <summary>
        /// The response.
        /// </summary>
        public LogResponseModel Response { get; set; }

        /// <summary>
        /// The mapping unique identifier.
        /// </summary>
        public Guid? MappingGuid { get; set; }

        /// <summary>
        /// The mapping unique title.
        /// </summary>
        public string MappingTitle { get; set; }

        /// <summary>
        /// The request match result.
        /// </summary>
        public LogRequestMatchModel RequestMatchResult { get; set; }

        /// <summary>
        /// The partial mapping unique identifier.
        /// </summary>
        public Guid? PartialMappingGuid { get; set; }

        /// <summary>
        /// The partial mapping unique title.
        /// </summary>
        public string PartialMappingTitle { get; set; }

        /// <summary>
        /// The partial request match result.
        /// </summary>
        public LogRequestMatchModel PartialRequestMatchResult { get; set; }
    }
}