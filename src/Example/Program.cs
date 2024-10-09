﻿/// This file contains some examples for using the Pieces .NET SDK
///
/// You can find each example in a region below. These examples are commented out, so uncomment each one to run it.
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

using Pieces.OS.Client;

// Set up logging
var services = new ServiceCollection();
services.AddLogging(builder =>builder.AddConsole());
var serviceProvider = services.BuildServiceProvider();
var logger = serviceProvider.GetRequiredService<ILogger<Program>>();

// Create the Pieces client
IPiecesClient client = new PiecesClient(logger);

// Get the copilot and asset manager
var copilot = await client.GetCopilotAsync().ConfigureAwait(false);
var assets = await client.GetAssetsAsync().ConfigureAwait(false);

// Write out the version
Console.WriteLine($"Pieces OS version: {await client.GetVersionAsync().ConfigureAwait(false)}");

// Examples

#region List all the models

// List all the models
//
// This example lists out all the LLMs Pieces currently supports

// {
//     foreach (var model in await client.GetModelsAsync().ConfigureAwait(false))
//     {
//         var modelStatus = model.Cloud ? "Cloud model" : "On-device model";
//         if (!model.Cloud)
//         {
//             var downloaded = model.Downloaded ? "downloaded" : "Not downloaded";
//             modelStatus += $", {downloaded}";
//         }

//         Console.WriteLine($"Model: {model.Name}, ID: {model.Id}. {modelStatus}");
//     }
// }

#endregion List all the models

#region Create a chat and ask a question:

// Create a chat and ask a question
//
// This will create a new copilot chat called C# question on async tasks that you will be able to see in other Pieces applications,
// such as Pieces Desktop, or Pieces for Visual Studio Code.
// The chat will ask a question, then return the full answer to the console once it has the answer.

// {
//     var chat = await copilot.CreateChatAsync("C# question on async tasks").ConfigureAwait(false);

//     var question = "What does the async keyword do in C#?";
//     var response = await chat.AskQuestionAsync(question);

//     Console.WriteLine(question);
//     Console.WriteLine();
//     Console.WriteLine(response);
//     Console.WriteLine();
// }

#endregion Create a chat and ask a question:

#region Create a chat and ask a question, then a follow up question:

// Create a chat and ask a question
//
// This will create a new copilot chat called C# question on async tasks that you will be able to see in other Pieces applications,
// such as Pieces Desktop, or Pieces for Visual Studio Code.
// The chat will ask a question, then return the full answer to the console once it has the answer.
// It will then ask a follow up question that relies on the first question to make sense, to show how copilot chats can have
// context from previous questions in the same chat.

// {
//     var chat = await copilot.CreateChatAsync("2 C# questions on async tasks").ConfigureAwait(false);

//     var question = "What does the async keyword do in C#?";
//     var response = await chat.AskQuestionAsync(question).ConfigureAwait(false);

//     var questionFollowUp = "Give me an example using it with an HTTP call?";
//     var responseFollowUp = await chat.AskQuestionAsync(questionFollowUp).ConfigureAwait(false);

//     Console.WriteLine(question);
//     Console.WriteLine();
//     Console.WriteLine(response);
//     Console.WriteLine();

//     Console.WriteLine(questionFollowUp);
//     Console.WriteLine();
//     Console.WriteLine(responseFollowUp);
//     Console.WriteLine();
// }

#endregion Create a chat and ask a question, then a follow up question:

#region Create a chat then delete it

// Create a chat then delete it
//
// This example creates a conversation, then deletes it. You should see it deleted in other Pieces apps
// like Pieces Desktop

// {
//     var chat = await copilot.CreateChatAsync("This chat will be deleted").ConfigureAwait(false);
//     var response = await chat.AskQuestionAsync("Hello").ConfigureAwait(false);
//     Console.WriteLine(response);

//     await copilot.DeleteChatAsync(chat).ConfigureAwait(false);

//     try
//     {
//         await chat.AskQuestionAsync("Hello").ConfigureAwait(false);
//         Console.WriteLine("Yu should not see this - deleted chats should be unavailable");
//     }
//     catch (Exception)
//     {
//         Console.WriteLine("Exception correctly thrown when accessing a deleted chat");
//     }
    
//     Console.WriteLine();
// }

#endregion Create a chat and delete it

#region Stream the response

// Stream the response
//
// This will create a new copilot chat called C# question on async tasks that you will be able to see in other Pieces applications,
// such as Pieces Desktop, or Pieces for Visual Studio Code.
// The chat will ask a question, then stream the response back token by token

// {
//     var chat = await copilot.CreateChatAsync("C# streaming question on primary constructors").ConfigureAwait(false);

//     var question = "In C#, what is a primary constructor? Give me some example code that declares a class with one.";
//     Console.WriteLine(question);
//     Console.WriteLine();

//     await foreach (var token in chat.AskStreamingQuestionAsync(question))
//     {
//         Console.Write(token);
//     }

