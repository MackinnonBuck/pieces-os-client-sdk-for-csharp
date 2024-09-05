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
    /// This is the enum used to describe the severity of our sensitive model. ie low, moderate, high
    /// </summary>
    /// <value>This is the enum used to describe the severity of our sensitive model. ie low, moderate, high</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SensitiveSeverityEnum
    {
        /// <summary>
        /// Enum LOW for value: LOW
        /// </summary>
        [EnumMember(Value = "LOW")]
        LOW = 1,

        /// <summary>
        /// Enum MODERATE for value: MODERATE
        /// </summary>
        [EnumMember(Value = "MODERATE")]
        MODERATE = 2,

        /// <summary>
        /// Enum HIGH for value: HIGH
        /// </summary>
        [EnumMember(Value = "HIGH")]
        HIGH = 3
    }

}
