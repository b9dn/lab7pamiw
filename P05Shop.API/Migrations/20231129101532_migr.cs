using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace P05Shop.API.Migrations
{
    /// <inheritdoc />
    public partial class migr : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Barcode", "Description", "Price", "ReleaseDate", "Title" },
                values: new object[] { "5", "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 709.097133107994m, new DateTime(2023, 1, 11, 11, 42, 51, 536, DateTimeKind.Local).AddTicks(9371), "ut" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "Price", "ReleaseDate", "Title" },
                values: new object[] { "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 395.001609376632m, new DateTime(2023, 4, 22, 7, 3, 54, 274, DateTimeKind.Local).AddTicks(8605), "quo" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Barcode", "Description", "Price", "ReleaseDate", "Title" },
                values: new object[] { "3", "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 702.518694762382m, new DateTime(2023, 5, 28, 19, 22, 23, 33, DateTimeKind.Local).AddTicks(2658), "repudiandae" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Barcode", "Description", "Price", "ReleaseDate", "Title" },
                values: new object[] { "4", "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 693.668755019395m, new DateTime(2022, 12, 2, 11, 18, 14, 402, DateTimeKind.Local).AddTicks(2027), "voluptatem" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Barcode", "Description", "Price", "ReleaseDate", "Title" },
                values: new object[] { "7", "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 526.029559857226m, new DateTime(2023, 11, 24, 3, 38, 3, 806, DateTimeKind.Local).AddTicks(8727), "esse" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Barcode", "Description", "Price", "ReleaseDate", "Title" },
                values: new object[] { "0", "The Football Is Good For Training And Recreational Purposes", 245.962609125284m, new DateTime(2022, 12, 3, 2, 54, 18, 162, DateTimeKind.Local).AddTicks(3756), "fuga" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Barcode", "Description", "Price", "ReleaseDate", "Title" },
                values: new object[] { "5", "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 57.7898492826102m, new DateTime(2023, 2, 8, 10, 21, 5, 268, DateTimeKind.Local).AddTicks(2853), "ipsa" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Barcode", "Description", "Price", "ReleaseDate", "Title" },
                values: new object[] { "9", "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 988.892659404265m, new DateTime(2023, 8, 13, 9, 5, 32, 31, DateTimeKind.Local).AddTicks(8805), "fuga" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Barcode", "Description", "Price", "ReleaseDate", "Title" },
                values: new object[] { "3", "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 223.882037785315m, new DateTime(2023, 7, 21, 23, 53, 44, 185, DateTimeKind.Local).AddTicks(6633), "dolor" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Barcode", "Description", "Price", "ReleaseDate", "Title" },
                values: new object[] { "3", "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 476.020144769466m, new DateTime(2023, 5, 3, 22, 36, 8, 635, DateTimeKind.Local).AddTicks(4987), "et" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Barcode", "Description", "Price", "ReleaseDate", "Title" },
                values: new object[] { "9", "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 594.964523955232m, new DateTime(2023, 1, 24, 21, 1, 36, 918, DateTimeKind.Local).AddTicks(2439), "dolore" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Barcode", "Description", "Price", "ReleaseDate", "Title" },
                values: new object[] { "9", "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 312.227141921049m, new DateTime(2023, 4, 7, 9, 32, 48, 107, DateTimeKind.Local).AddTicks(9571), "aspernatur" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Barcode", "Description", "Price", "ReleaseDate", "Title" },
                values: new object[] { "4", "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 618.358974748924m, new DateTime(2023, 9, 30, 19, 5, 48, 821, DateTimeKind.Local).AddTicks(303), "aspernatur" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Barcode", "Description", "Price", "ReleaseDate", "Title" },
                values: new object[] { "0", "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 80.6260295047546m, new DateTime(2023, 1, 27, 9, 3, 51, 197, DateTimeKind.Local).AddTicks(2458), "fuga" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Barcode", "Description", "Price", "ReleaseDate", "Title" },
                values: new object[] { "6", "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 471.610621951339m, new DateTime(2022, 12, 14, 2, 37, 44, 271, DateTimeKind.Local).AddTicks(5183), "nesciunt" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Barcode", "Description", "Price", "ReleaseDate", "Title" },
                values: new object[] { "4", "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 366.261149519245m, new DateTime(2023, 11, 25, 6, 45, 22, 737, DateTimeKind.Local).AddTicks(8267), "commodi" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Barcode", "Description", "Price", "ReleaseDate", "Title" },
                values: new object[] { "8", "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 271.938482550876m, new DateTime(2022, 12, 18, 10, 34, 59, 421, DateTimeKind.Local).AddTicks(8712), "ut" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Barcode", "Description", "Price", "ReleaseDate", "Title" },
                values: new object[] { "6", "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 461.718092748764m, new DateTime(2022, 12, 12, 8, 47, 58, 923, DateTimeKind.Local).AddTicks(835), "omnis" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Barcode", "Description", "Price", "ReleaseDate", "Title" },
                values: new object[] { "4", "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 319.251068810584m, new DateTime(2023, 6, 20, 11, 3, 24, 100, DateTimeKind.Local).AddTicks(5035), "earum" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Barcode", "Description", "Price", "ReleaseDate", "Title" },
                values: new object[] { "0", "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 612.278680905364m, new DateTime(2023, 2, 28, 22, 48, 14, 928, DateTimeKind.Local).AddTicks(4306), "consequuntur" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Barcode", "Description", "Price", "ReleaseDate", "Title" },
                values: new object[] { "8", "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 814.14169213648m, new DateTime(2023, 4, 25, 23, 25, 9, 923, DateTimeKind.Local).AddTicks(7828), "voluptates" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Barcode", "Description", "Price", "ReleaseDate", "Title" },
                values: new object[] { "8", "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 822.374616404238m, new DateTime(2023, 10, 11, 4, 12, 0, 614, DateTimeKind.Local).AddTicks(9520), "sint" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Barcode", "Description", "Price", "ReleaseDate", "Title" },
                values: new object[] { "4", "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 654.18977049747m, new DateTime(2023, 4, 2, 2, 43, 34, 339, DateTimeKind.Local).AddTicks(5292), "sunt" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Barcode", "Description", "Price", "ReleaseDate", "Title" },
                values: new object[] { "7", "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 738.155003849489m, new DateTime(2023, 11, 12, 15, 49, 10, 387, DateTimeKind.Local).AddTicks(9290), "molestiae" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Barcode", "Description", "Price", "ReleaseDate", "Title" },
                values: new object[] { "1", "The Football Is Good For Training And Recreational Purposes", 43.6775831215445m, new DateTime(2023, 6, 8, 11, 13, 22, 5, DateTimeKind.Local).AddTicks(5045), "et" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Description", "Price", "ReleaseDate", "Title" },
                values: new object[] { "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 507.616215421639m, new DateTime(2023, 11, 21, 20, 27, 21, 105, DateTimeKind.Local).AddTicks(3768), "laboriosam" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Barcode", "Description", "Price", "ReleaseDate", "Title" },
                values: new object[] { "2", "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 910.785444308438m, new DateTime(2023, 7, 27, 6, 57, 38, 927, DateTimeKind.Local).AddTicks(6701), "velit" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Barcode", "Description", "Price", "ReleaseDate", "Title" },
                values: new object[] { "3", "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 84.0327789569426m, new DateTime(2022, 12, 19, 12, 46, 30, 327, DateTimeKind.Local).AddTicks(5310), "suscipit" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Barcode", "Description", "Price", "ReleaseDate", "Title" },
                values: new object[] { "4", "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 660.05177966694m, new DateTime(2023, 7, 22, 4, 56, 41, 145, DateTimeKind.Local).AddTicks(8801), "et" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Description", "Price", "ReleaseDate", "Title" },
                values: new object[] { "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 430.155933462156m, new DateTime(2023, 6, 7, 17, 41, 35, 411, DateTimeKind.Local).AddTicks(7569), "nobis" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Barcode", "Description", "Price", "ReleaseDate", "Title" },
                values: new object[] { "9", "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 126.71586487755m, new DateTime(2023, 4, 21, 13, 14, 49, 121, DateTimeKind.Local).AddTicks(9466), "facilis" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Barcode", "Description", "Price", "ReleaseDate", "Title" },
                values: new object[] { "8", "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 150.158714624196m, new DateTime(2022, 12, 8, 2, 2, 3, 53, DateTimeKind.Local).AddTicks(3303), "occaecati" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Barcode", "Description", "Price", "ReleaseDate", "Title" },
                values: new object[] { "6", "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 3.84736985426739m, new DateTime(2023, 2, 21, 1, 0, 1, 100, DateTimeKind.Local).AddTicks(2745), "at" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Barcode", "Description", "Price", "ReleaseDate", "Title" },
                values: new object[] { "6", "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 645.993864636865m, new DateTime(2023, 3, 18, 1, 32, 4, 935, DateTimeKind.Local).AddTicks(3469), "qui" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Barcode", "Description", "Price", "ReleaseDate", "Title" },
                values: new object[] { "7", "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 289.121948837359m, new DateTime(2023, 10, 8, 22, 12, 16, 399, DateTimeKind.Local).AddTicks(8876), "corrupti" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Barcode", "Description", "Price", "ReleaseDate", "Title" },
                values: new object[] { "3", "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 255.49067058018m, new DateTime(2023, 8, 14, 22, 11, 54, 67, DateTimeKind.Local).AddTicks(6838), "maxime" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Barcode", "Description", "Price", "ReleaseDate", "Title" },
                values: new object[] { "1", "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 118.585349240147m, new DateTime(2022, 11, 30, 11, 0, 6, 878, DateTimeKind.Local).AddTicks(2959), "est" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Barcode", "Description", "Price", "ReleaseDate", "Title" },
                values: new object[] { "4", "The Football Is Good For Training And Recreational Purposes", 857.801498141979m, new DateTime(2023, 2, 23, 2, 57, 25, 970, DateTimeKind.Local).AddTicks(5955), "tenetur" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Barcode", "Description", "Price", "ReleaseDate", "Title" },
                values: new object[] { "0", "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 456.989796488541m, new DateTime(2023, 2, 25, 17, 38, 26, 837, DateTimeKind.Local).AddTicks(4333), "natus" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Barcode", "Description", "Price", "ReleaseDate", "Title" },
                values: new object[] { "3", "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 383.278243241961m, new DateTime(2022, 12, 18, 22, 39, 20, 531, DateTimeKind.Local).AddTicks(4332), "impedit" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Barcode", "Description", "Price", "ReleaseDate", "Title" },
                values: new object[] { "3", "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 729.819554187274m, new DateTime(2023, 3, 16, 12, 11, 36, 274, DateTimeKind.Local).AddTicks(5967), "et" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Barcode", "Description", "Price", "ReleaseDate", "Title" },
                values: new object[] { "7", "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 12.9330949308039m, new DateTime(2023, 9, 1, 21, 20, 18, 506, DateTimeKind.Local).AddTicks(5034), "aperiam" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Barcode", "Description", "Price", "ReleaseDate", "Title" },
                values: new object[] { "7", "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 32.5958482886645m, new DateTime(2023, 7, 5, 12, 26, 7, 139, DateTimeKind.Local).AddTicks(4421), "officiis" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Barcode", "Description", "Price", "ReleaseDate", "Title" },
                values: new object[] { "6", "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 342.748452510102m, new DateTime(2023, 5, 4, 2, 55, 37, 537, DateTimeKind.Local).AddTicks(6851), "id" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Barcode", "Description", "Price", "ReleaseDate", "Title" },
                values: new object[] { "2", "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 158.364214679396m, new DateTime(2023, 7, 18, 9, 22, 23, 583, DateTimeKind.Local).AddTicks(4228), "animi" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Barcode", "Description", "Price", "ReleaseDate", "Title" },
                values: new object[] { "5", "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 515.594907488485m, new DateTime(2023, 4, 28, 13, 28, 14, 571, DateTimeKind.Local).AddTicks(6983), "similique" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Barcode", "Description", "Price", "ReleaseDate", "Title" },
                values: new object[] { "0", "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 927.287084065046m, new DateTime(2023, 8, 17, 0, 54, 53, 978, DateTimeKind.Local).AddTicks(1095), "provident" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Barcode", "Description", "Price", "ReleaseDate", "Title" },
                values: new object[] { "7", "The Football Is Good For Training And Recreational Purposes", 674.987207627849m, new DateTime(2022, 12, 15, 9, 29, 58, 378, DateTimeKind.Local).AddTicks(3935), "ut" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Barcode", "Description", "Price", "ReleaseDate", "Title" },
                values: new object[] { "9", "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 69.0171712734816m, new DateTime(2023, 2, 16, 10, 27, 54, 105, DateTimeKind.Local).AddTicks(4314), "nulla" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Barcode", "Description", "Price", "ReleaseDate", "Title" },
                values: new object[] { "7", "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 890.001594146714m, new DateTime(2023, 7, 26, 15, 27, 14, 349, DateTimeKind.Local).AddTicks(2038), "sint" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Barcode", "Description", "Price", "ReleaseDate", "Title" },
                values: new object[] { "3", "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 712.021981759007m, new DateTime(2022, 11, 7, 14, 0, 21, 447, DateTimeKind.Local).AddTicks(7223), "Gorgeous Wooden Chair" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "Price", "ReleaseDate", "Title" },
                values: new object[] { "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 839.010165513032m, new DateTime(2023, 5, 20, 10, 38, 55, 83, DateTimeKind.Local).AddTicks(9172), "Handcrafted Steel Shoes" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Barcode", "Description", "Price", "ReleaseDate", "Title" },
                values: new object[] { "1", "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 198.083692779804m, new DateTime(2022, 9, 8, 5, 32, 38, 357, DateTimeKind.Local).AddTicks(1171), "Handmade Granite Table" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Barcode", "Description", "Price", "ReleaseDate", "Title" },
                values: new object[] { "1", "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 160.643399712929m, new DateTime(2023, 4, 9, 17, 46, 8, 716, DateTimeKind.Local).AddTicks(2543), "Handmade Wooden Table" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Barcode", "Description", "Price", "ReleaseDate", "Title" },
                values: new object[] { "0", "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 359.887736376788m, new DateTime(2022, 10, 10, 19, 4, 20, 445, DateTimeKind.Local).AddTicks(8719), "Intelligent Steel Salad" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Barcode", "Description", "Price", "ReleaseDate", "Title" },
                values: new object[] { "8", "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 181.360829243139m, new DateTime(2023, 4, 24, 6, 51, 53, 555, DateTimeKind.Local).AddTicks(5996), "Handcrafted Rubber Bike" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Barcode", "Description", "Price", "ReleaseDate", "Title" },
                values: new object[] { "1", "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 938.297015022625m, new DateTime(2022, 11, 23, 6, 4, 5, 965, DateTimeKind.Local).AddTicks(6074), "Unbranded Steel Car" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Barcode", "Description", "Price", "ReleaseDate", "Title" },
                values: new object[] { "3", "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 223.882037785315m, new DateTime(2023, 2, 15, 21, 18, 33, 653, DateTimeKind.Local).AddTicks(8294), "Tasty Plastic Cheese" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Barcode", "Description", "Price", "ReleaseDate", "Title" },
                values: new object[] { "0", "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 249.172251003875m, new DateTime(2022, 8, 7, 13, 17, 49, 110, DateTimeKind.Local).AddTicks(5761), "Handcrafted Fresh Sausages" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Barcode", "Description", "Price", "ReleaseDate", "Title" },
                values: new object[] { "1", "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 905.322284099796m, new DateTime(2023, 5, 30, 4, 59, 58, 571, DateTimeKind.Local).AddTicks(8410), "Fantastic Frozen Gloves" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Barcode", "Description", "Price", "ReleaseDate", "Title" },
                values: new object[] { "3", "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 842.480734222792m, new DateTime(2023, 3, 28, 22, 14, 2, 713, DateTimeKind.Local).AddTicks(5569), "Generic Steel Ball" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Barcode", "Description", "Price", "ReleaseDate", "Title" },
                values: new object[] { "1", "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 928.928430071533m, new DateTime(2023, 4, 6, 2, 45, 59, 487, DateTimeKind.Local).AddTicks(4269), "Ergonomic Rubber Car" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Barcode", "Description", "Price", "ReleaseDate", "Title" },
                values: new object[] { "6", "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 706.948686653259m, new DateTime(2023, 3, 6, 7, 59, 28, 407, DateTimeKind.Local).AddTicks(244), "Generic Steel Pizza" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Barcode", "Description", "Price", "ReleaseDate", "Title" },
                values: new object[] { "3", "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 306.262494314584m, new DateTime(2022, 8, 30, 21, 12, 6, 894, DateTimeKind.Local).AddTicks(6580), "Small Metal Sausages" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Barcode", "Description", "Price", "ReleaseDate", "Title" },
                values: new object[] { "2", "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 378.222576259273m, new DateTime(2023, 3, 21, 14, 17, 59, 924, DateTimeKind.Local).AddTicks(3725), "Fantastic Soft Pants" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Barcode", "Description", "Price", "ReleaseDate", "Title" },
                values: new object[] { "6", "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 461.718092748764m, new DateTime(2022, 7, 9, 6, 12, 48, 391, DateTimeKind.Local).AddTicks(2576), "Gorgeous Frozen Towels" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Barcode", "Description", "Price", "ReleaseDate", "Title" },
                values: new object[] { "7", "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 126.128098112125m, new DateTime(2023, 2, 15, 20, 34, 19, 969, DateTimeKind.Local).AddTicks(2057), "Tasty Steel Cheese" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Barcode", "Description", "Price", "ReleaseDate", "Title" },
                values: new object[] { "8", "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 530.970371435383m, new DateTime(2023, 2, 12, 22, 17, 1, 328, DateTimeKind.Local).AddTicks(5106), "Gorgeous Granite Cheese" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Barcode", "Description", "Price", "ReleaseDate", "Title" },
                values: new object[] { "9", "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 913.003066283186m, new DateTime(2022, 7, 9, 9, 35, 0, 907, DateTimeKind.Local).AddTicks(8450), "Sleek Rubber Chicken" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Barcode", "Description", "Price", "ReleaseDate", "Title" },
                values: new object[] { "5", "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 940.814879371698m, new DateTime(2022, 11, 30, 11, 5, 45, 390, DateTimeKind.Local).AddTicks(1719), "Intelligent Wooden Salad" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Barcode", "Description", "Price", "ReleaseDate", "Title" },
                values: new object[] { "4", "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 479.41424090062m, new DateTime(2023, 2, 7, 22, 28, 39, 578, DateTimeKind.Local).AddTicks(4094), "Handcrafted Wooden Sausages" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Barcode", "Description", "Price", "ReleaseDate", "Title" },
                values: new object[] { "7", "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 320.499838554068m, new DateTime(2022, 9, 20, 17, 56, 1, 848, DateTimeKind.Local).AddTicks(1809), "Sleek Granite Car" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Barcode", "Description", "Price", "ReleaseDate", "Title" },
                values: new object[] { "6", "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 478.915239043029m, new DateTime(2023, 1, 20, 11, 46, 9, 166, DateTimeKind.Local).AddTicks(5370), "Small Wooden Car" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Barcode", "Description", "Price", "ReleaseDate", "Title" },
                values: new object[] { "2", "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 910.785444308438m, new DateTime(2023, 2, 21, 4, 22, 28, 395, DateTimeKind.Local).AddTicks(8534), "Sleek Steel Shirt" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Barcode", "Description", "Price", "ReleaseDate", "Title" },
                values: new object[] { "3", "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 802.238750720974m, new DateTime(2023, 3, 9, 5, 51, 19, 959, DateTimeKind.Local).AddTicks(4980), "Incredible Frozen Mouse" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Description", "Price", "ReleaseDate", "Title" },
                values: new object[] { "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 150.818741621831m, new DateTime(2023, 1, 1, 23, 27, 40, 83, DateTimeKind.Local).AddTicks(242), "Incredible Wooden Chair" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Barcode", "Description", "Price", "ReleaseDate", "Title" },
                values: new object[] { "5", "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 721.773541800572m, new DateTime(2022, 9, 23, 11, 31, 16, 79, DateTimeKind.Local).AddTicks(1838), "Gorgeous Plastic Chips" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Barcode", "Description", "Price", "ReleaseDate", "Title" },
                values: new object[] { "5", "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 688.245783060904m, new DateTime(2022, 12, 16, 13, 57, 11, 190, DateTimeKind.Local).AddTicks(7058), "Incredible Fresh Bacon" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Barcode", "Description", "Price", "ReleaseDate", "Title" },
                values: new object[] { "7", "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 553.558320945389m, new DateTime(2023, 3, 11, 0, 28, 5, 183, DateTimeKind.Local).AddTicks(8360), "Incredible Soft Computer" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Description", "Price", "ReleaseDate", "Title" },
                values: new object[] { "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 663.536718269594m, new DateTime(2022, 7, 6, 1, 23, 28, 400, DateTimeKind.Local).AddTicks(143), "Handcrafted Rubber Bike" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Barcode", "Description", "Price", "ReleaseDate", "Title" },
                values: new object[] { "2", "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 922.479030014704m, new DateTime(2023, 5, 31, 23, 49, 17, 596, DateTimeKind.Local).AddTicks(8295), "Handcrafted Concrete Tuna" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Barcode", "Description", "Price", "ReleaseDate", "Title" },
                values: new object[] { "3", "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 255.49067058018m, new DateTime(2023, 3, 11, 19, 36, 43, 535, DateTimeKind.Local).AddTicks(8725), "Gorgeous Wooden Fish" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Barcode", "Description", "Price", "ReleaseDate", "Title" },
                values: new object[] { "7", "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 955.272407213818m, new DateTime(2022, 12, 17, 20, 5, 44, 786, DateTimeKind.Local).AddTicks(4656), "Handcrafted Frozen Keyboard" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Barcode", "Description", "Price", "ReleaseDate", "Title" },
                values: new object[] { "8", "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 151.982358236323m, new DateTime(2022, 7, 16, 13, 21, 32, 625, DateTimeKind.Local).AddTicks(2251), "Intelligent Plastic Chair" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Barcode", "Description", "Price", "ReleaseDate", "Title" },
                values: new object[] { "9", "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 434.299358334532m, new DateTime(2022, 8, 3, 18, 13, 50, 620, DateTimeKind.Local).AddTicks(1925), "Unbranded Wooden Pizza" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Barcode", "Description", "Price", "ReleaseDate", "Title" },
                values: new object[] { "4", "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 57.7988712865854m, new DateTime(2022, 8, 23, 12, 47, 48, 153, DateTimeKind.Local).AddTicks(3718), "Gorgeous Rubber Bacon" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Barcode", "Description", "Price", "ReleaseDate", "Title" },
                values: new object[] { "7", "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 883.980300599234m, new DateTime(2022, 11, 19, 4, 21, 1, 549, DateTimeKind.Local).AddTicks(1875), "Handcrafted Rubber Shirt" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Barcode", "Description", "Price", "ReleaseDate", "Title" },
                values: new object[] { "7", "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 822.452619476455m, new DateTime(2022, 8, 31, 2, 22, 41, 868, DateTimeKind.Local).AddTicks(3245), "Rustic Granite Shoes" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Barcode", "Description", "Price", "ReleaseDate", "Title" },
                values: new object[] { "7", "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 22.2432652671092m, new DateTime(2022, 11, 25, 10, 0, 56, 427, DateTimeKind.Local).AddTicks(8415), "Sleek Granite Chair" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Barcode", "Description", "Price", "ReleaseDate", "Title" },
                values: new object[] { "2", "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 158.364214679396m, new DateTime(2023, 2, 12, 6, 47, 13, 51, DateTimeKind.Local).AddTicks(6181), "Incredible Rubber Soap" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Barcode", "Description", "Price", "ReleaseDate", "Title" },
                values: new object[] { "7", "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 533.504530191656m, new DateTime(2023, 3, 27, 13, 52, 35, 199, DateTimeKind.Local).AddTicks(8226), "Awesome Soft Fish" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Barcode", "Description", "Price", "ReleaseDate", "Title" },
                values: new object[] { "8", "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 265.709933652407m, new DateTime(2023, 3, 19, 1, 3, 34, 629, DateTimeKind.Local).AddTicks(3536), "Intelligent Cotton Tuna" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Barcode", "Description", "Price", "ReleaseDate", "Title" },
                values: new object[] { "2", "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 294.402654204239m, new DateTime(2022, 9, 10, 16, 49, 48, 185, DateTimeKind.Local).AddTicks(2511), "Refined Soft Bike" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Barcode", "Description", "Price", "ReleaseDate", "Title" },
                values: new object[] { "5", "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 741.648888164036m, new DateTime(2022, 9, 14, 14, 30, 13, 344, DateTimeKind.Local).AddTicks(138), "Handmade Cotton Bacon" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Barcode", "Description", "Price", "ReleaseDate", "Title" },
                values: new object[] { "5", "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 825.239833488706m, new DateTime(2022, 8, 23, 10, 36, 36, 414, DateTimeKind.Local).AddTicks(1655), "Small Soft Tuna" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Barcode", "Description", "Price", "ReleaseDate", "Title" },
                values: new object[] { "1", "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 305.894089151124m, new DateTime(2022, 12, 26, 15, 18, 47, 973, DateTimeKind.Local).AddTicks(5191), "Practical Frozen Computer" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Barcode", "Description", "Price", "ReleaseDate", "Title" },
                values: new object[] { "4", "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 778.911179241683m, new DateTime(2022, 8, 31, 10, 18, 22, 275, DateTimeKind.Local).AddTicks(8331), "Rustic Wooden Mouse" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Barcode", "Description", "Price", "ReleaseDate", "Title" },
                values: new object[] { "2", "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 318.709401070936m, new DateTime(2022, 10, 13, 7, 10, 39, 701, DateTimeKind.Local).AddTicks(7965), "Handcrafted Metal Mouse" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Barcode", "Description", "Price", "ReleaseDate", "Title" },
                values: new object[] { "6", "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 463.195345650052m, new DateTime(2022, 11, 26, 11, 52, 43, 303, DateTimeKind.Local).AddTicks(7170), "Handcrafted Rubber Salad" });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Barcode", "Description", "Price", "ReleaseDate", "Title" },
                values: new object[] { "6", "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 717.609017980569m, new DateTime(2023, 4, 15, 1, 1, 42, 483, DateTimeKind.Local).AddTicks(5848), "Incredible Plastic Shoes" });
        }
    }
}
