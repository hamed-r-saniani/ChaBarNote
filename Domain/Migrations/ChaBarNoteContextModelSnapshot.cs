﻿// <auto-generated />
using Domain.DataModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Domain.Migrations
{
    [DbContext(typeof(ChaBarNoteContext))]
    partial class ChaBarNoteContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Domain.DataModel.Admin", b =>
                {
                    b.Property<int>("AdminId")
                        .HasColumnName("AdminID");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.Property<string>("Token");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.HasKey("AdminId");

                    b.ToTable("Admin");
                });

            modelBuilder.Entity("Domain.DataModel.Folder", b =>
                {
                    b.Property<int>("FolderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("FolderID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("UserId")
                        .HasColumnName("UserID");

                    b.Property<string>("FolderName")
                        .IsRequired()
                        .HasMaxLength(10)
                        .IsUnicode(false);

                    b.Property<int>("ParentId")
                        .HasColumnName("ParentID");

                    b.HasKey("FolderId", "UserId");

                    b.ToTable("Folder");
                });

            modelBuilder.Entity("Domain.DataModel.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("UserID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    b.Property<int>("State");

                    b.Property<string>("Token");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(10)
                        .IsUnicode(false);

                    b.HasKey("UserId");

                    b.ToTable("User");
                });

            modelBuilder.Entity("Domain.DataModel.UserState", b =>
                {
                    b.Property<int>("UserStateId")
                        .HasColumnName("UserStateID");

                    b.Property<string>("Type")
                        .HasMaxLength(5)
                        .IsUnicode(false);

                    b.HasKey("UserStateId");

                    b.ToTable("UserState");
                });
#pragma warning restore 612, 618
        }
    }
}
