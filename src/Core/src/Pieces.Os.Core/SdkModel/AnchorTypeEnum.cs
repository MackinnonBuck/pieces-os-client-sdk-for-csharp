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
    /// This is an enum used to differentiate the different between different anchors. Used in the Anchor data model.
    /// </summary>
    /// <value>This is an enum used to differentiate the different between different anchors. Used in the Anchor data model.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AnchorTypeEnum
    {
        /// <summary>
        /// Enum FILE for value: FILE
        /// </summary>
        [EnumMember(Value = "FILE")]
        FILE = 1,

        /// <summary>
        /// Enum DIRECTORY for value: DIRECTORY
        /// </summary>
        [EnumMember(Value = "DIRECTORY")]
        DIRECTORY = 2
    }

}
