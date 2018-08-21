// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.BatchAI.Fluent.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Additional parameters for ListByWorkspace operation.
    /// </summary>
    public partial class ExperimentsListByWorkspaceOptions
    {
        /// <summary>
        /// Initializes a new instance of the ExperimentsListByWorkspaceOptions
        /// class.
        /// </summary>
        public ExperimentsListByWorkspaceOptions()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ExperimentsListByWorkspaceOptions
        /// class.
        /// </summary>
        /// <param name="maxResults">The maximum number of items to return in
        /// the response. A maximum of 1000 files can be returned.</param>
        public ExperimentsListByWorkspaceOptions(int? maxResults = default(int?))
        {
            MaxResults = maxResults;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the maximum number of items to return in the response.
        /// A maximum of 1000 files can be returned.
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        public int? MaxResults { get; set; }

    }
}
