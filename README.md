# Running C# 13 Scripts With `dotnet run app.cs` (No Project Files Needed)

This repository (csharp13-scripting-examples) is available with Ziggy Rafiq's book **Running C# 13 Scripts With Dotnet Run App.cs.** available at **[C# Corner](https://www.c-sharpcorner.com/members/ziggy-rafiq)**.

Using the latest .NET 9 SDK features such as top-level statements, global usage, and modern language enhancements, it provides practical examples, templates, and guidance for writing and executing C# 13 scripts without projects.

---

## 🚀 What You’ll Learn

- How to **run single-file C# scripts** with `dotnet run app.cs`
- Using **.NET SDK defaults** for quick prototypes and automation
- Writing scripts with **C# 13 features**: primary constructors, list patterns, file-local types, records, and more
- Managing dependencies with **NuGet** (via `dotnet-script` or minimal projects)
- Practical **workarounds** for script limitations (config, environment variables, arguments)
- Structuring **production-ready script templates** using config files, error handling, and multi-file organization

---

## Repository Structure

Each chapter has a dedicated folder with runnable examples:

```
/csharp13-scripting-examples
  ├── Chapter-01   # Introduction and first scripts
  ├── Chapter-02   # Prerequisites & setup
  ├── Chapter-03   # Source file compilation
  ├── Chapter-04   # First simple example
  ├── Chapter-05   # Using NuGet packages
  ├── Chapter-06   # New C# 13 features in scripts
  ├── Chapter-07   # Best practices
  ├── Chapter-08   # Limitations & workarounds
  ├── Chapter-10   # Advanced examples with config & DI
  ├── Chapter-11   # Production-ready script template
  ├── Chapter-13   # Records & JSON serialization
  └── Chapter-15   # Final advanced script demos
```

---

## Prerequisites

- [.NET 9 SDK](https://dotnet.microsoft.com/download) (or newer)
- Optional: [`dotnet-script`](https://github.com/dotnet-script/dotnet-script) for NuGet inline references and `.csx` files
- Recommended editors:
  - [Visual Studio 2022 Preview](https://visualstudio.microsoft.com/)
  - [Visual Studio Code](https://code.visualstudio.com/) with [C# Dev Kit](https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.csdevkit)
  - JetBrains Rider

---

## Running the Examples

Run a script directly:

```bash
dotnet run app.cs
```

Run multiple files together:

```bash
dotnet run app.cs utils.cs
```

Run with arguments:

```bash
dotnet script runtimeArgs.cs -- MySecretApiKey
```

Use NuGet packages with `dotnet-script`:

```csharp
#r "nuget: Newtonsoft.Json, 13.0.3"
```

```bash
dotnet script app.csx
```

---

## Quick Cheat Sheet

| Action                     | Command Example                             |
| -------------------------- | ------------------------------------------- |
| Run a single script        | `dotnet run app.cs`                         |
| Run script with arguments  | `dotnet script runtimeArgs.cs -- arg1 arg2` |
| Run multiple files         | `dotnet run app.cs utils.cs`                |
| Install dotnet-script      | `dotnet tool install -g dotnet-script`      |
| Use NuGet in `.csx` script | `#r "nuget: Newtonsoft.Json, 13.0.3"`       |
| Check .NET SDK version     | `dotnet --version`                          |

---

## Reference

This repository is the companion to the book:  
**Running C# 13 Scripts With `dotnet run app.cs` (No Project Files Needed)**  
by **Ziggy Rafiq**

**For details, visit: [ziggyrafiq.com](https://ziggyrafiq.com)**

## License

This code is released under the MIT License. See the LICENSE file for more information.

## Stay Connected

For updates and more articles, follow me:

- LinkedIn: [Ziggy Rafiq LinkedIn](https://www.linkedin.com/in/ziggyrafiq/)
- GitHub: [Ziggy Rafiq GitHub](https://github.com/ziggyrafiq)
- Website [Ziggy Rafiq Website](https://ziggyrafiq.com)

## About The Author Ziggy Rafiq

Ziggy Rafiq works as a Technical Lead Developer and is a prominent public figure in the tech industry and developer community. With over 20 years of experience as a Full-Stack Designer, Developer, Tester, DevSecOps, Technical Architect,
Software Project Manager, and expert in Agile Management Best Practices and Standards, Ziggy is widely respected for his knowledge and skills. He is also an author, regularly contributing articles
to [C# Corner](https://www.c-sharpcorner.com/members/ziggy-rafiq), and [Geek Coding](https://geekcodinghub.com/members/ziggy-rafiq) to
share his expertise and wisdom with a global audience. Ziggy also has a YouTube Channel where he creates content based on his experience to help and inspire other developers, designers, testers, project managers,
technical architects, and Agile Scrum masters.

- **Technical Lead Developer, Mentor and Trainer**
- **[C# Corner (MVP 🏅, VIP⭐️, Public Speaker🎤)](https://www.c-sharpcorner.com/members/ziggy-rafiq)**
- **[Geek Coding Writter](https://geekcodinghub.com/members/ziggy-rafiq)**
- **[Technology Manager Writter](https://technology-manager.com/members/ziggy-rafiq)**
- Link to [**Ziggy Rafiq Blog**](https://blog.ziggyrafiq.com)
- Link to [**Ziggy Rafiq Website**](https://ziggyrafiq.com)

* [**Please remember to subscribe to My YouTube channel**](https://www.youtube.com/)
* [**Please remember to follow me on LinkedIn**](https://www.linkedin.com/in/ziggyrafiq/)
* [**Please remember to follow me on Twitter/X**](https://twitter.com/ziggyrafiq)
* [**Please remember to follow me on Instagram**](https://www.instagram.com/ziggyrafiq/)
* [**Please remember to follow me on Facebook**](https://www.facebook.com/ziggyrafiq)
