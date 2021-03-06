﻿using Microsoft.Azure.Documents;
using Microsoft.Azure.Mobile.Server.Tables;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileAppDocDBOfflineSyncSampleService.Helpers
{
    public abstract class DocumentResource : Document, ITableData 
    {
       
        [JsonProperty(PropertyName = "id")]
        public override string Id { get; set; }

        [JsonProperty(PropertyName = "version")]
        public byte[] Version { get; set; }

        [JsonProperty(PropertyName = "createdAt")]
        public DateTimeOffset? CreatedAt { get; set; }

        [JsonProperty(PropertyName = "updatedAt")]
        public DateTimeOffset? UpdatedAt { get; set; }

        [JsonProperty(PropertyName = "deleted")]
        public bool Deleted { get; set; }

    }
}
