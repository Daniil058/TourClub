﻿// <auto-generated />
using System;
using EquipmentStorage.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace EquipmentStorage.Migrations
{
    [DbContext(typeof(EquipmentStorageContext))]
    [Migration("20231228010454_MyAwesomeMigration5")]
    partial class MyAwesomeMigration5
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("EquipmentStorage.Data.Models.Booking", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int?>("EquipmentId")
                        .HasColumnType("integer")
                        .HasColumnName("equipment_id");

                    b.Property<DateTime>("FinishBookingDate")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("finish_booking_date");

                    b.Property<DateTime>("RequestDate")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("request_date");

                    b.Property<DateTime>("StartBookingDate")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("start_booking_date");

                    b.Property<int>("StatusBookingId")
                        .HasColumnType("integer")
                        .HasColumnName("status_booking_id");

                    b.Property<int>("UserId")
                        .HasColumnType("integer")
                        .HasColumnName("user_id");

                    b.HasKey("Id")
                        .HasName("pk_booking");

                    b.HasIndex("EquipmentId")
                        .HasDatabaseName("ix_booking_equipment_id");

                    b.HasIndex("StatusBookingId")
                        .HasDatabaseName("ix_booking_status_booking_id");

                    b.HasIndex("UserId")
                        .HasDatabaseName("ix_booking_user_id");

                    b.ToTable("booking");
                });

            modelBuilder.Entity("EquipmentStorage.Data.Models.CategoryEquipment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("category");

                    b.Property<string>("Orientation")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("orientation");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("type");

                    b.HasKey("Id")
                        .HasName("pk_category_equipment");

                    b.ToTable("category_equipment");
                });

            modelBuilder.Entity("EquipmentStorage.Data.Models.Condition", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.HasKey("Id")
                        .HasName("pk_condition");

                    b.ToTable("condition");
                });

            modelBuilder.Entity("EquipmentStorage.Data.Models.Equipment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("CategoryEquipmentId")
                        .HasColumnType("integer")
                        .HasColumnName("category_equipment_id");

                    b.Property<string>("Color")
                        .HasColumnType("text")
                        .HasColumnName("color");

                    b.Property<int>("ConditionId")
                        .HasColumnType("integer")
                        .HasColumnName("condition_id");

                    b.Property<float?>("Cost")
                        .HasColumnType("real")
                        .HasColumnName("cost");

                    b.Property<float?>("Cost_rent")
                        .HasColumnType("real")
                        .HasColumnName("cost_rent");

                    b.Property<string>("Description")
                        .HasColumnType("text")
                        .HasColumnName("description");

                    b.Property<int>("InventoryNumber")
                        .HasColumnType("integer")
                        .HasColumnName("inventory_number");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.Property<string>("PhotoPath")
                        .HasColumnType("text")
                        .HasColumnName("photo_path");

                    b.Property<string>("Problems")
                        .HasColumnType("text")
                        .HasColumnName("problems");

                    b.Property<string>("Producer")
                        .HasColumnType("text")
                        .HasColumnName("producer");

                    b.Property<DateTime?>("ProductionDate")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("production_date");

                    b.Property<string>("Property1")
                        .HasColumnType("text")
                        .HasColumnName("property1");

                    b.Property<string>("Property2")
                        .HasColumnType("text")
                        .HasColumnName("property2");

                    b.Property<string>("StorageLocation")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("storage_location");

                    b.Property<float?>("Weight")
                        .HasColumnType("real")
                        .HasColumnName("weight");

                    b.HasKey("Id")
                        .HasName("pk_equipment");

                    b.HasIndex("CategoryEquipmentId")
                        .HasDatabaseName("ix_equipment_category_equipment_id");

                    b.HasIndex("ConditionId")
                        .HasDatabaseName("ix_equipment_condition_id");

                    b.ToTable("equipment");
                });

            modelBuilder.Entity("EquipmentStorage.Data.Models.Interest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.Property<int?>("UserInterestId")
                        .HasColumnType("integer")
                        .HasColumnName("user_interest_id");

                    b.HasKey("Id")
                        .HasName("pk_interest");

                    b.HasIndex("UserInterestId")
                        .HasDatabaseName("ix_interest_user_interest_id");

                    b.ToTable("interest");
                });

            modelBuilder.Entity("EquipmentStorage.Data.Models.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.HasKey("Id")
                        .HasName("pk_role");

                    b.ToTable("role");
                });

            modelBuilder.Entity("EquipmentStorage.Data.Models.StatusBooking", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.HasKey("Id")
                        .HasName("pk_status_booking");

                    b.ToTable("status_booking");
                });

            modelBuilder.Entity("EquipmentStorage.Data.Models.UserAuth", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Email")
                        .HasColumnType("text")
                        .HasColumnName("email");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("login");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("password");

                    b.Property<string>("Phone")
                        .HasColumnType("text")
                        .HasColumnName("phone");

                    b.Property<int>("RoleId")
                        .HasColumnType("integer")
                        .HasColumnName("role_id");

                    b.HasKey("Id")
                        .HasName("pk_user_auth");

                    b.HasIndex("RoleId")
                        .HasDatabaseName("ix_user_auth_role_id");

                    b.ToTable("user_auth");
                });

            modelBuilder.Entity("EquipmentStorage.Data.Models.UserDescription", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime?>("Birthday")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("birthday");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.Property<string>("Patronymic")
                        .HasColumnType("text")
                        .HasColumnName("patronymic");

                    b.Property<int?>("RoleId")
                        .HasColumnType("integer")
                        .HasColumnName("role_id");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("surname");

                    b.HasKey("Id")
                        .HasName("pk_user_description");

                    b.HasIndex("RoleId")
                        .HasDatabaseName("ix_user_description_role_id");

                    b.ToTable("user_description");
                });

            modelBuilder.Entity("EquipmentStorage.Data.Models.UserInterest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("UserId")
                        .HasColumnType("integer")
                        .HasColumnName("user_id");

                    b.HasKey("Id")
                        .HasName("pk_user_interest");

                    b.ToTable("user_interest");
                });

            modelBuilder.Entity("InterestUserDescription", b =>
                {
                    b.Property<int>("InterestsId")
                        .HasColumnType("integer")
                        .HasColumnName("interests_id");

                    b.Property<int>("UsersId")
                        .HasColumnType("integer")
                        .HasColumnName("users_id");

                    b.HasKey("InterestsId", "UsersId")
                        .HasName("pk_interest_user_description");

                    b.HasIndex("UsersId")
                        .HasDatabaseName("ix_interest_user_description_users_id");

                    b.ToTable("interest_user_description");
                });

            modelBuilder.Entity("EquipmentStorage.Data.Models.Booking", b =>
                {
                    b.HasOne("EquipmentStorage.Data.Models.Equipment", "Equipment")
                        .WithMany()
                        .HasForeignKey("EquipmentId")
                        .HasConstraintName("fk_booking_equipment_equipment_id");

                    b.HasOne("EquipmentStorage.Data.Models.StatusBooking", "StatusBooking")
                        .WithMany("Bookings")
                        .HasForeignKey("StatusBookingId")
                        .HasConstraintName("fk_booking_status_booking_status_booking_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EquipmentStorage.Data.Models.UserDescription", "User")
                        .WithMany("Bookings")
                        .HasForeignKey("UserId")
                        .HasConstraintName("fk_booking_user_description_user_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Equipment");

                    b.Navigation("StatusBooking");

                    b.Navigation("User");
                });

            modelBuilder.Entity("EquipmentStorage.Data.Models.Equipment", b =>
                {
                    b.HasOne("EquipmentStorage.Data.Models.CategoryEquipment", "CategoryEquipment")
                        .WithMany("Equipments")
                        .HasForeignKey("CategoryEquipmentId")
                        .HasConstraintName("fk_equipment_category_equipment_category_equipment_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EquipmentStorage.Data.Models.Condition", "Condition")
                        .WithMany("Equipments")
                        .HasForeignKey("ConditionId")
                        .HasConstraintName("fk_equipment_condition_condition_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CategoryEquipment");

                    b.Navigation("Condition");
                });

            modelBuilder.Entity("EquipmentStorage.Data.Models.Interest", b =>
                {
                    b.HasOne("EquipmentStorage.Data.Models.UserInterest", null)
                        .WithMany("Interest")
                        .HasForeignKey("UserInterestId")
                        .HasConstraintName("fk_interest_user_interest_user_interest_id");
                });

            modelBuilder.Entity("EquipmentStorage.Data.Models.UserAuth", b =>
                {
                    b.HasOne("EquipmentStorage.Data.Models.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .HasConstraintName("fk_user_auth_role_role_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("EquipmentStorage.Data.Models.UserDescription", b =>
                {
                    b.HasOne("EquipmentStorage.Data.Models.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .HasConstraintName("fk_user_description_role_role_id");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("InterestUserDescription", b =>
                {
                    b.HasOne("EquipmentStorage.Data.Models.Interest", null)
                        .WithMany()
                        .HasForeignKey("InterestsId")
                        .HasConstraintName("fk_interest_user_description_interest_interests_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EquipmentStorage.Data.Models.UserDescription", null)
                        .WithMany()
                        .HasForeignKey("UsersId")
                        .HasConstraintName("fk_interest_user_description_user_description_users_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EquipmentStorage.Data.Models.CategoryEquipment", b =>
                {
                    b.Navigation("Equipments");
                });

            modelBuilder.Entity("EquipmentStorage.Data.Models.Condition", b =>
                {
                    b.Navigation("Equipments");
                });

            modelBuilder.Entity("EquipmentStorage.Data.Models.Role", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("EquipmentStorage.Data.Models.StatusBooking", b =>
                {
                    b.Navigation("Bookings");
                });

            modelBuilder.Entity("EquipmentStorage.Data.Models.UserDescription", b =>
                {
                    b.Navigation("Bookings");
                });

            modelBuilder.Entity("EquipmentStorage.Data.Models.UserInterest", b =>
                {
                    b.Navigation("Interest");
                });
#pragma warning restore 612, 618
        }
    }
}
