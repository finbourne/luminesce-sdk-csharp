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
    /// A single on clause term (a pair of columns to join or a column to filter on)
    /// </summary>
    [DataContract(Name = "OnClauseTermDesign")]
    public partial class OnClauseTermDesign : IEquatable<OnClauseTermDesign>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Operator
        /// </summary>
        [DataMember(Name = "operator", IsRequired = true, EmitDefaultValue = true)]
        public QueryDesignerBinaryOperator Operator { get; set; }

        /// <summary>
        /// Gets or Sets FilterValueDataType
        /// </summary>
        [DataMember(Name = "filterValueDataType", EmitDefaultValue = false)]
        public DataType? FilterValueDataType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="OnClauseTermDesign" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected OnClauseTermDesign() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="OnClauseTermDesign" /> class.
        /// </summary>
        /// <param name="leftTableField">Name of field in the left table to join to (complex expressions are not supported at this time).</param>
        /// <param name="rightTableField">Name of field in the left table to join to (complex expressions are not supported at this time).</param>
        /// <param name="varOperator">varOperator (required).</param>
        /// <param name="filterValue">The value to compare against (always as a string, but will be formatted to the correct type).</param>
        /// <param name="filterValueDataType">filterValueDataType.</param>
        public OnClauseTermDesign(string leftTableField = default(string), string rightTableField = default(string), QueryDesignerBinaryOperator varOperator = default(QueryDesignerBinaryOperator), string filterValue = default(string), DataType ?filterValueDataType = default(DataType?))
        {
            this.Operator = varOperator;
            this.LeftTableField = leftTableField;
            this.RightTableField = rightTableField;
            this.FilterValue = filterValue;
            this.FilterValueDataType = filterValueDataType;
        }

        /// <summary>
        /// Name of field in the left table to join to (complex expressions are not supported at this time)
        /// </summary>
        /// <value>Name of field in the left table to join to (complex expressions are not supported at this time)</value>
        [DataMember(Name = "leftTableField", EmitDefaultValue = true)]
        public string LeftTableField { get; set; }

        /// <summary>
        /// Name of field in the left table to join to (complex expressions are not supported at this time)
        /// </summary>
        /// <value>Name of field in the left table to join to (complex expressions are not supported at this time)</value>
        [DataMember(Name = "rightTableField", EmitDefaultValue = true)]
        public string RightTableField { get; set; }

        /// <summary>
        /// The value to compare against (always as a string, but will be formatted to the correct type)
        /// </summary>
        /// <value>The value to compare against (always as a string, but will be formatted to the correct type)</value>
        [DataMember(Name = "filterValue", EmitDefaultValue = true)]
        public string FilterValue { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OnClauseTermDesign {\n");
            sb.Append("  LeftTableField: ").Append(LeftTableField).Append("\n");
            sb.Append("  RightTableField: ").Append(RightTableField).Append("\n");
            sb.Append("  Operator: ").Append(Operator).Append("\n");
            sb.Append("  FilterValue: ").Append(FilterValue).Append("\n");
            sb.Append("  FilterValueDataType: ").Append(FilterValueDataType).Append("\n");
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
            return this.Equals(input as OnClauseTermDesign);
        }

        /// <summary>
        /// Returns true if OnClauseTermDesign instances are equal
        /// </summary>
        /// <param name="input">Instance of OnClauseTermDesign to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OnClauseTermDesign input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.LeftTableField == input.LeftTableField ||
                    (this.LeftTableField != null &&
                    this.LeftTableField.Equals(input.LeftTableField))
                ) && 
                (
                    this.RightTableField == input.RightTableField ||
                    (this.RightTableField != null &&
                    this.RightTableField.Equals(input.RightTableField))
                ) && 
                (
                    this.Operator == input.Operator ||
                    this.Operator.Equals(input.Operator)
                ) && 
                (
                    this.FilterValue == input.FilterValue ||
                    (this.FilterValue != null &&
                    this.FilterValue.Equals(input.FilterValue))
                ) && 
                (
                    this.FilterValueDataType == input.FilterValueDataType ||
                    this.FilterValueDataType.Equals(input.FilterValueDataType)
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
                if (this.LeftTableField != null)
                {
                    hashCode = (hashCode * 59) + this.LeftTableField.GetHashCode();
                }
                if (this.RightTableField != null)
                {
                    hashCode = (hashCode * 59) + this.RightTableField.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Operator.GetHashCode();
                if (this.FilterValue != null)
                {
                    hashCode = (hashCode * 59) + this.FilterValue.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.FilterValueDataType.GetHashCode();
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
            // LeftTableField (string) maxLength
            if (this.LeftTableField != null && this.LeftTableField.Length > 256)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for LeftTableField, length must be less than 256.", new [] { "LeftTableField" });
            }

            // LeftTableField (string) minLength
            if (this.LeftTableField != null && this.LeftTableField.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for LeftTableField, length must be greater than 0.", new [] { "LeftTableField" });
            }

            // RightTableField (string) maxLength
            if (this.RightTableField != null && this.RightTableField.Length > 256)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for RightTableField, length must be less than 256.", new [] { "RightTableField" });
            }

            // RightTableField (string) minLength
            if (this.RightTableField != null && this.RightTableField.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for RightTableField, length must be greater than 0.", new [] { "RightTableField" });
            }

            // FilterValue (string) maxLength
            if (this.FilterValue != null && this.FilterValue.Length > 2048)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for FilterValue, length must be less than 2048.", new [] { "FilterValue" });
            }

            // FilterValue (string) minLength
            if (this.FilterValue != null && this.FilterValue.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for FilterValue, length must be greater than 0.", new [] { "FilterValue" });
            }

            yield break;
        }
    }
}
