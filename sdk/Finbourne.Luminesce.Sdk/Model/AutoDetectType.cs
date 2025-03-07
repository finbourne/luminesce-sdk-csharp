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
    /// The method of name/type column inference being used
    /// </summary>
    /// <value>The method of name/type column inference being used</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AutoDetectType
    {
        /// <summary>
        /// Enum Auto for value: Auto
        /// </summary>
        [EnumMember(Value = "Auto")]
        Auto = 1,

        /// <summary>
        /// Enum SpecifyColumnsYetInferTypes for value: SpecifyColumnsYetInferTypes
        /// </summary>
        [EnumMember(Value = "SpecifyColumnsYetInferTypes")]
        SpecifyColumnsYetInferTypes = 2,

        /// <summary>
        /// Enum SpecifyColumnsAndTypes for value: SpecifyColumnsAndTypes
        /// </summary>
        [EnumMember(Value = "SpecifyColumnsAndTypes")]
        SpecifyColumnsAndTypes = 3
    }

}
