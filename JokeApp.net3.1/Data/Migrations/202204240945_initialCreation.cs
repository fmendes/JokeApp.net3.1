﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JokeApp.net3._1.Data.Migrations
{
    public partial class initialCreation : Migration
    {
        protected override void Up( MigrationBuilder migrationBuilder )
        {
            migrationBuilder.CreateTable(
                name: "Joke",
                 columns: table => new
                 {
                     Id = table.Column<int>(nullable: false)
                         .Annotation("Sqlite:Autoincrement", true),
                     JokeQuestion = table.Column<string>(nullable: true),
                     JokeAnswer = table.Column<string>(nullable: true)
                 },
                 constraints: table =>
                 {
                     table.PrimaryKey("PK_Joke", x => x.Id);
                 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable( name: "Joke" );
        }
    }
}
