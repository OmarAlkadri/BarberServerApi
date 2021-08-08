﻿// <auto-generated />
using System;
using BarberServerApi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BarberServerApi.Migrations
{
    [DbContext(typeof(My_Graduation_Project_DBContext))]
    partial class My_Graduation_Project_DBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.8")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BarberServerApi.Models.Barber", b =>
                {
                    b.Property<int>("BarberId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BarberShowName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("CertificationImgUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ContactInfoId")
                        .HasColumnType("int");

                    b.Property<int?>("PersonnelId")
                        .HasColumnType("int");

                    b.HasKey("BarberId");

                    b.HasIndex("ContactInfoId");

                    b.HasIndex("PersonnelId");

                    b.ToTable("Barber");
                });

            modelBuilder.Entity("BarberServerApi.Models.Comments", b =>
                {
                    b.Property<int>("CommentsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BarberId")
                        .HasColumnType("int");

                    b.Property<string>("Comments1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("EntityPostId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("CommentsId");

                    b.HasIndex("BarberId");

                    b.HasIndex("EntityPostId");

                    b.HasIndex("UserId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("BarberServerApi.Models.ContactInfo", b =>
                {
                    b.Property<int>("ContactInfoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("DistrictId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("PersonnelId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("StreetAvenueName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ContactInfoId");

                    b.HasIndex("DistrictId");

                    b.HasIndex("PersonnelId");

                    b.ToTable("ContactInfo");
                });

            modelBuilder.Entity("BarberServerApi.Models.District", b =>
                {
                    b.Property<int>("DistrictId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DistrictName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NeighborhoodId")
                        .HasColumnType("int");

                    b.HasKey("DistrictId");

                    b.HasIndex("NeighborhoodId");

                    b.ToTable("District");
                });

            modelBuilder.Entity("BarberServerApi.Models.EntityPost", b =>
                {
                    b.Property<int>("EntityPostId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("EntityImgVideoUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EntityPostText")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<TimeSpan?>("EntityPostTime")
                        .IsRequired()
                        .HasColumnType("time");

                    b.HasKey("EntityPostId");

                    b.ToTable("EntityPost");
                });

            modelBuilder.Entity("BarberServerApi.Models.Likes", b =>
                {
                    b.Property<int>("LikesId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("EntityPostId")
                        .HasColumnType("int");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("likes")
                        .HasColumnType("int");

                    b.HasKey("LikesId");

                    b.HasIndex("EntityPostId");

                    b.HasIndex("UserId");

                    b.ToTable("Likes");
                });

            modelBuilder.Entity("BarberServerApi.Models.Neighborhood", b =>
                {
                    b.Property<int>("NeighborhoodId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NeighborhoodName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProvinceId")
                        .HasColumnType("int");

                    b.HasKey("NeighborhoodId");

                    b.HasIndex("ProvinceId");

                    b.ToTable("Neighborhood");
                });

            modelBuilder.Entity("BarberServerApi.Models.PayingOff", b =>
                {
                    b.Property<int>("PayingOffId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<TimeSpan>("PayingTime")
                        .HasColumnType("time");

                    b.HasKey("PayingOffId");

                    b.ToTable("PayingOff");
                });

            modelBuilder.Entity("BarberServerApi.Models.Personnel", b =>
                {
                    b.Property<int>("PersonnelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("PersonelGender")
                        .HasColumnType("int");

                    b.Property<string>("PersonnelImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PersonnelMaill")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PersonnelName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PersonnelPassword")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PersonnelPhone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PersonnelSurname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PersonnelId");

                    b.ToTable("Personnel");
                });

            modelBuilder.Entity("BarberServerApi.Models.Province", b =>
                {
                    b.Property<int>("ProvinceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ProvinceName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProvinceId");

                    b.ToTable("Province");
                });

            modelBuilder.Entity("BarberServerApi.Models.Reservation", b =>
                {
                    b.Property<int>("ReservationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("PayingOffId")
                        .HasColumnType("int");

                    b.Property<TimeSpan>("ReservationTime")
                        .HasColumnType("time");

                    b.HasKey("ReservationId");

                    b.HasIndex("PayingOffId");

                    b.ToTable("Reservation");
                });

            modelBuilder.Entity("BarberServerApi.Models.ReservationBarber", b =>
                {
                    b.Property<int>("ReservationBarberId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BarberId")
                        .HasColumnType("int");

                    b.Property<int>("ReservationId")
                        .HasColumnType("int");

                    b.Property<string>("ReservationType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<bool>("reservationStatus")
                        .HasColumnType("bit");

                    b.HasKey("ReservationBarberId");

                    b.HasIndex("BarberId");

                    b.HasIndex("ReservationId");

                    b.HasIndex("UserId");

                    b.ToTable("ReservationBarber");
                });

            modelBuilder.Entity("BarberServerApi.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("PersonnelId")
                        .HasColumnType("int");

                    b.Property<int>("yas")
                        .HasColumnType("int");

                    b.HasKey("UserId");

                    b.HasIndex("PersonnelId");

                    b.ToTable("User");
                });

            modelBuilder.Entity("BarberServerApi.Models.Barber", b =>
                {
                    b.HasOne("BarberServerApi.Models.ContactInfo", "ContactInfo")
                        .WithMany()
                        .HasForeignKey("ContactInfoId");

                    b.HasOne("BarberServerApi.Models.Personnel", "Personnel")
                        .WithMany("Barber")
                        .HasForeignKey("PersonnelId");

                    b.Navigation("ContactInfo");

                    b.Navigation("Personnel");
                });

            modelBuilder.Entity("BarberServerApi.Models.Comments", b =>
                {
                    b.HasOne("BarberServerApi.Models.Barber", null)
                        .WithMany("Comments")
                        .HasForeignKey("BarberId");

                    b.HasOne("BarberServerApi.Models.EntityPost", "EntityPost")
                        .WithMany("Comments")
                        .HasForeignKey("EntityPostId");

                    b.HasOne("BarberServerApi.Models.User", "User")
                        .WithMany("Comments")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EntityPost");

                    b.Navigation("User");
                });

            modelBuilder.Entity("BarberServerApi.Models.ContactInfo", b =>
                {
                    b.HasOne("BarberServerApi.Models.District", "District")
                        .WithMany("ContactInfo")
                        .HasForeignKey("DistrictId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BarberServerApi.Models.Personnel", "Personnel")
                        .WithMany()
                        .HasForeignKey("PersonnelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("District");

                    b.Navigation("Personnel");
                });

            modelBuilder.Entity("BarberServerApi.Models.District", b =>
                {
                    b.HasOne("BarberServerApi.Models.Neighborhood", "Neighborhood")
                        .WithMany("District")
                        .HasForeignKey("NeighborhoodId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Neighborhood");
                });

            modelBuilder.Entity("BarberServerApi.Models.Likes", b =>
                {
                    b.HasOne("BarberServerApi.Models.EntityPost", "EntityPost")
                        .WithMany("Likes")
                        .HasForeignKey("EntityPostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BarberServerApi.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("EntityPost");

                    b.Navigation("User");
                });

            modelBuilder.Entity("BarberServerApi.Models.Neighborhood", b =>
                {
                    b.HasOne("BarberServerApi.Models.Province", "Province")
                        .WithMany("Neighborhood")
                        .HasForeignKey("ProvinceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Province");
                });

            modelBuilder.Entity("BarberServerApi.Models.Reservation", b =>
                {
                    b.HasOne("BarberServerApi.Models.PayingOff", "Paying")
                        .WithMany("Reservation")
                        .HasForeignKey("PayingOffId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Paying");
                });

            modelBuilder.Entity("BarberServerApi.Models.ReservationBarber", b =>
                {
                    b.HasOne("BarberServerApi.Models.Barber", "Barber")
                        .WithMany("ReservationBarber")
                        .HasForeignKey("BarberId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BarberServerApi.Models.Reservation", "Reservation")
                        .WithMany("ReservationBarber")
                        .HasForeignKey("ReservationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BarberServerApi.Models.User", "User")
                        .WithMany("ReservationBarber")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Barber");

                    b.Navigation("Reservation");

                    b.Navigation("User");
                });

            modelBuilder.Entity("BarberServerApi.Models.User", b =>
                {
                    b.HasOne("BarberServerApi.Models.Personnel", "Personnel")
                        .WithMany("User")
                        .HasForeignKey("PersonnelId");

                    b.Navigation("Personnel");
                });

            modelBuilder.Entity("BarberServerApi.Models.Barber", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("ReservationBarber");
                });

            modelBuilder.Entity("BarberServerApi.Models.District", b =>
                {
                    b.Navigation("ContactInfo");
                });

            modelBuilder.Entity("BarberServerApi.Models.EntityPost", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("Likes");
                });

            modelBuilder.Entity("BarberServerApi.Models.Neighborhood", b =>
                {
                    b.Navigation("District");
                });

            modelBuilder.Entity("BarberServerApi.Models.PayingOff", b =>
                {
                    b.Navigation("Reservation");
                });

            modelBuilder.Entity("BarberServerApi.Models.Personnel", b =>
                {
                    b.Navigation("Barber");

                    b.Navigation("User");
                });

            modelBuilder.Entity("BarberServerApi.Models.Province", b =>
                {
                    b.Navigation("Neighborhood");
                });

            modelBuilder.Entity("BarberServerApi.Models.Reservation", b =>
                {
                    b.Navigation("ReservationBarber");
                });

            modelBuilder.Entity("BarberServerApi.Models.User", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("ReservationBarber");
                });
#pragma warning restore 612, 618
        }
    }
}
