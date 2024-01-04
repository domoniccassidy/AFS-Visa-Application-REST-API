﻿// <auto-generated />
using System;
using AFS_Visa_Application_REST_API.Db;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AFS_Visa_Application_REST_API.Migrations
{
    [DbContext(typeof(VisaApplicationContext))]
    [Migration("20240104143215_Documentation-Required")]
    partial class DocumentationRequired
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AFS_Visa_Application_REST_API.Entity.Country", b =>
                {
                    b.Property<Guid>("CountryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CountryId");

                    b.ToTable("Country");
                });

            modelBuilder.Entity("AFS_Visa_Application_REST_API.Entity.DocumentationRequired", b =>
                {
                    b.Property<Guid>("DocumentationRequiredId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DocumentationTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FileType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DocumentationRequiredId");

                    b.ToTable("DocumentationRequired");
                });

            modelBuilder.Entity("AFS_Visa_Application_REST_API.Entity.Visa", b =>
                {
                    b.Property<Guid>("VisaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("AppointmentRequired")
                        .HasColumnType("bit");

                    b.Property<Guid>("CountryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("DaysValid")
                        .HasColumnType("int");

                    b.Property<int?>("EntryTimes")
                        .HasColumnType("int");

                    b.Property<float>("Price")
                        .HasColumnType("real");

                    b.Property<string>("VisaType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("VisaId");

                    b.HasIndex("CountryId");

                    b.ToTable("Visa");
                });

            modelBuilder.Entity("AFS_Visa_Application_REST_API.Entity.VisaApplication", b =>
                {
                    b.Property<Guid>("VisaApplicationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AgentAssignedToId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ApplicantId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("AppointmentDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("DestinationCountryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("OriginCountryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("VisaId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("VisaApplicationId");

                    b.HasIndex("VisaId");

                    b.ToTable("VisaApplication");
                });

            modelBuilder.Entity("CountryVisa", b =>
                {
                    b.Property<Guid>("CountriesExemptCountryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("VisasExemptVisaId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("CountriesExemptCountryId", "VisasExemptVisaId");

                    b.HasIndex("VisasExemptVisaId");

                    b.ToTable("CountryExemption", (string)null);
                });

            modelBuilder.Entity("DocumentationRequiredVisa", b =>
                {
                    b.Property<Guid>("DocumentationRequiredId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("VisaId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("DocumentationRequiredId", "VisaId");

                    b.HasIndex("VisaId");

                    b.ToTable("DocumentationRequiredVisa");
                });

            modelBuilder.Entity("AFS_Visa_Application_REST_API.Entity.Visa", b =>
                {
                    b.HasOne("AFS_Visa_Application_REST_API.Entity.Country", "OfferingCountry")
                        .WithMany("VisasOffered")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("OfferingCountry");
                });

            modelBuilder.Entity("AFS_Visa_Application_REST_API.Entity.VisaApplication", b =>
                {
                    b.HasOne("AFS_Visa_Application_REST_API.Entity.Visa", "Visa")
                        .WithMany("VisaApplications")
                        .HasForeignKey("VisaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Visa");
                });

            modelBuilder.Entity("CountryVisa", b =>
                {
                    b.HasOne("AFS_Visa_Application_REST_API.Entity.Country", null)
                        .WithMany()
                        .HasForeignKey("CountriesExemptCountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AFS_Visa_Application_REST_API.Entity.Visa", null)
                        .WithMany()
                        .HasForeignKey("VisasExemptVisaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DocumentationRequiredVisa", b =>
                {
                    b.HasOne("AFS_Visa_Application_REST_API.Entity.DocumentationRequired", null)
                        .WithMany()
                        .HasForeignKey("DocumentationRequiredId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AFS_Visa_Application_REST_API.Entity.Visa", null)
                        .WithMany()
                        .HasForeignKey("VisaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AFS_Visa_Application_REST_API.Entity.Country", b =>
                {
                    b.Navigation("VisasOffered");
                });

            modelBuilder.Entity("AFS_Visa_Application_REST_API.Entity.Visa", b =>
                {
                    b.Navigation("VisaApplications");
                });
#pragma warning restore 612, 618
        }
    }
}
