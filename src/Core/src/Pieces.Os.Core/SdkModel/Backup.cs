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
    /// This is a cloud Backup. This is specific metadata needed inorder to retrieve a Backup.
    /// </summary>
    [DataContract(Name = "Backup")]
    public partial class Backup : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Platform
        /// </summary>
        [DataMember(Name = "platform", IsRequired = true, EmitDefaultValue = true)]
        public PlatformEnum Platform { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Backup" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Backup() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Backup" /> class.
        /// </summary>
        /// <param name="schema">schema.</param>
        /// <param name="id">id (required).</param>
        /// <param name="varVersion">varVersion (required).</param>
        /// <param name="timestamp">timestamp (required).</param>
        /// <param name="bytes">bytes (required).</param>
        /// <param name="created">created (required).</param>
        /// <param name="deviceName">deviceName (required).</param>
        /// <param name="platform">platform (required).</param>
        public Backup(EmbeddedModelSchema schema = default(EmbeddedModelSchema), string id = default(string), string varVersion = default(string), string timestamp = default(string), decimal bytes = default(decimal), GroupedTimestamp created = default(GroupedTimestamp), string deviceName = default(string), PlatformEnum platform = default(PlatformEnum))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for Backup and cannot be null");
            }
            this.Id = id;
            // to ensure "varVersion" is required (not null)
            if (varVersion == null)
            {
                throw new ArgumentNullException("varVersion is a required property for Backup and cannot be null");
            }
            this.VarVersion = varVersion;
            // to ensure "timestamp" is required (not null)
            if (timestamp == null)
            {
                throw new ArgumentNullException("timestamp is a required property for Backup and cannot be null");
            }
            this.Timestamp = timestamp;
            this.Bytes = bytes;
            // to ensure "created" is required (not null)
            if (created == null)
            {
                throw new ArgumentNullException("created is a required property for Backup and cannot be null");
            }
            this.Created = created;
            // to ensure "deviceName" is required (not null)
            if (deviceName == null)
            {
                throw new ArgumentNullException("deviceName is a required property for Backup and cannot be null");
            }
            this.DeviceName = deviceName;
            this.Platform = platform;
            this.Schema = schema;
        }

        /// <summary>
        /// Gets or Sets Schema
        /// </summary>
        [DataMember(Name = "schema", EmitDefaultValue = false)]
        public EmbeddedModelSchema Schema { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets VarVersion
        /// </summary>
        [DataMember(Name = "version", IsRequired = true, EmitDefaultValue = true)]
        public string VarVersion { get; set; }

        /// <summary>
        /// Gets or Sets Timestamp
        /// </summary>
        [DataMember(Name = "timestamp", IsRequired = true, EmitDefaultValue = true)]
        public string Timestamp { get; set; }

        /// <summary>
        /// Gets or Sets Bytes
        /// </summary>
        [DataMember(Name = "bytes", IsRequired = true, EmitDefaultValue = true)]
        public decimal Bytes { get; set; }

        /// <summary>
        /// Gets or Sets Created
        /// </summary>
        [DataMember(Name = "created", IsRequired = true, EmitDefaultValue = true)]
        public GroupedTimestamp Created { get; set; }

        /// <summary>
        /// Gets or Sets DeviceName
        /// </summary>
        [DataMember(Name = "device_name", IsRequired = true, EmitDefaultValue = true)]
        public string DeviceName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Backup {\n");
            sb.Append("  Schema: ").Append(Schema).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  VarVersion: ").Append(VarVersion).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("  Bytes: ").Append(Bytes).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  DeviceName: ").Append(DeviceName).Append("\n");
            sb.Append("  Platform: ").Append(Platform).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

            /// <summary>
            /// To validate all properties of the instance
            /// </summary>
            /// <param name="validationContext">Validation context</param>
            /// <returns>Validation Result</returns>
            IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
            {
            yield break;
        }
    }

}
