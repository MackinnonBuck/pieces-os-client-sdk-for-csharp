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
    /// This will let us know specific hardware information related to the GPU.
    /// </summary>
    [DataContract(Name = "OSDeviceGPUHardwareInformation")]
    public partial class OSDeviceGPUHardwareInformation : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OSDeviceGPUHardwareInformation" /> class.
        /// </summary>
        /// <param name="schema">schema.</param>
        /// <param name="name">name.</param>
        /// <param name="memory">memory.</param>
        /// <param name="sharedMemory">sharedMemory.</param>
        /// <param name="capabilities">capabilities.</param>
        public OSDeviceGPUHardwareInformation(EmbeddedModelSchema schema = default(EmbeddedModelSchema), string name = default(string), decimal memory = default(decimal), bool? sharedMemory = default(bool?), OSDeviceGPUHardwareCapabilitiesInformation capabilities = default(OSDeviceGPUHardwareCapabilitiesInformation))
        {
            this.Schema = schema;
            this.Name = name;
            this.Memory = memory;
            this.SharedMemory = sharedMemory;
            this.Capabilities = capabilities;
        }

        /// <summary>
        /// Gets or Sets Schema
        /// </summary>
        [DataMember(Name = "schema", EmitDefaultValue = false)]
        public EmbeddedModelSchema Schema { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Memory
        /// </summary>
        [DataMember(Name = "memory", EmitDefaultValue = false)]
        public decimal Memory { get; set; }

        /// <summary>
        /// Gets or Sets SharedMemory
        /// </summary>
        [DataMember(Name = "shared_memory", EmitDefaultValue = true)]
        public bool? SharedMemory { get; set; }

        /// <summary>
        /// Gets or Sets Capabilities
        /// </summary>
        [DataMember(Name = "capabilities", EmitDefaultValue = false)]
        public OSDeviceGPUHardwareCapabilitiesInformation Capabilities { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OSDeviceGPUHardwareInformation {\n");
            sb.Append("  Schema: ").Append(Schema).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Memory: ").Append(Memory).Append("\n");
            sb.Append("  SharedMemory: ").Append(SharedMemory).Append("\n");
            sb.Append("  Capabilities: ").Append(Capabilities).Append("\n");
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
