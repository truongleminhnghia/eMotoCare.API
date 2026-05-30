# eMotoCare - Project Guide

Tài liệu này mô tả nhanh cấu trúc dự án, rule khi phát triển và các lệnh thường dùng cho solution `eMotoCare`.

## Tổng quan

`eMotoCare` là backend ASP.NET Core chạy trên `.NET 10`, tổ chức theo hướng Clean Architecture:

- `eMotoCare.API`: tầng HTTP/API, cấu hình middleware, authentication, Swagger và controller.
- `eMotoCare.Application`: tầng use case, MediatR handler, validator và business flow.
- `eMotoCare.Core`: tầng domain, chứa entity, enum và base model.
- `eMotoCare.Infrastructure`: tầng hạ tầng, EF Core DbContext, migration, cấu hình persistence.
- `eMotoCare.Share`: cấu hình dùng chung, settings model và helper chung giữa các project.

Rule chính: dependency luôn đi từ tầng ngoài vào tầng trong, không đi ngược lại.

```text
API
 ├─> Application ──> Core
 ├─> Infrastructure ──> Application/Core/Share
 └─> Share

Core không reference project nào khác.
```

## Cấu trúc thư mục

```text
eMotoCare/
├─ eMotoCare.API/
│  ├─ Configurations/          # Extension methods cho service, middleware, auth, Swagger
│  ├─ Controllers/             # API controllers
│  ├─ Properties/              # launchSettings
│  ├─ Program.cs               # Entry point
│  ├─ appsettings.json
│  └─ appsettings.Development.json
├─ eMotoCare.Application/
│  └─ DependencyInjection.cs   # Đăng ký MediatR và FluentValidation
├─ eMotoCare.Core/
│  ├─ Commons/Bases/           # Base entity/model
│  ├─ Entites/                 # Domain entities
│  └─ Enums/                   # Domain enums
├─ eMotoCare.Infrastructure/
│  ├─ Persistence/
│  │  ├─ Configurations/       # EF Core entity configurations
│  │  ├─ Migrations/           # EF Core migrations
│  │  ├─ EMotoCareDbContext.cs
│  │  └─ EMotoCareDbContextFactory.cs
│  └─ DependencyInjection.cs   # Đăng ký DbContext và hạ tầng
├─ eMotoCare.Share/
│  └─ Configurations/          # Settings và environment helpers
├─ dotnet-tools.json           # Local tools, hiện có dotnet-ef
├─ eMotoCare.slnx
└─ .env                        # Cấu hình local, không commit secret thật
```

## Rule phát triển

### Dependency

- `Core` chỉ chứa domain thuần: entity, enum, base class, domain rule nếu có.
- `Application` được reference `Core`, không phụ thuộc `API` hoặc implementation hạ tầng cụ thể.
- `Infrastructure` chứa implementation liên quan database, provider, file system, external services.
- `API` chỉ làm nhiệm vụ nhận request, trả response và cấu hình host.
- Không đặt business logic trực tiếp trong controller.
- Không để entity/domain phụ thuộc EF Core, ASP.NET Core hoặc package hạ tầng nếu không thật sự cần.

### Naming và namespace

- Namespace theo tên project và thư mục, ví dụ: `eMotoCare.Infrastructure.Persistence`.
- Class, method, property dùng `PascalCase`.
- Field/private variable dùng `camelCase`.
- Async method kết thúc bằng `Async`.
- Enum đặt tên rõ nghĩa theo domain; tránh viết tắt khó hiểu.
- Lưu ý hiện tại thư mục domain đang là `Entites`; nếu đổi thành `Entities` cần đổi đồng bộ namespace/reference.

### API

- Controller đặt trong `eMotoCare.API/Controllers`.
- Cấu hình service/middleware đặt trong `eMotoCare.API/Configurations`.
- Controller nên mỏng: validate input cơ bản, gọi use case qua Application, map response.
- Swagger chỉ bật trong môi trường `Development`.
- Authentication đang dùng JWT Bearer, cấu hình từ section `Jwt`.

### Application

- Use case mới nên đặt trong `eMotoCare.Application` theo feature/module khi bắt đầu mở rộng.
- Dùng MediatR cho command/query handler.
- Dùng FluentValidation cho request/command validation.
- Không truy cập trực tiếp `HttpContext`, controller, hoặc EF Core DbContext trong tầng này nếu có thể tránh.

### Core

- Entity đặt trong `eMotoCare.Core/Entites`.
- Enum đặt trong `eMotoCare.Core/Enums`.
- Base entity/model dùng chung đặt trong `eMotoCare.Core/Commons/Bases`.
- Domain model nên giữ độc lập với database schema chi tiết.

### Infrastructure và database

- `EMotoCareDbContext` là DbContext chính.
- Entity configuration đặt trong `eMotoCare.Infrastructure/Persistence/Configurations`.
- Migration đặt trong `eMotoCare.Infrastructure/Persistence/Migrations`.
- Database object đang được convert sang `snake_case` trong `EMotoCareDbContext`.
- Khi thêm entity mới:
  - Thêm entity vào `Core`.
  - Thêm `DbSet` vào `EMotoCareDbContext`.
  - Thêm configuration nếu cần key, relation, constraint, index.
  - Tạo migration mới.

### Configuration và secret

- Giá trị mặc định nằm trong `eMotoCare.API/appsettings.json`.
- Cấu hình local có thể đặt trong `.env`.
- `EnvironmentConfiguration` chỉ tự load `.env` cho `Development` hoặc khi environment rỗng.
- Không commit secret thật như connection string production, JWT signing key, username/password thật.
- Các key cấu hình chính:
  - `ConnectionStrings__DefaultConnection`
  - `Jwt__Issuer`
  - `Jwt__Audience`
  - `Jwt__SigningKey`
  - `SwaggerBasicAuth__Username`
  - `SwaggerBasicAuth__Password`

## Lệnh thường dùng

Restore package:

```powershell
dotnet restore
```

Build solution:

```powershell
dotnet build eMotoCare.slnx
```

Chạy API:

```powershell
dotnet run --project eMotoCare.API
```

Cài hoặc restore local tools:

```powershell
dotnet tool restore
```

Tạo migration mới:

```powershell
dotnet ef migrations add <MigrationName> --project eMotoCare.Infrastructure --startup-project eMotoCare.API --context EMotoCareDbContext
```

Update database:

```powershell
dotnet ef database update --project eMotoCare.Infrastructure --startup-project eMotoCare.API --context EMotoCareDbContext
```

## Checklist trước khi commit

- Code build thành công với `dotnet build eMotoCare.slnx`.
- Không commit secret thật trong `.env` hoặc `appsettings*.json`.
- Migration được tạo khi thay đổi schema database.
- Controller không chứa business logic phức tạp.
- Service/handler mới được đăng ký đúng qua DI hoặc assembly scanning.
- Tên bảng/cột mới vẫn đúng quy ước `snake_case` sau khi tạo migration.

## Ghi chú hiện trạng

- Project đang dùng `.NET 10` và package EF Core/ASP.NET Core version `10.0.8`.
- Local tool `dotnet-ef` đang được khai báo trong `dotnet-tools.json`.
- Swagger/OpenAPI được cấu hình trong `eMotoCare.API/Configurations`.
- JWT và Swagger Basic Auth được bind qua settings trong `eMotoCare.Share/Configurations`.
