﻿using System.Collections.Generic;
using Newtonsoft.Json;
using Skybrud.Umbraco.Redirects.Models.Options;

namespace Skybrud.Umbraco.Redirects.Import.Models {
    
    //TODO: We might not need this Class?
    public class RedirectImportItem {

        /// <summary>
        /// The options describing the redirect to be added.
        /// </summary>
        [JsonProperty("options")]
        public AddRedirectOptions AddOptions { get; set; }

        /// <summary>
        /// Gets or sets the import status of the redirect.
        /// </summary>
        [JsonProperty("status")]
        public RedirectImportStatus Status { get; set; }

        /// <summary>
        /// Gets a list of errors triggered by the redirect.
        /// </summary>
        [JsonProperty("errors")]
        public List<string> Errors = new List<string>();

    }

}