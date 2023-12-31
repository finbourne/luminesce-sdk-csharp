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
    /// Parameters of view
    /// </summary>
    [DataContract(Name = "ViewParameter")]
    public partial class ViewParameter : IEquatable<ViewParameter>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets DataType
        /// </summary>
        [DataMember(Name = "dataType", IsRequired = true, EmitDefaultValue = true)]
        public DataType DataType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ViewParameter" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ViewParameter() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ViewParameter" /> class.
        /// </summary>
        /// <param name="name">Name of the provider (required).</param>
        /// <param name="dataType">dataType (required).</param>
        /// <param name="value">Value of the provider (required).</param>
        /// <param name="isTableDataMandatory">Should this be selected? False would imply it is only being filtered on.  Ignored when Aggregations are present.</param>
        /// <param name="description">Description of the parameter.</param>
        public ViewParameter(string name = default(string), DataType dataType = default(DataType), string value = default(string), bool isTableDataMandatory = default(bool), string description = default(string))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for ViewParameter and cannot be null");
            }
            this.Name = name;
            this.DataType = dataType;
            // to ensure "value" is required (not null)
            if (value == null)
            {
                throw new ArgumentNullException("value is a required property for ViewParameter and cannot be null");
            }
            this.Value = value;
            this.IsTableDataMandatory = isTableDataMandatory;
            this.Description = description;
        }

        /// <summary>
        /// Name of the provider
        /// </summary>
        /// <value>Name of the provider</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Value of the provider
        /// </summary>
        /// <value>Value of the provider</value>
        [DataMember(Name = "value", IsRequired = true, EmitDefaultValue = true)]
        public string Value { get; set; }

        /// <summary>
        /// Should this be selected? False would imply it is only being filtered on.  Ignored when Aggregations are present
        /// </summary>
        /// <value>Should this be selected? False would imply it is only being filtered on.  Ignored when Aggregations are present</value>
        [DataMember(Name = "isTableDataMandatory", EmitDefaultValue = true)]
        public bool IsTableDataMandatory { get; set; }

        /// <summary>
        /// Description of the parameter
        /// </summary>
        /// <value>Description of the parameter</value>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ViewParameter {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  DataType: ").Append(DataType).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  IsTableDataMandatory: ").Append(IsTableDataMandatory).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
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
            return this.Equals(input as ViewParameter);
        }

        /// <summary>
        /// Returns true if ViewParameter instances are equal
        /// </summary>
        /// <param name="input">Instance of ViewParameter to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ViewParameter input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.DataType == input.DataType ||
                    this.DataType.Equals(input.DataType)
                ) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
                ) && 
                (
                    this.IsTableDataMandatory == input.IsTableDataMandatory ||
                    this.IsTableDataMandatory.Equals(input.IsTableDataMandatory)
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
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
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.DataType.GetHashCode();
                if (this.Value != null)
                {
                    hashCode = (hashCode * 59) + this.Value.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.IsTableDataMandatory.GetHashCode();
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
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
            // Name (string) maxLength
            if (this.Name != null && this.Name.Length > 256)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be less than 256.", new [] { "Name" });
            }

            // Name (string) minLength
            if (this.Name != null && this.Name.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be greater than 0.", new [] { "Name" });
            }

            // Value (string) maxLength
            if (this.Value != null && this.Value.Length > 256)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Value, length must be less than 256.", new [] { "Value" });
            }

            // Value (string) minLength
            if (this.Value != null && this.Value.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Value, length must be greater than 0.", new [] { "Value" });
            }

            // Description (string) maxLength
            if (this.Description != null && this.Description.Length > 256)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Description, length must be less than 256.", new [] { "Description" });
            }

            // Description (string) minLength
            if (this.Description != null && this.Description.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Description, length must be greater than 0.", new [] { "Description" });
            }

            yield break;
        }
    }
}
