# Ollama Blazor Aspire Demo

## Overview
Ollama Blazor Aspire Demo is a .NET Aspire-based distributed application that integrates Blazor, SQL Server, and Ollama AI models. It provides a scalable architecture for AI-driven chat applications with deep learning model support.

## Features
- **.NET Aspire Architecture**: Uses Aspire for distributed applications and service orchestration.
- **Ollama AI Integration**: Includes deepseek-r1:7b model for AI-powered chat.
- **Blazor Server UI**: Modern and interactive user interface with Razor components.
- **SQL Server with Persistent Storage**: Database integration with automatic provisioning.
- **Containerized Deployment**: Uses Aspire’s container lifecycle management.
- **GPU Support for AI Models**: Optimized inference using GPU acceleration.

## Technologies Used
- **.NET Aspire**
- **Blazor Server**
- **Ollama AI**
- **Microsoft SQL Server**
- **Entity Framework Core**
- **Identity Framework**

## Getting Started

### Prerequisites
- .NET 8 SDK
- Docker (for Aspire container management)
- SQL Server (or use built-in containerized DB)
- Ollama runtime

### Setup
1. Clone the repository:
   ```sh
   git clone https://github.com/fermanquliyev/OllamaBlazorAspireDemo.git
   cd OllamaBlazorAspireDemo
   ```

2. Run the Aspire project:
   ```sh
   dotnet run
   ```

3. The application will start with:
   - SQL Server running in a container
   - Ollama AI service with the chat model
   - Blazor-based UI for interaction

## Project Structure
```
OllamaBlazorAspireDemo
│── OllamaBlazorAspireDemo.AppHost          # Main hosting project
│   ├── Properties
│   ├── appsettings.json
│   ├── aspire-manifest.json                # Defines Aspire services
│   ├── Program.cs                          # Entry point for the app host
│
│── OllamaBlazorAspireDemo.ServiceDefaults  # Shared service configurations
│   ├── Extensions.cs
│   ├── OllamaBlazorAspireDemo.ServiceDefaults.csproj
│
│── OllamaBlazorAspireDemo                  # Blazor Web Application
│   ├── Components
│   │   ├── Account
│   │   ├── Layout
│   │
│   ├── Pages
│   │   ├── Auth.razor
│   │   ├── Chat.razor
│   │   ├── Error.razor
│   │   ├── Home.razor
│   │   ├── App.razor
│   │   ├── Routes.razor
│   │   ├── _Imports.razor
│   │
│   ├── Data
│   ├── Entities
│   ├── Migrations
│   ├── ApplicationDbContext.cs              # Database context
│
│   ├── Properties
│   ├── wwwroot                              # Static assets
│   ├── appsettings.json
│   ├── Program.cs                           # Entry point for Blazor app
│
│── .gitignore
│── .editorconfig
│── libman.json
```

## Contributing
Contributions are welcome! Feel free to submit issues and pull requests.

## License
This project is licensed under the MIT License.

