using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class booking_model_seed2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("9a07b7b1-38cd-4760-979d-83367464174b"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("f85a91b9-7efb-43d5-915a-b2f6644322fc"));

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: new Guid("1d9646c1-7209-42b3-b8b3-b18af522b85f"));

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: new Guid("26787fe2-efc2-4d83-9fcf-66da1d5e0e4c"));

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: new Guid("3127a72a-1b69-4d69-9b9f-c91cf66e6af0"));

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: new Guid("34d31b9a-33af-4a2f-803a-41892409fe5a"));

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: new Guid("3be758c6-d740-4c1f-9e68-fbc794df94fb"));

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: new Guid("3e38930b-9039-4573-a289-047554aecdf7"));

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: new Guid("51e0c21d-b3dc-4ed1-8ff9-52991f621cf7"));

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: new Guid("544b1d80-19cb-40a0-b972-da34ea52502e"));

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: new Guid("596784c5-b4c1-4af9-a4f8-2f5a3fdfc34d"));

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: new Guid("5d60ee89-1dd6-4f29-9ef9-f89d42922ee5"));

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: new Guid("5f853f7c-de2c-4a04-824e-3bf3cec6cafc"));

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: new Guid("6265e502-2601-40b8-972d-095c04334f8e"));

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: new Guid("6a16f76a-6237-425d-b0a9-4120d05fc8c4"));

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: new Guid("a14a4254-0772-4f71-a1bb-6aa7b250ea24"));

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: new Guid("b67cff75-577f-41ef-90fa-5d93d85cd686"));

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: new Guid("b8964035-ba7b-4880-aa54-d09b158f2012"));

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: new Guid("c9824d18-5012-4caa-91a0-4f250b29f11e"));

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: new Guid("ce040175-2666-4f00-9a53-33eba67d837d"));

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: new Guid("e621854b-732a-45b0-8c37-402b266f5751"));

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: new Guid("fa1c3798-565d-4ecd-985f-d1b104698e10"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("006e784a-f87b-49c6-84c9-0a769c97d1bd"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("01bbe8f9-0ccb-4115-8f43-5a74a1a194c9"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("01d229fc-33bd-49cd-8e2d-e95d6db3ec67"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("01e2736e-8864-4a8a-929a-92bb5efe78fe"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("02000f84-045f-465b-bf77-1b8207703869"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("0253a3de-d243-4079-976d-245d728db780"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("027038cb-1e06-4453-a98f-42409ebb20ab"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("0362ad6d-909f-4566-b1f7-513f38428a9b"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("03fb2d78-a73a-4901-a830-8b07fff08cf9"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("044ec767-f877-4553-8a6a-8b104c345d6d"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("0489e969-6940-4364-9928-19879c8a8ce7"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("061c5a82-bcef-4987-a0ba-a5282df1be37"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("0622f45a-5551-4cae-9f47-dfb7907c7e17"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("064dfb5a-fef2-4950-ac89-4d4b76210538"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("08ba6fbb-65b8-45bb-a8ef-fb29045bee85"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("08ed8c7c-ba89-4f83-a9ee-25e6c186f6e5"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("08fce645-8d81-41a3-8805-dfcf0c47b04a"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("09f347df-e38e-4e24-bb6c-15adb50098e6"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("0bb815a2-b701-42da-8cbe-2c3759345d97"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("0ccdaf97-332f-419c-a856-d1bb5562a0b5"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("0cfde89e-a5e0-45d1-9883-2b8df6bf7188"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("0d5ce291-debd-4eee-a01c-3724fd0deca6"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("0d9c2862-1000-4782-8bdc-142588531b48"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("0f4d2797-9f9a-4735-a030-3abbed014992"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("10880142-d374-4edf-a02a-b5dca8b5c46b"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("110c5ba2-1434-449c-8d26-48e952431a5a"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("112ab42f-94d8-4778-bef2-f6d1f390ef15"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("115ec8bd-1644-45fc-8f7c-c5faba2e338f"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("11af6c55-52b5-4b7c-8d18-f9fed18a2467"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("11c1aa73-a41d-4ff4-8bc0-d63aac827700"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("122f519b-0860-4e98-af60-e81232fba37e"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("139a2c94-6cec-482b-8bba-234011b364ab"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("14f4deea-bfeb-497d-a438-06b3edc3d20b"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("14fbdcb1-b9f7-4e73-a1ae-900940fd5a1b"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("15672710-c250-4d13-b4b6-5f8f3e5f9a7c"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("1618d2c6-0ee2-4e9e-b64b-8b12a018d3e8"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("16e5f437-74db-49ca-9159-1e7ccad413da"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("170becc5-4034-4722-98ec-4fedd70abecf"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("17b930c0-023f-46c2-bcc0-d471c541ce88"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("18ab4430-483f-462e-b11d-b649e65564c2"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("199afa40-731a-4728-8e34-442febf92738"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("1a3677ca-0a42-41eb-a8d0-77bdc5fa539e"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("1a9620c1-a1a1-4f0e-8a9c-b31e2045911d"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("1af63f1a-78ad-4109-8e6d-a681403eb3ba"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("1d1feef7-1fc3-47af-9aed-66509d87f942"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("1d6263e5-2fe1-4b5c-9ced-56bf815bb991"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("1ded01aa-1b64-424e-afc0-28ae454f94b3"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("1f17dbf6-db83-4371-bf7a-f8f02f088eca"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("1f618462-956d-41ce-888e-cdec4e0ad5ab"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("1fa124f4-fe8a-455a-be69-3a8146d82236"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("20847881-fa27-4534-b9ff-c33732634716"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("20a8f64a-3a24-4964-94e9-37555f1a1c8c"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("2181fce0-7788-4a77-99fb-8db745d034c1"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("21bf54a2-0ae5-4f52-8d78-502da311cb2f"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("225597e4-7319-404c-a15e-ae51322ce67d"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("225868e1-3b0c-40cf-9a12-5c547c87b597"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("228a8034-bfbb-49f2-a8c0-907668d9259d"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("22c0c4ff-84f8-42b1-845f-ca3486e0f220"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("24ececb8-1599-4ed8-be26-8fa9ac5f6f0b"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("250ad4d3-fbd7-4b59-89a8-26d176526a8e"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("25baf129-0305-4230-a4fa-86359c7adc21"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("25ca6c97-b16d-4386-8dfd-00f0e74e85ae"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("26243cad-ce30-4164-b3f0-f871f07b0c1d"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("269200b1-97b5-4a99-bc93-c806097ddc78"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("26dbf01d-2337-4a93-95a7-8c2b0ceddaa7"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("2958c220-e3fd-4bee-88d2-d47a7e0555d4"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("29942aa7-59ac-4593-8580-5c1102fa2cde"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("29f05d7a-1d03-4ff2-a772-9c33fda0792e"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("2a0bd116-59a0-41d4-ab09-174b4d7daaff"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("2afc1bbc-b296-4593-bb2d-55cfc83c13b6"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("2b4aec5d-b8cb-4520-b4c8-55c7cdaa5408"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("2c84764e-a9bd-4733-8396-66bc2fb7854f"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("2d67696d-9d9d-4712-9c48-13da298af1d4"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("2d99d6c3-ef6a-4cfd-86a6-17b364f2ab0a"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("2e6b6f9c-e880-4d75-9453-b684465df650"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("302cc893-7c12-4893-b18d-f8bcb6e476da"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("305f8eca-f1b8-40e4-81ef-9d0eb8c734f9"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("3074deef-7d3a-41c8-b1ec-05d14093e398"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("315dc986-aa49-4948-95e5-fdf219472236"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("31c7c921-8b25-41af-9cb2-ece01875b054"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("32335aa7-77fe-4db0-8912-c357c92099ee"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("335eb771-127c-4885-b8f2-b671b53306ae"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("3385e36f-af77-4b40-8e93-73e1d256c4e5"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("341e1be7-1e13-440e-b5ad-19dff652e3ba"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("3431e97a-5669-40d3-b172-a4cf9fcfbe84"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("3434e85c-a14d-4ffe-91b9-8f44d3f174fd"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("34ab4ed1-09b8-4a3b-9f1b-ccf0f409fe4c"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("351d2da9-0917-46b6-84e1-5ddc53920530"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("352fd444-bc8e-49ac-bc0e-1ff8561ba5ed"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("3570cccc-65d6-4121-8b66-c9807e356c79"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("35b4f4b4-e80f-497d-8951-e1b1942945f1"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("36ea31bd-e313-4116-ac28-4db26977d322"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("36f22f35-ecab-4685-bbb1-b2baf3f44f3c"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("37c86cf7-970b-4f82-a32b-e6d44b5c5126"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("37e6ce21-e78d-44a0-9a46-99cf3c3fd8ee"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("38cd76ca-ab19-43e2-8221-41d415b9f73c"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("38f6f5f8-5dba-4488-a8be-d93124cd66dc"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("391c6244-2b2c-41f1-a2e2-7ea13a417be0"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("392a0b2c-353b-470e-b0ea-27d68a7adffe"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("39df913b-739e-4f68-936d-2fd57d44b6df"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("39e7331a-872f-44a7-94b8-1def91ca2e55"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("39f91518-0c52-4a4b-9b01-81134b2269ac"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("3a2c8b0c-3cb0-487d-b27b-6a84da91c3f0"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("3a617948-3551-4adf-ac84-7b333fa76b17"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("3b27a690-f9df-4c1e-8090-f6301ead94de"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("3b339328-7ccb-4744-8793-85e779ec0cae"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("3c487c23-bb1c-4fdf-af61-f183f4329b5c"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("3c726097-c815-4597-98e4-8193de9dd76c"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("3c99ff00-f5bd-4a09-871b-ae0790318e42"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("3d61b0df-3185-4552-926b-89d9a3485a5e"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("3d7c3e74-a914-4f24-99de-da1010102ed9"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("3f07e3bc-cbf2-4a5c-b762-e728bedf0e2f"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("3f53fd0b-07f3-43c1-a0fb-678e22c0d032"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("3fb82e52-e018-4d02-a76f-bedce790bd93"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("42684a31-c73c-4cdd-9227-9d23ede798cf"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("437ab3d9-3ce2-409b-866d-a4fb4117e28f"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("44343bc3-6a62-4515-9b69-802a8333e321"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("44d7c8d3-66f1-49c5-90ba-4504649b56c2"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("44db2336-2396-4b9f-8bb2-9d912b09c548"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("450f9f5a-90ed-4b8e-98e4-2c3c455e6e88"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("47d4bb82-2651-497a-b3be-0d9bdcf0a78e"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("4880a8e1-a1b6-466c-89a9-7fbd813040c0"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("4887643e-63aa-48ad-b03f-feec27d2339b"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("49114ed4-90e8-4251-a848-6b5ba21de28e"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("4c0e0bc9-c255-4402-b67c-3f4948158004"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("4c9fcdb1-d784-4c71-b559-84dc60661d89"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("4d0fd940-474e-47ee-97ca-443c0b403bd0"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("4d12dcb7-7b91-4edc-93ed-6ada8942254f"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("4eb4ad2b-8caf-427f-ac83-5981b4c8bce6"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("4ee60ff9-0a2f-40f8-9659-3fc55204ffda"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("4f772e12-e78c-47a7-8f08-a750d1523297"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("4fa26cbe-76b0-4e3c-b6b1-073eeee572e6"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("4fff2a54-166e-4aee-9610-ff47b3cbe8f8"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("50587860-3b5a-431d-a44a-d5b4ed9096a6"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("50c4cf58-5808-4c99-9f48-1e9698327ff9"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("51ad70c8-f49d-4579-b04d-96804753216c"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("51cd66aa-4c90-4301-ab87-04bdaab22a0c"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("51e974da-9397-43f5-b046-43ed93bacc63"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("523bd851-12e4-426d-9646-eceada518c54"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("536a494f-4bff-441f-b1d2-97a487aa11e6"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("5402c82c-f26d-4f7f-a404-423190007124"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("54bb958e-ab75-495f-aea9-04ec263f74a9"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("54ccd61e-4474-4962-8eb0-1faae4bb74b9"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("54d54c52-9e1f-4b9a-82b7-a590afe69988"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("57413422-2223-4f85-a277-d5bbe55f5aa9"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("57af7203-95ab-4d1d-978b-888a782cef13"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("57dc1619-edb1-4453-b63d-925c2d130aa7"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("58f7746b-870a-4e85-abd3-f7d424e08c51"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("59b39058-341b-49e0-8134-6550a575dd89"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("59fba700-99be-4d88-8eb4-ee450aceefe8"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("5a23fb28-ea9c-4f02-9c73-83abd02385a7"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("5affc710-1f08-4aac-b57e-7803fd579f3d"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("5b4f41b6-9708-4876-a64d-0579b1f8bdf8"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("5b68cbd9-54f3-4a06-87d5-cb9a5d7ff226"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("5bc29d09-1bd3-49af-a62b-52a9683ba3d8"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("5bd232e0-c263-46ff-ab5d-b6adaa37946a"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("5cdb0323-8467-48b4-9bf2-f9a1fe6fffe1"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("5d4ca878-27b8-4a73-b3c8-9c7f101b55d0"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("5fc7acf6-11a7-4a94-8c5d-8a5bef73669b"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("60356998-4c0c-4717-a357-6fda84a05903"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("60ec45cb-9453-4c3f-bdb3-db93713ef1ee"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("6105beb9-b3c9-4e54-af7d-5933d8743d49"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("61759de7-25d7-4754-a432-6859384d0c8b"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("624c6483-0474-4323-80a1-4c0d25bd0fd3"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("62b24efa-9fa5-4d3f-8825-787790d52187"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("62e25483-5c99-414d-9f88-7459b4262ad5"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("63d1be08-7366-46a2-b2c8-ea1f1c048f76"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("640128ed-0a01-4d55-a7cd-2e49dec58abb"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("640b48ff-0235-440d-97d6-e4e348d04cf1"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("644a30b8-2221-4f02-bb08-3aa14b54e080"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("653dec78-c2d1-4adb-b043-5c625504d7ab"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("656c120d-d9f9-40ad-8f77-2301909bd2e5"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("6697d161-6270-4cff-ac92-33bf3d4b8842"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("676882df-a62f-4229-ac8d-97eb5d4726f6"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("693a2375-e18e-4cd0-92b9-85ef0c920990"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("6969c1c5-a226-4b94-865e-1f732474641f"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("699bd2ee-7c3d-42ac-a3d1-34486e58e24a"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("69e76785-297c-4e87-9f23-86f16b085be3"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("6a25b59b-997f-40be-be78-98ca3b1a4b62"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("6a60859f-f639-4f2f-ac4c-cf340dba1565"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("6a7da43f-bc9d-4ed5-8772-f26df643c3b3"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("6ae59487-c65d-4c82-8743-17f56bd83c24"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("6bab3572-c59f-441c-880f-adee5420f678"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("6beedfd6-86be-4b99-ae66-761fcbc7ff3a"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("6d102e88-afd8-4131-80bc-8e6b8c870ff6"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("6d660984-bec3-460c-aeb7-4d95ad917eb9"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("6df5031f-7ec0-4d63-9d11-e15a70e70ab7"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("6e274516-016c-4274-b686-e6fc99bb9c1f"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("6f2b6110-414a-411c-a1c9-7d5bdc6bba5a"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("6feb0676-93de-4c75-823c-d36550aa6a50"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("7010b2ad-f95b-446f-bdf1-0ef8e4fcc5b0"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("70e7089c-bd76-4d3f-91fb-821452fb53ea"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("713dc0db-3810-4aab-b926-0b79d3267837"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("71518b4f-ec4a-4a87-8e62-0f30054f6871"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("71856628-f666-495b-8deb-4749be929afa"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("71c8733c-5e0a-4ea0-8426-ccc6b5398bcc"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("73812f8c-d721-4cf2-be24-3e6b2f0447e1"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("73aa37c1-4b8c-4f91-9152-9fe0408e9925"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("76d01380-5ea3-409f-90f2-d224a9b25ae1"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("7793c65e-40ae-4f94-bf8c-a2dab9bac84d"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("783e95f4-d8e1-4af7-8c76-1773f2b2c834"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("78bc9aa3-d66b-453d-8202-562888b006b9"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("78ca350b-139a-48a4-b899-a161d2549a8f"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("79924263-c3d8-4cdf-b87c-9150dfc4149b"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("7a27ec68-ab83-4b9c-bdae-f27e57417dd3"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("7aa01805-7e34-48bf-ae97-dbe99c410ee9"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("7b017a24-283d-4be7-b968-542c84b13c1a"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("7c674f4c-ffe2-4de9-a8bb-62497d582b8b"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("7c69ce66-febd-4eda-91df-964417566e83"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("7cc300f6-696b-492c-94bc-3a9f088d5681"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("7cdfb7a5-ce27-4d2e-ae7f-578e8d25cc92"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("7d9ca589-cc37-483a-b45d-b533de755b30"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("7dcebab0-f57a-4ac7-b5f0-2ec17c31f8a8"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("7dfd6efe-0e38-4542-93b3-f300b8cb7333"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("7dfeb1f8-8fbb-44ac-b0d2-e6705d8a90ff"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("801b0fae-e874-44b5-9394-0ea8af6e96c1"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("80b46ce3-1cc6-4153-9af7-7d2ac4f7bf36"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("81313adb-1191-4f83-9ee1-9aa5d81a68a5"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("821eb3be-085a-43b3-bf0e-78db0493dae5"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("8240fb56-6c34-48cd-b89b-03d5aafc7a11"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("82484f9c-7d6f-48b5-a2d9-55a904cfeb3e"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("82fdf70b-78be-4c51-b858-0cfbf48937a7"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("856ee217-e282-4b6c-952d-5d0cff9d5491"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("857b8665-9321-4784-b445-078f82a90702"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("860271f4-396e-409e-b251-c53cec3443dd"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("861b7587-ed17-4388-b97b-528c1f300f0a"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("864d60a2-480a-4809-b29a-84744742ebe9"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("87250625-f5b3-4718-812c-37bec82438b6"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("8777ab8c-a7a2-4702-9b7b-fcc9d2bbecdc"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("87b50035-77e8-49e4-8f2b-d9eade455c36"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("88c37823-4113-45a0-8e52-a6544b764403"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("8903e012-3e0e-4520-8aa0-467a51c1a821"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("896f52a4-9a3f-4d45-a1f8-7b71dfbd4c9a"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("89ea2c9b-5b2d-4345-8b38-70a91d47c7ca"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("8acb18c6-95b3-4399-ac0d-006ff8a7e252"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("8b3d14ef-c062-43ad-9850-c396b1259ba6"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("8d53bf3e-a68a-4e31-8cbf-e0ec21ae817e"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("8db16a64-8c72-4136-8630-4f1a9bea22b2"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("8eab7bbc-740e-4527-bfa7-cb583294e4aa"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("8fc8b2e4-ed85-4667-b90d-315bfb3dfd91"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("9062bdb9-5fc7-47a7-b966-5440ff6f7b8f"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("917a3a72-1b18-47c0-a39d-e0d3a4696ffe"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("917dcbb7-4ec4-44cc-a899-a562cfeb0dd1"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("91ddab1d-af9c-4d4c-8336-7bb6ada58078"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("92000e5e-d52d-441f-b7bc-5442d526b954"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("92046c22-96fb-40b8-a2b3-173f58e04c18"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("925d86db-a944-4fcf-a01f-57123268e8bd"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("92e713d1-d19c-4707-be8f-caef27f96f5b"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("92f0dd4f-080e-4736-8fb3-8cffa3576ddd"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("939bbb86-deeb-465c-9430-73ea82650c87"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("9405e365-2f4c-47f6-a0dc-ac6e96d11631"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("94124a45-4464-4dab-924d-0686448314c3"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("94f150fe-b820-4f6e-bc9c-6bfbea461c52"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("952e49df-3350-421f-8c1b-5f5e86533f47"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("976bea11-0bbc-4ee4-982a-ea86fb8c24cc"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("979a5217-1fe5-4f95-9ca4-ddee19dc5eb2"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("97ab1534-2ff8-48fc-a1ac-294efafcf18b"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("98eaa8cd-044d-4013-baa4-216ec144050a"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("99650ed0-3b03-40d3-863d-03368c89e334"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("9979374a-13e3-40e9-80f5-279faaa8d91f"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("9a1f9cdd-777e-4b27-b665-8bc413ccd23c"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("9a2d4769-9d95-4f94-be94-e871b76c1487"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("9a49acfb-0077-410c-93ce-1bb7b2462f34"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("9d31fbd9-53cf-40e5-ad55-3bec7596ddfd"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("9d6340ee-a744-40b2-921e-caabbdd3543e"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("9d7c7883-e73b-4a60-abf0-ebd965be0336"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("9fbc089b-7681-428e-8fd6-a5ccb6319785"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("9fe7a201-aaa8-465e-b10f-6c1ad9a636ec"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("9ff5c837-1303-4aa6-9df1-81eb1ca7df1b"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("a04f8de3-96b8-4c1c-8be7-7976e360bdf6"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("a07b25f9-56bb-4d20-929b-174303da9a94"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("a0c8a064-db00-4f7e-b096-cfd60386991c"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("a116664e-8016-4206-8a51-3fc51e9eacae"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("a255e100-5969-4abd-a9e0-7b325d6f2659"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("a2effa89-1ccb-4ba6-b46f-a9c91701b9a6"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("a38b66ec-f1ff-424b-a9d6-3f5b95b35a45"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("a40c04f2-120c-49f1-83b0-0bf1b0ab21b3"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("a47e2ff5-4d5a-44d5-a002-1c148ff8e325"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("a49e4dcf-8cd0-4410-80cb-7db87959df57"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("a4a60dd7-0716-4a8b-a3a1-eb9637bc601a"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("a5191746-4340-455e-90dd-c4c323b94cde"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("a530106f-1e2b-4e3d-bccb-9e7d2c07575f"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("a63e3faa-43ef-4087-8a0b-9e459c5fae0b"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("a65007fb-d902-4f07-9bb9-a881c8c6eadd"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("a698b405-5e5f-452a-87bb-746509cdeb0c"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("a69f3014-b4d1-49fd-969c-fae3ab838d76"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("a6fb3a36-42a4-4f4f-aca0-11e109776645"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("a77bbadc-1f43-42d9-a4af-a508c8d52b39"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("a792f0d3-f7ef-4a17-a934-56c3594c7af3"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("a88336b4-0b21-415a-8da7-10e38e7fcb09"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("a8c01fb4-8478-4fe6-9409-0d859094eb7f"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("a9035328-0fc1-41aa-a95a-25e9f65db3a9"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("a903c6c2-f379-4076-a9ab-743565f14d66"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("a9baf6ef-a532-4173-ab75-4df966afc714"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("a9cd99ed-1c15-4c94-921c-239d41c0c426"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("aaad05ad-d351-4f44-a0b2-2ae12cf2935c"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("ac2db782-4cf8-486f-9732-0f3298420461"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("acad0c62-61a0-4e55-91d1-0af0c83bfbe0"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("acee53ee-ab8f-49fb-9aa1-e710a1c6483e"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("ae9b44fc-e2d2-4594-a547-7c3d33467859"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("aef148a7-9b84-4f05-926d-428d7f7eeeda"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("afb8563c-7681-4219-b016-3308233822a2"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("b0b3319e-3811-4e8f-a2bb-e6cd5277419b"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("b115e8e2-e8ab-43f0-9772-723018673107"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("b1ab38aa-3877-4c6b-b035-fa1414828093"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("b1e6366c-96ff-4b3e-a0f7-87bbaea4119c"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("b23f1b2f-2e6c-4483-90c5-6732d9f3730d"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("b4a047a1-fc14-4c5b-a623-582d2e63dee4"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("b4d3ab66-fefd-473b-b05e-0c2f60752eab"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("b58d60ea-8f1b-4561-b51b-8649e1166715"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("b66477e2-5ad2-4e08-a4ac-4de902873f88"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("b690c631-6619-4379-9b13-a6febfe7ff83"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("b6ded567-2dd2-4150-8501-5a4b7e259a2e"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("b73b4aef-ad66-4781-b3b4-3eae4f6aeb13"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("b772cce8-7aab-494b-9499-48cf3373ba13"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("b77e3f0e-b7f9-4dfe-ad9f-a78a39cd2dac"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("b84038c8-618f-435c-936a-4840005ed081"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("b89caddb-7a8d-4575-973c-0be5c0cad08d"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("b8eb7a47-bd89-4f87-b87a-9b46803089ed"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("b966bc1b-9420-4a01-a3b3-1bc5871558b1"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("b97e85ce-07b6-4509-bd52-fd2a2809ff2e"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("b9d72042-28cf-45f1-ae6a-0c126fd30750"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("bb401f5a-4370-41ad-bf07-dbd813e83e8b"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("bbc193fa-a349-4c69-98bd-8ecbaf70edda"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("bcd64545-c03f-49af-ad5d-55c5f39dbcb7"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("bcedfd6c-00d3-4215-ab2a-022a6ce2700d"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("bdf6ec25-ecbb-4aa4-b922-b389a81640e1"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("be62fadc-a611-4b45-88b6-e222a8f392f5"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("bebc4d5a-7464-48e7-bc6d-8f6a6f4a7b28"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("c08c82df-88ff-44a2-833f-eb9e200d8156"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("c097c510-836e-4489-8d3a-fa64d53e0be3"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("c1228048-01e5-4994-b74e-4b2a5cf9ed62"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("c17ec7b2-d744-4f99-a8da-b4f62065a36f"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("c1aee592-6919-4266-86f1-ae434f75e953"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("c1f29946-3df8-4e67-9e28-175414372859"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("c25237b5-6705-497d-8bcb-7749f1357cad"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("c2aec327-c8be-4fe3-b2bc-c31954ede7bb"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("c2b25c73-3f20-402c-a074-bc3fde7dd47a"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("c393df75-ee4c-4632-abce-d69670a42f2a"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("c45c399e-3c44-4366-b958-860e974d9eb7"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("c4a7efcc-f81a-4bd5-8f56-66f42644201e"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("c4afa987-4431-4443-a388-8959c17a6bee"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("c4eb4acb-7736-4227-a2a6-5b40cced8f15"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("c50045ae-e1ec-4601-9ac5-fda260552b2f"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("c56e45ee-5397-4e91-b9d3-997545fa8d2e"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("c58dba96-da68-4c26-bc37-3395612abe91"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("c599ded0-b3f1-4593-b69f-ac2b3fe8eeb6"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("c6730fb1-643e-418d-89d4-9566b140c437"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("c87cfbb6-9d33-48b6-b768-5096ee2ed031"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("c8890f87-75bc-4758-b29a-cfec3c158636"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("c8c0af40-9577-4d72-9a70-def3089c3200"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("c8f1bf11-4d29-41ad-9fb9-a8dbda0214ee"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("c9101b85-f84c-4cbd-aa02-1bb1f8e40ba7"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("c91dedd9-78f4-48a4-b99a-c359712983ab"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("c9fd5bff-7daa-4c91-9e03-81cfeddf2930"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("ca5570f9-7802-42d5-9e24-b2635ee8c601"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("ca6a6739-9a1c-43d8-8121-2d7bc6db5ac7"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("cc27825c-3a3f-4b42-9394-92ba103b4049"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("cc5da374-62c5-4d11-bee5-564638ea212f"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("cd03aa23-e911-4ff9-a914-1d82ddb54289"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("cdb8ab00-293f-4a05-a4ed-05ff68e66bdd"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("cdc6d31a-d7ab-4693-80a8-0313a0cb0692"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("ce2ecc47-aa56-44c4-a74e-c73537efd970"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("ce733fb4-3747-420d-bc30-05744b8806fe"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("cec5767f-f079-4845-9910-64c4c08def3a"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("cedf4690-cec0-4613-b778-c498a34b13e5"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("cf2e5ee8-00e9-47fb-9be4-d9a1efa04b41"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("cf8cf81c-a223-4756-af47-2a631becb6f5"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("cfb7ad11-6f54-4a9d-b45f-a6556706e3b5"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("d1dd2593-1bc6-439b-9ed6-da8d0c3368fe"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("d1e0e2e2-7897-484f-b3d3-908daec607b9"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("d2a26857-faf8-4ffa-a911-aa2c8e16b157"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("d307be16-6427-47a0-a18b-3aabc8240760"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("d356764d-5376-45ef-b919-e578b1c0c1c1"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("d3aa80bc-b935-4325-94c5-8604abea31c9"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("d3e46439-710c-4a9b-8dfd-5def7616afb0"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("d4d25725-2b08-4dd2-82ef-ee2695c060b9"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("d4f3e507-bcf4-488d-908e-07e4104f3329"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("d50f033c-15d0-41fb-a96b-27262247e797"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("d5af4071-3efc-46fd-9d36-174a6110a49a"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("d65ff36a-d481-4f75-b3b6-c8ae80125261"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("d6c9f814-3c96-473f-94fe-8447c238ffce"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("d7de48cc-5029-491d-88f0-eebc632d327e"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("d9d2682b-9147-4326-9f7d-e182df5ab3af"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("dc121015-00dc-4c76-b025-c1efca9baf59"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("dc7709c6-333d-4192-b08a-5bc07b41bd28"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("dcca9d22-9bfd-4f1d-bb1b-1ecd495a4a3e"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("dccebc5c-aab3-4016-bd1d-b6f43e8a90e0"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("dd95933f-6a33-4d95-b139-b8b7ad0d983a"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("de26d3a7-0b55-47cd-aee4-f91100c5159c"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("de7aabba-1e99-45ba-97f5-08408a4cf71a"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("ded8d7f1-174f-4992-87e1-a54f24ae243e"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("e0098236-6386-4185-a3ff-6742f1d14bed"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("e02e0046-b32c-4e30-90e8-ec6e74a5bc7e"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("e1361039-aed5-41f9-af67-abc2e4bcd3ae"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("e15814ae-740c-4275-85ed-555889c306a6"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("e2cf14a1-924a-4b77-bde6-5b6d8dc1200f"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("e2fe0e74-7513-483f-9067-623aa7b5ba2f"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("e3173aa0-8496-4227-be3f-3a5480797c1f"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("e335f12f-6f34-4616-b81c-d7d12e3d16f4"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("e33e148b-57b9-4743-8b60-bea2ac4fca6b"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("e3d1c689-1b1e-4e62-8ffa-ad1a074728b6"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("e46110c1-1516-4bbc-9685-aabdc5880a4c"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("e4b84656-b976-43d9-875c-00338f674d32"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("e59adf47-390d-4a07-b199-b8472483a0ae"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("e6c0b216-561a-4006-a8eb-86eb2c117eb6"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("e6decb4c-4b36-40dd-bcec-81b2aaf3d244"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("e82fb733-5548-434c-9278-a92a20883e19"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("e8740f2b-594a-4a35-a28a-43c0884bbb7c"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("e930e74a-2d15-42eb-a5fc-2883438c1b0e"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("e9bfd41a-9e54-4240-babb-f8c0a5989b0a"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("e9efa48e-c151-4e40-8a67-10ea0db310ac"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("eb3d32ec-ddd7-4a0e-a559-ad3795eedd04"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("eb71b418-0ac3-41b6-8437-6815dac88e0d"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("ebbcce5a-8626-4d20-b365-37b6de16a8c9"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("ec4c89d7-12ef-4ad5-ac71-ed3e563475fd"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("ec5cccf0-fff1-4455-8a22-6f7dee249a5d"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("ed253243-4297-46fc-86e9-af9c93e1693c"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("ed2deee1-ba3a-4122-83ee-cd128db9d7b5"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("ef7b75ce-6536-4428-acb2-bcd6eb2304ed"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("efb89a33-f0be-4bcf-b491-f7276e3f02d6"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("f047099b-2d31-4cb0-8503-ecb68dd59e62"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("f05eec8c-4c14-4213-b34c-398b4ca0b6af"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("f1391312-8960-4c15-92f4-02612f1f7974"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("f1b7feb1-1916-4692-a202-20386d6589db"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("f211bbd0-e128-4244-908d-d5e87305428e"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("f29f8d23-995e-441d-8cf7-abfedae53640"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("f2a48ef1-e701-4f48-9e1f-a5d845c59548"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("f3604413-75f8-43d6-9d72-a015612beceb"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("f38fcd51-2fd4-4497-b64a-0fdfcb4c919c"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("f397c2d8-9aa7-45ad-a92c-db3e3347e7a9"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("f3c7fe87-9afe-4b0b-8472-bcac1ba1442d"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("f55c8bb0-e53b-4c51-8b5b-ebcbf9c04689"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("f5daeed0-36c9-4fcc-ad7f-7e8755607465"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("f62fb2fe-05f2-4c1c-a910-b666c05a6651"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("f65fc64a-09b8-428b-a1ee-f0b374de8e98"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("f674daa5-03f9-4960-8ac7-7bd5b04da58c"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("f71496cf-d325-4412-bc77-8821fc6aab9e"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("f774ba7f-dac1-437e-a246-33af19e76b65"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("f7c1890a-0ae7-4692-a366-598206a7b825"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("f7e96088-187a-4488-8dd9-772345bda9f4"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("f84dc11a-cfcf-4de2-a9e7-388ae36f0b10"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("f8caf21f-35fa-41ff-9b16-2e5fe4cf3fea"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("f9fb6e84-669e-41a3-8450-0ed1c8eb5803"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("fa0d8080-510e-45e3-a846-896f30cc6f23"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("fa141053-18e3-4433-b4b7-af028fcd4001"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("fa392d8d-1396-4199-832b-145e0aff19e6"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("fb3da96f-03dc-455e-9e6d-b5a0c87e5dd8"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("fb9261b3-a0ef-4997-b58e-a84d9f1f503a"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("fbb86b18-2829-4421-a2e5-0fcf51402531"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("fc03eaec-38dd-4b63-b817-8f64864cad95"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("fc2d0dd5-aa00-46b0-a5e6-6f5248f0f698"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("fd1a7ce7-c4d3-4c15-be40-94d2c114f3df"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("fd24d496-b38a-4103-bd8b-f46b9e35bf5d"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("fd4cb69a-07ee-4c3a-9469-88f2e74acc45"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("fea0dbbf-7c5e-436e-96eb-91c946a1f0de"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("ff0b04ac-8afd-46ee-8aea-b02ec8368576"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("ff64d72d-7eeb-4d24-a2de-b6d7d269b8b5"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("ffa21caa-d084-4e81-bf2a-ad318c685199"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("ffe6c88d-5b90-4803-b36b-a21565056466"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d398d70f-259b-4b9f-b93d-f51254b9c4d7"));

            migrationBuilder.DeleteData(
                table: "ParkingLots",
                keyColumn: "Id",
                keyValue: new Guid("1eb3a738-9981-4171-8de2-d3e857a3b8bb"));

            migrationBuilder.DeleteData(
                table: "ParkingLots",
                keyColumn: "Id",
                keyValue: new Guid("5af99c7f-d6bf-4dce-9363-018315d9e1ad"));

            migrationBuilder.DeleteData(
                table: "ParkingLots",
                keyColumn: "Id",
                keyValue: new Guid("603467e3-e23d-41ee-aaef-8d21b2e2da6b"));

            migrationBuilder.DeleteData(
                table: "ParkingLots",
                keyColumn: "Id",
                keyValue: new Guid("723a9044-40fe-43ee-9f36-dbd4f21a4b90"));

            migrationBuilder.DeleteData(
                table: "ParkingLots",
                keyColumn: "Id",
                keyValue: new Guid("81749d15-9afa-4294-85b7-82204495d265"));

            migrationBuilder.DeleteData(
                table: "ParkingLots",
                keyColumn: "Id",
                keyValue: new Guid("8452e422-1d9e-418f-9b94-061cbe81e04d"));

            migrationBuilder.DeleteData(
                table: "ParkingLots",
                keyColumn: "Id",
                keyValue: new Guid("9309c264-dc77-4393-97d5-1f5277643f2b"));

            migrationBuilder.DeleteData(
                table: "ParkingLots",
                keyColumn: "Id",
                keyValue: new Guid("a1282826-8649-4590-9393-4430b27b802b"));

            migrationBuilder.DeleteData(
                table: "ParkingLots",
                keyColumn: "Id",
                keyValue: new Guid("ab78e541-dbbc-4124-bb86-ceb6d75cb71b"));

            migrationBuilder.DeleteData(
                table: "ParkingLots",
                keyColumn: "Id",
                keyValue: new Guid("cc8a4163-4cf3-467d-93a3-5dc0e15bab05"));

            migrationBuilder.DeleteData(
                table: "ParkingLots",
                keyColumn: "Id",
                keyValue: new Guid("e0bcde6c-3c72-4b55-a18f-f84fd8581131"));

            migrationBuilder.DeleteData(
                table: "ParkingLots",
                keyColumn: "Id",
                keyValue: new Guid("e85ec22e-df00-4afc-b1fb-2ca408f15d96"));

            migrationBuilder.DeleteData(
                table: "ParkingLots",
                keyColumn: "Id",
                keyValue: new Guid("fcc43452-25c4-48cb-a440-1cc413ed3422"));

            migrationBuilder.DeleteData(
                table: "ParkingLots",
                keyColumn: "Id",
                keyValue: new Guid("fe712484-2abf-43e2-a9f7-e67b9d2f0d04"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("0198067d-e43d-4ee8-98ed-78cdfb16127e"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("04bc6985-a3b0-42b8-9489-8c51f2a767ad"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("05797788-d09b-4495-93cd-61110c39b6d3"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("333e0f0c-5327-4d20-af23-74d79ac2539d"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("3359881d-43d8-4ab7-a493-c0f09ac8ca16"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("45bdf08d-a6d1-436e-affa-140d585e3308"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("4ecd5b1b-83eb-4584-8508-20f817bbdfce"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("4f6a8680-9d91-4972-aa94-43f7a86cb417"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("5571c0af-39d6-4a12-b2e8-8d23086fe1c7"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("62b37eec-de31-4d7d-9e2c-8c743e959306"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("6a1c00cc-4c87-4551-8931-4db3c364e81c"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("7c146bc4-5207-4c98-a35d-499d6c9193be"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("80158100-aca5-4646-9b0b-a818fb9a66ce"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("81b0e497-de75-47e8-870a-867d817c12e7"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("a3960301-298c-46d1-aa04-5d9da60b9cdb"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("c317457e-c212-45a8-a033-ba03060180f1"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("c659421d-3a4f-4f93-b5cc-e35b0298d649"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("e4bb636a-6455-4dd5-80ce-858cd7b9ca6b"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("f2e43a54-c44d-4072-bebf-c88962cc0d1b"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("f4c378da-7ac0-40a0-a2ad-2f5de2063ef3"));

            migrationBuilder.DeleteData(
                table: "ParkingLots",
                keyColumn: "Id",
                keyValue: new Guid("11137c72-b421-4023-ad31-7d82db8a5baa"));

            migrationBuilder.DeleteData(
                table: "ParkingLots",
                keyColumn: "Id",
                keyValue: new Guid("1bc3d521-4279-4b9d-83d2-647d18bc7a50"));

            migrationBuilder.DeleteData(
                table: "ParkingLots",
                keyColumn: "Id",
                keyValue: new Guid("438cd333-aa34-4a4d-b514-bbdc4a0cb506"));

            migrationBuilder.DeleteData(
                table: "ParkingLots",
                keyColumn: "Id",
                keyValue: new Guid("55551648-de97-4052-9014-293666338e1d"));

            migrationBuilder.DeleteData(
                table: "ParkingLots",
                keyColumn: "Id",
                keyValue: new Guid("599951ba-457b-418b-b563-98eb4b0420f6"));

            migrationBuilder.DeleteData(
                table: "ParkingLots",
                keyColumn: "Id",
                keyValue: new Guid("6f263ffd-8bc7-41fc-a9a4-578f892bd452"));

            migrationBuilder.DeleteData(
                table: "ParkingLots",
                keyColumn: "Id",
                keyValue: new Guid("736ed698-7b98-41d4-90d4-4d6f13415fba"));

            migrationBuilder.DeleteData(
                table: "ParkingLots",
                keyColumn: "Id",
                keyValue: new Guid("8c0a0b6c-ba87-4875-a11d-dec8b1eae16a"));

            migrationBuilder.DeleteData(
                table: "ParkingLots",
                keyColumn: "Id",
                keyValue: new Guid("99372c3d-5903-4a9c-b0b9-0cd15f55658e"));

            migrationBuilder.DeleteData(
                table: "ParkingLots",
                keyColumn: "Id",
                keyValue: new Guid("a669c2aa-41e8-4ff2-b1bf-6dc0ba156402"));

            migrationBuilder.DeleteData(
                table: "ParkingLots",
                keyColumn: "Id",
                keyValue: new Guid("ac366bab-6ac1-4215-a22a-7241bb2c5727"));

            migrationBuilder.DeleteData(
                table: "ParkingLots",
                keyColumn: "Id",
                keyValue: new Guid("b185c801-7cf9-4792-925b-96f8471d9c99"));

            migrationBuilder.DeleteData(
                table: "ParkingLots",
                keyColumn: "Id",
                keyValue: new Guid("b5ce9eb5-9343-475e-922b-8d2d1494b13f"));

            migrationBuilder.DeleteData(
                table: "ParkingLots",
                keyColumn: "Id",
                keyValue: new Guid("d62d31f9-9ced-4f7d-9ec5-e935519cd731"));

            migrationBuilder.DeleteData(
                table: "ParkingLots",
                keyColumn: "Id",
                keyValue: new Guid("e44df884-6d22-4568-ab33-be0090e61fe2"));

            migrationBuilder.DeleteData(
                table: "ParkingLots",
                keyColumn: "Id",
                keyValue: new Guid("e515ae1f-6859-4ea3-9dd9-8fb9d224f8c8"));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("1a6ef942-b31f-4dc0-a02c-d13159805229"), null, "Admin", "ADMIN" },
                    { new Guid("43cbb005-d8b1-4755-8f5b-8c8bf995fd1e"), null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedAt", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("484d700c-6ad8-4f37-be6d-14dacb11597c"), 0, "1234567890", new DateTime(2025, 1, 5, 23, 26, 57, 940, DateTimeKind.Local).AddTicks(3123), "faker@example.com", true, "faker", "faker", false, null, "FAKER@example.com", "FAKER", "1234567890", "1234567890", false, "1234567890", false, "faker" });

            migrationBuilder.InsertData(
                table: "ParkingLots",
                columns: new[] { "Id", "Address", "Description", "Latitude", "Longitude", "Name" },
                values: new object[,]
                {
                    { new Guid("0ada6bc9-6665-49b2-a427-5ad008b51fda"), "9260 Pfannerstill Loop, Conroyborough, Eritrea", "Dicta sed recusandae et quod.", 23.755017789316131, 90.361643981355769, "Fay - Roob" },
                    { new Guid("188984fb-f6f2-43a8-8f42-5761cf166a56"), "9334 Towne Heights, Marksberg, Greenland", "Quasi voluptatem perspiciatis et ullam molestiae.", 23.757423792189542, 90.394926870758397, "Hauck and Sons" },
                    { new Guid("19bcc6b0-45ed-4845-b411-400d4f6683b2"), "963 April Common, Brakusview, Malta", "Asperiores officiis aut officiis eligendi quam rerum repellat sequi.", 23.903685344927876, 89.133098941968285, "Davis, Boyle and Heller" },
                    { new Guid("1a0fc976-15ce-4e8e-9ce1-e01456178b41"), "3648 Gulgowski Freeway, Quigleyville, Belarus", "Ex accusamus aliquid ut qui incidunt et dolore aut.", 23.768026306099074, 90.364321418418825, "Corwin - Tillman" },
                    { new Guid("257b5f9f-b092-41af-beb1-2a2808fe0fc8"), "774 Jodie River, Kesslerport, Republic of Korea", "Aut magni deleniti odio similique aut et quaerat maxime.", 23.75562795548672, 90.439132072670546, "Moore and Sons" },
                    { new Guid("2848fcc2-f6b3-4b91-a829-47543cd6f877"), "898 Cecilia Springs, South Faymouth, Reunion", "Nam libero enim qui quos quaerat.", 23.780197270099844, 90.422840391691864, "Auer, Connelly and Hane" },
                    { new Guid("2cde977d-867d-40de-9a10-432b2301464c"), "8176 Ayana Wall, West Merleberg, Nepal", "Dolore vel id modi ut voluptatum consequatur.", 23.784466557532522, 90.347863293885283, "Anderson LLC" },
                    { new Guid("31faa74a-240a-4f20-a8e9-fc79657b09d4"), "86057 Price Parkway, West Jackelineton, Bosnia and Herzegovina", "Blanditiis sit ratione rerum.", 23.779441578741398, 90.425096168003222, "Renner LLC" },
                    { new Guid("322b8d0b-4524-4cd9-b4e5-1312d61fa572"), "79670 Rico Crescent, West Toni, China", "Voluptates iure omnis quisquam.", 23.740668958487891, 90.343684182979757, "Hansen - Kautzer" },
                    { new Guid("38633289-34c0-438f-b007-976f825ec000"), "814 Schiller Light, Port Perryfurt, Vanuatu", "Accusamus consequuntur eaque illo.", 23.761788779509683, 90.388395212234315, "Collier - Gutmann" },
                    { new Guid("387a98b1-c216-4873-9812-b12a9aca5ac7"), "0886 Kenneth Ranch, North Edna, Bouvet Island (Bouvetoya)", "Atque voluptatum nisi sed eos qui debitis illum.", 23.890686602949831, 89.156507170924044, "Bauch, Larson and Streich" },
                    { new Guid("3d85c54a-5fcb-49b5-a370-4c5d3216ae4f"), "673 Willow Spurs, Peterchester, Wallis and Futuna", "Voluptatem ut adipisci repellat.", 23.762337441801854, 90.340614605117352, "Keebler and Sons" },
                    { new Guid("3f771136-710d-4c9b-94ca-00b8c3abdd93"), "2896 Lane Turnpike, Desmondmouth, Antigua and Barbuda", "Quo et repudiandae sed necessitatibus vitae illum consectetur assumenda ad.", 23.902579472529901, 89.133090175953342, "Gusikowski - O'Reilly" },
                    { new Guid("495b86e8-5b8f-4f62-8ade-e8152d743878"), "667 Trevor Valleys, New Shirleyfurt, Christmas Island", "Iure eos et laboriosam et.", 23.786248088358171, 90.412935984642985, "Tromp - Harris" },
                    { new Guid("52688c85-e7f4-47e9-b9f2-d508de79f823"), "7418 Declan Club, South Kolbyside, Malawi", "Quae est eum.", 23.901040476238709, 89.103291520012363, "Shields - Schneider" },
                    { new Guid("59e5fd81-c04a-450d-bdd6-c36e80361881"), "4835 Rashad Camp, Adalbertofort, Virgin Islands, British", "Voluptatem sed dolores eligendi facere ut incidunt dolor.", 23.897643941405963, 89.106001111121685, "Heidenreich, Wilkinson and Ryan" },
                    { new Guid("59eb481c-e88b-4a04-93c8-aa9fad3b8fbd"), "59900 Gerlach Loaf, West Nelda, Lebanon", "Repudiandae rerum corporis quaerat adipisci veritatis tempore est omnis quam.", 23.886170891909138, 89.109986457468608, "Koch, Weimann and Robel" },
                    { new Guid("5a694bc0-b3ea-4d3b-b228-1555a8738e1d"), "72529 Mohr Locks, New Trentville, Bulgaria", "Recusandae consequuntur fugiat harum adipisci cumque.", 23.759809028286632, 90.32563014351706, "Goyette, VonRueden and Ward" },
                    { new Guid("5db7d818-7b21-4b81-8cf8-99d99ffaf375"), "56128 Murazik Pines, Dangeloburgh, Cote d'Ivoire", "Nam sit non explicabo cum dolores ab est quisquam et.", 23.89485722140293, 89.130514899388871, "Schowalter - Hermiston" },
                    { new Guid("610d361a-c14c-4e3a-9ddb-700cd803bb7d"), "7805 Howe Freeway, Starktown, Eritrea", "Eum voluptas velit cum est corporis.", 23.883834884736434, 89.111685302545382, "Moen - Gutkowski" },
                    { new Guid("635a063b-8794-4510-b61d-899c3b425034"), "56833 Keyshawn Causeway, New Janet, Samoa", "Expedita qui recusandae eos nihil cupiditate repudiandae qui minus ad.", 23.891943565205747, 89.146405704723719, "Hudson LLC" },
                    { new Guid("6caabf59-5600-43f0-98c9-ab24acf0dadf"), "9292 Price Course, Ratkefurt, Liechtenstein", "Dignissimos velit expedita officia.", 23.901047962901526, 89.126894119147067, "Hermann and Sons" },
                    { new Guid("6f8b493b-9523-43ba-9a39-6080882550be"), "1081 Tania Shoal, Leonardofurt, Ethiopia", "Non distinctio exercitationem incidunt.", 23.906359937995301, 89.137053287510327, "Carter - Boyer" },
                    { new Guid("70713bfe-20a7-4b8e-bcc9-7cd0e57ae2cf"), "3854 Streich Rue, West Linda, Pakistan", "At est rem tempora.", 23.888735837139965, 89.130947770724617, "Pouros - Ankunding" },
                    { new Guid("7140654e-28d2-494f-a602-8bb6bff2fc13"), "2067 Mabel Courts, North Peggieburgh, Mali", "Ducimus et ea eius reprehenderit sed voluptatem est blanditiis.", 23.898805836367565, 89.153026704642883, "Franecki LLC" },
                    { new Guid("7b821087-607f-4dd9-a07b-18f22d1c8fd8"), "18378 Kailyn Streets, West Janiston, Brazil", "Quasi quo enim vitae modi autem.", 23.901733816173174, 89.122584701735491, "Walter, Prosacco and Schroeder" },
                    { new Guid("85611762-85eb-4a9a-a993-dc85d0a68cca"), "87896 Marcel Locks, Marciaberg, Samoa", "Quod voluptates occaecati voluptatum tenetur totam.", 23.896415598659615, 89.106605365275996, "MacGyver, Rosenbaum and Quigley" },
                    { new Guid("86f938e1-046b-4c2d-80ba-6eb7d3f4b2b9"), "4960 Aglae Unions, Finnfurt, Ecuador", "Et harum maiores architecto veritatis enim quibusdam.", 23.751839575772067, 90.409748865599198, "Russel - Beier" },
                    { new Guid("8886b676-b97c-4d0b-ae45-d18b2f2df900"), "400 Meggie Springs, Destinyton, Cyprus", "Sit reiciendis ut non voluptas dolores quisquam.", 23.893554808095523, 89.09704666646924, "Simonis, Price and Satterfield" },
                    { new Guid("891fbb4c-6ace-4cd9-ba70-deb2d06886bc"), "86707 Joannie Extension, East Dejaburgh, Tanzania", "Sit ut ullam explicabo laudantium consequatur.", 23.746078333893553, 90.369015437809523, "Mayert, Stark and Welch" },
                    { new Guid("8e054a25-6fd3-4e9d-b12b-aaa8e6ac85eb"), "32588 Saul Loaf, Lake Israel, Faroe Islands", "Non eveniet repudiandae et.", 23.786653458020979, 90.356775407918377, "Sauer - Wilkinson" },
                    { new Guid("930245a8-ee38-4501-a6ec-b31839348aaa"), "39464 Breitenberg Inlet, Korbinfort, Montenegro", "Iusto tenetur voluptas earum sint eum aut itaque nemo.", 23.903761952349427, 89.15450128473762, "Mante, Conn and Bergstrom" },
                    { new Guid("9c6c5b2a-00b3-448c-81cc-a9010d2d4196"), "12739 Heller Freeway, Bernieceland, Morocco", "Dolorem repudiandae occaecati nam necessitatibus itaque reprehenderit.", 23.895773851854674, 89.153915117020546, "Parker, Harris and Cremin" },
                    { new Guid("a8827db7-700c-4e56-94f6-2a77e3f61a9c"), "87567 Ritchie Grove, New Madonnamouth, Egypt", "Beatae nesciunt eaque.", 23.759584530269898, 90.351193042326329, "Klocko, Effertz and Ankunding" },
                    { new Guid("aae01dc0-240f-4c2b-85b8-db1d578305ed"), "73735 Hagenes Court, Donnellyside, Anguilla", "Quisquam quos vel in aut eum.", 23.889618325521507, 89.149753873154808, "Wiegand - Gleason" },
                    { new Guid("ae16885c-9a8e-49a8-b817-0be9a9960d0f"), "074 Barton Place, South Verla, Guam", "Odio voluptas eos at non.", 23.771903820318411, 90.423006342379566, "Romaguera, Breitenberg and Pouros" },
                    { new Guid("b26c6185-7128-4959-b92d-665002dce200"), "7380 Alva Gateway, Jevonfurt, Morocco", "Ratione ut ut sed aut assumenda est.", 23.747380508730817, 90.388078795169207, "Beier, Renner and Spinka" },
                    { new Guid("b75467ff-4404-40c1-8269-b787f50a14dc"), "70030 Bernice Burg, South Kristianmouth, Ecuador", "Quo neque iste nisi aut temporibus.", 23.905136557887108, 89.105594840712172, "Effertz LLC" },
                    { new Guid("bcf6224b-83e4-44b6-84b7-9a5b11f6f78d"), "085 Marks Forest, Yvetteview, Bolivia", "In cupiditate delectus consequatur.", 23.884098596315447, 89.137744496101419, "Robel - Shanahan" },
                    { new Guid("bf21db4e-8dd6-4bc3-9d0d-1e673e3c0541"), "97599 Glover Bridge, Eileenshire, Aruba", "Numquam aliquam modi molestiae dolore voluptatem qui.", 23.765037020696035, 90.415933904804248, "Ledner LLC" },
                    { new Guid("c23b858e-6380-4605-81ed-fae4578261ea"), "28184 Kaden Stream, Connellyfurt, American Samoa", "Alias suscipit quam velit reprehenderit.", 23.888654893817147, 89.150714562931228, "Brakus - Simonis" },
                    { new Guid("c4fb855c-c3fd-4224-909c-e4cb4ebef275"), "05350 Maurice Summit, Juliusberg, Solomon Islands", "Ea corrupti laboriosam aut voluptatem consequatur voluptatem excepturi sit.", 23.776013626365639, 90.432747783524917, "Schuppe - Buckridge" },
                    { new Guid("c5174f79-1a96-4d56-ae5b-b089b385e4f5"), "240 Breanna Crescent, Uptonland, Saint Helena", "Beatae sint harum dolorem ipsa officiis ut aspernatur est distinctio.", 23.899588335677127, 89.15415111638508, "Rolfson - Rodriguez" },
                    { new Guid("cf8ba59d-1e62-43aa-b128-f92651d868c4"), "11021 Norma Lake, New Altheafort, Pakistan", "Eum voluptas unde recusandae temporibus totam consectetur.", 23.73753889894201, 90.429540330203366, "Roberts - Hansen" },
                    { new Guid("cfba1888-af59-40c6-bf90-ff89882538a3"), "225 Steve Street, West Lavonne, Turkmenistan", "Aut minima occaecati illo tempora voluptatibus nihil recusandae rerum doloremque.", 23.74063228479492, 90.356762800012874, "Kuphal Group" },
                    { new Guid("d09a2181-65c3-4ee5-b8b3-d4ea251a8fbf"), "3332 Kub Landing, Port Minamouth, Cyprus", "Et corrupti id tempora et fugiat illum delectus accusamus.", 23.756764300857473, 90.352914857436318, "Kessler - Barrows" },
                    { new Guid("d6240ccd-9331-4c53-91af-3b1992316096"), "610 Seth Landing, Lorenaton, Lithuania", "Voluptatum nostrum omnis aut fuga sed.", 23.743528031968431, 90.35456547077969, "Volkman Group" },
                    { new Guid("d65b48a9-6c74-44b4-aaf3-635151fa5984"), "585 Ambrose Crossing, Darioport, Western Sahara", "Qui rerum ipsam inventore minima facere ullam et.", 23.783431846959733, 90.392797364752909, "Smitham Inc" },
                    { new Guid("dab1d406-ad92-4844-b279-1cd9dfb40639"), "887 Boyer Isle, West Jedland, French Southern Territories", "Consequatur rerum provident reiciendis quia atque quia corrupti nesciunt vitae.", 23.904724833240685, 89.112461157004645, "Jacobs, Nader and Heathcote" },
                    { new Guid("e21cdfc0-d3d8-47cc-8b74-bdf62436fcdb"), "27846 Sienna Freeway, East Erick, Malaysia", "Fugiat voluptas saepe odit quia iure necessitatibus quam et.", 23.785195401401371, 90.373039918020098, "Pfeffer, Williamson and Grimes" },
                    { new Guid("e2826ba2-5ca3-4ce6-ac50-811f085e3cf6"), "67342 Homenick Oval, New Kyraberg, Indonesia", "Maiores excepturi commodi quasi.", 23.902656502388158, 89.101412727912574, "Flatley and Sons" },
                    { new Guid("e3c60e04-8b6c-497d-b040-30019f1951fe"), "01357 Feeney Bypass, Bodemouth, Cameroon", "Quisquam accusantium sint adipisci.", 23.886264321786225, 89.106740772871902, "Wintheiser LLC" },
                    { new Guid("e5cb274b-9061-42f7-aff5-97663074409e"), "49524 Ortiz Passage, North Johann, Lesotho", "Aut dolores maiores maxime deleniti hic dolorem.", 23.73770385516525, 90.343185393703962, "Swift - Kulas" },
                    { new Guid("eb384a62-fea4-491c-a7a3-8a4e2c92b0c6"), "7169 Alessia Mission, East Angel, Venezuela", "Qui praesentium magni fuga non.", 23.751841668637812, 90.431281551321931, "Wolff - Bergstrom" },
                    { new Guid("f3297de4-ea7b-42da-993e-9ae374023e94"), "4926 Gorczany Point, Port Austynland, Colombia", "In repellendus rerum mollitia.", 23.898353893482785, 89.132500215501693, "Lockman, Runolfsdottir and Simonis" },
                    { new Guid("f35520f7-2e5e-4340-ba78-c10259f8c8c5"), "981 Cummerata Valleys, North Shakiratown, Sudan", "Libero et sit natus fuga maxime sapiente cupiditate.", 23.902851325545235, 89.103005710094038, "Koch - Hand" },
                    { new Guid("fc11e465-6669-4617-a41f-a1d1c76a908a"), "717 Bulah Flats, Blakechester, Syrian Arab Republic", "Eos laborum natus ipsam.", 23.740778972852912, 90.332105438992841, "Swaniawski - Medhurst" },
                    { new Guid("fc2a8276-f127-4246-86dc-4d2b3262ed86"), "749 Purdy Ville, New Haven, Tokelau", "Vel voluptatum quasi.", 23.895136540169979, 89.133819962852925, "Becker Inc" },
                    { new Guid("fd6deed8-c835-4168-8d92-abafacbe20b6"), "973 Hauck Road, West Nedraville, French Southern Territories", "Rerum fugit qui optio voluptates quis velit ea numquam.", 23.902720927952473, 89.132586598001097, "Reichert LLC" },
                    { new Guid("fe188580-6e2f-4ff8-a49e-814745f688b7"), "44732 Weissnat Place, Langworthshire, Cote d'Ivoire", "Neque aperiam magnam et inventore et.", 23.780022237147993, 90.442798145549048, "Auer, Gleason and McClure" }
                });

            migrationBuilder.InsertData(
                table: "ParkingSpaces",
                columns: new[] { "Id", "ParkingLotId", "PricePerHour", "SectionName", "SpotNumber", "VehicleType" },
                values: new object[,]
                {
                    { new Guid("001251cc-d62a-4898-860e-edcf7c9f2b82"), new Guid("2848fcc2-f6b3-4b91-a829-47543cd6f877"), 300.0, "A", 7, "TRUCK" },
                    { new Guid("00190733-47c2-4d72-9b3a-5fb225a49db8"), new Guid("31faa74a-240a-4f20-a8e9-fc79657b09d4"), 300.0, "A", 2, "TRUCK" },
                    { new Guid("0077f4a8-8e98-4418-8eb7-acf2acb45cef"), new Guid("891fbb4c-6ace-4cd9-ba70-deb2d06886bc"), 300.0, "B", 6, "TRUCK" },
                    { new Guid("009a2b54-43d0-427d-9777-5405f0cae6d9"), new Guid("b26c6185-7128-4959-b92d-665002dce200"), 300.0, "A", 3, "TRUCK" },
                    { new Guid("00d2ea3c-ac48-4184-a0ac-83520d1c4a07"), new Guid("fc2a8276-f127-4246-86dc-4d2b3262ed86"), 100.0, "B", 5, "CAR" },
                    { new Guid("00dfeda2-497b-46a7-85f9-c465d3081de4"), new Guid("70713bfe-20a7-4b8e-bcc9-7cd0e57ae2cf"), 200.0, "A", 1, "VAN" },
                    { new Guid("00e15d14-428a-496f-a9bf-1733228d372c"), new Guid("fc2a8276-f127-4246-86dc-4d2b3262ed86"), 100.0, "B", 6, "CAR" },
                    { new Guid("01388abe-0f89-4241-bb0d-50c3c2d6ca5f"), new Guid("d09a2181-65c3-4ee5-b8b3-d4ea251a8fbf"), 100.0, "B", 7, "CAR" },
                    { new Guid("01c84b6e-a9c0-42b9-bbea-85c095a781f3"), new Guid("bcf6224b-83e4-44b6-84b7-9a5b11f6f78d"), 100.0, "A", 1, "CAR" },
                    { new Guid("01c8ded2-6485-4a0b-9113-7159023d350f"), new Guid("bcf6224b-83e4-44b6-84b7-9a5b11f6f78d"), 100.0, "A", 5, "CAR" },
                    { new Guid("02137a89-1c80-43d5-9764-d7d08e6023e7"), new Guid("c5174f79-1a96-4d56-ae5b-b089b385e4f5"), 300.0, "B", 4, "TRUCK" },
                    { new Guid("023f3d24-33d6-4b9a-9dc1-5b0e6b1fb871"), new Guid("cf8ba59d-1e62-43aa-b128-f92651d868c4"), 300.0, "A", 4, "TRUCK" },
                    { new Guid("027a287b-17f0-4e00-b6e2-921a24d53cc9"), new Guid("59eb481c-e88b-4a04-93c8-aa9fad3b8fbd"), 200.0, "B", 7, "VAN" },
                    { new Guid("028f49da-2e4b-41c9-97b5-993442eb7d3e"), new Guid("930245a8-ee38-4501-a6ec-b31839348aaa"), 100.0, "A", 8, "CAR" },
                    { new Guid("02f30cc4-3ce7-4331-9355-269828994901"), new Guid("7140654e-28d2-494f-a602-8bb6bff2fc13"), 50.0, "B", 4, "MOTORCYCLE" },
                    { new Guid("02f824ca-de90-4a11-b808-81a1b6c2c14c"), new Guid("8886b676-b97c-4d0b-ae45-d18b2f2df900"), 100.0, "A", 7, "CAR" },
                    { new Guid("034962cb-8d20-4b41-8745-66825f4e2b06"), new Guid("bf21db4e-8dd6-4bc3-9d0d-1e673e3c0541"), 300.0, "A", 4, "TRUCK" },
                    { new Guid("036a764c-5ecb-467d-944e-cc60d18ba1cd"), new Guid("f35520f7-2e5e-4340-ba78-c10259f8c8c5"), 100.0, "B", 2, "CAR" },
                    { new Guid("03a38f89-2dda-4412-b189-0b33940d6c74"), new Guid("bcf6224b-83e4-44b6-84b7-9a5b11f6f78d"), 100.0, "A", 2, "CAR" },
                    { new Guid("0417bb31-b4ac-409c-8abe-13195664f9df"), new Guid("e21cdfc0-d3d8-47cc-8b74-bdf62436fcdb"), 300.0, "B", 6, "TRUCK" },
                    { new Guid("041f4f48-72b4-45c0-82c9-70309c2f9971"), new Guid("0ada6bc9-6665-49b2-a427-5ad008b51fda"), 100.0, "B", 4, "CAR" },
                    { new Guid("042b6642-4b90-41cd-8f83-278a20b5ea94"), new Guid("5db7d818-7b21-4b81-8cf8-99d99ffaf375"), 200.0, "B", 3, "VAN" },
                    { new Guid("0442051b-024a-4eef-b6ab-1e0bcd9e561c"), new Guid("fe188580-6e2f-4ff8-a49e-814745f688b7"), 300.0, "A", 2, "TRUCK" },
                    { new Guid("04ba7c6f-9d17-40d1-8e07-c03a85393b90"), new Guid("ae16885c-9a8e-49a8-b817-0be9a9960d0f"), 300.0, "A", 5, "TRUCK" },
                    { new Guid("056807ab-b26d-47c5-be7a-6d5a371ba36d"), new Guid("e2826ba2-5ca3-4ce6-ac50-811f085e3cf6"), 100.0, "B", 1, "CAR" },
                    { new Guid("05e637ba-7f1d-42d7-9e0a-f305d29fd07a"), new Guid("e21cdfc0-d3d8-47cc-8b74-bdf62436fcdb"), 200.0, "A", 2, "VAN" },
                    { new Guid("06ead2cf-f6dd-419d-af38-4f877569470d"), new Guid("188984fb-f6f2-43a8-8f42-5761cf166a56"), 300.0, "A", 8, "TRUCK" },
                    { new Guid("072311f9-a1df-4fd2-8192-95ce3bdaa39c"), new Guid("fe188580-6e2f-4ff8-a49e-814745f688b7"), 300.0, "A", 8, "TRUCK" },
                    { new Guid("075a4151-cfac-4a57-8ea6-72a58f7eb6a9"), new Guid("891fbb4c-6ace-4cd9-ba70-deb2d06886bc"), 300.0, "B", 5, "TRUCK" },
                    { new Guid("07864be6-8512-4d81-aaa1-b2273c93657d"), new Guid("635a063b-8794-4510-b61d-899c3b425034"), 200.0, "A", 4, "VAN" },
                    { new Guid("07df8a7e-eb1f-4d42-bfc8-4b7c77df731e"), new Guid("6caabf59-5600-43f0-98c9-ab24acf0dadf"), 100.0, "B", 1, "CAR" },
                    { new Guid("08186908-d500-4b89-90de-1b59aa062afc"), new Guid("85611762-85eb-4a9a-a993-dc85d0a68cca"), 300.0, "A", 5, "TRUCK" },
                    { new Guid("09402872-1a2f-4ca6-9365-28b62cb3b5cf"), new Guid("387a98b1-c216-4873-9812-b12a9aca5ac7"), 300.0, "A", 4, "TRUCK" },
                    { new Guid("0968ca26-b580-45ab-96e0-0f48492876f0"), new Guid("5a694bc0-b3ea-4d3b-b228-1555a8738e1d"), 200.0, "A", 8, "VAN" },
                    { new Guid("09e404f6-c557-4522-908e-3142b797602d"), new Guid("8886b676-b97c-4d0b-ae45-d18b2f2df900"), 100.0, "A", 6, "CAR" },
                    { new Guid("09f32392-8857-4f72-978f-ee0f87fea25d"), new Guid("cfba1888-af59-40c6-bf90-ff89882538a3"), 100.0, "A", 3, "CAR" },
                    { new Guid("09f50a77-a2af-4698-8427-833fa2883c5a"), new Guid("495b86e8-5b8f-4f62-8ade-e8152d743878"), 50.0, "B", 4, "MOTORCYCLE" },
                    { new Guid("0a0aba48-da1d-4a49-b9af-4e297f5cb81e"), new Guid("3d85c54a-5fcb-49b5-a370-4c5d3216ae4f"), 200.0, "A", 5, "VAN" },
                    { new Guid("0a1fedf8-0fe6-49a9-beb7-babd28443f5d"), new Guid("31faa74a-240a-4f20-a8e9-fc79657b09d4"), 200.0, "B", 3, "VAN" },
                    { new Guid("0a364202-5893-4438-9fdd-3837a80641a2"), new Guid("fe188580-6e2f-4ff8-a49e-814745f688b7"), 300.0, "A", 7, "TRUCK" },
                    { new Guid("0a5a7400-8989-4ee7-a47a-3e368245b65e"), new Guid("9c6c5b2a-00b3-448c-81cc-a9010d2d4196"), 300.0, "A", 3, "TRUCK" },
                    { new Guid("0a842c27-c33b-4278-afb8-400fa2049b7b"), new Guid("dab1d406-ad92-4844-b279-1cd9dfb40639"), 200.0, "B", 4, "VAN" },
                    { new Guid("0aa3b51b-ef30-40c5-8dd1-2f6a07fad40b"), new Guid("52688c85-e7f4-47e9-b9f2-d508de79f823"), 100.0, "B", 3, "CAR" },
                    { new Guid("0aecfc4b-1984-4dd7-a140-bc8f29f2fe17"), new Guid("cfba1888-af59-40c6-bf90-ff89882538a3"), 100.0, "A", 5, "CAR" },
                    { new Guid("0b0cacfa-dd7e-4969-81ae-aa059dee3c74"), new Guid("b75467ff-4404-40c1-8269-b787f50a14dc"), 100.0, "A", 7, "CAR" },
                    { new Guid("0b1fe6bd-144c-45bf-b2d8-d1a81d5e6b6b"), new Guid("85611762-85eb-4a9a-a993-dc85d0a68cca"), 50.0, "B", 8, "MOTORCYCLE" },
                    { new Guid("0b260d14-3ca6-4d97-8aaf-fd2c7bc7c31e"), new Guid("8e054a25-6fd3-4e9d-b12b-aaa8e6ac85eb"), 200.0, "A", 3, "VAN" },
                    { new Guid("0b4e8d4b-a881-480c-95a5-4b8969821137"), new Guid("d6240ccd-9331-4c53-91af-3b1992316096"), 100.0, "A", 2, "CAR" },
                    { new Guid("0b58a077-5f10-455f-bf5e-f0a85ad85089"), new Guid("70713bfe-20a7-4b8e-bcc9-7cd0e57ae2cf"), 200.0, "A", 5, "VAN" },
                    { new Guid("0b9ce54a-4aea-4721-af4b-485af9ff5e1d"), new Guid("e3c60e04-8b6c-497d-b040-30019f1951fe"), 300.0, "A", 7, "TRUCK" },
                    { new Guid("0bcf6bba-2763-458a-9687-4bd54afe62e9"), new Guid("2cde977d-867d-40de-9a10-432b2301464c"), 50.0, "B", 8, "MOTORCYCLE" },
                    { new Guid("0bd64e36-2b99-471d-a4bb-ad1796730940"), new Guid("5a694bc0-b3ea-4d3b-b228-1555a8738e1d"), 100.0, "B", 1, "CAR" },
                    { new Guid("0bf74b48-90d5-4988-a78b-6c5d090b3c7e"), new Guid("5a694bc0-b3ea-4d3b-b228-1555a8738e1d"), 200.0, "A", 2, "VAN" },
                    { new Guid("0c3190ce-850b-44fd-ae97-2593ba8e8e0a"), new Guid("aae01dc0-240f-4c2b-85b8-db1d578305ed"), 100.0, "A", 7, "CAR" },
                    { new Guid("0c6f2933-1a31-4d55-8ec3-7058b9b8a576"), new Guid("70713bfe-20a7-4b8e-bcc9-7cd0e57ae2cf"), 50.0, "B", 8, "MOTORCYCLE" },
                    { new Guid("0c8c7e1c-e49e-4c94-b7ab-b249fa83e403"), new Guid("e3c60e04-8b6c-497d-b040-30019f1951fe"), 200.0, "B", 4, "VAN" },
                    { new Guid("0ca972ed-837e-4d6d-af90-a28c6b68ad22"), new Guid("cfba1888-af59-40c6-bf90-ff89882538a3"), 200.0, "B", 1, "VAN" },
                    { new Guid("0d35df22-7cc5-4d4d-9adc-e53417db629e"), new Guid("6f8b493b-9523-43ba-9a39-6080882550be"), 300.0, "B", 4, "TRUCK" },
                    { new Guid("0d377836-17e4-4327-a367-1ba86f0a35ee"), new Guid("610d361a-c14c-4e3a-9ddb-700cd803bb7d"), 200.0, "A", 6, "VAN" },
                    { new Guid("0e2ec267-9c22-4613-97c2-e30895feeae4"), new Guid("b75467ff-4404-40c1-8269-b787f50a14dc"), 100.0, "B", 2, "CAR" },
                    { new Guid("0ebfa4ea-ad26-467c-b588-83fe131dd6f9"), new Guid("322b8d0b-4524-4cd9-b4e5-1312d61fa572"), 200.0, "A", 6, "VAN" },
                    { new Guid("0ee244ad-0efb-41d5-b48f-f325693e6abf"), new Guid("70713bfe-20a7-4b8e-bcc9-7cd0e57ae2cf"), 200.0, "A", 6, "VAN" },
                    { new Guid("0f1c8b53-4af9-4ae7-88af-b65a00f5a3f6"), new Guid("cf8ba59d-1e62-43aa-b128-f92651d868c4"), 100.0, "B", 6, "CAR" },
                    { new Guid("0fd23506-426b-4d7d-a4b1-00c168b3a5e3"), new Guid("257b5f9f-b092-41af-beb1-2a2808fe0fc8"), 100.0, "B", 1, "CAR" },
                    { new Guid("101a12ef-03fb-4229-bd9a-f9bed84af9cd"), new Guid("dab1d406-ad92-4844-b279-1cd9dfb40639"), 200.0, "B", 1, "VAN" },
                    { new Guid("1107094b-d6ae-41b8-9104-ef710fec4d5d"), new Guid("d09a2181-65c3-4ee5-b8b3-d4ea251a8fbf"), 50.0, "A", 1, "MOTORCYCLE" },
                    { new Guid("114c1c4c-6153-4d14-9420-909720a13460"), new Guid("eb384a62-fea4-491c-a7a3-8a4e2c92b0c6"), 200.0, "B", 3, "VAN" },
                    { new Guid("1194fdd5-39d0-496f-b4e4-25781cf2cbc5"), new Guid("d6240ccd-9331-4c53-91af-3b1992316096"), 100.0, "A", 8, "CAR" },
                    { new Guid("11d6ff93-fbbe-4745-b6cf-9bdbabb038a5"), new Guid("fe188580-6e2f-4ff8-a49e-814745f688b7"), 300.0, "B", 5, "TRUCK" },
                    { new Guid("12455af7-3fb9-4877-b697-9f13129f60da"), new Guid("59eb481c-e88b-4a04-93c8-aa9fad3b8fbd"), 300.0, "A", 4, "TRUCK" },
                    { new Guid("12bf7b81-e6ec-47eb-8186-17ef9e395c5f"), new Guid("0ada6bc9-6665-49b2-a427-5ad008b51fda"), 300.0, "A", 4, "TRUCK" },
                    { new Guid("131ad2da-92f9-4637-9e71-55e6137b0c32"), new Guid("fd6deed8-c835-4168-8d92-abafacbe20b6"), 50.0, "A", 2, "MOTORCYCLE" },
                    { new Guid("13876180-346c-4bb2-8200-9a1e2aee57e8"), new Guid("fd6deed8-c835-4168-8d92-abafacbe20b6"), 50.0, "A", 7, "MOTORCYCLE" },
                    { new Guid("145f4366-3317-4ec3-abcd-da366795b8a6"), new Guid("38633289-34c0-438f-b007-976f825ec000"), 300.0, "B", 1, "TRUCK" },
                    { new Guid("14ef0cde-095b-444c-a45e-265a5971c2b3"), new Guid("aae01dc0-240f-4c2b-85b8-db1d578305ed"), 100.0, "B", 8, "CAR" },
                    { new Guid("151968bb-a5df-4d23-9b35-a4c9178142a3"), new Guid("2cde977d-867d-40de-9a10-432b2301464c"), 300.0, "A", 1, "TRUCK" },
                    { new Guid("151d0219-abf3-4697-a2ee-49ef6982ac75"), new Guid("e5cb274b-9061-42f7-aff5-97663074409e"), 50.0, "B", 1, "MOTORCYCLE" },
                    { new Guid("1522124b-f052-4ea7-bbce-08908ff2565c"), new Guid("257b5f9f-b092-41af-beb1-2a2808fe0fc8"), 300.0, "A", 1, "TRUCK" },
                    { new Guid("152868a1-9ea2-49e8-93d6-e09cb475b136"), new Guid("2848fcc2-f6b3-4b91-a829-47543cd6f877"), 300.0, "A", 4, "TRUCK" },
                    { new Guid("1537b802-3f85-41a3-b7a7-807b9c0052df"), new Guid("7b821087-607f-4dd9-a07b-18f22d1c8fd8"), 100.0, "A", 1, "CAR" },
                    { new Guid("157c33b1-e0fd-4d7f-a114-419f313ef309"), new Guid("c5174f79-1a96-4d56-ae5b-b089b385e4f5"), 300.0, "A", 2, "TRUCK" },
                    { new Guid("1583ffa0-ca97-4bfd-ac6e-cf420e655d2c"), new Guid("f3297de4-ea7b-42da-993e-9ae374023e94"), 50.0, "A", 5, "MOTORCYCLE" },
                    { new Guid("15f38b61-22de-47e0-b315-4ae8f4b7cb58"), new Guid("5a694bc0-b3ea-4d3b-b228-1555a8738e1d"), 200.0, "A", 7, "VAN" },
                    { new Guid("15f6b4ba-2e16-4ff7-83dd-4ade88bfdd95"), new Guid("fe188580-6e2f-4ff8-a49e-814745f688b7"), 300.0, "A", 3, "TRUCK" },
                    { new Guid("164d157f-2ab3-48b4-a515-21e3fd3727fc"), new Guid("dab1d406-ad92-4844-b279-1cd9dfb40639"), 200.0, "B", 6, "VAN" },
                    { new Guid("167e4868-22c9-474d-b84b-11fc93035a2f"), new Guid("387a98b1-c216-4873-9812-b12a9aca5ac7"), 300.0, "A", 3, "TRUCK" },
                    { new Guid("169656c0-7737-4b19-afc0-91e131b94d4a"), new Guid("c23b858e-6380-4605-81ed-fae4578261ea"), 50.0, "A", 3, "MOTORCYCLE" },
                    { new Guid("16e7f948-6539-4dbd-b5f0-6fb94efab83d"), new Guid("85611762-85eb-4a9a-a993-dc85d0a68cca"), 50.0, "B", 5, "MOTORCYCLE" },
                    { new Guid("16f59195-511b-43b7-bddd-a9eaeddee94f"), new Guid("dab1d406-ad92-4844-b279-1cd9dfb40639"), 200.0, "B", 8, "VAN" },
                    { new Guid("17113316-1906-4f39-bc6c-6c3a05b318db"), new Guid("bcf6224b-83e4-44b6-84b7-9a5b11f6f78d"), 200.0, "B", 2, "VAN" },
                    { new Guid("172a54db-d4c7-44a5-bdf9-470d4c032ccc"), new Guid("7140654e-28d2-494f-a602-8bb6bff2fc13"), 50.0, "B", 5, "MOTORCYCLE" },
                    { new Guid("1766c653-c238-4a15-b42b-bb80ed0dd1e8"), new Guid("bf21db4e-8dd6-4bc3-9d0d-1e673e3c0541"), 300.0, "A", 2, "TRUCK" },
                    { new Guid("1775ba3e-7bc1-43bf-bff8-8fbb256e5424"), new Guid("dab1d406-ad92-4844-b279-1cd9dfb40639"), 300.0, "A", 8, "TRUCK" },
                    { new Guid("178c5007-f3a8-440e-b84c-6f8480bd281f"), new Guid("e2826ba2-5ca3-4ce6-ac50-811f085e3cf6"), 100.0, "A", 7, "CAR" },
                    { new Guid("17f1afac-ca1a-461b-9531-9a29bc53974f"), new Guid("610d361a-c14c-4e3a-9ddb-700cd803bb7d"), 200.0, "A", 1, "VAN" },
                    { new Guid("1802eb52-5ff4-41e1-8cf7-52bdcd12b4e5"), new Guid("e3c60e04-8b6c-497d-b040-30019f1951fe"), 200.0, "B", 7, "VAN" },
                    { new Guid("18716b96-5dfb-4a68-8b31-6b2fe32e4a72"), new Guid("aae01dc0-240f-4c2b-85b8-db1d578305ed"), 100.0, "A", 8, "CAR" },
                    { new Guid("18ee55c2-eedf-41f4-b9d1-9646bef99db1"), new Guid("b75467ff-4404-40c1-8269-b787f50a14dc"), 100.0, "B", 1, "CAR" },
                    { new Guid("1907db7b-66e3-4352-9875-dcba16800c2b"), new Guid("fd6deed8-c835-4168-8d92-abafacbe20b6"), 50.0, "A", 4, "MOTORCYCLE" },
                    { new Guid("19438ec6-76fa-4f8d-a281-4ca39319bca8"), new Guid("38633289-34c0-438f-b007-976f825ec000"), 50.0, "A", 6, "MOTORCYCLE" },
                    { new Guid("19e8c391-705c-496f-991f-841b0b968377"), new Guid("387a98b1-c216-4873-9812-b12a9aca5ac7"), 300.0, "A", 2, "TRUCK" },
                    { new Guid("1a32090b-1aaf-45dd-a3af-c485136bae45"), new Guid("610d361a-c14c-4e3a-9ddb-700cd803bb7d"), 200.0, "A", 2, "VAN" },
                    { new Guid("1a3cd594-fb7e-4dbe-a352-47da5c16c7e2"), new Guid("fe188580-6e2f-4ff8-a49e-814745f688b7"), 300.0, "B", 7, "TRUCK" },
                    { new Guid("1a69e915-3701-4a8b-9a6e-cdb6c50bf37d"), new Guid("9c6c5b2a-00b3-448c-81cc-a9010d2d4196"), 50.0, "B", 5, "MOTORCYCLE" },
                    { new Guid("1a825bae-c544-413f-84c8-a6dc5f2b9111"), new Guid("bf21db4e-8dd6-4bc3-9d0d-1e673e3c0541"), 100.0, "B", 5, "CAR" },
                    { new Guid("1b0aa0bd-844f-4969-a256-974a1a174909"), new Guid("fd6deed8-c835-4168-8d92-abafacbe20b6"), 200.0, "B", 7, "VAN" },
                    { new Guid("1b45566f-3204-48e4-aae8-8facda51d667"), new Guid("85611762-85eb-4a9a-a993-dc85d0a68cca"), 300.0, "A", 4, "TRUCK" },
                    { new Guid("1b5ccf58-bdfc-4153-88da-5477a30f2666"), new Guid("59e5fd81-c04a-450d-bdd6-c36e80361881"), 300.0, "B", 2, "TRUCK" },
                    { new Guid("1b717b8b-bc61-4454-af4e-48b68caa6997"), new Guid("fd6deed8-c835-4168-8d92-abafacbe20b6"), 50.0, "A", 3, "MOTORCYCLE" },
                    { new Guid("1b7fe602-d839-46fa-8a68-64a3d182419a"), new Guid("d65b48a9-6c74-44b4-aaf3-635151fa5984"), 50.0, "A", 3, "MOTORCYCLE" },
                    { new Guid("1bff8fe8-53ae-4bcc-92ed-83cc48c733c3"), new Guid("59e5fd81-c04a-450d-bdd6-c36e80361881"), 50.0, "A", 1, "MOTORCYCLE" },
                    { new Guid("1c43b13c-121d-4098-b01a-1866b98bd229"), new Guid("eb384a62-fea4-491c-a7a3-8a4e2c92b0c6"), 300.0, "A", 4, "TRUCK" },
                    { new Guid("1dc1a727-ac90-4f4d-b8ad-7278532426f2"), new Guid("387a98b1-c216-4873-9812-b12a9aca5ac7"), 300.0, "A", 1, "TRUCK" },
                    { new Guid("1de1f621-2d1b-4322-b246-6c77a3b87828"), new Guid("635a063b-8794-4510-b61d-899c3b425034"), 200.0, "A", 2, "VAN" },
                    { new Guid("1e1f99c8-b029-419c-88dd-0b2877ca6daf"), new Guid("31faa74a-240a-4f20-a8e9-fc79657b09d4"), 200.0, "B", 1, "VAN" },
                    { new Guid("1e37ad39-29bc-471d-847a-2935a5cd5f1f"), new Guid("c4fb855c-c3fd-4224-909c-e4cb4ebef275"), 300.0, "A", 2, "TRUCK" },
                    { new Guid("1ec4082e-8b60-4f35-ae84-efe160dbc861"), new Guid("59e5fd81-c04a-450d-bdd6-c36e80361881"), 50.0, "A", 5, "MOTORCYCLE" },
                    { new Guid("1eca041b-c4fa-4d11-99b3-e47dd9335daf"), new Guid("85611762-85eb-4a9a-a993-dc85d0a68cca"), 50.0, "B", 3, "MOTORCYCLE" },
                    { new Guid("1f1aed56-b0ff-409f-a2d6-a48f677047b8"), new Guid("85611762-85eb-4a9a-a993-dc85d0a68cca"), 300.0, "A", 7, "TRUCK" },
                    { new Guid("1f72b83e-99d1-4e1e-a6cc-659153d6014a"), new Guid("fc11e465-6669-4617-a41f-a1d1c76a908a"), 300.0, "B", 7, "TRUCK" },
                    { new Guid("1f8c7a47-6b96-4ccf-b6c3-f32e00d5c400"), new Guid("aae01dc0-240f-4c2b-85b8-db1d578305ed"), 100.0, "A", 2, "CAR" },
                    { new Guid("1f9786d8-f9c3-4ae6-9f61-d55362e6a266"), new Guid("930245a8-ee38-4501-a6ec-b31839348aaa"), 100.0, "A", 7, "CAR" },
                    { new Guid("1fcaeca2-796a-4bb4-bdb8-962301ced71f"), new Guid("bcf6224b-83e4-44b6-84b7-9a5b11f6f78d"), 200.0, "B", 5, "VAN" },
                    { new Guid("20053e0c-51d9-48fb-be65-5ed30339b790"), new Guid("8e054a25-6fd3-4e9d-b12b-aaa8e6ac85eb"), 100.0, "B", 8, "CAR" },
                    { new Guid("20a3900b-b614-426b-9d42-ef5efcd1bc75"), new Guid("c5174f79-1a96-4d56-ae5b-b089b385e4f5"), 300.0, "A", 8, "TRUCK" },
                    { new Guid("20cd0323-b2a4-4c0a-81a5-72b168980ca5"), new Guid("e3c60e04-8b6c-497d-b040-30019f1951fe"), 300.0, "A", 5, "TRUCK" },
                    { new Guid("21a327bd-1ed6-4d8d-9526-e35af7bce6f8"), new Guid("d6240ccd-9331-4c53-91af-3b1992316096"), 100.0, "B", 3, "CAR" },
                    { new Guid("221f0970-bfe6-466e-b2c8-aa2845b7fad1"), new Guid("fe188580-6e2f-4ff8-a49e-814745f688b7"), 300.0, "B", 1, "TRUCK" },
                    { new Guid("2328e2a6-05ef-402a-becb-023abbfa03f9"), new Guid("322b8d0b-4524-4cd9-b4e5-1312d61fa572"), 200.0, "B", 7, "VAN" },
                    { new Guid("23914148-1f20-40a4-9c90-c678efb502d5"), new Guid("f3297de4-ea7b-42da-993e-9ae374023e94"), 50.0, "A", 3, "MOTORCYCLE" },
                    { new Guid("23ee5b47-639b-4f22-b982-2a083a62a848"), new Guid("dab1d406-ad92-4844-b279-1cd9dfb40639"), 300.0, "A", 1, "TRUCK" },
                    { new Guid("240e6821-9336-4585-b905-3159c1d58bef"), new Guid("59eb481c-e88b-4a04-93c8-aa9fad3b8fbd"), 200.0, "B", 8, "VAN" },
                    { new Guid("244eba17-4a3f-4ef7-b959-4e5c89abf5ff"), new Guid("5db7d818-7b21-4b81-8cf8-99d99ffaf375"), 200.0, "B", 8, "VAN" },
                    { new Guid("245131eb-2dfc-42e9-8c7d-f6427c8ef20e"), new Guid("2848fcc2-f6b3-4b91-a829-47543cd6f877"), 200.0, "B", 5, "VAN" },
                    { new Guid("246004b2-980a-4365-9daa-0ef35ba0a60c"), new Guid("eb384a62-fea4-491c-a7a3-8a4e2c92b0c6"), 300.0, "A", 7, "TRUCK" },
                    { new Guid("248cd87c-3f52-4be7-a247-3df530ed0b98"), new Guid("19bcc6b0-45ed-4845-b411-400d4f6683b2"), 100.0, "A", 3, "CAR" },
                    { new Guid("25094002-ead1-4a45-9bb9-f2354832e089"), new Guid("38633289-34c0-438f-b007-976f825ec000"), 300.0, "B", 6, "TRUCK" },
                    { new Guid("255591a0-6ecc-4519-8738-ab570072aa44"), new Guid("322b8d0b-4524-4cd9-b4e5-1312d61fa572"), 200.0, "A", 7, "VAN" },
                    { new Guid("25585b93-6dc2-447c-8d34-890db3041844"), new Guid("0ada6bc9-6665-49b2-a427-5ad008b51fda"), 100.0, "B", 8, "CAR" },
                    { new Guid("257ab028-8198-418b-ac11-2752be4a47f6"), new Guid("86f938e1-046b-4c2d-80ba-6eb7d3f4b2b9"), 50.0, "B", 5, "MOTORCYCLE" },
                    { new Guid("25834b3d-61e9-4eaa-9e3d-edf3a9cc480a"), new Guid("b75467ff-4404-40c1-8269-b787f50a14dc"), 100.0, "A", 5, "CAR" },
                    { new Guid("25b14ead-0564-4d18-a44a-54f1b7d1d2b8"), new Guid("387a98b1-c216-4873-9812-b12a9aca5ac7"), 50.0, "B", 2, "MOTORCYCLE" },
                    { new Guid("25bab44e-33a5-4855-893d-715abfd11b57"), new Guid("e5cb274b-9061-42f7-aff5-97663074409e"), 300.0, "A", 7, "TRUCK" },
                    { new Guid("25babcae-3103-4b70-ac57-16e80fe2752c"), new Guid("5db7d818-7b21-4b81-8cf8-99d99ffaf375"), 200.0, "B", 2, "VAN" },
                    { new Guid("25ce77ea-4562-495c-9a9e-0659631682a4"), new Guid("cf8ba59d-1e62-43aa-b128-f92651d868c4"), 100.0, "B", 3, "CAR" },
                    { new Guid("25e14e04-d9e4-47af-8fd5-4f3d2387e60d"), new Guid("c4fb855c-c3fd-4224-909c-e4cb4ebef275"), 300.0, "A", 7, "TRUCK" },
                    { new Guid("265b6097-9706-43f2-8815-7f75a8134a3c"), new Guid("635a063b-8794-4510-b61d-899c3b425034"), 200.0, "A", 8, "VAN" },
                    { new Guid("265b7436-9bcf-4e02-b63d-ad682c1a9e3f"), new Guid("b26c6185-7128-4959-b92d-665002dce200"), 300.0, "A", 8, "TRUCK" },
                    { new Guid("26cf38c1-5fed-47db-82e8-3a869faf6266"), new Guid("257b5f9f-b092-41af-beb1-2a2808fe0fc8"), 300.0, "A", 3, "TRUCK" },
                    { new Guid("274f1df2-b439-48a8-807f-bf7dbd779f4e"), new Guid("891fbb4c-6ace-4cd9-ba70-deb2d06886bc"), 100.0, "A", 5, "CAR" },
                    { new Guid("276db519-784f-41d5-acb4-11b73e5d5b1a"), new Guid("3f771136-710d-4c9b-94ca-00b8c3abdd93"), 50.0, "B", 3, "MOTORCYCLE" },
                    { new Guid("27893d97-bf94-4cfc-817a-270f46bc93c2"), new Guid("3f771136-710d-4c9b-94ca-00b8c3abdd93"), 50.0, "B", 1, "MOTORCYCLE" },
                    { new Guid("28728b56-d903-4064-b4bb-15414a65f284"), new Guid("38633289-34c0-438f-b007-976f825ec000"), 50.0, "A", 2, "MOTORCYCLE" },
                    { new Guid("28d74eff-9f67-4844-b94e-ad90c4b62840"), new Guid("9c6c5b2a-00b3-448c-81cc-a9010d2d4196"), 300.0, "A", 7, "TRUCK" },
                    { new Guid("290702d1-95c0-470b-8f0f-faa418d954dc"), new Guid("322b8d0b-4524-4cd9-b4e5-1312d61fa572"), 200.0, "A", 5, "VAN" },
                    { new Guid("295540bb-d166-4379-9bfb-3793b29f1c77"), new Guid("d65b48a9-6c74-44b4-aaf3-635151fa5984"), 50.0, "A", 5, "MOTORCYCLE" },
                    { new Guid("2a904237-71cc-417b-a998-f5e72a2bacfb"), new Guid("610d361a-c14c-4e3a-9ddb-700cd803bb7d"), 100.0, "B", 3, "CAR" },
                    { new Guid("2aaae866-be62-4be0-9578-723c17ed1b72"), new Guid("d6240ccd-9331-4c53-91af-3b1992316096"), 100.0, "A", 7, "CAR" },
                    { new Guid("2afc9719-8bef-495c-8c6e-4437d25c192c"), new Guid("188984fb-f6f2-43a8-8f42-5761cf166a56"), 200.0, "B", 5, "VAN" },
                    { new Guid("2b407f1e-e79f-413c-8eff-28a83cea14a0"), new Guid("f3297de4-ea7b-42da-993e-9ae374023e94"), 50.0, "A", 7, "MOTORCYCLE" },
                    { new Guid("2b5b5f30-23b9-48c0-9bcf-967ddc4e7c34"), new Guid("fe188580-6e2f-4ff8-a49e-814745f688b7"), 300.0, "A", 4, "TRUCK" },
                    { new Guid("2bbe4935-59c9-4421-9e9f-f639ef26ac7e"), new Guid("85611762-85eb-4a9a-a993-dc85d0a68cca"), 50.0, "B", 1, "MOTORCYCLE" },
                    { new Guid("2c425550-5a13-44d0-a7c5-573c8b95dc91"), new Guid("610d361a-c14c-4e3a-9ddb-700cd803bb7d"), 200.0, "A", 5, "VAN" },
                    { new Guid("2c589dd7-5eb3-49b8-bc22-9ec8c667bac3"), new Guid("8e054a25-6fd3-4e9d-b12b-aaa8e6ac85eb"), 200.0, "A", 5, "VAN" },
                    { new Guid("2c65452b-e666-4cc4-a0ed-215668e0ec5f"), new Guid("3f771136-710d-4c9b-94ca-00b8c3abdd93"), 200.0, "A", 1, "VAN" },
                    { new Guid("2cb200ca-30ab-4b33-aeb1-b6c8135866d1"), new Guid("bf21db4e-8dd6-4bc3-9d0d-1e673e3c0541"), 300.0, "A", 6, "TRUCK" },
                    { new Guid("2cf0ba31-555d-49bf-8c01-f4bb37759a94"), new Guid("c4fb855c-c3fd-4224-909c-e4cb4ebef275"), 100.0, "B", 5, "CAR" },
                    { new Guid("2d35849a-540e-4d92-af6b-9b503703cf35"), new Guid("bf21db4e-8dd6-4bc3-9d0d-1e673e3c0541"), 100.0, "B", 2, "CAR" },
                    { new Guid("2d85738a-a75c-4928-9ac2-c7e684567295"), new Guid("d09a2181-65c3-4ee5-b8b3-d4ea251a8fbf"), 100.0, "B", 8, "CAR" },
                    { new Guid("2d9009de-d8d8-480b-a892-30be8e0c3842"), new Guid("930245a8-ee38-4501-a6ec-b31839348aaa"), 100.0, "B", 8, "CAR" },
                    { new Guid("2d92482f-25ea-405a-a00f-667264b85d35"), new Guid("6caabf59-5600-43f0-98c9-ab24acf0dadf"), 300.0, "A", 7, "TRUCK" },
                    { new Guid("2daa6135-4105-4f92-a130-65bfa0f8a0c0"), new Guid("495b86e8-5b8f-4f62-8ade-e8152d743878"), 50.0, "B", 1, "MOTORCYCLE" },
                    { new Guid("2dce7789-19a7-494d-addd-25af5e3d6470"), new Guid("cf8ba59d-1e62-43aa-b128-f92651d868c4"), 300.0, "A", 1, "TRUCK" },
                    { new Guid("2e587d8c-fecc-43a4-8970-f6dc1d78e357"), new Guid("38633289-34c0-438f-b007-976f825ec000"), 300.0, "B", 2, "TRUCK" },
                    { new Guid("2e6d0a6b-b8b3-4be4-bfd4-e9e3859db9e6"), new Guid("6f8b493b-9523-43ba-9a39-6080882550be"), 300.0, "B", 8, "TRUCK" },
                    { new Guid("2eb09d75-9817-417e-aa94-6ca554602594"), new Guid("fc11e465-6669-4617-a41f-a1d1c76a908a"), 300.0, "B", 5, "TRUCK" },
                    { new Guid("2f15ecd2-e5c5-44b7-9715-8a6c754d61ff"), new Guid("d6240ccd-9331-4c53-91af-3b1992316096"), 100.0, "A", 5, "CAR" },
                    { new Guid("2f163448-a190-4625-bb5d-947ba1e44e6f"), new Guid("495b86e8-5b8f-4f62-8ade-e8152d743878"), 50.0, "A", 6, "MOTORCYCLE" },
                    { new Guid("2ffc4b4b-4c0b-4f5a-912d-6edd70989ed9"), new Guid("fe188580-6e2f-4ff8-a49e-814745f688b7"), 300.0, "A", 6, "TRUCK" },
                    { new Guid("300d2cb5-44ee-4359-9ade-f7f4120a71aa"), new Guid("38633289-34c0-438f-b007-976f825ec000"), 50.0, "A", 8, "MOTORCYCLE" },
                    { new Guid("3014b95a-cdc8-48f1-8f3b-08d6aa62028a"), new Guid("6f8b493b-9523-43ba-9a39-6080882550be"), 100.0, "A", 8, "CAR" },
                    { new Guid("3018e266-a932-40de-bf4d-ba447aab186c"), new Guid("fd6deed8-c835-4168-8d92-abafacbe20b6"), 200.0, "B", 3, "VAN" },
                    { new Guid("305b1488-f743-4eac-bebf-323dce1b2cb6"), new Guid("fc2a8276-f127-4246-86dc-4d2b3262ed86"), 100.0, "B", 1, "CAR" },
                    { new Guid("30b52a3d-f2ba-411c-aa80-42ba6b3af147"), new Guid("3d85c54a-5fcb-49b5-a370-4c5d3216ae4f"), 200.0, "A", 6, "VAN" },
                    { new Guid("30b823d2-d918-4840-b00a-c79bc2db035a"), new Guid("322b8d0b-4524-4cd9-b4e5-1312d61fa572"), 200.0, "B", 2, "VAN" },
                    { new Guid("30d64edd-679c-4e46-a758-b218c05fe0f5"), new Guid("19bcc6b0-45ed-4845-b411-400d4f6683b2"), 100.0, "A", 1, "CAR" },
                    { new Guid("30e93e06-07e0-43bd-ad9b-0d6447aa2d89"), new Guid("d09a2181-65c3-4ee5-b8b3-d4ea251a8fbf"), 100.0, "B", 3, "CAR" },
                    { new Guid("313826ce-b9c9-448e-9f11-e1cf0ec31de7"), new Guid("bf21db4e-8dd6-4bc3-9d0d-1e673e3c0541"), 100.0, "B", 3, "CAR" },
                    { new Guid("315d0ec6-b1a9-4d06-ad2b-c65eeef18039"), new Guid("930245a8-ee38-4501-a6ec-b31839348aaa"), 100.0, "B", 3, "CAR" },
                    { new Guid("317e96ae-2b07-46aa-853b-a81d750b7c37"), new Guid("3d85c54a-5fcb-49b5-a370-4c5d3216ae4f"), 200.0, "B", 8, "VAN" },
                    { new Guid("317efd99-44c7-4c4f-a06b-f19e37dbf3c7"), new Guid("cf8ba59d-1e62-43aa-b128-f92651d868c4"), 300.0, "A", 8, "TRUCK" },
                    { new Guid("3191d7d2-7db5-4570-85e5-13298aeb24c4"), new Guid("19bcc6b0-45ed-4845-b411-400d4f6683b2"), 100.0, "B", 2, "CAR" },
                    { new Guid("31acb28d-1c74-4b61-9444-6c5e67c147ec"), new Guid("8886b676-b97c-4d0b-ae45-d18b2f2df900"), 200.0, "B", 3, "VAN" },
                    { new Guid("31c313ef-30d2-470e-a129-6bcee6dee506"), new Guid("d6240ccd-9331-4c53-91af-3b1992316096"), 100.0, "A", 6, "CAR" },
                    { new Guid("31ff615f-6f13-49e9-83b3-095392f3e84d"), new Guid("fd6deed8-c835-4168-8d92-abafacbe20b6"), 200.0, "B", 4, "VAN" },
                    { new Guid("3208f06b-7c21-4e9c-aca0-1ecc3490df79"), new Guid("cfba1888-af59-40c6-bf90-ff89882538a3"), 100.0, "A", 2, "CAR" },
                    { new Guid("3227c724-c645-4a75-bc10-e40faed59bad"), new Guid("38633289-34c0-438f-b007-976f825ec000"), 300.0, "B", 4, "TRUCK" },
                    { new Guid("323ec3de-cf48-4e8b-9c5e-00ef3e45ad4a"), new Guid("322b8d0b-4524-4cd9-b4e5-1312d61fa572"), 200.0, "B", 4, "VAN" },
                    { new Guid("32720445-5852-4f5e-b733-0fe4593d41af"), new Guid("8886b676-b97c-4d0b-ae45-d18b2f2df900"), 200.0, "B", 6, "VAN" },
                    { new Guid("32a297b7-9950-4b12-8e24-c591ffee2494"), new Guid("1a0fc976-15ce-4e8e-9ce1-e01456178b41"), 100.0, "A", 2, "CAR" },
                    { new Guid("339d4cf8-7cf6-40a4-b119-2ec419793a46"), new Guid("5a694bc0-b3ea-4d3b-b228-1555a8738e1d"), 200.0, "A", 3, "VAN" },
                    { new Guid("3423f337-0498-4560-8395-74ef523718c0"), new Guid("ae16885c-9a8e-49a8-b817-0be9a9960d0f"), 200.0, "B", 6, "VAN" },
                    { new Guid("342ea489-875c-4e62-ba74-b96b4cf69c65"), new Guid("7b821087-607f-4dd9-a07b-18f22d1c8fd8"), 100.0, "A", 2, "CAR" },
                    { new Guid("34eb0c65-9fd2-4798-a8cf-24bfaf4eea68"), new Guid("bcf6224b-83e4-44b6-84b7-9a5b11f6f78d"), 100.0, "A", 4, "CAR" },
                    { new Guid("3559c596-a37c-4b9b-9498-d224bf39121e"), new Guid("86f938e1-046b-4c2d-80ba-6eb7d3f4b2b9"), 200.0, "A", 7, "VAN" },
                    { new Guid("356aaf20-93fa-40ed-ac90-08bc759a5837"), new Guid("52688c85-e7f4-47e9-b9f2-d508de79f823"), 200.0, "A", 2, "VAN" },
                    { new Guid("356c6e69-b539-4bb0-bc8e-de5622cb992f"), new Guid("b26c6185-7128-4959-b92d-665002dce200"), 300.0, "B", 1, "TRUCK" },
                    { new Guid("35aff249-1064-4257-901e-ed597396c2dc"), new Guid("eb384a62-fea4-491c-a7a3-8a4e2c92b0c6"), 200.0, "B", 5, "VAN" },
                    { new Guid("3673fa3a-fd92-4f84-970b-a79e5829a9be"), new Guid("e3c60e04-8b6c-497d-b040-30019f1951fe"), 300.0, "A", 8, "TRUCK" },
                    { new Guid("36e810a5-1388-49a6-a7f1-b3fd2dfaea0c"), new Guid("f3297de4-ea7b-42da-993e-9ae374023e94"), 50.0, "A", 6, "MOTORCYCLE" },
                    { new Guid("37b7a402-f425-4322-96a5-ca80cf54ff2f"), new Guid("b75467ff-4404-40c1-8269-b787f50a14dc"), 100.0, "A", 6, "CAR" },
                    { new Guid("392e4da7-4fb9-429f-803f-44942b478664"), new Guid("188984fb-f6f2-43a8-8f42-5761cf166a56"), 300.0, "A", 3, "TRUCK" },
                    { new Guid("39e33b5f-56fd-4f0a-9b0e-56a2b28a774b"), new Guid("8e054a25-6fd3-4e9d-b12b-aaa8e6ac85eb"), 200.0, "A", 4, "VAN" },
                    { new Guid("3a1f4c43-d633-4df5-8a6c-e8078722f638"), new Guid("c23b858e-6380-4605-81ed-fae4578261ea"), 50.0, "B", 8, "MOTORCYCLE" },
                    { new Guid("3a31bbd0-1222-4314-b7ea-e3c87178d7a9"), new Guid("c4fb855c-c3fd-4224-909c-e4cb4ebef275"), 100.0, "B", 4, "CAR" },
                    { new Guid("3a33b64e-5249-4cc5-89f8-e8fc55e6f6da"), new Guid("59eb481c-e88b-4a04-93c8-aa9fad3b8fbd"), 200.0, "B", 4, "VAN" },
                    { new Guid("3a5ce483-4636-4895-8c83-623dccba8b48"), new Guid("cfba1888-af59-40c6-bf90-ff89882538a3"), 100.0, "A", 8, "CAR" },
                    { new Guid("3acfdc94-33b8-4074-84ca-cf5f0aefbc0e"), new Guid("dab1d406-ad92-4844-b279-1cd9dfb40639"), 300.0, "A", 6, "TRUCK" },
                    { new Guid("3b11dec6-3348-4d83-a5d1-1afe558645f6"), new Guid("2848fcc2-f6b3-4b91-a829-47543cd6f877"), 200.0, "B", 8, "VAN" },
                    { new Guid("3c30ed77-e7f6-4658-83ee-c704645a9d26"), new Guid("c23b858e-6380-4605-81ed-fae4578261ea"), 50.0, "B", 7, "MOTORCYCLE" },
                    { new Guid("3c3eaa52-407d-406d-bc9a-c8a280d83ed5"), new Guid("7b821087-607f-4dd9-a07b-18f22d1c8fd8"), 100.0, "B", 2, "CAR" },
                    { new Guid("3d168788-dcd2-4135-8d25-688188d41bd1"), new Guid("bf21db4e-8dd6-4bc3-9d0d-1e673e3c0541"), 100.0, "B", 8, "CAR" },
                    { new Guid("3d3d3420-c766-4fc6-a9d0-d04163781dc2"), new Guid("3d85c54a-5fcb-49b5-a370-4c5d3216ae4f"), 200.0, "B", 7, "VAN" },
                    { new Guid("3d9365f5-a7d7-437b-a2d6-5d17f4331bec"), new Guid("495b86e8-5b8f-4f62-8ade-e8152d743878"), 50.0, "A", 2, "MOTORCYCLE" },
                    { new Guid("3da09aae-e950-4e99-a03a-da60b77e6b32"), new Guid("52688c85-e7f4-47e9-b9f2-d508de79f823"), 100.0, "B", 6, "CAR" },
                    { new Guid("3ed972be-ed47-41b2-abde-ae470df7ff35"), new Guid("1a0fc976-15ce-4e8e-9ce1-e01456178b41"), 300.0, "B", 7, "TRUCK" },
                    { new Guid("3efddc8f-1bf7-44e6-a9aa-e338a0e694a1"), new Guid("bcf6224b-83e4-44b6-84b7-9a5b11f6f78d"), 200.0, "B", 4, "VAN" },
                    { new Guid("3f4a231d-d99e-4618-b69d-fe1c861f46f9"), new Guid("d65b48a9-6c74-44b4-aaf3-635151fa5984"), 50.0, "A", 2, "MOTORCYCLE" },
                    { new Guid("3f7b559c-14ff-4d89-88b3-8e6ba32c28d0"), new Guid("930245a8-ee38-4501-a6ec-b31839348aaa"), 100.0, "B", 5, "CAR" },
                    { new Guid("3f7bbcc4-a453-47c1-a956-957fd348b2cc"), new Guid("8886b676-b97c-4d0b-ae45-d18b2f2df900"), 100.0, "A", 3, "CAR" },
                    { new Guid("3fb4f719-d388-4f63-ba0e-fb5f06535692"), new Guid("fc2a8276-f127-4246-86dc-4d2b3262ed86"), 50.0, "A", 4, "MOTORCYCLE" },
                    { new Guid("403b647f-350a-4984-8d9f-2e380e579182"), new Guid("b26c6185-7128-4959-b92d-665002dce200"), 300.0, "A", 4, "TRUCK" },
                    { new Guid("40e45c4a-993c-46fd-bb88-ccd6fdce6a81"), new Guid("fe188580-6e2f-4ff8-a49e-814745f688b7"), 300.0, "B", 4, "TRUCK" },
                    { new Guid("41544e7a-99d5-4a6a-aa10-5852209d4065"), new Guid("257b5f9f-b092-41af-beb1-2a2808fe0fc8"), 300.0, "A", 7, "TRUCK" },
                    { new Guid("41bc927d-d0da-4213-a0a9-e194a8d1ab48"), new Guid("257b5f9f-b092-41af-beb1-2a2808fe0fc8"), 300.0, "A", 4, "TRUCK" },
                    { new Guid("41cf73b5-44c3-429c-8952-beee4f590306"), new Guid("c23b858e-6380-4605-81ed-fae4578261ea"), 50.0, "A", 1, "MOTORCYCLE" },
                    { new Guid("41e79e98-03bc-4667-ac58-7e9fb02906bb"), new Guid("dab1d406-ad92-4844-b279-1cd9dfb40639"), 200.0, "B", 7, "VAN" },
                    { new Guid("41f492b9-9d29-42e9-98ef-460cf6eadc67"), new Guid("2cde977d-867d-40de-9a10-432b2301464c"), 300.0, "A", 5, "TRUCK" },
                    { new Guid("420629c2-861d-48c2-abd2-e6ea971d4eda"), new Guid("b26c6185-7128-4959-b92d-665002dce200"), 300.0, "A", 7, "TRUCK" },
                    { new Guid("421e2eee-c69d-40f5-9809-cba1575bb8cb"), new Guid("495b86e8-5b8f-4f62-8ade-e8152d743878"), 50.0, "B", 6, "MOTORCYCLE" },
                    { new Guid("42fb9a32-d8b6-4619-a79f-b912daa76181"), new Guid("610d361a-c14c-4e3a-9ddb-700cd803bb7d"), 100.0, "B", 2, "CAR" },
                    { new Guid("435710ce-2f0c-4514-a09b-1196994f8ac2"), new Guid("b26c6185-7128-4959-b92d-665002dce200"), 300.0, "B", 8, "TRUCK" },
                    { new Guid("454f75d7-ebc4-410d-8cdc-a91cc7077395"), new Guid("c5174f79-1a96-4d56-ae5b-b089b385e4f5"), 300.0, "A", 6, "TRUCK" },
                    { new Guid("458e2da8-cf39-41b3-9fcb-6f8a9b3cfe4f"), new Guid("d6240ccd-9331-4c53-91af-3b1992316096"), 100.0, "B", 5, "CAR" },
                    { new Guid("45c2404b-5e32-4617-b999-0bb8c2d8ef42"), new Guid("b75467ff-4404-40c1-8269-b787f50a14dc"), 100.0, "A", 1, "CAR" },
                    { new Guid("45db9ef6-d382-41ab-a69e-f6a435d631d7"), new Guid("0ada6bc9-6665-49b2-a427-5ad008b51fda"), 300.0, "A", 5, "TRUCK" },
                    { new Guid("462b309e-9ea1-436a-9056-a3456219174e"), new Guid("f35520f7-2e5e-4340-ba78-c10259f8c8c5"), 50.0, "A", 8, "MOTORCYCLE" },
                    { new Guid("462bd796-becd-4120-b6a4-4bb292338b3a"), new Guid("d65b48a9-6c74-44b4-aaf3-635151fa5984"), 50.0, "B", 6, "MOTORCYCLE" },
                    { new Guid("46303751-8bfb-401a-b029-cc3c73fc7446"), new Guid("52688c85-e7f4-47e9-b9f2-d508de79f823"), 200.0, "A", 5, "VAN" },
                    { new Guid("4690adf5-dde5-4678-a898-51cb761c3298"), new Guid("3f771136-710d-4c9b-94ca-00b8c3abdd93"), 50.0, "B", 2, "MOTORCYCLE" },
                    { new Guid("46b1c062-fd93-4cc1-9919-90296eb83a07"), new Guid("e2826ba2-5ca3-4ce6-ac50-811f085e3cf6"), 100.0, "A", 6, "CAR" },
                    { new Guid("46bb8d4b-3453-466a-a3bf-8f333182c0d1"), new Guid("dab1d406-ad92-4844-b279-1cd9dfb40639"), 200.0, "B", 5, "VAN" },
                    { new Guid("46c8d9c8-6524-4728-acfd-acadfc1f1420"), new Guid("0ada6bc9-6665-49b2-a427-5ad008b51fda"), 300.0, "A", 7, "TRUCK" },
                    { new Guid("46cd41e2-6484-4654-87f2-3a450a9afdb7"), new Guid("6f8b493b-9523-43ba-9a39-6080882550be"), 100.0, "A", 5, "CAR" },
                    { new Guid("46d813b4-8f0f-4374-838d-1d88ab0efd8f"), new Guid("5db7d818-7b21-4b81-8cf8-99d99ffaf375"), 200.0, "B", 4, "VAN" },
                    { new Guid("46e38ef1-41c5-44f4-b4a3-9bde0db9950f"), new Guid("fc2a8276-f127-4246-86dc-4d2b3262ed86"), 100.0, "B", 2, "CAR" },
                    { new Guid("46efab15-85a0-43c1-bfdd-33fafc22127c"), new Guid("bf21db4e-8dd6-4bc3-9d0d-1e673e3c0541"), 300.0, "A", 7, "TRUCK" },
                    { new Guid("46f2916e-fef2-4b6b-bf4e-b70e12ce677d"), new Guid("6caabf59-5600-43f0-98c9-ab24acf0dadf"), 100.0, "B", 5, "CAR" },
                    { new Guid("46fb8902-d035-4f98-aaa9-e0f04d70cd8f"), new Guid("d65b48a9-6c74-44b4-aaf3-635151fa5984"), 50.0, "B", 5, "MOTORCYCLE" },
                    { new Guid("4701b90c-3633-4e8a-8d98-f13faf6ae522"), new Guid("257b5f9f-b092-41af-beb1-2a2808fe0fc8"), 100.0, "B", 3, "CAR" },
                    { new Guid("47066c2a-e013-4f4a-a616-12eff9a7cc51"), new Guid("70713bfe-20a7-4b8e-bcc9-7cd0e57ae2cf"), 200.0, "A", 3, "VAN" },
                    { new Guid("472795b9-0197-4e44-bc61-a1766608c671"), new Guid("38633289-34c0-438f-b007-976f825ec000"), 300.0, "B", 8, "TRUCK" },
                    { new Guid("4749e998-0248-4f75-a56f-709baaf3b54b"), new Guid("bf21db4e-8dd6-4bc3-9d0d-1e673e3c0541"), 300.0, "A", 1, "TRUCK" },
                    { new Guid("48081af6-5909-46ee-9307-759d86e62630"), new Guid("eb384a62-fea4-491c-a7a3-8a4e2c92b0c6"), 200.0, "B", 7, "VAN" },
                    { new Guid("488c8cd8-bb50-4c2f-8954-e0738c58c78b"), new Guid("ae16885c-9a8e-49a8-b817-0be9a9960d0f"), 300.0, "A", 1, "TRUCK" },
                    { new Guid("48a2e3fb-349b-488c-9e26-c85a5f62a2ee"), new Guid("0ada6bc9-6665-49b2-a427-5ad008b51fda"), 100.0, "B", 3, "CAR" },
                    { new Guid("497eaa09-51be-4125-b954-ba159d7b2c81"), new Guid("891fbb4c-6ace-4cd9-ba70-deb2d06886bc"), 100.0, "A", 6, "CAR" },
                    { new Guid("49a4d00d-319f-4159-96a2-4f9760ca2ba1"), new Guid("fe188580-6e2f-4ff8-a49e-814745f688b7"), 300.0, "B", 6, "TRUCK" },
                    { new Guid("49ff4b24-1870-4758-a016-7011e26cca17"), new Guid("495b86e8-5b8f-4f62-8ade-e8152d743878"), 50.0, "A", 8, "MOTORCYCLE" },
                    { new Guid("4a177b8a-39cb-49ce-bebf-a1d9e925a588"), new Guid("e21cdfc0-d3d8-47cc-8b74-bdf62436fcdb"), 300.0, "B", 2, "TRUCK" },
                    { new Guid("4a1ebb18-2c7f-4881-83f1-7869ef37c76a"), new Guid("891fbb4c-6ace-4cd9-ba70-deb2d06886bc"), 300.0, "B", 1, "TRUCK" },
                    { new Guid("4a3eec55-2f60-4875-9d4d-20512af60743"), new Guid("59e5fd81-c04a-450d-bdd6-c36e80361881"), 300.0, "B", 6, "TRUCK" },
                    { new Guid("4a42f742-4e59-4b8d-b5d5-779892515207"), new Guid("f35520f7-2e5e-4340-ba78-c10259f8c8c5"), 50.0, "A", 6, "MOTORCYCLE" },
                    { new Guid("4aa8229c-f4c9-4524-9761-20f2c0e5259a"), new Guid("c4fb855c-c3fd-4224-909c-e4cb4ebef275"), 100.0, "B", 1, "CAR" },
                    { new Guid("4aedfb40-b4ed-485e-879a-9bf7a0fcb9d5"), new Guid("cfba1888-af59-40c6-bf90-ff89882538a3"), 200.0, "B", 8, "VAN" },
                    { new Guid("4b330768-547a-4089-831e-91cbd0f60963"), new Guid("e21cdfc0-d3d8-47cc-8b74-bdf62436fcdb"), 300.0, "B", 1, "TRUCK" },
                    { new Guid("4b3be3b4-3fa5-4eb4-90fe-6fa2b385c2c5"), new Guid("d09a2181-65c3-4ee5-b8b3-d4ea251a8fbf"), 50.0, "A", 2, "MOTORCYCLE" },
                    { new Guid("4b5d924d-d99f-4be6-b8fb-b8cabf585ce6"), new Guid("fc11e465-6669-4617-a41f-a1d1c76a908a"), 200.0, "A", 5, "VAN" },
                    { new Guid("4b65560f-7cf9-4d9b-ac10-7c5b83c18ef6"), new Guid("2848fcc2-f6b3-4b91-a829-47543cd6f877"), 300.0, "A", 2, "TRUCK" },
                    { new Guid("4b77fb48-89d8-4344-a758-b514582b31c1"), new Guid("cf8ba59d-1e62-43aa-b128-f92651d868c4"), 100.0, "B", 5, "CAR" },
                    { new Guid("4b8df5d2-eda5-4226-9e65-7762c02db1b6"), new Guid("e3c60e04-8b6c-497d-b040-30019f1951fe"), 200.0, "B", 1, "VAN" },
                    { new Guid("4bd077cd-7c57-4ce6-8cdd-dce66c51d28e"), new Guid("1a0fc976-15ce-4e8e-9ce1-e01456178b41"), 300.0, "B", 2, "TRUCK" },
                    { new Guid("4c634125-4d18-4a6e-aa32-221dcdb6832a"), new Guid("31faa74a-240a-4f20-a8e9-fc79657b09d4"), 200.0, "B", 4, "VAN" },
                    { new Guid("4c7f1c7c-c642-4779-b6dd-d95c5bc08bbb"), new Guid("a8827db7-700c-4e56-94f6-2a77e3f61a9c"), 300.0, "A", 7, "TRUCK" },
                    { new Guid("4c8e54a2-720f-4262-ae9b-cf1eaa25f788"), new Guid("2848fcc2-f6b3-4b91-a829-47543cd6f877"), 300.0, "A", 3, "TRUCK" },
                    { new Guid("4cbd3c15-3fa4-4af6-9dc2-606e5db25818"), new Guid("188984fb-f6f2-43a8-8f42-5761cf166a56"), 200.0, "B", 1, "VAN" },
                    { new Guid("4dd3577b-11ea-4ea0-8753-53fa1cb0bb51"), new Guid("188984fb-f6f2-43a8-8f42-5761cf166a56"), 300.0, "A", 5, "TRUCK" },
                    { new Guid("4de7c9e6-2210-47e4-83e1-9f0e63f152bd"), new Guid("52688c85-e7f4-47e9-b9f2-d508de79f823"), 100.0, "B", 2, "CAR" },
                    { new Guid("4e069189-ce0f-48ce-aed2-0c60e38430bf"), new Guid("c23b858e-6380-4605-81ed-fae4578261ea"), 50.0, "A", 8, "MOTORCYCLE" },
                    { new Guid("4e2f18d9-2a33-49f1-a60f-6bdc6d311f42"), new Guid("c4fb855c-c3fd-4224-909c-e4cb4ebef275"), 300.0, "A", 3, "TRUCK" },
                    { new Guid("4f09b742-dece-4027-a589-275349c4f2a4"), new Guid("c23b858e-6380-4605-81ed-fae4578261ea"), 50.0, "B", 2, "MOTORCYCLE" },
                    { new Guid("4f86cc7a-3496-4cdb-a103-c18936e05ce8"), new Guid("0ada6bc9-6665-49b2-a427-5ad008b51fda"), 300.0, "A", 8, "TRUCK" },
                    { new Guid("51140f7a-0b2a-43b7-adb0-ea9263c9f895"), new Guid("c5174f79-1a96-4d56-ae5b-b089b385e4f5"), 300.0, "B", 2, "TRUCK" },
                    { new Guid("512e4e31-f48c-40c4-a822-7b74c29eb213"), new Guid("cf8ba59d-1e62-43aa-b128-f92651d868c4"), 100.0, "B", 1, "CAR" },
                    { new Guid("5181dcbe-4432-486c-8bd5-fd003fba3250"), new Guid("fc11e465-6669-4617-a41f-a1d1c76a908a"), 200.0, "A", 7, "VAN" },
                    { new Guid("51bd04f7-fe60-4394-9926-86471f4521ee"), new Guid("257b5f9f-b092-41af-beb1-2a2808fe0fc8"), 300.0, "A", 5, "TRUCK" },
                    { new Guid("51f0ffcf-a469-4757-b833-b086bdf92c33"), new Guid("9c6c5b2a-00b3-448c-81cc-a9010d2d4196"), 50.0, "B", 8, "MOTORCYCLE" },
                    { new Guid("5231347f-c1c4-4f22-a5e2-ca65129eaf4b"), new Guid("a8827db7-700c-4e56-94f6-2a77e3f61a9c"), 300.0, "A", 4, "TRUCK" },
                    { new Guid("524dc36d-6fd3-44bc-a972-d184cbb10d99"), new Guid("ae16885c-9a8e-49a8-b817-0be9a9960d0f"), 300.0, "A", 2, "TRUCK" },
                    { new Guid("532826a0-2648-4608-b521-e3a26c5af7cd"), new Guid("f35520f7-2e5e-4340-ba78-c10259f8c8c5"), 100.0, "B", 1, "CAR" },
                    { new Guid("5332c626-7977-48bb-93e1-b986d3009dfb"), new Guid("387a98b1-c216-4873-9812-b12a9aca5ac7"), 300.0, "A", 8, "TRUCK" },
                    { new Guid("5338b139-c758-42de-ac3b-228bd9720fcf"), new Guid("e2826ba2-5ca3-4ce6-ac50-811f085e3cf6"), 100.0, "B", 5, "CAR" },
                    { new Guid("533c0f3b-28d8-426b-971b-4099c5d116bc"), new Guid("891fbb4c-6ace-4cd9-ba70-deb2d06886bc"), 100.0, "A", 1, "CAR" },
                    { new Guid("53f496e1-6804-49e2-a9cd-02635b155cbb"), new Guid("e5cb274b-9061-42f7-aff5-97663074409e"), 300.0, "A", 1, "TRUCK" },
                    { new Guid("542e014d-3ef5-46a0-ae25-5e3bfe2e9cc4"), new Guid("fe188580-6e2f-4ff8-a49e-814745f688b7"), 300.0, "A", 1, "TRUCK" },
                    { new Guid("547006ae-7bf6-4d6d-9374-7a2b08cfffc8"), new Guid("86f938e1-046b-4c2d-80ba-6eb7d3f4b2b9"), 50.0, "B", 6, "MOTORCYCLE" },
                    { new Guid("54782404-1c44-4fb5-b4b0-96e23ff4582a"), new Guid("c23b858e-6380-4605-81ed-fae4578261ea"), 50.0, "A", 5, "MOTORCYCLE" },
                    { new Guid("5484f409-ca9c-4be6-8847-6e3bccd6dd55"), new Guid("8886b676-b97c-4d0b-ae45-d18b2f2df900"), 100.0, "A", 8, "CAR" },
                    { new Guid("54d6dc49-3e8b-407a-b924-48738e19b3f8"), new Guid("610d361a-c14c-4e3a-9ddb-700cd803bb7d"), 100.0, "B", 7, "CAR" },
                    { new Guid("54e55ffc-db32-418c-bd7b-80484aa6c086"), new Guid("1a0fc976-15ce-4e8e-9ce1-e01456178b41"), 100.0, "A", 7, "CAR" },
                    { new Guid("55909176-0504-4a49-b639-5e37fce9bab3"), new Guid("bf21db4e-8dd6-4bc3-9d0d-1e673e3c0541"), 100.0, "B", 7, "CAR" },
                    { new Guid("55ab93b6-556d-4a9a-adbf-469a0252d764"), new Guid("188984fb-f6f2-43a8-8f42-5761cf166a56"), 200.0, "B", 3, "VAN" },
                    { new Guid("55f61e5d-5979-4487-abc3-91609abc2c3f"), new Guid("cf8ba59d-1e62-43aa-b128-f92651d868c4"), 300.0, "A", 2, "TRUCK" },
                    { new Guid("570649c7-69ea-4b4e-8260-af5de319e707"), new Guid("3f771136-710d-4c9b-94ca-00b8c3abdd93"), 200.0, "A", 5, "VAN" },
                    { new Guid("57151461-dd89-4236-82e8-e9800e7da1f6"), new Guid("0ada6bc9-6665-49b2-a427-5ad008b51fda"), 300.0, "A", 2, "TRUCK" },
                    { new Guid("57300731-216d-480c-a66f-6b4ccedb7251"), new Guid("3f771136-710d-4c9b-94ca-00b8c3abdd93"), 50.0, "B", 4, "MOTORCYCLE" },
                    { new Guid("573a1409-5154-48a1-a25c-c37a997e57b7"), new Guid("fc2a8276-f127-4246-86dc-4d2b3262ed86"), 50.0, "A", 8, "MOTORCYCLE" },
                    { new Guid("575d13f0-2267-480c-afa2-38b4079d8163"), new Guid("b26c6185-7128-4959-b92d-665002dce200"), 300.0, "B", 3, "TRUCK" },
                    { new Guid("578acbbd-d368-478c-93de-662189f6a023"), new Guid("c23b858e-6380-4605-81ed-fae4578261ea"), 50.0, "B", 4, "MOTORCYCLE" },
                    { new Guid("57cd3d2a-8430-402a-909a-954d9cb0cb55"), new Guid("635a063b-8794-4510-b61d-899c3b425034"), 200.0, "B", 8, "VAN" },
                    { new Guid("581fc8f4-9969-418e-9e51-2699b9d880f5"), new Guid("c23b858e-6380-4605-81ed-fae4578261ea"), 50.0, "B", 1, "MOTORCYCLE" },
                    { new Guid("5827caec-2494-4a15-91e0-4e522d1be1d2"), new Guid("59eb481c-e88b-4a04-93c8-aa9fad3b8fbd"), 300.0, "A", 6, "TRUCK" },
                    { new Guid("586a7073-adb8-4f69-95ca-7a522263d732"), new Guid("70713bfe-20a7-4b8e-bcc9-7cd0e57ae2cf"), 50.0, "B", 1, "MOTORCYCLE" },
                    { new Guid("58ec4fcd-d9de-494d-b983-a39bea7aa744"), new Guid("d09a2181-65c3-4ee5-b8b3-d4ea251a8fbf"), 50.0, "A", 7, "MOTORCYCLE" },
                    { new Guid("5918de75-058b-4964-9b37-b22414d8f77e"), new Guid("fc2a8276-f127-4246-86dc-4d2b3262ed86"), 50.0, "A", 7, "MOTORCYCLE" },
                    { new Guid("597c5ee2-de07-4765-affe-c3cde5c74bde"), new Guid("aae01dc0-240f-4c2b-85b8-db1d578305ed"), 100.0, "B", 1, "CAR" },
                    { new Guid("5a0d21c0-147c-425d-a860-e5a2a834909b"), new Guid("fc11e465-6669-4617-a41f-a1d1c76a908a"), 300.0, "B", 8, "TRUCK" },
                    { new Guid("5a0e8d04-51cb-47ef-af01-ae14670cbaa5"), new Guid("86f938e1-046b-4c2d-80ba-6eb7d3f4b2b9"), 200.0, "A", 1, "VAN" },
                    { new Guid("5a46fb1e-3e54-4416-ae02-671234b2b1cd"), new Guid("8886b676-b97c-4d0b-ae45-d18b2f2df900"), 200.0, "B", 5, "VAN" },
                    { new Guid("5a84e9c1-40b3-4c6e-932b-2247bf4438da"), new Guid("188984fb-f6f2-43a8-8f42-5761cf166a56"), 300.0, "A", 7, "TRUCK" },
                    { new Guid("5ab0394f-6810-46a7-88e1-372fc946f1bb"), new Guid("1a0fc976-15ce-4e8e-9ce1-e01456178b41"), 100.0, "A", 4, "CAR" },
                    { new Guid("5aefa7d8-24cd-4ec5-a6e5-08bfd28880f6"), new Guid("1a0fc976-15ce-4e8e-9ce1-e01456178b41"), 300.0, "B", 5, "TRUCK" },
                    { new Guid("5b00b417-b7b7-4172-b92c-4c6051f53aea"), new Guid("fc11e465-6669-4617-a41f-a1d1c76a908a"), 200.0, "A", 2, "VAN" },
                    { new Guid("5b06c77a-8026-475f-9ffd-936310b507f3"), new Guid("bf21db4e-8dd6-4bc3-9d0d-1e673e3c0541"), 100.0, "B", 4, "CAR" },
                    { new Guid("5b39cc7c-6ebb-41ce-8205-e5c5bb1bb870"), new Guid("188984fb-f6f2-43a8-8f42-5761cf166a56"), 200.0, "B", 2, "VAN" },
                    { new Guid("5b5d90e9-b9ca-4877-bf80-57f0fd1a25a0"), new Guid("1a0fc976-15ce-4e8e-9ce1-e01456178b41"), 100.0, "A", 6, "CAR" },
                    { new Guid("5b8e9206-e180-4997-9d73-52dfede0fd54"), new Guid("59eb481c-e88b-4a04-93c8-aa9fad3b8fbd"), 200.0, "B", 2, "VAN" },
                    { new Guid("5bb207c3-1055-4b41-abed-c2d101bd9ed1"), new Guid("3d85c54a-5fcb-49b5-a370-4c5d3216ae4f"), 200.0, "A", 3, "VAN" },
                    { new Guid("5bce2f29-80d0-4adb-bcf4-59a8c17bf7bf"), new Guid("d6240ccd-9331-4c53-91af-3b1992316096"), 100.0, "B", 1, "CAR" },
                    { new Guid("5c285ccb-b01e-4460-a369-b85d1e1a31a7"), new Guid("891fbb4c-6ace-4cd9-ba70-deb2d06886bc"), 300.0, "B", 2, "TRUCK" },
                    { new Guid("5c8226a2-30b6-40ab-ac79-8b0b869eb73f"), new Guid("cf8ba59d-1e62-43aa-b128-f92651d868c4"), 100.0, "B", 2, "CAR" },
                    { new Guid("5c96ef83-16db-4b97-adf2-7ee9e900dedf"), new Guid("3d85c54a-5fcb-49b5-a370-4c5d3216ae4f"), 200.0, "B", 2, "VAN" },
                    { new Guid("5cceddab-b39f-4141-bb2f-e3f6bc1e1eca"), new Guid("bcf6224b-83e4-44b6-84b7-9a5b11f6f78d"), 100.0, "A", 3, "CAR" },
                    { new Guid("5d2ae4c8-8f0c-446c-a254-3a0bbbd5770d"), new Guid("930245a8-ee38-4501-a6ec-b31839348aaa"), 100.0, "A", 2, "CAR" },
                    { new Guid("5e392907-0a1f-4343-a5ef-17a5a164d8dd"), new Guid("7b821087-607f-4dd9-a07b-18f22d1c8fd8"), 100.0, "B", 8, "CAR" },
                    { new Guid("5e56eb12-ee71-45ee-a5fa-d2c1517e23b5"), new Guid("e3c60e04-8b6c-497d-b040-30019f1951fe"), 200.0, "B", 8, "VAN" },
                    { new Guid("5ed4b514-2e29-409e-bc98-18474ddede96"), new Guid("322b8d0b-4524-4cd9-b4e5-1312d61fa572"), 200.0, "B", 6, "VAN" },
                    { new Guid("5eeb8469-d9d2-43b4-8cad-7f5a89bd14bb"), new Guid("e2826ba2-5ca3-4ce6-ac50-811f085e3cf6"), 100.0, "B", 8, "CAR" },
                    { new Guid("5f053f86-5955-4776-b7e0-e83254d4992d"), new Guid("3f771136-710d-4c9b-94ca-00b8c3abdd93"), 50.0, "B", 5, "MOTORCYCLE" },
                    { new Guid("5f0e0f3e-4a6c-4501-8ac4-38cd26c2e001"), new Guid("cfba1888-af59-40c6-bf90-ff89882538a3"), 200.0, "B", 5, "VAN" },
                    { new Guid("5f909831-3c75-486d-a6fc-56ff80f99aa3"), new Guid("3d85c54a-5fcb-49b5-a370-4c5d3216ae4f"), 200.0, "A", 8, "VAN" },
                    { new Guid("5fd7e22c-e9d5-467c-b8e4-5b10ea386712"), new Guid("ae16885c-9a8e-49a8-b817-0be9a9960d0f"), 200.0, "B", 7, "VAN" },
                    { new Guid("5fda9076-9829-4255-8f66-66464f3d3b75"), new Guid("f3297de4-ea7b-42da-993e-9ae374023e94"), 50.0, "A", 2, "MOTORCYCLE" },
                    { new Guid("603f8516-98a1-4083-8616-f84b0f164854"), new Guid("b26c6185-7128-4959-b92d-665002dce200"), 300.0, "B", 4, "TRUCK" },
                    { new Guid("60a8d8fa-4291-43e0-9f87-c8edb178e9aa"), new Guid("2848fcc2-f6b3-4b91-a829-47543cd6f877"), 200.0, "B", 3, "VAN" },
                    { new Guid("60e43b4e-edda-41be-b03f-a86c3bbd1164"), new Guid("8e054a25-6fd3-4e9d-b12b-aaa8e6ac85eb"), 100.0, "B", 3, "CAR" },
                    { new Guid("60fc49ca-5f27-48d0-b378-3398f2eae19c"), new Guid("19bcc6b0-45ed-4845-b411-400d4f6683b2"), 100.0, "A", 6, "CAR" },
                    { new Guid("61cc01f4-c4ab-485c-a9f4-746c2f78a908"), new Guid("52688c85-e7f4-47e9-b9f2-d508de79f823"), 100.0, "B", 7, "CAR" },
                    { new Guid("61d39ea5-788d-4b4a-9db2-97190d33d86b"), new Guid("52688c85-e7f4-47e9-b9f2-d508de79f823"), 100.0, "B", 5, "CAR" },
                    { new Guid("62058d24-770b-4895-86a8-09fb25a01746"), new Guid("a8827db7-700c-4e56-94f6-2a77e3f61a9c"), 50.0, "B", 8, "MOTORCYCLE" },
                    { new Guid("6228bd28-fec0-497c-981c-6ec25667ad60"), new Guid("d09a2181-65c3-4ee5-b8b3-d4ea251a8fbf"), 100.0, "B", 4, "CAR" },
                    { new Guid("6230ea89-5065-4b5d-859e-0f29c20a1ab4"), new Guid("b26c6185-7128-4959-b92d-665002dce200"), 300.0, "B", 6, "TRUCK" },
                    { new Guid("6250f1e8-c32c-4b85-9281-41c57a8f2974"), new Guid("a8827db7-700c-4e56-94f6-2a77e3f61a9c"), 50.0, "B", 5, "MOTORCYCLE" },
                    { new Guid("6258abe1-599f-4eec-b6af-b3e0517452ac"), new Guid("f3297de4-ea7b-42da-993e-9ae374023e94"), 300.0, "B", 5, "TRUCK" },
                    { new Guid("634ef4cb-d5b6-48c5-82a9-17f47bb6af4b"), new Guid("e2826ba2-5ca3-4ce6-ac50-811f085e3cf6"), 100.0, "B", 3, "CAR" },
                    { new Guid("6351ab89-27f0-4ebc-9cf6-b65c585d3223"), new Guid("2848fcc2-f6b3-4b91-a829-47543cd6f877"), 300.0, "A", 6, "TRUCK" },
                    { new Guid("63790b3b-fc8c-4803-ab04-e2f1392964e3"), new Guid("e5cb274b-9061-42f7-aff5-97663074409e"), 50.0, "B", 7, "MOTORCYCLE" },
                    { new Guid("646c11f7-7031-4663-a397-4888678436b5"), new Guid("fc2a8276-f127-4246-86dc-4d2b3262ed86"), 50.0, "A", 2, "MOTORCYCLE" },
                    { new Guid("648c85db-c850-4e7c-84bf-bf16cb2bdd3d"), new Guid("c4fb855c-c3fd-4224-909c-e4cb4ebef275"), 100.0, "B", 6, "CAR" },
                    { new Guid("64b80f42-3962-4d77-b21f-eff3c41a89b4"), new Guid("cfba1888-af59-40c6-bf90-ff89882538a3"), 100.0, "A", 6, "CAR" },
                    { new Guid("64e15ea7-3bd0-44f7-9ee1-09e935cd2705"), new Guid("b26c6185-7128-4959-b92d-665002dce200"), 300.0, "A", 2, "TRUCK" },
                    { new Guid("650cdfb8-9a9f-4d47-af50-bb9b4e4d0a0f"), new Guid("635a063b-8794-4510-b61d-899c3b425034"), 200.0, "A", 1, "VAN" },
                    { new Guid("652294dc-63a1-4ca0-bf40-7787f12fa829"), new Guid("59e5fd81-c04a-450d-bdd6-c36e80361881"), 50.0, "A", 6, "MOTORCYCLE" },
                    { new Guid("65351b17-0e4b-4195-8510-8ce8c38c25f4"), new Guid("70713bfe-20a7-4b8e-bcc9-7cd0e57ae2cf"), 200.0, "A", 8, "VAN" },
                    { new Guid("65826fbb-104f-4a96-a035-8c0a1730e0f6"), new Guid("6f8b493b-9523-43ba-9a39-6080882550be"), 100.0, "A", 4, "CAR" },
                    { new Guid("65cb6eba-c577-4adb-ac74-816152d06767"), new Guid("fe188580-6e2f-4ff8-a49e-814745f688b7"), 300.0, "A", 5, "TRUCK" },
                    { new Guid("65fc56a1-0c3a-4ee0-b146-ac743e89aeec"), new Guid("e2826ba2-5ca3-4ce6-ac50-811f085e3cf6"), 100.0, "A", 8, "CAR" },
                    { new Guid("660030dc-9f42-4005-856f-63165e497bfb"), new Guid("7b821087-607f-4dd9-a07b-18f22d1c8fd8"), 100.0, "A", 8, "CAR" },
                    { new Guid("66645cf0-82fe-4edc-aea3-1725256806ab"), new Guid("d65b48a9-6c74-44b4-aaf3-635151fa5984"), 50.0, "A", 7, "MOTORCYCLE" },
                    { new Guid("6664e884-c0d8-4ef1-974c-bf7759d28af9"), new Guid("257b5f9f-b092-41af-beb1-2a2808fe0fc8"), 300.0, "A", 6, "TRUCK" },
                    { new Guid("66a6128f-fbc8-40ba-8f56-0841cd0bfad6"), new Guid("c5174f79-1a96-4d56-ae5b-b089b385e4f5"), 300.0, "A", 3, "TRUCK" },
                    { new Guid("6716fda0-e534-45a4-a975-9c935479fd7e"), new Guid("6caabf59-5600-43f0-98c9-ab24acf0dadf"), 100.0, "B", 7, "CAR" },
                    { new Guid("67967b02-cf84-4244-9f79-0c3d82474b60"), new Guid("e5cb274b-9061-42f7-aff5-97663074409e"), 50.0, "B", 8, "MOTORCYCLE" },
                    { new Guid("67bc1e36-ac11-4146-a9e7-00ec2a611ca1"), new Guid("c23b858e-6380-4605-81ed-fae4578261ea"), 50.0, "A", 4, "MOTORCYCLE" },
                    { new Guid("67f46469-fd8e-4398-8861-770c503d1590"), new Guid("a8827db7-700c-4e56-94f6-2a77e3f61a9c"), 300.0, "A", 6, "TRUCK" },
                    { new Guid("68450ef1-cfec-4c65-a24f-4a430777aa9a"), new Guid("86f938e1-046b-4c2d-80ba-6eb7d3f4b2b9"), 50.0, "B", 3, "MOTORCYCLE" },
                    { new Guid("685d023f-9218-456f-a152-a0bcdc999eef"), new Guid("fd6deed8-c835-4168-8d92-abafacbe20b6"), 50.0, "A", 6, "MOTORCYCLE" },
                    { new Guid("689a9d52-d731-4a94-a634-c010df51b6b0"), new Guid("cfba1888-af59-40c6-bf90-ff89882538a3"), 200.0, "B", 4, "VAN" },
                    { new Guid("68bda25b-d2de-4325-aa04-8b6c8be43259"), new Guid("635a063b-8794-4510-b61d-899c3b425034"), 200.0, "A", 7, "VAN" },
                    { new Guid("69b4f072-fda8-4b5e-b7b7-62c83801553d"), new Guid("610d361a-c14c-4e3a-9ddb-700cd803bb7d"), 100.0, "B", 5, "CAR" },
                    { new Guid("69de897b-e444-4ce5-b039-a1f4b077940d"), new Guid("e3c60e04-8b6c-497d-b040-30019f1951fe"), 300.0, "A", 2, "TRUCK" },
                    { new Guid("69e68c96-2e4a-485c-8971-5591c8cfaf7e"), new Guid("cf8ba59d-1e62-43aa-b128-f92651d868c4"), 300.0, "A", 6, "TRUCK" },
                    { new Guid("6a4a4a2b-19c8-406c-93bd-12934dba0076"), new Guid("59eb481c-e88b-4a04-93c8-aa9fad3b8fbd"), 300.0, "A", 8, "TRUCK" },
                    { new Guid("6b602ce5-72e4-4a24-97c8-38a0ce9f5ff5"), new Guid("891fbb4c-6ace-4cd9-ba70-deb2d06886bc"), 100.0, "A", 8, "CAR" },
                    { new Guid("6bd7dd97-41cb-47e4-9c82-20b89986465a"), new Guid("8886b676-b97c-4d0b-ae45-d18b2f2df900"), 100.0, "A", 5, "CAR" },
                    { new Guid("6c22351c-1597-422e-abc2-c45320770207"), new Guid("eb384a62-fea4-491c-a7a3-8a4e2c92b0c6"), 300.0, "A", 5, "TRUCK" },
                    { new Guid("6c412e8a-7345-4d8e-b36d-cd02d410869b"), new Guid("2cde977d-867d-40de-9a10-432b2301464c"), 50.0, "B", 4, "MOTORCYCLE" },
                    { new Guid("6c5540a6-dae9-4a68-853f-642f1700fcbb"), new Guid("635a063b-8794-4510-b61d-899c3b425034"), 200.0, "A", 5, "VAN" },
                    { new Guid("6ca3e4d3-9a58-4e4f-b84f-0acc129f4085"), new Guid("85611762-85eb-4a9a-a993-dc85d0a68cca"), 300.0, "A", 8, "TRUCK" },
                    { new Guid("6ce2af07-4370-42dd-a053-b1b6f3f08923"), new Guid("5db7d818-7b21-4b81-8cf8-99d99ffaf375"), 50.0, "A", 2, "MOTORCYCLE" },
                    { new Guid("6d3670c3-6322-4d3a-b766-f0387ffc126a"), new Guid("d65b48a9-6c74-44b4-aaf3-635151fa5984"), 50.0, "A", 4, "MOTORCYCLE" },
                    { new Guid("6d3cdff2-e3d9-4519-8124-beb96a51d2be"), new Guid("1a0fc976-15ce-4e8e-9ce1-e01456178b41"), 100.0, "A", 3, "CAR" },
                    { new Guid("6d878322-5988-4eaf-b77c-a125d9bb41cf"), new Guid("d6240ccd-9331-4c53-91af-3b1992316096"), 100.0, "B", 4, "CAR" },
                    { new Guid("6d8b1329-fd91-4b25-a9d0-cb2d487f8e82"), new Guid("8886b676-b97c-4d0b-ae45-d18b2f2df900"), 200.0, "B", 7, "VAN" },
                    { new Guid("6de4c473-6c9e-4601-8d84-d711caf118e3"), new Guid("9c6c5b2a-00b3-448c-81cc-a9010d2d4196"), 50.0, "B", 4, "MOTORCYCLE" },
                    { new Guid("6e042dca-16c1-44fe-ace1-7b0e49a9fb6c"), new Guid("5db7d818-7b21-4b81-8cf8-99d99ffaf375"), 50.0, "A", 3, "MOTORCYCLE" },
                    { new Guid("6e118b05-33dd-496b-a127-be07999413c9"), new Guid("19bcc6b0-45ed-4845-b411-400d4f6683b2"), 100.0, "A", 8, "CAR" },
                    { new Guid("6e31647d-af45-4fce-b490-bb44b60feff4"), new Guid("891fbb4c-6ace-4cd9-ba70-deb2d06886bc"), 100.0, "A", 7, "CAR" },
                    { new Guid("6e5c6b91-6ae2-4804-9e56-6fa2834c8a58"), new Guid("e3c60e04-8b6c-497d-b040-30019f1951fe"), 200.0, "B", 3, "VAN" },
                    { new Guid("6f613c2a-ca27-46a1-8521-a2ac43527fd6"), new Guid("b26c6185-7128-4959-b92d-665002dce200"), 300.0, "A", 1, "TRUCK" },
                    { new Guid("6f63352f-4d6e-4e93-b24c-afe00751cf1d"), new Guid("257b5f9f-b092-41af-beb1-2a2808fe0fc8"), 100.0, "B", 8, "CAR" },
                    { new Guid("6f8e58b4-4110-44fd-83d8-655ee2ea91e8"), new Guid("e21cdfc0-d3d8-47cc-8b74-bdf62436fcdb"), 200.0, "A", 4, "VAN" },
                    { new Guid("6fd864c6-a7c3-4814-9bff-3942773de67e"), new Guid("8e054a25-6fd3-4e9d-b12b-aaa8e6ac85eb"), 200.0, "A", 7, "VAN" },
                    { new Guid("6ffcf025-f118-484b-a995-7b435887f0e6"), new Guid("d65b48a9-6c74-44b4-aaf3-635151fa5984"), 50.0, "B", 1, "MOTORCYCLE" },
                    { new Guid("706dd9dc-b416-456e-b0c4-5b3ad0b2b14c"), new Guid("5db7d818-7b21-4b81-8cf8-99d99ffaf375"), 200.0, "B", 7, "VAN" },
                    { new Guid("70ae294f-cd6c-4c96-a605-6c6793ced309"), new Guid("930245a8-ee38-4501-a6ec-b31839348aaa"), 100.0, "A", 3, "CAR" },
                    { new Guid("711f68c8-351e-4386-82cb-7545f97dab45"), new Guid("c4fb855c-c3fd-4224-909c-e4cb4ebef275"), 100.0, "B", 2, "CAR" },
                    { new Guid("7192b789-6281-4072-a82a-54af7d22c915"), new Guid("85611762-85eb-4a9a-a993-dc85d0a68cca"), 50.0, "B", 4, "MOTORCYCLE" },
                    { new Guid("719f78a3-89c3-4d89-8501-b93d0b7e3e25"), new Guid("5a694bc0-b3ea-4d3b-b228-1555a8738e1d"), 200.0, "A", 4, "VAN" },
                    { new Guid("71afc361-9075-454b-82bf-ad451405d5ce"), new Guid("f3297de4-ea7b-42da-993e-9ae374023e94"), 300.0, "B", 4, "TRUCK" },
                    { new Guid("71edf2d2-fed6-45ce-a2c4-9b5eb22b4ab9"), new Guid("b75467ff-4404-40c1-8269-b787f50a14dc"), 100.0, "A", 4, "CAR" },
                    { new Guid("721c715b-9b71-4edf-9dd0-a50bcba5fc9c"), new Guid("0ada6bc9-6665-49b2-a427-5ad008b51fda"), 100.0, "B", 1, "CAR" },
                    { new Guid("72479571-41ba-4c64-9f58-678e711f2822"), new Guid("aae01dc0-240f-4c2b-85b8-db1d578305ed"), 100.0, "B", 7, "CAR" },
                    { new Guid("7248c679-e5d6-4cfd-8a6f-aaca82b1a090"), new Guid("387a98b1-c216-4873-9812-b12a9aca5ac7"), 50.0, "B", 6, "MOTORCYCLE" },
                    { new Guid("72cff4f8-26e3-49c9-9120-d3cfbf80358b"), new Guid("7b821087-607f-4dd9-a07b-18f22d1c8fd8"), 100.0, "A", 7, "CAR" },
                    { new Guid("72f45cd6-1122-4af5-8533-e58ee3c9546e"), new Guid("2848fcc2-f6b3-4b91-a829-47543cd6f877"), 300.0, "A", 8, "TRUCK" },
                    { new Guid("73334cbb-929f-4f25-9423-13fc6de7950c"), new Guid("7140654e-28d2-494f-a602-8bb6bff2fc13"), 50.0, "B", 7, "MOTORCYCLE" },
                    { new Guid("73d58b57-3642-44d1-8fbc-cb6fae8d8dd7"), new Guid("c5174f79-1a96-4d56-ae5b-b089b385e4f5"), 300.0, "B", 1, "TRUCK" },
                    { new Guid("7413fdbe-6be8-4b46-b649-f1fdb772725d"), new Guid("8886b676-b97c-4d0b-ae45-d18b2f2df900"), 200.0, "B", 1, "VAN" },
                    { new Guid("74207d90-adc5-4e51-920b-da7c4b11e2b0"), new Guid("6caabf59-5600-43f0-98c9-ab24acf0dadf"), 300.0, "A", 4, "TRUCK" },
                    { new Guid("74390565-f2ab-4276-9868-01b50718dca2"), new Guid("e21cdfc0-d3d8-47cc-8b74-bdf62436fcdb"), 300.0, "B", 3, "TRUCK" },
                    { new Guid("74721265-f028-4616-b7f7-72b28ac87a5c"), new Guid("e3c60e04-8b6c-497d-b040-30019f1951fe"), 300.0, "A", 3, "TRUCK" },
                    { new Guid("748ef50c-eaee-4d5e-96c5-c6fa92c75da3"), new Guid("cfba1888-af59-40c6-bf90-ff89882538a3"), 200.0, "B", 7, "VAN" },
                    { new Guid("74b3ba45-58e1-4023-83fe-48299c96249c"), new Guid("d6240ccd-9331-4c53-91af-3b1992316096"), 100.0, "B", 6, "CAR" },
                    { new Guid("74d63826-5bf3-42dd-b3d7-78041dadad5a"), new Guid("7b821087-607f-4dd9-a07b-18f22d1c8fd8"), 100.0, "B", 4, "CAR" },
                    { new Guid("75397a4c-6dc1-4b51-bf87-41670d27752d"), new Guid("59e5fd81-c04a-450d-bdd6-c36e80361881"), 50.0, "A", 3, "MOTORCYCLE" },
                    { new Guid("7569e159-b459-4a0f-85eb-f9d0f018b301"), new Guid("6caabf59-5600-43f0-98c9-ab24acf0dadf"), 100.0, "B", 8, "CAR" },
                    { new Guid("7580d18e-e0b3-4f74-b73f-44f040220732"), new Guid("1a0fc976-15ce-4e8e-9ce1-e01456178b41"), 300.0, "B", 8, "TRUCK" },
                    { new Guid("759e70f9-ff9b-4c37-9a87-e957ec0cb967"), new Guid("7140654e-28d2-494f-a602-8bb6bff2fc13"), 200.0, "A", 2, "VAN" },
                    { new Guid("75ba4f9d-ce35-4d34-ae63-580246d0d561"), new Guid("d09a2181-65c3-4ee5-b8b3-d4ea251a8fbf"), 100.0, "B", 2, "CAR" },
                    { new Guid("75c68d90-9990-483a-b0f0-ca9d4b5d7ceb"), new Guid("59e5fd81-c04a-450d-bdd6-c36e80361881"), 50.0, "A", 4, "MOTORCYCLE" },
                    { new Guid("75eb527d-d791-4ec6-b48f-cda9054ac4c9"), new Guid("38633289-34c0-438f-b007-976f825ec000"), 50.0, "A", 7, "MOTORCYCLE" },
                    { new Guid("75fb272d-5dc7-43e2-817e-de373f52e305"), new Guid("5db7d818-7b21-4b81-8cf8-99d99ffaf375"), 200.0, "B", 6, "VAN" },
                    { new Guid("760d66f5-90b5-4161-b3e9-44d29103ac58"), new Guid("f3297de4-ea7b-42da-993e-9ae374023e94"), 50.0, "A", 4, "MOTORCYCLE" },
                    { new Guid("7611a6a5-03e4-4738-b0cb-b5667a52cf3a"), new Guid("52688c85-e7f4-47e9-b9f2-d508de79f823"), 100.0, "B", 8, "CAR" },
                    { new Guid("762ec938-616b-49b9-9c2d-c4d3408b8674"), new Guid("2cde977d-867d-40de-9a10-432b2301464c"), 300.0, "A", 6, "TRUCK" },
                    { new Guid("768b11a4-9a63-4c8a-9cf3-ef50efa2a9bb"), new Guid("c4fb855c-c3fd-4224-909c-e4cb4ebef275"), 100.0, "B", 8, "CAR" },
                    { new Guid("76abb8a3-ba7d-4086-849e-6f6e2c7d7771"), new Guid("c5174f79-1a96-4d56-ae5b-b089b385e4f5"), 300.0, "A", 4, "TRUCK" },
                    { new Guid("76faa7c8-19fa-43b4-90d9-1c2b4dd4a4f1"), new Guid("c5174f79-1a96-4d56-ae5b-b089b385e4f5"), 300.0, "B", 6, "TRUCK" },
                    { new Guid("77b3adf8-bb55-4e4d-9c42-8357f229c505"), new Guid("e2826ba2-5ca3-4ce6-ac50-811f085e3cf6"), 100.0, "B", 6, "CAR" },
                    { new Guid("77b56f79-77f2-4f29-896b-db213e9f0552"), new Guid("d65b48a9-6c74-44b4-aaf3-635151fa5984"), 50.0, "B", 8, "MOTORCYCLE" },
                    { new Guid("77cdf0f1-80f1-4046-83e3-f4e79808d15f"), new Guid("e5cb274b-9061-42f7-aff5-97663074409e"), 300.0, "A", 6, "TRUCK" },
                    { new Guid("78370809-5141-4aa2-ace4-e607ca6a1d3e"), new Guid("610d361a-c14c-4e3a-9ddb-700cd803bb7d"), 100.0, "B", 4, "CAR" },
                    { new Guid("7849872b-1340-43a9-99b6-308ea15b3b3b"), new Guid("930245a8-ee38-4501-a6ec-b31839348aaa"), 100.0, "B", 2, "CAR" },
                    { new Guid("7864b1bb-70fe-4544-b801-f243f7ae3ff2"), new Guid("1a0fc976-15ce-4e8e-9ce1-e01456178b41"), 300.0, "B", 4, "TRUCK" },
                    { new Guid("78bde407-c45c-4703-8354-a432ed1b54ed"), new Guid("b26c6185-7128-4959-b92d-665002dce200"), 300.0, "B", 2, "TRUCK" },
                    { new Guid("796262af-1270-4f77-9978-2934785f3049"), new Guid("52688c85-e7f4-47e9-b9f2-d508de79f823"), 200.0, "A", 3, "VAN" },
                    { new Guid("797b7337-7a54-4610-af8d-0d0d96052b70"), new Guid("52688c85-e7f4-47e9-b9f2-d508de79f823"), 200.0, "A", 7, "VAN" },
                    { new Guid("798deea0-8906-4ed2-bd44-3a2a80297401"), new Guid("1a0fc976-15ce-4e8e-9ce1-e01456178b41"), 100.0, "A", 5, "CAR" },
                    { new Guid("79af75c8-8526-467e-a18a-1b19a93556b8"), new Guid("5a694bc0-b3ea-4d3b-b228-1555a8738e1d"), 200.0, "A", 5, "VAN" },
                    { new Guid("79b69751-2d45-4e71-a91c-537d7a244f48"), new Guid("cfba1888-af59-40c6-bf90-ff89882538a3"), 100.0, "A", 1, "CAR" },
                    { new Guid("79ba705d-b2d4-43e8-a27a-615cfd176537"), new Guid("cfba1888-af59-40c6-bf90-ff89882538a3"), 100.0, "A", 4, "CAR" },
                    { new Guid("79f11dff-f3c8-41cd-8f96-7673c99f50b2"), new Guid("eb384a62-fea4-491c-a7a3-8a4e2c92b0c6"), 300.0, "A", 6, "TRUCK" },
                    { new Guid("7a7c1b54-dc0a-41e5-80cb-ab7936ddcbe9"), new Guid("8e054a25-6fd3-4e9d-b12b-aaa8e6ac85eb"), 100.0, "B", 5, "CAR" },
                    { new Guid("7ad16e42-ef5e-457c-8736-6e43a0c49ab8"), new Guid("eb384a62-fea4-491c-a7a3-8a4e2c92b0c6"), 300.0, "A", 8, "TRUCK" },
                    { new Guid("7b0cf5d7-7e5b-4779-9b95-c8bc106a584a"), new Guid("d6240ccd-9331-4c53-91af-3b1992316096"), 100.0, "B", 8, "CAR" },
                    { new Guid("7b37232b-b798-4542-ba73-649d7b75b113"), new Guid("188984fb-f6f2-43a8-8f42-5761cf166a56"), 200.0, "B", 7, "VAN" },
                    { new Guid("7b38ebad-e9eb-4d46-a821-71843f682988"), new Guid("59e5fd81-c04a-450d-bdd6-c36e80361881"), 50.0, "A", 8, "MOTORCYCLE" },
                    { new Guid("7b5bf3a8-9df1-4680-a8c4-93fe329582fe"), new Guid("aae01dc0-240f-4c2b-85b8-db1d578305ed"), 100.0, "A", 1, "CAR" },
                    { new Guid("7bfababf-8f69-430c-9325-63ca16da7416"), new Guid("7140654e-28d2-494f-a602-8bb6bff2fc13"), 50.0, "B", 6, "MOTORCYCLE" },
                    { new Guid("7c72d8ed-2811-4ab6-9807-bd0c4ea09268"), new Guid("322b8d0b-4524-4cd9-b4e5-1312d61fa572"), 200.0, "A", 8, "VAN" },
                    { new Guid("7d9dfd98-23d3-4570-9418-af4a894eb90b"), new Guid("7140654e-28d2-494f-a602-8bb6bff2fc13"), 50.0, "B", 3, "MOTORCYCLE" },
                    { new Guid("7dab372b-58bc-4cfd-8db6-54338e1043eb"), new Guid("aae01dc0-240f-4c2b-85b8-db1d578305ed"), 100.0, "A", 4, "CAR" },
                    { new Guid("7dd834ee-7714-4679-b09e-f8a6ec6919be"), new Guid("9c6c5b2a-00b3-448c-81cc-a9010d2d4196"), 300.0, "A", 8, "TRUCK" },
                    { new Guid("7e0e3e40-a557-4f3e-a4b1-3ad00a5ec89c"), new Guid("6caabf59-5600-43f0-98c9-ab24acf0dadf"), 100.0, "B", 4, "CAR" },
                    { new Guid("7e31b952-5878-466b-9700-8af21e3bf56d"), new Guid("ae16885c-9a8e-49a8-b817-0be9a9960d0f"), 200.0, "B", 3, "VAN" },
                    { new Guid("7ecc7fe0-73b1-41a7-ac36-53842bc1979f"), new Guid("257b5f9f-b092-41af-beb1-2a2808fe0fc8"), 300.0, "A", 8, "TRUCK" },
                    { new Guid("7efbfaf3-9666-42ee-8b95-0d3ffa751988"), new Guid("257b5f9f-b092-41af-beb1-2a2808fe0fc8"), 100.0, "B", 6, "CAR" },
                    { new Guid("80044896-f28c-4def-a6e9-3d7ffe70e261"), new Guid("38633289-34c0-438f-b007-976f825ec000"), 50.0, "A", 3, "MOTORCYCLE" },
                    { new Guid("80215557-516a-4e48-aba5-fcb57b041357"), new Guid("495b86e8-5b8f-4f62-8ade-e8152d743878"), 50.0, "A", 7, "MOTORCYCLE" },
                    { new Guid("80c1ce08-d53e-4651-998b-3db57bd69c9f"), new Guid("19bcc6b0-45ed-4845-b411-400d4f6683b2"), 100.0, "A", 2, "CAR" },
                    { new Guid("816e9ec1-5d7d-4c33-b2fd-1a5d2777541c"), new Guid("6f8b493b-9523-43ba-9a39-6080882550be"), 300.0, "B", 6, "TRUCK" },
                    { new Guid("8194fa6b-daae-4b9e-a334-21e115dc6668"), new Guid("31faa74a-240a-4f20-a8e9-fc79657b09d4"), 300.0, "A", 5, "TRUCK" },
                    { new Guid("81b74b30-9945-43f1-bdf4-879fadbe7477"), new Guid("c23b858e-6380-4605-81ed-fae4578261ea"), 50.0, "B", 3, "MOTORCYCLE" },
                    { new Guid("81d709ef-b8dc-4968-9125-2f2755b849da"), new Guid("52688c85-e7f4-47e9-b9f2-d508de79f823"), 200.0, "A", 1, "VAN" },
                    { new Guid("81db0ee8-6cd8-4638-97e6-d17ae4e102b9"), new Guid("322b8d0b-4524-4cd9-b4e5-1312d61fa572"), 200.0, "A", 3, "VAN" },
                    { new Guid("81dd3327-2928-4bc7-8963-0528f7b5cbbb"), new Guid("ae16885c-9a8e-49a8-b817-0be9a9960d0f"), 300.0, "A", 3, "TRUCK" },
                    { new Guid("8275a752-e321-4627-b5bc-e43301309c6f"), new Guid("d09a2181-65c3-4ee5-b8b3-d4ea251a8fbf"), 50.0, "A", 3, "MOTORCYCLE" },
                    { new Guid("8285c64f-ace3-4362-8c8a-9d6ff15c9e40"), new Guid("f3297de4-ea7b-42da-993e-9ae374023e94"), 300.0, "B", 3, "TRUCK" },
                    { new Guid("830d958f-b1e8-4d28-96b7-a18916e97689"), new Guid("85611762-85eb-4a9a-a993-dc85d0a68cca"), 50.0, "B", 7, "MOTORCYCLE" },
                    { new Guid("83384ac8-79ae-42e3-acf7-239dba3c58f9"), new Guid("59eb481c-e88b-4a04-93c8-aa9fad3b8fbd"), 300.0, "A", 5, "TRUCK" },
                    { new Guid("8354ed1a-d1e3-4e30-8805-d687fba1e38b"), new Guid("3f771136-710d-4c9b-94ca-00b8c3abdd93"), 50.0, "B", 7, "MOTORCYCLE" },
                    { new Guid("83602b22-ccb8-4275-bcb7-5a102e030028"), new Guid("8886b676-b97c-4d0b-ae45-d18b2f2df900"), 200.0, "B", 4, "VAN" },
                    { new Guid("840a5915-963a-46de-b780-6f250ec7b287"), new Guid("fc2a8276-f127-4246-86dc-4d2b3262ed86"), 50.0, "A", 6, "MOTORCYCLE" },
                    { new Guid("84cc9a0f-0486-47b3-acf4-0a9f44da10a4"), new Guid("9c6c5b2a-00b3-448c-81cc-a9010d2d4196"), 50.0, "B", 1, "MOTORCYCLE" },
                    { new Guid("84d495df-de40-454e-ba03-58da7c1de911"), new Guid("31faa74a-240a-4f20-a8e9-fc79657b09d4"), 300.0, "A", 6, "TRUCK" },
                    { new Guid("84f3964d-bb02-41b7-b149-21905d119999"), new Guid("59e5fd81-c04a-450d-bdd6-c36e80361881"), 300.0, "B", 5, "TRUCK" },
                    { new Guid("84f68d15-eb85-47a3-bc73-b7ab046e610b"), new Guid("c4fb855c-c3fd-4224-909c-e4cb4ebef275"), 300.0, "A", 8, "TRUCK" },
                    { new Guid("853353e8-f6ab-43d6-87af-c80c252af907"), new Guid("f35520f7-2e5e-4340-ba78-c10259f8c8c5"), 100.0, "B", 4, "CAR" },
                    { new Guid("85bfbea4-0c5b-47f3-b747-5f8e2749a694"), new Guid("b75467ff-4404-40c1-8269-b787f50a14dc"), 100.0, "B", 5, "CAR" },
                    { new Guid("85c04380-87de-4602-af62-6c88bc477cdd"), new Guid("19bcc6b0-45ed-4845-b411-400d4f6683b2"), 100.0, "B", 3, "CAR" },
                    { new Guid("85edf543-90e6-47eb-8c09-2f03e76b25f3"), new Guid("e5cb274b-9061-42f7-aff5-97663074409e"), 300.0, "A", 4, "TRUCK" },
                    { new Guid("85f38882-d296-4dae-9392-f1e936d16a64"), new Guid("85611762-85eb-4a9a-a993-dc85d0a68cca"), 300.0, "A", 2, "TRUCK" },
                    { new Guid("860c83c8-985f-4b9a-a616-6842472484a5"), new Guid("635a063b-8794-4510-b61d-899c3b425034"), 200.0, "A", 6, "VAN" },
                    { new Guid("8636a76b-ed9a-401e-96df-8a3524b69bdb"), new Guid("6caabf59-5600-43f0-98c9-ab24acf0dadf"), 300.0, "A", 2, "TRUCK" },
                    { new Guid("8653362c-2067-446e-b7a5-25bc809d5511"), new Guid("dab1d406-ad92-4844-b279-1cd9dfb40639"), 300.0, "A", 5, "TRUCK" },
                    { new Guid("86962328-2055-44f9-a38b-024cbc78d7fa"), new Guid("fe188580-6e2f-4ff8-a49e-814745f688b7"), 300.0, "B", 3, "TRUCK" },
                    { new Guid("86b57b35-06a1-4622-9847-d1fda4297e30"), new Guid("fc11e465-6669-4617-a41f-a1d1c76a908a"), 300.0, "B", 1, "TRUCK" },
                    { new Guid("8771fa0d-253e-4767-bd79-857e595e88e7"), new Guid("a8827db7-700c-4e56-94f6-2a77e3f61a9c"), 50.0, "B", 2, "MOTORCYCLE" },
                    { new Guid("879570d8-5ffb-4398-9641-581bc2729c0c"), new Guid("59e5fd81-c04a-450d-bdd6-c36e80361881"), 50.0, "A", 7, "MOTORCYCLE" },
                    { new Guid("87e498ac-fa53-4030-8671-0ff297094bec"), new Guid("85611762-85eb-4a9a-a993-dc85d0a68cca"), 300.0, "A", 6, "TRUCK" },
                    { new Guid("88061ee1-501b-43da-b422-f3c6556bfb18"), new Guid("387a98b1-c216-4873-9812-b12a9aca5ac7"), 50.0, "B", 1, "MOTORCYCLE" },
                    { new Guid("88831383-d195-4e0a-bdd6-e02d48f6fc0f"), new Guid("7b821087-607f-4dd9-a07b-18f22d1c8fd8"), 100.0, "A", 4, "CAR" },
                    { new Guid("88b309d7-49e4-4de0-b74e-b836bbd4732c"), new Guid("7b821087-607f-4dd9-a07b-18f22d1c8fd8"), 100.0, "A", 6, "CAR" },
                    { new Guid("88db4e1a-394e-49f7-9e11-e9cff55875ad"), new Guid("b75467ff-4404-40c1-8269-b787f50a14dc"), 100.0, "A", 2, "CAR" },
                    { new Guid("88dffeb3-c113-4010-a287-fa3a6080b961"), new Guid("fc11e465-6669-4617-a41f-a1d1c76a908a"), 300.0, "B", 2, "TRUCK" },
                    { new Guid("88eddc48-aed9-4014-a2ea-60706fae4e42"), new Guid("7b821087-607f-4dd9-a07b-18f22d1c8fd8"), 100.0, "A", 3, "CAR" },
                    { new Guid("88feefab-2117-48f2-a484-308d02992d3e"), new Guid("cfba1888-af59-40c6-bf90-ff89882538a3"), 200.0, "B", 3, "VAN" },
                    { new Guid("890f8e32-8421-4d49-b425-386222793036"), new Guid("70713bfe-20a7-4b8e-bcc9-7cd0e57ae2cf"), 50.0, "B", 3, "MOTORCYCLE" },
                    { new Guid("89292213-c4e3-4935-81b0-4267dd3fae20"), new Guid("fe188580-6e2f-4ff8-a49e-814745f688b7"), 300.0, "B", 8, "TRUCK" },
                    { new Guid("894d4ef9-aaed-44bc-9287-c288dcad29cc"), new Guid("495b86e8-5b8f-4f62-8ade-e8152d743878"), 50.0, "B", 8, "MOTORCYCLE" },
                    { new Guid("898ac5dd-bedb-4bb8-a321-888fa341ab4d"), new Guid("86f938e1-046b-4c2d-80ba-6eb7d3f4b2b9"), 50.0, "B", 8, "MOTORCYCLE" },
                    { new Guid("89f244a8-c60b-490f-bc37-489ee1795e67"), new Guid("387a98b1-c216-4873-9812-b12a9aca5ac7"), 50.0, "B", 5, "MOTORCYCLE" },
                    { new Guid("8a156628-52ec-4441-a7f3-1db5af857d53"), new Guid("387a98b1-c216-4873-9812-b12a9aca5ac7"), 50.0, "B", 3, "MOTORCYCLE" },
                    { new Guid("8a2aee91-9671-47b1-827c-9a7e0138094e"), new Guid("2cde977d-867d-40de-9a10-432b2301464c"), 50.0, "B", 1, "MOTORCYCLE" },
                    { new Guid("8af7dadb-d348-4b1d-9733-2a8851df4323"), new Guid("86f938e1-046b-4c2d-80ba-6eb7d3f4b2b9"), 50.0, "B", 2, "MOTORCYCLE" },
                    { new Guid("8b1e9401-cf98-4a66-80f0-438db4baa691"), new Guid("b75467ff-4404-40c1-8269-b787f50a14dc"), 100.0, "B", 3, "CAR" },
                    { new Guid("8b2ec7f4-fa77-4df5-a847-946a0a414df8"), new Guid("3d85c54a-5fcb-49b5-a370-4c5d3216ae4f"), 200.0, "B", 5, "VAN" },
                    { new Guid("8b6f0e3b-f605-416e-a6be-a871a64ff9ff"), new Guid("c4fb855c-c3fd-4224-909c-e4cb4ebef275"), 100.0, "B", 3, "CAR" },
                    { new Guid("8b856379-54a2-48b0-8ddd-63a0b9200f56"), new Guid("eb384a62-fea4-491c-a7a3-8a4e2c92b0c6"), 300.0, "A", 3, "TRUCK" },
                    { new Guid("8ba8f90f-bce8-47a2-adb1-ea96893ebc82"), new Guid("d65b48a9-6c74-44b4-aaf3-635151fa5984"), 50.0, "B", 7, "MOTORCYCLE" },
                    { new Guid("8bdf47fc-7f32-4ea7-a1e8-b077e36e8dc1"), new Guid("322b8d0b-4524-4cd9-b4e5-1312d61fa572"), 200.0, "B", 8, "VAN" },
                    { new Guid("8c08e9f1-04d8-4dc3-8a4e-7bc995f235d9"), new Guid("e5cb274b-9061-42f7-aff5-97663074409e"), 50.0, "B", 2, "MOTORCYCLE" },
                    { new Guid("8c2850a3-396c-4675-888b-c6536fe3a915"), new Guid("c23b858e-6380-4605-81ed-fae4578261ea"), 50.0, "A", 2, "MOTORCYCLE" },
                    { new Guid("8c5462f5-664a-47fc-8ac8-744d8b23ad06"), new Guid("86f938e1-046b-4c2d-80ba-6eb7d3f4b2b9"), 200.0, "A", 8, "VAN" },
                    { new Guid("8c7ac863-10e7-4ede-a638-598c21e35b27"), new Guid("fc2a8276-f127-4246-86dc-4d2b3262ed86"), 100.0, "B", 4, "CAR" },
                    { new Guid("8d0a136a-11bd-4f08-b658-49001401a165"), new Guid("fc11e465-6669-4617-a41f-a1d1c76a908a"), 200.0, "A", 6, "VAN" },
                    { new Guid("8d5fc879-8fa4-4bb1-8b0b-bd2eabcb273a"), new Guid("5a694bc0-b3ea-4d3b-b228-1555a8738e1d"), 100.0, "B", 5, "CAR" },
                    { new Guid("8d742769-5010-46c4-9160-00cc14023c53"), new Guid("5db7d818-7b21-4b81-8cf8-99d99ffaf375"), 200.0, "B", 5, "VAN" },
                    { new Guid("8d7fbb1e-6bd2-40fe-84b9-30a1a0379a32"), new Guid("3d85c54a-5fcb-49b5-a370-4c5d3216ae4f"), 200.0, "B", 4, "VAN" },
                    { new Guid("8dbbe074-ceeb-474e-9752-8bebd530cec2"), new Guid("31faa74a-240a-4f20-a8e9-fc79657b09d4"), 200.0, "B", 8, "VAN" },
                    { new Guid("8dbd822d-372f-45e9-9b89-bc97350803b7"), new Guid("e21cdfc0-d3d8-47cc-8b74-bdf62436fcdb"), 300.0, "B", 4, "TRUCK" },
                    { new Guid("8dce4586-acf8-4690-8282-2c29f0822312"), new Guid("a8827db7-700c-4e56-94f6-2a77e3f61a9c"), 50.0, "B", 1, "MOTORCYCLE" },
                    { new Guid("8e85d88b-b981-4757-a69a-210496a230d3"), new Guid("6caabf59-5600-43f0-98c9-ab24acf0dadf"), 300.0, "A", 8, "TRUCK" },
                    { new Guid("8ed6609d-8f59-4d4e-89d7-671cd391afcf"), new Guid("635a063b-8794-4510-b61d-899c3b425034"), 200.0, "A", 3, "VAN" },
                    { new Guid("8f054124-273e-4a2a-9c75-08abcf57be91"), new Guid("610d361a-c14c-4e3a-9ddb-700cd803bb7d"), 200.0, "A", 4, "VAN" },
                    { new Guid("8f294424-44fa-4721-8748-d868f1b18a09"), new Guid("eb384a62-fea4-491c-a7a3-8a4e2c92b0c6"), 200.0, "B", 4, "VAN" },
                    { new Guid("8f9e2620-682e-4a60-b0d7-c037ada70651"), new Guid("1a0fc976-15ce-4e8e-9ce1-e01456178b41"), 300.0, "B", 6, "TRUCK" },
                    { new Guid("8fc34687-136e-4154-82d5-0db4c4c0a8a2"), new Guid("fc2a8276-f127-4246-86dc-4d2b3262ed86"), 100.0, "B", 8, "CAR" },
                    { new Guid("8fdec7bc-7320-4597-831d-65521cf37b8a"), new Guid("8e054a25-6fd3-4e9d-b12b-aaa8e6ac85eb"), 100.0, "B", 6, "CAR" },
                    { new Guid("8ff29034-1960-4ab5-8d38-28e657e3c944"), new Guid("e5cb274b-9061-42f7-aff5-97663074409e"), 50.0, "B", 3, "MOTORCYCLE" },
                    { new Guid("90b4e078-9680-4075-81a8-2c4620dad7ec"), new Guid("bf21db4e-8dd6-4bc3-9d0d-1e673e3c0541"), 300.0, "A", 5, "TRUCK" },
                    { new Guid("9144c0ab-95aa-4ace-81f4-1fb47f7a6b6f"), new Guid("59eb481c-e88b-4a04-93c8-aa9fad3b8fbd"), 200.0, "B", 6, "VAN" },
                    { new Guid("918ff981-0258-4dbc-b42b-ebbeeec6e46f"), new Guid("6caabf59-5600-43f0-98c9-ab24acf0dadf"), 300.0, "A", 3, "TRUCK" },
                    { new Guid("91b97d71-054e-4b3f-8e01-26f7e2f02376"), new Guid("ae16885c-9a8e-49a8-b817-0be9a9960d0f"), 300.0, "A", 4, "TRUCK" },
                    { new Guid("91f4ab07-694c-45dd-85cf-6559abdbc209"), new Guid("cfba1888-af59-40c6-bf90-ff89882538a3"), 200.0, "B", 2, "VAN" },
                    { new Guid("924179bf-36d3-477f-a8ca-73712a015197"), new Guid("fc2a8276-f127-4246-86dc-4d2b3262ed86"), 50.0, "A", 3, "MOTORCYCLE" },
                    { new Guid("924bc147-40ba-4ca4-bc5d-bc67fa6547f1"), new Guid("38633289-34c0-438f-b007-976f825ec000"), 50.0, "A", 5, "MOTORCYCLE" },
                    { new Guid("9315e97d-4147-4b2b-bac8-71fe78b72eab"), new Guid("257b5f9f-b092-41af-beb1-2a2808fe0fc8"), 100.0, "B", 5, "CAR" },
                    { new Guid("9364750d-0b35-4f12-a518-f5afa8c42bd7"), new Guid("610d361a-c14c-4e3a-9ddb-700cd803bb7d"), 100.0, "B", 6, "CAR" },
                    { new Guid("93653ac2-6cf5-44a6-aab6-95b5a71d7854"), new Guid("c5174f79-1a96-4d56-ae5b-b089b385e4f5"), 300.0, "A", 5, "TRUCK" },
                    { new Guid("93654454-1728-48ac-96d0-ae477553c5f3"), new Guid("495b86e8-5b8f-4f62-8ade-e8152d743878"), 50.0, "A", 1, "MOTORCYCLE" },
                    { new Guid("93876abd-2387-4e42-82fa-cf6784321d90"), new Guid("9c6c5b2a-00b3-448c-81cc-a9010d2d4196"), 300.0, "A", 2, "TRUCK" },
                    { new Guid("93c2bf4b-1276-421e-9714-ab7d7ccb0056"), new Guid("2848fcc2-f6b3-4b91-a829-47543cd6f877"), 300.0, "A", 1, "TRUCK" },
                    { new Guid("93d40004-8626-44eb-996a-19f3cb56ec12"), new Guid("2cde977d-867d-40de-9a10-432b2301464c"), 300.0, "A", 4, "TRUCK" },
                    { new Guid("93f116aa-f786-4bc6-be79-56c18347e88f"), new Guid("e2826ba2-5ca3-4ce6-ac50-811f085e3cf6"), 100.0, "A", 5, "CAR" },
                    { new Guid("93f1523d-1318-4604-ab78-f4e0199d313e"), new Guid("7b821087-607f-4dd9-a07b-18f22d1c8fd8"), 100.0, "B", 7, "CAR" },
                    { new Guid("9413a8ea-7dc0-41e1-8c02-4e3893cc2830"), new Guid("fd6deed8-c835-4168-8d92-abafacbe20b6"), 200.0, "B", 1, "VAN" },
                    { new Guid("953544ce-125c-4cab-af7e-5d1676cbf679"), new Guid("891fbb4c-6ace-4cd9-ba70-deb2d06886bc"), 100.0, "A", 2, "CAR" },
                    { new Guid("95cac3cd-63dd-4e99-9e47-a1703442ec93"), new Guid("f35520f7-2e5e-4340-ba78-c10259f8c8c5"), 50.0, "A", 2, "MOTORCYCLE" },
                    { new Guid("95d7417a-1db8-43e6-bc9d-e80d3405db5b"), new Guid("86f938e1-046b-4c2d-80ba-6eb7d3f4b2b9"), 50.0, "B", 7, "MOTORCYCLE" },
                    { new Guid("95e77a81-d710-493e-837e-9159c34c1e29"), new Guid("d65b48a9-6c74-44b4-aaf3-635151fa5984"), 50.0, "A", 6, "MOTORCYCLE" },
                    { new Guid("95f14ea3-2815-4ba8-9824-3293921df6cc"), new Guid("6f8b493b-9523-43ba-9a39-6080882550be"), 300.0, "B", 1, "TRUCK" },
                    { new Guid("961fcf8c-d6d8-4293-82bd-5345ef0ace51"), new Guid("e5cb274b-9061-42f7-aff5-97663074409e"), 300.0, "A", 5, "TRUCK" },
                    { new Guid("962c55c7-ceb4-4f83-bc72-3ceea47e121f"), new Guid("8e054a25-6fd3-4e9d-b12b-aaa8e6ac85eb"), 200.0, "A", 6, "VAN" },
                    { new Guid("96c617cb-ed47-4a13-b932-02c9d2a1a75a"), new Guid("495b86e8-5b8f-4f62-8ade-e8152d743878"), 50.0, "A", 4, "MOTORCYCLE" },
                    { new Guid("971eb844-2ad5-43dd-b1de-b600cfb5f7e1"), new Guid("2cde977d-867d-40de-9a10-432b2301464c"), 300.0, "A", 7, "TRUCK" },
                    { new Guid("97615ef3-6b3b-4426-9e33-90250ef87721"), new Guid("c23b858e-6380-4605-81ed-fae4578261ea"), 50.0, "B", 5, "MOTORCYCLE" },
                    { new Guid("977865c9-21cd-48c6-80a2-4e76878a546b"), new Guid("b75467ff-4404-40c1-8269-b787f50a14dc"), 100.0, "B", 8, "CAR" },
                    { new Guid("9781b577-086e-4148-a134-a71b5f64c5c7"), new Guid("ae16885c-9a8e-49a8-b817-0be9a9960d0f"), 200.0, "B", 2, "VAN" },
                    { new Guid("97aa0076-f9a0-424d-9875-1075baba3b43"), new Guid("bf21db4e-8dd6-4bc3-9d0d-1e673e3c0541"), 100.0, "B", 1, "CAR" },
                    { new Guid("97cd8b1a-1293-4556-a21a-81f7a859a666"), new Guid("d6240ccd-9331-4c53-91af-3b1992316096"), 100.0, "A", 1, "CAR" },
                    { new Guid("97f59e8e-3cd9-4253-8133-07dccf73105d"), new Guid("f3297de4-ea7b-42da-993e-9ae374023e94"), 300.0, "B", 6, "TRUCK" },
                    { new Guid("981faaf8-03aa-4514-93d0-b29d15291a82"), new Guid("d65b48a9-6c74-44b4-aaf3-635151fa5984"), 50.0, "A", 1, "MOTORCYCLE" },
                    { new Guid("982dce94-698f-4f1d-9dc4-b7cfbc118f1b"), new Guid("e3c60e04-8b6c-497d-b040-30019f1951fe"), 300.0, "A", 1, "TRUCK" },
                    { new Guid("982de2d7-70d1-433b-8a48-a2079622f4d8"), new Guid("70713bfe-20a7-4b8e-bcc9-7cd0e57ae2cf"), 50.0, "B", 4, "MOTORCYCLE" },
                    { new Guid("988beb1d-fe17-441e-9658-206f8209195f"), new Guid("2cde977d-867d-40de-9a10-432b2301464c"), 50.0, "B", 2, "MOTORCYCLE" },
                    { new Guid("98e69c72-e729-46eb-ad77-2b1a5e776379"), new Guid("6f8b493b-9523-43ba-9a39-6080882550be"), 100.0, "A", 6, "CAR" },
                    { new Guid("990a1ec1-3bec-47fc-8a4d-ba3420f8df59"), new Guid("ae16885c-9a8e-49a8-b817-0be9a9960d0f"), 300.0, "A", 7, "TRUCK" },
                    { new Guid("99785aea-4aa7-40bb-ae83-94a6056dfdd7"), new Guid("d65b48a9-6c74-44b4-aaf3-635151fa5984"), 50.0, "B", 3, "MOTORCYCLE" },
                    { new Guid("999e7726-1351-4696-8ea9-7c3e72f57eee"), new Guid("38633289-34c0-438f-b007-976f825ec000"), 50.0, "A", 4, "MOTORCYCLE" },
                    { new Guid("99a19ace-b24c-4be9-9ba1-f5c88ba54729"), new Guid("5db7d818-7b21-4b81-8cf8-99d99ffaf375"), 50.0, "A", 4, "MOTORCYCLE" },
                    { new Guid("99b3535d-1715-45eb-a5b9-2b8f17081fa5"), new Guid("6caabf59-5600-43f0-98c9-ab24acf0dadf"), 100.0, "B", 6, "CAR" },
                    { new Guid("99b9945e-e662-4833-a85d-2ef1aec3d449"), new Guid("52688c85-e7f4-47e9-b9f2-d508de79f823"), 200.0, "A", 6, "VAN" },
                    { new Guid("99e05c4b-f0b8-4cb0-972f-62b7a07b37e1"), new Guid("59eb481c-e88b-4a04-93c8-aa9fad3b8fbd"), 200.0, "B", 5, "VAN" },
                    { new Guid("9a074c89-156f-4ff5-954e-dbdf3e381f34"), new Guid("387a98b1-c216-4873-9812-b12a9aca5ac7"), 50.0, "B", 8, "MOTORCYCLE" },
                    { new Guid("9a331a21-55a9-4a15-bdc0-9547b5d5774c"), new Guid("e21cdfc0-d3d8-47cc-8b74-bdf62436fcdb"), 200.0, "A", 3, "VAN" },
                    { new Guid("9a61cc62-8aaa-417f-99df-1ea761bdbaf8"), new Guid("f3297de4-ea7b-42da-993e-9ae374023e94"), 50.0, "A", 8, "MOTORCYCLE" },
                    { new Guid("9a98d4cb-e6b2-43be-a8b8-77a544ea6304"), new Guid("19bcc6b0-45ed-4845-b411-400d4f6683b2"), 100.0, "B", 7, "CAR" },
                    { new Guid("9a9c8806-8634-43c0-bc18-6651710bfc59"), new Guid("6f8b493b-9523-43ba-9a39-6080882550be"), 100.0, "A", 2, "CAR" },
                    { new Guid("9aa05667-1466-4173-b6a8-59a60e3d3fdc"), new Guid("c5174f79-1a96-4d56-ae5b-b089b385e4f5"), 300.0, "B", 3, "TRUCK" },
                    { new Guid("9b93d102-bddd-4aa6-9170-95aef1f02aa0"), new Guid("86f938e1-046b-4c2d-80ba-6eb7d3f4b2b9"), 50.0, "B", 4, "MOTORCYCLE" },
                    { new Guid("9bc56e27-cf34-47a1-9fc4-805b11ad4b83"), new Guid("387a98b1-c216-4873-9812-b12a9aca5ac7"), 300.0, "A", 5, "TRUCK" },
                    { new Guid("9c253313-e74a-4a24-8b2c-60b8bc3bd42d"), new Guid("52688c85-e7f4-47e9-b9f2-d508de79f823"), 200.0, "A", 4, "VAN" },
                    { new Guid("9c4224e1-4efb-4eaf-817f-6f438fdefc6d"), new Guid("930245a8-ee38-4501-a6ec-b31839348aaa"), 100.0, "A", 1, "CAR" },
                    { new Guid("9cd1f3f7-a316-460a-abbb-992191640ef9"), new Guid("635a063b-8794-4510-b61d-899c3b425034"), 200.0, "B", 7, "VAN" },
                    { new Guid("9cd5c948-0528-4ac6-af69-8099105c83b5"), new Guid("930245a8-ee38-4501-a6ec-b31839348aaa"), 100.0, "A", 6, "CAR" },
                    { new Guid("9cd6fd73-5341-4326-bac1-62598101e1fa"), new Guid("fd6deed8-c835-4168-8d92-abafacbe20b6"), 200.0, "B", 5, "VAN" },
                    { new Guid("9cf90b38-eb3a-408e-9064-5dd87f7a34e4"), new Guid("31faa74a-240a-4f20-a8e9-fc79657b09d4"), 200.0, "B", 2, "VAN" },
                    { new Guid("9d29a662-09e7-471a-ba05-7cf53ef4faaf"), new Guid("8886b676-b97c-4d0b-ae45-d18b2f2df900"), 100.0, "A", 4, "CAR" },
                    { new Guid("9d337e91-f0c9-447f-89fc-ec87ddb7da0a"), new Guid("387a98b1-c216-4873-9812-b12a9aca5ac7"), 50.0, "B", 7, "MOTORCYCLE" },
                    { new Guid("9db27a10-84b6-4dcb-ab7c-08d37d4a1871"), new Guid("fe188580-6e2f-4ff8-a49e-814745f688b7"), 300.0, "B", 2, "TRUCK" },
                    { new Guid("9e56a8b1-6fe9-4291-96e6-0a7a8b3a392c"), new Guid("ae16885c-9a8e-49a8-b817-0be9a9960d0f"), 200.0, "B", 4, "VAN" },
                    { new Guid("9f081a64-4419-4da2-ae6f-285eef92fe19"), new Guid("c23b858e-6380-4605-81ed-fae4578261ea"), 50.0, "A", 7, "MOTORCYCLE" },
                    { new Guid("9f1306a0-abb1-49a4-a110-8d37f4baa9d7"), new Guid("19bcc6b0-45ed-4845-b411-400d4f6683b2"), 100.0, "B", 1, "CAR" },
                    { new Guid("9f1393d4-1284-4f35-8669-d5477c6dddde"), new Guid("5db7d818-7b21-4b81-8cf8-99d99ffaf375"), 50.0, "A", 7, "MOTORCYCLE" },
                    { new Guid("9f5f0e41-b123-4a71-8daa-6224be7227a5"), new Guid("dab1d406-ad92-4844-b279-1cd9dfb40639"), 200.0, "B", 3, "VAN" },
                    { new Guid("9fb2e399-2d2b-474b-b2d0-034d72dea455"), new Guid("635a063b-8794-4510-b61d-899c3b425034"), 200.0, "B", 3, "VAN" },
                    { new Guid("9fb74888-ecc8-4144-9048-5005929728e5"), new Guid("a8827db7-700c-4e56-94f6-2a77e3f61a9c"), 300.0, "A", 1, "TRUCK" },
                    { new Guid("9fbce7a7-b677-44df-893e-6fc9cce35364"), new Guid("86f938e1-046b-4c2d-80ba-6eb7d3f4b2b9"), 200.0, "A", 4, "VAN" },
                    { new Guid("9fdc0498-1fd2-43d1-bfb3-320ea8df16de"), new Guid("59eb481c-e88b-4a04-93c8-aa9fad3b8fbd"), 300.0, "A", 3, "TRUCK" },
                    { new Guid("9ff57056-0262-4e97-a1ff-dec2dd038a20"), new Guid("70713bfe-20a7-4b8e-bcc9-7cd0e57ae2cf"), 200.0, "A", 4, "VAN" },
                    { new Guid("a00be3eb-c151-4e21-b291-a327fcf56c98"), new Guid("f3297de4-ea7b-42da-993e-9ae374023e94"), 300.0, "B", 8, "TRUCK" },
                    { new Guid("a06502d8-eea7-4f60-9f19-85666c6e3910"), new Guid("c4fb855c-c3fd-4224-909c-e4cb4ebef275"), 300.0, "A", 6, "TRUCK" },
                    { new Guid("a0db3d61-bcf1-40b8-ade3-3a4e0b87e087"), new Guid("2848fcc2-f6b3-4b91-a829-47543cd6f877"), 200.0, "B", 2, "VAN" },
                    { new Guid("a0df98f2-3f5f-4327-a5fb-4e9f00c99419"), new Guid("322b8d0b-4524-4cd9-b4e5-1312d61fa572"), 200.0, "A", 2, "VAN" },
                    { new Guid("a2ee56a9-9b89-4b94-92c2-1b04d8aa3b5a"), new Guid("59e5fd81-c04a-450d-bdd6-c36e80361881"), 300.0, "B", 8, "TRUCK" },
                    { new Guid("a30a509a-05f8-470a-891d-4e7be8f5b658"), new Guid("e2826ba2-5ca3-4ce6-ac50-811f085e3cf6"), 100.0, "B", 7, "CAR" },
                    { new Guid("a3bdd8c7-827c-4079-83c3-bae97457413d"), new Guid("c4fb855c-c3fd-4224-909c-e4cb4ebef275"), 300.0, "A", 4, "TRUCK" },
                    { new Guid("a3c51b58-a2c9-4831-91fd-95e281bacc83"), new Guid("5db7d818-7b21-4b81-8cf8-99d99ffaf375"), 50.0, "A", 8, "MOTORCYCLE" },
                    { new Guid("a40f3b2d-9051-4728-898b-1be6832b2c60"), new Guid("322b8d0b-4524-4cd9-b4e5-1312d61fa572"), 200.0, "A", 4, "VAN" },
                    { new Guid("a4af20dd-a7ca-479b-81f8-b3b49b8c9cf5"), new Guid("fc11e465-6669-4617-a41f-a1d1c76a908a"), 300.0, "B", 3, "TRUCK" },
                    { new Guid("a52de9e7-f453-4781-a3f5-0c265e07f9bd"), new Guid("fd6deed8-c835-4168-8d92-abafacbe20b6"), 200.0, "B", 8, "VAN" },
                    { new Guid("a566254c-7d1e-4ca0-a7fd-f3d76ee54122"), new Guid("d09a2181-65c3-4ee5-b8b3-d4ea251a8fbf"), 100.0, "B", 6, "CAR" },
                    { new Guid("a58a924e-c200-42ea-8641-6f3732f3a13f"), new Guid("d6240ccd-9331-4c53-91af-3b1992316096"), 100.0, "B", 7, "CAR" },
                    { new Guid("a599905e-3b58-4a2d-8da8-f6ef83a7425b"), new Guid("59e5fd81-c04a-450d-bdd6-c36e80361881"), 300.0, "B", 4, "TRUCK" },
                    { new Guid("a5de9a15-fbfa-46f3-870e-cf721389e887"), new Guid("e5cb274b-9061-42f7-aff5-97663074409e"), 300.0, "A", 2, "TRUCK" },
                    { new Guid("a5f0bcd5-9865-46f9-ad4c-a07af6bb60d6"), new Guid("c5174f79-1a96-4d56-ae5b-b089b385e4f5"), 300.0, "A", 7, "TRUCK" },
                    { new Guid("a6e7c7a4-49df-4432-9702-f597456fd9ef"), new Guid("8e054a25-6fd3-4e9d-b12b-aaa8e6ac85eb"), 100.0, "B", 2, "CAR" },
                    { new Guid("a756f25a-8caf-4c6a-baae-1882fe91b55c"), new Guid("e5cb274b-9061-42f7-aff5-97663074409e"), 300.0, "A", 3, "TRUCK" },
                    { new Guid("a776c653-1a3c-4a61-9d2a-b93260555aae"), new Guid("635a063b-8794-4510-b61d-899c3b425034"), 200.0, "B", 1, "VAN" },
                    { new Guid("a7bb84bd-d6fa-4d1b-8f8e-ac9792589405"), new Guid("d6240ccd-9331-4c53-91af-3b1992316096"), 100.0, "A", 3, "CAR" },
                    { new Guid("a7eabf58-c8ff-45e5-a144-999be75f2c0f"), new Guid("c5174f79-1a96-4d56-ae5b-b089b385e4f5"), 300.0, "B", 8, "TRUCK" },
                    { new Guid("a809c0b8-562f-46a4-91b0-b7d95dd24394"), new Guid("e2826ba2-5ca3-4ce6-ac50-811f085e3cf6"), 100.0, "A", 2, "CAR" },
                    { new Guid("a887ea1c-9b78-4e7b-8a89-f30fbab84430"), new Guid("e3c60e04-8b6c-497d-b040-30019f1951fe"), 200.0, "B", 6, "VAN" },
                    { new Guid("a88da33d-3f82-422b-802a-eac2c2ffb7d8"), new Guid("e3c60e04-8b6c-497d-b040-30019f1951fe"), 200.0, "B", 5, "VAN" },
                    { new Guid("a89051d4-da8f-4ae5-970c-fd0dbae96a49"), new Guid("c5174f79-1a96-4d56-ae5b-b089b385e4f5"), 300.0, "B", 7, "TRUCK" },
                    { new Guid("a8d815b3-89f5-47e8-9f28-a143c347eae7"), new Guid("3d85c54a-5fcb-49b5-a370-4c5d3216ae4f"), 200.0, "A", 7, "VAN" },
                    { new Guid("a8ef2636-c8f7-44e4-b88f-5f3eacb99528"), new Guid("38633289-34c0-438f-b007-976f825ec000"), 300.0, "B", 3, "TRUCK" },
                    { new Guid("a9d61991-329a-4b25-8f5e-a51555cbffa9"), new Guid("eb384a62-fea4-491c-a7a3-8a4e2c92b0c6"), 300.0, "A", 1, "TRUCK" },
                    { new Guid("aa3986b0-893b-4c1c-ac9e-d481cb123581"), new Guid("6caabf59-5600-43f0-98c9-ab24acf0dadf"), 300.0, "A", 1, "TRUCK" },
                    { new Guid("aa50f344-33c0-4e92-8e7b-033eaa48d31e"), new Guid("0ada6bc9-6665-49b2-a427-5ad008b51fda"), 100.0, "B", 6, "CAR" },
                    { new Guid("ab2a034c-9122-4e7f-8380-f16a3de57160"), new Guid("cf8ba59d-1e62-43aa-b128-f92651d868c4"), 300.0, "A", 3, "TRUCK" },
                    { new Guid("ab2e5a6d-7755-484f-85cb-f75b8410d854"), new Guid("188984fb-f6f2-43a8-8f42-5761cf166a56"), 200.0, "B", 4, "VAN" },
                    { new Guid("abcbcab2-6958-48a3-b155-763343272521"), new Guid("bcf6224b-83e4-44b6-84b7-9a5b11f6f78d"), 100.0, "A", 8, "CAR" },
                    { new Guid("ac028b62-be26-4677-a823-1d59a1b5272f"), new Guid("aae01dc0-240f-4c2b-85b8-db1d578305ed"), 100.0, "B", 5, "CAR" },
                    { new Guid("acc787e5-e801-405b-8a85-fe133c1664d6"), new Guid("2cde977d-867d-40de-9a10-432b2301464c"), 50.0, "B", 7, "MOTORCYCLE" },
                    { new Guid("ad13fe29-1c2c-4d43-b188-bc4daedaf787"), new Guid("b26c6185-7128-4959-b92d-665002dce200"), 300.0, "A", 5, "TRUCK" },
                    { new Guid("ad17e5b7-b827-4941-aa35-b4fabd83ad73"), new Guid("188984fb-f6f2-43a8-8f42-5761cf166a56"), 200.0, "B", 8, "VAN" },
                    { new Guid("ad8e9857-8ec9-46c0-bbe3-d7fda1fb5b60"), new Guid("930245a8-ee38-4501-a6ec-b31839348aaa"), 100.0, "B", 4, "CAR" },
                    { new Guid("adcb6495-f200-434d-a98e-c16934c14958"), new Guid("e5cb274b-9061-42f7-aff5-97663074409e"), 50.0, "B", 4, "MOTORCYCLE" },
                    { new Guid("addf3b39-9959-4a9c-af47-72b9a8434623"), new Guid("b75467ff-4404-40c1-8269-b787f50a14dc"), 100.0, "A", 3, "CAR" },
                    { new Guid("ae16b851-5350-464d-8664-ddaf004a219a"), new Guid("1a0fc976-15ce-4e8e-9ce1-e01456178b41"), 300.0, "B", 1, "TRUCK" },
                    { new Guid("ae241fc4-8945-4271-b530-6855bfbd11b7"), new Guid("c4fb855c-c3fd-4224-909c-e4cb4ebef275"), 100.0, "B", 7, "CAR" },
                    { new Guid("ae5842aa-22fd-4a23-bb31-747d5458c611"), new Guid("f35520f7-2e5e-4340-ba78-c10259f8c8c5"), 50.0, "A", 1, "MOTORCYCLE" },
                    { new Guid("b0f26694-fdb6-4022-8f06-79b6a9dc40df"), new Guid("5db7d818-7b21-4b81-8cf8-99d99ffaf375"), 200.0, "B", 1, "VAN" },
                    { new Guid("b1516396-a360-4798-a99c-446ceb0332d8"), new Guid("e21cdfc0-d3d8-47cc-8b74-bdf62436fcdb"), 200.0, "A", 8, "VAN" },
                    { new Guid("b15dfaac-e4fe-49fd-91bf-a085700b1b2a"), new Guid("fc2a8276-f127-4246-86dc-4d2b3262ed86"), 50.0, "A", 1, "MOTORCYCLE" },
                    { new Guid("b186cf9e-d40f-4f09-bae2-db439df6567b"), new Guid("b75467ff-4404-40c1-8269-b787f50a14dc"), 100.0, "B", 6, "CAR" },
                    { new Guid("b1ac42fe-3003-4751-b5a7-bb3d8036849d"), new Guid("d65b48a9-6c74-44b4-aaf3-635151fa5984"), 50.0, "B", 2, "MOTORCYCLE" },
                    { new Guid("b2553ae6-e1fb-4f1e-acd8-d894625c6c50"), new Guid("c23b858e-6380-4605-81ed-fae4578261ea"), 50.0, "B", 6, "MOTORCYCLE" },
                    { new Guid("b2657a99-1125-43bf-845b-2f98d2671d0e"), new Guid("891fbb4c-6ace-4cd9-ba70-deb2d06886bc"), 300.0, "B", 8, "TRUCK" },
                    { new Guid("b29c7b5a-7242-43b6-bebb-30f54349a7f9"), new Guid("891fbb4c-6ace-4cd9-ba70-deb2d06886bc"), 100.0, "A", 3, "CAR" },
                    { new Guid("b29ff4b1-fe79-4833-a2a3-9815dcf4e7db"), new Guid("635a063b-8794-4510-b61d-899c3b425034"), 200.0, "B", 5, "VAN" },
                    { new Guid("b2e87d6c-558d-47b3-b68a-a925a7efc718"), new Guid("52688c85-e7f4-47e9-b9f2-d508de79f823"), 100.0, "B", 4, "CAR" },
                    { new Guid("b2ec7e16-c5ef-427e-b86a-6665d1c9f89a"), new Guid("59eb481c-e88b-4a04-93c8-aa9fad3b8fbd"), 200.0, "B", 1, "VAN" },
                    { new Guid("b3165af6-9097-4bbe-9d2d-50131f40ad3a"), new Guid("635a063b-8794-4510-b61d-899c3b425034"), 200.0, "B", 4, "VAN" },
                    { new Guid("b354e891-b0f8-4a5c-8003-4277ddaa1a6a"), new Guid("86f938e1-046b-4c2d-80ba-6eb7d3f4b2b9"), 200.0, "A", 6, "VAN" },
                    { new Guid("b36b9f56-c677-4e4a-906a-f8d9d538f5a7"), new Guid("cfba1888-af59-40c6-bf90-ff89882538a3"), 200.0, "B", 6, "VAN" },
                    { new Guid("b3887c33-fc0f-43d0-8476-389da9a0aeea"), new Guid("a8827db7-700c-4e56-94f6-2a77e3f61a9c"), 300.0, "A", 3, "TRUCK" },
                    { new Guid("b3a9460a-d4e7-40c6-8123-b77cc3610157"), new Guid("c4fb855c-c3fd-4224-909c-e4cb4ebef275"), 300.0, "A", 1, "TRUCK" },
                    { new Guid("b3f938e7-9189-4759-a633-d07296bec8de"), new Guid("b75467ff-4404-40c1-8269-b787f50a14dc"), 100.0, "B", 7, "CAR" },
                    { new Guid("b43e1d62-9d83-480c-961b-b06926933910"), new Guid("e21cdfc0-d3d8-47cc-8b74-bdf62436fcdb"), 200.0, "A", 5, "VAN" },
                    { new Guid("b4886fc7-74da-4dde-aebb-ce9cb369afd7"), new Guid("9c6c5b2a-00b3-448c-81cc-a9010d2d4196"), 300.0, "A", 5, "TRUCK" },
                    { new Guid("b52b795d-3019-4527-9781-99ae0667f3ea"), new Guid("930245a8-ee38-4501-a6ec-b31839348aaa"), 100.0, "A", 5, "CAR" },
                    { new Guid("b548f369-dffb-48ff-b0f7-547a2337cf35"), new Guid("3d85c54a-5fcb-49b5-a370-4c5d3216ae4f"), 200.0, "A", 1, "VAN" },
                    { new Guid("b5612ad2-f4e4-4cca-a9ae-648c529f5c24"), new Guid("aae01dc0-240f-4c2b-85b8-db1d578305ed"), 100.0, "B", 2, "CAR" },
                    { new Guid("b5bca4d5-b34c-4c38-964f-44dea0d9e46b"), new Guid("7b821087-607f-4dd9-a07b-18f22d1c8fd8"), 100.0, "B", 6, "CAR" },
                    { new Guid("b5ccb6aa-3f62-4e24-a9a7-3701a8aa88d0"), new Guid("6f8b493b-9523-43ba-9a39-6080882550be"), 300.0, "B", 2, "TRUCK" },
                    { new Guid("b6bf0ac7-bc31-4943-b3cc-8244f5b41477"), new Guid("7140654e-28d2-494f-a602-8bb6bff2fc13"), 200.0, "A", 3, "VAN" },
                    { new Guid("b706b2ed-337a-4553-857a-335410e97b08"), new Guid("2848fcc2-f6b3-4b91-a829-47543cd6f877"), 200.0, "B", 4, "VAN" },
                    { new Guid("b7830563-d205-49ad-bdaf-7180f3404a68"), new Guid("c5174f79-1a96-4d56-ae5b-b089b385e4f5"), 300.0, "B", 5, "TRUCK" },
                    { new Guid("b7cd2567-879a-46bf-8aa9-2c69e014009b"), new Guid("188984fb-f6f2-43a8-8f42-5761cf166a56"), 300.0, "A", 1, "TRUCK" },
                    { new Guid("b7d15400-1b12-4e9e-943e-16a866acef0d"), new Guid("610d361a-c14c-4e3a-9ddb-700cd803bb7d"), 200.0, "A", 7, "VAN" },
                    { new Guid("b83049d7-f6b8-4dd2-b08a-d8a046c5208e"), new Guid("3f771136-710d-4c9b-94ca-00b8c3abdd93"), 50.0, "B", 8, "MOTORCYCLE" },
                    { new Guid("b84eb5cf-f890-497e-a0b2-a00259da5013"), new Guid("c5174f79-1a96-4d56-ae5b-b089b385e4f5"), 300.0, "A", 1, "TRUCK" },
                    { new Guid("b887252c-b30b-4d39-a9bc-00cec0f74e2a"), new Guid("cf8ba59d-1e62-43aa-b128-f92651d868c4"), 100.0, "B", 8, "CAR" },
                    { new Guid("b8a733c1-7bea-4789-bf05-ebc6556342b8"), new Guid("e2826ba2-5ca3-4ce6-ac50-811f085e3cf6"), 100.0, "B", 2, "CAR" },
                    { new Guid("b8a76934-05ca-4dea-af55-87740674f27d"), new Guid("70713bfe-20a7-4b8e-bcc9-7cd0e57ae2cf"), 200.0, "A", 7, "VAN" },
                    { new Guid("b8d8e41e-3dfb-4483-ad0a-5073995b289f"), new Guid("1a0fc976-15ce-4e8e-9ce1-e01456178b41"), 100.0, "A", 8, "CAR" },
                    { new Guid("b8f2ec9a-1574-4ab4-bf01-8cb56c4bb783"), new Guid("2848fcc2-f6b3-4b91-a829-47543cd6f877"), 200.0, "B", 6, "VAN" },
                    { new Guid("b9e64d61-dd3c-4176-8beb-b98409eea65b"), new Guid("fd6deed8-c835-4168-8d92-abafacbe20b6"), 50.0, "A", 1, "MOTORCYCLE" },
                    { new Guid("ba52a2f5-095c-40c9-890b-c4b6962e6636"), new Guid("85611762-85eb-4a9a-a993-dc85d0a68cca"), 300.0, "A", 3, "TRUCK" },
                    { new Guid("ba75981d-682a-4ab6-a520-5622485dbbee"), new Guid("891fbb4c-6ace-4cd9-ba70-deb2d06886bc"), 300.0, "B", 7, "TRUCK" },
                    { new Guid("ba841147-de86-4b87-9f7b-b665bfc6dfc0"), new Guid("f35520f7-2e5e-4340-ba78-c10259f8c8c5"), 50.0, "A", 7, "MOTORCYCLE" },
                    { new Guid("bab2ef10-cbad-43fe-8b65-bcaeb73d1439"), new Guid("2cde977d-867d-40de-9a10-432b2301464c"), 50.0, "B", 6, "MOTORCYCLE" },
                    { new Guid("bb2a4976-2816-4ca4-bed2-71c39ce3670b"), new Guid("cf8ba59d-1e62-43aa-b128-f92651d868c4"), 300.0, "A", 5, "TRUCK" },
                    { new Guid("bbba32c5-cfe0-4450-9a7a-3ee682bd4336"), new Guid("d6240ccd-9331-4c53-91af-3b1992316096"), 100.0, "A", 4, "CAR" },
                    { new Guid("bbf0fbe7-c067-484e-acca-0bad6590eaa8"), new Guid("ae16885c-9a8e-49a8-b817-0be9a9960d0f"), 200.0, "B", 1, "VAN" },
                    { new Guid("bbfdbe33-eb5c-4a2d-975e-34c802181548"), new Guid("aae01dc0-240f-4c2b-85b8-db1d578305ed"), 100.0, "A", 6, "CAR" },
                    { new Guid("bc1eab00-8a1d-4df9-aa1c-c8cd04d3863e"), new Guid("8886b676-b97c-4d0b-ae45-d18b2f2df900"), 200.0, "B", 2, "VAN" },
                    { new Guid("bc2274a6-3d73-4622-9a4e-5235d62744c4"), new Guid("495b86e8-5b8f-4f62-8ade-e8152d743878"), 50.0, "B", 3, "MOTORCYCLE" },
                    { new Guid("bc5adcca-c2d8-45e7-b6ca-e7fd9c94f700"), new Guid("bcf6224b-83e4-44b6-84b7-9a5b11f6f78d"), 100.0, "A", 7, "CAR" },
                    { new Guid("bc9a1a23-c9f1-4f14-8095-0da70b5f2558"), new Guid("fc2a8276-f127-4246-86dc-4d2b3262ed86"), 50.0, "A", 5, "MOTORCYCLE" },
                    { new Guid("bccc6ef6-82a4-4f1b-86ec-f60624090d2d"), new Guid("5a694bc0-b3ea-4d3b-b228-1555a8738e1d"), 100.0, "B", 3, "CAR" },
                    { new Guid("bcd93965-c920-4ca4-b2b6-ad022fd4cd25"), new Guid("0ada6bc9-6665-49b2-a427-5ad008b51fda"), 100.0, "B", 7, "CAR" },
                    { new Guid("bcf7e21e-80e6-4f65-acf2-f9eaafa4678d"), new Guid("dab1d406-ad92-4844-b279-1cd9dfb40639"), 300.0, "A", 3, "TRUCK" },
                    { new Guid("bd25974e-d632-4417-9642-d1802cea6f77"), new Guid("7b821087-607f-4dd9-a07b-18f22d1c8fd8"), 100.0, "A", 5, "CAR" },
                    { new Guid("bdd7ed2c-f278-4be7-9b72-c3fb648f6fd1"), new Guid("ae16885c-9a8e-49a8-b817-0be9a9960d0f"), 200.0, "B", 8, "VAN" },
                    { new Guid("be8565f4-1c66-4d6a-b46a-556332e392a5"), new Guid("322b8d0b-4524-4cd9-b4e5-1312d61fa572"), 200.0, "B", 1, "VAN" },
                    { new Guid("be86b5c0-57f1-4781-9117-8c31055b9b9e"), new Guid("e5cb274b-9061-42f7-aff5-97663074409e"), 300.0, "A", 8, "TRUCK" },
                    { new Guid("be8d5aff-ede1-49fc-93a8-608e3ad1c9d7"), new Guid("31faa74a-240a-4f20-a8e9-fc79657b09d4"), 300.0, "A", 7, "TRUCK" },
                    { new Guid("beadccc7-ec9f-4960-9b24-ec3ea8199fd1"), new Guid("f3297de4-ea7b-42da-993e-9ae374023e94"), 300.0, "B", 7, "TRUCK" },
                    { new Guid("bf5b05f5-c23d-4f84-967a-bb603879fbc4"), new Guid("3d85c54a-5fcb-49b5-a370-4c5d3216ae4f"), 200.0, "A", 2, "VAN" },
                    { new Guid("bfe3c1cc-9fcb-4680-b445-419cdf96927e"), new Guid("257b5f9f-b092-41af-beb1-2a2808fe0fc8"), 300.0, "A", 2, "TRUCK" },
                    { new Guid("c000dd82-e39b-4a86-9192-53c0030fa4d2"), new Guid("635a063b-8794-4510-b61d-899c3b425034"), 200.0, "B", 6, "VAN" },
                    { new Guid("c0419d64-9e1a-4904-b831-632dd7c54b7c"), new Guid("610d361a-c14c-4e3a-9ddb-700cd803bb7d"), 200.0, "A", 3, "VAN" },
                    { new Guid("c0bd9717-e037-4052-affa-11a8e0d88715"), new Guid("6caabf59-5600-43f0-98c9-ab24acf0dadf"), 100.0, "B", 2, "CAR" },
                    { new Guid("c0d021e5-a77e-4095-a74d-ad7a77829611"), new Guid("bcf6224b-83e4-44b6-84b7-9a5b11f6f78d"), 200.0, "B", 8, "VAN" },
                    { new Guid("c1684515-025c-4e42-b9fd-b0c017f597e2"), new Guid("fd6deed8-c835-4168-8d92-abafacbe20b6"), 50.0, "A", 8, "MOTORCYCLE" },
                    { new Guid("c189c802-6bef-40e4-a5df-68ce1c5f50a1"), new Guid("dab1d406-ad92-4844-b279-1cd9dfb40639"), 300.0, "A", 4, "TRUCK" },
                    { new Guid("c1d21253-415a-4caf-8e8a-7a8979a0d0f2"), new Guid("6f8b493b-9523-43ba-9a39-6080882550be"), 100.0, "A", 7, "CAR" },
                    { new Guid("c26c55e3-0cc9-4604-a8ba-af0f7836fff8"), new Guid("59e5fd81-c04a-450d-bdd6-c36e80361881"), 300.0, "B", 3, "TRUCK" },
                    { new Guid("c33c0044-c477-47af-a96f-352545e229a6"), new Guid("9c6c5b2a-00b3-448c-81cc-a9010d2d4196"), 300.0, "A", 6, "TRUCK" },
                    { new Guid("c34d791a-48f0-408e-bc45-7be8b4294a5c"), new Guid("70713bfe-20a7-4b8e-bcc9-7cd0e57ae2cf"), 50.0, "B", 2, "MOTORCYCLE" },
                    { new Guid("c35adfe1-401e-492d-864d-8fb1e12892f5"), new Guid("85611762-85eb-4a9a-a993-dc85d0a68cca"), 50.0, "B", 2, "MOTORCYCLE" },
                    { new Guid("c3cf7d66-9250-4650-ba5a-00eaa533977b"), new Guid("188984fb-f6f2-43a8-8f42-5761cf166a56"), 300.0, "A", 4, "TRUCK" },
                    { new Guid("c405750e-acaa-4dca-8737-21d4035306a2"), new Guid("86f938e1-046b-4c2d-80ba-6eb7d3f4b2b9"), 50.0, "B", 1, "MOTORCYCLE" },
                    { new Guid("c407d805-f4ad-4694-a085-3ced18a195c2"), new Guid("cf8ba59d-1e62-43aa-b128-f92651d868c4"), 100.0, "B", 4, "CAR" },
                    { new Guid("c410c9b1-25cb-4c9f-8a3f-23aa1b8a01c4"), new Guid("19bcc6b0-45ed-4845-b411-400d4f6683b2"), 100.0, "B", 4, "CAR" },
                    { new Guid("c425ddd3-20aa-4186-8300-bb43cbb594a0"), new Guid("31faa74a-240a-4f20-a8e9-fc79657b09d4"), 200.0, "B", 5, "VAN" },
                    { new Guid("c4fcd7c5-02fc-4162-8bd9-35ecee16d0b6"), new Guid("930245a8-ee38-4501-a6ec-b31839348aaa"), 100.0, "A", 4, "CAR" },
                    { new Guid("c50b22e8-2def-48d7-9a0c-d0b9299e0084"), new Guid("5a694bc0-b3ea-4d3b-b228-1555a8738e1d"), 100.0, "B", 8, "CAR" },
                    { new Guid("c59012af-0bff-41c9-a6e3-2b2cd99d0b2c"), new Guid("d09a2181-65c3-4ee5-b8b3-d4ea251a8fbf"), 50.0, "A", 6, "MOTORCYCLE" },
                    { new Guid("c5a6132e-e9c6-493b-b8f4-f17f22f0fa1b"), new Guid("e2826ba2-5ca3-4ce6-ac50-811f085e3cf6"), 100.0, "A", 1, "CAR" },
                    { new Guid("c5d4c91c-7de3-4a10-88ed-f751f4c73e18"), new Guid("5a694bc0-b3ea-4d3b-b228-1555a8738e1d"), 100.0, "B", 2, "CAR" },
                    { new Guid("c6d4ab13-45b2-40f1-b249-030003bb4444"), new Guid("2cde977d-867d-40de-9a10-432b2301464c"), 300.0, "A", 8, "TRUCK" },
                    { new Guid("c70b1e00-e17a-4e90-aa42-488029fab557"), new Guid("387a98b1-c216-4873-9812-b12a9aca5ac7"), 50.0, "B", 4, "MOTORCYCLE" },
                    { new Guid("c7f6b056-2f58-410a-9822-c1b3350b2270"), new Guid("8e054a25-6fd3-4e9d-b12b-aaa8e6ac85eb"), 100.0, "B", 1, "CAR" },
                    { new Guid("c83df9ac-5f67-4931-a918-631811b3ffd5"), new Guid("59e5fd81-c04a-450d-bdd6-c36e80361881"), 300.0, "B", 1, "TRUCK" },
                    { new Guid("c8618817-c97b-46ff-b193-e84f59020ab4"), new Guid("257b5f9f-b092-41af-beb1-2a2808fe0fc8"), 100.0, "B", 4, "CAR" },
                    { new Guid("c87be492-acc5-4bd3-aa26-a706e3c526a4"), new Guid("85611762-85eb-4a9a-a993-dc85d0a68cca"), 50.0, "B", 6, "MOTORCYCLE" },
                    { new Guid("c889e72c-1986-487c-a445-3edd7efde433"), new Guid("2cde977d-867d-40de-9a10-432b2301464c"), 300.0, "A", 2, "TRUCK" },
                    { new Guid("c8c7f157-4001-4d6b-9f9c-62b97077e3d0"), new Guid("6f8b493b-9523-43ba-9a39-6080882550be"), 100.0, "A", 3, "CAR" },
                    { new Guid("c8c8f9dd-083d-425a-9cce-e95083a39684"), new Guid("7140654e-28d2-494f-a602-8bb6bff2fc13"), 200.0, "A", 4, "VAN" },
                    { new Guid("c8d1d942-113b-42da-a308-4f254b946cbe"), new Guid("f35520f7-2e5e-4340-ba78-c10259f8c8c5"), 50.0, "A", 4, "MOTORCYCLE" },
                    { new Guid("c8e5e590-d30e-4b72-8503-fbb69d2ecc85"), new Guid("ae16885c-9a8e-49a8-b817-0be9a9960d0f"), 300.0, "A", 8, "TRUCK" },
                    { new Guid("c942651b-4f95-47c4-8500-2efdb6220e93"), new Guid("fc11e465-6669-4617-a41f-a1d1c76a908a"), 200.0, "A", 4, "VAN" },
                    { new Guid("c9e7734a-1924-4dd9-98d3-6b3ea8b3c8f6"), new Guid("e21cdfc0-d3d8-47cc-8b74-bdf62436fcdb"), 200.0, "A", 6, "VAN" },
                    { new Guid("c9ed6e5e-0a45-479e-9fcc-1840c15a3621"), new Guid("fd6deed8-c835-4168-8d92-abafacbe20b6"), 200.0, "B", 2, "VAN" },
                    { new Guid("ca0e73de-9ef6-4f3d-8071-45aab0d94692"), new Guid("7140654e-28d2-494f-a602-8bb6bff2fc13"), 200.0, "A", 6, "VAN" },
                    { new Guid("ca47d382-f31c-4146-ab23-337d866806cf"), new Guid("d09a2181-65c3-4ee5-b8b3-d4ea251a8fbf"), 50.0, "A", 8, "MOTORCYCLE" },
                    { new Guid("ca6eae4d-10d8-46ba-b99b-32500c74d702"), new Guid("0ada6bc9-6665-49b2-a427-5ad008b51fda"), 300.0, "A", 3, "TRUCK" },
                    { new Guid("ca8764bf-18bd-4b65-9d60-ceda6c16b391"), new Guid("9c6c5b2a-00b3-448c-81cc-a9010d2d4196"), 300.0, "A", 4, "TRUCK" },
                    { new Guid("caa6397c-7536-4056-b418-1718728e80d2"), new Guid("eb384a62-fea4-491c-a7a3-8a4e2c92b0c6"), 200.0, "B", 2, "VAN" },
                    { new Guid("cab8a7b7-fa53-4c3c-a05d-d57ca6e9b591"), new Guid("a8827db7-700c-4e56-94f6-2a77e3f61a9c"), 50.0, "B", 4, "MOTORCYCLE" },
                    { new Guid("cb11c418-e305-4b54-9262-c7748da5591a"), new Guid("f35520f7-2e5e-4340-ba78-c10259f8c8c5"), 50.0, "A", 3, "MOTORCYCLE" },
                    { new Guid("cb4d927f-8876-482d-9b3e-115ff9a7262a"), new Guid("891fbb4c-6ace-4cd9-ba70-deb2d06886bc"), 100.0, "A", 4, "CAR" },
                    { new Guid("cb7c9a3c-f950-4e22-b75b-bf30ea3844d7"), new Guid("52688c85-e7f4-47e9-b9f2-d508de79f823"), 200.0, "A", 8, "VAN" },
                    { new Guid("cb89ba23-a192-4880-a574-e3720f849faa"), new Guid("cfba1888-af59-40c6-bf90-ff89882538a3"), 100.0, "A", 7, "CAR" },
                    { new Guid("cbf4019d-9b6c-4c83-bd42-cadb4871a637"), new Guid("6f8b493b-9523-43ba-9a39-6080882550be"), 300.0, "B", 7, "TRUCK" },
                    { new Guid("ccea65d8-0711-4963-9876-ea22623a3b20"), new Guid("7140654e-28d2-494f-a602-8bb6bff2fc13"), 200.0, "A", 1, "VAN" },
                    { new Guid("ccf12f95-7610-46f8-8017-c0e215c78e97"), new Guid("5a694bc0-b3ea-4d3b-b228-1555a8738e1d"), 200.0, "A", 1, "VAN" },
                    { new Guid("cd12a791-443a-416f-a4b2-bbf94ac83540"), new Guid("610d361a-c14c-4e3a-9ddb-700cd803bb7d"), 100.0, "B", 8, "CAR" },
                    { new Guid("cdac9857-b64e-4801-8764-2bd30ed0da4f"), new Guid("257b5f9f-b092-41af-beb1-2a2808fe0fc8"), 100.0, "B", 7, "CAR" },
                    { new Guid("cde54e6b-9013-4967-8815-3ae3e401a5d6"), new Guid("5db7d818-7b21-4b81-8cf8-99d99ffaf375"), 50.0, "A", 5, "MOTORCYCLE" },
                    { new Guid("cec2c42e-19bf-4e61-aa21-d811ceedb509"), new Guid("1a0fc976-15ce-4e8e-9ce1-e01456178b41"), 300.0, "B", 3, "TRUCK" },
                    { new Guid("cee3fcc2-7729-4e99-9726-062e46966226"), new Guid("aae01dc0-240f-4c2b-85b8-db1d578305ed"), 100.0, "B", 3, "CAR" },
                    { new Guid("cf124369-3808-4348-bbc0-6f184cbd94f4"), new Guid("7140654e-28d2-494f-a602-8bb6bff2fc13"), 200.0, "A", 7, "VAN" },
                    { new Guid("cf24dc52-b017-4981-a432-57c4c3cb1eeb"), new Guid("fc11e465-6669-4617-a41f-a1d1c76a908a"), 200.0, "A", 3, "VAN" },
                    { new Guid("cf59f674-89e0-4489-9012-f2f63763885a"), new Guid("59eb481c-e88b-4a04-93c8-aa9fad3b8fbd"), 200.0, "B", 3, "VAN" },
                    { new Guid("cf6a6cb6-06c7-48eb-888c-518f3c79e011"), new Guid("8886b676-b97c-4d0b-ae45-d18b2f2df900"), 100.0, "A", 1, "CAR" },
                    { new Guid("d0255f41-bc9f-41ba-957b-63d2c5305f02"), new Guid("2848fcc2-f6b3-4b91-a829-47543cd6f877"), 200.0, "B", 1, "VAN" },
                    { new Guid("d0371a39-9b54-4a13-970c-9854160c0e10"), new Guid("322b8d0b-4524-4cd9-b4e5-1312d61fa572"), 200.0, "B", 3, "VAN" },
                    { new Guid("d0379d39-5d26-491b-9f8e-08b553078665"), new Guid("e21cdfc0-d3d8-47cc-8b74-bdf62436fcdb"), 300.0, "B", 8, "TRUCK" },
                    { new Guid("d0980099-44b4-4547-9030-37dae193aa93"), new Guid("dab1d406-ad92-4844-b279-1cd9dfb40639"), 300.0, "A", 7, "TRUCK" },
                    { new Guid("d1674c00-1f8b-49e5-ac59-c5c3c64801dd"), new Guid("19bcc6b0-45ed-4845-b411-400d4f6683b2"), 100.0, "A", 7, "CAR" },
                    { new Guid("d1819260-ef92-41ea-8139-44fa28fcb724"), new Guid("a8827db7-700c-4e56-94f6-2a77e3f61a9c"), 300.0, "A", 8, "TRUCK" },
                    { new Guid("d19543d9-fb7f-404b-b4ad-8dd83f7c1f89"), new Guid("2cde977d-867d-40de-9a10-432b2301464c"), 50.0, "B", 3, "MOTORCYCLE" },
                    { new Guid("d1f874e9-b7ae-4037-9b9d-58842a57c76e"), new Guid("31faa74a-240a-4f20-a8e9-fc79657b09d4"), 300.0, "A", 3, "TRUCK" },
                    { new Guid("d20fb163-09fe-4bb5-a988-429fc3acaa9d"), new Guid("930245a8-ee38-4501-a6ec-b31839348aaa"), 100.0, "B", 7, "CAR" },
                    { new Guid("d2497b60-1289-4622-9ee9-504f98a4511c"), new Guid("a8827db7-700c-4e56-94f6-2a77e3f61a9c"), 50.0, "B", 3, "MOTORCYCLE" },
                    { new Guid("d26f91e5-e24e-4d61-bbb0-0da0effd8d86"), new Guid("3f771136-710d-4c9b-94ca-00b8c3abdd93"), 200.0, "A", 7, "VAN" },
                    { new Guid("d2a08e4d-ec4e-4f11-aec5-2b4373a9a362"), new Guid("188984fb-f6f2-43a8-8f42-5761cf166a56"), 200.0, "B", 6, "VAN" },
                    { new Guid("d342ca7c-34b2-45ca-a8b6-ffedac8ac1c6"), new Guid("fc2a8276-f127-4246-86dc-4d2b3262ed86"), 100.0, "B", 3, "CAR" },
                    { new Guid("d461ff43-8bca-4692-8af7-dd9fee0f4c6c"), new Guid("ae16885c-9a8e-49a8-b817-0be9a9960d0f"), 200.0, "B", 5, "VAN" },
                    { new Guid("d48ad11d-dcf7-4944-81f9-39767bc49f51"), new Guid("7140654e-28d2-494f-a602-8bb6bff2fc13"), 200.0, "A", 8, "VAN" },
                    { new Guid("d4a03dfd-59e9-4e01-a5d9-265d2ac3187a"), new Guid("257b5f9f-b092-41af-beb1-2a2808fe0fc8"), 100.0, "B", 2, "CAR" },
                    { new Guid("d4afb42c-f655-4638-a0d6-3b2c9c3452ac"), new Guid("e21cdfc0-d3d8-47cc-8b74-bdf62436fcdb"), 300.0, "B", 5, "TRUCK" },
                    { new Guid("d4d1cced-62b9-4706-bd5c-cf0a0cb5a35f"), new Guid("ae16885c-9a8e-49a8-b817-0be9a9960d0f"), 300.0, "A", 6, "TRUCK" },
                    { new Guid("d560f46f-9fe6-4ae3-9f91-4526f2db73cc"), new Guid("31faa74a-240a-4f20-a8e9-fc79657b09d4"), 200.0, "B", 7, "VAN" },
                    { new Guid("d57907b4-cebc-4517-b9a1-9750b34cc544"), new Guid("d09a2181-65c3-4ee5-b8b3-d4ea251a8fbf"), 100.0, "B", 1, "CAR" },
                    { new Guid("d5a66e51-e571-4688-be5d-288275a10ba3"), new Guid("f35520f7-2e5e-4340-ba78-c10259f8c8c5"), 100.0, "B", 3, "CAR" },
                    { new Guid("d5de8da0-087f-4943-845e-1a060f33ac2f"), new Guid("bcf6224b-83e4-44b6-84b7-9a5b11f6f78d"), 200.0, "B", 1, "VAN" },
                    { new Guid("d68a3316-2cbf-4110-940c-7e38188000fd"), new Guid("8e054a25-6fd3-4e9d-b12b-aaa8e6ac85eb"), 200.0, "A", 2, "VAN" },
                    { new Guid("d6910c44-68f4-4022-8465-35f1f8f4782a"), new Guid("7140654e-28d2-494f-a602-8bb6bff2fc13"), 50.0, "B", 2, "MOTORCYCLE" },
                    { new Guid("d6944403-884e-4b1d-ac87-b183ab87f4be"), new Guid("3d85c54a-5fcb-49b5-a370-4c5d3216ae4f"), 200.0, "B", 6, "VAN" },
                    { new Guid("d6c2ceef-c459-4694-9900-8aaf87a1d634"), new Guid("2cde977d-867d-40de-9a10-432b2301464c"), 300.0, "A", 3, "TRUCK" },
                    { new Guid("d6ce8949-0682-4982-bd18-c34f6b3cd087"), new Guid("d65b48a9-6c74-44b4-aaf3-635151fa5984"), 50.0, "B", 4, "MOTORCYCLE" },
                    { new Guid("d6edda6b-c394-4dd2-b5dc-7935e285cd4f"), new Guid("31faa74a-240a-4f20-a8e9-fc79657b09d4"), 300.0, "A", 8, "TRUCK" },
                    { new Guid("d74b1a11-c55a-4ce1-99b3-d15abd5b914a"), new Guid("bf21db4e-8dd6-4bc3-9d0d-1e673e3c0541"), 300.0, "A", 3, "TRUCK" },
                    { new Guid("d792f546-14d0-4904-a62a-0e9b4f0a5117"), new Guid("7b821087-607f-4dd9-a07b-18f22d1c8fd8"), 100.0, "B", 3, "CAR" },
                    { new Guid("d7cff48b-41ae-4205-97b7-c200864b7f49"), new Guid("fc11e465-6669-4617-a41f-a1d1c76a908a"), 300.0, "B", 4, "TRUCK" },
                    { new Guid("d83e4edb-253c-4a0b-8c40-84fb17fb7063"), new Guid("bcf6224b-83e4-44b6-84b7-9a5b11f6f78d"), 100.0, "A", 6, "CAR" },
                    { new Guid("d868ec68-61e5-4eb5-9f49-6d4969ec7dcc"), new Guid("9c6c5b2a-00b3-448c-81cc-a9010d2d4196"), 50.0, "B", 7, "MOTORCYCLE" },
                    { new Guid("d91017b6-3c3e-450a-8309-ff6c21b866ce"), new Guid("6f8b493b-9523-43ba-9a39-6080882550be"), 300.0, "B", 3, "TRUCK" },
                    { new Guid("d931c600-b4ac-4bd8-a89a-a1c194a3cee7"), new Guid("891fbb4c-6ace-4cd9-ba70-deb2d06886bc"), 300.0, "B", 3, "TRUCK" },
                    { new Guid("d966969d-01aa-41c4-b8e9-c181fa3f078d"), new Guid("0ada6bc9-6665-49b2-a427-5ad008b51fda"), 100.0, "B", 2, "CAR" },
                    { new Guid("d97c295a-b628-4d26-9322-beac7c6c0d55"), new Guid("aae01dc0-240f-4c2b-85b8-db1d578305ed"), 100.0, "A", 3, "CAR" },
                    { new Guid("d988297d-a949-4b8e-8510-d854595f6438"), new Guid("7140654e-28d2-494f-a602-8bb6bff2fc13"), 50.0, "B", 1, "MOTORCYCLE" },
                    { new Guid("da0cd4d5-bbf0-4b4b-b933-06ed3c948a04"), new Guid("6caabf59-5600-43f0-98c9-ab24acf0dadf"), 300.0, "A", 6, "TRUCK" },
                    { new Guid("da2195fd-a432-41b4-9c3c-8f2fa5122346"), new Guid("b26c6185-7128-4959-b92d-665002dce200"), 300.0, "B", 7, "TRUCK" },
                    { new Guid("da368ee9-b079-40ed-b1bf-0bab8dc80140"), new Guid("d6240ccd-9331-4c53-91af-3b1992316096"), 100.0, "B", 2, "CAR" },
                    { new Guid("da8f856f-914c-4725-893d-97e94aa6bd5d"), new Guid("a8827db7-700c-4e56-94f6-2a77e3f61a9c"), 50.0, "B", 7, "MOTORCYCLE" },
                    { new Guid("daa49ec0-34e8-4c3a-a442-49d261b7fe02"), new Guid("59eb481c-e88b-4a04-93c8-aa9fad3b8fbd"), 300.0, "A", 2, "TRUCK" },
                    { new Guid("daa5599f-9154-47d7-b4fe-b4e0727971de"), new Guid("52688c85-e7f4-47e9-b9f2-d508de79f823"), 100.0, "B", 1, "CAR" },
                    { new Guid("dae3e1f5-b61a-4c8c-b5e3-9b39fa14883a"), new Guid("e3c60e04-8b6c-497d-b040-30019f1951fe"), 200.0, "B", 2, "VAN" },
                    { new Guid("dbb719d5-cc14-4dfc-bcab-934bdc9af0ca"), new Guid("188984fb-f6f2-43a8-8f42-5761cf166a56"), 300.0, "A", 6, "TRUCK" },
                    { new Guid("dbb76c84-7a14-4a0d-bf8a-a21397691c81"), new Guid("495b86e8-5b8f-4f62-8ade-e8152d743878"), 50.0, "B", 5, "MOTORCYCLE" },
                    { new Guid("dbf2696e-f42f-463c-a600-6c0a7073fc68"), new Guid("3f771136-710d-4c9b-94ca-00b8c3abdd93"), 200.0, "A", 8, "VAN" },
                    { new Guid("dbfa4d35-82c0-489a-96dc-557fa1a33773"), new Guid("aae01dc0-240f-4c2b-85b8-db1d578305ed"), 100.0, "B", 4, "CAR" },
                    { new Guid("dd0aeaff-8967-48c7-a1d0-12322d8ca502"), new Guid("38633289-34c0-438f-b007-976f825ec000"), 300.0, "B", 7, "TRUCK" },
                    { new Guid("dd88d0c4-40fc-405f-b7e0-8ad38442dd96"), new Guid("a8827db7-700c-4e56-94f6-2a77e3f61a9c"), 50.0, "B", 6, "MOTORCYCLE" },
                    { new Guid("ddebcb2f-712e-4529-bd78-199f9c8aaad7"), new Guid("bf21db4e-8dd6-4bc3-9d0d-1e673e3c0541"), 300.0, "A", 8, "TRUCK" },
                    { new Guid("ddfdcfad-1319-44a6-9c80-8b9d01fa2139"), new Guid("9c6c5b2a-00b3-448c-81cc-a9010d2d4196"), 50.0, "B", 2, "MOTORCYCLE" },
                    { new Guid("de4b89b9-a5dc-49b9-93e8-6562e75802a8"), new Guid("e5cb274b-9061-42f7-aff5-97663074409e"), 50.0, "B", 6, "MOTORCYCLE" },
                    { new Guid("de4f9f84-7348-420b-9b83-852aaa48a586"), new Guid("930245a8-ee38-4501-a6ec-b31839348aaa"), 100.0, "B", 6, "CAR" },
                    { new Guid("de9d7586-2c68-4421-a808-6014bfb1872b"), new Guid("5db7d818-7b21-4b81-8cf8-99d99ffaf375"), 50.0, "A", 1, "MOTORCYCLE" },
                    { new Guid("de9eb270-252c-4155-bf95-67cfbc3607df"), new Guid("38633289-34c0-438f-b007-976f825ec000"), 300.0, "B", 5, "TRUCK" },
                    { new Guid("dedd2bb6-76a2-4296-8f8f-e02700c75dc3"), new Guid("19bcc6b0-45ed-4845-b411-400d4f6683b2"), 100.0, "B", 8, "CAR" },
                    { new Guid("df256477-e686-4ede-80f2-4f39e74c1732"), new Guid("5db7d818-7b21-4b81-8cf8-99d99ffaf375"), 50.0, "A", 6, "MOTORCYCLE" },
                    { new Guid("df474d49-0e1f-4172-8bf1-d2cf65f5a124"), new Guid("fc11e465-6669-4617-a41f-a1d1c76a908a"), 200.0, "A", 1, "VAN" },
                    { new Guid("df577e6c-af2f-492e-ace0-ab48e903cacf"), new Guid("bcf6224b-83e4-44b6-84b7-9a5b11f6f78d"), 200.0, "B", 6, "VAN" },
                    { new Guid("dfa27c04-b387-45d6-a248-ed6145131ca1"), new Guid("e5cb274b-9061-42f7-aff5-97663074409e"), 50.0, "B", 5, "MOTORCYCLE" },
                    { new Guid("e0907015-d432-4768-a5f1-d72c0da95f9c"), new Guid("fc11e465-6669-4617-a41f-a1d1c76a908a"), 300.0, "B", 6, "TRUCK" },
                    { new Guid("e0b542a6-6e26-4d9a-b0c4-b5cb81375079"), new Guid("59e5fd81-c04a-450d-bdd6-c36e80361881"), 50.0, "A", 2, "MOTORCYCLE" },
                    { new Guid("e121a5ff-bde8-468e-bc66-6ddcfc11f7ae"), new Guid("d65b48a9-6c74-44b4-aaf3-635151fa5984"), 50.0, "A", 8, "MOTORCYCLE" },
                    { new Guid("e1ab5ba4-b044-4352-8558-803608e32ed1"), new Guid("f35520f7-2e5e-4340-ba78-c10259f8c8c5"), 100.0, "B", 7, "CAR" },
                    { new Guid("e1df31da-ca9e-4268-b9c3-455300e35600"), new Guid("b75467ff-4404-40c1-8269-b787f50a14dc"), 100.0, "A", 8, "CAR" },
                    { new Guid("e2835a6e-43c5-4feb-aaaa-b1032abb9362"), new Guid("dab1d406-ad92-4844-b279-1cd9dfb40639"), 300.0, "A", 2, "TRUCK" },
                    { new Guid("e2f10f37-4f62-41a0-976e-e5d865924288"), new Guid("2848fcc2-f6b3-4b91-a829-47543cd6f877"), 300.0, "A", 5, "TRUCK" },
                    { new Guid("e4212067-e62f-4f79-8702-242b494eccfd"), new Guid("fd6deed8-c835-4168-8d92-abafacbe20b6"), 50.0, "A", 5, "MOTORCYCLE" },
                    { new Guid("e456312b-de34-4ba2-8a39-749e64788c57"), new Guid("38633289-34c0-438f-b007-976f825ec000"), 50.0, "A", 1, "MOTORCYCLE" },
                    { new Guid("e4c4e28b-4ae6-433e-86a1-0a1bdc050991"), new Guid("5a694bc0-b3ea-4d3b-b228-1555a8738e1d"), 200.0, "A", 6, "VAN" },
                    { new Guid("e4d200f1-c597-4ebe-8c0f-69e5f432fdf4"), new Guid("9c6c5b2a-00b3-448c-81cc-a9010d2d4196"), 50.0, "B", 6, "MOTORCYCLE" },
                    { new Guid("e536c941-2eeb-4ae5-8549-9203f739d1b6"), new Guid("6caabf59-5600-43f0-98c9-ab24acf0dadf"), 100.0, "B", 3, "CAR" },
                    { new Guid("e53f2a1c-1399-43c4-b84b-fc0466b93d1f"), new Guid("635a063b-8794-4510-b61d-899c3b425034"), 200.0, "B", 2, "VAN" },
                    { new Guid("e55b033b-c5c0-4aa2-9a14-ca5c5a81b368"), new Guid("a8827db7-700c-4e56-94f6-2a77e3f61a9c"), 300.0, "A", 5, "TRUCK" },
                    { new Guid("e57b0e65-fc13-46d7-87fc-86df83e84ea7"), new Guid("eb384a62-fea4-491c-a7a3-8a4e2c92b0c6"), 200.0, "B", 8, "VAN" },
                    { new Guid("e58379c1-f8fc-48c0-be5a-3899d0d01a57"), new Guid("3f771136-710d-4c9b-94ca-00b8c3abdd93"), 200.0, "A", 4, "VAN" },
                    { new Guid("e5857b3b-816b-4ffe-8b50-2ed947ca4f04"), new Guid("f35520f7-2e5e-4340-ba78-c10259f8c8c5"), 100.0, "B", 5, "CAR" },
                    { new Guid("e5af651c-4dc8-4d3b-89e2-bf7e38ca1342"), new Guid("1a0fc976-15ce-4e8e-9ce1-e01456178b41"), 100.0, "A", 1, "CAR" },
                    { new Guid("e5cb4e61-b265-436f-a588-554aafffc9c1"), new Guid("e3c60e04-8b6c-497d-b040-30019f1951fe"), 300.0, "A", 4, "TRUCK" },
                    { new Guid("e5cd8a70-ed94-4a90-a536-9e9efb712601"), new Guid("e2826ba2-5ca3-4ce6-ac50-811f085e3cf6"), 100.0, "A", 4, "CAR" },
                    { new Guid("e625acf5-ff3f-4e37-ade5-394402634cdc"), new Guid("610d361a-c14c-4e3a-9ddb-700cd803bb7d"), 100.0, "B", 1, "CAR" },
                    { new Guid("e62d2034-b62a-4f1b-b1a5-68adc7eaef92"), new Guid("3f771136-710d-4c9b-94ca-00b8c3abdd93"), 200.0, "A", 6, "VAN" },
                    { new Guid("e6936dbb-d262-495a-b69e-81f68658b90a"), new Guid("3f771136-710d-4c9b-94ca-00b8c3abdd93"), 200.0, "A", 2, "VAN" },
                    { new Guid("e69ec96d-76b9-4c1a-b60b-78a7210654f0"), new Guid("8886b676-b97c-4d0b-ae45-d18b2f2df900"), 100.0, "A", 2, "CAR" },
                    { new Guid("e6eea030-1970-41aa-af5e-47c956763a3f"), new Guid("5a694bc0-b3ea-4d3b-b228-1555a8738e1d"), 100.0, "B", 7, "CAR" },
                    { new Guid("e72c03e0-0a07-46dc-b13e-91865f9a7fa2"), new Guid("0ada6bc9-6665-49b2-a427-5ad008b51fda"), 300.0, "A", 6, "TRUCK" },
                    { new Guid("e752b68c-f04f-48f4-957a-2b346f21e97c"), new Guid("3d85c54a-5fcb-49b5-a370-4c5d3216ae4f"), 200.0, "A", 4, "VAN" },
                    { new Guid("e771e626-8835-4f96-964e-c70f0eb0d396"), new Guid("19bcc6b0-45ed-4845-b411-400d4f6683b2"), 100.0, "B", 5, "CAR" },
                    { new Guid("e7a307ca-cba0-4e31-9b53-d8a250d166b6"), new Guid("6f8b493b-9523-43ba-9a39-6080882550be"), 100.0, "A", 1, "CAR" },
                    { new Guid("e83a6c78-6bc2-4e7a-be3a-a99cd9b307a6"), new Guid("e21cdfc0-d3d8-47cc-8b74-bdf62436fcdb"), 300.0, "B", 7, "TRUCK" },
                    { new Guid("e8672fb8-d00a-425b-be9b-9c21f65eaedf"), new Guid("8e054a25-6fd3-4e9d-b12b-aaa8e6ac85eb"), 100.0, "B", 4, "CAR" },
                    { new Guid("e919b085-8c27-4862-a200-f921afc86bd8"), new Guid("70713bfe-20a7-4b8e-bcc9-7cd0e57ae2cf"), 50.0, "B", 5, "MOTORCYCLE" },
                    { new Guid("e9b745d0-cbbf-4101-9110-30936b099c23"), new Guid("59eb481c-e88b-4a04-93c8-aa9fad3b8fbd"), 300.0, "A", 1, "TRUCK" },
                    { new Guid("e9d1834a-9358-4f34-a1dd-88d9fe37b43a"), new Guid("31faa74a-240a-4f20-a8e9-fc79657b09d4"), 200.0, "B", 6, "VAN" },
                    { new Guid("e9e16159-c172-4f07-b2ea-08a017b843ab"), new Guid("8e054a25-6fd3-4e9d-b12b-aaa8e6ac85eb"), 200.0, "A", 1, "VAN" },
                    { new Guid("e9e741e8-5918-46f8-8a06-1a03871aea2c"), new Guid("3f771136-710d-4c9b-94ca-00b8c3abdd93"), 50.0, "B", 6, "MOTORCYCLE" },
                    { new Guid("ea24956e-7894-42a1-b62b-edba2d23f353"), new Guid("891fbb4c-6ace-4cd9-ba70-deb2d06886bc"), 300.0, "B", 4, "TRUCK" },
                    { new Guid("ea62d25e-5841-4ee2-8dd4-f0ca9f428ffd"), new Guid("3d85c54a-5fcb-49b5-a370-4c5d3216ae4f"), 200.0, "B", 1, "VAN" },
                    { new Guid("eae9f1df-9fa5-4008-b9e0-c660f9c10202"), new Guid("8e054a25-6fd3-4e9d-b12b-aaa8e6ac85eb"), 100.0, "B", 7, "CAR" },
                    { new Guid("eb0a3404-0775-425a-88a0-c892ef6ea033"), new Guid("c23b858e-6380-4605-81ed-fae4578261ea"), 50.0, "A", 6, "MOTORCYCLE" },
                    { new Guid("ebdda60c-c8c7-4071-9954-19487a40c50b"), new Guid("86f938e1-046b-4c2d-80ba-6eb7d3f4b2b9"), 200.0, "A", 3, "VAN" },
                    { new Guid("ebdf1b91-652b-4ba1-a317-ceee7420fe27"), new Guid("9c6c5b2a-00b3-448c-81cc-a9010d2d4196"), 300.0, "A", 1, "TRUCK" },
                    { new Guid("ec07210a-c0a3-416b-8779-c5e15df6203f"), new Guid("188984fb-f6f2-43a8-8f42-5761cf166a56"), 300.0, "A", 2, "TRUCK" },
                    { new Guid("ec119c45-f461-455a-8ce0-879c4fa0a091"), new Guid("a8827db7-700c-4e56-94f6-2a77e3f61a9c"), 300.0, "A", 2, "TRUCK" },
                    { new Guid("ec7b32ba-f778-41ea-a3d0-65b43a7a9e2f"), new Guid("85611762-85eb-4a9a-a993-dc85d0a68cca"), 300.0, "A", 1, "TRUCK" },
                    { new Guid("ec89de68-137a-49f1-af31-dbc128669a4e"), new Guid("0ada6bc9-6665-49b2-a427-5ad008b51fda"), 100.0, "B", 5, "CAR" },
                    { new Guid("ecb43e18-5617-47bc-bd6a-50d9bf078a07"), new Guid("d09a2181-65c3-4ee5-b8b3-d4ea251a8fbf"), 50.0, "A", 5, "MOTORCYCLE" },
                    { new Guid("ecec12b0-8cf6-41ab-bcb0-6f7ba9d3a1c5"), new Guid("7140654e-28d2-494f-a602-8bb6bff2fc13"), 50.0, "B", 8, "MOTORCYCLE" },
                    { new Guid("ed0ae3f7-68e5-4ca8-83a4-e317289d799c"), new Guid("6f8b493b-9523-43ba-9a39-6080882550be"), 300.0, "B", 5, "TRUCK" },
                    { new Guid("edb078a4-e3e4-4cf1-a899-cb3398cb8739"), new Guid("2cde977d-867d-40de-9a10-432b2301464c"), 50.0, "B", 5, "MOTORCYCLE" },
                    { new Guid("edd92dd0-32d2-4683-887f-5075c97d8328"), new Guid("eb384a62-fea4-491c-a7a3-8a4e2c92b0c6"), 300.0, "A", 2, "TRUCK" },
                    { new Guid("edfaf90d-126f-4047-bfc7-dc442ccaff7e"), new Guid("e2826ba2-5ca3-4ce6-ac50-811f085e3cf6"), 100.0, "A", 3, "CAR" },
                    { new Guid("ee024dc6-0537-4e6b-9303-938164022cf7"), new Guid("19bcc6b0-45ed-4845-b411-400d4f6683b2"), 100.0, "B", 6, "CAR" },
                    { new Guid("ee763faa-4c12-4711-8afe-a460f822ffe0"), new Guid("bf21db4e-8dd6-4bc3-9d0d-1e673e3c0541"), 100.0, "B", 6, "CAR" },
                    { new Guid("ee8ec57d-5fb7-4bac-9b9f-6b7b3a6e2aa1"), new Guid("f3297de4-ea7b-42da-993e-9ae374023e94"), 50.0, "A", 1, "MOTORCYCLE" },
                    { new Guid("ee936606-938c-4d5a-849f-fb0dfc81f021"), new Guid("f35520f7-2e5e-4340-ba78-c10259f8c8c5"), 100.0, "B", 8, "CAR" },
                    { new Guid("eee12b45-f001-4c7e-aa22-82a73d6fafc1"), new Guid("c4fb855c-c3fd-4224-909c-e4cb4ebef275"), 300.0, "A", 5, "TRUCK" },
                    { new Guid("ef42d0ef-f759-4acf-8c7e-abfed41331f9"), new Guid("bcf6224b-83e4-44b6-84b7-9a5b11f6f78d"), 200.0, "B", 7, "VAN" },
                    { new Guid("efc0bbe6-9192-486f-ae91-9ddae84c5dac"), new Guid("19bcc6b0-45ed-4845-b411-400d4f6683b2"), 100.0, "A", 5, "CAR" },
                    { new Guid("f00e0fb6-b4ac-48d2-b1e7-a395f6c2cf6f"), new Guid("86f938e1-046b-4c2d-80ba-6eb7d3f4b2b9"), 200.0, "A", 5, "VAN" },
                    { new Guid("f0189ff7-26a0-4f89-816d-c23284a8bbd3"), new Guid("5a694bc0-b3ea-4d3b-b228-1555a8738e1d"), 100.0, "B", 6, "CAR" },
                    { new Guid("f13ce7e4-9676-4976-86b6-86c562d74fa5"), new Guid("fc11e465-6669-4617-a41f-a1d1c76a908a"), 200.0, "A", 8, "VAN" },
                    { new Guid("f18d2270-2b9d-40d8-8ef3-37abbb507269"), new Guid("31faa74a-240a-4f20-a8e9-fc79657b09d4"), 300.0, "A", 4, "TRUCK" },
                    { new Guid("f1bff78a-8857-4d1c-bae7-d87c57a6cccf"), new Guid("6caabf59-5600-43f0-98c9-ab24acf0dadf"), 300.0, "A", 5, "TRUCK" },
                    { new Guid("f256f8a6-cea3-45f4-83e8-646b411dc48e"), new Guid("495b86e8-5b8f-4f62-8ade-e8152d743878"), 50.0, "A", 5, "MOTORCYCLE" },
                    { new Guid("f2adf655-3f9d-41fa-9584-ea35413dd6d2"), new Guid("f35520f7-2e5e-4340-ba78-c10259f8c8c5"), 50.0, "A", 5, "MOTORCYCLE" },
                    { new Guid("f3064e1c-2b14-4737-80e4-015871041f6b"), new Guid("eb384a62-fea4-491c-a7a3-8a4e2c92b0c6"), 200.0, "B", 1, "VAN" },
                    { new Guid("f3dd79c8-a8f2-4df6-931f-0f2f674d3e30"), new Guid("495b86e8-5b8f-4f62-8ade-e8152d743878"), 50.0, "B", 7, "MOTORCYCLE" },
                    { new Guid("f435ca06-a9fb-4da4-9dab-9ca59215072b"), new Guid("70713bfe-20a7-4b8e-bcc9-7cd0e57ae2cf"), 50.0, "B", 7, "MOTORCYCLE" },
                    { new Guid("f46d7a50-cf3b-4247-8e41-c80d644c8666"), new Guid("f35520f7-2e5e-4340-ba78-c10259f8c8c5"), 100.0, "B", 6, "CAR" },
                    { new Guid("f4980282-ea99-457b-9cfc-15179cb33af6"), new Guid("dab1d406-ad92-4844-b279-1cd9dfb40639"), 200.0, "B", 2, "VAN" },
                    { new Guid("f4a465fa-55c4-4115-83ea-f9f0d1633981"), new Guid("e2826ba2-5ca3-4ce6-ac50-811f085e3cf6"), 100.0, "B", 4, "CAR" },
                    { new Guid("f4a553f7-6b72-4d0c-8017-a3900cd58c7f"), new Guid("e21cdfc0-d3d8-47cc-8b74-bdf62436fcdb"), 200.0, "A", 7, "VAN" },
                    { new Guid("f4d47766-42d8-4943-a3e6-13f4b2910a91"), new Guid("b26c6185-7128-4959-b92d-665002dce200"), 300.0, "B", 5, "TRUCK" },
                    { new Guid("f54d2e12-48bb-4a8a-8c4a-37df6f6049fb"), new Guid("7b821087-607f-4dd9-a07b-18f22d1c8fd8"), 100.0, "B", 1, "CAR" },
                    { new Guid("f5a477bd-ef41-4529-a309-33062f106e8e"), new Guid("19bcc6b0-45ed-4845-b411-400d4f6683b2"), 100.0, "A", 4, "CAR" },
                    { new Guid("f61582d3-a4d1-4ce2-8d70-591bc3678d1c"), new Guid("d09a2181-65c3-4ee5-b8b3-d4ea251a8fbf"), 100.0, "B", 5, "CAR" },
                    { new Guid("f643feff-bd40-4872-83fa-6038e03c628c"), new Guid("cf8ba59d-1e62-43aa-b128-f92651d868c4"), 300.0, "A", 7, "TRUCK" },
                    { new Guid("f67f1183-fff7-4d5d-b153-c5009be50844"), new Guid("930245a8-ee38-4501-a6ec-b31839348aaa"), 100.0, "B", 1, "CAR" },
                    { new Guid("f78d43b8-8c6f-47c1-9c22-333cde48e3d1"), new Guid("70713bfe-20a7-4b8e-bcc9-7cd0e57ae2cf"), 200.0, "A", 2, "VAN" },
                    { new Guid("f82db68f-cec3-44f6-984c-4d2e95addf91"), new Guid("e21cdfc0-d3d8-47cc-8b74-bdf62436fcdb"), 200.0, "A", 1, "VAN" },
                    { new Guid("f8853fb8-e280-4add-9b96-e550715c31d6"), new Guid("fd6deed8-c835-4168-8d92-abafacbe20b6"), 200.0, "B", 6, "VAN" },
                    { new Guid("f8bbe230-5183-4754-9773-0c8e968d67da"), new Guid("387a98b1-c216-4873-9812-b12a9aca5ac7"), 300.0, "A", 7, "TRUCK" },
                    { new Guid("f8d46048-e7f5-4f0a-9c68-a21450046e81"), new Guid("fc2a8276-f127-4246-86dc-4d2b3262ed86"), 100.0, "B", 7, "CAR" },
                    { new Guid("f8e63b81-f325-4bd1-9303-152a5f5e79ad"), new Guid("387a98b1-c216-4873-9812-b12a9aca5ac7"), 300.0, "A", 6, "TRUCK" },
                    { new Guid("f965f7f0-185c-414b-9014-fde0d59c8201"), new Guid("b75467ff-4404-40c1-8269-b787f50a14dc"), 100.0, "B", 4, "CAR" },
                    { new Guid("f9a68af7-aee8-4c52-afa1-9e65983be307"), new Guid("322b8d0b-4524-4cd9-b4e5-1312d61fa572"), 200.0, "A", 1, "VAN" },
                    { new Guid("f9a88a08-d561-4496-afb8-9523aff40c85"), new Guid("b26c6185-7128-4959-b92d-665002dce200"), 300.0, "A", 6, "TRUCK" },
                    { new Guid("fa16781e-ea41-4106-b5b1-ecb99c885afd"), new Guid("9c6c5b2a-00b3-448c-81cc-a9010d2d4196"), 50.0, "B", 3, "MOTORCYCLE" },
                    { new Guid("fa2256e0-7ca2-4c2c-a619-85d8b2e34a97"), new Guid("7140654e-28d2-494f-a602-8bb6bff2fc13"), 200.0, "A", 5, "VAN" },
                    { new Guid("fa5d666f-85a6-4556-bd25-a09f0c328eca"), new Guid("59e5fd81-c04a-450d-bdd6-c36e80361881"), 300.0, "B", 7, "TRUCK" },
                    { new Guid("fa6e5946-d80f-4f7e-9777-03599095d703"), new Guid("2848fcc2-f6b3-4b91-a829-47543cd6f877"), 200.0, "B", 7, "VAN" },
                    { new Guid("fab9972e-aff6-4a8b-ae0f-e9b55b33e725"), new Guid("322b8d0b-4524-4cd9-b4e5-1312d61fa572"), 200.0, "B", 5, "VAN" },
                    { new Guid("fabfbfa1-b96b-451f-b8a3-1021594ed50a"), new Guid("3f771136-710d-4c9b-94ca-00b8c3abdd93"), 200.0, "A", 3, "VAN" },
                    { new Guid("fad8c608-318f-4ce7-8c02-c11a6c1b16ef"), new Guid("86f938e1-046b-4c2d-80ba-6eb7d3f4b2b9"), 200.0, "A", 2, "VAN" },
                    { new Guid("fb176ca5-dffc-47c3-9e3d-37244fa336cd"), new Guid("610d361a-c14c-4e3a-9ddb-700cd803bb7d"), 200.0, "A", 8, "VAN" },
                    { new Guid("fb245602-af65-48da-8b8c-1522faf94026"), new Guid("f3297de4-ea7b-42da-993e-9ae374023e94"), 300.0, "B", 1, "TRUCK" },
                    { new Guid("fb6ffeda-bf47-48ca-a323-6a676b3359ce"), new Guid("59eb481c-e88b-4a04-93c8-aa9fad3b8fbd"), 300.0, "A", 7, "TRUCK" },
                    { new Guid("fbd7ad21-e43e-4eda-9520-85119a6323e0"), new Guid("5a694bc0-b3ea-4d3b-b228-1555a8738e1d"), 100.0, "B", 4, "CAR" },
                    { new Guid("fc3acc77-32c4-40c4-8ccd-55cdd88e50c7"), new Guid("495b86e8-5b8f-4f62-8ade-e8152d743878"), 50.0, "B", 2, "MOTORCYCLE" },
                    { new Guid("fc935aa0-62f6-4a9c-99df-645ddecf30cd"), new Guid("495b86e8-5b8f-4f62-8ade-e8152d743878"), 50.0, "A", 3, "MOTORCYCLE" },
                    { new Guid("fcd1b550-9760-4f9a-abae-7d91d5dedd95"), new Guid("7b821087-607f-4dd9-a07b-18f22d1c8fd8"), 100.0, "B", 5, "CAR" },
                    { new Guid("fcd29456-a016-407d-8ff4-7e425fe3e1c6"), new Guid("bcf6224b-83e4-44b6-84b7-9a5b11f6f78d"), 200.0, "B", 3, "VAN" },
                    { new Guid("fcd59fb6-8af3-4938-a658-8651837316b8"), new Guid("eb384a62-fea4-491c-a7a3-8a4e2c92b0c6"), 200.0, "B", 6, "VAN" },
                    { new Guid("fcd9eeb9-a01d-4983-8d93-67b3093f1bd4"), new Guid("cf8ba59d-1e62-43aa-b128-f92651d868c4"), 100.0, "B", 7, "CAR" },
                    { new Guid("fd7499ff-4779-45ff-8cba-28afcc53016e"), new Guid("8e054a25-6fd3-4e9d-b12b-aaa8e6ac85eb"), 200.0, "A", 8, "VAN" },
                    { new Guid("fd78955d-faa5-4706-af1a-3fe307bfaeb2"), new Guid("70713bfe-20a7-4b8e-bcc9-7cd0e57ae2cf"), 50.0, "B", 6, "MOTORCYCLE" },
                    { new Guid("fd9ae1f4-d4be-4c4c-8b1d-967bb5e74da1"), new Guid("8886b676-b97c-4d0b-ae45-d18b2f2df900"), 200.0, "B", 8, "VAN" },
                    { new Guid("fe096419-cb85-46ca-9303-cda3822106e9"), new Guid("31faa74a-240a-4f20-a8e9-fc79657b09d4"), 300.0, "A", 1, "TRUCK" },
                    { new Guid("fe259229-e08c-4b0a-9ec8-8963aabdadbe"), new Guid("0ada6bc9-6665-49b2-a427-5ad008b51fda"), 300.0, "A", 1, "TRUCK" },
                    { new Guid("fe5054df-3e01-4049-bbe6-c0f6795aa576"), new Guid("aae01dc0-240f-4c2b-85b8-db1d578305ed"), 100.0, "A", 5, "CAR" },
                    { new Guid("fe6b3f22-1151-4803-bcfb-7ab82d025e90"), new Guid("aae01dc0-240f-4c2b-85b8-db1d578305ed"), 100.0, "B", 6, "CAR" },
                    { new Guid("fe71aa79-a9a7-40e3-9bbe-2a5997df2f76"), new Guid("3d85c54a-5fcb-49b5-a370-4c5d3216ae4f"), 200.0, "B", 3, "VAN" },
                    { new Guid("feb4107c-d837-440d-9a69-ac3d0864996c"), new Guid("e3c60e04-8b6c-497d-b040-30019f1951fe"), 300.0, "A", 6, "TRUCK" },
                    { new Guid("ff1fb975-23e1-419e-87de-380687888f15"), new Guid("d09a2181-65c3-4ee5-b8b3-d4ea251a8fbf"), 50.0, "A", 4, "MOTORCYCLE" },
                    { new Guid("ffd0e9bc-e79f-427a-bc03-73db8e18be01"), new Guid("f3297de4-ea7b-42da-993e-9ae374023e94"), 300.0, "B", 2, "TRUCK" }
                });

            migrationBuilder.InsertData(
                table: "Bookings",
                columns: new[] { "Id", "CreatedAt", "EndDate", "ParkingSpaceId", "Passcode", "PhoneNumber", "PricePerHour", "StartDate", "Status", "StripePaymentSessionId", "TotalPrice", "UpdatedAt", "UserId", "VehicleNumber" },
                values: new object[,]
                {
                    { new Guid("051529ce-5dfc-4e13-8bca-76a04e8d1d96"), new DateTime(2025, 1, 5, 17, 26, 57, 996, DateTimeKind.Utc).AddTicks(494), new DateTime(2025, 2, 1, 1, 0, 0, 0, DateTimeKind.Unspecified), new Guid("0c3190ce-850b-44fd-ae97-2593ba8e8e0a"), "XNLOL3", "+8801931996107", 100.0, new DateTime(2025, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "VEHICLE_CHECKED_OUT", null, 100.0, new DateTime(2025, 1, 5, 17, 26, 57, 996, DateTimeKind.Utc).AddTicks(549), new Guid("484d700c-6ad8-4f37-be6d-14dacb11597c"), "VU27GMJCV5YO63636" },
                    { new Guid("0fbe84e9-7cb7-4ccb-9948-f300e408fd46"), new DateTime(2025, 1, 5, 17, 26, 57, 979, DateTimeKind.Utc).AddTicks(6493), new DateTime(2025, 2, 1, 5, 0, 0, 0, DateTimeKind.Unspecified), new Guid("a4af20dd-a7ca-479b-81f8-b3b49b8c9cf5"), "NT2AL1", "+8801102431518", 300.0, new DateTime(2025, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "CONFIRMED", null, 1500.0, new DateTime(2025, 1, 5, 17, 26, 57, 979, DateTimeKind.Utc).AddTicks(6532), new Guid("484d700c-6ad8-4f37-be6d-14dacb11597c"), "JPF2WMN9EAMY85322" },
                    { new Guid("12b738f0-0535-47f5-86f7-3ed2d86b4bd5"), new DateTime(2025, 1, 5, 17, 26, 58, 23, DateTimeKind.Utc).AddTicks(3655), new DateTime(2025, 2, 1, 1, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00d2ea3c-ac48-4184-a0ac-83520d1c4a07"), "PE0T2U", "+8801687975825", 100.0, new DateTime(2025, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "CANCELLED", null, 100.0, new DateTime(2025, 1, 5, 17, 26, 58, 23, DateTimeKind.Utc).AddTicks(3694), new Guid("484d700c-6ad8-4f37-be6d-14dacb11597c"), "QKIALYCRA8BU74523" },
                    { new Guid("1db4dd7d-fc65-46c8-99d1-39d570f16729"), new DateTime(2025, 1, 5, 17, 26, 58, 67, DateTimeKind.Utc).AddTicks(6563), new DateTime(2025, 2, 1, 5, 0, 0, 0, DateTimeKind.Unspecified), new Guid("ddebcb2f-712e-4529-bd78-199f9c8aaad7"), "SSE9DW", "+8801507756413", 300.0, new DateTime(2025, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "CANCELLED", null, 1500.0, new DateTime(2025, 1, 5, 17, 26, 58, 67, DateTimeKind.Utc).AddTicks(6600), new Guid("484d700c-6ad8-4f37-be6d-14dacb11597c"), "LFU1DXYORUAH37942" },
                    { new Guid("39fdbf14-f81d-4284-a7d9-3fd1f5309f79"), new DateTime(2025, 1, 5, 17, 26, 58, 61, DateTimeKind.Utc).AddTicks(8349), new DateTime(2025, 2, 1, 5, 0, 0, 0, DateTimeKind.Unspecified), new Guid("57300731-216d-480c-a66f-6b4ccedb7251"), "6LKURU", "+8801792499994", 50.0, new DateTime(2025, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "CANCELLED", null, 250.0, new DateTime(2025, 1, 5, 17, 26, 58, 61, DateTimeKind.Utc).AddTicks(8385), new Guid("484d700c-6ad8-4f37-be6d-14dacb11597c"), "NBG17S9BRWRR37958" },
                    { new Guid("3c473fe3-6cb2-4b62-aaf6-f2c0b18eaf4c"), new DateTime(2025, 1, 5, 17, 26, 58, 18, DateTimeKind.Utc).AddTicks(166), new DateTime(2025, 2, 1, 1, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d0379d39-5d26-491b-9f8e-08b553078665"), "75DJCO", "+8801975497592", 300.0, new DateTime(2025, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "CANCELLED", null, 300.0, new DateTime(2025, 1, 5, 17, 26, 58, 18, DateTimeKind.Utc).AddTicks(201), new Guid("484d700c-6ad8-4f37-be6d-14dacb11597c"), "UZ5ZGHN167QN99375" },
                    { new Guid("44df48ee-446b-47a6-835c-d9bf05403f98"), new DateTime(2025, 1, 5, 17, 26, 57, 990, DateTimeKind.Utc).AddTicks(7285), new DateTime(2025, 2, 1, 1, 0, 0, 0, DateTimeKind.Unspecified), new Guid("0077f4a8-8e98-4418-8eb7-acf2acb45cef"), "T6RRUO", "+8801266923889", 300.0, new DateTime(2025, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "VEHICLE_CHECKED_OUT", null, 300.0, new DateTime(2025, 1, 5, 17, 26, 57, 990, DateTimeKind.Utc).AddTicks(7323), new Guid("484d700c-6ad8-4f37-be6d-14dacb11597c"), "Y4Z6BS2PGSH473332" },
                    { new Guid("4aceb728-29a5-41a2-aec5-fe355d59da34"), new DateTime(2025, 1, 5, 17, 26, 58, 45, DateTimeKind.Utc).AddTicks(782), new DateTime(2025, 2, 1, 1, 0, 0, 0, DateTimeKind.Unspecified), new Guid("075a4151-cfac-4a57-8ea6-72a58f7eb6a9"), "NYB554", "+8801329165162", 300.0, new DateTime(2025, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "CONFIRMED", null, 300.0, new DateTime(2025, 1, 5, 17, 26, 58, 45, DateTimeKind.Utc).AddTicks(819), new Guid("484d700c-6ad8-4f37-be6d-14dacb11597c"), "41USTG5KA2LU69209" },
                    { new Guid("5ccb2366-7df2-4746-afc7-5873f8cf43be"), new DateTime(2025, 1, 5, 17, 26, 58, 73, DateTimeKind.Utc).AddTicks(4849), new DateTime(2025, 2, 1, 1, 0, 0, 0, DateTimeKind.Unspecified), new Guid("462bd796-becd-4120-b6a4-4bb292338b3a"), "0XJB2N", "+8801815786383", 50.0, new DateTime(2025, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "VEHICLE_CHECKED_OUT", null, 50.0, new DateTime(2025, 1, 5, 17, 26, 58, 73, DateTimeKind.Utc).AddTicks(4886), new Guid("484d700c-6ad8-4f37-be6d-14dacb11597c"), "EED2AFAJVDA535520" },
                    { new Guid("66088c65-1e8c-42b2-80f3-9e05bb03e17d"), new DateTime(2025, 1, 5, 17, 26, 58, 51, DateTimeKind.Utc).AddTicks(2263), new DateTime(2025, 2, 1, 1, 0, 0, 0, DateTimeKind.Unspecified), new Guid("300d2cb5-44ee-4359-9ade-f7f4120a71aa"), "R132YF", "+8801003347262", 50.0, new DateTime(2025, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "CONFIRMED", null, 50.0, new DateTime(2025, 1, 5, 17, 26, 58, 51, DateTimeKind.Utc).AddTicks(2301), new Guid("484d700c-6ad8-4f37-be6d-14dacb11597c"), "QPXB1A1J5IFF12468" },
                    { new Guid("67d0c73a-2363-487f-ab99-aadd459dbf8d"), new DateTime(2025, 1, 5, 17, 26, 57, 960, DateTimeKind.Utc).AddTicks(6627), new DateTime(2025, 2, 1, 5, 0, 0, 0, DateTimeKind.Unspecified), new Guid("20053e0c-51d9-48fb-be65-5ed30339b790"), "ZV9O4Q", "+8801803591022", 100.0, new DateTime(2025, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "VEHICLE_CHECKED_OUT", null, 500.0, new DateTime(2025, 1, 5, 17, 26, 57, 960, DateTimeKind.Utc).AddTicks(7682), new Guid("484d700c-6ad8-4f37-be6d-14dacb11597c"), "ACXT2NTN7MTN31990" },
                    { new Guid("85f72c67-e7d2-4b77-8eec-c0075ee315f5"), new DateTime(2025, 1, 5, 17, 26, 57, 968, DateTimeKind.Utc).AddTicks(1797), new DateTime(2025, 2, 1, 5, 0, 0, 0, DateTimeKind.Unspecified), new Guid("58ec4fcd-d9de-494d-b983-a39bea7aa744"), "YMA8HB", "+8801797462869", 50.0, new DateTime(2025, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "CONFIRMED", null, 250.0, new DateTime(2025, 1, 5, 17, 26, 57, 968, DateTimeKind.Utc).AddTicks(1856), new Guid("484d700c-6ad8-4f37-be6d-14dacb11597c"), "117PSDOI41XY18232" },
                    { new Guid("8ce3876e-51b1-482e-86bd-59fcf72bc3fd"), new DateTime(2025, 1, 5, 17, 26, 58, 39, DateTimeKind.Utc).AddTicks(6626), new DateTime(2025, 2, 1, 1, 0, 0, 0, DateTimeKind.Unspecified), new Guid("2b407f1e-e79f-413c-8eff-28a83cea14a0"), "XCMV2N", "+8801630065831", 50.0, new DateTime(2025, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "PENDING", null, 50.0, new DateTime(2025, 1, 5, 17, 26, 58, 39, DateTimeKind.Utc).AddTicks(6664), new Guid("484d700c-6ad8-4f37-be6d-14dacb11597c"), "OES42XKLW1GU41120" },
                    { new Guid("8ddd4637-0895-43e1-a1da-f7a6840ad6b9"), new DateTime(2025, 1, 5, 17, 26, 58, 1, DateTimeKind.Utc).AddTicks(7055), new DateTime(2025, 2, 1, 1, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c8d1d942-113b-42da-a308-4f254b946cbe"), "89WUJD", "+8801420246974", 50.0, new DateTime(2025, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "CANCELLED", null, 50.0, new DateTime(2025, 1, 5, 17, 26, 58, 1, DateTimeKind.Utc).AddTicks(7093), new Guid("484d700c-6ad8-4f37-be6d-14dacb11597c"), "TG985ACXMOYE47774" },
                    { new Guid("a35c234a-8838-4056-8798-2495497d3abe"), new DateTime(2025, 1, 5, 17, 26, 57, 985, DateTimeKind.Utc).AddTicks(2666), new DateTime(2025, 2, 1, 5, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8f294424-44fa-4721-8748-d868f1b18a09"), "QATLSS", "+8801730682392", 200.0, new DateTime(2025, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "VEHICLE_CHECKED_OUT", null, 1000.0, new DateTime(2025, 1, 5, 17, 26, 57, 985, DateTimeKind.Utc).AddTicks(2704), new Guid("484d700c-6ad8-4f37-be6d-14dacb11597c"), "ZHNC8QINIIKG46812" },
                    { new Guid("b04c949e-31c4-4371-bdd2-425b8d41003d"), new DateTime(2025, 1, 5, 17, 26, 58, 28, DateTimeKind.Utc).AddTicks(7256), new DateTime(2025, 2, 1, 5, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00d2ea3c-ac48-4184-a0ac-83520d1c4a07"), "CDYC2I", "+8801498357372", 100.0, new DateTime(2025, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "VEHICLE_CHECKED_IN", null, 500.0, new DateTime(2025, 1, 5, 17, 26, 58, 28, DateTimeKind.Utc).AddTicks(7294), new Guid("484d700c-6ad8-4f37-be6d-14dacb11597c"), "NF215XBO64P062801" },
                    { new Guid("e601c638-a555-4bd3-b5bc-7f8561601d51"), new DateTime(2025, 1, 5, 17, 26, 58, 12, DateTimeKind.Utc).AddTicks(4174), new DateTime(2025, 2, 1, 1, 0, 0, 0, DateTimeKind.Unspecified), new Guid("2f163448-a190-4625-bb5d-947ba1e44e6f"), "Q50GHH", "+8801964725613", 50.0, new DateTime(2025, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "VEHICLE_CHECKED_IN", null, 50.0, new DateTime(2025, 1, 5, 17, 26, 58, 12, DateTimeKind.Utc).AddTicks(4210), new Guid("484d700c-6ad8-4f37-be6d-14dacb11597c"), "N9TTHZPDL4PP43201" },
                    { new Guid("ea359403-32cc-43ab-9825-024e2a8af8da"), new DateTime(2025, 1, 5, 17, 26, 58, 56, DateTimeKind.Utc).AddTicks(4689), new DateTime(2025, 2, 1, 1, 0, 0, 0, DateTimeKind.Unspecified), new Guid("79af75c8-8526-467e-a18a-1b19a93556b8"), "B1X7SJ", "+8801367909855", 200.0, new DateTime(2025, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "VEHICLE_CHECKED_OUT", null, 200.0, new DateTime(2025, 1, 5, 17, 26, 58, 56, DateTimeKind.Utc).AddTicks(4725), new Guid("484d700c-6ad8-4f37-be6d-14dacb11597c"), "KX5YGA3CX8YK63698" },
                    { new Guid("f825f37c-4348-40d5-95a3-8a9a85db98d4"), new DateTime(2025, 1, 5, 17, 26, 58, 34, DateTimeKind.Utc).AddTicks(4463), new DateTime(2025, 2, 1, 1, 0, 0, 0, DateTimeKind.Unspecified), new Guid("81d709ef-b8dc-4968-9125-2f2755b849da"), "CN7IJQ", "+8801303200185", 200.0, new DateTime(2025, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "VEHICLE_CHECKED_IN", null, 200.0, new DateTime(2025, 1, 5, 17, 26, 58, 34, DateTimeKind.Utc).AddTicks(4501), new Guid("484d700c-6ad8-4f37-be6d-14dacb11597c"), "B2L4HMH634ES13329" },
                    { new Guid("f968ab87-9719-4e73-bc5d-985d2ca13fd9"), new DateTime(2025, 1, 5, 17, 26, 58, 7, DateTimeKind.Utc).AddTicks(1685), new DateTime(2025, 2, 1, 1, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e57b0e65-fc13-46d7-87fc-86df83e84ea7"), "T0BLC7", "+8801992719090", 200.0, new DateTime(2025, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "CANCELLED", null, 200.0, new DateTime(2025, 1, 5, 17, 26, 58, 7, DateTimeKind.Utc).AddTicks(1722), new Guid("484d700c-6ad8-4f37-be6d-14dacb11597c"), "BHBO77JS8GP953730" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("1a6ef942-b31f-4dc0-a02c-d13159805229"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("43cbb005-d8b1-4755-8f5b-8c8bf995fd1e"));

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: new Guid("051529ce-5dfc-4e13-8bca-76a04e8d1d96"));

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: new Guid("0fbe84e9-7cb7-4ccb-9948-f300e408fd46"));

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: new Guid("12b738f0-0535-47f5-86f7-3ed2d86b4bd5"));

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: new Guid("1db4dd7d-fc65-46c8-99d1-39d570f16729"));

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: new Guid("39fdbf14-f81d-4284-a7d9-3fd1f5309f79"));

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: new Guid("3c473fe3-6cb2-4b62-aaf6-f2c0b18eaf4c"));

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: new Guid("44df48ee-446b-47a6-835c-d9bf05403f98"));

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: new Guid("4aceb728-29a5-41a2-aec5-fe355d59da34"));

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: new Guid("5ccb2366-7df2-4746-afc7-5873f8cf43be"));

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: new Guid("66088c65-1e8c-42b2-80f3-9e05bb03e17d"));

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: new Guid("67d0c73a-2363-487f-ab99-aadd459dbf8d"));

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: new Guid("85f72c67-e7d2-4b77-8eec-c0075ee315f5"));

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: new Guid("8ce3876e-51b1-482e-86bd-59fcf72bc3fd"));

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: new Guid("8ddd4637-0895-43e1-a1da-f7a6840ad6b9"));

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: new Guid("a35c234a-8838-4056-8798-2495497d3abe"));

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: new Guid("b04c949e-31c4-4371-bdd2-425b8d41003d"));

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: new Guid("e601c638-a555-4bd3-b5bc-7f8561601d51"));

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: new Guid("ea359403-32cc-43ab-9825-024e2a8af8da"));

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: new Guid("f825f37c-4348-40d5-95a3-8a9a85db98d4"));

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: new Guid("f968ab87-9719-4e73-bc5d-985d2ca13fd9"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("001251cc-d62a-4898-860e-edcf7c9f2b82"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("00190733-47c2-4d72-9b3a-5fb225a49db8"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("009a2b54-43d0-427d-9777-5405f0cae6d9"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("00dfeda2-497b-46a7-85f9-c465d3081de4"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("00e15d14-428a-496f-a9bf-1733228d372c"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("01388abe-0f89-4241-bb0d-50c3c2d6ca5f"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("01c84b6e-a9c0-42b9-bbea-85c095a781f3"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("01c8ded2-6485-4a0b-9113-7159023d350f"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("02137a89-1c80-43d5-9764-d7d08e6023e7"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("023f3d24-33d6-4b9a-9dc1-5b0e6b1fb871"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("027a287b-17f0-4e00-b6e2-921a24d53cc9"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("028f49da-2e4b-41c9-97b5-993442eb7d3e"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("02f30cc4-3ce7-4331-9355-269828994901"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("02f824ca-de90-4a11-b808-81a1b6c2c14c"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("034962cb-8d20-4b41-8745-66825f4e2b06"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("036a764c-5ecb-467d-944e-cc60d18ba1cd"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("03a38f89-2dda-4412-b189-0b33940d6c74"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("0417bb31-b4ac-409c-8abe-13195664f9df"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("041f4f48-72b4-45c0-82c9-70309c2f9971"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("042b6642-4b90-41cd-8f83-278a20b5ea94"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("0442051b-024a-4eef-b6ab-1e0bcd9e561c"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("04ba7c6f-9d17-40d1-8e07-c03a85393b90"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("056807ab-b26d-47c5-be7a-6d5a371ba36d"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("05e637ba-7f1d-42d7-9e0a-f305d29fd07a"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("06ead2cf-f6dd-419d-af38-4f877569470d"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("072311f9-a1df-4fd2-8192-95ce3bdaa39c"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("07864be6-8512-4d81-aaa1-b2273c93657d"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("07df8a7e-eb1f-4d42-bfc8-4b7c77df731e"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("08186908-d500-4b89-90de-1b59aa062afc"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("09402872-1a2f-4ca6-9365-28b62cb3b5cf"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("0968ca26-b580-45ab-96e0-0f48492876f0"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("09e404f6-c557-4522-908e-3142b797602d"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("09f32392-8857-4f72-978f-ee0f87fea25d"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("09f50a77-a2af-4698-8427-833fa2883c5a"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("0a0aba48-da1d-4a49-b9af-4e297f5cb81e"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("0a1fedf8-0fe6-49a9-beb7-babd28443f5d"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("0a364202-5893-4438-9fdd-3837a80641a2"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("0a5a7400-8989-4ee7-a47a-3e368245b65e"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("0a842c27-c33b-4278-afb8-400fa2049b7b"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("0aa3b51b-ef30-40c5-8dd1-2f6a07fad40b"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("0aecfc4b-1984-4dd7-a140-bc8f29f2fe17"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("0b0cacfa-dd7e-4969-81ae-aa059dee3c74"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("0b1fe6bd-144c-45bf-b2d8-d1a81d5e6b6b"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("0b260d14-3ca6-4d97-8aaf-fd2c7bc7c31e"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("0b4e8d4b-a881-480c-95a5-4b8969821137"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("0b58a077-5f10-455f-bf5e-f0a85ad85089"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("0b9ce54a-4aea-4721-af4b-485af9ff5e1d"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("0bcf6bba-2763-458a-9687-4bd54afe62e9"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("0bd64e36-2b99-471d-a4bb-ad1796730940"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("0bf74b48-90d5-4988-a78b-6c5d090b3c7e"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("0c6f2933-1a31-4d55-8ec3-7058b9b8a576"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("0c8c7e1c-e49e-4c94-b7ab-b249fa83e403"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("0ca972ed-837e-4d6d-af90-a28c6b68ad22"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("0d35df22-7cc5-4d4d-9adc-e53417db629e"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("0d377836-17e4-4327-a367-1ba86f0a35ee"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("0e2ec267-9c22-4613-97c2-e30895feeae4"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("0ebfa4ea-ad26-467c-b588-83fe131dd6f9"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("0ee244ad-0efb-41d5-b48f-f325693e6abf"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("0f1c8b53-4af9-4ae7-88af-b65a00f5a3f6"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("0fd23506-426b-4d7d-a4b1-00c168b3a5e3"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("101a12ef-03fb-4229-bd9a-f9bed84af9cd"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("1107094b-d6ae-41b8-9104-ef710fec4d5d"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("114c1c4c-6153-4d14-9420-909720a13460"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("1194fdd5-39d0-496f-b4e4-25781cf2cbc5"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("11d6ff93-fbbe-4745-b6cf-9bdbabb038a5"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("12455af7-3fb9-4877-b697-9f13129f60da"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("12bf7b81-e6ec-47eb-8186-17ef9e395c5f"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("131ad2da-92f9-4637-9e71-55e6137b0c32"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("13876180-346c-4bb2-8200-9a1e2aee57e8"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("145f4366-3317-4ec3-abcd-da366795b8a6"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("14ef0cde-095b-444c-a45e-265a5971c2b3"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("151968bb-a5df-4d23-9b35-a4c9178142a3"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("151d0219-abf3-4697-a2ee-49ef6982ac75"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("1522124b-f052-4ea7-bbce-08908ff2565c"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("152868a1-9ea2-49e8-93d6-e09cb475b136"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("1537b802-3f85-41a3-b7a7-807b9c0052df"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("157c33b1-e0fd-4d7f-a114-419f313ef309"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("1583ffa0-ca97-4bfd-ac6e-cf420e655d2c"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("15f38b61-22de-47e0-b315-4ae8f4b7cb58"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("15f6b4ba-2e16-4ff7-83dd-4ade88bfdd95"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("164d157f-2ab3-48b4-a515-21e3fd3727fc"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("167e4868-22c9-474d-b84b-11fc93035a2f"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("169656c0-7737-4b19-afc0-91e131b94d4a"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("16e7f948-6539-4dbd-b5f0-6fb94efab83d"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("16f59195-511b-43b7-bddd-a9eaeddee94f"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("17113316-1906-4f39-bc6c-6c3a05b318db"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("172a54db-d4c7-44a5-bdf9-470d4c032ccc"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("1766c653-c238-4a15-b42b-bb80ed0dd1e8"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("1775ba3e-7bc1-43bf-bff8-8fbb256e5424"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("178c5007-f3a8-440e-b84c-6f8480bd281f"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("17f1afac-ca1a-461b-9531-9a29bc53974f"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("1802eb52-5ff4-41e1-8cf7-52bdcd12b4e5"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("18716b96-5dfb-4a68-8b31-6b2fe32e4a72"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("18ee55c2-eedf-41f4-b9d1-9646bef99db1"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("1907db7b-66e3-4352-9875-dcba16800c2b"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("19438ec6-76fa-4f8d-a281-4ca39319bca8"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("19e8c391-705c-496f-991f-841b0b968377"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("1a32090b-1aaf-45dd-a3af-c485136bae45"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("1a3cd594-fb7e-4dbe-a352-47da5c16c7e2"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("1a69e915-3701-4a8b-9a6e-cdb6c50bf37d"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("1a825bae-c544-413f-84c8-a6dc5f2b9111"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("1b0aa0bd-844f-4969-a256-974a1a174909"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("1b45566f-3204-48e4-aae8-8facda51d667"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("1b5ccf58-bdfc-4153-88da-5477a30f2666"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("1b717b8b-bc61-4454-af4e-48b68caa6997"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("1b7fe602-d839-46fa-8a68-64a3d182419a"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("1bff8fe8-53ae-4bcc-92ed-83cc48c733c3"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("1c43b13c-121d-4098-b01a-1866b98bd229"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("1dc1a727-ac90-4f4d-b8ad-7278532426f2"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("1de1f621-2d1b-4322-b246-6c77a3b87828"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("1e1f99c8-b029-419c-88dd-0b2877ca6daf"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("1e37ad39-29bc-471d-847a-2935a5cd5f1f"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("1ec4082e-8b60-4f35-ae84-efe160dbc861"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("1eca041b-c4fa-4d11-99b3-e47dd9335daf"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("1f1aed56-b0ff-409f-a2d6-a48f677047b8"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("1f72b83e-99d1-4e1e-a6cc-659153d6014a"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("1f8c7a47-6b96-4ccf-b6c3-f32e00d5c400"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("1f9786d8-f9c3-4ae6-9f61-d55362e6a266"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("1fcaeca2-796a-4bb4-bdb8-962301ced71f"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("20a3900b-b614-426b-9d42-ef5efcd1bc75"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("20cd0323-b2a4-4c0a-81a5-72b168980ca5"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("21a327bd-1ed6-4d8d-9526-e35af7bce6f8"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("221f0970-bfe6-466e-b2c8-aa2845b7fad1"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("2328e2a6-05ef-402a-becb-023abbfa03f9"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("23914148-1f20-40a4-9c90-c678efb502d5"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("23ee5b47-639b-4f22-b982-2a083a62a848"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("240e6821-9336-4585-b905-3159c1d58bef"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("244eba17-4a3f-4ef7-b959-4e5c89abf5ff"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("245131eb-2dfc-42e9-8c7d-f6427c8ef20e"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("246004b2-980a-4365-9daa-0ef35ba0a60c"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("248cd87c-3f52-4be7-a247-3df530ed0b98"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("25094002-ead1-4a45-9bb9-f2354832e089"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("255591a0-6ecc-4519-8738-ab570072aa44"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("25585b93-6dc2-447c-8d34-890db3041844"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("257ab028-8198-418b-ac11-2752be4a47f6"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("25834b3d-61e9-4eaa-9e3d-edf3a9cc480a"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("25b14ead-0564-4d18-a44a-54f1b7d1d2b8"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("25bab44e-33a5-4855-893d-715abfd11b57"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("25babcae-3103-4b70-ac57-16e80fe2752c"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("25ce77ea-4562-495c-9a9e-0659631682a4"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("25e14e04-d9e4-47af-8fd5-4f3d2387e60d"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("265b6097-9706-43f2-8815-7f75a8134a3c"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("265b7436-9bcf-4e02-b63d-ad682c1a9e3f"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("26cf38c1-5fed-47db-82e8-3a869faf6266"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("274f1df2-b439-48a8-807f-bf7dbd779f4e"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("276db519-784f-41d5-acb4-11b73e5d5b1a"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("27893d97-bf94-4cfc-817a-270f46bc93c2"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("28728b56-d903-4064-b4bb-15414a65f284"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("28d74eff-9f67-4844-b94e-ad90c4b62840"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("290702d1-95c0-470b-8f0f-faa418d954dc"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("295540bb-d166-4379-9bfb-3793b29f1c77"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("2a904237-71cc-417b-a998-f5e72a2bacfb"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("2aaae866-be62-4be0-9578-723c17ed1b72"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("2afc9719-8bef-495c-8c6e-4437d25c192c"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("2b5b5f30-23b9-48c0-9bcf-967ddc4e7c34"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("2bbe4935-59c9-4421-9e9f-f639ef26ac7e"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("2c425550-5a13-44d0-a7c5-573c8b95dc91"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("2c589dd7-5eb3-49b8-bc22-9ec8c667bac3"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("2c65452b-e666-4cc4-a0ed-215668e0ec5f"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("2cb200ca-30ab-4b33-aeb1-b6c8135866d1"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("2cf0ba31-555d-49bf-8c01-f4bb37759a94"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("2d35849a-540e-4d92-af6b-9b503703cf35"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("2d85738a-a75c-4928-9ac2-c7e684567295"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("2d9009de-d8d8-480b-a892-30be8e0c3842"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("2d92482f-25ea-405a-a00f-667264b85d35"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("2daa6135-4105-4f92-a130-65bfa0f8a0c0"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("2dce7789-19a7-494d-addd-25af5e3d6470"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("2e587d8c-fecc-43a4-8970-f6dc1d78e357"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("2e6d0a6b-b8b3-4be4-bfd4-e9e3859db9e6"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("2eb09d75-9817-417e-aa94-6ca554602594"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("2f15ecd2-e5c5-44b7-9715-8a6c754d61ff"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("2ffc4b4b-4c0b-4f5a-912d-6edd70989ed9"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("3014b95a-cdc8-48f1-8f3b-08d6aa62028a"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("3018e266-a932-40de-bf4d-ba447aab186c"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("305b1488-f743-4eac-bebf-323dce1b2cb6"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("30b52a3d-f2ba-411c-aa80-42ba6b3af147"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("30b823d2-d918-4840-b00a-c79bc2db035a"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("30d64edd-679c-4e46-a758-b218c05fe0f5"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("30e93e06-07e0-43bd-ad9b-0d6447aa2d89"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("313826ce-b9c9-448e-9f11-e1cf0ec31de7"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("315d0ec6-b1a9-4d06-ad2b-c65eeef18039"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("317e96ae-2b07-46aa-853b-a81d750b7c37"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("317efd99-44c7-4c4f-a06b-f19e37dbf3c7"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("3191d7d2-7db5-4570-85e5-13298aeb24c4"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("31acb28d-1c74-4b61-9444-6c5e67c147ec"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("31c313ef-30d2-470e-a129-6bcee6dee506"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("31ff615f-6f13-49e9-83b3-095392f3e84d"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("3208f06b-7c21-4e9c-aca0-1ecc3490df79"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("3227c724-c645-4a75-bc10-e40faed59bad"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("323ec3de-cf48-4e8b-9c5e-00ef3e45ad4a"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("32720445-5852-4f5e-b733-0fe4593d41af"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("32a297b7-9950-4b12-8e24-c591ffee2494"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("339d4cf8-7cf6-40a4-b119-2ec419793a46"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("3423f337-0498-4560-8395-74ef523718c0"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("342ea489-875c-4e62-ba74-b96b4cf69c65"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("34eb0c65-9fd2-4798-a8cf-24bfaf4eea68"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("3559c596-a37c-4b9b-9498-d224bf39121e"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("356aaf20-93fa-40ed-ac90-08bc759a5837"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("356c6e69-b539-4bb0-bc8e-de5622cb992f"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("35aff249-1064-4257-901e-ed597396c2dc"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("3673fa3a-fd92-4f84-970b-a79e5829a9be"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("36e810a5-1388-49a6-a7f1-b3fd2dfaea0c"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("37b7a402-f425-4322-96a5-ca80cf54ff2f"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("392e4da7-4fb9-429f-803f-44942b478664"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("39e33b5f-56fd-4f0a-9b0e-56a2b28a774b"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("3a1f4c43-d633-4df5-8a6c-e8078722f638"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("3a31bbd0-1222-4314-b7ea-e3c87178d7a9"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("3a33b64e-5249-4cc5-89f8-e8fc55e6f6da"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("3a5ce483-4636-4895-8c83-623dccba8b48"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("3acfdc94-33b8-4074-84ca-cf5f0aefbc0e"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("3b11dec6-3348-4d83-a5d1-1afe558645f6"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("3c30ed77-e7f6-4658-83ee-c704645a9d26"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("3c3eaa52-407d-406d-bc9a-c8a280d83ed5"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("3d168788-dcd2-4135-8d25-688188d41bd1"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("3d3d3420-c766-4fc6-a9d0-d04163781dc2"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("3d9365f5-a7d7-437b-a2d6-5d17f4331bec"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("3da09aae-e950-4e99-a03a-da60b77e6b32"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("3ed972be-ed47-41b2-abde-ae470df7ff35"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("3efddc8f-1bf7-44e6-a9aa-e338a0e694a1"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("3f4a231d-d99e-4618-b69d-fe1c861f46f9"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("3f7b559c-14ff-4d89-88b3-8e6ba32c28d0"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("3f7bbcc4-a453-47c1-a956-957fd348b2cc"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("3fb4f719-d388-4f63-ba0e-fb5f06535692"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("403b647f-350a-4984-8d9f-2e380e579182"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("40e45c4a-993c-46fd-bb88-ccd6fdce6a81"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("41544e7a-99d5-4a6a-aa10-5852209d4065"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("41bc927d-d0da-4213-a0a9-e194a8d1ab48"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("41cf73b5-44c3-429c-8952-beee4f590306"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("41e79e98-03bc-4667-ac58-7e9fb02906bb"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("41f492b9-9d29-42e9-98ef-460cf6eadc67"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("420629c2-861d-48c2-abd2-e6ea971d4eda"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("421e2eee-c69d-40f5-9809-cba1575bb8cb"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("42fb9a32-d8b6-4619-a79f-b912daa76181"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("435710ce-2f0c-4514-a09b-1196994f8ac2"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("454f75d7-ebc4-410d-8cdc-a91cc7077395"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("458e2da8-cf39-41b3-9fcb-6f8a9b3cfe4f"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("45c2404b-5e32-4617-b999-0bb8c2d8ef42"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("45db9ef6-d382-41ab-a69e-f6a435d631d7"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("462b309e-9ea1-436a-9056-a3456219174e"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("46303751-8bfb-401a-b029-cc3c73fc7446"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("4690adf5-dde5-4678-a898-51cb761c3298"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("46b1c062-fd93-4cc1-9919-90296eb83a07"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("46bb8d4b-3453-466a-a3bf-8f333182c0d1"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("46c8d9c8-6524-4728-acfd-acadfc1f1420"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("46cd41e2-6484-4654-87f2-3a450a9afdb7"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("46d813b4-8f0f-4374-838d-1d88ab0efd8f"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("46e38ef1-41c5-44f4-b4a3-9bde0db9950f"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("46efab15-85a0-43c1-bfdd-33fafc22127c"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("46f2916e-fef2-4b6b-bf4e-b70e12ce677d"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("46fb8902-d035-4f98-aaa9-e0f04d70cd8f"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("4701b90c-3633-4e8a-8d98-f13faf6ae522"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("47066c2a-e013-4f4a-a616-12eff9a7cc51"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("472795b9-0197-4e44-bc61-a1766608c671"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("4749e998-0248-4f75-a56f-709baaf3b54b"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("48081af6-5909-46ee-9307-759d86e62630"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("488c8cd8-bb50-4c2f-8954-e0738c58c78b"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("48a2e3fb-349b-488c-9e26-c85a5f62a2ee"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("497eaa09-51be-4125-b954-ba159d7b2c81"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("49a4d00d-319f-4159-96a2-4f9760ca2ba1"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("49ff4b24-1870-4758-a016-7011e26cca17"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("4a177b8a-39cb-49ce-bebf-a1d9e925a588"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("4a1ebb18-2c7f-4881-83f1-7869ef37c76a"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("4a3eec55-2f60-4875-9d4d-20512af60743"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("4a42f742-4e59-4b8d-b5d5-779892515207"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("4aa8229c-f4c9-4524-9761-20f2c0e5259a"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("4aedfb40-b4ed-485e-879a-9bf7a0fcb9d5"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("4b330768-547a-4089-831e-91cbd0f60963"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("4b3be3b4-3fa5-4eb4-90fe-6fa2b385c2c5"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("4b5d924d-d99f-4be6-b8fb-b8cabf585ce6"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("4b65560f-7cf9-4d9b-ac10-7c5b83c18ef6"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("4b77fb48-89d8-4344-a758-b514582b31c1"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("4b8df5d2-eda5-4226-9e65-7762c02db1b6"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("4bd077cd-7c57-4ce6-8cdd-dce66c51d28e"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("4c634125-4d18-4a6e-aa32-221dcdb6832a"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("4c7f1c7c-c642-4779-b6dd-d95c5bc08bbb"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("4c8e54a2-720f-4262-ae9b-cf1eaa25f788"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("4cbd3c15-3fa4-4af6-9dc2-606e5db25818"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("4dd3577b-11ea-4ea0-8753-53fa1cb0bb51"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("4de7c9e6-2210-47e4-83e1-9f0e63f152bd"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("4e069189-ce0f-48ce-aed2-0c60e38430bf"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("4e2f18d9-2a33-49f1-a60f-6bdc6d311f42"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("4f09b742-dece-4027-a589-275349c4f2a4"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("4f86cc7a-3496-4cdb-a103-c18936e05ce8"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("51140f7a-0b2a-43b7-adb0-ea9263c9f895"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("512e4e31-f48c-40c4-a822-7b74c29eb213"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("5181dcbe-4432-486c-8bd5-fd003fba3250"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("51bd04f7-fe60-4394-9926-86471f4521ee"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("51f0ffcf-a469-4757-b833-b086bdf92c33"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("5231347f-c1c4-4f22-a5e2-ca65129eaf4b"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("524dc36d-6fd3-44bc-a972-d184cbb10d99"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("532826a0-2648-4608-b521-e3a26c5af7cd"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("5332c626-7977-48bb-93e1-b986d3009dfb"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("5338b139-c758-42de-ac3b-228bd9720fcf"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("533c0f3b-28d8-426b-971b-4099c5d116bc"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("53f496e1-6804-49e2-a9cd-02635b155cbb"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("542e014d-3ef5-46a0-ae25-5e3bfe2e9cc4"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("547006ae-7bf6-4d6d-9374-7a2b08cfffc8"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("54782404-1c44-4fb5-b4b0-96e23ff4582a"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("5484f409-ca9c-4be6-8847-6e3bccd6dd55"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("54d6dc49-3e8b-407a-b924-48738e19b3f8"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("54e55ffc-db32-418c-bd7b-80484aa6c086"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("55909176-0504-4a49-b639-5e37fce9bab3"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("55ab93b6-556d-4a9a-adbf-469a0252d764"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("55f61e5d-5979-4487-abc3-91609abc2c3f"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("570649c7-69ea-4b4e-8260-af5de319e707"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("57151461-dd89-4236-82e8-e9800e7da1f6"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("573a1409-5154-48a1-a25c-c37a997e57b7"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("575d13f0-2267-480c-afa2-38b4079d8163"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("578acbbd-d368-478c-93de-662189f6a023"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("57cd3d2a-8430-402a-909a-954d9cb0cb55"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("581fc8f4-9969-418e-9e51-2699b9d880f5"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("5827caec-2494-4a15-91e0-4e522d1be1d2"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("586a7073-adb8-4f69-95ca-7a522263d732"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("5918de75-058b-4964-9b37-b22414d8f77e"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("597c5ee2-de07-4765-affe-c3cde5c74bde"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("5a0d21c0-147c-425d-a860-e5a2a834909b"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("5a0e8d04-51cb-47ef-af01-ae14670cbaa5"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("5a46fb1e-3e54-4416-ae02-671234b2b1cd"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("5a84e9c1-40b3-4c6e-932b-2247bf4438da"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("5ab0394f-6810-46a7-88e1-372fc946f1bb"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("5aefa7d8-24cd-4ec5-a6e5-08bfd28880f6"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("5b00b417-b7b7-4172-b92c-4c6051f53aea"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("5b06c77a-8026-475f-9ffd-936310b507f3"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("5b39cc7c-6ebb-41ce-8205-e5c5bb1bb870"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("5b5d90e9-b9ca-4877-bf80-57f0fd1a25a0"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("5b8e9206-e180-4997-9d73-52dfede0fd54"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("5bb207c3-1055-4b41-abed-c2d101bd9ed1"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("5bce2f29-80d0-4adb-bcf4-59a8c17bf7bf"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("5c285ccb-b01e-4460-a369-b85d1e1a31a7"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("5c8226a2-30b6-40ab-ac79-8b0b869eb73f"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("5c96ef83-16db-4b97-adf2-7ee9e900dedf"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("5cceddab-b39f-4141-bb2f-e3f6bc1e1eca"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("5d2ae4c8-8f0c-446c-a254-3a0bbbd5770d"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("5e392907-0a1f-4343-a5ef-17a5a164d8dd"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("5e56eb12-ee71-45ee-a5fa-d2c1517e23b5"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("5ed4b514-2e29-409e-bc98-18474ddede96"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("5eeb8469-d9d2-43b4-8cad-7f5a89bd14bb"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("5f053f86-5955-4776-b7e0-e83254d4992d"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("5f0e0f3e-4a6c-4501-8ac4-38cd26c2e001"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("5f909831-3c75-486d-a6fc-56ff80f99aa3"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("5fd7e22c-e9d5-467c-b8e4-5b10ea386712"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("5fda9076-9829-4255-8f66-66464f3d3b75"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("603f8516-98a1-4083-8616-f84b0f164854"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("60a8d8fa-4291-43e0-9f87-c8edb178e9aa"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("60e43b4e-edda-41be-b03f-a86c3bbd1164"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("60fc49ca-5f27-48d0-b378-3398f2eae19c"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("61cc01f4-c4ab-485c-a9f4-746c2f78a908"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("61d39ea5-788d-4b4a-9db2-97190d33d86b"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("62058d24-770b-4895-86a8-09fb25a01746"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("6228bd28-fec0-497c-981c-6ec25667ad60"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("6230ea89-5065-4b5d-859e-0f29c20a1ab4"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("6250f1e8-c32c-4b85-9281-41c57a8f2974"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("6258abe1-599f-4eec-b6af-b3e0517452ac"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("634ef4cb-d5b6-48c5-82a9-17f47bb6af4b"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("6351ab89-27f0-4ebc-9cf6-b65c585d3223"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("63790b3b-fc8c-4803-ab04-e2f1392964e3"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("646c11f7-7031-4663-a397-4888678436b5"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("648c85db-c850-4e7c-84bf-bf16cb2bdd3d"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("64b80f42-3962-4d77-b21f-eff3c41a89b4"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("64e15ea7-3bd0-44f7-9ee1-09e935cd2705"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("650cdfb8-9a9f-4d47-af50-bb9b4e4d0a0f"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("652294dc-63a1-4ca0-bf40-7787f12fa829"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("65351b17-0e4b-4195-8510-8ce8c38c25f4"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("65826fbb-104f-4a96-a035-8c0a1730e0f6"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("65cb6eba-c577-4adb-ac74-816152d06767"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("65fc56a1-0c3a-4ee0-b146-ac743e89aeec"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("660030dc-9f42-4005-856f-63165e497bfb"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("66645cf0-82fe-4edc-aea3-1725256806ab"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("6664e884-c0d8-4ef1-974c-bf7759d28af9"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("66a6128f-fbc8-40ba-8f56-0841cd0bfad6"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("6716fda0-e534-45a4-a975-9c935479fd7e"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("67967b02-cf84-4244-9f79-0c3d82474b60"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("67bc1e36-ac11-4146-a9e7-00ec2a611ca1"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("67f46469-fd8e-4398-8861-770c503d1590"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("68450ef1-cfec-4c65-a24f-4a430777aa9a"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("685d023f-9218-456f-a152-a0bcdc999eef"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("689a9d52-d731-4a94-a634-c010df51b6b0"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("68bda25b-d2de-4325-aa04-8b6c8be43259"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("69b4f072-fda8-4b5e-b7b7-62c83801553d"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("69de897b-e444-4ce5-b039-a1f4b077940d"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("69e68c96-2e4a-485c-8971-5591c8cfaf7e"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("6a4a4a2b-19c8-406c-93bd-12934dba0076"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("6b602ce5-72e4-4a24-97c8-38a0ce9f5ff5"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("6bd7dd97-41cb-47e4-9c82-20b89986465a"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("6c22351c-1597-422e-abc2-c45320770207"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("6c412e8a-7345-4d8e-b36d-cd02d410869b"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("6c5540a6-dae9-4a68-853f-642f1700fcbb"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("6ca3e4d3-9a58-4e4f-b84f-0acc129f4085"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("6ce2af07-4370-42dd-a053-b1b6f3f08923"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("6d3670c3-6322-4d3a-b766-f0387ffc126a"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("6d3cdff2-e3d9-4519-8124-beb96a51d2be"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("6d878322-5988-4eaf-b77c-a125d9bb41cf"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("6d8b1329-fd91-4b25-a9d0-cb2d487f8e82"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("6de4c473-6c9e-4601-8d84-d711caf118e3"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("6e042dca-16c1-44fe-ace1-7b0e49a9fb6c"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("6e118b05-33dd-496b-a127-be07999413c9"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("6e31647d-af45-4fce-b490-bb44b60feff4"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("6e5c6b91-6ae2-4804-9e56-6fa2834c8a58"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("6f613c2a-ca27-46a1-8521-a2ac43527fd6"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("6f63352f-4d6e-4e93-b24c-afe00751cf1d"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("6f8e58b4-4110-44fd-83d8-655ee2ea91e8"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("6fd864c6-a7c3-4814-9bff-3942773de67e"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("6ffcf025-f118-484b-a995-7b435887f0e6"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("706dd9dc-b416-456e-b0c4-5b3ad0b2b14c"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("70ae294f-cd6c-4c96-a605-6c6793ced309"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("711f68c8-351e-4386-82cb-7545f97dab45"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("7192b789-6281-4072-a82a-54af7d22c915"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("719f78a3-89c3-4d89-8501-b93d0b7e3e25"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("71afc361-9075-454b-82bf-ad451405d5ce"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("71edf2d2-fed6-45ce-a2c4-9b5eb22b4ab9"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("721c715b-9b71-4edf-9dd0-a50bcba5fc9c"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("72479571-41ba-4c64-9f58-678e711f2822"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("7248c679-e5d6-4cfd-8a6f-aaca82b1a090"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("72cff4f8-26e3-49c9-9120-d3cfbf80358b"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("72f45cd6-1122-4af5-8533-e58ee3c9546e"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("73334cbb-929f-4f25-9423-13fc6de7950c"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("73d58b57-3642-44d1-8fbc-cb6fae8d8dd7"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("7413fdbe-6be8-4b46-b649-f1fdb772725d"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("74207d90-adc5-4e51-920b-da7c4b11e2b0"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("74390565-f2ab-4276-9868-01b50718dca2"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("74721265-f028-4616-b7f7-72b28ac87a5c"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("748ef50c-eaee-4d5e-96c5-c6fa92c75da3"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("74b3ba45-58e1-4023-83fe-48299c96249c"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("74d63826-5bf3-42dd-b3d7-78041dadad5a"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("75397a4c-6dc1-4b51-bf87-41670d27752d"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("7569e159-b459-4a0f-85eb-f9d0f018b301"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("7580d18e-e0b3-4f74-b73f-44f040220732"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("759e70f9-ff9b-4c37-9a87-e957ec0cb967"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("75ba4f9d-ce35-4d34-ae63-580246d0d561"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("75c68d90-9990-483a-b0f0-ca9d4b5d7ceb"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("75eb527d-d791-4ec6-b48f-cda9054ac4c9"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("75fb272d-5dc7-43e2-817e-de373f52e305"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("760d66f5-90b5-4161-b3e9-44d29103ac58"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("7611a6a5-03e4-4738-b0cb-b5667a52cf3a"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("762ec938-616b-49b9-9c2d-c4d3408b8674"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("768b11a4-9a63-4c8a-9cf3-ef50efa2a9bb"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("76abb8a3-ba7d-4086-849e-6f6e2c7d7771"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("76faa7c8-19fa-43b4-90d9-1c2b4dd4a4f1"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("77b3adf8-bb55-4e4d-9c42-8357f229c505"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("77b56f79-77f2-4f29-896b-db213e9f0552"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("77cdf0f1-80f1-4046-83e3-f4e79808d15f"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("78370809-5141-4aa2-ace4-e607ca6a1d3e"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("7849872b-1340-43a9-99b6-308ea15b3b3b"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("7864b1bb-70fe-4544-b801-f243f7ae3ff2"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("78bde407-c45c-4703-8354-a432ed1b54ed"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("796262af-1270-4f77-9978-2934785f3049"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("797b7337-7a54-4610-af8d-0d0d96052b70"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("798deea0-8906-4ed2-bd44-3a2a80297401"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("79b69751-2d45-4e71-a91c-537d7a244f48"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("79ba705d-b2d4-43e8-a27a-615cfd176537"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("79f11dff-f3c8-41cd-8f96-7673c99f50b2"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("7a7c1b54-dc0a-41e5-80cb-ab7936ddcbe9"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("7ad16e42-ef5e-457c-8736-6e43a0c49ab8"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("7b0cf5d7-7e5b-4779-9b95-c8bc106a584a"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("7b37232b-b798-4542-ba73-649d7b75b113"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("7b38ebad-e9eb-4d46-a821-71843f682988"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("7b5bf3a8-9df1-4680-a8c4-93fe329582fe"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("7bfababf-8f69-430c-9325-63ca16da7416"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("7c72d8ed-2811-4ab6-9807-bd0c4ea09268"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("7d9dfd98-23d3-4570-9418-af4a894eb90b"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("7dab372b-58bc-4cfd-8db6-54338e1043eb"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("7dd834ee-7714-4679-b09e-f8a6ec6919be"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("7e0e3e40-a557-4f3e-a4b1-3ad00a5ec89c"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("7e31b952-5878-466b-9700-8af21e3bf56d"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("7ecc7fe0-73b1-41a7-ac36-53842bc1979f"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("7efbfaf3-9666-42ee-8b95-0d3ffa751988"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("80044896-f28c-4def-a6e9-3d7ffe70e261"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("80215557-516a-4e48-aba5-fcb57b041357"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("80c1ce08-d53e-4651-998b-3db57bd69c9f"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("816e9ec1-5d7d-4c33-b2fd-1a5d2777541c"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("8194fa6b-daae-4b9e-a334-21e115dc6668"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("81b74b30-9945-43f1-bdf4-879fadbe7477"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("81db0ee8-6cd8-4638-97e6-d17ae4e102b9"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("81dd3327-2928-4bc7-8963-0528f7b5cbbb"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("8275a752-e321-4627-b5bc-e43301309c6f"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("8285c64f-ace3-4362-8c8a-9d6ff15c9e40"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("830d958f-b1e8-4d28-96b7-a18916e97689"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("83384ac8-79ae-42e3-acf7-239dba3c58f9"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("8354ed1a-d1e3-4e30-8805-d687fba1e38b"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("83602b22-ccb8-4275-bcb7-5a102e030028"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("840a5915-963a-46de-b780-6f250ec7b287"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("84cc9a0f-0486-47b3-acf4-0a9f44da10a4"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("84d495df-de40-454e-ba03-58da7c1de911"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("84f3964d-bb02-41b7-b149-21905d119999"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("84f68d15-eb85-47a3-bc73-b7ab046e610b"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("853353e8-f6ab-43d6-87af-c80c252af907"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("85bfbea4-0c5b-47f3-b747-5f8e2749a694"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("85c04380-87de-4602-af62-6c88bc477cdd"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("85edf543-90e6-47eb-8c09-2f03e76b25f3"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("85f38882-d296-4dae-9392-f1e936d16a64"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("860c83c8-985f-4b9a-a616-6842472484a5"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("8636a76b-ed9a-401e-96df-8a3524b69bdb"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("8653362c-2067-446e-b7a5-25bc809d5511"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("86962328-2055-44f9-a38b-024cbc78d7fa"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("86b57b35-06a1-4622-9847-d1fda4297e30"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("8771fa0d-253e-4767-bd79-857e595e88e7"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("879570d8-5ffb-4398-9641-581bc2729c0c"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("87e498ac-fa53-4030-8671-0ff297094bec"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("88061ee1-501b-43da-b422-f3c6556bfb18"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("88831383-d195-4e0a-bdd6-e02d48f6fc0f"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("88b309d7-49e4-4de0-b74e-b836bbd4732c"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("88db4e1a-394e-49f7-9e11-e9cff55875ad"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("88dffeb3-c113-4010-a287-fa3a6080b961"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("88eddc48-aed9-4014-a2ea-60706fae4e42"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("88feefab-2117-48f2-a484-308d02992d3e"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("890f8e32-8421-4d49-b425-386222793036"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("89292213-c4e3-4935-81b0-4267dd3fae20"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("894d4ef9-aaed-44bc-9287-c288dcad29cc"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("898ac5dd-bedb-4bb8-a321-888fa341ab4d"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("89f244a8-c60b-490f-bc37-489ee1795e67"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("8a156628-52ec-4441-a7f3-1db5af857d53"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("8a2aee91-9671-47b1-827c-9a7e0138094e"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("8af7dadb-d348-4b1d-9733-2a8851df4323"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("8b1e9401-cf98-4a66-80f0-438db4baa691"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("8b2ec7f4-fa77-4df5-a847-946a0a414df8"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("8b6f0e3b-f605-416e-a6be-a871a64ff9ff"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("8b856379-54a2-48b0-8ddd-63a0b9200f56"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("8ba8f90f-bce8-47a2-adb1-ea96893ebc82"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("8bdf47fc-7f32-4ea7-a1e8-b077e36e8dc1"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("8c08e9f1-04d8-4dc3-8a4e-7bc995f235d9"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("8c2850a3-396c-4675-888b-c6536fe3a915"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("8c5462f5-664a-47fc-8ac8-744d8b23ad06"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("8c7ac863-10e7-4ede-a638-598c21e35b27"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("8d0a136a-11bd-4f08-b658-49001401a165"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("8d5fc879-8fa4-4bb1-8b0b-bd2eabcb273a"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("8d742769-5010-46c4-9160-00cc14023c53"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("8d7fbb1e-6bd2-40fe-84b9-30a1a0379a32"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("8dbbe074-ceeb-474e-9752-8bebd530cec2"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("8dbd822d-372f-45e9-9b89-bc97350803b7"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("8dce4586-acf8-4690-8282-2c29f0822312"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("8e85d88b-b981-4757-a69a-210496a230d3"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("8ed6609d-8f59-4d4e-89d7-671cd391afcf"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("8f054124-273e-4a2a-9c75-08abcf57be91"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("8f9e2620-682e-4a60-b0d7-c037ada70651"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("8fc34687-136e-4154-82d5-0db4c4c0a8a2"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("8fdec7bc-7320-4597-831d-65521cf37b8a"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("8ff29034-1960-4ab5-8d38-28e657e3c944"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("90b4e078-9680-4075-81a8-2c4620dad7ec"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("9144c0ab-95aa-4ace-81f4-1fb47f7a6b6f"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("918ff981-0258-4dbc-b42b-ebbeeec6e46f"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("91b97d71-054e-4b3f-8e01-26f7e2f02376"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("91f4ab07-694c-45dd-85cf-6559abdbc209"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("924179bf-36d3-477f-a8ca-73712a015197"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("924bc147-40ba-4ca4-bc5d-bc67fa6547f1"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("9315e97d-4147-4b2b-bac8-71fe78b72eab"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("9364750d-0b35-4f12-a518-f5afa8c42bd7"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("93653ac2-6cf5-44a6-aab6-95b5a71d7854"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("93654454-1728-48ac-96d0-ae477553c5f3"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("93876abd-2387-4e42-82fa-cf6784321d90"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("93c2bf4b-1276-421e-9714-ab7d7ccb0056"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("93d40004-8626-44eb-996a-19f3cb56ec12"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("93f116aa-f786-4bc6-be79-56c18347e88f"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("93f1523d-1318-4604-ab78-f4e0199d313e"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("9413a8ea-7dc0-41e1-8c02-4e3893cc2830"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("953544ce-125c-4cab-af7e-5d1676cbf679"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("95cac3cd-63dd-4e99-9e47-a1703442ec93"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("95d7417a-1db8-43e6-bc9d-e80d3405db5b"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("95e77a81-d710-493e-837e-9159c34c1e29"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("95f14ea3-2815-4ba8-9824-3293921df6cc"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("961fcf8c-d6d8-4293-82bd-5345ef0ace51"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("962c55c7-ceb4-4f83-bc72-3ceea47e121f"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("96c617cb-ed47-4a13-b932-02c9d2a1a75a"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("971eb844-2ad5-43dd-b1de-b600cfb5f7e1"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("97615ef3-6b3b-4426-9e33-90250ef87721"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("977865c9-21cd-48c6-80a2-4e76878a546b"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("9781b577-086e-4148-a134-a71b5f64c5c7"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("97aa0076-f9a0-424d-9875-1075baba3b43"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("97cd8b1a-1293-4556-a21a-81f7a859a666"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("97f59e8e-3cd9-4253-8133-07dccf73105d"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("981faaf8-03aa-4514-93d0-b29d15291a82"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("982dce94-698f-4f1d-9dc4-b7cfbc118f1b"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("982de2d7-70d1-433b-8a48-a2079622f4d8"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("988beb1d-fe17-441e-9658-206f8209195f"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("98e69c72-e729-46eb-ad77-2b1a5e776379"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("990a1ec1-3bec-47fc-8a4d-ba3420f8df59"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("99785aea-4aa7-40bb-ae83-94a6056dfdd7"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("999e7726-1351-4696-8ea9-7c3e72f57eee"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("99a19ace-b24c-4be9-9ba1-f5c88ba54729"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("99b3535d-1715-45eb-a5b9-2b8f17081fa5"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("99b9945e-e662-4833-a85d-2ef1aec3d449"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("99e05c4b-f0b8-4cb0-972f-62b7a07b37e1"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("9a074c89-156f-4ff5-954e-dbdf3e381f34"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("9a331a21-55a9-4a15-bdc0-9547b5d5774c"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("9a61cc62-8aaa-417f-99df-1ea761bdbaf8"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("9a98d4cb-e6b2-43be-a8b8-77a544ea6304"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("9a9c8806-8634-43c0-bc18-6651710bfc59"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("9aa05667-1466-4173-b6a8-59a60e3d3fdc"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("9b93d102-bddd-4aa6-9170-95aef1f02aa0"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("9bc56e27-cf34-47a1-9fc4-805b11ad4b83"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("9c253313-e74a-4a24-8b2c-60b8bc3bd42d"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("9c4224e1-4efb-4eaf-817f-6f438fdefc6d"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("9cd1f3f7-a316-460a-abbb-992191640ef9"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("9cd5c948-0528-4ac6-af69-8099105c83b5"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("9cd6fd73-5341-4326-bac1-62598101e1fa"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("9cf90b38-eb3a-408e-9064-5dd87f7a34e4"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("9d29a662-09e7-471a-ba05-7cf53ef4faaf"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("9d337e91-f0c9-447f-89fc-ec87ddb7da0a"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("9db27a10-84b6-4dcb-ab7c-08d37d4a1871"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("9e56a8b1-6fe9-4291-96e6-0a7a8b3a392c"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("9f081a64-4419-4da2-ae6f-285eef92fe19"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("9f1306a0-abb1-49a4-a110-8d37f4baa9d7"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("9f1393d4-1284-4f35-8669-d5477c6dddde"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("9f5f0e41-b123-4a71-8daa-6224be7227a5"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("9fb2e399-2d2b-474b-b2d0-034d72dea455"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("9fb74888-ecc8-4144-9048-5005929728e5"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("9fbce7a7-b677-44df-893e-6fc9cce35364"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("9fdc0498-1fd2-43d1-bfb3-320ea8df16de"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("9ff57056-0262-4e97-a1ff-dec2dd038a20"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("a00be3eb-c151-4e21-b291-a327fcf56c98"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("a06502d8-eea7-4f60-9f19-85666c6e3910"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("a0db3d61-bcf1-40b8-ade3-3a4e0b87e087"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("a0df98f2-3f5f-4327-a5fb-4e9f00c99419"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("a2ee56a9-9b89-4b94-92c2-1b04d8aa3b5a"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("a30a509a-05f8-470a-891d-4e7be8f5b658"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("a3bdd8c7-827c-4079-83c3-bae97457413d"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("a3c51b58-a2c9-4831-91fd-95e281bacc83"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("a40f3b2d-9051-4728-898b-1be6832b2c60"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("a52de9e7-f453-4781-a3f5-0c265e07f9bd"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("a566254c-7d1e-4ca0-a7fd-f3d76ee54122"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("a58a924e-c200-42ea-8641-6f3732f3a13f"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("a599905e-3b58-4a2d-8da8-f6ef83a7425b"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("a5de9a15-fbfa-46f3-870e-cf721389e887"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("a5f0bcd5-9865-46f9-ad4c-a07af6bb60d6"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("a6e7c7a4-49df-4432-9702-f597456fd9ef"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("a756f25a-8caf-4c6a-baae-1882fe91b55c"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("a776c653-1a3c-4a61-9d2a-b93260555aae"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("a7bb84bd-d6fa-4d1b-8f8e-ac9792589405"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("a7eabf58-c8ff-45e5-a144-999be75f2c0f"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("a809c0b8-562f-46a4-91b0-b7d95dd24394"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("a887ea1c-9b78-4e7b-8a89-f30fbab84430"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("a88da33d-3f82-422b-802a-eac2c2ffb7d8"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("a89051d4-da8f-4ae5-970c-fd0dbae96a49"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("a8d815b3-89f5-47e8-9f28-a143c347eae7"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("a8ef2636-c8f7-44e4-b88f-5f3eacb99528"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("a9d61991-329a-4b25-8f5e-a51555cbffa9"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("aa3986b0-893b-4c1c-ac9e-d481cb123581"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("aa50f344-33c0-4e92-8e7b-033eaa48d31e"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("ab2a034c-9122-4e7f-8380-f16a3de57160"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("ab2e5a6d-7755-484f-85cb-f75b8410d854"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("abcbcab2-6958-48a3-b155-763343272521"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("ac028b62-be26-4677-a823-1d59a1b5272f"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("acc787e5-e801-405b-8a85-fe133c1664d6"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("ad13fe29-1c2c-4d43-b188-bc4daedaf787"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("ad17e5b7-b827-4941-aa35-b4fabd83ad73"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("ad8e9857-8ec9-46c0-bbe3-d7fda1fb5b60"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("adcb6495-f200-434d-a98e-c16934c14958"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("addf3b39-9959-4a9c-af47-72b9a8434623"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("ae16b851-5350-464d-8664-ddaf004a219a"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("ae241fc4-8945-4271-b530-6855bfbd11b7"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("ae5842aa-22fd-4a23-bb31-747d5458c611"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("b0f26694-fdb6-4022-8f06-79b6a9dc40df"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("b1516396-a360-4798-a99c-446ceb0332d8"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("b15dfaac-e4fe-49fd-91bf-a085700b1b2a"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("b186cf9e-d40f-4f09-bae2-db439df6567b"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("b1ac42fe-3003-4751-b5a7-bb3d8036849d"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("b2553ae6-e1fb-4f1e-acd8-d894625c6c50"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("b2657a99-1125-43bf-845b-2f98d2671d0e"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("b29c7b5a-7242-43b6-bebb-30f54349a7f9"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("b29ff4b1-fe79-4833-a2a3-9815dcf4e7db"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("b2e87d6c-558d-47b3-b68a-a925a7efc718"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("b2ec7e16-c5ef-427e-b86a-6665d1c9f89a"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("b3165af6-9097-4bbe-9d2d-50131f40ad3a"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("b354e891-b0f8-4a5c-8003-4277ddaa1a6a"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("b36b9f56-c677-4e4a-906a-f8d9d538f5a7"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("b3887c33-fc0f-43d0-8476-389da9a0aeea"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("b3a9460a-d4e7-40c6-8123-b77cc3610157"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("b3f938e7-9189-4759-a633-d07296bec8de"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("b43e1d62-9d83-480c-961b-b06926933910"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("b4886fc7-74da-4dde-aebb-ce9cb369afd7"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("b52b795d-3019-4527-9781-99ae0667f3ea"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("b548f369-dffb-48ff-b0f7-547a2337cf35"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("b5612ad2-f4e4-4cca-a9ae-648c529f5c24"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("b5bca4d5-b34c-4c38-964f-44dea0d9e46b"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("b5ccb6aa-3f62-4e24-a9a7-3701a8aa88d0"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("b6bf0ac7-bc31-4943-b3cc-8244f5b41477"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("b706b2ed-337a-4553-857a-335410e97b08"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("b7830563-d205-49ad-bdaf-7180f3404a68"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("b7cd2567-879a-46bf-8aa9-2c69e014009b"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("b7d15400-1b12-4e9e-943e-16a866acef0d"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("b83049d7-f6b8-4dd2-b08a-d8a046c5208e"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("b84eb5cf-f890-497e-a0b2-a00259da5013"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("b887252c-b30b-4d39-a9bc-00cec0f74e2a"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("b8a733c1-7bea-4789-bf05-ebc6556342b8"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("b8a76934-05ca-4dea-af55-87740674f27d"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("b8d8e41e-3dfb-4483-ad0a-5073995b289f"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("b8f2ec9a-1574-4ab4-bf01-8cb56c4bb783"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("b9e64d61-dd3c-4176-8beb-b98409eea65b"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("ba52a2f5-095c-40c9-890b-c4b6962e6636"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("ba75981d-682a-4ab6-a520-5622485dbbee"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("ba841147-de86-4b87-9f7b-b665bfc6dfc0"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("bab2ef10-cbad-43fe-8b65-bcaeb73d1439"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("bb2a4976-2816-4ca4-bed2-71c39ce3670b"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("bbba32c5-cfe0-4450-9a7a-3ee682bd4336"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("bbf0fbe7-c067-484e-acca-0bad6590eaa8"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("bbfdbe33-eb5c-4a2d-975e-34c802181548"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("bc1eab00-8a1d-4df9-aa1c-c8cd04d3863e"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("bc2274a6-3d73-4622-9a4e-5235d62744c4"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("bc5adcca-c2d8-45e7-b6ca-e7fd9c94f700"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("bc9a1a23-c9f1-4f14-8095-0da70b5f2558"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("bccc6ef6-82a4-4f1b-86ec-f60624090d2d"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("bcd93965-c920-4ca4-b2b6-ad022fd4cd25"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("bcf7e21e-80e6-4f65-acf2-f9eaafa4678d"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("bd25974e-d632-4417-9642-d1802cea6f77"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("bdd7ed2c-f278-4be7-9b72-c3fb648f6fd1"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("be8565f4-1c66-4d6a-b46a-556332e392a5"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("be86b5c0-57f1-4781-9117-8c31055b9b9e"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("be8d5aff-ede1-49fc-93a8-608e3ad1c9d7"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("beadccc7-ec9f-4960-9b24-ec3ea8199fd1"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("bf5b05f5-c23d-4f84-967a-bb603879fbc4"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("bfe3c1cc-9fcb-4680-b445-419cdf96927e"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("c000dd82-e39b-4a86-9192-53c0030fa4d2"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("c0419d64-9e1a-4904-b831-632dd7c54b7c"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("c0bd9717-e037-4052-affa-11a8e0d88715"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("c0d021e5-a77e-4095-a74d-ad7a77829611"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("c1684515-025c-4e42-b9fd-b0c017f597e2"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("c189c802-6bef-40e4-a5df-68ce1c5f50a1"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("c1d21253-415a-4caf-8e8a-7a8979a0d0f2"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("c26c55e3-0cc9-4604-a8ba-af0f7836fff8"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("c33c0044-c477-47af-a96f-352545e229a6"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("c34d791a-48f0-408e-bc45-7be8b4294a5c"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("c35adfe1-401e-492d-864d-8fb1e12892f5"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("c3cf7d66-9250-4650-ba5a-00eaa533977b"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("c405750e-acaa-4dca-8737-21d4035306a2"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("c407d805-f4ad-4694-a085-3ced18a195c2"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("c410c9b1-25cb-4c9f-8a3f-23aa1b8a01c4"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("c425ddd3-20aa-4186-8300-bb43cbb594a0"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("c4fcd7c5-02fc-4162-8bd9-35ecee16d0b6"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("c50b22e8-2def-48d7-9a0c-d0b9299e0084"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("c59012af-0bff-41c9-a6e3-2b2cd99d0b2c"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("c5a6132e-e9c6-493b-b8f4-f17f22f0fa1b"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("c5d4c91c-7de3-4a10-88ed-f751f4c73e18"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("c6d4ab13-45b2-40f1-b249-030003bb4444"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("c70b1e00-e17a-4e90-aa42-488029fab557"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("c7f6b056-2f58-410a-9822-c1b3350b2270"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("c83df9ac-5f67-4931-a918-631811b3ffd5"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("c8618817-c97b-46ff-b193-e84f59020ab4"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("c87be492-acc5-4bd3-aa26-a706e3c526a4"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("c889e72c-1986-487c-a445-3edd7efde433"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("c8c7f157-4001-4d6b-9f9c-62b97077e3d0"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("c8c8f9dd-083d-425a-9cce-e95083a39684"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("c8e5e590-d30e-4b72-8503-fbb69d2ecc85"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("c942651b-4f95-47c4-8500-2efdb6220e93"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("c9e7734a-1924-4dd9-98d3-6b3ea8b3c8f6"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("c9ed6e5e-0a45-479e-9fcc-1840c15a3621"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("ca0e73de-9ef6-4f3d-8071-45aab0d94692"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("ca47d382-f31c-4146-ab23-337d866806cf"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("ca6eae4d-10d8-46ba-b99b-32500c74d702"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("ca8764bf-18bd-4b65-9d60-ceda6c16b391"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("caa6397c-7536-4056-b418-1718728e80d2"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("cab8a7b7-fa53-4c3c-a05d-d57ca6e9b591"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("cb11c418-e305-4b54-9262-c7748da5591a"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("cb4d927f-8876-482d-9b3e-115ff9a7262a"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("cb7c9a3c-f950-4e22-b75b-bf30ea3844d7"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("cb89ba23-a192-4880-a574-e3720f849faa"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("cbf4019d-9b6c-4c83-bd42-cadb4871a637"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("ccea65d8-0711-4963-9876-ea22623a3b20"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("ccf12f95-7610-46f8-8017-c0e215c78e97"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("cd12a791-443a-416f-a4b2-bbf94ac83540"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("cdac9857-b64e-4801-8764-2bd30ed0da4f"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("cde54e6b-9013-4967-8815-3ae3e401a5d6"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("cec2c42e-19bf-4e61-aa21-d811ceedb509"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("cee3fcc2-7729-4e99-9726-062e46966226"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("cf124369-3808-4348-bbc0-6f184cbd94f4"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("cf24dc52-b017-4981-a432-57c4c3cb1eeb"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("cf59f674-89e0-4489-9012-f2f63763885a"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("cf6a6cb6-06c7-48eb-888c-518f3c79e011"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("d0255f41-bc9f-41ba-957b-63d2c5305f02"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("d0371a39-9b54-4a13-970c-9854160c0e10"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("d0980099-44b4-4547-9030-37dae193aa93"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("d1674c00-1f8b-49e5-ac59-c5c3c64801dd"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("d1819260-ef92-41ea-8139-44fa28fcb724"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("d19543d9-fb7f-404b-b4ad-8dd83f7c1f89"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("d1f874e9-b7ae-4037-9b9d-58842a57c76e"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("d20fb163-09fe-4bb5-a988-429fc3acaa9d"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("d2497b60-1289-4622-9ee9-504f98a4511c"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("d26f91e5-e24e-4d61-bbb0-0da0effd8d86"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("d2a08e4d-ec4e-4f11-aec5-2b4373a9a362"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("d342ca7c-34b2-45ca-a8b6-ffedac8ac1c6"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("d461ff43-8bca-4692-8af7-dd9fee0f4c6c"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("d48ad11d-dcf7-4944-81f9-39767bc49f51"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("d4a03dfd-59e9-4e01-a5d9-265d2ac3187a"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("d4afb42c-f655-4638-a0d6-3b2c9c3452ac"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("d4d1cced-62b9-4706-bd5c-cf0a0cb5a35f"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("d560f46f-9fe6-4ae3-9f91-4526f2db73cc"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("d57907b4-cebc-4517-b9a1-9750b34cc544"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("d5a66e51-e571-4688-be5d-288275a10ba3"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("d5de8da0-087f-4943-845e-1a060f33ac2f"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("d68a3316-2cbf-4110-940c-7e38188000fd"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("d6910c44-68f4-4022-8465-35f1f8f4782a"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("d6944403-884e-4b1d-ac87-b183ab87f4be"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("d6c2ceef-c459-4694-9900-8aaf87a1d634"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("d6ce8949-0682-4982-bd18-c34f6b3cd087"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("d6edda6b-c394-4dd2-b5dc-7935e285cd4f"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("d74b1a11-c55a-4ce1-99b3-d15abd5b914a"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("d792f546-14d0-4904-a62a-0e9b4f0a5117"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("d7cff48b-41ae-4205-97b7-c200864b7f49"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("d83e4edb-253c-4a0b-8c40-84fb17fb7063"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("d868ec68-61e5-4eb5-9f49-6d4969ec7dcc"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("d91017b6-3c3e-450a-8309-ff6c21b866ce"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("d931c600-b4ac-4bd8-a89a-a1c194a3cee7"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("d966969d-01aa-41c4-b8e9-c181fa3f078d"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("d97c295a-b628-4d26-9322-beac7c6c0d55"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("d988297d-a949-4b8e-8510-d854595f6438"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("da0cd4d5-bbf0-4b4b-b933-06ed3c948a04"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("da2195fd-a432-41b4-9c3c-8f2fa5122346"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("da368ee9-b079-40ed-b1bf-0bab8dc80140"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("da8f856f-914c-4725-893d-97e94aa6bd5d"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("daa49ec0-34e8-4c3a-a442-49d261b7fe02"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("daa5599f-9154-47d7-b4fe-b4e0727971de"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("dae3e1f5-b61a-4c8c-b5e3-9b39fa14883a"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("dbb719d5-cc14-4dfc-bcab-934bdc9af0ca"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("dbb76c84-7a14-4a0d-bf8a-a21397691c81"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("dbf2696e-f42f-463c-a600-6c0a7073fc68"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("dbfa4d35-82c0-489a-96dc-557fa1a33773"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("dd0aeaff-8967-48c7-a1d0-12322d8ca502"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("dd88d0c4-40fc-405f-b7e0-8ad38442dd96"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("ddfdcfad-1319-44a6-9c80-8b9d01fa2139"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("de4b89b9-a5dc-49b9-93e8-6562e75802a8"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("de4f9f84-7348-420b-9b83-852aaa48a586"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("de9d7586-2c68-4421-a808-6014bfb1872b"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("de9eb270-252c-4155-bf95-67cfbc3607df"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("dedd2bb6-76a2-4296-8f8f-e02700c75dc3"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("df256477-e686-4ede-80f2-4f39e74c1732"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("df474d49-0e1f-4172-8bf1-d2cf65f5a124"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("df577e6c-af2f-492e-ace0-ab48e903cacf"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("dfa27c04-b387-45d6-a248-ed6145131ca1"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("e0907015-d432-4768-a5f1-d72c0da95f9c"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("e0b542a6-6e26-4d9a-b0c4-b5cb81375079"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("e121a5ff-bde8-468e-bc66-6ddcfc11f7ae"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("e1ab5ba4-b044-4352-8558-803608e32ed1"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("e1df31da-ca9e-4268-b9c3-455300e35600"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("e2835a6e-43c5-4feb-aaaa-b1032abb9362"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("e2f10f37-4f62-41a0-976e-e5d865924288"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("e4212067-e62f-4f79-8702-242b494eccfd"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("e456312b-de34-4ba2-8a39-749e64788c57"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("e4c4e28b-4ae6-433e-86a1-0a1bdc050991"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("e4d200f1-c597-4ebe-8c0f-69e5f432fdf4"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("e536c941-2eeb-4ae5-8549-9203f739d1b6"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("e53f2a1c-1399-43c4-b84b-fc0466b93d1f"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("e55b033b-c5c0-4aa2-9a14-ca5c5a81b368"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("e58379c1-f8fc-48c0-be5a-3899d0d01a57"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("e5857b3b-816b-4ffe-8b50-2ed947ca4f04"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("e5af651c-4dc8-4d3b-89e2-bf7e38ca1342"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("e5cb4e61-b265-436f-a588-554aafffc9c1"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("e5cd8a70-ed94-4a90-a536-9e9efb712601"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("e625acf5-ff3f-4e37-ade5-394402634cdc"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("e62d2034-b62a-4f1b-b1a5-68adc7eaef92"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("e6936dbb-d262-495a-b69e-81f68658b90a"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("e69ec96d-76b9-4c1a-b60b-78a7210654f0"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("e6eea030-1970-41aa-af5e-47c956763a3f"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("e72c03e0-0a07-46dc-b13e-91865f9a7fa2"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("e752b68c-f04f-48f4-957a-2b346f21e97c"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("e771e626-8835-4f96-964e-c70f0eb0d396"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("e7a307ca-cba0-4e31-9b53-d8a250d166b6"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("e83a6c78-6bc2-4e7a-be3a-a99cd9b307a6"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("e8672fb8-d00a-425b-be9b-9c21f65eaedf"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("e919b085-8c27-4862-a200-f921afc86bd8"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("e9b745d0-cbbf-4101-9110-30936b099c23"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("e9d1834a-9358-4f34-a1dd-88d9fe37b43a"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("e9e16159-c172-4f07-b2ea-08a017b843ab"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("e9e741e8-5918-46f8-8a06-1a03871aea2c"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("ea24956e-7894-42a1-b62b-edba2d23f353"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("ea62d25e-5841-4ee2-8dd4-f0ca9f428ffd"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("eae9f1df-9fa5-4008-b9e0-c660f9c10202"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("eb0a3404-0775-425a-88a0-c892ef6ea033"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("ebdda60c-c8c7-4071-9954-19487a40c50b"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("ebdf1b91-652b-4ba1-a317-ceee7420fe27"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("ec07210a-c0a3-416b-8779-c5e15df6203f"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("ec119c45-f461-455a-8ce0-879c4fa0a091"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("ec7b32ba-f778-41ea-a3d0-65b43a7a9e2f"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("ec89de68-137a-49f1-af31-dbc128669a4e"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("ecb43e18-5617-47bc-bd6a-50d9bf078a07"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("ecec12b0-8cf6-41ab-bcb0-6f7ba9d3a1c5"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("ed0ae3f7-68e5-4ca8-83a4-e317289d799c"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("edb078a4-e3e4-4cf1-a899-cb3398cb8739"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("edd92dd0-32d2-4683-887f-5075c97d8328"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("edfaf90d-126f-4047-bfc7-dc442ccaff7e"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("ee024dc6-0537-4e6b-9303-938164022cf7"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("ee763faa-4c12-4711-8afe-a460f822ffe0"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("ee8ec57d-5fb7-4bac-9b9f-6b7b3a6e2aa1"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("ee936606-938c-4d5a-849f-fb0dfc81f021"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("eee12b45-f001-4c7e-aa22-82a73d6fafc1"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("ef42d0ef-f759-4acf-8c7e-abfed41331f9"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("efc0bbe6-9192-486f-ae91-9ddae84c5dac"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("f00e0fb6-b4ac-48d2-b1e7-a395f6c2cf6f"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("f0189ff7-26a0-4f89-816d-c23284a8bbd3"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("f13ce7e4-9676-4976-86b6-86c562d74fa5"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("f18d2270-2b9d-40d8-8ef3-37abbb507269"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("f1bff78a-8857-4d1c-bae7-d87c57a6cccf"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("f256f8a6-cea3-45f4-83e8-646b411dc48e"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("f2adf655-3f9d-41fa-9584-ea35413dd6d2"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("f3064e1c-2b14-4737-80e4-015871041f6b"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("f3dd79c8-a8f2-4df6-931f-0f2f674d3e30"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("f435ca06-a9fb-4da4-9dab-9ca59215072b"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("f46d7a50-cf3b-4247-8e41-c80d644c8666"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("f4980282-ea99-457b-9cfc-15179cb33af6"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("f4a465fa-55c4-4115-83ea-f9f0d1633981"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("f4a553f7-6b72-4d0c-8017-a3900cd58c7f"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("f4d47766-42d8-4943-a3e6-13f4b2910a91"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("f54d2e12-48bb-4a8a-8c4a-37df6f6049fb"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("f5a477bd-ef41-4529-a309-33062f106e8e"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("f61582d3-a4d1-4ce2-8d70-591bc3678d1c"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("f643feff-bd40-4872-83fa-6038e03c628c"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("f67f1183-fff7-4d5d-b153-c5009be50844"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("f78d43b8-8c6f-47c1-9c22-333cde48e3d1"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("f82db68f-cec3-44f6-984c-4d2e95addf91"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("f8853fb8-e280-4add-9b96-e550715c31d6"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("f8bbe230-5183-4754-9773-0c8e968d67da"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("f8d46048-e7f5-4f0a-9c68-a21450046e81"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("f8e63b81-f325-4bd1-9303-152a5f5e79ad"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("f965f7f0-185c-414b-9014-fde0d59c8201"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("f9a68af7-aee8-4c52-afa1-9e65983be307"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("f9a88a08-d561-4496-afb8-9523aff40c85"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("fa16781e-ea41-4106-b5b1-ecb99c885afd"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("fa2256e0-7ca2-4c2c-a619-85d8b2e34a97"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("fa5d666f-85a6-4556-bd25-a09f0c328eca"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("fa6e5946-d80f-4f7e-9777-03599095d703"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("fab9972e-aff6-4a8b-ae0f-e9b55b33e725"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("fabfbfa1-b96b-451f-b8a3-1021594ed50a"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("fad8c608-318f-4ce7-8c02-c11a6c1b16ef"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("fb176ca5-dffc-47c3-9e3d-37244fa336cd"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("fb245602-af65-48da-8b8c-1522faf94026"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("fb6ffeda-bf47-48ca-a323-6a676b3359ce"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("fbd7ad21-e43e-4eda-9520-85119a6323e0"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("fc3acc77-32c4-40c4-8ccd-55cdd88e50c7"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("fc935aa0-62f6-4a9c-99df-645ddecf30cd"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("fcd1b550-9760-4f9a-abae-7d91d5dedd95"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("fcd29456-a016-407d-8ff4-7e425fe3e1c6"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("fcd59fb6-8af3-4938-a658-8651837316b8"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("fcd9eeb9-a01d-4983-8d93-67b3093f1bd4"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("fd7499ff-4779-45ff-8cba-28afcc53016e"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("fd78955d-faa5-4706-af1a-3fe307bfaeb2"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("fd9ae1f4-d4be-4c4c-8b1d-967bb5e74da1"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("fe096419-cb85-46ca-9303-cda3822106e9"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("fe259229-e08c-4b0a-9ec8-8963aabdadbe"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("fe5054df-3e01-4049-bbe6-c0f6795aa576"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("fe6b3f22-1151-4803-bcfb-7ab82d025e90"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("fe71aa79-a9a7-40e3-9bbe-2a5997df2f76"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("feb4107c-d837-440d-9a69-ac3d0864996c"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("ff1fb975-23e1-419e-87de-380687888f15"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("ffd0e9bc-e79f-427a-bc03-73db8e18be01"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("484d700c-6ad8-4f37-be6d-14dacb11597c"));

            migrationBuilder.DeleteData(
                table: "ParkingLots",
                keyColumn: "Id",
                keyValue: new Guid("0ada6bc9-6665-49b2-a427-5ad008b51fda"));

            migrationBuilder.DeleteData(
                table: "ParkingLots",
                keyColumn: "Id",
                keyValue: new Guid("188984fb-f6f2-43a8-8f42-5761cf166a56"));

            migrationBuilder.DeleteData(
                table: "ParkingLots",
                keyColumn: "Id",
                keyValue: new Guid("19bcc6b0-45ed-4845-b411-400d4f6683b2"));

            migrationBuilder.DeleteData(
                table: "ParkingLots",
                keyColumn: "Id",
                keyValue: new Guid("1a0fc976-15ce-4e8e-9ce1-e01456178b41"));

            migrationBuilder.DeleteData(
                table: "ParkingLots",
                keyColumn: "Id",
                keyValue: new Guid("257b5f9f-b092-41af-beb1-2a2808fe0fc8"));

            migrationBuilder.DeleteData(
                table: "ParkingLots",
                keyColumn: "Id",
                keyValue: new Guid("2848fcc2-f6b3-4b91-a829-47543cd6f877"));

            migrationBuilder.DeleteData(
                table: "ParkingLots",
                keyColumn: "Id",
                keyValue: new Guid("2cde977d-867d-40de-9a10-432b2301464c"));

            migrationBuilder.DeleteData(
                table: "ParkingLots",
                keyColumn: "Id",
                keyValue: new Guid("31faa74a-240a-4f20-a8e9-fc79657b09d4"));

            migrationBuilder.DeleteData(
                table: "ParkingLots",
                keyColumn: "Id",
                keyValue: new Guid("322b8d0b-4524-4cd9-b4e5-1312d61fa572"));

            migrationBuilder.DeleteData(
                table: "ParkingLots",
                keyColumn: "Id",
                keyValue: new Guid("387a98b1-c216-4873-9812-b12a9aca5ac7"));

            migrationBuilder.DeleteData(
                table: "ParkingLots",
                keyColumn: "Id",
                keyValue: new Guid("3d85c54a-5fcb-49b5-a370-4c5d3216ae4f"));

            migrationBuilder.DeleteData(
                table: "ParkingLots",
                keyColumn: "Id",
                keyValue: new Guid("59e5fd81-c04a-450d-bdd6-c36e80361881"));

            migrationBuilder.DeleteData(
                table: "ParkingLots",
                keyColumn: "Id",
                keyValue: new Guid("59eb481c-e88b-4a04-93c8-aa9fad3b8fbd"));

            migrationBuilder.DeleteData(
                table: "ParkingLots",
                keyColumn: "Id",
                keyValue: new Guid("5db7d818-7b21-4b81-8cf8-99d99ffaf375"));

            migrationBuilder.DeleteData(
                table: "ParkingLots",
                keyColumn: "Id",
                keyValue: new Guid("610d361a-c14c-4e3a-9ddb-700cd803bb7d"));

            migrationBuilder.DeleteData(
                table: "ParkingLots",
                keyColumn: "Id",
                keyValue: new Guid("635a063b-8794-4510-b61d-899c3b425034"));

            migrationBuilder.DeleteData(
                table: "ParkingLots",
                keyColumn: "Id",
                keyValue: new Guid("6caabf59-5600-43f0-98c9-ab24acf0dadf"));

            migrationBuilder.DeleteData(
                table: "ParkingLots",
                keyColumn: "Id",
                keyValue: new Guid("6f8b493b-9523-43ba-9a39-6080882550be"));

            migrationBuilder.DeleteData(
                table: "ParkingLots",
                keyColumn: "Id",
                keyValue: new Guid("70713bfe-20a7-4b8e-bcc9-7cd0e57ae2cf"));

            migrationBuilder.DeleteData(
                table: "ParkingLots",
                keyColumn: "Id",
                keyValue: new Guid("7140654e-28d2-494f-a602-8bb6bff2fc13"));

            migrationBuilder.DeleteData(
                table: "ParkingLots",
                keyColumn: "Id",
                keyValue: new Guid("7b821087-607f-4dd9-a07b-18f22d1c8fd8"));

            migrationBuilder.DeleteData(
                table: "ParkingLots",
                keyColumn: "Id",
                keyValue: new Guid("85611762-85eb-4a9a-a993-dc85d0a68cca"));

            migrationBuilder.DeleteData(
                table: "ParkingLots",
                keyColumn: "Id",
                keyValue: new Guid("86f938e1-046b-4c2d-80ba-6eb7d3f4b2b9"));

            migrationBuilder.DeleteData(
                table: "ParkingLots",
                keyColumn: "Id",
                keyValue: new Guid("8886b676-b97c-4d0b-ae45-d18b2f2df900"));

            migrationBuilder.DeleteData(
                table: "ParkingLots",
                keyColumn: "Id",
                keyValue: new Guid("930245a8-ee38-4501-a6ec-b31839348aaa"));

            migrationBuilder.DeleteData(
                table: "ParkingLots",
                keyColumn: "Id",
                keyValue: new Guid("9c6c5b2a-00b3-448c-81cc-a9010d2d4196"));

            migrationBuilder.DeleteData(
                table: "ParkingLots",
                keyColumn: "Id",
                keyValue: new Guid("a8827db7-700c-4e56-94f6-2a77e3f61a9c"));

            migrationBuilder.DeleteData(
                table: "ParkingLots",
                keyColumn: "Id",
                keyValue: new Guid("ae16885c-9a8e-49a8-b817-0be9a9960d0f"));

            migrationBuilder.DeleteData(
                table: "ParkingLots",
                keyColumn: "Id",
                keyValue: new Guid("b26c6185-7128-4959-b92d-665002dce200"));

            migrationBuilder.DeleteData(
                table: "ParkingLots",
                keyColumn: "Id",
                keyValue: new Guid("b75467ff-4404-40c1-8269-b787f50a14dc"));

            migrationBuilder.DeleteData(
                table: "ParkingLots",
                keyColumn: "Id",
                keyValue: new Guid("bcf6224b-83e4-44b6-84b7-9a5b11f6f78d"));

            migrationBuilder.DeleteData(
                table: "ParkingLots",
                keyColumn: "Id",
                keyValue: new Guid("c23b858e-6380-4605-81ed-fae4578261ea"));

            migrationBuilder.DeleteData(
                table: "ParkingLots",
                keyColumn: "Id",
                keyValue: new Guid("c4fb855c-c3fd-4224-909c-e4cb4ebef275"));

            migrationBuilder.DeleteData(
                table: "ParkingLots",
                keyColumn: "Id",
                keyValue: new Guid("c5174f79-1a96-4d56-ae5b-b089b385e4f5"));

            migrationBuilder.DeleteData(
                table: "ParkingLots",
                keyColumn: "Id",
                keyValue: new Guid("cf8ba59d-1e62-43aa-b128-f92651d868c4"));

            migrationBuilder.DeleteData(
                table: "ParkingLots",
                keyColumn: "Id",
                keyValue: new Guid("cfba1888-af59-40c6-bf90-ff89882538a3"));

            migrationBuilder.DeleteData(
                table: "ParkingLots",
                keyColumn: "Id",
                keyValue: new Guid("d6240ccd-9331-4c53-91af-3b1992316096"));

            migrationBuilder.DeleteData(
                table: "ParkingLots",
                keyColumn: "Id",
                keyValue: new Guid("dab1d406-ad92-4844-b279-1cd9dfb40639"));

            migrationBuilder.DeleteData(
                table: "ParkingLots",
                keyColumn: "Id",
                keyValue: new Guid("e2826ba2-5ca3-4ce6-ac50-811f085e3cf6"));

            migrationBuilder.DeleteData(
                table: "ParkingLots",
                keyColumn: "Id",
                keyValue: new Guid("e3c60e04-8b6c-497d-b040-30019f1951fe"));

            migrationBuilder.DeleteData(
                table: "ParkingLots",
                keyColumn: "Id",
                keyValue: new Guid("e5cb274b-9061-42f7-aff5-97663074409e"));

            migrationBuilder.DeleteData(
                table: "ParkingLots",
                keyColumn: "Id",
                keyValue: new Guid("fd6deed8-c835-4168-8d92-abafacbe20b6"));

            migrationBuilder.DeleteData(
                table: "ParkingLots",
                keyColumn: "Id",
                keyValue: new Guid("fe188580-6e2f-4ff8-a49e-814745f688b7"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("0077f4a8-8e98-4418-8eb7-acf2acb45cef"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("00d2ea3c-ac48-4184-a0ac-83520d1c4a07"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("075a4151-cfac-4a57-8ea6-72a58f7eb6a9"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("0c3190ce-850b-44fd-ae97-2593ba8e8e0a"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("20053e0c-51d9-48fb-be65-5ed30339b790"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("2b407f1e-e79f-413c-8eff-28a83cea14a0"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("2f163448-a190-4625-bb5d-947ba1e44e6f"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("300d2cb5-44ee-4359-9ade-f7f4120a71aa"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("462bd796-becd-4120-b6a4-4bb292338b3a"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("57300731-216d-480c-a66f-6b4ccedb7251"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("58ec4fcd-d9de-494d-b983-a39bea7aa744"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("79af75c8-8526-467e-a18a-1b19a93556b8"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("81d709ef-b8dc-4968-9125-2f2755b849da"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("8f294424-44fa-4721-8748-d868f1b18a09"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("a4af20dd-a7ca-479b-81f8-b3b49b8c9cf5"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("c8d1d942-113b-42da-a308-4f254b946cbe"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("d0379d39-5d26-491b-9f8e-08b553078665"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("ddebcb2f-712e-4529-bd78-199f9c8aaad7"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("e57b0e65-fc13-46d7-87fc-86df83e84ea7"));

            migrationBuilder.DeleteData(
                table: "ParkingLots",
                keyColumn: "Id",
                keyValue: new Guid("38633289-34c0-438f-b007-976f825ec000"));

            migrationBuilder.DeleteData(
                table: "ParkingLots",
                keyColumn: "Id",
                keyValue: new Guid("3f771136-710d-4c9b-94ca-00b8c3abdd93"));

            migrationBuilder.DeleteData(
                table: "ParkingLots",
                keyColumn: "Id",
                keyValue: new Guid("495b86e8-5b8f-4f62-8ade-e8152d743878"));

            migrationBuilder.DeleteData(
                table: "ParkingLots",
                keyColumn: "Id",
                keyValue: new Guid("52688c85-e7f4-47e9-b9f2-d508de79f823"));

            migrationBuilder.DeleteData(
                table: "ParkingLots",
                keyColumn: "Id",
                keyValue: new Guid("5a694bc0-b3ea-4d3b-b228-1555a8738e1d"));

            migrationBuilder.DeleteData(
                table: "ParkingLots",
                keyColumn: "Id",
                keyValue: new Guid("891fbb4c-6ace-4cd9-ba70-deb2d06886bc"));

            migrationBuilder.DeleteData(
                table: "ParkingLots",
                keyColumn: "Id",
                keyValue: new Guid("8e054a25-6fd3-4e9d-b12b-aaa8e6ac85eb"));

            migrationBuilder.DeleteData(
                table: "ParkingLots",
                keyColumn: "Id",
                keyValue: new Guid("aae01dc0-240f-4c2b-85b8-db1d578305ed"));

            migrationBuilder.DeleteData(
                table: "ParkingLots",
                keyColumn: "Id",
                keyValue: new Guid("bf21db4e-8dd6-4bc3-9d0d-1e673e3c0541"));

            migrationBuilder.DeleteData(
                table: "ParkingLots",
                keyColumn: "Id",
                keyValue: new Guid("d09a2181-65c3-4ee5-b8b3-d4ea251a8fbf"));

            migrationBuilder.DeleteData(
                table: "ParkingLots",
                keyColumn: "Id",
                keyValue: new Guid("d65b48a9-6c74-44b4-aaf3-635151fa5984"));

            migrationBuilder.DeleteData(
                table: "ParkingLots",
                keyColumn: "Id",
                keyValue: new Guid("e21cdfc0-d3d8-47cc-8b74-bdf62436fcdb"));

            migrationBuilder.DeleteData(
                table: "ParkingLots",
                keyColumn: "Id",
                keyValue: new Guid("eb384a62-fea4-491c-a7a3-8a4e2c92b0c6"));

            migrationBuilder.DeleteData(
                table: "ParkingLots",
                keyColumn: "Id",
                keyValue: new Guid("f3297de4-ea7b-42da-993e-9ae374023e94"));

            migrationBuilder.DeleteData(
                table: "ParkingLots",
                keyColumn: "Id",
                keyValue: new Guid("f35520f7-2e5e-4340-ba78-c10259f8c8c5"));

            migrationBuilder.DeleteData(
                table: "ParkingLots",
                keyColumn: "Id",
                keyValue: new Guid("fc11e465-6669-4617-a41f-a1d1c76a908a"));

            migrationBuilder.DeleteData(
                table: "ParkingLots",
                keyColumn: "Id",
                keyValue: new Guid("fc2a8276-f127-4246-86dc-4d2b3262ed86"));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("9a07b7b1-38cd-4760-979d-83367464174b"), null, "User", "USER" },
                    { new Guid("f85a91b9-7efb-43d5-915a-b2f6644322fc"), null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedAt", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("d398d70f-259b-4b9f-b93d-f51254b9c4d7"), 0, "1234567890", new DateTime(2025, 1, 5, 21, 57, 1, 927, DateTimeKind.Local).AddTicks(9458), "faker@example.com", true, "faker", "faker", false, null, "FAKER@example.com", "FAKER", "1234567890", "1234567890", false, "1234567890", false, "faker" });

            migrationBuilder.InsertData(
                table: "ParkingLots",
                columns: new[] { "Id", "Address", "Description", "Latitude", "Longitude", "Name" },
                values: new object[,]
                {
                    { new Guid("11137c72-b421-4023-ad31-7d82db8a5baa"), "68459 Meagan Mountain, Octaviafort, Venezuela", "Sunt officiis atque.", 23.900563355995544, 89.098103896449118, "Frami, Weimann and Heathcote" },
                    { new Guid("1bc3d521-4279-4b9d-83d2-647d18bc7a50"), "9098 Schmitt Crest, O'Harastad, Lebanon", "Aut consequatur dolores.", 23.764901978364712, 90.431702825708072, "Kihn Group" },
                    { new Guid("1eb3a738-9981-4171-8de2-d3e857a3b8bb"), "624 Edgar Squares, Makennaside, South Africa", "Veritatis odit est voluptatibus id.", 23.89880226248242, 89.157122450331528, "Torp Inc" },
                    { new Guid("438cd333-aa34-4a4d-b514-bbdc4a0cb506"), "32957 Will Village, Rhiannonshire, Belgium", "Provident voluptatem quia eos veritatis.", 23.905679269257636, 89.128198190533794, "Cassin, Hettinger and White" },
                    { new Guid("55551648-de97-4052-9014-293666338e1d"), "33863 Queenie Dale, West Kaylee, Tajikistan", "Soluta eum veritatis blanditiis accusantium omnis officiis vel quis.", 23.756833311382731, 90.35726080378393, "Kutch - Yost" },
                    { new Guid("599951ba-457b-418b-b563-98eb4b0420f6"), "7407 Zulauf Ranch, New Deionmouth, French Southern Territories", "Laborum aut qui laudantium dolorum eaque explicabo illum.", 23.900288211189054, 89.153487009377884, "Abshire - Ankunding" },
                    { new Guid("5af99c7f-d6bf-4dce-9363-018315d9e1ad"), "124 Emilie Island, Coltenburgh, American Samoa", "Aut dolor quidem sunt.", 23.894818507718576, 89.117862087619528, "Tremblay - Thiel" },
                    { new Guid("603467e3-e23d-41ee-aaef-8d21b2e2da6b"), "59685 Trey Glens, Sherwoodstad, Lebanon", "Et sit consequatur laboriosam eum officiis.", 23.772947285597411, 90.362094094184286, "Boyer Group" },
                    { new Guid("6f263ffd-8bc7-41fc-a9a4-578f892bd452"), "5517 Predovic Valley, Rockychester, Samoa", "Ut ea qui voluptate.", 23.751263740371023, 90.372022422762711, "Kshlerin, Quitzon and Legros" },
                    { new Guid("723a9044-40fe-43ee-9f36-dbd4f21a4b90"), "53983 Zora Gardens, Demondport, Angola", "Sapiente animi et qui repellat veritatis officia provident laboriosam.", 23.743624782165838, 90.34226353545516, "Wintheiser LLC" },
                    { new Guid("736ed698-7b98-41d4-90d4-4d6f13415fba"), "175 Josephine Inlet, Lake Louvenia, Cyprus", "Labore similique culpa.", 23.902940336779345, 89.156390924470898, "McKenzie, Bartoletti and Murazik" },
                    { new Guid("81749d15-9afa-4294-85b7-82204495d265"), "3232 Brakus Wall, West Dulce, Belgium", "Eveniet libero corporis et ipsa quia.", 23.893829341886175, 89.144456795523013, "Wehner and Sons" },
                    { new Guid("8452e422-1d9e-418f-9b94-061cbe81e04d"), "8079 Goldner Mills, Daughertyberg, Bhutan", "Ea aut qui hic fuga rerum.", 23.905291846226316, 89.107496631704308, "Streich LLC" },
                    { new Guid("8c0a0b6c-ba87-4875-a11d-dec8b1eae16a"), "74059 Brisa Inlet, West Dameon, Oman", "Nemo non consequuntur reiciendis autem quia dolores.", 23.761253071565093, 90.3785750141367, "Schoen Inc" },
                    { new Guid("9309c264-dc77-4393-97d5-1f5277643f2b"), "37085 Torphy Points, Dietrichshire, Isle of Man", "Corrupti quae nobis non cupiditate odio neque quia sed.", 23.888139874304244, 89.105363633582513, "Mosciski, Schaden and Okuneva" },
                    { new Guid("99372c3d-5903-4a9c-b0b9-0cd15f55658e"), "160 Nienow Junction, Port Giannimouth, Micronesia", "Distinctio ut dolore quibusdam non omnis deleniti.", 23.787708507443416, 90.426134494549956, "Reichel, Kassulke and Kutch" },
                    { new Guid("a1282826-8649-4590-9393-4430b27b802b"), "79194 Clement View, South Junior, Moldova", "Aliquid cupiditate consequatur quas dolore iure est expedita dolorem et.", 23.76554802721731, 90.36037418390832, "Brown - Homenick" },
                    { new Guid("a669c2aa-41e8-4ff2-b1bf-6dc0ba156402"), "06157 Dach Square, South Ianmouth, Guyana", "Totam eaque minima facere cupiditate.", 23.768524660385644, 90.414733703091358, "Medhurst Group" },
                    { new Guid("ab78e541-dbbc-4124-bb86-ceb6d75cb71b"), "02746 Timmothy Mall, Danniemouth, India", "Aut officia eum soluta atque.", 23.784127554338557, 90.39718466533472, "Shanahan, Haag and Gibson" },
                    { new Guid("ac366bab-6ac1-4215-a22a-7241bb2c5727"), "57271 Shanie Mission, Kemmermouth, Estonia", "Fuga amet quod aut perferendis enim ipsa explicabo.", 23.889520505346635, 89.096545379650422, "Tremblay - Rippin" },
                    { new Guid("b185c801-7cf9-4792-925b-96f8471d9c99"), "475 Schmidt Spurs, Adolftown, Slovenia", "Nihil ut fuga ut ab corrupti veritatis ut ducimus.", 23.897798803476089, 89.138487792404533, "Keebler LLC" },
                    { new Guid("b5ce9eb5-9343-475e-922b-8d2d1494b13f"), "42565 Kiarra Land, Dockton, Montserrat", "Est ipsum cum est.", 23.885289636927403, 89.12732974193419, "Kuvalis, Haley and Lynch" },
                    { new Guid("cc8a4163-4cf3-467d-93a3-5dc0e15bab05"), "51132 Lowe Creek, Clareview, Seychelles", "Placeat aut laudantium hic enim incidunt.", 23.742025427583524, 90.438718627642487, "Schmeler - Turner" },
                    { new Guid("d62d31f9-9ced-4f7d-9ec5-e935519cd731"), "635 D'Amore Isle, Chelsiebury, New Zealand", "Perspiciatis perspiciatis corporis ea.", 23.777398128014298, 90.3699277040878, "Heidenreich - Hudson" },
                    { new Guid("e0bcde6c-3c72-4b55-a18f-f84fd8581131"), "94206 Hiram Club, South Fae, Papua New Guinea", "Vero aut excepturi quod ut rerum alias.", 23.734053666918001, 90.447389475029311, "Veum - Halvorson" },
                    { new Guid("e44df884-6d22-4568-ab33-be0090e61fe2"), "241 Lindgren Rapids, Theresiahaven, Philippines", "Itaque qui est odio odit.", 23.908522109707359, 89.129304856967948, "Cassin Group" },
                    { new Guid("e515ae1f-6859-4ea3-9dd9-8fb9d224f8c8"), "698 Chris Loaf, Ryanfort, Indonesia", "Nostrum consectetur quo ea voluptatem ea aut ratione.", 23.889311490115361, 89.141516414544441, "Frami LLC" },
                    { new Guid("e85ec22e-df00-4afc-b1fb-2ca408f15d96"), "4337 Douglas Lights, Port Rosario, San Marino", "Est nam eveniet dicta hic ipsam nesciunt omnis deserunt velit.", 23.761737079045925, 90.376794168228145, "Baumbach LLC" },
                    { new Guid("fcc43452-25c4-48cb-a440-1cc413ed3422"), "3347 Javonte Harbor, Parkershire, New Zealand", "Pariatur voluptatum aliquid ipsam neque quidem voluptatem accusamus.", 23.897761675443494, 89.139297778362888, "Rice, Sporer and Bogisich" },
                    { new Guid("fe712484-2abf-43e2-a9f7-e67b9d2f0d04"), "33545 Blanda Grove, Port Ilaburgh, Vanuatu", "Tempora animi aut qui nihil quia.", 23.762463811960391, 90.410589651410135, "Lockman - Dare" }
                });

            migrationBuilder.InsertData(
                table: "ParkingSpaces",
                columns: new[] { "Id", "ParkingLotId", "PricePerHour", "SectionName", "SpotNumber", "VehicleType" },
                values: new object[,]
                {
                    { new Guid("006e784a-f87b-49c6-84c9-0a769c97d1bd"), new Guid("1bc3d521-4279-4b9d-83d2-647d18bc7a50"), 300.0, "A", 3, "TRUCK" },
                    { new Guid("0198067d-e43d-4ee8-98ed-78cdfb16127e"), new Guid("e44df884-6d22-4568-ab33-be0090e61fe2"), 100.0, "B", 2, "CAR" },
                    { new Guid("01bbe8f9-0ccb-4115-8f43-5a74a1a194c9"), new Guid("1bc3d521-4279-4b9d-83d2-647d18bc7a50"), 50.0, "B", 3, "MOTORCYCLE" },
                    { new Guid("01d229fc-33bd-49cd-8e2d-e95d6db3ec67"), new Guid("e515ae1f-6859-4ea3-9dd9-8fb9d224f8c8"), 100.0, "A", 5, "CAR" },
                    { new Guid("01e2736e-8864-4a8a-929a-92bb5efe78fe"), new Guid("ab78e541-dbbc-4124-bb86-ceb6d75cb71b"), 300.0, "B", 8, "TRUCK" },
                    { new Guid("02000f84-045f-465b-bf77-1b8207703869"), new Guid("e0bcde6c-3c72-4b55-a18f-f84fd8581131"), 300.0, "A", 2, "TRUCK" },
                    { new Guid("0253a3de-d243-4079-976d-245d728db780"), new Guid("b185c801-7cf9-4792-925b-96f8471d9c99"), 50.0, "A", 1, "MOTORCYCLE" },
                    { new Guid("027038cb-1e06-4453-a98f-42409ebb20ab"), new Guid("8452e422-1d9e-418f-9b94-061cbe81e04d"), 100.0, "B", 2, "CAR" },
                    { new Guid("0362ad6d-909f-4566-b1f7-513f38428a9b"), new Guid("736ed698-7b98-41d4-90d4-4d6f13415fba"), 300.0, "A", 8, "TRUCK" },
                    { new Guid("03fb2d78-a73a-4901-a830-8b07fff08cf9"), new Guid("438cd333-aa34-4a4d-b514-bbdc4a0cb506"), 200.0, "B", 4, "VAN" },
                    { new Guid("044ec767-f877-4553-8a6a-8b104c345d6d"), new Guid("5af99c7f-d6bf-4dce-9363-018315d9e1ad"), 300.0, "A", 7, "TRUCK" },
                    { new Guid("0489e969-6940-4364-9928-19879c8a8ce7"), new Guid("ab78e541-dbbc-4124-bb86-ceb6d75cb71b"), 300.0, "B", 7, "TRUCK" },
                    { new Guid("04bc6985-a3b0-42b8-9489-8c51f2a767ad"), new Guid("1bc3d521-4279-4b9d-83d2-647d18bc7a50"), 50.0, "B", 6, "MOTORCYCLE" },
                    { new Guid("05797788-d09b-4495-93cd-61110c39b6d3"), new Guid("b185c801-7cf9-4792-925b-96f8471d9c99"), 50.0, "A", 8, "MOTORCYCLE" },
                    { new Guid("061c5a82-bcef-4987-a0ba-a5282df1be37"), new Guid("6f263ffd-8bc7-41fc-a9a4-578f892bd452"), 100.0, "B", 1, "CAR" },
                    { new Guid("0622f45a-5551-4cae-9f47-dfb7907c7e17"), new Guid("5af99c7f-d6bf-4dce-9363-018315d9e1ad"), 50.0, "B", 4, "MOTORCYCLE" },
                    { new Guid("064dfb5a-fef2-4950-ac89-4d4b76210538"), new Guid("438cd333-aa34-4a4d-b514-bbdc4a0cb506"), 300.0, "A", 8, "TRUCK" },
                    { new Guid("08ba6fbb-65b8-45bb-a8ef-fb29045bee85"), new Guid("a1282826-8649-4590-9393-4430b27b802b"), 200.0, "A", 7, "VAN" },
                    { new Guid("08ed8c7c-ba89-4f83-a9ee-25e6c186f6e5"), new Guid("81749d15-9afa-4294-85b7-82204495d265"), 200.0, "A", 2, "VAN" },
                    { new Guid("08fce645-8d81-41a3-8805-dfcf0c47b04a"), new Guid("1eb3a738-9981-4171-8de2-d3e857a3b8bb"), 300.0, "B", 1, "TRUCK" },
                    { new Guid("09f347df-e38e-4e24-bb6c-15adb50098e6"), new Guid("1bc3d521-4279-4b9d-83d2-647d18bc7a50"), 50.0, "B", 8, "MOTORCYCLE" },
                    { new Guid("0bb815a2-b701-42da-8cbe-2c3759345d97"), new Guid("438cd333-aa34-4a4d-b514-bbdc4a0cb506"), 300.0, "A", 2, "TRUCK" },
                    { new Guid("0ccdaf97-332f-419c-a856-d1bb5562a0b5"), new Guid("11137c72-b421-4023-ad31-7d82db8a5baa"), 50.0, "B", 1, "MOTORCYCLE" },
                    { new Guid("0cfde89e-a5e0-45d1-9883-2b8df6bf7188"), new Guid("a669c2aa-41e8-4ff2-b1bf-6dc0ba156402"), 100.0, "B", 8, "CAR" },
                    { new Guid("0d5ce291-debd-4eee-a01c-3724fd0deca6"), new Guid("9309c264-dc77-4393-97d5-1f5277643f2b"), 50.0, "A", 3, "MOTORCYCLE" },
                    { new Guid("0d9c2862-1000-4782-8bdc-142588531b48"), new Guid("fcc43452-25c4-48cb-a440-1cc413ed3422"), 50.0, "B", 2, "MOTORCYCLE" },
                    { new Guid("0f4d2797-9f9a-4735-a030-3abbed014992"), new Guid("81749d15-9afa-4294-85b7-82204495d265"), 200.0, "A", 4, "VAN" },
                    { new Guid("10880142-d374-4edf-a02a-b5dca8b5c46b"), new Guid("8452e422-1d9e-418f-9b94-061cbe81e04d"), 100.0, "B", 6, "CAR" },
                    { new Guid("110c5ba2-1434-449c-8d26-48e952431a5a"), new Guid("fe712484-2abf-43e2-a9f7-e67b9d2f0d04"), 300.0, "B", 7, "TRUCK" },
                    { new Guid("112ab42f-94d8-4778-bef2-f6d1f390ef15"), new Guid("b5ce9eb5-9343-475e-922b-8d2d1494b13f"), 100.0, "A", 8, "CAR" },
                    { new Guid("115ec8bd-1644-45fc-8f7c-c5faba2e338f"), new Guid("ab78e541-dbbc-4124-bb86-ceb6d75cb71b"), 300.0, "B", 2, "TRUCK" },
                    { new Guid("11af6c55-52b5-4b7c-8d18-f9fed18a2467"), new Guid("599951ba-457b-418b-b563-98eb4b0420f6"), 300.0, "B", 3, "TRUCK" },
                    { new Guid("11c1aa73-a41d-4ff4-8bc0-d63aac827700"), new Guid("fe712484-2abf-43e2-a9f7-e67b9d2f0d04"), 200.0, "A", 8, "VAN" },
                    { new Guid("122f519b-0860-4e98-af60-e81232fba37e"), new Guid("5af99c7f-d6bf-4dce-9363-018315d9e1ad"), 300.0, "A", 3, "TRUCK" },
                    { new Guid("139a2c94-6cec-482b-8bba-234011b364ab"), new Guid("11137c72-b421-4023-ad31-7d82db8a5baa"), 200.0, "A", 6, "VAN" },
                    { new Guid("14f4deea-bfeb-497d-a438-06b3edc3d20b"), new Guid("99372c3d-5903-4a9c-b0b9-0cd15f55658e"), 50.0, "A", 6, "MOTORCYCLE" },
                    { new Guid("14fbdcb1-b9f7-4e73-a1ae-900940fd5a1b"), new Guid("b185c801-7cf9-4792-925b-96f8471d9c99"), 50.0, "A", 3, "MOTORCYCLE" },
                    { new Guid("15672710-c250-4d13-b4b6-5f8f3e5f9a7c"), new Guid("ac366bab-6ac1-4215-a22a-7241bb2c5727"), 300.0, "B", 1, "TRUCK" },
                    { new Guid("1618d2c6-0ee2-4e9e-b64b-8b12a018d3e8"), new Guid("cc8a4163-4cf3-467d-93a3-5dc0e15bab05"), 100.0, "A", 2, "CAR" },
                    { new Guid("16e5f437-74db-49ca-9159-1e7ccad413da"), new Guid("b185c801-7cf9-4792-925b-96f8471d9c99"), 50.0, "A", 7, "MOTORCYCLE" },
                    { new Guid("170becc5-4034-4722-98ec-4fedd70abecf"), new Guid("736ed698-7b98-41d4-90d4-4d6f13415fba"), 300.0, "A", 3, "TRUCK" },
                    { new Guid("17b930c0-023f-46c2-bcc0-d471c541ce88"), new Guid("603467e3-e23d-41ee-aaef-8d21b2e2da6b"), 200.0, "B", 2, "VAN" },
                    { new Guid("18ab4430-483f-462e-b11d-b649e65564c2"), new Guid("ab78e541-dbbc-4124-bb86-ceb6d75cb71b"), 200.0, "A", 8, "VAN" },
                    { new Guid("199afa40-731a-4728-8e34-442febf92738"), new Guid("603467e3-e23d-41ee-aaef-8d21b2e2da6b"), 200.0, "B", 1, "VAN" },
                    { new Guid("1a3677ca-0a42-41eb-a8d0-77bdc5fa539e"), new Guid("e85ec22e-df00-4afc-b1fb-2ca408f15d96"), 50.0, "B", 3, "MOTORCYCLE" },
                    { new Guid("1a9620c1-a1a1-4f0e-8a9c-b31e2045911d"), new Guid("438cd333-aa34-4a4d-b514-bbdc4a0cb506"), 300.0, "A", 1, "TRUCK" },
                    { new Guid("1af63f1a-78ad-4109-8e6d-a681403eb3ba"), new Guid("e0bcde6c-3c72-4b55-a18f-f84fd8581131"), 300.0, "A", 8, "TRUCK" },
                    { new Guid("1d1feef7-1fc3-47af-9aed-66509d87f942"), new Guid("723a9044-40fe-43ee-9f36-dbd4f21a4b90"), 100.0, "B", 2, "CAR" },
                    { new Guid("1d6263e5-2fe1-4b5c-9ced-56bf815bb991"), new Guid("5af99c7f-d6bf-4dce-9363-018315d9e1ad"), 300.0, "A", 2, "TRUCK" },
                    { new Guid("1ded01aa-1b64-424e-afc0-28ae454f94b3"), new Guid("d62d31f9-9ced-4f7d-9ec5-e935519cd731"), 50.0, "A", 2, "MOTORCYCLE" },
                    { new Guid("1f17dbf6-db83-4371-bf7a-f8f02f088eca"), new Guid("fcc43452-25c4-48cb-a440-1cc413ed3422"), 100.0, "A", 4, "CAR" },
                    { new Guid("1f618462-956d-41ce-888e-cdec4e0ad5ab"), new Guid("9309c264-dc77-4393-97d5-1f5277643f2b"), 50.0, "A", 7, "MOTORCYCLE" },
                    { new Guid("1fa124f4-fe8a-455a-be69-3a8146d82236"), new Guid("ac366bab-6ac1-4215-a22a-7241bb2c5727"), 50.0, "A", 5, "MOTORCYCLE" },
                    { new Guid("20847881-fa27-4534-b9ff-c33732634716"), new Guid("11137c72-b421-4023-ad31-7d82db8a5baa"), 200.0, "A", 1, "VAN" },
                    { new Guid("20a8f64a-3a24-4964-94e9-37555f1a1c8c"), new Guid("723a9044-40fe-43ee-9f36-dbd4f21a4b90"), 200.0, "A", 1, "VAN" },
                    { new Guid("2181fce0-7788-4a77-99fb-8db745d034c1"), new Guid("b5ce9eb5-9343-475e-922b-8d2d1494b13f"), 100.0, "B", 1, "CAR" },
                    { new Guid("21bf54a2-0ae5-4f52-8d78-502da311cb2f"), new Guid("ab78e541-dbbc-4124-bb86-ceb6d75cb71b"), 200.0, "A", 2, "VAN" },
                    { new Guid("225597e4-7319-404c-a15e-ae51322ce67d"), new Guid("603467e3-e23d-41ee-aaef-8d21b2e2da6b"), 200.0, "B", 3, "VAN" },
                    { new Guid("225868e1-3b0c-40cf-9a12-5c547c87b597"), new Guid("e0bcde6c-3c72-4b55-a18f-f84fd8581131"), 300.0, "B", 4, "TRUCK" },
                    { new Guid("228a8034-bfbb-49f2-a8c0-907668d9259d"), new Guid("b5ce9eb5-9343-475e-922b-8d2d1494b13f"), 100.0, "A", 1, "CAR" },
                    { new Guid("22c0c4ff-84f8-42b1-845f-ca3486e0f220"), new Guid("e0bcde6c-3c72-4b55-a18f-f84fd8581131"), 300.0, "A", 6, "TRUCK" },
                    { new Guid("24ececb8-1599-4ed8-be26-8fa9ac5f6f0b"), new Guid("e44df884-6d22-4568-ab33-be0090e61fe2"), 300.0, "A", 6, "TRUCK" },
                    { new Guid("250ad4d3-fbd7-4b59-89a8-26d176526a8e"), new Guid("b5ce9eb5-9343-475e-922b-8d2d1494b13f"), 100.0, "A", 6, "CAR" },
                    { new Guid("25baf129-0305-4230-a4fa-86359c7adc21"), new Guid("438cd333-aa34-4a4d-b514-bbdc4a0cb506"), 300.0, "A", 5, "TRUCK" },
                    { new Guid("25ca6c97-b16d-4386-8dfd-00f0e74e85ae"), new Guid("e0bcde6c-3c72-4b55-a18f-f84fd8581131"), 300.0, "B", 6, "TRUCK" },
                    { new Guid("26243cad-ce30-4164-b3f0-f871f07b0c1d"), new Guid("438cd333-aa34-4a4d-b514-bbdc4a0cb506"), 200.0, "B", 8, "VAN" },
                    { new Guid("269200b1-97b5-4a99-bc93-c806097ddc78"), new Guid("1bc3d521-4279-4b9d-83d2-647d18bc7a50"), 300.0, "A", 6, "TRUCK" },
                    { new Guid("26dbf01d-2337-4a93-95a7-8c2b0ceddaa7"), new Guid("ab78e541-dbbc-4124-bb86-ceb6d75cb71b"), 200.0, "A", 4, "VAN" },
                    { new Guid("2958c220-e3fd-4bee-88d2-d47a7e0555d4"), new Guid("ac366bab-6ac1-4215-a22a-7241bb2c5727"), 300.0, "B", 2, "TRUCK" },
                    { new Guid("29942aa7-59ac-4593-8580-5c1102fa2cde"), new Guid("723a9044-40fe-43ee-9f36-dbd4f21a4b90"), 100.0, "B", 6, "CAR" },
                    { new Guid("29f05d7a-1d03-4ff2-a772-9c33fda0792e"), new Guid("5af99c7f-d6bf-4dce-9363-018315d9e1ad"), 50.0, "B", 6, "MOTORCYCLE" },
                    { new Guid("2a0bd116-59a0-41d4-ab09-174b4d7daaff"), new Guid("8c0a0b6c-ba87-4875-a11d-dec8b1eae16a"), 100.0, "A", 6, "CAR" },
                    { new Guid("2afc1bbc-b296-4593-bb2d-55cfc83c13b6"), new Guid("e0bcde6c-3c72-4b55-a18f-f84fd8581131"), 300.0, "B", 7, "TRUCK" },
                    { new Guid("2b4aec5d-b8cb-4520-b4c8-55c7cdaa5408"), new Guid("8c0a0b6c-ba87-4875-a11d-dec8b1eae16a"), 300.0, "B", 1, "TRUCK" },
                    { new Guid("2c84764e-a9bd-4733-8396-66bc2fb7854f"), new Guid("11137c72-b421-4023-ad31-7d82db8a5baa"), 200.0, "A", 8, "VAN" },
                    { new Guid("2d67696d-9d9d-4712-9c48-13da298af1d4"), new Guid("cc8a4163-4cf3-467d-93a3-5dc0e15bab05"), 200.0, "B", 6, "VAN" },
                    { new Guid("2d99d6c3-ef6a-4cfd-86a6-17b364f2ab0a"), new Guid("6f263ffd-8bc7-41fc-a9a4-578f892bd452"), 100.0, "B", 3, "CAR" },
                    { new Guid("2e6b6f9c-e880-4d75-9453-b684465df650"), new Guid("d62d31f9-9ced-4f7d-9ec5-e935519cd731"), 50.0, "A", 7, "MOTORCYCLE" },
                    { new Guid("302cc893-7c12-4893-b18d-f8bcb6e476da"), new Guid("b5ce9eb5-9343-475e-922b-8d2d1494b13f"), 100.0, "B", 3, "CAR" },
                    { new Guid("305f8eca-f1b8-40e4-81ef-9d0eb8c734f9"), new Guid("cc8a4163-4cf3-467d-93a3-5dc0e15bab05"), 200.0, "B", 7, "VAN" },
                    { new Guid("3074deef-7d3a-41c8-b1ec-05d14093e398"), new Guid("ac366bab-6ac1-4215-a22a-7241bb2c5727"), 50.0, "A", 6, "MOTORCYCLE" },
                    { new Guid("315dc986-aa49-4948-95e5-fdf219472236"), new Guid("cc8a4163-4cf3-467d-93a3-5dc0e15bab05"), 100.0, "A", 1, "CAR" },
                    { new Guid("31c7c921-8b25-41af-9cb2-ece01875b054"), new Guid("b5ce9eb5-9343-475e-922b-8d2d1494b13f"), 100.0, "A", 4, "CAR" },
                    { new Guid("32335aa7-77fe-4db0-8912-c357c92099ee"), new Guid("81749d15-9afa-4294-85b7-82204495d265"), 200.0, "A", 5, "VAN" },
                    { new Guid("333e0f0c-5327-4d20-af23-74d79ac2539d"), new Guid("8c0a0b6c-ba87-4875-a11d-dec8b1eae16a"), 300.0, "B", 5, "TRUCK" },
                    { new Guid("3359881d-43d8-4ab7-a493-c0f09ac8ca16"), new Guid("6f263ffd-8bc7-41fc-a9a4-578f892bd452"), 100.0, "B", 7, "CAR" },
                    { new Guid("335eb771-127c-4885-b8f2-b671b53306ae"), new Guid("fcc43452-25c4-48cb-a440-1cc413ed3422"), 100.0, "A", 2, "CAR" },
                    { new Guid("3385e36f-af77-4b40-8e93-73e1d256c4e5"), new Guid("e0bcde6c-3c72-4b55-a18f-f84fd8581131"), 300.0, "B", 1, "TRUCK" },
                    { new Guid("341e1be7-1e13-440e-b5ad-19dff652e3ba"), new Guid("603467e3-e23d-41ee-aaef-8d21b2e2da6b"), 200.0, "B", 8, "VAN" },
                    { new Guid("3431e97a-5669-40d3-b172-a4cf9fcfbe84"), new Guid("e515ae1f-6859-4ea3-9dd9-8fb9d224f8c8"), 100.0, "A", 2, "CAR" },
                    { new Guid("3434e85c-a14d-4ffe-91b9-8f44d3f174fd"), new Guid("a1282826-8649-4590-9393-4430b27b802b"), 50.0, "B", 5, "MOTORCYCLE" },
                    { new Guid("34ab4ed1-09b8-4a3b-9f1b-ccf0f409fe4c"), new Guid("438cd333-aa34-4a4d-b514-bbdc4a0cb506"), 300.0, "A", 6, "TRUCK" },
                    { new Guid("351d2da9-0917-46b6-84e1-5ddc53920530"), new Guid("1eb3a738-9981-4171-8de2-d3e857a3b8bb"), 300.0, "A", 6, "TRUCK" },
                    { new Guid("352fd444-bc8e-49ac-bc0e-1ff8561ba5ed"), new Guid("55551648-de97-4052-9014-293666338e1d"), 300.0, "B", 1, "TRUCK" },
                    { new Guid("3570cccc-65d6-4121-8b66-c9807e356c79"), new Guid("8452e422-1d9e-418f-9b94-061cbe81e04d"), 200.0, "A", 7, "VAN" },
                    { new Guid("35b4f4b4-e80f-497d-8951-e1b1942945f1"), new Guid("ab78e541-dbbc-4124-bb86-ceb6d75cb71b"), 200.0, "A", 7, "VAN" },
                    { new Guid("36ea31bd-e313-4116-ac28-4db26977d322"), new Guid("6f263ffd-8bc7-41fc-a9a4-578f892bd452"), 200.0, "A", 8, "VAN" },
                    { new Guid("36f22f35-ecab-4685-bbb1-b2baf3f44f3c"), new Guid("b5ce9eb5-9343-475e-922b-8d2d1494b13f"), 100.0, "B", 7, "CAR" },
                    { new Guid("37c86cf7-970b-4f82-a32b-e6d44b5c5126"), new Guid("8c0a0b6c-ba87-4875-a11d-dec8b1eae16a"), 100.0, "A", 7, "CAR" },
                    { new Guid("37e6ce21-e78d-44a0-9a46-99cf3c3fd8ee"), new Guid("a669c2aa-41e8-4ff2-b1bf-6dc0ba156402"), 100.0, "A", 3, "CAR" },
                    { new Guid("38cd76ca-ab19-43e2-8221-41d415b9f73c"), new Guid("1eb3a738-9981-4171-8de2-d3e857a3b8bb"), 300.0, "A", 3, "TRUCK" },
                    { new Guid("38f6f5f8-5dba-4488-a8be-d93124cd66dc"), new Guid("a669c2aa-41e8-4ff2-b1bf-6dc0ba156402"), 100.0, "B", 2, "CAR" },
                    { new Guid("391c6244-2b2c-41f1-a2e2-7ea13a417be0"), new Guid("6f263ffd-8bc7-41fc-a9a4-578f892bd452"), 100.0, "B", 6, "CAR" },
                    { new Guid("392a0b2c-353b-470e-b0ea-27d68a7adffe"), new Guid("d62d31f9-9ced-4f7d-9ec5-e935519cd731"), 50.0, "A", 3, "MOTORCYCLE" },
                    { new Guid("39df913b-739e-4f68-936d-2fd57d44b6df"), new Guid("ac366bab-6ac1-4215-a22a-7241bb2c5727"), 50.0, "A", 2, "MOTORCYCLE" },
                    { new Guid("39e7331a-872f-44a7-94b8-1def91ca2e55"), new Guid("1eb3a738-9981-4171-8de2-d3e857a3b8bb"), 300.0, "B", 3, "TRUCK" },
                    { new Guid("39f91518-0c52-4a4b-9b01-81134b2269ac"), new Guid("fe712484-2abf-43e2-a9f7-e67b9d2f0d04"), 300.0, "B", 6, "TRUCK" },
                    { new Guid("3a2c8b0c-3cb0-487d-b27b-6a84da91c3f0"), new Guid("cc8a4163-4cf3-467d-93a3-5dc0e15bab05"), 100.0, "A", 5, "CAR" },
                    { new Guid("3a617948-3551-4adf-ac84-7b333fa76b17"), new Guid("55551648-de97-4052-9014-293666338e1d"), 300.0, "B", 4, "TRUCK" },
                    { new Guid("3b27a690-f9df-4c1e-8090-f6301ead94de"), new Guid("9309c264-dc77-4393-97d5-1f5277643f2b"), 50.0, "A", 1, "MOTORCYCLE" },
                    { new Guid("3b339328-7ccb-4744-8793-85e779ec0cae"), new Guid("b185c801-7cf9-4792-925b-96f8471d9c99"), 50.0, "B", 7, "MOTORCYCLE" },
                    { new Guid("3c487c23-bb1c-4fdf-af61-f183f4329b5c"), new Guid("e85ec22e-df00-4afc-b1fb-2ca408f15d96"), 300.0, "A", 6, "TRUCK" },
                    { new Guid("3c726097-c815-4597-98e4-8193de9dd76c"), new Guid("8452e422-1d9e-418f-9b94-061cbe81e04d"), 200.0, "A", 4, "VAN" },
                    { new Guid("3c99ff00-f5bd-4a09-871b-ae0790318e42"), new Guid("1eb3a738-9981-4171-8de2-d3e857a3b8bb"), 300.0, "A", 2, "TRUCK" },
                    { new Guid("3d61b0df-3185-4552-926b-89d9a3485a5e"), new Guid("81749d15-9afa-4294-85b7-82204495d265"), 50.0, "B", 4, "MOTORCYCLE" },
                    { new Guid("3d7c3e74-a914-4f24-99de-da1010102ed9"), new Guid("603467e3-e23d-41ee-aaef-8d21b2e2da6b"), 50.0, "A", 8, "MOTORCYCLE" },
                    { new Guid("3f07e3bc-cbf2-4a5c-b762-e728bedf0e2f"), new Guid("99372c3d-5903-4a9c-b0b9-0cd15f55658e"), 50.0, "A", 3, "MOTORCYCLE" },
                    { new Guid("3f53fd0b-07f3-43c1-a0fb-678e22c0d032"), new Guid("723a9044-40fe-43ee-9f36-dbd4f21a4b90"), 100.0, "B", 4, "CAR" },
                    { new Guid("3fb82e52-e018-4d02-a76f-bedce790bd93"), new Guid("d62d31f9-9ced-4f7d-9ec5-e935519cd731"), 50.0, "A", 5, "MOTORCYCLE" },
                    { new Guid("42684a31-c73c-4cdd-9227-9d23ede798cf"), new Guid("fcc43452-25c4-48cb-a440-1cc413ed3422"), 100.0, "A", 6, "CAR" },
                    { new Guid("437ab3d9-3ce2-409b-866d-a4fb4117e28f"), new Guid("b185c801-7cf9-4792-925b-96f8471d9c99"), 50.0, "B", 8, "MOTORCYCLE" },
                    { new Guid("44343bc3-6a62-4515-9b69-802a8333e321"), new Guid("d62d31f9-9ced-4f7d-9ec5-e935519cd731"), 50.0, "A", 6, "MOTORCYCLE" },
                    { new Guid("44d7c8d3-66f1-49c5-90ba-4504649b56c2"), new Guid("fe712484-2abf-43e2-a9f7-e67b9d2f0d04"), 300.0, "B", 5, "TRUCK" },
                    { new Guid("44db2336-2396-4b9f-8bb2-9d912b09c548"), new Guid("438cd333-aa34-4a4d-b514-bbdc4a0cb506"), 200.0, "B", 7, "VAN" },
                    { new Guid("450f9f5a-90ed-4b8e-98e4-2c3c455e6e88"), new Guid("b185c801-7cf9-4792-925b-96f8471d9c99"), 50.0, "B", 4, "MOTORCYCLE" },
                    { new Guid("45bdf08d-a6d1-436e-affa-140d585e3308"), new Guid("e515ae1f-6859-4ea3-9dd9-8fb9d224f8c8"), 100.0, "A", 7, "CAR" },
                    { new Guid("47d4bb82-2651-497a-b3be-0d9bdcf0a78e"), new Guid("a1282826-8649-4590-9393-4430b27b802b"), 50.0, "B", 2, "MOTORCYCLE" },
                    { new Guid("4880a8e1-a1b6-466c-89a9-7fbd813040c0"), new Guid("a669c2aa-41e8-4ff2-b1bf-6dc0ba156402"), 100.0, "B", 6, "CAR" },
                    { new Guid("4887643e-63aa-48ad-b03f-feec27d2339b"), new Guid("cc8a4163-4cf3-467d-93a3-5dc0e15bab05"), 100.0, "A", 7, "CAR" },
                    { new Guid("49114ed4-90e8-4251-a848-6b5ba21de28e"), new Guid("81749d15-9afa-4294-85b7-82204495d265"), 200.0, "A", 8, "VAN" },
                    { new Guid("4c0e0bc9-c255-4402-b67c-3f4948158004"), new Guid("a1282826-8649-4590-9393-4430b27b802b"), 50.0, "B", 8, "MOTORCYCLE" },
                    { new Guid("4c9fcdb1-d784-4c71-b559-84dc60661d89"), new Guid("ac366bab-6ac1-4215-a22a-7241bb2c5727"), 300.0, "B", 4, "TRUCK" },
                    { new Guid("4d0fd940-474e-47ee-97ca-443c0b403bd0"), new Guid("a1282826-8649-4590-9393-4430b27b802b"), 200.0, "A", 6, "VAN" },
                    { new Guid("4d12dcb7-7b91-4edc-93ed-6ada8942254f"), new Guid("1bc3d521-4279-4b9d-83d2-647d18bc7a50"), 300.0, "A", 5, "TRUCK" },
                    { new Guid("4eb4ad2b-8caf-427f-ac83-5981b4c8bce6"), new Guid("603467e3-e23d-41ee-aaef-8d21b2e2da6b"), 50.0, "A", 3, "MOTORCYCLE" },
                    { new Guid("4ecd5b1b-83eb-4584-8508-20f817bbdfce"), new Guid("11137c72-b421-4023-ad31-7d82db8a5baa"), 200.0, "A", 4, "VAN" },
                    { new Guid("4ee60ff9-0a2f-40f8-9659-3fc55204ffda"), new Guid("fe712484-2abf-43e2-a9f7-e67b9d2f0d04"), 200.0, "A", 5, "VAN" },
                    { new Guid("4f6a8680-9d91-4972-aa94-43f7a86cb417"), new Guid("ac366bab-6ac1-4215-a22a-7241bb2c5727"), 50.0, "A", 3, "MOTORCYCLE" },
                    { new Guid("4f772e12-e78c-47a7-8f08-a750d1523297"), new Guid("736ed698-7b98-41d4-90d4-4d6f13415fba"), 300.0, "A", 7, "TRUCK" },
                    { new Guid("4fa26cbe-76b0-4e3c-b6b1-073eeee572e6"), new Guid("e44df884-6d22-4568-ab33-be0090e61fe2"), 300.0, "A", 7, "TRUCK" },
                    { new Guid("4fff2a54-166e-4aee-9610-ff47b3cbe8f8"), new Guid("b185c801-7cf9-4792-925b-96f8471d9c99"), 50.0, "B", 2, "MOTORCYCLE" },
                    { new Guid("50587860-3b5a-431d-a44a-d5b4ed9096a6"), new Guid("736ed698-7b98-41d4-90d4-4d6f13415fba"), 300.0, "A", 1, "TRUCK" },
                    { new Guid("50c4cf58-5808-4c99-9f48-1e9698327ff9"), new Guid("736ed698-7b98-41d4-90d4-4d6f13415fba"), 50.0, "B", 8, "MOTORCYCLE" },
                    { new Guid("51ad70c8-f49d-4579-b04d-96804753216c"), new Guid("fe712484-2abf-43e2-a9f7-e67b9d2f0d04"), 200.0, "A", 3, "VAN" },
                    { new Guid("51cd66aa-4c90-4301-ab87-04bdaab22a0c"), new Guid("438cd333-aa34-4a4d-b514-bbdc4a0cb506"), 200.0, "B", 5, "VAN" },
                    { new Guid("51e974da-9397-43f5-b046-43ed93bacc63"), new Guid("5af99c7f-d6bf-4dce-9363-018315d9e1ad"), 50.0, "B", 5, "MOTORCYCLE" },
                    { new Guid("523bd851-12e4-426d-9646-eceada518c54"), new Guid("438cd333-aa34-4a4d-b514-bbdc4a0cb506"), 200.0, "B", 2, "VAN" },
                    { new Guid("536a494f-4bff-441f-b1d2-97a487aa11e6"), new Guid("fe712484-2abf-43e2-a9f7-e67b9d2f0d04"), 300.0, "B", 1, "TRUCK" },
                    { new Guid("5402c82c-f26d-4f7f-a404-423190007124"), new Guid("a669c2aa-41e8-4ff2-b1bf-6dc0ba156402"), 100.0, "A", 1, "CAR" },
                    { new Guid("54bb958e-ab75-495f-aea9-04ec263f74a9"), new Guid("599951ba-457b-418b-b563-98eb4b0420f6"), 300.0, "B", 7, "TRUCK" },
                    { new Guid("54ccd61e-4474-4962-8eb0-1faae4bb74b9"), new Guid("99372c3d-5903-4a9c-b0b9-0cd15f55658e"), 200.0, "B", 4, "VAN" },
                    { new Guid("54d54c52-9e1f-4b9a-82b7-a590afe69988"), new Guid("b185c801-7cf9-4792-925b-96f8471d9c99"), 50.0, "A", 6, "MOTORCYCLE" },
                    { new Guid("5571c0af-39d6-4a12-b2e8-8d23086fe1c7"), new Guid("b5ce9eb5-9343-475e-922b-8d2d1494b13f"), 100.0, "A", 2, "CAR" },
                    { new Guid("57413422-2223-4f85-a277-d5bbe55f5aa9"), new Guid("55551648-de97-4052-9014-293666338e1d"), 100.0, "A", 7, "CAR" },
                    { new Guid("57af7203-95ab-4d1d-978b-888a782cef13"), new Guid("11137c72-b421-4023-ad31-7d82db8a5baa"), 200.0, "A", 5, "VAN" },
                    { new Guid("57dc1619-edb1-4453-b63d-925c2d130aa7"), new Guid("99372c3d-5903-4a9c-b0b9-0cd15f55658e"), 50.0, "A", 7, "MOTORCYCLE" },
                    { new Guid("58f7746b-870a-4e85-abd3-f7d424e08c51"), new Guid("b5ce9eb5-9343-475e-922b-8d2d1494b13f"), 100.0, "B", 2, "CAR" },
                    { new Guid("59b39058-341b-49e0-8134-6550a575dd89"), new Guid("599951ba-457b-418b-b563-98eb4b0420f6"), 50.0, "A", 6, "MOTORCYCLE" },
                    { new Guid("59fba700-99be-4d88-8eb4-ee450aceefe8"), new Guid("a669c2aa-41e8-4ff2-b1bf-6dc0ba156402"), 100.0, "B", 5, "CAR" },
                    { new Guid("5a23fb28-ea9c-4f02-9c73-83abd02385a7"), new Guid("723a9044-40fe-43ee-9f36-dbd4f21a4b90"), 100.0, "B", 5, "CAR" },
                    { new Guid("5affc710-1f08-4aac-b57e-7803fd579f3d"), new Guid("9309c264-dc77-4393-97d5-1f5277643f2b"), 50.0, "B", 4, "MOTORCYCLE" },
                    { new Guid("5b4f41b6-9708-4876-a64d-0579b1f8bdf8"), new Guid("ac366bab-6ac1-4215-a22a-7241bb2c5727"), 300.0, "B", 6, "TRUCK" },
                    { new Guid("5b68cbd9-54f3-4a06-87d5-cb9a5d7ff226"), new Guid("1eb3a738-9981-4171-8de2-d3e857a3b8bb"), 300.0, "B", 6, "TRUCK" },
                    { new Guid("5bc29d09-1bd3-49af-a62b-52a9683ba3d8"), new Guid("603467e3-e23d-41ee-aaef-8d21b2e2da6b"), 50.0, "A", 6, "MOTORCYCLE" },
                    { new Guid("5bd232e0-c263-46ff-ab5d-b6adaa37946a"), new Guid("ac366bab-6ac1-4215-a22a-7241bb2c5727"), 300.0, "B", 5, "TRUCK" },
                    { new Guid("5cdb0323-8467-48b4-9bf2-f9a1fe6fffe1"), new Guid("e85ec22e-df00-4afc-b1fb-2ca408f15d96"), 300.0, "A", 1, "TRUCK" },
                    { new Guid("5d4ca878-27b8-4a73-b3c8-9c7f101b55d0"), new Guid("e44df884-6d22-4568-ab33-be0090e61fe2"), 300.0, "A", 5, "TRUCK" },
                    { new Guid("5fc7acf6-11a7-4a94-8c5d-8a5bef73669b"), new Guid("a669c2aa-41e8-4ff2-b1bf-6dc0ba156402"), 100.0, "A", 5, "CAR" },
                    { new Guid("60356998-4c0c-4717-a357-6fda84a05903"), new Guid("11137c72-b421-4023-ad31-7d82db8a5baa"), 200.0, "A", 2, "VAN" },
                    { new Guid("60ec45cb-9453-4c3f-bdb3-db93713ef1ee"), new Guid("ab78e541-dbbc-4124-bb86-ceb6d75cb71b"), 300.0, "B", 4, "TRUCK" },
                    { new Guid("6105beb9-b3c9-4e54-af7d-5933d8743d49"), new Guid("a669c2aa-41e8-4ff2-b1bf-6dc0ba156402"), 100.0, "A", 4, "CAR" },
                    { new Guid("61759de7-25d7-4754-a432-6859384d0c8b"), new Guid("55551648-de97-4052-9014-293666338e1d"), 300.0, "B", 6, "TRUCK" },
                    { new Guid("624c6483-0474-4323-80a1-4c0d25bd0fd3"), new Guid("fe712484-2abf-43e2-a9f7-e67b9d2f0d04"), 200.0, "A", 7, "VAN" },
                    { new Guid("62b24efa-9fa5-4d3f-8825-787790d52187"), new Guid("99372c3d-5903-4a9c-b0b9-0cd15f55658e"), 200.0, "B", 1, "VAN" },
                    { new Guid("62b37eec-de31-4d7d-9e2c-8c743e959306"), new Guid("ac366bab-6ac1-4215-a22a-7241bb2c5727"), 50.0, "A", 8, "MOTORCYCLE" },
                    { new Guid("62e25483-5c99-414d-9f88-7459b4262ad5"), new Guid("8c0a0b6c-ba87-4875-a11d-dec8b1eae16a"), 100.0, "A", 1, "CAR" },
                    { new Guid("63d1be08-7366-46a2-b2c8-ea1f1c048f76"), new Guid("723a9044-40fe-43ee-9f36-dbd4f21a4b90"), 100.0, "B", 1, "CAR" },
                    { new Guid("640128ed-0a01-4d55-a7cd-2e49dec58abb"), new Guid("9309c264-dc77-4393-97d5-1f5277643f2b"), 50.0, "A", 2, "MOTORCYCLE" },
                    { new Guid("640b48ff-0235-440d-97d6-e4e348d04cf1"), new Guid("81749d15-9afa-4294-85b7-82204495d265"), 50.0, "B", 1, "MOTORCYCLE" },
                    { new Guid("644a30b8-2221-4f02-bb08-3aa14b54e080"), new Guid("1eb3a738-9981-4171-8de2-d3e857a3b8bb"), 300.0, "B", 8, "TRUCK" },
                    { new Guid("653dec78-c2d1-4adb-b043-5c625504d7ab"), new Guid("fcc43452-25c4-48cb-a440-1cc413ed3422"), 50.0, "B", 7, "MOTORCYCLE" },
                    { new Guid("656c120d-d9f9-40ad-8f77-2301909bd2e5"), new Guid("e44df884-6d22-4568-ab33-be0090e61fe2"), 100.0, "B", 5, "CAR" },
                    { new Guid("6697d161-6270-4cff-ac92-33bf3d4b8842"), new Guid("9309c264-dc77-4393-97d5-1f5277643f2b"), 50.0, "B", 5, "MOTORCYCLE" },
                    { new Guid("676882df-a62f-4229-ac8d-97eb5d4726f6"), new Guid("6f263ffd-8bc7-41fc-a9a4-578f892bd452"), 200.0, "A", 1, "VAN" },
                    { new Guid("693a2375-e18e-4cd0-92b9-85ef0c920990"), new Guid("ac366bab-6ac1-4215-a22a-7241bb2c5727"), 50.0, "A", 4, "MOTORCYCLE" },
                    { new Guid("6969c1c5-a226-4b94-865e-1f732474641f"), new Guid("cc8a4163-4cf3-467d-93a3-5dc0e15bab05"), 200.0, "B", 4, "VAN" },
                    { new Guid("699bd2ee-7c3d-42ac-a3d1-34486e58e24a"), new Guid("99372c3d-5903-4a9c-b0b9-0cd15f55658e"), 200.0, "B", 6, "VAN" },
                    { new Guid("69e76785-297c-4e87-9f23-86f16b085be3"), new Guid("9309c264-dc77-4393-97d5-1f5277643f2b"), 50.0, "B", 7, "MOTORCYCLE" },
                    { new Guid("6a1c00cc-4c87-4551-8931-4db3c364e81c"), new Guid("599951ba-457b-418b-b563-98eb4b0420f6"), 50.0, "A", 4, "MOTORCYCLE" },
                    { new Guid("6a25b59b-997f-40be-be78-98ca3b1a4b62"), new Guid("81749d15-9afa-4294-85b7-82204495d265"), 50.0, "B", 2, "MOTORCYCLE" },
                    { new Guid("6a60859f-f639-4f2f-ac4c-cf340dba1565"), new Guid("8c0a0b6c-ba87-4875-a11d-dec8b1eae16a"), 300.0, "B", 8, "TRUCK" },
                    { new Guid("6a7da43f-bc9d-4ed5-8772-f26df643c3b3"), new Guid("8452e422-1d9e-418f-9b94-061cbe81e04d"), 200.0, "A", 8, "VAN" },
                    { new Guid("6ae59487-c65d-4c82-8743-17f56bd83c24"), new Guid("5af99c7f-d6bf-4dce-9363-018315d9e1ad"), 50.0, "B", 1, "MOTORCYCLE" },
                    { new Guid("6bab3572-c59f-441c-880f-adee5420f678"), new Guid("11137c72-b421-4023-ad31-7d82db8a5baa"), 50.0, "B", 8, "MOTORCYCLE" },
                    { new Guid("6beedfd6-86be-4b99-ae66-761fcbc7ff3a"), new Guid("e85ec22e-df00-4afc-b1fb-2ca408f15d96"), 50.0, "B", 7, "MOTORCYCLE" },
                    { new Guid("6d102e88-afd8-4131-80bc-8e6b8c870ff6"), new Guid("e515ae1f-6859-4ea3-9dd9-8fb9d224f8c8"), 100.0, "A", 6, "CAR" },
                    { new Guid("6d660984-bec3-460c-aeb7-4d95ad917eb9"), new Guid("438cd333-aa34-4a4d-b514-bbdc4a0cb506"), 300.0, "A", 4, "TRUCK" },
                    { new Guid("6df5031f-7ec0-4d63-9d11-e15a70e70ab7"), new Guid("603467e3-e23d-41ee-aaef-8d21b2e2da6b"), 50.0, "A", 1, "MOTORCYCLE" },
                    { new Guid("6e274516-016c-4274-b686-e6fc99bb9c1f"), new Guid("e515ae1f-6859-4ea3-9dd9-8fb9d224f8c8"), 200.0, "B", 8, "VAN" },
                    { new Guid("6f2b6110-414a-411c-a1c9-7d5bdc6bba5a"), new Guid("a1282826-8649-4590-9393-4430b27b802b"), 50.0, "B", 1, "MOTORCYCLE" },
                    { new Guid("6feb0676-93de-4c75-823c-d36550aa6a50"), new Guid("e44df884-6d22-4568-ab33-be0090e61fe2"), 100.0, "B", 3, "CAR" },
                    { new Guid("7010b2ad-f95b-446f-bdf1-0ef8e4fcc5b0"), new Guid("723a9044-40fe-43ee-9f36-dbd4f21a4b90"), 100.0, "B", 3, "CAR" },
                    { new Guid("70e7089c-bd76-4d3f-91fb-821452fb53ea"), new Guid("99372c3d-5903-4a9c-b0b9-0cd15f55658e"), 50.0, "A", 2, "MOTORCYCLE" },
                    { new Guid("713dc0db-3810-4aab-b926-0b79d3267837"), new Guid("723a9044-40fe-43ee-9f36-dbd4f21a4b90"), 200.0, "A", 3, "VAN" },
                    { new Guid("71518b4f-ec4a-4a87-8e62-0f30054f6871"), new Guid("a669c2aa-41e8-4ff2-b1bf-6dc0ba156402"), 100.0, "A", 6, "CAR" },
                    { new Guid("71856628-f666-495b-8deb-4749be929afa"), new Guid("e0bcde6c-3c72-4b55-a18f-f84fd8581131"), 300.0, "A", 7, "TRUCK" },
                    { new Guid("71c8733c-5e0a-4ea0-8426-ccc6b5398bcc"), new Guid("603467e3-e23d-41ee-aaef-8d21b2e2da6b"), 50.0, "A", 4, "MOTORCYCLE" },
                    { new Guid("73812f8c-d721-4cf2-be24-3e6b2f0447e1"), new Guid("fcc43452-25c4-48cb-a440-1cc413ed3422"), 100.0, "A", 8, "CAR" },
                    { new Guid("73aa37c1-4b8c-4f91-9152-9fe0408e9925"), new Guid("6f263ffd-8bc7-41fc-a9a4-578f892bd452"), 100.0, "B", 4, "CAR" },
                    { new Guid("76d01380-5ea3-409f-90f2-d224a9b25ae1"), new Guid("e0bcde6c-3c72-4b55-a18f-f84fd8581131"), 300.0, "A", 4, "TRUCK" },
                    { new Guid("7793c65e-40ae-4f94-bf8c-a2dab9bac84d"), new Guid("6f263ffd-8bc7-41fc-a9a4-578f892bd452"), 200.0, "A", 4, "VAN" },
                    { new Guid("783e95f4-d8e1-4af7-8c76-1773f2b2c834"), new Guid("736ed698-7b98-41d4-90d4-4d6f13415fba"), 50.0, "B", 1, "MOTORCYCLE" },
                    { new Guid("78bc9aa3-d66b-453d-8202-562888b006b9"), new Guid("cc8a4163-4cf3-467d-93a3-5dc0e15bab05"), 100.0, "A", 8, "CAR" },
                    { new Guid("78ca350b-139a-48a4-b899-a161d2549a8f"), new Guid("5af99c7f-d6bf-4dce-9363-018315d9e1ad"), 50.0, "B", 8, "MOTORCYCLE" },
                    { new Guid("79924263-c3d8-4cdf-b87c-9150dfc4149b"), new Guid("8c0a0b6c-ba87-4875-a11d-dec8b1eae16a"), 300.0, "B", 7, "TRUCK" },
                    { new Guid("7a27ec68-ab83-4b9c-bdae-f27e57417dd3"), new Guid("a669c2aa-41e8-4ff2-b1bf-6dc0ba156402"), 100.0, "A", 7, "CAR" },
                    { new Guid("7aa01805-7e34-48bf-ae97-dbe99c410ee9"), new Guid("723a9044-40fe-43ee-9f36-dbd4f21a4b90"), 100.0, "B", 7, "CAR" },
                    { new Guid("7b017a24-283d-4be7-b968-542c84b13c1a"), new Guid("e515ae1f-6859-4ea3-9dd9-8fb9d224f8c8"), 200.0, "B", 3, "VAN" },
                    { new Guid("7c146bc4-5207-4c98-a35d-499d6c9193be"), new Guid("736ed698-7b98-41d4-90d4-4d6f13415fba"), 300.0, "A", 5, "TRUCK" },
                    { new Guid("7c674f4c-ffe2-4de9-a8bb-62497d582b8b"), new Guid("6f263ffd-8bc7-41fc-a9a4-578f892bd452"), 200.0, "A", 7, "VAN" },
                    { new Guid("7c69ce66-febd-4eda-91df-964417566e83"), new Guid("e0bcde6c-3c72-4b55-a18f-f84fd8581131"), 300.0, "A", 1, "TRUCK" },
                    { new Guid("7cc300f6-696b-492c-94bc-3a9f088d5681"), new Guid("6f263ffd-8bc7-41fc-a9a4-578f892bd452"), 200.0, "A", 2, "VAN" },
                    { new Guid("7cdfb7a5-ce27-4d2e-ae7f-578e8d25cc92"), new Guid("99372c3d-5903-4a9c-b0b9-0cd15f55658e"), 50.0, "A", 1, "MOTORCYCLE" },
                    { new Guid("7d9ca589-cc37-483a-b45d-b533de755b30"), new Guid("1bc3d521-4279-4b9d-83d2-647d18bc7a50"), 300.0, "A", 7, "TRUCK" },
                    { new Guid("7dcebab0-f57a-4ac7-b5f0-2ec17c31f8a8"), new Guid("9309c264-dc77-4393-97d5-1f5277643f2b"), 50.0, "A", 5, "MOTORCYCLE" },
                    { new Guid("7dfd6efe-0e38-4542-93b3-f300b8cb7333"), new Guid("fe712484-2abf-43e2-a9f7-e67b9d2f0d04"), 300.0, "B", 4, "TRUCK" },
                    { new Guid("7dfeb1f8-8fbb-44ac-b0d2-e6705d8a90ff"), new Guid("b185c801-7cf9-4792-925b-96f8471d9c99"), 50.0, "A", 4, "MOTORCYCLE" },
                    { new Guid("80158100-aca5-4646-9b0b-a818fb9a66ce"), new Guid("438cd333-aa34-4a4d-b514-bbdc4a0cb506"), 300.0, "A", 7, "TRUCK" },
                    { new Guid("801b0fae-e874-44b5-9394-0ea8af6e96c1"), new Guid("b185c801-7cf9-4792-925b-96f8471d9c99"), 50.0, "B", 6, "MOTORCYCLE" },
                    { new Guid("80b46ce3-1cc6-4153-9af7-7d2ac4f7bf36"), new Guid("55551648-de97-4052-9014-293666338e1d"), 100.0, "A", 3, "CAR" },
                    { new Guid("81313adb-1191-4f83-9ee1-9aa5d81a68a5"), new Guid("e515ae1f-6859-4ea3-9dd9-8fb9d224f8c8"), 200.0, "B", 4, "VAN" },
                    { new Guid("81b0e497-de75-47e8-870a-867d817c12e7"), new Guid("55551648-de97-4052-9014-293666338e1d"), 100.0, "A", 2, "CAR" },
                    { new Guid("821eb3be-085a-43b3-bf0e-78db0493dae5"), new Guid("fcc43452-25c4-48cb-a440-1cc413ed3422"), 50.0, "B", 1, "MOTORCYCLE" },
                    { new Guid("8240fb56-6c34-48cd-b89b-03d5aafc7a11"), new Guid("81749d15-9afa-4294-85b7-82204495d265"), 200.0, "A", 1, "VAN" },
                    { new Guid("82484f9c-7d6f-48b5-a2d9-55a904cfeb3e"), new Guid("e85ec22e-df00-4afc-b1fb-2ca408f15d96"), 50.0, "B", 8, "MOTORCYCLE" },
                    { new Guid("82fdf70b-78be-4c51-b858-0cfbf48937a7"), new Guid("e515ae1f-6859-4ea3-9dd9-8fb9d224f8c8"), 200.0, "B", 5, "VAN" },
                    { new Guid("856ee217-e282-4b6c-952d-5d0cff9d5491"), new Guid("e44df884-6d22-4568-ab33-be0090e61fe2"), 300.0, "A", 2, "TRUCK" },
                    { new Guid("857b8665-9321-4784-b445-078f82a90702"), new Guid("603467e3-e23d-41ee-aaef-8d21b2e2da6b"), 50.0, "A", 5, "MOTORCYCLE" },
                    { new Guid("860271f4-396e-409e-b251-c53cec3443dd"), new Guid("55551648-de97-4052-9014-293666338e1d"), 100.0, "A", 8, "CAR" },
                    { new Guid("861b7587-ed17-4388-b97b-528c1f300f0a"), new Guid("cc8a4163-4cf3-467d-93a3-5dc0e15bab05"), 200.0, "B", 8, "VAN" },
                    { new Guid("864d60a2-480a-4809-b29a-84744742ebe9"), new Guid("d62d31f9-9ced-4f7d-9ec5-e935519cd731"), 50.0, "A", 4, "MOTORCYCLE" },
                    { new Guid("87250625-f5b3-4718-812c-37bec82438b6"), new Guid("1eb3a738-9981-4171-8de2-d3e857a3b8bb"), 300.0, "B", 7, "TRUCK" },
                    { new Guid("8777ab8c-a7a2-4702-9b7b-fcc9d2bbecdc"), new Guid("5af99c7f-d6bf-4dce-9363-018315d9e1ad"), 300.0, "A", 6, "TRUCK" },
                    { new Guid("87b50035-77e8-49e4-8f2b-d9eade455c36"), new Guid("736ed698-7b98-41d4-90d4-4d6f13415fba"), 50.0, "B", 3, "MOTORCYCLE" },
                    { new Guid("88c37823-4113-45a0-8e52-a6544b764403"), new Guid("a1282826-8649-4590-9393-4430b27b802b"), 200.0, "A", 8, "VAN" },
                    { new Guid("8903e012-3e0e-4520-8aa0-467a51c1a821"), new Guid("a1282826-8649-4590-9393-4430b27b802b"), 200.0, "A", 5, "VAN" },
                    { new Guid("896f52a4-9a3f-4d45-a1f8-7b71dfbd4c9a"), new Guid("e85ec22e-df00-4afc-b1fb-2ca408f15d96"), 300.0, "A", 3, "TRUCK" },
                    { new Guid("89ea2c9b-5b2d-4345-8b38-70a91d47c7ca"), new Guid("81749d15-9afa-4294-85b7-82204495d265"), 50.0, "B", 8, "MOTORCYCLE" },
                    { new Guid("8acb18c6-95b3-4399-ac0d-006ff8a7e252"), new Guid("9309c264-dc77-4393-97d5-1f5277643f2b"), 50.0, "B", 2, "MOTORCYCLE" },
                    { new Guid("8b3d14ef-c062-43ad-9850-c396b1259ba6"), new Guid("1eb3a738-9981-4171-8de2-d3e857a3b8bb"), 300.0, "A", 4, "TRUCK" },
                    { new Guid("8d53bf3e-a68a-4e31-8cbf-e0ec21ae817e"), new Guid("99372c3d-5903-4a9c-b0b9-0cd15f55658e"), 200.0, "B", 5, "VAN" },
                    { new Guid("8db16a64-8c72-4136-8630-4f1a9bea22b2"), new Guid("e515ae1f-6859-4ea3-9dd9-8fb9d224f8c8"), 200.0, "B", 7, "VAN" },
                    { new Guid("8eab7bbc-740e-4527-bfa7-cb583294e4aa"), new Guid("99372c3d-5903-4a9c-b0b9-0cd15f55658e"), 200.0, "B", 8, "VAN" },
                    { new Guid("8fc8b2e4-ed85-4667-b90d-315bfb3dfd91"), new Guid("1bc3d521-4279-4b9d-83d2-647d18bc7a50"), 300.0, "A", 4, "TRUCK" },
                    { new Guid("9062bdb9-5fc7-47a7-b966-5440ff6f7b8f"), new Guid("a1282826-8649-4590-9393-4430b27b802b"), 50.0, "B", 7, "MOTORCYCLE" },
                    { new Guid("917a3a72-1b18-47c0-a39d-e0d3a4696ffe"), new Guid("6f263ffd-8bc7-41fc-a9a4-578f892bd452"), 200.0, "A", 6, "VAN" },
                    { new Guid("917dcbb7-4ec4-44cc-a899-a562cfeb0dd1"), new Guid("81749d15-9afa-4294-85b7-82204495d265"), 50.0, "B", 6, "MOTORCYCLE" },
                    { new Guid("91ddab1d-af9c-4d4c-8336-7bb6ada58078"), new Guid("723a9044-40fe-43ee-9f36-dbd4f21a4b90"), 200.0, "A", 2, "VAN" },
                    { new Guid("92000e5e-d52d-441f-b7bc-5442d526b954"), new Guid("e44df884-6d22-4568-ab33-be0090e61fe2"), 100.0, "B", 1, "CAR" },
                    { new Guid("92046c22-96fb-40b8-a2b3-173f58e04c18"), new Guid("8452e422-1d9e-418f-9b94-061cbe81e04d"), 100.0, "B", 5, "CAR" },
                    { new Guid("925d86db-a944-4fcf-a01f-57123268e8bd"), new Guid("5af99c7f-d6bf-4dce-9363-018315d9e1ad"), 50.0, "B", 2, "MOTORCYCLE" },
                    { new Guid("92e713d1-d19c-4707-be8f-caef27f96f5b"), new Guid("e515ae1f-6859-4ea3-9dd9-8fb9d224f8c8"), 100.0, "A", 3, "CAR" },
                    { new Guid("92f0dd4f-080e-4736-8fb3-8cffa3576ddd"), new Guid("438cd333-aa34-4a4d-b514-bbdc4a0cb506"), 200.0, "B", 6, "VAN" },
                    { new Guid("939bbb86-deeb-465c-9430-73ea82650c87"), new Guid("e85ec22e-df00-4afc-b1fb-2ca408f15d96"), 300.0, "A", 5, "TRUCK" },
                    { new Guid("9405e365-2f4c-47f6-a0dc-ac6e96d11631"), new Guid("e44df884-6d22-4568-ab33-be0090e61fe2"), 300.0, "A", 4, "TRUCK" },
                    { new Guid("94124a45-4464-4dab-924d-0686448314c3"), new Guid("736ed698-7b98-41d4-90d4-4d6f13415fba"), 300.0, "A", 4, "TRUCK" },
                    { new Guid("94f150fe-b820-4f6e-bc9c-6bfbea461c52"), new Guid("599951ba-457b-418b-b563-98eb4b0420f6"), 50.0, "A", 8, "MOTORCYCLE" },
                    { new Guid("952e49df-3350-421f-8c1b-5f5e86533f47"), new Guid("1bc3d521-4279-4b9d-83d2-647d18bc7a50"), 300.0, "A", 2, "TRUCK" },
                    { new Guid("976bea11-0bbc-4ee4-982a-ea86fb8c24cc"), new Guid("ab78e541-dbbc-4124-bb86-ceb6d75cb71b"), 200.0, "A", 1, "VAN" },
                    { new Guid("979a5217-1fe5-4f95-9ca4-ddee19dc5eb2"), new Guid("1bc3d521-4279-4b9d-83d2-647d18bc7a50"), 50.0, "B", 7, "MOTORCYCLE" },
                    { new Guid("97ab1534-2ff8-48fc-a1ac-294efafcf18b"), new Guid("e85ec22e-df00-4afc-b1fb-2ca408f15d96"), 300.0, "A", 8, "TRUCK" },
                    { new Guid("98eaa8cd-044d-4013-baa4-216ec144050a"), new Guid("599951ba-457b-418b-b563-98eb4b0420f6"), 50.0, "A", 7, "MOTORCYCLE" },
                    { new Guid("99650ed0-3b03-40d3-863d-03368c89e334"), new Guid("ab78e541-dbbc-4124-bb86-ceb6d75cb71b"), 300.0, "B", 5, "TRUCK" },
                    { new Guid("9979374a-13e3-40e9-80f5-279faaa8d91f"), new Guid("736ed698-7b98-41d4-90d4-4d6f13415fba"), 50.0, "B", 7, "MOTORCYCLE" },
                    { new Guid("9a1f9cdd-777e-4b27-b665-8bc413ccd23c"), new Guid("a1282826-8649-4590-9393-4430b27b802b"), 50.0, "B", 3, "MOTORCYCLE" },
                    { new Guid("9a2d4769-9d95-4f94-be94-e871b76c1487"), new Guid("b5ce9eb5-9343-475e-922b-8d2d1494b13f"), 100.0, "A", 3, "CAR" },
                    { new Guid("9a49acfb-0077-410c-93ce-1bb7b2462f34"), new Guid("9309c264-dc77-4393-97d5-1f5277643f2b"), 50.0, "B", 3, "MOTORCYCLE" },
                    { new Guid("9d31fbd9-53cf-40e5-ad55-3bec7596ddfd"), new Guid("55551648-de97-4052-9014-293666338e1d"), 300.0, "B", 3, "TRUCK" },
                    { new Guid("9d6340ee-a744-40b2-921e-caabbdd3543e"), new Guid("fcc43452-25c4-48cb-a440-1cc413ed3422"), 50.0, "B", 6, "MOTORCYCLE" },
                    { new Guid("9d7c7883-e73b-4a60-abf0-ebd965be0336"), new Guid("6f263ffd-8bc7-41fc-a9a4-578f892bd452"), 100.0, "B", 2, "CAR" },
                    { new Guid("9fbc089b-7681-428e-8fd6-a5ccb6319785"), new Guid("e85ec22e-df00-4afc-b1fb-2ca408f15d96"), 50.0, "B", 2, "MOTORCYCLE" },
                    { new Guid("9fe7a201-aaa8-465e-b10f-6c1ad9a636ec"), new Guid("599951ba-457b-418b-b563-98eb4b0420f6"), 50.0, "A", 5, "MOTORCYCLE" },
                    { new Guid("9ff5c837-1303-4aa6-9df1-81eb1ca7df1b"), new Guid("e85ec22e-df00-4afc-b1fb-2ca408f15d96"), 50.0, "B", 6, "MOTORCYCLE" },
                    { new Guid("a04f8de3-96b8-4c1c-8be7-7976e360bdf6"), new Guid("81749d15-9afa-4294-85b7-82204495d265"), 200.0, "A", 7, "VAN" },
                    { new Guid("a07b25f9-56bb-4d20-929b-174303da9a94"), new Guid("99372c3d-5903-4a9c-b0b9-0cd15f55658e"), 50.0, "A", 5, "MOTORCYCLE" },
                    { new Guid("a0c8a064-db00-4f7e-b096-cfd60386991c"), new Guid("8452e422-1d9e-418f-9b94-061cbe81e04d"), 200.0, "A", 1, "VAN" },
                    { new Guid("a116664e-8016-4206-8a51-3fc51e9eacae"), new Guid("9309c264-dc77-4393-97d5-1f5277643f2b"), 50.0, "B", 1, "MOTORCYCLE" },
                    { new Guid("a255e100-5969-4abd-a9e0-7b325d6f2659"), new Guid("9309c264-dc77-4393-97d5-1f5277643f2b"), 50.0, "B", 6, "MOTORCYCLE" },
                    { new Guid("a2effa89-1ccb-4ba6-b46f-a9c91701b9a6"), new Guid("723a9044-40fe-43ee-9f36-dbd4f21a4b90"), 200.0, "A", 6, "VAN" },
                    { new Guid("a38b66ec-f1ff-424b-a9d6-3f5b95b35a45"), new Guid("d62d31f9-9ced-4f7d-9ec5-e935519cd731"), 50.0, "B", 2, "MOTORCYCLE" },
                    { new Guid("a3960301-298c-46d1-aa04-5d9da60b9cdb"), new Guid("a669c2aa-41e8-4ff2-b1bf-6dc0ba156402"), 100.0, "B", 7, "CAR" },
                    { new Guid("a40c04f2-120c-49f1-83b0-0bf1b0ab21b3"), new Guid("1eb3a738-9981-4171-8de2-d3e857a3b8bb"), 300.0, "B", 5, "TRUCK" },
                    { new Guid("a47e2ff5-4d5a-44d5-a002-1c148ff8e325"), new Guid("e85ec22e-df00-4afc-b1fb-2ca408f15d96"), 50.0, "B", 5, "MOTORCYCLE" },
                    { new Guid("a49e4dcf-8cd0-4410-80cb-7db87959df57"), new Guid("ab78e541-dbbc-4124-bb86-ceb6d75cb71b"), 300.0, "B", 6, "TRUCK" },
                    { new Guid("a4a60dd7-0716-4a8b-a3a1-eb9637bc601a"), new Guid("55551648-de97-4052-9014-293666338e1d"), 300.0, "B", 2, "TRUCK" },
                    { new Guid("a5191746-4340-455e-90dd-c4c323b94cde"), new Guid("a1282826-8649-4590-9393-4430b27b802b"), 50.0, "B", 4, "MOTORCYCLE" },
                    { new Guid("a530106f-1e2b-4e3d-bccb-9e7d2c07575f"), new Guid("736ed698-7b98-41d4-90d4-4d6f13415fba"), 50.0, "B", 4, "MOTORCYCLE" },
                    { new Guid("a63e3faa-43ef-4087-8a0b-9e459c5fae0b"), new Guid("b5ce9eb5-9343-475e-922b-8d2d1494b13f"), 100.0, "A", 7, "CAR" },
                    { new Guid("a65007fb-d902-4f07-9bb9-a881c8c6eadd"), new Guid("603467e3-e23d-41ee-aaef-8d21b2e2da6b"), 200.0, "B", 6, "VAN" },
                    { new Guid("a698b405-5e5f-452a-87bb-746509cdeb0c"), new Guid("9309c264-dc77-4393-97d5-1f5277643f2b"), 50.0, "A", 6, "MOTORCYCLE" },
                    { new Guid("a69f3014-b4d1-49fd-969c-fae3ab838d76"), new Guid("723a9044-40fe-43ee-9f36-dbd4f21a4b90"), 200.0, "A", 7, "VAN" },
                    { new Guid("a6fb3a36-42a4-4f4f-aca0-11e109776645"), new Guid("a669c2aa-41e8-4ff2-b1bf-6dc0ba156402"), 100.0, "B", 1, "CAR" },
                    { new Guid("a77bbadc-1f43-42d9-a4af-a508c8d52b39"), new Guid("11137c72-b421-4023-ad31-7d82db8a5baa"), 50.0, "B", 4, "MOTORCYCLE" },
                    { new Guid("a792f0d3-f7ef-4a17-a934-56c3594c7af3"), new Guid("99372c3d-5903-4a9c-b0b9-0cd15f55658e"), 200.0, "B", 7, "VAN" },
                    { new Guid("a88336b4-0b21-415a-8da7-10e38e7fcb09"), new Guid("a669c2aa-41e8-4ff2-b1bf-6dc0ba156402"), 100.0, "B", 4, "CAR" },
                    { new Guid("a8c01fb4-8478-4fe6-9409-0d859094eb7f"), new Guid("d62d31f9-9ced-4f7d-9ec5-e935519cd731"), 50.0, "B", 5, "MOTORCYCLE" },
                    { new Guid("a9035328-0fc1-41aa-a95a-25e9f65db3a9"), new Guid("1bc3d521-4279-4b9d-83d2-647d18bc7a50"), 50.0, "B", 4, "MOTORCYCLE" },
                    { new Guid("a903c6c2-f379-4076-a9ab-743565f14d66"), new Guid("e44df884-6d22-4568-ab33-be0090e61fe2"), 100.0, "B", 7, "CAR" },
                    { new Guid("a9baf6ef-a532-4173-ab75-4df966afc714"), new Guid("e44df884-6d22-4568-ab33-be0090e61fe2"), 300.0, "A", 3, "TRUCK" },
                    { new Guid("a9cd99ed-1c15-4c94-921c-239d41c0c426"), new Guid("d62d31f9-9ced-4f7d-9ec5-e935519cd731"), 50.0, "A", 1, "MOTORCYCLE" },
                    { new Guid("aaad05ad-d351-4f44-a0b2-2ae12cf2935c"), new Guid("5af99c7f-d6bf-4dce-9363-018315d9e1ad"), 300.0, "A", 5, "TRUCK" },
                    { new Guid("ac2db782-4cf8-486f-9732-0f3298420461"), new Guid("8c0a0b6c-ba87-4875-a11d-dec8b1eae16a"), 100.0, "A", 4, "CAR" },
                    { new Guid("acad0c62-61a0-4e55-91d1-0af0c83bfbe0"), new Guid("723a9044-40fe-43ee-9f36-dbd4f21a4b90"), 100.0, "B", 8, "CAR" },
                    { new Guid("acee53ee-ab8f-49fb-9aa1-e710a1c6483e"), new Guid("a669c2aa-41e8-4ff2-b1bf-6dc0ba156402"), 100.0, "A", 2, "CAR" },
                    { new Guid("ae9b44fc-e2d2-4594-a547-7c3d33467859"), new Guid("d62d31f9-9ced-4f7d-9ec5-e935519cd731"), 50.0, "B", 4, "MOTORCYCLE" },
                    { new Guid("aef148a7-9b84-4f05-926d-428d7f7eeeda"), new Guid("cc8a4163-4cf3-467d-93a3-5dc0e15bab05"), 100.0, "A", 4, "CAR" },
                    { new Guid("afb8563c-7681-4219-b016-3308233822a2"), new Guid("81749d15-9afa-4294-85b7-82204495d265"), 200.0, "A", 3, "VAN" },
                    { new Guid("b0b3319e-3811-4e8f-a2bb-e6cd5277419b"), new Guid("e44df884-6d22-4568-ab33-be0090e61fe2"), 100.0, "B", 4, "CAR" },
                    { new Guid("b115e8e2-e8ab-43f0-9772-723018673107"), new Guid("ac366bab-6ac1-4215-a22a-7241bb2c5727"), 300.0, "B", 3, "TRUCK" },
                    { new Guid("b1ab38aa-3877-4c6b-b035-fa1414828093"), new Guid("8452e422-1d9e-418f-9b94-061cbe81e04d"), 200.0, "A", 2, "VAN" },
                    { new Guid("b1e6366c-96ff-4b3e-a0f7-87bbaea4119c"), new Guid("d62d31f9-9ced-4f7d-9ec5-e935519cd731"), 50.0, "B", 3, "MOTORCYCLE" },
                    { new Guid("b23f1b2f-2e6c-4483-90c5-6732d9f3730d"), new Guid("e0bcde6c-3c72-4b55-a18f-f84fd8581131"), 300.0, "B", 8, "TRUCK" },
                    { new Guid("b4a047a1-fc14-4c5b-a623-582d2e63dee4"), new Guid("99372c3d-5903-4a9c-b0b9-0cd15f55658e"), 50.0, "A", 4, "MOTORCYCLE" },
                    { new Guid("b4d3ab66-fefd-473b-b05e-0c2f60752eab"), new Guid("8452e422-1d9e-418f-9b94-061cbe81e04d"), 200.0, "A", 3, "VAN" },
                    { new Guid("b58d60ea-8f1b-4561-b51b-8649e1166715"), new Guid("cc8a4163-4cf3-467d-93a3-5dc0e15bab05"), 200.0, "B", 3, "VAN" },
                    { new Guid("b66477e2-5ad2-4e08-a4ac-4de902873f88"), new Guid("5af99c7f-d6bf-4dce-9363-018315d9e1ad"), 300.0, "A", 8, "TRUCK" },
                    { new Guid("b690c631-6619-4379-9b13-a6febfe7ff83"), new Guid("599951ba-457b-418b-b563-98eb4b0420f6"), 50.0, "A", 2, "MOTORCYCLE" },
                    { new Guid("b6ded567-2dd2-4150-8501-5a4b7e259a2e"), new Guid("5af99c7f-d6bf-4dce-9363-018315d9e1ad"), 50.0, "B", 3, "MOTORCYCLE" },
                    { new Guid("b73b4aef-ad66-4781-b3b4-3eae4f6aeb13"), new Guid("1eb3a738-9981-4171-8de2-d3e857a3b8bb"), 300.0, "B", 2, "TRUCK" },
                    { new Guid("b772cce8-7aab-494b-9499-48cf3373ba13"), new Guid("55551648-de97-4052-9014-293666338e1d"), 300.0, "B", 8, "TRUCK" },
                    { new Guid("b77e3f0e-b7f9-4dfe-ad9f-a78a39cd2dac"), new Guid("e0bcde6c-3c72-4b55-a18f-f84fd8581131"), 300.0, "B", 3, "TRUCK" },
                    { new Guid("b84038c8-618f-435c-936a-4840005ed081"), new Guid("d62d31f9-9ced-4f7d-9ec5-e935519cd731"), 50.0, "B", 1, "MOTORCYCLE" },
                    { new Guid("b89caddb-7a8d-4575-973c-0be5c0cad08d"), new Guid("a1282826-8649-4590-9393-4430b27b802b"), 50.0, "B", 6, "MOTORCYCLE" },
                    { new Guid("b8eb7a47-bd89-4f87-b87a-9b46803089ed"), new Guid("a1282826-8649-4590-9393-4430b27b802b"), 200.0, "A", 4, "VAN" },
                    { new Guid("b966bc1b-9420-4a01-a3b3-1bc5871558b1"), new Guid("55551648-de97-4052-9014-293666338e1d"), 100.0, "A", 1, "CAR" },
                    { new Guid("b97e85ce-07b6-4509-bd52-fd2a2809ff2e"), new Guid("b185c801-7cf9-4792-925b-96f8471d9c99"), 50.0, "B", 5, "MOTORCYCLE" },
                    { new Guid("b9d72042-28cf-45f1-ae6a-0c126fd30750"), new Guid("5af99c7f-d6bf-4dce-9363-018315d9e1ad"), 300.0, "A", 4, "TRUCK" },
                    { new Guid("bb401f5a-4370-41ad-bf07-dbd813e83e8b"), new Guid("e515ae1f-6859-4ea3-9dd9-8fb9d224f8c8"), 100.0, "A", 4, "CAR" },
                    { new Guid("bbc193fa-a349-4c69-98bd-8ecbaf70edda"), new Guid("6f263ffd-8bc7-41fc-a9a4-578f892bd452"), 100.0, "B", 5, "CAR" },
                    { new Guid("bcd64545-c03f-49af-ad5d-55c5f39dbcb7"), new Guid("a1282826-8649-4590-9393-4430b27b802b"), 200.0, "A", 2, "VAN" },
                    { new Guid("bcedfd6c-00d3-4215-ab2a-022a6ce2700d"), new Guid("55551648-de97-4052-9014-293666338e1d"), 300.0, "B", 5, "TRUCK" },
                    { new Guid("bdf6ec25-ecbb-4aa4-b922-b389a81640e1"), new Guid("8c0a0b6c-ba87-4875-a11d-dec8b1eae16a"), 100.0, "A", 3, "CAR" },
                    { new Guid("be62fadc-a611-4b45-88b6-e222a8f392f5"), new Guid("1eb3a738-9981-4171-8de2-d3e857a3b8bb"), 300.0, "A", 8, "TRUCK" },
                    { new Guid("bebc4d5a-7464-48e7-bc6d-8f6a6f4a7b28"), new Guid("ab78e541-dbbc-4124-bb86-ceb6d75cb71b"), 200.0, "A", 3, "VAN" },
                    { new Guid("c08c82df-88ff-44a2-833f-eb9e200d8156"), new Guid("8c0a0b6c-ba87-4875-a11d-dec8b1eae16a"), 300.0, "B", 6, "TRUCK" },
                    { new Guid("c097c510-836e-4489-8d3a-fa64d53e0be3"), new Guid("599951ba-457b-418b-b563-98eb4b0420f6"), 300.0, "B", 1, "TRUCK" },
                    { new Guid("c1228048-01e5-4994-b74e-4b2a5cf9ed62"), new Guid("e515ae1f-6859-4ea3-9dd9-8fb9d224f8c8"), 200.0, "B", 2, "VAN" },
                    { new Guid("c17ec7b2-d744-4f99-a8da-b4f62065a36f"), new Guid("55551648-de97-4052-9014-293666338e1d"), 300.0, "B", 7, "TRUCK" },
                    { new Guid("c1aee592-6919-4266-86f1-ae434f75e953"), new Guid("81749d15-9afa-4294-85b7-82204495d265"), 200.0, "A", 6, "VAN" },
                    { new Guid("c1f29946-3df8-4e67-9e28-175414372859"), new Guid("8452e422-1d9e-418f-9b94-061cbe81e04d"), 100.0, "B", 3, "CAR" },
                    { new Guid("c25237b5-6705-497d-8bcb-7749f1357cad"), new Guid("ab78e541-dbbc-4124-bb86-ceb6d75cb71b"), 300.0, "B", 1, "TRUCK" },
                    { new Guid("c2aec327-c8be-4fe3-b2bc-c31954ede7bb"), new Guid("e85ec22e-df00-4afc-b1fb-2ca408f15d96"), 300.0, "A", 4, "TRUCK" },
                    { new Guid("c2b25c73-3f20-402c-a074-bc3fde7dd47a"), new Guid("1eb3a738-9981-4171-8de2-d3e857a3b8bb"), 300.0, "A", 7, "TRUCK" },
                    { new Guid("c317457e-c212-45a8-a033-ba03060180f1"), new Guid("8c0a0b6c-ba87-4875-a11d-dec8b1eae16a"), 300.0, "B", 2, "TRUCK" },
                    { new Guid("c393df75-ee4c-4632-abce-d69670a42f2a"), new Guid("fcc43452-25c4-48cb-a440-1cc413ed3422"), 50.0, "B", 4, "MOTORCYCLE" },
                    { new Guid("c45c399e-3c44-4366-b958-860e974d9eb7"), new Guid("8452e422-1d9e-418f-9b94-061cbe81e04d"), 200.0, "A", 6, "VAN" },
                    { new Guid("c4a7efcc-f81a-4bd5-8f56-66f42644201e"), new Guid("736ed698-7b98-41d4-90d4-4d6f13415fba"), 300.0, "A", 2, "TRUCK" },
                    { new Guid("c4afa987-4431-4443-a388-8959c17a6bee"), new Guid("e515ae1f-6859-4ea3-9dd9-8fb9d224f8c8"), 100.0, "A", 1, "CAR" },
                    { new Guid("c4eb4acb-7736-4227-a2a6-5b40cced8f15"), new Guid("723a9044-40fe-43ee-9f36-dbd4f21a4b90"), 200.0, "A", 8, "VAN" },
                    { new Guid("c50045ae-e1ec-4601-9ac5-fda260552b2f"), new Guid("a669c2aa-41e8-4ff2-b1bf-6dc0ba156402"), 100.0, "A", 8, "CAR" },
                    { new Guid("c56e45ee-5397-4e91-b9d3-997545fa8d2e"), new Guid("99372c3d-5903-4a9c-b0b9-0cd15f55658e"), 200.0, "B", 3, "VAN" },
                    { new Guid("c58dba96-da68-4c26-bc37-3395612abe91"), new Guid("fcc43452-25c4-48cb-a440-1cc413ed3422"), 100.0, "A", 3, "CAR" },
                    { new Guid("c599ded0-b3f1-4593-b69f-ac2b3fe8eeb6"), new Guid("cc8a4163-4cf3-467d-93a3-5dc0e15bab05"), 200.0, "B", 2, "VAN" },
                    { new Guid("c659421d-3a4f-4f93-b5cc-e35b0298d649"), new Guid("99372c3d-5903-4a9c-b0b9-0cd15f55658e"), 50.0, "A", 8, "MOTORCYCLE" },
                    { new Guid("c6730fb1-643e-418d-89d4-9566b140c437"), new Guid("e44df884-6d22-4568-ab33-be0090e61fe2"), 300.0, "A", 1, "TRUCK" },
                    { new Guid("c87cfbb6-9d33-48b6-b768-5096ee2ed031"), new Guid("1bc3d521-4279-4b9d-83d2-647d18bc7a50"), 50.0, "B", 2, "MOTORCYCLE" },
                    { new Guid("c8890f87-75bc-4758-b29a-cfec3c158636"), new Guid("fe712484-2abf-43e2-a9f7-e67b9d2f0d04"), 200.0, "A", 2, "VAN" },
                    { new Guid("c8c0af40-9577-4d72-9a70-def3089c3200"), new Guid("6f263ffd-8bc7-41fc-a9a4-578f892bd452"), 200.0, "A", 3, "VAN" },
                    { new Guid("c8f1bf11-4d29-41ad-9fb9-a8dbda0214ee"), new Guid("fcc43452-25c4-48cb-a440-1cc413ed3422"), 50.0, "B", 5, "MOTORCYCLE" },
                    { new Guid("c9101b85-f84c-4cbd-aa02-1bb1f8e40ba7"), new Guid("55551648-de97-4052-9014-293666338e1d"), 100.0, "A", 4, "CAR" },
                    { new Guid("c91dedd9-78f4-48a4-b99a-c359712983ab"), new Guid("b185c801-7cf9-4792-925b-96f8471d9c99"), 50.0, "B", 3, "MOTORCYCLE" },
                    { new Guid("c9fd5bff-7daa-4c91-9e03-81cfeddf2930"), new Guid("e44df884-6d22-4568-ab33-be0090e61fe2"), 100.0, "B", 8, "CAR" },
                    { new Guid("ca5570f9-7802-42d5-9e24-b2635ee8c601"), new Guid("8c0a0b6c-ba87-4875-a11d-dec8b1eae16a"), 300.0, "B", 4, "TRUCK" },
                    { new Guid("ca6a6739-9a1c-43d8-8121-2d7bc6db5ac7"), new Guid("fe712484-2abf-43e2-a9f7-e67b9d2f0d04"), 200.0, "A", 4, "VAN" },
                    { new Guid("cc27825c-3a3f-4b42-9394-92ba103b4049"), new Guid("fcc43452-25c4-48cb-a440-1cc413ed3422"), 50.0, "B", 3, "MOTORCYCLE" },
                    { new Guid("cc5da374-62c5-4d11-bee5-564638ea212f"), new Guid("723a9044-40fe-43ee-9f36-dbd4f21a4b90"), 200.0, "A", 4, "VAN" },
                    { new Guid("cd03aa23-e911-4ff9-a914-1d82ddb54289"), new Guid("e44df884-6d22-4568-ab33-be0090e61fe2"), 300.0, "A", 8, "TRUCK" },
                    { new Guid("cdb8ab00-293f-4a05-a4ed-05ff68e66bdd"), new Guid("8452e422-1d9e-418f-9b94-061cbe81e04d"), 100.0, "B", 8, "CAR" },
                    { new Guid("cdc6d31a-d7ab-4693-80a8-0313a0cb0692"), new Guid("e0bcde6c-3c72-4b55-a18f-f84fd8581131"), 300.0, "B", 2, "TRUCK" },
                    { new Guid("ce2ecc47-aa56-44c4-a74e-c73537efd970"), new Guid("ac366bab-6ac1-4215-a22a-7241bb2c5727"), 50.0, "A", 7, "MOTORCYCLE" },
                    { new Guid("ce733fb4-3747-420d-bc30-05744b8806fe"), new Guid("a1282826-8649-4590-9393-4430b27b802b"), 200.0, "A", 3, "VAN" },
                    { new Guid("cec5767f-f079-4845-9910-64c4c08def3a"), new Guid("fe712484-2abf-43e2-a9f7-e67b9d2f0d04"), 200.0, "A", 6, "VAN" },
                    { new Guid("cedf4690-cec0-4613-b778-c498a34b13e5"), new Guid("599951ba-457b-418b-b563-98eb4b0420f6"), 300.0, "B", 8, "TRUCK" },
                    { new Guid("cf2e5ee8-00e9-47fb-9be4-d9a1efa04b41"), new Guid("b5ce9eb5-9343-475e-922b-8d2d1494b13f"), 100.0, "A", 5, "CAR" },
                    { new Guid("cf8cf81c-a223-4756-af47-2a631becb6f5"), new Guid("55551648-de97-4052-9014-293666338e1d"), 100.0, "A", 5, "CAR" },
                    { new Guid("cfb7ad11-6f54-4a9d-b45f-a6556706e3b5"), new Guid("438cd333-aa34-4a4d-b514-bbdc4a0cb506"), 200.0, "B", 1, "VAN" },
                    { new Guid("d1dd2593-1bc6-439b-9ed6-da8d0c3368fe"), new Guid("cc8a4163-4cf3-467d-93a3-5dc0e15bab05"), 100.0, "A", 3, "CAR" },
                    { new Guid("d1e0e2e2-7897-484f-b3d3-908daec607b9"), new Guid("d62d31f9-9ced-4f7d-9ec5-e935519cd731"), 50.0, "B", 8, "MOTORCYCLE" },
                    { new Guid("d2a26857-faf8-4ffa-a911-aa2c8e16b157"), new Guid("8c0a0b6c-ba87-4875-a11d-dec8b1eae16a"), 100.0, "A", 5, "CAR" },
                    { new Guid("d307be16-6427-47a0-a18b-3aabc8240760"), new Guid("e85ec22e-df00-4afc-b1fb-2ca408f15d96"), 50.0, "B", 4, "MOTORCYCLE" },
                    { new Guid("d356764d-5376-45ef-b919-e578b1c0c1c1"), new Guid("1bc3d521-4279-4b9d-83d2-647d18bc7a50"), 300.0, "A", 8, "TRUCK" },
                    { new Guid("d3aa80bc-b935-4325-94c5-8604abea31c9"), new Guid("e0bcde6c-3c72-4b55-a18f-f84fd8581131"), 300.0, "A", 5, "TRUCK" },
                    { new Guid("d3e46439-710c-4a9b-8dfd-5def7616afb0"), new Guid("55551648-de97-4052-9014-293666338e1d"), 100.0, "A", 6, "CAR" },
                    { new Guid("d4d25725-2b08-4dd2-82ef-ee2695c060b9"), new Guid("ab78e541-dbbc-4124-bb86-ceb6d75cb71b"), 200.0, "A", 5, "VAN" },
                    { new Guid("d4f3e507-bcf4-488d-908e-07e4104f3329"), new Guid("e44df884-6d22-4568-ab33-be0090e61fe2"), 100.0, "B", 6, "CAR" },
                    { new Guid("d50f033c-15d0-41fb-a96b-27262247e797"), new Guid("b5ce9eb5-9343-475e-922b-8d2d1494b13f"), 100.0, "B", 8, "CAR" },
                    { new Guid("d5af4071-3efc-46fd-9d36-174a6110a49a"), new Guid("b185c801-7cf9-4792-925b-96f8471d9c99"), 50.0, "A", 2, "MOTORCYCLE" },
                    { new Guid("d65ff36a-d481-4f75-b3b6-c8ae80125261"), new Guid("8c0a0b6c-ba87-4875-a11d-dec8b1eae16a"), 300.0, "B", 3, "TRUCK" },
                    { new Guid("d6c9f814-3c96-473f-94fe-8447c238ffce"), new Guid("1eb3a738-9981-4171-8de2-d3e857a3b8bb"), 300.0, "B", 4, "TRUCK" },
                    { new Guid("d7de48cc-5029-491d-88f0-eebc632d327e"), new Guid("736ed698-7b98-41d4-90d4-4d6f13415fba"), 50.0, "B", 2, "MOTORCYCLE" },
                    { new Guid("d9d2682b-9147-4326-9f7d-e182df5ab3af"), new Guid("603467e3-e23d-41ee-aaef-8d21b2e2da6b"), 50.0, "A", 7, "MOTORCYCLE" },
                    { new Guid("dc121015-00dc-4c76-b025-c1efca9baf59"), new Guid("e515ae1f-6859-4ea3-9dd9-8fb9d224f8c8"), 200.0, "B", 1, "VAN" },
                    { new Guid("dc7709c6-333d-4192-b08a-5bc07b41bd28"), new Guid("9309c264-dc77-4393-97d5-1f5277643f2b"), 50.0, "A", 4, "MOTORCYCLE" },
                    { new Guid("dcca9d22-9bfd-4f1d-bb1b-1ecd495a4a3e"), new Guid("736ed698-7b98-41d4-90d4-4d6f13415fba"), 50.0, "B", 5, "MOTORCYCLE" },
                    { new Guid("dccebc5c-aab3-4016-bd1d-b6f43e8a90e0"), new Guid("599951ba-457b-418b-b563-98eb4b0420f6"), 300.0, "B", 5, "TRUCK" },
                    { new Guid("dd95933f-6a33-4d95-b139-b8b7ad0d983a"), new Guid("81749d15-9afa-4294-85b7-82204495d265"), 50.0, "B", 5, "MOTORCYCLE" },
                    { new Guid("de26d3a7-0b55-47cd-aee4-f91100c5159c"), new Guid("d62d31f9-9ced-4f7d-9ec5-e935519cd731"), 50.0, "A", 8, "MOTORCYCLE" },
                    { new Guid("de7aabba-1e99-45ba-97f5-08408a4cf71a"), new Guid("fe712484-2abf-43e2-a9f7-e67b9d2f0d04"), 300.0, "B", 3, "TRUCK" },
                    { new Guid("ded8d7f1-174f-4992-87e1-a54f24ae243e"), new Guid("438cd333-aa34-4a4d-b514-bbdc4a0cb506"), 200.0, "B", 3, "VAN" },
                    { new Guid("e0098236-6386-4185-a3ff-6742f1d14bed"), new Guid("603467e3-e23d-41ee-aaef-8d21b2e2da6b"), 200.0, "B", 4, "VAN" },
                    { new Guid("e02e0046-b32c-4e30-90e8-ec6e74a5bc7e"), new Guid("b5ce9eb5-9343-475e-922b-8d2d1494b13f"), 100.0, "B", 4, "CAR" },
                    { new Guid("e1361039-aed5-41f9-af67-abc2e4bcd3ae"), new Guid("11137c72-b421-4023-ad31-7d82db8a5baa"), 50.0, "B", 6, "MOTORCYCLE" },
                    { new Guid("e15814ae-740c-4275-85ed-555889c306a6"), new Guid("cc8a4163-4cf3-467d-93a3-5dc0e15bab05"), 200.0, "B", 5, "VAN" },
                    { new Guid("e2cf14a1-924a-4b77-bde6-5b6d8dc1200f"), new Guid("d62d31f9-9ced-4f7d-9ec5-e935519cd731"), 50.0, "B", 6, "MOTORCYCLE" },
                    { new Guid("e2fe0e74-7513-483f-9067-623aa7b5ba2f"), new Guid("11137c72-b421-4023-ad31-7d82db8a5baa"), 50.0, "B", 7, "MOTORCYCLE" },
                    { new Guid("e3173aa0-8496-4227-be3f-3a5480797c1f"), new Guid("6f263ffd-8bc7-41fc-a9a4-578f892bd452"), 100.0, "B", 8, "CAR" },
                    { new Guid("e335f12f-6f34-4616-b81c-d7d12e3d16f4"), new Guid("11137c72-b421-4023-ad31-7d82db8a5baa"), 50.0, "B", 3, "MOTORCYCLE" },
                    { new Guid("e33e148b-57b9-4743-8b60-bea2ac4fca6b"), new Guid("cc8a4163-4cf3-467d-93a3-5dc0e15bab05"), 100.0, "A", 6, "CAR" },
                    { new Guid("e3d1c689-1b1e-4e62-8ffa-ad1a074728b6"), new Guid("8452e422-1d9e-418f-9b94-061cbe81e04d"), 100.0, "B", 4, "CAR" },
                    { new Guid("e46110c1-1516-4bbc-9685-aabdc5880a4c"), new Guid("b5ce9eb5-9343-475e-922b-8d2d1494b13f"), 100.0, "B", 6, "CAR" },
                    { new Guid("e4b84656-b976-43d9-875c-00338f674d32"), new Guid("e85ec22e-df00-4afc-b1fb-2ca408f15d96"), 300.0, "A", 7, "TRUCK" },
                    { new Guid("e4bb636a-6455-4dd5-80ce-858cd7b9ca6b"), new Guid("d62d31f9-9ced-4f7d-9ec5-e935519cd731"), 50.0, "B", 7, "MOTORCYCLE" },
                    { new Guid("e59adf47-390d-4a07-b199-b8472483a0ae"), new Guid("8452e422-1d9e-418f-9b94-061cbe81e04d"), 100.0, "B", 7, "CAR" },
                    { new Guid("e6c0b216-561a-4006-a8eb-86eb2c117eb6"), new Guid("fe712484-2abf-43e2-a9f7-e67b9d2f0d04"), 300.0, "B", 8, "TRUCK" },
                    { new Guid("e6decb4c-4b36-40dd-bcec-81b2aaf3d244"), new Guid("8c0a0b6c-ba87-4875-a11d-dec8b1eae16a"), 100.0, "A", 8, "CAR" },
                    { new Guid("e82fb733-5548-434c-9278-a92a20883e19"), new Guid("8c0a0b6c-ba87-4875-a11d-dec8b1eae16a"), 100.0, "A", 2, "CAR" },
                    { new Guid("e8740f2b-594a-4a35-a28a-43c0884bbb7c"), new Guid("a1282826-8649-4590-9393-4430b27b802b"), 200.0, "A", 1, "VAN" },
                    { new Guid("e930e74a-2d15-42eb-a5fc-2883438c1b0e"), new Guid("603467e3-e23d-41ee-aaef-8d21b2e2da6b"), 200.0, "B", 7, "VAN" },
                    { new Guid("e9bfd41a-9e54-4240-babb-f8c0a5989b0a"), new Guid("e515ae1f-6859-4ea3-9dd9-8fb9d224f8c8"), 100.0, "A", 8, "CAR" },
                    { new Guid("e9efa48e-c151-4e40-8a67-10ea0db310ac"), new Guid("e0bcde6c-3c72-4b55-a18f-f84fd8581131"), 300.0, "B", 5, "TRUCK" },
                    { new Guid("eb3d32ec-ddd7-4a0e-a559-ad3795eedd04"), new Guid("1bc3d521-4279-4b9d-83d2-647d18bc7a50"), 50.0, "B", 1, "MOTORCYCLE" },
                    { new Guid("eb71b418-0ac3-41b6-8437-6815dac88e0d"), new Guid("723a9044-40fe-43ee-9f36-dbd4f21a4b90"), 200.0, "A", 5, "VAN" },
                    { new Guid("ebbcce5a-8626-4d20-b365-37b6de16a8c9"), new Guid("9309c264-dc77-4393-97d5-1f5277643f2b"), 50.0, "B", 8, "MOTORCYCLE" },
                    { new Guid("ec4c89d7-12ef-4ad5-ac71-ed3e563475fd"), new Guid("ab78e541-dbbc-4124-bb86-ceb6d75cb71b"), 200.0, "A", 6, "VAN" },
                    { new Guid("ec5cccf0-fff1-4455-8a22-6f7dee249a5d"), new Guid("cc8a4163-4cf3-467d-93a3-5dc0e15bab05"), 200.0, "B", 1, "VAN" },
                    { new Guid("ed253243-4297-46fc-86e9-af9c93e1693c"), new Guid("81749d15-9afa-4294-85b7-82204495d265"), 50.0, "B", 7, "MOTORCYCLE" },
                    { new Guid("ed2deee1-ba3a-4122-83ee-cd128db9d7b5"), new Guid("1eb3a738-9981-4171-8de2-d3e857a3b8bb"), 300.0, "A", 5, "TRUCK" },
                    { new Guid("ef7b75ce-6536-4428-acb2-bcd6eb2304ed"), new Guid("8452e422-1d9e-418f-9b94-061cbe81e04d"), 200.0, "A", 5, "VAN" },
                    { new Guid("efb89a33-f0be-4bcf-b491-f7276e3f02d6"), new Guid("fe712484-2abf-43e2-a9f7-e67b9d2f0d04"), 200.0, "A", 1, "VAN" },
                    { new Guid("f047099b-2d31-4cb0-8503-ecb68dd59e62"), new Guid("599951ba-457b-418b-b563-98eb4b0420f6"), 50.0, "A", 3, "MOTORCYCLE" },
                    { new Guid("f05eec8c-4c14-4213-b34c-398b4ca0b6af"), new Guid("6f263ffd-8bc7-41fc-a9a4-578f892bd452"), 200.0, "A", 5, "VAN" },
                    { new Guid("f1391312-8960-4c15-92f4-02612f1f7974"), new Guid("81749d15-9afa-4294-85b7-82204495d265"), 50.0, "B", 3, "MOTORCYCLE" },
                    { new Guid("f1b7feb1-1916-4692-a202-20386d6589db"), new Guid("603467e3-e23d-41ee-aaef-8d21b2e2da6b"), 50.0, "A", 2, "MOTORCYCLE" },
                    { new Guid("f211bbd0-e128-4244-908d-d5e87305428e"), new Guid("5af99c7f-d6bf-4dce-9363-018315d9e1ad"), 300.0, "A", 1, "TRUCK" },
                    { new Guid("f29f8d23-995e-441d-8cf7-abfedae53640"), new Guid("599951ba-457b-418b-b563-98eb4b0420f6"), 50.0, "A", 1, "MOTORCYCLE" },
                    { new Guid("f2a48ef1-e701-4f48-9e1f-a5d845c59548"), new Guid("11137c72-b421-4023-ad31-7d82db8a5baa"), 50.0, "B", 5, "MOTORCYCLE" },
                    { new Guid("f2e43a54-c44d-4072-bebf-c88962cc0d1b"), new Guid("b185c801-7cf9-4792-925b-96f8471d9c99"), 50.0, "B", 1, "MOTORCYCLE" },
                    { new Guid("f3604413-75f8-43d6-9d72-a015612beceb"), new Guid("599951ba-457b-418b-b563-98eb4b0420f6"), 300.0, "B", 6, "TRUCK" },
                    { new Guid("f38fcd51-2fd4-4497-b64a-0fdfcb4c919c"), new Guid("11137c72-b421-4023-ad31-7d82db8a5baa"), 50.0, "B", 2, "MOTORCYCLE" },
                    { new Guid("f397c2d8-9aa7-45ad-a92c-db3e3347e7a9"), new Guid("5af99c7f-d6bf-4dce-9363-018315d9e1ad"), 50.0, "B", 7, "MOTORCYCLE" },
                    { new Guid("f3c7fe87-9afe-4b0b-8472-bcac1ba1442d"), new Guid("599951ba-457b-418b-b563-98eb4b0420f6"), 300.0, "B", 4, "TRUCK" },
                    { new Guid("f4c378da-7ac0-40a0-a2ad-2f5de2063ef3"), new Guid("599951ba-457b-418b-b563-98eb4b0420f6"), 300.0, "B", 2, "TRUCK" },
                    { new Guid("f55c8bb0-e53b-4c51-8b5b-ebcbf9c04689"), new Guid("736ed698-7b98-41d4-90d4-4d6f13415fba"), 50.0, "B", 6, "MOTORCYCLE" },
                    { new Guid("f5daeed0-36c9-4fcc-ad7f-7e8755607465"), new Guid("fcc43452-25c4-48cb-a440-1cc413ed3422"), 100.0, "A", 1, "CAR" },
                    { new Guid("f62fb2fe-05f2-4c1c-a910-b666c05a6651"), new Guid("438cd333-aa34-4a4d-b514-bbdc4a0cb506"), 300.0, "A", 3, "TRUCK" },
                    { new Guid("f65fc64a-09b8-428b-a1ee-f0b374de8e98"), new Guid("736ed698-7b98-41d4-90d4-4d6f13415fba"), 300.0, "A", 6, "TRUCK" },
                    { new Guid("f674daa5-03f9-4960-8ac7-7bd5b04da58c"), new Guid("603467e3-e23d-41ee-aaef-8d21b2e2da6b"), 200.0, "B", 5, "VAN" },
                    { new Guid("f71496cf-d325-4412-bc77-8821fc6aab9e"), new Guid("1eb3a738-9981-4171-8de2-d3e857a3b8bb"), 300.0, "A", 1, "TRUCK" },
                    { new Guid("f774ba7f-dac1-437e-a246-33af19e76b65"), new Guid("9309c264-dc77-4393-97d5-1f5277643f2b"), 50.0, "A", 8, "MOTORCYCLE" },
                    { new Guid("f7c1890a-0ae7-4692-a366-598206a7b825"), new Guid("b185c801-7cf9-4792-925b-96f8471d9c99"), 50.0, "A", 5, "MOTORCYCLE" },
                    { new Guid("f7e96088-187a-4488-8dd9-772345bda9f4"), new Guid("e85ec22e-df00-4afc-b1fb-2ca408f15d96"), 300.0, "A", 2, "TRUCK" },
                    { new Guid("f84dc11a-cfcf-4de2-a9e7-388ae36f0b10"), new Guid("11137c72-b421-4023-ad31-7d82db8a5baa"), 200.0, "A", 3, "VAN" },
                    { new Guid("f8caf21f-35fa-41ff-9b16-2e5fe4cf3fea"), new Guid("1bc3d521-4279-4b9d-83d2-647d18bc7a50"), 300.0, "A", 1, "TRUCK" },
                    { new Guid("f9fb6e84-669e-41a3-8450-0ed1c8eb5803"), new Guid("11137c72-b421-4023-ad31-7d82db8a5baa"), 200.0, "A", 7, "VAN" },
                    { new Guid("fa0d8080-510e-45e3-a846-896f30cc6f23"), new Guid("1bc3d521-4279-4b9d-83d2-647d18bc7a50"), 50.0, "B", 5, "MOTORCYCLE" },
                    { new Guid("fa141053-18e3-4433-b4b7-af028fcd4001"), new Guid("8452e422-1d9e-418f-9b94-061cbe81e04d"), 100.0, "B", 1, "CAR" },
                    { new Guid("fa392d8d-1396-4199-832b-145e0aff19e6"), new Guid("ab78e541-dbbc-4124-bb86-ceb6d75cb71b"), 300.0, "B", 3, "TRUCK" },
                    { new Guid("fb3da96f-03dc-455e-9e6d-b5a0c87e5dd8"), new Guid("e85ec22e-df00-4afc-b1fb-2ca408f15d96"), 50.0, "B", 1, "MOTORCYCLE" },
                    { new Guid("fb9261b3-a0ef-4997-b58e-a84d9f1f503a"), new Guid("ac366bab-6ac1-4215-a22a-7241bb2c5727"), 50.0, "A", 1, "MOTORCYCLE" },
                    { new Guid("fbb86b18-2829-4421-a2e5-0fcf51402531"), new Guid("fcc43452-25c4-48cb-a440-1cc413ed3422"), 50.0, "B", 8, "MOTORCYCLE" },
                    { new Guid("fc03eaec-38dd-4b63-b817-8f64864cad95"), new Guid("ac366bab-6ac1-4215-a22a-7241bb2c5727"), 300.0, "B", 7, "TRUCK" },
                    { new Guid("fc2d0dd5-aa00-46b0-a5e6-6f5248f0f698"), new Guid("fcc43452-25c4-48cb-a440-1cc413ed3422"), 100.0, "A", 5, "CAR" },
                    { new Guid("fd1a7ce7-c4d3-4c15-be40-94d2c114f3df"), new Guid("fcc43452-25c4-48cb-a440-1cc413ed3422"), 100.0, "A", 7, "CAR" },
                    { new Guid("fd24d496-b38a-4103-bd8b-f46b9e35bf5d"), new Guid("99372c3d-5903-4a9c-b0b9-0cd15f55658e"), 200.0, "B", 2, "VAN" },
                    { new Guid("fd4cb69a-07ee-4c3a-9469-88f2e74acc45"), new Guid("fe712484-2abf-43e2-a9f7-e67b9d2f0d04"), 300.0, "B", 2, "TRUCK" },
                    { new Guid("fea0dbbf-7c5e-436e-96eb-91c946a1f0de"), new Guid("ac366bab-6ac1-4215-a22a-7241bb2c5727"), 300.0, "B", 8, "TRUCK" },
                    { new Guid("ff0b04ac-8afd-46ee-8aea-b02ec8368576"), new Guid("e515ae1f-6859-4ea3-9dd9-8fb9d224f8c8"), 200.0, "B", 6, "VAN" },
                    { new Guid("ff64d72d-7eeb-4d24-a2de-b6d7d269b8b5"), new Guid("a669c2aa-41e8-4ff2-b1bf-6dc0ba156402"), 100.0, "B", 3, "CAR" },
                    { new Guid("ffa21caa-d084-4e81-bf2a-ad318c685199"), new Guid("b5ce9eb5-9343-475e-922b-8d2d1494b13f"), 100.0, "B", 5, "CAR" },
                    { new Guid("ffe6c88d-5b90-4803-b36b-a21565056466"), new Guid("e0bcde6c-3c72-4b55-a18f-f84fd8581131"), 300.0, "A", 3, "TRUCK" }
                });

            migrationBuilder.InsertData(
                table: "Bookings",
                columns: new[] { "Id", "CreatedAt", "EndDate", "ParkingSpaceId", "Passcode", "PhoneNumber", "PricePerHour", "StartDate", "Status", "StripePaymentSessionId", "TotalPrice", "UpdatedAt", "UserId", "VehicleNumber" },
                values: new object[,]
                {
                    { new Guid("1d9646c1-7209-42b3-b8b3-b18af522b85f"), new DateTime(2025, 1, 5, 15, 57, 2, 143, DateTimeKind.Utc).AddTicks(9079), new DateTime(2025, 2, 10, 3, 0, 0, 0, DateTimeKind.Unspecified), new Guid("80158100-aca5-4646-9b0b-a818fb9a66ce"), "B5GDSJ", "+8801165392863", 300.0, new DateTime(2025, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "PENDING", null, 900.0, new DateTime(2025, 1, 5, 15, 57, 2, 143, DateTimeKind.Utc).AddTicks(9117), new Guid("d398d70f-259b-4b9f-b93d-f51254b9c4d7"), "X4RL4FJBY8AQ37693" },
                    { new Guid("26787fe2-efc2-4d83-9fcf-66da1d5e0e4c"), new DateTime(2025, 1, 5, 15, 57, 2, 78, DateTimeKind.Utc).AddTicks(5460), new DateTime(2025, 1, 10, 3, 0, 0, 0, DateTimeKind.Unspecified), new Guid("5571c0af-39d6-4a12-b2e8-8d23086fe1c7"), "I47QX1", "+8801006819451", 100.0, new DateTime(2025, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "CANCELLED", null, 300.0, new DateTime(2025, 1, 5, 15, 57, 2, 78, DateTimeKind.Utc).AddTicks(5497), new Guid("d398d70f-259b-4b9f-b93d-f51254b9c4d7"), "OC58B8FECPS216517" },
                    { new Guid("3127a72a-1b69-4d69-9b9f-c91cf66e6af0"), new DateTime(2025, 1, 5, 15, 57, 1, 997, DateTimeKind.Utc).AddTicks(1462), new DateTime(2025, 2, 1, 3, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3359881d-43d8-4ab7-a493-c0f09ac8ca16"), "VYO8TE", "+8801200728476", 100.0, new DateTime(2025, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "PENDING", null, 300.0, new DateTime(2025, 1, 5, 15, 57, 1, 997, DateTimeKind.Utc).AddTicks(1521), new Guid("d398d70f-259b-4b9f-b93d-f51254b9c4d7"), "OQK31Z3KDSQC20041" },
                    { new Guid("34d31b9a-33af-4a2f-803a-41892409fe5a"), new DateTime(2025, 1, 5, 15, 57, 2, 67, DateTimeKind.Utc).AddTicks(7873), new DateTime(2025, 2, 10, 3, 0, 0, 0, DateTimeKind.Unspecified), new Guid("05797788-d09b-4495-93cd-61110c39b6d3"), "H28ZNX", "+8801935614373", 50.0, new DateTime(2025, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "PENDING", null, 150.0, new DateTime(2025, 1, 5, 15, 57, 2, 67, DateTimeKind.Utc).AddTicks(7911), new Guid("d398d70f-259b-4b9f-b93d-f51254b9c4d7"), "JQUXUOC434H712101" },
                    { new Guid("3be758c6-d740-4c1f-9e68-fbc794df94fb"), new DateTime(2025, 1, 5, 15, 57, 2, 38, DateTimeKind.Utc).AddTicks(9), new DateTime(2025, 1, 1, 3, 0, 0, 0, DateTimeKind.Unspecified), new Guid("0198067d-e43d-4ee8-98ed-78cdfb16127e"), "DEBXLZ", "+8801419693695", 100.0, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "CONFIRMED", null, 300.0, new DateTime(2025, 1, 5, 15, 57, 2, 38, DateTimeKind.Utc).AddTicks(48), new Guid("d398d70f-259b-4b9f-b93d-f51254b9c4d7"), "N5CWJS543QB031616" },
                    { new Guid("3e38930b-9039-4573-a289-047554aecdf7"), new DateTime(2025, 1, 5, 15, 57, 2, 196, DateTimeKind.Utc).AddTicks(1347), new DateTime(2025, 1, 10, 1, 0, 0, 0, DateTimeKind.Unspecified), new Guid("a3960301-298c-46d1-aa04-5d9da60b9cdb"), "VPBDR8", "+8801009020342", 100.0, new DateTime(2025, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "CONFIRMED", null, 100.0, new DateTime(2025, 1, 5, 15, 57, 2, 196, DateTimeKind.Utc).AddTicks(1421), new Guid("d398d70f-259b-4b9f-b93d-f51254b9c4d7"), "D4Q6FR30KNF387395" },
                    { new Guid("51e0c21d-b3dc-4ed1-8ff9-52991f621cf7"), new DateTime(2025, 1, 5, 15, 57, 1, 976, DateTimeKind.Utc).AddTicks(662), new DateTime(2025, 2, 1, 3, 0, 0, 0, DateTimeKind.Unspecified), new Guid("04bc6985-a3b0-42b8-9489-8c51f2a767ad"), "R5SV34", "+8801208553526", 50.0, new DateTime(2025, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "CANCELLED", null, 150.0, new DateTime(2025, 1, 5, 15, 57, 1, 976, DateTimeKind.Utc).AddTicks(830), new Guid("d398d70f-259b-4b9f-b93d-f51254b9c4d7"), "0CDXBJ4AGYRU26334" },
                    { new Guid("544b1d80-19cb-40a0-b972-da34ea52502e"), new DateTime(2025, 1, 5, 15, 57, 2, 51, DateTimeKind.Utc).AddTicks(899), new DateTime(2025, 1, 1, 1, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c659421d-3a4f-4f93-b5cc-e35b0298d649"), "2IC35P", "+8801664049313", 50.0, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "PENDING", null, 50.0, new DateTime(2025, 1, 5, 15, 57, 2, 51, DateTimeKind.Utc).AddTicks(936), new Guid("d398d70f-259b-4b9f-b93d-f51254b9c4d7"), "GDWRHWVSTHO447946" },
                    { new Guid("596784c5-b4c1-4af9-a4f8-2f5a3fdfc34d"), new DateTime(2025, 1, 5, 15, 57, 2, 100, DateTimeKind.Utc).AddTicks(2492), new DateTime(2025, 1, 10, 3, 0, 0, 0, DateTimeKind.Unspecified), new Guid("333e0f0c-5327-4d20-af23-74d79ac2539d"), "F13DLC", "+8801644995969", 300.0, new DateTime(2025, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "VEHICLE_CHECKED_IN", null, 900.0, new DateTime(2025, 1, 5, 15, 57, 2, 100, DateTimeKind.Utc).AddTicks(2527), new Guid("d398d70f-259b-4b9f-b93d-f51254b9c4d7"), "8EBCEXUTWOEZ39868" },
                    { new Guid("5d60ee89-1dd6-4f29-9ef9-f89d42922ee5"), new DateTime(2025, 1, 5, 15, 57, 2, 132, DateTimeKind.Utc).AddTicks(5590), new DateTime(2025, 2, 10, 3, 0, 0, 0, DateTimeKind.Unspecified), new Guid("62b37eec-de31-4d7d-9e2c-8c743e959306"), "W00756", "+8801007904159", 50.0, new DateTime(2025, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "VEHICLE_CHECKED_IN", null, 150.0, new DateTime(2025, 1, 5, 15, 57, 2, 132, DateTimeKind.Utc).AddTicks(5626), new Guid("d398d70f-259b-4b9f-b93d-f51254b9c4d7"), "1EBFXH6REFT843714" },
                    { new Guid("5f853f7c-de2c-4a04-824e-3bf3cec6cafc"), new DateTime(2025, 1, 5, 15, 57, 2, 111, DateTimeKind.Utc).AddTicks(3489), new DateTime(2025, 1, 1, 1, 0, 0, 0, DateTimeKind.Unspecified), new Guid("81b0e497-de75-47e8-870a-867d817c12e7"), "SHKN9T", "+8801262325096", 100.0, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "CONFIRMED", null, 100.0, new DateTime(2025, 1, 5, 15, 57, 2, 111, DateTimeKind.Utc).AddTicks(3525), new Guid("d398d70f-259b-4b9f-b93d-f51254b9c4d7"), "6K20QRX7GSIY18376" },
                    { new Guid("6265e502-2601-40b8-972d-095c04334f8e"), new DateTime(2025, 1, 5, 15, 57, 1, 960, DateTimeKind.Utc).AddTicks(5652), new DateTime(2025, 2, 10, 1, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4f6a8680-9d91-4972-aa94-43f7a86cb417"), "H8J4RG", "+8801908904787", 50.0, new DateTime(2025, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "CANCELLED", null, 50.0, new DateTime(2025, 1, 5, 15, 57, 1, 960, DateTimeKind.Utc).AddTicks(6860), new Guid("d398d70f-259b-4b9f-b93d-f51254b9c4d7"), "UR5Z45LXMNF880357" },
                    { new Guid("6a16f76a-6237-425d-b0a9-4120d05fc8c4"), new DateTime(2025, 1, 5, 15, 57, 2, 154, DateTimeKind.Utc).AddTicks(9564), new DateTime(2025, 2, 10, 3, 0, 0, 0, DateTimeKind.Unspecified), new Guid("6a1c00cc-4c87-4551-8931-4db3c364e81c"), "3WKQKN", "+8801707262368", 50.0, new DateTime(2025, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "PENDING", null, 150.0, new DateTime(2025, 1, 5, 15, 57, 2, 154, DateTimeKind.Utc).AddTicks(9602), new Guid("d398d70f-259b-4b9f-b93d-f51254b9c4d7"), "2B5KQQT1P4QS19859" },
                    { new Guid("a14a4254-0772-4f71-a1bb-6aa7b250ea24"), new DateTime(2025, 1, 5, 15, 57, 2, 12, DateTimeKind.Utc).AddTicks(7614), new DateTime(2025, 1, 1, 3, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e4bb636a-6455-4dd5-80ce-858cd7b9ca6b"), "07RAU1", "+8801001332603", 50.0, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "VEHICLE_CHECKED_IN", null, 150.0, new DateTime(2025, 1, 5, 15, 57, 2, 12, DateTimeKind.Utc).AddTicks(7684), new Guid("d398d70f-259b-4b9f-b93d-f51254b9c4d7"), "RCWM20XU28C014513" },
                    { new Guid("b67cff75-577f-41ef-90fa-5d93d85cd686"), new DateTime(2025, 1, 5, 15, 57, 2, 177, DateTimeKind.Utc).AddTicks(9957), new DateTime(2025, 2, 1, 1, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4ecd5b1b-83eb-4584-8508-20f817bbdfce"), "PJR85J", "+8801821888579", 200.0, new DateTime(2025, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "CANCELLED", null, 200.0, new DateTime(2025, 1, 5, 15, 57, 2, 177, DateTimeKind.Utc).AddTicks(9993), new Guid("d398d70f-259b-4b9f-b93d-f51254b9c4d7"), "NSB1GTPW2LMF89278" },
                    { new Guid("b8964035-ba7b-4880-aa54-d09b158f2012"), new DateTime(2025, 1, 5, 15, 57, 2, 26, DateTimeKind.Utc).AddTicks(9207), new DateTime(2025, 1, 1, 3, 0, 0, 0, DateTimeKind.Unspecified), new Guid("7c146bc4-5207-4c98-a35d-499d6c9193be"), "GR06HS", "+8801205731086", 300.0, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "CONFIRMED", null, 900.0, new DateTime(2025, 1, 5, 15, 57, 2, 26, DateTimeKind.Utc).AddTicks(9251), new Guid("d398d70f-259b-4b9f-b93d-f51254b9c4d7"), "TGWPBF69O2DH73960" },
                    { new Guid("c9824d18-5012-4caa-91a0-4f250b29f11e"), new DateTime(2025, 1, 5, 15, 57, 2, 121, DateTimeKind.Utc).AddTicks(7918), new DateTime(2025, 1, 1, 1, 0, 0, 0, DateTimeKind.Unspecified), new Guid("f2e43a54-c44d-4072-bebf-c88962cc0d1b"), "8JCZVW", "+8801924363261", 50.0, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "CANCELLED", null, 50.0, new DateTime(2025, 1, 5, 15, 57, 2, 121, DateTimeKind.Utc).AddTicks(7965), new Guid("d398d70f-259b-4b9f-b93d-f51254b9c4d7"), "1LYL58MYSCA743444" },
                    { new Guid("ce040175-2666-4f00-9a53-33eba67d837d"), new DateTime(2025, 1, 5, 15, 57, 2, 166, DateTimeKind.Utc).AddTicks(4475), new DateTime(2025, 1, 10, 1, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c317457e-c212-45a8-a033-ba03060180f1"), "XM5L7B", "+8801810523330", 300.0, new DateTime(2025, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "CONFIRMED", null, 300.0, new DateTime(2025, 1, 5, 15, 57, 2, 166, DateTimeKind.Utc).AddTicks(4512), new Guid("d398d70f-259b-4b9f-b93d-f51254b9c4d7"), "FGDPZWJYA4NN41953" },
                    { new Guid("e621854b-732a-45b0-8c37-402b266f5751"), new DateTime(2025, 1, 5, 15, 57, 2, 217, DateTimeKind.Utc).AddTicks(3390), new DateTime(2025, 1, 1, 3, 0, 0, 0, DateTimeKind.Unspecified), new Guid("f4c378da-7ac0-40a0-a2ad-2f5de2063ef3"), "POU3EW", "+8801923398339", 300.0, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "CANCELLED", null, 900.0, new DateTime(2025, 1, 5, 15, 57, 2, 217, DateTimeKind.Utc).AddTicks(3461), new Guid("d398d70f-259b-4b9f-b93d-f51254b9c4d7"), "XAVALP369TQD55403" },
                    { new Guid("fa1c3798-565d-4ecd-985f-d1b104698e10"), new DateTime(2025, 1, 5, 15, 57, 2, 89, DateTimeKind.Utc).AddTicks(2038), new DateTime(2025, 2, 10, 1, 0, 0, 0, DateTimeKind.Unspecified), new Guid("45bdf08d-a6d1-436e-affa-140d585e3308"), "6XN0V9", "+8801486389484", 100.0, new DateTime(2025, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "CONFIRMED", null, 100.0, new DateTime(2025, 1, 5, 15, 57, 2, 89, DateTimeKind.Utc).AddTicks(2075), new Guid("d398d70f-259b-4b9f-b93d-f51254b9c4d7"), "RB4RUU5QI4JE90795" }
                });
        }
    }
}
