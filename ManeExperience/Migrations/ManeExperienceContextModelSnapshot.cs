using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using ManeExperience.Models;

namespace ManeExperience.Migrations
{
    [DbContext(typeof(ManeExperienceContext))]
    partial class ManeExperienceContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ManeExperience.Models.Events", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("EventCreated");

                    b.Property<string>("EventCreatedBy");

                    b.Property<DateTime>("EventDate");

                    b.Property<string>("EventDetails");

                    b.Property<string>("EventInfo");

                    b.Property<string>("EventTime");

                    b.Property<string>("EventTitle");

                    b.HasKey("ID");

                    b.ToTable("Events");
                });
        }
    }
}
