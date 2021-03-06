// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace k8s.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Rule is a tuple of APIGroups, APIVersion, and Resources.It is
    /// recommended to make sure that all the tuple expansions are valid.
    /// </summary>
    public partial class V1alpha1Rule
    {
        /// <summary>
        /// Initializes a new instance of the V1alpha1Rule class.
        /// </summary>
        public V1alpha1Rule()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V1alpha1Rule class.
        /// </summary>
        /// <param name="apiGroups">APIGroups is the API groups the resources
        /// belong to. '*' is all groups. If '*' is present, the length of the
        /// slice must be one. Required.</param>
        /// <param name="apiVersions">APIVersions is the API versions the
        /// resources belong to. '*' is all versions. If '*' is present, the
        /// length of the slice must be one. Required.</param>
        /// <param name="resources">Resources is a list of resources this rule
        /// applies to.
        ///
        /// For example: 'pods' means pods. 'pods/log' means the log
        /// subresource of pods. '*' means all resources, but not subresources.
        /// 'pods/*' means all subresources of pods. '*/scale' means all scale
        /// subresources. '*/*' means all resources and their subresources.
        ///
        /// If wildcard is present, the validation rule will ensure resources
        /// do not overlap with each other.
        ///
        /// Depending on the enclosing object, subresources might not be
        /// allowed. Required.</param>
        public V1alpha1Rule(IList<string> apiGroups = default(IList<string>), IList<string> apiVersions = default(IList<string>), IList<string> resources = default(IList<string>))
        {
            ApiGroups = apiGroups;
            ApiVersions = apiVersions;
            Resources = resources;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets aPIGroups is the API groups the resources belong to.
        /// '*' is all groups. If '*' is present, the length of the slice must
        /// be one. Required.
        /// </summary>
        [JsonProperty(PropertyName = "apiGroups")]
        public IList<string> ApiGroups { get; set; }

        /// <summary>
        /// Gets or sets aPIVersions is the API versions the resources belong
        /// to. '*' is all versions. If '*' is present, the length of the slice
        /// must be one. Required.
        /// </summary>
        [JsonProperty(PropertyName = "apiVersions")]
        public IList<string> ApiVersions { get; set; }

        /// <summary>
        /// Gets or sets resources is a list of resources this rule applies to.
        ///
        /// For example: 'pods' means pods. 'pods/log' means the log
        /// subresource of pods. '*' means all resources, but not subresources.
        /// 'pods/*' means all subresources of pods. '*/scale' means all scale
        /// subresources. '*/*' means all resources and their subresources.
        ///
        /// If wildcard is present, the validation rule will ensure resources
        /// do not overlap with each other.
        ///
        /// Depending on the enclosing object, subresources might not be
        /// allowed. Required.
        /// </summary>
        [JsonProperty(PropertyName = "resources")]
        public IList<string> Resources { get; set; }

    }
}
