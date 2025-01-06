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
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
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
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
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
                    RoleId = table.Column<Guid>(type: "TEXT", nullable: false),
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
                    UserId = table.Column<Guid>(type: "TEXT", nullable: false),
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
                    UserId = table.Column<Guid>(type: "TEXT", nullable: false)
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
                    UserId = table.Column<Guid>(type: "TEXT", nullable: false),
                    RoleId = table.Column<Guid>(type: "TEXT", nullable: false)
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
                    UserId = table.Column<Guid>(type: "TEXT", nullable: false),
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
                    UserId = table.Column<Guid>(type: "TEXT", nullable: false)
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
                    VehicleType = table.Column<string>(type: "TEXT", nullable: false),
                    SectionName = table.Column<string>(type: "TEXT", nullable: false),
                    SpotNumber = table.Column<int>(type: "INTEGER", nullable: false),
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

            migrationBuilder.CreateTable(
                name: "Bookings",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    PricePerHour = table.Column<double>(type: "REAL", nullable: false),
                    TotalPrice = table.Column<double>(type: "REAL", nullable: false),
                    VehicleNumber = table.Column<string>(type: "TEXT", nullable: false),
                    PhoneNumber = table.Column<string>(type: "TEXT", nullable: true),
                    Passcode = table.Column<string>(type: "TEXT", nullable: false),
                    Status = table.Column<string>(type: "TEXT", nullable: false),
                    StripePaymentSessionId = table.Column<string>(type: "TEXT", nullable: true),
                    StartDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    EndDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UserId = table.Column<Guid>(type: "TEXT", nullable: false),
                    ParkingSpaceId = table.Column<Guid>(type: "TEXT", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bookings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bookings_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Bookings_ParkingSpaces_ParkingSpaceId",
                        column: x => x.ParkingSpaceId,
                        principalTable: "ParkingSpaces",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TimeLines",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    BookingId = table.Column<Guid>(type: "TEXT", nullable: false),
                    TimeLineValue = table.Column<int>(type: "INTEGER", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TimeLines", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TimeLines_Bookings_BookingId",
                        column: x => x.BookingId,
                        principalTable: "Bookings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("1b71f336-8d78-406e-b7ad-e2567aa50d5f"), null, "User", "USER" },
                    { new Guid("6e10c4e9-fdaa-479f-b4fa-b508b5ee9ebd"), null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "ParkingLots",
                columns: new[] { "Id", "Address", "Description", "Latitude", "Longitude", "Name" },
                values: new object[,]
                {
                    { new Guid("0300e2e8-5324-4e9e-a263-b6e21ef522e1"), "19297 Raheem Estate, Lake Jenamouth, Oman", "Officiis vero soluta nisi id.", 23.896634933217793, 89.123834949357445, "Altenwerth Inc" },
                    { new Guid("05edf7de-d320-4f8d-a1e3-b0bc2e39542b"), "34886 Jaren Mountain, South Jess, Japan", "Est placeat impedit beatae reprehenderit sit ea.", 23.910180043004473, 89.101931404537353, "Stoltenberg - Little" },
                    { new Guid("062da560-f045-4060-96ba-f55f018f22fa"), "1175 Dooley Coves, New Adelinefort, Aruba", "Provident nulla architecto aperiam qui sapiente ex.", 23.886335475184872, 89.158265689325248, "Ruecker Inc" },
                    { new Guid("177e5403-7253-460d-9dad-1fe45da5084f"), "55892 Sherman Lodge, Lake Josuefort, Australia", "Adipisci nisi adipisci autem veniam et quibusdam quae.", 23.892947587563977, 89.105299137256623, "Bosco Inc" },
                    { new Guid("222dabdc-8eb6-438f-9420-1718acb4ac98"), "55277 Maryse Drive, Runolfsdottirberg, Saint Martin", "Et ut ex quasi explicabo quo sed eius.", 23.888729591143413, 89.154376934238172, "Larkin LLC" },
                    { new Guid("2fdc4e40-1753-4bad-b51b-879103cb8e6c"), "599 Wolff View, Kiehnside, Senegal", "Earum quia tempore magnam.", 23.737179753534274, 90.380898926617846, "Thompson - Runte" },
                    { new Guid("31c01a3b-3f2b-49a4-acc5-01f815ede550"), "2722 Perry Corners, Beahanburgh, Bouvet Island (Bouvetoya)", "Laboriosam optio sit eligendi qui illo iure et doloremque nesciunt.", 23.888424980349349, 89.126124284864076, "Roob - Davis" },
                    { new Guid("35bd00fe-9bed-4685-babf-544508a6bd3f"), "5403 Winfield Ports, East Jazlynfurt, Philippines", "Cumque dolorem quis excepturi deserunt.", 23.754686639733482, 90.423720592127594, "Murphy - Marquardt" },
                    { new Guid("389a4fe1-99bb-4993-adb6-62b343d955f0"), "67884 Brooke Rapid, Kingport, Norfolk Island", "Rerum enim tempore quae a cupiditate.", 23.885125196532901, 89.13564849814631, "Armstrong, Bauch and Harris" },
                    { new Guid("3e9cd60c-04e9-4f3b-9fad-93c221bc30c7"), "137 Elsa Plaza, New Erickstad, Palau", "Vel ea et.", 23.88652858517592, 89.14986710096224, "Durgan, Cummings and Haag" },
                    { new Guid("438c734f-725d-4a35-85e7-f03b07c10532"), "64075 Stamm Land, Eugeniahaven, Nepal", "Sapiente rerum et mollitia.", 23.763884511728701, 90.452171863615945, "Krajcik Inc" },
                    { new Guid("54038a10-6c7a-43c0-ae3c-378099c88c64"), "80350 Pacocha Walks, Arielport, Christmas Island", "Corporis dicta laudantium nemo aliquid odit cum debitis beatae.", 23.732824234370408, 90.375044122949618, "Jenkins LLC" },
                    { new Guid("5475a577-b9b7-452a-8870-915408c3bf05"), "081 Effertz Vista, West Jules, Poland", "Deserunt at nihil voluptatem sint sit aspernatur est enim.", 23.756317788121446, 90.372532717842716, "Walker - Schuster" },
                    { new Guid("7dfcc8b1-a83c-4aee-8987-a86828f6f257"), "66093 Morissette Shoals, Mireilleland, Holy See (Vatican City State)", "Eligendi et odio.", 23.887387998811715, 89.115049698974957, "Maggio, Lang and Denesik" },
                    { new Guid("815ac24d-d4c7-4f3c-bacb-01f4a5f6fd3b"), "210 Hills Plains, South Telly, Iran", "Nemo omnis commodi dolorem et necessitatibus dicta.", 23.905831492072416, 89.144250679820956, "Zboncak, Simonis and Gibson" },
                    { new Guid("84ec85e1-8d2a-48f1-a31c-051d5d584b18"), "8211 Vallie Camp, Dachbury, Turkey", "Quo soluta mollitia quos.", 23.763059035602353, 90.370589592527523, "Collier, Bayer and Sawayn" },
                    { new Guid("9e3ab747-8a77-4857-9d94-5165e0ab019c"), "5835 Reginald Field, North Ocie, Albania", "Quia recusandae accusamus a autem autem qui blanditiis.", 23.895556929943158, 89.115228355525574, "Hagenes - Rath" },
                    { new Guid("abc2aa0f-084c-4c16-b0f2-42767da7c8da"), "76555 Friesen Bridge, North Giuseppetown, Trinidad and Tobago", "Ducimus minus quia atque nobis quo et consectetur velit.", 23.781494412747215, 90.358589041493303, "Goodwin LLC" },
                    { new Guid("b2a1ee4a-9bbb-4f49-ac21-74c45a404e3b"), "6088 Frederique Landing, Reichertstad, Slovenia", "Dolor consequatur accusamus aut saepe consequatur.", 23.758626698027278, 90.430972195532902, "Rolfson Inc" },
                    { new Guid("b5008c91-0712-4873-ad29-295924447837"), "97808 O'Reilly Row, South Francesmouth, Chile", "Eum nisi et non iure.", 23.896301549353311, 89.115466444534448, "Bode - Schaefer" },
                    { new Guid("b78c84be-608a-4dce-a721-fe98e12baab4"), "0235 Idella Manor, North Mauricioland, Netherlands", "Ut fugit sapiente non omnis quia quibusdam dolores.", 23.885275751058114, 89.152331684972921, "Kirlin - Hodkiewicz" },
                    { new Guid("b88bc938-52c1-436d-94bf-d654fbdc7a04"), "278 Goldner Cliffs, Skilesmouth, Micronesia", "Libero sunt voluptatem doloremque cumque inventore sit pariatur.", 23.89680957751818, 89.151685191843256, "Smitham Inc" },
                    { new Guid("c25adb05-f5ba-4e26-b1d2-d5fca4802f14"), "478 Clement Valley, Torphyborough, Palestinian Territory", "Sint delectus aspernatur eum voluptas rem.", 23.9027019708181, 89.11603471936948, "Kohler, King and Orn" },
                    { new Guid("ca2d3a26-8813-4f14-a2f7-7a716b06183c"), "23569 Langworth Parks, Romaguerashire, Finland", "Incidunt praesentium eius sapiente ut.", 23.760960893794998, 90.377788624588163, "Graham - Orn" },
                    { new Guid("dd1ab61b-6f46-4fce-8cc9-cd2100b6cbd5"), "739 Nestor Highway, Kaitlyntown, Qatar", "Labore et facilis.", 23.765724120369459, 90.404881262433392, "Wisozk, Marks and Farrell" },
                    { new Guid("f1e09b0f-06a8-43f9-a77a-7d4eee6443ba"), "4289 Jesse Way, East Johanna, Monaco", "Fugit cupiditate inventore in quae.", 23.76469484283378, 90.341475356680135, "Okuneva and Sons" },
                    { new Guid("f6167eba-a93b-408c-9e6f-04e70262a3f1"), "6278 Antoinette Creek, Lake Aaron, United States of America", "Voluptates corporis enim perferendis praesentium.", 23.771448696029914, 90.418600409910653, "Prohaska LLC" },
                    { new Guid("f7d9e1df-23cb-4664-9b6c-e8ae239afc92"), "40628 Keira Viaduct, Pricebury, Armenia", "Quia rerum quis qui iure in.", 23.742170478256998, 90.402063565128529, "Lueilwitz LLC" },
                    { new Guid("fae37de9-614b-4f66-affa-db74f60ee387"), "3562 Eleanora Falls, West Lewisview, Slovenia", "Fugit veritatis labore.", 23.755548423297142, 90.403656911213659, "Simonis, Ratke and Bruen" },
                    { new Guid("ff466904-5b83-454f-9ff1-99266e4a60a1"), "238 Bins Vista, South Orlandville, Cocos (Keeling) Islands", "Sit in aliquam in aut fugiat voluptatibus.", 23.772114186861728, 90.444967144738527, "Mitchell, Heathcote and Bogisich" }
                });

            migrationBuilder.InsertData(
                table: "ParkingSpaces",
                columns: new[] { "Id", "ParkingLotId", "PricePerHour", "SectionName", "SpotNumber", "VehicleType" },
                values: new object[,]
                {
                    { new Guid("00c324f2-7fca-48db-baf7-183de6be98b6"), new Guid("84ec85e1-8d2a-48f1-a31c-051d5d584b18"), 100.0, "B", 5, "CAR" },
                    { new Guid("02370277-a482-4246-b5da-7659b63334ec"), new Guid("062da560-f045-4060-96ba-f55f018f22fa"), 200.0, "A", 1, "VAN" },
                    { new Guid("024a9196-810d-4550-9cee-568c9c13c269"), new Guid("062da560-f045-4060-96ba-f55f018f22fa"), 200.0, "A", 3, "VAN" },
                    { new Guid("027ad036-f4eb-4119-b013-4e1cdb101a8e"), new Guid("31c01a3b-3f2b-49a4-acc5-01f815ede550"), 300.0, "A", 4, "TRUCK" },
                    { new Guid("029f0f46-112d-4382-85f8-55289702fc2f"), new Guid("389a4fe1-99bb-4993-adb6-62b343d955f0"), 300.0, "A", 2, "TRUCK" },
                    { new Guid("031aea9e-214d-48f3-bb5d-85bd9418c3eb"), new Guid("05edf7de-d320-4f8d-a1e3-b0bc2e39542b"), 50.0, "B", 4, "MOTORCYCLE" },
                    { new Guid("0497e33f-1406-41d9-9679-07c4f6e040a9"), new Guid("7dfcc8b1-a83c-4aee-8987-a86828f6f257"), 50.0, "B", 7, "MOTORCYCLE" },
                    { new Guid("06d5b378-c29b-4b99-8351-38646652ae7b"), new Guid("062da560-f045-4060-96ba-f55f018f22fa"), 50.0, "B", 2, "MOTORCYCLE" },
                    { new Guid("06f03e40-9654-4b6c-b0f5-01e552bc5aac"), new Guid("dd1ab61b-6f46-4fce-8cc9-cd2100b6cbd5"), 100.0, "B", 6, "CAR" },
                    { new Guid("07cf3455-3b3b-49be-9594-8b4e512f654a"), new Guid("f7d9e1df-23cb-4664-9b6c-e8ae239afc92"), 100.0, "A", 6, "CAR" },
                    { new Guid("0800ceed-e1c5-4fa3-bd89-77c318d7ecb6"), new Guid("9e3ab747-8a77-4857-9d94-5165e0ab019c"), 200.0, "A", 6, "VAN" },
                    { new Guid("09046519-6f0f-454c-bc20-dbbab3e89948"), new Guid("7dfcc8b1-a83c-4aee-8987-a86828f6f257"), 100.0, "A", 2, "CAR" },
                    { new Guid("0a9c3365-1b5d-43d6-8536-3fe247384f24"), new Guid("05edf7de-d320-4f8d-a1e3-b0bc2e39542b"), 50.0, "B", 5, "MOTORCYCLE" },
                    { new Guid("0b46474a-28f1-4059-8e50-767ff1a15464"), new Guid("3e9cd60c-04e9-4f3b-9fad-93c221bc30c7"), 200.0, "B", 5, "VAN" },
                    { new Guid("0bcbc8ce-eb93-4665-8b1c-40c0a6df4e77"), new Guid("fae37de9-614b-4f66-affa-db74f60ee387"), 100.0, "B", 5, "CAR" },
                    { new Guid("0c8ad5da-e0f5-4a78-9b2a-7e56ab0ce28b"), new Guid("222dabdc-8eb6-438f-9420-1718acb4ac98"), 300.0, "B", 8, "TRUCK" },
                    { new Guid("0d27fdb4-3014-43ce-b8ed-26bf6c438875"), new Guid("177e5403-7253-460d-9dad-1fe45da5084f"), 200.0, "B", 5, "VAN" },
                    { new Guid("0d538fe8-9713-41b1-ac80-6e2ce87bd38c"), new Guid("f1e09b0f-06a8-43f9-a77a-7d4eee6443ba"), 50.0, "B", 1, "MOTORCYCLE" },
                    { new Guid("0d921981-4067-49e8-bc15-aa31465de0e0"), new Guid("b78c84be-608a-4dce-a721-fe98e12baab4"), 300.0, "A", 1, "TRUCK" },
                    { new Guid("0dc5b0a1-c492-493e-b9d3-b663a17deae6"), new Guid("ff466904-5b83-454f-9ff1-99266e4a60a1"), 50.0, "A", 3, "MOTORCYCLE" },
                    { new Guid("0e2660cf-2dd9-4127-8efc-b5aef3e21163"), new Guid("062da560-f045-4060-96ba-f55f018f22fa"), 200.0, "A", 4, "VAN" },
                    { new Guid("0fa8bbc7-18b4-46d8-8f6b-957b6b4b530b"), new Guid("f1e09b0f-06a8-43f9-a77a-7d4eee6443ba"), 200.0, "A", 5, "VAN" },
                    { new Guid("101b2ec7-5cb7-4081-8ab9-8d355a3f6790"), new Guid("fae37de9-614b-4f66-affa-db74f60ee387"), 300.0, "A", 3, "TRUCK" },
                    { new Guid("10445594-fa1a-4e7d-aa7a-86bd9c70df4f"), new Guid("ca2d3a26-8813-4f14-a2f7-7a716b06183c"), 200.0, "B", 7, "VAN" },
                    { new Guid("1188ab2a-2dc1-4dbf-b688-de26462c793c"), new Guid("b78c84be-608a-4dce-a721-fe98e12baab4"), 300.0, "A", 7, "TRUCK" },
                    { new Guid("12219006-4f09-4a34-bbef-04a1020811e7"), new Guid("815ac24d-d4c7-4f3c-bacb-01f4a5f6fd3b"), 100.0, "A", 6, "CAR" },
                    { new Guid("12389285-63da-450e-89bd-1bf5e79468dc"), new Guid("062da560-f045-4060-96ba-f55f018f22fa"), 50.0, "B", 6, "MOTORCYCLE" },
                    { new Guid("12df1204-c9e2-4972-ae96-2616af795f6a"), new Guid("ff466904-5b83-454f-9ff1-99266e4a60a1"), 50.0, "A", 1, "MOTORCYCLE" },
                    { new Guid("12e3a946-eac7-422b-ad25-7368d5eb9abb"), new Guid("f7d9e1df-23cb-4664-9b6c-e8ae239afc92"), 50.0, "B", 7, "MOTORCYCLE" },
                    { new Guid("1430ff78-8940-4bbc-83ad-d95111981009"), new Guid("b2a1ee4a-9bbb-4f49-ac21-74c45a404e3b"), 200.0, "A", 7, "VAN" },
                    { new Guid("1468d8f5-096a-4e5e-a6b6-3647b74c0de4"), new Guid("54038a10-6c7a-43c0-ae3c-378099c88c64"), 50.0, "B", 1, "MOTORCYCLE" },
                    { new Guid("14dd0092-b49d-4604-99bc-b66d8c5b21c3"), new Guid("7dfcc8b1-a83c-4aee-8987-a86828f6f257"), 50.0, "B", 3, "MOTORCYCLE" },
                    { new Guid("15057f2c-4562-444f-86d2-f1d27b9ed415"), new Guid("abc2aa0f-084c-4c16-b0f2-42767da7c8da"), 300.0, "B", 4, "TRUCK" },
                    { new Guid("1525b88a-9a91-4d39-a2cb-7ae28f87f30e"), new Guid("b88bc938-52c1-436d-94bf-d654fbdc7a04"), 50.0, "B", 7, "MOTORCYCLE" },
                    { new Guid("1556cd2f-28de-44ac-b4e5-d70938194e4a"), new Guid("ff466904-5b83-454f-9ff1-99266e4a60a1"), 200.0, "B", 2, "VAN" },
                    { new Guid("17b69cfe-2468-47b6-95c9-288b434bec7c"), new Guid("3e9cd60c-04e9-4f3b-9fad-93c221bc30c7"), 300.0, "A", 2, "TRUCK" },
                    { new Guid("191d81f2-6bf2-485c-ac08-75c11fd789e9"), new Guid("ca2d3a26-8813-4f14-a2f7-7a716b06183c"), 100.0, "A", 2, "CAR" },
                    { new Guid("1939100a-ceab-41ab-9e97-6e8a5793b928"), new Guid("fae37de9-614b-4f66-affa-db74f60ee387"), 300.0, "A", 8, "TRUCK" },
                    { new Guid("19477444-9a23-46d8-8f5e-99afa149437f"), new Guid("35bd00fe-9bed-4685-babf-544508a6bd3f"), 200.0, "A", 1, "VAN" },
                    { new Guid("1ad6a4b4-bc25-460c-9bed-f931c108395f"), new Guid("35bd00fe-9bed-4685-babf-544508a6bd3f"), 200.0, "A", 3, "VAN" },
                    { new Guid("1c814f48-4033-4a27-b22b-ebb4ed2e9865"), new Guid("389a4fe1-99bb-4993-adb6-62b343d955f0"), 300.0, "A", 3, "TRUCK" },
                    { new Guid("1cedeeed-23dc-43f7-8f90-c67b4e1bafe0"), new Guid("0300e2e8-5324-4e9e-a263-b6e21ef522e1"), 200.0, "A", 8, "VAN" },
                    { new Guid("1cf5352d-49b3-4724-9415-4c8c98a0b146"), new Guid("f7d9e1df-23cb-4664-9b6c-e8ae239afc92"), 50.0, "B", 8, "MOTORCYCLE" },
                    { new Guid("1d5a432f-4c9b-49d4-b82b-3a5e5e620065"), new Guid("222dabdc-8eb6-438f-9420-1718acb4ac98"), 200.0, "A", 6, "VAN" },
                    { new Guid("1d754cbc-f16c-4dfc-a83f-f5ebe233bd39"), new Guid("815ac24d-d4c7-4f3c-bacb-01f4a5f6fd3b"), 100.0, "A", 2, "CAR" },
                    { new Guid("1db28e2f-d475-4ffc-98b3-ce7d18bf7de9"), new Guid("389a4fe1-99bb-4993-adb6-62b343d955f0"), 300.0, "A", 7, "TRUCK" },
                    { new Guid("1e349a6f-0677-4a19-ba76-8d8deb18d22a"), new Guid("177e5403-7253-460d-9dad-1fe45da5084f"), 100.0, "A", 1, "CAR" },
                    { new Guid("1e5d8ced-f728-4b6d-abe9-d5fe016ba3fe"), new Guid("ca2d3a26-8813-4f14-a2f7-7a716b06183c"), 200.0, "B", 2, "VAN" },
                    { new Guid("1e957bca-05de-456f-876e-31ea83fd0e58"), new Guid("05edf7de-d320-4f8d-a1e3-b0bc2e39542b"), 300.0, "A", 8, "TRUCK" },
                    { new Guid("1ed906f7-ac6b-4bcd-add0-11859b45800a"), new Guid("abc2aa0f-084c-4c16-b0f2-42767da7c8da"), 300.0, "B", 6, "TRUCK" },
                    { new Guid("1f0e2931-67f1-46b9-a6dd-027988f713e8"), new Guid("222dabdc-8eb6-438f-9420-1718acb4ac98"), 200.0, "A", 2, "VAN" },
                    { new Guid("20628392-5d44-484b-ac81-4cdab8d7359e"), new Guid("fae37de9-614b-4f66-affa-db74f60ee387"), 100.0, "B", 8, "CAR" },
                    { new Guid("2130c607-a6da-4b5e-b308-c8b1200c682c"), new Guid("31c01a3b-3f2b-49a4-acc5-01f815ede550"), 300.0, "A", 5, "TRUCK" },
                    { new Guid("218c841d-afc4-4cd6-9e61-81fc446f9811"), new Guid("438c734f-725d-4a35-85e7-f03b07c10532"), 100.0, "B", 2, "CAR" },
                    { new Guid("22ff7863-ba91-41c2-b697-67079a96f875"), new Guid("dd1ab61b-6f46-4fce-8cc9-cd2100b6cbd5"), 100.0, "B", 8, "CAR" },
                    { new Guid("2305b381-4ad6-496e-9408-8efb6d104227"), new Guid("438c734f-725d-4a35-85e7-f03b07c10532"), 300.0, "A", 7, "TRUCK" },
                    { new Guid("23590a11-9966-47b3-b45c-00ce1bcf79ed"), new Guid("222dabdc-8eb6-438f-9420-1718acb4ac98"), 300.0, "B", 3, "TRUCK" },
                    { new Guid("23baff5b-82b4-48c8-b90a-78f8c10cf740"), new Guid("0300e2e8-5324-4e9e-a263-b6e21ef522e1"), 200.0, "A", 6, "VAN" },
                    { new Guid("23ef58a0-4ecc-45a1-9927-86db29efa10b"), new Guid("b5008c91-0712-4873-ad29-295924447837"), 50.0, "A", 3, "MOTORCYCLE" },
                    { new Guid("26f4a198-bbdb-4a4f-a4c7-90ed9ba08b4d"), new Guid("f7d9e1df-23cb-4664-9b6c-e8ae239afc92"), 50.0, "B", 1, "MOTORCYCLE" },
                    { new Guid("27399438-20f1-46e1-bda3-0b667c38dae2"), new Guid("fae37de9-614b-4f66-affa-db74f60ee387"), 100.0, "B", 4, "CAR" },
                    { new Guid("274ff7e4-03b8-4d40-837b-a2687268fa95"), new Guid("b2a1ee4a-9bbb-4f49-ac21-74c45a404e3b"), 50.0, "B", 6, "MOTORCYCLE" },
                    { new Guid("280de991-05da-45d5-b73e-a616a1da6c20"), new Guid("abc2aa0f-084c-4c16-b0f2-42767da7c8da"), 300.0, "B", 1, "TRUCK" },
                    { new Guid("29a8cda2-391f-4fde-8744-f335441b1839"), new Guid("9e3ab747-8a77-4857-9d94-5165e0ab019c"), 200.0, "B", 4, "VAN" },
                    { new Guid("29b59a91-043a-4ced-ac30-a019b0724e2a"), new Guid("31c01a3b-3f2b-49a4-acc5-01f815ede550"), 50.0, "B", 2, "MOTORCYCLE" },
                    { new Guid("2a70294b-a706-4c47-b136-c0f40324c5f3"), new Guid("389a4fe1-99bb-4993-adb6-62b343d955f0"), 100.0, "B", 7, "CAR" },
                    { new Guid("2a84cf21-0196-4e8c-8c07-b4ae78ee81d3"), new Guid("f1e09b0f-06a8-43f9-a77a-7d4eee6443ba"), 50.0, "B", 2, "MOTORCYCLE" },
                    { new Guid("2b68cb2d-3489-40d0-aade-c8efff637653"), new Guid("7dfcc8b1-a83c-4aee-8987-a86828f6f257"), 50.0, "B", 5, "MOTORCYCLE" },
                    { new Guid("2b900054-4c49-4c8d-be74-3df759cc5495"), new Guid("35bd00fe-9bed-4685-babf-544508a6bd3f"), 200.0, "A", 5, "VAN" },
                    { new Guid("2bbab291-f4ce-4324-955d-e970670653e8"), new Guid("5475a577-b9b7-452a-8870-915408c3bf05"), 50.0, "B", 6, "MOTORCYCLE" },
                    { new Guid("2c8d1515-1761-4a6c-b1ef-d2550a597df8"), new Guid("b5008c91-0712-4873-ad29-295924447837"), 50.0, "A", 4, "MOTORCYCLE" },
                    { new Guid("2d0e89d6-eb13-41d9-b5e3-d6f3be50ad73"), new Guid("177e5403-7253-460d-9dad-1fe45da5084f"), 100.0, "A", 4, "CAR" },
                    { new Guid("2dc2df92-f6ac-42e4-b1ce-e7dc73b5dd1e"), new Guid("b5008c91-0712-4873-ad29-295924447837"), 50.0, "A", 8, "MOTORCYCLE" },
                    { new Guid("2de6b57a-e331-4d23-abca-ba784e6df264"), new Guid("2fdc4e40-1753-4bad-b51b-879103cb8e6c"), 50.0, "A", 1, "MOTORCYCLE" },
                    { new Guid("2e5fbc53-8469-4cd3-be43-3cebba7d8009"), new Guid("f1e09b0f-06a8-43f9-a77a-7d4eee6443ba"), 50.0, "B", 3, "MOTORCYCLE" },
                    { new Guid("2e9c28a6-6a27-46ba-919b-d7d062724e13"), new Guid("222dabdc-8eb6-438f-9420-1718acb4ac98"), 300.0, "B", 1, "TRUCK" },
                    { new Guid("2ef5f24c-4258-428f-bf4a-276978cbe945"), new Guid("b78c84be-608a-4dce-a721-fe98e12baab4"), 300.0, "B", 6, "TRUCK" },
                    { new Guid("3004a590-a6ac-4825-a9b3-efabfbd116f0"), new Guid("9e3ab747-8a77-4857-9d94-5165e0ab019c"), 200.0, "A", 1, "VAN" },
                    { new Guid("3099ded0-4413-413b-b049-f9bb00588aca"), new Guid("31c01a3b-3f2b-49a4-acc5-01f815ede550"), 300.0, "A", 7, "TRUCK" },
                    { new Guid("30bf64b0-ca2d-4c53-8337-047631864511"), new Guid("5475a577-b9b7-452a-8870-915408c3bf05"), 100.0, "A", 7, "CAR" },
                    { new Guid("30da0ade-014c-423b-a82d-3fc432597169"), new Guid("5475a577-b9b7-452a-8870-915408c3bf05"), 100.0, "A", 2, "CAR" },
                    { new Guid("30f74389-9d73-459f-a4ac-775f07983e8a"), new Guid("dd1ab61b-6f46-4fce-8cc9-cd2100b6cbd5"), 100.0, "B", 1, "CAR" },
                    { new Guid("31523450-5ebb-4a84-894e-46dca834c179"), new Guid("3e9cd60c-04e9-4f3b-9fad-93c221bc30c7"), 300.0, "A", 7, "TRUCK" },
                    { new Guid("31722878-76d6-450f-a20b-670e2d926bfc"), new Guid("062da560-f045-4060-96ba-f55f018f22fa"), 200.0, "A", 6, "VAN" },
                    { new Guid("317f2c97-9636-49d4-94f6-596ac567e8fc"), new Guid("84ec85e1-8d2a-48f1-a31c-051d5d584b18"), 100.0, "A", 6, "CAR" },
                    { new Guid("322f379c-2a40-4578-8eda-43d2a7713566"), new Guid("35bd00fe-9bed-4685-babf-544508a6bd3f"), 200.0, "A", 7, "VAN" },
                    { new Guid("33306c5e-37bc-45f3-a88b-64da0dd45301"), new Guid("84ec85e1-8d2a-48f1-a31c-051d5d584b18"), 100.0, "A", 3, "CAR" },
                    { new Guid("3368ba92-139e-4f8d-bf8a-75ea62423a56"), new Guid("815ac24d-d4c7-4f3c-bacb-01f4a5f6fd3b"), 100.0, "A", 4, "CAR" },
                    { new Guid("33c8b17d-212b-462f-b20e-6476f010263f"), new Guid("5475a577-b9b7-452a-8870-915408c3bf05"), 50.0, "B", 4, "MOTORCYCLE" },
                    { new Guid("33cf9ee6-634b-43c4-bc66-88955fa338e8"), new Guid("f1e09b0f-06a8-43f9-a77a-7d4eee6443ba"), 200.0, "A", 4, "VAN" },
                    { new Guid("33e9ef8d-30d9-4df0-956d-3fdaace21b50"), new Guid("abc2aa0f-084c-4c16-b0f2-42767da7c8da"), 300.0, "B", 5, "TRUCK" },
                    { new Guid("3409e206-4b3c-4fa0-9512-5a9bc781874b"), new Guid("b88bc938-52c1-436d-94bf-d654fbdc7a04"), 200.0, "A", 8, "VAN" },
                    { new Guid("348cc3b7-faff-4e88-b60e-864d28fb2c9e"), new Guid("177e5403-7253-460d-9dad-1fe45da5084f"), 100.0, "A", 2, "CAR" },
                    { new Guid("35d6a617-98d3-4b07-9b57-f78d0f49c8f8"), new Guid("f1e09b0f-06a8-43f9-a77a-7d4eee6443ba"), 200.0, "A", 1, "VAN" },
                    { new Guid("35fd37a8-cdfe-4e13-9d0a-ac4f62f9582e"), new Guid("f6167eba-a93b-408c-9e6f-04e70262a3f1"), 100.0, "B", 4, "CAR" },
                    { new Guid("36b3ab32-b9eb-4a14-8107-3bad475005e8"), new Guid("abc2aa0f-084c-4c16-b0f2-42767da7c8da"), 50.0, "A", 1, "MOTORCYCLE" },
                    { new Guid("377f28dd-14cd-4c43-a508-ff04fc9ff0b9"), new Guid("3e9cd60c-04e9-4f3b-9fad-93c221bc30c7"), 200.0, "B", 8, "VAN" },
                    { new Guid("37eebac9-225a-46ab-868a-f50e3ff8ebfb"), new Guid("dd1ab61b-6f46-4fce-8cc9-cd2100b6cbd5"), 200.0, "A", 7, "VAN" },
                    { new Guid("3846819c-5d6d-4e19-9d67-9d49e275b88a"), new Guid("fae37de9-614b-4f66-affa-db74f60ee387"), 100.0, "B", 3, "CAR" },
                    { new Guid("387d9dc4-1a5d-4075-a6a7-77f0b2727f48"), new Guid("9e3ab747-8a77-4857-9d94-5165e0ab019c"), 200.0, "B", 8, "VAN" },
                    { new Guid("38b3f863-249c-4b88-ac15-e46f79e0bcea"), new Guid("84ec85e1-8d2a-48f1-a31c-051d5d584b18"), 100.0, "A", 1, "CAR" },
                    { new Guid("38f4fdf9-bedb-4a9b-be3c-fa5d8a5615e0"), new Guid("f6167eba-a93b-408c-9e6f-04e70262a3f1"), 100.0, "A", 4, "CAR" },
                    { new Guid("3946a6a7-2028-4b59-92b9-52e62664a15d"), new Guid("3e9cd60c-04e9-4f3b-9fad-93c221bc30c7"), 300.0, "A", 1, "TRUCK" },
                    { new Guid("397327d1-fc67-4ac6-90d6-c872a753c55b"), new Guid("b78c84be-608a-4dce-a721-fe98e12baab4"), 300.0, "B", 2, "TRUCK" },
                    { new Guid("397cceaa-c8eb-4980-8a1c-3913c655c66d"), new Guid("35bd00fe-9bed-4685-babf-544508a6bd3f"), 200.0, "A", 2, "VAN" },
                    { new Guid("3ab5b1fb-1398-4c06-9003-431b0678f02b"), new Guid("438c734f-725d-4a35-85e7-f03b07c10532"), 300.0, "A", 6, "TRUCK" },
                    { new Guid("3b5fc1ec-18ad-4960-8034-e84cc34e6105"), new Guid("2fdc4e40-1753-4bad-b51b-879103cb8e6c"), 50.0, "B", 4, "MOTORCYCLE" },
                    { new Guid("3bbffba7-0ca2-4a6a-9f3e-538068b98d73"), new Guid("222dabdc-8eb6-438f-9420-1718acb4ac98"), 300.0, "B", 4, "TRUCK" },
                    { new Guid("3c4320ed-6854-465e-9ab4-7601a0ce998e"), new Guid("389a4fe1-99bb-4993-adb6-62b343d955f0"), 100.0, "B", 4, "CAR" },
                    { new Guid("3d21f190-1be7-4d53-b82d-4b6a3996fd94"), new Guid("b88bc938-52c1-436d-94bf-d654fbdc7a04"), 50.0, "B", 1, "MOTORCYCLE" },
                    { new Guid("3d7f58cd-5103-4572-88ad-71bd762ddd25"), new Guid("7dfcc8b1-a83c-4aee-8987-a86828f6f257"), 100.0, "A", 1, "CAR" },
                    { new Guid("3dec4272-ca99-4e2f-9029-b7891c626138"), new Guid("438c734f-725d-4a35-85e7-f03b07c10532"), 300.0, "A", 4, "TRUCK" },
                    { new Guid("3e0972ac-50f3-4e41-8fb1-05780ecfd7ca"), new Guid("2fdc4e40-1753-4bad-b51b-879103cb8e6c"), 50.0, "A", 4, "MOTORCYCLE" },
                    { new Guid("3e332684-d597-4561-892a-271a4b2b75a6"), new Guid("84ec85e1-8d2a-48f1-a31c-051d5d584b18"), 100.0, "B", 7, "CAR" },
                    { new Guid("3e4b83ff-a4cb-4100-8c65-250d43af7bc6"), new Guid("5475a577-b9b7-452a-8870-915408c3bf05"), 50.0, "B", 2, "MOTORCYCLE" },
                    { new Guid("3ec1714b-0438-4b9c-9a31-2e33be51d15c"), new Guid("815ac24d-d4c7-4f3c-bacb-01f4a5f6fd3b"), 100.0, "A", 1, "CAR" },
                    { new Guid("3f8c7748-606e-41c6-bb07-ed02826de27d"), new Guid("5475a577-b9b7-452a-8870-915408c3bf05"), 50.0, "B", 8, "MOTORCYCLE" },
                    { new Guid("3fcf7f44-ad5f-426e-b1d1-f6e75c5a9b80"), new Guid("7dfcc8b1-a83c-4aee-8987-a86828f6f257"), 50.0, "B", 1, "MOTORCYCLE" },
                    { new Guid("3ff8689c-dbb1-414a-be8d-039a5378a72c"), new Guid("b2a1ee4a-9bbb-4f49-ac21-74c45a404e3b"), 50.0, "B", 8, "MOTORCYCLE" },
                    { new Guid("4005951a-6cb5-4c0e-9589-6e1a0a4a0634"), new Guid("2fdc4e40-1753-4bad-b51b-879103cb8e6c"), 50.0, "A", 5, "MOTORCYCLE" },
                    { new Guid("4136b289-2338-42ad-8bf0-238111ebd40e"), new Guid("ff466904-5b83-454f-9ff1-99266e4a60a1"), 50.0, "A", 5, "MOTORCYCLE" },
                    { new Guid("41ed9eb2-bb58-4997-a126-e9b000b2647d"), new Guid("c25adb05-f5ba-4e26-b1d2-d5fca4802f14"), 300.0, "A", 2, "TRUCK" },
                    { new Guid("42137b6f-4bed-486c-bd88-9b314e0b7364"), new Guid("c25adb05-f5ba-4e26-b1d2-d5fca4802f14"), 300.0, "A", 3, "TRUCK" },
                    { new Guid("42215a64-11ff-403d-b24c-4e17cba5fc90"), new Guid("b78c84be-608a-4dce-a721-fe98e12baab4"), 300.0, "A", 4, "TRUCK" },
                    { new Guid("42ccd9af-78b9-4bdb-941d-148b21f1845f"), new Guid("54038a10-6c7a-43c0-ae3c-378099c88c64"), 100.0, "A", 5, "CAR" },
                    { new Guid("43dd24a4-8f6e-4b1c-99a0-74c289b27e0b"), new Guid("fae37de9-614b-4f66-affa-db74f60ee387"), 300.0, "A", 7, "TRUCK" },
                    { new Guid("443ab09a-6152-43de-987a-e2772413b355"), new Guid("b5008c91-0712-4873-ad29-295924447837"), 50.0, "A", 7, "MOTORCYCLE" },
                    { new Guid("444e34d0-113c-461b-9dc8-3de2c0355051"), new Guid("389a4fe1-99bb-4993-adb6-62b343d955f0"), 100.0, "B", 6, "CAR" },
                    { new Guid("44b2344e-1591-4021-910e-6b050f3b3e95"), new Guid("2fdc4e40-1753-4bad-b51b-879103cb8e6c"), 50.0, "A", 6, "MOTORCYCLE" },
                    { new Guid("451c659f-a7bf-4351-9617-b6cec9416e99"), new Guid("dd1ab61b-6f46-4fce-8cc9-cd2100b6cbd5"), 100.0, "B", 5, "CAR" },
                    { new Guid("45703739-bbf5-42dd-b9e3-12ce83a4fb74"), new Guid("fae37de9-614b-4f66-affa-db74f60ee387"), 100.0, "B", 1, "CAR" },
                    { new Guid("45ba068f-fc22-45a7-97ff-39128783f2f9"), new Guid("ff466904-5b83-454f-9ff1-99266e4a60a1"), 200.0, "B", 4, "VAN" },
                    { new Guid("46585aec-f8be-41ec-a0a1-892b61494bc0"), new Guid("ca2d3a26-8813-4f14-a2f7-7a716b06183c"), 100.0, "A", 1, "CAR" },
                    { new Guid("46593eb7-0d0d-4ec3-8518-33a30b4e6469"), new Guid("2fdc4e40-1753-4bad-b51b-879103cb8e6c"), 50.0, "B", 3, "MOTORCYCLE" },
                    { new Guid("46f20298-4106-482a-9c18-b197e51b7af5"), new Guid("2fdc4e40-1753-4bad-b51b-879103cb8e6c"), 50.0, "A", 7, "MOTORCYCLE" },
                    { new Guid("4744c04a-caab-49c3-8f11-f1524c4876cf"), new Guid("84ec85e1-8d2a-48f1-a31c-051d5d584b18"), 100.0, "A", 5, "CAR" },
                    { new Guid("477a5eec-571e-42b6-bf67-10f3a94bc648"), new Guid("177e5403-7253-460d-9dad-1fe45da5084f"), 100.0, "A", 5, "CAR" },
                    { new Guid("48536d4f-a7ab-4795-9fac-7f7c58c25eaa"), new Guid("05edf7de-d320-4f8d-a1e3-b0bc2e39542b"), 50.0, "B", 6, "MOTORCYCLE" },
                    { new Guid("48cb7c77-ed98-45ab-b08e-6d9fc1ffd646"), new Guid("9e3ab747-8a77-4857-9d94-5165e0ab019c"), 200.0, "B", 2, "VAN" },
                    { new Guid("49e6a98b-c7e2-4754-a5e0-8d364cfa3d3e"), new Guid("54038a10-6c7a-43c0-ae3c-378099c88c64"), 100.0, "A", 1, "CAR" },
                    { new Guid("49ee4e1a-491c-4dc6-833d-bcb31d6d128f"), new Guid("062da560-f045-4060-96ba-f55f018f22fa"), 50.0, "B", 8, "MOTORCYCLE" },
                    { new Guid("4a6a1373-a7ab-45c0-8e33-f3db9a8516c3"), new Guid("ff466904-5b83-454f-9ff1-99266e4a60a1"), 50.0, "A", 7, "MOTORCYCLE" },
                    { new Guid("4a6b6d0c-fafb-4c30-b975-99c804851177"), new Guid("7dfcc8b1-a83c-4aee-8987-a86828f6f257"), 50.0, "B", 2, "MOTORCYCLE" },
                    { new Guid("4b139e34-76dd-40d2-8374-acab96dcdbc6"), new Guid("fae37de9-614b-4f66-affa-db74f60ee387"), 300.0, "A", 1, "TRUCK" },
                    { new Guid("4b74cfef-7b6b-4c21-8b8e-099ee288cbfb"), new Guid("5475a577-b9b7-452a-8870-915408c3bf05"), 50.0, "B", 1, "MOTORCYCLE" },
                    { new Guid("4bb9af21-1f66-46c9-ae07-899e5a9fcbc2"), new Guid("84ec85e1-8d2a-48f1-a31c-051d5d584b18"), 100.0, "B", 2, "CAR" },
                    { new Guid("4ca2c352-e10b-48ea-a459-7766aa286843"), new Guid("f1e09b0f-06a8-43f9-a77a-7d4eee6443ba"), 50.0, "B", 6, "MOTORCYCLE" },
                    { new Guid("4d959419-d42f-4417-9168-abcaff689d63"), new Guid("54038a10-6c7a-43c0-ae3c-378099c88c64"), 50.0, "B", 8, "MOTORCYCLE" },
                    { new Guid("4da3b1b5-6216-4acc-8497-7064c11b20ca"), new Guid("b5008c91-0712-4873-ad29-295924447837"), 50.0, "B", 7, "MOTORCYCLE" },
                    { new Guid("4dab9f27-3247-4d17-8456-a11377dcc96f"), new Guid("f1e09b0f-06a8-43f9-a77a-7d4eee6443ba"), 200.0, "A", 6, "VAN" },
                    { new Guid("4e3ac898-200c-46df-a3ce-aa8314a38093"), new Guid("c25adb05-f5ba-4e26-b1d2-d5fca4802f14"), 300.0, "A", 7, "TRUCK" },
                    { new Guid("4eccec02-c483-43d1-9f8a-ac2081fac040"), new Guid("31c01a3b-3f2b-49a4-acc5-01f815ede550"), 300.0, "A", 3, "TRUCK" },
                    { new Guid("4f5cef8e-fafa-4c0f-a527-a70e710e0e87"), new Guid("35bd00fe-9bed-4685-babf-544508a6bd3f"), 200.0, "A", 6, "VAN" },
                    { new Guid("4f954aad-0408-4bf6-8bea-273755d4d79d"), new Guid("9e3ab747-8a77-4857-9d94-5165e0ab019c"), 200.0, "B", 1, "VAN" },
                    { new Guid("4f9a8d34-5f73-4d73-851c-7bc72b84d03f"), new Guid("abc2aa0f-084c-4c16-b0f2-42767da7c8da"), 50.0, "A", 6, "MOTORCYCLE" },
                    { new Guid("4faeab61-45f8-4734-a9b2-b1b83932d36b"), new Guid("b78c84be-608a-4dce-a721-fe98e12baab4"), 300.0, "B", 8, "TRUCK" },
                    { new Guid("4fc0244d-95e8-46a3-a08f-e0e47687fde7"), new Guid("7dfcc8b1-a83c-4aee-8987-a86828f6f257"), 100.0, "A", 3, "CAR" },
                    { new Guid("501f7de6-45bc-4896-8029-3e9c43acfbad"), new Guid("438c734f-725d-4a35-85e7-f03b07c10532"), 100.0, "B", 6, "CAR" },
                    { new Guid("50924325-6398-454a-93c8-73ada7ba16e3"), new Guid("54038a10-6c7a-43c0-ae3c-378099c88c64"), 100.0, "A", 7, "CAR" },
                    { new Guid("514fdabf-6db4-4bb4-9f65-50c393f40373"), new Guid("b2a1ee4a-9bbb-4f49-ac21-74c45a404e3b"), 200.0, "A", 5, "VAN" },
                    { new Guid("516bb05e-8625-4a18-b77c-454def06f476"), new Guid("062da560-f045-4060-96ba-f55f018f22fa"), 200.0, "A", 5, "VAN" },
                    { new Guid("51b71cad-7f21-4cf5-96df-b98c747421c4"), new Guid("84ec85e1-8d2a-48f1-a31c-051d5d584b18"), 100.0, "B", 6, "CAR" },
                    { new Guid("5282da15-c401-4558-bcae-f5f7d4c5d5ab"), new Guid("2fdc4e40-1753-4bad-b51b-879103cb8e6c"), 50.0, "B", 7, "MOTORCYCLE" },
                    { new Guid("529df007-7bdd-4253-a652-5f3fdebb8bc0"), new Guid("9e3ab747-8a77-4857-9d94-5165e0ab019c"), 200.0, "A", 4, "VAN" },
                    { new Guid("52a70526-5d7b-437c-b0f7-845f1e8eca2d"), new Guid("c25adb05-f5ba-4e26-b1d2-d5fca4802f14"), 300.0, "A", 5, "TRUCK" },
                    { new Guid("52db2e6c-8a05-4015-a72a-a324d5e6b886"), new Guid("f7d9e1df-23cb-4664-9b6c-e8ae239afc92"), 100.0, "A", 5, "CAR" },
                    { new Guid("53f57b2f-58c9-4783-bd52-d5cfcd93683f"), new Guid("062da560-f045-4060-96ba-f55f018f22fa"), 50.0, "B", 4, "MOTORCYCLE" },
                    { new Guid("545caca9-f0f8-4403-b7b6-60967a33088c"), new Guid("0300e2e8-5324-4e9e-a263-b6e21ef522e1"), 300.0, "B", 6, "TRUCK" },
                    { new Guid("54d4fd97-e6c5-4938-9b68-ac7a7e9f6f39"), new Guid("062da560-f045-4060-96ba-f55f018f22fa"), 50.0, "B", 7, "MOTORCYCLE" },
                    { new Guid("5540cec5-4481-4ce7-8b20-2a96d4d8342c"), new Guid("b78c84be-608a-4dce-a721-fe98e12baab4"), 300.0, "B", 5, "TRUCK" },
                    { new Guid("5631acd8-063b-4841-8081-c922afbf062c"), new Guid("815ac24d-d4c7-4f3c-bacb-01f4a5f6fd3b"), 300.0, "B", 6, "TRUCK" },
                    { new Guid("56cd8f8b-3784-419c-987f-9b52d59d8aa4"), new Guid("438c734f-725d-4a35-85e7-f03b07c10532"), 300.0, "A", 2, "TRUCK" },
                    { new Guid("5738c4a0-e26c-457b-a532-b22a4aaa8cfa"), new Guid("f7d9e1df-23cb-4664-9b6c-e8ae239afc92"), 50.0, "B", 5, "MOTORCYCLE" },
                    { new Guid("57eed1da-5284-43d2-815c-0c27843626c9"), new Guid("177e5403-7253-460d-9dad-1fe45da5084f"), 200.0, "B", 1, "VAN" },
                    { new Guid("58815b15-5582-40c8-b67a-4aabe74b986d"), new Guid("54038a10-6c7a-43c0-ae3c-378099c88c64"), 100.0, "A", 6, "CAR" },
                    { new Guid("589a6bbd-7d1b-4407-b415-44dc5916e4ed"), new Guid("54038a10-6c7a-43c0-ae3c-378099c88c64"), 100.0, "A", 8, "CAR" },
                    { new Guid("58ae8f23-8086-4997-94b1-f3726c98a987"), new Guid("b5008c91-0712-4873-ad29-295924447837"), 50.0, "A", 5, "MOTORCYCLE" },
                    { new Guid("58bf5a88-a086-4b64-8658-2a57cd5d03a9"), new Guid("815ac24d-d4c7-4f3c-bacb-01f4a5f6fd3b"), 300.0, "B", 5, "TRUCK" },
                    { new Guid("596cd792-2a7d-469f-8bdf-76742a01a247"), new Guid("9e3ab747-8a77-4857-9d94-5165e0ab019c"), 200.0, "A", 5, "VAN" },
                    { new Guid("5a239c84-d6cc-445d-be5e-ad79a71b6401"), new Guid("84ec85e1-8d2a-48f1-a31c-051d5d584b18"), 100.0, "B", 8, "CAR" },
                    { new Guid("5a5bf324-43aa-4e36-8b1b-86d28cb50a7e"), new Guid("ca2d3a26-8813-4f14-a2f7-7a716b06183c"), 100.0, "A", 7, "CAR" },
                    { new Guid("5a9b46b6-911b-4abb-bce3-861e610e06cb"), new Guid("ff466904-5b83-454f-9ff1-99266e4a60a1"), 200.0, "B", 5, "VAN" },
                    { new Guid("5b518dcd-4ea5-4e3d-afb3-7dbd438fa73c"), new Guid("7dfcc8b1-a83c-4aee-8987-a86828f6f257"), 100.0, "A", 4, "CAR" },
                    { new Guid("5ba1d938-1462-4c41-be07-895783de6453"), new Guid("f1e09b0f-06a8-43f9-a77a-7d4eee6443ba"), 200.0, "A", 2, "VAN" },
                    { new Guid("5c4ecf79-5e93-46fe-8c46-9e6aef33962c"), new Guid("0300e2e8-5324-4e9e-a263-b6e21ef522e1"), 300.0, "B", 7, "TRUCK" },
                    { new Guid("5e029d7f-0a05-4cd6-ae77-429b0573a9ab"), new Guid("05edf7de-d320-4f8d-a1e3-b0bc2e39542b"), 300.0, "A", 6, "TRUCK" },
                    { new Guid("5e282272-4d59-49f7-927d-f0cac18a185a"), new Guid("fae37de9-614b-4f66-affa-db74f60ee387"), 100.0, "B", 2, "CAR" },
                    { new Guid("5e823766-d2d9-49fb-b281-73a6a9eb7669"), new Guid("b5008c91-0712-4873-ad29-295924447837"), 50.0, "B", 2, "MOTORCYCLE" },
                    { new Guid("5eb18cd5-c285-48ac-9e87-f043d49299a5"), new Guid("84ec85e1-8d2a-48f1-a31c-051d5d584b18"), 100.0, "A", 8, "CAR" },
                    { new Guid("5facea20-ada1-4801-90a1-c0382870a7bb"), new Guid("3e9cd60c-04e9-4f3b-9fad-93c221bc30c7"), 300.0, "A", 8, "TRUCK" },
                    { new Guid("6076992d-c42b-4cd4-9d08-3dfacb6343fa"), new Guid("5475a577-b9b7-452a-8870-915408c3bf05"), 50.0, "B", 3, "MOTORCYCLE" },
                    { new Guid("60d788a0-5948-4c39-a086-81e5cb15af2c"), new Guid("31c01a3b-3f2b-49a4-acc5-01f815ede550"), 50.0, "B", 3, "MOTORCYCLE" },
                    { new Guid("6180612d-4d21-4b47-bd13-e7b6e82fed9f"), new Guid("b5008c91-0712-4873-ad29-295924447837"), 50.0, "A", 6, "MOTORCYCLE" },
                    { new Guid("62f3064b-0896-4bd0-8b8d-617f82d06488"), new Guid("0300e2e8-5324-4e9e-a263-b6e21ef522e1"), 200.0, "A", 5, "VAN" },
                    { new Guid("6342184d-d4e8-4eab-a0db-8a59fdb8452a"), new Guid("815ac24d-d4c7-4f3c-bacb-01f4a5f6fd3b"), 300.0, "B", 8, "TRUCK" },
                    { new Guid("63b7298c-96b5-4fb0-bd9d-2abd4e41f865"), new Guid("7dfcc8b1-a83c-4aee-8987-a86828f6f257"), 50.0, "B", 4, "MOTORCYCLE" },
                    { new Guid("63beece2-4e53-40a7-8196-75e6710dec1e"), new Guid("54038a10-6c7a-43c0-ae3c-378099c88c64"), 50.0, "B", 2, "MOTORCYCLE" },
                    { new Guid("644b9b1a-0089-4ea8-adc9-7d3d6495a1d1"), new Guid("dd1ab61b-6f46-4fce-8cc9-cd2100b6cbd5"), 200.0, "A", 1, "VAN" },
                    { new Guid("648e6411-f563-440f-979c-35ff42c6e83d"), new Guid("389a4fe1-99bb-4993-adb6-62b343d955f0"), 100.0, "B", 3, "CAR" },
                    { new Guid("64eba11f-eaa5-4531-a66f-b22cb3af6498"), new Guid("9e3ab747-8a77-4857-9d94-5165e0ab019c"), 200.0, "B", 3, "VAN" },
                    { new Guid("65168d94-8a9a-4cba-b45f-cd56c5ab27ee"), new Guid("31c01a3b-3f2b-49a4-acc5-01f815ede550"), 300.0, "A", 1, "TRUCK" },
                    { new Guid("653351e2-b283-4427-a19c-9b8b60d0f64f"), new Guid("fae37de9-614b-4f66-affa-db74f60ee387"), 300.0, "A", 5, "TRUCK" },
                    { new Guid("655f0e5c-519d-4c3c-8b82-abdb16b73472"), new Guid("35bd00fe-9bed-4685-babf-544508a6bd3f"), 200.0, "B", 4, "VAN" },
                    { new Guid("656cf5ab-437f-4455-820a-94d8c32eb071"), new Guid("438c734f-725d-4a35-85e7-f03b07c10532"), 300.0, "A", 5, "TRUCK" },
                    { new Guid("65dcc0ef-6c77-4737-a791-400f3fdc3c13"), new Guid("b78c84be-608a-4dce-a721-fe98e12baab4"), 300.0, "B", 7, "TRUCK" },
                    { new Guid("66371503-c745-4494-8d91-9f20ced775f0"), new Guid("0300e2e8-5324-4e9e-a263-b6e21ef522e1"), 300.0, "B", 1, "TRUCK" },
                    { new Guid("66444504-3c48-49ae-abec-3face9a30845"), new Guid("438c734f-725d-4a35-85e7-f03b07c10532"), 100.0, "B", 5, "CAR" },
                    { new Guid("67f4bab9-0d84-4dfb-91ff-6d9807861db1"), new Guid("389a4fe1-99bb-4993-adb6-62b343d955f0"), 100.0, "B", 2, "CAR" },
                    { new Guid("6853e4ed-6fff-435b-96dc-4f0ee7f30829"), new Guid("ca2d3a26-8813-4f14-a2f7-7a716b06183c"), 100.0, "A", 3, "CAR" },
                    { new Guid("69c201ef-1221-4e72-b5e1-581bef619545"), new Guid("b88bc938-52c1-436d-94bf-d654fbdc7a04"), 50.0, "B", 8, "MOTORCYCLE" },
                    { new Guid("6a5cbee2-933e-4645-818e-b20858ce4804"), new Guid("b2a1ee4a-9bbb-4f49-ac21-74c45a404e3b"), 200.0, "A", 3, "VAN" },
                    { new Guid("6a829dc7-e4f6-4a5c-8033-002c07a5dae9"), new Guid("05edf7de-d320-4f8d-a1e3-b0bc2e39542b"), 50.0, "B", 3, "MOTORCYCLE" },
                    { new Guid("6b2c5553-9035-48f6-8d65-538b546b97c5"), new Guid("35bd00fe-9bed-4685-babf-544508a6bd3f"), 200.0, "B", 3, "VAN" },
                    { new Guid("6c5c3972-e2e7-4413-8d54-241a0a805af5"), new Guid("f7d9e1df-23cb-4664-9b6c-e8ae239afc92"), 100.0, "A", 2, "CAR" },
                    { new Guid("6cc78055-ff9d-4169-937f-2d0235ff993c"), new Guid("0300e2e8-5324-4e9e-a263-b6e21ef522e1"), 200.0, "A", 1, "VAN" },
                    { new Guid("6cc8123c-25aa-454c-881a-21cef13bc1ab"), new Guid("438c734f-725d-4a35-85e7-f03b07c10532"), 300.0, "A", 3, "TRUCK" },
                    { new Guid("6d327d1a-a8a1-413f-848e-eae0660714f1"), new Guid("389a4fe1-99bb-4993-adb6-62b343d955f0"), 300.0, "A", 5, "TRUCK" },
                    { new Guid("6de18c46-1338-46de-941c-dcb7a5c13bea"), new Guid("177e5403-7253-460d-9dad-1fe45da5084f"), 200.0, "B", 7, "VAN" },
                    { new Guid("6e09d797-b1a9-4df2-b164-14ca456379de"), new Guid("815ac24d-d4c7-4f3c-bacb-01f4a5f6fd3b"), 300.0, "B", 1, "TRUCK" },
                    { new Guid("6f2049f4-018a-41c9-bf04-87bd14056f90"), new Guid("389a4fe1-99bb-4993-adb6-62b343d955f0"), 100.0, "B", 8, "CAR" },
                    { new Guid("6f466f97-bf9b-4b81-ab73-627b9331d778"), new Guid("3e9cd60c-04e9-4f3b-9fad-93c221bc30c7"), 200.0, "B", 3, "VAN" },
                    { new Guid("6f531f0b-6d42-46ff-bd17-f1f2b4b5516d"), new Guid("438c734f-725d-4a35-85e7-f03b07c10532"), 100.0, "B", 4, "CAR" },
                    { new Guid("6f7f419b-59e5-47ee-b153-917aa0e9f308"), new Guid("ca2d3a26-8813-4f14-a2f7-7a716b06183c"), 100.0, "A", 8, "CAR" },
                    { new Guid("702730b5-4418-4a0d-8ab9-16f1289324ba"), new Guid("05edf7de-d320-4f8d-a1e3-b0bc2e39542b"), 300.0, "A", 1, "TRUCK" },
                    { new Guid("702a993f-e113-4a17-ab02-caf9a63087b1"), new Guid("815ac24d-d4c7-4f3c-bacb-01f4a5f6fd3b"), 300.0, "B", 4, "TRUCK" },
                    { new Guid("70859d8c-9f5d-4ca6-976b-94a99618f089"), new Guid("b78c84be-608a-4dce-a721-fe98e12baab4"), 300.0, "A", 3, "TRUCK" },
                    { new Guid("715e2034-b5df-43ce-a4c3-6468aeceff31"), new Guid("ca2d3a26-8813-4f14-a2f7-7a716b06183c"), 200.0, "B", 8, "VAN" },
                    { new Guid("71609479-8e2f-4cdd-8f53-02324cc7c88f"), new Guid("35bd00fe-9bed-4685-babf-544508a6bd3f"), 200.0, "B", 6, "VAN" },
                    { new Guid("71ab188a-a686-4327-acc5-af0a31c9cac5"), new Guid("b88bc938-52c1-436d-94bf-d654fbdc7a04"), 50.0, "B", 2, "MOTORCYCLE" },
                    { new Guid("736d1d2b-562d-472f-92c3-88202241f25f"), new Guid("c25adb05-f5ba-4e26-b1d2-d5fca4802f14"), 200.0, "B", 8, "VAN" },
                    { new Guid("7379fce9-8e39-40c5-9653-ab7968b1d9e1"), new Guid("c25adb05-f5ba-4e26-b1d2-d5fca4802f14"), 200.0, "B", 7, "VAN" },
                    { new Guid("748f092c-cefe-49a9-838a-db6e07bc5c2b"), new Guid("31c01a3b-3f2b-49a4-acc5-01f815ede550"), 300.0, "A", 6, "TRUCK" },
                    { new Guid("750f947a-84a8-42f2-842a-5e6ea69705f3"), new Guid("31c01a3b-3f2b-49a4-acc5-01f815ede550"), 50.0, "B", 4, "MOTORCYCLE" },
                    { new Guid("75a92a7f-d739-4612-9ce3-694023ab59ab"), new Guid("ff466904-5b83-454f-9ff1-99266e4a60a1"), 50.0, "A", 2, "MOTORCYCLE" },
                    { new Guid("75bafac0-5a0a-4cf5-8d2d-987ec5211790"), new Guid("c25adb05-f5ba-4e26-b1d2-d5fca4802f14"), 200.0, "B", 3, "VAN" },
                    { new Guid("75dfa5e9-3f03-4439-9e3f-3ed5a7829e4e"), new Guid("c25adb05-f5ba-4e26-b1d2-d5fca4802f14"), 200.0, "B", 4, "VAN" },
                    { new Guid("76c78369-0f9a-4046-a881-a2fd9646ab5a"), new Guid("c25adb05-f5ba-4e26-b1d2-d5fca4802f14"), 200.0, "B", 1, "VAN" },
                    { new Guid("771f829f-f5ce-42bc-bf55-f30059355dc7"), new Guid("2fdc4e40-1753-4bad-b51b-879103cb8e6c"), 50.0, "B", 6, "MOTORCYCLE" },
                    { new Guid("79a93522-be40-492f-b4be-092d86f1e77a"), new Guid("9e3ab747-8a77-4857-9d94-5165e0ab019c"), 200.0, "A", 2, "VAN" },
                    { new Guid("79f19881-fc3a-46ad-93f2-391e849e5686"), new Guid("b78c84be-608a-4dce-a721-fe98e12baab4"), 300.0, "B", 3, "TRUCK" },
                    { new Guid("7aa3a16a-1de3-4771-bdff-3774b09d80e1"), new Guid("f7d9e1df-23cb-4664-9b6c-e8ae239afc92"), 50.0, "B", 6, "MOTORCYCLE" },
                    { new Guid("7af6a475-b1c3-4370-8773-1f87813cc884"), new Guid("f6167eba-a93b-408c-9e6f-04e70262a3f1"), 100.0, "A", 2, "CAR" },
                    { new Guid("7b5e49df-5f32-4790-9d10-c7e449035cb8"), new Guid("c25adb05-f5ba-4e26-b1d2-d5fca4802f14"), 300.0, "A", 4, "TRUCK" },
                    { new Guid("7b793a1f-8860-470e-bb9e-392c60929d89"), new Guid("0300e2e8-5324-4e9e-a263-b6e21ef522e1"), 300.0, "B", 2, "TRUCK" },
                    { new Guid("7b8b8c05-bba3-46d8-a906-65bb36268454"), new Guid("7dfcc8b1-a83c-4aee-8987-a86828f6f257"), 50.0, "B", 6, "MOTORCYCLE" },
                    { new Guid("7c9bc5e1-916f-4281-8431-ab2fa203c83f"), new Guid("31c01a3b-3f2b-49a4-acc5-01f815ede550"), 300.0, "A", 2, "TRUCK" },
                    { new Guid("7d2e81d0-bead-4bd0-8f0f-187bc990a1eb"), new Guid("05edf7de-d320-4f8d-a1e3-b0bc2e39542b"), 50.0, "B", 8, "MOTORCYCLE" },
                    { new Guid("7d72f37d-cf41-427f-869a-226a03df3418"), new Guid("177e5403-7253-460d-9dad-1fe45da5084f"), 100.0, "A", 3, "CAR" },
                    { new Guid("7d8f42fe-f9b8-4ae1-b63d-ad7d70e31644"), new Guid("f1e09b0f-06a8-43f9-a77a-7d4eee6443ba"), 200.0, "A", 3, "VAN" },
                    { new Guid("7ebf33f9-944e-49f6-8281-9c60e5b7117c"), new Guid("31c01a3b-3f2b-49a4-acc5-01f815ede550"), 50.0, "B", 8, "MOTORCYCLE" },
                    { new Guid("7eec8ed5-14d6-45b9-9d38-dbd12e81aeba"), new Guid("b2a1ee4a-9bbb-4f49-ac21-74c45a404e3b"), 200.0, "A", 2, "VAN" },
                    { new Guid("7f3875f2-b71e-4fc9-917f-1fc8b090d58d"), new Guid("389a4fe1-99bb-4993-adb6-62b343d955f0"), 300.0, "A", 1, "TRUCK" },
                    { new Guid("7fb7e55c-64b6-4406-920a-55b6d3f30785"), new Guid("9e3ab747-8a77-4857-9d94-5165e0ab019c"), 200.0, "A", 8, "VAN" },
                    { new Guid("80747a99-6cd6-4592-87db-662537a5adcd"), new Guid("2fdc4e40-1753-4bad-b51b-879103cb8e6c"), 50.0, "B", 5, "MOTORCYCLE" },
                    { new Guid("80adc868-d247-42a5-a4af-81a61bdbb524"), new Guid("3e9cd60c-04e9-4f3b-9fad-93c221bc30c7"), 300.0, "A", 5, "TRUCK" },
                    { new Guid("813ce443-0304-4296-89b4-1907dd8ad31e"), new Guid("05edf7de-d320-4f8d-a1e3-b0bc2e39542b"), 300.0, "A", 7, "TRUCK" },
                    { new Guid("816402d7-b53b-4cb8-a70f-dedf5486e00e"), new Guid("3e9cd60c-04e9-4f3b-9fad-93c221bc30c7"), 200.0, "B", 4, "VAN" },
                    { new Guid("8192eb04-1f7d-4f25-bba0-20139df74e61"), new Guid("54038a10-6c7a-43c0-ae3c-378099c88c64"), 50.0, "B", 4, "MOTORCYCLE" },
                    { new Guid("839c784c-5225-48b2-80d6-96ffee21e910"), new Guid("dd1ab61b-6f46-4fce-8cc9-cd2100b6cbd5"), 100.0, "B", 4, "CAR" },
                    { new Guid("83a7ea7d-11d2-470d-b4a2-8d26da6b81bc"), new Guid("b5008c91-0712-4873-ad29-295924447837"), 50.0, "B", 8, "MOTORCYCLE" },
                    { new Guid("8426b1fe-e643-4d2b-9655-5ed90b9756bd"), new Guid("b88bc938-52c1-436d-94bf-d654fbdc7a04"), 50.0, "B", 4, "MOTORCYCLE" },
                    { new Guid("84b7d184-3b4b-4a0f-bbc3-636a49d238aa"), new Guid("54038a10-6c7a-43c0-ae3c-378099c88c64"), 100.0, "A", 4, "CAR" },
                    { new Guid("84fdbcf6-ce7a-4d3f-b9b3-0f1a16a11fe8"), new Guid("5475a577-b9b7-452a-8870-915408c3bf05"), 100.0, "A", 3, "CAR" },
                    { new Guid("8685995f-f3bd-4595-aebf-702f955921d3"), new Guid("b78c84be-608a-4dce-a721-fe98e12baab4"), 300.0, "A", 8, "TRUCK" },
                    { new Guid("869e269f-edab-44d2-96c3-2338fd820d67"), new Guid("222dabdc-8eb6-438f-9420-1718acb4ac98"), 200.0, "A", 3, "VAN" },
                    { new Guid("86a24fc6-8e1f-4272-aff1-86209760eeac"), new Guid("177e5403-7253-460d-9dad-1fe45da5084f"), 100.0, "A", 6, "CAR" },
                    { new Guid("8730b1ee-6a32-4d7b-a664-5fbbb8cc5894"), new Guid("177e5403-7253-460d-9dad-1fe45da5084f"), 100.0, "A", 7, "CAR" },
                    { new Guid("87861b99-9e7d-41c0-a3e5-a22669d15c72"), new Guid("f1e09b0f-06a8-43f9-a77a-7d4eee6443ba"), 200.0, "A", 8, "VAN" },
                    { new Guid("87b2a37c-ff66-46e8-a827-7863196d2c52"), new Guid("84ec85e1-8d2a-48f1-a31c-051d5d584b18"), 100.0, "B", 4, "CAR" },
                    { new Guid("87c2e45e-ae98-4f2f-b722-55360de8a1fe"), new Guid("b88bc938-52c1-436d-94bf-d654fbdc7a04"), 50.0, "B", 6, "MOTORCYCLE" },
                    { new Guid("88bc0608-b0d6-47ec-b3df-4020b2aa48f5"), new Guid("abc2aa0f-084c-4c16-b0f2-42767da7c8da"), 50.0, "A", 3, "MOTORCYCLE" },
                    { new Guid("8954dedb-ec28-4f71-890e-a0b1fa9cead2"), new Guid("9e3ab747-8a77-4857-9d94-5165e0ab019c"), 200.0, "B", 7, "VAN" },
                    { new Guid("89b6f6ca-2a53-4768-b586-a585867e71db"), new Guid("fae37de9-614b-4f66-affa-db74f60ee387"), 100.0, "B", 6, "CAR" },
                    { new Guid("89c3bcaf-bf56-43d2-a924-4cc9e3d9dd24"), new Guid("dd1ab61b-6f46-4fce-8cc9-cd2100b6cbd5"), 100.0, "B", 3, "CAR" },
                    { new Guid("8a9e3d21-7d94-4989-af77-292b085c7c43"), new Guid("05edf7de-d320-4f8d-a1e3-b0bc2e39542b"), 300.0, "A", 5, "TRUCK" },
                    { new Guid("8aabd34b-a55c-4a07-8745-89422c54e650"), new Guid("fae37de9-614b-4f66-affa-db74f60ee387"), 300.0, "A", 2, "TRUCK" },
                    { new Guid("8b24f903-ed4a-4633-bba0-d0e712b892e3"), new Guid("222dabdc-8eb6-438f-9420-1718acb4ac98"), 200.0, "A", 5, "VAN" },
                    { new Guid("8b502307-20e2-48e5-a523-696dc7797839"), new Guid("b2a1ee4a-9bbb-4f49-ac21-74c45a404e3b"), 50.0, "B", 1, "MOTORCYCLE" },
                    { new Guid("8c2ae109-6d7f-4e89-a88c-e9c15ce6126a"), new Guid("3e9cd60c-04e9-4f3b-9fad-93c221bc30c7"), 200.0, "B", 1, "VAN" },
                    { new Guid("8cbfaac3-12ef-438f-ba6d-58a0f846c328"), new Guid("815ac24d-d4c7-4f3c-bacb-01f4a5f6fd3b"), 300.0, "B", 2, "TRUCK" },
                    { new Guid("8ea048e1-e967-4867-8772-7ba840983005"), new Guid("ff466904-5b83-454f-9ff1-99266e4a60a1"), 200.0, "B", 8, "VAN" },
                    { new Guid("8f1ec15b-b67a-4cae-9a0a-0943e3314b3a"), new Guid("815ac24d-d4c7-4f3c-bacb-01f4a5f6fd3b"), 100.0, "A", 7, "CAR" },
                    { new Guid("8f85c5ff-361d-40f1-b509-92788663c3fc"), new Guid("05edf7de-d320-4f8d-a1e3-b0bc2e39542b"), 50.0, "B", 1, "MOTORCYCLE" },
                    { new Guid("8f9df81f-9918-4450-a105-924d4fca09b6"), new Guid("ca2d3a26-8813-4f14-a2f7-7a716b06183c"), 200.0, "B", 4, "VAN" },
                    { new Guid("8fa77360-8c2f-4df2-9e74-e33e4c8b0b33"), new Guid("5475a577-b9b7-452a-8870-915408c3bf05"), 100.0, "A", 4, "CAR" },
                    { new Guid("8fc944cc-edd9-46f3-afa9-1047289c0f79"), new Guid("3e9cd60c-04e9-4f3b-9fad-93c221bc30c7"), 300.0, "A", 3, "TRUCK" },
                    { new Guid("91a7b420-f7a5-4b6f-aa14-1a4bc9513ad8"), new Guid("222dabdc-8eb6-438f-9420-1718acb4ac98"), 300.0, "B", 5, "TRUCK" },
                    { new Guid("91b3985e-40d9-4b19-b374-763330e54b7b"), new Guid("5475a577-b9b7-452a-8870-915408c3bf05"), 50.0, "B", 7, "MOTORCYCLE" },
                    { new Guid("91c9aaf8-4226-491b-8cd1-359f7be888ae"), new Guid("5475a577-b9b7-452a-8870-915408c3bf05"), 100.0, "A", 8, "CAR" },
                    { new Guid("91d76f18-c7f9-4be4-b231-59127851d6a3"), new Guid("222dabdc-8eb6-438f-9420-1718acb4ac98"), 300.0, "B", 6, "TRUCK" },
                    { new Guid("922fb2c3-441e-4302-a666-0d7f0887cd7b"), new Guid("f7d9e1df-23cb-4664-9b6c-e8ae239afc92"), 50.0, "B", 3, "MOTORCYCLE" },
                    { new Guid("92672d51-ce3e-4da8-bb46-c7287ee22d81"), new Guid("2fdc4e40-1753-4bad-b51b-879103cb8e6c"), 50.0, "B", 8, "MOTORCYCLE" },
                    { new Guid("92885d9a-f320-453e-be20-8fc528209826"), new Guid("9e3ab747-8a77-4857-9d94-5165e0ab019c"), 200.0, "B", 6, "VAN" },
                    { new Guid("932dd47e-e9f4-4cc8-8971-b639aaa1c45e"), new Guid("222dabdc-8eb6-438f-9420-1718acb4ac98"), 200.0, "A", 8, "VAN" },
                    { new Guid("9390e0aa-27ed-4e3e-a236-4566fd073817"), new Guid("5475a577-b9b7-452a-8870-915408c3bf05"), 100.0, "A", 1, "CAR" },
                    { new Guid("94115f4a-7be1-4751-97fe-f89f279afded"), new Guid("177e5403-7253-460d-9dad-1fe45da5084f"), 200.0, "B", 2, "VAN" },
                    { new Guid("9423e504-29fb-4b52-a049-b2d31f9e9e84"), new Guid("ff466904-5b83-454f-9ff1-99266e4a60a1"), 50.0, "A", 4, "MOTORCYCLE" },
                    { new Guid("9500ac72-5078-4ad0-995e-93102e9823c7"), new Guid("f6167eba-a93b-408c-9e6f-04e70262a3f1"), 100.0, "A", 7, "CAR" },
                    { new Guid("9743a2a5-1330-4b28-9e1a-73957500e9f4"), new Guid("b2a1ee4a-9bbb-4f49-ac21-74c45a404e3b"), 200.0, "A", 1, "VAN" },
                    { new Guid("980bd59a-4b43-45e4-be4e-34ed96893159"), new Guid("b2a1ee4a-9bbb-4f49-ac21-74c45a404e3b"), 50.0, "B", 7, "MOTORCYCLE" },
                    { new Guid("981c02cc-cf4a-42b6-b4e8-b96e0c9197a4"), new Guid("f6167eba-a93b-408c-9e6f-04e70262a3f1"), 100.0, "A", 3, "CAR" },
                    { new Guid("989d7ede-9372-4323-816f-3632c42ad7e1"), new Guid("2fdc4e40-1753-4bad-b51b-879103cb8e6c"), 50.0, "B", 1, "MOTORCYCLE" },
                    { new Guid("9909145e-6f5d-4995-aa75-1758b91352bc"), new Guid("b78c84be-608a-4dce-a721-fe98e12baab4"), 300.0, "A", 2, "TRUCK" },
                    { new Guid("9914ec4a-5dbc-4014-8a96-8bc70a453427"), new Guid("b2a1ee4a-9bbb-4f49-ac21-74c45a404e3b"), 50.0, "B", 4, "MOTORCYCLE" },
                    { new Guid("9a112b4f-368c-436b-bba0-cb775834b690"), new Guid("2fdc4e40-1753-4bad-b51b-879103cb8e6c"), 50.0, "B", 2, "MOTORCYCLE" },
                    { new Guid("9a1c689d-6e43-465a-933d-3fc6f4856952"), new Guid("5475a577-b9b7-452a-8870-915408c3bf05"), 100.0, "A", 5, "CAR" },
                    { new Guid("9a695f3a-064a-4418-8bea-c8c258476fda"), new Guid("b88bc938-52c1-436d-94bf-d654fbdc7a04"), 50.0, "B", 5, "MOTORCYCLE" },
                    { new Guid("9acb8527-058d-4f39-956a-9545ddc6cec8"), new Guid("f6167eba-a93b-408c-9e6f-04e70262a3f1"), 100.0, "B", 5, "CAR" },
                    { new Guid("9b222128-ba30-4acf-bebe-dd4cf0ba4120"), new Guid("062da560-f045-4060-96ba-f55f018f22fa"), 50.0, "B", 1, "MOTORCYCLE" },
                    { new Guid("9c03b2a5-bc5e-4eeb-9619-b539b373f089"), new Guid("0300e2e8-5324-4e9e-a263-b6e21ef522e1"), 200.0, "A", 4, "VAN" },
                    { new Guid("9d03275c-12db-4f69-9291-a58ac52160c6"), new Guid("b5008c91-0712-4873-ad29-295924447837"), 50.0, "B", 4, "MOTORCYCLE" },
                    { new Guid("9d21ab8f-d595-4a51-a720-93aa5ba99487"), new Guid("abc2aa0f-084c-4c16-b0f2-42767da7c8da"), 50.0, "A", 7, "MOTORCYCLE" },
                    { new Guid("9d38fffa-d037-46e3-a603-f7448db0b23c"), new Guid("f1e09b0f-06a8-43f9-a77a-7d4eee6443ba"), 50.0, "B", 8, "MOTORCYCLE" },
                    { new Guid("9d452591-322f-41ec-b474-f8d18500f652"), new Guid("fae37de9-614b-4f66-affa-db74f60ee387"), 300.0, "A", 6, "TRUCK" },
                    { new Guid("9e0de835-b228-45a4-b057-d0bd2117cfaa"), new Guid("dd1ab61b-6f46-4fce-8cc9-cd2100b6cbd5"), 100.0, "B", 2, "CAR" },
                    { new Guid("9e6ab68e-4c96-4715-b1b1-d7966793dea7"), new Guid("fae37de9-614b-4f66-affa-db74f60ee387"), 300.0, "A", 4, "TRUCK" },
                    { new Guid("9ea196b3-3d07-4594-a227-6cc48cea194c"), new Guid("3e9cd60c-04e9-4f3b-9fad-93c221bc30c7"), 300.0, "A", 6, "TRUCK" },
                    { new Guid("9fafe741-15ee-41e4-9e8a-64b79f78d725"), new Guid("c25adb05-f5ba-4e26-b1d2-d5fca4802f14"), 200.0, "B", 6, "VAN" },
                    { new Guid("a0868572-e384-4d9a-aac0-3e979f75300f"), new Guid("b5008c91-0712-4873-ad29-295924447837"), 50.0, "B", 6, "MOTORCYCLE" },
                    { new Guid("a1009476-3b15-4ebc-bec6-f2dac27c172f"), new Guid("222dabdc-8eb6-438f-9420-1718acb4ac98"), 200.0, "A", 7, "VAN" },
                    { new Guid("a1443b14-c3f9-4cfb-baec-4e4564186138"), new Guid("b5008c91-0712-4873-ad29-295924447837"), 50.0, "B", 3, "MOTORCYCLE" },
                    { new Guid("a174c628-a8c0-43d9-bfe7-9aedb7fd5cbd"), new Guid("54038a10-6c7a-43c0-ae3c-378099c88c64"), 50.0, "B", 5, "MOTORCYCLE" },
                    { new Guid("a1c5a9b0-4e39-4e80-b456-98da08848ba8"), new Guid("f6167eba-a93b-408c-9e6f-04e70262a3f1"), 100.0, "B", 2, "CAR" },
                    { new Guid("a1f893e1-e83b-4225-b74b-e7261a2378fd"), new Guid("b78c84be-608a-4dce-a721-fe98e12baab4"), 300.0, "B", 4, "TRUCK" },
                    { new Guid("a3615e15-17a5-4a67-a533-429c4a762379"), new Guid("54038a10-6c7a-43c0-ae3c-378099c88c64"), 50.0, "B", 6, "MOTORCYCLE" },
                    { new Guid("a38b67ce-e2e4-44f2-9617-b28176c6b574"), new Guid("31c01a3b-3f2b-49a4-acc5-01f815ede550"), 50.0, "B", 5, "MOTORCYCLE" },
                    { new Guid("a45c1e32-58ca-408b-8d79-d826d96e0b56"), new Guid("9e3ab747-8a77-4857-9d94-5165e0ab019c"), 200.0, "B", 5, "VAN" },
                    { new Guid("a54f3ae7-0c5b-4b60-9b15-fccb1f16f690"), new Guid("b2a1ee4a-9bbb-4f49-ac21-74c45a404e3b"), 200.0, "A", 6, "VAN" },
                    { new Guid("a566880b-b996-4119-9e13-87ccd1af1370"), new Guid("c25adb05-f5ba-4e26-b1d2-d5fca4802f14"), 200.0, "B", 5, "VAN" },
                    { new Guid("a6aed7aa-047f-4490-81ee-d9964a002dfb"), new Guid("0300e2e8-5324-4e9e-a263-b6e21ef522e1"), 300.0, "B", 4, "TRUCK" },
                    { new Guid("a85354af-9a61-4909-b1e0-8ae6978c4933"), new Guid("b88bc938-52c1-436d-94bf-d654fbdc7a04"), 200.0, "A", 6, "VAN" },
                    { new Guid("a9312854-7c28-4393-9e09-db0fdf8ba74f"), new Guid("222dabdc-8eb6-438f-9420-1718acb4ac98"), 200.0, "A", 1, "VAN" },
                    { new Guid("a9593064-0dd7-498b-ae3c-c90186b7cca0"), new Guid("dd1ab61b-6f46-4fce-8cc9-cd2100b6cbd5"), 200.0, "A", 5, "VAN" },
                    { new Guid("aa697786-5e2b-48f5-ac00-f235d9fc14c8"), new Guid("3e9cd60c-04e9-4f3b-9fad-93c221bc30c7"), 200.0, "B", 6, "VAN" },
                    { new Guid("aa7d7f7c-0ba2-49c0-9710-db724b70ce3f"), new Guid("b2a1ee4a-9bbb-4f49-ac21-74c45a404e3b"), 50.0, "B", 3, "MOTORCYCLE" },
                    { new Guid("ac698236-17f9-4aed-908c-8b664b89e31d"), new Guid("dd1ab61b-6f46-4fce-8cc9-cd2100b6cbd5"), 200.0, "A", 6, "VAN" },
                    { new Guid("ad68d5ad-6554-4f40-bdaa-56f5e560495b"), new Guid("f7d9e1df-23cb-4664-9b6c-e8ae239afc92"), 50.0, "B", 4, "MOTORCYCLE" },
                    { new Guid("adaef09b-0285-49d2-828a-7ce034e07835"), new Guid("31c01a3b-3f2b-49a4-acc5-01f815ede550"), 50.0, "B", 7, "MOTORCYCLE" },
                    { new Guid("ae61d692-2ff3-4908-92d6-7cf61912c8a7"), new Guid("389a4fe1-99bb-4993-adb6-62b343d955f0"), 100.0, "B", 1, "CAR" },
                    { new Guid("ae8662f3-c5cf-455f-b9a0-7d20e18ace80"), new Guid("438c734f-725d-4a35-85e7-f03b07c10532"), 300.0, "A", 8, "TRUCK" },
                    { new Guid("aed0130e-5790-4279-930e-08ef30a88164"), new Guid("05edf7de-d320-4f8d-a1e3-b0bc2e39542b"), 300.0, "A", 4, "TRUCK" },
                    { new Guid("b1022b5b-8cca-4a47-bd8d-b8a95ddffdd4"), new Guid("c25adb05-f5ba-4e26-b1d2-d5fca4802f14"), 300.0, "A", 8, "TRUCK" },
                    { new Guid("b1117bde-1912-45ef-b602-323cfeead899"), new Guid("815ac24d-d4c7-4f3c-bacb-01f4a5f6fd3b"), 100.0, "A", 3, "CAR" },
                    { new Guid("b17a7e5d-e951-4b72-ab64-9c49101bd952"), new Guid("35bd00fe-9bed-4685-babf-544508a6bd3f"), 200.0, "B", 8, "VAN" },
                    { new Guid("b3676d04-f49a-4e4d-af90-2ed879f75e14"), new Guid("31c01a3b-3f2b-49a4-acc5-01f815ede550"), 300.0, "A", 8, "TRUCK" },
                    { new Guid("b3e374d4-77d8-49f6-b0e0-157840cf54ba"), new Guid("84ec85e1-8d2a-48f1-a31c-051d5d584b18"), 100.0, "A", 4, "CAR" },
                    { new Guid("b3f45162-9612-4286-9445-124c48fb9f99"), new Guid("9e3ab747-8a77-4857-9d94-5165e0ab019c"), 200.0, "A", 3, "VAN" },
                    { new Guid("b5700f4c-755d-47be-b55c-8da535c4fdd6"), new Guid("05edf7de-d320-4f8d-a1e3-b0bc2e39542b"), 50.0, "B", 2, "MOTORCYCLE" },
                    { new Guid("b6b38a1c-0d16-41d6-ac2d-7470a6ec90a9"), new Guid("35bd00fe-9bed-4685-babf-544508a6bd3f"), 200.0, "A", 8, "VAN" },
                    { new Guid("b6eb99c1-3da7-40fc-94cf-23ef39c0654f"), new Guid("84ec85e1-8d2a-48f1-a31c-051d5d584b18"), 100.0, "B", 1, "CAR" },
                    { new Guid("b70c9132-fd84-4417-aa74-d44255b42758"), new Guid("815ac24d-d4c7-4f3c-bacb-01f4a5f6fd3b"), 300.0, "B", 3, "TRUCK" },
                    { new Guid("b7903e42-6ddc-4e83-b162-0659c0d25444"), new Guid("3e9cd60c-04e9-4f3b-9fad-93c221bc30c7"), 200.0, "B", 7, "VAN" },
                    { new Guid("b815a4ee-0ac1-4cf8-94c0-2c9fb97fb946"), new Guid("54038a10-6c7a-43c0-ae3c-378099c88c64"), 50.0, "B", 7, "MOTORCYCLE" },
                    { new Guid("b839e966-9750-460f-ba7c-ac8d3b9c367d"), new Guid("0300e2e8-5324-4e9e-a263-b6e21ef522e1"), 300.0, "B", 5, "TRUCK" },
                    { new Guid("b8fe831e-ec77-482b-a987-75a6f0bfa7d8"), new Guid("f7d9e1df-23cb-4664-9b6c-e8ae239afc92"), 100.0, "A", 8, "CAR" },
                    { new Guid("b90b99c0-e9e7-4e33-a015-12144d0d1124"), new Guid("438c734f-725d-4a35-85e7-f03b07c10532"), 300.0, "A", 1, "TRUCK" },
                    { new Guid("b97493d5-36ca-40fa-87c6-00efbc167cbb"), new Guid("438c734f-725d-4a35-85e7-f03b07c10532"), 100.0, "B", 1, "CAR" },
                    { new Guid("b9b9d969-882b-4c12-9507-aaad50d10f46"), new Guid("222dabdc-8eb6-438f-9420-1718acb4ac98"), 300.0, "B", 2, "TRUCK" },
                    { new Guid("ba6b779d-b72f-4f23-a324-7fdd804ede8c"), new Guid("fae37de9-614b-4f66-affa-db74f60ee387"), 100.0, "B", 7, "CAR" },
                    { new Guid("bd6eb26d-5901-4dd9-a0d6-03365f9fd203"), new Guid("35bd00fe-9bed-4685-babf-544508a6bd3f"), 200.0, "B", 1, "VAN" },
                    { new Guid("be2c3a23-552a-431f-bb8d-63ded5cfb8d5"), new Guid("438c734f-725d-4a35-85e7-f03b07c10532"), 100.0, "B", 3, "CAR" },
                    { new Guid("bf148954-a6dc-495e-a9c8-460c94722626"), new Guid("c25adb05-f5ba-4e26-b1d2-d5fca4802f14"), 200.0, "B", 2, "VAN" },
                    { new Guid("bf3a82b0-e573-41c8-a733-87e403b74c8d"), new Guid("abc2aa0f-084c-4c16-b0f2-42767da7c8da"), 50.0, "A", 5, "MOTORCYCLE" },
                    { new Guid("bf7e649a-8114-4fef-b067-f45ddac54a8c"), new Guid("ff466904-5b83-454f-9ff1-99266e4a60a1"), 200.0, "B", 6, "VAN" },
                    { new Guid("bf845cc6-8dbf-47a5-9d6b-b02d96cca1ff"), new Guid("3e9cd60c-04e9-4f3b-9fad-93c221bc30c7"), 300.0, "A", 4, "TRUCK" },
                    { new Guid("c190dcbc-7b45-473e-8a81-e824d0e8d8f7"), new Guid("84ec85e1-8d2a-48f1-a31c-051d5d584b18"), 100.0, "A", 7, "CAR" },
                    { new Guid("c1e2fa10-bfb9-455b-926c-901aaaaa728a"), new Guid("b88bc938-52c1-436d-94bf-d654fbdc7a04"), 200.0, "A", 2, "VAN" },
                    { new Guid("c27c3b56-1378-4719-99a0-f10db2579cf7"), new Guid("062da560-f045-4060-96ba-f55f018f22fa"), 50.0, "B", 5, "MOTORCYCLE" },
                    { new Guid("c2b27f25-79d0-4f43-8bd0-07efec45a936"), new Guid("0300e2e8-5324-4e9e-a263-b6e21ef522e1"), 200.0, "A", 2, "VAN" },
                    { new Guid("c2e6cd7c-5a0f-4aa6-aab0-5a44c47b13fa"), new Guid("5475a577-b9b7-452a-8870-915408c3bf05"), 50.0, "B", 5, "MOTORCYCLE" },
                    { new Guid("c3eb35f2-ce2a-4ef7-a662-a9d5460fcf0d"), new Guid("ff466904-5b83-454f-9ff1-99266e4a60a1"), 50.0, "A", 6, "MOTORCYCLE" },
                    { new Guid("c4049802-5355-458a-8ec8-36c1aaddd72a"), new Guid("7dfcc8b1-a83c-4aee-8987-a86828f6f257"), 100.0, "A", 5, "CAR" },
                    { new Guid("c40576f4-8248-487e-8638-8167f3e5b6e5"), new Guid("0300e2e8-5324-4e9e-a263-b6e21ef522e1"), 200.0, "A", 7, "VAN" },
                    { new Guid("c647483a-04e2-4a1c-8ddf-f258a37a5c88"), new Guid("54038a10-6c7a-43c0-ae3c-378099c88c64"), 50.0, "B", 3, "MOTORCYCLE" },
                    { new Guid("c6a9b470-af1b-438e-b3bc-c7e853b885d2"), new Guid("222dabdc-8eb6-438f-9420-1718acb4ac98"), 300.0, "B", 7, "TRUCK" },
                    { new Guid("c80cb0ba-c978-4247-a481-61f59efe6c5a"), new Guid("dd1ab61b-6f46-4fce-8cc9-cd2100b6cbd5"), 200.0, "A", 8, "VAN" },
                    { new Guid("c9a99936-1541-42c6-82b0-c23a4d2983c2"), new Guid("b78c84be-608a-4dce-a721-fe98e12baab4"), 300.0, "A", 5, "TRUCK" },
                    { new Guid("ca757c79-db26-4ebc-a784-8d7f24418c3f"), new Guid("abc2aa0f-084c-4c16-b0f2-42767da7c8da"), 50.0, "A", 4, "MOTORCYCLE" },
                    { new Guid("ca8a798c-88c9-4c02-ad93-a3ee5cbdb36b"), new Guid("815ac24d-d4c7-4f3c-bacb-01f4a5f6fd3b"), 100.0, "A", 5, "CAR" },
                    { new Guid("cb7103bd-3cf5-4b3d-9955-db7527641626"), new Guid("815ac24d-d4c7-4f3c-bacb-01f4a5f6fd3b"), 100.0, "A", 8, "CAR" },
                    { new Guid("cb8e32ed-c9d3-48cd-b9a9-66b352bace89"), new Guid("438c734f-725d-4a35-85e7-f03b07c10532"), 100.0, "B", 7, "CAR" },
                    { new Guid("cc0bebe0-7bd9-4a83-9c51-77569cc40c47"), new Guid("3e9cd60c-04e9-4f3b-9fad-93c221bc30c7"), 200.0, "B", 2, "VAN" },
                    { new Guid("cc92584c-22b8-4f80-ad5d-eca8e7f7bc5a"), new Guid("31c01a3b-3f2b-49a4-acc5-01f815ede550"), 50.0, "B", 1, "MOTORCYCLE" },
                    { new Guid("ccc1317f-b306-4e34-917a-3098a25a8abb"), new Guid("b88bc938-52c1-436d-94bf-d654fbdc7a04"), 200.0, "A", 4, "VAN" },
                    { new Guid("ccc3ff2a-2930-4b21-b07c-319b1ad53563"), new Guid("f6167eba-a93b-408c-9e6f-04e70262a3f1"), 100.0, "A", 6, "CAR" },
                    { new Guid("cd73ac91-e12c-4414-9c0e-f4226311b7de"), new Guid("f6167eba-a93b-408c-9e6f-04e70262a3f1"), 100.0, "B", 6, "CAR" },
                    { new Guid("ce1e3ae0-fda3-4949-a7bf-5a8db980904b"), new Guid("f6167eba-a93b-408c-9e6f-04e70262a3f1"), 100.0, "B", 8, "CAR" },
                    { new Guid("ce8877a6-7d74-4c7e-a108-75bbe2f8d991"), new Guid("ff466904-5b83-454f-9ff1-99266e4a60a1"), 200.0, "B", 1, "VAN" },
                    { new Guid("cfe81dec-1017-4e49-841a-5dec8bdbdcf3"), new Guid("f7d9e1df-23cb-4664-9b6c-e8ae239afc92"), 100.0, "A", 4, "CAR" },
                    { new Guid("cff6e8d5-7d31-49a9-a6d1-226551f515ae"), new Guid("b5008c91-0712-4873-ad29-295924447837"), 50.0, "B", 1, "MOTORCYCLE" },
                    { new Guid("d203cfcb-6e3f-40c9-9954-083e76f9f1fc"), new Guid("177e5403-7253-460d-9dad-1fe45da5084f"), 100.0, "A", 8, "CAR" },
                    { new Guid("d379b68c-2941-4565-b81b-dadd92785698"), new Guid("abc2aa0f-084c-4c16-b0f2-42767da7c8da"), 300.0, "B", 2, "TRUCK" },
                    { new Guid("d5668722-a233-4608-b3be-22a993a361c5"), new Guid("f1e09b0f-06a8-43f9-a77a-7d4eee6443ba"), 50.0, "B", 5, "MOTORCYCLE" },
                    { new Guid("d592bf37-3f74-4a02-a22b-6bb831b62569"), new Guid("062da560-f045-4060-96ba-f55f018f22fa"), 50.0, "B", 3, "MOTORCYCLE" },
                    { new Guid("d607eebc-3602-4614-a9ca-2cbdc97ee020"), new Guid("815ac24d-d4c7-4f3c-bacb-01f4a5f6fd3b"), 300.0, "B", 7, "TRUCK" },
                    { new Guid("d66706dc-50d7-450b-805f-659b78ad99c6"), new Guid("9e3ab747-8a77-4857-9d94-5165e0ab019c"), 200.0, "A", 7, "VAN" },
                    { new Guid("d723029a-6097-4bd6-bd07-e61d5704a8cb"), new Guid("54038a10-6c7a-43c0-ae3c-378099c88c64"), 100.0, "A", 2, "CAR" },
                    { new Guid("d8537dd7-d5c0-483c-8a99-e371032f1cfa"), new Guid("ca2d3a26-8813-4f14-a2f7-7a716b06183c"), 200.0, "B", 6, "VAN" },
                    { new Guid("d866d92f-7857-4292-a89d-7133d52175a5"), new Guid("f1e09b0f-06a8-43f9-a77a-7d4eee6443ba"), 50.0, "B", 7, "MOTORCYCLE" },
                    { new Guid("d879096c-b706-40a4-8372-d75d21b7dcf7"), new Guid("f7d9e1df-23cb-4664-9b6c-e8ae239afc92"), 100.0, "A", 3, "CAR" },
                    { new Guid("d99fac67-d6ea-4f9a-ada0-d1de68e4fdd4"), new Guid("0300e2e8-5324-4e9e-a263-b6e21ef522e1"), 300.0, "B", 3, "TRUCK" },
                    { new Guid("d9d1a8fe-8885-49bf-beb3-27977b2f94c2"), new Guid("b88bc938-52c1-436d-94bf-d654fbdc7a04"), 200.0, "A", 5, "VAN" },
                    { new Guid("da4afb23-e13e-4507-85ed-8031dc2b656b"), new Guid("b88bc938-52c1-436d-94bf-d654fbdc7a04"), 200.0, "A", 1, "VAN" },
                    { new Guid("db3dd221-2578-4532-96e9-598fb40338c2"), new Guid("abc2aa0f-084c-4c16-b0f2-42767da7c8da"), 50.0, "A", 2, "MOTORCYCLE" },
                    { new Guid("db6f981e-abb4-4399-baa9-affd26a32038"), new Guid("dd1ab61b-6f46-4fce-8cc9-cd2100b6cbd5"), 200.0, "A", 4, "VAN" },
                    { new Guid("dbb8792b-1423-4661-90fb-821be2dea340"), new Guid("f6167eba-a93b-408c-9e6f-04e70262a3f1"), 100.0, "A", 8, "CAR" },
                    { new Guid("dc667f4d-3eff-4d7d-917c-db6f528d9f58"), new Guid("abc2aa0f-084c-4c16-b0f2-42767da7c8da"), 300.0, "B", 8, "TRUCK" },
                    { new Guid("dce007e1-48b5-425d-9882-03459f6bbaa7"), new Guid("f6167eba-a93b-408c-9e6f-04e70262a3f1"), 100.0, "B", 3, "CAR" },
                    { new Guid("dde192a1-f21c-495a-8d5a-aa6e13049465"), new Guid("84ec85e1-8d2a-48f1-a31c-051d5d584b18"), 100.0, "A", 2, "CAR" },
                    { new Guid("de50f6de-6c93-4a51-8797-c9bbdd7dc3ad"), new Guid("abc2aa0f-084c-4c16-b0f2-42767da7c8da"), 300.0, "B", 7, "TRUCK" },
                    { new Guid("de68a012-ecc5-4176-bb02-90d1730cb48c"), new Guid("f6167eba-a93b-408c-9e6f-04e70262a3f1"), 100.0, "A", 5, "CAR" },
                    { new Guid("de82940b-fa18-47c4-bc7f-1b308ab437bb"), new Guid("7dfcc8b1-a83c-4aee-8987-a86828f6f257"), 100.0, "A", 8, "CAR" },
                    { new Guid("dec21ee9-6e2e-4599-8aed-49ac0f3d7b8a"), new Guid("b88bc938-52c1-436d-94bf-d654fbdc7a04"), 200.0, "A", 3, "VAN" },
                    { new Guid("dee8e656-ca42-41e8-867b-a8c65b5a21ed"), new Guid("177e5403-7253-460d-9dad-1fe45da5084f"), 200.0, "B", 3, "VAN" },
                    { new Guid("e0018b18-2eb1-46e5-8c72-908a65ad5e23"), new Guid("abc2aa0f-084c-4c16-b0f2-42767da7c8da"), 300.0, "B", 3, "TRUCK" },
                    { new Guid("e037c884-a221-4737-a154-8d75af068844"), new Guid("7dfcc8b1-a83c-4aee-8987-a86828f6f257"), 100.0, "A", 7, "CAR" },
                    { new Guid("e1cc3a2a-af88-4699-8d03-31c58c4d6c81"), new Guid("2fdc4e40-1753-4bad-b51b-879103cb8e6c"), 50.0, "A", 2, "MOTORCYCLE" },
                    { new Guid("e24d1192-6498-4792-9b65-f9595f95486e"), new Guid("389a4fe1-99bb-4993-adb6-62b343d955f0"), 300.0, "A", 8, "TRUCK" },
                    { new Guid("e2666fce-d72d-4757-9848-5583a6f595ce"), new Guid("b88bc938-52c1-436d-94bf-d654fbdc7a04"), 200.0, "A", 7, "VAN" },
                    { new Guid("e2bedf71-2179-477a-a5be-77a09599471a"), new Guid("0300e2e8-5324-4e9e-a263-b6e21ef522e1"), 200.0, "A", 3, "VAN" },
                    { new Guid("e32e9f52-ae2a-4d23-8db6-eb87033a5717"), new Guid("05edf7de-d320-4f8d-a1e3-b0bc2e39542b"), 50.0, "B", 7, "MOTORCYCLE" },
                    { new Guid("e337a410-6f3d-476f-bedf-880aa85b0edc"), new Guid("dd1ab61b-6f46-4fce-8cc9-cd2100b6cbd5"), 200.0, "A", 3, "VAN" },
                    { new Guid("e3508976-4307-4875-a806-91bb55d8ef54"), new Guid("54038a10-6c7a-43c0-ae3c-378099c88c64"), 100.0, "A", 3, "CAR" },
                    { new Guid("e438b106-1b74-4227-ac83-de22e9a7efbb"), new Guid("c25adb05-f5ba-4e26-b1d2-d5fca4802f14"), 300.0, "A", 1, "TRUCK" },
                    { new Guid("e4e60d6c-bc98-466a-abe1-0a24ffb1f38e"), new Guid("f6167eba-a93b-408c-9e6f-04e70262a3f1"), 100.0, "B", 7, "CAR" },
                    { new Guid("e517182d-adf3-4b5d-9809-27e256bf3933"), new Guid("b5008c91-0712-4873-ad29-295924447837"), 50.0, "B", 5, "MOTORCYCLE" },
                    { new Guid("e56f2ce5-196d-4334-a76e-c66e6bf0b410"), new Guid("389a4fe1-99bb-4993-adb6-62b343d955f0"), 300.0, "A", 4, "TRUCK" },
                    { new Guid("e5d05fbb-ee6b-4a0f-a3b6-efb895b757a2"), new Guid("222dabdc-8eb6-438f-9420-1718acb4ac98"), 200.0, "A", 4, "VAN" },
                    { new Guid("e67103ca-fc08-403d-9c35-820593e1608b"), new Guid("ca2d3a26-8813-4f14-a2f7-7a716b06183c"), 100.0, "A", 4, "CAR" },
                    { new Guid("e6787abc-a990-4489-a7ce-d831681b06c3"), new Guid("177e5403-7253-460d-9dad-1fe45da5084f"), 200.0, "B", 8, "VAN" },
                    { new Guid("e7225b1b-bfe6-4252-95bd-94c6ce348a12"), new Guid("b5008c91-0712-4873-ad29-295924447837"), 50.0, "A", 1, "MOTORCYCLE" },
                    { new Guid("e87bbdbb-c21b-45bd-9d8c-b18827b90baf"), new Guid("b2a1ee4a-9bbb-4f49-ac21-74c45a404e3b"), 200.0, "A", 8, "VAN" },
                    { new Guid("e8912a99-15c0-4be6-ba76-b2bbd668f293"), new Guid("35bd00fe-9bed-4685-babf-544508a6bd3f"), 200.0, "A", 4, "VAN" },
                    { new Guid("e8b71327-6d8c-435a-9e27-005019e76d48"), new Guid("062da560-f045-4060-96ba-f55f018f22fa"), 200.0, "A", 7, "VAN" },
                    { new Guid("e92bbc81-494e-41ab-a9c8-52bee389ff83"), new Guid("84ec85e1-8d2a-48f1-a31c-051d5d584b18"), 100.0, "B", 3, "CAR" },
                    { new Guid("e9872183-f460-49d9-a9e2-be0278414e4c"), new Guid("35bd00fe-9bed-4685-babf-544508a6bd3f"), 200.0, "B", 2, "VAN" },
                    { new Guid("e99239c7-5e49-494d-a233-24bf47e9dcdf"), new Guid("35bd00fe-9bed-4685-babf-544508a6bd3f"), 200.0, "B", 5, "VAN" },
                    { new Guid("e9d890c4-526f-400d-9ac3-8776df8955de"), new Guid("ff466904-5b83-454f-9ff1-99266e4a60a1"), 200.0, "B", 3, "VAN" },
                    { new Guid("ea1c2d77-49a5-4f5b-8b92-d3ce409b1176"), new Guid("f1e09b0f-06a8-43f9-a77a-7d4eee6443ba"), 50.0, "B", 4, "MOTORCYCLE" },
                    { new Guid("ea45163d-c880-4a7a-add6-cdda33f91876"), new Guid("0300e2e8-5324-4e9e-a263-b6e21ef522e1"), 300.0, "B", 8, "TRUCK" },
                    { new Guid("ea5168c1-d9f6-437e-b18d-58b39d222554"), new Guid("ca2d3a26-8813-4f14-a2f7-7a716b06183c"), 200.0, "B", 1, "VAN" },
                    { new Guid("ea5269dd-11f2-4b5b-933c-07742b616386"), new Guid("7dfcc8b1-a83c-4aee-8987-a86828f6f257"), 100.0, "A", 6, "CAR" },
                    { new Guid("eb95d08f-dc52-4c26-a526-eb77ccb02d99"), new Guid("ca2d3a26-8813-4f14-a2f7-7a716b06183c"), 100.0, "A", 5, "CAR" },
                    { new Guid("ec0468e4-98aa-449b-b52e-ceea2dba0e64"), new Guid("f7d9e1df-23cb-4664-9b6c-e8ae239afc92"), 50.0, "B", 2, "MOTORCYCLE" },
                    { new Guid("ec0bc2ab-5e56-4d4d-9230-5890d7caa429"), new Guid("f7d9e1df-23cb-4664-9b6c-e8ae239afc92"), 100.0, "A", 1, "CAR" },
                    { new Guid("ec80aeaf-0cc6-4e72-8ec0-8cd48f61e314"), new Guid("b2a1ee4a-9bbb-4f49-ac21-74c45a404e3b"), 50.0, "B", 5, "MOTORCYCLE" },
                    { new Guid("edad4172-2fd4-4b8b-a62a-94ef2a622fa8"), new Guid("f7d9e1df-23cb-4664-9b6c-e8ae239afc92"), 100.0, "A", 7, "CAR" },
                    { new Guid("ee4eabc5-b1cf-418c-a094-e8af0a9f97f0"), new Guid("05edf7de-d320-4f8d-a1e3-b0bc2e39542b"), 300.0, "A", 2, "TRUCK" },
                    { new Guid("f0173e74-23c9-4b0e-bad0-d7cd61efed5d"), new Guid("ca2d3a26-8813-4f14-a2f7-7a716b06183c"), 200.0, "B", 5, "VAN" },
                    { new Guid("f1aec9c4-92d3-4fba-91d6-ddbafa514cbc"), new Guid("f1e09b0f-06a8-43f9-a77a-7d4eee6443ba"), 200.0, "A", 7, "VAN" },
                    { new Guid("f1c56a74-141e-465e-8f3a-0293e9e6772e"), new Guid("f6167eba-a93b-408c-9e6f-04e70262a3f1"), 100.0, "A", 1, "CAR" },
                    { new Guid("f24390bd-ce9e-4f31-bd64-89729b1b66fd"), new Guid("ca2d3a26-8813-4f14-a2f7-7a716b06183c"), 100.0, "A", 6, "CAR" },
                    { new Guid("f2b654b5-f954-4fe8-9a0f-6862f5948304"), new Guid("389a4fe1-99bb-4993-adb6-62b343d955f0"), 100.0, "B", 5, "CAR" },
                    { new Guid("f2dce7ba-93ee-4945-a8b0-cd733356dc54"), new Guid("ff466904-5b83-454f-9ff1-99266e4a60a1"), 200.0, "B", 7, "VAN" },
                    { new Guid("f310eb55-6316-40cc-b843-8fbd40cc0b29"), new Guid("7dfcc8b1-a83c-4aee-8987-a86828f6f257"), 50.0, "B", 8, "MOTORCYCLE" },
                    { new Guid("f3345007-6456-4cca-8111-012d4b6a8e4a"), new Guid("2fdc4e40-1753-4bad-b51b-879103cb8e6c"), 50.0, "A", 3, "MOTORCYCLE" },
                    { new Guid("f397da81-9bbf-48b2-b89a-0f19f4bb3fc9"), new Guid("b2a1ee4a-9bbb-4f49-ac21-74c45a404e3b"), 50.0, "B", 2, "MOTORCYCLE" },
                    { new Guid("f39e48b7-66d8-4ea0-9bdd-129af152355f"), new Guid("177e5403-7253-460d-9dad-1fe45da5084f"), 200.0, "B", 6, "VAN" },
                    { new Guid("f39ebd4e-7bfa-4f0c-9d74-36359f66fcab"), new Guid("abc2aa0f-084c-4c16-b0f2-42767da7c8da"), 50.0, "A", 8, "MOTORCYCLE" },
                    { new Guid("f3c18a6f-d8d6-40f1-a5da-1d62a78787cb"), new Guid("b78c84be-608a-4dce-a721-fe98e12baab4"), 300.0, "A", 6, "TRUCK" },
                    { new Guid("f45a06b1-0d14-48af-b509-3a0e58cddf20"), new Guid("438c734f-725d-4a35-85e7-f03b07c10532"), 100.0, "B", 8, "CAR" },
                    { new Guid("f6e86967-781f-4cb6-9b93-0d8be63d6bbb"), new Guid("35bd00fe-9bed-4685-babf-544508a6bd3f"), 200.0, "B", 7, "VAN" },
                    { new Guid("f72f13e2-9ce4-4e63-b711-0e6400c25187"), new Guid("c25adb05-f5ba-4e26-b1d2-d5fca4802f14"), 300.0, "A", 6, "TRUCK" },
                    { new Guid("f79bdac9-0a25-45f9-a563-6291c1266262"), new Guid("05edf7de-d320-4f8d-a1e3-b0bc2e39542b"), 300.0, "A", 3, "TRUCK" },
                    { new Guid("f976c5fd-38f7-40df-9340-f7c628425372"), new Guid("b5008c91-0712-4873-ad29-295924447837"), 50.0, "A", 2, "MOTORCYCLE" },
                    { new Guid("fa1bc52c-ea21-4603-b3e6-336110873a29"), new Guid("b88bc938-52c1-436d-94bf-d654fbdc7a04"), 50.0, "B", 3, "MOTORCYCLE" },
                    { new Guid("fa7a1706-573f-4ae9-b81f-5916adb6da6c"), new Guid("389a4fe1-99bb-4993-adb6-62b343d955f0"), 300.0, "A", 6, "TRUCK" },
                    { new Guid("faaa73a2-b11a-4cc6-a56e-4f109602664c"), new Guid("ca2d3a26-8813-4f14-a2f7-7a716b06183c"), 200.0, "B", 3, "VAN" },
                    { new Guid("fb3f1baa-05a7-464a-b467-7873d8a5d46a"), new Guid("dd1ab61b-6f46-4fce-8cc9-cd2100b6cbd5"), 200.0, "A", 2, "VAN" },
                    { new Guid("fb68987f-3597-4746-8424-280ea01768f7"), new Guid("f6167eba-a93b-408c-9e6f-04e70262a3f1"), 100.0, "B", 1, "CAR" },
                    { new Guid("fb8da3a6-18ac-45db-9009-830fc1c5f6be"), new Guid("b78c84be-608a-4dce-a721-fe98e12baab4"), 300.0, "B", 1, "TRUCK" },
                    { new Guid("fc9e6ba9-79d0-446a-94e1-2d2211b439f6"), new Guid("dd1ab61b-6f46-4fce-8cc9-cd2100b6cbd5"), 100.0, "B", 7, "CAR" },
                    { new Guid("fd7e2f5b-9b24-4c4d-936d-36fca1ff2723"), new Guid("2fdc4e40-1753-4bad-b51b-879103cb8e6c"), 50.0, "A", 8, "MOTORCYCLE" },
                    { new Guid("fd87d0b7-6c2d-4b01-a585-75869c6de889"), new Guid("062da560-f045-4060-96ba-f55f018f22fa"), 200.0, "A", 2, "VAN" },
                    { new Guid("fded279c-03b3-4ee4-be61-4055403f4931"), new Guid("062da560-f045-4060-96ba-f55f018f22fa"), 200.0, "A", 8, "VAN" },
                    { new Guid("fea8fac1-0034-4bbf-85e7-cefc92246c46"), new Guid("b2a1ee4a-9bbb-4f49-ac21-74c45a404e3b"), 200.0, "A", 4, "VAN" },
                    { new Guid("ff39ad16-c5a5-4768-9348-39a25216e079"), new Guid("31c01a3b-3f2b-49a4-acc5-01f815ede550"), 50.0, "B", 6, "MOTORCYCLE" },
                    { new Guid("ff6e0247-0b09-450e-8e14-9d1c1a133c40"), new Guid("5475a577-b9b7-452a-8870-915408c3bf05"), 100.0, "A", 6, "CAR" },
                    { new Guid("ff992cb9-906f-4625-9a80-cf515536f15a"), new Guid("177e5403-7253-460d-9dad-1fe45da5084f"), 200.0, "B", 4, "VAN" },
                    { new Guid("fff9c676-2dd1-4a61-a96c-9b2f7e1cb8f8"), new Guid("ff466904-5b83-454f-9ff1-99266e4a60a1"), 50.0, "A", 8, "MOTORCYCLE" }
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
                name: "IX_Bookings_ParkingSpaceId",
                table: "Bookings",
                column: "ParkingSpaceId");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_UserId",
                table: "Bookings",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ParkingSpaces_ParkingLotId",
                table: "ParkingSpaces",
                column: "ParkingLotId");

            migrationBuilder.CreateIndex(
                name: "IX_ParkingSpaces_SectionName_SpotNumber_ParkingLotId",
                table: "ParkingSpaces",
                columns: new[] { "SectionName", "SpotNumber", "ParkingLotId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_RefreshTokens_UserId",
                table: "RefreshTokens",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TimeLines_BookingId",
                table: "TimeLines",
                column: "BookingId");
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
                name: "RefreshTokens");

            migrationBuilder.DropTable(
                name: "TimeLines");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Bookings");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "ParkingSpaces");

            migrationBuilder.DropTable(
                name: "ParkingLots");
        }
    }
}
