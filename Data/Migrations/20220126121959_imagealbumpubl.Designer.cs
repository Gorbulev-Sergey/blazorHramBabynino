﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using blazorHramBabynino.Data;

namespace blazorHramBabynino.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220126121959_imagealbumpubl")]
    partial class imagealbumpubl
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("posttag", b =>
                {
                    b.Property<int>("postsID")
                        .HasColumnType("int");

                    b.Property<int>("tagsID")
                        .HasColumnType("int");

                    b.HasKey("postsID", "tagsID");

                    b.HasIndex("tagsID");

                    b.ToTable("posttag");
                });

            modelBuilder.Entity("blazorHramBabynino.Models.comment", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("created")
                        .HasColumnType("datetime2");

                    b.Property<int?>("imageAlbumID")
                        .HasColumnType("int");

                    b.Property<int?>("postID")
                        .HasColumnType("int");

                    b.Property<string>("text")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("userId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("userName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("imageAlbumID");

                    b.HasIndex("postID");

                    b.HasIndex("userId");

                    b.ToTable("comments");
                });

            modelBuilder.Entity("blazorHramBabynino.Models.image", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("created")
                        .HasColumnType("datetime2");

                    b.Property<int?>("imageAlbumID")
                        .HasColumnType("int");

                    b.Property<int?>("postID")
                        .HasColumnType("int");

                    b.Property<string>("title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("url")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("imageAlbumID");

                    b.HasIndex("postID");

                    b.ToTable("images");
                });

            modelBuilder.Entity("blazorHramBabynino.Models.imageAlbum", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("cover_image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("created")
                        .HasColumnType("datetime2");

                    b.Property<string>("description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("published")
                        .HasColumnType("bit");

                    b.Property<string>("title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("userId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("ID");

                    b.HasIndex("userId");

                    b.ToTable("imageAlbums");
                });

            modelBuilder.Entity("blazorHramBabynino.Models.like", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("created")
                        .HasColumnType("datetime2");

                    b.Property<int?>("imageAlbumID")
                        .HasColumnType("int");

                    b.Property<int?>("postID")
                        .HasColumnType("int");

                    b.Property<string>("userId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("ID");

                    b.HasIndex("imageAlbumID");

                    b.HasIndex("postID");

                    b.HasIndex("userId");

                    b.ToTable("likes");
                });

            modelBuilder.Entity("blazorHramBabynino.Models.post", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("cover_image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("cover_video")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("created")
                        .HasColumnType("datetime2");

                    b.Property<string>("description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("published")
                        .HasColumnType("bit");

                    b.Property<string>("title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("type")
                        .HasColumnType("int");

                    b.Property<string>("userId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("ID");

                    b.HasIndex("userId");

                    b.ToTable("posts");
                });

            modelBuilder.Entity("blazorHramBabynino.Models.schedule_string", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("date_and_time")
                        .HasColumnType("datetime2");

                    b.Property<string>("description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("prayer")
                        .HasColumnType("int");

                    b.Property<string>("userId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("тип_праздника")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("userId");

                    b.ToTable("schedule");
                });

            modelBuilder.Entity("blazorHramBabynino.Models.tag", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("bg_color")
                        .HasColumnType("int");

                    b.Property<DateTime>("created")
                        .HasColumnType("datetime2");

                    b.Property<string>("description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("text_color")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("tags");
                });

            modelBuilder.Entity("blazorHramBabynino.Models.user", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("blazorHramBabynino.Models.video", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("created")
                        .HasColumnType("datetime2");

                    b.Property<int?>("postID")
                        .HasColumnType("int");

                    b.Property<string>("url")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("postID");

                    b.ToTable("videos");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("blazorHramBabynino.Models.user", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("blazorHramBabynino.Models.user", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("blazorHramBabynino.Models.user", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("blazorHramBabynino.Models.user", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("posttag", b =>
                {
                    b.HasOne("blazorHramBabynino.Models.post", null)
                        .WithMany()
                        .HasForeignKey("postsID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("blazorHramBabynino.Models.tag", null)
                        .WithMany()
                        .HasForeignKey("tagsID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("blazorHramBabynino.Models.comment", b =>
                {
                    b.HasOne("blazorHramBabynino.Models.imageAlbum", null)
                        .WithMany("comments")
                        .HasForeignKey("imageAlbumID");

                    b.HasOne("blazorHramBabynino.Models.post", null)
                        .WithMany("comments")
                        .HasForeignKey("postID");

                    b.HasOne("blazorHramBabynino.Models.user", null)
                        .WithMany("comments")
                        .HasForeignKey("userId");
                });

            modelBuilder.Entity("blazorHramBabynino.Models.image", b =>
                {
                    b.HasOne("blazorHramBabynino.Models.imageAlbum", null)
                        .WithMany("images")
                        .HasForeignKey("imageAlbumID");

                    b.HasOne("blazorHramBabynino.Models.post", null)
                        .WithMany("images")
                        .HasForeignKey("postID");
                });

            modelBuilder.Entity("blazorHramBabynino.Models.imageAlbum", b =>
                {
                    b.HasOne("blazorHramBabynino.Models.user", null)
                        .WithMany("imageAlbums")
                        .HasForeignKey("userId");
                });

            modelBuilder.Entity("blazorHramBabynino.Models.like", b =>
                {
                    b.HasOne("blazorHramBabynino.Models.imageAlbum", null)
                        .WithMany("likes")
                        .HasForeignKey("imageAlbumID");

                    b.HasOne("blazorHramBabynino.Models.post", null)
                        .WithMany("likes")
                        .HasForeignKey("postID");

                    b.HasOne("blazorHramBabynino.Models.user", null)
                        .WithMany("likes")
                        .HasForeignKey("userId");
                });

            modelBuilder.Entity("blazorHramBabynino.Models.post", b =>
                {
                    b.HasOne("blazorHramBabynino.Models.user", null)
                        .WithMany("posts")
                        .HasForeignKey("userId");
                });

            modelBuilder.Entity("blazorHramBabynino.Models.schedule_string", b =>
                {
                    b.HasOne("blazorHramBabynino.Models.user", null)
                        .WithMany("schedule")
                        .HasForeignKey("userId");
                });

            modelBuilder.Entity("blazorHramBabynino.Models.video", b =>
                {
                    b.HasOne("blazorHramBabynino.Models.post", null)
                        .WithMany("videos")
                        .HasForeignKey("postID");
                });

            modelBuilder.Entity("blazorHramBabynino.Models.imageAlbum", b =>
                {
                    b.Navigation("comments");

                    b.Navigation("images");

                    b.Navigation("likes");
                });

            modelBuilder.Entity("blazorHramBabynino.Models.post", b =>
                {
                    b.Navigation("comments");

                    b.Navigation("images");

                    b.Navigation("likes");

                    b.Navigation("videos");
                });

            modelBuilder.Entity("blazorHramBabynino.Models.user", b =>
                {
                    b.Navigation("comments");

                    b.Navigation("imageAlbums");

                    b.Navigation("likes");

                    b.Navigation("posts");

                    b.Navigation("schedule");
                });
#pragma warning restore 612, 618
        }
    }
}
