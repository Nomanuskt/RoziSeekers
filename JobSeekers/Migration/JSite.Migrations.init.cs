using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JobSeekers.Migrations
{
    public partial class  init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.CreateTable(
            name: "esiteHomes",
            columns: table => new
            {
                jobtype = table.Column<string>(type: "nvarchar(450)", nullable: false),
                jobId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                jobsalary = table.Column<string>(type: "nvarchar(max)", nullable: true)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_JSitehome", x => x.jobtype);
            });
    }

    /// <inheritdoc />
    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropTable(
            name: "JSiteHomes");
    }
}
}
