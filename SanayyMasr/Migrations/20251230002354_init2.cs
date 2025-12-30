using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SanayyMasr.Migrations
{
    /// <inheritdoc />
    public partial class init2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Governorates",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArabicName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Governorates", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Professions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArabicName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Professions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Skills",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArabicName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skills", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SubscriptionPlans",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArabicName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DurationDays = table.Column<int>(type: "int", nullable: false),
                    Features = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubscriptionPlans", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Citys",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GovernorateId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArabicName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Latitude = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Longitude = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Citys", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Citys_Governorates_GovernorateId",
                        column: x => x.GovernorateId,
                        principalTable: "Governorates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProfileImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    GovernorateId = table.Column<int>(type: "int", nullable: true),
                    CityId = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Citys_CityId",
                        column: x => x.CityId,
                        principalTable: "Citys",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Users_Governorates_GovernorateId",
                        column: x => x.GovernorateId,
                        principalTable: "Governorates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Craftsmens",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ProfessionId = table.Column<int>(type: "int", nullable: false),
                    Bio = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExperienceYears = table.Column<int>(type: "int", nullable: false),
                    MinPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MaxPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IsVerified = table.Column<bool>(type: "bit", nullable: false),
                    VerificationDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Craftsmens", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Craftsmens_Professions_ProfessionId",
                        column: x => x.ProfessionId,
                        principalTable: "Professions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Craftsmens_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RefreshTokens",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Token = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExpiresAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsRevoked = table.Column<bool>(type: "bit", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RefreshTokens", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RefreshTokens_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CraftsmansCity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CraftsmanId = table.Column<int>(type: "int", nullable: false),
                    CityId = table.Column<int>(type: "int", nullable: false),
                    IsPrimary = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CraftsmansCity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CraftsmansCity_Citys_CityId",
                        column: x => x.CityId,
                        principalTable: "Citys",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CraftsmansCity_Craftsmens_CraftsmanId",
                        column: x => x.CraftsmanId,
                        principalTable: "Craftsmens",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CraftsmansSkills",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CraftsmanId = table.Column<int>(type: "int", nullable: false),
                    SkillId = table.Column<int>(type: "int", nullable: false),
                    ProficiencyLevel = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CraftsmansSkills", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CraftsmansSkills_Craftsmens_CraftsmanId",
                        column: x => x.CraftsmanId,
                        principalTable: "Craftsmens",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CraftsmansSkills_Skills_SkillId",
                        column: x => x.SkillId,
                        principalTable: "Skills",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CraftsmansSubscriptions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CraftsmanId = table.Column<int>(type: "int", nullable: false),
                    PlanId = table.Column<int>(type: "int", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CraftsmansSubscriptions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CraftsmansSubscriptions_Craftsmens_CraftsmanId",
                        column: x => x.CraftsmanId,
                        principalTable: "Craftsmens",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CraftsmansSubscriptions_SubscriptionPlans_PlanId",
                        column: x => x.PlanId,
                        principalTable: "SubscriptionPlans",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Gallerys",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CraftsmanId = table.Column<int>(type: "int", nullable: false),
                    MediaUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MediaType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gallerys", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Gallerys_Craftsmens_CraftsmanId",
                        column: x => x.CraftsmanId,
                        principalTable: "Craftsmens",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Reports",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReporterUserId = table.Column<int>(type: "int", nullable: false),
                    CraftsmanId = table.Column<int>(type: "int", nullable: false),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsResolved = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reports", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reports_Craftsmens_CraftsmanId",
                        column: x => x.CraftsmanId,
                        principalTable: "Craftsmens",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Reports_Users_ReporterUserId",
                        column: x => x.ReporterUserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    CraftsmanId = table.Column<int>(type: "int", nullable: false),
                    Stars = table.Column<int>(type: "int", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsVerified = table.Column<bool>(type: "bit", nullable: false),
                    IsApproved = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reviews_Craftsmens_CraftsmanId",
                        column: x => x.CraftsmanId,
                        principalTable: "Craftsmens",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Reviews_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubscriptionId = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Currency = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PaymentMethod = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProviderReference = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Payments_CraftsmansSubscriptions_SubscriptionId",
                        column: x => x.SubscriptionId,
                        principalTable: "CraftsmansSubscriptions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Governorates",
                columns: new[] { "Id", "ArabicName", "CreatedAt", "CreatedBy", "IsDeleted", "Name", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "القاهرة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Cairo", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 2, "الجيزة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Giza", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 3, "القليوبية", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Qalyubia", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 4, "السويس", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Suez", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 5, "بورسعيد", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Port Said", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 6, "الإسماعيلية", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Ismailia", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 7, "الدقهلية", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Dakahlia", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 8, "الشرقية", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Sharqia", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 9, "الغربية", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Gharbia", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 10, "المنوفية", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Monufia", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 11, "البحيرة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Beheira", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 12, "كفر الشيخ", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Kafr El Sheikh", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 13, "دمياط", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Damietta", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 14, "الفيوم", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Fayoum", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 15, "بني سويف", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Beni Suef", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 16, "المنيا", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Minya", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 17, "أسيوط", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Asyut", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 18, "سوهاج", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Sohag", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 19, "قنا", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Qena", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 20, "الأقصر", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Luxor", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 21, "أسوان", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Aswan", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 22, "البحر الأحمر", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Red Sea", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 23, "الوادي الجديد", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "New Valley", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 24, "مطروح", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Matrouh", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 25, "شمال سيناء", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "North Sinai", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 26, "جنوب سيناء", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "South Sinai", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null }
                });

            migrationBuilder.InsertData(
                table: "Professions",
                columns: new[] { "Id", "ArabicName", "CreatedAt", "CreatedBy", "Description", "IsDeleted", "Name", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "سباك", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Plumbing and installations", false, "Plumber", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 2, "كهربائي", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Electrical maintenance and wiring", false, "Electrician", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 3, "نجار", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Wood works and furniture", false, "Carpenter", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 4, "فني تكييف", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "AC maintenance and installation", false, "AC Technician", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 5, "نقاش", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Painting and finishing works", false, "Painter", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 6, "فني ألوميتال", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Aluminum kitchens and windows", false, "Aluminum Installer", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 7, "فني غاز", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Gas systems maintenance and installation", false, "Gas Technician", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 8, "إصلاح أجهزة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Repair of home appliances", false, "Appliance Repair", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null }
                });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "ArabicName", "CreatedAt", "CreatedBy", "IsDeleted", "Name", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "تمديدات كهرباء", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Wiring", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 2, "تشخيص الدوائر الكهربائية", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Circuit Diagnosis", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 3, "تركيب لوحات كهرباء", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Panel Installation", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 4, "تركيب إضاءة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Lighting", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 5, "تركيب مخارج كهرباء", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Power Outlets", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 6, "إصلاح مواسير", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Pipe Fixing", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 7, "تسليك صرف", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Drain Unclog", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 8, "إصلاح حنفيات", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Faucet Repair", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 9, "لحام", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Soldering", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 10, "تقطيع خشب", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Wood Cutting", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 11, "تصنيع خزائن", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Cabinet Making", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 12, "إصلاح أبواب", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Door Repair", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 13, "دهانات داخلية", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Interior Painting", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 14, "دهانات خارجية", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Exterior Painting", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 15, "إصلاح تكييف", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "AC Repair", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 16, "شحن فريون تكييف", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "AC Gas Recharge", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 17, "تركيب بلاط", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Tile Laying", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 18, "ملء فواصل البلاط", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Grouting", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 19, "مهارة عامة 19", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "General Skill 19", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 20, "مهارة عامة 20", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "General Skill 20", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 21, "تركيب أقفال", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Lock Installation", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 22, "إصلاح أقفال", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Lock Repair", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 23, "مهارة عامة 23", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "General Skill 23", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 24, "مهارة عامة 24", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "General Skill 24", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 25, "مهارة عامة 25", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "General Skill 25", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 26, "مهارة عامة 26", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "General Skill 26", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 27, "مهارة عامة 27", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "General Skill 27", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 28, "مهارة عامة 28", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "General Skill 28", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 29, "مهارة عامة 29", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "General Skill 29", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 30, "مهارة عامة 30", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "General Skill 30", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 31, "مهارة عامة 31", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "General Skill 31", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 32, "مهارة عامة 32", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "General Skill 32", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 33, "مهارة عامة 33", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "General Skill 33", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 34, "مهارة عامة 34", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "General Skill 34", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 35, "مهارة عامة 35", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "General Skill 35", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 36, "مهارة عامة 36", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "General Skill 36", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 37, "مهارة عامة 37", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "General Skill 37", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 38, "مهارة عامة 38", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "General Skill 38", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 39, "مهارة عامة 39", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "General Skill 39", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 40, "مهارة عامة 40", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "General Skill 40", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 41, "إصلاح ثلاجات", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Fridge Repair", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 42, "إصلاح غسالات", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Washing Machine Repair", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 43, "إصلاح أفران", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Oven Repair", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 44, "إصلاح ميكروويف", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Microwave Repair", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 45, "مهارة عامة 45", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "General Skill 45", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 46, "مهارة عامة 46", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "General Skill 46", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 47, "مهارة عامة 47", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "General Skill 47", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 48, "تركيب أنظمة منزل ذكي", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Smart Home Install", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 49, "مهارة عامة 49", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "General Skill 49", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 50, "مهارة عامة 50", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "General Skill 50", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 51, "مهارة عامة 51", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "General Skill 51", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 52, "تركيب ألواح شمسية", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Solar Panel Install", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 53, "مهارة عامة 53", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "General Skill 53", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 54, "مهارة عامة 54", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "General Skill 54", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 55, "تركيب كاميرات مراقبة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Security Camera Install", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 56, "مهارة عامة 56", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "General Skill 56", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 57, "مهارة عامة 57", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "General Skill 57", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 58, "مهارة عامة 58", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "General Skill 58", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 59, "تجديد حمامات", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Bathroom Renovation", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 60, "تجديد مطابخ", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "Kitchen Renovation", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null }
                });

            migrationBuilder.InsertData(
                table: "SubscriptionPlans",
                columns: new[] { "Id", "ArabicName", "CreatedAt", "CreatedBy", "DurationDays", "Features", "IsActive", "IsDeleted", "Name", "Price", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "مجاني", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, "Free listing (limited)", true, false, "Free", 0m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 2, "أساسي", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 30, "Standard listing + contact", true, false, "Basic", 50m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 3, "مميز", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 30, "Featured listing + top search", true, false, "Premium", 200m, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CityId", "CreatedAt", "CreatedBy", "Email", "FullName", "GovernorateId", "IsActive", "IsDeleted", "PasswordHash", "Phone", "ProfileImage", "Role", "UpdatedAt", "UpdatedBy" },
                values: new object[] { 1, null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "admin@gmail.com", "Admin", null, true, false, "O2Esdae1BIpDX7bsgeUv+S1teVqLWpwXBw9qY8l6U7I=", "01000000000", "default-user.png", "Admin", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.InsertData(
                table: "Citys",
                columns: new[] { "Id", "ArabicName", "CreatedAt", "CreatedBy", "GovernorateId", "IsDeleted", "Latitude", "Longitude", "Name", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "مدينة نصر", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, false, 30.0561m, 31.3300m, "Nasr City", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 2, "مصر الجديدة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, false, 30.0917m, 31.3180m, "Heliopolis", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 3, "المعادي", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, false, 29.9602m, 31.2569m, "Maadi", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 4, "الزمالك", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, false, 30.0666m, 31.2197m, "Zamalek", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 5, "الدقي", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, false, 30.0386m, 31.2120m, "Dokki", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 6, "6 أكتوبر", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, false, 29.9773m, 30.9455m, "6th of October", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 7, "الشيخ زايد", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, false, 30.0215m, 30.9886m, "Sheikh Zayed", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 8, "سيدي جابر", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3, false, 31.2156m, 29.9553m, "Sidi Gaber", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 9, "سموحة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3, false, 31.2100m, 29.9400m, "Smouha", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 10, "ستانلي", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3, false, 31.2358m, 29.9662m, "Stanley", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 11, "المنصورة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 7, false, 31.0409m, 31.3785m, "Mansoura", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 12, "طلخا", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 7, false, 31.0524m, 31.3812m, "Talkha", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 13, "الزقازيق", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 8, false, 30.5877m, 31.5020m, "Zagazig", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 14, "بلبيس", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 8, false, 30.4181m, 31.5622m, "Belbeis", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 15, "الغردقة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 20, false, 27.2579m, 33.8116m, "Hurghada", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 16, "سفاجا", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 20, false, 26.7500m, 33.9333m, "Safaga", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 17, "مرسى علم", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 20, false, 25.0699m, 34.8900m, "Marsa Alam", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 18, "الأقصر", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 18, false, 25.6872m, 32.6396m, "Luxor City", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 19, "أسوان", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 19, false, 24.0889m, 32.8998m, "Aswan City", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 20, "الضبعة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 22, false, 31.0460m, 28.4400m, "El Dabaa", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 21, "شرم الشيخ", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 24, false, 27.9158m, 34.3299m, "Sharm El-Sheikh", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 22, "طابا", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 24, false, 29.4920m, 34.8947m, "Taba", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CityId", "CreatedAt", "CreatedBy", "Email", "FullName", "GovernorateId", "IsActive", "IsDeleted", "PasswordHash", "Phone", "ProfileImage", "Role", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { 2, 3, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "craftsman2@example.com", "أحمد محمد علي", 1, true, false, "10000.hFJ4X3Yw9kF2QzJc6R6yVg==.pQ8x3x0+1uYw0xXrC6b3n0k8vZ5q3P9Z+7Yxw4Q1F3Y=", "01000000002", "default-user.png", "Craftsman", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 3, 4, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "craftsman3@example.com", "محمد محمد علي", 1, true, false, "10000.hFJ4X3Yw9kF2QzJc6R6yVg==.pQ8x3x0+1uYw0xXrC6b3n0k8vZ5q3P9Z+7Yxw4Q1F3Y=", "01000000003", "default-user.png", "Craftsman", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 4, 5, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "craftsman4@example.com", "محمود محمد علي", 1, true, false, "10000.hFJ4X3Yw9kF2QzJc6R6yVg==.pQ8x3x0+1uYw0xXrC6b3n0k8vZ5q3P9Z+7Yxw4Q1F3Y=", "01000000004", "default-user.png", "Craftsman", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 5, 1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "craftsman5@example.com", "عبدالله محمد علي", 1, true, false, "10000.hFJ4X3Yw9kF2QzJc6R6yVg==.pQ8x3x0+1uYw0xXrC6b3n0k8vZ5q3P9Z+7Yxw4Q1F3Y=", "01000000005", "default-user.png", "Craftsman", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 6, 2, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "craftsman6@example.com", "عمر محمد علي", 1, true, false, "10000.hFJ4X3Yw9kF2QzJc6R6yVg==.pQ8x3x0+1uYw0xXrC6b3n0k8vZ5q3P9Z+7Yxw4Q1F3Y=", "01000000006", "default-user.png", "Craftsman", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 7, 3, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "craftsman7@example.com", "كريم محمد علي", 1, true, false, "10000.hFJ4X3Yw9kF2QzJc6R6yVg==.pQ8x3x0+1uYw0xXrC6b3n0k8vZ5q3P9Z+7Yxw4Q1F3Y=", "01000000007", "default-user.png", "Craftsman", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 8, 4, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "craftsman8@example.com", "سارة محمد علي", 1, true, false, "10000.hFJ4X3Yw9kF2QzJc6R6yVg==.pQ8x3x0+1uYw0xXrC6b3n0k8vZ5q3P9Z+7Yxw4Q1F3Y=", "01000000008", "default-user.png", "Craftsman", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 9, 5, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "craftsman9@example.com", "نور محمد علي", 1, true, false, "10000.hFJ4X3Yw9kF2QzJc6R6yVg==.pQ8x3x0+1uYw0xXrC6b3n0k8vZ5q3P9Z+7Yxw4Q1F3Y=", "01000000009", "default-user.png", "Craftsman", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 10, 1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "craftsman10@example.com", "هند محمد علي", 1, true, false, "10000.hFJ4X3Yw9kF2QzJc6R6yVg==.pQ8x3x0+1uYw0xXrC6b3n0k8vZ5q3P9Z+7Yxw4Q1F3Y=", "01000000010", "default-user.png", "Craftsman", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 11, 2, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "craftsman11@example.com", "ليلى محمد علي", 1, true, false, "10000.hFJ4X3Yw9kF2QzJc6R6yVg==.pQ8x3x0+1uYw0xXrC6b3n0k8vZ5q3P9Z+7Yxw4Q1F3Y=", "01000000011", "default-user.png", "Craftsman", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 12, 3, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "craftsman12@example.com", "منى محمد علي", 1, true, false, "10000.hFJ4X3Yw9kF2QzJc6R6yVg==.pQ8x3x0+1uYw0xXrC6b3n0k8vZ5q3P9Z+7Yxw4Q1F3Y=", "01000000012", "default-user.png", "Craftsman", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 13, 4, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "craftsman13@example.com", "إيهاب محمد علي", 1, true, false, "10000.hFJ4X3Yw9kF2QzJc6R6yVg==.pQ8x3x0+1uYw0xXrC6b3n0k8vZ5q3P9Z+7Yxw4Q1F3Y=", "01000000013", "default-user.png", "Craftsman", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 14, 5, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "craftsman14@example.com", "مروة محمد علي", 1, true, false, "10000.hFJ4X3Yw9kF2QzJc6R6yVg==.pQ8x3x0+1uYw0xXrC6b3n0k8vZ5q3P9Z+7Yxw4Q1F3Y=", "01000000014", "default-user.png", "Craftsman", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 15, 1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "craftsman15@example.com", "طارق محمد علي", 1, true, false, "10000.hFJ4X3Yw9kF2QzJc6R6yVg==.pQ8x3x0+1uYw0xXrC6b3n0k8vZ5q3P9Z+7Yxw4Q1F3Y=", "01000000015", "default-user.png", "Craftsman", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 16, 2, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "craftsman16@example.com", "علي محمد علي", 1, true, false, "10000.hFJ4X3Yw9kF2QzJc6R6yVg==.pQ8x3x0+1uYw0xXrC6b3n0k8vZ5q3P9Z+7Yxw4Q1F3Y=", "01000000016", "default-user.png", "Craftsman", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 17, 3, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "craftsman17@example.com", "يوسف محمد علي", 1, true, false, "10000.hFJ4X3Yw9kF2QzJc6R6yVg==.pQ8x3x0+1uYw0xXrC6b3n0k8vZ5q3P9Z+7Yxw4Q1F3Y=", "01000000017", "default-user.png", "Craftsman", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 18, 4, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "craftsman18@example.com", "عائشة محمد علي", 1, true, false, "10000.hFJ4X3Yw9kF2QzJc6R6yVg==.pQ8x3x0+1uYw0xXrC6b3n0k8vZ5q3P9Z+7Yxw4Q1F3Y=", "01000000018", "default-user.png", "Craftsman", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 19, 5, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "craftsman19@example.com", "مريم محمد علي", 1, true, false, "10000.hFJ4X3Yw9kF2QzJc6R6yVg==.pQ8x3x0+1uYw0xXrC6b3n0k8vZ5q3P9Z+7Yxw4Q1F3Y=", "01000000019", "default-user.png", "Craftsman", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 20, 1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "craftsman20@example.com", "خالد محمد علي", 1, true, false, "10000.hFJ4X3Yw9kF2QzJc6R6yVg==.pQ8x3x0+1uYw0xXrC6b3n0k8vZ5q3P9Z+7Yxw4Q1F3Y=", "01000000020", "default-user.png", "Craftsman", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 21, 2, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "craftsman21@example.com", "إبراهيم محمد علي", 1, true, false, "10000.hFJ4X3Yw9kF2QzJc6R6yVg==.pQ8x3x0+1uYw0xXrC6b3n0k8vZ5q3P9Z+7Yxw4Q1F3Y=", "01000000021", "default-user.png", "Craftsman", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 22, 3, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "craftsman22@example.com", "أحمد حسن علي", 1, true, false, "10000.hFJ4X3Yw9kF2QzJc6R6yVg==.pQ8x3x0+1uYw0xXrC6b3n0k8vZ5q3P9Z+7Yxw4Q1F3Y=", "01000000022", "default-user.png", "Craftsman", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 23, 4, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "craftsman23@example.com", "محمد حسن علي", 1, true, false, "10000.hFJ4X3Yw9kF2QzJc6R6yVg==.pQ8x3x0+1uYw0xXrC6b3n0k8vZ5q3P9Z+7Yxw4Q1F3Y=", "01000000023", "default-user.png", "Craftsman", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 24, 5, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "craftsman24@example.com", "محمود حسن علي", 1, true, false, "10000.hFJ4X3Yw9kF2QzJc6R6yVg==.pQ8x3x0+1uYw0xXrC6b3n0k8vZ5q3P9Z+7Yxw4Q1F3Y=", "01000000024", "default-user.png", "Craftsman", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 25, 1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "craftsman25@example.com", "عبدالله حسن علي", 1, true, false, "10000.hFJ4X3Yw9kF2QzJc6R6yVg==.pQ8x3x0+1uYw0xXrC6b3n0k8vZ5q3P9Z+7Yxw4Q1F3Y=", "01000000025", "default-user.png", "Craftsman", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 26, 2, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "craftsman26@example.com", "عمر حسن علي", 1, true, false, "10000.hFJ4X3Yw9kF2QzJc6R6yVg==.pQ8x3x0+1uYw0xXrC6b3n0k8vZ5q3P9Z+7Yxw4Q1F3Y=", "01000000026", "default-user.png", "Craftsman", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 27, 3, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "craftsman27@example.com", "كريم حسن علي", 1, true, false, "10000.hFJ4X3Yw9kF2QzJc6R6yVg==.pQ8x3x0+1uYw0xXrC6b3n0k8vZ5q3P9Z+7Yxw4Q1F3Y=", "01000000027", "default-user.png", "Craftsman", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 28, 4, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "craftsman28@example.com", "سارة حسن علي", 1, true, false, "10000.hFJ4X3Yw9kF2QzJc6R6yVg==.pQ8x3x0+1uYw0xXrC6b3n0k8vZ5q3P9Z+7Yxw4Q1F3Y=", "01000000028", "default-user.png", "Craftsman", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 29, 5, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "craftsman29@example.com", "نور حسن علي", 1, true, false, "10000.hFJ4X3Yw9kF2QzJc6R6yVg==.pQ8x3x0+1uYw0xXrC6b3n0k8vZ5q3P9Z+7Yxw4Q1F3Y=", "01000000029", "default-user.png", "Craftsman", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 30, 1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "craftsman30@example.com", "هند حسن علي", 1, true, false, "10000.hFJ4X3Yw9kF2QzJc6R6yVg==.pQ8x3x0+1uYw0xXrC6b3n0k8vZ5q3P9Z+7Yxw4Q1F3Y=", "01000000030", "default-user.png", "Craftsman", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 31, 2, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "craftsman31@example.com", "ليلى حسن علي", 1, true, false, "10000.hFJ4X3Yw9kF2QzJc6R6yVg==.pQ8x3x0+1uYw0xXrC6b3n0k8vZ5q3P9Z+7Yxw4Q1F3Y=", "01000000031", "default-user.png", "Craftsman", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 32, 3, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "craftsman32@example.com", "منى حسن علي", 1, true, false, "10000.hFJ4X3Yw9kF2QzJc6R6yVg==.pQ8x3x0+1uYw0xXrC6b3n0k8vZ5q3P9Z+7Yxw4Q1F3Y=", "01000000032", "default-user.png", "Craftsman", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 33, 4, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "craftsman33@example.com", "إيهاب حسن علي", 1, true, false, "10000.hFJ4X3Yw9kF2QzJc6R6yVg==.pQ8x3x0+1uYw0xXrC6b3n0k8vZ5q3P9Z+7Yxw4Q1F3Y=", "01000000033", "default-user.png", "Craftsman", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 34, 5, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "craftsman34@example.com", "مروة حسن علي", 1, true, false, "10000.hFJ4X3Yw9kF2QzJc6R6yVg==.pQ8x3x0+1uYw0xXrC6b3n0k8vZ5q3P9Z+7Yxw4Q1F3Y=", "01000000034", "default-user.png", "Craftsman", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 35, 1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "craftsman35@example.com", "طارق حسن علي", 1, true, false, "10000.hFJ4X3Yw9kF2QzJc6R6yVg==.pQ8x3x0+1uYw0xXrC6b3n0k8vZ5q3P9Z+7Yxw4Q1F3Y=", "01000000035", "default-user.png", "Craftsman", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 36, 2, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "craftsman36@example.com", "علي حسن علي", 1, true, false, "10000.hFJ4X3Yw9kF2QzJc6R6yVg==.pQ8x3x0+1uYw0xXrC6b3n0k8vZ5q3P9Z+7Yxw4Q1F3Y=", "01000000036", "default-user.png", "Craftsman", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 37, 3, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "craftsman37@example.com", "يوسف حسن علي", 1, true, false, "10000.hFJ4X3Yw9kF2QzJc6R6yVg==.pQ8x3x0+1uYw0xXrC6b3n0k8vZ5q3P9Z+7Yxw4Q1F3Y=", "01000000037", "default-user.png", "Craftsman", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 38, 4, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "craftsman38@example.com", "عائشة حسن علي", 1, true, false, "10000.hFJ4X3Yw9kF2QzJc6R6yVg==.pQ8x3x0+1uYw0xXrC6b3n0k8vZ5q3P9Z+7Yxw4Q1F3Y=", "01000000038", "default-user.png", "Craftsman", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 39, 5, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "craftsman39@example.com", "مريم حسن علي", 1, true, false, "10000.hFJ4X3Yw9kF2QzJc6R6yVg==.pQ8x3x0+1uYw0xXrC6b3n0k8vZ5q3P9Z+7Yxw4Q1F3Y=", "01000000039", "default-user.png", "Craftsman", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 40, 1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "craftsman40@example.com", "خالد حسن علي", 1, true, false, "10000.hFJ4X3Yw9kF2QzJc6R6yVg==.pQ8x3x0+1uYw0xXrC6b3n0k8vZ5q3P9Z+7Yxw4Q1F3Y=", "01000000040", "default-user.png", "Craftsman", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 41, 2, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "craftsman41@example.com", "إبراهيم حسن علي", 1, true, false, "10000.hFJ4X3Yw9kF2QzJc6R6yVg==.pQ8x3x0+1uYw0xXrC6b3n0k8vZ5q3P9Z+7Yxw4Q1F3Y=", "01000000041", "default-user.png", "Craftsman", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 42, 3, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "craftsman42@example.com", "أحمد إبراهيم علي", 1, true, false, "10000.hFJ4X3Yw9kF2QzJc6R6yVg==.pQ8x3x0+1uYw0xXrC6b3n0k8vZ5q3P9Z+7Yxw4Q1F3Y=", "01000000042", "default-user.png", "Craftsman", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 43, 4, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "craftsman43@example.com", "محمد إبراهيم علي", 1, true, false, "10000.hFJ4X3Yw9kF2QzJc6R6yVg==.pQ8x3x0+1uYw0xXrC6b3n0k8vZ5q3P9Z+7Yxw4Q1F3Y=", "01000000043", "default-user.png", "Craftsman", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 44, 5, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "craftsman44@example.com", "محمود إبراهيم علي", 1, true, false, "10000.hFJ4X3Yw9kF2QzJc6R6yVg==.pQ8x3x0+1uYw0xXrC6b3n0k8vZ5q3P9Z+7Yxw4Q1F3Y=", "01000000044", "default-user.png", "Craftsman", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 45, 1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "craftsman45@example.com", "عبدالله إبراهيم علي", 1, true, false, "10000.hFJ4X3Yw9kF2QzJc6R6yVg==.pQ8x3x0+1uYw0xXrC6b3n0k8vZ5q3P9Z+7Yxw4Q1F3Y=", "01000000045", "default-user.png", "Craftsman", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 46, 2, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "craftsman46@example.com", "عمر إبراهيم علي", 1, true, false, "10000.hFJ4X3Yw9kF2QzJc6R6yVg==.pQ8x3x0+1uYw0xXrC6b3n0k8vZ5q3P9Z+7Yxw4Q1F3Y=", "01000000046", "default-user.png", "Craftsman", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 47, 3, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "craftsman47@example.com", "كريم إبراهيم علي", 1, true, false, "10000.hFJ4X3Yw9kF2QzJc6R6yVg==.pQ8x3x0+1uYw0xXrC6b3n0k8vZ5q3P9Z+7Yxw4Q1F3Y=", "01000000047", "default-user.png", "Craftsman", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 48, 4, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "craftsman48@example.com", "سارة إبراهيم علي", 1, true, false, "10000.hFJ4X3Yw9kF2QzJc6R6yVg==.pQ8x3x0+1uYw0xXrC6b3n0k8vZ5q3P9Z+7Yxw4Q1F3Y=", "01000000048", "default-user.png", "Craftsman", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 49, 5, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "craftsman49@example.com", "نور إبراهيم علي", 1, true, false, "10000.hFJ4X3Yw9kF2QzJc6R6yVg==.pQ8x3x0+1uYw0xXrC6b3n0k8vZ5q3P9Z+7Yxw4Q1F3Y=", "01000000049", "default-user.png", "Craftsman", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 50, 1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "craftsman50@example.com", "هند إبراهيم علي", 1, true, false, "10000.hFJ4X3Yw9kF2QzJc6R6yVg==.pQ8x3x0+1uYw0xXrC6b3n0k8vZ5q3P9Z+7Yxw4Q1F3Y=", "01000000050", "default-user.png", "Craftsman", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 51, 2, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "craftsman51@example.com", "ليلى إبراهيم علي", 1, true, false, "10000.hFJ4X3Yw9kF2QzJc6R6yVg==.pQ8x3x0+1uYw0xXrC6b3n0k8vZ5q3P9Z+7Yxw4Q1F3Y=", "01000000051", "default-user.png", "Craftsman", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 52, 3, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "craftsman52@example.com", "منى إبراهيم علي", 1, true, false, "10000.hFJ4X3Yw9kF2QzJc6R6yVg==.pQ8x3x0+1uYw0xXrC6b3n0k8vZ5q3P9Z+7Yxw4Q1F3Y=", "01000000052", "default-user.png", "Craftsman", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 53, 4, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "craftsman53@example.com", "إيهاب إبراهيم علي", 1, true, false, "10000.hFJ4X3Yw9kF2QzJc6R6yVg==.pQ8x3x0+1uYw0xXrC6b3n0k8vZ5q3P9Z+7Yxw4Q1F3Y=", "01000000053", "default-user.png", "Craftsman", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 54, 5, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "craftsman54@example.com", "مروة إبراهيم علي", 1, true, false, "10000.hFJ4X3Yw9kF2QzJc6R6yVg==.pQ8x3x0+1uYw0xXrC6b3n0k8vZ5q3P9Z+7Yxw4Q1F3Y=", "01000000054", "default-user.png", "Craftsman", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 55, 1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "craftsman55@example.com", "طارق إبراهيم علي", 1, true, false, "10000.hFJ4X3Yw9kF2QzJc6R6yVg==.pQ8x3x0+1uYw0xXrC6b3n0k8vZ5q3P9Z+7Yxw4Q1F3Y=", "01000000055", "default-user.png", "Craftsman", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 56, 2, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "craftsman56@example.com", "علي إبراهيم علي", 1, true, false, "10000.hFJ4X3Yw9kF2QzJc6R6yVg==.pQ8x3x0+1uYw0xXrC6b3n0k8vZ5q3P9Z+7Yxw4Q1F3Y=", "01000000056", "default-user.png", "Craftsman", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 57, 3, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "craftsman57@example.com", "يوسف إبراهيم علي", 1, true, false, "10000.hFJ4X3Yw9kF2QzJc6R6yVg==.pQ8x3x0+1uYw0xXrC6b3n0k8vZ5q3P9Z+7Yxw4Q1F3Y=", "01000000057", "default-user.png", "Craftsman", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 58, 4, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "craftsman58@example.com", "عائشة إبراهيم علي", 1, true, false, "10000.hFJ4X3Yw9kF2QzJc6R6yVg==.pQ8x3x0+1uYw0xXrC6b3n0k8vZ5q3P9Z+7Yxw4Q1F3Y=", "01000000058", "default-user.png", "Craftsman", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 59, 5, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "craftsman59@example.com", "مريم إبراهيم علي", 1, true, false, "10000.hFJ4X3Yw9kF2QzJc6R6yVg==.pQ8x3x0+1uYw0xXrC6b3n0k8vZ5q3P9Z+7Yxw4Q1F3Y=", "01000000059", "default-user.png", "Craftsman", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 60, 1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "craftsman60@example.com", "خالد إبراهيم علي", 1, true, false, "10000.hFJ4X3Yw9kF2QzJc6R6yVg==.pQ8x3x0+1uYw0xXrC6b3n0k8vZ5q3P9Z+7Yxw4Q1F3Y=", "01000000060", "default-user.png", "Craftsman", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 61, 2, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "craftsman61@example.com", "إبراهيم إبراهيم علي", 1, true, false, "10000.hFJ4X3Yw9kF2QzJc6R6yVg==.pQ8x3x0+1uYw0xXrC6b3n0k8vZ5q3P9Z+7Yxw4Q1F3Y=", "01000000061", "default-user.png", "Craftsman", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 62, 3, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "craftsman62@example.com", "أحمد محمود علي", 1, true, false, "10000.hFJ4X3Yw9kF2QzJc6R6yVg==.pQ8x3x0+1uYw0xXrC6b3n0k8vZ5q3P9Z+7Yxw4Q1F3Y=", "01000000062", "default-user.png", "Craftsman", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 63, 4, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "craftsman63@example.com", "محمد محمود علي", 1, true, false, "10000.hFJ4X3Yw9kF2QzJc6R6yVg==.pQ8x3x0+1uYw0xXrC6b3n0k8vZ5q3P9Z+7Yxw4Q1F3Y=", "01000000063", "default-user.png", "Craftsman", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 64, 5, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "craftsman64@example.com", "محمود محمود علي", 1, true, false, "10000.hFJ4X3Yw9kF2QzJc6R6yVg==.pQ8x3x0+1uYw0xXrC6b3n0k8vZ5q3P9Z+7Yxw4Q1F3Y=", "01000000064", "default-user.png", "Craftsman", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 65, 1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "craftsman65@example.com", "عبدالله محمود علي", 1, true, false, "10000.hFJ4X3Yw9kF2QzJc6R6yVg==.pQ8x3x0+1uYw0xXrC6b3n0k8vZ5q3P9Z+7Yxw4Q1F3Y=", "01000000065", "default-user.png", "Craftsman", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 66, 2, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "craftsman66@example.com", "عمر محمود علي", 1, true, false, "10000.hFJ4X3Yw9kF2QzJc6R6yVg==.pQ8x3x0+1uYw0xXrC6b3n0k8vZ5q3P9Z+7Yxw4Q1F3Y=", "01000000066", "default-user.png", "Craftsman", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 67, 3, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "craftsman67@example.com", "كريم محمود علي", 1, true, false, "10000.hFJ4X3Yw9kF2QzJc6R6yVg==.pQ8x3x0+1uYw0xXrC6b3n0k8vZ5q3P9Z+7Yxw4Q1F3Y=", "01000000067", "default-user.png", "Craftsman", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 68, 4, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "craftsman68@example.com", "سارة محمود علي", 1, true, false, "10000.hFJ4X3Yw9kF2QzJc6R6yVg==.pQ8x3x0+1uYw0xXrC6b3n0k8vZ5q3P9Z+7Yxw4Q1F3Y=", "01000000068", "default-user.png", "Craftsman", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 69, 5, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "craftsman69@example.com", "نور محمود علي", 1, true, false, "10000.hFJ4X3Yw9kF2QzJc6R6yVg==.pQ8x3x0+1uYw0xXrC6b3n0k8vZ5q3P9Z+7Yxw4Q1F3Y=", "01000000069", "default-user.png", "Craftsman", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 70, 1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "craftsman70@example.com", "هند محمود علي", 1, true, false, "10000.hFJ4X3Yw9kF2QzJc6R6yVg==.pQ8x3x0+1uYw0xXrC6b3n0k8vZ5q3P9Z+7Yxw4Q1F3Y=", "01000000070", "default-user.png", "Craftsman", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 71, 2, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "craftsman71@example.com", "ليلى محمود علي", 1, true, false, "10000.hFJ4X3Yw9kF2QzJc6R6yVg==.pQ8x3x0+1uYw0xXrC6b3n0k8vZ5q3P9Z+7Yxw4Q1F3Y=", "01000000071", "default-user.png", "Craftsman", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 72, 3, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "craftsman72@example.com", "منى محمود علي", 1, true, false, "10000.hFJ4X3Yw9kF2QzJc6R6yVg==.pQ8x3x0+1uYw0xXrC6b3n0k8vZ5q3P9Z+7Yxw4Q1F3Y=", "01000000072", "default-user.png", "Craftsman", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 73, 4, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "craftsman73@example.com", "إيهاب محمود علي", 1, true, false, "10000.hFJ4X3Yw9kF2QzJc6R6yVg==.pQ8x3x0+1uYw0xXrC6b3n0k8vZ5q3P9Z+7Yxw4Q1F3Y=", "01000000073", "default-user.png", "Craftsman", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 74, 5, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "craftsman74@example.com", "مروة محمود علي", 1, true, false, "10000.hFJ4X3Yw9kF2QzJc6R6yVg==.pQ8x3x0+1uYw0xXrC6b3n0k8vZ5q3P9Z+7Yxw4Q1F3Y=", "01000000074", "default-user.png", "Craftsman", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 75, 1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "craftsman75@example.com", "طارق محمود علي", 1, true, false, "10000.hFJ4X3Yw9kF2QzJc6R6yVg==.pQ8x3x0+1uYw0xXrC6b3n0k8vZ5q3P9Z+7Yxw4Q1F3Y=", "01000000075", "default-user.png", "Craftsman", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 76, 2, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "craftsman76@example.com", "علي محمود علي", 1, true, false, "10000.hFJ4X3Yw9kF2QzJc6R6yVg==.pQ8x3x0+1uYw0xXrC6b3n0k8vZ5q3P9Z+7Yxw4Q1F3Y=", "01000000076", "default-user.png", "Craftsman", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 77, 3, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "craftsman77@example.com", "يوسف محمود علي", 1, true, false, "10000.hFJ4X3Yw9kF2QzJc6R6yVg==.pQ8x3x0+1uYw0xXrC6b3n0k8vZ5q3P9Z+7Yxw4Q1F3Y=", "01000000077", "default-user.png", "Craftsman", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 78, 4, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "craftsman78@example.com", "عائشة محمود علي", 1, true, false, "10000.hFJ4X3Yw9kF2QzJc6R6yVg==.pQ8x3x0+1uYw0xXrC6b3n0k8vZ5q3P9Z+7Yxw4Q1F3Y=", "01000000078", "default-user.png", "Craftsman", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 79, 5, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "craftsman79@example.com", "مريم محمود علي", 1, true, false, "10000.hFJ4X3Yw9kF2QzJc6R6yVg==.pQ8x3x0+1uYw0xXrC6b3n0k8vZ5q3P9Z+7Yxw4Q1F3Y=", "01000000079", "default-user.png", "Craftsman", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 80, 1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "craftsman80@example.com", "خالد محمود علي", 1, true, false, "10000.hFJ4X3Yw9kF2QzJc6R6yVg==.pQ8x3x0+1uYw0xXrC6b3n0k8vZ5q3P9Z+7Yxw4Q1F3Y=", "01000000080", "default-user.png", "Craftsman", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 81, 2, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "craftsman81@example.com", "إبراهيم محمود علي", 1, true, false, "10000.hFJ4X3Yw9kF2QzJc6R6yVg==.pQ8x3x0+1uYw0xXrC6b3n0k8vZ5q3P9Z+7Yxw4Q1F3Y=", "01000000081", "default-user.png", "Craftsman", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 82, 3, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "craftsman82@example.com", "أحمد عبدالرحمن علي", 1, true, false, "10000.hFJ4X3Yw9kF2QzJc6R6yVg==.pQ8x3x0+1uYw0xXrC6b3n0k8vZ5q3P9Z+7Yxw4Q1F3Y=", "01000000082", "default-user.png", "Craftsman", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 83, 4, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "craftsman83@example.com", "محمد عبدالرحمن علي", 1, true, false, "10000.hFJ4X3Yw9kF2QzJc6R6yVg==.pQ8x3x0+1uYw0xXrC6b3n0k8vZ5q3P9Z+7Yxw4Q1F3Y=", "01000000083", "default-user.png", "Craftsman", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 84, 5, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "craftsman84@example.com", "محمود عبدالرحمن علي", 1, true, false, "10000.hFJ4X3Yw9kF2QzJc6R6yVg==.pQ8x3x0+1uYw0xXrC6b3n0k8vZ5q3P9Z+7Yxw4Q1F3Y=", "01000000084", "default-user.png", "Craftsman", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 85, 1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "craftsman85@example.com", "عبدالله عبدالرحمن علي", 1, true, false, "10000.hFJ4X3Yw9kF2QzJc6R6yVg==.pQ8x3x0+1uYw0xXrC6b3n0k8vZ5q3P9Z+7Yxw4Q1F3Y=", "01000000085", "default-user.png", "Craftsman", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 86, 2, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "craftsman86@example.com", "عمر عبدالرحمن علي", 1, true, false, "10000.hFJ4X3Yw9kF2QzJc6R6yVg==.pQ8x3x0+1uYw0xXrC6b3n0k8vZ5q3P9Z+7Yxw4Q1F3Y=", "01000000086", "default-user.png", "Craftsman", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 87, 3, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "craftsman87@example.com", "كريم عبدالرحمن علي", 1, true, false, "10000.hFJ4X3Yw9kF2QzJc6R6yVg==.pQ8x3x0+1uYw0xXrC6b3n0k8vZ5q3P9Z+7Yxw4Q1F3Y=", "01000000087", "default-user.png", "Craftsman", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 88, 4, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "craftsman88@example.com", "سارة عبدالرحمن علي", 1, true, false, "10000.hFJ4X3Yw9kF2QzJc6R6yVg==.pQ8x3x0+1uYw0xXrC6b3n0k8vZ5q3P9Z+7Yxw4Q1F3Y=", "01000000088", "default-user.png", "Craftsman", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 89, 5, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "craftsman89@example.com", "نور عبدالرحمن علي", 1, true, false, "10000.hFJ4X3Yw9kF2QzJc6R6yVg==.pQ8x3x0+1uYw0xXrC6b3n0k8vZ5q3P9Z+7Yxw4Q1F3Y=", "01000000089", "default-user.png", "Craftsman", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 90, 1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "craftsman90@example.com", "هند عبدالرحمن علي", 1, true, false, "10000.hFJ4X3Yw9kF2QzJc6R6yVg==.pQ8x3x0+1uYw0xXrC6b3n0k8vZ5q3P9Z+7Yxw4Q1F3Y=", "01000000090", "default-user.png", "Craftsman", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 91, 2, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "craftsman91@example.com", "ليلى عبدالرحمن علي", 1, true, false, "10000.hFJ4X3Yw9kF2QzJc6R6yVg==.pQ8x3x0+1uYw0xXrC6b3n0k8vZ5q3P9Z+7Yxw4Q1F3Y=", "01000000091", "default-user.png", "Craftsman", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 92, 3, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "craftsman92@example.com", "منى عبدالرحمن علي", 1, true, false, "10000.hFJ4X3Yw9kF2QzJc6R6yVg==.pQ8x3x0+1uYw0xXrC6b3n0k8vZ5q3P9Z+7Yxw4Q1F3Y=", "01000000092", "default-user.png", "Craftsman", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 93, 4, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "craftsman93@example.com", "إيهاب عبدالرحمن علي", 1, true, false, "10000.hFJ4X3Yw9kF2QzJc6R6yVg==.pQ8x3x0+1uYw0xXrC6b3n0k8vZ5q3P9Z+7Yxw4Q1F3Y=", "01000000093", "default-user.png", "Craftsman", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 94, 5, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "craftsman94@example.com", "مروة عبدالرحمن علي", 1, true, false, "10000.hFJ4X3Yw9kF2QzJc6R6yVg==.pQ8x3x0+1uYw0xXrC6b3n0k8vZ5q3P9Z+7Yxw4Q1F3Y=", "01000000094", "default-user.png", "Craftsman", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 95, 1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "craftsman95@example.com", "طارق عبدالرحمن علي", 1, true, false, "10000.hFJ4X3Yw9kF2QzJc6R6yVg==.pQ8x3x0+1uYw0xXrC6b3n0k8vZ5q3P9Z+7Yxw4Q1F3Y=", "01000000095", "default-user.png", "Craftsman", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 96, 2, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "craftsman96@example.com", "علي عبدالرحمن علي", 1, true, false, "10000.hFJ4X3Yw9kF2QzJc6R6yVg==.pQ8x3x0+1uYw0xXrC6b3n0k8vZ5q3P9Z+7Yxw4Q1F3Y=", "01000000096", "default-user.png", "Craftsman", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 97, 3, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "craftsman97@example.com", "يوسف عبدالرحمن علي", 1, true, false, "10000.hFJ4X3Yw9kF2QzJc6R6yVg==.pQ8x3x0+1uYw0xXrC6b3n0k8vZ5q3P9Z+7Yxw4Q1F3Y=", "01000000097", "default-user.png", "Craftsman", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 98, 4, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "craftsman98@example.com", "عائشة عبدالرحمن علي", 1, true, false, "10000.hFJ4X3Yw9kF2QzJc6R6yVg==.pQ8x3x0+1uYw0xXrC6b3n0k8vZ5q3P9Z+7Yxw4Q1F3Y=", "01000000098", "default-user.png", "Craftsman", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 99, 5, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "craftsman99@example.com", "مريم عبدالرحمن علي", 1, true, false, "10000.hFJ4X3Yw9kF2QzJc6R6yVg==.pQ8x3x0+1uYw0xXrC6b3n0k8vZ5q3P9Z+7Yxw4Q1F3Y=", "01000000099", "default-user.png", "Craftsman", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 100, 1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "craftsman100@example.com", "خالد عبدالرحمن علي", 1, true, false, "10000.hFJ4X3Yw9kF2QzJc6R6yVg==.pQ8x3x0+1uYw0xXrC6b3n0k8vZ5q3P9Z+7Yxw4Q1F3Y=", "01000000100", "default-user.png", "Craftsman", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 101, 2, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "craftsman101@example.com", "إبراهيم عبدالرحمن علي", 1, true, false, "10000.hFJ4X3Yw9kF2QzJc6R6yVg==.pQ8x3x0+1uYw0xXrC6b3n0k8vZ5q3P9Z+7Yxw4Q1F3Y=", "01000000101", "default-user.png", "Craftsman", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 102, 3, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "craftsman102@example.com", "أحمد مصطفى علي", 1, true, false, "10000.hFJ4X3Yw9kF2QzJc6R6yVg==.pQ8x3x0+1uYw0xXrC6b3n0k8vZ5q3P9Z+7Yxw4Q1F3Y=", "01000000102", "default-user.png", "Craftsman", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 103, 4, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "craftsman103@example.com", "محمد مصطفى علي", 1, true, false, "10000.hFJ4X3Yw9kF2QzJc6R6yVg==.pQ8x3x0+1uYw0xXrC6b3n0k8vZ5q3P9Z+7Yxw4Q1F3Y=", "01000000103", "default-user.png", "Craftsman", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 104, 5, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "craftsman104@example.com", "محمود مصطفى علي", 1, true, false, "10000.hFJ4X3Yw9kF2QzJc6R6yVg==.pQ8x3x0+1uYw0xXrC6b3n0k8vZ5q3P9Z+7Yxw4Q1F3Y=", "01000000104", "default-user.png", "Craftsman", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 105, 1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "craftsman105@example.com", "عبدالله مصطفى علي", 1, true, false, "10000.hFJ4X3Yw9kF2QzJc6R6yVg==.pQ8x3x0+1uYw0xXrC6b3n0k8vZ5q3P9Z+7Yxw4Q1F3Y=", "01000000105", "default-user.png", "Craftsman", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 106, 2, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "craftsman106@example.com", "عمر مصطفى علي", 1, true, false, "10000.hFJ4X3Yw9kF2QzJc6R6yVg==.pQ8x3x0+1uYw0xXrC6b3n0k8vZ5q3P9Z+7Yxw4Q1F3Y=", "01000000106", "default-user.png", "Craftsman", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 107, 3, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "craftsman107@example.com", "كريم مصطفى علي", 1, true, false, "10000.hFJ4X3Yw9kF2QzJc6R6yVg==.pQ8x3x0+1uYw0xXrC6b3n0k8vZ5q3P9Z+7Yxw4Q1F3Y=", "01000000107", "default-user.png", "Craftsman", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 108, 4, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "craftsman108@example.com", "سارة مصطفى علي", 1, true, false, "10000.hFJ4X3Yw9kF2QzJc6R6yVg==.pQ8x3x0+1uYw0xXrC6b3n0k8vZ5q3P9Z+7Yxw4Q1F3Y=", "01000000108", "default-user.png", "Craftsman", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 109, 5, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "craftsman109@example.com", "نور مصطفى علي", 1, true, false, "10000.hFJ4X3Yw9kF2QzJc6R6yVg==.pQ8x3x0+1uYw0xXrC6b3n0k8vZ5q3P9Z+7Yxw4Q1F3Y=", "01000000109", "default-user.png", "Craftsman", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 110, 1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "craftsman110@example.com", "هند مصطفى علي", 1, true, false, "10000.hFJ4X3Yw9kF2QzJc6R6yVg==.pQ8x3x0+1uYw0xXrC6b3n0k8vZ5q3P9Z+7Yxw4Q1F3Y=", "01000000110", "default-user.png", "Craftsman", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 111, 2, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "craftsman111@example.com", "ليلى مصطفى علي", 1, true, false, "10000.hFJ4X3Yw9kF2QzJc6R6yVg==.pQ8x3x0+1uYw0xXrC6b3n0k8vZ5q3P9Z+7Yxw4Q1F3Y=", "01000000111", "default-user.png", "Craftsman", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 112, 3, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "craftsman112@example.com", "منى مصطفى علي", 1, true, false, "10000.hFJ4X3Yw9kF2QzJc6R6yVg==.pQ8x3x0+1uYw0xXrC6b3n0k8vZ5q3P9Z+7Yxw4Q1F3Y=", "01000000112", "default-user.png", "Craftsman", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 113, 4, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "craftsman113@example.com", "إيهاب مصطفى علي", 1, true, false, "10000.hFJ4X3Yw9kF2QzJc6R6yVg==.pQ8x3x0+1uYw0xXrC6b3n0k8vZ5q3P9Z+7Yxw4Q1F3Y=", "01000000113", "default-user.png", "Craftsman", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 114, 5, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "craftsman114@example.com", "مروة مصطفى علي", 1, true, false, "10000.hFJ4X3Yw9kF2QzJc6R6yVg==.pQ8x3x0+1uYw0xXrC6b3n0k8vZ5q3P9Z+7Yxw4Q1F3Y=", "01000000114", "default-user.png", "Craftsman", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 115, 1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "craftsman115@example.com", "طارق مصطفى علي", 1, true, false, "10000.hFJ4X3Yw9kF2QzJc6R6yVg==.pQ8x3x0+1uYw0xXrC6b3n0k8vZ5q3P9Z+7Yxw4Q1F3Y=", "01000000115", "default-user.png", "Craftsman", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 116, 2, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "craftsman116@example.com", "علي مصطفى علي", 1, true, false, "10000.hFJ4X3Yw9kF2QzJc6R6yVg==.pQ8x3x0+1uYw0xXrC6b3n0k8vZ5q3P9Z+7Yxw4Q1F3Y=", "01000000116", "default-user.png", "Craftsman", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 117, 3, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "craftsman117@example.com", "يوسف مصطفى علي", 1, true, false, "10000.hFJ4X3Yw9kF2QzJc6R6yVg==.pQ8x3x0+1uYw0xXrC6b3n0k8vZ5q3P9Z+7Yxw4Q1F3Y=", "01000000117", "default-user.png", "Craftsman", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 118, 4, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "craftsman118@example.com", "عائشة مصطفى علي", 1, true, false, "10000.hFJ4X3Yw9kF2QzJc6R6yVg==.pQ8x3x0+1uYw0xXrC6b3n0k8vZ5q3P9Z+7Yxw4Q1F3Y=", "01000000118", "default-user.png", "Craftsman", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 119, 5, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "craftsman119@example.com", "مريم مصطفى علي", 1, true, false, "10000.hFJ4X3Yw9kF2QzJc6R6yVg==.pQ8x3x0+1uYw0xXrC6b3n0k8vZ5q3P9Z+7Yxw4Q1F3Y=", "01000000119", "default-user.png", "Craftsman", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 120, 1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "craftsman120@example.com", "خالد مصطفى علي", 1, true, false, "10000.hFJ4X3Yw9kF2QzJc6R6yVg==.pQ8x3x0+1uYw0xXrC6b3n0k8vZ5q3P9Z+7Yxw4Q1F3Y=", "01000000120", "default-user.png", "Craftsman", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 121, 2, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "craftsman121@example.com", "إبراهيم مصطفى علي", 1, true, false, "10000.hFJ4X3Yw9kF2QzJc6R6yVg==.pQ8x3x0+1uYw0xXrC6b3n0k8vZ5q3P9Z+7Yxw4Q1F3Y=", "01000000121", "default-user.png", "Craftsman", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 122, 3, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "craftsman122@example.com", "أحمد ياسر علي", 1, true, false, "10000.hFJ4X3Yw9kF2QzJc6R6yVg==.pQ8x3x0+1uYw0xXrC6b3n0k8vZ5q3P9Z+7Yxw4Q1F3Y=", "01000000122", "default-user.png", "Craftsman", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 123, 4, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "craftsman123@example.com", "محمد ياسر علي", 1, true, false, "10000.hFJ4X3Yw9kF2QzJc6R6yVg==.pQ8x3x0+1uYw0xXrC6b3n0k8vZ5q3P9Z+7Yxw4Q1F3Y=", "01000000123", "default-user.png", "Craftsman", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 124, 5, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "craftsman124@example.com", "محمود ياسر علي", 1, true, false, "10000.hFJ4X3Yw9kF2QzJc6R6yVg==.pQ8x3x0+1uYw0xXrC6b3n0k8vZ5q3P9Z+7Yxw4Q1F3Y=", "01000000124", "default-user.png", "Craftsman", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 125, 1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "craftsman125@example.com", "عبدالله ياسر علي", 1, true, false, "10000.hFJ4X3Yw9kF2QzJc6R6yVg==.pQ8x3x0+1uYw0xXrC6b3n0k8vZ5q3P9Z+7Yxw4Q1F3Y=", "01000000125", "default-user.png", "Craftsman", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 126, 2, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "craftsman126@example.com", "عمر ياسر علي", 1, true, false, "10000.hFJ4X3Yw9kF2QzJc6R6yVg==.pQ8x3x0+1uYw0xXrC6b3n0k8vZ5q3P9Z+7Yxw4Q1F3Y=", "01000000126", "default-user.png", "Craftsman", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 127, 3, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "craftsman127@example.com", "كريم ياسر علي", 1, true, false, "10000.hFJ4X3Yw9kF2QzJc6R6yVg==.pQ8x3x0+1uYw0xXrC6b3n0k8vZ5q3P9Z+7Yxw4Q1F3Y=", "01000000127", "default-user.png", "Craftsman", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 128, 4, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "craftsman128@example.com", "سارة ياسر علي", 1, true, false, "10000.hFJ4X3Yw9kF2QzJc6R6yVg==.pQ8x3x0+1uYw0xXrC6b3n0k8vZ5q3P9Z+7Yxw4Q1F3Y=", "01000000128", "default-user.png", "Craftsman", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 129, 5, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "craftsman129@example.com", "نور ياسر علي", 1, true, false, "10000.hFJ4X3Yw9kF2QzJc6R6yVg==.pQ8x3x0+1uYw0xXrC6b3n0k8vZ5q3P9Z+7Yxw4Q1F3Y=", "01000000129", "default-user.png", "Craftsman", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 130, 1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "craftsman130@example.com", "هند ياسر علي", 1, true, false, "10000.hFJ4X3Yw9kF2QzJc6R6yVg==.pQ8x3x0+1uYw0xXrC6b3n0k8vZ5q3P9Z+7Yxw4Q1F3Y=", "01000000130", "default-user.png", "Craftsman", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 131, 2, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "craftsman131@example.com", "ليلى ياسر علي", 1, true, false, "10000.hFJ4X3Yw9kF2QzJc6R6yVg==.pQ8x3x0+1uYw0xXrC6b3n0k8vZ5q3P9Z+7Yxw4Q1F3Y=", "01000000131", "default-user.png", "Craftsman", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 132, 3, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "craftsman132@example.com", "منى ياسر علي", 1, true, false, "10000.hFJ4X3Yw9kF2QzJc6R6yVg==.pQ8x3x0+1uYw0xXrC6b3n0k8vZ5q3P9Z+7Yxw4Q1F3Y=", "01000000132", "default-user.png", "Craftsman", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 133, 4, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "craftsman133@example.com", "إيهاب ياسر علي", 1, true, false, "10000.hFJ4X3Yw9kF2QzJc6R6yVg==.pQ8x3x0+1uYw0xXrC6b3n0k8vZ5q3P9Z+7Yxw4Q1F3Y=", "01000000133", "default-user.png", "Craftsman", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 134, 5, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "craftsman134@example.com", "مروة ياسر علي", 1, true, false, "10000.hFJ4X3Yw9kF2QzJc6R6yVg==.pQ8x3x0+1uYw0xXrC6b3n0k8vZ5q3P9Z+7Yxw4Q1F3Y=", "01000000134", "default-user.png", "Craftsman", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 135, 1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "craftsman135@example.com", "طارق ياسر علي", 1, true, false, "10000.hFJ4X3Yw9kF2QzJc6R6yVg==.pQ8x3x0+1uYw0xXrC6b3n0k8vZ5q3P9Z+7Yxw4Q1F3Y=", "01000000135", "default-user.png", "Craftsman", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 136, 2, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "craftsman136@example.com", "علي ياسر علي", 1, true, false, "10000.hFJ4X3Yw9kF2QzJc6R6yVg==.pQ8x3x0+1uYw0xXrC6b3n0k8vZ5q3P9Z+7Yxw4Q1F3Y=", "01000000136", "default-user.png", "Craftsman", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 137, 3, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "craftsman137@example.com", "يوسف ياسر علي", 1, true, false, "10000.hFJ4X3Yw9kF2QzJc6R6yVg==.pQ8x3x0+1uYw0xXrC6b3n0k8vZ5q3P9Z+7Yxw4Q1F3Y=", "01000000137", "default-user.png", "Craftsman", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 138, 4, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "craftsman138@example.com", "عائشة ياسر علي", 1, true, false, "10000.hFJ4X3Yw9kF2QzJc6R6yVg==.pQ8x3x0+1uYw0xXrC6b3n0k8vZ5q3P9Z+7Yxw4Q1F3Y=", "01000000138", "default-user.png", "Craftsman", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 139, 5, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "craftsman139@example.com", "مريم ياسر علي", 1, true, false, "10000.hFJ4X3Yw9kF2QzJc6R6yVg==.pQ8x3x0+1uYw0xXrC6b3n0k8vZ5q3P9Z+7Yxw4Q1F3Y=", "01000000139", "default-user.png", "Craftsman", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 140, 1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "craftsman140@example.com", "خالد ياسر علي", 1, true, false, "10000.hFJ4X3Yw9kF2QzJc6R6yVg==.pQ8x3x0+1uYw0xXrC6b3n0k8vZ5q3P9Z+7Yxw4Q1F3Y=", "01000000140", "default-user.png", "Craftsman", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 141, 2, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "craftsman141@example.com", "إبراهيم ياسر علي", 1, true, false, "10000.hFJ4X3Yw9kF2QzJc6R6yVg==.pQ8x3x0+1uYw0xXrC6b3n0k8vZ5q3P9Z+7Yxw4Q1F3Y=", "01000000141", "default-user.png", "Craftsman", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 142, 3, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "craftsman142@example.com", "أحمد سامي علي", 1, true, false, "10000.hFJ4X3Yw9kF2QzJc6R6yVg==.pQ8x3x0+1uYw0xXrC6b3n0k8vZ5q3P9Z+7Yxw4Q1F3Y=", "01000000142", "default-user.png", "Craftsman", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 143, 4, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "craftsman143@example.com", "محمد سامي علي", 1, true, false, "10000.hFJ4X3Yw9kF2QzJc6R6yVg==.pQ8x3x0+1uYw0xXrC6b3n0k8vZ5q3P9Z+7Yxw4Q1F3Y=", "01000000143", "default-user.png", "Craftsman", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 144, 5, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "craftsman144@example.com", "محمود سامي علي", 1, true, false, "10000.hFJ4X3Yw9kF2QzJc6R6yVg==.pQ8x3x0+1uYw0xXrC6b3n0k8vZ5q3P9Z+7Yxw4Q1F3Y=", "01000000144", "default-user.png", "Craftsman", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 145, 1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "craftsman145@example.com", "عبدالله سامي علي", 1, true, false, "10000.hFJ4X3Yw9kF2QzJc6R6yVg==.pQ8x3x0+1uYw0xXrC6b3n0k8vZ5q3P9Z+7Yxw4Q1F3Y=", "01000000145", "default-user.png", "Craftsman", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 146, 2, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "craftsman146@example.com", "عمر سامي علي", 1, true, false, "10000.hFJ4X3Yw9kF2QzJc6R6yVg==.pQ8x3x0+1uYw0xXrC6b3n0k8vZ5q3P9Z+7Yxw4Q1F3Y=", "01000000146", "default-user.png", "Craftsman", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 147, 3, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "craftsman147@example.com", "كريم سامي علي", 1, true, false, "10000.hFJ4X3Yw9kF2QzJc6R6yVg==.pQ8x3x0+1uYw0xXrC6b3n0k8vZ5q3P9Z+7Yxw4Q1F3Y=", "01000000147", "default-user.png", "Craftsman", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 148, 4, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "craftsman148@example.com", "سارة سامي علي", 1, true, false, "10000.hFJ4X3Yw9kF2QzJc6R6yVg==.pQ8x3x0+1uYw0xXrC6b3n0k8vZ5q3P9Z+7Yxw4Q1F3Y=", "01000000148", "default-user.png", "Craftsman", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 149, 5, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "craftsman149@example.com", "نور سامي علي", 1, true, false, "10000.hFJ4X3Yw9kF2QzJc6R6yVg==.pQ8x3x0+1uYw0xXrC6b3n0k8vZ5q3P9Z+7Yxw4Q1F3Y=", "01000000149", "default-user.png", "Craftsman", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 150, 1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "craftsman150@example.com", "هند سامي علي", 1, true, false, "10000.hFJ4X3Yw9kF2QzJc6R6yVg==.pQ8x3x0+1uYw0xXrC6b3n0k8vZ5q3P9Z+7Yxw4Q1F3Y=", "01000000150", "default-user.png", "Craftsman", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 151, 2, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "craftsman151@example.com", "ليلى سامي علي", 1, true, false, "10000.hFJ4X3Yw9kF2QzJc6R6yVg==.pQ8x3x0+1uYw0xXrC6b3n0k8vZ5q3P9Z+7Yxw4Q1F3Y=", "01000000151", "default-user.png", "Craftsman", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 152, 3, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "craftsman152@example.com", "منى سامي علي", 1, true, false, "10000.hFJ4X3Yw9kF2QzJc6R6yVg==.pQ8x3x0+1uYw0xXrC6b3n0k8vZ5q3P9Z+7Yxw4Q1F3Y=", "01000000152", "default-user.png", "Craftsman", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 153, 4, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "craftsman153@example.com", "إيهاب سامي علي", 1, true, false, "10000.hFJ4X3Yw9kF2QzJc6R6yVg==.pQ8x3x0+1uYw0xXrC6b3n0k8vZ5q3P9Z+7Yxw4Q1F3Y=", "01000000153", "default-user.png", "Craftsman", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 154, 5, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "craftsman154@example.com", "مروة سامي علي", 1, true, false, "10000.hFJ4X3Yw9kF2QzJc6R6yVg==.pQ8x3x0+1uYw0xXrC6b3n0k8vZ5q3P9Z+7Yxw4Q1F3Y=", "01000000154", "default-user.png", "Craftsman", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 155, 1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "craftsman155@example.com", "طارق سامي علي", 1, true, false, "10000.hFJ4X3Yw9kF2QzJc6R6yVg==.pQ8x3x0+1uYw0xXrC6b3n0k8vZ5q3P9Z+7Yxw4Q1F3Y=", "01000000155", "default-user.png", "Craftsman", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 156, 2, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "craftsman156@example.com", "علي سامي علي", 1, true, false, "10000.hFJ4X3Yw9kF2QzJc6R6yVg==.pQ8x3x0+1uYw0xXrC6b3n0k8vZ5q3P9Z+7Yxw4Q1F3Y=", "01000000156", "default-user.png", "Craftsman", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 157, 3, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "craftsman157@example.com", "يوسف سامي علي", 1, true, false, "10000.hFJ4X3Yw9kF2QzJc6R6yVg==.pQ8x3x0+1uYw0xXrC6b3n0k8vZ5q3P9Z+7Yxw4Q1F3Y=", "01000000157", "default-user.png", "Craftsman", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 158, 4, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "craftsman158@example.com", "عائشة سامي علي", 1, true, false, "10000.hFJ4X3Yw9kF2QzJc6R6yVg==.pQ8x3x0+1uYw0xXrC6b3n0k8vZ5q3P9Z+7Yxw4Q1F3Y=", "01000000158", "default-user.png", "Craftsman", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 159, 5, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "craftsman159@example.com", "مريم سامي علي", 1, true, false, "10000.hFJ4X3Yw9kF2QzJc6R6yVg==.pQ8x3x0+1uYw0xXrC6b3n0k8vZ5q3P9Z+7Yxw4Q1F3Y=", "01000000159", "default-user.png", "Craftsman", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 160, 1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "craftsman160@example.com", "خالد سامي علي", 1, true, false, "10000.hFJ4X3Yw9kF2QzJc6R6yVg==.pQ8x3x0+1uYw0xXrC6b3n0k8vZ5q3P9Z+7Yxw4Q1F3Y=", "01000000160", "default-user.png", "Craftsman", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 161, 2, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "craftsman161@example.com", "إبراهيم سامي علي", 1, true, false, "10000.hFJ4X3Yw9kF2QzJc6R6yVg==.pQ8x3x0+1uYw0xXrC6b3n0k8vZ5q3P9Z+7Yxw4Q1F3Y=", "01000000161", "default-user.png", "Craftsman", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null }
                });

            migrationBuilder.InsertData(
                table: "Craftsmens",
                columns: new[] { "Id", "Bio", "CreatedAt", "CreatedBy", "ExperienceYears", "IsDeleted", "IsVerified", "MaxPrice", "MinPrice", "ProfessionId", "UpdatedAt", "UpdatedBy", "UserId", "VerificationDate" },
                values: new object[,]
                {
                    { 1, "صنايعي فني تكييف خبرة أكثر من 1 سنة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, false, false, 400m, 100m, 1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, null },
                    { 2, "صنايعي فني تكييف خبرة أكثر من 2 سنة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, false, false, 420m, 120m, 1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3, null },
                    { 3, "صنايعي فني تكييف خبرة أكثر من 3 سنة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3, false, true, 440m, 140m, 1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, "صنايعي فني تكييف خبرة أكثر من 4 سنة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4, false, false, 460m, 160m, 1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5, null },
                    { 5, "صنايعي فني تكييف خبرة أكثر من 5 سنة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5, false, false, 480m, 180m, 1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 6, null },
                    { 6, "صنايعي فني تكييف خبرة أكثر من 6 سنة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 6, false, true, 500m, 200m, 1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 7, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, "صنايعي فني تكييف خبرة أكثر من 7 سنة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 7, false, false, 520m, 220m, 1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 8, null },
                    { 8, "صنايعي فني تكييف خبرة أكثر من 8 سنة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 8, false, false, 540m, 240m, 1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 9, null },
                    { 9, "صنايعي فني تكييف خبرة أكثر من 9 سنة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 9, false, true, 560m, 260m, 1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, "صنايعي فني تكييف خبرة أكثر من 10 سنة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10, false, false, 580m, 280m, 1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 11, null },
                    { 11, "صنايعي فني تكييف خبرة أكثر من 11 سنة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 11, false, false, 600m, 300m, 1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 12, null },
                    { 12, "صنايعي فني تكييف خبرة أكثر من 12 سنة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 12, false, true, 620m, 320m, 1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 13, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 13, "صنايعي فني تكييف خبرة أكثر من 13 سنة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 13, false, false, 640m, 340m, 1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 14, null },
                    { 14, "صنايعي فني تكييف خبرة أكثر من 14 سنة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 14, false, false, 660m, 360m, 1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 15, null },
                    { 15, "صنايعي فني تكييف خبرة أكثر من 15 سنة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 15, false, true, 680m, 380m, 1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 16, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 16, "صنايعي فني تكييف خبرة أكثر من 1 سنة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, false, false, 700m, 400m, 1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 17, null },
                    { 17, "صنايعي فني تكييف خبرة أكثر من 2 سنة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, false, false, 720m, 420m, 1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 18, null },
                    { 18, "صنايعي فني تكييف خبرة أكثر من 3 سنة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3, false, true, 740m, 440m, 1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 19, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 19, "صنايعي فني تكييف خبرة أكثر من 4 سنة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4, false, false, 760m, 460m, 1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 20, null },
                    { 20, "صنايعي فني تكييف خبرة أكثر من 5 سنة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5, false, false, 780m, 480m, 1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 21, null },
                    { 21, "صنايعي نجار خبرة أكثر من 1 سنة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, false, true, 400m, 100m, 2, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 22, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 22, "صنايعي نجار خبرة أكثر من 2 سنة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, false, false, 420m, 120m, 2, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 23, null },
                    { 23, "صنايعي نجار خبرة أكثر من 3 سنة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3, false, false, 440m, 140m, 2, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 24, null },
                    { 24, "صنايعي نجار خبرة أكثر من 4 سنة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4, false, true, 460m, 160m, 2, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 25, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 25, "صنايعي نجار خبرة أكثر من 5 سنة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5, false, false, 480m, 180m, 2, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 26, null },
                    { 26, "صنايعي نجار خبرة أكثر من 6 سنة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 6, false, false, 500m, 200m, 2, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 27, null },
                    { 27, "صنايعي نجار خبرة أكثر من 7 سنة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 7, false, true, 520m, 220m, 2, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 28, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 28, "صنايعي نجار خبرة أكثر من 8 سنة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 8, false, false, 540m, 240m, 2, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 29, null },
                    { 29, "صنايعي نجار خبرة أكثر من 9 سنة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 9, false, false, 560m, 260m, 2, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 30, null },
                    { 30, "صنايعي نجار خبرة أكثر من 10 سنة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10, false, true, 580m, 280m, 2, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 31, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 31, "صنايعي نجار خبرة أكثر من 11 سنة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 11, false, false, 600m, 300m, 2, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 32, null },
                    { 32, "صنايعي نجار خبرة أكثر من 12 سنة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 12, false, false, 620m, 320m, 2, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 33, null },
                    { 33, "صنايعي نجار خبرة أكثر من 13 سنة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 13, false, true, 640m, 340m, 2, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 34, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 34, "صنايعي نجار خبرة أكثر من 14 سنة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 14, false, false, 660m, 360m, 2, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 35, null },
                    { 35, "صنايعي نجار خبرة أكثر من 15 سنة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 15, false, false, 680m, 380m, 2, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 36, null },
                    { 36, "صنايعي نجار خبرة أكثر من 1 سنة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, false, true, 700m, 400m, 2, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 37, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 37, "صنايعي نجار خبرة أكثر من 2 سنة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, false, false, 720m, 420m, 2, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 38, null },
                    { 38, "صنايعي نجار خبرة أكثر من 3 سنة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3, false, false, 740m, 440m, 2, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 39, null },
                    { 39, "صنايعي نجار خبرة أكثر من 4 سنة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4, false, true, 760m, 460m, 2, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 40, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 40, "صنايعي نجار خبرة أكثر من 5 سنة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5, false, false, 780m, 480m, 2, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 41, null },
                    { 41, "صنايعي كهربائي خبرة أكثر من 1 سنة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, false, false, 400m, 100m, 3, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 42, null },
                    { 42, "صنايعي كهربائي خبرة أكثر من 2 سنة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, false, true, 420m, 120m, 3, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 43, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 43, "صنايعي كهربائي خبرة أكثر من 3 سنة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3, false, false, 440m, 140m, 3, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 44, null },
                    { 44, "صنايعي كهربائي خبرة أكثر من 4 سنة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4, false, false, 460m, 160m, 3, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 45, null },
                    { 45, "صنايعي كهربائي خبرة أكثر من 5 سنة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5, false, true, 480m, 180m, 3, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 46, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 46, "صنايعي كهربائي خبرة أكثر من 6 سنة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 6, false, false, 500m, 200m, 3, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 47, null },
                    { 47, "صنايعي كهربائي خبرة أكثر من 7 سنة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 7, false, false, 520m, 220m, 3, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 48, null },
                    { 48, "صنايعي كهربائي خبرة أكثر من 8 سنة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 8, false, true, 540m, 240m, 3, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 49, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 49, "صنايعي كهربائي خبرة أكثر من 9 سنة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 9, false, false, 560m, 260m, 3, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 50, null },
                    { 50, "صنايعي كهربائي خبرة أكثر من 10 سنة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10, false, false, 580m, 280m, 3, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 51, null },
                    { 51, "صنايعي كهربائي خبرة أكثر من 11 سنة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 11, false, true, 600m, 300m, 3, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 52, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 52, "صنايعي كهربائي خبرة أكثر من 12 سنة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 12, false, false, 620m, 320m, 3, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 53, null },
                    { 53, "صنايعي كهربائي خبرة أكثر من 13 سنة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 13, false, false, 640m, 340m, 3, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 54, null },
                    { 54, "صنايعي كهربائي خبرة أكثر من 14 سنة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 14, false, true, 660m, 360m, 3, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 55, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 55, "صنايعي كهربائي خبرة أكثر من 15 سنة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 15, false, false, 680m, 380m, 3, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 56, null },
                    { 56, "صنايعي كهربائي خبرة أكثر من 1 سنة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, false, false, 700m, 400m, 3, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 57, null },
                    { 57, "صنايعي كهربائي خبرة أكثر من 2 سنة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, false, true, 720m, 420m, 3, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 58, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 58, "صنايعي كهربائي خبرة أكثر من 3 سنة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3, false, false, 740m, 440m, 3, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 59, null },
                    { 59, "صنايعي كهربائي خبرة أكثر من 4 سنة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4, false, false, 760m, 460m, 3, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 60, null },
                    { 60, "صنايعي كهربائي خبرة أكثر من 5 سنة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5, false, true, 780m, 480m, 3, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 61, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 61, "صنايعي سباك خبرة أكثر من 1 سنة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, false, false, 400m, 100m, 4, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 62, null },
                    { 62, "صنايعي سباك خبرة أكثر من 2 سنة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, false, false, 420m, 120m, 4, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 63, null },
                    { 63, "صنايعي سباك خبرة أكثر من 3 سنة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3, false, true, 440m, 140m, 4, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 64, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 64, "صنايعي سباك خبرة أكثر من 4 سنة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4, false, false, 460m, 160m, 4, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 65, null },
                    { 65, "صنايعي سباك خبرة أكثر من 5 سنة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5, false, false, 480m, 180m, 4, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 66, null },
                    { 66, "صنايعي سباك خبرة أكثر من 6 سنة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 6, false, true, 500m, 200m, 4, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 67, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 67, "صنايعي سباك خبرة أكثر من 7 سنة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 7, false, false, 520m, 220m, 4, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 68, null },
                    { 68, "صنايعي سباك خبرة أكثر من 8 سنة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 8, false, false, 540m, 240m, 4, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 69, null },
                    { 69, "صنايعي سباك خبرة أكثر من 9 سنة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 9, false, true, 560m, 260m, 4, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 70, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 70, "صنايعي سباك خبرة أكثر من 10 سنة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10, false, false, 580m, 280m, 4, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 71, null },
                    { 71, "صنايعي سباك خبرة أكثر من 11 سنة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 11, false, false, 600m, 300m, 4, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 72, null },
                    { 72, "صنايعي سباك خبرة أكثر من 12 سنة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 12, false, true, 620m, 320m, 4, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 73, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 73, "صنايعي سباك خبرة أكثر من 13 سنة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 13, false, false, 640m, 340m, 4, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 74, null },
                    { 74, "صنايعي سباك خبرة أكثر من 14 سنة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 14, false, false, 660m, 360m, 4, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 75, null },
                    { 75, "صنايعي سباك خبرة أكثر من 15 سنة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 15, false, true, 680m, 380m, 4, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 76, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 76, "صنايعي سباك خبرة أكثر من 1 سنة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, false, false, 700m, 400m, 4, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 77, null },
                    { 77, "صنايعي سباك خبرة أكثر من 2 سنة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, false, false, 720m, 420m, 4, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 78, null },
                    { 78, "صنايعي سباك خبرة أكثر من 3 سنة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3, false, true, 740m, 440m, 4, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 79, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 79, "صنايعي سباك خبرة أكثر من 4 سنة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4, false, false, 760m, 460m, 4, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 80, null },
                    { 80, "صنايعي سباك خبرة أكثر من 5 سنة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5, false, false, 780m, 480m, 4, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 81, null },
                    { 81, "صنايعي إصلاح أجهزة خبرة أكثر من 1 سنة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, false, true, 400m, 100m, 5, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 82, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 82, "صنايعي إصلاح أجهزة خبرة أكثر من 2 سنة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, false, false, 420m, 120m, 5, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 83, null },
                    { 83, "صنايعي إصلاح أجهزة خبرة أكثر من 3 سنة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3, false, false, 440m, 140m, 5, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 84, null },
                    { 84, "صنايعي إصلاح أجهزة خبرة أكثر من 4 سنة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4, false, true, 460m, 160m, 5, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 85, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 85, "صنايعي إصلاح أجهزة خبرة أكثر من 5 سنة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5, false, false, 480m, 180m, 5, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 86, null },
                    { 86, "صنايعي إصلاح أجهزة خبرة أكثر من 6 سنة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 6, false, false, 500m, 200m, 5, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 87, null },
                    { 87, "صنايعي إصلاح أجهزة خبرة أكثر من 7 سنة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 7, false, true, 520m, 220m, 5, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 88, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 88, "صنايعي إصلاح أجهزة خبرة أكثر من 8 سنة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 8, false, false, 540m, 240m, 5, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 89, null },
                    { 89, "صنايعي إصلاح أجهزة خبرة أكثر من 9 سنة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 9, false, false, 560m, 260m, 5, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 90, null },
                    { 90, "صنايعي إصلاح أجهزة خبرة أكثر من 10 سنة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10, false, true, 580m, 280m, 5, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 91, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 91, "صنايعي إصلاح أجهزة خبرة أكثر من 11 سنة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 11, false, false, 600m, 300m, 5, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 92, null },
                    { 92, "صنايعي إصلاح أجهزة خبرة أكثر من 12 سنة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 12, false, false, 620m, 320m, 5, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 93, null },
                    { 93, "صنايعي إصلاح أجهزة خبرة أكثر من 13 سنة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 13, false, true, 640m, 340m, 5, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 94, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 94, "صنايعي إصلاح أجهزة خبرة أكثر من 14 سنة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 14, false, false, 660m, 360m, 5, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 95, null },
                    { 95, "صنايعي إصلاح أجهزة خبرة أكثر من 15 سنة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 15, false, false, 680m, 380m, 5, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 96, null },
                    { 96, "صنايعي إصلاح أجهزة خبرة أكثر من 1 سنة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, false, true, 700m, 400m, 5, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 97, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 97, "صنايعي إصلاح أجهزة خبرة أكثر من 2 سنة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, false, false, 720m, 420m, 5, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 98, null },
                    { 98, "صنايعي إصلاح أجهزة خبرة أكثر من 3 سنة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3, false, false, 740m, 440m, 5, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 99, null },
                    { 99, "صنايعي إصلاح أجهزة خبرة أكثر من 4 سنة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4, false, true, 760m, 460m, 5, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 100, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 100, "صنايعي إصلاح أجهزة خبرة أكثر من 5 سنة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5, false, false, 780m, 480m, 5, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 101, null },
                    { 101, "صنايعي فني غاز خبرة أكثر من 1 سنة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, false, false, 400m, 100m, 6, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 102, null },
                    { 102, "صنايعي فني غاز خبرة أكثر من 2 سنة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, false, true, 420m, 120m, 6, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 103, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 103, "صنايعي فني غاز خبرة أكثر من 3 سنة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3, false, false, 440m, 140m, 6, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 104, null },
                    { 104, "صنايعي فني غاز خبرة أكثر من 4 سنة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4, false, false, 460m, 160m, 6, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 105, null },
                    { 105, "صنايعي فني غاز خبرة أكثر من 5 سنة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5, false, true, 480m, 180m, 6, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 106, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 106, "صنايعي فني غاز خبرة أكثر من 6 سنة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 6, false, false, 500m, 200m, 6, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 107, null },
                    { 107, "صنايعي فني غاز خبرة أكثر من 7 سنة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 7, false, false, 520m, 220m, 6, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 108, null },
                    { 108, "صنايعي فني غاز خبرة أكثر من 8 سنة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 8, false, true, 540m, 240m, 6, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 109, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 109, "صنايعي فني غاز خبرة أكثر من 9 سنة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 9, false, false, 560m, 260m, 6, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 110, null },
                    { 110, "صنايعي فني غاز خبرة أكثر من 10 سنة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10, false, false, 580m, 280m, 6, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 111, null },
                    { 111, "صنايعي فني غاز خبرة أكثر من 11 سنة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 11, false, true, 600m, 300m, 6, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 112, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 112, "صنايعي فني غاز خبرة أكثر من 12 سنة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 12, false, false, 620m, 320m, 6, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 113, null },
                    { 113, "صنايعي فني غاز خبرة أكثر من 13 سنة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 13, false, false, 640m, 340m, 6, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 114, null },
                    { 114, "صنايعي فني غاز خبرة أكثر من 14 سنة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 14, false, true, 660m, 360m, 6, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 115, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 115, "صنايعي فني غاز خبرة أكثر من 15 سنة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 15, false, false, 680m, 380m, 6, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 116, null },
                    { 116, "صنايعي فني غاز خبرة أكثر من 1 سنة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, false, false, 700m, 400m, 6, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 117, null },
                    { 117, "صنايعي فني غاز خبرة أكثر من 2 سنة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, false, true, 720m, 420m, 6, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 118, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 118, "صنايعي فني غاز خبرة أكثر من 3 سنة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3, false, false, 740m, 440m, 6, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 119, null },
                    { 119, "صنايعي فني غاز خبرة أكثر من 4 سنة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4, false, false, 760m, 460m, 6, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 120, null },
                    { 120, "صنايعي فني غاز خبرة أكثر من 5 سنة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5, false, true, 780m, 480m, 6, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 121, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 121, "صنايعي فني ألوميتال خبرة أكثر من 1 سنة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, false, false, 400m, 100m, 7, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 122, null },
                    { 122, "صنايعي فني ألوميتال خبرة أكثر من 2 سنة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, false, false, 420m, 120m, 7, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 123, null },
                    { 123, "صنايعي فني ألوميتال خبرة أكثر من 3 سنة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3, false, true, 440m, 140m, 7, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 124, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 124, "صنايعي فني ألوميتال خبرة أكثر من 4 سنة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4, false, false, 460m, 160m, 7, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 125, null },
                    { 125, "صنايعي فني ألوميتال خبرة أكثر من 5 سنة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5, false, false, 480m, 180m, 7, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 126, null },
                    { 126, "صنايعي فني ألوميتال خبرة أكثر من 6 سنة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 6, false, true, 500m, 200m, 7, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 127, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 127, "صنايعي فني ألوميتال خبرة أكثر من 7 سنة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 7, false, false, 520m, 220m, 7, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 128, null },
                    { 128, "صنايعي فني ألوميتال خبرة أكثر من 8 سنة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 8, false, false, 540m, 240m, 7, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 129, null },
                    { 129, "صنايعي فني ألوميتال خبرة أكثر من 9 سنة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 9, false, true, 560m, 260m, 7, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 130, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 130, "صنايعي فني ألوميتال خبرة أكثر من 10 سنة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10, false, false, 580m, 280m, 7, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 131, null },
                    { 131, "صنايعي فني ألوميتال خبرة أكثر من 11 سنة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 11, false, false, 600m, 300m, 7, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 132, null },
                    { 132, "صنايعي فني ألوميتال خبرة أكثر من 12 سنة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 12, false, true, 620m, 320m, 7, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 133, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 133, "صنايعي فني ألوميتال خبرة أكثر من 13 سنة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 13, false, false, 640m, 340m, 7, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 134, null },
                    { 134, "صنايعي فني ألوميتال خبرة أكثر من 14 سنة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 14, false, false, 660m, 360m, 7, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 135, null },
                    { 135, "صنايعي فني ألوميتال خبرة أكثر من 15 سنة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 15, false, true, 680m, 380m, 7, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 136, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 136, "صنايعي فني ألوميتال خبرة أكثر من 1 سنة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, false, false, 700m, 400m, 7, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 137, null },
                    { 137, "صنايعي فني ألوميتال خبرة أكثر من 2 سنة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, false, false, 720m, 420m, 7, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 138, null },
                    { 138, "صنايعي فني ألوميتال خبرة أكثر من 3 سنة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3, false, true, 740m, 440m, 7, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 139, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 139, "صنايعي فني ألوميتال خبرة أكثر من 4 سنة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4, false, false, 760m, 460m, 7, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 140, null },
                    { 140, "صنايعي فني ألوميتال خبرة أكثر من 5 سنة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5, false, false, 780m, 480m, 7, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 141, null },
                    { 141, "صنايعي نقاش خبرة أكثر من 1 سنة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, false, true, 400m, 100m, 8, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 142, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 142, "صنايعي نقاش خبرة أكثر من 2 سنة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, false, false, 420m, 120m, 8, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 143, null },
                    { 143, "صنايعي نقاش خبرة أكثر من 3 سنة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3, false, false, 440m, 140m, 8, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 144, null },
                    { 144, "صنايعي نقاش خبرة أكثر من 4 سنة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4, false, true, 460m, 160m, 8, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 145, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 145, "صنايعي نقاش خبرة أكثر من 5 سنة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5, false, false, 480m, 180m, 8, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 146, null },
                    { 146, "صنايعي نقاش خبرة أكثر من 6 سنة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 6, false, false, 500m, 200m, 8, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 147, null },
                    { 147, "صنايعي نقاش خبرة أكثر من 7 سنة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 7, false, true, 520m, 220m, 8, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 148, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 148, "صنايعي نقاش خبرة أكثر من 8 سنة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 8, false, false, 540m, 240m, 8, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 149, null },
                    { 149, "صنايعي نقاش خبرة أكثر من 9 سنة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 9, false, false, 560m, 260m, 8, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 150, null },
                    { 150, "صنايعي نقاش خبرة أكثر من 10 سنة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10, false, true, 580m, 280m, 8, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 151, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 151, "صنايعي نقاش خبرة أكثر من 11 سنة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 11, false, false, 600m, 300m, 8, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 152, null },
                    { 152, "صنايعي نقاش خبرة أكثر من 12 سنة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 12, false, false, 620m, 320m, 8, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 153, null },
                    { 153, "صنايعي نقاش خبرة أكثر من 13 سنة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 13, false, true, 640m, 340m, 8, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 154, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 154, "صنايعي نقاش خبرة أكثر من 14 سنة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 14, false, false, 660m, 360m, 8, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 155, null },
                    { 155, "صنايعي نقاش خبرة أكثر من 15 سنة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 15, false, false, 680m, 380m, 8, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 156, null },
                    { 156, "صنايعي نقاش خبرة أكثر من 1 سنة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, false, true, 700m, 400m, 8, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 157, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 157, "صنايعي نقاش خبرة أكثر من 2 سنة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, false, false, 720m, 420m, 8, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 158, null },
                    { 158, "صنايعي نقاش خبرة أكثر من 3 سنة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3, false, false, 740m, 440m, 8, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 159, null },
                    { 159, "صنايعي نقاش خبرة أكثر من 4 سنة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4, false, true, 760m, 460m, 8, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 160, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 160, "صنايعي نقاش خبرة أكثر من 5 سنة", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5, false, false, 780m, 480m, 8, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 161, null }
                });

            migrationBuilder.InsertData(
                table: "CraftsmansCity",
                columns: new[] { "Id", "CityId", "CraftsmanId", "CreatedAt", "CreatedBy", "IsDeleted", "IsPrimary", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, 1, 1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, true, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 2, 2, 2, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, true, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 3, 6, 2, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, false, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 4, 3, 3, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, true, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 5, 4, 4, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, true, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 6, 8, 4, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, false, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 7, 5, 5, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, true, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 8, 6, 6, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, true, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 9, 10, 6, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, false, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 10, 7, 7, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, true, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 11, 8, 8, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, true, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 12, 12, 8, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, false, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 13, 9, 9, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, true, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 14, 10, 10, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, true, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 15, 14, 10, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, false, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 16, 11, 11, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, true, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 17, 12, 12, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, true, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 18, 16, 12, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, false, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 19, 13, 13, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, true, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 20, 14, 14, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, true, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 21, 18, 14, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, false, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 22, 15, 15, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, true, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 23, 16, 16, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, true, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 24, 20, 16, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, false, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 25, 17, 17, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, true, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 26, 18, 18, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, true, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 27, 2, 18, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, false, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 28, 19, 19, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, true, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 29, 20, 20, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, true, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 30, 4, 20, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, false, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 31, 1, 21, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, true, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 32, 2, 22, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, true, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 33, 6, 22, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, false, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 34, 3, 23, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, true, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 35, 4, 24, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, true, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 36, 8, 24, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, false, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 37, 5, 25, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, true, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 38, 6, 26, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, true, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 39, 10, 26, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, false, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 40, 7, 27, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, true, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 41, 8, 28, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, true, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 42, 12, 28, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, false, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 43, 9, 29, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, true, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 44, 10, 30, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, true, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 45, 14, 30, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, false, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null }
                });

            migrationBuilder.InsertData(
                table: "CraftsmansSkills",
                columns: new[] { "Id", "CraftsmanId", "CreatedAt", "CreatedBy", "IsDeleted", "ProficiencyLevel", "SkillId", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, 1, 1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 2, 1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, 2, 2, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 3, 1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, 4, 3, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 4, 2, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, 1, 4, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 5, 2, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, 2, 5, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 6, 2, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, 4, 6, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 7, 3, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, 1, 7, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 8, 3, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, 2, 8, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 9, 3, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, 4, 9, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 10, 4, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, 1, 10, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 11, 4, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, 2, 11, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 12, 4, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, 4, 12, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 13, 5, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, 1, 13, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 14, 5, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, 2, 14, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 15, 5, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, 4, 15, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 16, 6, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, 1, 16, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 17, 6, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, 2, 17, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 18, 6, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, 4, 18, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 19, 7, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, 1, 19, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 20, 7, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, 2, 20, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 21, 7, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, 4, 21, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 22, 8, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, 1, 22, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 23, 8, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, 2, 23, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 24, 8, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, 4, 24, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 25, 9, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, 1, 25, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 26, 9, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, 2, 26, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 27, 9, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, 4, 27, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 28, 10, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, 1, 28, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 29, 10, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, 2, 29, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 30, 10, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, 4, 30, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 31, 11, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, 1, 31, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 32, 11, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, 2, 32, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 33, 11, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, 4, 33, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 34, 12, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, 1, 34, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 35, 12, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, 2, 35, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 36, 12, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, 4, 36, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 37, 13, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, 1, 37, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 38, 13, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, 2, 38, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 39, 13, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, 4, 39, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 40, 14, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, 1, 40, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 41, 14, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, 2, 41, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 42, 14, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, 4, 42, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 43, 15, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, 1, 43, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 44, 15, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, 2, 44, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 45, 15, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, 4, 45, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 46, 16, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, 1, 46, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 47, 16, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, 2, 47, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 48, 16, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, 4, 48, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 49, 17, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, 1, 49, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 50, 17, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, 2, 50, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 51, 17, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, 4, 51, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 52, 18, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, 1, 52, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 53, 18, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, 2, 53, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 54, 18, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, 4, 54, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 55, 19, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, 1, 55, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 56, 19, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, 2, 56, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 57, 19, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, 4, 57, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 58, 20, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, 1, 58, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 59, 20, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, 2, 59, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 60, 20, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, 4, 60, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 61, 21, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, 1, 1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 62, 21, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, 2, 2, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 63, 21, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, 4, 3, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 64, 22, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, 1, 4, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 65, 22, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, 2, 5, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 66, 22, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, 4, 6, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 67, 23, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, 1, 7, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 68, 23, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, 2, 8, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 69, 23, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, 4, 9, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 70, 24, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, 1, 10, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 71, 24, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, 2, 11, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 72, 24, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, 4, 12, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 73, 25, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, 1, 13, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 74, 25, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, 2, 14, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 75, 25, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, 4, 15, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 76, 26, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, 1, 16, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 77, 26, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, 2, 17, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 78, 26, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, 4, 18, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 79, 27, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, 1, 19, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 80, 27, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, 2, 20, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 81, 27, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, 4, 21, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 82, 28, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, 1, 22, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 83, 28, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, 2, 23, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 84, 28, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, 4, 24, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 85, 29, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, 1, 25, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 86, 29, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, 2, 26, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 87, 29, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, 4, 27, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 88, 30, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, 1, 28, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 89, 30, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, 2, 29, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 90, 30, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, 4, 30, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null }
                });

            migrationBuilder.InsertData(
                table: "CraftsmansSubscriptions",
                columns: new[] { "Id", "CraftsmanId", "CreatedAt", "CreatedBy", "EndDate", "IsActive", "IsDeleted", "PlanId", "StartDate", "Status", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, 3, new DateTime(2024, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", new DateTime(2024, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 2, 2, new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, 2, new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 3, 3, new DateTime(2024, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, 3, new DateTime(2024, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", new DateTime(2024, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 4, 4, new DateTime(2024, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, 2, new DateTime(2024, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", new DateTime(2024, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 5, 5, new DateTime(2024, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, 3, new DateTime(2024, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", new DateTime(2024, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 6, 6, new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, 2, new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 7, 7, new DateTime(2024, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, 3, new DateTime(2024, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", new DateTime(2024, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 8, 8, new DateTime(2024, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, 2, new DateTime(2024, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", new DateTime(2024, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 9, 9, new DateTime(2024, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, 3, new DateTime(2024, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", new DateTime(2024, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 10, 10, new DateTime(2024, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, 2, new DateTime(2024, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", new DateTime(2024, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 11, 11, new DateTime(2024, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, 3, new DateTime(2024, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", new DateTime(2024, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 12, 12, new DateTime(2024, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, 2, new DateTime(2024, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", new DateTime(2024, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 13, 13, new DateTime(2024, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, 3, new DateTime(2024, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", new DateTime(2024, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 14, 14, new DateTime(2024, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, 2, new DateTime(2024, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", new DateTime(2024, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 15, 15, new DateTime(2024, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, 3, new DateTime(2024, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", new DateTime(2024, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 16, 16, new DateTime(2024, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, 2, new DateTime(2024, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", new DateTime(2024, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 17, 17, new DateTime(2024, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, 3, new DateTime(2024, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", new DateTime(2024, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 18, 18, new DateTime(2024, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, 2, new DateTime(2024, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", new DateTime(2024, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 19, 19, new DateTime(2024, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, 3, new DateTime(2024, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", new DateTime(2024, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 20, 20, new DateTime(2024, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, 2, new DateTime(2024, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", new DateTime(2024, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null }
                });

            migrationBuilder.InsertData(
                table: "Gallerys",
                columns: new[] { "Id", "CraftsmanId", "CreatedAt", "CreatedBy", "Description", "IsDeleted", "MediaType", "MediaUrl", "Title", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sample gallery image 1 for craftsman 1", false, "Image", "/uploads/gallery/c1_1.jpg", "Work sample 1", new DateTime(2024, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 2, 1, new DateTime(2024, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sample gallery image 2 for craftsman 1", false, "Image", "/uploads/gallery/c1_2.jpg", "Work sample 2", new DateTime(2024, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 3, 1, new DateTime(2024, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sample gallery image 3 for craftsman 1", false, "Image", "/uploads/gallery/c1_3.jpg", "Work sample 3", new DateTime(2024, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 4, 2, new DateTime(2024, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sample gallery image 1 for craftsman 2", false, "Image", "/uploads/gallery/c2_1.jpg", "Work sample 1", new DateTime(2024, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 5, 2, new DateTime(2024, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sample gallery image 2 for craftsman 2", false, "Image", "/uploads/gallery/c2_2.jpg", "Work sample 2", new DateTime(2024, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 6, 2, new DateTime(2024, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sample gallery image 3 for craftsman 2", false, "Image", "/uploads/gallery/c2_3.jpg", "Work sample 3", new DateTime(2024, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 7, 3, new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sample gallery image 1 for craftsman 3", false, "Image", "/uploads/gallery/c3_1.jpg", "Work sample 1", new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 8, 3, new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sample gallery image 2 for craftsman 3", false, "Image", "/uploads/gallery/c3_2.jpg", "Work sample 2", new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 9, 3, new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sample gallery image 3 for craftsman 3", false, "Image", "/uploads/gallery/c3_3.jpg", "Work sample 3", new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 10, 4, new DateTime(2024, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sample gallery image 1 for craftsman 4", false, "Image", "/uploads/gallery/c4_1.jpg", "Work sample 1", new DateTime(2024, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 11, 4, new DateTime(2024, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sample gallery image 2 for craftsman 4", false, "Image", "/uploads/gallery/c4_2.jpg", "Work sample 2", new DateTime(2024, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 12, 4, new DateTime(2024, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sample gallery image 3 for craftsman 4", false, "Image", "/uploads/gallery/c4_3.jpg", "Work sample 3", new DateTime(2024, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 13, 5, new DateTime(2024, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sample gallery image 1 for craftsman 5", false, "Image", "/uploads/gallery/c5_1.jpg", "Work sample 1", new DateTime(2024, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 14, 5, new DateTime(2024, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sample gallery image 2 for craftsman 5", false, "Image", "/uploads/gallery/c5_2.jpg", "Work sample 2", new DateTime(2024, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 15, 5, new DateTime(2024, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sample gallery image 3 for craftsman 5", false, "Image", "/uploads/gallery/c5_3.jpg", "Work sample 3", new DateTime(2024, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 16, 6, new DateTime(2024, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sample gallery image 1 for craftsman 6", false, "Image", "/uploads/gallery/c6_1.jpg", "Work sample 1", new DateTime(2024, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 17, 6, new DateTime(2024, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sample gallery image 2 for craftsman 6", false, "Image", "/uploads/gallery/c6_2.jpg", "Work sample 2", new DateTime(2024, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 18, 6, new DateTime(2024, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sample gallery image 3 for craftsman 6", false, "Image", "/uploads/gallery/c6_3.jpg", "Work sample 3", new DateTime(2024, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 19, 7, new DateTime(2024, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sample gallery image 1 for craftsman 7", false, "Image", "/uploads/gallery/c7_1.jpg", "Work sample 1", new DateTime(2024, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 20, 7, new DateTime(2024, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sample gallery image 2 for craftsman 7", false, "Image", "/uploads/gallery/c7_2.jpg", "Work sample 2", new DateTime(2024, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 21, 7, new DateTime(2024, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sample gallery image 3 for craftsman 7", false, "Image", "/uploads/gallery/c7_3.jpg", "Work sample 3", new DateTime(2024, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 22, 8, new DateTime(2024, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sample gallery image 1 for craftsman 8", false, "Image", "/uploads/gallery/c8_1.jpg", "Work sample 1", new DateTime(2024, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 23, 8, new DateTime(2024, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sample gallery image 2 for craftsman 8", false, "Image", "/uploads/gallery/c8_2.jpg", "Work sample 2", new DateTime(2024, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 24, 8, new DateTime(2024, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sample gallery image 3 for craftsman 8", false, "Image", "/uploads/gallery/c8_3.jpg", "Work sample 3", new DateTime(2024, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 25, 9, new DateTime(2024, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sample gallery image 1 for craftsman 9", false, "Image", "/uploads/gallery/c9_1.jpg", "Work sample 1", new DateTime(2024, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 26, 9, new DateTime(2024, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sample gallery image 2 for craftsman 9", false, "Image", "/uploads/gallery/c9_2.jpg", "Work sample 2", new DateTime(2024, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 27, 9, new DateTime(2024, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sample gallery image 3 for craftsman 9", false, "Image", "/uploads/gallery/c9_3.jpg", "Work sample 3", new DateTime(2024, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 28, 10, new DateTime(2024, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sample gallery image 1 for craftsman 10", false, "Image", "/uploads/gallery/c10_1.jpg", "Work sample 1", new DateTime(2024, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 29, 10, new DateTime(2024, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sample gallery image 2 for craftsman 10", false, "Image", "/uploads/gallery/c10_2.jpg", "Work sample 2", new DateTime(2024, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 30, 10, new DateTime(2024, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sample gallery image 3 for craftsman 10", false, "Image", "/uploads/gallery/c10_3.jpg", "Work sample 3", new DateTime(2024, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 31, 11, new DateTime(2024, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sample gallery image 1 for craftsman 11", false, "Image", "/uploads/gallery/c11_1.jpg", "Work sample 1", new DateTime(2024, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 32, 11, new DateTime(2024, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sample gallery image 2 for craftsman 11", false, "Image", "/uploads/gallery/c11_2.jpg", "Work sample 2", new DateTime(2024, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 33, 11, new DateTime(2024, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sample gallery image 3 for craftsman 11", false, "Image", "/uploads/gallery/c11_3.jpg", "Work sample 3", new DateTime(2024, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 34, 12, new DateTime(2024, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sample gallery image 1 for craftsman 12", false, "Image", "/uploads/gallery/c12_1.jpg", "Work sample 1", new DateTime(2024, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 35, 12, new DateTime(2024, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sample gallery image 2 for craftsman 12", false, "Image", "/uploads/gallery/c12_2.jpg", "Work sample 2", new DateTime(2024, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 36, 12, new DateTime(2024, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sample gallery image 3 for craftsman 12", false, "Image", "/uploads/gallery/c12_3.jpg", "Work sample 3", new DateTime(2024, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 37, 13, new DateTime(2024, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sample gallery image 1 for craftsman 13", false, "Image", "/uploads/gallery/c13_1.jpg", "Work sample 1", new DateTime(2024, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 38, 13, new DateTime(2024, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sample gallery image 2 for craftsman 13", false, "Image", "/uploads/gallery/c13_2.jpg", "Work sample 2", new DateTime(2024, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 39, 13, new DateTime(2024, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sample gallery image 3 for craftsman 13", false, "Image", "/uploads/gallery/c13_3.jpg", "Work sample 3", new DateTime(2024, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 40, 14, new DateTime(2024, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sample gallery image 1 for craftsman 14", false, "Image", "/uploads/gallery/c14_1.jpg", "Work sample 1", new DateTime(2024, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 41, 14, new DateTime(2024, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sample gallery image 2 for craftsman 14", false, "Image", "/uploads/gallery/c14_2.jpg", "Work sample 2", new DateTime(2024, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 42, 14, new DateTime(2024, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sample gallery image 3 for craftsman 14", false, "Image", "/uploads/gallery/c14_3.jpg", "Work sample 3", new DateTime(2024, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 43, 15, new DateTime(2024, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sample gallery image 1 for craftsman 15", false, "Image", "/uploads/gallery/c15_1.jpg", "Work sample 1", new DateTime(2024, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 44, 15, new DateTime(2024, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sample gallery image 2 for craftsman 15", false, "Image", "/uploads/gallery/c15_2.jpg", "Work sample 2", new DateTime(2024, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 45, 15, new DateTime(2024, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sample gallery image 3 for craftsman 15", false, "Image", "/uploads/gallery/c15_3.jpg", "Work sample 3", new DateTime(2024, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 46, 16, new DateTime(2024, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sample gallery image 1 for craftsman 16", false, "Image", "/uploads/gallery/c16_1.jpg", "Work sample 1", new DateTime(2024, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 47, 16, new DateTime(2024, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sample gallery image 2 for craftsman 16", false, "Image", "/uploads/gallery/c16_2.jpg", "Work sample 2", new DateTime(2024, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 48, 16, new DateTime(2024, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sample gallery image 3 for craftsman 16", false, "Image", "/uploads/gallery/c16_3.jpg", "Work sample 3", new DateTime(2024, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 49, 17, new DateTime(2024, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sample gallery image 1 for craftsman 17", false, "Image", "/uploads/gallery/c17_1.jpg", "Work sample 1", new DateTime(2024, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 50, 17, new DateTime(2024, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sample gallery image 2 for craftsman 17", false, "Image", "/uploads/gallery/c17_2.jpg", "Work sample 2", new DateTime(2024, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 51, 17, new DateTime(2024, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sample gallery image 3 for craftsman 17", false, "Image", "/uploads/gallery/c17_3.jpg", "Work sample 3", new DateTime(2024, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 52, 18, new DateTime(2024, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sample gallery image 1 for craftsman 18", false, "Image", "/uploads/gallery/c18_1.jpg", "Work sample 1", new DateTime(2024, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 53, 18, new DateTime(2024, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sample gallery image 2 for craftsman 18", false, "Image", "/uploads/gallery/c18_2.jpg", "Work sample 2", new DateTime(2024, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 54, 18, new DateTime(2024, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sample gallery image 3 for craftsman 18", false, "Image", "/uploads/gallery/c18_3.jpg", "Work sample 3", new DateTime(2024, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 55, 19, new DateTime(2024, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sample gallery image 1 for craftsman 19", false, "Image", "/uploads/gallery/c19_1.jpg", "Work sample 1", new DateTime(2024, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 56, 19, new DateTime(2024, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sample gallery image 2 for craftsman 19", false, "Image", "/uploads/gallery/c19_2.jpg", "Work sample 2", new DateTime(2024, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 57, 19, new DateTime(2024, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sample gallery image 3 for craftsman 19", false, "Image", "/uploads/gallery/c19_3.jpg", "Work sample 3", new DateTime(2024, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 58, 20, new DateTime(2024, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sample gallery image 1 for craftsman 20", false, "Image", "/uploads/gallery/c20_1.jpg", "Work sample 1", new DateTime(2024, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 59, 20, new DateTime(2024, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sample gallery image 2 for craftsman 20", false, "Image", "/uploads/gallery/c20_2.jpg", "Work sample 2", new DateTime(2024, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 60, 20, new DateTime(2024, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sample gallery image 3 for craftsman 20", false, "Image", "/uploads/gallery/c20_3.jpg", "Work sample 3", new DateTime(2024, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 61, 21, new DateTime(2024, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sample gallery image 1 for craftsman 21", false, "Image", "/uploads/gallery/c21_1.jpg", "Work sample 1", new DateTime(2024, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 62, 21, new DateTime(2024, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sample gallery image 2 for craftsman 21", false, "Image", "/uploads/gallery/c21_2.jpg", "Work sample 2", new DateTime(2024, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 63, 21, new DateTime(2024, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sample gallery image 3 for craftsman 21", false, "Image", "/uploads/gallery/c21_3.jpg", "Work sample 3", new DateTime(2024, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 64, 22, new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sample gallery image 1 for craftsman 22", false, "Image", "/uploads/gallery/c22_1.jpg", "Work sample 1", new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 65, 22, new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sample gallery image 2 for craftsman 22", false, "Image", "/uploads/gallery/c22_2.jpg", "Work sample 2", new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 66, 22, new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sample gallery image 3 for craftsman 22", false, "Image", "/uploads/gallery/c22_3.jpg", "Work sample 3", new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 67, 23, new DateTime(2024, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sample gallery image 1 for craftsman 23", false, "Image", "/uploads/gallery/c23_1.jpg", "Work sample 1", new DateTime(2024, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 68, 23, new DateTime(2024, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sample gallery image 2 for craftsman 23", false, "Image", "/uploads/gallery/c23_2.jpg", "Work sample 2", new DateTime(2024, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 69, 23, new DateTime(2024, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sample gallery image 3 for craftsman 23", false, "Image", "/uploads/gallery/c23_3.jpg", "Work sample 3", new DateTime(2024, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 70, 24, new DateTime(2024, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sample gallery image 1 for craftsman 24", false, "Image", "/uploads/gallery/c24_1.jpg", "Work sample 1", new DateTime(2024, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 71, 24, new DateTime(2024, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sample gallery image 2 for craftsman 24", false, "Image", "/uploads/gallery/c24_2.jpg", "Work sample 2", new DateTime(2024, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 72, 24, new DateTime(2024, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sample gallery image 3 for craftsman 24", false, "Image", "/uploads/gallery/c24_3.jpg", "Work sample 3", new DateTime(2024, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 73, 25, new DateTime(2024, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sample gallery image 1 for craftsman 25", false, "Image", "/uploads/gallery/c25_1.jpg", "Work sample 1", new DateTime(2024, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 74, 25, new DateTime(2024, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sample gallery image 2 for craftsman 25", false, "Image", "/uploads/gallery/c25_2.jpg", "Work sample 2", new DateTime(2024, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 75, 25, new DateTime(2024, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sample gallery image 3 for craftsman 25", false, "Image", "/uploads/gallery/c25_3.jpg", "Work sample 3", new DateTime(2024, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 76, 26, new DateTime(2024, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sample gallery image 1 for craftsman 26", false, "Image", "/uploads/gallery/c26_1.jpg", "Work sample 1", new DateTime(2024, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 77, 26, new DateTime(2024, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sample gallery image 2 for craftsman 26", false, "Image", "/uploads/gallery/c26_2.jpg", "Work sample 2", new DateTime(2024, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 78, 26, new DateTime(2024, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sample gallery image 3 for craftsman 26", false, "Image", "/uploads/gallery/c26_3.jpg", "Work sample 3", new DateTime(2024, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 79, 27, new DateTime(2024, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sample gallery image 1 for craftsman 27", false, "Image", "/uploads/gallery/c27_1.jpg", "Work sample 1", new DateTime(2024, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 80, 27, new DateTime(2024, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sample gallery image 2 for craftsman 27", false, "Image", "/uploads/gallery/c27_2.jpg", "Work sample 2", new DateTime(2024, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 81, 27, new DateTime(2024, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sample gallery image 3 for craftsman 27", false, "Image", "/uploads/gallery/c27_3.jpg", "Work sample 3", new DateTime(2024, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 82, 28, new DateTime(2024, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sample gallery image 1 for craftsman 28", false, "Image", "/uploads/gallery/c28_1.jpg", "Work sample 1", new DateTime(2024, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 83, 28, new DateTime(2024, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sample gallery image 2 for craftsman 28", false, "Image", "/uploads/gallery/c28_2.jpg", "Work sample 2", new DateTime(2024, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 84, 28, new DateTime(2024, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sample gallery image 3 for craftsman 28", false, "Image", "/uploads/gallery/c28_3.jpg", "Work sample 3", new DateTime(2024, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 85, 29, new DateTime(2024, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sample gallery image 1 for craftsman 29", false, "Image", "/uploads/gallery/c29_1.jpg", "Work sample 1", new DateTime(2024, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 86, 29, new DateTime(2024, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sample gallery image 2 for craftsman 29", false, "Image", "/uploads/gallery/c29_2.jpg", "Work sample 2", new DateTime(2024, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 87, 29, new DateTime(2024, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sample gallery image 3 for craftsman 29", false, "Image", "/uploads/gallery/c29_3.jpg", "Work sample 3", new DateTime(2024, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 88, 30, new DateTime(2024, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sample gallery image 1 for craftsman 30", false, "Image", "/uploads/gallery/c30_1.jpg", "Work sample 1", new DateTime(2024, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 89, 30, new DateTime(2024, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sample gallery image 2 for craftsman 30", false, "Image", "/uploads/gallery/c30_2.jpg", "Work sample 2", new DateTime(2024, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 90, 30, new DateTime(2024, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sample gallery image 3 for craftsman 30", false, "Image", "/uploads/gallery/c30_3.jpg", "Work sample 3", new DateTime(2024, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Comment", "CraftsmanId", "CreatedAt", "CreatedBy", "IsApproved", "IsDeleted", "IsVerified", "Stars", "UpdatedAt", "UpdatedBy", "UserId" },
                values: new object[,]
                {
                    { 1, "Review #1 for craftsman 1", 1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, false, false, 3, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null },
                    { 2, "Review #2 for craftsman 2", 2, new DateTime(2024, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, false, true, 4, new DateTime(2024, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 33 },
                    { 3, "Review #3 for craftsman 3", 3, new DateTime(2024, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, false, true, 5, new DateTime(2024, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 34 },
                    { 4, "Review #4 for craftsman 4", 4, new DateTime(2024, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, false, true, 3, new DateTime(2024, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 35 },
                    { 5, "Review #5 for craftsman 5", 5, new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, false, false, 4, new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 36 },
                    { 6, "Review #6 for craftsman 6", 6, new DateTime(2024, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, false, true, 5, new DateTime(2024, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 37 },
                    { 7, "Review #7 for craftsman 7", 7, new DateTime(2024, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, false, true, 3, new DateTime(2024, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 38 },
                    { 8, "Review #8 for craftsman 8", 8, new DateTime(2024, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, false, true, 4, new DateTime(2024, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 39 },
                    { 9, "Review #9 for craftsman 9", 9, new DateTime(2024, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, false, false, 5, new DateTime(2024, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 40 },
                    { 10, "Review #10 for craftsman 10", 10, new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, false, true, 3, new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 41 },
                    { 11, "Review #11 for craftsman 11", 11, new DateTime(2024, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, false, true, 4, new DateTime(2024, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null },
                    { 12, "Review #12 for craftsman 12", 12, new DateTime(2024, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, false, true, 5, new DateTime(2024, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 43 },
                    { 13, "Review #13 for craftsman 13", 13, new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, false, false, 3, new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 44 },
                    { 14, "Review #14 for craftsman 14", 14, new DateTime(2024, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, false, true, 4, new DateTime(2024, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 45 },
                    { 15, "Review #15 for craftsman 15", 15, new DateTime(2024, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, false, true, 5, new DateTime(2024, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 46 },
                    { 16, "Review #16 for craftsman 16", 16, new DateTime(2024, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, false, true, 3, new DateTime(2024, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 47 },
                    { 17, "Review #17 for craftsman 17", 17, new DateTime(2024, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, false, false, 4, new DateTime(2024, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 48 },
                    { 18, "Review #18 for craftsman 18", 18, new DateTime(2024, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, false, true, 5, new DateTime(2024, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 49 },
                    { 19, "Review #19 for craftsman 19", 19, new DateTime(2024, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, false, true, 3, new DateTime(2024, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 32 },
                    { 20, "Review #20 for craftsman 20", 20, new DateTime(2024, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, false, true, 4, new DateTime(2024, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 33 },
                    { 21, "Review #21 for craftsman 21", 21, new DateTime(2024, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, false, false, 5, new DateTime(2024, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null },
                    { 22, "Review #22 for craftsman 22", 22, new DateTime(2024, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, false, true, 3, new DateTime(2024, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 35 },
                    { 23, "Review #23 for craftsman 23", 23, new DateTime(2024, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, false, true, 4, new DateTime(2024, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 36 },
                    { 24, "Review #24 for craftsman 24", 24, new DateTime(2024, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, false, true, 5, new DateTime(2024, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 37 },
                    { 25, "Review #25 for craftsman 25", 25, new DateTime(2024, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, false, false, 3, new DateTime(2024, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 38 },
                    { 26, "Review #26 for craftsman 26", 26, new DateTime(2024, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, false, true, 4, new DateTime(2024, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 39 },
                    { 27, "Review #27 for craftsman 27", 27, new DateTime(2024, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, false, true, 5, new DateTime(2024, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 40 },
                    { 28, "Review #28 for craftsman 28", 28, new DateTime(2024, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, false, true, 3, new DateTime(2024, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 41 },
                    { 29, "Review #29 for craftsman 29", 29, new DateTime(2024, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, false, false, 4, new DateTime(2024, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 42 },
                    { 30, "Review #30 for craftsman 30", 30, new DateTime(2024, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, false, true, 5, new DateTime(2024, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 43 },
                    { 31, "Review #31 for craftsman 1", 1, new DateTime(2024, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, false, true, 3, new DateTime(2024, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null },
                    { 32, "Review #32 for craftsman 2", 2, new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, false, true, 4, new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 45 },
                    { 33, "Review #33 for craftsman 3", 3, new DateTime(2024, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, false, false, 5, new DateTime(2024, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 46 },
                    { 34, "Review #34 for craftsman 4", 4, new DateTime(2024, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, false, true, 3, new DateTime(2024, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 47 },
                    { 35, "Review #35 for craftsman 5", 5, new DateTime(2024, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, false, true, 4, new DateTime(2024, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 48 },
                    { 36, "Review #36 for craftsman 6", 6, new DateTime(2024, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, false, true, 5, new DateTime(2024, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 49 },
                    { 37, "Review #37 for craftsman 7", 7, new DateTime(2024, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, false, false, 3, new DateTime(2024, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 32 },
                    { 38, "Review #38 for craftsman 8", 8, new DateTime(2024, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, false, true, 4, new DateTime(2024, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 33 },
                    { 39, "Review #39 for craftsman 9", 9, new DateTime(2024, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, false, true, 5, new DateTime(2024, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 34 },
                    { 40, "Review #40 for craftsman 10", 10, new DateTime(2024, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, false, true, 3, new DateTime(2024, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 35 },
                    { 41, "Review #41 for craftsman 11", 11, new DateTime(2024, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, false, false, 4, new DateTime(2024, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null },
                    { 42, "Review #42 for craftsman 12", 12, new DateTime(2024, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, false, true, 5, new DateTime(2024, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 37 },
                    { 43, "Review #43 for craftsman 13", 13, new DateTime(2024, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, false, true, 3, new DateTime(2024, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 38 },
                    { 44, "Review #44 for craftsman 14", 14, new DateTime(2024, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, false, true, 4, new DateTime(2024, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 39 },
                    { 45, "Review #45 for craftsman 15", 15, new DateTime(2024, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, false, false, 5, new DateTime(2024, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 40 },
                    { 46, "Review #46 for craftsman 16", 16, new DateTime(2024, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, false, true, 3, new DateTime(2024, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 41 },
                    { 47, "Review #47 for craftsman 17", 17, new DateTime(2024, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, false, true, 4, new DateTime(2024, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 42 },
                    { 48, "Review #48 for craftsman 18", 18, new DateTime(2024, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, false, true, 5, new DateTime(2024, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 43 },
                    { 49, "Review #49 for craftsman 19", 19, new DateTime(2024, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, false, false, 3, new DateTime(2024, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 44 },
                    { 50, "Review #50 for craftsman 20", 20, new DateTime(2024, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, false, true, 4, new DateTime(2024, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 45 },
                    { 51, "Review #51 for craftsman 21", 21, new DateTime(2024, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, false, true, 5, new DateTime(2024, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null },
                    { 52, "Review #52 for craftsman 22", 22, new DateTime(2024, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, false, true, 3, new DateTime(2024, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 47 },
                    { 53, "Review #53 for craftsman 23", 23, new DateTime(2024, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, false, false, 4, new DateTime(2024, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 48 },
                    { 54, "Review #54 for craftsman 24", 24, new DateTime(2024, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, false, true, 5, new DateTime(2024, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 49 },
                    { 55, "Review #55 for craftsman 25", 25, new DateTime(2024, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, false, true, 3, new DateTime(2024, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 32 },
                    { 56, "Review #56 for craftsman 26", 26, new DateTime(2024, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, false, true, 4, new DateTime(2024, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 33 },
                    { 57, "Review #57 for craftsman 27", 27, new DateTime(2024, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, false, false, 5, new DateTime(2024, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 34 },
                    { 58, "Review #58 for craftsman 28", 28, new DateTime(2024, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, false, true, 3, new DateTime(2024, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 35 },
                    { 59, "Review #59 for craftsman 29", 29, new DateTime(2024, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, false, true, 4, new DateTime(2024, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 36 },
                    { 60, "Review #60 for craftsman 30", 30, new DateTime(2024, 2, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, false, true, 5, new DateTime(2024, 2, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 37 },
                    { 61, "Review #61 for craftsman 1", 1, new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, false, false, 3, new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null },
                    { 62, "Review #62 for craftsman 2", 2, new DateTime(2024, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, false, true, 4, new DateTime(2024, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 39 },
                    { 63, "Review #63 for craftsman 3", 3, new DateTime(2024, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, false, true, 5, new DateTime(2024, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 40 },
                    { 64, "Review #64 for craftsman 4", 4, new DateTime(2024, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, false, true, 3, new DateTime(2024, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 41 },
                    { 65, "Review #65 for craftsman 5", 5, new DateTime(2024, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, false, false, 4, new DateTime(2024, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 42 },
                    { 66, "Review #66 for craftsman 6", 6, new DateTime(2024, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, false, true, 5, new DateTime(2024, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 43 },
                    { 67, "Review #67 for craftsman 7", 7, new DateTime(2024, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, false, true, 3, new DateTime(2024, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 44 },
                    { 68, "Review #68 for craftsman 8", 8, new DateTime(2024, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, false, true, 4, new DateTime(2024, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 45 },
                    { 69, "Review #69 for craftsman 9", 9, new DateTime(2024, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, false, false, 5, new DateTime(2024, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 46 },
                    { 70, "Review #70 for craftsman 10", 10, new DateTime(2024, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, false, true, 3, new DateTime(2024, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 47 },
                    { 71, "Review #71 for craftsman 11", 11, new DateTime(2024, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, false, true, 4, new DateTime(2024, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null },
                    { 72, "Review #72 for craftsman 12", 12, new DateTime(2024, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, false, true, 5, new DateTime(2024, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 49 },
                    { 73, "Review #73 for craftsman 13", 13, new DateTime(2024, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, false, false, 3, new DateTime(2024, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 32 },
                    { 74, "Review #74 for craftsman 14", 14, new DateTime(2024, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, false, true, 4, new DateTime(2024, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 33 },
                    { 75, "Review #75 for craftsman 15", 15, new DateTime(2024, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, false, true, 5, new DateTime(2024, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 34 },
                    { 76, "Review #76 for craftsman 16", 16, new DateTime(2024, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, false, true, 3, new DateTime(2024, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 35 },
                    { 77, "Review #77 for craftsman 17", 17, new DateTime(2024, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, false, false, 4, new DateTime(2024, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 36 },
                    { 78, "Review #78 for craftsman 18", 18, new DateTime(2024, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, false, true, 5, new DateTime(2024, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 37 },
                    { 79, "Review #79 for craftsman 19", 19, new DateTime(2024, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, false, true, 3, new DateTime(2024, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 38 },
                    { 80, "Review #80 for craftsman 20", 20, new DateTime(2024, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, false, true, 4, new DateTime(2024, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 39 },
                    { 81, "Review #81 for craftsman 21", 21, new DateTime(2024, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, false, false, 5, new DateTime(2024, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null },
                    { 82, "Review #82 for craftsman 22", 22, new DateTime(2024, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, false, true, 3, new DateTime(2024, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 41 },
                    { 83, "Review #83 for craftsman 23", 23, new DateTime(2024, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, false, true, 4, new DateTime(2024, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 42 },
                    { 84, "Review #84 for craftsman 24", 24, new DateTime(2024, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, false, true, 5, new DateTime(2024, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 43 },
                    { 85, "Review #85 for craftsman 25", 25, new DateTime(2024, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, false, false, 3, new DateTime(2024, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 44 },
                    { 86, "Review #86 for craftsman 26", 26, new DateTime(2024, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, false, true, 4, new DateTime(2024, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 45 },
                    { 87, "Review #87 for craftsman 27", 27, new DateTime(2024, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, false, true, 5, new DateTime(2024, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 46 },
                    { 88, "Review #88 for craftsman 28", 28, new DateTime(2024, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, false, true, 3, new DateTime(2024, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 47 },
                    { 89, "Review #89 for craftsman 29", 29, new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, false, false, 4, new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 48 },
                    { 90, "Review #90 for craftsman 30", 30, new DateTime(2024, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, false, true, 5, new DateTime(2024, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 49 },
                    { 91, "Review #91 for craftsman 1", 1, new DateTime(2024, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, false, true, 3, new DateTime(2024, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null },
                    { 92, "Review #92 for craftsman 2", 2, new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, false, true, 4, new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 33 },
                    { 93, "Review #93 for craftsman 3", 3, new DateTime(2024, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, false, false, 5, new DateTime(2024, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 34 },
                    { 94, "Review #94 for craftsman 4", 4, new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, false, true, 3, new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 35 },
                    { 95, "Review #95 for craftsman 5", 5, new DateTime(2024, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, false, true, 4, new DateTime(2024, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 36 },
                    { 96, "Review #96 for craftsman 6", 6, new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, false, true, 5, new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 37 },
                    { 97, "Review #97 for craftsman 7", 7, new DateTime(2024, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, false, false, 3, new DateTime(2024, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 38 },
                    { 98, "Review #98 for craftsman 8", 8, new DateTime(2024, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, false, true, 4, new DateTime(2024, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 39 },
                    { 99, "Review #99 for craftsman 9", 9, new DateTime(2024, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, false, true, 5, new DateTime(2024, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 40 },
                    { 100, "Review #100 for craftsman 10", 10, new DateTime(2024, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, false, true, 3, new DateTime(2024, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 41 },
                    { 101, "Review #101 for craftsman 11", 11, new DateTime(2024, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, false, false, 4, new DateTime(2024, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null },
                    { 102, "Review #102 for craftsman 12", 12, new DateTime(2024, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, false, true, 5, new DateTime(2024, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 43 },
                    { 103, "Review #103 for craftsman 13", 13, new DateTime(2024, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, false, true, 3, new DateTime(2024, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 44 },
                    { 104, "Review #104 for craftsman 14", 14, new DateTime(2024, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, false, true, 4, new DateTime(2024, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 45 },
                    { 105, "Review #105 for craftsman 15", 15, new DateTime(2024, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, false, false, 5, new DateTime(2024, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 46 },
                    { 106, "Review #106 for craftsman 16", 16, new DateTime(2024, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, false, true, 3, new DateTime(2024, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 47 },
                    { 107, "Review #107 for craftsman 17", 17, new DateTime(2024, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, false, true, 4, new DateTime(2024, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 48 },
                    { 108, "Review #108 for craftsman 18", 18, new DateTime(2024, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, false, true, 5, new DateTime(2024, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 49 },
                    { 109, "Review #109 for craftsman 19", 19, new DateTime(2024, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, false, false, 3, new DateTime(2024, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 32 },
                    { 110, "Review #110 for craftsman 20", 20, new DateTime(2024, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, false, true, 4, new DateTime(2024, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 33 },
                    { 111, "Review #111 for craftsman 21", 21, new DateTime(2024, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, false, true, 5, new DateTime(2024, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null },
                    { 112, "Review #112 for craftsman 22", 22, new DateTime(2024, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, false, true, 3, new DateTime(2024, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 35 },
                    { 113, "Review #113 for craftsman 23", 23, new DateTime(2024, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, false, false, 4, new DateTime(2024, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 36 },
                    { 114, "Review #114 for craftsman 24", 24, new DateTime(2024, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, false, true, 5, new DateTime(2024, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 37 },
                    { 115, "Review #115 for craftsman 25", 25, new DateTime(2024, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, false, true, 3, new DateTime(2024, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 38 },
                    { 116, "Review #116 for craftsman 26", 26, new DateTime(2024, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, false, true, 4, new DateTime(2024, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 39 },
                    { 117, "Review #117 for craftsman 27", 27, new DateTime(2024, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, false, false, 5, new DateTime(2024, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 40 },
                    { 118, "Review #118 for craftsman 28", 28, new DateTime(2024, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, false, true, 3, new DateTime(2024, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 41 },
                    { 119, "Review #119 for craftsman 29", 29, new DateTime(2024, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, false, true, 4, new DateTime(2024, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 42 },
                    { 120, "Review #120 for craftsman 30", 30, new DateTime(2024, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, false, true, 5, new DateTime(2024, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 43 }
                });

            migrationBuilder.InsertData(
                table: "Payments",
                columns: new[] { "Id", "Amount", "CreatedAt", "CreatedBy", "Currency", "IsDeleted", "PaymentMethod", "ProviderReference", "Status", "SubscriptionId", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, 200m, new DateTime(2024, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "EGP", false, "CreditCard", "TXN00001", "Paid", 1, new DateTime(2024, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 2, 50m, new DateTime(2024, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "EGP", false, "VodafoneCash", "TXN00002", "Paid", 2, new DateTime(2024, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 3, 200m, new DateTime(2024, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "EGP", false, "CreditCard", "TXN00003", "Paid", 3, new DateTime(2024, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 4, 50m, new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "EGP", false, "VodafoneCash", "TXN00004", "Paid", 4, new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 5, 200m, new DateTime(2024, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "EGP", false, "CreditCard", "TXN00005", "Paid", 5, new DateTime(2024, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 6, 50m, new DateTime(2024, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "EGP", false, "VodafoneCash", "TXN00006", "Paid", 6, new DateTime(2024, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 7, 200m, new DateTime(2024, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "EGP", false, "CreditCard", "TXN00007", "Paid", 7, new DateTime(2024, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 8, 50m, new DateTime(2024, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "EGP", false, "VodafoneCash", "TXN00008", "Paid", 8, new DateTime(2024, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 9, 200m, new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "EGP", false, "CreditCard", "TXN00009", "Paid", 9, new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 10, 50m, new DateTime(2024, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "EGP", false, "VodafoneCash", "TXN00010", "Paid", 10, new DateTime(2024, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 11, 200m, new DateTime(2024, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "EGP", false, "CreditCard", "TXN00011", "Paid", 11, new DateTime(2024, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 12, 50m, new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "EGP", false, "VodafoneCash", "TXN00012", "Paid", 12, new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 13, 200m, new DateTime(2024, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "EGP", false, "CreditCard", "TXN00013", "Paid", 13, new DateTime(2024, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 14, 50m, new DateTime(2024, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "EGP", false, "VodafoneCash", "TXN00014", "Paid", 14, new DateTime(2024, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 15, 200m, new DateTime(2024, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "EGP", false, "CreditCard", "TXN00015", "Paid", 15, new DateTime(2024, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 16, 50m, new DateTime(2024, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "EGP", false, "VodafoneCash", "TXN00016", "Paid", 16, new DateTime(2024, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 17, 200m, new DateTime(2024, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "EGP", false, "CreditCard", "TXN00017", "Paid", 17, new DateTime(2024, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 18, 50m, new DateTime(2024, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "EGP", false, "VodafoneCash", "TXN00018", "Paid", 18, new DateTime(2024, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 19, 200m, new DateTime(2024, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "EGP", false, "CreditCard", "TXN00019", "Paid", 19, new DateTime(2024, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 20, 50m, new DateTime(2024, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "EGP", false, "VodafoneCash", "TXN00020", "Paid", 20, new DateTime(2024, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Citys_GovernorateId",
                table: "Citys",
                column: "GovernorateId");

            migrationBuilder.CreateIndex(
                name: "IX_CraftsmansCity_CityId",
                table: "CraftsmansCity",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_CraftsmansCity_CraftsmanId",
                table: "CraftsmansCity",
                column: "CraftsmanId");

            migrationBuilder.CreateIndex(
                name: "IX_CraftsmansSkills_CraftsmanId",
                table: "CraftsmansSkills",
                column: "CraftsmanId");

            migrationBuilder.CreateIndex(
                name: "IX_CraftsmansSkills_SkillId",
                table: "CraftsmansSkills",
                column: "SkillId");

            migrationBuilder.CreateIndex(
                name: "IX_CraftsmansSubscriptions_CraftsmanId",
                table: "CraftsmansSubscriptions",
                column: "CraftsmanId");

            migrationBuilder.CreateIndex(
                name: "IX_CraftsmansSubscriptions_PlanId",
                table: "CraftsmansSubscriptions",
                column: "PlanId");

            migrationBuilder.CreateIndex(
                name: "IX_Craftsmens_ProfessionId",
                table: "Craftsmens",
                column: "ProfessionId");

            migrationBuilder.CreateIndex(
                name: "IX_Craftsmens_UserId",
                table: "Craftsmens",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Gallerys_CraftsmanId",
                table: "Gallerys",
                column: "CraftsmanId");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_SubscriptionId",
                table: "Payments",
                column: "SubscriptionId");

            migrationBuilder.CreateIndex(
                name: "IX_RefreshTokens_UserId",
                table: "RefreshTokens",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Reports_CraftsmanId",
                table: "Reports",
                column: "CraftsmanId");

            migrationBuilder.CreateIndex(
                name: "IX_Reports_ReporterUserId",
                table: "Reports",
                column: "ReporterUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_CraftsmanId",
                table: "Reviews",
                column: "CraftsmanId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_UserId",
                table: "Reviews",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_CityId",
                table: "Users",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_GovernorateId",
                table: "Users",
                column: "GovernorateId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CraftsmansCity");

            migrationBuilder.DropTable(
                name: "CraftsmansSkills");

            migrationBuilder.DropTable(
                name: "Gallerys");

            migrationBuilder.DropTable(
                name: "Payments");

            migrationBuilder.DropTable(
                name: "RefreshTokens");

            migrationBuilder.DropTable(
                name: "Reports");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "Skills");

            migrationBuilder.DropTable(
                name: "CraftsmansSubscriptions");

            migrationBuilder.DropTable(
                name: "Craftsmens");

            migrationBuilder.DropTable(
                name: "SubscriptionPlans");

            migrationBuilder.DropTable(
                name: "Professions");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Citys");

            migrationBuilder.DropTable(
                name: "Governorates");
        }
    }
}
