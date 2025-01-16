using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class test_model : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "TestDBs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Value = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestDBs", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("0395b4e6-c154-4f41-b27d-7fec42f2cc63"), null, "Admin", "ADMIN" },
                    { new Guid("260bff3e-a0d6-490c-8664-5bad14379098"), null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedAt", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("83cd26b0-6fcc-47e4-ac26-181f60fae47a"), 0, "1234567890", new DateTime(2025, 1, 16, 15, 8, 12, 377, DateTimeKind.Local).AddTicks(2856), "faker@example.com", true, "faker", "faker", false, null, "FAKER@example.com", "FAKER", "1234567890", "1234567890", false, "1234567890", false, "faker" });

            migrationBuilder.InsertData(
                table: "ParkingLots",
                columns: new[] { "Id", "Address", "Description", "Latitude", "Longitude", "Name" },
                values: new object[,]
                {
                    { new Guid("04b75293-d378-4ee1-b298-9f723aa1e4bf"), "61782 Marshall Stream, West Tre, Nicaragua", "Iure consequatur est est aspernatur voluptatibus odio quod inventore.", 23.886963151320199, 89.110833971248965, "McLaughlin - Cartwright" },
                    { new Guid("0b1a89a0-0f56-47cf-8cf8-6e15ec4f04ef"), "06063 Opal Key, Mateotown, United States Minor Outlying Islands", "Quod laboriosam incidunt cumque repudiandae.", 23.744607529305394, 90.450058952526192, "Mraz - Muller" },
                    { new Guid("0e1cf06a-2c1f-4f3a-804f-0a21ca76a827"), "77545 Andy Shore, Lake Drakemouth, Vanuatu", "Consequatur aut quo beatae tempore non ducimus voluptatem velit.", 23.896641758193713, 89.106476032048519, "Koss - Gutkowski" },
                    { new Guid("0e6822f5-7394-400d-bca7-a4cc4dd28978"), "3533 Altenwerth Track, Naderborough, Mauritius", "Aut pariatur autem dolorem.", 23.895706942342539, 89.144225756125337, "Schinner Group" },
                    { new Guid("0ea2b9de-200d-4f13-b796-bd86c412194b"), "251 Wellington Avenue, Jerodville, Cape Verde", "Ducimus praesentium expedita et quae vitae.", 23.740834056999706, 90.432612713074647, "Runolfsson Inc" },
                    { new Guid("13d8bc75-3ef2-4d55-a2bd-ffc7a683e7e4"), "214 Asia Forks, Lindaport, Botswana", "Voluptatem tempora consequuntur iusto est aspernatur.", 23.902347182710407, 89.110097856109462, "Lakin, Schaefer and Weissnat" },
                    { new Guid("14f021ba-4e08-416b-8751-e5d09e9b107d"), "3637 Alexys Stravenue, Port Eriberto, Macedonia", "Architecto molestiae similique temporibus omnis quibusdam expedita dolores.", 23.744807939955745, 90.354078099933673, "Daniel Group" },
                    { new Guid("15e5b2e9-d51f-4413-9a87-0a8051c82ff4"), "56643 Joany Ways, South Dino, Haiti", "Ipsa non ab.", 23.888738089423402, 89.135145156477378, "Kuhic, Rohan and McKenzie" },
                    { new Guid("18bb3ced-ef4c-4990-902d-9ccdbee03709"), "42484 Renner Course, Luratown, Czech Republic", "Nesciunt dignissimos consequatur et esse.", 23.891753881513758, 89.109193448973286, "Casper - Armstrong" },
                    { new Guid("2aedce44-d62f-4847-a9ad-2245b9d31387"), "355 Ritchie Underpass, East Gwenfort, Hong Kong", "Soluta perspiciatis ea omnis dolores et totam quia occaecati nisi.", 23.739299610835918, 90.37097653361738, "Strosin LLC" },
                    { new Guid("30fd900a-27d9-4682-b5e2-db8c76e2062b"), "635 Annalise Street, Maciland, French Polynesia", "Aperiam mollitia aut vitae pariatur rerum consequuntur voluptas eos.", 23.777112989139372, 90.454366417271217, "Schmidt, Schmeler and Jerde" },
                    { new Guid("325cdcfb-5542-41fb-bca0-5aec0a1f8209"), "76274 Beverly Motorway, South Providenciborough, Maldives", "Ad ut officia in sit voluptatum similique animi eum.", 23.898194557002775, 89.114073302796484, "Gleichner LLC" },
                    { new Guid("37b1553e-e0cc-460c-b0a8-d72fea93dadc"), "821 Cristian Mall, Lake Claudmouth, Afghanistan", "Accusamus inventore in ullam assumenda id officiis porro quam.", 23.903605465319707, 89.122489829862914, "Harvey - Homenick" },
                    { new Guid("40448bf3-c284-402d-a1bf-7593c2d267c4"), "2610 Jamie Fall, Blancheburgh, Lao People's Democratic Republic", "Tempora sapiente necessitatibus in sed ut aut similique quaerat.", 23.787042514589427, 90.382590233959448, "Herzog Group" },
                    { new Guid("454290bd-e2c7-4154-b980-cc091b14465d"), "1533 Cruickshank Oval, Ratkebury, Azerbaijan", "Qui voluptatibus recusandae recusandae qui voluptate ducimus nesciunt sint velit.", 23.895472858518012, 89.155633860681021, "Carroll - Price" },
                    { new Guid("47569aaa-bf51-4525-832e-9153120d433e"), "1993 Terry Gateway, Port Gilbert, Kiribati", "Ducimus recusandae et ex minus omnis.", 23.762273661672754, 90.343297492865759, "Paucek and Sons" },
                    { new Guid("4bbdfefd-5984-4fd5-ad27-04ef0d85ef60"), "73639 Rudy Mountains, Effertzchester, Ghana", "Tenetur ipsa sit enim iste.", 23.89576733054232, 89.156462022910517, "Murphy and Sons" },
                    { new Guid("4f8943b0-c325-4306-8872-c0687a860552"), "3160 O'Hara Ford, Hagenesberg, Tunisia", "Debitis eaque architecto.", 23.774626974219071, 90.401580887526663, "Waelchi - Altenwerth" },
                    { new Guid("516e7943-059a-44cc-bd82-d4c4480a6676"), "5213 Rubye Lock, Albertostad, Saint Lucia", "Delectus iure labore.", 23.909394582012933, 89.137666058755883, "Crooks LLC" },
                    { new Guid("561ae673-4668-49b7-81ca-2fc792ab1b3e"), "585 Nya Village, Port Elbert, Cote d'Ivoire", "Dolores dignissimos repudiandae reiciendis rerum fuga natus.", 23.884899757633583, 89.140081538460862, "Terry Group" },
                    { new Guid("564ba9ef-c816-47d7-a41b-a7b061183905"), "35367 Walker Trafficway, New Moises, Cayman Islands", "Deleniti rerum occaecati neque ad minima qui sed est et.", 23.905156803487536, 89.127996584931395, "Rosenbaum Inc" },
                    { new Guid("5a1062de-7895-4914-b081-cc7ff9e007e7"), "341 Susie Meadow, New Birdie, Haiti", "Laudantium nesciunt voluptatibus sit perspiciatis.", 23.744686586367532, 90.359098305510159, "Hansen - Feil" },
                    { new Guid("60bf0a3a-02aa-4218-8e61-a5dd00e5e0d4"), "480 Heller Locks, South Montana, Jamaica", "Harum praesentium qui error adipisci dolore earum.", 23.909005565431748, 89.15660193247605, "Hirthe Group" },
                    { new Guid("66af1e03-1839-46f2-a5b1-999c4f3a5b30"), "121 Danielle Bridge, Dylanberg, Guinea-Bissau", "Dicta quia qui quia sit voluptates.", 23.778841095595737, 90.410962085675692, "Legros, Barrows and Corkery" },
                    { new Guid("66ccfd45-4738-48da-ac09-400c1a1a26bb"), "959 Satterfield Ridge, Lake Tianna, Philippines", "Id quod et repudiandae.", 23.783849223082804, 90.431956750572382, "Boyer - Koss" },
                    { new Guid("6834e8ac-9efa-4f21-a027-d8ae1c1b973e"), "958 Beer Mountains, Kendrabury, Malaysia", "Vitae molestias omnis non.", 23.887040929302092, 89.151012549676878, "Ryan Inc" },
                    { new Guid("76a04e41-7aa0-46e2-8c27-0b677cde6543"), "49546 Mohamed Way, Halieborough, French Polynesia", "At nemo ad ullam nostrum.", 23.752810036604714, 90.345453091112773, "Grant, Kautzer and Fay" },
                    { new Guid("7fd19919-4f47-4257-af41-0eaf6d2f3533"), "202 Sim Estates, East Keenan, United States Minor Outlying Islands", "Sit delectus iste nisi eaque at nam voluptas voluptate molestiae.", 23.90545670839467, 89.155027144038684, "Brown, Bailey and Hickle" },
                    { new Guid("88c0746c-384c-48a3-8a24-034a9d11e036"), "6604 Vivianne Village, North Frederic, French Guiana", "Qui qui et tenetur explicabo repellendus tenetur voluptas illo.", 23.757115968031382, 90.360330839451365, "Hoeger, Fisher and Ortiz" },
                    { new Guid("8eda8dbd-513f-49c9-a050-7c8a6e6475d7"), "967 Reggie Cape, New Malachi, Turkey", "Fugiat velit tenetur incidunt.", 23.772081001777639, 90.399221877128042, "Champlin, Romaguera and Wisoky" },
                    { new Guid("9ef7200f-cd79-41e9-ac2b-c0215f0fc9fc"), "743 Runolfsson Streets, Skyemouth, Russian Federation", "Rerum ut sed quas sit dolorem.", 23.897610026026943, 89.142876695870356, "Konopelski - Corwin" },
                    { new Guid("a2702078-cb6b-4d1d-a83a-640674eeeffe"), "9814 Emmy Spurs, North Haley, Djibouti", "Accusamus eligendi porro quibusdam eos.", 23.768456861620994, 90.376302613072923, "Haley - Abbott" },
                    { new Guid("a4cc4c37-d39f-4d36-9a60-2d6404fc97f6"), "3911 Feest Road, Leliaborough, Uzbekistan", "Nostrum tempora numquam modi explicabo omnis tempora dicta eos est.", 23.769739315532139, 90.400831468602604, "Osinski and Sons" },
                    { new Guid("ab2501ec-a3d8-4027-98dd-df99be5a1bf9"), "16682 Lura Walks, West Martine, Mauritius", "Quis culpa dolore sit amet qui placeat ullam numquam velit.", 23.885400973091865, 89.15082944066755, "Kassulke - Bergstrom" },
                    { new Guid("ac8d075d-9942-4f4e-b98f-e8df09ce60d3"), "688 Ellen Valley, North Orval, Costa Rica", "Nisi ea cupiditate occaecati nemo dolor.", 23.897527205391189, 89.131117984267917, "Swaniawski Inc" },
                    { new Guid("ae3959c4-5bca-457d-9c14-4cc88f49d61e"), "398 Emmerich Drive, North Hildaburgh, Brunei Darussalam", "Quis cum incidunt quia praesentium omnis harum.", 23.787712839350917, 90.415913768989583, "O'Kon - Rohan" },
                    { new Guid("b1ad3048-49d6-4a9a-a0f8-d99e3f5f70f5"), "89970 Homenick Vista, Port Sylvia, Brazil", "Et dolor magnam doloribus harum voluptatem.", 23.758637480897324, 90.430103027645075, "Deckow, Considine and McDermott" },
                    { new Guid("b202d20c-9aca-47ab-8c0c-417b0566bc9a"), "59973 Wyman Oval, North Uriahburgh, Cook Islands", "Consequatur et vero numquam vero.", 23.732778975835494, 90.359562715444795, "Jakubowski - Leuschke" },
                    { new Guid("b7048c17-53ab-4005-8a80-eed7f70c6c99"), "540 Emelia Roads, East Chyna, Aruba", "Rerum cupiditate architecto voluptatem quisquam harum fuga eum.", 23.781150381493337, 90.325871376198435, "Hilpert, Stanton and Lind" },
                    { new Guid("b74f87ee-301c-418b-a49a-4a8ebe631eb8"), "1993 Pouros Path, Greenfelderchester, French Polynesia", "Repellendus dolor magnam.", 23.748737963820773, 90.362750976130428, "DuBuque, Corwin and Johns" },
                    { new Guid("bf2771a1-c2c5-496e-beab-9667afd9bbfe"), "790 Lowe Shore, Wisokyberg, Chile", "Reiciendis in error et omnis nesciunt nisi nostrum.", 23.89154509152716, 89.117031893141743, "Auer - Hansen" },
                    { new Guid("bf471c98-2465-4e39-b3a4-a0a56d7f0b0c"), "8067 Boyer Hills, Casperton, Virgin Islands, U.S.", "Corporis sit error veniam.", 23.740808597441148, 90.44065264414715, "Moore, Stiedemann and Waelchi" },
                    { new Guid("c5d2c35b-c774-4f68-bc8b-4b23482c4244"), "2593 Streich Prairie, Hilpertberg, Singapore", "Amet aut ex repellendus ea autem rerum.", 23.774798715773755, 90.418011962770933, "Von and Sons" },
                    { new Guid("c7dca08c-fee9-47a0-bb70-4dc53f2699d0"), "8155 Tremblay Meadows, West Florencio, Philippines", "Velit est odit saepe molestiae commodi voluptatem.", 23.892507510717898, 89.16019847964607, "Gutkowski Group" },
                    { new Guid("cacdb08a-111b-49ab-81b8-13817060e4e8"), "002 Vivian Parkway, Rebekahfort, Mauritius", "Voluptate ipsa molestiae eum laudantium libero dignissimos eligendi assumenda facere.", 23.894922750383909, 89.135686649109942, "Schulist and Sons" },
                    { new Guid("cc8bb9f7-35ca-4c40-8498-8e83c25136cd"), "3104 Odie Lights, Lake Gardner, Bermuda", "Ratione labore magni qui enim ea.", 23.766832314362528, 90.374037918716326, "Sanford and Sons" },
                    { new Guid("cdd98f54-2de4-464d-912e-488674be6f46"), "913 Roosevelt Viaduct, Cummerataburgh, Saint Barthelemy", "Et et enim officia explicabo.", 23.786853006284463, 90.409762922596769, "Koelpin Group" },
                    { new Guid("cfeefc53-67a5-4e6a-a136-330d10920937"), "1440 Bayer View, Lake Toni, Mauritius", "Iusto voluptas et est maiores quis tempore eos et magni.", 23.777089629095698, 90.332005670060568, "Strosin, Rippin and Block" },
                    { new Guid("d12f5883-ab8e-4d3f-a967-ec7675a0ab47"), "67398 Aryanna Mews, Grahamshire, Saint Kitts and Nevis", "Recusandae inventore quidem laboriosam repellat perspiciatis voluptatibus.", 23.898672521296596, 89.116601487614446, "Carter, Sporer and Hodkiewicz" },
                    { new Guid("d76e484e-5fd9-4cf5-8892-f4fcf44654fa"), "498 Marquardt Vista, West Hazelburgh, Cape Verde", "Ad esse et similique optio officiis amet.", 23.761170390007909, 90.334523062650092, "Brekke - Boehm" },
                    { new Guid("d7bcb6e9-67e9-4afc-9d25-f169447500eb"), "431 Erick Mount, Leannonmouth, Croatia", "Aliquid voluptatem dolorum reiciendis rem.", 23.77177509428061, 90.385930131326347, "Cruickshank - Mante" },
                    { new Guid("dec19efa-56f4-4a25-8590-7b1938391756"), "671 Mona Ferry, Asamouth, Eritrea", "Tempore iusto deleniti corrupti.", 23.77074533901299, 90.353615221083501, "Kozey and Sons" },
                    { new Guid("e07be4a4-a28a-4d40-bd21-3371ef69fc0b"), "2046 Fahey Fords, Ziemannchester, Haiti", "Consequatur ut occaecati in neque eveniet possimus ipsum voluptatem quidem.", 23.902862071329917, 89.145593268433586, "Schmitt - O'Hara" },
                    { new Guid("e5dceac8-c4a8-4f0a-b51b-9a305ff65216"), "50249 Monahan Plain, Lake Raquelton, Colombia", "Quia eius nostrum eum.", 23.895994389612753, 89.13535238659982, "Brakus - Okuneva" },
                    { new Guid("eb01d97e-5919-4537-822f-2fff3c6fd84f"), "46231 Kamryn Field, East Cadenshire, Maldives", "Quam aut provident id quae.", 23.754342191204593, 90.442812753438616, "Bernhard Group" },
                    { new Guid("ed42e83a-2e39-4c0c-8803-4b595c801a43"), "05517 Jordi Alley, O'Connermouth, Malawi", "Aperiam a a animi ea qui.", 23.901323323504609, 89.101014173411869, "Hirthe - Weber" },
                    { new Guid("f5882dab-e003-453f-b642-a38560da3beb"), "5670 Witting Oval, New Paulinemouth, Kazakhstan", "Eligendi itaque veritatis voluptatem et rem eos mollitia.", 23.899259657522741, 89.123504970655901, "Block LLC" },
                    { new Guid("f5e07364-5770-4cca-8215-4bc9687928fd"), "562 Dorthy Well, Port Oralville, Svalbard & Jan Mayen Islands", "Est est similique dolorem pariatur.", 23.905674732256664, 89.120898389811032, "Labadie and Sons" },
                    { new Guid("f8fec2b0-96c9-47ff-be70-eee9e7195d60"), "41214 Graham Overpass, Katelynnbury, France", "Cumque et ab nostrum voluptas.", 23.892085063265586, 89.158815862344369, "Lockman, Wiza and Robel" },
                    { new Guid("f92eb003-edbb-4752-9d08-baf8cf0be864"), "27356 Tiana Spring, North Mervinmouth, Cote d'Ivoire", "Nemo esse laborum quaerat incidunt incidunt praesentium debitis eum ea.", 23.89255942590653, 89.110965066381354, "Maggio, Hand and Koepp" }
                });

            migrationBuilder.InsertData(
                table: "TestDBs",
                columns: new[] { "Id", "Value" },
                values: new object[,]
                {
                    { new Guid("0875247d-5736-4546-ab4a-13f208dc09ec"), "suscipit" },
                    { new Guid("10223c37-8da4-4594-9752-b1327bfb3c4c"), "quibusdam" },
                    { new Guid("1af8fea6-9704-4383-96bc-d71eb262515b"), "tempora" },
                    { new Guid("815ad906-f08f-408d-829c-7e7c1dc8380f"), "ut" },
                    { new Guid("909cc88a-5acb-45c9-9151-bbf7bc7b8d1d"), "saepe" },
                    { new Guid("9646947e-d6bc-4f8e-800f-9ca0df886c84"), "non" },
                    { new Guid("9e1e5c7a-4d9f-4ff5-80c9-0dcef2119228"), "exercitationem" },
                    { new Guid("9ed97c16-ef18-4be5-911f-1c6a7d1340e6"), "deserunt" },
                    { new Guid("ccfe72e4-4150-46d7-8f90-d6b24cf36819"), "vitae" },
                    { new Guid("eb9e2d75-c7cc-4b82-ad6c-45a3a4e170c3"), "quod" }
                });

            migrationBuilder.InsertData(
                table: "ParkingSpaces",
                columns: new[] { "Id", "ParkingLotId", "PricePerHour", "SectionName", "SpotNumber", "VehicleType" },
                values: new object[,]
                {
                    { new Guid("0003b395-04b2-44e8-a034-8acb9f246777"), new Guid("e07be4a4-a28a-4d40-bd21-3371ef69fc0b"), 200.0, "A", 6, "VAN" },
                    { new Guid("0015a495-01ca-4352-8084-f71456d0ad34"), new Guid("4f8943b0-c325-4306-8872-c0687a860552"), 200.0, "A", 2, "VAN" },
                    { new Guid("00281306-9d92-4757-af82-d58fcb26b012"), new Guid("d7bcb6e9-67e9-4afc-9d25-f169447500eb"), 100.0, "A", 7, "CAR" },
                    { new Guid("009bb99b-2f79-4f20-991f-9170811e19b6"), new Guid("b7048c17-53ab-4005-8a80-eed7f70c6c99"), 100.0, "A", 7, "CAR" },
                    { new Guid("00c51279-73e6-4046-bc51-a385de764bce"), new Guid("7fd19919-4f47-4257-af41-0eaf6d2f3533"), 100.0, "B", 1, "CAR" },
                    { new Guid("00ebdcf3-0d1e-4d1d-bfe6-8111f6c3d18f"), new Guid("b1ad3048-49d6-4a9a-a0f8-d99e3f5f70f5"), 300.0, "A", 5, "TRUCK" },
                    { new Guid("00f3b677-c594-434b-8445-bb7699a072aa"), new Guid("516e7943-059a-44cc-bd82-d4c4480a6676"), 100.0, "B", 2, "CAR" },
                    { new Guid("00fa5cd2-67e9-47c8-8fb6-0dcc30dfa0a2"), new Guid("37b1553e-e0cc-460c-b0a8-d72fea93dadc"), 300.0, "B", 7, "TRUCK" },
                    { new Guid("017bd424-49ea-4776-a812-36d7d580c289"), new Guid("c5d2c35b-c774-4f68-bc8b-4b23482c4244"), 300.0, "A", 3, "TRUCK" },
                    { new Guid("0237d4a1-1f1c-43bc-8b03-4854746dbb19"), new Guid("f5882dab-e003-453f-b642-a38560da3beb"), 50.0, "A", 8, "MOTORCYCLE" },
                    { new Guid("0243ed01-7dcf-4374-8a38-2d5871f34261"), new Guid("4bbdfefd-5984-4fd5-ad27-04ef0d85ef60"), 200.0, "B", 7, "VAN" },
                    { new Guid("02828525-f31a-46f1-be1c-b1747437e229"), new Guid("0b1a89a0-0f56-47cf-8cf8-6e15ec4f04ef"), 100.0, "B", 5, "CAR" },
                    { new Guid("0285c81e-f07c-49b7-b80d-339f3ba440c0"), new Guid("8eda8dbd-513f-49c9-a050-7c8a6e6475d7"), 200.0, "B", 1, "VAN" },
                    { new Guid("028eb27b-3fa7-45c8-8152-1884864e1614"), new Guid("4bbdfefd-5984-4fd5-ad27-04ef0d85ef60"), 300.0, "A", 1, "TRUCK" },
                    { new Guid("02b086ef-462a-4353-a8f9-bc489f77455d"), new Guid("0e6822f5-7394-400d-bca7-a4cc4dd28978"), 50.0, "A", 4, "MOTORCYCLE" },
                    { new Guid("03473ebf-8943-4da5-8ad6-b0dacf6010d3"), new Guid("cacdb08a-111b-49ab-81b8-13817060e4e8"), 100.0, "A", 1, "CAR" },
                    { new Guid("0353281e-8b60-405f-997c-603fa12cd003"), new Guid("a2702078-cb6b-4d1d-a83a-640674eeeffe"), 300.0, "B", 3, "TRUCK" },
                    { new Guid("03d1e296-dff9-48e5-a271-828be59fb97b"), new Guid("66af1e03-1839-46f2-a5b1-999c4f3a5b30"), 200.0, "A", 7, "VAN" },
                    { new Guid("040a389d-388f-4084-b86c-e47a50023fbc"), new Guid("b7048c17-53ab-4005-8a80-eed7f70c6c99"), 200.0, "B", 4, "VAN" },
                    { new Guid("04229bdb-efa2-447f-b47b-352bebb8009f"), new Guid("cfeefc53-67a5-4e6a-a136-330d10920937"), 100.0, "A", 7, "CAR" },
                    { new Guid("0423166d-70f4-407f-946f-cce2db49621c"), new Guid("cdd98f54-2de4-464d-912e-488674be6f46"), 50.0, "A", 1, "MOTORCYCLE" },
                    { new Guid("043c4de7-3275-4fd0-9dd1-0cb858cf0a81"), new Guid("ab2501ec-a3d8-4027-98dd-df99be5a1bf9"), 300.0, "B", 1, "TRUCK" },
                    { new Guid("050044fc-ee7a-4b8b-8f8a-a898caea6512"), new Guid("d12f5883-ab8e-4d3f-a967-ec7675a0ab47"), 300.0, "A", 8, "TRUCK" },
                    { new Guid("0534b92e-a2a0-4386-b19d-2c6538f3048d"), new Guid("dec19efa-56f4-4a25-8590-7b1938391756"), 300.0, "B", 8, "TRUCK" },
                    { new Guid("060677ec-0a06-4d02-911f-7a3315dd1e49"), new Guid("bf471c98-2465-4e39-b3a4-a0a56d7f0b0c"), 50.0, "A", 1, "MOTORCYCLE" },
                    { new Guid("06216e48-0e75-458b-8489-3459fdf30852"), new Guid("cdd98f54-2de4-464d-912e-488674be6f46"), 300.0, "B", 5, "TRUCK" },
                    { new Guid("0650f2ca-f72e-4570-a5c4-7fd88b2b1d93"), new Guid("0b1a89a0-0f56-47cf-8cf8-6e15ec4f04ef"), 50.0, "A", 3, "MOTORCYCLE" },
                    { new Guid("0674e61e-24f8-4d74-9746-f6ae057d08c1"), new Guid("f92eb003-edbb-4752-9d08-baf8cf0be864"), 100.0, "B", 3, "CAR" },
                    { new Guid("067aa469-ca46-42d0-87de-ed5a3f9c1698"), new Guid("0e1cf06a-2c1f-4f3a-804f-0a21ca76a827"), 50.0, "B", 1, "MOTORCYCLE" },
                    { new Guid("06ee6083-7531-444b-a2a3-24fb31aff620"), new Guid("f8fec2b0-96c9-47ff-be70-eee9e7195d60"), 300.0, "A", 6, "TRUCK" },
                    { new Guid("076b5fca-037e-4212-8b7f-24609ebe8900"), new Guid("a4cc4c37-d39f-4d36-9a60-2d6404fc97f6"), 100.0, "B", 5, "CAR" },
                    { new Guid("07b7ec8c-f282-45f8-9d05-d2dd7fd8f9df"), new Guid("ab2501ec-a3d8-4027-98dd-df99be5a1bf9"), 300.0, "B", 8, "TRUCK" },
                    { new Guid("07c3ecc9-8dc0-44bc-a07c-e2ce4f65af89"), new Guid("7fd19919-4f47-4257-af41-0eaf6d2f3533"), 100.0, "A", 8, "CAR" },
                    { new Guid("07e1e16b-b008-4b2d-9824-3e6807e557dc"), new Guid("18bb3ced-ef4c-4990-902d-9ccdbee03709"), 100.0, "A", 4, "CAR" },
                    { new Guid("07e5694f-ff5b-4193-8d49-6932901df464"), new Guid("f8fec2b0-96c9-47ff-be70-eee9e7195d60"), 300.0, "A", 7, "TRUCK" },
                    { new Guid("08029ab1-6c21-44c3-8c52-62ab81aa085c"), new Guid("47569aaa-bf51-4525-832e-9153120d433e"), 200.0, "B", 6, "VAN" },
                    { new Guid("0848d2ec-1ffa-4858-903f-6c1182802a9f"), new Guid("cc8bb9f7-35ca-4c40-8498-8e83c25136cd"), 300.0, "A", 5, "TRUCK" },
                    { new Guid("08804a04-e055-4084-9ad2-a731ae741da4"), new Guid("2aedce44-d62f-4847-a9ad-2245b9d31387"), 100.0, "A", 8, "CAR" },
                    { new Guid("08b182f6-ac4d-405a-af15-552b31e0c9c0"), new Guid("14f021ba-4e08-416b-8751-e5d09e9b107d"), 100.0, "A", 3, "CAR" },
                    { new Guid("091f8333-d928-4c24-a710-4a113d22e048"), new Guid("04b75293-d378-4ee1-b298-9f723aa1e4bf"), 100.0, "B", 1, "CAR" },
                    { new Guid("0973d7db-fdb3-44cd-bb10-f3f913d55c49"), new Guid("cdd98f54-2de4-464d-912e-488674be6f46"), 300.0, "B", 2, "TRUCK" },
                    { new Guid("09990de3-dd56-4438-afff-bdeabeb0b721"), new Guid("ab2501ec-a3d8-4027-98dd-df99be5a1bf9"), 200.0, "A", 2, "VAN" },
                    { new Guid("09faaf8f-1be4-44ec-96dc-b7d7ef660cac"), new Guid("cacdb08a-111b-49ab-81b8-13817060e4e8"), 200.0, "B", 8, "VAN" },
                    { new Guid("0a39281d-1649-4541-ab31-6a8fe1f6cee6"), new Guid("0ea2b9de-200d-4f13-b796-bd86c412194b"), 50.0, "A", 7, "MOTORCYCLE" },
                    { new Guid("0a684207-beee-4589-8c26-34f94b1a0034"), new Guid("ac8d075d-9942-4f4e-b98f-e8df09ce60d3"), 300.0, "B", 2, "TRUCK" },
                    { new Guid("0aaab760-d33b-41cd-8ead-6cde9ee36e90"), new Guid("e5dceac8-c4a8-4f0a-b51b-9a305ff65216"), 200.0, "A", 7, "VAN" },
                    { new Guid("0aad1606-23c9-44f5-8242-9b7a73347dbb"), new Guid("a4cc4c37-d39f-4d36-9a60-2d6404fc97f6"), 200.0, "A", 5, "VAN" },
                    { new Guid("0ac9138a-984d-4eb5-9a06-31b839a36afd"), new Guid("30fd900a-27d9-4682-b5e2-db8c76e2062b"), 50.0, "B", 1, "MOTORCYCLE" },
                    { new Guid("0af0a5bb-6e90-4443-a669-e085c33ec8df"), new Guid("b202d20c-9aca-47ab-8c0c-417b0566bc9a"), 100.0, "A", 2, "CAR" },
                    { new Guid("0b023820-c166-43e9-8b0a-1d1022968b03"), new Guid("04b75293-d378-4ee1-b298-9f723aa1e4bf"), 100.0, "A", 1, "CAR" },
                    { new Guid("0b046cbd-cd9a-4fd2-8b31-c7929a0d3c3c"), new Guid("60bf0a3a-02aa-4218-8e61-a5dd00e5e0d4"), 50.0, "A", 3, "MOTORCYCLE" },
                    { new Guid("0b1d80b0-5ada-464b-bd28-a6651ffc6b79"), new Guid("325cdcfb-5542-41fb-bca0-5aec0a1f8209"), 300.0, "A", 8, "TRUCK" },
                    { new Guid("0b249cb9-2690-4b11-b843-6eba44f29bd2"), new Guid("f5882dab-e003-453f-b642-a38560da3beb"), 200.0, "B", 5, "VAN" },
                    { new Guid("0b6d02c4-1dad-4a15-8318-fd457fa2c959"), new Guid("2aedce44-d62f-4847-a9ad-2245b9d31387"), 100.0, "A", 7, "CAR" },
                    { new Guid("0bbbe287-4b50-4011-9772-eb208af03a3c"), new Guid("c5d2c35b-c774-4f68-bc8b-4b23482c4244"), 100.0, "B", 4, "CAR" },
                    { new Guid("0c3f87f6-8003-40b0-be65-8bffbf814f42"), new Guid("561ae673-4668-49b7-81ca-2fc792ab1b3e"), 50.0, "A", 5, "MOTORCYCLE" },
                    { new Guid("0d2fca8f-2963-45a6-8475-f8548ee32d9d"), new Guid("2aedce44-d62f-4847-a9ad-2245b9d31387"), 300.0, "B", 1, "TRUCK" },
                    { new Guid("0d4a2fb1-1648-4dc2-86a3-af47b32c9dbd"), new Guid("8eda8dbd-513f-49c9-a050-7c8a6e6475d7"), 200.0, "B", 4, "VAN" },
                    { new Guid("0e2684a3-a184-4e97-95f5-8677a3fc17da"), new Guid("b202d20c-9aca-47ab-8c0c-417b0566bc9a"), 200.0, "B", 1, "VAN" },
                    { new Guid("0e4a2031-a3b0-4a36-a703-350a830ebfdc"), new Guid("ed42e83a-2e39-4c0c-8803-4b595c801a43"), 50.0, "A", 8, "MOTORCYCLE" },
                    { new Guid("0e5b0c4f-a04d-4011-813e-2f965da54a3d"), new Guid("ae3959c4-5bca-457d-9c14-4cc88f49d61e"), 300.0, "A", 7, "TRUCK" },
                    { new Guid("0e81b26f-0d11-4f7e-b745-826f2d737754"), new Guid("b202d20c-9aca-47ab-8c0c-417b0566bc9a"), 200.0, "B", 4, "VAN" },
                    { new Guid("0eaa552a-7081-44e5-a528-8fd0ba2d28e9"), new Guid("5a1062de-7895-4914-b081-cc7ff9e007e7"), 50.0, "A", 3, "MOTORCYCLE" },
                    { new Guid("0ee0ea2d-bbb6-489d-8391-59db14c7c1b6"), new Guid("6834e8ac-9efa-4f21-a027-d8ae1c1b973e"), 200.0, "A", 4, "VAN" },
                    { new Guid("0ef50262-ebb0-4c2a-9126-68c40e0289f8"), new Guid("88c0746c-384c-48a3-8a24-034a9d11e036"), 100.0, "B", 6, "CAR" },
                    { new Guid("0f4fdf95-e8c7-4772-ab39-4703c4335ad9"), new Guid("b7048c17-53ab-4005-8a80-eed7f70c6c99"), 200.0, "B", 1, "VAN" },
                    { new Guid("0f553819-8287-4868-8eb3-da5380015fea"), new Guid("cc8bb9f7-35ca-4c40-8498-8e83c25136cd"), 50.0, "B", 1, "MOTORCYCLE" },
                    { new Guid("0fd61a21-ac5f-4263-8ce7-f3c02bdf9fc3"), new Guid("0e1cf06a-2c1f-4f3a-804f-0a21ca76a827"), 50.0, "B", 3, "MOTORCYCLE" },
                    { new Guid("1087b969-0203-4795-a265-2e583c4b385c"), new Guid("15e5b2e9-d51f-4413-9a87-0a8051c82ff4"), 50.0, "B", 7, "MOTORCYCLE" },
                    { new Guid("109ce311-2069-4f2b-8cf3-1d19ed12d2d2"), new Guid("7fd19919-4f47-4257-af41-0eaf6d2f3533"), 100.0, "B", 6, "CAR" },
                    { new Guid("10b42f99-b658-4d27-a9e5-3729a0519b61"), new Guid("516e7943-059a-44cc-bd82-d4c4480a6676"), 100.0, "B", 5, "CAR" },
                    { new Guid("10cf4676-afc5-4dcf-9c7c-8a71e0379982"), new Guid("f5882dab-e003-453f-b642-a38560da3beb"), 200.0, "B", 8, "VAN" },
                    { new Guid("10d89b76-1535-4569-bdb9-d29e5dc67817"), new Guid("b1ad3048-49d6-4a9a-a0f8-d99e3f5f70f5"), 300.0, "A", 4, "TRUCK" },
                    { new Guid("110779f0-bc27-400e-87f2-73261899c72b"), new Guid("7fd19919-4f47-4257-af41-0eaf6d2f3533"), 100.0, "A", 2, "CAR" },
                    { new Guid("11369e5c-f710-4e2d-9893-81edc1ee6b89"), new Guid("516e7943-059a-44cc-bd82-d4c4480a6676"), 100.0, "B", 1, "CAR" },
                    { new Guid("11dda23b-45dd-4cdb-84f5-f82d5979416b"), new Guid("30fd900a-27d9-4682-b5e2-db8c76e2062b"), 50.0, "B", 3, "MOTORCYCLE" },
                    { new Guid("133c28b2-4a37-4a99-8449-a099baba93b8"), new Guid("4f8943b0-c325-4306-8872-c0687a860552"), 200.0, "A", 1, "VAN" },
                    { new Guid("13c6cdfc-4e68-4f85-beb7-ca7cc0c395d1"), new Guid("0ea2b9de-200d-4f13-b796-bd86c412194b"), 50.0, "A", 5, "MOTORCYCLE" },
                    { new Guid("13d0a381-12ed-4657-bd69-f4d8c0cc2604"), new Guid("15e5b2e9-d51f-4413-9a87-0a8051c82ff4"), 200.0, "A", 6, "VAN" },
                    { new Guid("141c8c66-001a-40a8-ac88-7f8abe170c46"), new Guid("c5d2c35b-c774-4f68-bc8b-4b23482c4244"), 100.0, "B", 2, "CAR" },
                    { new Guid("1475086f-6a34-4a75-8e4a-32f27f2daacc"), new Guid("0ea2b9de-200d-4f13-b796-bd86c412194b"), 300.0, "B", 1, "TRUCK" },
                    { new Guid("1479cc78-81f4-4ac4-9a30-58800a4905a7"), new Guid("cc8bb9f7-35ca-4c40-8498-8e83c25136cd"), 300.0, "A", 2, "TRUCK" },
                    { new Guid("1483d002-dc6a-42ca-ae5b-fd12b444cede"), new Guid("e07be4a4-a28a-4d40-bd21-3371ef69fc0b"), 100.0, "B", 8, "CAR" },
                    { new Guid("1497437d-bf80-42ab-adec-810f37c66b84"), new Guid("18bb3ced-ef4c-4990-902d-9ccdbee03709"), 100.0, "A", 6, "CAR" },
                    { new Guid("14fbca1c-d2a9-40cf-b038-3fb6e77d27ff"), new Guid("88c0746c-384c-48a3-8a24-034a9d11e036"), 100.0, "A", 4, "CAR" },
                    { new Guid("1548d6bf-503d-4c78-9d9f-93ac36447a40"), new Guid("13d8bc75-3ef2-4d55-a2bd-ffc7a683e7e4"), 300.0, "A", 3, "TRUCK" },
                    { new Guid("157664fe-4ada-4818-ab1a-053cf03efc9c"), new Guid("b7048c17-53ab-4005-8a80-eed7f70c6c99"), 100.0, "A", 3, "CAR" },
                    { new Guid("15c978e9-3bfc-4f15-956f-5a21d2910b25"), new Guid("d12f5883-ab8e-4d3f-a967-ec7675a0ab47"), 300.0, "A", 3, "TRUCK" },
                    { new Guid("165c7861-a1d7-4260-afd5-5231bf9c91dd"), new Guid("47569aaa-bf51-4525-832e-9153120d433e"), 200.0, "A", 4, "VAN" },
                    { new Guid("16a6d3b3-b12f-49ed-b7b6-50a8baf30ccd"), new Guid("f92eb003-edbb-4752-9d08-baf8cf0be864"), 100.0, "B", 4, "CAR" },
                    { new Guid("1701fa25-f630-4040-9712-ed577b69c030"), new Guid("cc8bb9f7-35ca-4c40-8498-8e83c25136cd"), 300.0, "A", 8, "TRUCK" },
                    { new Guid("17854d9d-13be-414a-9036-f51d192ba1b5"), new Guid("14f021ba-4e08-416b-8751-e5d09e9b107d"), 100.0, "A", 4, "CAR" },
                    { new Guid("17fbd831-56d1-4d72-bf88-81cbe25e9f16"), new Guid("b202d20c-9aca-47ab-8c0c-417b0566bc9a"), 100.0, "A", 4, "CAR" },
                    { new Guid("183a8484-fadf-4b74-a24a-36c846bba6ba"), new Guid("6834e8ac-9efa-4f21-a027-d8ae1c1b973e"), 200.0, "A", 6, "VAN" },
                    { new Guid("183ae804-0cc9-4004-b52a-9a1a5316f7c7"), new Guid("0e1cf06a-2c1f-4f3a-804f-0a21ca76a827"), 300.0, "A", 8, "TRUCK" },
                    { new Guid("184247fe-b38d-4a3d-9c17-69f8ab83d57a"), new Guid("561ae673-4668-49b7-81ca-2fc792ab1b3e"), 50.0, "A", 8, "MOTORCYCLE" },
                    { new Guid("192fd427-e768-4e29-abe5-6f71e297e626"), new Guid("37b1553e-e0cc-460c-b0a8-d72fea93dadc"), 50.0, "A", 5, "MOTORCYCLE" },
                    { new Guid("19430a60-6de1-4221-af74-b0e8619d9353"), new Guid("ed42e83a-2e39-4c0c-8803-4b595c801a43"), 50.0, "A", 4, "MOTORCYCLE" },
                    { new Guid("19600553-9f46-44c9-ba95-7a465b657dbf"), new Guid("04b75293-d378-4ee1-b298-9f723aa1e4bf"), 100.0, "B", 3, "CAR" },
                    { new Guid("19959850-acd5-4428-b3a7-9b1c29a76438"), new Guid("b74f87ee-301c-418b-a49a-4a8ebe631eb8"), 100.0, "B", 4, "CAR" },
                    { new Guid("19d259a2-86c0-4f7f-8e9b-022288a74a38"), new Guid("564ba9ef-c816-47d7-a41b-a7b061183905"), 200.0, "A", 6, "VAN" },
                    { new Guid("1a07b749-bb94-47b2-85a6-2ac994d97468"), new Guid("ed42e83a-2e39-4c0c-8803-4b595c801a43"), 50.0, "A", 3, "MOTORCYCLE" },
                    { new Guid("1a41cafc-4720-490f-be98-c47804da3fda"), new Guid("ab2501ec-a3d8-4027-98dd-df99be5a1bf9"), 300.0, "B", 6, "TRUCK" },
                    { new Guid("1aa4ded3-c5c6-48b1-a985-26ddd2882681"), new Guid("cacdb08a-111b-49ab-81b8-13817060e4e8"), 100.0, "A", 3, "CAR" },
                    { new Guid("1abb0ad2-ac23-42a1-bee6-648e2b502b58"), new Guid("c7dca08c-fee9-47a0-bb70-4dc53f2699d0"), 100.0, "A", 4, "CAR" },
                    { new Guid("1aeb21bc-3daa-45d3-a00f-8c9e79a5fdd1"), new Guid("561ae673-4668-49b7-81ca-2fc792ab1b3e"), 50.0, "A", 7, "MOTORCYCLE" },
                    { new Guid("1af82acf-c3e5-48e1-9d78-081ef60d00ab"), new Guid("60bf0a3a-02aa-4218-8e61-a5dd00e5e0d4"), 50.0, "B", 7, "MOTORCYCLE" },
                    { new Guid("1b82eccf-26d0-453c-9baa-e7a13368407d"), new Guid("2aedce44-d62f-4847-a9ad-2245b9d31387"), 300.0, "B", 4, "TRUCK" },
                    { new Guid("1bc05c34-c431-450c-838f-9b09e35feac4"), new Guid("b1ad3048-49d6-4a9a-a0f8-d99e3f5f70f5"), 300.0, "A", 1, "TRUCK" },
                    { new Guid("1bc31985-d532-4266-ba7d-e9eb62bf898a"), new Guid("d12f5883-ab8e-4d3f-a967-ec7675a0ab47"), 50.0, "B", 1, "MOTORCYCLE" },
                    { new Guid("1beb42d7-149d-4296-bc24-d66f14600a67"), new Guid("37b1553e-e0cc-460c-b0a8-d72fea93dadc"), 300.0, "B", 1, "TRUCK" },
                    { new Guid("1c517ee0-a08a-4153-988c-e431700667a1"), new Guid("d7bcb6e9-67e9-4afc-9d25-f169447500eb"), 200.0, "B", 8, "VAN" },
                    { new Guid("1ca1c989-af57-45e0-8bc1-30c8aab98fad"), new Guid("b74f87ee-301c-418b-a49a-4a8ebe631eb8"), 50.0, "A", 3, "MOTORCYCLE" },
                    { new Guid("1d38ee94-d80d-429d-a15a-72599fc4972f"), new Guid("d7bcb6e9-67e9-4afc-9d25-f169447500eb"), 200.0, "B", 2, "VAN" },
                    { new Guid("1dd411e9-aea9-4b0f-a2e1-705effb43498"), new Guid("66af1e03-1839-46f2-a5b1-999c4f3a5b30"), 100.0, "B", 8, "CAR" },
                    { new Guid("1e8ca406-d741-466a-bd20-ea313c84228e"), new Guid("a2702078-cb6b-4d1d-a83a-640674eeeffe"), 200.0, "A", 8, "VAN" },
                    { new Guid("1f3fee17-004c-48e8-8a94-d3c521af4bf5"), new Guid("ab2501ec-a3d8-4027-98dd-df99be5a1bf9"), 200.0, "A", 3, "VAN" },
                    { new Guid("1f825d07-d8e7-4d66-be85-f1a67f8d4efe"), new Guid("ac8d075d-9942-4f4e-b98f-e8df09ce60d3"), 100.0, "A", 6, "CAR" },
                    { new Guid("1f8b66ac-d737-44c0-bd05-085804be7dce"), new Guid("f8fec2b0-96c9-47ff-be70-eee9e7195d60"), 300.0, "A", 1, "TRUCK" },
                    { new Guid("1fdb8cd3-70a5-4b0b-8ffd-3ba83ddd7603"), new Guid("13d8bc75-3ef2-4d55-a2bd-ffc7a683e7e4"), 300.0, "B", 8, "TRUCK" },
                    { new Guid("20523c80-9b71-45e2-a7f6-758ddb727311"), new Guid("c5d2c35b-c774-4f68-bc8b-4b23482c4244"), 300.0, "A", 2, "TRUCK" },
                    { new Guid("208e3f0c-b2fd-42bf-adf4-9546fd1422a3"), new Guid("76a04e41-7aa0-46e2-8c27-0b677cde6543"), 100.0, "B", 2, "CAR" },
                    { new Guid("2090cae6-237c-46c8-bf34-174ddad1c858"), new Guid("f92eb003-edbb-4752-9d08-baf8cf0be864"), 100.0, "B", 5, "CAR" },
                    { new Guid("209323e5-f54c-4630-a116-88f5833ef13c"), new Guid("66ccfd45-4738-48da-ac09-400c1a1a26bb"), 100.0, "B", 6, "CAR" },
                    { new Guid("20b56e59-f7c7-4f69-bd65-80d1eba9e4e1"), new Guid("60bf0a3a-02aa-4218-8e61-a5dd00e5e0d4"), 50.0, "B", 1, "MOTORCYCLE" },
                    { new Guid("211f4db6-244a-4af2-be8b-d4823d74daeb"), new Guid("bf2771a1-c2c5-496e-beab-9667afd9bbfe"), 100.0, "A", 2, "CAR" },
                    { new Guid("217da0bd-a8c1-49db-b15d-7cf24593d7e3"), new Guid("4f8943b0-c325-4306-8872-c0687a860552"), 300.0, "B", 7, "TRUCK" },
                    { new Guid("2197ce9a-50dd-4b70-90b3-ce843dfdcec3"), new Guid("d7bcb6e9-67e9-4afc-9d25-f169447500eb"), 200.0, "B", 6, "VAN" },
                    { new Guid("219f0ff5-e223-4dad-910d-1f9b3fad6ce2"), new Guid("b74f87ee-301c-418b-a49a-4a8ebe631eb8"), 50.0, "A", 8, "MOTORCYCLE" },
                    { new Guid("21e264c7-dab7-46ab-b546-f4758b8c736d"), new Guid("eb01d97e-5919-4537-822f-2fff3c6fd84f"), 50.0, "A", 8, "MOTORCYCLE" },
                    { new Guid("220a34bf-4b63-4ca7-b201-a3a2ce3e6bfe"), new Guid("a2702078-cb6b-4d1d-a83a-640674eeeffe"), 200.0, "A", 5, "VAN" },
                    { new Guid("2269ff49-ae15-48f4-abbb-82a3cc245158"), new Guid("a4cc4c37-d39f-4d36-9a60-2d6404fc97f6"), 200.0, "A", 1, "VAN" },
                    { new Guid("22cb777d-ca21-4d02-8b02-8ccd6be23709"), new Guid("e5dceac8-c4a8-4f0a-b51b-9a305ff65216"), 200.0, "A", 3, "VAN" },
                    { new Guid("232bcb3b-38c2-4166-8a25-ba8affb296de"), new Guid("4bbdfefd-5984-4fd5-ad27-04ef0d85ef60"), 300.0, "A", 4, "TRUCK" },
                    { new Guid("234d100d-81c8-42ac-82cb-429e39fce2c2"), new Guid("cfeefc53-67a5-4e6a-a136-330d10920937"), 50.0, "B", 8, "MOTORCYCLE" },
                    { new Guid("23bcaccb-add3-4a48-9f52-4db10ebbf7a9"), new Guid("b1ad3048-49d6-4a9a-a0f8-d99e3f5f70f5"), 300.0, "A", 8, "TRUCK" },
                    { new Guid("2452326d-cedc-40b5-9da5-d4e35b567250"), new Guid("ae3959c4-5bca-457d-9c14-4cc88f49d61e"), 100.0, "B", 3, "CAR" },
                    { new Guid("24adf949-3ece-4938-b1ca-623b0a5d7d2a"), new Guid("37b1553e-e0cc-460c-b0a8-d72fea93dadc"), 300.0, "B", 2, "TRUCK" },
                    { new Guid("257802e7-9152-47d9-8942-04ed78079fd4"), new Guid("13d8bc75-3ef2-4d55-a2bd-ffc7a683e7e4"), 300.0, "A", 7, "TRUCK" },
                    { new Guid("2584c9d6-4458-4a64-b9f4-399f34bd98a8"), new Guid("15e5b2e9-d51f-4413-9a87-0a8051c82ff4"), 200.0, "A", 1, "VAN" },
                    { new Guid("25b9ae0b-9e8e-4cb9-be55-a6b9e68ed412"), new Guid("13d8bc75-3ef2-4d55-a2bd-ffc7a683e7e4"), 300.0, "A", 1, "TRUCK" },
                    { new Guid("25c931a3-0b8c-4415-8a07-fc15e8eda6c2"), new Guid("88c0746c-384c-48a3-8a24-034a9d11e036"), 100.0, "A", 7, "CAR" },
                    { new Guid("26610d47-2303-4045-95bf-f8ceb5b3e3ee"), new Guid("cc8bb9f7-35ca-4c40-8498-8e83c25136cd"), 50.0, "B", 5, "MOTORCYCLE" },
                    { new Guid("26b298ba-6190-4cc9-8995-0dbda3f27719"), new Guid("f5e07364-5770-4cca-8215-4bc9687928fd"), 300.0, "A", 3, "TRUCK" },
                    { new Guid("27090145-8171-4a95-b83b-958e2b8596ae"), new Guid("e5dceac8-c4a8-4f0a-b51b-9a305ff65216"), 200.0, "B", 3, "VAN" },
                    { new Guid("271a15cc-52d2-4f1b-abe9-7393907624a5"), new Guid("7fd19919-4f47-4257-af41-0eaf6d2f3533"), 100.0, "B", 7, "CAR" },
                    { new Guid("2766c231-0cc1-4dcc-91a6-1429c888505e"), new Guid("325cdcfb-5542-41fb-bca0-5aec0a1f8209"), 300.0, "A", 7, "TRUCK" },
                    { new Guid("2786f240-a3ba-4665-8ae8-fe7a488d2709"), new Guid("516e7943-059a-44cc-bd82-d4c4480a6676"), 100.0, "A", 8, "CAR" },
                    { new Guid("27e5bcf8-cb0e-402e-8ac1-3152cefd1f7c"), new Guid("d76e484e-5fd9-4cf5-8892-f4fcf44654fa"), 50.0, "A", 1, "MOTORCYCLE" },
                    { new Guid("290d49b9-7809-4317-89f8-9e384548ebac"), new Guid("30fd900a-27d9-4682-b5e2-db8c76e2062b"), 50.0, "B", 2, "MOTORCYCLE" },
                    { new Guid("296d0d21-118d-47f9-8757-233c55ecd6e8"), new Guid("561ae673-4668-49b7-81ca-2fc792ab1b3e"), 50.0, "B", 8, "MOTORCYCLE" },
                    { new Guid("2a302eb5-e11b-47c3-b02d-19de14cbaa34"), new Guid("14f021ba-4e08-416b-8751-e5d09e9b107d"), 300.0, "B", 3, "TRUCK" },
                    { new Guid("2a4d200f-9d9b-4efa-9cf3-38b1180f85da"), new Guid("0e1cf06a-2c1f-4f3a-804f-0a21ca76a827"), 300.0, "A", 2, "TRUCK" },
                    { new Guid("2ad0a60a-ccb5-43c6-ba2a-11c9fcb6e9d6"), new Guid("c7dca08c-fee9-47a0-bb70-4dc53f2699d0"), 300.0, "B", 1, "TRUCK" },
                    { new Guid("2b015cd8-3ec7-4af7-b719-78ffbd3d2998"), new Guid("ab2501ec-a3d8-4027-98dd-df99be5a1bf9"), 200.0, "A", 8, "VAN" },
                    { new Guid("2b49f5ce-1ced-448b-919f-8bc48926c2bd"), new Guid("40448bf3-c284-402d-a1bf-7593c2d267c4"), 300.0, "B", 2, "TRUCK" },
                    { new Guid("2b6340f8-d3a6-47a5-8434-4905a14ebe50"), new Guid("04b75293-d378-4ee1-b298-9f723aa1e4bf"), 100.0, "A", 8, "CAR" },
                    { new Guid("2ca29831-382d-4f34-a23b-bb1ae7f3f629"), new Guid("14f021ba-4e08-416b-8751-e5d09e9b107d"), 300.0, "B", 7, "TRUCK" },
                    { new Guid("2d713258-e562-42b4-88fd-c76fce639a9c"), new Guid("f5e07364-5770-4cca-8215-4bc9687928fd"), 300.0, "A", 5, "TRUCK" },
                    { new Guid("2d9d30d5-7af6-4097-a838-c0983cc88640"), new Guid("0e1cf06a-2c1f-4f3a-804f-0a21ca76a827"), 50.0, "B", 6, "MOTORCYCLE" },
                    { new Guid("2dbeec1e-519f-4444-a32d-d8b1de8a18bb"), new Guid("c7dca08c-fee9-47a0-bb70-4dc53f2699d0"), 100.0, "A", 3, "CAR" },
                    { new Guid("2e02f412-9338-4e00-afd1-1347d93e1a65"), new Guid("0e6822f5-7394-400d-bca7-a4cc4dd28978"), 300.0, "B", 8, "TRUCK" },
                    { new Guid("2e0da49b-2d2e-4b82-a0f7-bd67744040ae"), new Guid("30fd900a-27d9-4682-b5e2-db8c76e2062b"), 50.0, "A", 5, "MOTORCYCLE" },
                    { new Guid("2e75769e-3ab4-4d40-a409-1f459abaed75"), new Guid("13d8bc75-3ef2-4d55-a2bd-ffc7a683e7e4"), 300.0, "B", 3, "TRUCK" },
                    { new Guid("2e99890c-c8e7-4836-820a-170dbc52f21f"), new Guid("88c0746c-384c-48a3-8a24-034a9d11e036"), 100.0, "A", 2, "CAR" },
                    { new Guid("2ec39376-b3eb-41e9-9b10-671db853fe4e"), new Guid("ae3959c4-5bca-457d-9c14-4cc88f49d61e"), 300.0, "A", 6, "TRUCK" },
                    { new Guid("2f34d956-03af-4047-ae7c-c94c2dfaf8e3"), new Guid("e5dceac8-c4a8-4f0a-b51b-9a305ff65216"), 200.0, "B", 2, "VAN" },
                    { new Guid("2f6d26d6-ba81-4c19-ba39-17143fb2d030"), new Guid("60bf0a3a-02aa-4218-8e61-a5dd00e5e0d4"), 50.0, "B", 6, "MOTORCYCLE" },
                    { new Guid("2f7bed80-f365-4cc8-8665-7f26bd027b34"), new Guid("7fd19919-4f47-4257-af41-0eaf6d2f3533"), 100.0, "A", 5, "CAR" },
                    { new Guid("2f9c1cbb-7d96-4a89-be2f-5dae4608edcb"), new Guid("454290bd-e2c7-4154-b980-cc091b14465d"), 50.0, "A", 4, "MOTORCYCLE" },
                    { new Guid("3035524a-03c6-4ffa-8216-8379d0f17af7"), new Guid("7fd19919-4f47-4257-af41-0eaf6d2f3533"), 100.0, "A", 7, "CAR" },
                    { new Guid("30426b21-29b5-4ac8-b859-9b433d8f043a"), new Guid("f8fec2b0-96c9-47ff-be70-eee9e7195d60"), 200.0, "B", 7, "VAN" },
                    { new Guid("30562ede-8b50-4d1a-93a3-0eae3df40bcb"), new Guid("f5882dab-e003-453f-b642-a38560da3beb"), 200.0, "B", 2, "VAN" },
                    { new Guid("307c2103-6fe0-4f8e-957e-0fd1cfc29f2f"), new Guid("4bbdfefd-5984-4fd5-ad27-04ef0d85ef60"), 200.0, "B", 4, "VAN" },
                    { new Guid("30b9cc1b-97f5-4bf9-aef3-d5b146763c7c"), new Guid("7fd19919-4f47-4257-af41-0eaf6d2f3533"), 100.0, "A", 3, "CAR" },
                    { new Guid("31c7f30f-bfe5-4722-8ece-b4c186037970"), new Guid("18bb3ced-ef4c-4990-902d-9ccdbee03709"), 100.0, "B", 5, "CAR" },
                    { new Guid("324d5316-2555-4cf2-93ff-b8b257590834"), new Guid("66af1e03-1839-46f2-a5b1-999c4f3a5b30"), 200.0, "A", 6, "VAN" },
                    { new Guid("3287cf90-7a08-42bb-862b-32698a4a6e34"), new Guid("bf2771a1-c2c5-496e-beab-9667afd9bbfe"), 100.0, "B", 5, "CAR" },
                    { new Guid("329ebfa8-4514-4aa1-b80b-9f8229480395"), new Guid("15e5b2e9-d51f-4413-9a87-0a8051c82ff4"), 50.0, "B", 5, "MOTORCYCLE" },
                    { new Guid("32ce8405-9df0-4357-bdd7-fef2559688f2"), new Guid("f92eb003-edbb-4752-9d08-baf8cf0be864"), 50.0, "A", 6, "MOTORCYCLE" },
                    { new Guid("32df984a-4803-4109-9749-abcf15c47b67"), new Guid("6834e8ac-9efa-4f21-a027-d8ae1c1b973e"), 200.0, "A", 1, "VAN" },
                    { new Guid("33f5bebe-9020-4ae0-8dc3-cb3df5b98d77"), new Guid("564ba9ef-c816-47d7-a41b-a7b061183905"), 200.0, "A", 1, "VAN" },
                    { new Guid("3449a78b-132d-4cc4-b981-ac086e752c1d"), new Guid("ac8d075d-9942-4f4e-b98f-e8df09ce60d3"), 300.0, "B", 4, "TRUCK" },
                    { new Guid("34d56340-d6eb-4b22-9544-cba6f6bf8bbb"), new Guid("a2702078-cb6b-4d1d-a83a-640674eeeffe"), 200.0, "A", 6, "VAN" },
                    { new Guid("34d59eed-868b-4544-9789-209f17cbc60e"), new Guid("d76e484e-5fd9-4cf5-8892-f4fcf44654fa"), 50.0, "A", 2, "MOTORCYCLE" },
                    { new Guid("3507bf04-dda3-421a-a2fe-427ca6c29c1a"), new Guid("37b1553e-e0cc-460c-b0a8-d72fea93dadc"), 300.0, "B", 4, "TRUCK" },
                    { new Guid("3613fe29-0fb5-49a6-b79a-d3625d423a2a"), new Guid("0e1cf06a-2c1f-4f3a-804f-0a21ca76a827"), 50.0, "B", 8, "MOTORCYCLE" },
                    { new Guid("361facd9-c64e-4003-9ebe-daf5755ecd4f"), new Guid("f8fec2b0-96c9-47ff-be70-eee9e7195d60"), 300.0, "A", 2, "TRUCK" },
                    { new Guid("3631df6c-9972-4567-b8fe-03f9941820bf"), new Guid("88c0746c-384c-48a3-8a24-034a9d11e036"), 100.0, "B", 1, "CAR" },
                    { new Guid("366eebf8-1fde-4c60-975e-f42f30335a4c"), new Guid("bf2771a1-c2c5-496e-beab-9667afd9bbfe"), 100.0, "B", 1, "CAR" },
                    { new Guid("36cc1581-0f41-4e12-b8d2-1f0451666912"), new Guid("d76e484e-5fd9-4cf5-8892-f4fcf44654fa"), 50.0, "A", 4, "MOTORCYCLE" },
                    { new Guid("36e8c342-cfeb-441f-a44e-32f07f15169e"), new Guid("88c0746c-384c-48a3-8a24-034a9d11e036"), 100.0, "A", 5, "CAR" },
                    { new Guid("36f8952e-0d91-40cc-8c8d-b88126176d3e"), new Guid("b7048c17-53ab-4005-8a80-eed7f70c6c99"), 200.0, "B", 8, "VAN" },
                    { new Guid("3704a1f4-f7fe-48b8-95cd-a23f4311473a"), new Guid("325cdcfb-5542-41fb-bca0-5aec0a1f8209"), 300.0, "B", 2, "TRUCK" },
                    { new Guid("370636f9-56d8-4b09-b008-0614aee3d9bf"), new Guid("e5dceac8-c4a8-4f0a-b51b-9a305ff65216"), 200.0, "A", 4, "VAN" },
                    { new Guid("387fed27-a2e6-464a-8ce6-f1f1e807ac9b"), new Guid("ac8d075d-9942-4f4e-b98f-e8df09ce60d3"), 100.0, "A", 2, "CAR" },
                    { new Guid("388c844b-ba50-4fd5-89df-ab72f19f6b03"), new Guid("88c0746c-384c-48a3-8a24-034a9d11e036"), 100.0, "A", 1, "CAR" },
                    { new Guid("38fa1077-68c0-4996-9721-a0ae99193eef"), new Guid("cdd98f54-2de4-464d-912e-488674be6f46"), 300.0, "B", 7, "TRUCK" },
                    { new Guid("3963e460-24e2-476f-9aa8-bf4ef42e7d71"), new Guid("f92eb003-edbb-4752-9d08-baf8cf0be864"), 50.0, "A", 1, "MOTORCYCLE" },
                    { new Guid("39b07de9-f22e-4157-9aff-17dcf0068939"), new Guid("40448bf3-c284-402d-a1bf-7593c2d267c4"), 300.0, "B", 8, "TRUCK" },
                    { new Guid("39ceb8a7-18c9-411a-af5b-33b04c9bd886"), new Guid("d76e484e-5fd9-4cf5-8892-f4fcf44654fa"), 300.0, "B", 5, "TRUCK" },
                    { new Guid("39f3ce7c-f882-4db0-b506-fa3d644ddd4b"), new Guid("ed42e83a-2e39-4c0c-8803-4b595c801a43"), 50.0, "B", 1, "MOTORCYCLE" },
                    { new Guid("3a4129bd-95eb-431d-a746-28e0e9e12016"), new Guid("37b1553e-e0cc-460c-b0a8-d72fea93dadc"), 50.0, "A", 4, "MOTORCYCLE" },
                    { new Guid("3a691238-5c25-497b-961b-95bfa0005eb3"), new Guid("cc8bb9f7-35ca-4c40-8498-8e83c25136cd"), 300.0, "A", 6, "TRUCK" },
                    { new Guid("3a835e76-fa95-47fe-87ae-9b1f4b64c461"), new Guid("40448bf3-c284-402d-a1bf-7593c2d267c4"), 100.0, "A", 4, "CAR" },
                    { new Guid("3b1c2509-c6b1-4c09-8205-d506c3a3f036"), new Guid("cdd98f54-2de4-464d-912e-488674be6f46"), 300.0, "B", 6, "TRUCK" },
                    { new Guid("3b2893d6-74d3-4bbb-8236-e63e826927b5"), new Guid("9ef7200f-cd79-41e9-ac2b-c0215f0fc9fc"), 50.0, "A", 8, "MOTORCYCLE" },
                    { new Guid("3b71b880-b601-4ab5-8ef8-12076f5e8f4a"), new Guid("ab2501ec-a3d8-4027-98dd-df99be5a1bf9"), 300.0, "B", 5, "TRUCK" },
                    { new Guid("3ba631e5-adf8-4d32-926a-5a1d8988afbc"), new Guid("14f021ba-4e08-416b-8751-e5d09e9b107d"), 300.0, "B", 5, "TRUCK" },
                    { new Guid("3bc5c097-e31f-4821-a3e4-1f6de2177997"), new Guid("b74f87ee-301c-418b-a49a-4a8ebe631eb8"), 100.0, "B", 8, "CAR" },
                    { new Guid("3c14c4ff-6025-450b-a076-adb52e3e7b3c"), new Guid("d12f5883-ab8e-4d3f-a967-ec7675a0ab47"), 300.0, "A", 4, "TRUCK" },
                    { new Guid("3c3304ae-69eb-42a5-a89c-763cb5b6f250"), new Guid("b1ad3048-49d6-4a9a-a0f8-d99e3f5f70f5"), 300.0, "A", 7, "TRUCK" },
                    { new Guid("3cb4b6dd-f29d-4508-b49c-854c6ef7ae29"), new Guid("0ea2b9de-200d-4f13-b796-bd86c412194b"), 50.0, "A", 1, "MOTORCYCLE" },
                    { new Guid("3ccc9a2e-5de0-4fac-852d-c0e4114bcffa"), new Guid("cc8bb9f7-35ca-4c40-8498-8e83c25136cd"), 50.0, "B", 8, "MOTORCYCLE" },
                    { new Guid("3d37cdd2-1617-4dd4-ad03-f97b5b46e4ad"), new Guid("66af1e03-1839-46f2-a5b1-999c4f3a5b30"), 100.0, "B", 1, "CAR" },
                    { new Guid("3d3909c0-c868-4084-821f-be0baa3fcc8d"), new Guid("40448bf3-c284-402d-a1bf-7593c2d267c4"), 100.0, "A", 5, "CAR" },
                    { new Guid("3d54bd31-6466-45e1-a649-b1db43fda1bb"), new Guid("4f8943b0-c325-4306-8872-c0687a860552"), 300.0, "B", 1, "TRUCK" },
                    { new Guid("3d625cb4-78f9-47c7-b474-a74a10dd0f7d"), new Guid("9ef7200f-cd79-41e9-ac2b-c0215f0fc9fc"), 300.0, "B", 1, "TRUCK" },
                    { new Guid("3db559d1-ffc4-4277-8594-ef4f657ef1ef"), new Guid("88c0746c-384c-48a3-8a24-034a9d11e036"), 100.0, "A", 6, "CAR" },
                    { new Guid("3db6814e-dd6b-4750-857e-b7fa819298c3"), new Guid("0b1a89a0-0f56-47cf-8cf8-6e15ec4f04ef"), 100.0, "B", 6, "CAR" },
                    { new Guid("3e0e9b71-8e44-421b-a906-b0a316162848"), new Guid("66af1e03-1839-46f2-a5b1-999c4f3a5b30"), 100.0, "B", 5, "CAR" },
                    { new Guid("3e8000f1-3146-4372-83af-92e312372e22"), new Guid("b74f87ee-301c-418b-a49a-4a8ebe631eb8"), 100.0, "B", 1, "CAR" },
                    { new Guid("3e96c3e4-f4f1-463e-82f7-b9d95b2ef961"), new Guid("c7dca08c-fee9-47a0-bb70-4dc53f2699d0"), 300.0, "B", 7, "TRUCK" },
                    { new Guid("3e988dc4-ce7c-4999-aad0-57159b0f5ad4"), new Guid("ac8d075d-9942-4f4e-b98f-e8df09ce60d3"), 100.0, "A", 8, "CAR" },
                    { new Guid("3ec5450c-f9a3-4c0f-9ef8-4ae6b7624fd4"), new Guid("325cdcfb-5542-41fb-bca0-5aec0a1f8209"), 300.0, "A", 6, "TRUCK" },
                    { new Guid("3ed1fd1e-c9d8-4f56-81e7-164cd79ff366"), new Guid("60bf0a3a-02aa-4218-8e61-a5dd00e5e0d4"), 50.0, "B", 8, "MOTORCYCLE" },
                    { new Guid("3ef7d946-bf54-442f-a13d-567dc9996115"), new Guid("ed42e83a-2e39-4c0c-8803-4b595c801a43"), 50.0, "B", 7, "MOTORCYCLE" },
                    { new Guid("3f15f63e-6b78-4a29-87c4-610ca1edab69"), new Guid("6834e8ac-9efa-4f21-a027-d8ae1c1b973e"), 100.0, "B", 7, "CAR" },
                    { new Guid("3f6c1ade-a8ef-4480-ae30-43627e791c8a"), new Guid("ed42e83a-2e39-4c0c-8803-4b595c801a43"), 50.0, "A", 5, "MOTORCYCLE" },
                    { new Guid("3f7789fc-435a-4e5f-a723-ff01f88f9f7a"), new Guid("66ccfd45-4738-48da-ac09-400c1a1a26bb"), 300.0, "A", 4, "TRUCK" },
                    { new Guid("3f959e27-b980-4623-aaec-8bbfd8a427b0"), new Guid("eb01d97e-5919-4537-822f-2fff3c6fd84f"), 300.0, "B", 8, "TRUCK" },
                    { new Guid("3fc1d976-78ee-4ba7-b661-c1088d0f7e71"), new Guid("6834e8ac-9efa-4f21-a027-d8ae1c1b973e"), 100.0, "B", 3, "CAR" },
                    { new Guid("3fd8bdb9-c1ee-4de4-ad61-940e963d0184"), new Guid("b7048c17-53ab-4005-8a80-eed7f70c6c99"), 200.0, "B", 6, "VAN" },
                    { new Guid("4007aa27-d3d7-45e5-9524-f01178273084"), new Guid("f5882dab-e003-453f-b642-a38560da3beb"), 200.0, "B", 1, "VAN" },
                    { new Guid("4069be49-10a1-4cb7-89d4-845f562fbde4"), new Guid("47569aaa-bf51-4525-832e-9153120d433e"), 200.0, "A", 1, "VAN" },
                    { new Guid("40757a25-6631-4a87-8067-e5d9db334ad9"), new Guid("4f8943b0-c325-4306-8872-c0687a860552"), 300.0, "B", 4, "TRUCK" },
                    { new Guid("4093f338-23f2-45e8-9d86-52e2e199bbbe"), new Guid("66af1e03-1839-46f2-a5b1-999c4f3a5b30"), 200.0, "A", 8, "VAN" },
                    { new Guid("40cc74fb-d722-4f95-87db-0daa990cea36"), new Guid("76a04e41-7aa0-46e2-8c27-0b677cde6543"), 100.0, "B", 4, "CAR" },
                    { new Guid("4103789e-6608-4ca7-bb7a-ecb24cfa4209"), new Guid("66ccfd45-4738-48da-ac09-400c1a1a26bb"), 100.0, "B", 3, "CAR" },
                    { new Guid("412c10ad-b61c-4c28-90e0-de6d11895898"), new Guid("b1ad3048-49d6-4a9a-a0f8-d99e3f5f70f5"), 300.0, "B", 4, "TRUCK" },
                    { new Guid("4261b870-bc88-4018-b49d-917c29046eae"), new Guid("a2702078-cb6b-4d1d-a83a-640674eeeffe"), 200.0, "A", 1, "VAN" },
                    { new Guid("42c96f32-19b8-4a79-861c-d87954900f7d"), new Guid("30fd900a-27d9-4682-b5e2-db8c76e2062b"), 50.0, "B", 7, "MOTORCYCLE" },
                    { new Guid("43052d01-77dd-42b1-9e59-df48e780f26d"), new Guid("14f021ba-4e08-416b-8751-e5d09e9b107d"), 100.0, "A", 2, "CAR" },
                    { new Guid("431ff94d-f298-47ed-bcc2-90fd8d4e5da0"), new Guid("a2702078-cb6b-4d1d-a83a-640674eeeffe"), 200.0, "A", 4, "VAN" },
                    { new Guid("432aff7c-f099-496a-a0c4-f2b2d1e9025d"), new Guid("4f8943b0-c325-4306-8872-c0687a860552"), 200.0, "A", 6, "VAN" },
                    { new Guid("438eb2ff-faab-4f3b-bd63-3b022805d472"), new Guid("6834e8ac-9efa-4f21-a027-d8ae1c1b973e"), 200.0, "A", 3, "VAN" },
                    { new Guid("43a1cd8c-07e9-4835-ab9b-6b7e1740d56c"), new Guid("9ef7200f-cd79-41e9-ac2b-c0215f0fc9fc"), 300.0, "B", 8, "TRUCK" },
                    { new Guid("43e78c3e-1082-4381-b475-425f5cd4271e"), new Guid("0e1cf06a-2c1f-4f3a-804f-0a21ca76a827"), 50.0, "B", 2, "MOTORCYCLE" },
                    { new Guid("44191851-268d-4e76-9320-62e487b8b595"), new Guid("d76e484e-5fd9-4cf5-8892-f4fcf44654fa"), 50.0, "A", 7, "MOTORCYCLE" },
                    { new Guid("44208ee1-f487-40fd-8bb3-1cdce08b42ea"), new Guid("ae3959c4-5bca-457d-9c14-4cc88f49d61e"), 100.0, "B", 6, "CAR" },
                    { new Guid("446fe08a-044f-4ad5-83a7-9b22a1ca38d2"), new Guid("ab2501ec-a3d8-4027-98dd-df99be5a1bf9"), 300.0, "B", 3, "TRUCK" },
                    { new Guid("4477769d-f0fa-497e-87dc-735d0dbdbd82"), new Guid("ab2501ec-a3d8-4027-98dd-df99be5a1bf9"), 200.0, "A", 5, "VAN" },
                    { new Guid("44ce4009-a7e0-480e-a8bb-0767a44fe37a"), new Guid("13d8bc75-3ef2-4d55-a2bd-ffc7a683e7e4"), 300.0, "A", 8, "TRUCK" },
                    { new Guid("44d1ac39-6a56-4acc-ac40-b5076488d59a"), new Guid("cfeefc53-67a5-4e6a-a136-330d10920937"), 100.0, "A", 3, "CAR" },
                    { new Guid("44f4992e-66cc-4fca-a8c0-6e4532cac027"), new Guid("564ba9ef-c816-47d7-a41b-a7b061183905"), 50.0, "B", 5, "MOTORCYCLE" },
                    { new Guid("44fe078b-d557-48c1-97d6-f0a23eadb660"), new Guid("ac8d075d-9942-4f4e-b98f-e8df09ce60d3"), 100.0, "A", 5, "CAR" },
                    { new Guid("45018520-5b8a-40d9-bd3a-421802953f40"), new Guid("cc8bb9f7-35ca-4c40-8498-8e83c25136cd"), 50.0, "B", 2, "MOTORCYCLE" },
                    { new Guid("4536fd1c-ca1f-4759-bfe8-55f4945ff807"), new Guid("eb01d97e-5919-4537-822f-2fff3c6fd84f"), 300.0, "B", 1, "TRUCK" },
                    { new Guid("4570e19a-94e9-4915-b96e-8439d77686d5"), new Guid("cc8bb9f7-35ca-4c40-8498-8e83c25136cd"), 50.0, "B", 7, "MOTORCYCLE" },
                    { new Guid("45a6783e-ac0b-4b21-939a-3bd5fdd40e2d"), new Guid("cdd98f54-2de4-464d-912e-488674be6f46"), 300.0, "B", 4, "TRUCK" },
                    { new Guid("45af41b9-cc49-4331-ac7f-aadd458e0109"), new Guid("30fd900a-27d9-4682-b5e2-db8c76e2062b"), 50.0, "B", 5, "MOTORCYCLE" },
                    { new Guid("45e6ee60-7e66-409f-9fbe-2a9efcff084e"), new Guid("8eda8dbd-513f-49c9-a050-7c8a6e6475d7"), 200.0, "A", 6, "VAN" },
                    { new Guid("465d26a0-1bcc-4812-abe8-c68ce7725130"), new Guid("561ae673-4668-49b7-81ca-2fc792ab1b3e"), 50.0, "A", 6, "MOTORCYCLE" },
                    { new Guid("46c44ec9-8b05-4690-b4f6-0bd1fee245f2"), new Guid("564ba9ef-c816-47d7-a41b-a7b061183905"), 200.0, "A", 3, "VAN" },
                    { new Guid("47916aa3-8593-4abc-b92c-619df6f7603d"), new Guid("454290bd-e2c7-4154-b980-cc091b14465d"), 300.0, "B", 8, "TRUCK" },
                    { new Guid("47ad28c4-04f1-4639-9a26-da48d70af52d"), new Guid("561ae673-4668-49b7-81ca-2fc792ab1b3e"), 50.0, "B", 3, "MOTORCYCLE" },
                    { new Guid("47cb7c04-220f-4dbe-84b7-e859eb5eebfa"), new Guid("8eda8dbd-513f-49c9-a050-7c8a6e6475d7"), 200.0, "A", 7, "VAN" },
                    { new Guid("4829b23b-f171-4050-8f06-ebd5daee6bb9"), new Guid("0e6822f5-7394-400d-bca7-a4cc4dd28978"), 50.0, "A", 6, "MOTORCYCLE" },
                    { new Guid("482ba256-38da-4aaf-b359-474990198bb9"), new Guid("ab2501ec-a3d8-4027-98dd-df99be5a1bf9"), 200.0, "A", 6, "VAN" },
                    { new Guid("48461733-ccda-45af-9fa7-65ab4a628cae"), new Guid("564ba9ef-c816-47d7-a41b-a7b061183905"), 200.0, "A", 5, "VAN" },
                    { new Guid("489f4e53-5075-45ef-ae4e-9bbbab42fc20"), new Guid("bf2771a1-c2c5-496e-beab-9667afd9bbfe"), 100.0, "B", 8, "CAR" },
                    { new Guid("48a31950-1aa8-4c7b-ba24-6e7ea42f7ed8"), new Guid("b7048c17-53ab-4005-8a80-eed7f70c6c99"), 100.0, "A", 4, "CAR" },
                    { new Guid("48b781c4-84ed-4412-adce-9f42bff1ee27"), new Guid("dec19efa-56f4-4a25-8590-7b1938391756"), 100.0, "A", 4, "CAR" },
                    { new Guid("4908fc68-a762-4b63-a50a-c0a7ef5ba509"), new Guid("4f8943b0-c325-4306-8872-c0687a860552"), 300.0, "B", 2, "TRUCK" },
                    { new Guid("49dedfca-f721-43b1-92b8-42eedabadb21"), new Guid("9ef7200f-cd79-41e9-ac2b-c0215f0fc9fc"), 300.0, "B", 3, "TRUCK" },
                    { new Guid("49e6321e-a895-46fb-92d6-fa410ead2746"), new Guid("a2702078-cb6b-4d1d-a83a-640674eeeffe"), 300.0, "B", 1, "TRUCK" },
                    { new Guid("49e7b478-f5ea-43f9-b307-1190282e9b7e"), new Guid("cacdb08a-111b-49ab-81b8-13817060e4e8"), 200.0, "B", 7, "VAN" },
                    { new Guid("4a1b9c4b-6310-442a-9413-f347e31b07c3"), new Guid("cc8bb9f7-35ca-4c40-8498-8e83c25136cd"), 50.0, "B", 4, "MOTORCYCLE" },
                    { new Guid("4a1d1dde-21b8-4221-a42f-90243ec28ff0"), new Guid("30fd900a-27d9-4682-b5e2-db8c76e2062b"), 50.0, "A", 6, "MOTORCYCLE" },
                    { new Guid("4a37f3cb-fd26-4bef-b9b5-dc0d5a5ecff9"), new Guid("0b1a89a0-0f56-47cf-8cf8-6e15ec4f04ef"), 100.0, "B", 2, "CAR" },
                    { new Guid("4a3ac181-33bf-4225-9ced-732bc9ebd2b5"), new Guid("b74f87ee-301c-418b-a49a-4a8ebe631eb8"), 100.0, "B", 3, "CAR" },
                    { new Guid("4a4dc439-e0a0-4d43-846e-1d3495b6a55f"), new Guid("04b75293-d378-4ee1-b298-9f723aa1e4bf"), 100.0, "B", 4, "CAR" },
                    { new Guid("4a6eabf8-2d04-413a-b555-bb21af15f1a4"), new Guid("cdd98f54-2de4-464d-912e-488674be6f46"), 50.0, "A", 4, "MOTORCYCLE" },
                    { new Guid("4a755abf-b6d6-44bf-93a3-1822535d6157"), new Guid("dec19efa-56f4-4a25-8590-7b1938391756"), 100.0, "A", 1, "CAR" },
                    { new Guid("4acf40ac-dd1c-45fe-ac54-6a11ca6f0b6f"), new Guid("4f8943b0-c325-4306-8872-c0687a860552"), 300.0, "B", 8, "TRUCK" },
                    { new Guid("4ae2af57-5ac3-4bc8-adaa-1dc4e3d38f80"), new Guid("cfeefc53-67a5-4e6a-a136-330d10920937"), 100.0, "A", 2, "CAR" },
                    { new Guid("4b9d6ae1-3894-40b3-806e-643c962baa1e"), new Guid("f8fec2b0-96c9-47ff-be70-eee9e7195d60"), 200.0, "B", 3, "VAN" },
                    { new Guid("4c1823e6-94c1-4650-99bb-3d8387e50b49"), new Guid("ed42e83a-2e39-4c0c-8803-4b595c801a43"), 50.0, "B", 4, "MOTORCYCLE" },
                    { new Guid("4c81e057-d30a-4956-970a-5ce30317babe"), new Guid("a2702078-cb6b-4d1d-a83a-640674eeeffe"), 300.0, "B", 2, "TRUCK" },
                    { new Guid("4c87e2c3-663d-483e-9d3c-030b6ffc413e"), new Guid("0b1a89a0-0f56-47cf-8cf8-6e15ec4f04ef"), 50.0, "A", 5, "MOTORCYCLE" },
                    { new Guid("4d072e44-74e0-462c-83eb-2e9aced1bf14"), new Guid("30fd900a-27d9-4682-b5e2-db8c76e2062b"), 50.0, "B", 4, "MOTORCYCLE" },
                    { new Guid("4d49bc6a-f583-4f76-9cf3-6cd4e7e48fc4"), new Guid("a4cc4c37-d39f-4d36-9a60-2d6404fc97f6"), 100.0, "B", 2, "CAR" },
                    { new Guid("4d7b0395-52d8-43ae-b7f8-afa4b3eb233b"), new Guid("60bf0a3a-02aa-4218-8e61-a5dd00e5e0d4"), 50.0, "B", 4, "MOTORCYCLE" },
                    { new Guid("4e53d180-8bb8-4461-94b6-6c38063a0544"), new Guid("f5882dab-e003-453f-b642-a38560da3beb"), 200.0, "B", 4, "VAN" },
                    { new Guid("4ead4199-2b3a-49b6-9efb-b7fe58210138"), new Guid("ab2501ec-a3d8-4027-98dd-df99be5a1bf9"), 300.0, "B", 7, "TRUCK" },
                    { new Guid("4eb5b96b-2fcf-4780-9bb9-26d4cb9d5f4c"), new Guid("76a04e41-7aa0-46e2-8c27-0b677cde6543"), 50.0, "A", 5, "MOTORCYCLE" },
                    { new Guid("4f111bb9-9e25-4161-89b8-c52ade546edf"), new Guid("b202d20c-9aca-47ab-8c0c-417b0566bc9a"), 200.0, "B", 8, "VAN" },
                    { new Guid("4f20e72c-5cc1-430f-9eca-c6e219d52135"), new Guid("ae3959c4-5bca-457d-9c14-4cc88f49d61e"), 100.0, "B", 5, "CAR" },
                    { new Guid("4f375940-3163-4ac5-befb-4973bcd88ec9"), new Guid("0e6822f5-7394-400d-bca7-a4cc4dd28978"), 300.0, "B", 1, "TRUCK" },
                    { new Guid("4f60381d-63de-401b-9409-afe7a70888e6"), new Guid("c5d2c35b-c774-4f68-bc8b-4b23482c4244"), 100.0, "B", 1, "CAR" },
                    { new Guid("4f6b6dc3-d798-4c01-8228-2f41f7c49f20"), new Guid("88c0746c-384c-48a3-8a24-034a9d11e036"), 100.0, "B", 2, "CAR" },
                    { new Guid("4ff237cf-c93b-44ba-a03d-d22ebe3db695"), new Guid("d12f5883-ab8e-4d3f-a967-ec7675a0ab47"), 50.0, "B", 3, "MOTORCYCLE" },
                    { new Guid("5013c8e0-d08c-4abe-9aaa-5370dbb0acf2"), new Guid("60bf0a3a-02aa-4218-8e61-a5dd00e5e0d4"), 50.0, "A", 2, "MOTORCYCLE" },
                    { new Guid("5054aa5a-e61c-4ce6-875e-2539421606e7"), new Guid("d7bcb6e9-67e9-4afc-9d25-f169447500eb"), 100.0, "A", 4, "CAR" },
                    { new Guid("50bc0d88-100e-4a11-acbe-c94fdf14be17"), new Guid("7fd19919-4f47-4257-af41-0eaf6d2f3533"), 100.0, "B", 4, "CAR" },
                    { new Guid("51c4857e-6207-4c1f-9a01-4b741d355423"), new Guid("6834e8ac-9efa-4f21-a027-d8ae1c1b973e"), 100.0, "B", 4, "CAR" },
                    { new Guid("51e272eb-459a-4a1a-af53-bbe7293901ee"), new Guid("e5dceac8-c4a8-4f0a-b51b-9a305ff65216"), 200.0, "B", 8, "VAN" },
                    { new Guid("51eff525-55fd-401c-b768-888198eabaf2"), new Guid("454290bd-e2c7-4154-b980-cc091b14465d"), 300.0, "B", 3, "TRUCK" },
                    { new Guid("529d157e-9353-43a2-89a0-4ad6249c253d"), new Guid("e5dceac8-c4a8-4f0a-b51b-9a305ff65216"), 200.0, "A", 5, "VAN" },
                    { new Guid("52affb16-f0d8-46d0-bd8e-2e98847d70a9"), new Guid("5a1062de-7895-4914-b081-cc7ff9e007e7"), 100.0, "B", 4, "CAR" },
                    { new Guid("52f52b32-1cba-41ff-a76e-04db62f58ffe"), new Guid("b7048c17-53ab-4005-8a80-eed7f70c6c99"), 100.0, "A", 2, "CAR" },
                    { new Guid("536dbc86-dd35-4771-9204-f9931defb411"), new Guid("cdd98f54-2de4-464d-912e-488674be6f46"), 300.0, "B", 1, "TRUCK" },
                    { new Guid("5389dfc9-0ce3-4bad-8554-bcabdb32b768"), new Guid("eb01d97e-5919-4537-822f-2fff3c6fd84f"), 50.0, "A", 1, "MOTORCYCLE" },
                    { new Guid("53ac5c6d-419b-4251-8387-c601592ed4a9"), new Guid("47569aaa-bf51-4525-832e-9153120d433e"), 200.0, "A", 8, "VAN" },
                    { new Guid("53ae38de-a523-48ec-87f0-7ed71b07e345"), new Guid("66af1e03-1839-46f2-a5b1-999c4f3a5b30"), 200.0, "A", 1, "VAN" },
                    { new Guid("53d171da-c158-4a55-be79-fa175d299078"), new Guid("f8fec2b0-96c9-47ff-be70-eee9e7195d60"), 200.0, "B", 5, "VAN" },
                    { new Guid("53ea159c-f43d-4576-9fa3-df79434a5fa2"), new Guid("f92eb003-edbb-4752-9d08-baf8cf0be864"), 50.0, "A", 8, "MOTORCYCLE" },
                    { new Guid("54752781-4e4c-44ef-a2d8-d8eec3a37853"), new Guid("a2702078-cb6b-4d1d-a83a-640674eeeffe"), 300.0, "B", 4, "TRUCK" },
                    { new Guid("54b91da0-da59-41c9-b22d-c17e2ecedcc9"), new Guid("ed42e83a-2e39-4c0c-8803-4b595c801a43"), 50.0, "A", 7, "MOTORCYCLE" },
                    { new Guid("5507201d-3350-4d9c-a62b-739cd4a0af50"), new Guid("dec19efa-56f4-4a25-8590-7b1938391756"), 300.0, "B", 3, "TRUCK" },
                    { new Guid("5585c53e-0f15-4b93-9db2-f01952422fc7"), new Guid("5a1062de-7895-4914-b081-cc7ff9e007e7"), 50.0, "A", 8, "MOTORCYCLE" },
                    { new Guid("558832a6-a7c0-4b5d-9fbd-95b4e8170042"), new Guid("cdd98f54-2de4-464d-912e-488674be6f46"), 50.0, "A", 8, "MOTORCYCLE" },
                    { new Guid("560b7684-3820-4f82-90d4-fb76093d325f"), new Guid("37b1553e-e0cc-460c-b0a8-d72fea93dadc"), 50.0, "A", 7, "MOTORCYCLE" },
                    { new Guid("5672cbc1-9946-4d07-b9a2-adf0472222fb"), new Guid("8eda8dbd-513f-49c9-a050-7c8a6e6475d7"), 200.0, "B", 3, "VAN" },
                    { new Guid("5687b80c-1fe2-4107-9c8d-ab15b2c984ee"), new Guid("a2702078-cb6b-4d1d-a83a-640674eeeffe"), 300.0, "B", 8, "TRUCK" },
                    { new Guid("5698588e-8723-414e-b9ff-469d70dada1e"), new Guid("eb01d97e-5919-4537-822f-2fff3c6fd84f"), 50.0, "A", 2, "MOTORCYCLE" },
                    { new Guid("56ea487b-0608-4104-af59-b7f47d9f8488"), new Guid("564ba9ef-c816-47d7-a41b-a7b061183905"), 50.0, "B", 4, "MOTORCYCLE" },
                    { new Guid("57d78042-c69d-4bce-8b2d-8a5582c1f650"), new Guid("88c0746c-384c-48a3-8a24-034a9d11e036"), 100.0, "B", 3, "CAR" },
                    { new Guid("5837e6df-9752-47b4-8ebf-0b9c1d6c3f2d"), new Guid("66ccfd45-4738-48da-ac09-400c1a1a26bb"), 300.0, "A", 6, "TRUCK" },
                    { new Guid("5843c5df-9740-472b-a8e9-fca261ff6fdc"), new Guid("0e6822f5-7394-400d-bca7-a4cc4dd28978"), 50.0, "A", 5, "MOTORCYCLE" },
                    { new Guid("5862a2b0-854e-4dc7-94f7-695db427147e"), new Guid("cacdb08a-111b-49ab-81b8-13817060e4e8"), 200.0, "B", 4, "VAN" },
                    { new Guid("589c9f65-22c8-4dbb-b6ab-4e57dde97c7a"), new Guid("d76e484e-5fd9-4cf5-8892-f4fcf44654fa"), 50.0, "A", 6, "MOTORCYCLE" },
                    { new Guid("58d3c653-8e9a-4db5-bdbc-bfca0511e855"), new Guid("516e7943-059a-44cc-bd82-d4c4480a6676"), 100.0, "A", 1, "CAR" },
                    { new Guid("590df9b3-ac15-4cd5-8bef-4a0e9e1af53a"), new Guid("4bbdfefd-5984-4fd5-ad27-04ef0d85ef60"), 200.0, "B", 2, "VAN" },
                    { new Guid("59b30d7b-ef27-4090-bf92-684bfaaed45a"), new Guid("a2702078-cb6b-4d1d-a83a-640674eeeffe"), 300.0, "B", 6, "TRUCK" },
                    { new Guid("59ba2bbb-b86f-4ad3-ae64-e6e8e50f3d78"), new Guid("88c0746c-384c-48a3-8a24-034a9d11e036"), 100.0, "B", 5, "CAR" },
                    { new Guid("59bfc50e-c4e5-4d9f-a4d7-765ac8a46fd6"), new Guid("dec19efa-56f4-4a25-8590-7b1938391756"), 100.0, "A", 2, "CAR" },
                    { new Guid("5a035fcd-7e21-4c0f-be74-639f5b9b2264"), new Guid("454290bd-e2c7-4154-b980-cc091b14465d"), 50.0, "A", 6, "MOTORCYCLE" },
                    { new Guid("5a141c78-82e9-4b0f-8722-24b3a54451aa"), new Guid("b1ad3048-49d6-4a9a-a0f8-d99e3f5f70f5"), 300.0, "B", 1, "TRUCK" },
                    { new Guid("5a2693ef-289c-42fe-8f6b-64016d191de8"), new Guid("f92eb003-edbb-4752-9d08-baf8cf0be864"), 50.0, "A", 7, "MOTORCYCLE" },
                    { new Guid("5a407341-8e51-48f6-87a1-01fa28bdc9ad"), new Guid("40448bf3-c284-402d-a1bf-7593c2d267c4"), 100.0, "A", 2, "CAR" },
                    { new Guid("5a8783ab-883e-4057-b327-1e5dd71fa4f8"), new Guid("ac8d075d-9942-4f4e-b98f-e8df09ce60d3"), 100.0, "A", 7, "CAR" },
                    { new Guid("5af0f425-e1db-4b72-b959-9ed300239dac"), new Guid("bf471c98-2465-4e39-b3a4-a0a56d7f0b0c"), 50.0, "A", 8, "MOTORCYCLE" },
                    { new Guid("5b99db51-c951-4010-917c-c8511d64eeb3"), new Guid("0ea2b9de-200d-4f13-b796-bd86c412194b"), 300.0, "B", 3, "TRUCK" },
                    { new Guid("5c1c56d8-162c-4a83-9e60-8259c47102e4"), new Guid("4bbdfefd-5984-4fd5-ad27-04ef0d85ef60"), 200.0, "B", 6, "VAN" },
                    { new Guid("5c48dab8-d85d-4570-9f02-6457f73b9f51"), new Guid("14f021ba-4e08-416b-8751-e5d09e9b107d"), 100.0, "A", 6, "CAR" },
                    { new Guid("5c5f2ede-9a2a-4f22-84d8-c6cfa70b1c7e"), new Guid("0e6822f5-7394-400d-bca7-a4cc4dd28978"), 300.0, "B", 2, "TRUCK" },
                    { new Guid("5c72c0d0-a228-4f26-a37b-307846734e5a"), new Guid("9ef7200f-cd79-41e9-ac2b-c0215f0fc9fc"), 300.0, "B", 2, "TRUCK" },
                    { new Guid("5d73265f-6ab3-4fc8-9f2e-a87b3a7115b5"), new Guid("cdd98f54-2de4-464d-912e-488674be6f46"), 50.0, "A", 5, "MOTORCYCLE" },
                    { new Guid("5da1d74f-275e-4c78-86d1-f44be64972e9"), new Guid("0e6822f5-7394-400d-bca7-a4cc4dd28978"), 300.0, "B", 6, "TRUCK" },
                    { new Guid("5def06e5-4834-420f-8f4c-d070ff931d8a"), new Guid("ac8d075d-9942-4f4e-b98f-e8df09ce60d3"), 300.0, "B", 7, "TRUCK" },
                    { new Guid("5e818a12-1ea9-410e-b390-182cbc59354f"), new Guid("b1ad3048-49d6-4a9a-a0f8-d99e3f5f70f5"), 300.0, "A", 6, "TRUCK" },
                    { new Guid("5e910396-abb7-423f-bd42-98a16784cb90"), new Guid("37b1553e-e0cc-460c-b0a8-d72fea93dadc"), 300.0, "B", 6, "TRUCK" },
                    { new Guid("5ec55573-13e4-4ae7-9e18-82ecc6b39f55"), new Guid("0ea2b9de-200d-4f13-b796-bd86c412194b"), 50.0, "A", 3, "MOTORCYCLE" },
                    { new Guid("5f185e54-9271-442f-81db-f897bc324c5e"), new Guid("b202d20c-9aca-47ab-8c0c-417b0566bc9a"), 100.0, "A", 1, "CAR" },
                    { new Guid("5f520cbc-55ad-4f3d-be5c-4817fcaaee20"), new Guid("e07be4a4-a28a-4d40-bd21-3371ef69fc0b"), 100.0, "B", 1, "CAR" },
                    { new Guid("5f73a385-ee33-44df-9bc3-3378d58d180b"), new Guid("0e1cf06a-2c1f-4f3a-804f-0a21ca76a827"), 50.0, "B", 4, "MOTORCYCLE" },
                    { new Guid("5f8d592c-99b6-4975-a53c-1059ba7238a6"), new Guid("cfeefc53-67a5-4e6a-a136-330d10920937"), 50.0, "B", 7, "MOTORCYCLE" },
                    { new Guid("5fe65d5e-128e-4b51-bca3-d42481fcc277"), new Guid("76a04e41-7aa0-46e2-8c27-0b677cde6543"), 50.0, "A", 6, "MOTORCYCLE" },
                    { new Guid("6002824c-e290-4c90-a72a-67e04160933b"), new Guid("0e6822f5-7394-400d-bca7-a4cc4dd28978"), 50.0, "A", 2, "MOTORCYCLE" },
                    { new Guid("60288f61-e00a-4c7e-bfd9-45f328ed4400"), new Guid("66af1e03-1839-46f2-a5b1-999c4f3a5b30"), 100.0, "B", 4, "CAR" },
                    { new Guid("605acedf-6a90-4da6-8ee9-d7fe826294a7"), new Guid("c7dca08c-fee9-47a0-bb70-4dc53f2699d0"), 300.0, "B", 6, "TRUCK" },
                    { new Guid("60d0ff0c-98f3-4f56-aa67-ee4341bd1ad7"), new Guid("14f021ba-4e08-416b-8751-e5d09e9b107d"), 300.0, "B", 6, "TRUCK" },
                    { new Guid("60d351b9-b5e0-4c20-8a77-1a9db0146b6a"), new Guid("0ea2b9de-200d-4f13-b796-bd86c412194b"), 300.0, "B", 8, "TRUCK" },
                    { new Guid("60e02458-1dfc-4b82-8f6c-fbe26ad73c51"), new Guid("f92eb003-edbb-4752-9d08-baf8cf0be864"), 100.0, "B", 2, "CAR" },
                    { new Guid("60e52ebd-10f7-489d-994b-d9e8d152b746"), new Guid("37b1553e-e0cc-460c-b0a8-d72fea93dadc"), 300.0, "B", 8, "TRUCK" },
                    { new Guid("60e5ca60-d364-40db-913b-25b20d8b804c"), new Guid("b74f87ee-301c-418b-a49a-4a8ebe631eb8"), 100.0, "B", 2, "CAR" },
                    { new Guid("611cf76c-d8f6-4437-98ce-4d135cc01ea6"), new Guid("0e1cf06a-2c1f-4f3a-804f-0a21ca76a827"), 300.0, "A", 5, "TRUCK" },
                    { new Guid("61202da2-883f-43ac-b478-1278268b4689"), new Guid("c7dca08c-fee9-47a0-bb70-4dc53f2699d0"), 100.0, "A", 6, "CAR" },
                    { new Guid("62681467-9f49-4d5e-8aa2-78f264c66647"), new Guid("0e6822f5-7394-400d-bca7-a4cc4dd28978"), 50.0, "A", 3, "MOTORCYCLE" },
                    { new Guid("62ad8333-2758-4111-ad40-9e546b232647"), new Guid("7fd19919-4f47-4257-af41-0eaf6d2f3533"), 100.0, "B", 3, "CAR" },
                    { new Guid("6327bee6-2ff0-4a3b-8cbe-9acb31d62321"), new Guid("b1ad3048-49d6-4a9a-a0f8-d99e3f5f70f5"), 300.0, "B", 7, "TRUCK" },
                    { new Guid("63417f30-c075-4040-80be-10610cc3420e"), new Guid("564ba9ef-c816-47d7-a41b-a7b061183905"), 50.0, "B", 7, "MOTORCYCLE" },
                    { new Guid("634596c2-e591-4754-9fad-94338f0d593d"), new Guid("76a04e41-7aa0-46e2-8c27-0b677cde6543"), 100.0, "B", 1, "CAR" },
                    { new Guid("63588b14-1ea3-4bd0-aa85-b08f24b2828b"), new Guid("13d8bc75-3ef2-4d55-a2bd-ffc7a683e7e4"), 300.0, "B", 4, "TRUCK" },
                    { new Guid("636b68f7-c825-4f7d-b804-4acd3935a3d0"), new Guid("b74f87ee-301c-418b-a49a-4a8ebe631eb8"), 100.0, "B", 5, "CAR" },
                    { new Guid("6377a00c-adff-4ee6-a54b-a66d27412efa"), new Guid("cacdb08a-111b-49ab-81b8-13817060e4e8"), 100.0, "A", 5, "CAR" },
                    { new Guid("63dc8838-a9e7-4c77-ad22-eb224bbb56fe"), new Guid("40448bf3-c284-402d-a1bf-7593c2d267c4"), 100.0, "A", 7, "CAR" },
                    { new Guid("63f3edac-7c9a-4e61-8aa6-62236f6fa9a3"), new Guid("0b1a89a0-0f56-47cf-8cf8-6e15ec4f04ef"), 50.0, "A", 4, "MOTORCYCLE" },
                    { new Guid("6427f204-284d-4dca-b898-d004cbbc935f"), new Guid("e5dceac8-c4a8-4f0a-b51b-9a305ff65216"), 200.0, "B", 7, "VAN" },
                    { new Guid("64633b81-f511-4a72-9b59-f7b76f1f8785"), new Guid("cfeefc53-67a5-4e6a-a136-330d10920937"), 50.0, "B", 6, "MOTORCYCLE" },
                    { new Guid("65ca8ac9-e0a4-4807-97cc-efe9752895d0"), new Guid("0b1a89a0-0f56-47cf-8cf8-6e15ec4f04ef"), 50.0, "A", 6, "MOTORCYCLE" },
                    { new Guid("663446d9-3077-4466-b2bd-c166c21fe5bf"), new Guid("f5882dab-e003-453f-b642-a38560da3beb"), 50.0, "A", 7, "MOTORCYCLE" },
                    { new Guid("66427d7b-a99d-427c-9be3-149962a8d40c"), new Guid("d7bcb6e9-67e9-4afc-9d25-f169447500eb"), 200.0, "B", 5, "VAN" },
                    { new Guid("666c13de-7248-4159-a433-6518e3e1f4b9"), new Guid("15e5b2e9-d51f-4413-9a87-0a8051c82ff4"), 50.0, "B", 4, "MOTORCYCLE" },
                    { new Guid("66ae6e77-7dc6-4b09-95fd-c8b7495c41db"), new Guid("4f8943b0-c325-4306-8872-c0687a860552"), 200.0, "A", 8, "VAN" },
                    { new Guid("66c84d3d-6c8b-4884-81fd-c20117e40de3"), new Guid("88c0746c-384c-48a3-8a24-034a9d11e036"), 100.0, "B", 8, "CAR" },
                    { new Guid("66fad316-0a3b-451f-9753-2a19c8f04e45"), new Guid("bf471c98-2465-4e39-b3a4-a0a56d7f0b0c"), 200.0, "B", 3, "VAN" },
                    { new Guid("670b5adf-5d60-4107-a5c8-924e88ae39c9"), new Guid("0ea2b9de-200d-4f13-b796-bd86c412194b"), 50.0, "A", 6, "MOTORCYCLE" },
                    { new Guid("67170f90-bb89-488e-9b0b-d97e07601a61"), new Guid("cfeefc53-67a5-4e6a-a136-330d10920937"), 50.0, "B", 2, "MOTORCYCLE" },
                    { new Guid("67720b98-b891-4e3c-9c17-59d047d20a59"), new Guid("f5e07364-5770-4cca-8215-4bc9687928fd"), 100.0, "B", 4, "CAR" },
                    { new Guid("677d1fa2-943f-4a00-b6d8-08ee7d0082bd"), new Guid("d76e484e-5fd9-4cf5-8892-f4fcf44654fa"), 300.0, "B", 7, "TRUCK" },
                    { new Guid("678ea3b6-4876-4fbb-b0e7-577aa8931f0a"), new Guid("ab2501ec-a3d8-4027-98dd-df99be5a1bf9"), 200.0, "A", 4, "VAN" },
                    { new Guid("67925390-7928-4044-afb1-ca7cf3addfe7"), new Guid("561ae673-4668-49b7-81ca-2fc792ab1b3e"), 50.0, "B", 5, "MOTORCYCLE" },
                    { new Guid("684f17fa-d7ed-4a9d-9c74-1232387b9c8f"), new Guid("0e1cf06a-2c1f-4f3a-804f-0a21ca76a827"), 50.0, "B", 7, "MOTORCYCLE" },
                    { new Guid("68a9b99d-9fd6-4a18-b5e2-443b42425ddc"), new Guid("f5882dab-e003-453f-b642-a38560da3beb"), 50.0, "A", 5, "MOTORCYCLE" },
                    { new Guid("68ed8f67-132c-4f27-8bf7-1058b35cfe1a"), new Guid("15e5b2e9-d51f-4413-9a87-0a8051c82ff4"), 200.0, "A", 3, "VAN" },
                    { new Guid("690ed5e6-5e29-489b-a3ca-115972bdaea0"), new Guid("4f8943b0-c325-4306-8872-c0687a860552"), 200.0, "A", 4, "VAN" },
                    { new Guid("6914bc18-aa72-472c-a9ba-80c147d8b5b2"), new Guid("66ccfd45-4738-48da-ac09-400c1a1a26bb"), 100.0, "B", 2, "CAR" },
                    { new Guid("6959d709-2e23-4deb-be33-cb11335fc281"), new Guid("60bf0a3a-02aa-4218-8e61-a5dd00e5e0d4"), 50.0, "A", 7, "MOTORCYCLE" },
                    { new Guid("696cfa08-2283-4587-8cd3-2a4b174e9689"), new Guid("f5e07364-5770-4cca-8215-4bc9687928fd"), 100.0, "B", 1, "CAR" },
                    { new Guid("6973c2f3-1c73-40fa-a2aa-e0df9ef84f1f"), new Guid("c7dca08c-fee9-47a0-bb70-4dc53f2699d0"), 300.0, "B", 3, "TRUCK" },
                    { new Guid("6985facb-3b1b-41bf-b41a-057ffd0c2d55"), new Guid("4bbdfefd-5984-4fd5-ad27-04ef0d85ef60"), 300.0, "A", 2, "TRUCK" },
                    { new Guid("69902210-56da-4791-a2a9-375ea88d7d50"), new Guid("e07be4a4-a28a-4d40-bd21-3371ef69fc0b"), 200.0, "A", 2, "VAN" },
                    { new Guid("69ea9747-5041-4b76-a3f8-ac1f2874b8e2"), new Guid("04b75293-d378-4ee1-b298-9f723aa1e4bf"), 100.0, "B", 8, "CAR" },
                    { new Guid("6a08facd-73a4-475e-b251-f34a3f634c8e"), new Guid("9ef7200f-cd79-41e9-ac2b-c0215f0fc9fc"), 50.0, "A", 2, "MOTORCYCLE" },
                    { new Guid("6ae23626-76c8-4f7f-9bf5-3073b7a79f13"), new Guid("ac8d075d-9942-4f4e-b98f-e8df09ce60d3"), 300.0, "B", 3, "TRUCK" },
                    { new Guid("6af08a34-20b4-4831-a399-7fec6cc7fa9b"), new Guid("cacdb08a-111b-49ab-81b8-13817060e4e8"), 200.0, "B", 3, "VAN" },
                    { new Guid("6b06bb10-77a8-4971-bf6c-b71e1cfd0102"), new Guid("0ea2b9de-200d-4f13-b796-bd86c412194b"), 300.0, "B", 5, "TRUCK" },
                    { new Guid("6b773577-9839-45a8-a5fd-cecc598889d4"), new Guid("f5e07364-5770-4cca-8215-4bc9687928fd"), 300.0, "A", 4, "TRUCK" },
                    { new Guid("6b79b26f-607c-4231-af0a-27a769303dcf"), new Guid("18bb3ced-ef4c-4990-902d-9ccdbee03709"), 100.0, "B", 1, "CAR" },
                    { new Guid("6b8a2170-0268-430b-9588-eb2d93abefc3"), new Guid("561ae673-4668-49b7-81ca-2fc792ab1b3e"), 50.0, "B", 2, "MOTORCYCLE" },
                    { new Guid("6c01456f-c00f-4b7a-b29b-3609d5073b83"), new Guid("15e5b2e9-d51f-4413-9a87-0a8051c82ff4"), 200.0, "A", 7, "VAN" },
                    { new Guid("6c8e25c4-5be7-41d8-9876-90b4c6d44479"), new Guid("bf2771a1-c2c5-496e-beab-9667afd9bbfe"), 100.0, "A", 3, "CAR" },
                    { new Guid("6cb8733f-3724-4bcf-adde-cec049b81322"), new Guid("0e1cf06a-2c1f-4f3a-804f-0a21ca76a827"), 50.0, "B", 5, "MOTORCYCLE" },
                    { new Guid("6d52eca5-216e-4773-9a59-963d633fdcd5"), new Guid("ab2501ec-a3d8-4027-98dd-df99be5a1bf9"), 200.0, "A", 7, "VAN" },
                    { new Guid("6d80346f-27c7-43d7-b120-e49ddc1cff93"), new Guid("b74f87ee-301c-418b-a49a-4a8ebe631eb8"), 100.0, "B", 6, "CAR" },
                    { new Guid("6db050d1-35d5-461d-aa67-4eecbc664662"), new Guid("ae3959c4-5bca-457d-9c14-4cc88f49d61e"), 300.0, "A", 3, "TRUCK" },
                    { new Guid("6e0db4f4-47f8-42fa-bc31-e0273505691f"), new Guid("dec19efa-56f4-4a25-8590-7b1938391756"), 100.0, "A", 6, "CAR" },
                    { new Guid("6e0dd505-3d22-4b2b-af72-b3061736926d"), new Guid("a4cc4c37-d39f-4d36-9a60-2d6404fc97f6"), 100.0, "B", 6, "CAR" },
                    { new Guid("6e123d76-c38e-438f-9197-1a950e99e004"), new Guid("ed42e83a-2e39-4c0c-8803-4b595c801a43"), 50.0, "B", 6, "MOTORCYCLE" },
                    { new Guid("6ef469b6-37b2-4faf-b132-e076c28686fa"), new Guid("04b75293-d378-4ee1-b298-9f723aa1e4bf"), 100.0, "A", 7, "CAR" },
                    { new Guid("6fe417cf-7aef-4793-acf4-8a46348168dd"), new Guid("f5882dab-e003-453f-b642-a38560da3beb"), 50.0, "A", 2, "MOTORCYCLE" },
                    { new Guid("70143194-7407-494b-80c4-b4c6b90f22be"), new Guid("0b1a89a0-0f56-47cf-8cf8-6e15ec4f04ef"), 100.0, "B", 3, "CAR" },
                    { new Guid("701e8f73-c3cc-44fe-8f83-eae93155b111"), new Guid("bf2771a1-c2c5-496e-beab-9667afd9bbfe"), 100.0, "B", 3, "CAR" },
                    { new Guid("709679b8-1f17-4e16-bcea-8b71839fe1e9"), new Guid("d7bcb6e9-67e9-4afc-9d25-f169447500eb"), 100.0, "A", 1, "CAR" },
                    { new Guid("70d97ac6-d278-4458-beff-614cf7f55587"), new Guid("ac8d075d-9942-4f4e-b98f-e8df09ce60d3"), 300.0, "B", 8, "TRUCK" },
                    { new Guid("70f7e599-bc47-4336-8662-44d879bb09ce"), new Guid("7fd19919-4f47-4257-af41-0eaf6d2f3533"), 100.0, "A", 6, "CAR" },
                    { new Guid("715b91ec-e0a1-40a0-899f-f623e9e1297c"), new Guid("ac8d075d-9942-4f4e-b98f-e8df09ce60d3"), 100.0, "A", 1, "CAR" },
                    { new Guid("7172ca63-4f86-4f20-a3f7-9ab77fbcd0f9"), new Guid("ae3959c4-5bca-457d-9c14-4cc88f49d61e"), 100.0, "B", 4, "CAR" },
                    { new Guid("726ee0e3-f8ce-4f32-b4cf-c906f97b095e"), new Guid("04b75293-d378-4ee1-b298-9f723aa1e4bf"), 100.0, "A", 2, "CAR" },
                    { new Guid("728385e2-c45b-43da-9da0-57a497a00f81"), new Guid("ae3959c4-5bca-457d-9c14-4cc88f49d61e"), 300.0, "A", 8, "TRUCK" },
                    { new Guid("7293bc1f-fbf9-4750-a441-9bd735977e16"), new Guid("516e7943-059a-44cc-bd82-d4c4480a6676"), 100.0, "A", 4, "CAR" },
                    { new Guid("72d7a93b-67de-4b97-8bcf-cc9fc6f15004"), new Guid("f92eb003-edbb-4752-9d08-baf8cf0be864"), 50.0, "A", 3, "MOTORCYCLE" },
                    { new Guid("72ede12e-9ab7-460d-8c7e-10c7f4a274b7"), new Guid("66af1e03-1839-46f2-a5b1-999c4f3a5b30"), 200.0, "A", 5, "VAN" },
                    { new Guid("732fcc8e-fe8a-4c6d-8172-cef03e858a0f"), new Guid("bf2771a1-c2c5-496e-beab-9667afd9bbfe"), 100.0, "B", 7, "CAR" },
                    { new Guid("7338922b-3a76-4c46-8bb2-d54978ff95dc"), new Guid("30fd900a-27d9-4682-b5e2-db8c76e2062b"), 50.0, "A", 4, "MOTORCYCLE" },
                    { new Guid("73a69d2e-8a41-49f4-8204-14ec1657c830"), new Guid("18bb3ced-ef4c-4990-902d-9ccdbee03709"), 100.0, "A", 2, "CAR" },
                    { new Guid("7436ad00-acb4-42a4-9aa0-fb820e4f7ba4"), new Guid("ed42e83a-2e39-4c0c-8803-4b595c801a43"), 50.0, "B", 8, "MOTORCYCLE" },
                    { new Guid("746e4f76-4496-4f0d-8be4-dde491bd82f7"), new Guid("dec19efa-56f4-4a25-8590-7b1938391756"), 300.0, "B", 7, "TRUCK" },
                    { new Guid("74723afc-d2d2-470e-87fa-1d74b5b43400"), new Guid("454290bd-e2c7-4154-b980-cc091b14465d"), 50.0, "A", 2, "MOTORCYCLE" },
                    { new Guid("74a7ecb2-77c4-4326-a5ca-fa3b5b22a76f"), new Guid("76a04e41-7aa0-46e2-8c27-0b677cde6543"), 100.0, "B", 7, "CAR" },
                    { new Guid("75846cbe-3164-4aa2-8590-02bcd3cb3c27"), new Guid("0b1a89a0-0f56-47cf-8cf8-6e15ec4f04ef"), 50.0, "A", 7, "MOTORCYCLE" },
                    { new Guid("75941876-ddd1-483a-a027-ac7a872192c9"), new Guid("4bbdfefd-5984-4fd5-ad27-04ef0d85ef60"), 200.0, "B", 5, "VAN" },
                    { new Guid("75a57b34-8f55-4ae7-8766-e73e31414529"), new Guid("cc8bb9f7-35ca-4c40-8498-8e83c25136cd"), 300.0, "A", 1, "TRUCK" },
                    { new Guid("75fa6279-0ce4-4f58-8731-240b75d86355"), new Guid("8eda8dbd-513f-49c9-a050-7c8a6e6475d7"), 200.0, "B", 8, "VAN" },
                    { new Guid("7602984b-06b7-4445-a2f6-5a16c95192b1"), new Guid("c7dca08c-fee9-47a0-bb70-4dc53f2699d0"), 300.0, "B", 2, "TRUCK" },
                    { new Guid("7627024d-1162-479e-beff-bd62ab521877"), new Guid("a4cc4c37-d39f-4d36-9a60-2d6404fc97f6"), 100.0, "B", 3, "CAR" },
                    { new Guid("76f42be8-85e1-47d3-aa9e-24b08aa67382"), new Guid("d7bcb6e9-67e9-4afc-9d25-f169447500eb"), 100.0, "A", 3, "CAR" },
                    { new Guid("76f803d8-8942-41a3-bc3a-4c8ce2820d4e"), new Guid("d76e484e-5fd9-4cf5-8892-f4fcf44654fa"), 50.0, "A", 5, "MOTORCYCLE" },
                    { new Guid("77487f60-06ab-43eb-bc73-ecc5b4b7219c"), new Guid("c7dca08c-fee9-47a0-bb70-4dc53f2699d0"), 100.0, "A", 7, "CAR" },
                    { new Guid("778f8d22-d996-46f1-b6ff-f1b465882c45"), new Guid("b202d20c-9aca-47ab-8c0c-417b0566bc9a"), 100.0, "A", 3, "CAR" },
                    { new Guid("7795dd0a-96b7-4fb0-bf63-bc7f098ba377"), new Guid("cacdb08a-111b-49ab-81b8-13817060e4e8"), 100.0, "A", 4, "CAR" },
                    { new Guid("77d5ca1d-9404-40a1-b572-7c480c6a73fb"), new Guid("b7048c17-53ab-4005-8a80-eed7f70c6c99"), 100.0, "A", 5, "CAR" },
                    { new Guid("77e28cbc-d109-490f-a258-9e3fcf28fc14"), new Guid("eb01d97e-5919-4537-822f-2fff3c6fd84f"), 50.0, "A", 5, "MOTORCYCLE" },
                    { new Guid("789ff9b2-ac14-4b4c-a7e1-b88792549da4"), new Guid("47569aaa-bf51-4525-832e-9153120d433e"), 200.0, "A", 5, "VAN" },
                    { new Guid("78d54aa8-c025-4862-bb05-44826f349bea"), new Guid("561ae673-4668-49b7-81ca-2fc792ab1b3e"), 50.0, "A", 3, "MOTORCYCLE" },
                    { new Guid("7914fe70-b787-40b2-b940-d0769d42aea2"), new Guid("66af1e03-1839-46f2-a5b1-999c4f3a5b30"), 100.0, "B", 3, "CAR" },
                    { new Guid("793a0eee-3ca6-43a2-afb5-bbbe3a73ca69"), new Guid("4bbdfefd-5984-4fd5-ad27-04ef0d85ef60"), 300.0, "A", 7, "TRUCK" },
                    { new Guid("794f4130-e169-4af6-932c-56bdc8d62110"), new Guid("76a04e41-7aa0-46e2-8c27-0b677cde6543"), 100.0, "B", 6, "CAR" },
                    { new Guid("79577990-0c48-4fcc-8033-b6edc2f128f9"), new Guid("e5dceac8-c4a8-4f0a-b51b-9a305ff65216"), 200.0, "A", 6, "VAN" },
                    { new Guid("7984ff9c-6329-46a5-8d1f-6bb9b0ac215e"), new Guid("f5e07364-5770-4cca-8215-4bc9687928fd"), 100.0, "B", 7, "CAR" },
                    { new Guid("79a1926f-d61b-4020-9256-4123310f92d8"), new Guid("14f021ba-4e08-416b-8751-e5d09e9b107d"), 300.0, "B", 1, "TRUCK" },
                    { new Guid("7a841024-3e19-4093-9d11-56f141faf898"), new Guid("2aedce44-d62f-4847-a9ad-2245b9d31387"), 100.0, "A", 2, "CAR" },
                    { new Guid("7ae85df1-bc10-48c5-a611-494c51b14a03"), new Guid("2aedce44-d62f-4847-a9ad-2245b9d31387"), 300.0, "B", 3, "TRUCK" },
                    { new Guid("7b1342ee-1fa2-4de7-983b-e4ae03b5fca1"), new Guid("325cdcfb-5542-41fb-bca0-5aec0a1f8209"), 300.0, "B", 5, "TRUCK" },
                    { new Guid("7b14ba12-d9fc-4d42-85b5-84f175e60405"), new Guid("18bb3ced-ef4c-4990-902d-9ccdbee03709"), 100.0, "B", 7, "CAR" },
                    { new Guid("7b681fe6-27f0-421c-9f68-6f1b80cabdd8"), new Guid("d12f5883-ab8e-4d3f-a967-ec7675a0ab47"), 50.0, "B", 7, "MOTORCYCLE" },
                    { new Guid("7b9f077e-8fdb-4cdc-b10e-673dd3bd22a8"), new Guid("564ba9ef-c816-47d7-a41b-a7b061183905"), 50.0, "B", 1, "MOTORCYCLE" },
                    { new Guid("7babefae-dbe5-4387-8b05-b14fa6c00b61"), new Guid("a4cc4c37-d39f-4d36-9a60-2d6404fc97f6"), 100.0, "B", 4, "CAR" },
                    { new Guid("7bc75da5-bbfc-425a-a8e4-d4b54fc06b84"), new Guid("561ae673-4668-49b7-81ca-2fc792ab1b3e"), 50.0, "B", 4, "MOTORCYCLE" },
                    { new Guid("7c783e41-c906-49a1-b644-96b33c3e88a7"), new Guid("15e5b2e9-d51f-4413-9a87-0a8051c82ff4"), 200.0, "A", 8, "VAN" },
                    { new Guid("7cf39454-c29c-48f2-a3fc-bef070531a37"), new Guid("b1ad3048-49d6-4a9a-a0f8-d99e3f5f70f5"), 300.0, "B", 5, "TRUCK" },
                    { new Guid("7cf64752-38ff-407f-b823-7a7e7c41f624"), new Guid("5a1062de-7895-4914-b081-cc7ff9e007e7"), 100.0, "B", 5, "CAR" },
                    { new Guid("7dd40ff0-2eb0-43eb-ac61-da1308c8ce1f"), new Guid("5a1062de-7895-4914-b081-cc7ff9e007e7"), 50.0, "A", 6, "MOTORCYCLE" },
                    { new Guid("7e544d51-1835-4f2b-823f-2da1c9b45e4c"), new Guid("76a04e41-7aa0-46e2-8c27-0b677cde6543"), 50.0, "A", 3, "MOTORCYCLE" },
                    { new Guid("7eae2b4f-34c1-4b59-b4aa-b85d287a1250"), new Guid("e5dceac8-c4a8-4f0a-b51b-9a305ff65216"), 200.0, "B", 1, "VAN" },
                    { new Guid("7ee2e1fb-52a8-499f-b818-d849cdf5a60e"), new Guid("d12f5883-ab8e-4d3f-a967-ec7675a0ab47"), 300.0, "A", 5, "TRUCK" },
                    { new Guid("7f019046-5759-44b4-b42a-c0583b58993a"), new Guid("30fd900a-27d9-4682-b5e2-db8c76e2062b"), 50.0, "B", 6, "MOTORCYCLE" },
                    { new Guid("7f50819b-c243-4a70-9712-6685d84a7783"), new Guid("47569aaa-bf51-4525-832e-9153120d433e"), 200.0, "B", 1, "VAN" },
                    { new Guid("7f7c4369-b41b-4676-98fa-10d5092f813a"), new Guid("cfeefc53-67a5-4e6a-a136-330d10920937"), 100.0, "A", 5, "CAR" },
                    { new Guid("7fe8ebd4-827d-438d-a7ac-e6eea4d80499"), new Guid("ae3959c4-5bca-457d-9c14-4cc88f49d61e"), 100.0, "B", 1, "CAR" },
                    { new Guid("7fea20aa-f312-4dec-914d-20a60f009d4e"), new Guid("d12f5883-ab8e-4d3f-a967-ec7675a0ab47"), 300.0, "A", 6, "TRUCK" },
                    { new Guid("802fb454-b42f-4406-b9ea-c67dd1b01742"), new Guid("564ba9ef-c816-47d7-a41b-a7b061183905"), 200.0, "A", 2, "VAN" },
                    { new Guid("80b68db2-79d5-45bf-94b5-1e909cb56137"), new Guid("40448bf3-c284-402d-a1bf-7593c2d267c4"), 300.0, "B", 1, "TRUCK" },
                    { new Guid("80c4038d-fe51-4050-ac57-8bf29d0c65b7"), new Guid("bf471c98-2465-4e39-b3a4-a0a56d7f0b0c"), 50.0, "A", 2, "MOTORCYCLE" },
                    { new Guid("81811324-d8d1-46e3-8b7c-20bbbb4ca489"), new Guid("d12f5883-ab8e-4d3f-a967-ec7675a0ab47"), 300.0, "A", 7, "TRUCK" },
                    { new Guid("81d2cce1-74ab-4c8a-99ef-2b3350d44b42"), new Guid("e07be4a4-a28a-4d40-bd21-3371ef69fc0b"), 100.0, "B", 7, "CAR" },
                    { new Guid("820db283-b11d-4623-a4ba-37a72e7fcf2b"), new Guid("40448bf3-c284-402d-a1bf-7593c2d267c4"), 300.0, "B", 4, "TRUCK" },
                    { new Guid("827b6064-75c3-471a-a61e-7a7d58f55561"), new Guid("eb01d97e-5919-4537-822f-2fff3c6fd84f"), 50.0, "A", 4, "MOTORCYCLE" },
                    { new Guid("828763c5-b79f-4615-8aba-315d1fc76675"), new Guid("ae3959c4-5bca-457d-9c14-4cc88f49d61e"), 300.0, "A", 4, "TRUCK" },
                    { new Guid("82cd9d15-3a04-4aba-97be-4cd59fb681bb"), new Guid("325cdcfb-5542-41fb-bca0-5aec0a1f8209"), 300.0, "A", 1, "TRUCK" },
                    { new Guid("82d5d9a7-c2ae-4454-80da-67cf9b6b7d84"), new Guid("0e6822f5-7394-400d-bca7-a4cc4dd28978"), 50.0, "A", 1, "MOTORCYCLE" },
                    { new Guid("83961ba2-622b-4ce9-9f8d-f9371a6cf53a"), new Guid("c7dca08c-fee9-47a0-bb70-4dc53f2699d0"), 100.0, "A", 8, "CAR" },
                    { new Guid("83f722e9-eead-4b0e-9307-0f90ecb10600"), new Guid("cfeefc53-67a5-4e6a-a136-330d10920937"), 50.0, "B", 1, "MOTORCYCLE" },
                    { new Guid("83fd1a63-6dc7-4396-92fa-2773a677981e"), new Guid("d76e484e-5fd9-4cf5-8892-f4fcf44654fa"), 300.0, "B", 3, "TRUCK" },
                    { new Guid("8411f1cd-1c96-4e0c-8d85-70fdc16605a6"), new Guid("18bb3ced-ef4c-4990-902d-9ccdbee03709"), 100.0, "A", 3, "CAR" },
                    { new Guid("842a0167-1530-4659-a941-ec350e17a0c8"), new Guid("f5e07364-5770-4cca-8215-4bc9687928fd"), 300.0, "A", 8, "TRUCK" },
                    { new Guid("8480bfba-5e74-43af-ac69-4aa2a823d19c"), new Guid("bf2771a1-c2c5-496e-beab-9667afd9bbfe"), 100.0, "A", 4, "CAR" },
                    { new Guid("8485dda4-4693-436c-8064-5a37bf912406"), new Guid("b202d20c-9aca-47ab-8c0c-417b0566bc9a"), 200.0, "B", 6, "VAN" },
                    { new Guid("857d9a1d-3c99-4bb9-82d2-d762c29c6c3a"), new Guid("f5e07364-5770-4cca-8215-4bc9687928fd"), 100.0, "B", 8, "CAR" },
                    { new Guid("85aad4da-913e-4186-ba0e-a4dd71e0bb63"), new Guid("4f8943b0-c325-4306-8872-c0687a860552"), 200.0, "A", 7, "VAN" },
                    { new Guid("86330967-f06f-4b37-8a3d-29a31049ba6d"), new Guid("14f021ba-4e08-416b-8751-e5d09e9b107d"), 100.0, "A", 1, "CAR" },
                    { new Guid("865e12b4-5de1-470e-b9e4-5f6aee6686d2"), new Guid("a4cc4c37-d39f-4d36-9a60-2d6404fc97f6"), 100.0, "B", 1, "CAR" },
                    { new Guid("8680efeb-6d28-438c-bea9-84bc77613270"), new Guid("ac8d075d-9942-4f4e-b98f-e8df09ce60d3"), 300.0, "B", 1, "TRUCK" },
                    { new Guid("86850071-73e1-4881-9b09-b7ec3cf044fb"), new Guid("e07be4a4-a28a-4d40-bd21-3371ef69fc0b"), 100.0, "B", 4, "CAR" },
                    { new Guid("87015ed7-c9a2-4b1f-855b-11ff5dc72cf5"), new Guid("40448bf3-c284-402d-a1bf-7593c2d267c4"), 100.0, "A", 8, "CAR" },
                    { new Guid("875cdc66-9535-4aec-a7b0-9460cd7e3a59"), new Guid("76a04e41-7aa0-46e2-8c27-0b677cde6543"), 50.0, "A", 4, "MOTORCYCLE" },
                    { new Guid("879d0096-6342-4b3d-aaa4-034a27a9ddd9"), new Guid("454290bd-e2c7-4154-b980-cc091b14465d"), 300.0, "B", 5, "TRUCK" },
                    { new Guid("87abaa98-fddc-4196-9122-a89740d5d886"), new Guid("cc8bb9f7-35ca-4c40-8498-8e83c25136cd"), 300.0, "A", 7, "TRUCK" },
                    { new Guid("87cab68a-05bd-4a00-a067-c1658303158c"), new Guid("d7bcb6e9-67e9-4afc-9d25-f169447500eb"), 200.0, "B", 1, "VAN" },
                    { new Guid("87e70b9a-dbfc-404d-9ee3-60edd4191ac9"), new Guid("2aedce44-d62f-4847-a9ad-2245b9d31387"), 300.0, "B", 2, "TRUCK" },
                    { new Guid("87fa7b31-964f-4081-848d-d569db372de8"), new Guid("66ccfd45-4738-48da-ac09-400c1a1a26bb"), 100.0, "B", 7, "CAR" },
                    { new Guid("88b5f44d-146b-441d-bbc0-d1271912d743"), new Guid("0e1cf06a-2c1f-4f3a-804f-0a21ca76a827"), 300.0, "A", 7, "TRUCK" },
                    { new Guid("88c9cfcc-21b0-4616-b0ad-a4d6ee6c5b0b"), new Guid("7fd19919-4f47-4257-af41-0eaf6d2f3533"), 100.0, "B", 8, "CAR" },
                    { new Guid("88cbb5f6-cd10-4dbb-9bae-81ef82cdcb09"), new Guid("37b1553e-e0cc-460c-b0a8-d72fea93dadc"), 300.0, "B", 5, "TRUCK" },
                    { new Guid("88eb7051-5a0d-4729-8e35-04409a44b48b"), new Guid("8eda8dbd-513f-49c9-a050-7c8a6e6475d7"), 200.0, "A", 5, "VAN" },
                    { new Guid("897de6f2-7a02-4071-8bcf-d6babcffb620"), new Guid("b1ad3048-49d6-4a9a-a0f8-d99e3f5f70f5"), 300.0, "A", 3, "TRUCK" },
                    { new Guid("89be92f3-083d-4dad-ba60-264ee2b5691d"), new Guid("f5e07364-5770-4cca-8215-4bc9687928fd"), 300.0, "A", 7, "TRUCK" },
                    { new Guid("8a1e06cf-4d42-4e45-bd1e-8c922e875ad6"), new Guid("13d8bc75-3ef2-4d55-a2bd-ffc7a683e7e4"), 300.0, "B", 2, "TRUCK" },
                    { new Guid("8a49077a-1553-4b4c-81c6-3d133d508d1e"), new Guid("5a1062de-7895-4914-b081-cc7ff9e007e7"), 50.0, "A", 5, "MOTORCYCLE" },
                    { new Guid("8abe1484-a11c-4d0b-8a00-5e1b270d97ef"), new Guid("47569aaa-bf51-4525-832e-9153120d433e"), 200.0, "B", 5, "VAN" },
                    { new Guid("8ac4a4cd-181a-40a5-9d5b-b835c811416b"), new Guid("561ae673-4668-49b7-81ca-2fc792ab1b3e"), 50.0, "B", 6, "MOTORCYCLE" },
                    { new Guid("8ac8420f-e679-492b-8e52-8837c20a9c77"), new Guid("d12f5883-ab8e-4d3f-a967-ec7675a0ab47"), 300.0, "A", 2, "TRUCK" },
                    { new Guid("8ada301a-2f03-4051-9e60-732fe9899f47"), new Guid("325cdcfb-5542-41fb-bca0-5aec0a1f8209"), 300.0, "A", 4, "TRUCK" },
                    { new Guid("8af4922f-b939-4ec6-9d11-8e0ab98ccd03"), new Guid("15e5b2e9-d51f-4413-9a87-0a8051c82ff4"), 50.0, "B", 6, "MOTORCYCLE" },
                    { new Guid("8b492288-a6ed-48de-9714-346221701354"), new Guid("6834e8ac-9efa-4f21-a027-d8ae1c1b973e"), 100.0, "B", 6, "CAR" },
                    { new Guid("8b4a8fea-7147-4c66-83e0-9165e68ed108"), new Guid("325cdcfb-5542-41fb-bca0-5aec0a1f8209"), 300.0, "B", 7, "TRUCK" },
                    { new Guid("8d826623-83fe-4dc1-bbc8-99630934fcf7"), new Guid("516e7943-059a-44cc-bd82-d4c4480a6676"), 100.0, "B", 7, "CAR" },
                    { new Guid("8da810f2-73c3-4c87-a84b-c295f3a6c7c4"), new Guid("ae3959c4-5bca-457d-9c14-4cc88f49d61e"), 100.0, "B", 7, "CAR" },
                    { new Guid("8e309c1e-d639-4766-a7a9-3e8e80de37e0"), new Guid("d76e484e-5fd9-4cf5-8892-f4fcf44654fa"), 300.0, "B", 6, "TRUCK" },
                    { new Guid("8e62920d-1e49-4b22-90a0-7143d576cd7d"), new Guid("88c0746c-384c-48a3-8a24-034a9d11e036"), 100.0, "B", 4, "CAR" },
                    { new Guid("8eac6ed1-7bcf-48e0-8e9a-d1f94d12fb05"), new Guid("ac8d075d-9942-4f4e-b98f-e8df09ce60d3"), 300.0, "B", 6, "TRUCK" },
                    { new Guid("8ee22289-7650-4857-b9c3-5478d2d20586"), new Guid("0ea2b9de-200d-4f13-b796-bd86c412194b"), 50.0, "A", 4, "MOTORCYCLE" },
                    { new Guid("8ef8fe8f-1bbb-454c-8fed-6bb7e2d374a9"), new Guid("0b1a89a0-0f56-47cf-8cf8-6e15ec4f04ef"), 100.0, "B", 7, "CAR" },
                    { new Guid("8f01fa4d-5162-41f0-b0ab-1e804e41a91e"), new Guid("66af1e03-1839-46f2-a5b1-999c4f3a5b30"), 200.0, "A", 2, "VAN" },
                    { new Guid("8f76cb16-4160-4b36-9e84-a8af20363e76"), new Guid("ae3959c4-5bca-457d-9c14-4cc88f49d61e"), 300.0, "A", 5, "TRUCK" },
                    { new Guid("8faf8cba-bbe8-4811-8235-9c5e399a75ee"), new Guid("13d8bc75-3ef2-4d55-a2bd-ffc7a683e7e4"), 300.0, "B", 7, "TRUCK" },
                    { new Guid("9031ab9a-394a-4887-afe9-aba037518aee"), new Guid("18bb3ced-ef4c-4990-902d-9ccdbee03709"), 100.0, "A", 5, "CAR" },
                    { new Guid("904dbf8d-6719-433d-9c05-69da4fa01d3d"), new Guid("cfeefc53-67a5-4e6a-a136-330d10920937"), 50.0, "B", 5, "MOTORCYCLE" },
                    { new Guid("905c4e1b-8d13-4b2c-920e-f357fecea8a5"), new Guid("c7dca08c-fee9-47a0-bb70-4dc53f2699d0"), 300.0, "B", 8, "TRUCK" },
                    { new Guid("907c918c-f827-4390-a115-6d5e761bec64"), new Guid("325cdcfb-5542-41fb-bca0-5aec0a1f8209"), 300.0, "B", 6, "TRUCK" },
                    { new Guid("90a2015a-547b-46eb-9e1a-4623ff0857a8"), new Guid("8eda8dbd-513f-49c9-a050-7c8a6e6475d7"), 200.0, "A", 4, "VAN" },
                    { new Guid("9146efae-3cea-4e50-aeb8-1e382f8de68c"), new Guid("325cdcfb-5542-41fb-bca0-5aec0a1f8209"), 300.0, "B", 1, "TRUCK" },
                    { new Guid("91aa6884-1a46-4efe-94c6-f1bcae2ed5c5"), new Guid("eb01d97e-5919-4537-822f-2fff3c6fd84f"), 50.0, "A", 7, "MOTORCYCLE" },
                    { new Guid("91b30942-84f1-4062-83cd-a80f950308d9"), new Guid("c5d2c35b-c774-4f68-bc8b-4b23482c4244"), 300.0, "A", 1, "TRUCK" },
                    { new Guid("91d0594b-4b87-4d15-a87b-b7e1c84dc319"), new Guid("7fd19919-4f47-4257-af41-0eaf6d2f3533"), 100.0, "B", 2, "CAR" },
                    { new Guid("93236b99-ef2f-432e-a833-537e8e5c0145"), new Guid("cacdb08a-111b-49ab-81b8-13817060e4e8"), 200.0, "B", 5, "VAN" },
                    { new Guid("937ac073-946d-4cee-8c9d-1afe8784162a"), new Guid("47569aaa-bf51-4525-832e-9153120d433e"), 200.0, "A", 3, "VAN" },
                    { new Guid("94b538cc-d6d6-4de1-807d-0b9fe75bb982"), new Guid("e07be4a4-a28a-4d40-bd21-3371ef69fc0b"), 200.0, "A", 7, "VAN" },
                    { new Guid("94d8853d-1c4c-4d12-a47b-1ec02ce345d2"), new Guid("b74f87ee-301c-418b-a49a-4a8ebe631eb8"), 50.0, "A", 1, "MOTORCYCLE" },
                    { new Guid("9533cdbd-ba73-4c1b-aa68-c395ff6875d8"), new Guid("bf2771a1-c2c5-496e-beab-9667afd9bbfe"), 100.0, "A", 8, "CAR" },
                    { new Guid("95698810-834d-4f25-89bf-3d5aecd88502"), new Guid("76a04e41-7aa0-46e2-8c27-0b677cde6543"), 100.0, "B", 3, "CAR" },
                    { new Guid("956d8a84-e53b-4b6b-87b1-666569921f09"), new Guid("76a04e41-7aa0-46e2-8c27-0b677cde6543"), 50.0, "A", 1, "MOTORCYCLE" },
                    { new Guid("95d83f41-7f1a-49a9-9474-51934391774f"), new Guid("8eda8dbd-513f-49c9-a050-7c8a6e6475d7"), 200.0, "A", 2, "VAN" },
                    { new Guid("96177c8b-4715-4e7b-8cf5-a3a7a2f4033b"), new Guid("ed42e83a-2e39-4c0c-8803-4b595c801a43"), 50.0, "A", 6, "MOTORCYCLE" },
                    { new Guid("962f6fc2-3628-415e-b843-cad6b34aff0a"), new Guid("f92eb003-edbb-4752-9d08-baf8cf0be864"), 50.0, "A", 5, "MOTORCYCLE" },
                    { new Guid("964211e1-d57e-42a1-b54c-060918beb6bc"), new Guid("0b1a89a0-0f56-47cf-8cf8-6e15ec4f04ef"), 100.0, "B", 1, "CAR" },
                    { new Guid("9661c9c9-f9e5-47ce-bdb6-9558ca15ba06"), new Guid("f8fec2b0-96c9-47ff-be70-eee9e7195d60"), 200.0, "B", 8, "VAN" },
                    { new Guid("96ddca87-abe6-49e5-ac5b-1e85f3b9d03c"), new Guid("40448bf3-c284-402d-a1bf-7593c2d267c4"), 300.0, "B", 6, "TRUCK" },
                    { new Guid("9741f437-81ab-494d-8b6f-b2c9eb2f48b7"), new Guid("cc8bb9f7-35ca-4c40-8498-8e83c25136cd"), 50.0, "B", 3, "MOTORCYCLE" },
                    { new Guid("97811313-e5a4-4427-931c-5ff3f5ca00b2"), new Guid("0e6822f5-7394-400d-bca7-a4cc4dd28978"), 50.0, "A", 8, "MOTORCYCLE" },
                    { new Guid("9897f01c-f90e-4d13-863f-65c979de732d"), new Guid("c5d2c35b-c774-4f68-bc8b-4b23482c4244"), 300.0, "A", 6, "TRUCK" },
                    { new Guid("98f79a68-9aef-4110-904c-7c09d42aac3e"), new Guid("b1ad3048-49d6-4a9a-a0f8-d99e3f5f70f5"), 300.0, "B", 3, "TRUCK" },
                    { new Guid("991491ff-4dce-4c6f-a2d6-d70cf30c6adf"), new Guid("564ba9ef-c816-47d7-a41b-a7b061183905"), 50.0, "B", 6, "MOTORCYCLE" },
                    { new Guid("9920e1d1-0515-4d17-a92e-5a47acc1ac31"), new Guid("0e1cf06a-2c1f-4f3a-804f-0a21ca76a827"), 300.0, "A", 3, "TRUCK" },
                    { new Guid("99369fba-26f0-49de-8ee1-4343bf0c60ef"), new Guid("a4cc4c37-d39f-4d36-9a60-2d6404fc97f6"), 200.0, "A", 4, "VAN" },
                    { new Guid("994a94f3-eb7a-477d-bc0b-00e5fc7c229a"), new Guid("88c0746c-384c-48a3-8a24-034a9d11e036"), 100.0, "B", 7, "CAR" },
                    { new Guid("99501e4a-406a-49cd-8e50-1fdf519e1a38"), new Guid("5a1062de-7895-4914-b081-cc7ff9e007e7"), 100.0, "B", 2, "CAR" },
                    { new Guid("9a41069f-434f-4344-a84b-b98e4c8d4029"), new Guid("325cdcfb-5542-41fb-bca0-5aec0a1f8209"), 300.0, "B", 8, "TRUCK" },
                    { new Guid("9ae0a20e-364f-4f5e-91d7-d28e13de5a00"), new Guid("2aedce44-d62f-4847-a9ad-2245b9d31387"), 100.0, "A", 1, "CAR" },
                    { new Guid("9aec1bd2-465c-4ca7-b0b0-f0d7a0a533b8"), new Guid("e07be4a4-a28a-4d40-bd21-3371ef69fc0b"), 200.0, "A", 8, "VAN" },
                    { new Guid("9b842efd-527c-4ea7-a2b9-ea75844776ed"), new Guid("a2702078-cb6b-4d1d-a83a-640674eeeffe"), 300.0, "B", 7, "TRUCK" },
                    { new Guid("9b8c533d-9305-4f5f-9f83-f3bce7985f0d"), new Guid("561ae673-4668-49b7-81ca-2fc792ab1b3e"), 50.0, "B", 1, "MOTORCYCLE" },
                    { new Guid("9c2212a3-4dd6-454e-b570-c6e8d5d22211"), new Guid("cfeefc53-67a5-4e6a-a136-330d10920937"), 50.0, "B", 4, "MOTORCYCLE" },
                    { new Guid("9cc32e19-2876-4a80-a3be-1bb0207ed19c"), new Guid("13d8bc75-3ef2-4d55-a2bd-ffc7a683e7e4"), 300.0, "A", 5, "TRUCK" },
                    { new Guid("9d23f16d-21a2-4a26-aab5-da49eb6f488e"), new Guid("eb01d97e-5919-4537-822f-2fff3c6fd84f"), 300.0, "B", 7, "TRUCK" },
                    { new Guid("9d280ead-b69b-4a41-9c12-ddae243c75ca"), new Guid("9ef7200f-cd79-41e9-ac2b-c0215f0fc9fc"), 50.0, "A", 6, "MOTORCYCLE" },
                    { new Guid("9e5f627d-af75-4972-b82b-9c5ceb705150"), new Guid("516e7943-059a-44cc-bd82-d4c4480a6676"), 100.0, "B", 3, "CAR" },
                    { new Guid("9ec9ca09-de57-4de7-aedd-43203dc9a903"), new Guid("564ba9ef-c816-47d7-a41b-a7b061183905"), 50.0, "B", 2, "MOTORCYCLE" },
                    { new Guid("9f0cc7db-d3c8-4b65-b546-387d16bd1b6a"), new Guid("f92eb003-edbb-4752-9d08-baf8cf0be864"), 100.0, "B", 6, "CAR" },
                    { new Guid("9fa030f0-29cd-4a03-90de-188a282a4833"), new Guid("9ef7200f-cd79-41e9-ac2b-c0215f0fc9fc"), 300.0, "B", 7, "TRUCK" },
                    { new Guid("a0317d77-351e-4660-90b2-2b978a90d3e9"), new Guid("66af1e03-1839-46f2-a5b1-999c4f3a5b30"), 100.0, "B", 6, "CAR" },
                    { new Guid("a05d8d44-a2dd-4fc9-89c8-f126af9db7d8"), new Guid("325cdcfb-5542-41fb-bca0-5aec0a1f8209"), 300.0, "A", 2, "TRUCK" },
                    { new Guid("a086379c-51fc-42f8-848b-5fba66378ba4"), new Guid("f5e07364-5770-4cca-8215-4bc9687928fd"), 100.0, "B", 5, "CAR" },
                    { new Guid("a0fad794-507c-4367-b721-17902b17f8eb"), new Guid("8eda8dbd-513f-49c9-a050-7c8a6e6475d7"), 200.0, "B", 2, "VAN" },
                    { new Guid("a12e0925-3153-4a0f-98c8-3186fcc3b673"), new Guid("a4cc4c37-d39f-4d36-9a60-2d6404fc97f6"), 200.0, "A", 2, "VAN" },
                    { new Guid("a13f7268-6410-49d5-ab27-335dc94125db"), new Guid("454290bd-e2c7-4154-b980-cc091b14465d"), 300.0, "B", 7, "TRUCK" },
                    { new Guid("a18f0d47-c186-49f8-934b-d8cac6e5992c"), new Guid("4f8943b0-c325-4306-8872-c0687a860552"), 300.0, "B", 5, "TRUCK" },
                    { new Guid("a1908a65-9764-4821-ae3b-4a053ae5793b"), new Guid("ae3959c4-5bca-457d-9c14-4cc88f49d61e"), 300.0, "A", 2, "TRUCK" },
                    { new Guid("a199011b-38fd-4b96-93f2-e269aa755f16"), new Guid("f8fec2b0-96c9-47ff-be70-eee9e7195d60"), 300.0, "A", 8, "TRUCK" },
                    { new Guid("a26e9190-02c7-44f1-93d9-f689c258e93b"), new Guid("d7bcb6e9-67e9-4afc-9d25-f169447500eb"), 100.0, "A", 8, "CAR" },
                    { new Guid("a2fdd6c6-d748-43c3-a4ca-98a46376b28e"), new Guid("564ba9ef-c816-47d7-a41b-a7b061183905"), 50.0, "B", 3, "MOTORCYCLE" },
                    { new Guid("a2ffc8e9-316c-4e93-8d3a-d885a22a02de"), new Guid("cdd98f54-2de4-464d-912e-488674be6f46"), 50.0, "A", 6, "MOTORCYCLE" },
                    { new Guid("a3137c9e-b2e2-4eed-858b-c70f287b70c3"), new Guid("18bb3ced-ef4c-4990-902d-9ccdbee03709"), 100.0, "B", 3, "CAR" },
                    { new Guid("a385ceb4-b6cc-46b4-8033-f6e305d76560"), new Guid("cdd98f54-2de4-464d-912e-488674be6f46"), 50.0, "A", 7, "MOTORCYCLE" },
                    { new Guid("a3a7877f-3681-4870-b78a-489838eab71d"), new Guid("60bf0a3a-02aa-4218-8e61-a5dd00e5e0d4"), 50.0, "A", 5, "MOTORCYCLE" },
                    { new Guid("a3f41c72-11e2-4fde-88c7-88011ef52342"), new Guid("4bbdfefd-5984-4fd5-ad27-04ef0d85ef60"), 300.0, "A", 8, "TRUCK" },
                    { new Guid("a4037797-81e6-43d2-a48f-76171e7c6c9e"), new Guid("c5d2c35b-c774-4f68-bc8b-4b23482c4244"), 100.0, "B", 8, "CAR" },
                    { new Guid("a405ca26-1589-47d5-aa60-f432fc4a3dd7"), new Guid("325cdcfb-5542-41fb-bca0-5aec0a1f8209"), 300.0, "B", 3, "TRUCK" },
                    { new Guid("a40d7952-f3c0-486c-b9a2-e4e5711c22e2"), new Guid("f8fec2b0-96c9-47ff-be70-eee9e7195d60"), 200.0, "B", 6, "VAN" },
                    { new Guid("a43939ca-f795-4a6d-8fcc-e02c4981e254"), new Guid("e5dceac8-c4a8-4f0a-b51b-9a305ff65216"), 200.0, "B", 6, "VAN" },
                    { new Guid("a4d69654-84cf-49a2-8043-1c20647c9cf8"), new Guid("76a04e41-7aa0-46e2-8c27-0b677cde6543"), 100.0, "B", 5, "CAR" },
                    { new Guid("a4eeaa93-5b7c-4983-b3d3-120a70fc189f"), new Guid("a2702078-cb6b-4d1d-a83a-640674eeeffe"), 200.0, "A", 3, "VAN" },
                    { new Guid("a53afe08-481b-4e9c-8b63-f097e05a4e3a"), new Guid("d76e484e-5fd9-4cf5-8892-f4fcf44654fa"), 50.0, "A", 8, "MOTORCYCLE" },
                    { new Guid("a54e2542-81ef-4547-a2c0-5a5397cc4a18"), new Guid("8eda8dbd-513f-49c9-a050-7c8a6e6475d7"), 200.0, "A", 1, "VAN" },
                    { new Guid("a5c069e1-f7e1-46f0-a4f0-ed46057fd7b3"), new Guid("5a1062de-7895-4914-b081-cc7ff9e007e7"), 100.0, "B", 1, "CAR" },
                    { new Guid("a65a4018-e551-40de-8d15-cce8f5986fb8"), new Guid("18bb3ced-ef4c-4990-902d-9ccdbee03709"), 100.0, "B", 2, "CAR" },
                    { new Guid("a6630a7a-984b-4aac-9085-6003201e77ad"), new Guid("5a1062de-7895-4914-b081-cc7ff9e007e7"), 100.0, "B", 3, "CAR" },
                    { new Guid("a668be51-f794-440c-ab4f-d6416982ca2a"), new Guid("bf471c98-2465-4e39-b3a4-a0a56d7f0b0c"), 200.0, "B", 5, "VAN" },
                    { new Guid("a6754fd8-37db-4a12-820c-3932306376c9"), new Guid("8eda8dbd-513f-49c9-a050-7c8a6e6475d7"), 200.0, "A", 8, "VAN" },
                    { new Guid("a688a146-3dda-458e-955c-0c18d0140a35"), new Guid("15e5b2e9-d51f-4413-9a87-0a8051c82ff4"), 200.0, "A", 4, "VAN" },
                    { new Guid("a713f8ba-6108-470d-91f0-acbc2cb15122"), new Guid("cdd98f54-2de4-464d-912e-488674be6f46"), 50.0, "A", 2, "MOTORCYCLE" },
                    { new Guid("a726ee39-a4b6-4b2d-b9d9-661186f7e262"), new Guid("b7048c17-53ab-4005-8a80-eed7f70c6c99"), 100.0, "A", 1, "CAR" },
                    { new Guid("a73fe73f-5a4c-412b-9030-0eb12c7895c7"), new Guid("8eda8dbd-513f-49c9-a050-7c8a6e6475d7"), 200.0, "B", 6, "VAN" },
                    { new Guid("a761d52b-db5c-43f2-82b5-fc4b361f8bc8"), new Guid("b74f87ee-301c-418b-a49a-4a8ebe631eb8"), 50.0, "A", 6, "MOTORCYCLE" },
                    { new Guid("a7927a58-7b01-4af1-86a7-d267e3dd23f9"), new Guid("cfeefc53-67a5-4e6a-a136-330d10920937"), 100.0, "A", 4, "CAR" },
                    { new Guid("a803587d-de77-4fb0-9823-743f3330e0a1"), new Guid("9ef7200f-cd79-41e9-ac2b-c0215f0fc9fc"), 300.0, "B", 5, "TRUCK" },
                    { new Guid("a822e3db-c9b0-4cfa-b0aa-888d85f114aa"), new Guid("40448bf3-c284-402d-a1bf-7593c2d267c4"), 300.0, "B", 5, "TRUCK" },
                    { new Guid("a825e922-a61b-469a-ae0d-8ed63181aa63"), new Guid("454290bd-e2c7-4154-b980-cc091b14465d"), 300.0, "B", 6, "TRUCK" },
                    { new Guid("a88a5726-6185-413c-8aa6-2c3d33078e39"), new Guid("15e5b2e9-d51f-4413-9a87-0a8051c82ff4"), 50.0, "B", 1, "MOTORCYCLE" },
                    { new Guid("a8f19574-bcb7-4a67-9d7b-827debe9d13b"), new Guid("9ef7200f-cd79-41e9-ac2b-c0215f0fc9fc"), 50.0, "A", 3, "MOTORCYCLE" },
                    { new Guid("a9543c8c-bd75-4666-92f7-08fd0d2379bc"), new Guid("6834e8ac-9efa-4f21-a027-d8ae1c1b973e"), 100.0, "B", 2, "CAR" },
                    { new Guid("a9551270-4ef4-49cc-bc0d-753c21b62826"), new Guid("60bf0a3a-02aa-4218-8e61-a5dd00e5e0d4"), 50.0, "A", 4, "MOTORCYCLE" },
                    { new Guid("a981b997-132b-446c-8710-101f42e13d1e"), new Guid("f92eb003-edbb-4752-9d08-baf8cf0be864"), 100.0, "B", 7, "CAR" },
                    { new Guid("a9871b35-7153-4ca2-9910-aff3dc744018"), new Guid("04b75293-d378-4ee1-b298-9f723aa1e4bf"), 100.0, "A", 3, "CAR" },
                    { new Guid("aa025135-8399-42ea-bffd-ab5184c3093e"), new Guid("ed42e83a-2e39-4c0c-8803-4b595c801a43"), 50.0, "B", 3, "MOTORCYCLE" },
                    { new Guid("aa50ffc8-d51f-44e8-b3bf-417c25ef4b49"), new Guid("bf2771a1-c2c5-496e-beab-9667afd9bbfe"), 100.0, "A", 6, "CAR" },
                    { new Guid("aa849050-3dd7-4342-8602-bc430f541171"), new Guid("66ccfd45-4738-48da-ac09-400c1a1a26bb"), 100.0, "B", 8, "CAR" },
                    { new Guid("aaba0a7b-ce8e-4da2-92b3-9311b533abe8"), new Guid("5a1062de-7895-4914-b081-cc7ff9e007e7"), 50.0, "A", 1, "MOTORCYCLE" },
                    { new Guid("aad087ae-e3d9-40e4-8b77-cb0a1836fc58"), new Guid("ed42e83a-2e39-4c0c-8803-4b595c801a43"), 50.0, "A", 2, "MOTORCYCLE" },
                    { new Guid("ab368442-8f1d-402e-bf28-66e93ef5b035"), new Guid("88c0746c-384c-48a3-8a24-034a9d11e036"), 100.0, "A", 3, "CAR" },
                    { new Guid("ab3f6b7b-a46a-440b-ba5e-e8d98eae6176"), new Guid("d12f5883-ab8e-4d3f-a967-ec7675a0ab47"), 50.0, "B", 2, "MOTORCYCLE" },
                    { new Guid("abae36ce-e01a-48d3-8b56-527e8a129a17"), new Guid("564ba9ef-c816-47d7-a41b-a7b061183905"), 200.0, "A", 7, "VAN" },
                    { new Guid("abb81c21-5be4-452e-9013-8e4aff147a2a"), new Guid("454290bd-e2c7-4154-b980-cc091b14465d"), 50.0, "A", 3, "MOTORCYCLE" },
                    { new Guid("abe4c4a8-a419-41d5-85ee-45071c6fcf43"), new Guid("37b1553e-e0cc-460c-b0a8-d72fea93dadc"), 50.0, "A", 8, "MOTORCYCLE" },
                    { new Guid("ac3237f6-4fdc-454f-ab88-5cec5451325f"), new Guid("f8fec2b0-96c9-47ff-be70-eee9e7195d60"), 200.0, "B", 1, "VAN" },
                    { new Guid("ac59a5f2-de20-4865-867f-44cdd4ca8b40"), new Guid("76a04e41-7aa0-46e2-8c27-0b677cde6543"), 100.0, "B", 8, "CAR" },
                    { new Guid("ac89f9b0-b981-477d-bb00-7cfc8287098b"), new Guid("76a04e41-7aa0-46e2-8c27-0b677cde6543"), 50.0, "A", 2, "MOTORCYCLE" },
                    { new Guid("ac96bc6a-c2e3-4ce5-b434-35d4838939b3"), new Guid("b7048c17-53ab-4005-8a80-eed7f70c6c99"), 200.0, "B", 2, "VAN" },
                    { new Guid("acb36f7b-04ad-4486-a3c6-abb771e655c9"), new Guid("2aedce44-d62f-4847-a9ad-2245b9d31387"), 300.0, "B", 7, "TRUCK" },
                    { new Guid("accb094d-cc9a-4018-92d3-019866b56ab1"), new Guid("f8fec2b0-96c9-47ff-be70-eee9e7195d60"), 200.0, "B", 2, "VAN" },
                    { new Guid("ada43566-d5da-4024-9843-ba9df826af76"), new Guid("f5e07364-5770-4cca-8215-4bc9687928fd"), 100.0, "B", 3, "CAR" },
                    { new Guid("adbbdf69-ea8a-4a66-9584-e609eeb40f44"), new Guid("66af1e03-1839-46f2-a5b1-999c4f3a5b30"), 200.0, "A", 4, "VAN" },
                    { new Guid("adec34e3-6a68-4cbd-8652-b4cd979bcfec"), new Guid("454290bd-e2c7-4154-b980-cc091b14465d"), 300.0, "B", 2, "TRUCK" },
                    { new Guid("ae1db8c1-88ce-46f0-b918-ebfcb7b472e8"), new Guid("0b1a89a0-0f56-47cf-8cf8-6e15ec4f04ef"), 50.0, "A", 2, "MOTORCYCLE" },
                    { new Guid("aea13a1c-7a41-4e43-b935-d36c4f772e92"), new Guid("c5d2c35b-c774-4f68-bc8b-4b23482c4244"), 300.0, "A", 7, "TRUCK" },
                    { new Guid("aeffcdf3-0198-4ef7-a5f1-83cb5905aee8"), new Guid("d7bcb6e9-67e9-4afc-9d25-f169447500eb"), 100.0, "A", 2, "CAR" },
                    { new Guid("af1fa1aa-21b4-4ed3-991b-57897fa7a896"), new Guid("dec19efa-56f4-4a25-8590-7b1938391756"), 100.0, "A", 3, "CAR" },
                    { new Guid("af59e68c-82a6-48a6-8cc8-972f05d1774a"), new Guid("5a1062de-7895-4914-b081-cc7ff9e007e7"), 50.0, "A", 4, "MOTORCYCLE" },
                    { new Guid("af9b41f6-08c0-49ad-9716-cfa63ed84d6a"), new Guid("9ef7200f-cd79-41e9-ac2b-c0215f0fc9fc"), 50.0, "A", 5, "MOTORCYCLE" },
                    { new Guid("afd7e555-da07-4608-84c9-4642f770c9f6"), new Guid("0ea2b9de-200d-4f13-b796-bd86c412194b"), 300.0, "B", 6, "TRUCK" },
                    { new Guid("b01aba31-4362-42dd-856a-ed7f3f3e9866"), new Guid("e5dceac8-c4a8-4f0a-b51b-9a305ff65216"), 200.0, "A", 2, "VAN" },
                    { new Guid("b09de4c8-7c1b-48ac-a088-5696f2180ee4"), new Guid("dec19efa-56f4-4a25-8590-7b1938391756"), 300.0, "B", 2, "TRUCK" },
                    { new Guid("b171e908-6df1-49b2-9e18-286ee4d6abdd"), new Guid("ed42e83a-2e39-4c0c-8803-4b595c801a43"), 50.0, "A", 1, "MOTORCYCLE" },
                    { new Guid("b1a75ff6-3f2b-4ad5-a3c9-18f8ab7f6736"), new Guid("ac8d075d-9942-4f4e-b98f-e8df09ce60d3"), 300.0, "B", 5, "TRUCK" },
                    { new Guid("b1df11f2-6881-4499-8dbf-64ce346c5e83"), new Guid("a4cc4c37-d39f-4d36-9a60-2d6404fc97f6"), 100.0, "B", 8, "CAR" },
                    { new Guid("b1fb2bf7-ea2b-411b-942a-9c098cb3bc65"), new Guid("c7dca08c-fee9-47a0-bb70-4dc53f2699d0"), 100.0, "A", 5, "CAR" },
                    { new Guid("b20b23ba-bf11-495c-ae89-1519b820b579"), new Guid("30fd900a-27d9-4682-b5e2-db8c76e2062b"), 50.0, "B", 8, "MOTORCYCLE" },
                    { new Guid("b24fd7f3-4f18-4854-8e12-31071850b239"), new Guid("13d8bc75-3ef2-4d55-a2bd-ffc7a683e7e4"), 300.0, "B", 1, "TRUCK" },
                    { new Guid("b25994af-9fd9-4bf4-92d7-62674227b0a2"), new Guid("e07be4a4-a28a-4d40-bd21-3371ef69fc0b"), 100.0, "B", 3, "CAR" },
                    { new Guid("b26ddfcd-8e81-40af-9084-b46563d13791"), new Guid("eb01d97e-5919-4537-822f-2fff3c6fd84f"), 50.0, "A", 3, "MOTORCYCLE" },
                    { new Guid("b281c591-ca1c-4820-aa97-8d49f40969f4"), new Guid("c5d2c35b-c774-4f68-bc8b-4b23482c4244"), 100.0, "B", 5, "CAR" },
                    { new Guid("b28a27a3-9971-4911-9714-2e192079c34d"), new Guid("eb01d97e-5919-4537-822f-2fff3c6fd84f"), 300.0, "B", 5, "TRUCK" },
                    { new Guid("b29dd839-9b49-4562-9502-0e4d82501423"), new Guid("ed42e83a-2e39-4c0c-8803-4b595c801a43"), 50.0, "B", 5, "MOTORCYCLE" },
                    { new Guid("b2e64e01-57ef-40e0-96e4-ce6c6523e710"), new Guid("14f021ba-4e08-416b-8751-e5d09e9b107d"), 300.0, "B", 2, "TRUCK" },
                    { new Guid("b30f6200-adce-40fc-a6d9-d32e400fde7a"), new Guid("cacdb08a-111b-49ab-81b8-13817060e4e8"), 100.0, "A", 2, "CAR" },
                    { new Guid("b32bd220-dd3f-4d3e-bd89-a9b17c4bfee9"), new Guid("40448bf3-c284-402d-a1bf-7593c2d267c4"), 300.0, "B", 3, "TRUCK" },
                    { new Guid("b32e72cd-23f5-429e-ae4c-1a14559f00d7"), new Guid("4bbdfefd-5984-4fd5-ad27-04ef0d85ef60"), 200.0, "B", 8, "VAN" },
                    { new Guid("b3ad5d18-84fd-45ce-b3e3-e0acf6831ec6"), new Guid("b74f87ee-301c-418b-a49a-4a8ebe631eb8"), 50.0, "A", 7, "MOTORCYCLE" },
                    { new Guid("b3c2df51-b309-4193-b56f-e39b8c713496"), new Guid("d76e484e-5fd9-4cf5-8892-f4fcf44654fa"), 300.0, "B", 1, "TRUCK" },
                    { new Guid("b3f564c4-96f9-4947-83b0-e267d0ac6c6e"), new Guid("d76e484e-5fd9-4cf5-8892-f4fcf44654fa"), 300.0, "B", 4, "TRUCK" },
                    { new Guid("b3fcb3e5-9a1e-4df7-8b1d-c27308e6a7b4"), new Guid("454290bd-e2c7-4154-b980-cc091b14465d"), 50.0, "A", 8, "MOTORCYCLE" },
                    { new Guid("b43a72dd-0686-4548-b932-fd4738137de7"), new Guid("47569aaa-bf51-4525-832e-9153120d433e"), 200.0, "A", 6, "VAN" },
                    { new Guid("b4c1bc6f-dc37-4a20-a137-60f9cd33d879"), new Guid("b7048c17-53ab-4005-8a80-eed7f70c6c99"), 200.0, "B", 3, "VAN" },
                    { new Guid("b515c04f-1f38-4d4c-976b-84aaf5b7aa66"), new Guid("13d8bc75-3ef2-4d55-a2bd-ffc7a683e7e4"), 300.0, "A", 4, "TRUCK" },
                    { new Guid("b550392d-3316-494c-80df-21c5b4eafa4d"), new Guid("47569aaa-bf51-4525-832e-9153120d433e"), 200.0, "B", 8, "VAN" },
                    { new Guid("b5559d8e-5f38-4aa1-936a-c4e823857396"), new Guid("bf2771a1-c2c5-496e-beab-9667afd9bbfe"), 100.0, "A", 7, "CAR" },
                    { new Guid("b5616e15-224e-48ad-8a91-7aedf2a16a17"), new Guid("f5882dab-e003-453f-b642-a38560da3beb"), 200.0, "B", 3, "VAN" },
                    { new Guid("b57357a6-c798-40b9-96ec-38ade5fb347a"), new Guid("14f021ba-4e08-416b-8751-e5d09e9b107d"), 100.0, "A", 7, "CAR" },
                    { new Guid("b5a0fc14-df90-4141-a55c-a22943ac2bab"), new Guid("0e6822f5-7394-400d-bca7-a4cc4dd28978"), 300.0, "B", 4, "TRUCK" },
                    { new Guid("b5dd4719-8a14-4e6c-9679-4093f5ba1d3c"), new Guid("f5e07364-5770-4cca-8215-4bc9687928fd"), 100.0, "B", 6, "CAR" },
                    { new Guid("b62d716e-f174-4d2a-932b-470e09527f57"), new Guid("a4cc4c37-d39f-4d36-9a60-2d6404fc97f6"), 200.0, "A", 3, "VAN" },
                    { new Guid("b675a554-fd89-4abd-a6f5-7eae83649cf7"), new Guid("bf471c98-2465-4e39-b3a4-a0a56d7f0b0c"), 50.0, "A", 4, "MOTORCYCLE" },
                    { new Guid("b6762d3b-541e-48c2-b2c6-4d8ea77e2631"), new Guid("a2702078-cb6b-4d1d-a83a-640674eeeffe"), 200.0, "A", 2, "VAN" },
                    { new Guid("b70c6d0e-acd6-4a98-a919-438a2ce4878d"), new Guid("516e7943-059a-44cc-bd82-d4c4480a6676"), 100.0, "A", 6, "CAR" },
                    { new Guid("b7192efe-b2a8-4070-96de-7012d8083011"), new Guid("4bbdfefd-5984-4fd5-ad27-04ef0d85ef60"), 200.0, "B", 1, "VAN" },
                    { new Guid("b79acdf2-79a1-44d5-b1ae-887df07140ec"), new Guid("0b1a89a0-0f56-47cf-8cf8-6e15ec4f04ef"), 100.0, "B", 8, "CAR" },
                    { new Guid("b806f4f2-bd44-4dc0-8d5e-3a29aa4a2815"), new Guid("dec19efa-56f4-4a25-8590-7b1938391756"), 300.0, "B", 1, "TRUCK" },
                    { new Guid("b88018a6-ba00-4dcc-8ccf-10d07ede295a"), new Guid("a2702078-cb6b-4d1d-a83a-640674eeeffe"), 200.0, "A", 7, "VAN" },
                    { new Guid("b94893cb-2837-4368-960b-aabdbc47f411"), new Guid("2aedce44-d62f-4847-a9ad-2245b9d31387"), 300.0, "B", 6, "TRUCK" },
                    { new Guid("b98370d5-a7e8-4e28-a967-fa4f4cc2d233"), new Guid("6834e8ac-9efa-4f21-a027-d8ae1c1b973e"), 200.0, "A", 5, "VAN" },
                    { new Guid("b984e5a1-35c8-4400-8ea5-c1fc60e5b54f"), new Guid("30fd900a-27d9-4682-b5e2-db8c76e2062b"), 50.0, "A", 7, "MOTORCYCLE" },
                    { new Guid("ba6b9d6f-d3e5-4293-811e-979b81eb7210"), new Guid("6834e8ac-9efa-4f21-a027-d8ae1c1b973e"), 200.0, "A", 2, "VAN" },
                    { new Guid("bae62933-59d5-4954-b890-b6bd2d005496"), new Guid("15e5b2e9-d51f-4413-9a87-0a8051c82ff4"), 200.0, "A", 2, "VAN" },
                    { new Guid("bb81909e-7f29-4aec-b448-8facb323b0d0"), new Guid("516e7943-059a-44cc-bd82-d4c4480a6676"), 100.0, "A", 5, "CAR" },
                    { new Guid("bc3cc5ad-2932-4ff9-ad2b-1977e6e83b02"), new Guid("325cdcfb-5542-41fb-bca0-5aec0a1f8209"), 300.0, "B", 4, "TRUCK" },
                    { new Guid("bc5e2fa4-4552-4475-901c-0d36d084aaee"), new Guid("14f021ba-4e08-416b-8751-e5d09e9b107d"), 300.0, "B", 8, "TRUCK" },
                    { new Guid("bd5c6401-e604-4209-b835-d8e71d8a0402"), new Guid("0ea2b9de-200d-4f13-b796-bd86c412194b"), 300.0, "B", 4, "TRUCK" },
                    { new Guid("be3c32fd-364a-48f2-b727-57bb90c1defb"), new Guid("15e5b2e9-d51f-4413-9a87-0a8051c82ff4"), 50.0, "B", 8, "MOTORCYCLE" },
                    { new Guid("be7ecd77-8890-4091-9812-36b6596ccc00"), new Guid("ae3959c4-5bca-457d-9c14-4cc88f49d61e"), 300.0, "A", 1, "TRUCK" },
                    { new Guid("be994fa2-93b4-4374-b089-69a2f3a2377e"), new Guid("f92eb003-edbb-4752-9d08-baf8cf0be864"), 50.0, "A", 4, "MOTORCYCLE" },
                    { new Guid("be9f42f7-e5c0-49e3-a2c2-5a6791b22333"), new Guid("dec19efa-56f4-4a25-8590-7b1938391756"), 100.0, "A", 5, "CAR" },
                    { new Guid("bed3e96b-5765-4254-ac54-646f6c7f13ba"), new Guid("60bf0a3a-02aa-4218-8e61-a5dd00e5e0d4"), 50.0, "A", 6, "MOTORCYCLE" },
                    { new Guid("bf13a469-6522-4471-a8fa-a910bf911b5c"), new Guid("6834e8ac-9efa-4f21-a027-d8ae1c1b973e"), 200.0, "A", 8, "VAN" },
                    { new Guid("bf365d1c-962c-45a2-9ed0-65e7892e3dae"), new Guid("cdd98f54-2de4-464d-912e-488674be6f46"), 300.0, "B", 8, "TRUCK" },
                    { new Guid("c0aeb7a9-a59f-417e-9335-ca302832fdf7"), new Guid("13d8bc75-3ef2-4d55-a2bd-ffc7a683e7e4"), 300.0, "A", 6, "TRUCK" },
                    { new Guid("c0c24256-7abd-45fa-9b58-5ae7db4dd5e1"), new Guid("9ef7200f-cd79-41e9-ac2b-c0215f0fc9fc"), 50.0, "A", 7, "MOTORCYCLE" },
                    { new Guid("c1205d8d-371a-433e-b1c8-f1fa119800d9"), new Guid("b7048c17-53ab-4005-8a80-eed7f70c6c99"), 100.0, "A", 6, "CAR" },
                    { new Guid("c12245a4-f2a6-4ceb-9a49-2c305e8617c5"), new Guid("47569aaa-bf51-4525-832e-9153120d433e"), 200.0, "B", 4, "VAN" },
                    { new Guid("c133e679-cc9d-48a4-a895-7a3955c8a82b"), new Guid("60bf0a3a-02aa-4218-8e61-a5dd00e5e0d4"), 50.0, "B", 3, "MOTORCYCLE" },
                    { new Guid("c18b0593-c318-44e5-8790-e5e171b29305"), new Guid("37b1553e-e0cc-460c-b0a8-d72fea93dadc"), 300.0, "B", 3, "TRUCK" },
                    { new Guid("c1a4b963-3190-42f6-8539-1eb6a178da4f"), new Guid("5a1062de-7895-4914-b081-cc7ff9e007e7"), 100.0, "B", 6, "CAR" },
                    { new Guid("c1d00401-dbb7-459a-b2fa-2ff68caa1d2a"), new Guid("0ea2b9de-200d-4f13-b796-bd86c412194b"), 50.0, "A", 8, "MOTORCYCLE" },
                    { new Guid("c24745dd-7ca9-454f-8efb-d16bfc1c0b02"), new Guid("66ccfd45-4738-48da-ac09-400c1a1a26bb"), 300.0, "A", 7, "TRUCK" },
                    { new Guid("c2aaf223-b165-4fc3-838d-1287144e9f31"), new Guid("d7bcb6e9-67e9-4afc-9d25-f169447500eb"), 100.0, "A", 6, "CAR" },
                    { new Guid("c31fe5a6-81c0-4eb1-8cd6-e3bc5e152011"), new Guid("0b1a89a0-0f56-47cf-8cf8-6e15ec4f04ef"), 50.0, "A", 8, "MOTORCYCLE" },
                    { new Guid("c3214fbb-8c37-4c65-aae4-812887cd67f7"), new Guid("561ae673-4668-49b7-81ca-2fc792ab1b3e"), 50.0, "A", 2, "MOTORCYCLE" },
                    { new Guid("c344d843-6252-4da6-899f-bb59e684546b"), new Guid("325cdcfb-5542-41fb-bca0-5aec0a1f8209"), 300.0, "A", 3, "TRUCK" },
                    { new Guid("c37616f3-3400-4d89-ae47-b0f43a034f8e"), new Guid("66af1e03-1839-46f2-a5b1-999c4f3a5b30"), 100.0, "B", 7, "CAR" },
                    { new Guid("c39d7908-65e4-43bd-a928-f6cb10114721"), new Guid("f8fec2b0-96c9-47ff-be70-eee9e7195d60"), 300.0, "A", 3, "TRUCK" },
                    { new Guid("c3b59758-83d7-494c-8e94-d06ae858dd28"), new Guid("c7dca08c-fee9-47a0-bb70-4dc53f2699d0"), 300.0, "B", 4, "TRUCK" },
                    { new Guid("c3c74aac-3217-41cc-aba9-6da93b60912d"), new Guid("d12f5883-ab8e-4d3f-a967-ec7675a0ab47"), 50.0, "B", 8, "MOTORCYCLE" },
                    { new Guid("c4b4cb7d-cdaa-4f93-ba4d-15f267e289a8"), new Guid("4f8943b0-c325-4306-8872-c0687a860552"), 200.0, "A", 5, "VAN" },
                    { new Guid("c4c5063c-704d-4e74-a3f5-ed998e533e14"), new Guid("d76e484e-5fd9-4cf5-8892-f4fcf44654fa"), 50.0, "A", 3, "MOTORCYCLE" },
                    { new Guid("c4c8d524-0741-4012-b39b-765f75b94563"), new Guid("c5d2c35b-c774-4f68-bc8b-4b23482c4244"), 100.0, "B", 6, "CAR" },
                    { new Guid("c4c9bbde-56aa-42e4-a52c-6a8413eacb22"), new Guid("15e5b2e9-d51f-4413-9a87-0a8051c82ff4"), 50.0, "B", 2, "MOTORCYCLE" },
                    { new Guid("c505c0c5-f1ae-4964-82b4-266bee97d56a"), new Guid("18bb3ced-ef4c-4990-902d-9ccdbee03709"), 100.0, "B", 8, "CAR" },
                    { new Guid("c543cc8e-6d07-4f50-9f36-8e0c21df451c"), new Guid("9ef7200f-cd79-41e9-ac2b-c0215f0fc9fc"), 50.0, "A", 4, "MOTORCYCLE" },
                    { new Guid("c5a106e0-9732-425f-a5a9-a6d424826257"), new Guid("f92eb003-edbb-4752-9d08-baf8cf0be864"), 100.0, "B", 1, "CAR" },
                    { new Guid("c5b10fcf-089e-4d51-8509-51b5d4c9ed1c"), new Guid("d12f5883-ab8e-4d3f-a967-ec7675a0ab47"), 50.0, "B", 6, "MOTORCYCLE" },
                    { new Guid("c5c7a201-04a5-406f-b3e1-256975a80cec"), new Guid("c5d2c35b-c774-4f68-bc8b-4b23482c4244"), 100.0, "B", 3, "CAR" },
                    { new Guid("c5df6e34-d434-4c31-8c59-beb1811d2997"), new Guid("60bf0a3a-02aa-4218-8e61-a5dd00e5e0d4"), 50.0, "B", 5, "MOTORCYCLE" },
                    { new Guid("c5dfe0e9-a64c-4af5-a2ee-0e58ba4a3804"), new Guid("b7048c17-53ab-4005-8a80-eed7f70c6c99"), 200.0, "B", 7, "VAN" },
                    { new Guid("c5f993b4-a699-485b-baf9-aa0bdca159e1"), new Guid("0e6822f5-7394-400d-bca7-a4cc4dd28978"), 50.0, "A", 7, "MOTORCYCLE" },
                    { new Guid("c60765e0-d803-4696-9c8b-0bad830cc7d7"), new Guid("564ba9ef-c816-47d7-a41b-a7b061183905"), 50.0, "B", 8, "MOTORCYCLE" },
                    { new Guid("c612fba2-ac1e-46f2-b17e-022347876c10"), new Guid("d7bcb6e9-67e9-4afc-9d25-f169447500eb"), 200.0, "B", 4, "VAN" },
                    { new Guid("c62af715-b279-42c4-b1c6-db43de9c1f18"), new Guid("eb01d97e-5919-4537-822f-2fff3c6fd84f"), 300.0, "B", 2, "TRUCK" },
                    { new Guid("c6b2d9ce-bfee-4a9e-81cd-5935db805600"), new Guid("bf471c98-2465-4e39-b3a4-a0a56d7f0b0c"), 50.0, "A", 7, "MOTORCYCLE" },
                    { new Guid("c6cdaea4-e042-44e0-a90e-d45f22dbe74c"), new Guid("60bf0a3a-02aa-4218-8e61-a5dd00e5e0d4"), 50.0, "A", 1, "MOTORCYCLE" },
                    { new Guid("c718e192-963d-4df7-abfa-d2831a9d1d52"), new Guid("f5e07364-5770-4cca-8215-4bc9687928fd"), 300.0, "A", 2, "TRUCK" },
                    { new Guid("c721dde3-9cf3-4398-9a81-ffd7e5f3b51d"), new Guid("5a1062de-7895-4914-b081-cc7ff9e007e7"), 100.0, "B", 8, "CAR" },
                    { new Guid("c738dfba-e7a6-4ac0-b991-72347f1c8161"), new Guid("454290bd-e2c7-4154-b980-cc091b14465d"), 50.0, "A", 1, "MOTORCYCLE" },
                    { new Guid("c75e6e4d-5719-42ad-ae08-589445a6cec1"), new Guid("04b75293-d378-4ee1-b298-9f723aa1e4bf"), 100.0, "B", 5, "CAR" },
                    { new Guid("c76b009f-b54e-4cf7-b677-d49c7a52a8f8"), new Guid("561ae673-4668-49b7-81ca-2fc792ab1b3e"), 50.0, "A", 4, "MOTORCYCLE" },
                    { new Guid("c7b4d2ae-d821-4c49-896b-a551f6ec170f"), new Guid("f5882dab-e003-453f-b642-a38560da3beb"), 50.0, "A", 6, "MOTORCYCLE" },
                    { new Guid("c7c994d0-4276-465f-8750-6f9a6afd5529"), new Guid("a4cc4c37-d39f-4d36-9a60-2d6404fc97f6"), 200.0, "A", 7, "VAN" },
                    { new Guid("c7c9afa6-2503-4201-bdac-58ae6b039524"), new Guid("564ba9ef-c816-47d7-a41b-a7b061183905"), 200.0, "A", 4, "VAN" },
                    { new Guid("c7dcc0af-7a77-4f4e-b9aa-5dcfa76bc147"), new Guid("b1ad3048-49d6-4a9a-a0f8-d99e3f5f70f5"), 300.0, "A", 2, "TRUCK" },
                    { new Guid("c85db957-137e-4543-8486-8d0f4a6227fc"), new Guid("7fd19919-4f47-4257-af41-0eaf6d2f3533"), 100.0, "A", 4, "CAR" },
                    { new Guid("c879074e-4290-4174-b919-cf948d3972c1"), new Guid("e07be4a4-a28a-4d40-bd21-3371ef69fc0b"), 200.0, "A", 5, "VAN" },
                    { new Guid("c8a5760d-f276-4b3f-b353-1831b121df81"), new Guid("04b75293-d378-4ee1-b298-9f723aa1e4bf"), 100.0, "A", 5, "CAR" },
                    { new Guid("c8b69526-936b-4708-9372-25360bb3acfb"), new Guid("8eda8dbd-513f-49c9-a050-7c8a6e6475d7"), 200.0, "A", 3, "VAN" },
                    { new Guid("c9239a63-fbb2-4133-a78a-e3a1b97c4d3b"), new Guid("f92eb003-edbb-4752-9d08-baf8cf0be864"), 50.0, "A", 2, "MOTORCYCLE" },
                    { new Guid("c9ba41aa-bc55-43f2-9430-186f3fde9e15"), new Guid("4f8943b0-c325-4306-8872-c0687a860552"), 300.0, "B", 6, "TRUCK" },
                    { new Guid("c9fc9322-ba55-4dff-8d3c-5ea48d0fa909"), new Guid("454290bd-e2c7-4154-b980-cc091b14465d"), 300.0, "B", 4, "TRUCK" },
                    { new Guid("ca23a047-ea18-486f-9af3-44ca5be4f813"), new Guid("b74f87ee-301c-418b-a49a-4a8ebe631eb8"), 50.0, "A", 2, "MOTORCYCLE" },
                    { new Guid("ca2fd475-481d-4b10-be71-d1868b8c9356"), new Guid("bf2771a1-c2c5-496e-beab-9667afd9bbfe"), 100.0, "B", 6, "CAR" },
                    { new Guid("ca57387d-a073-4138-bd77-00cff8328172"), new Guid("15e5b2e9-d51f-4413-9a87-0a8051c82ff4"), 50.0, "B", 3, "MOTORCYCLE" },
                    { new Guid("ca609860-5f9e-499a-b26d-930305f0404a"), new Guid("bf471c98-2465-4e39-b3a4-a0a56d7f0b0c"), 200.0, "B", 2, "VAN" },
                    { new Guid("ca65c697-3052-46a4-b412-2c9bf527965b"), new Guid("454290bd-e2c7-4154-b980-cc091b14465d"), 50.0, "A", 7, "MOTORCYCLE" },
                    { new Guid("ca81006c-e34e-4cad-8ed2-919a0f220033"), new Guid("2aedce44-d62f-4847-a9ad-2245b9d31387"), 300.0, "B", 5, "TRUCK" },
                    { new Guid("cacb16d2-9ca2-47a7-801e-38e5655df80d"), new Guid("eb01d97e-5919-4537-822f-2fff3c6fd84f"), 300.0, "B", 6, "TRUCK" },
                    { new Guid("cb2b8277-11be-41e8-82f5-9443bfcb70da"), new Guid("c5d2c35b-c774-4f68-bc8b-4b23482c4244"), 300.0, "A", 8, "TRUCK" },
                    { new Guid("cc1751f6-945b-4cfb-a26e-e3985e0f0817"), new Guid("ab2501ec-a3d8-4027-98dd-df99be5a1bf9"), 300.0, "B", 4, "TRUCK" },
                    { new Guid("cc200a4a-90f6-478f-8926-8a4196677cbf"), new Guid("18bb3ced-ef4c-4990-902d-9ccdbee03709"), 100.0, "B", 4, "CAR" },
                    { new Guid("cc6eeb01-cd55-4177-ae5b-e349bd62d832"), new Guid("f5e07364-5770-4cca-8215-4bc9687928fd"), 300.0, "A", 1, "TRUCK" },
                    { new Guid("cc950e2e-d7a9-4a47-a57d-b2f2a5282104"), new Guid("f5882dab-e003-453f-b642-a38560da3beb"), 200.0, "B", 7, "VAN" },
                    { new Guid("ccd83e44-e8b5-45a0-a511-ebcd729e09dc"), new Guid("b202d20c-9aca-47ab-8c0c-417b0566bc9a"), 100.0, "A", 5, "CAR" },
                    { new Guid("cd0a5e3d-e851-4620-8e54-9ee4fd4828c2"), new Guid("e5dceac8-c4a8-4f0a-b51b-9a305ff65216"), 200.0, "A", 1, "VAN" },
                    { new Guid("cdcd15e7-209f-40c0-86d8-9e93d68ca4e5"), new Guid("dec19efa-56f4-4a25-8590-7b1938391756"), 100.0, "A", 7, "CAR" },
                    { new Guid("cdee5598-5428-4ee5-9c20-6e8b061aef75"), new Guid("a4cc4c37-d39f-4d36-9a60-2d6404fc97f6"), 200.0, "A", 6, "VAN" },
                    { new Guid("ce3948bc-6652-441f-9b1b-961527c6f68a"), new Guid("e07be4a4-a28a-4d40-bd21-3371ef69fc0b"), 200.0, "A", 1, "VAN" },
                    { new Guid("ce484e2b-2398-49d9-9a0a-90d36eb96dcd"), new Guid("ac8d075d-9942-4f4e-b98f-e8df09ce60d3"), 100.0, "A", 4, "CAR" },
                    { new Guid("ce4c5460-79c0-41da-8320-9d1f06b5cb28"), new Guid("bf471c98-2465-4e39-b3a4-a0a56d7f0b0c"), 200.0, "B", 8, "VAN" },
                    { new Guid("ce6be59c-155e-4f8c-a56d-2a568488333d"), new Guid("b7048c17-53ab-4005-8a80-eed7f70c6c99"), 100.0, "A", 8, "CAR" },
                    { new Guid("ceb5685c-8945-47b2-a793-b50995915c1a"), new Guid("14f021ba-4e08-416b-8751-e5d09e9b107d"), 100.0, "A", 5, "CAR" },
                    { new Guid("cf2377cb-3506-4342-9be0-8badd7aca83d"), new Guid("60bf0a3a-02aa-4218-8e61-a5dd00e5e0d4"), 50.0, "A", 8, "MOTORCYCLE" },
                    { new Guid("cf2be43c-2911-4e19-9a47-deedf3062f32"), new Guid("ed42e83a-2e39-4c0c-8803-4b595c801a43"), 50.0, "B", 2, "MOTORCYCLE" },
                    { new Guid("cf993e4a-0645-450b-96dc-34acef322284"), new Guid("14f021ba-4e08-416b-8751-e5d09e9b107d"), 100.0, "A", 8, "CAR" },
                    { new Guid("cfb48caf-e097-4255-8486-a24f3748d045"), new Guid("d12f5883-ab8e-4d3f-a967-ec7675a0ab47"), 50.0, "B", 4, "MOTORCYCLE" },
                    { new Guid("d087c4d8-0a49-49f8-90b7-98a0657e671b"), new Guid("6834e8ac-9efa-4f21-a027-d8ae1c1b973e"), 100.0, "B", 1, "CAR" },
                    { new Guid("d0cb151b-0d71-425c-a990-ec53fd29f203"), new Guid("04b75293-d378-4ee1-b298-9f723aa1e4bf"), 100.0, "A", 4, "CAR" },
                    { new Guid("d1c0634d-b592-413f-98b5-fea0b1722a4a"), new Guid("d7bcb6e9-67e9-4afc-9d25-f169447500eb"), 100.0, "A", 5, "CAR" },
                    { new Guid("d2245d1f-f212-4c4e-87b6-d7a23299a063"), new Guid("f5882dab-e003-453f-b642-a38560da3beb"), 50.0, "A", 3, "MOTORCYCLE" },
                    { new Guid("d2572ac8-9d68-42de-b156-861c131d8147"), new Guid("516e7943-059a-44cc-bd82-d4c4480a6676"), 100.0, "B", 6, "CAR" },
                    { new Guid("d26572f2-f19a-44a3-9171-8ac75e570d6c"), new Guid("d7bcb6e9-67e9-4afc-9d25-f169447500eb"), 200.0, "B", 7, "VAN" },
                    { new Guid("d2a55379-f670-46f0-9687-b35ee86ebbcd"), new Guid("66af1e03-1839-46f2-a5b1-999c4f3a5b30"), 100.0, "B", 2, "CAR" },
                    { new Guid("d2bb5d1f-1e33-4e7b-96d8-b7d59ccb146c"), new Guid("30fd900a-27d9-4682-b5e2-db8c76e2062b"), 50.0, "A", 8, "MOTORCYCLE" },
                    { new Guid("d2c5ebbd-fa64-4946-84fc-900526752799"), new Guid("e07be4a4-a28a-4d40-bd21-3371ef69fc0b"), 200.0, "A", 3, "VAN" },
                    { new Guid("d2eb21f8-14e3-4d24-a67f-0e4078a6f646"), new Guid("d12f5883-ab8e-4d3f-a967-ec7675a0ab47"), 50.0, "B", 5, "MOTORCYCLE" },
                    { new Guid("d30ce76e-1fb0-4d41-a308-a9eb27a61698"), new Guid("66ccfd45-4738-48da-ac09-400c1a1a26bb"), 300.0, "A", 2, "TRUCK" },
                    { new Guid("d328339f-1e60-4949-89dc-7b2c2794fdae"), new Guid("0e1cf06a-2c1f-4f3a-804f-0a21ca76a827"), 300.0, "A", 1, "TRUCK" },
                    { new Guid("d34f339a-5fa9-4c78-bcc7-74ef0eaa9675"), new Guid("bf471c98-2465-4e39-b3a4-a0a56d7f0b0c"), 200.0, "B", 6, "VAN" },
                    { new Guid("d376b757-7f36-486e-9923-db33bd77e2cd"), new Guid("30fd900a-27d9-4682-b5e2-db8c76e2062b"), 50.0, "A", 2, "MOTORCYCLE" },
                    { new Guid("d39d2f9d-9b6d-42c1-abe2-ae93a388af28"), new Guid("cdd98f54-2de4-464d-912e-488674be6f46"), 300.0, "B", 3, "TRUCK" },
                    { new Guid("d3c47218-73ca-445d-aca5-63389f2e1e8b"), new Guid("b1ad3048-49d6-4a9a-a0f8-d99e3f5f70f5"), 300.0, "B", 6, "TRUCK" },
                    { new Guid("d41a7f34-8669-4ea6-9f31-99424d220266"), new Guid("cfeefc53-67a5-4e6a-a136-330d10920937"), 100.0, "A", 1, "CAR" },
                    { new Guid("d43ad864-94e4-4f5f-aca2-a8428f0da423"), new Guid("2aedce44-d62f-4847-a9ad-2245b9d31387"), 300.0, "B", 8, "TRUCK" },
                    { new Guid("d49a8cb9-2871-4f59-807b-b3d5623366a6"), new Guid("eb01d97e-5919-4537-822f-2fff3c6fd84f"), 300.0, "B", 3, "TRUCK" },
                    { new Guid("d4faa3b3-d260-4436-9fc4-aa0592780041"), new Guid("ab2501ec-a3d8-4027-98dd-df99be5a1bf9"), 200.0, "A", 1, "VAN" },
                    { new Guid("d525ae1a-8ef7-4767-9c36-8583293242e1"), new Guid("8eda8dbd-513f-49c9-a050-7c8a6e6475d7"), 200.0, "B", 7, "VAN" },
                    { new Guid("d61e6b2a-eb5b-46ac-acaa-1be58a4bbc17"), new Guid("40448bf3-c284-402d-a1bf-7593c2d267c4"), 100.0, "A", 3, "CAR" },
                    { new Guid("d6309311-5295-4d9d-94d9-16983e3b4514"), new Guid("47569aaa-bf51-4525-832e-9153120d433e"), 200.0, "A", 2, "VAN" },
                    { new Guid("d66c73ab-da3f-4fef-b009-66c5db09837e"), new Guid("a2702078-cb6b-4d1d-a83a-640674eeeffe"), 300.0, "B", 5, "TRUCK" },
                    { new Guid("d6a0cde7-72f9-44f1-b36d-3da81a62630a"), new Guid("6834e8ac-9efa-4f21-a027-d8ae1c1b973e"), 100.0, "B", 8, "CAR" },
                    { new Guid("d754260c-0e1d-4b03-9f35-d8e4aeda55ba"), new Guid("7fd19919-4f47-4257-af41-0eaf6d2f3533"), 100.0, "A", 1, "CAR" },
                    { new Guid("d7a1a647-d74a-489e-9979-bb92b6a48cbf"), new Guid("66ccfd45-4738-48da-ac09-400c1a1a26bb"), 300.0, "A", 3, "TRUCK" },
                    { new Guid("d806bf29-4463-438a-a413-7c9a36b4c138"), new Guid("4bbdfefd-5984-4fd5-ad27-04ef0d85ef60"), 200.0, "B", 3, "VAN" },
                    { new Guid("d84f22d6-9a1a-4b35-a019-d8e8bc51d40c"), new Guid("66ccfd45-4738-48da-ac09-400c1a1a26bb"), 100.0, "B", 4, "CAR" },
                    { new Guid("d861748b-80b2-4e1f-8fcc-99fa642dfa9a"), new Guid("e5dceac8-c4a8-4f0a-b51b-9a305ff65216"), 200.0, "A", 8, "VAN" },
                    { new Guid("d953d75d-1ee4-4261-932f-e109a24e7d84"), new Guid("6834e8ac-9efa-4f21-a027-d8ae1c1b973e"), 100.0, "B", 5, "CAR" },
                    { new Guid("d97fbc73-1b9d-4dd3-a60e-19645f9202f8"), new Guid("cfeefc53-67a5-4e6a-a136-330d10920937"), 50.0, "B", 3, "MOTORCYCLE" },
                    { new Guid("d9979f2b-1cdc-4654-ad12-b2f3d74b9cd3"), new Guid("9ef7200f-cd79-41e9-ac2b-c0215f0fc9fc"), 300.0, "B", 4, "TRUCK" },
                    { new Guid("d9ded2f6-579e-460b-b9f3-f0043b51d38a"), new Guid("c5d2c35b-c774-4f68-bc8b-4b23482c4244"), 100.0, "B", 7, "CAR" },
                    { new Guid("da9ee688-6226-458d-9d5b-20ec5bcd2d39"), new Guid("cc8bb9f7-35ca-4c40-8498-8e83c25136cd"), 300.0, "A", 4, "TRUCK" },
                    { new Guid("dabf441b-db98-4af2-90a0-1a5eab58515e"), new Guid("a4cc4c37-d39f-4d36-9a60-2d6404fc97f6"), 100.0, "B", 7, "CAR" },
                    { new Guid("dacfbde5-53b3-41d9-a07e-43ac65b9c34a"), new Guid("66ccfd45-4738-48da-ac09-400c1a1a26bb"), 300.0, "A", 1, "TRUCK" },
                    { new Guid("daf1ca75-4f63-43a2-81f2-d79c22df7a29"), new Guid("b202d20c-9aca-47ab-8c0c-417b0566bc9a"), 200.0, "B", 5, "VAN" },
                    { new Guid("dafd0bfb-285b-4c9e-93e2-3aa9ab331c5d"), new Guid("9ef7200f-cd79-41e9-ac2b-c0215f0fc9fc"), 50.0, "A", 1, "MOTORCYCLE" },
                    { new Guid("db30adb2-739d-4cbe-a4c5-d748f7c2a223"), new Guid("ac8d075d-9942-4f4e-b98f-e8df09ce60d3"), 100.0, "A", 3, "CAR" },
                    { new Guid("db4dd5df-c5cc-484d-94ca-52039ecf02e1"), new Guid("47569aaa-bf51-4525-832e-9153120d433e"), 200.0, "B", 7, "VAN" },
                    { new Guid("db5408d4-94e1-45f3-8e35-0e9590fb08df"), new Guid("cacdb08a-111b-49ab-81b8-13817060e4e8"), 200.0, "B", 1, "VAN" },
                    { new Guid("db652a1b-3ad9-4935-b2bd-1e24ebca9642"), new Guid("14f021ba-4e08-416b-8751-e5d09e9b107d"), 300.0, "B", 4, "TRUCK" },
                    { new Guid("db78cf6f-6479-4819-a001-6faeeaac0dc8"), new Guid("60bf0a3a-02aa-4218-8e61-a5dd00e5e0d4"), 50.0, "B", 2, "MOTORCYCLE" },
                    { new Guid("db7d9446-1340-4060-a38f-807e0e54f517"), new Guid("30fd900a-27d9-4682-b5e2-db8c76e2062b"), 50.0, "A", 1, "MOTORCYCLE" },
                    { new Guid("dba4df60-ea13-4040-97d7-71e59874e438"), new Guid("18bb3ced-ef4c-4990-902d-9ccdbee03709"), 100.0, "A", 8, "CAR" },
                    { new Guid("dbde5351-384c-48a4-9452-6c14f765090a"), new Guid("37b1553e-e0cc-460c-b0a8-d72fea93dadc"), 50.0, "A", 6, "MOTORCYCLE" },
                    { new Guid("dc3b7530-a813-4e91-8d72-799bbb282550"), new Guid("4f8943b0-c325-4306-8872-c0687a860552"), 300.0, "B", 3, "TRUCK" },
                    { new Guid("dc3ebec8-b11c-4899-aaeb-27cd859a7062"), new Guid("40448bf3-c284-402d-a1bf-7593c2d267c4"), 100.0, "A", 1, "CAR" },
                    { new Guid("dc6d0029-9196-4ec4-b43c-900d551ca376"), new Guid("4bbdfefd-5984-4fd5-ad27-04ef0d85ef60"), 300.0, "A", 6, "TRUCK" },
                    { new Guid("dc7a9886-4a75-4497-ba5a-b67b89ffbcee"), new Guid("eb01d97e-5919-4537-822f-2fff3c6fd84f"), 300.0, "B", 4, "TRUCK" },
                    { new Guid("dcaf3e45-7a8d-41fc-b9ca-698c510465fc"), new Guid("cacdb08a-111b-49ab-81b8-13817060e4e8"), 100.0, "A", 8, "CAR" },
                    { new Guid("dce1fcff-536f-4137-9c05-d75f6bf8ed39"), new Guid("0e1cf06a-2c1f-4f3a-804f-0a21ca76a827"), 300.0, "A", 4, "TRUCK" },
                    { new Guid("dd315146-eb7c-4bd6-9dc0-f8ebf86085ec"), new Guid("04b75293-d378-4ee1-b298-9f723aa1e4bf"), 100.0, "B", 2, "CAR" },
                    { new Guid("dd79b456-95e8-4397-bb75-6ea762f927dc"), new Guid("d12f5883-ab8e-4d3f-a967-ec7675a0ab47"), 300.0, "A", 1, "TRUCK" },
                    { new Guid("de25793e-a4d7-4c1e-937b-547de8a7e779"), new Guid("454290bd-e2c7-4154-b980-cc091b14465d"), 50.0, "A", 5, "MOTORCYCLE" },
                    { new Guid("de2fccd0-a179-44ed-91d2-a42c9c3d013c"), new Guid("13d8bc75-3ef2-4d55-a2bd-ffc7a683e7e4"), 300.0, "A", 2, "TRUCK" },
                    { new Guid("decb882a-cfa9-42f0-a451-90aab98a56c9"), new Guid("c5d2c35b-c774-4f68-bc8b-4b23482c4244"), 300.0, "A", 4, "TRUCK" },
                    { new Guid("def96fd0-41ea-4076-a29d-6d1043d7b3ca"), new Guid("0e6822f5-7394-400d-bca7-a4cc4dd28978"), 300.0, "B", 3, "TRUCK" },
                    { new Guid("dffec0db-c3cc-4c07-974c-622c27472fdc"), new Guid("bf2771a1-c2c5-496e-beab-9667afd9bbfe"), 100.0, "A", 5, "CAR" },
                    { new Guid("e016d2bd-9c36-4a21-a718-dd6740dc9c01"), new Guid("dec19efa-56f4-4a25-8590-7b1938391756"), 300.0, "B", 5, "TRUCK" },
                    { new Guid("e0260001-23d9-4cde-826d-9dee68d54ae0"), new Guid("ab2501ec-a3d8-4027-98dd-df99be5a1bf9"), 300.0, "B", 2, "TRUCK" },
                    { new Guid("e10c9fd0-b7bc-4ebb-a9db-f924b328d5ae"), new Guid("b74f87ee-301c-418b-a49a-4a8ebe631eb8"), 100.0, "B", 7, "CAR" },
                    { new Guid("e18574d6-a72b-4130-9e4e-fada49bed1e2"), new Guid("0ea2b9de-200d-4f13-b796-bd86c412194b"), 300.0, "B", 2, "TRUCK" },
                    { new Guid("e18ee184-e536-4d1d-81cf-42016c26fc38"), new Guid("76a04e41-7aa0-46e2-8c27-0b677cde6543"), 50.0, "A", 8, "MOTORCYCLE" },
                    { new Guid("e1f86b5a-50e5-451d-aa8c-abc62e4de743"), new Guid("f8fec2b0-96c9-47ff-be70-eee9e7195d60"), 300.0, "A", 4, "TRUCK" },
                    { new Guid("e22638e1-9de7-4756-998f-4e76764e6d92"), new Guid("40448bf3-c284-402d-a1bf-7593c2d267c4"), 100.0, "A", 6, "CAR" },
                    { new Guid("e260c28a-7d6a-4b68-ac3c-8734e01a5e6b"), new Guid("0e6822f5-7394-400d-bca7-a4cc4dd28978"), 300.0, "B", 5, "TRUCK" },
                    { new Guid("e2a02355-b171-4f1f-a076-8345ca4cb24d"), new Guid("f8fec2b0-96c9-47ff-be70-eee9e7195d60"), 300.0, "A", 5, "TRUCK" },
                    { new Guid("e2ee7ce0-6781-49b1-8265-a55b178de4b9"), new Guid("4bbdfefd-5984-4fd5-ad27-04ef0d85ef60"), 300.0, "A", 3, "TRUCK" },
                    { new Guid("e368c8b3-c1b2-4e76-82f0-a7eb649899f4"), new Guid("516e7943-059a-44cc-bd82-d4c4480a6676"), 100.0, "A", 2, "CAR" },
                    { new Guid("e36abafb-d16e-4908-b838-64a905ae2bff"), new Guid("516e7943-059a-44cc-bd82-d4c4480a6676"), 100.0, "A", 3, "CAR" },
                    { new Guid("e39ae9f1-d2e1-4dd4-ae8e-4d8be43012f4"), new Guid("516e7943-059a-44cc-bd82-d4c4480a6676"), 100.0, "A", 7, "CAR" },
                    { new Guid("e3b0b355-851a-4755-b30f-347316f3aa47"), new Guid("cacdb08a-111b-49ab-81b8-13817060e4e8"), 100.0, "A", 6, "CAR" },
                    { new Guid("e423de84-5514-4068-a79d-fb0f4e072ef8"), new Guid("2aedce44-d62f-4847-a9ad-2245b9d31387"), 100.0, "A", 3, "CAR" },
                    { new Guid("e4e891eb-b473-42e2-995d-90c73d81e9c9"), new Guid("bf2771a1-c2c5-496e-beab-9667afd9bbfe"), 100.0, "B", 4, "CAR" },
                    { new Guid("e5481398-f232-4fd1-b432-19fb7d59db16"), new Guid("0e6822f5-7394-400d-bca7-a4cc4dd28978"), 300.0, "B", 7, "TRUCK" },
                    { new Guid("e586d5b0-f8b9-4403-9500-fe8677063cf2"), new Guid("cacdb08a-111b-49ab-81b8-13817060e4e8"), 100.0, "A", 7, "CAR" },
                    { new Guid("e596abcb-c7d7-470e-b593-0e3b0cd4f656"), new Guid("b202d20c-9aca-47ab-8c0c-417b0566bc9a"), 100.0, "A", 6, "CAR" },
                    { new Guid("e599e8f5-2dad-4c42-a77b-47fdf780b18d"), new Guid("b202d20c-9aca-47ab-8c0c-417b0566bc9a"), 100.0, "A", 7, "CAR" },
                    { new Guid("e5ad6d40-485a-4b14-8a24-b8392c0fdb12"), new Guid("6834e8ac-9efa-4f21-a027-d8ae1c1b973e"), 200.0, "A", 7, "VAN" },
                    { new Guid("e5d04925-664d-4205-a632-a809e973fbed"), new Guid("b74f87ee-301c-418b-a49a-4a8ebe631eb8"), 50.0, "A", 5, "MOTORCYCLE" },
                    { new Guid("e6017569-404d-40d3-98fe-516527d498d8"), new Guid("0e1cf06a-2c1f-4f3a-804f-0a21ca76a827"), 300.0, "A", 6, "TRUCK" },
                    { new Guid("e6713c19-4d26-4803-b8d3-37fca4200a08"), new Guid("2aedce44-d62f-4847-a9ad-2245b9d31387"), 100.0, "A", 5, "CAR" },
                    { new Guid("e6984bcb-77cd-47d4-adf8-f82255bbe794"), new Guid("13d8bc75-3ef2-4d55-a2bd-ffc7a683e7e4"), 300.0, "B", 5, "TRUCK" },
                    { new Guid("e6cd272b-250a-4b9e-a1c3-3914b701f52b"), new Guid("15e5b2e9-d51f-4413-9a87-0a8051c82ff4"), 200.0, "A", 5, "VAN" },
                    { new Guid("e6ecbdcc-d1c8-4ebd-aaba-b452b58a1ed6"), new Guid("b202d20c-9aca-47ab-8c0c-417b0566bc9a"), 200.0, "B", 7, "VAN" },
                    { new Guid("e6f0164c-9b2d-4ce6-af5a-b10bc37697b9"), new Guid("325cdcfb-5542-41fb-bca0-5aec0a1f8209"), 300.0, "A", 5, "TRUCK" },
                    { new Guid("e7674d7b-04c0-4dd1-a8b2-da20ed168977"), new Guid("b202d20c-9aca-47ab-8c0c-417b0566bc9a"), 200.0, "B", 2, "VAN" },
                    { new Guid("e787905d-cd1a-4641-9049-e2ccf00c9fb0"), new Guid("f5882dab-e003-453f-b642-a38560da3beb"), 50.0, "A", 4, "MOTORCYCLE" },
                    { new Guid("e792df26-ace5-4276-8175-c31c3310b36f"), new Guid("7fd19919-4f47-4257-af41-0eaf6d2f3533"), 100.0, "B", 5, "CAR" },
                    { new Guid("e7ced068-050c-4b8b-8e90-91e2534d18ab"), new Guid("37b1553e-e0cc-460c-b0a8-d72fea93dadc"), 50.0, "A", 3, "MOTORCYCLE" },
                    { new Guid("e7d09c3f-157c-4d4a-aeb6-654be19df83d"), new Guid("cacdb08a-111b-49ab-81b8-13817060e4e8"), 200.0, "B", 6, "VAN" },
                    { new Guid("e852eb93-1705-48c9-ba27-85f1564d0723"), new Guid("d76e484e-5fd9-4cf5-8892-f4fcf44654fa"), 300.0, "B", 2, "TRUCK" },
                    { new Guid("e9914ca2-9bbd-4c71-988c-0fdbab487016"), new Guid("47569aaa-bf51-4525-832e-9153120d433e"), 200.0, "B", 2, "VAN" },
                    { new Guid("ea0e3b71-e599-4fd3-a67f-0c118c32dc66"), new Guid("47569aaa-bf51-4525-832e-9153120d433e"), 200.0, "B", 3, "VAN" },
                    { new Guid("ea1946b5-057d-4c86-9ef1-1d1c5814edb2"), new Guid("f5e07364-5770-4cca-8215-4bc9687928fd"), 100.0, "B", 2, "CAR" },
                    { new Guid("eabb66c8-ee6f-4fe1-a17b-5b72e27afc97"), new Guid("bf471c98-2465-4e39-b3a4-a0a56d7f0b0c"), 50.0, "A", 6, "MOTORCYCLE" },
                    { new Guid("eb266138-4ad2-498d-bed1-0bc2718a4422"), new Guid("cfeefc53-67a5-4e6a-a136-330d10920937"), 100.0, "A", 6, "CAR" },
                    { new Guid("eb4737b6-10f6-46c8-bb90-d110fe95a0b6"), new Guid("30fd900a-27d9-4682-b5e2-db8c76e2062b"), 50.0, "A", 3, "MOTORCYCLE" },
                    { new Guid("eb4dca9a-415b-4830-a33c-2aa3f20e970a"), new Guid("c5d2c35b-c774-4f68-bc8b-4b23482c4244"), 300.0, "A", 5, "TRUCK" },
                    { new Guid("ec2cb267-df32-4329-aef1-f4962d7c94a6"), new Guid("0ea2b9de-200d-4f13-b796-bd86c412194b"), 50.0, "A", 2, "MOTORCYCLE" },
                    { new Guid("ecc2e147-90db-4f6e-aef0-01765e457c8c"), new Guid("66ccfd45-4738-48da-ac09-400c1a1a26bb"), 100.0, "B", 1, "CAR" },
                    { new Guid("ed53fc9f-18da-45ca-b935-6a74b1988278"), new Guid("e07be4a4-a28a-4d40-bd21-3371ef69fc0b"), 100.0, "B", 5, "CAR" },
                    { new Guid("ed69c800-a352-4ce7-bcee-4f4f0bda974d"), new Guid("e07be4a4-a28a-4d40-bd21-3371ef69fc0b"), 200.0, "A", 4, "VAN" },
                    { new Guid("ed7fd4a2-3e2c-49f2-ad6a-669ca97e4978"), new Guid("4f8943b0-c325-4306-8872-c0687a860552"), 200.0, "A", 3, "VAN" },
                    { new Guid("ee7e380f-09b8-40dc-add0-fdb8356d78ef"), new Guid("dec19efa-56f4-4a25-8590-7b1938391756"), 300.0, "B", 4, "TRUCK" },
                    { new Guid("ee9e2c07-902e-41d2-a21b-11189aeb2e3a"), new Guid("0ea2b9de-200d-4f13-b796-bd86c412194b"), 300.0, "B", 7, "TRUCK" },
                    { new Guid("eebfeb34-9138-44a9-9f4a-b81d61e584d5"), new Guid("561ae673-4668-49b7-81ca-2fc792ab1b3e"), 50.0, "A", 1, "MOTORCYCLE" },
                    { new Guid("eecf0b02-5803-4f5d-a606-f9a20b5f344d"), new Guid("0b1a89a0-0f56-47cf-8cf8-6e15ec4f04ef"), 100.0, "B", 4, "CAR" },
                    { new Guid("ef127f40-32c8-4d0b-af7e-d98bb3d2ed94"), new Guid("b1ad3048-49d6-4a9a-a0f8-d99e3f5f70f5"), 300.0, "B", 8, "TRUCK" },
                    { new Guid("ef4510f0-6cd1-41c1-9a10-5543c35fae15"), new Guid("04b75293-d378-4ee1-b298-9f723aa1e4bf"), 100.0, "A", 6, "CAR" },
                    { new Guid("ef6b7b66-7ac7-433e-8c74-3696782b0a03"), new Guid("e07be4a4-a28a-4d40-bd21-3371ef69fc0b"), 100.0, "B", 2, "CAR" },
                    { new Guid("efd0d9e5-4adb-4317-ac26-a92e19e6b457"), new Guid("13d8bc75-3ef2-4d55-a2bd-ffc7a683e7e4"), 300.0, "B", 6, "TRUCK" },
                    { new Guid("f0823772-cb94-4856-a517-319966008753"), new Guid("18bb3ced-ef4c-4990-902d-9ccdbee03709"), 100.0, "B", 6, "CAR" },
                    { new Guid("f0a5e1b7-7858-4f21-9b8d-0abd0c989c4d"), new Guid("f5e07364-5770-4cca-8215-4bc9687928fd"), 300.0, "A", 6, "TRUCK" },
                    { new Guid("f0b8ee33-f191-4adb-b34d-b2b85dcd48fa"), new Guid("04b75293-d378-4ee1-b298-9f723aa1e4bf"), 100.0, "B", 6, "CAR" },
                    { new Guid("f0bda719-84ae-43dc-8891-bccad7a61df7"), new Guid("66ccfd45-4738-48da-ac09-400c1a1a26bb"), 300.0, "A", 5, "TRUCK" },
                    { new Guid("f0f76762-5452-4c1b-9007-cf0eb50484e5"), new Guid("c7dca08c-fee9-47a0-bb70-4dc53f2699d0"), 300.0, "B", 5, "TRUCK" },
                    { new Guid("f0fd4453-5c0f-41ec-a4d9-f56e9ff161d4"), new Guid("c7dca08c-fee9-47a0-bb70-4dc53f2699d0"), 100.0, "A", 2, "CAR" },
                    { new Guid("f10405c2-bf3e-482d-9524-9ae0228b31bc"), new Guid("2aedce44-d62f-4847-a9ad-2245b9d31387"), 100.0, "A", 6, "CAR" },
                    { new Guid("f175fdcb-51bc-455c-b57d-8413048ea486"), new Guid("66ccfd45-4738-48da-ac09-400c1a1a26bb"), 300.0, "A", 8, "TRUCK" },
                    { new Guid("f19b26b2-c018-4727-b820-df207f99a252"), new Guid("b7048c17-53ab-4005-8a80-eed7f70c6c99"), 200.0, "B", 5, "VAN" },
                    { new Guid("f1a363dd-9dd1-448e-94c4-5bacf3450973"), new Guid("88c0746c-384c-48a3-8a24-034a9d11e036"), 100.0, "A", 8, "CAR" },
                    { new Guid("f22e3fb1-212c-4fdf-8b8f-9eba284ec67f"), new Guid("d76e484e-5fd9-4cf5-8892-f4fcf44654fa"), 300.0, "B", 8, "TRUCK" },
                    { new Guid("f240c46e-ae96-414e-ac40-2ee78e3f179d"), new Guid("f92eb003-edbb-4752-9d08-baf8cf0be864"), 100.0, "B", 8, "CAR" },
                    { new Guid("f28f4fa6-2bf6-48e9-9460-5ff7ba383d20"), new Guid("dec19efa-56f4-4a25-8590-7b1938391756"), 100.0, "A", 8, "CAR" },
                    { new Guid("f29b5e86-6f2e-4936-b8e4-c2696c52a927"), new Guid("5a1062de-7895-4914-b081-cc7ff9e007e7"), 50.0, "A", 7, "MOTORCYCLE" },
                    { new Guid("f29d4de7-365e-4161-9bd3-0fdd4ca56297"), new Guid("04b75293-d378-4ee1-b298-9f723aa1e4bf"), 100.0, "B", 7, "CAR" },
                    { new Guid("f2de4bbc-af68-4ce5-8e9b-de03104c2b4a"), new Guid("2aedce44-d62f-4847-a9ad-2245b9d31387"), 100.0, "A", 4, "CAR" },
                    { new Guid("f3b002c2-02bf-44cd-87b0-103389448deb"), new Guid("f8fec2b0-96c9-47ff-be70-eee9e7195d60"), 200.0, "B", 4, "VAN" },
                    { new Guid("f3f32d93-c356-4f94-8cfe-5aa5de0e0fc2"), new Guid("516e7943-059a-44cc-bd82-d4c4480a6676"), 100.0, "B", 8, "CAR" },
                    { new Guid("f4285cf8-e8ec-4d83-b908-fe8924f94462"), new Guid("bf2771a1-c2c5-496e-beab-9667afd9bbfe"), 100.0, "A", 1, "CAR" },
                    { new Guid("f45213b3-d1e9-4840-a749-a2fd9cd4ec11"), new Guid("40448bf3-c284-402d-a1bf-7593c2d267c4"), 300.0, "B", 7, "TRUCK" },
                    { new Guid("f4bc6001-0e59-4633-b0c8-fdc4de543448"), new Guid("d7bcb6e9-67e9-4afc-9d25-f169447500eb"), 200.0, "B", 3, "VAN" },
                    { new Guid("f4f250b7-0ece-4fdd-87b5-a60e15dbbd96"), new Guid("bf2771a1-c2c5-496e-beab-9667afd9bbfe"), 100.0, "B", 2, "CAR" },
                    { new Guid("f545c662-23a2-4518-a332-020ba91962a2"), new Guid("cc8bb9f7-35ca-4c40-8498-8e83c25136cd"), 50.0, "B", 6, "MOTORCYCLE" },
                    { new Guid("f593b7ea-f6d5-4dac-8017-ecbfbffb93ba"), new Guid("4bbdfefd-5984-4fd5-ad27-04ef0d85ef60"), 300.0, "A", 5, "TRUCK" },
                    { new Guid("f5a44339-b5b2-4523-8ed2-09a55f9fe6ac"), new Guid("561ae673-4668-49b7-81ca-2fc792ab1b3e"), 50.0, "B", 7, "MOTORCYCLE" },
                    { new Guid("f5bda226-69c9-49f5-ab8b-cefee586564c"), new Guid("66af1e03-1839-46f2-a5b1-999c4f3a5b30"), 200.0, "A", 3, "VAN" },
                    { new Guid("f5cbf40d-9563-468a-9b5e-8c5ed4dd26c9"), new Guid("37b1553e-e0cc-460c-b0a8-d72fea93dadc"), 50.0, "A", 1, "MOTORCYCLE" },
                    { new Guid("f5eaee75-afff-45e9-af08-b2520b0c33b4"), new Guid("47569aaa-bf51-4525-832e-9153120d433e"), 200.0, "A", 7, "VAN" },
                    { new Guid("f617340f-4180-4415-be99-d91d92ae2efb"), new Guid("eb01d97e-5919-4537-822f-2fff3c6fd84f"), 50.0, "A", 6, "MOTORCYCLE" },
                    { new Guid("f64ef84b-e474-479d-8259-58f093ee0905"), new Guid("f5882dab-e003-453f-b642-a38560da3beb"), 50.0, "A", 1, "MOTORCYCLE" },
                    { new Guid("f650d6fa-d3ff-4946-a1a5-29b2612ccaad"), new Guid("37b1553e-e0cc-460c-b0a8-d72fea93dadc"), 50.0, "A", 2, "MOTORCYCLE" },
                    { new Guid("f6798afa-4414-4ae6-bd5b-8e02c0f57d72"), new Guid("b1ad3048-49d6-4a9a-a0f8-d99e3f5f70f5"), 300.0, "B", 2, "TRUCK" },
                    { new Guid("f6858a45-6d47-4345-99d2-c0fcb24f6f81"), new Guid("bf471c98-2465-4e39-b3a4-a0a56d7f0b0c"), 200.0, "B", 1, "VAN" },
                    { new Guid("f6db7a7b-593e-44b8-93b8-10a2c32bff1a"), new Guid("76a04e41-7aa0-46e2-8c27-0b677cde6543"), 50.0, "A", 7, "MOTORCYCLE" },
                    { new Guid("f75420bb-6f4b-4c4a-8da9-538fbfa7c738"), new Guid("5a1062de-7895-4914-b081-cc7ff9e007e7"), 100.0, "B", 7, "CAR" },
                    { new Guid("f851e8c0-bf14-4206-b714-cef157a2c7a9"), new Guid("e5dceac8-c4a8-4f0a-b51b-9a305ff65216"), 200.0, "B", 4, "VAN" },
                    { new Guid("f86b02df-6ac1-4773-9910-a84698274aa5"), new Guid("c7dca08c-fee9-47a0-bb70-4dc53f2699d0"), 100.0, "A", 1, "CAR" },
                    { new Guid("f88c56d3-77f2-48fd-90f0-1a19008852ea"), new Guid("0b1a89a0-0f56-47cf-8cf8-6e15ec4f04ef"), 50.0, "A", 1, "MOTORCYCLE" },
                    { new Guid("f8a69e81-b646-46a5-b2d2-e140011fb877"), new Guid("18bb3ced-ef4c-4990-902d-9ccdbee03709"), 100.0, "A", 1, "CAR" },
                    { new Guid("f8ac2101-aac7-407c-84af-f306c033fdbf"), new Guid("66ccfd45-4738-48da-ac09-400c1a1a26bb"), 100.0, "B", 5, "CAR" },
                    { new Guid("f9187369-caef-46a4-a9bf-ffdf996321c9"), new Guid("b202d20c-9aca-47ab-8c0c-417b0566bc9a"), 200.0, "B", 3, "VAN" },
                    { new Guid("f95de228-8512-41fc-87e6-1bf62310ba59"), new Guid("cfeefc53-67a5-4e6a-a136-330d10920937"), 100.0, "A", 8, "CAR" },
                    { new Guid("f96cdc55-6d6f-4dde-8f8f-c4558d2d8d15"), new Guid("b74f87ee-301c-418b-a49a-4a8ebe631eb8"), 50.0, "A", 4, "MOTORCYCLE" },
                    { new Guid("f9bd73cf-f228-4144-8707-d4cfe5ba54b5"), new Guid("454290bd-e2c7-4154-b980-cc091b14465d"), 300.0, "B", 1, "TRUCK" },
                    { new Guid("f9f2871d-091c-44e9-adbf-32ae3b3c4439"), new Guid("cc8bb9f7-35ca-4c40-8498-8e83c25136cd"), 300.0, "A", 3, "TRUCK" },
                    { new Guid("fab8c0d2-9970-4675-a9a2-1a7ec09e41e1"), new Guid("bf471c98-2465-4e39-b3a4-a0a56d7f0b0c"), 50.0, "A", 5, "MOTORCYCLE" },
                    { new Guid("fae9e72e-bc9f-4502-b977-3f18925977ee"), new Guid("e5dceac8-c4a8-4f0a-b51b-9a305ff65216"), 200.0, "B", 5, "VAN" },
                    { new Guid("fb6a61db-eed9-4be4-ac02-a2c4040a188d"), new Guid("9ef7200f-cd79-41e9-ac2b-c0215f0fc9fc"), 300.0, "B", 6, "TRUCK" },
                    { new Guid("fb9bf142-a30d-4795-8b06-aca6d6a8bbc0"), new Guid("bf471c98-2465-4e39-b3a4-a0a56d7f0b0c"), 200.0, "B", 4, "VAN" },
                    { new Guid("fbecf67b-3256-47da-b2aa-fd9b2349749d"), new Guid("5a1062de-7895-4914-b081-cc7ff9e007e7"), 50.0, "A", 2, "MOTORCYCLE" },
                    { new Guid("fc853e86-8ea0-4384-b363-7ef44f440848"), new Guid("564ba9ef-c816-47d7-a41b-a7b061183905"), 200.0, "A", 8, "VAN" },
                    { new Guid("fcf03135-0d94-4fd0-890d-6d08d0425789"), new Guid("cdd98f54-2de4-464d-912e-488674be6f46"), 50.0, "A", 3, "MOTORCYCLE" },
                    { new Guid("fd1a3447-7c69-48e3-8fbc-d913fcfff594"), new Guid("cacdb08a-111b-49ab-81b8-13817060e4e8"), 200.0, "B", 2, "VAN" },
                    { new Guid("fd28bace-42ed-44a6-814b-4f97c42d8b9d"), new Guid("b202d20c-9aca-47ab-8c0c-417b0566bc9a"), 100.0, "A", 8, "CAR" },
                    { new Guid("fd6209d2-1aef-4333-953e-bc9617832cb1"), new Guid("f5882dab-e003-453f-b642-a38560da3beb"), 200.0, "B", 6, "VAN" },
                    { new Guid("fd7f3e33-4dd1-4302-80f5-2603013ad26b"), new Guid("18bb3ced-ef4c-4990-902d-9ccdbee03709"), 100.0, "A", 7, "CAR" },
                    { new Guid("fdd647e9-eab2-4b6e-929b-748a2a70b503"), new Guid("ae3959c4-5bca-457d-9c14-4cc88f49d61e"), 100.0, "B", 2, "CAR" },
                    { new Guid("fe149709-d779-4fc0-8341-5af2b1286591"), new Guid("8eda8dbd-513f-49c9-a050-7c8a6e6475d7"), 200.0, "B", 5, "VAN" },
                    { new Guid("fe19fe85-abff-4382-ac64-044e08493b4c"), new Guid("dec19efa-56f4-4a25-8590-7b1938391756"), 300.0, "B", 6, "TRUCK" },
                    { new Guid("fe35be3a-56af-48e9-abea-6a7cd2ff4ff6"), new Guid("e07be4a4-a28a-4d40-bd21-3371ef69fc0b"), 100.0, "B", 6, "CAR" },
                    { new Guid("fe75f6de-9e85-41c0-a31a-1ddcb1bb9e99"), new Guid("516e7943-059a-44cc-bd82-d4c4480a6676"), 100.0, "B", 4, "CAR" },
                    { new Guid("fe7cf9f6-bf80-4261-a0ea-ead2e0d16e6c"), new Guid("bf471c98-2465-4e39-b3a4-a0a56d7f0b0c"), 50.0, "A", 3, "MOTORCYCLE" },
                    { new Guid("fe9914b8-823e-4e03-b5e6-afce55dfd9a2"), new Guid("bf471c98-2465-4e39-b3a4-a0a56d7f0b0c"), 200.0, "B", 7, "VAN" },
                    { new Guid("fed953ed-c5f2-40c6-8aaa-e172833cc759"), new Guid("ae3959c4-5bca-457d-9c14-4cc88f49d61e"), 100.0, "B", 8, "CAR" },
                    { new Guid("ffda40c4-bd63-4223-937c-f6eea9391040"), new Guid("a4cc4c37-d39f-4d36-9a60-2d6404fc97f6"), 200.0, "A", 8, "VAN" }
                });

            migrationBuilder.InsertData(
                table: "Bookings",
                columns: new[] { "Id", "CreatedAt", "EndDate", "ParkingSpaceId", "Passcode", "PhoneNumber", "PricePerHour", "StartDate", "Status", "StripePaymentSessionId", "TotalPrice", "UpdatedAt", "UserId", "VehicleNumber" },
                values: new object[,]
                {
                    { new Guid("027c5017-c643-4238-9708-bd2546f114f2"), new DateTime(2025, 1, 16, 9, 8, 12, 518, DateTimeKind.Utc).AddTicks(5270), new DateTime(2025, 2, 1, 1, 0, 0, 0, DateTimeKind.Unspecified), new Guid("f29b5e86-6f2e-4936-b8e4-c2696c52a927"), "KNVIZ7", "+8801174224635", 50.0, new DateTime(2025, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "VEHICLE_CHECKED_OUT", null, 50.0, new DateTime(2025, 1, 16, 9, 8, 12, 518, DateTimeKind.Utc).AddTicks(5299), new Guid("83cd26b0-6fcc-47e4-ac26-181f60fae47a"), "H2QRW4XUQBW021845" },
                    { new Guid("0dcb0f0e-853f-4e79-9c3d-4c6c5d19e6a7"), new DateTime(2025, 1, 16, 9, 8, 12, 418, DateTimeKind.Utc).AddTicks(2206), new DateTime(2025, 2, 1, 1, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8ac4a4cd-181a-40a5-9d5b-b835c811416b"), "83JH2G", "+8801041848666", 50.0, new DateTime(2025, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "VEHICLE_CHECKED_IN", null, 50.0, new DateTime(2025, 1, 16, 9, 8, 12, 418, DateTimeKind.Utc).AddTicks(2242), new Guid("83cd26b0-6fcc-47e4-ac26-181f60fae47a"), "HYN3NUGJ27G713908" },
                    { new Guid("10ba937a-b6cd-434e-b23a-cf089b73d127"), new DateTime(2025, 1, 16, 9, 8, 12, 512, DateTimeKind.Utc).AddTicks(6315), new DateTime(2025, 2, 1, 5, 0, 0, 0, DateTimeKind.Unspecified), new Guid("0b249cb9-2690-4b11-b843-6eba44f29bd2"), "TL1TAB", "+8801917916202", 200.0, new DateTime(2025, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "VEHICLE_CHECKED_OUT", null, 1000.0, new DateTime(2025, 1, 16, 9, 8, 12, 512, DateTimeKind.Utc).AddTicks(6353), new Guid("83cd26b0-6fcc-47e4-ac26-181f60fae47a"), "11KWKM5JOBXR42609" },
                    { new Guid("169df8c0-8389-408f-8f03-8483f2558c87"), new DateTime(2025, 1, 16, 9, 8, 12, 501, DateTimeKind.Utc).AddTicks(7491), new DateTime(2025, 2, 1, 1, 0, 0, 0, DateTimeKind.Unspecified), new Guid("964211e1-d57e-42a1-b54c-060918beb6bc"), "K1658E", "+8801370999370", 100.0, new DateTime(2025, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "VEHICLE_CHECKED_IN", null, 100.0, new DateTime(2025, 1, 16, 9, 8, 12, 501, DateTimeKind.Utc).AddTicks(7519), new Guid("83cd26b0-6fcc-47e4-ac26-181f60fae47a"), "GSB29M394PSK78380" },
                    { new Guid("1ba7c29d-3719-482d-bdbe-6d9e19b30685"), new DateTime(2025, 1, 16, 9, 8, 12, 491, DateTimeKind.Utc).AddTicks(600), new DateTime(2025, 2, 1, 5, 0, 0, 0, DateTimeKind.Unspecified), new Guid("72ede12e-9ab7-460d-8c7e-10c7f4a274b7"), "Q6TAHK", "+8801495401277", 200.0, new DateTime(2025, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "CANCELLED", null, 1000.0, new DateTime(2025, 1, 16, 9, 8, 12, 491, DateTimeKind.Utc).AddTicks(628), new Guid("83cd26b0-6fcc-47e4-ac26-181f60fae47a"), "OXQY3P1XUYE464562" },
                    { new Guid("1f7398b4-d66d-4270-a886-682a3794aaa2"), new DateTime(2025, 1, 16, 9, 8, 12, 454, DateTimeKind.Utc).AddTicks(506), new DateTime(2025, 2, 1, 5, 0, 0, 0, DateTimeKind.Unspecified), new Guid("40757a25-6631-4a87-8067-e5d9db334ad9"), "DZEHB5", "+8801296891904", 300.0, new DateTime(2025, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "CONFIRMED", null, 1500.0, new DateTime(2025, 1, 16, 9, 8, 12, 454, DateTimeKind.Utc).AddTicks(538), new Guid("83cd26b0-6fcc-47e4-ac26-181f60fae47a"), "DWIOJ9YIDLPU66723" },
                    { new Guid("4a5423d4-eaac-4441-b828-f9318d6c88e5"), new DateTime(2025, 1, 16, 9, 8, 12, 523, DateTimeKind.Utc).AddTicks(6458), new DateTime(2025, 2, 1, 5, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e260c28a-7d6a-4b68-ac3c-8734e01a5e6b"), "SWZ35Y", "+8801359240679", 300.0, new DateTime(2025, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "CONFIRMED", null, 1500.0, new DateTime(2025, 1, 16, 9, 8, 12, 523, DateTimeKind.Utc).AddTicks(6487), new Guid("83cd26b0-6fcc-47e4-ac26-181f60fae47a"), "PWD9T55CFSVY51402" },
                    { new Guid("593fbde4-34b6-419a-af5d-8825f03ac1df"), new DateTime(2025, 1, 16, 9, 8, 12, 496, DateTimeKind.Utc).AddTicks(4741), new DateTime(2025, 2, 1, 1, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c9fc9322-ba55-4dff-8d3c-5ea48d0fa909"), "28GVB4", "+8801606504465", 300.0, new DateTime(2025, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "PENDING", null, 300.0, new DateTime(2025, 1, 16, 9, 8, 12, 496, DateTimeKind.Utc).AddTicks(4771), new Guid("83cd26b0-6fcc-47e4-ac26-181f60fae47a"), "KYW4TESDHPLJ81364" },
                    { new Guid("610f81d7-18f4-43e4-9d24-d122e59220fb"), new DateTime(2025, 1, 16, 9, 8, 12, 428, DateTimeKind.Utc).AddTicks(1264), new DateTime(2025, 2, 1, 1, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1b82eccf-26d0-453c-9baa-e7a13368407d"), "E32L69", "+8801709224182", 300.0, new DateTime(2025, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "VEHICLE_CHECKED_OUT", null, 300.0, new DateTime(2025, 1, 16, 9, 8, 12, 428, DateTimeKind.Utc).AddTicks(1298), new Guid("83cd26b0-6fcc-47e4-ac26-181f60fae47a"), "91RSWICXUXAQ47144" },
                    { new Guid("6738241b-ac7d-4818-b85f-f29415204129"), new DateTime(2025, 1, 16, 9, 8, 12, 460, DateTimeKind.Utc).AddTicks(449), new DateTime(2025, 2, 1, 1, 0, 0, 0, DateTimeKind.Unspecified), new Guid("7b1342ee-1fa2-4de7-983b-e4ae03b5fca1"), "3NO7HG", "+8801336216010", 300.0, new DateTime(2025, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "CONFIRMED", null, 300.0, new DateTime(2025, 1, 16, 9, 8, 12, 460, DateTimeKind.Utc).AddTicks(491), new Guid("83cd26b0-6fcc-47e4-ac26-181f60fae47a"), "8URFG9ON35CV38585" },
                    { new Guid("7f822108-4744-4b41-b602-ea2dcafbafbb"), new DateTime(2025, 1, 16, 9, 8, 12, 447, DateTimeKind.Utc).AddTicks(8697), new DateTime(2025, 2, 1, 1, 0, 0, 0, DateTimeKind.Unspecified), new Guid("7ee2e1fb-52a8-499f-b818-d849cdf5a60e"), "ME0YH7", "+8801827006076", 300.0, new DateTime(2025, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "VEHICLE_CHECKED_OUT", null, 300.0, new DateTime(2025, 1, 16, 9, 8, 12, 447, DateTimeKind.Utc).AddTicks(8736), new Guid("83cd26b0-6fcc-47e4-ac26-181f60fae47a"), "BU0WOS2H84F047464" },
                    { new Guid("83baa2ee-30b6-4c6f-9bd5-1dd86f73d7c8"), new DateTime(2025, 1, 16, 9, 8, 12, 434, DateTimeKind.Utc).AddTicks(1410), new DateTime(2025, 2, 1, 1, 0, 0, 0, DateTimeKind.Unspecified), new Guid("48a31950-1aa8-4c7b-ba24-6e7ea42f7ed8"), "SRUM86", "+8801191361656", 100.0, new DateTime(2025, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "CONFIRMED", null, 100.0, new DateTime(2025, 1, 16, 9, 8, 12, 434, DateTimeKind.Utc).AddTicks(1445), new Guid("83cd26b0-6fcc-47e4-ac26-181f60fae47a"), "QI5MDT94P1U320360" },
                    { new Guid("8e3bdbb0-c755-4244-b0e5-b0d2dacb6157"), new DateTime(2025, 1, 16, 9, 8, 12, 410, DateTimeKind.Utc).AddTicks(8962), new DateTime(2025, 2, 1, 1, 0, 0, 0, DateTimeKind.Unspecified), new Guid("91aa6884-1a46-4efe-94c6-f1bcae2ed5c5"), "NC0GGK", "+8801127674505", 50.0, new DateTime(2025, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "VEHICLE_CHECKED_IN", null, 50.0, new DateTime(2025, 1, 16, 9, 8, 12, 410, DateTimeKind.Utc).AddTicks(9022), new Guid("83cd26b0-6fcc-47e4-ac26-181f60fae47a"), "E0BF7PK4UYLH65807" },
                    { new Guid("8f28558f-6fbc-43b8-b0ca-a5d902c0deb2"), new DateTime(2025, 1, 16, 9, 8, 12, 475, DateTimeKind.Utc).AddTicks(421), new DateTime(2025, 2, 1, 1, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8d826623-83fe-4dc1-bbc8-99630934fcf7"), "2ZPQQI", "+8801252669290", 100.0, new DateTime(2025, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "CANCELLED", null, 100.0, new DateTime(2025, 1, 16, 9, 8, 12, 475, DateTimeKind.Utc).AddTicks(468), new Guid("83cd26b0-6fcc-47e4-ac26-181f60fae47a"), "6U0VQUS8G4X882810" },
                    { new Guid("9a3e6d4c-1086-4b35-891d-c9a6481c9abc"), new DateTime(2025, 1, 16, 9, 8, 12, 403, DateTimeKind.Utc).AddTicks(2168), new DateTime(2025, 2, 1, 5, 0, 0, 0, DateTimeKind.Unspecified), new Guid("5a141c78-82e9-4b0f-8722-24b3a54451aa"), "Y5GK6J", "+8801225299050", 300.0, new DateTime(2025, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "CANCELLED", null, 1500.0, new DateTime(2025, 1, 16, 9, 8, 12, 403, DateTimeKind.Utc).AddTicks(3635), new Guid("83cd26b0-6fcc-47e4-ac26-181f60fae47a"), "95GKZW4O4KBS37577" },
                    { new Guid("9d4d47bc-120a-4507-8cca-a1083117e34e"), new DateTime(2025, 1, 16, 9, 8, 12, 485, DateTimeKind.Utc).AddTicks(8520), new DateTime(2025, 2, 1, 1, 0, 0, 0, DateTimeKind.Unspecified), new Guid("f0f76762-5452-4c1b-9007-cf0eb50484e5"), "OPUZET", "+8801004183039", 300.0, new DateTime(2025, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "CONFIRMED", null, 300.0, new DateTime(2025, 1, 16, 9, 8, 12, 485, DateTimeKind.Utc).AddTicks(8550), new Guid("83cd26b0-6fcc-47e4-ac26-181f60fae47a"), "QOGKCCH1NOEN57705" },
                    { new Guid("c6d0053f-bd1f-43a0-9982-5f679064bb32"), new DateTime(2025, 1, 16, 9, 8, 12, 506, DateTimeKind.Utc).AddTicks(9963), new DateTime(2025, 2, 1, 5, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4103789e-6608-4ca7-bb7a-ecb24cfa4209"), "QC9T7A", "+8801106042494", 100.0, new DateTime(2025, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "VEHICLE_CHECKED_IN", null, 500.0, new DateTime(2025, 1, 16, 9, 8, 12, 506, DateTimeKind.Utc).AddTicks(9991), new Guid("83cd26b0-6fcc-47e4-ac26-181f60fae47a"), "8R5BPHSFKIA129733" },
                    { new Guid("c99b612c-0387-49aa-a30a-f7193933abd7"), new DateTime(2025, 1, 16, 9, 8, 12, 441, DateTimeKind.Utc).AddTicks(3763), new DateTime(2025, 2, 1, 5, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b01aba31-4362-42dd-856a-ed7f3f3e9866"), "EI0F4C", "+8801995277175", 200.0, new DateTime(2025, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "CANCELLED", null, 1000.0, new DateTime(2025, 1, 16, 9, 8, 12, 441, DateTimeKind.Utc).AddTicks(3809), new Guid("83cd26b0-6fcc-47e4-ac26-181f60fae47a"), "8DED2SQ0Z2FE68832" },
                    { new Guid("e52ce3ff-1754-456d-81fc-28b193550da9"), new DateTime(2025, 1, 16, 9, 8, 12, 480, DateTimeKind.Utc).AddTicks(4335), new DateTime(2025, 2, 1, 5, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00fa5cd2-67e9-47c8-8fb6-0dcc30dfa0a2"), "8HERRF", "+8801344797102", 300.0, new DateTime(2025, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "VEHICLE_CHECKED_IN", null, 1500.0, new DateTime(2025, 1, 16, 9, 8, 12, 480, DateTimeKind.Utc).AddTicks(4365), new Guid("83cd26b0-6fcc-47e4-ac26-181f60fae47a"), "GMRAO3CN9YXK48151" },
                    { new Guid("f77ea64f-8e90-4c11-8f0a-dcd15a0ba837"), new DateTime(2025, 1, 16, 9, 8, 12, 466, DateTimeKind.Utc).AddTicks(1873), new DateTime(2025, 2, 1, 1, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3a691238-5c25-497b-961b-95bfa0005eb3"), "GSWG0T", "+8801181500213", 300.0, new DateTime(2025, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "CANCELLED", null, 300.0, new DateTime(2025, 1, 16, 9, 8, 12, 466, DateTimeKind.Utc).AddTicks(1907), new Guid("83cd26b0-6fcc-47e4-ac26-181f60fae47a"), "3B5VTO8WBDPF33626" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TestDBs");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("0395b4e6-c154-4f41-b27d-7fec42f2cc63"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("260bff3e-a0d6-490c-8664-5bad14379098"));

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: new Guid("027c5017-c643-4238-9708-bd2546f114f2"));

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: new Guid("0dcb0f0e-853f-4e79-9c3d-4c6c5d19e6a7"));

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: new Guid("10ba937a-b6cd-434e-b23a-cf089b73d127"));

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: new Guid("169df8c0-8389-408f-8f03-8483f2558c87"));

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: new Guid("1ba7c29d-3719-482d-bdbe-6d9e19b30685"));

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: new Guid("1f7398b4-d66d-4270-a886-682a3794aaa2"));

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: new Guid("4a5423d4-eaac-4441-b828-f9318d6c88e5"));

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: new Guid("593fbde4-34b6-419a-af5d-8825f03ac1df"));

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: new Guid("610f81d7-18f4-43e4-9d24-d122e59220fb"));

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: new Guid("6738241b-ac7d-4818-b85f-f29415204129"));

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: new Guid("7f822108-4744-4b41-b602-ea2dcafbafbb"));

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: new Guid("83baa2ee-30b6-4c6f-9bd5-1dd86f73d7c8"));

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: new Guid("8e3bdbb0-c755-4244-b0e5-b0d2dacb6157"));

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: new Guid("8f28558f-6fbc-43b8-b0ca-a5d902c0deb2"));

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: new Guid("9a3e6d4c-1086-4b35-891d-c9a6481c9abc"));

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: new Guid("9d4d47bc-120a-4507-8cca-a1083117e34e"));

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: new Guid("c6d0053f-bd1f-43a0-9982-5f679064bb32"));

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: new Guid("c99b612c-0387-49aa-a30a-f7193933abd7"));

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: new Guid("e52ce3ff-1754-456d-81fc-28b193550da9"));

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: new Guid("f77ea64f-8e90-4c11-8f0a-dcd15a0ba837"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("0003b395-04b2-44e8-a034-8acb9f246777"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("0015a495-01ca-4352-8084-f71456d0ad34"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("00281306-9d92-4757-af82-d58fcb26b012"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("009bb99b-2f79-4f20-991f-9170811e19b6"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("00c51279-73e6-4046-bc51-a385de764bce"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("00ebdcf3-0d1e-4d1d-bfe6-8111f6c3d18f"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("00f3b677-c594-434b-8445-bb7699a072aa"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("017bd424-49ea-4776-a812-36d7d580c289"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("0237d4a1-1f1c-43bc-8b03-4854746dbb19"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("0243ed01-7dcf-4374-8a38-2d5871f34261"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("02828525-f31a-46f1-be1c-b1747437e229"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("0285c81e-f07c-49b7-b80d-339f3ba440c0"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("028eb27b-3fa7-45c8-8152-1884864e1614"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("02b086ef-462a-4353-a8f9-bc489f77455d"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("03473ebf-8943-4da5-8ad6-b0dacf6010d3"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("0353281e-8b60-405f-997c-603fa12cd003"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("03d1e296-dff9-48e5-a271-828be59fb97b"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("040a389d-388f-4084-b86c-e47a50023fbc"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("04229bdb-efa2-447f-b47b-352bebb8009f"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("0423166d-70f4-407f-946f-cce2db49621c"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("043c4de7-3275-4fd0-9dd1-0cb858cf0a81"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("050044fc-ee7a-4b8b-8f8a-a898caea6512"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("0534b92e-a2a0-4386-b19d-2c6538f3048d"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("060677ec-0a06-4d02-911f-7a3315dd1e49"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("06216e48-0e75-458b-8489-3459fdf30852"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("0650f2ca-f72e-4570-a5c4-7fd88b2b1d93"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("0674e61e-24f8-4d74-9746-f6ae057d08c1"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("067aa469-ca46-42d0-87de-ed5a3f9c1698"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("06ee6083-7531-444b-a2a3-24fb31aff620"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("076b5fca-037e-4212-8b7f-24609ebe8900"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("07b7ec8c-f282-45f8-9d05-d2dd7fd8f9df"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("07c3ecc9-8dc0-44bc-a07c-e2ce4f65af89"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("07e1e16b-b008-4b2d-9824-3e6807e557dc"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("07e5694f-ff5b-4193-8d49-6932901df464"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("08029ab1-6c21-44c3-8c52-62ab81aa085c"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("0848d2ec-1ffa-4858-903f-6c1182802a9f"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("08804a04-e055-4084-9ad2-a731ae741da4"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("08b182f6-ac4d-405a-af15-552b31e0c9c0"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("091f8333-d928-4c24-a710-4a113d22e048"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("0973d7db-fdb3-44cd-bb10-f3f913d55c49"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("09990de3-dd56-4438-afff-bdeabeb0b721"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("09faaf8f-1be4-44ec-96dc-b7d7ef660cac"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("0a39281d-1649-4541-ab31-6a8fe1f6cee6"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("0a684207-beee-4589-8c26-34f94b1a0034"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("0aaab760-d33b-41cd-8ead-6cde9ee36e90"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("0aad1606-23c9-44f5-8242-9b7a73347dbb"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("0ac9138a-984d-4eb5-9a06-31b839a36afd"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("0af0a5bb-6e90-4443-a669-e085c33ec8df"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("0b023820-c166-43e9-8b0a-1d1022968b03"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("0b046cbd-cd9a-4fd2-8b31-c7929a0d3c3c"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("0b1d80b0-5ada-464b-bd28-a6651ffc6b79"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("0b6d02c4-1dad-4a15-8318-fd457fa2c959"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("0bbbe287-4b50-4011-9772-eb208af03a3c"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("0c3f87f6-8003-40b0-be65-8bffbf814f42"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("0d2fca8f-2963-45a6-8475-f8548ee32d9d"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("0d4a2fb1-1648-4dc2-86a3-af47b32c9dbd"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("0e2684a3-a184-4e97-95f5-8677a3fc17da"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("0e4a2031-a3b0-4a36-a703-350a830ebfdc"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("0e5b0c4f-a04d-4011-813e-2f965da54a3d"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("0e81b26f-0d11-4f7e-b745-826f2d737754"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("0eaa552a-7081-44e5-a528-8fd0ba2d28e9"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("0ee0ea2d-bbb6-489d-8391-59db14c7c1b6"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("0ef50262-ebb0-4c2a-9126-68c40e0289f8"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("0f4fdf95-e8c7-4772-ab39-4703c4335ad9"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("0f553819-8287-4868-8eb3-da5380015fea"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("0fd61a21-ac5f-4263-8ce7-f3c02bdf9fc3"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("1087b969-0203-4795-a265-2e583c4b385c"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("109ce311-2069-4f2b-8cf3-1d19ed12d2d2"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("10b42f99-b658-4d27-a9e5-3729a0519b61"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("10cf4676-afc5-4dcf-9c7c-8a71e0379982"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("10d89b76-1535-4569-bdb9-d29e5dc67817"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("110779f0-bc27-400e-87f2-73261899c72b"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("11369e5c-f710-4e2d-9893-81edc1ee6b89"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("11dda23b-45dd-4cdb-84f5-f82d5979416b"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("133c28b2-4a37-4a99-8449-a099baba93b8"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("13c6cdfc-4e68-4f85-beb7-ca7cc0c395d1"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("13d0a381-12ed-4657-bd69-f4d8c0cc2604"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("141c8c66-001a-40a8-ac88-7f8abe170c46"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("1475086f-6a34-4a75-8e4a-32f27f2daacc"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("1479cc78-81f4-4ac4-9a30-58800a4905a7"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("1483d002-dc6a-42ca-ae5b-fd12b444cede"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("1497437d-bf80-42ab-adec-810f37c66b84"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("14fbca1c-d2a9-40cf-b038-3fb6e77d27ff"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("1548d6bf-503d-4c78-9d9f-93ac36447a40"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("157664fe-4ada-4818-ab1a-053cf03efc9c"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("15c978e9-3bfc-4f15-956f-5a21d2910b25"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("165c7861-a1d7-4260-afd5-5231bf9c91dd"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("16a6d3b3-b12f-49ed-b7b6-50a8baf30ccd"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("1701fa25-f630-4040-9712-ed577b69c030"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("17854d9d-13be-414a-9036-f51d192ba1b5"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("17fbd831-56d1-4d72-bf88-81cbe25e9f16"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("183a8484-fadf-4b74-a24a-36c846bba6ba"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("183ae804-0cc9-4004-b52a-9a1a5316f7c7"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("184247fe-b38d-4a3d-9c17-69f8ab83d57a"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("192fd427-e768-4e29-abe5-6f71e297e626"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("19430a60-6de1-4221-af74-b0e8619d9353"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("19600553-9f46-44c9-ba95-7a465b657dbf"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("19959850-acd5-4428-b3a7-9b1c29a76438"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("19d259a2-86c0-4f7f-8e9b-022288a74a38"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("1a07b749-bb94-47b2-85a6-2ac994d97468"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("1a41cafc-4720-490f-be98-c47804da3fda"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("1aa4ded3-c5c6-48b1-a985-26ddd2882681"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("1abb0ad2-ac23-42a1-bee6-648e2b502b58"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("1aeb21bc-3daa-45d3-a00f-8c9e79a5fdd1"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("1af82acf-c3e5-48e1-9d78-081ef60d00ab"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("1bc05c34-c431-450c-838f-9b09e35feac4"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("1bc31985-d532-4266-ba7d-e9eb62bf898a"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("1beb42d7-149d-4296-bc24-d66f14600a67"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("1c517ee0-a08a-4153-988c-e431700667a1"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("1ca1c989-af57-45e0-8bc1-30c8aab98fad"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("1d38ee94-d80d-429d-a15a-72599fc4972f"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("1dd411e9-aea9-4b0f-a2e1-705effb43498"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("1e8ca406-d741-466a-bd20-ea313c84228e"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("1f3fee17-004c-48e8-8a94-d3c521af4bf5"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("1f825d07-d8e7-4d66-be85-f1a67f8d4efe"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("1f8b66ac-d737-44c0-bd05-085804be7dce"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("1fdb8cd3-70a5-4b0b-8ffd-3ba83ddd7603"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("20523c80-9b71-45e2-a7f6-758ddb727311"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("208e3f0c-b2fd-42bf-adf4-9546fd1422a3"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("2090cae6-237c-46c8-bf34-174ddad1c858"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("209323e5-f54c-4630-a116-88f5833ef13c"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("20b56e59-f7c7-4f69-bd65-80d1eba9e4e1"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("211f4db6-244a-4af2-be8b-d4823d74daeb"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("217da0bd-a8c1-49db-b15d-7cf24593d7e3"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("2197ce9a-50dd-4b70-90b3-ce843dfdcec3"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("219f0ff5-e223-4dad-910d-1f9b3fad6ce2"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("21e264c7-dab7-46ab-b546-f4758b8c736d"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("220a34bf-4b63-4ca7-b201-a3a2ce3e6bfe"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("2269ff49-ae15-48f4-abbb-82a3cc245158"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("22cb777d-ca21-4d02-8b02-8ccd6be23709"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("232bcb3b-38c2-4166-8a25-ba8affb296de"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("234d100d-81c8-42ac-82cb-429e39fce2c2"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("23bcaccb-add3-4a48-9f52-4db10ebbf7a9"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("2452326d-cedc-40b5-9da5-d4e35b567250"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("24adf949-3ece-4938-b1ca-623b0a5d7d2a"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("257802e7-9152-47d9-8942-04ed78079fd4"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("2584c9d6-4458-4a64-b9f4-399f34bd98a8"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("25b9ae0b-9e8e-4cb9-be55-a6b9e68ed412"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("25c931a3-0b8c-4415-8a07-fc15e8eda6c2"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("26610d47-2303-4045-95bf-f8ceb5b3e3ee"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("26b298ba-6190-4cc9-8995-0dbda3f27719"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("27090145-8171-4a95-b83b-958e2b8596ae"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("271a15cc-52d2-4f1b-abe9-7393907624a5"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("2766c231-0cc1-4dcc-91a6-1429c888505e"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("2786f240-a3ba-4665-8ae8-fe7a488d2709"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("27e5bcf8-cb0e-402e-8ac1-3152cefd1f7c"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("290d49b9-7809-4317-89f8-9e384548ebac"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("296d0d21-118d-47f9-8757-233c55ecd6e8"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("2a302eb5-e11b-47c3-b02d-19de14cbaa34"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("2a4d200f-9d9b-4efa-9cf3-38b1180f85da"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("2ad0a60a-ccb5-43c6-ba2a-11c9fcb6e9d6"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("2b015cd8-3ec7-4af7-b719-78ffbd3d2998"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("2b49f5ce-1ced-448b-919f-8bc48926c2bd"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("2b6340f8-d3a6-47a5-8434-4905a14ebe50"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("2ca29831-382d-4f34-a23b-bb1ae7f3f629"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("2d713258-e562-42b4-88fd-c76fce639a9c"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("2d9d30d5-7af6-4097-a838-c0983cc88640"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("2dbeec1e-519f-4444-a32d-d8b1de8a18bb"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("2e02f412-9338-4e00-afd1-1347d93e1a65"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("2e0da49b-2d2e-4b82-a0f7-bd67744040ae"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("2e75769e-3ab4-4d40-a409-1f459abaed75"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("2e99890c-c8e7-4836-820a-170dbc52f21f"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("2ec39376-b3eb-41e9-9b10-671db853fe4e"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("2f34d956-03af-4047-ae7c-c94c2dfaf8e3"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("2f6d26d6-ba81-4c19-ba39-17143fb2d030"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("2f7bed80-f365-4cc8-8665-7f26bd027b34"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("2f9c1cbb-7d96-4a89-be2f-5dae4608edcb"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("3035524a-03c6-4ffa-8216-8379d0f17af7"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("30426b21-29b5-4ac8-b859-9b433d8f043a"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("30562ede-8b50-4d1a-93a3-0eae3df40bcb"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("307c2103-6fe0-4f8e-957e-0fd1cfc29f2f"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("30b9cc1b-97f5-4bf9-aef3-d5b146763c7c"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("31c7f30f-bfe5-4722-8ece-b4c186037970"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("324d5316-2555-4cf2-93ff-b8b257590834"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("3287cf90-7a08-42bb-862b-32698a4a6e34"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("329ebfa8-4514-4aa1-b80b-9f8229480395"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("32ce8405-9df0-4357-bdd7-fef2559688f2"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("32df984a-4803-4109-9749-abcf15c47b67"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("33f5bebe-9020-4ae0-8dc3-cb3df5b98d77"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("3449a78b-132d-4cc4-b981-ac086e752c1d"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("34d56340-d6eb-4b22-9544-cba6f6bf8bbb"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("34d59eed-868b-4544-9789-209f17cbc60e"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("3507bf04-dda3-421a-a2fe-427ca6c29c1a"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("3613fe29-0fb5-49a6-b79a-d3625d423a2a"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("361facd9-c64e-4003-9ebe-daf5755ecd4f"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("3631df6c-9972-4567-b8fe-03f9941820bf"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("366eebf8-1fde-4c60-975e-f42f30335a4c"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("36cc1581-0f41-4e12-b8d2-1f0451666912"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("36e8c342-cfeb-441f-a44e-32f07f15169e"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("36f8952e-0d91-40cc-8c8d-b88126176d3e"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("3704a1f4-f7fe-48b8-95cd-a23f4311473a"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("370636f9-56d8-4b09-b008-0614aee3d9bf"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("387fed27-a2e6-464a-8ce6-f1f1e807ac9b"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("388c844b-ba50-4fd5-89df-ab72f19f6b03"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("38fa1077-68c0-4996-9721-a0ae99193eef"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("3963e460-24e2-476f-9aa8-bf4ef42e7d71"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("39b07de9-f22e-4157-9aff-17dcf0068939"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("39ceb8a7-18c9-411a-af5b-33b04c9bd886"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("39f3ce7c-f882-4db0-b506-fa3d644ddd4b"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("3a4129bd-95eb-431d-a746-28e0e9e12016"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("3a835e76-fa95-47fe-87ae-9b1f4b64c461"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("3b1c2509-c6b1-4c09-8205-d506c3a3f036"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("3b2893d6-74d3-4bbb-8236-e63e826927b5"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("3b71b880-b601-4ab5-8ef8-12076f5e8f4a"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("3ba631e5-adf8-4d32-926a-5a1d8988afbc"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("3bc5c097-e31f-4821-a3e4-1f6de2177997"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("3c14c4ff-6025-450b-a076-adb52e3e7b3c"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("3c3304ae-69eb-42a5-a89c-763cb5b6f250"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("3cb4b6dd-f29d-4508-b49c-854c6ef7ae29"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("3ccc9a2e-5de0-4fac-852d-c0e4114bcffa"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("3d37cdd2-1617-4dd4-ad03-f97b5b46e4ad"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("3d3909c0-c868-4084-821f-be0baa3fcc8d"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("3d54bd31-6466-45e1-a649-b1db43fda1bb"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("3d625cb4-78f9-47c7-b474-a74a10dd0f7d"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("3db559d1-ffc4-4277-8594-ef4f657ef1ef"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("3db6814e-dd6b-4750-857e-b7fa819298c3"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("3e0e9b71-8e44-421b-a906-b0a316162848"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("3e8000f1-3146-4372-83af-92e312372e22"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("3e96c3e4-f4f1-463e-82f7-b9d95b2ef961"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("3e988dc4-ce7c-4999-aad0-57159b0f5ad4"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("3ec5450c-f9a3-4c0f-9ef8-4ae6b7624fd4"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("3ed1fd1e-c9d8-4f56-81e7-164cd79ff366"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("3ef7d946-bf54-442f-a13d-567dc9996115"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("3f15f63e-6b78-4a29-87c4-610ca1edab69"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("3f6c1ade-a8ef-4480-ae30-43627e791c8a"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("3f7789fc-435a-4e5f-a723-ff01f88f9f7a"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("3f959e27-b980-4623-aaec-8bbfd8a427b0"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("3fc1d976-78ee-4ba7-b661-c1088d0f7e71"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("3fd8bdb9-c1ee-4de4-ad61-940e963d0184"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("4007aa27-d3d7-45e5-9524-f01178273084"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("4069be49-10a1-4cb7-89d4-845f562fbde4"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("4093f338-23f2-45e8-9d86-52e2e199bbbe"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("40cc74fb-d722-4f95-87db-0daa990cea36"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("412c10ad-b61c-4c28-90e0-de6d11895898"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("4261b870-bc88-4018-b49d-917c29046eae"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("42c96f32-19b8-4a79-861c-d87954900f7d"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("43052d01-77dd-42b1-9e59-df48e780f26d"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("431ff94d-f298-47ed-bcc2-90fd8d4e5da0"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("432aff7c-f099-496a-a0c4-f2b2d1e9025d"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("438eb2ff-faab-4f3b-bd63-3b022805d472"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("43a1cd8c-07e9-4835-ab9b-6b7e1740d56c"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("43e78c3e-1082-4381-b475-425f5cd4271e"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("44191851-268d-4e76-9320-62e487b8b595"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("44208ee1-f487-40fd-8bb3-1cdce08b42ea"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("446fe08a-044f-4ad5-83a7-9b22a1ca38d2"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("4477769d-f0fa-497e-87dc-735d0dbdbd82"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("44ce4009-a7e0-480e-a8bb-0767a44fe37a"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("44d1ac39-6a56-4acc-ac40-b5076488d59a"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("44f4992e-66cc-4fca-a8c0-6e4532cac027"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("44fe078b-d557-48c1-97d6-f0a23eadb660"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("45018520-5b8a-40d9-bd3a-421802953f40"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("4536fd1c-ca1f-4759-bfe8-55f4945ff807"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("4570e19a-94e9-4915-b96e-8439d77686d5"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("45a6783e-ac0b-4b21-939a-3bd5fdd40e2d"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("45af41b9-cc49-4331-ac7f-aadd458e0109"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("45e6ee60-7e66-409f-9fbe-2a9efcff084e"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("465d26a0-1bcc-4812-abe8-c68ce7725130"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("46c44ec9-8b05-4690-b4f6-0bd1fee245f2"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("47916aa3-8593-4abc-b92c-619df6f7603d"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("47ad28c4-04f1-4639-9a26-da48d70af52d"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("47cb7c04-220f-4dbe-84b7-e859eb5eebfa"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("4829b23b-f171-4050-8f06-ebd5daee6bb9"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("482ba256-38da-4aaf-b359-474990198bb9"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("48461733-ccda-45af-9fa7-65ab4a628cae"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("489f4e53-5075-45ef-ae4e-9bbbab42fc20"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("48b781c4-84ed-4412-adce-9f42bff1ee27"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("4908fc68-a762-4b63-a50a-c0a7ef5ba509"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("49dedfca-f721-43b1-92b8-42eedabadb21"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("49e6321e-a895-46fb-92d6-fa410ead2746"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("49e7b478-f5ea-43f9-b307-1190282e9b7e"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("4a1b9c4b-6310-442a-9413-f347e31b07c3"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("4a1d1dde-21b8-4221-a42f-90243ec28ff0"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("4a37f3cb-fd26-4bef-b9b5-dc0d5a5ecff9"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("4a3ac181-33bf-4225-9ced-732bc9ebd2b5"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("4a4dc439-e0a0-4d43-846e-1d3495b6a55f"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("4a6eabf8-2d04-413a-b555-bb21af15f1a4"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("4a755abf-b6d6-44bf-93a3-1822535d6157"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("4acf40ac-dd1c-45fe-ac54-6a11ca6f0b6f"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("4ae2af57-5ac3-4bc8-adaa-1dc4e3d38f80"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("4b9d6ae1-3894-40b3-806e-643c962baa1e"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("4c1823e6-94c1-4650-99bb-3d8387e50b49"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("4c81e057-d30a-4956-970a-5ce30317babe"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("4c87e2c3-663d-483e-9d3c-030b6ffc413e"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("4d072e44-74e0-462c-83eb-2e9aced1bf14"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("4d49bc6a-f583-4f76-9cf3-6cd4e7e48fc4"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("4d7b0395-52d8-43ae-b7f8-afa4b3eb233b"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("4e53d180-8bb8-4461-94b6-6c38063a0544"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("4ead4199-2b3a-49b6-9efb-b7fe58210138"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("4eb5b96b-2fcf-4780-9bb9-26d4cb9d5f4c"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("4f111bb9-9e25-4161-89b8-c52ade546edf"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("4f20e72c-5cc1-430f-9eca-c6e219d52135"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("4f375940-3163-4ac5-befb-4973bcd88ec9"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("4f60381d-63de-401b-9409-afe7a70888e6"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("4f6b6dc3-d798-4c01-8228-2f41f7c49f20"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("4ff237cf-c93b-44ba-a03d-d22ebe3db695"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("5013c8e0-d08c-4abe-9aaa-5370dbb0acf2"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("5054aa5a-e61c-4ce6-875e-2539421606e7"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("50bc0d88-100e-4a11-acbe-c94fdf14be17"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("51c4857e-6207-4c1f-9a01-4b741d355423"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("51e272eb-459a-4a1a-af53-bbe7293901ee"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("51eff525-55fd-401c-b768-888198eabaf2"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("529d157e-9353-43a2-89a0-4ad6249c253d"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("52affb16-f0d8-46d0-bd8e-2e98847d70a9"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("52f52b32-1cba-41ff-a76e-04db62f58ffe"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("536dbc86-dd35-4771-9204-f9931defb411"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("5389dfc9-0ce3-4bad-8554-bcabdb32b768"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("53ac5c6d-419b-4251-8387-c601592ed4a9"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("53ae38de-a523-48ec-87f0-7ed71b07e345"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("53d171da-c158-4a55-be79-fa175d299078"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("53ea159c-f43d-4576-9fa3-df79434a5fa2"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("54752781-4e4c-44ef-a2d8-d8eec3a37853"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("54b91da0-da59-41c9-b22d-c17e2ecedcc9"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("5507201d-3350-4d9c-a62b-739cd4a0af50"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("5585c53e-0f15-4b93-9db2-f01952422fc7"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("558832a6-a7c0-4b5d-9fbd-95b4e8170042"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("560b7684-3820-4f82-90d4-fb76093d325f"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("5672cbc1-9946-4d07-b9a2-adf0472222fb"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("5687b80c-1fe2-4107-9c8d-ab15b2c984ee"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("5698588e-8723-414e-b9ff-469d70dada1e"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("56ea487b-0608-4104-af59-b7f47d9f8488"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("57d78042-c69d-4bce-8b2d-8a5582c1f650"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("5837e6df-9752-47b4-8ebf-0b9c1d6c3f2d"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("5843c5df-9740-472b-a8e9-fca261ff6fdc"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("5862a2b0-854e-4dc7-94f7-695db427147e"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("589c9f65-22c8-4dbb-b6ab-4e57dde97c7a"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("58d3c653-8e9a-4db5-bdbc-bfca0511e855"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("590df9b3-ac15-4cd5-8bef-4a0e9e1af53a"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("59b30d7b-ef27-4090-bf92-684bfaaed45a"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("59ba2bbb-b86f-4ad3-ae64-e6e8e50f3d78"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("59bfc50e-c4e5-4d9f-a4d7-765ac8a46fd6"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("5a035fcd-7e21-4c0f-be74-639f5b9b2264"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("5a2693ef-289c-42fe-8f6b-64016d191de8"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("5a407341-8e51-48f6-87a1-01fa28bdc9ad"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("5a8783ab-883e-4057-b327-1e5dd71fa4f8"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("5af0f425-e1db-4b72-b959-9ed300239dac"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("5b99db51-c951-4010-917c-c8511d64eeb3"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("5c1c56d8-162c-4a83-9e60-8259c47102e4"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("5c48dab8-d85d-4570-9f02-6457f73b9f51"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("5c5f2ede-9a2a-4f22-84d8-c6cfa70b1c7e"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("5c72c0d0-a228-4f26-a37b-307846734e5a"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("5d73265f-6ab3-4fc8-9f2e-a87b3a7115b5"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("5da1d74f-275e-4c78-86d1-f44be64972e9"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("5def06e5-4834-420f-8f4c-d070ff931d8a"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("5e818a12-1ea9-410e-b390-182cbc59354f"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("5e910396-abb7-423f-bd42-98a16784cb90"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("5ec55573-13e4-4ae7-9e18-82ecc6b39f55"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("5f185e54-9271-442f-81db-f897bc324c5e"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("5f520cbc-55ad-4f3d-be5c-4817fcaaee20"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("5f73a385-ee33-44df-9bc3-3378d58d180b"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("5f8d592c-99b6-4975-a53c-1059ba7238a6"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("5fe65d5e-128e-4b51-bca3-d42481fcc277"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("6002824c-e290-4c90-a72a-67e04160933b"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("60288f61-e00a-4c7e-bfd9-45f328ed4400"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("605acedf-6a90-4da6-8ee9-d7fe826294a7"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("60d0ff0c-98f3-4f56-aa67-ee4341bd1ad7"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("60d351b9-b5e0-4c20-8a77-1a9db0146b6a"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("60e02458-1dfc-4b82-8f6c-fbe26ad73c51"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("60e52ebd-10f7-489d-994b-d9e8d152b746"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("60e5ca60-d364-40db-913b-25b20d8b804c"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("611cf76c-d8f6-4437-98ce-4d135cc01ea6"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("61202da2-883f-43ac-b478-1278268b4689"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("62681467-9f49-4d5e-8aa2-78f264c66647"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("62ad8333-2758-4111-ad40-9e546b232647"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("6327bee6-2ff0-4a3b-8cbe-9acb31d62321"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("63417f30-c075-4040-80be-10610cc3420e"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("634596c2-e591-4754-9fad-94338f0d593d"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("63588b14-1ea3-4bd0-aa85-b08f24b2828b"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("636b68f7-c825-4f7d-b804-4acd3935a3d0"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("6377a00c-adff-4ee6-a54b-a66d27412efa"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("63dc8838-a9e7-4c77-ad22-eb224bbb56fe"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("63f3edac-7c9a-4e61-8aa6-62236f6fa9a3"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("6427f204-284d-4dca-b898-d004cbbc935f"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("64633b81-f511-4a72-9b59-f7b76f1f8785"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("65ca8ac9-e0a4-4807-97cc-efe9752895d0"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("663446d9-3077-4466-b2bd-c166c21fe5bf"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("66427d7b-a99d-427c-9be3-149962a8d40c"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("666c13de-7248-4159-a433-6518e3e1f4b9"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("66ae6e77-7dc6-4b09-95fd-c8b7495c41db"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("66c84d3d-6c8b-4884-81fd-c20117e40de3"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("66fad316-0a3b-451f-9753-2a19c8f04e45"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("670b5adf-5d60-4107-a5c8-924e88ae39c9"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("67170f90-bb89-488e-9b0b-d97e07601a61"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("67720b98-b891-4e3c-9c17-59d047d20a59"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("677d1fa2-943f-4a00-b6d8-08ee7d0082bd"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("678ea3b6-4876-4fbb-b0e7-577aa8931f0a"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("67925390-7928-4044-afb1-ca7cf3addfe7"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("684f17fa-d7ed-4a9d-9c74-1232387b9c8f"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("68a9b99d-9fd6-4a18-b5e2-443b42425ddc"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("68ed8f67-132c-4f27-8bf7-1058b35cfe1a"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("690ed5e6-5e29-489b-a3ca-115972bdaea0"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("6914bc18-aa72-472c-a9ba-80c147d8b5b2"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("6959d709-2e23-4deb-be33-cb11335fc281"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("696cfa08-2283-4587-8cd3-2a4b174e9689"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("6973c2f3-1c73-40fa-a2aa-e0df9ef84f1f"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("6985facb-3b1b-41bf-b41a-057ffd0c2d55"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("69902210-56da-4791-a2a9-375ea88d7d50"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("69ea9747-5041-4b76-a3f8-ac1f2874b8e2"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("6a08facd-73a4-475e-b251-f34a3f634c8e"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("6ae23626-76c8-4f7f-9bf5-3073b7a79f13"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("6af08a34-20b4-4831-a399-7fec6cc7fa9b"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("6b06bb10-77a8-4971-bf6c-b71e1cfd0102"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("6b773577-9839-45a8-a5fd-cecc598889d4"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("6b79b26f-607c-4231-af0a-27a769303dcf"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("6b8a2170-0268-430b-9588-eb2d93abefc3"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("6c01456f-c00f-4b7a-b29b-3609d5073b83"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("6c8e25c4-5be7-41d8-9876-90b4c6d44479"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("6cb8733f-3724-4bcf-adde-cec049b81322"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("6d52eca5-216e-4773-9a59-963d633fdcd5"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("6d80346f-27c7-43d7-b120-e49ddc1cff93"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("6db050d1-35d5-461d-aa67-4eecbc664662"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("6e0db4f4-47f8-42fa-bc31-e0273505691f"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("6e0dd505-3d22-4b2b-af72-b3061736926d"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("6e123d76-c38e-438f-9197-1a950e99e004"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("6ef469b6-37b2-4faf-b132-e076c28686fa"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("6fe417cf-7aef-4793-acf4-8a46348168dd"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("70143194-7407-494b-80c4-b4c6b90f22be"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("701e8f73-c3cc-44fe-8f83-eae93155b111"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("709679b8-1f17-4e16-bcea-8b71839fe1e9"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("70d97ac6-d278-4458-beff-614cf7f55587"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("70f7e599-bc47-4336-8662-44d879bb09ce"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("715b91ec-e0a1-40a0-899f-f623e9e1297c"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("7172ca63-4f86-4f20-a3f7-9ab77fbcd0f9"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("726ee0e3-f8ce-4f32-b4cf-c906f97b095e"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("728385e2-c45b-43da-9da0-57a497a00f81"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("7293bc1f-fbf9-4750-a441-9bd735977e16"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("72d7a93b-67de-4b97-8bcf-cc9fc6f15004"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("732fcc8e-fe8a-4c6d-8172-cef03e858a0f"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("7338922b-3a76-4c46-8bb2-d54978ff95dc"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("73a69d2e-8a41-49f4-8204-14ec1657c830"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("7436ad00-acb4-42a4-9aa0-fb820e4f7ba4"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("746e4f76-4496-4f0d-8be4-dde491bd82f7"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("74723afc-d2d2-470e-87fa-1d74b5b43400"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("74a7ecb2-77c4-4326-a5ca-fa3b5b22a76f"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("75846cbe-3164-4aa2-8590-02bcd3cb3c27"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("75941876-ddd1-483a-a027-ac7a872192c9"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("75a57b34-8f55-4ae7-8766-e73e31414529"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("75fa6279-0ce4-4f58-8731-240b75d86355"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("7602984b-06b7-4445-a2f6-5a16c95192b1"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("7627024d-1162-479e-beff-bd62ab521877"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("76f42be8-85e1-47d3-aa9e-24b08aa67382"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("76f803d8-8942-41a3-bc3a-4c8ce2820d4e"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("77487f60-06ab-43eb-bc73-ecc5b4b7219c"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("778f8d22-d996-46f1-b6ff-f1b465882c45"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("7795dd0a-96b7-4fb0-bf63-bc7f098ba377"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("77d5ca1d-9404-40a1-b572-7c480c6a73fb"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("77e28cbc-d109-490f-a258-9e3fcf28fc14"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("789ff9b2-ac14-4b4c-a7e1-b88792549da4"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("78d54aa8-c025-4862-bb05-44826f349bea"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("7914fe70-b787-40b2-b940-d0769d42aea2"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("793a0eee-3ca6-43a2-afb5-bbbe3a73ca69"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("794f4130-e169-4af6-932c-56bdc8d62110"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("79577990-0c48-4fcc-8033-b6edc2f128f9"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("7984ff9c-6329-46a5-8d1f-6bb9b0ac215e"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("79a1926f-d61b-4020-9256-4123310f92d8"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("7a841024-3e19-4093-9d11-56f141faf898"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("7ae85df1-bc10-48c5-a611-494c51b14a03"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("7b14ba12-d9fc-4d42-85b5-84f175e60405"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("7b681fe6-27f0-421c-9f68-6f1b80cabdd8"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("7b9f077e-8fdb-4cdc-b10e-673dd3bd22a8"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("7babefae-dbe5-4387-8b05-b14fa6c00b61"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("7bc75da5-bbfc-425a-a8e4-d4b54fc06b84"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("7c783e41-c906-49a1-b644-96b33c3e88a7"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("7cf39454-c29c-48f2-a3fc-bef070531a37"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("7cf64752-38ff-407f-b823-7a7e7c41f624"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("7dd40ff0-2eb0-43eb-ac61-da1308c8ce1f"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("7e544d51-1835-4f2b-823f-2da1c9b45e4c"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("7eae2b4f-34c1-4b59-b4aa-b85d287a1250"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("7f019046-5759-44b4-b42a-c0583b58993a"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("7f50819b-c243-4a70-9712-6685d84a7783"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("7f7c4369-b41b-4676-98fa-10d5092f813a"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("7fe8ebd4-827d-438d-a7ac-e6eea4d80499"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("7fea20aa-f312-4dec-914d-20a60f009d4e"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("802fb454-b42f-4406-b9ea-c67dd1b01742"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("80b68db2-79d5-45bf-94b5-1e909cb56137"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("80c4038d-fe51-4050-ac57-8bf29d0c65b7"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("81811324-d8d1-46e3-8b7c-20bbbb4ca489"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("81d2cce1-74ab-4c8a-99ef-2b3350d44b42"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("820db283-b11d-4623-a4ba-37a72e7fcf2b"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("827b6064-75c3-471a-a61e-7a7d58f55561"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("828763c5-b79f-4615-8aba-315d1fc76675"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("82cd9d15-3a04-4aba-97be-4cd59fb681bb"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("82d5d9a7-c2ae-4454-80da-67cf9b6b7d84"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("83961ba2-622b-4ce9-9f8d-f9371a6cf53a"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("83f722e9-eead-4b0e-9307-0f90ecb10600"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("83fd1a63-6dc7-4396-92fa-2773a677981e"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("8411f1cd-1c96-4e0c-8d85-70fdc16605a6"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("842a0167-1530-4659-a941-ec350e17a0c8"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("8480bfba-5e74-43af-ac69-4aa2a823d19c"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("8485dda4-4693-436c-8064-5a37bf912406"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("857d9a1d-3c99-4bb9-82d2-d762c29c6c3a"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("85aad4da-913e-4186-ba0e-a4dd71e0bb63"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("86330967-f06f-4b37-8a3d-29a31049ba6d"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("865e12b4-5de1-470e-b9e4-5f6aee6686d2"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("8680efeb-6d28-438c-bea9-84bc77613270"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("86850071-73e1-4881-9b09-b7ec3cf044fb"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("87015ed7-c9a2-4b1f-855b-11ff5dc72cf5"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("875cdc66-9535-4aec-a7b0-9460cd7e3a59"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("879d0096-6342-4b3d-aaa4-034a27a9ddd9"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("87abaa98-fddc-4196-9122-a89740d5d886"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("87cab68a-05bd-4a00-a067-c1658303158c"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("87e70b9a-dbfc-404d-9ee3-60edd4191ac9"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("87fa7b31-964f-4081-848d-d569db372de8"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("88b5f44d-146b-441d-bbc0-d1271912d743"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("88c9cfcc-21b0-4616-b0ad-a4d6ee6c5b0b"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("88cbb5f6-cd10-4dbb-9bae-81ef82cdcb09"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("88eb7051-5a0d-4729-8e35-04409a44b48b"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("897de6f2-7a02-4071-8bcf-d6babcffb620"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("89be92f3-083d-4dad-ba60-264ee2b5691d"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("8a1e06cf-4d42-4e45-bd1e-8c922e875ad6"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("8a49077a-1553-4b4c-81c6-3d133d508d1e"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("8abe1484-a11c-4d0b-8a00-5e1b270d97ef"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("8ac8420f-e679-492b-8e52-8837c20a9c77"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("8ada301a-2f03-4051-9e60-732fe9899f47"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("8af4922f-b939-4ec6-9d11-8e0ab98ccd03"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("8b492288-a6ed-48de-9714-346221701354"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("8b4a8fea-7147-4c66-83e0-9165e68ed108"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("8da810f2-73c3-4c87-a84b-c295f3a6c7c4"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("8e309c1e-d639-4766-a7a9-3e8e80de37e0"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("8e62920d-1e49-4b22-90a0-7143d576cd7d"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("8eac6ed1-7bcf-48e0-8e9a-d1f94d12fb05"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("8ee22289-7650-4857-b9c3-5478d2d20586"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("8ef8fe8f-1bbb-454c-8fed-6bb7e2d374a9"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("8f01fa4d-5162-41f0-b0ab-1e804e41a91e"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("8f76cb16-4160-4b36-9e84-a8af20363e76"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("8faf8cba-bbe8-4811-8235-9c5e399a75ee"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("9031ab9a-394a-4887-afe9-aba037518aee"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("904dbf8d-6719-433d-9c05-69da4fa01d3d"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("905c4e1b-8d13-4b2c-920e-f357fecea8a5"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("907c918c-f827-4390-a115-6d5e761bec64"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("90a2015a-547b-46eb-9e1a-4623ff0857a8"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("9146efae-3cea-4e50-aeb8-1e382f8de68c"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("91b30942-84f1-4062-83cd-a80f950308d9"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("91d0594b-4b87-4d15-a87b-b7e1c84dc319"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("93236b99-ef2f-432e-a833-537e8e5c0145"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("937ac073-946d-4cee-8c9d-1afe8784162a"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("94b538cc-d6d6-4de1-807d-0b9fe75bb982"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("94d8853d-1c4c-4d12-a47b-1ec02ce345d2"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("9533cdbd-ba73-4c1b-aa68-c395ff6875d8"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("95698810-834d-4f25-89bf-3d5aecd88502"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("956d8a84-e53b-4b6b-87b1-666569921f09"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("95d83f41-7f1a-49a9-9474-51934391774f"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("96177c8b-4715-4e7b-8cf5-a3a7a2f4033b"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("962f6fc2-3628-415e-b843-cad6b34aff0a"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("9661c9c9-f9e5-47ce-bdb6-9558ca15ba06"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("96ddca87-abe6-49e5-ac5b-1e85f3b9d03c"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("9741f437-81ab-494d-8b6f-b2c9eb2f48b7"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("97811313-e5a4-4427-931c-5ff3f5ca00b2"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("9897f01c-f90e-4d13-863f-65c979de732d"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("98f79a68-9aef-4110-904c-7c09d42aac3e"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("991491ff-4dce-4c6f-a2d6-d70cf30c6adf"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("9920e1d1-0515-4d17-a92e-5a47acc1ac31"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("99369fba-26f0-49de-8ee1-4343bf0c60ef"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("994a94f3-eb7a-477d-bc0b-00e5fc7c229a"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("99501e4a-406a-49cd-8e50-1fdf519e1a38"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("9a41069f-434f-4344-a84b-b98e4c8d4029"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("9ae0a20e-364f-4f5e-91d7-d28e13de5a00"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("9aec1bd2-465c-4ca7-b0b0-f0d7a0a533b8"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("9b842efd-527c-4ea7-a2b9-ea75844776ed"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("9b8c533d-9305-4f5f-9f83-f3bce7985f0d"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("9c2212a3-4dd6-454e-b570-c6e8d5d22211"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("9cc32e19-2876-4a80-a3be-1bb0207ed19c"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("9d23f16d-21a2-4a26-aab5-da49eb6f488e"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("9d280ead-b69b-4a41-9c12-ddae243c75ca"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("9e5f627d-af75-4972-b82b-9c5ceb705150"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("9ec9ca09-de57-4de7-aedd-43203dc9a903"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("9f0cc7db-d3c8-4b65-b546-387d16bd1b6a"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("9fa030f0-29cd-4a03-90de-188a282a4833"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("a0317d77-351e-4660-90b2-2b978a90d3e9"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("a05d8d44-a2dd-4fc9-89c8-f126af9db7d8"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("a086379c-51fc-42f8-848b-5fba66378ba4"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("a0fad794-507c-4367-b721-17902b17f8eb"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("a12e0925-3153-4a0f-98c8-3186fcc3b673"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("a13f7268-6410-49d5-ab27-335dc94125db"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("a18f0d47-c186-49f8-934b-d8cac6e5992c"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("a1908a65-9764-4821-ae3b-4a053ae5793b"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("a199011b-38fd-4b96-93f2-e269aa755f16"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("a26e9190-02c7-44f1-93d9-f689c258e93b"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("a2fdd6c6-d748-43c3-a4ca-98a46376b28e"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("a2ffc8e9-316c-4e93-8d3a-d885a22a02de"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("a3137c9e-b2e2-4eed-858b-c70f287b70c3"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("a385ceb4-b6cc-46b4-8033-f6e305d76560"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("a3a7877f-3681-4870-b78a-489838eab71d"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("a3f41c72-11e2-4fde-88c7-88011ef52342"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("a4037797-81e6-43d2-a48f-76171e7c6c9e"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("a405ca26-1589-47d5-aa60-f432fc4a3dd7"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("a40d7952-f3c0-486c-b9a2-e4e5711c22e2"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("a43939ca-f795-4a6d-8fcc-e02c4981e254"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("a4d69654-84cf-49a2-8043-1c20647c9cf8"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("a4eeaa93-5b7c-4983-b3d3-120a70fc189f"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("a53afe08-481b-4e9c-8b63-f097e05a4e3a"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("a54e2542-81ef-4547-a2c0-5a5397cc4a18"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("a5c069e1-f7e1-46f0-a4f0-ed46057fd7b3"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("a65a4018-e551-40de-8d15-cce8f5986fb8"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("a6630a7a-984b-4aac-9085-6003201e77ad"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("a668be51-f794-440c-ab4f-d6416982ca2a"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("a6754fd8-37db-4a12-820c-3932306376c9"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("a688a146-3dda-458e-955c-0c18d0140a35"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("a713f8ba-6108-470d-91f0-acbc2cb15122"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("a726ee39-a4b6-4b2d-b9d9-661186f7e262"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("a73fe73f-5a4c-412b-9030-0eb12c7895c7"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("a761d52b-db5c-43f2-82b5-fc4b361f8bc8"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("a7927a58-7b01-4af1-86a7-d267e3dd23f9"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("a803587d-de77-4fb0-9823-743f3330e0a1"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("a822e3db-c9b0-4cfa-b0aa-888d85f114aa"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("a825e922-a61b-469a-ae0d-8ed63181aa63"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("a88a5726-6185-413c-8aa6-2c3d33078e39"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("a8f19574-bcb7-4a67-9d7b-827debe9d13b"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("a9543c8c-bd75-4666-92f7-08fd0d2379bc"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("a9551270-4ef4-49cc-bc0d-753c21b62826"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("a981b997-132b-446c-8710-101f42e13d1e"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("a9871b35-7153-4ca2-9910-aff3dc744018"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("aa025135-8399-42ea-bffd-ab5184c3093e"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("aa50ffc8-d51f-44e8-b3bf-417c25ef4b49"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("aa849050-3dd7-4342-8602-bc430f541171"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("aaba0a7b-ce8e-4da2-92b3-9311b533abe8"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("aad087ae-e3d9-40e4-8b77-cb0a1836fc58"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("ab368442-8f1d-402e-bf28-66e93ef5b035"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("ab3f6b7b-a46a-440b-ba5e-e8d98eae6176"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("abae36ce-e01a-48d3-8b56-527e8a129a17"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("abb81c21-5be4-452e-9013-8e4aff147a2a"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("abe4c4a8-a419-41d5-85ee-45071c6fcf43"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("ac3237f6-4fdc-454f-ab88-5cec5451325f"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("ac59a5f2-de20-4865-867f-44cdd4ca8b40"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("ac89f9b0-b981-477d-bb00-7cfc8287098b"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("ac96bc6a-c2e3-4ce5-b434-35d4838939b3"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("acb36f7b-04ad-4486-a3c6-abb771e655c9"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("accb094d-cc9a-4018-92d3-019866b56ab1"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("ada43566-d5da-4024-9843-ba9df826af76"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("adbbdf69-ea8a-4a66-9584-e609eeb40f44"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("adec34e3-6a68-4cbd-8652-b4cd979bcfec"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("ae1db8c1-88ce-46f0-b918-ebfcb7b472e8"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("aea13a1c-7a41-4e43-b935-d36c4f772e92"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("aeffcdf3-0198-4ef7-a5f1-83cb5905aee8"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("af1fa1aa-21b4-4ed3-991b-57897fa7a896"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("af59e68c-82a6-48a6-8cc8-972f05d1774a"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("af9b41f6-08c0-49ad-9716-cfa63ed84d6a"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("afd7e555-da07-4608-84c9-4642f770c9f6"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("b09de4c8-7c1b-48ac-a088-5696f2180ee4"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("b171e908-6df1-49b2-9e18-286ee4d6abdd"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("b1a75ff6-3f2b-4ad5-a3c9-18f8ab7f6736"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("b1df11f2-6881-4499-8dbf-64ce346c5e83"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("b1fb2bf7-ea2b-411b-942a-9c098cb3bc65"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("b20b23ba-bf11-495c-ae89-1519b820b579"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("b24fd7f3-4f18-4854-8e12-31071850b239"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("b25994af-9fd9-4bf4-92d7-62674227b0a2"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("b26ddfcd-8e81-40af-9084-b46563d13791"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("b281c591-ca1c-4820-aa97-8d49f40969f4"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("b28a27a3-9971-4911-9714-2e192079c34d"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("b29dd839-9b49-4562-9502-0e4d82501423"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("b2e64e01-57ef-40e0-96e4-ce6c6523e710"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("b30f6200-adce-40fc-a6d9-d32e400fde7a"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("b32bd220-dd3f-4d3e-bd89-a9b17c4bfee9"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("b32e72cd-23f5-429e-ae4c-1a14559f00d7"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("b3ad5d18-84fd-45ce-b3e3-e0acf6831ec6"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("b3c2df51-b309-4193-b56f-e39b8c713496"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("b3f564c4-96f9-4947-83b0-e267d0ac6c6e"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("b3fcb3e5-9a1e-4df7-8b1d-c27308e6a7b4"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("b43a72dd-0686-4548-b932-fd4738137de7"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("b4c1bc6f-dc37-4a20-a137-60f9cd33d879"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("b515c04f-1f38-4d4c-976b-84aaf5b7aa66"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("b550392d-3316-494c-80df-21c5b4eafa4d"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("b5559d8e-5f38-4aa1-936a-c4e823857396"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("b5616e15-224e-48ad-8a91-7aedf2a16a17"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("b57357a6-c798-40b9-96ec-38ade5fb347a"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("b5a0fc14-df90-4141-a55c-a22943ac2bab"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("b5dd4719-8a14-4e6c-9679-4093f5ba1d3c"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("b62d716e-f174-4d2a-932b-470e09527f57"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("b675a554-fd89-4abd-a6f5-7eae83649cf7"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("b6762d3b-541e-48c2-b2c6-4d8ea77e2631"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("b70c6d0e-acd6-4a98-a919-438a2ce4878d"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("b7192efe-b2a8-4070-96de-7012d8083011"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("b79acdf2-79a1-44d5-b1ae-887df07140ec"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("b806f4f2-bd44-4dc0-8d5e-3a29aa4a2815"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("b88018a6-ba00-4dcc-8ccf-10d07ede295a"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("b94893cb-2837-4368-960b-aabdbc47f411"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("b98370d5-a7e8-4e28-a967-fa4f4cc2d233"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("b984e5a1-35c8-4400-8ea5-c1fc60e5b54f"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("ba6b9d6f-d3e5-4293-811e-979b81eb7210"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("bae62933-59d5-4954-b890-b6bd2d005496"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("bb81909e-7f29-4aec-b448-8facb323b0d0"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("bc3cc5ad-2932-4ff9-ad2b-1977e6e83b02"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("bc5e2fa4-4552-4475-901c-0d36d084aaee"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("bd5c6401-e604-4209-b835-d8e71d8a0402"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("be3c32fd-364a-48f2-b727-57bb90c1defb"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("be7ecd77-8890-4091-9812-36b6596ccc00"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("be994fa2-93b4-4374-b089-69a2f3a2377e"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("be9f42f7-e5c0-49e3-a2c2-5a6791b22333"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("bed3e96b-5765-4254-ac54-646f6c7f13ba"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("bf13a469-6522-4471-a8fa-a910bf911b5c"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("bf365d1c-962c-45a2-9ed0-65e7892e3dae"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("c0aeb7a9-a59f-417e-9335-ca302832fdf7"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("c0c24256-7abd-45fa-9b58-5ae7db4dd5e1"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("c1205d8d-371a-433e-b1c8-f1fa119800d9"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("c12245a4-f2a6-4ceb-9a49-2c305e8617c5"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("c133e679-cc9d-48a4-a895-7a3955c8a82b"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("c18b0593-c318-44e5-8790-e5e171b29305"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("c1a4b963-3190-42f6-8539-1eb6a178da4f"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("c1d00401-dbb7-459a-b2fa-2ff68caa1d2a"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("c24745dd-7ca9-454f-8efb-d16bfc1c0b02"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("c2aaf223-b165-4fc3-838d-1287144e9f31"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("c31fe5a6-81c0-4eb1-8cd6-e3bc5e152011"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("c3214fbb-8c37-4c65-aae4-812887cd67f7"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("c344d843-6252-4da6-899f-bb59e684546b"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("c37616f3-3400-4d89-ae47-b0f43a034f8e"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("c39d7908-65e4-43bd-a928-f6cb10114721"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("c3b59758-83d7-494c-8e94-d06ae858dd28"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("c3c74aac-3217-41cc-aba9-6da93b60912d"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("c4b4cb7d-cdaa-4f93-ba4d-15f267e289a8"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("c4c5063c-704d-4e74-a3f5-ed998e533e14"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("c4c8d524-0741-4012-b39b-765f75b94563"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("c4c9bbde-56aa-42e4-a52c-6a8413eacb22"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("c505c0c5-f1ae-4964-82b4-266bee97d56a"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("c543cc8e-6d07-4f50-9f36-8e0c21df451c"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("c5a106e0-9732-425f-a5a9-a6d424826257"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("c5b10fcf-089e-4d51-8509-51b5d4c9ed1c"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("c5c7a201-04a5-406f-b3e1-256975a80cec"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("c5df6e34-d434-4c31-8c59-beb1811d2997"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("c5dfe0e9-a64c-4af5-a2ee-0e58ba4a3804"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("c5f993b4-a699-485b-baf9-aa0bdca159e1"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("c60765e0-d803-4696-9c8b-0bad830cc7d7"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("c612fba2-ac1e-46f2-b17e-022347876c10"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("c62af715-b279-42c4-b1c6-db43de9c1f18"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("c6b2d9ce-bfee-4a9e-81cd-5935db805600"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("c6cdaea4-e042-44e0-a90e-d45f22dbe74c"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("c718e192-963d-4df7-abfa-d2831a9d1d52"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("c721dde3-9cf3-4398-9a81-ffd7e5f3b51d"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("c738dfba-e7a6-4ac0-b991-72347f1c8161"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("c75e6e4d-5719-42ad-ae08-589445a6cec1"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("c76b009f-b54e-4cf7-b677-d49c7a52a8f8"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("c7b4d2ae-d821-4c49-896b-a551f6ec170f"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("c7c994d0-4276-465f-8750-6f9a6afd5529"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("c7c9afa6-2503-4201-bdac-58ae6b039524"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("c7dcc0af-7a77-4f4e-b9aa-5dcfa76bc147"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("c85db957-137e-4543-8486-8d0f4a6227fc"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("c879074e-4290-4174-b919-cf948d3972c1"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("c8a5760d-f276-4b3f-b353-1831b121df81"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("c8b69526-936b-4708-9372-25360bb3acfb"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("c9239a63-fbb2-4133-a78a-e3a1b97c4d3b"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("c9ba41aa-bc55-43f2-9430-186f3fde9e15"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("ca23a047-ea18-486f-9af3-44ca5be4f813"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("ca2fd475-481d-4b10-be71-d1868b8c9356"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("ca57387d-a073-4138-bd77-00cff8328172"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("ca609860-5f9e-499a-b26d-930305f0404a"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("ca65c697-3052-46a4-b412-2c9bf527965b"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("ca81006c-e34e-4cad-8ed2-919a0f220033"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("cacb16d2-9ca2-47a7-801e-38e5655df80d"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("cb2b8277-11be-41e8-82f5-9443bfcb70da"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("cc1751f6-945b-4cfb-a26e-e3985e0f0817"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("cc200a4a-90f6-478f-8926-8a4196677cbf"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("cc6eeb01-cd55-4177-ae5b-e349bd62d832"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("cc950e2e-d7a9-4a47-a57d-b2f2a5282104"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("ccd83e44-e8b5-45a0-a511-ebcd729e09dc"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("cd0a5e3d-e851-4620-8e54-9ee4fd4828c2"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("cdcd15e7-209f-40c0-86d8-9e93d68ca4e5"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("cdee5598-5428-4ee5-9c20-6e8b061aef75"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("ce3948bc-6652-441f-9b1b-961527c6f68a"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("ce484e2b-2398-49d9-9a0a-90d36eb96dcd"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("ce4c5460-79c0-41da-8320-9d1f06b5cb28"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("ce6be59c-155e-4f8c-a56d-2a568488333d"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("ceb5685c-8945-47b2-a793-b50995915c1a"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("cf2377cb-3506-4342-9be0-8badd7aca83d"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("cf2be43c-2911-4e19-9a47-deedf3062f32"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("cf993e4a-0645-450b-96dc-34acef322284"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("cfb48caf-e097-4255-8486-a24f3748d045"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("d087c4d8-0a49-49f8-90b7-98a0657e671b"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("d0cb151b-0d71-425c-a990-ec53fd29f203"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("d1c0634d-b592-413f-98b5-fea0b1722a4a"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("d2245d1f-f212-4c4e-87b6-d7a23299a063"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("d2572ac8-9d68-42de-b156-861c131d8147"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("d26572f2-f19a-44a3-9171-8ac75e570d6c"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("d2a55379-f670-46f0-9687-b35ee86ebbcd"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("d2bb5d1f-1e33-4e7b-96d8-b7d59ccb146c"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("d2c5ebbd-fa64-4946-84fc-900526752799"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("d2eb21f8-14e3-4d24-a67f-0e4078a6f646"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("d30ce76e-1fb0-4d41-a308-a9eb27a61698"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("d328339f-1e60-4949-89dc-7b2c2794fdae"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("d34f339a-5fa9-4c78-bcc7-74ef0eaa9675"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("d376b757-7f36-486e-9923-db33bd77e2cd"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("d39d2f9d-9b6d-42c1-abe2-ae93a388af28"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("d3c47218-73ca-445d-aca5-63389f2e1e8b"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("d41a7f34-8669-4ea6-9f31-99424d220266"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("d43ad864-94e4-4f5f-aca2-a8428f0da423"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("d49a8cb9-2871-4f59-807b-b3d5623366a6"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("d4faa3b3-d260-4436-9fc4-aa0592780041"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("d525ae1a-8ef7-4767-9c36-8583293242e1"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("d61e6b2a-eb5b-46ac-acaa-1be58a4bbc17"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("d6309311-5295-4d9d-94d9-16983e3b4514"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("d66c73ab-da3f-4fef-b009-66c5db09837e"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("d6a0cde7-72f9-44f1-b36d-3da81a62630a"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("d754260c-0e1d-4b03-9f35-d8e4aeda55ba"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("d7a1a647-d74a-489e-9979-bb92b6a48cbf"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("d806bf29-4463-438a-a413-7c9a36b4c138"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("d84f22d6-9a1a-4b35-a019-d8e8bc51d40c"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("d861748b-80b2-4e1f-8fcc-99fa642dfa9a"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("d953d75d-1ee4-4261-932f-e109a24e7d84"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("d97fbc73-1b9d-4dd3-a60e-19645f9202f8"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("d9979f2b-1cdc-4654-ad12-b2f3d74b9cd3"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("d9ded2f6-579e-460b-b9f3-f0043b51d38a"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("da9ee688-6226-458d-9d5b-20ec5bcd2d39"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("dabf441b-db98-4af2-90a0-1a5eab58515e"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("dacfbde5-53b3-41d9-a07e-43ac65b9c34a"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("daf1ca75-4f63-43a2-81f2-d79c22df7a29"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("dafd0bfb-285b-4c9e-93e2-3aa9ab331c5d"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("db30adb2-739d-4cbe-a4c5-d748f7c2a223"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("db4dd5df-c5cc-484d-94ca-52039ecf02e1"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("db5408d4-94e1-45f3-8e35-0e9590fb08df"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("db652a1b-3ad9-4935-b2bd-1e24ebca9642"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("db78cf6f-6479-4819-a001-6faeeaac0dc8"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("db7d9446-1340-4060-a38f-807e0e54f517"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("dba4df60-ea13-4040-97d7-71e59874e438"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("dbde5351-384c-48a4-9452-6c14f765090a"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("dc3b7530-a813-4e91-8d72-799bbb282550"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("dc3ebec8-b11c-4899-aaeb-27cd859a7062"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("dc6d0029-9196-4ec4-b43c-900d551ca376"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("dc7a9886-4a75-4497-ba5a-b67b89ffbcee"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("dcaf3e45-7a8d-41fc-b9ca-698c510465fc"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("dce1fcff-536f-4137-9c05-d75f6bf8ed39"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("dd315146-eb7c-4bd6-9dc0-f8ebf86085ec"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("dd79b456-95e8-4397-bb75-6ea762f927dc"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("de25793e-a4d7-4c1e-937b-547de8a7e779"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("de2fccd0-a179-44ed-91d2-a42c9c3d013c"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("decb882a-cfa9-42f0-a451-90aab98a56c9"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("def96fd0-41ea-4076-a29d-6d1043d7b3ca"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("dffec0db-c3cc-4c07-974c-622c27472fdc"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("e016d2bd-9c36-4a21-a718-dd6740dc9c01"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("e0260001-23d9-4cde-826d-9dee68d54ae0"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("e10c9fd0-b7bc-4ebb-a9db-f924b328d5ae"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("e18574d6-a72b-4130-9e4e-fada49bed1e2"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("e18ee184-e536-4d1d-81cf-42016c26fc38"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("e1f86b5a-50e5-451d-aa8c-abc62e4de743"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("e22638e1-9de7-4756-998f-4e76764e6d92"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("e2a02355-b171-4f1f-a076-8345ca4cb24d"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("e2ee7ce0-6781-49b1-8265-a55b178de4b9"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("e368c8b3-c1b2-4e76-82f0-a7eb649899f4"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("e36abafb-d16e-4908-b838-64a905ae2bff"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("e39ae9f1-d2e1-4dd4-ae8e-4d8be43012f4"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("e3b0b355-851a-4755-b30f-347316f3aa47"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("e423de84-5514-4068-a79d-fb0f4e072ef8"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("e4e891eb-b473-42e2-995d-90c73d81e9c9"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("e5481398-f232-4fd1-b432-19fb7d59db16"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("e586d5b0-f8b9-4403-9500-fe8677063cf2"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("e596abcb-c7d7-470e-b593-0e3b0cd4f656"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("e599e8f5-2dad-4c42-a77b-47fdf780b18d"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("e5ad6d40-485a-4b14-8a24-b8392c0fdb12"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("e5d04925-664d-4205-a632-a809e973fbed"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("e6017569-404d-40d3-98fe-516527d498d8"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("e6713c19-4d26-4803-b8d3-37fca4200a08"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("e6984bcb-77cd-47d4-adf8-f82255bbe794"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("e6cd272b-250a-4b9e-a1c3-3914b701f52b"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("e6ecbdcc-d1c8-4ebd-aaba-b452b58a1ed6"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("e6f0164c-9b2d-4ce6-af5a-b10bc37697b9"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("e7674d7b-04c0-4dd1-a8b2-da20ed168977"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("e787905d-cd1a-4641-9049-e2ccf00c9fb0"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("e792df26-ace5-4276-8175-c31c3310b36f"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("e7ced068-050c-4b8b-8e90-91e2534d18ab"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("e7d09c3f-157c-4d4a-aeb6-654be19df83d"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("e852eb93-1705-48c9-ba27-85f1564d0723"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("e9914ca2-9bbd-4c71-988c-0fdbab487016"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("ea0e3b71-e599-4fd3-a67f-0c118c32dc66"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("ea1946b5-057d-4c86-9ef1-1d1c5814edb2"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("eabb66c8-ee6f-4fe1-a17b-5b72e27afc97"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("eb266138-4ad2-498d-bed1-0bc2718a4422"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("eb4737b6-10f6-46c8-bb90-d110fe95a0b6"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("eb4dca9a-415b-4830-a33c-2aa3f20e970a"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("ec2cb267-df32-4329-aef1-f4962d7c94a6"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("ecc2e147-90db-4f6e-aef0-01765e457c8c"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("ed53fc9f-18da-45ca-b935-6a74b1988278"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("ed69c800-a352-4ce7-bcee-4f4f0bda974d"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("ed7fd4a2-3e2c-49f2-ad6a-669ca97e4978"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("ee7e380f-09b8-40dc-add0-fdb8356d78ef"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("ee9e2c07-902e-41d2-a21b-11189aeb2e3a"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("eebfeb34-9138-44a9-9f4a-b81d61e584d5"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("eecf0b02-5803-4f5d-a606-f9a20b5f344d"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("ef127f40-32c8-4d0b-af7e-d98bb3d2ed94"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("ef4510f0-6cd1-41c1-9a10-5543c35fae15"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("ef6b7b66-7ac7-433e-8c74-3696782b0a03"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("efd0d9e5-4adb-4317-ac26-a92e19e6b457"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("f0823772-cb94-4856-a517-319966008753"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("f0a5e1b7-7858-4f21-9b8d-0abd0c989c4d"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("f0b8ee33-f191-4adb-b34d-b2b85dcd48fa"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("f0bda719-84ae-43dc-8891-bccad7a61df7"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("f0fd4453-5c0f-41ec-a4d9-f56e9ff161d4"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("f10405c2-bf3e-482d-9524-9ae0228b31bc"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("f175fdcb-51bc-455c-b57d-8413048ea486"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("f19b26b2-c018-4727-b820-df207f99a252"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("f1a363dd-9dd1-448e-94c4-5bacf3450973"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("f22e3fb1-212c-4fdf-8b8f-9eba284ec67f"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("f240c46e-ae96-414e-ac40-2ee78e3f179d"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("f28f4fa6-2bf6-48e9-9460-5ff7ba383d20"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("f29d4de7-365e-4161-9bd3-0fdd4ca56297"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("f2de4bbc-af68-4ce5-8e9b-de03104c2b4a"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("f3b002c2-02bf-44cd-87b0-103389448deb"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("f3f32d93-c356-4f94-8cfe-5aa5de0e0fc2"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("f4285cf8-e8ec-4d83-b908-fe8924f94462"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("f45213b3-d1e9-4840-a749-a2fd9cd4ec11"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("f4bc6001-0e59-4633-b0c8-fdc4de543448"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("f4f250b7-0ece-4fdd-87b5-a60e15dbbd96"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("f545c662-23a2-4518-a332-020ba91962a2"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("f593b7ea-f6d5-4dac-8017-ecbfbffb93ba"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("f5a44339-b5b2-4523-8ed2-09a55f9fe6ac"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("f5bda226-69c9-49f5-ab8b-cefee586564c"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("f5cbf40d-9563-468a-9b5e-8c5ed4dd26c9"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("f5eaee75-afff-45e9-af08-b2520b0c33b4"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("f617340f-4180-4415-be99-d91d92ae2efb"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("f64ef84b-e474-479d-8259-58f093ee0905"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("f650d6fa-d3ff-4946-a1a5-29b2612ccaad"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("f6798afa-4414-4ae6-bd5b-8e02c0f57d72"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("f6858a45-6d47-4345-99d2-c0fcb24f6f81"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("f6db7a7b-593e-44b8-93b8-10a2c32bff1a"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("f75420bb-6f4b-4c4a-8da9-538fbfa7c738"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("f851e8c0-bf14-4206-b714-cef157a2c7a9"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("f86b02df-6ac1-4773-9910-a84698274aa5"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("f88c56d3-77f2-48fd-90f0-1a19008852ea"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("f8a69e81-b646-46a5-b2d2-e140011fb877"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("f8ac2101-aac7-407c-84af-f306c033fdbf"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("f9187369-caef-46a4-a9bf-ffdf996321c9"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("f95de228-8512-41fc-87e6-1bf62310ba59"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("f96cdc55-6d6f-4dde-8f8f-c4558d2d8d15"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("f9bd73cf-f228-4144-8707-d4cfe5ba54b5"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("f9f2871d-091c-44e9-adbf-32ae3b3c4439"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("fab8c0d2-9970-4675-a9a2-1a7ec09e41e1"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("fae9e72e-bc9f-4502-b977-3f18925977ee"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("fb6a61db-eed9-4be4-ac02-a2c4040a188d"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("fb9bf142-a30d-4795-8b06-aca6d6a8bbc0"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("fbecf67b-3256-47da-b2aa-fd9b2349749d"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("fc853e86-8ea0-4384-b363-7ef44f440848"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("fcf03135-0d94-4fd0-890d-6d08d0425789"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("fd1a3447-7c69-48e3-8fbc-d913fcfff594"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("fd28bace-42ed-44a6-814b-4f97c42d8b9d"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("fd6209d2-1aef-4333-953e-bc9617832cb1"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("fd7f3e33-4dd1-4302-80f5-2603013ad26b"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("fdd647e9-eab2-4b6e-929b-748a2a70b503"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("fe149709-d779-4fc0-8341-5af2b1286591"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("fe19fe85-abff-4382-ac64-044e08493b4c"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("fe35be3a-56af-48e9-abea-6a7cd2ff4ff6"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("fe75f6de-9e85-41c0-a31a-1ddcb1bb9e99"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("fe7cf9f6-bf80-4261-a0ea-ead2e0d16e6c"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("fe9914b8-823e-4e03-b5e6-afce55dfd9a2"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("fed953ed-c5f2-40c6-8aaa-e172833cc759"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("ffda40c4-bd63-4223-937c-f6eea9391040"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("83cd26b0-6fcc-47e4-ac26-181f60fae47a"));

            migrationBuilder.DeleteData(
                table: "ParkingLots",
                keyColumn: "Id",
                keyValue: new Guid("04b75293-d378-4ee1-b298-9f723aa1e4bf"));

            migrationBuilder.DeleteData(
                table: "ParkingLots",
                keyColumn: "Id",
                keyValue: new Guid("0e1cf06a-2c1f-4f3a-804f-0a21ca76a827"));

            migrationBuilder.DeleteData(
                table: "ParkingLots",
                keyColumn: "Id",
                keyValue: new Guid("0ea2b9de-200d-4f13-b796-bd86c412194b"));

            migrationBuilder.DeleteData(
                table: "ParkingLots",
                keyColumn: "Id",
                keyValue: new Guid("13d8bc75-3ef2-4d55-a2bd-ffc7a683e7e4"));

            migrationBuilder.DeleteData(
                table: "ParkingLots",
                keyColumn: "Id",
                keyValue: new Guid("14f021ba-4e08-416b-8751-e5d09e9b107d"));

            migrationBuilder.DeleteData(
                table: "ParkingLots",
                keyColumn: "Id",
                keyValue: new Guid("15e5b2e9-d51f-4413-9a87-0a8051c82ff4"));

            migrationBuilder.DeleteData(
                table: "ParkingLots",
                keyColumn: "Id",
                keyValue: new Guid("18bb3ced-ef4c-4990-902d-9ccdbee03709"));

            migrationBuilder.DeleteData(
                table: "ParkingLots",
                keyColumn: "Id",
                keyValue: new Guid("30fd900a-27d9-4682-b5e2-db8c76e2062b"));

            migrationBuilder.DeleteData(
                table: "ParkingLots",
                keyColumn: "Id",
                keyValue: new Guid("40448bf3-c284-402d-a1bf-7593c2d267c4"));

            migrationBuilder.DeleteData(
                table: "ParkingLots",
                keyColumn: "Id",
                keyValue: new Guid("47569aaa-bf51-4525-832e-9153120d433e"));

            migrationBuilder.DeleteData(
                table: "ParkingLots",
                keyColumn: "Id",
                keyValue: new Guid("4bbdfefd-5984-4fd5-ad27-04ef0d85ef60"));

            migrationBuilder.DeleteData(
                table: "ParkingLots",
                keyColumn: "Id",
                keyValue: new Guid("564ba9ef-c816-47d7-a41b-a7b061183905"));

            migrationBuilder.DeleteData(
                table: "ParkingLots",
                keyColumn: "Id",
                keyValue: new Guid("60bf0a3a-02aa-4218-8e61-a5dd00e5e0d4"));

            migrationBuilder.DeleteData(
                table: "ParkingLots",
                keyColumn: "Id",
                keyValue: new Guid("6834e8ac-9efa-4f21-a027-d8ae1c1b973e"));

            migrationBuilder.DeleteData(
                table: "ParkingLots",
                keyColumn: "Id",
                keyValue: new Guid("76a04e41-7aa0-46e2-8c27-0b677cde6543"));

            migrationBuilder.DeleteData(
                table: "ParkingLots",
                keyColumn: "Id",
                keyValue: new Guid("7fd19919-4f47-4257-af41-0eaf6d2f3533"));

            migrationBuilder.DeleteData(
                table: "ParkingLots",
                keyColumn: "Id",
                keyValue: new Guid("88c0746c-384c-48a3-8a24-034a9d11e036"));

            migrationBuilder.DeleteData(
                table: "ParkingLots",
                keyColumn: "Id",
                keyValue: new Guid("8eda8dbd-513f-49c9-a050-7c8a6e6475d7"));

            migrationBuilder.DeleteData(
                table: "ParkingLots",
                keyColumn: "Id",
                keyValue: new Guid("9ef7200f-cd79-41e9-ac2b-c0215f0fc9fc"));

            migrationBuilder.DeleteData(
                table: "ParkingLots",
                keyColumn: "Id",
                keyValue: new Guid("a2702078-cb6b-4d1d-a83a-640674eeeffe"));

            migrationBuilder.DeleteData(
                table: "ParkingLots",
                keyColumn: "Id",
                keyValue: new Guid("a4cc4c37-d39f-4d36-9a60-2d6404fc97f6"));

            migrationBuilder.DeleteData(
                table: "ParkingLots",
                keyColumn: "Id",
                keyValue: new Guid("ab2501ec-a3d8-4027-98dd-df99be5a1bf9"));

            migrationBuilder.DeleteData(
                table: "ParkingLots",
                keyColumn: "Id",
                keyValue: new Guid("ac8d075d-9942-4f4e-b98f-e8df09ce60d3"));

            migrationBuilder.DeleteData(
                table: "ParkingLots",
                keyColumn: "Id",
                keyValue: new Guid("ae3959c4-5bca-457d-9c14-4cc88f49d61e"));

            migrationBuilder.DeleteData(
                table: "ParkingLots",
                keyColumn: "Id",
                keyValue: new Guid("b202d20c-9aca-47ab-8c0c-417b0566bc9a"));

            migrationBuilder.DeleteData(
                table: "ParkingLots",
                keyColumn: "Id",
                keyValue: new Guid("b74f87ee-301c-418b-a49a-4a8ebe631eb8"));

            migrationBuilder.DeleteData(
                table: "ParkingLots",
                keyColumn: "Id",
                keyValue: new Guid("bf2771a1-c2c5-496e-beab-9667afd9bbfe"));

            migrationBuilder.DeleteData(
                table: "ParkingLots",
                keyColumn: "Id",
                keyValue: new Guid("bf471c98-2465-4e39-b3a4-a0a56d7f0b0c"));

            migrationBuilder.DeleteData(
                table: "ParkingLots",
                keyColumn: "Id",
                keyValue: new Guid("c5d2c35b-c774-4f68-bc8b-4b23482c4244"));

            migrationBuilder.DeleteData(
                table: "ParkingLots",
                keyColumn: "Id",
                keyValue: new Guid("cacdb08a-111b-49ab-81b8-13817060e4e8"));

            migrationBuilder.DeleteData(
                table: "ParkingLots",
                keyColumn: "Id",
                keyValue: new Guid("cdd98f54-2de4-464d-912e-488674be6f46"));

            migrationBuilder.DeleteData(
                table: "ParkingLots",
                keyColumn: "Id",
                keyValue: new Guid("cfeefc53-67a5-4e6a-a136-330d10920937"));

            migrationBuilder.DeleteData(
                table: "ParkingLots",
                keyColumn: "Id",
                keyValue: new Guid("d76e484e-5fd9-4cf5-8892-f4fcf44654fa"));

            migrationBuilder.DeleteData(
                table: "ParkingLots",
                keyColumn: "Id",
                keyValue: new Guid("d7bcb6e9-67e9-4afc-9d25-f169447500eb"));

            migrationBuilder.DeleteData(
                table: "ParkingLots",
                keyColumn: "Id",
                keyValue: new Guid("dec19efa-56f4-4a25-8590-7b1938391756"));

            migrationBuilder.DeleteData(
                table: "ParkingLots",
                keyColumn: "Id",
                keyValue: new Guid("e07be4a4-a28a-4d40-bd21-3371ef69fc0b"));

            migrationBuilder.DeleteData(
                table: "ParkingLots",
                keyColumn: "Id",
                keyValue: new Guid("ed42e83a-2e39-4c0c-8803-4b595c801a43"));

            migrationBuilder.DeleteData(
                table: "ParkingLots",
                keyColumn: "Id",
                keyValue: new Guid("f5e07364-5770-4cca-8215-4bc9687928fd"));

            migrationBuilder.DeleteData(
                table: "ParkingLots",
                keyColumn: "Id",
                keyValue: new Guid("f8fec2b0-96c9-47ff-be70-eee9e7195d60"));

            migrationBuilder.DeleteData(
                table: "ParkingLots",
                keyColumn: "Id",
                keyValue: new Guid("f92eb003-edbb-4752-9d08-baf8cf0be864"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("00fa5cd2-67e9-47c8-8fb6-0dcc30dfa0a2"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("0b249cb9-2690-4b11-b843-6eba44f29bd2"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("1b82eccf-26d0-453c-9baa-e7a13368407d"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("3a691238-5c25-497b-961b-95bfa0005eb3"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("40757a25-6631-4a87-8067-e5d9db334ad9"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("4103789e-6608-4ca7-bb7a-ecb24cfa4209"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("48a31950-1aa8-4c7b-ba24-6e7ea42f7ed8"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("5a141c78-82e9-4b0f-8722-24b3a54451aa"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("72ede12e-9ab7-460d-8c7e-10c7f4a274b7"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("7b1342ee-1fa2-4de7-983b-e4ae03b5fca1"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("7ee2e1fb-52a8-499f-b818-d849cdf5a60e"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("8ac4a4cd-181a-40a5-9d5b-b835c811416b"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("8d826623-83fe-4dc1-bbc8-99630934fcf7"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("91aa6884-1a46-4efe-94c6-f1bcae2ed5c5"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("964211e1-d57e-42a1-b54c-060918beb6bc"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("b01aba31-4362-42dd-856a-ed7f3f3e9866"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("c9fc9322-ba55-4dff-8d3c-5ea48d0fa909"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("e260c28a-7d6a-4b68-ac3c-8734e01a5e6b"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("f0f76762-5452-4c1b-9007-cf0eb50484e5"));

            migrationBuilder.DeleteData(
                table: "ParkingSpaces",
                keyColumn: "Id",
                keyValue: new Guid("f29b5e86-6f2e-4936-b8e4-c2696c52a927"));

            migrationBuilder.DeleteData(
                table: "ParkingLots",
                keyColumn: "Id",
                keyValue: new Guid("0b1a89a0-0f56-47cf-8cf8-6e15ec4f04ef"));

            migrationBuilder.DeleteData(
                table: "ParkingLots",
                keyColumn: "Id",
                keyValue: new Guid("0e6822f5-7394-400d-bca7-a4cc4dd28978"));

            migrationBuilder.DeleteData(
                table: "ParkingLots",
                keyColumn: "Id",
                keyValue: new Guid("2aedce44-d62f-4847-a9ad-2245b9d31387"));

            migrationBuilder.DeleteData(
                table: "ParkingLots",
                keyColumn: "Id",
                keyValue: new Guid("325cdcfb-5542-41fb-bca0-5aec0a1f8209"));

            migrationBuilder.DeleteData(
                table: "ParkingLots",
                keyColumn: "Id",
                keyValue: new Guid("37b1553e-e0cc-460c-b0a8-d72fea93dadc"));

            migrationBuilder.DeleteData(
                table: "ParkingLots",
                keyColumn: "Id",
                keyValue: new Guid("454290bd-e2c7-4154-b980-cc091b14465d"));

            migrationBuilder.DeleteData(
                table: "ParkingLots",
                keyColumn: "Id",
                keyValue: new Guid("4f8943b0-c325-4306-8872-c0687a860552"));

            migrationBuilder.DeleteData(
                table: "ParkingLots",
                keyColumn: "Id",
                keyValue: new Guid("516e7943-059a-44cc-bd82-d4c4480a6676"));

            migrationBuilder.DeleteData(
                table: "ParkingLots",
                keyColumn: "Id",
                keyValue: new Guid("561ae673-4668-49b7-81ca-2fc792ab1b3e"));

            migrationBuilder.DeleteData(
                table: "ParkingLots",
                keyColumn: "Id",
                keyValue: new Guid("5a1062de-7895-4914-b081-cc7ff9e007e7"));

            migrationBuilder.DeleteData(
                table: "ParkingLots",
                keyColumn: "Id",
                keyValue: new Guid("66af1e03-1839-46f2-a5b1-999c4f3a5b30"));

            migrationBuilder.DeleteData(
                table: "ParkingLots",
                keyColumn: "Id",
                keyValue: new Guid("66ccfd45-4738-48da-ac09-400c1a1a26bb"));

            migrationBuilder.DeleteData(
                table: "ParkingLots",
                keyColumn: "Id",
                keyValue: new Guid("b1ad3048-49d6-4a9a-a0f8-d99e3f5f70f5"));

            migrationBuilder.DeleteData(
                table: "ParkingLots",
                keyColumn: "Id",
                keyValue: new Guid("b7048c17-53ab-4005-8a80-eed7f70c6c99"));

            migrationBuilder.DeleteData(
                table: "ParkingLots",
                keyColumn: "Id",
                keyValue: new Guid("c7dca08c-fee9-47a0-bb70-4dc53f2699d0"));

            migrationBuilder.DeleteData(
                table: "ParkingLots",
                keyColumn: "Id",
                keyValue: new Guid("cc8bb9f7-35ca-4c40-8498-8e83c25136cd"));

            migrationBuilder.DeleteData(
                table: "ParkingLots",
                keyColumn: "Id",
                keyValue: new Guid("d12f5883-ab8e-4d3f-a967-ec7675a0ab47"));

            migrationBuilder.DeleteData(
                table: "ParkingLots",
                keyColumn: "Id",
                keyValue: new Guid("e5dceac8-c4a8-4f0a-b51b-9a305ff65216"));

            migrationBuilder.DeleteData(
                table: "ParkingLots",
                keyColumn: "Id",
                keyValue: new Guid("eb01d97e-5919-4537-822f-2fff3c6fd84f"));

            migrationBuilder.DeleteData(
                table: "ParkingLots",
                keyColumn: "Id",
                keyValue: new Guid("f5882dab-e003-453f-b642-a38560da3beb"));

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
    }
}
