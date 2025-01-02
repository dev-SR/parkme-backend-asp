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
                    Longitude = table.Column<double>(type: "REAL", nullable: false),
                    Latitude = table.Column<double>(type: "REAL", nullable: false)
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
                    VehicleType = table.Column<string>(type: "TEXT", nullable: false),
                    Capacity = table.Column<int>(type: "INTEGER", nullable: false),
                    PricePerHour = table.Column<int>(type: "INTEGER", nullable: false),
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
                    { "6012500d-cedb-40ba-a452-53aa1c846c52", null, "User", "USER" },
                    { "d54d3b27-30ae-488c-871c-5826c9679dce", null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "ParkingLots",
                columns: new[] { "Id", "Address", "Description", "Latitude", "Longitude", "Name" },
                values: new object[,]
                {
                    { new Guid("0172c101-551e-458d-ad5e-4dc766c71318"), "23914 Ward Haven, Frederickview, Bahrain", "Harum labore quia nobis incidunt aut corrupti maiores aut debitis.", 23.901969056765701, 89.128734566096398, "Kreiger and Sons" },
                    { new Guid("139406c3-9839-4b7b-bbca-4d40cb86dfe3"), "8217 Maria Trafficway, West Samaraport, Mozambique", "Et aut quia magnam.", 23.741837646267591, 90.391849413150382, "Rau - Quitzon" },
                    { new Guid("13e0dfe0-5eac-4777-8ea3-7eb029491fb4"), "8304 Wiza Radial, North Curtstad, Ukraine", "A sint maiores sapiente doloremque.", 23.891193202822588, 89.141021580526711, "Beer LLC" },
                    { new Guid("3281ace4-5746-4068-8cc4-2a2bd011f8fa"), "8041 Donnie Passage, East Solonbury, Montenegro", "Et blanditiis quis aspernatur.", 23.754479865340159, 90.438196552407234, "Borer - Nicolas" },
                    { new Guid("445c7c0a-7a09-4028-b08e-7360cf4b1369"), "274 Willms Lights, Violatown, Comoros", "Aut dicta neque repellendus tempore iste exercitationem debitis repellendus.", 23.739473610583165, 90.355776024743818, "Johnston - Wuckert" },
                    { new Guid("4904751b-1a15-45a1-a1ab-dcdfe0eeda95"), "6614 Rutherford Avenue, Port Rey, Congo", "Facere vel atque molestias maiores dolor ut iusto.", 23.759017799885253, 90.375942982587532, "Hessel Group" },
                    { new Guid("59b98f97-d4c7-48dd-901d-68adaab4994b"), "61144 Maddison Walks, Russelchester, Denmark", "Perferendis dolorem qui possimus illo.", 23.763629939587005, 90.42218834065153, "Dooley Inc" },
                    { new Guid("61c9ce1f-b4ee-49e4-ad17-334d2b2db138"), "23424 Alexys Summit, Lake Gwendolyn, Turks and Caicos Islands", "Repudiandae a dignissimos.", 23.891457009395459, 89.131104963351419, "Bailey - D'Amore" },
                    { new Guid("64289b3d-1a5b-463e-a560-93ffbf693bd6"), "1707 Salma Walk, Port Astrid, Tuvalu", "Voluptatem eos amet ipsa qui similique sit.", 23.900753343601696, 89.098318725078599, "Kautzer and Sons" },
                    { new Guid("73b52805-ee3d-4d5e-a7d9-600a892a17f3"), "1534 Hodkiewicz Forges, Hazletown, Gambia", "Consequatur temporibus et a et est id dignissimos.", 23.904779150376335, 89.154724066092015, "Mante - Boehm" },
                    { new Guid("76f09f6b-2c3f-4ddb-8adf-0f36ee949c17"), "1944 Kurtis Views, Hazleview, Latvia", "A veritatis eveniet labore tenetur velit qui corrupti nulla.", 23.763870912795518, 90.448954858863843, "Kovacek - Bernhard" },
                    { new Guid("7719d308-09f3-4734-98fd-575b7493c6f7"), "49327 Daniela Vista, Champlinton, Liberia", "Laudantium eos mollitia accusantium id sed voluptatem nostrum.", 23.901025699738035, 89.154110956221373, "Miller, Dietrich and Buckridge" },
                    { new Guid("866fad0d-10f4-415f-af7a-3cbbf0b47b5e"), "683 Gutkowski Villages, North Doug, Uzbekistan", "Dolorem id ex.", 23.732884894441217, 90.418988988463468, "Runolfsdottir, Ankunding and Bernhard" },
                    { new Guid("86ab2717-5459-43fc-8140-52282f04870c"), "264 Gusikowski Route, New Kaylee, Tanzania", "Qui illo autem deserunt aut aut magni at.", 23.886076285307173, 89.135409407287781, "Donnelly - Cole" },
                    { new Guid("86c389d1-85f8-48f7-8668-a71fff93ed92"), "7688 Bogan Summit, Buckridgeberg, Venezuela", "Earum delectus consequatur non earum voluptatem veritatis.", 23.898183963633816, 89.147198474443755, "Olson and Sons" },
                    { new Guid("988200fa-90db-4fe7-b936-c3e77a0a4177"), "63126 Langworth Rapids, Kesslerberg, British Indian Ocean Territory (Chagos Archipelago)", "Veniam possimus molestiae veritatis deleniti est et facilis.", 23.758622802901044, 90.357376907496644, "Schulist and Sons" },
                    { new Guid("9d97d88d-b910-4d05-8b73-cf547236ebb9"), "27650 Stanton Walk, North Jesse, Rwanda", "Labore laudantium sed et consequuntur ut dignissimos sed repellendus.", 23.744623304691064, 90.451755202708242, "Keeling and Sons" },
                    { new Guid("a2704293-efbd-4a54-85e4-3d9884921bb7"), "54420 Orion Expressway, Port Harrison, Israel", "Mollitia maxime eos ab blanditiis facere eum.", 23.770720194626392, 90.384040799667858, "Walsh, Wiegand and Keeling" },
                    { new Guid("a27f8946-24b1-4872-bcff-af56d425e764"), "9832 Selina Springs, Kshlerinchester, Ukraine", "Cupiditate impedit ut laudantium a exercitationem et expedita.", 23.743396294983235, 90.441444164453443, "Greenholt Inc" },
                    { new Guid("a5e7342e-cf74-4886-b5a8-cb918c71b193"), "897 Ozella Points, Hermanland, Togo", "Eaque non perspiciatis reprehenderit et.", 23.883922106037883, 89.157514997272941, "Hoeger - Bahringer" },
                    { new Guid("abce056e-eb75-4d49-9f85-73f17ff0bc12"), "89519 Nitzsche Ridge, Hackettton, Taiwan", "Sed harum ut qui quis officia.", 23.905273965553182, 89.142959768211242, "Windler LLC" },
                    { new Guid("b7bab51f-45c0-4231-aaee-c08c76b77dcc"), "99190 Chase Key, Roobville, Kazakhstan", "Expedita architecto laudantium amet ratione rerum nobis hic est architecto.", 23.899766810304435, 89.129226602671721, "Konopelski Group" },
                    { new Guid("bd8ae708-e890-45d8-8f71-9a67d52194df"), "615 Letha Spring, West Candida, Chile", "Voluptatem adipisci ullam impedit perspiciatis molestiae.", 23.897821323884944, 89.157936265188766, "Wiza - Kozey" },
                    { new Guid("cf66f5d8-db62-477c-a1e5-5052331c7076"), "63819 Cummings Ways, Treutelfort, Guinea-Bissau", "Nesciunt ab ipsa perspiciatis et maxime voluptates modi.", 23.746040678365418, 90.419100391787211, "Casper Inc" },
                    { new Guid("dda5efcc-4b45-42b3-9f1e-418ced4e2f02"), "248 Stoltenberg Key, South Agnesbury, Morocco", "Nihil suscipit nisi cum eveniet.", 23.901119343954505, 89.150110198121368, "Hudson - Nicolas" },
                    { new Guid("e197306c-4464-415d-bc76-a4c711b02791"), "151 Doyle Park, East Audreanneland, Reunion", "Quia ullam eum voluptatum vel facilis tenetur cupiditate enim.", 23.770445231415888, 90.36327606981483, "Kutch - Hyatt" },
                    { new Guid("e625751d-553c-46c0-b10b-6ff1239eb152"), "569 Cordelia Fords, West Vladimirhaven, Uganda", "Velit illum quam qui error voluptas autem labore magni et.", 23.893852569518398, 89.096186946273008, "Hoppe - Parker" },
                    { new Guid("f346adfb-32a1-40d9-a5be-cb0e77e8c6bc"), "413 Moen Track, McDermottland, Kyrgyz Republic", "Ut et dolores quis fuga quod.", 23.750842518473533, 90.362046833173807, "Blick, Ryan and Schowalter" },
                    { new Guid("f53e9bac-18d3-4f91-8cc3-23bbd4c2202f"), "8792 Swaniawski Land, East River, Bahrain", "Eaque sunt culpa nihil consequatur possimus voluptatem perspiciatis.", 23.893322281006906, 89.116005293145889, "Gibson Group" },
                    { new Guid("fa5037da-e3bc-4432-ace5-70c5db8d7c8c"), "1718 Fahey Trace, Jackytown, Afghanistan", "Excepturi dignissimos eum.", 23.733415456752216, 90.434519230234329, "Daniel, Hand and Daugherty" }
                });

            migrationBuilder.InsertData(
                table: "ParkingSpaces",
                columns: new[] { "Id", "Capacity", "ParkingLotId", "PricePerHour", "SectionName", "VehicleType" },
                values: new object[,]
                {
                    { new Guid("040f8f50-5e8e-472a-9314-7e3f19bb51ea"), 39, new Guid("73b52805-ee3d-4d5e-a7d9-600a892a17f3"), 500, "D-2", "TRUCK" },
                    { new Guid("041f00a0-0224-43f5-9610-64e52de0faf5"), 39, new Guid("4904751b-1a15-45a1-a1ab-dcdfe0eeda95"), 100, "B-3", "TRUCK" },
                    { new Guid("05a5bcb7-cee2-4ac4-9fda-df13b7f2d2a1"), 39, new Guid("73b52805-ee3d-4d5e-a7d9-600a892a17f3"), 150, "D-16", "TRUCK" },
                    { new Guid("08764a3b-8fee-48ba-86d7-7a8c8232a825"), 11, new Guid("7719d308-09f3-4734-98fd-575b7493c6f7"), 100, "A-15", "TRUCK" },
                    { new Guid("087a3920-bca6-4ddd-9232-39d04e6caacc"), 37, new Guid("a2704293-efbd-4a54-85e4-3d9884921bb7"), 200, "D-2", "CAR" },
                    { new Guid("08a0941f-5162-4251-bebc-28720d5ed2f5"), 14, new Guid("b7bab51f-45c0-4231-aaee-c08c76b77dcc"), 150, "A-18", "MOTORCYCLE" },
                    { new Guid("1122c289-87bb-4f33-a005-f1cad642588b"), 11, new Guid("fa5037da-e3bc-4432-ace5-70c5db8d7c8c"), 200, "B-10", "CAR" },
                    { new Guid("144ffd92-ab07-48ae-831f-1e3376106af5"), 50, new Guid("86c389d1-85f8-48f7-8668-a71fff93ed92"), 100, "C-16", "TRUCK" },
                    { new Guid("186cf141-dfe7-420b-9cdf-8ffc32f60150"), 46, new Guid("abce056e-eb75-4d49-9f85-73f17ff0bc12"), 200, "D-7", "CAR" },
                    { new Guid("1979f296-5fad-4903-aa0f-79c39773f2cb"), 17, new Guid("13e0dfe0-5eac-4777-8ea3-7eb029491fb4"), 300, "A-15", "TRUCK" },
                    { new Guid("1983628d-5b81-4cba-8a99-a8a568f6747e"), 18, new Guid("e197306c-4464-415d-bc76-a4c711b02791"), 500, "D-13", "TRUCK" },
                    { new Guid("1c2dc280-0c05-474b-a024-d053fbdaf574"), 45, new Guid("13e0dfe0-5eac-4777-8ea3-7eb029491fb4"), 300, "C-14", "MOTORCYCLE" },
                    { new Guid("216c1def-1e3b-4ca8-babb-dec1156a3c26"), 23, new Guid("a2704293-efbd-4a54-85e4-3d9884921bb7"), 500, "A-14", "MOTORCYCLE" },
                    { new Guid("223351d4-ddb5-469e-93ce-500df7ecd371"), 21, new Guid("dda5efcc-4b45-42b3-9f1e-418ced4e2f02"), 500, "A-4", "TRUCK" },
                    { new Guid("29c791e9-0841-40a7-a092-0aa2b6ade445"), 16, new Guid("b7bab51f-45c0-4231-aaee-c08c76b77dcc"), 300, "B-7", "TRUCK" },
                    { new Guid("3028198a-d1a8-440d-9a08-26782c51a79d"), 46, new Guid("988200fa-90db-4fe7-b936-c3e77a0a4177"), 100, "C-12", "TRUCK" },
                    { new Guid("336cbd44-a0b5-4f85-bfd7-4c4286eb6374"), 34, new Guid("7719d308-09f3-4734-98fd-575b7493c6f7"), 200, "A-18", "CAR" },
                    { new Guid("33d3efbf-a916-48bb-b42a-2892abf6b7d1"), 26, new Guid("a5e7342e-cf74-4886-b5a8-cb918c71b193"), 500, "C-12", "CAR" },
                    { new Guid("35f10dbf-0832-4db7-981e-10d6018b8b5d"), 50, new Guid("139406c3-9839-4b7b-bbca-4d40cb86dfe3"), 150, "B-14", "MOTORCYCLE" },
                    { new Guid("36a9e684-0406-4929-994f-bddd913c9e12"), 16, new Guid("4904751b-1a15-45a1-a1ab-dcdfe0eeda95"), 500, "A-1", "TRUCK" },
                    { new Guid("3a24866b-dd8f-4f14-92d3-3f698f04f782"), 21, new Guid("a2704293-efbd-4a54-85e4-3d9884921bb7"), 100, "D-13", "MOTORCYCLE" },
                    { new Guid("3e23a9ef-2f19-43d3-99e4-0f2aa87d8cc5"), 39, new Guid("988200fa-90db-4fe7-b936-c3e77a0a4177"), 150, "A-17", "CAR" },
                    { new Guid("3ed9d122-2376-4d52-a3b8-aeed887b550c"), 32, new Guid("13e0dfe0-5eac-4777-8ea3-7eb029491fb4"), 200, "B-10", "TRUCK" },
                    { new Guid("43ad7d45-c7b6-4d3a-bf50-6b0fb77a4037"), 25, new Guid("73b52805-ee3d-4d5e-a7d9-600a892a17f3"), 150, "C-10", "TRUCK" },
                    { new Guid("46535a26-a524-43ff-8e2d-83d0edf00900"), 35, new Guid("988200fa-90db-4fe7-b936-c3e77a0a4177"), 150, "B-3", "CAR" },
                    { new Guid("481d837e-2db5-42ea-a9a3-474de26b587f"), 38, new Guid("13e0dfe0-5eac-4777-8ea3-7eb029491fb4"), 150, "B-9", "CAR" },
                    { new Guid("4c1b3c97-9674-442c-84fa-d157ef04c036"), 31, new Guid("a5e7342e-cf74-4886-b5a8-cb918c71b193"), 200, "D-9", "MOTORCYCLE" },
                    { new Guid("5b2a747b-f4f6-4293-9aa2-fbc5530af963"), 47, new Guid("b7bab51f-45c0-4231-aaee-c08c76b77dcc"), 500, "B-1", "CAR" },
                    { new Guid("5b3be4a8-dd8b-4fde-ab69-d1f615b22070"), 46, new Guid("e625751d-553c-46c0-b10b-6ff1239eb152"), 200, "D-11", "TRUCK" },
                    { new Guid("5e7d1776-cd72-4e7c-9f66-de5f635827ef"), 14, new Guid("fa5037da-e3bc-4432-ace5-70c5db8d7c8c"), 300, "B-18", "MOTORCYCLE" },
                    { new Guid("6257af59-9dfa-4d0e-987e-9fc2ab109481"), 41, new Guid("61c9ce1f-b4ee-49e4-ad17-334d2b2db138"), 300, "A-4", "MOTORCYCLE" },
                    { new Guid("63ccb230-54d5-4f63-ab6b-a7b6c5ac793f"), 17, new Guid("e197306c-4464-415d-bc76-a4c711b02791"), 100, "C-15", "TRUCK" },
                    { new Guid("65e4be9f-3300-404b-a946-675f54aa4f36"), 17, new Guid("7719d308-09f3-4734-98fd-575b7493c6f7"), 200, "C-5", "CAR" },
                    { new Guid("672dbb5b-3c60-4bd3-93f5-2090bcb35ff7"), 33, new Guid("bd8ae708-e890-45d8-8f71-9a67d52194df"), 150, "B-17", "TRUCK" },
                    { new Guid("674b54c1-5f8e-4e36-9f99-078d6ac5d67c"), 50, new Guid("4904751b-1a15-45a1-a1ab-dcdfe0eeda95"), 200, "C-2", "MOTORCYCLE" },
                    { new Guid("68c2e7b3-8163-4a13-8fc9-fae4aafd2670"), 39, new Guid("86ab2717-5459-43fc-8140-52282f04870c"), 200, "B-14", "CAR" },
                    { new Guid("6bf09931-ff51-4c96-bfd0-83a0b218cd40"), 27, new Guid("988200fa-90db-4fe7-b936-c3e77a0a4177"), 200, "D-4", "MOTORCYCLE" },
                    { new Guid("6ca43c8e-134d-4a18-9c2d-09660191865e"), 19, new Guid("f346adfb-32a1-40d9-a5be-cb0e77e8c6bc"), 150, "C-10", "CAR" },
                    { new Guid("6efa9c0a-d13e-4835-8d31-7b1dc2c67929"), 41, new Guid("3281ace4-5746-4068-8cc4-2a2bd011f8fa"), 150, "D-10", "TRUCK" },
                    { new Guid("70af49c0-8cf3-4457-b8c5-74c567eae80d"), 39, new Guid("64289b3d-1a5b-463e-a560-93ffbf693bd6"), 100, "B-15", "MOTORCYCLE" },
                    { new Guid("77188b84-4864-43c3-8c2f-b552c073bee3"), 18, new Guid("3281ace4-5746-4068-8cc4-2a2bd011f8fa"), 500, "B-14", "MOTORCYCLE" },
                    { new Guid("7b91867f-3fe0-4b9e-9457-d839d47092e7"), 39, new Guid("86ab2717-5459-43fc-8140-52282f04870c"), 200, "A-6", "MOTORCYCLE" },
                    { new Guid("7c06afcc-3763-45b9-b5cc-65f610610c49"), 36, new Guid("4904751b-1a15-45a1-a1ab-dcdfe0eeda95"), 300, "B-16", "TRUCK" },
                    { new Guid("7ffaa177-f850-4f7b-8129-dc94c9854b26"), 42, new Guid("4904751b-1a15-45a1-a1ab-dcdfe0eeda95"), 500, "A-16", "MOTORCYCLE" },
                    { new Guid("80c97962-f52d-4081-8c95-2372140a5117"), 35, new Guid("73b52805-ee3d-4d5e-a7d9-600a892a17f3"), 300, "C-4", "MOTORCYCLE" },
                    { new Guid("815b9f6a-764e-4d82-bf2b-34c5961c0243"), 28, new Guid("61c9ce1f-b4ee-49e4-ad17-334d2b2db138"), 200, "C-3", "CAR" },
                    { new Guid("8b9f098c-aaa6-46f7-a080-d2d22df2d32a"), 21, new Guid("a27f8946-24b1-4872-bcff-af56d425e764"), 100, "B-2", "CAR" },
                    { new Guid("8e6b2c81-03ea-470c-865c-c52635e9d91d"), 30, new Guid("f53e9bac-18d3-4f91-8cc3-23bbd4c2202f"), 100, "D-18", "MOTORCYCLE" },
                    { new Guid("92853e84-e149-46a0-b8ba-70158c287a9f"), 21, new Guid("e197306c-4464-415d-bc76-a4c711b02791"), 500, "A-5", "CAR" },
                    { new Guid("9562d554-a0bb-42a1-9823-d92671dedd86"), 33, new Guid("61c9ce1f-b4ee-49e4-ad17-334d2b2db138"), 500, "A-17", "MOTORCYCLE" },
                    { new Guid("9582bb3a-fb6b-4180-8f5c-864b700ae745"), 44, new Guid("59b98f97-d4c7-48dd-901d-68adaab4994b"), 100, "A-15", "MOTORCYCLE" },
                    { new Guid("989a40e2-f78f-438d-95fb-3606d615ce12"), 17, new Guid("13e0dfe0-5eac-4777-8ea3-7eb029491fb4"), 500, "C-9", "CAR" },
                    { new Guid("9c33b6ff-ee08-4a60-800c-d2f5304824cb"), 44, new Guid("cf66f5d8-db62-477c-a1e5-5052331c7076"), 100, "C-14", "MOTORCYCLE" },
                    { new Guid("9df752f0-a871-4d7e-ada8-b30d3867af91"), 27, new Guid("a27f8946-24b1-4872-bcff-af56d425e764"), 300, "C-9", "TRUCK" },
                    { new Guid("a859a30c-c873-4d51-8c09-9aa4af1c9114"), 41, new Guid("fa5037da-e3bc-4432-ace5-70c5db8d7c8c"), 500, "B-8", "TRUCK" },
                    { new Guid("ab1dc41b-51cc-46f4-ae8c-c455052dce3b"), 44, new Guid("9d97d88d-b910-4d05-8b73-cf547236ebb9"), 500, "B-6", "TRUCK" },
                    { new Guid("ada19218-5d79-44c4-87fa-c84afe90f081"), 39, new Guid("64289b3d-1a5b-463e-a560-93ffbf693bd6"), 500, "B-1", "TRUCK" },
                    { new Guid("adaa0c3a-c3b8-4806-b6f0-461635182c92"), 31, new Guid("a27f8946-24b1-4872-bcff-af56d425e764"), 300, "D-9", "TRUCK" },
                    { new Guid("af9c836e-0f02-48e1-964c-750a520448d5"), 45, new Guid("fa5037da-e3bc-4432-ace5-70c5db8d7c8c"), 150, "A-5", "TRUCK" },
                    { new Guid("b198b273-d76d-4f03-b9fb-e380548d0074"), 12, new Guid("9d97d88d-b910-4d05-8b73-cf547236ebb9"), 300, "A-3", "CAR" },
                    { new Guid("b1d847e3-c95c-4e03-8e4b-7841c405dda3"), 34, new Guid("13e0dfe0-5eac-4777-8ea3-7eb029491fb4"), 150, "A-18", "MOTORCYCLE" },
                    { new Guid("b5fb5ae8-a485-47d0-811f-b8ae26389493"), 36, new Guid("86c389d1-85f8-48f7-8668-a71fff93ed92"), 100, "C-1", "MOTORCYCLE" },
                    { new Guid("b744e8c9-1a98-4e68-ab7f-bb497b6722e9"), 39, new Guid("4904751b-1a15-45a1-a1ab-dcdfe0eeda95"), 100, "C-9", "MOTORCYCLE" },
                    { new Guid("bb2fb330-5fb0-4e8f-8448-a1806be8cd09"), 31, new Guid("139406c3-9839-4b7b-bbca-4d40cb86dfe3"), 100, "C-4", "TRUCK" },
                    { new Guid("bea46713-7c47-4fdd-8844-21caaf1812f9"), 11, new Guid("64289b3d-1a5b-463e-a560-93ffbf693bd6"), 100, "B-9", "MOTORCYCLE" },
                    { new Guid("c4c38539-7437-43b6-b082-3e878a4142e5"), 15, new Guid("cf66f5d8-db62-477c-a1e5-5052331c7076"), 500, "D-9", "MOTORCYCLE" },
                    { new Guid("c4f6d5c0-d844-4383-a0e6-5b5c5e1d2cca"), 49, new Guid("0172c101-551e-458d-ad5e-4dc766c71318"), 500, "B-5", "CAR" },
                    { new Guid("c718c356-22d6-42bb-a987-fc46412c18fc"), 44, new Guid("a2704293-efbd-4a54-85e4-3d9884921bb7"), 500, "B-20", "MOTORCYCLE" },
                    { new Guid("cd3d49f7-7f9a-455c-ba54-840d631c8f23"), 40, new Guid("a2704293-efbd-4a54-85e4-3d9884921bb7"), 500, "C-8", "TRUCK" },
                    { new Guid("ce5ec044-cccb-4a86-bdae-ab275982adea"), 25, new Guid("61c9ce1f-b4ee-49e4-ad17-334d2b2db138"), 300, "C-1", "TRUCK" },
                    { new Guid("d1d56aee-ffe6-44b0-b0a8-ca1392301935"), 16, new Guid("86c389d1-85f8-48f7-8668-a71fff93ed92"), 300, "B-18", "TRUCK" },
                    { new Guid("d258f8d1-a725-48cc-949f-785026a2beb0"), 30, new Guid("4904751b-1a15-45a1-a1ab-dcdfe0eeda95"), 500, "C-10", "CAR" },
                    { new Guid("d3737b42-5f0e-4a8e-95a8-7b3c172ccaa7"), 13, new Guid("9d97d88d-b910-4d05-8b73-cf547236ebb9"), 100, "C-15", "MOTORCYCLE" },
                    { new Guid("d3816d2b-c970-4510-add0-cf253ad13282"), 27, new Guid("f53e9bac-18d3-4f91-8cc3-23bbd4c2202f"), 100, "B-18", "TRUCK" },
                    { new Guid("deee6b25-678d-4f96-9ca5-d1ec751e883b"), 11, new Guid("b7bab51f-45c0-4231-aaee-c08c76b77dcc"), 150, "A-19", "CAR" },
                    { new Guid("e03f5be1-0c15-4972-b19f-09c80ade936a"), 45, new Guid("fa5037da-e3bc-4432-ace5-70c5db8d7c8c"), 500, "D-11", "MOTORCYCLE" },
                    { new Guid("e33150d6-0711-4997-b734-e7db312e0b5f"), 27, new Guid("f53e9bac-18d3-4f91-8cc3-23bbd4c2202f"), 150, "D-16", "CAR" },
                    { new Guid("e50fc53a-31ab-4419-acd7-427ec5e5eb60"), 20, new Guid("e625751d-553c-46c0-b10b-6ff1239eb152"), 100, "D-6", "MOTORCYCLE" },
                    { new Guid("e6852ca0-f593-4ac6-be46-c10f65807216"), 44, new Guid("988200fa-90db-4fe7-b936-c3e77a0a4177"), 500, "C-9", "MOTORCYCLE" },
                    { new Guid("ea7175bf-e5eb-4e8c-91ce-f8bd86e39f4d"), 45, new Guid("e625751d-553c-46c0-b10b-6ff1239eb152"), 300, "B-17", "TRUCK" },
                    { new Guid("ed4d2606-2861-4fe4-b360-19e74778e44f"), 36, new Guid("cf66f5d8-db62-477c-a1e5-5052331c7076"), 300, "D-11", "MOTORCYCLE" },
                    { new Guid("ed9e12ed-81ff-43b9-a4dd-02de6c856a51"), 39, new Guid("988200fa-90db-4fe7-b936-c3e77a0a4177"), 150, "B-6", "CAR" },
                    { new Guid("eda201c1-cf7e-4fa4-ac8d-795061641b57"), 22, new Guid("139406c3-9839-4b7b-bbca-4d40cb86dfe3"), 150, "A-19", "MOTORCYCLE" },
                    { new Guid("eefb01e9-97a2-4e5e-997b-2cb410eaf0cc"), 17, new Guid("59b98f97-d4c7-48dd-901d-68adaab4994b"), 300, "D-11", "TRUCK" },
                    { new Guid("ef74ac10-5309-4e7a-88d2-06588239a4a7"), 41, new Guid("86ab2717-5459-43fc-8140-52282f04870c"), 150, "B-8", "TRUCK" },
                    { new Guid("f35b6727-463b-4719-962a-ecc1775413ee"), 10, new Guid("a5e7342e-cf74-4886-b5a8-cb918c71b193"), 500, "C-6", "CAR" },
                    { new Guid("f36cec52-ca5e-43d1-ac89-1b781dc29473"), 47, new Guid("988200fa-90db-4fe7-b936-c3e77a0a4177"), 100, "A-4", "CAR" },
                    { new Guid("f4a94b1a-7f49-4edc-ae90-aa7b39def8d5"), 49, new Guid("4904751b-1a15-45a1-a1ab-dcdfe0eeda95"), 100, "A-17", "CAR" },
                    { new Guid("fd57a9f1-0907-45ef-bb1d-3927de73b6e0"), 37, new Guid("abce056e-eb75-4d49-9f85-73f17ff0bc12"), 100, "B-19", "MOTORCYCLE" },
                    { new Guid("fff3039d-5806-42e6-bb39-6666543d566f"), 31, new Guid("e625751d-553c-46c0-b10b-6ff1239eb152"), 300, "A-1", "CAR" }
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
