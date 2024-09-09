// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.SecurityInsights.Models;

namespace Azure.ResourceManager.SecurityInsights
{
    /// <summary>
    /// A class representing the SecurityInsightsProductTemplate data model.
    /// Template resource definition.
    /// </summary>
    public partial class SecurityInsightsProductTemplateData : ResourceData
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="SecurityInsightsProductTemplateData"/>. </summary>
        public SecurityInsightsProductTemplateData()
        {
            Providers = new ChangeTrackingList<string>();
            ThreatAnalysisTactics = new ChangeTrackingList<string>();
            ThreatAnalysisTechniques = new ChangeTrackingList<string>();
            PreviewImages = new ChangeTrackingList<string>();
            PreviewImagesDark = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="SecurityInsightsProductTemplateData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="contentId"> Static ID for the content.  Used to identify dependencies and content from solutions or community.  Hard-coded/static for out of the box content and solutions. Dynamic for user-created.  This is the resource name. </param>
        /// <param name="contentProductId"> Unique ID for the content. It should be generated based on the contentId of the package, contentId of the template, contentKind of the template and the contentVersion of the template. </param>
        /// <param name="packageVersion"> Version of the package.  Default and recommended format is numeric (e.g. 1, 1.0, 1.0.0, 1.0.0.0), following ARM metadata best practices.  Can also be any string, but then we cannot guarantee any version checks. </param>
        /// <param name="version"> Version of the content.  Default and recommended format is numeric (e.g. 1, 1.0, 1.0.0, 1.0.0.0), following ARM metadata best practices.  Can also be any string, but then we cannot guarantee any version checks. </param>
        /// <param name="displayName"> The display name of the template. </param>
        /// <param name="contentKind"> The kind of content the template is for. </param>
        /// <param name="source"> Source of the content.  This is where/how it was created. </param>
        /// <param name="author"> The creator of the content item. </param>
        /// <param name="support"> Support information for the template - type, name, contact information. </param>
        /// <param name="dependencies"> Dependencies for the content item, what other content items it requires to work.  Can describe more complex dependencies using a recursive/nested structure. For a single dependency an id/kind/version can be supplied or operator/criteria for complex formats. </param>
        /// <param name="categories"> Categories for the item. </param>
        /// <param name="providers"> Providers for the content item. </param>
        /// <param name="firstPublishOn"> first publish date content item. </param>
        /// <param name="lastPublishOn"> last publish date for the content item. </param>
        /// <param name="customVersion"> The custom version of the content. A optional free text. </param>
        /// <param name="contentSchemaVersion"> Schema version of the content. Can be used to distinguish between different flow based on the schema version. </param>
        /// <param name="icon"> the icon identifier. this id can later be fetched from the content metadata. </param>
        /// <param name="threatAnalysisTactics"> the tactics the resource covers. </param>
        /// <param name="threatAnalysisTechniques"> the techniques the resource covers, these have to be aligned with the tactics being used. </param>
        /// <param name="previewImages"> preview image file names. These will be taken from the solution artifacts. </param>
        /// <param name="previewImagesDark"> preview image file names. These will be taken from the solution artifacts. used for dark theme support. </param>
        /// <param name="packageId"> the package Id contains this template. </param>
        /// <param name="packageKind"> the packageKind of the package contains this template. </param>
        /// <param name="packageName"> the name of the package contains this template. </param>
        /// <param name="isDeprecated"> Flag indicates if this template is deprecated. </param>
        /// <param name="packagedContent"> The json of the ARM template to deploy. </param>
        /// <param name="etag"> Etag of the azure resource. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SecurityInsightsProductTemplateData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string contentId, string contentProductId, string packageVersion, string version, string displayName, SecurityInsightsKind? contentKind, SecurityInsightsMetadataSource source, SecurityInsightsMetadataAuthor author, SecurityInsightsMetadataSupport support, SecurityInsightsMetadataDependencies dependencies, SecurityInsightsMetadataCategories categories, IList<string> providers, DateTimeOffset? firstPublishOn, DateTimeOffset? lastPublishOn, string customVersion, string contentSchemaVersion, string icon, IList<string> threatAnalysisTactics, IList<string> threatAnalysisTechniques, IList<string> previewImages, IList<string> previewImagesDark, string packageId, SecurityInsightsMetadataPackageKind? packageKind, string packageName, SecurityInsightsMetadataFlag? isDeprecated, BinaryData packagedContent, ETag? etag, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            ContentId = contentId;
            ContentProductId = contentProductId;
            PackageVersion = packageVersion;
            Version = version;
            DisplayName = displayName;
            ContentKind = contentKind;
            Source = source;
            Author = author;
            Support = support;
            Dependencies = dependencies;
            Categories = categories;
            Providers = providers;
            FirstPublishOn = firstPublishOn;
            LastPublishOn = lastPublishOn;
            CustomVersion = customVersion;
            ContentSchemaVersion = contentSchemaVersion;
            Icon = icon;
            ThreatAnalysisTactics = threatAnalysisTactics;
            ThreatAnalysisTechniques = threatAnalysisTechniques;
            PreviewImages = previewImages;
            PreviewImagesDark = previewImagesDark;
            PackageId = packageId;
            PackageKind = packageKind;
            PackageName = packageName;
            IsDeprecated = isDeprecated;
            PackagedContent = packagedContent;
            ETag = etag;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Static ID for the content.  Used to identify dependencies and content from solutions or community.  Hard-coded/static for out of the box content and solutions. Dynamic for user-created.  This is the resource name. </summary>
        [WirePath("properties.contentId")]
        public string ContentId { get; set; }
        /// <summary> Unique ID for the content. It should be generated based on the contentId of the package, contentId of the template, contentKind of the template and the contentVersion of the template. </summary>
        [WirePath("properties.contentProductId")]
        public string ContentProductId { get; set; }
        /// <summary> Version of the package.  Default and recommended format is numeric (e.g. 1, 1.0, 1.0.0, 1.0.0.0), following ARM metadata best practices.  Can also be any string, but then we cannot guarantee any version checks. </summary>
        [WirePath("properties.packageVersion")]
        public string PackageVersion { get; set; }
        /// <summary> Version of the content.  Default and recommended format is numeric (e.g. 1, 1.0, 1.0.0, 1.0.0.0), following ARM metadata best practices.  Can also be any string, but then we cannot guarantee any version checks. </summary>
        [WirePath("properties.version")]
        public string Version { get; set; }
        /// <summary> The display name of the template. </summary>
        [WirePath("properties.displayName")]
        public string DisplayName { get; set; }
        /// <summary> The kind of content the template is for. </summary>
        [WirePath("properties.contentKind")]
        public SecurityInsightsKind? ContentKind { get; set; }
        /// <summary> Source of the content.  This is where/how it was created. </summary>
        [WirePath("properties.source")]
        public SecurityInsightsMetadataSource Source { get; set; }
        /// <summary> The creator of the content item. </summary>
        [WirePath("properties.author")]
        public SecurityInsightsMetadataAuthor Author { get; set; }
        /// <summary> Support information for the template - type, name, contact information. </summary>
        [WirePath("properties.support")]
        public SecurityInsightsMetadataSupport Support { get; set; }
        /// <summary> Dependencies for the content item, what other content items it requires to work.  Can describe more complex dependencies using a recursive/nested structure. For a single dependency an id/kind/version can be supplied or operator/criteria for complex formats. </summary>
        [WirePath("properties.dependencies")]
        public SecurityInsightsMetadataDependencies Dependencies { get; set; }
        /// <summary> Categories for the item. </summary>
        [WirePath("properties.categories")]
        public SecurityInsightsMetadataCategories Categories { get; set; }
        /// <summary> Providers for the content item. </summary>
        [WirePath("properties.providers")]
        public IList<string> Providers { get; }
        /// <summary> first publish date content item. </summary>
        [WirePath("properties.firstPublishDate")]
        public DateTimeOffset? FirstPublishOn { get; set; }
        /// <summary> last publish date for the content item. </summary>
        [WirePath("properties.lastPublishDate")]
        public DateTimeOffset? LastPublishOn { get; set; }
        /// <summary> The custom version of the content. A optional free text. </summary>
        [WirePath("properties.customVersion")]
        public string CustomVersion { get; set; }
        /// <summary> Schema version of the content. Can be used to distinguish between different flow based on the schema version. </summary>
        [WirePath("properties.contentSchemaVersion")]
        public string ContentSchemaVersion { get; set; }
        /// <summary> the icon identifier. this id can later be fetched from the content metadata. </summary>
        [WirePath("properties.icon")]
        public string Icon { get; set; }
        /// <summary> the tactics the resource covers. </summary>
        [WirePath("properties.threatAnalysisTactics")]
        public IList<string> ThreatAnalysisTactics { get; }
        /// <summary> the techniques the resource covers, these have to be aligned with the tactics being used. </summary>
        [WirePath("properties.threatAnalysisTechniques")]
        public IList<string> ThreatAnalysisTechniques { get; }
        /// <summary> preview image file names. These will be taken from the solution artifacts. </summary>
        [WirePath("properties.previewImages")]
        public IList<string> PreviewImages { get; }
        /// <summary> preview image file names. These will be taken from the solution artifacts. used for dark theme support. </summary>
        [WirePath("properties.previewImagesDark")]
        public IList<string> PreviewImagesDark { get; }
        /// <summary> the package Id contains this template. </summary>
        [WirePath("properties.packageId")]
        public string PackageId { get; set; }
        /// <summary> the packageKind of the package contains this template. </summary>
        [WirePath("properties.packageKind")]
        public SecurityInsightsMetadataPackageKind? PackageKind { get; set; }
        /// <summary> the name of the package contains this template. </summary>
        [WirePath("properties.packageName")]
        public string PackageName { get; set; }
        /// <summary> Flag indicates if this template is deprecated. </summary>
        [WirePath("properties.isDeprecated")]
        public SecurityInsightsMetadataFlag? IsDeprecated { get; }
        /// <summary>
        /// The json of the ARM template to deploy
        /// <para>
        /// To assign an object to this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        [WirePath("properties.packagedContent")]
        public BinaryData PackagedContent { get; set; }
        /// <summary> Etag of the azure resource. </summary>
        [WirePath("etag")]
        public ETag? ETag { get; set; }
    }
}
