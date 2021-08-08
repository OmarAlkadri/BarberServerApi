using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BarberServerApi.Migrations
{
    public partial class update7281 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EntityPost",
                columns: table => new
                {
                    EntityPostId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EntityPostText = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EntityPostTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    EntityImgVideoUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EntityPost", x => x.EntityPostId);
                });

            migrationBuilder.CreateTable(
                name: "PayingOff",
                columns: table => new
                {
                    PayingOffId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PayingTime = table.Column<TimeSpan>(type: "time", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PayingOff", x => x.PayingOffId);
                });

            migrationBuilder.CreateTable(
                name: "Personnel",
                columns: table => new
                {
                    PersonnelId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonnelName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PersonnelSurname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PersonelGender = table.Column<int>(type: "int", nullable: false),
                    PersonnelMaill = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PersonnelPassword = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PersonnelPhone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PersonnelImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personnel", x => x.PersonnelId);
                });

            migrationBuilder.CreateTable(
                name: "Province",
                columns: table => new
                {
                    ProvinceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProvinceName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Province", x => x.ProvinceId);
                });

            migrationBuilder.CreateTable(
                name: "Reservation",
                columns: table => new
                {
                    ReservationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReservationTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    PayingOffId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservation", x => x.ReservationId);
                    table.ForeignKey(
                        name: "FK_Reservation_PayingOff_PayingOffId",
                        column: x => x.PayingOffId,
                        principalTable: "PayingOff",
                        principalColumn: "PayingOffId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    yas = table.Column<int>(type: "int", nullable: false),
                    PersonnelId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_User_Personnel_PersonnelId",
                        column: x => x.PersonnelId,
                        principalTable: "Personnel",
                        principalColumn: "PersonnelId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Neighborhood",
                columns: table => new
                {
                    NeighborhoodId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NeighborhoodName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProvinceId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Neighborhood", x => x.NeighborhoodId);
                    table.ForeignKey(
                        name: "FK_Neighborhood_Province_ProvinceId",
                        column: x => x.ProvinceId,
                        principalTable: "Province",
                        principalColumn: "ProvinceId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Likes",
                columns: table => new
                {
                    LikesId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    EntityPostId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Likes", x => x.LikesId);
                    table.ForeignKey(
                        name: "FK_Likes_EntityPost_EntityPostId",
                        column: x => x.EntityPostId,
                        principalTable: "EntityPost",
                        principalColumn: "EntityPostId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Likes_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "District",
                columns: table => new
                {
                    DistrictId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DistrictName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NeighborhoodId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_District", x => x.DistrictId);
                    table.ForeignKey(
                        name: "FK_District_Neighborhood_NeighborhoodId",
                        column: x => x.NeighborhoodId,
                        principalTable: "Neighborhood",
                        principalColumn: "NeighborhoodId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ContactInfo",
                columns: table => new
                {
                    ContactInfoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DistrictId = table.Column<int>(type: "int", nullable: false),
                    PersonnelId = table.Column<int>(type: "int", nullable: false),
                    StreetAvenueName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactInfo", x => x.ContactInfoId);
                    table.ForeignKey(
                        name: "FK_ContactInfo_District_DistrictId",
                        column: x => x.DistrictId,
                        principalTable: "District",
                        principalColumn: "DistrictId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ContactInfo_Personnel_PersonnelId",
                        column: x => x.PersonnelId,
                        principalTable: "Personnel",
                        principalColumn: "PersonnelId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Barber",
                columns: table => new
                {
                    BarberId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BarberShowName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CertificationImgUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PersonnelId = table.Column<int>(type: "int", nullable: true),
                    ContactInfoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Barber", x => x.BarberId);
                    table.ForeignKey(
                        name: "FK_Barber_ContactInfo_ContactInfoId",
                        column: x => x.ContactInfoId,
                        principalTable: "ContactInfo",
                        principalColumn: "ContactInfoId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Barber_Personnel_PersonnelId",
                        column: x => x.PersonnelId,
                        principalTable: "Personnel",
                        principalColumn: "PersonnelId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    CommentsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EntityPostId = table.Column<int>(type: "int", nullable: true),
                    Comments1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    BarberId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.CommentsId);
                    table.ForeignKey(
                        name: "FK_Comments_Barber_BarberId",
                        column: x => x.BarberId,
                        principalTable: "Barber",
                        principalColumn: "BarberId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Comments_EntityPost_EntityPostId",
                        column: x => x.EntityPostId,
                        principalTable: "EntityPost",
                        principalColumn: "EntityPostId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Comments_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ReservationBarber",
                columns: table => new
                {
                    ReservationBarberId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReservationId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    BarberId = table.Column<int>(type: "int", nullable: false),
                    ReservationType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    reservationStatus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReservationBarber", x => x.ReservationBarberId);
                    table.ForeignKey(
                        name: "FK_ReservationBarber_Barber_BarberId",
                        column: x => x.BarberId,
                        principalTable: "Barber",
                        principalColumn: "BarberId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReservationBarber_Reservation_ReservationId",
                        column: x => x.ReservationId,
                        principalTable: "Reservation",
                        principalColumn: "ReservationId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReservationBarber_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Barber_ContactInfoId",
                table: "Barber",
                column: "ContactInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_Barber_PersonnelId",
                table: "Barber",
                column: "PersonnelId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_BarberId",
                table: "Comments",
                column: "BarberId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_EntityPostId",
                table: "Comments",
                column: "EntityPostId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_UserId",
                table: "Comments",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ContactInfo_DistrictId",
                table: "ContactInfo",
                column: "DistrictId");

            migrationBuilder.CreateIndex(
                name: "IX_ContactInfo_PersonnelId",
                table: "ContactInfo",
                column: "PersonnelId");

            migrationBuilder.CreateIndex(
                name: "IX_District_NeighborhoodId",
                table: "District",
                column: "NeighborhoodId");

            migrationBuilder.CreateIndex(
                name: "IX_Likes_EntityPostId",
                table: "Likes",
                column: "EntityPostId");

            migrationBuilder.CreateIndex(
                name: "IX_Likes_UserId",
                table: "Likes",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Neighborhood_ProvinceId",
                table: "Neighborhood",
                column: "ProvinceId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservation_PayingOffId",
                table: "Reservation",
                column: "PayingOffId");

            migrationBuilder.CreateIndex(
                name: "IX_ReservationBarber_BarberId",
                table: "ReservationBarber",
                column: "BarberId");

            migrationBuilder.CreateIndex(
                name: "IX_ReservationBarber_ReservationId",
                table: "ReservationBarber",
                column: "ReservationId");

            migrationBuilder.CreateIndex(
                name: "IX_ReservationBarber_UserId",
                table: "ReservationBarber",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_User_PersonnelId",
                table: "User",
                column: "PersonnelId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "Likes");

            migrationBuilder.DropTable(
                name: "ReservationBarber");

            migrationBuilder.DropTable(
                name: "EntityPost");

            migrationBuilder.DropTable(
                name: "Barber");

            migrationBuilder.DropTable(
                name: "Reservation");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "ContactInfo");

            migrationBuilder.DropTable(
                name: "PayingOff");

            migrationBuilder.DropTable(
                name: "District");

            migrationBuilder.DropTable(
                name: "Personnel");

            migrationBuilder.DropTable(
                name: "Neighborhood");

            migrationBuilder.DropTable(
                name: "Province");
        }
    }
}
