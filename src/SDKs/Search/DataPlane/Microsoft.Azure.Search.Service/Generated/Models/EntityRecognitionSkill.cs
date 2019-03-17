// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Search.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Text analytics entity recognition.
    /// <see
    /// href="https://docs.microsoft.com/azure/search/cognitive-search-skill-entity-recognition"
    /// />
    /// </summary>
    [Newtonsoft.Json.JsonObject("#Microsoft.Skills.Text.EntityRecognitionSkill")]
    public partial class EntityRecognitionSkill : Skill
    {
        /// <summary>
        /// Initializes a new instance of the EntityRecognitionSkill class.
        /// </summary>
        public EntityRecognitionSkill()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the EntityRecognitionSkill class.
        /// </summary>
        /// <param name="description">The description of the skill which
        /// describes the inputs, outputs, and usage of the skill.</param>
        /// <param name="context">Represents the level at which operations take
        /// place, such as the document root or document content (for example,
        /// /document or /document/content). The default is /document.</param>
        /// <param name="inputs">Inputs of the skills could be a column in the
        /// source data set, or the output of an upstream skill.</param>
        /// <param name="outputs">The output of a skill is either a field in an
        /// Azure Search index, or a value that can be consumed as an input by
        /// another skill.</param>
        /// <param name="categories">A list of entity categories that should be
        /// extracted.</param>
        /// <param name="defaultLanguageCode">A value indicating which language
        /// code to use. Default is en. Possible values include: 'de', 'en',
        /// 'es', 'fr', 'it'</param>
        /// <param name="includeTypelessEntities">Determines whether or not to
        /// include entities which are well known but don't conform to a type.
        /// If this configuration is not set (default), set to null or set to
        /// false, entities which don't have a type will not be
        /// surfaced.</param>
        public EntityRecognitionSkill(string description = default(string), string context = default(string), IList<InputFieldMappingEntry> inputs = default(IList<InputFieldMappingEntry>), IList<OutputFieldMappingEntry> outputs = default(IList<OutputFieldMappingEntry>), IList<EntityCategory> categories = default(IList<EntityCategory>), EntityRecognitionSkillLanguage? defaultLanguageCode = default(EntityRecognitionSkillLanguage?), bool? includeTypelessEntities = default(bool?))
            : base(description, context, inputs, outputs)
        {
            Categories = categories;
            DefaultLanguageCode = defaultLanguageCode;
            IncludeTypelessEntities = includeTypelessEntities;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets a list of entity categories that should be extracted.
        /// </summary>
        [JsonProperty(PropertyName = "categories")]
        public IList<EntityCategory> Categories { get; set; }

        /// <summary>
        /// Gets or sets a value indicating which language code to use. Default
        /// is en. Possible values include: 'de', 'en', 'es', 'fr', 'it'
        /// </summary>
        [JsonProperty(PropertyName = "defaultLanguageCode")]
        public EntityRecognitionSkillLanguage? DefaultLanguageCode { get; set; }

        /// <summary>
        /// Gets or sets determines whether or not to include entities which
        /// are well known but don't conform to a type. If this configuration
        /// is not set (default), set to null or set to false, entities which
        /// don't have a type will not be surfaced.
        /// </summary>
        [JsonProperty(PropertyName = "includeTypelessEntities")]
        public bool? IncludeTypelessEntities { get; set; }

    }
}
