[![Pieces](https://raw.githubusercontent.com/pieces-app/pieces-os-client-sdk-for-csharp/main/assets/pieces-logo.png?token=GHSAT0AAAAAACTAEQJM63MDD3OICVSXMCLCZW2LDQQ)](https://pieces.app)

# Pieces OS Client SDK For C#

[![GitHub contributors](https://img.shields.io/github/contributors/pieces-app/pieces-os-client-sdk-for-csharp.svg)](https://github.com/pieces-app/pieces-os-client-sdk-for-csharp/graphs/contributors)
[![GitHub issues by-label](https://img.shields.io/github/issues/pieces-app/pieces-os-client-sdk-for-csharp)](https://github.com/pieces-app/pieces-os-client-sdk-for-csharp/issues)
[![Pieces.OS.Client SDK on nuget](https://img.shields.io/nuget/vpre/Pieces.OS.Client)](https://www.nuget.org/packages/Pieces.OS.Client/)
[![Pieces.Extensions.AI SDK on nuget](https://img.shields.io/nuget/vpre/Pieces.Extensions.AI)](https://www.nuget.org/packages/Pieces.Extensions.AI/)
[![Discord](https://img.shields.io/badge/Discord-@layer5.svg?color=7389D8&label&logo=discord&logoColor=ffffff)](https://discord.gg/getpieces)
[![Twitter Follow](https://img.shields.io/twitter/follow/pieces.svg?label=Follow)](https://twitter.com/getpieces)
[![License](https://img.shields.io/github/license/pieces-app/pieces-os-client-sdk-for-csharp.svg)](https://github.com/pieces-app/pieces-os-client-sdk-for-csharp/blob/main/LICENSE)

## Introduction

The Pieces OS Client SDK is a set of powerful code engine packages designed for writing applications on top of Pieces OS. It facilitates communication with a locally hosted server to enable features such as copilot chats, asset saving, and more.

This SDK has 2 packages:

- [Pieces.Os.Client](https://www.nuget.org/packages/Pieces.OS.Client/) - this is the core SDK package providing access to the features of Pieces from your C# application
- [Pieces.Extensions.AI](https://www.nuget.org/packages/Pieces.Extensions.AI/) - this is an implementation of [Microsoft.Extensions.AI](https://www.nuget.org/packages/Microsoft.Extensions.AI/) using Pieces to provide support for multiple LLMs, as well as adding context such as snippets, files, folders, and live context to your AI conversation.

## Features

The Pieces SDK offers the following key features:

1. Copilot Chats: Communicate seamlessly with copilot chats functionality.
1. Asset Management: Save and manage assets and formats efficiently.
1. Local Server Interaction: Interact with a locally hosted server for various functionality.
1. Multi LLMs support: Use any Pieces supported LLM to power your app.
1. File, folder, and live context in copilot chats

## Installation

To get started with the Pieces OS Client SDK, follow these steps:

1. **Download Pieces OS**: Pieces OS serves as the primary backend service, providing essential functionality for the SDK. Download the appropriate version for your operating system:
   - [macOS](https://docs.pieces.app/installation-getting-started/macos) 
   - [Windows](https://docs.pieces.app/installation-getting-started/windows) 
   - [Linux](https://docs.pieces.app/installation-getting-started/linux)

1. **Install the SDK**: Use nuget to install the Pieces OS Client SDK package:

   ```shell
   dotnet add package Pieces.OS.Client --prerelease
   ```

1. **Install the Extensions SDK**: If you want [Microsoft.Extensions.AI](https://www.nuget.org/packages/Microsoft.Extensions.AI/) support, install the Pieces.Extensions.AI package:

    ```shell
    dotnet add package Pieces.Extensions.AI --prerelease
    ```

## Pieces.OS.Client Examples

There is an example project using the Pieces.OS.Client package in the [`./src/Client.Example`](./src/Client.Example) folder. This example is a console app containing a range of different examples, each commented out. To run these examples, uncomment the one you wan to run, then run `dotnet run` from the [`./src/Client.Example`](./src/Client.Example) folder.

Details of this example project is provided in the [src/Client/README.md file](./src/Client/README.md).

## Pieces.Extensions.AI Examples

There is an example project using the Pieces.Extensions.AI package in the [`./src/Extensions.Example`](./src/Extensions.Example) folder. This example is a console app containing a range of different examples, each commented out. To run these examples, uncomment the one you wan to run, then run `dotnet run` from the [`./src/Extensions.Example`](./src/Extensions.Example) folder.

Details of this example project is provided in the [src/Extensions/README.md file](./src/Extensions/README.md).
