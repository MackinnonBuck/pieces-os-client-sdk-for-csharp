/*
 * Pieces Isomorphic OpenAPI
 *
 * Endpoints for Assets, Formats, Users, Asset, Format, User.
 *
 * The version of the OpenAPI document: 1.0
 * Contact: tsavo@pieces.app
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Pieces.Os.Core.Client.OpenAPIDateConverter;

namespace Pieces.Os.Core.SdkModel
{
    /// <summary>
    /// This will describe the sentiment of a specific message ie if the message was liked/disliked/reported
    /// </summary>
    /// <value>This will describe the sentiment of a specific message ie if the message was liked/disliked/reported</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ConversationMessageSentimentEnum
    {
        /// <summary>
        /// Enum LIKE for value: LIKE
        /// </summary>
        [EnumMember(Value = "LIKE")]
        LIKE = 1,

        /// <summary>
        /// Enum DISLIKE for value: DISLIKE
        /// </summary>
        [EnumMember(Value = "DISLIKE")]
        DISLIKE = 2,

        /// <summary>
        /// Enum REPORT for value: REPORT
        /// </summary>
        [EnumMember(Value = "REPORT")]
        REPORT = 3
    }

}
