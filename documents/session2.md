# データの出し入れをしてみよう

+ Model登録

  Models/Chat.cs

  ```csharp
  namespace Study.Models{
      public class Chat{
        public long ID { get; set; }
        public string Message { get; set; }
      }
  }
  ```

+ DBの追加

  Study/Models/StudyContext.csを追加

  ```csharp
  using Microsoft.EntityFrameworkCore;

  namespace Study.Models
  {
      public class StudyContext : DbContext
      {
          public StudyContext (DbContextOptions<StudyContext> options)
              : base(options)
          {
          }

          public DbSet<Chat> Chats { get; set; }
      }
  }
  ```

  ```bash
  dotnet add package Microsoft.EntityFrameworkCore.SQLite
  dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design
  ```

  appsettings.jsonを編集

  ```json
  {
    "Logging": {
      "LogLevel": {
        "Default": "Warning"
      }
    },
    "AllowedHosts": "*",
    "ConnectionStrings": {
      "StudyContext": "Data Source=Study.db"
    }
  }
  ```

  Startup.csに追加

  ```csharp
  using Study.Models;
  using Microsoft.EntityFrameworkCore;

  // 中略
  public void ConfigureServices(IServiceCollection services)
  {
      services.Configure<CookiePolicyOptions>(options =>
      {
          // This lambda determines whether user consent for non-essential cookies is needed for a given request.
          options.CheckConsentNeeded = context => true;
          options.MinimumSameSitePolicy = SameSiteMode.None;
      });

      services.AddDbContext<StudyContext>(options =>
          options.UseSqlite(Configuration.GetConnectionString("StudyContext")));

      services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
  }
  ```

+ Scaffold

  ```bash
  dotnet tool install --global dotnet-aspnet-codegenerator
  $env:Path = [System.Environment]::GetEnvironmentVariable("Path","Machine") + ";" + [System.Environment]::GetEnvironmentVariable("Path","User")
  dotnet aspnet-codegenerator controller -name ChatsController -m Chat -dc StudyContext --relativeFolderPath Controllers --useDefaultLayout --referenceScriptLibraries
  ```

+ DatabaseMigration

  ```bash
  dotnet ef migrations add InitialCreate
  dotnet ef database update
  ```

+ メッセージ送信ボタンの追加
  + Createページからボタンを移植する
+ 名前入力欄の追加
  
  + ChatModelにnameプロパティを追加する
  + DBmigrationする

  ```bash
  dotnet ef migrations add InitialCreate
  dotnet ef database update
  ```

  + Viewに入力欄を設置する
