using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _1_DAL.Migrations
{
    public partial class QLThuVien : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ChucVu",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenCV = table.Column<string>(type: "nvarchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChucVu", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sach",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TheLoai = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    TacGia = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    NXB = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    TenSach = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: false),
                    GiaTien = table.Column<decimal>(type: "money", nullable: false),
                    GhiChu = table.Column<string>(type: "nvarchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sach", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TheThanhVien",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenThanhVien = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    NgayDangKi = table.Column<DateTime>(type: "DateTime", nullable: false),
                    NgayHetHan = table.Column<DateTime>(type: "DateTime", nullable: false),
                    SDT = table.Column<string>(type: "char(10)", nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    NgaySinh = table.Column<DateTime>(type: "DateTime", nullable: false),
                    GhiChu = table.Column<string>(type: "nvarchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TheThanhVien", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NhanVien",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdCV = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenNhanVien = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    NgaySinh = table.Column<DateTime>(type: "DateTime", nullable: false),
                    SDT = table.Column<string>(type: "char(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhanVien", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NhanVien_ChucVu_IdCV",
                        column: x => x.IdCV,
                        principalTable: "ChucVu",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PhieuMuon",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdTheTV = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdNV = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NgayMuon = table.Column<DateTime>(type: "DateTime", nullable: false),
                    NgayTra = table.Column<DateTime>(type: "DateTime", nullable: false),
                    GhiChu = table.Column<string>(type: "nvarchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhieuMuon", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PhieuMuon_NhanVien_IdNV",
                        column: x => x.IdNV,
                        principalTable: "NhanVien",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PhieuMuon_TheThanhVien_IdTheTV",
                        column: x => x.IdTheTV,
                        principalTable: "TheThanhVien",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TheNgay",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdNV = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StartTime = table.Column<DateTime>(type: "DateTime", nullable: false),
                    EndTime = table.Column<DateTime>(type: "DateTime", nullable: false),
                    GhiChu = table.Column<string>(type: "nvarchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TheNgay", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TheNgay_NhanVien_IdNV",
                        column: x => x.IdNV,
                        principalTable: "NhanVien",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PhieuMuonChiTiet",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdPM = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdSach = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SoLuong = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    DieuKien = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    GhiChu = table.Column<string>(type: "nvarchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhieuMuonChiTiet", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PhieuMuonChiTiet_PhieuMuon_IdPM",
                        column: x => x.IdPM,
                        principalTable: "PhieuMuon",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PhieuMuonChiTiet_Sach_IdSach",
                        column: x => x.IdSach,
                        principalTable: "Sach",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PhieuTra",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdPM = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NgayTra = table.Column<DateTime>(type: "DateTime", nullable: false),
                    GhiChu = table.Column<string>(type: "nvarchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhieuTra", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PhieuTra_PhieuMuon_IdPM",
                        column: x => x.IdPM,
                        principalTable: "PhieuMuon",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PhieuTraChiTiet",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdPT = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdSach = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SoLuong = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    TinhTrang = table.Column<int>(type: "int", nullable: false),
                    GhiChu = table.Column<string>(type: "nvarchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhieuTraChiTiet", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PhieuTraChiTiet_PhieuTra_IdPT",
                        column: x => x.IdPT,
                        principalTable: "PhieuTra",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PhieuTraChiTiet_Sach_IdSach",
                        column: x => x.IdSach,
                        principalTable: "Sach",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_NhanVien_IdCV",
                table: "NhanVien",
                column: "IdCV");

            migrationBuilder.CreateIndex(
                name: "IX_PhieuMuon_IdNV",
                table: "PhieuMuon",
                column: "IdNV");

            migrationBuilder.CreateIndex(
                name: "IX_PhieuMuon_IdTheTV",
                table: "PhieuMuon",
                column: "IdTheTV");

            migrationBuilder.CreateIndex(
                name: "IX_PhieuMuonChiTiet_IdPM",
                table: "PhieuMuonChiTiet",
                column: "IdPM");

            migrationBuilder.CreateIndex(
                name: "IX_PhieuMuonChiTiet_IdSach",
                table: "PhieuMuonChiTiet",
                column: "IdSach");

            migrationBuilder.CreateIndex(
                name: "IX_PhieuTra_IdPM",
                table: "PhieuTra",
                column: "IdPM");

            migrationBuilder.CreateIndex(
                name: "IX_PhieuTraChiTiet_IdPT",
                table: "PhieuTraChiTiet",
                column: "IdPT");

            migrationBuilder.CreateIndex(
                name: "IX_PhieuTraChiTiet_IdSach",
                table: "PhieuTraChiTiet",
                column: "IdSach");

            migrationBuilder.CreateIndex(
                name: "IX_TheNgay_IdNV",
                table: "TheNgay",
                column: "IdNV");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PhieuMuonChiTiet");

            migrationBuilder.DropTable(
                name: "PhieuTraChiTiet");

            migrationBuilder.DropTable(
                name: "TheNgay");

            migrationBuilder.DropTable(
                name: "PhieuTra");

            migrationBuilder.DropTable(
                name: "Sach");

            migrationBuilder.DropTable(
                name: "PhieuMuon");

            migrationBuilder.DropTable(
                name: "NhanVien");

            migrationBuilder.DropTable(
                name: "TheThanhVien");

            migrationBuilder.DropTable(
                name: "ChucVu");
        }
    }
}
