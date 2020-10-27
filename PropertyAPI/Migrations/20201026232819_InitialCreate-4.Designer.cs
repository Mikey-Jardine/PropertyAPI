﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PropertyAPI.Models;

namespace PropertyAPI.Migrations
{
    [DbContext(typeof(AppDBContext))]
    [Migration("20201026232819_InitialCreate-4")]
    partial class InitialCreate4
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0-rc.2.20475.6");

            modelBuilder.Entity("PropertyAPI.Models.Photo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("PropertyId")
                        .HasColumnType("int");

                    b.Property<string>("Url")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Photo");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            PropertyId = 4292232,
                            Url = "https://photosa.propertyimages.ie/media/2/3/2/4292232/38e98b8e-645f-4adf-8e57-f927e5769840_l.jpg"
                        },
                        new
                        {
                            Id = 2,
                            PropertyId = 4292232,
                            Url = "https://photosa.propertyimages.ie/media/2/3/2/4292232/e0c4c2c8-6a61-4fda-b5a8-59edc32060b6_l.jpg"
                        },
                        new
                        {
                            Id = 3,
                            PropertyId = 4292232,
                            Url = "https://photosa.propertyimages.ie/media/2/3/2/4292232/b5ce3372-d71c-4897-91dc7c5b4ce21c17_l.jpg"
                        },
                        new
                        {
                            Id = 4,
                            PropertyId = 4229499,
                            Url = "https://photosa.propertyimages.ie/media/9/9/4/4229499/aae25e08-31b0-465b-ba35-498d78f6b5c9_l.jpg"
                        },
                        new
                        {
                            Id = 5,
                            PropertyId = 4229499,
                            Url = "https://photosa.propertyimages.ie/media/9/9/4/4229499/7f983103-2529-425a-905b617b23bfa0f7_l.jpg"
                        },
                        new
                        {
                            Id = 6,
                            PropertyId = 4229499,
                            Url = "https://photosa.propertyimages.ie/media/9/9/4/4229499/4470fb1c-c301-4b1c-8bfae1c85a5d8fbc_l.jpg"
                        },
                        new
                        {
                            Id = 7,
                            PropertyId = 4301249,
                            Url = "https://photosa.propertyimages.ie/media/9/4/2/4301249/0e9bc081-ab16-4885-bddbf33678432a17_l.jpg"
                        },
                        new
                        {
                            Id = 8,
                            PropertyId = 4301249,
                            Url = "https://photosa.propertyimages.ie/media/9/4/2/4301249/2e03ba2b-471d-4f93-a8ad6bfecd2fd35b_l.jpg"
                        },
                        new
                        {
                            Id = 9,
                            PropertyId = 4301247,
                            Url = "https://photosa.propertyimages.ie/media/7/4/2/4301247/7ff064ce-07c2-4a34-8765-d031b7a28295_l.jpg"
                        },
                        new
                        {
                            Id = 10,
                            PropertyId = 4301247,
                            Url = "https://photosa.propertyimages.ie/media/7/4/2/4301247/ecd5bd19-e956-4c04-9932-0cf0112bb2f6_l.jpg"
                        },
                        new
                        {
                            Id = 11,
                            PropertyId = 4301247,
                            Url = "https://photosa.propertyimages.ie/media/7/4/2/4301247/94b223ea-a365-4646-966d90743344a5d0_l.jpg"
                        },
                        new
                        {
                            Id = 12,
                            PropertyId = 4301247,
                            Url = "https://photosa.propertyimages.ie/media/7/4/2/4301247/be1c10b1-d7be-4c97-890dc8759f288881_l.jpg"
                        },
                        new
                        {
                            Id = 13,
                            PropertyId = 4301246,
                            Url = "https://photosa.propertyimages.ie/media/6/4/2/4301246/90ef0a16-59e7-410c-b688-f45361fc00df_l.jpg"
                        },
                        new
                        {
                            Id = 14,
                            PropertyId = 4301246,
                            Url = "https://photosa.propertyimages.ie/media/6/4/2/4301246/2066a03f-d26a-4ceb-92ddd0247556c803_l.jpg"
                        },
                        new
                        {
                            Id = 15,
                            PropertyId = 4301246,
                            Url = "https://photosa.propertyimages.ie/media/6/4/2/4301246/a28bd769-e544-468f-8fa6-e590a3ed77c0_l.jpg"
                        },
                        new
                        {
                            Id = 16,
                            PropertyId = 4301246,
                            Url = "https://photosa.propertyimages.ie/media/6/4/2/4301246/183b8fa1-33d1-4bcb-91ae696f51c08935_l.jpg"
                        },
                        new
                        {
                            Id = 17,
                            PropertyId = 4301246,
                            Url = "https://photosa.propertyimages.ie/media/6/4/2/4301246/8e15e93c-c64e-4306-a18fa276858b25da_l.jpg"
                        },
                        new
                        {
                            Id = 18,
                            PropertyId = 4301245,
                            Url = "https://photosa.propertyimages.ie/media/5/4/2/4301245/a8fc46c4-6676-4e82-89cf74c1736ce441_l.jpg"
                        },
                        new
                        {
                            Id = 19,
                            PropertyId = 4301245,
                            Url = "https://photosa.propertyimages.ie/media/5/4/2/4301245/c6756ace-04b6-4701-b80bbb74f9b985de_l.jpg"
                        },
                        new
                        {
                            Id = 20,
                            PropertyId = 4301245,
                            Url = "https://photosa.propertyimages.ie/media/5/4/2/4301245/7976ee5f-3dc0-4874-833dc169cd0e2ef9_l.jpg"
                        },
                        new
                        {
                            Id = 21,
                            PropertyId = 4301245,
                            Url = "https://photosa.propertyimages.ie/media/5/4/2/4301245/0eade5e7-95b6-43dc-a22da12ec5e37159_l.jpg"
                        },
                        new
                        {
                            Id = 22,
                            PropertyId = 4301245,
                            Url = "https://photosa.propertyimages.ie/media/5/4/2/4301245/7c4d1310-c0c6-4403-97e0-ecc84e564605_l.jpg"
                        },
                        new
                        {
                            Id = 23,
                            PropertyId = 4284885,
                            Url = "https://photosa.propertyimages.ie/media/5/8/8/4284885/f85794ff-5714-4247-91a0-08eed0853a46_l.jpg"
                        },
                        new
                        {
                            Id = 24,
                            PropertyId = 4284885,
                            Url = "https://photosa.propertyimages.ie/media/5/8/8/4284885/1e2309b8-8fa3-4315-bf20-488d5532856b_l.jpg"
                        },
                        new
                        {
                            Id = 25,
                            PropertyId = 4284885,
                            Url = "https://photosa.propertyimages.ie/media/5/8/8/4284885/394f3834-3ccd-4185-9eeeaf6686004801_l.jpg"
                        },
                        new
                        {
                            Id = 26,
                            PropertyId = 4284885,
                            Url = "https://photosa.propertyimages.ie/media/5/8/8/4284885/9100e307-c3dc-468c-bbfc4e0509cf69be_l.jpg"
                        },
                        new
                        {
                            Id = 27,
                            PropertyId = 4301244,
                            Url = "https://photosa.propertyimages.ie/media/4/4/2/4301244/dcacf01c-089b-4d54-b452-eb0d9cb9de4d_l.jpg"
                        },
                        new
                        {
                            Id = 28,
                            PropertyId = 4301244,
                            Url = "https://photosa.propertyimages.ie/media/4/4/2/4301244/e60480c8-a834-41ee-8250-9d2c97ba249e_l.jpg"
                        },
                        new
                        {
                            Id = 29,
                            PropertyId = 4301244,
                            Url = "https://photos-a.propertyimages.ie/media/8/9/2/3851298/44915955-f480-4f3d-8e42-84f12ebfbfde_l.jpg"
                        },
                        new
                        {
                            Id = 30,
                            PropertyId = 4301244,
                            Url = "https://photosa.propertyimages.ie/media/8/9/2/3851298/d8874610-f7ca-4e2b-b450-1dd19597ff0c_l.jpg"
                        },
                        new
                        {
                            Id = 31,
                            PropertyId = 4301244,
                            Url = "https://photosa.propertyimages.ie/media/8/9/2/3851298/3360cd3a-d478-47ab-94b0-f1bd30361dda_l.jpg"
                        },
                        new
                        {
                            Id = 32,
                            PropertyId = 4301243,
                            Url = "https://photosa.propertyimages.ie/media/3/4/2/4301243/4453564d-ffa4-4e58-af73-04104692e3cd_l.jpg"
                        },
                        new
                        {
                            Id = 33,
                            PropertyId = 4301243,
                            Url = "https://photos-a.propertyimages.ie/media/8/9/2/3851298/9991fa79-d54d-4c0d-a753-23838287e215_l.jpg"
                        },
                        new
                        {
                            Id = 34,
                            PropertyId = 4301243,
                            Url = "https://photos-a.propertyimages.ie/media/8/9/2/3851298/9b15a341-5698-4d8a-9849-a8d2df6f4bef_l.jpg"
                        },
                        new
                        {
                            Id = 35,
                            PropertyId = 4301243,
                            Url = "https://photosa.propertyimages.ie/media/3/4/2/4301243/b7a48e74-ff8a-436d-af3a4eb2ed0c47de_l.jpg"
                        },
                        new
                        {
                            Id = 36,
                            PropertyId = 4301242,
                            Url = "https://photosa.propertyimages.ie/media/2/4/2/4301242/4c9ea054-1865-4bd3-901a6ad05a79fa7e_l.jpg"
                        },
                        new
                        {
                            Id = 37,
                            PropertyId = 4301242,
                            Url = "https://photosa.propertyimages.ie/media/2/4/2/4301242/f08c8c5d-731d-4be3-a78ee3501d1214d6_l.jpg"
                        });
                });

            modelBuilder.Entity("PropertyAPI.Models.Property", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("BedsString")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BerRating")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DisplayAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GroupLogoUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MainPhoto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<string>("PropertyType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("SizeStringMeters")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Property");

                    b.HasData(
                        new
                        {
                            Id = 4292232,
                            BedsString = "2	beds",
                            BerRating = "D2",
                            DisplayAddress = "Apt.	16	The	Northumberlands,	Off	Lower	Mount	Street,",
                            GroupLogoUrl = "https://photosa.propertyimages.ie/groups/9/0/4/6409/logo.jpg",
                            MainPhoto = "https://photosa.propertyimages.ie/media/2/3/2/4292232/38e98b8e-645f-4adf-8e57-f927e5769840_l.jpg",
                            Price = 395000,
                            PropertyType = "Apartment",
                            SizeStringMeters = 52.950000000000003
                        },
                        new
                        {
                            Id = 4229499,
                            BedsString = "5	beds",
                            BerRating = "B2",
                            DisplayAddress = "Alleen,	Donohill,	Tipperary",
                            GroupLogoUrl = "https://photosa.propertyimages.ie/groups/9/2/6/283629/logo.jpg",
                            MainPhoto = "https://photosa.propertyimages.ie/media/9/9/4/4229499/aae25e08-31b0-465b-ba35-498d78f6b5c9_l.jpg",
                            Price = 420000,
                            PropertyType = "Detached	House",
                            SizeStringMeters = 98.0
                        },
                        new
                        {
                            Id = 4301249,
                            BedsString = "2	beds",
                            BerRating = "G",
                            DisplayAddress = "20	Gratton	Street,	Gorey,	Wexford",
                            GroupLogoUrl = "https://photosa.propertyimages.ie/groups/3/1/4/256413/logo.jpg",
                            MainPhoto = "https://photosa.propertyimages.ie/media/9/4/2/4301249/0e9bc081-ab16-4885-bddbf33678432a17_l.jpg",
                            Price = 99000,
                            PropertyType = "Terraced	House",
                            SizeStringMeters = 0.0
                        },
                        new
                        {
                            Id = 4301247,
                            BedsString = "4 beds",
                            BerRating = "C1",
                            DisplayAddress = "Cappagh,	Inistioge,	Co	Kilkenny,	R95	E642",
                            GroupLogoUrl = "https://photosa.propertyimages.ie/groups/0/5/6/5650/logo.jpg",
                            MainPhoto = "https://photosa.propertyimages.ie/media/7/4/2/4301247/7ff064ce-07c2-4a34-8765-d031b7a28295_l.jpg",
                            Price = 550000,
                            PropertyType = "Detached	House",
                            SizeStringMeters = 238.40000000000001
                        },
                        new
                        {
                            Id = 4301246,
                            BedsString = "3	beds",
                            DisplayAddress = "4	Rices	Street,	Dungarvan,	Waterford",
                            GroupLogoUrl = "https://photosa.propertyimages.ie/groups/8/6/9/8968/logo.jpg",
                            MainPhoto = "https://photosa.propertyimages.ie/media/6/4/2/4301246/90ef0a16-59e7-410c-b688-f45361fc00df_l.jpg",
                            Price = 135000,
                            PropertyType = "End	of	Terrace	House",
                            SizeStringMeters = 0.0
                        },
                        new
                        {
                            Id = 4301245,
                            BedsString = "3	beds",
                            DisplayAddress = "Cloghan	Road,	Shannonbridge,	Offaly",
                            GroupLogoUrl = "https://photosa.propertyimages.ie/groups/9/9/5/309599/logo.jpg",
                            MainPhoto = "https://photosa.propertyimages.ie/media/5/4/2/4301245/a8fc46c4-6676-4e82-89cf74c1736ce441_l.jpg",
                            Price = 0,
                            PropertyType = "Bungalow",
                            SizeStringMeters = 109.0
                        },
                        new
                        {
                            Id = 4284885,
                            BedsString = "4	beds",
                            BerRating = "D1",
                            DisplayAddress = "45	Ardmore,	Gorey,	Wexford",
                            GroupLogoUrl = "https://photosa.propertyimages.ie/groups/3/1/4/256413/logo.jpg",
                            MainPhoto = "https://photosa.propertyimages.ie/media/5/8/8/4284885/f85794ff-5714-4247-91a0-08eed0853a46_l.jpg",
                            Price = 325000,
                            PropertyType = "Detached	House",
                            SizeStringMeters = 0.0
                        },
                        new
                        {
                            Id = 4301244,
                            BedsString = "3	beds",
                            DisplayAddress = "21	Derryounce,	Portarlington,	Co.	Laois",
                            GroupLogoUrl = "https://photosa.propertyimages.ie/groups/7/0/1/259107/logo.jpg",
                            MainPhoto = "https://photosa.propertyimages.ie/media/4/4/2/4301244/dcacf01c-089b-4d54-b452-eb0d9cb9de4d_l.jpg",
                            Price = 200000,
                            PropertyType = "End	of	Terrace	House",
                            SizeStringMeters = 0.0
                        },
                        new
                        {
                            Id = 4301243,
                            BedsString = "3	beds",
                            DisplayAddress = "22	Derryounce,	Portarlington,	Co.	Laois",
                            GroupLogoUrl = "https://photosa.propertyimages.ie/groups/7/0/1/259107/logo.jpg",
                            MainPhoto = "https://photosa.propertyimages.ie/media/3/4/2/4301243/4453564d-ffa4-4e58-af73-04104692e3cd_l.jpg",
                            Price = 260000,
                            PropertyType = "Terraced	House",
                            SizeStringMeters = 0.0
                        },
                        new
                        {
                            Id = 4301242,
                            BedsString = "3	beds",
                            DisplayAddress = "23	Derryounce,	Portarlington,	Co.	Laois",
                            GroupLogoUrl = "https://photosa.propertyimages.ie/groups/7/0/1/259107/logo.jpg",
                            MainPhoto = "https://photosa.propertyimages.ie/media/2/4/2/4301242/4c9ea054-1865-4bd3-901a6ad05a79fa7e_l.jpg",
                            Price = 200000,
                            PropertyType = "Terraced	House",
                            SizeStringMeters = 0.0
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
