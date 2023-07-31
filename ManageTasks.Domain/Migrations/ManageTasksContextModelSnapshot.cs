// <auto-generated />
using System;
using ManageTasks.Domain.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ManageTasks.Domain.Migrations
{
    [DbContext(typeof(ManageTasksContext))]
    partial class ManageTasksContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ManageTasks.Domain.Entities.TaskEntity", b =>
                {
                    b.Property<Guid>("TaskId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("NEWID()");

                    b.Property<string>("Action")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTimeOffset>("Created")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetimeoffset")
                        .HasDefaultValueSql("GETUTCDATE()");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<byte[]>("Version")
                        .IsConcurrencyToken()
                        .IsRequired()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.HasKey("TaskId");

                    b.ToTable("Task", "dbo");

                    b.HasData(
                        new
                        {
                            TaskId = new Guid("5d84ed88-8078-4825-b740-02bd71d5346a"),
                            Action = "Tocar la guitarra",
                            Created = new DateTimeOffset(new DateTime(2023, 5, 11, 15, 30, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)),
                            Status = 0
                        },
                        new
                        {
                            TaskId = new Guid("a9741f3a-baea-4211-90de-f2fa53c9caa2"),
                            Action = "Practicar la calistenia",
                            Created = new DateTimeOffset(new DateTime(2023, 6, 8, 10, 42, 10, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)),
                            Status = 0
                        },
                        new
                        {
                            TaskId = new Guid("ef839c0b-0e57-4bbe-be29-be1c501e82bb"),
                            Action = "Leer \"Menos miedos más Riquezas\"",
                            Created = new DateTimeOffset(new DateTime(2023, 7, 1, 12, 0, 44, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)),
                            Status = 1
                        },
                        new
                        {
                            TaskId = new Guid("24e01e15-3f23-49e0-b177-0b325ec2af9c"),
                            Action = "Meditar en la noche",
                            Created = new DateTimeOffset(new DateTime(2023, 7, 17, 19, 27, 50, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)),
                            Status = 0
                        },
                        new
                        {
                            TaskId = new Guid("49cf31ba-32dc-4ded-817c-f9b5c71c968c"),
                            Action = "Pasear a mi Pit Bull",
                            Created = new DateTimeOffset(new DateTime(2023, 7, 28, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)),
                            Status = 1
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