//     Console.WriteLine();
// }

#endregion Stream the response

#region Use live context

// Use live context
//
// This will create a new copilot chat called 1 hour context window, with live context turned on that you will be able to see in other Pieces applications,
// such as Pieces Desktop, or Pieces for Visual Studio Code. You will also be able to see live context turned on against the chat
// The chat will ask a question related to this code file using a 1 hour context window, then stream the response back token by token

// {
//     var chat = await copilot.CreateChatAsync("1 hour context window", useLiveContext: true).ConfigureAwait(false);

//     var question = "Describe the Program.cs file I was just reading in my IDE";
//     Console.WriteLine(question);
//     Console.WriteLine();

//     await foreach (var token in chat.AskStreamingQuestionAsync(question, liveContextTimeSpan: TimeSpan.FromHours(1)))
//     {
//         Console.Write(token);
//     }

//     Console.WriteLine();
// }

#endregion Use live context

#region Load assets

// Load assets
//
// This example loads all the assets in your current Pieces OS and prints the names and language

// await foreach(var asset in assets.GetAllAssetsAsync())
// {
//     var language = asset.Formats.Iterable.FirstOrDefault(a => !string.IsNullOrWhiteSpace(a?.Analysis?.Code?.Language))?.Analysis?.Code?.Language;
//     Console.WriteLine($"{asset.Name} - {language}");
// }

#endregion Load assets

#region Create an asset and use it in a copilot chat

// Create an asset and use it in a copilot chat
//
// This example creates a new asset. It then uses it in a copilot chat asking a question about it.

// {
//     var assetCode = @"using System;
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             // Prompt the user for their name
//             Console.Write(""Please enter your name: "");
            
//             // Read the user's input
//             string name = Console.ReadLine();
            
//             // Print a greeting with the user's name
//             Console.WriteLine($""Hello, {name}! Nice to meet you."");
            
//             // Wait for the user to press a key before closing the console window
//             Console.WriteLine(""Press any key to exit..."");
//             Console.ReadKey();
//         }
//     }
//     ";

//     var newAsset = await assets.CreateAssetAsync(assetCode).ConfigureAwait(false);
//     Console.WriteLine($"Asset created = name {newAsset.Name}, id: {newAsset.Id}");

//     var chat = await copilot.CreateChatAsync("C# chat with an asset", assetIds: [newAsset.Id]).ConfigureAwait(false);

//     var question = "Describe this C# program";
//     Console.WriteLine(question);
//     Console.WriteLine();

//     await foreach (var token in chat.AskStreamingQuestionAsync(question))
//     {
//         Console.Write(token);
//     }

//     Console.WriteLine();
// }

#endregion Create an asset and use it in a copilot chat

#region Change the model

// Change the model
//
// This example shows how to select a different model and use it for a copilot chat
// If the current model is claude, select GPT-4o, otherwise select Claude

// {
//     var models = await client.GetModelsAsync().ConfigureAwait(false);
//     var claudeModel = models.First(m => m.Name.Contains("Claude 3.5 Sonnet", StringComparison.CurrentCultureIgnoreCase));
//     var gpt4oModel = models.First(m => m.Name.Contains("GPT-4o", StringComparison.CurrentCultureIgnoreCase));

//     var chatModel = copilot.Model.Id == claudeModel.Id ? gpt4oModel : claudeModel;

//     var chat = await copilot.CreateChatAsync("Chat with a different model", model: chatModel).ConfigureAwait(false);
//     var question = "What LLM are you?";
//     Console.WriteLine(question);
//     Console.WriteLine();

//     await foreach (var token in chat.AskStreamingQuestionAsync(question))
//     {
//         Console.Write(token);
//     }
// }

#endregion Change the model

#region Change the model to a local model

// Change the model to a local model
//
// This example shows how to select a different model and use it for a copilot chat
// In this case, the model is a local model, so may need to be downloaded. If the model needs to be downloaded,
// you will be able to monitor the progress in Pieces Desktop

// {
//     var models = await client.GetModelsAsync().ConfigureAwait(false);
//     var llamaModel = models.First(m => m.Name.Contains("Llama-3", StringComparison.CurrentCultureIgnoreCase));
//     var phi3Model = models.First(m => m.Name.Contains("Phi-3", StringComparison.CurrentCultureIgnoreCase));

//     var chatModel = copilot.Model.Id == llamaModel.Id ? phi3Model : llamaModel;

//     if (!chatModel.Downloaded)
//     {
//         await client.DownloadModelAsync(chatModel).ConfigureAwait(false);
//     }

//     var chat = await copilot.CreateChatAsync("Chat with a different model", model: chatModel).ConfigureAwait(false);
//     var question = "What LLM are you?";
//     Console.WriteLine(question);
//     Console.WriteLine();

//     await foreach (var token in chat.AskStreamingQuestionAsync(question))
//     {
//         Console.Write(token);
//     }
// }

#endregion Change the model to a local model
