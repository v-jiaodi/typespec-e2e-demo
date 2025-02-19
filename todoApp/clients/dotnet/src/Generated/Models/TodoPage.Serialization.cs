// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Todo;

namespace Todo.Models
{
    /// <summary></summary>
    public partial class TodoPage : IJsonModel<TodoPage>
    {
        internal TodoPage()
        {
        }

        void IJsonModel<TodoPage>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<TodoPage>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TodoPage)} does not support writing '{format}' format.");
            }
            writer.WritePropertyName("items"u8);
            writer.WriteStartArray();
            foreach (TodoItem item in Items)
            {
                writer.WriteObjectValue(item, options);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("pagination"u8);
            writer.WriteObjectValue(Pagination, options);
            if (options.Format != "W" && _additionalBinaryDataProperties != null)
            {
                foreach (var item in _additionalBinaryDataProperties)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
                    writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
        }

        TodoPage IJsonModel<TodoPage>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => JsonModelCreateCore(ref reader, options);

        /// <param name="reader"> The JSON reader. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual TodoPage JsonModelCreateCore(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<TodoPage>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TodoPage)} does not support reading '{format}' format.");
            }
            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeTodoPage(document.RootElement, options);
        }

        internal static TodoPage DeserializeTodoPage(JsonElement element, ModelReaderWriterOptions options)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<TodoItem> items = default;
            TodoPagePagination pagination = default;
            IDictionary<string, BinaryData> additionalBinaryDataProperties = new ChangeTrackingDictionary<string, BinaryData>();
            foreach (var prop in element.EnumerateObject())
            {
                if (prop.NameEquals("items"u8))
                {
                    List<TodoItem> array = new List<TodoItem>();
                    foreach (var item in prop.Value.EnumerateArray())
                    {
                        array.Add(TodoItem.DeserializeTodoItem(item, options));
                    }
                    items = array;
                    continue;
                }
                if (prop.NameEquals("pagination"u8))
                {
                    pagination = TodoPagePagination.DeserializeTodoPagePagination(prop.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalBinaryDataProperties.Add(prop.Name, BinaryData.FromString(prop.Value.GetRawText()));
                }
            }
            return new TodoPage(items, pagination, additionalBinaryDataProperties);
        }

        BinaryData IPersistableModel<TodoPage>.Write(ModelReaderWriterOptions options) => PersistableModelWriteCore(options);

        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual BinaryData PersistableModelWriteCore(ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<TodoPage>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(TodoPage)} does not support writing '{options.Format}' format.");
            }
        }

        TodoPage IPersistableModel<TodoPage>.Create(BinaryData data, ModelReaderWriterOptions options) => PersistableModelCreateCore(data, options);

        /// <param name="data"> The data to parse. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual TodoPage PersistableModelCreateCore(BinaryData data, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<TodoPage>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    using (JsonDocument document = JsonDocument.Parse(data))
                    {
                        return DeserializeTodoPage(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(TodoPage)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<TodoPage>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <param name="todoPage"> The <see cref="TodoPage"/> to serialize into <see cref="BinaryContent"/>. </param>
        public static implicit operator BinaryContent(TodoPage todoPage)
        {
            if (todoPage == null)
            {
                return null;
            }
            return BinaryContent.Create(todoPage, ModelSerializationExtensions.WireOptions);
        }

        /// <param name="result"> The <see cref="ClientResult"/> to deserialize the <see cref="TodoPage"/> from. </param>
        public static explicit operator TodoPage(ClientResult result)
        {
            using PipelineResponse response = result.GetRawResponse();
            using JsonDocument document = JsonDocument.Parse(response.Content);
            return DeserializeTodoPage(document.RootElement, ModelSerializationExtensions.WireOptions);
        }
    }
}
