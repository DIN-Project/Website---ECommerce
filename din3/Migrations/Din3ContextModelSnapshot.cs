﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace din3.Migrations
{
    [DbContext(typeof(Din3Context))]
    partial class Din3ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.11");

            modelBuilder.Entity("Case", b =>
                {
                    b.Property<long>("CaseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Created")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<long>("ManufacturerId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<long>("Price")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Updated")
                        .HasColumnType("TEXT");

                    b.HasKey("CaseId");

                    b.HasIndex("ManufacturerId");

                    b.ToTable("Cases");
                });

            modelBuilder.Entity("Computer", b =>
                {
                    b.Property<long>("ComputerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<long>("CaseId")
                        .HasColumnType("INTEGER");

                    b.Property<long>("CoolerId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Created")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<long>("GraphicsCardId")
                        .HasColumnType("INTEGER");

                    b.Property<long>("MotherboardId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<long>("PowerSupplyId")
                        .HasColumnType("INTEGER");

                    b.Property<long>("ProcessorId")
                        .HasColumnType("INTEGER");

                    b.Property<long>("RamId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Updated")
                        .HasColumnType("TEXT");

                    b.HasKey("ComputerId");

                    b.HasIndex("CaseId");

                    b.HasIndex("CoolerId");

                    b.HasIndex("GraphicsCardId");

                    b.HasIndex("MotherboardId");

                    b.HasIndex("PowerSupplyId");

                    b.HasIndex("ProcessorId");

                    b.HasIndex("RamId");

                    b.ToTable("Computers");
                });

            modelBuilder.Entity("Cooler", b =>
                {
                    b.Property<long>("CoolerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Created")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<long>("ManufacturerId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<long>("Price")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Updated")
                        .HasColumnType("TEXT");

                    b.HasKey("CoolerId");

                    b.HasIndex("ManufacturerId");

                    b.ToTable("Coolers");
                });

            modelBuilder.Entity("GraphicsCard", b =>
                {
                    b.Property<long>("GraphicsCardId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Created")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<long>("ManufacturerId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<long>("Price")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Updated")
                        .HasColumnType("TEXT");

                    b.HasKey("GraphicsCardId");

                    b.HasIndex("ManufacturerId");

                    b.ToTable("GraphicsCards");
                });

            modelBuilder.Entity("Headset", b =>
                {
                    b.Property<long>("HeadsetId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Created")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<long>("ManufacturerId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<long>("Price")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Updated")
                        .HasColumnType("TEXT");

                    b.HasKey("HeadsetId");

                    b.HasIndex("ManufacturerId");

                    b.ToTable("Headsets");
                });

            modelBuilder.Entity("Keyboard", b =>
                {
                    b.Property<long>("KeyboardId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Created")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<long>("ManufacturerId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<long>("Price")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Updated")
                        .HasColumnType("TEXT");

                    b.HasKey("KeyboardId");

                    b.HasIndex("ManufacturerId");

                    b.ToTable("Keyboards");
                });

            modelBuilder.Entity("Manufacturer", b =>
                {
                    b.Property<long>("ManufacturerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("ManufacturerId");

                    b.ToTable("Manufacturers");
                });

            modelBuilder.Entity("Monitor", b =>
                {
                    b.Property<long>("MonitorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Created")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<long>("ManufacturerId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<long>("Price")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Updated")
                        .HasColumnType("TEXT");

                    b.HasKey("MonitorId");

                    b.HasIndex("ManufacturerId");

                    b.ToTable("Monitors");
                });

            modelBuilder.Entity("Motherboard", b =>
                {
                    b.Property<long>("MotherboardId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Created")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ImagePath")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<long>("ManufacturerId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<long>("Price")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Updated")
                        .HasColumnType("TEXT");

                    b.HasKey("MotherboardId");

                    b.HasIndex("ManufacturerId");

                    b.ToTable("Motherboards");
                });

            modelBuilder.Entity("Mouse", b =>
                {
                    b.Property<long>("MouseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Created")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<long>("ManufacturerId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<long>("Price")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Updated")
                        .HasColumnType("TEXT");

                    b.HasKey("MouseId");

                    b.HasIndex("ManufacturerId");

                    b.ToTable("Mouses");
                });

            modelBuilder.Entity("Order", b =>
                {
                    b.Property<long>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<long>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("OrderId");

                    b.HasIndex("UserId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("OrderItem", b =>
                {
                    b.Property<long>("OrderItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Created")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<long?>("OrderId")
                        .HasColumnType("INTEGER");

                    b.Property<long>("Price")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Updated")
                        .HasColumnType("TEXT");

                    b.HasKey("OrderItemId");

                    b.HasIndex("OrderId");

                    b.ToTable("OrderItems");
                });

            modelBuilder.Entity("PowerSupply", b =>
                {
                    b.Property<long>("PowerSupplyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Created")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<long>("ManufacturerId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<long>("Price")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Updated")
                        .HasColumnType("TEXT");

                    b.HasKey("PowerSupplyId");

                    b.HasIndex("ManufacturerId");

                    b.ToTable("PowerSupplies");
                });

            modelBuilder.Entity("Processor", b =>
                {
                    b.Property<long>("ProcessorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Created")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<long>("ManufacturerId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<long>("Price")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Updated")
                        .HasColumnType("TEXT");

                    b.HasKey("ProcessorId");

                    b.HasIndex("ManufacturerId");

                    b.ToTable("Processors");
                });

            modelBuilder.Entity("Ram", b =>
                {
                    b.Property<long>("RamId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Created")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<long>("ManufacturerId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<long>("Price")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Updated")
                        .HasColumnType("TEXT");

                    b.HasKey("RamId");

                    b.HasIndex("ManufacturerId");

                    b.ToTable("Rams");
                });

            modelBuilder.Entity("User", b =>
                {
                    b.Property<long>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Case", b =>
                {
                    b.HasOne("Manufacturer", "Manufacturer")
                        .WithMany("Cases")
                        .HasForeignKey("ManufacturerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Manufacturer");
                });

            modelBuilder.Entity("Computer", b =>
                {
                    b.HasOne("Case", "Case")
                        .WithMany()
                        .HasForeignKey("CaseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Cooler", "Cooler")
                        .WithMany()
                        .HasForeignKey("CoolerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GraphicsCard", "GraphicsCard")
                        .WithMany()
                        .HasForeignKey("GraphicsCardId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Motherboard", "Motherboard")
                        .WithMany()
                        .HasForeignKey("MotherboardId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PowerSupply", "PowerSupply")
                        .WithMany()
                        .HasForeignKey("PowerSupplyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Processor", "Processor")
                        .WithMany()
                        .HasForeignKey("ProcessorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Ram", "Ram")
                        .WithMany()
                        .HasForeignKey("RamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Case");

                    b.Navigation("Cooler");

                    b.Navigation("GraphicsCard");

                    b.Navigation("Motherboard");

                    b.Navigation("PowerSupply");

                    b.Navigation("Processor");

                    b.Navigation("Ram");
                });

            modelBuilder.Entity("Cooler", b =>
                {
                    b.HasOne("Manufacturer", "Manufacturer")
                        .WithMany("Coolers")
                        .HasForeignKey("ManufacturerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Manufacturer");
                });

            modelBuilder.Entity("GraphicsCard", b =>
                {
                    b.HasOne("Manufacturer", "Manufacturer")
                        .WithMany("GraphicsCards")
                        .HasForeignKey("ManufacturerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Manufacturer");
                });

            modelBuilder.Entity("Headset", b =>
                {
                    b.HasOne("Manufacturer", "Manufacturer")
                        .WithMany("Headsets")
                        .HasForeignKey("ManufacturerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Manufacturer");
                });

            modelBuilder.Entity("Keyboard", b =>
                {
                    b.HasOne("Manufacturer", "Manufacturer")
                        .WithMany("Keyboards")
                        .HasForeignKey("ManufacturerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Manufacturer");
                });

            modelBuilder.Entity("Monitor", b =>
                {
                    b.HasOne("Manufacturer", "Manufacturer")
                        .WithMany("Monitors")
                        .HasForeignKey("ManufacturerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Manufacturer");
                });

            modelBuilder.Entity("Motherboard", b =>
                {
                    b.HasOne("Manufacturer", "Manufacturer")
                        .WithMany("Motherboards")
                        .HasForeignKey("ManufacturerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Manufacturer");
                });

            modelBuilder.Entity("Mouse", b =>
                {
                    b.HasOne("Manufacturer", "Manufacturer")
                        .WithMany("Mouses")
                        .HasForeignKey("ManufacturerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Manufacturer");
                });

            modelBuilder.Entity("Order", b =>
                {
                    b.HasOne("User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("OrderItem", b =>
                {
                    b.HasOne("Order", null)
                        .WithMany("OrderItems")
                        .HasForeignKey("OrderId");
                });

            modelBuilder.Entity("PowerSupply", b =>
                {
                    b.HasOne("Manufacturer", "Manufacturer")
                        .WithMany("PowerSupplies")
                        .HasForeignKey("ManufacturerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Manufacturer");
                });

            modelBuilder.Entity("Processor", b =>
                {
                    b.HasOne("Manufacturer", "Manufacturer")
                        .WithMany("Processors")
                        .HasForeignKey("ManufacturerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Manufacturer");
                });

            modelBuilder.Entity("Ram", b =>
                {
                    b.HasOne("Manufacturer", "Manufacturer")
                        .WithMany("Rams")
                        .HasForeignKey("ManufacturerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Manufacturer");
                });

            modelBuilder.Entity("Manufacturer", b =>
                {
                    b.Navigation("Cases");

                    b.Navigation("Coolers");

                    b.Navigation("GraphicsCards");

                    b.Navigation("Headsets");

                    b.Navigation("Keyboards");

                    b.Navigation("Monitors");

                    b.Navigation("Motherboards");

                    b.Navigation("Mouses");

                    b.Navigation("PowerSupplies");

                    b.Navigation("Processors");

                    b.Navigation("Rams");
                });

            modelBuilder.Entity("Order", b =>
                {
                    b.Navigation("OrderItems");
                });
#pragma warning restore 612, 618
        }
    }
}
