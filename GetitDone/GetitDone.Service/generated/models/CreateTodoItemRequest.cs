// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.
// <auto-generated />

using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Getitdone.Service.Models
{

    public partial class CreateTodoItemRequest
    {
        public string Content { get; set; }

        public string Description { get; set; }

        public Due Due { get; set; }

        public string[] Labels { get; set; }

        public int? Priority { get; set; }

        [JsonPropertyName("parent_id")]
        public string ParentId { get; set; }

        public int? Order { get; set; }

        [JsonPropertyName("project_id")]
        public string ProjectId { get; set; }

        [JsonPropertyName("section_id")]
        public string SectionId { get; set; }

        [JsonPropertyName("assignee_id")]
        public string AssigneeId { get; set; }


    }
}