﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using P05Shop.API.Models;

#nullable disable

namespace P05Shop.API.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230606075656_addInitialData")]
    partial class addInitialData
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("FilmVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("P06Shop.Shared.Shop.Film", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Barcode")
                        .IsRequired()
                        .HasMaxLength(12)
                        .HasColumnType("nvarchar(12)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(8,2)");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Films");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Barcode = "3",
                            Description = "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design",
                            Price = 712.021981759007m,
                            ReleaseDate = new DateTime(2022, 10, 18, 15, 16, 56, 509, DateTimeKind.Local).AddTicks(3637),
                            Title = "Gorgeous Wooden Chair"
                        },
                        new
                        {
                            Id = 2,
                            Barcode = "7",
                            Description = "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive",
                            Price = 839.010165513032m,
                            ReleaseDate = new DateTime(2023, 4, 30, 11, 55, 30, 145, DateTimeKind.Local).AddTicks(5509),
                            Title = "Handcrafted Steel Shoes"
                        },
                        new
                        {
                            Id = 3,
                            Barcode = "1",
                            Description = "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit",
                            Price = 198.083692779804m,
                            ReleaseDate = new DateTime(2022, 8, 19, 6, 49, 13, 418, DateTimeKind.Local).AddTicks(7493),
                            Title = "Handmade Granite Table"
                        },
                        new
                        {
                            Id = 4,
                            Barcode = "1",
                            Description = "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive",
                            Price = 160.643399712929m,
                            ReleaseDate = new DateTime(2023, 3, 20, 19, 2, 43, 777, DateTimeKind.Local).AddTicks(8854),
                            Title = "Handmade Wooden Table"
                        },
                        new
                        {
                            Id = 5,
                            Barcode = "0",
                            Description = "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles",
                            Price = 359.887736376788m,
                            ReleaseDate = new DateTime(2022, 9, 20, 20, 20, 55, 507, DateTimeKind.Local).AddTicks(5017),
                            Title = "Intelligent Steel Salad"
                        },
                        new
                        {
                            Id = 6,
                            Barcode = "8",
                            Description = "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals",
                            Price = 181.360829243139m,
                            ReleaseDate = new DateTime(2023, 4, 4, 8, 8, 28, 617, DateTimeKind.Local).AddTicks(2314),
                            Title = "Handcrafted Rubber Bike"
                        },
                        new
                        {
                            Id = 7,
                            Barcode = "1",
                            Description = "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart",
                            Price = 938.297015022625m,
                            ReleaseDate = new DateTime(2022, 11, 3, 7, 20, 41, 27, DateTimeKind.Local).AddTicks(2350),
                            Title = "Unbranded Steel Car"
                        },
                        new
                        {
                            Id = 8,
                            Barcode = "3",
                            Description = "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients",
                            Price = 223.882037785315m,
                            ReleaseDate = new DateTime(2023, 1, 26, 22, 35, 8, 715, DateTimeKind.Local).AddTicks(4556),
                            Title = "Tasty Plastic Cheese"
                        },
                        new
                        {
                            Id = 9,
                            Barcode = "0",
                            Description = "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals",
                            Price = 249.172251003875m,
                            ReleaseDate = new DateTime(2022, 7, 18, 14, 34, 24, 172, DateTimeKind.Local).AddTicks(2009),
                            Title = "Handcrafted Fresh Sausages"
                        },
                        new
                        {
                            Id = 10,
                            Barcode = "1",
                            Description = "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support",
                            Price = 905.322284099796m,
                            ReleaseDate = new DateTime(2023, 5, 10, 6, 16, 33, 633, DateTimeKind.Local).AddTicks(4650),
                            Title = "Fantastic Frozen Gloves"
                        },
                        new
                        {
                            Id = 11,
                            Barcode = "3",
                            Description = "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design",
                            Price = 842.480734222792m,
                            ReleaseDate = new DateTime(2023, 3, 8, 23, 30, 37, 775, DateTimeKind.Local).AddTicks(1797),
                            Title = "Generic Steel Ball"
                        },
                        new
                        {
                            Id = 12,
                            Barcode = "1",
                            Description = "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals",
                            Price = 928.928430071533m,
                            ReleaseDate = new DateTime(2023, 3, 17, 4, 2, 34, 549, DateTimeKind.Local).AddTicks(485),
                            Title = "Ergonomic Rubber Car"
                        },
                        new
                        {
                            Id = 13,
                            Barcode = "6",
                            Description = "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality",
                            Price = 706.948686653259m,
                            ReleaseDate = new DateTime(2023, 2, 14, 9, 16, 3, 468, DateTimeKind.Local).AddTicks(6471),
                            Title = "Generic Steel Pizza"
                        },
                        new
                        {
                            Id = 14,
                            Barcode = "3",
                            Description = "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles",
                            Price = 306.262494314584m,
                            ReleaseDate = new DateTime(2022, 8, 10, 22, 28, 41, 956, DateTimeKind.Local).AddTicks(2766),
                            Title = "Small Metal Sausages"
                        },
                        new
                        {
                            Id = 15,
                            Barcode = "2",
                            Description = "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support",
                            Price = 378.222576259273m,
                            ReleaseDate = new DateTime(2023, 3, 1, 15, 34, 34, 985, DateTimeKind.Local).AddTicks(9896),
                            Title = "Fantastic Soft Pants"
                        },
                        new
                        {
                            Id = 16,
                            Barcode = "6",
                            Description = "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients",
                            Price = 461.718092748764m,
                            ReleaseDate = new DateTime(2022, 6, 19, 7, 29, 23, 452, DateTimeKind.Local).AddTicks(8735),
                            Title = "Gorgeous Frozen Towels"
                        },
                        new
                        {
                            Id = 17,
                            Barcode = "7",
                            Description = "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles",
                            Price = 126.128098112125m,
                            ReleaseDate = new DateTime(2023, 1, 26, 21, 50, 55, 30, DateTimeKind.Local).AddTicks(8205),
                            Title = "Tasty Steel Cheese"
                        },
                        new
                        {
                            Id = 18,
                            Barcode = "8",
                            Description = "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart",
                            Price = 530.970371435383m,
                            ReleaseDate = new DateTime(2023, 1, 23, 23, 33, 36, 390, DateTimeKind.Local).AddTicks(1241),
                            Title = "Gorgeous Granite Cheese"
                        },
                        new
                        {
                            Id = 19,
                            Barcode = "9",
                            Description = "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive",
                            Price = 913.003066283186m,
                            ReleaseDate = new DateTime(2022, 6, 19, 10, 51, 35, 969, DateTimeKind.Local).AddTicks(4599),
                            Title = "Sleek Rubber Chicken"
                        },
                        new
                        {
                            Id = 20,
                            Barcode = "5",
                            Description = "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals",
                            Price = 940.814879371698m,
                            ReleaseDate = new DateTime(2022, 11, 10, 12, 22, 20, 451, DateTimeKind.Local).AddTicks(7829),
                            Title = "Intelligent Wooden Salad"
                        },
                        new
                        {
                            Id = 21,
                            Barcode = "4",
                            Description = "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support",
                            Price = 479.41424090062m,
                            ReleaseDate = new DateTime(2023, 1, 18, 23, 45, 14, 640, DateTimeKind.Local).AddTicks(190),
                            Title = "Handcrafted Wooden Sausages"
                        },
                        new
                        {
                            Id = 22,
                            Barcode = "7",
                            Description = "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit",
                            Price = 320.499838554068m,
                            ReleaseDate = new DateTime(2022, 8, 31, 19, 12, 36, 909, DateTimeKind.Local).AddTicks(7892),
                            Title = "Sleek Granite Car"
                        },
                        new
                        {
                            Id = 23,
                            Barcode = "6",
                            Description = "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J",
                            Price = 478.915239043029m,
                            ReleaseDate = new DateTime(2022, 12, 31, 13, 2, 44, 228, DateTimeKind.Local).AddTicks(1440),
                            Title = "Small Wooden Car"
                        },
                        new
                        {
                            Id = 24,
                            Barcode = "2",
                            Description = "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients",
                            Price = 910.785444308438m,
                            ReleaseDate = new DateTime(2023, 2, 1, 5, 39, 3, 457, DateTimeKind.Local).AddTicks(4592),
                            Title = "Sleek Steel Shirt"
                        },
                        new
                        {
                            Id = 25,
                            Barcode = "3",
                            Description = "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016",
                            Price = 802.238750720974m,
                            ReleaseDate = new DateTime(2023, 2, 17, 7, 7, 55, 21, DateTimeKind.Local).AddTicks(1026),
                            Title = "Incredible Frozen Mouse"
                        },
                        new
                        {
                            Id = 26,
                            Barcode = "7",
                            Description = "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J",
                            Price = 150.818741621831m,
                            ReleaseDate = new DateTime(2022, 12, 13, 0, 44, 15, 144, DateTimeKind.Local).AddTicks(6304),
                            Title = "Incredible Wooden Chair"
                        },
                        new
                        {
                            Id = 27,
                            Barcode = "5",
                            Description = "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit",
                            Price = 721.773541800572m,
                            ReleaseDate = new DateTime(2022, 9, 3, 12, 47, 51, 140, DateTimeKind.Local).AddTicks(7861),
                            Title = "Gorgeous Plastic Chips"
                        },
                        new
                        {
                            Id = 28,
                            Barcode = "5",
                            Description = "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit",
                            Price = 688.245783060904m,
                            ReleaseDate = new DateTime(2022, 11, 26, 15, 13, 46, 252, DateTimeKind.Local).AddTicks(3068),
                            Title = "Incredible Fresh Bacon"
                        },
                        new
                        {
                            Id = 29,
                            Barcode = "7",
                            Description = "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support",
                            Price = 553.558320945389m,
                            ReleaseDate = new DateTime(2023, 2, 19, 1, 44, 40, 245, DateTimeKind.Local).AddTicks(4357),
                            Title = "Incredible Soft Computer"
                        },
                        new
                        {
                            Id = 30,
                            Barcode = "4",
                            Description = "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016",
                            Price = 663.536718269594m,
                            ReleaseDate = new DateTime(2022, 6, 16, 2, 40, 3, 461, DateTimeKind.Local).AddTicks(6127),
                            Title = "Handcrafted Rubber Bike"
                        },
                        new
                        {
                            Id = 31,
                            Barcode = "2",
                            Description = "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles",
                            Price = 922.479030014704m,
                            ReleaseDate = new DateTime(2023, 5, 12, 1, 5, 52, 658, DateTimeKind.Local).AddTicks(4267),
                            Title = "Handcrafted Concrete Tuna"
                        },
                        new
                        {
                            Id = 32,
                            Barcode = "3",
                            Description = "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality",
                            Price = 255.49067058018m,
                            ReleaseDate = new DateTime(2023, 2, 19, 20, 53, 18, 597, DateTimeKind.Local).AddTicks(4683),
                            Title = "Gorgeous Wooden Fish"
                        },
                        new
                        {
                            Id = 33,
                            Barcode = "7",
                            Description = "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016",
                            Price = 955.272407213818m,
                            ReleaseDate = new DateTime(2022, 11, 27, 21, 22, 19, 848, DateTimeKind.Local).AddTicks(574),
                            Title = "Handcrafted Frozen Keyboard"
                        },
                        new
                        {
                            Id = 34,
                            Barcode = "8",
                            Description = "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive",
                            Price = 151.982358236323m,
                            ReleaseDate = new DateTime(2022, 6, 26, 14, 38, 7, 686, DateTimeKind.Local).AddTicks(8156),
                            Title = "Intelligent Plastic Chair"
                        },
                        new
                        {
                            Id = 35,
                            Barcode = "9",
                            Description = "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit",
                            Price = 434.299358334532m,
                            ReleaseDate = new DateTime(2022, 7, 14, 19, 30, 25, 681, DateTimeKind.Local).AddTicks(7818),
                            Title = "Unbranded Wooden Pizza"
                        },
                        new
                        {
                            Id = 36,
                            Barcode = "4",
                            Description = "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J",
                            Price = 57.7988712865854m,
                            ReleaseDate = new DateTime(2022, 8, 3, 14, 4, 23, 214, DateTimeKind.Local).AddTicks(9787),
                            Title = "Gorgeous Rubber Bacon"
                        },
                        new
                        {
                            Id = 37,
                            Barcode = "7",
                            Description = "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart",
                            Price = 883.980300599234m,
                            ReleaseDate = new DateTime(2022, 10, 30, 5, 37, 36, 610, DateTimeKind.Local).AddTicks(7975),
                            Title = "Handcrafted Rubber Shirt"
                        },
                        new
                        {
                            Id = 38,
                            Barcode = "7",
                            Description = "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support",
                            Price = 822.452619476455m,
                            ReleaseDate = new DateTime(2022, 8, 11, 3, 39, 16, 929, DateTimeKind.Local).AddTicks(9338),
                            Title = "Rustic Granite Shoes"
                        },
                        new
                        {
                            Id = 39,
                            Barcode = "7",
                            Description = "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design",
                            Price = 22.2432652671092m,
                            ReleaseDate = new DateTime(2022, 11, 5, 11, 17, 31, 489, DateTimeKind.Local).AddTicks(4472),
                            Title = "Sleek Granite Chair"
                        },
                        new
                        {
                            Id = 40,
                            Barcode = "2",
                            Description = "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive",
                            Price = 158.364214679396m,
                            ReleaseDate = new DateTime(2023, 1, 23, 8, 3, 48, 113, DateTimeKind.Local).AddTicks(2250),
                            Title = "Incredible Rubber Soap"
                        },
                        new
                        {
                            Id = 41,
                            Barcode = "7",
                            Description = "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit",
                            Price = 533.504530191656m,
                            ReleaseDate = new DateTime(2023, 3, 7, 15, 9, 10, 261, DateTimeKind.Local).AddTicks(4287),
                            Title = "Awesome Soft Fish"
                        },
                        new
                        {
                            Id = 42,
                            Barcode = "8",
                            Description = "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive",
                            Price = 265.709933652407m,
                            ReleaseDate = new DateTime(2023, 2, 27, 2, 20, 9, 690, DateTimeKind.Local).AddTicks(9584),
                            Title = "Intelligent Cotton Tuna"
                        },
                        new
                        {
                            Id = 43,
                            Barcode = "2",
                            Description = "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J",
                            Price = 294.402654204239m,
                            ReleaseDate = new DateTime(2022, 8, 21, 18, 6, 23, 246, DateTimeKind.Local).AddTicks(8547),
                            Title = "Refined Soft Bike"
                        },
                        new
                        {
                            Id = 44,
                            Barcode = "5",
                            Description = "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals",
                            Price = 741.648888164036m,
                            ReleaseDate = new DateTime(2022, 8, 25, 15, 46, 48, 405, DateTimeKind.Local).AddTicks(6162),
                            Title = "Handmade Cotton Bacon"
                        },
                        new
                        {
                            Id = 45,
                            Barcode = "5",
                            Description = "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit",
                            Price = 825.239833488706m,
                            ReleaseDate = new DateTime(2022, 8, 3, 11, 53, 11, 475, DateTimeKind.Local).AddTicks(7666),
                            Title = "Small Soft Tuna"
                        },
                        new
                        {
                            Id = 46,
                            Barcode = "1",
                            Description = "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality",
                            Price = 305.894089151124m,
                            ReleaseDate = new DateTime(2022, 12, 6, 16, 35, 23, 35, DateTimeKind.Local).AddTicks(1204),
                            Title = "Practical Frozen Computer"
                        },
                        new
                        {
                            Id = 47,
                            Barcode = "4",
                            Description = "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients",
                            Price = 778.911179241683m,
                            ReleaseDate = new DateTime(2022, 8, 11, 11, 34, 57, 337, DateTimeKind.Local).AddTicks(4333),
                            Title = "Rustic Wooden Mouse"
                        },
                        new
                        {
                            Id = 48,
                            Barcode = "2",
                            Description = "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart",
                            Price = 318.709401070936m,
                            ReleaseDate = new DateTime(2022, 9, 23, 8, 27, 14, 763, DateTimeKind.Local).AddTicks(3956),
                            Title = "Handcrafted Metal Mouse"
                        },
                        new
                        {
                            Id = 49,
                            Barcode = "6",
                            Description = "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients",
                            Price = 463.195345650052m,
                            ReleaseDate = new DateTime(2022, 11, 6, 13, 9, 18, 365, DateTimeKind.Local).AddTicks(3151),
                            Title = "Handcrafted Rubber Salad"
                        },
                        new
                        {
                            Id = 50,
                            Barcode = "6",
                            Description = "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support",
                            Price = 717.609017980569m,
                            ReleaseDate = new DateTime(2023, 3, 26, 2, 18, 17, 545, DateTimeKind.Local).AddTicks(1817),
                            Title = "Incredible Plastic Shoes"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
