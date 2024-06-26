﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BFF.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Sessions",
                columns: table => new
                {
                    id = table.Column<string>(type: "string", nullable: false),
                    ClientId = table.Column<string>(type: "TEXT", nullable: false),
                    AuthorizationEndpoint = table.Column<string>(type: "TEXT", nullable: false),
                    RedirectUri = table.Column<string>(type: "TEXT", nullable: false),
                    Scopes = table.Column<string>(type: "TEXT", nullable: false),
                    CodeVerifier = table.Column<string>(type: "TEXT", nullable: false),
                    IdToken = table.Column<string>(type: "TEXT", nullable: true),
                    AccessToken = table.Column<string>(type: "TEXT", nullable: true),
                    ExpiresAt = table.Column<DateTime>(type: "TEXT", nullable: true),
                    RefreshToken = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sessions", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sessions");
        }
    }
}
