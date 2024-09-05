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
    /// Enum used for the status of creating a backup or restoring a backup.
    /// </summary>
    /// <value>Enum used for the status of creating a backup or restoring a backup.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum BackupStatusEnum
    {
        /// <summary>
        /// Enum INITIALIZED for value: INITIALIZED
        /// </summary>
        [EnumMember(Value = "INITIALIZED")]
        INITIALIZED = 1,

        /// <summary>
        /// Enum INPROGRESS for value: IN-PROGRESS
        /// </summary>
        [EnumMember(Value = "IN-PROGRESS")]
        INPROGRESS = 2,

        /// <summary>
        /// Enum COMPLETED for value: COMPLETED
        /// </summary>
        [EnumMember(Value = "COMPLETED")]
        COMPLETED = 3,

        /// <summary>
        /// Enum FAILED for value: FAILED
        /// </summary>
        [EnumMember(Value = "FAILED")]
        FAILED = 4,

        /// <summary>
        /// Enum UNKNOWN for value: UNKNOWN
        /// </summary>
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN = 5,

        /// <summary>
        /// Enum CANCELED for value: CANCELED
        /// </summary>
        [EnumMember(Value = "CANCELED")]
        CANCELED = 6,

        /// <summary>
        /// Enum RESET for value: RESET
        /// </summary>
        [EnumMember(Value = "RESET")]
        RESET = 7
    }

}
