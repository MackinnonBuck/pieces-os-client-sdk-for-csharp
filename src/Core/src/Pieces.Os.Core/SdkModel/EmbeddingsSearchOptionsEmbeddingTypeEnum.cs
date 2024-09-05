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
    /// TODO
    /// </summary>
    /// <value>TODO</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum EmbeddingsSearchOptionsEmbeddingTypeEnum
    {
        /// <summary>
        /// Enum JINA for value: JINA
        /// </summary>
        [EnumMember(Value = "JINA")]
        JINA = 1,

        /// <summary>
        /// Enum NCS for value: NCS
        /// </summary>
        [EnumMember(Value = "NCS")]
        NCS = 2
    }

}
