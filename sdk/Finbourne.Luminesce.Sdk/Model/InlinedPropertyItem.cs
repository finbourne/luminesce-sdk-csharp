/*
 * FINBOURNE Luminesce Web API
 *
 * Contact: info@finbourne.com
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
using OpenAPIDateConverter = Finbourne.Luminesce.Sdk.Client.OpenAPIDateConverter;

namespace Finbourne.Luminesce.Sdk.Model
{
    /// <summary>
    /// Information about a inlined property so that decorated properties can be inlined into luminesce
    /// </summary>
    [DataContract(Name = "InlinedPropertyItem")]
    public partial class InlinedPropertyItem : IEquatable<InlinedPropertyItem>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InlinedPropertyItem" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InlinedPropertyItem() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InlinedPropertyItem" /> class.
        /// </summary>
        /// <param name="key">Key of the property (required).</param>
        /// <param name="name">Name of the property.</param>
        /// <param name="isMain">Is Main indicator for the property.</param>
        /// <param name="description">Description of the property.</param>
        /// <param name="dataType">Data type of the property.</param>
        public InlinedPropertyItem(string key = default(string), string name = default(string), bool isMain = default(bool), string description = default(string), string dataType = default(string))
        {
            // to ensure "key" is required (not null)
            if (key == null)
            {
                throw new ArgumentNullException("key is a required property for InlinedPropertyItem and cannot be null");
            }
            this.Key = key;
            this.Name = name;
            this.IsMain = isMain;
            this.Description = description;
            this.DataType = dataType;
        }

        /// <summary>
        /// Key of the property
        /// </summary>
        /// <value>Key of the property</value>
        [DataMember(Name = "key", IsRequired = true, EmitDefaultValue = true)]
        public string Key { get; set; }

        /// <summary>
        /// Name of the property
        /// </summary>
        /// <value>Name of the property</value>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Is Main indicator for the property
        /// </summary>
        /// <value>Is Main indicator for the property</value>
        [DataMember(Name = "isMain", EmitDefaultValue = true)]
        public bool IsMain { get; set; }

        /// <summary>
        /// Description of the property
        /// </summary>
        /// <value>Description of the property</value>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// Data type of the property
        /// </summary>
        /// <value>Data type of the property</value>
        [DataMember(Name = "dataType", EmitDefaultValue = true)]
        public string DataType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InlinedPropertyItem {\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  IsMain: ").Append(IsMain).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  DataType: ").Append(DataType).Append("\n");
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
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as InlinedPropertyItem);
        }

        /// <summary>
        /// Returns true if InlinedPropertyItem instances are equal
        /// </summary>
        /// <param name="input">Instance of InlinedPropertyItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlinedPropertyItem input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Key == input.Key ||
                    (this.Key != null &&
                    this.Key.Equals(input.Key))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.IsMain == input.IsMain ||
                    this.IsMain.Equals(input.IsMain)
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.DataType == input.DataType ||
                    (this.DataType != null &&
                    this.DataType.Equals(input.DataType))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Key != null)
                {
                    hashCode = (hashCode * 59) + this.Key.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.IsMain.GetHashCode();
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.DataType != null)
                {
                    hashCode = (hashCode * 59) + this.DataType.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            // Key (string) minLength
            if (this.Key != null && this.Key.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Key, length must be greater than 1.", new [] { "Key" });
            }

            yield break;
        }
    }
}
