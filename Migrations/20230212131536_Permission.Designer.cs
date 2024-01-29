﻿// <auto-generated />
using System;
using Identity.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Identity.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230212131536_Permission")]
    partial class Permission
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Identity.Data.Models.Permission", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("Permissions");

                    b.HasData(
                        new
                        {
                            Id = new Guid("b8ff867b-1979-44fb-86da-7ccfce4d052d"),
                            Name = "Transaction View"
                        },
                        new
                        {
                            Id = new Guid("22d17c90-7658-4120-a087-c1f30797f9f5"),
                            Name = "Transaction Edit"
                        },
                        new
                        {
                            Id = new Guid("b1f5a953-a3c0-40b7-9842-3ed29084aa27"),
                            Name = "Transaction Delete"
                        },
                        new
                        {
                            Id = new Guid("65ef9fb5-0a0f-4805-a712-66983b9ca33c"),
                            Name = "Staff View"
                        },
                        new
                        {
                            Id = new Guid("6989d9bc-b5df-4088-8e8e-e452bba3c098"),
                            Name = "Staff Edit"
                        },
                        new
                        {
                            Id = new Guid("d8fa6d21-4a0b-40c3-a4e7-0ab7a4559c49"),
                            Name = "Staff Delete"
                        },
                        new
                        {
                            Id = new Guid("f7ddd8d8-a96e-42f9-92f7-b92a8061aca0"),
                            Name = "Staff Create"
                        },
                        new
                        {
                            Id = new Guid("a2c9fcaa-560b-4bd4-88d7-727ec722e47e"),
                            Name = "Customer View"
                        },
                        new
                        {
                            Id = new Guid("0a31d551-2a1c-4941-aeec-a698b6678747"),
                            Name = "Customer Edit"
                        },
                        new
                        {
                            Id = new Guid("43eac5fd-7509-4cd5-83aa-17083ccbc577"),
                            Name = "Customer Delete"
                        },
                        new
                        {
                            Id = new Guid("b129d9aa-f6a9-4ed4-a50e-f3651a8633dc"),
                            Name = "Location View"
                        },
                        new
                        {
                            Id = new Guid("345011ad-de0a-492d-8706-06f877a6e202"),
                            Name = "Location Edit"
                        },
                        new
                        {
                            Id = new Guid("7b476fc8-e1cd-49bb-986d-db9bab72e003"),
                            Name = "Location Create"
                        },
                        new
                        {
                            Id = new Guid("04eb9f6c-570c-4f75-a1c3-505beb7583ff"),
                            Name = "Location Delete"
                        },
                        new
                        {
                            Id = new Guid("7de1e463-3e67-4ad0-94b8-09873030dc95"),
                            Name = "ExchangeRate View"
                        },
                        new
                        {
                            Id = new Guid("aad5c740-0b0b-485e-a488-5128a95d0a55"),
                            Name = "ExchangeRate Edit"
                        },
                        new
                        {
                            Id = new Guid("4e5e641b-d54d-4c8f-a0d1-23bb23bbb6d9"),
                            Name = "ExchangeRate Create"
                        },
                        new
                        {
                            Id = new Guid("c15dcb6f-a335-4518-afb4-33c83e94bc2f"),
                            Name = "ExchangeRate Delete"
                        });
                });

            modelBuilder.Entity("Identity.Data.Models.Role", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            Id = new Guid("fb52ee2d-0e69-47c5-856d-3a367c66378d"),
                            Name = "Admin"
                        },
                        new
                        {
                            Id = new Guid("b4b063e8-3dd1-4c46-815c-d2a0ea9cac0c"),
                            Name = "User"
                        },
                        new
                        {
                            Id = new Guid("796138b4-cc1c-4660-a6c9-18250cb20672"),
                            Name = "Business manager"
                        },
                        new
                        {
                            Id = new Guid("ae25cb3d-b983-44eb-a233-430684f37330"),
                            Name = "Customer services"
                        },
                        new
                        {
                            Id = new Guid("92053e15-bb56-4170-9198-6f944d3b008a"),
                            Name = "Compliance officer"
                        });
                });

            modelBuilder.Entity("Identity.Data.Models.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("HasPin")
                        .HasColumnType("bit");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsEmailVerified")
                        .HasColumnType("bit");

                    b.Property<bool>("IsKycVerified")
                        .HasColumnType("bit");

                    b.Property<bool>("IsProfileComplete")
                        .HasColumnType("bit");

                    b.Property<bool>("IsZaiUser")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MiddleName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pin")
                        .HasMaxLength(6)
                        .HasColumnType("nvarchar(6)");

                    b.Property<string>("PostalCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("RoleId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Identity.Data.Models.UserRefreshToken", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CustomerId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RefreshToken")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("UserRefreshTokens");
                });

            modelBuilder.Entity("Identity.Data.Models.UserToken", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Token")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("UserTokens");
                });

            modelBuilder.Entity("Identity.Data.Models.Permission", b =>
                {
                    b.HasOne("Identity.Data.Models.Role", null)
                        .WithMany("Permissions")
                        .HasForeignKey("RoleId");
                });

            modelBuilder.Entity("Identity.Data.Models.User", b =>
                {
                    b.HasOne("Identity.Data.Models.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("Identity.Data.Models.UserToken", b =>
                {
                    b.HasOne("Identity.Data.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Identity.Data.Models.Role", b =>
                {
                    b.Navigation("Permissions");
                });
#pragma warning restore 612, 618
        }
    }
}
