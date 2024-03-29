﻿// <auto-generated />
using System;
using System.Collections.Generic;
using Endpoint.Repository.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Endpoint.Repository.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    partial class DatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Endpoint.Utilities.Models.Feature", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Id");

                    b.ToTable("Features");

                    b.HasData(
                        new
                        {
                            Id = new Guid("05968ad9-bcf4-46b9-a309-f6efe17a9e18"),
                            Name = "Feature 1"
                        },
                        new
                        {
                            Id = new Guid("c5444152-d541-4989-99b2-19ac6ed9125f"),
                            Name = "Feature 2"
                        },
                        new
                        {
                            Id = new Guid("a62f2406-ef12-48ff-ba14-c2ddb04754d8"),
                            Name = "Feature 3"
                        });
                });

            modelBuilder.Entity("Endpoint.Utilities.Models.LinkTables.VehicleFeature", b =>
                {
                    b.Property<Guid>("VehicleId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("FeatureId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("VehicleId", "FeatureId");

                    b.HasIndex("FeatureId");

                    b.ToTable("VehicleFeatures");
                });

            modelBuilder.Entity("Endpoint.Utilities.Models.Make", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Id");

                    b.ToTable("Makes");

                    b.HasData(
                        new
                        {
                            Id = new Guid("b7f26ac9-5b71-497f-b0a5-5c683e267181"),
                            Name = "Make 1"
                        },
                        new
                        {
                            Id = new Guid("b9c77744-3064-4d72-b349-ba12a23fecf7"),
                            Name = "Make 2"
                        },
                        new
                        {
                            Id = new Guid("b4b83d92-d0ac-4bf9-8fae-8fe52284dd9a"),
                            Name = "Make 3"
                        });
                });

            modelBuilder.Entity("Endpoint.Utilities.Models.Model", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("MakeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("MakeId");

                    b.ToTable("Models");

                    b.HasData(
                        new
                        {
                            Id = new Guid("42532caa-0a7f-4556-bcb2-43113ddb7386"),
                            MakeId = new Guid("b7f26ac9-5b71-497f-b0a5-5c683e267181"),
                            Name = "ModelA-Make1"
                        },
                        new
                        {
                            Id = new Guid("acb956e0-7a1f-48c1-b100-7e9f35d9411b"),
                            MakeId = new Guid("b7f26ac9-5b71-497f-b0a5-5c683e267181"),
                            Name = "ModelB-Make1"
                        },
                        new
                        {
                            Id = new Guid("e0799875-c7cd-4c34-b119-9ce3d9f5f742"),
                            MakeId = new Guid("b7f26ac9-5b71-497f-b0a5-5c683e267181"),
                            Name = "ModelC-Make1"
                        },
                        new
                        {
                            Id = new Guid("5f708c2e-5497-4b8f-a8e2-d393d7ef1540"),
                            MakeId = new Guid("b9c77744-3064-4d72-b349-ba12a23fecf7"),
                            Name = "ModelA-Make2"
                        },
                        new
                        {
                            Id = new Guid("c956850a-e488-420f-8611-dd30849aaa8e"),
                            MakeId = new Guid("b9c77744-3064-4d72-b349-ba12a23fecf7"),
                            Name = "ModelB-Make2"
                        },
                        new
                        {
                            Id = new Guid("91414760-4cef-4da4-8c91-00e2b18078b2"),
                            MakeId = new Guid("b9c77744-3064-4d72-b349-ba12a23fecf7"),
                            Name = "ModelC-Make2"
                        },
                        new
                        {
                            Id = new Guid("e5c7929a-956d-4e29-9b86-22f472430933"),
                            MakeId = new Guid("b4b83d92-d0ac-4bf9-8fae-8fe52284dd9a"),
                            Name = "ModelA-Make3"
                        },
                        new
                        {
                            Id = new Guid("c06435a9-1913-4a52-a415-01c93753c388"),
                            MakeId = new Guid("b4b83d92-d0ac-4bf9-8fae-8fe52284dd9a"),
                            Name = "ModelB-Make3"
                        },
                        new
                        {
                            Id = new Guid("c2dc45ee-9bb0-42e9-b625-aeddc53da952"),
                            MakeId = new Guid("b4b83d92-d0ac-4bf9-8fae-8fe52284dd9a"),
                            Name = "ModelC-Make3"
                        });
                });

            modelBuilder.Entity("Endpoint.Utilities.Models.Vehicle", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsRegistered")
                        .HasColumnType("bit");

                    b.Property<DateTime>("LastUpdated")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("ModelId")
                        .HasColumnType("uniqueidentifier");

                    b.ComplexProperty<Dictionary<string, object>>("Contact", "Endpoint.Utilities.Models.Vehicle.Contact#Contact", b1 =>
                        {
                            b1.IsRequired();

                            b1.Property<string>("Email")
                                .HasMaxLength(255)
                                .HasColumnType("nvarchar(255)");

                            b1.Property<string>("Name")
                                .IsRequired()
                                .HasMaxLength(255)
                                .HasColumnType("nvarchar(255)");

                            b1.Property<string>("Phone")
                                .IsRequired()
                                .HasMaxLength(255)
                                .HasColumnType("nvarchar(255)");
                        });

                    b.HasKey("Id");

                    b.HasIndex("ModelId");

                    b.ToTable("Vehicles");
                });

            modelBuilder.Entity("Endpoint.Utilities.Models.LinkTables.VehicleFeature", b =>
                {
                    b.HasOne("Endpoint.Utilities.Models.Feature", "Feature")
                        .WithMany("Vehicles")
                        .HasForeignKey("FeatureId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Endpoint.Utilities.Models.Vehicle", "Vehicle")
                        .WithMany("Features")
                        .HasForeignKey("VehicleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Feature");

                    b.Navigation("Vehicle");
                });

            modelBuilder.Entity("Endpoint.Utilities.Models.Model", b =>
                {
                    b.HasOne("Endpoint.Utilities.Models.Make", "Make")
                        .WithMany("Models")
                        .HasForeignKey("MakeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Make");
                });

            modelBuilder.Entity("Endpoint.Utilities.Models.Vehicle", b =>
                {
                    b.HasOne("Endpoint.Utilities.Models.Model", "Model")
                        .WithMany("Vehicles")
                        .HasForeignKey("ModelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Model");
                });

            modelBuilder.Entity("Endpoint.Utilities.Models.Feature", b =>
                {
                    b.Navigation("Vehicles");
                });

            modelBuilder.Entity("Endpoint.Utilities.Models.Make", b =>
                {
                    b.Navigation("Models");
                });

            modelBuilder.Entity("Endpoint.Utilities.Models.Model", b =>
                {
                    b.Navigation("Vehicles");
                });

            modelBuilder.Entity("Endpoint.Utilities.Models.Vehicle", b =>
                {
                    b.Navigation("Features");
                });
#pragma warning restore 612, 618
        }
    }
}
