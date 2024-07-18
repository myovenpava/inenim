using System;
using System.Collections.Generic;

class Program {
    static void Main() {
        CreateContentItemParameters createParams = new CreateContentItemParameters(
            "New Content Item",
            "This is a description of the new content item.",
            new List<string> { "csharp", "programming", "example" },
            "John Smith"
        );

        // Use createParams as needed
        Console.WriteLine("Title: " + createParams.Title);
        Console.WriteLine("Description: " + createParams.Description);
        Console.WriteLine("Tags: " + string.Join(", ", createParams.Tags));
        Console.WriteLine("Created By: " + createParams.CreatedBy);
        Console.WriteLine("Created At: " + createParams.CreatedAt);
    }
}
