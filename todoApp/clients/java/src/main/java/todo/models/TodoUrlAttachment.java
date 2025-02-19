// Code generated by Microsoft (R) TypeSpec Code Generator.

package todo.models;

import io.clientcore.core.annotation.Metadata;
import io.clientcore.core.annotation.TypeConditions;
import io.clientcore.core.json.JsonReader;
import io.clientcore.core.json.JsonSerializable;
import io.clientcore.core.json.JsonToken;
import io.clientcore.core.json.JsonWriter;
import java.io.IOException;

/**
 * The TodoUrlAttachment model.
 */
@Metadata(conditions = { TypeConditions.IMMUTABLE })
public final class TodoUrlAttachment implements JsonSerializable<TodoUrlAttachment> {
    /*
     * A description of the URL
     */
    @Metadata(generated = true)
    private final String description;

    /*
     * The url
     */
    @Metadata(generated = true)
    private final String url;

    /**
     * Creates an instance of TodoUrlAttachment class.
     * 
     * @param description the description value to set.
     * @param url the url value to set.
     */
    @Metadata(generated = true)
    public TodoUrlAttachment(String description, String url) {
        this.description = description;
        this.url = url;
    }

    /**
     * Get the description property: A description of the URL.
     * 
     * @return the description value.
     */
    @Metadata(generated = true)
    public String getDescription() {
        return this.description;
    }

    /**
     * Get the url property: The url.
     * 
     * @return the url value.
     */
    @Metadata(generated = true)
    public String getUrl() {
        return this.url;
    }

    /**
     * {@inheritDoc}
     */
    @Metadata(generated = true)
    @Override
    public JsonWriter toJson(JsonWriter jsonWriter) throws IOException {
        jsonWriter.writeStartObject();
        jsonWriter.writeStringField("description", this.description);
        jsonWriter.writeStringField("url", this.url);
        return jsonWriter.writeEndObject();
    }

    /**
     * Reads an instance of TodoUrlAttachment from the JsonReader.
     * 
     * @param jsonReader The JsonReader being read.
     * @return An instance of TodoUrlAttachment if the JsonReader was pointing to an instance of it, or null if it was
     * pointing to JSON null.
     * @throws IllegalStateException If the deserialized JSON object was missing any required properties.
     * @throws IOException If an error occurs while reading the TodoUrlAttachment.
     */
    @Metadata(generated = true)
    public static TodoUrlAttachment fromJson(JsonReader jsonReader) throws IOException {
        return jsonReader.readObject(reader -> {
            String description = null;
            String url = null;
            while (reader.nextToken() != JsonToken.END_OBJECT) {
                String fieldName = reader.getFieldName();
                reader.nextToken();

                if ("description".equals(fieldName)) {
                    description = reader.getString();
                } else if ("url".equals(fieldName)) {
                    url = reader.getString();
                } else {
                    reader.skipChildren();
                }
            }
            return new TodoUrlAttachment(description, url);
        });
    }
}
