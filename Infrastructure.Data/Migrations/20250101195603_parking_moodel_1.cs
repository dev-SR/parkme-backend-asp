using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class parking_moodel_1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    FirstName = table.Column<string>(type: "TEXT", nullable: false),
                    LastName = table.Column<string>(type: "TEXT", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UserName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    PasswordHash = table.Column<string>(type: "TEXT", nullable: true),
                    SecurityStamp = table.Column<string>(type: "TEXT", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumber = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "TEXT", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ParkingLots",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    Address = table.Column<string>(type: "TEXT", nullable: false),
                    longitude = table.Column<double>(type: "REAL", nullable: false),
                    latitude = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParkingLots", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RoleId = table.Column<string>(type: "TEXT", nullable: false),
                    ClaimType = table.Column<string>(type: "TEXT", nullable: true),
                    ClaimValue = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    ClaimType = table.Column<string>(type: "TEXT", nullable: true),
                    ClaimValue = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "TEXT", nullable: false),
                    ProviderKey = table.Column<string>(type: "TEXT", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "TEXT", nullable: true),
                    UserId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    RoleId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    LoginProvider = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Value = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RefreshTokens",
                columns: table => new
                {
                    Token = table.Column<string>(type: "TEXT", nullable: false),
                    ExpiryDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    IsRevoked = table.Column<bool>(type: "INTEGER", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UserId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RefreshTokens", x => x.Token);
                    table.ForeignKey(
                        name: "FK_RefreshTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ParkingSpaces",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    SectionName = table.Column<string>(type: "TEXT", nullable: false),
                    VehicleType = table.Column<int>(type: "INTEGER", nullable: false),
                    Capacity = table.Column<int>(type: "INTEGER", nullable: false),
                    PricePerHour = table.Column<double>(type: "REAL", nullable: false),
                    ParkingLotId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParkingSpaces", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ParkingSpaces_ParkingLots_ParkingLotId",
                        column: x => x.ParkingLotId,
                        principalTable: "ParkingLots",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4756678c-b5b7-491a-992c-19f486247f9d", null, "Admin", "ADMIN" },
                    { "a94ec28e-da22-4681-be2c-dec4a19bb62b", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "ParkingLots",
                columns: new[] { "Id", "Address", "Description", "Name", "latitude", "longitude" },
                values: new object[,]
                {
                    { new Guid("266f8638-3805-492d-a872-94cb569cd27b"), "46399 Bahringer Stravenue, Port Birdie, Marshall Islands", "Consequatur dolore velit nam est et rerum ut neque vero.", "Hyatt Inc", 23.888311733618991, 89.099423516151745 },
                    { new Guid("39468006-c1d6-4c27-86a8-c0ff6915954d"), "279 Spencer Port, New Ricoshire, Central African Republic", "Tenetur suscipit blanditiis deleniti maxime officia quidem aspernatur in.", "Klein Group", 23.908507157432538, 89.148880168572063 },
                    { new Guid("48c7da8d-d4cd-48e4-838a-7cdf57a3dbf8"), "939 Hoppe Mountain, Hillsborough, Somalia", "Velit dolor maiores at est et.", "Heidenreich - Mosciski", 23.903954677657424, 89.131602261188974 },
                    { new Guid("57eca706-dcff-417a-b48e-842ce6ddf40e"), "13898 Nader Island, Okeyfurt, Suriname", "Est tempore est iusto soluta et.", "Hackett - Abshire", 23.892626180183775, 89.138904281470431 },
                    { new Guid("664ae4a3-c11e-417d-85b6-ffbe021c90ae"), "597 Syble Crossing, Olgaland, Barbados", "Facilis quibusdam inventore.", "Muller Group", 23.905043627143375, 89.146605618007058 },
                    { new Guid("91f45093-d313-4d5b-82cd-58fa754f2d93"), "62269 Spinka Point, Floydside, Taiwan", "Adipisci nostrum minus magni.", "Wyman - Lemke", 23.907187067970931, 89.109804321631671 },
                    { new Guid("a1e6b7ff-d5e3-44f6-a185-8a096f40b798"), "110 Upton Estate, Paucekfurt, Belize", "Placeat asperiores error.", "Witting - Friesen", 23.88776119840907, 89.119022777502295 },
                    { new Guid("b5df6745-d30b-4691-ae16-7477184cd22b"), "933 Maribel Fords, South Claireport, Malta", "Provident tempore quia culpa harum officia excepturi inventore et.", "Hettinger, Wuckert and Larkin", 23.895335708425002, 89.10435557335181 },
                    { new Guid("b73f4670-3f97-40c4-9dbf-2749b08740fa"), "3425 Sporer Forges, New Maximoton, Portugal", "Rerum est nihil dolores enim iure at recusandae ut maiores.", "Ritchie - Gutmann", 23.888316153525082, 89.133589140033308 },
                    { new Guid("cd391eaa-08b8-442e-986e-599083aca06e"), "244 Federico Street, Margaretberg, Antarctica (the territory South of 60 deg S)", "Iusto cupiditate quia dolorem.", "Schaden, Konopelski and Rosenbaum", 23.882816724487977, 89.150900249184147 }
                });

            migrationBuilder.InsertData(
                table: "ParkingSpaces",
                columns: new[] { "Id", "Capacity", "ParkingLotId", "PricePerHour", "SectionName", "VehicleType" },
                values: new object[,]
                {
                    { new Guid("0f519fe2-4873-4dc6-be0a-b4b06d36b0cd"), 24, new Guid("a1e6b7ff-d5e3-44f6-a185-8a096f40b798"), 12.795442821893351, "A-9", 1 },
                    { new Guid("0fd162ce-f5b8-42e7-8aa0-892c8097eb5b"), 32, new Guid("a1e6b7ff-d5e3-44f6-a185-8a096f40b798"), 14.586403606244845, "C-17", 1 },
                    { new Guid("10473166-6693-4281-8aa6-639b4e8c07b6"), 37, new Guid("266f8638-3805-492d-a872-94cb569cd27b"), 19.361347897081064, "B-1", 1 },
                    { new Guid("118f64bd-1457-4cef-ad83-f2e012e98540"), 15, new Guid("b73f4670-3f97-40c4-9dbf-2749b08740fa"), 13.966158285221363, "A-8", 2 },
                    { new Guid("125d4b60-120d-4ded-bc28-40f17ee70321"), 15, new Guid("664ae4a3-c11e-417d-85b6-ffbe021c90ae"), 6.7983245329865944, "D-19", 2 },
                    { new Guid("19f59729-462c-4c6e-aa1d-2eb98aed336a"), 39, new Guid("664ae4a3-c11e-417d-85b6-ffbe021c90ae"), 19.952309301183838, "C-14", 0 },
                    { new Guid("204bdba4-7dc5-4719-bf2d-fb754e89b450"), 21, new Guid("b73f4670-3f97-40c4-9dbf-2749b08740fa"), 10.561430096167445, "C-14", 2 },
                    { new Guid("24639b99-3bdf-4603-a030-9b0dde29d6cd"), 35, new Guid("b5df6745-d30b-4691-ae16-7477184cd22b"), 15.153764617482022, "A-3", 1 },
                    { new Guid("2ca1d638-2296-48d5-9be1-4cbcea928226"), 20, new Guid("266f8638-3805-492d-a872-94cb569cd27b"), 13.836605728537387, "D-19", 1 },
                    { new Guid("2f6fe8a5-6312-4f73-91b5-1f44e094c8bf"), 24, new Guid("cd391eaa-08b8-442e-986e-599083aca06e"), 18.359090007258324, "C-17", 0 },
                    { new Guid("3aa4d7d7-efc3-452b-9283-ce91d2d45301"), 31, new Guid("48c7da8d-d4cd-48e4-838a-7cdf57a3dbf8"), 5.7122875492342216, "A-4", 2 },
                    { new Guid("42dc44e8-a75f-449e-a2a4-f6a3d0b565d3"), 31, new Guid("91f45093-d313-4d5b-82cd-58fa754f2d93"), 6.7053851113062652, "B-12", 0 },
                    { new Guid("471e5627-1658-4809-aae5-f3aa18ad8396"), 16, new Guid("cd391eaa-08b8-442e-986e-599083aca06e"), 13.034586225760197, "D-5", 2 },
                    { new Guid("4b67061c-a137-4116-851a-d63722aeeaac"), 19, new Guid("57eca706-dcff-417a-b48e-842ce6ddf40e"), 15.505833848685823, "D-19", 0 },
                    { new Guid("4c795b09-ff25-4d7a-94b1-2c71ace65453"), 49, new Guid("a1e6b7ff-d5e3-44f6-a185-8a096f40b798"), 18.436518562830202, "A-1", 1 },
                    { new Guid("50875bec-6aba-459d-9541-f25054a210c0"), 25, new Guid("a1e6b7ff-d5e3-44f6-a185-8a096f40b798"), 17.705429800014279, "A-6", 0 },
                    { new Guid("527a002a-a585-4d31-9fe3-4dd18f030b6a"), 22, new Guid("664ae4a3-c11e-417d-85b6-ffbe021c90ae"), 8.4770121110788743, "A-17", 2 },
                    { new Guid("549f1288-b808-4d76-91af-c708b7e41eab"), 47, new Guid("57eca706-dcff-417a-b48e-842ce6ddf40e"), 5.3337111350009909, "B-13", 2 },
                    { new Guid("6fbb6b58-8060-4a08-bab7-f9fa37373015"), 34, new Guid("39468006-c1d6-4c27-86a8-c0ff6915954d"), 6.4398530983966547, "A-9", 2 },
                    { new Guid("759f5f6e-2bd9-49b4-b62c-0fed9c8a340e"), 30, new Guid("48c7da8d-d4cd-48e4-838a-7cdf57a3dbf8"), 9.9841472413450933, "C-9", 0 },
                    { new Guid("7b564d17-06e2-401e-bbce-a10f3681cd9f"), 36, new Guid("48c7da8d-d4cd-48e4-838a-7cdf57a3dbf8"), 11.994348269043483, "D-14", 2 },
                    { new Guid("80c51b07-c8ac-49d7-96a4-587b47f3f28a"), 49, new Guid("48c7da8d-d4cd-48e4-838a-7cdf57a3dbf8"), 9.9453691500855044, "B-18", 1 },
                    { new Guid("884db358-8a3b-491a-aac6-f6e2a5ad5590"), 28, new Guid("39468006-c1d6-4c27-86a8-c0ff6915954d"), 15.432597948046247, "C-15", 1 },
                    { new Guid("8a2341b7-1992-4da7-935d-3b2f48ca9f41"), 30, new Guid("b5df6745-d30b-4691-ae16-7477184cd22b"), 17.722519623664812, "B-1", 2 },
                    { new Guid("8cb37558-25ac-4cb2-a68e-1a83a0679e15"), 42, new Guid("cd391eaa-08b8-442e-986e-599083aca06e"), 8.8122770727490369, "B-7", 1 },
                    { new Guid("9bb755b7-3588-4de7-b775-9db7e1b80b35"), 15, new Guid("57eca706-dcff-417a-b48e-842ce6ddf40e"), 15.509685115576719, "A-19", 2 },
                    { new Guid("a3f71ad7-d4c8-43d0-8ba2-e357bfb43715"), 40, new Guid("664ae4a3-c11e-417d-85b6-ffbe021c90ae"), 7.6810145223099635, "A-2", 0 },
                    { new Guid("a4be293b-2fec-4608-bd88-41c1c409f9b1"), 10, new Guid("cd391eaa-08b8-442e-986e-599083aca06e"), 12.050696691452014, "B-18", 1 },
                    { new Guid("a63595c4-c597-4465-8b59-ce092f18b654"), 44, new Guid("b73f4670-3f97-40c4-9dbf-2749b08740fa"), 13.083383047427587, "C-8", 0 },
                    { new Guid("a9f19ed4-7a1b-4470-9ea1-975ef784d423"), 19, new Guid("57eca706-dcff-417a-b48e-842ce6ddf40e"), 15.58587471788597, "B-12", 1 },
                    { new Guid("ab74d4bf-3066-4a8b-8dfc-5c78fb094791"), 22, new Guid("664ae4a3-c11e-417d-85b6-ffbe021c90ae"), 16.174229053129796, "B-10", 1 },
                    { new Guid("af3344b2-65f2-4105-b61f-452ad28fffb8"), 28, new Guid("48c7da8d-d4cd-48e4-838a-7cdf57a3dbf8"), 12.33232245723925, "A-6", 2 },
                    { new Guid("b30c1335-a32a-4c0b-a826-13302c24077a"), 45, new Guid("39468006-c1d6-4c27-86a8-c0ff6915954d"), 6.1578097423095173, "A-11", 2 },
                    { new Guid("b4db7ae2-96ef-483f-a014-6f53b4ea071e"), 22, new Guid("b5df6745-d30b-4691-ae16-7477184cd22b"), 8.227812033302337, "A-3", 0 },
                    { new Guid("b5b25fbf-c70a-47cc-af94-c51ec938095c"), 13, new Guid("57eca706-dcff-417a-b48e-842ce6ddf40e"), 16.219038582542126, "C-5", 2 },
                    { new Guid("b7446432-5e45-437a-a475-bb0a19c2b842"), 49, new Guid("b5df6745-d30b-4691-ae16-7477184cd22b"), 19.438460786470035, "A-19", 1 },
                    { new Guid("ba72bb65-0276-428e-968f-6e939d885711"), 48, new Guid("266f8638-3805-492d-a872-94cb569cd27b"), 12.582574414441741, "D-8", 1 },
                    { new Guid("bbf5b7ac-a50b-4027-9fa7-fa0804335022"), 33, new Guid("266f8638-3805-492d-a872-94cb569cd27b"), 16.566507973045816, "A-1", 2 },
                    { new Guid("bcb8fc49-a251-4d04-94fc-2eaa5dee78a4"), 49, new Guid("664ae4a3-c11e-417d-85b6-ffbe021c90ae"), 19.780663320634297, "D-6", 2 },
                    { new Guid("c16b5981-12c6-4dd9-893e-b69b3a71ca8d"), 38, new Guid("266f8638-3805-492d-a872-94cb569cd27b"), 10.977550590310672, "A-8", 0 },
                    { new Guid("c2d1d9ab-bc31-4599-89ec-5f9b4b53cc4a"), 44, new Guid("664ae4a3-c11e-417d-85b6-ffbe021c90ae"), 16.315271241066121, "C-15", 0 },
                    { new Guid("c46840a3-c02a-4d30-9098-05d92ee46e72"), 16, new Guid("39468006-c1d6-4c27-86a8-c0ff6915954d"), 16.781571264015302, "D-19", 0 },
                    { new Guid("c46af96d-95ea-4b04-a647-331d8a47d398"), 50, new Guid("b73f4670-3f97-40c4-9dbf-2749b08740fa"), 9.4534173927887792, "A-17", 1 },
                    { new Guid("d18c9b5d-b2f9-4c5d-93ad-c9cf3ca3e758"), 31, new Guid("91f45093-d313-4d5b-82cd-58fa754f2d93"), 14.966591295406278, "D-8", 0 },
                    { new Guid("d37a1ad8-404c-4c42-8147-414e8f5f4656"), 28, new Guid("664ae4a3-c11e-417d-85b6-ffbe021c90ae"), 6.9127041460113166, "D-5", 1 },
                    { new Guid("e2912572-12df-4093-b16d-d80d1cebe3f4"), 40, new Guid("266f8638-3805-492d-a872-94cb569cd27b"), 13.533947825389628, "C-4", 0 },
                    { new Guid("e50c2398-c114-41b9-9595-ae021a989b3d"), 25, new Guid("b5df6745-d30b-4691-ae16-7477184cd22b"), 17.413204937686807, "C-4", 0 },
                    { new Guid("f1c6f07e-d819-4971-9f62-169f5a870ed2"), 40, new Guid("a1e6b7ff-d5e3-44f6-a185-8a096f40b798"), 18.984391376412198, "A-13", 2 },
                    { new Guid("fcf59565-e4c1-47e3-ad4e-1fff994f2c8d"), 26, new Guid("48c7da8d-d4cd-48e4-838a-7cdf57a3dbf8"), 16.14099513903227, "B-9", 2 },
                    { new Guid("febc0f5d-f371-4dc4-9c5a-e1cb25eb063b"), 15, new Guid("b5df6745-d30b-4691-ae16-7477184cd22b"), 6.1819410739568115, "C-12", 0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ParkingSpaces_ParkingLotId",
                table: "ParkingSpaces",
                column: "ParkingLotId");

            migrationBuilder.CreateIndex(
                name: "IX_RefreshTokens_UserId",
                table: "RefreshTokens",
                column: "UserId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "ParkingSpaces");

            migrationBuilder.DropTable(
                name: "RefreshTokens");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "ParkingLots");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
