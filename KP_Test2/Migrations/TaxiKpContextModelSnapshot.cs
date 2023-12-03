﻿// <auto-generated />
using System;
using KP_Test2.EF;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace KP_Test2.Migrations
{
    [DbContext(typeof(TaxiKpContext))]
    partial class TaxiKpContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("KP_Test2.Entities.Car", b =>
                {
                    b.Property<int>("Idcar")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("idcar");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Idcar"));

                    b.Property<bool?>("IsFree")
                        .HasColumnType("boolean");

                    b.Property<bool?>("Isautopark")
                        .HasColumnType("boolean")
                        .HasColumnName("isautopark");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("model");

                    b.Property<string>("Numbers")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("character varying(10)")
                        .HasColumnName("numbers");

                    b.HasKey("Idcar")
                        .HasName("car_pkey");

                    b.ToTable("car", (string)null);
                });

            modelBuilder.Entity("KP_Test2.Entities.Driver", b =>
                {
                    b.Property<int>("Iddriver")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("iddriver");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Iddriver"));

                    b.Property<string>("Description")
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)")
                        .HasColumnName("description");

                    b.Property<int?>("Idcar")
                        .HasColumnType("integer")
                        .HasColumnName("idcar");

                    b.Property<int>("Iduser")
                        .HasColumnType("integer")
                        .HasColumnName("iduser");

                    b.Property<bool>("Iswork")
                        .HasColumnType("boolean")
                        .HasColumnName("iswork");

                    b.Property<int>("License")
                        .HasColumnType("integer")
                        .HasColumnName("license");

                    b.Property<string>("Plane")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("plane");

                    b.Property<double?>("Rating")
                        .HasColumnType("double precision")
                        .HasColumnName("rating");

                    b.HasKey("Iddriver")
                        .HasName("driver_pkey");

                    b.HasIndex("Idcar");

                    b.HasIndex("Iduser");

                    b.ToTable("driver", (string)null);
                });

            modelBuilder.Entity("KP_Test2.Entities.Historyorder", b =>
                {
                    b.Property<int>("Idorder")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("idorder");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Idorder"));

                    b.Property<int?>("Iddriver")
                        .HasColumnType("integer")
                        .HasColumnName("iddriver");

                    b.Property<int>("Idpassenger")
                        .HasColumnType("integer")
                        .HasColumnName("idpassenger");

                    b.Property<int?>("Price")
                        .HasColumnType("integer")
                        .HasColumnName("price");

                    b.Property<string>("Routeend")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("character varying(250)")
                        .HasColumnName("routeend");

                    b.Property<string>("Routestart")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("character varying(250)")
                        .HasColumnName("routestart");

                    b.Property<DateTime?>("Timeend")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("timeend");

                    b.Property<DateTime?>("Timestart")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("timestart");

                    b.HasKey("Idorder")
                        .HasName("historyorder_pkey");

                    b.HasIndex("Iddriver");

                    b.HasIndex("Idpassenger");

                    b.ToTable("historyorder", (string)null);
                });

            modelBuilder.Entity("KP_Test2.Entities.Passenger", b =>
                {
                    b.Property<int>("Idpassenger")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("idpassenger");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Idpassenger"));

                    b.Property<string>("Addresshome")
                        .HasMaxLength(150)
                        .HasColumnType("character varying(150)")
                        .HasColumnName("addresshome");

                    b.Property<string>("Description")
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)")
                        .HasColumnName("description");

                    b.Property<int>("Iduser")
                        .HasColumnType("integer")
                        .HasColumnName("iduser");

                    b.Property<double?>("Rating")
                        .HasColumnType("double precision")
                        .HasColumnName("rating");

                    b.HasKey("Idpassenger")
                        .HasName("passenger_pkey");

                    b.HasIndex("Iduser");

                    b.ToTable("passenger", (string)null);
                });

            modelBuilder.Entity("KP_Test2.Entities.Usertaxi", b =>
                {
                    b.Property<int>("Iduser")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("iduser");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Iduser"));

                    b.Property<long?>("Card")
                        .HasColumnType("bigint")
                        .HasColumnName("card");

                    b.Property<string>("Contact")
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)")
                        .HasColumnName("contact");

                    b.Property<DateOnly>("Dateregistration")
                        .HasColumnType("date")
                        .HasColumnName("dateregistration");

                    b.Property<string>("Email")
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)")
                        .HasColumnName("email");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)")
                        .HasColumnName("login");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("name");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)")
                        .HasColumnName("password");

                    b.Property<string>("Roletype")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("roletype");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)")
                        .HasColumnName("surname");

                    b.HasKey("Iduser")
                        .HasName("usertaxi_pkey");

                    b.ToTable("usertaxi", (string)null);
                });

            modelBuilder.Entity("KP_Test2.Entities.Driver", b =>
                {
                    b.HasOne("KP_Test2.Entities.Car", "IdcarNavigation")
                        .WithMany("Drivers")
                        .HasForeignKey("Idcar")
                        .HasConstraintName("driver_idcar_fkey");

                    b.HasOne("KP_Test2.Entities.Usertaxi", "IduserNavigation")
                        .WithMany("Drivers")
                        .HasForeignKey("Iduser")
                        .IsRequired()
                        .HasConstraintName("driver_iduser_fkey");

                    b.Navigation("IdcarNavigation");

                    b.Navigation("IduserNavigation");
                });

            modelBuilder.Entity("KP_Test2.Entities.Historyorder", b =>
                {
                    b.HasOne("KP_Test2.Entities.Driver", "IddriverNavigation")
                        .WithMany("Historyorders")
                        .HasForeignKey("Iddriver")
                        .HasConstraintName("historyorder_iddriver_fkey");

                    b.HasOne("KP_Test2.Entities.Passenger", "IdpassengerNavigation")
                        .WithMany("Historyorders")
                        .HasForeignKey("Idpassenger")
                        .IsRequired()
                        .HasConstraintName("historyorder_idpassenger_fkey");

                    b.Navigation("IddriverNavigation");

                    b.Navigation("IdpassengerNavigation");
                });

            modelBuilder.Entity("KP_Test2.Entities.Passenger", b =>
                {
                    b.HasOne("KP_Test2.Entities.Usertaxi", "IduserNavigation")
                        .WithMany("Passengers")
                        .HasForeignKey("Iduser")
                        .IsRequired()
                        .HasConstraintName("passenger_iduser_fkey");

                    b.Navigation("IduserNavigation");
                });

            modelBuilder.Entity("KP_Test2.Entities.Car", b =>
                {
                    b.Navigation("Drivers");
                });

            modelBuilder.Entity("KP_Test2.Entities.Driver", b =>
                {
                    b.Navigation("Historyorders");
                });

            modelBuilder.Entity("KP_Test2.Entities.Passenger", b =>
                {
                    b.Navigation("Historyorders");
                });

            modelBuilder.Entity("KP_Test2.Entities.Usertaxi", b =>
                {
                    b.Navigation("Drivers");

                    b.Navigation("Passengers");
                });
#pragma warning restore 612, 618
        }
    }
}
