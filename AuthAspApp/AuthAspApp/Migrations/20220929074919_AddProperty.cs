using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AuthAspApp.Migrations
{
    public partial class AddProperty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LastSignInDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SignUpDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LastSignInDate", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "SignUpDate", "Status", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "a2853a4c-73a0-43c8-bd2a-b99a2435a7bf", 0, "2086b3c6-8876-46af-a97e-e2e4fd704110", "g.chubey13@gmail.com", false, new DateTime(2022, 9, 29, 12, 49, 18, 373, DateTimeKind.Local).AddTicks(489), false, null, null, null, null, null, false, "ad8d9648-ee75-40b8-95f2-807d7c0d3da7", new DateTime(2022, 9, 29, 12, 49, 18, 377, DateTimeKind.Local).AddTicks(278), 1, false, "Grisha" },
                    { "c6ef89b8-d7e6-4de7-9b98-8ba38685c4ef", 0, "79529aa8-98a3-48e7-aa55-40ba6757cb46", "helenfox@yahoo.com", false, new DateTime(2022, 9, 29, 12, 49, 18, 377, DateTimeKind.Local).AddTicks(3107), false, null, null, null, null, null, false, "cd91f0fe-3f9e-4d2c-9f54-f24fd82a7fe7", new DateTime(2022, 9, 29, 12, 49, 18, 377, DateTimeKind.Local).AddTicks(3145), 0, false, "Helen" },
                    { "b6dad1de-428b-4e15-9e13-99f21f429e73", 0, "97f7ac95-bced-45b8-857d-0c432126aebf", "19karimov82@hotmail.com", false, new DateTime(2022, 9, 29, 12, 49, 18, 377, DateTimeKind.Local).AddTicks(3647), false, null, null, null, null, null, false, "8b44aece-f121-4404-88f8-a50ab3db81cf", new DateTime(2022, 9, 29, 12, 49, 18, 377, DateTimeKind.Local).AddTicks(3649), 0, false, "Azamat" },
                    { "a309f118-ecef-4e30-aa0e-e9bcc13fb35f", 0, "25611f05-1042-4b39-967e-baf4d1104c2d", "cla_udette6@gmail.com", false, new DateTime(2022, 9, 29, 12, 49, 18, 377, DateTimeKind.Local).AddTicks(3661), false, null, null, null, null, null, false, "3005b9eb-eb05-4bc3-a14a-70bd5f5fe13d", new DateTime(2022, 9, 29, 12, 49, 18, 377, DateTimeKind.Local).AddTicks(3663), 0, false, "Claudette" },
                    { "7accbd05-e608-4351-a586-35b8b1b9ebb1", 0, "abffd0cf-2050-4610-8aaa-17537fcb5273", "persi.j@gmail.com", false, new DateTime(2022, 9, 29, 12, 49, 18, 377, DateTimeKind.Local).AddTicks(3671), false, null, null, null, null, null, false, "86f95c8f-d85e-4d62-9ee8-2e13243c2808", new DateTime(2022, 9, 29, 12, 49, 18, 377, DateTimeKind.Local).AddTicks(3672), 0, false, "Persi" },
                    { "c75823ff-a592-4e00-92a7-12be2b8a6600", 0, "8178b8c9-d4f7-409a-a987-70c88f0eb041", "mikh_1994_ail@hotmail.com", false, new DateTime(2022, 9, 29, 12, 49, 18, 377, DateTimeKind.Local).AddTicks(3722), false, null, null, null, null, null, false, "9a9eaa30-3115-4607-8ece-5c80c4be2502", new DateTime(2022, 9, 29, 12, 49, 18, 377, DateTimeKind.Local).AddTicks(3731), 0, false, "Mikhail" },
                    { "34b6b22b-d096-4ba0-b34b-e8841f199b22", 0, "6253557b-745a-4659-badf-1b1e8255f0d8", "sergey.zrch@gmail.com@gmail.com", false, new DateTime(2022, 9, 29, 12, 49, 18, 377, DateTimeKind.Local).AddTicks(3739), false, null, null, null, null, null, false, "6acfa693-6ef4-41fa-bf5c-4b716d92404e", new DateTime(2022, 9, 29, 12, 49, 18, 377, DateTimeKind.Local).AddTicks(3740), 0, false, "Sergey" },
                    { "65efc2b6-c6dc-4000-9e8a-7c89910b35cb", 0, "d01b13fa-a31a-49aa-9677-600836184c65", "daya_18_flo@hotmail.com", false, new DateTime(2022, 9, 29, 12, 49, 18, 377, DateTimeKind.Local).AddTicks(3748), false, null, null, null, null, null, false, "657f5105-149d-4674-b90f-cd3b84a89a07", new DateTime(2022, 9, 29, 12, 49, 18, 377, DateTimeKind.Local).AddTicks(3749), 0, false, "Dayana" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
