﻿// <auto-generated />
using System;
using KariHotel.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace KariHotel.Migrations
{
    [DbContext(typeof(HotelContext))]
    partial class HotelContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.3-servicing-35854")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("KariHotel.Models.Bills", b =>
                {
                    b.Property<int>("OrderID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("OrderDate");

                    b.Property<int?>("OrdersID");

                    b.Property<decimal>("Price")
                        .HasMaxLength(50);

                    b.HasKey("OrderID");

                    b.HasIndex("OrdersID");

                    b.ToTable("Bills");
                });

            modelBuilder.Entity("KariHotel.Models.Client", b =>
                {
                    b.Property<int>("ClientID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ContactPhone")
                        .IsRequired();

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("FirstMidName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Pass")
                        .IsRequired();

                    b.HasKey("ClientID");

                    b.ToTable("Client");
                });

            modelBuilder.Entity("KariHotel.Models.Fines", b =>
                {
                    b.Property<int>("FinesID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<DateTime>("OddDate");

                    b.Property<int>("OrderID");

                    b.Property<int?>("OrdersID");

                    b.Property<decimal>("Price");

                    b.HasKey("FinesID");

                    b.HasIndex("OrdersID");

                    b.ToTable("Fines");
                });

            modelBuilder.Entity("KariHotel.Models.OddServ", b =>
                {
                    b.Property<int>("OddServID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<DateTime>("OddDate");

                    b.Property<int>("OrderID");

                    b.Property<int?>("OrdersID");

                    b.Property<decimal>("Price");

                    b.HasKey("OddServID");

                    b.HasIndex("OrdersID");

                    b.ToTable("OddServ");
                });

            modelBuilder.Entity("KariHotel.Models.Orders", b =>
                {
                    b.Property<int>("OrdersID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Check_inDate");

                    b.Property<DateTime>("Check_outDate");

                    b.Property<int>("ClientID");

                    b.Property<DateTime>("OrderDate");

                    b.Property<int>("RoomID");

                    b.HasKey("OrdersID");

                    b.HasIndex("ClientID");

                    b.HasIndex("RoomID");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("KariHotel.Models.Room", b =>
                {
                    b.Property<int>("RoomID");

                    b.Property<int>("Number");

                    b.Property<string>("Title");

                    b.HasKey("RoomID");

                    b.ToTable("Room");
                });

            modelBuilder.Entity("KariHotel.Models.Bills", b =>
                {
                    b.HasOne("KariHotel.Models.Orders", "Orders")
                        .WithMany("Bills")
                        .HasForeignKey("OrdersID");
                });

            modelBuilder.Entity("KariHotel.Models.Fines", b =>
                {
                    b.HasOne("KariHotel.Models.Orders", "Orders")
                        .WithMany("Fines")
                        .HasForeignKey("OrdersID");
                });

            modelBuilder.Entity("KariHotel.Models.OddServ", b =>
                {
                    b.HasOne("KariHotel.Models.Orders", "Orders")
                        .WithMany("OddServ")
                        .HasForeignKey("OrdersID");
                });

            modelBuilder.Entity("KariHotel.Models.Orders", b =>
                {
                    b.HasOne("KariHotel.Models.Client", "Client")
                        .WithMany("Orders")
                        .HasForeignKey("ClientID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("KariHotel.Models.Room", "Room")
                        .WithMany("Orders")
                        .HasForeignKey("RoomID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
