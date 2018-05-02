﻿// <auto-generated />
using MakeupRetailSearcher.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace MakeupRetailSearcher.Migrations
{
    [DbContext(typeof(MakeupContext))]
    [Migration("20180502181726_Second")]
    partial class Second
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MakeupRetailSearcher.Models.Makeup", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Brand");

                    b.Property<string>("Link");

                    b.Property<double>("Price");

                    b.Property<int>("Product_Id");

                    b.Property<string>("Product_Name");

                    b.Property<int>("Retailer_Id");

                    b.Property<string>("Type");

                    b.HasKey("ID");

                    b.ToTable("Makeup");
                });

            modelBuilder.Entity("MakeupRetailSearcher.Models.Retailer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Retailer_Name");

                    b.Property<int>("Retailer_id");

                    b.HasKey("Id");

                    b.ToTable("Retailer");
                });
#pragma warning restore 612, 618
        }
    }
}
