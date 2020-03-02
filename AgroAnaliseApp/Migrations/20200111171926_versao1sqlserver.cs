using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AgroAnaliseApp.Migrations
{
    public partial class versao1sqlserver : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Addresses_Citys_CityId",
                table: "Addresses");

            migrationBuilder.DropForeignKey(
                name: "FK_Documents_Farm_FarmId1",
                table: "Documents");

            migrationBuilder.DropForeignKey(
                name: "FK_Documents_Farm_FarmId",
                table: "Documents");

            migrationBuilder.DropForeignKey(
                name: "FK_Farm_Addresses_AddressId",
                table: "Farm");

            migrationBuilder.DropForeignKey(
                name: "FK_Farm_Persons_FarmerId",
                table: "Farm");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Farm",
                table: "Farm");

            migrationBuilder.RenameTable(
                name: "Farm",
                newName: "Farms");

            migrationBuilder.RenameColumn(
                name: "FarmId1",
                table: "Documents",
                newName: "FarmId2");

            migrationBuilder.RenameIndex(
                name: "IX_Documents_FarmId1",
                table: "Documents",
                newName: "IX_Documents_FarmId2");

            migrationBuilder.RenameIndex(
                name: "IX_Farm_FarmerId",
                table: "Farms",
                newName: "IX_Farms_FarmerId");

            migrationBuilder.RenameIndex(
                name: "IX_Farm_AddressId",
                table: "Farms",
                newName: "IX_Farms_AddressId");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Persons",
                nullable: false,
                oldClrType: typeof(int))
                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Documents",
                nullable: false,
                oldClrType: typeof(int))
                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Citys",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Citys",
                nullable: false,
                oldClrType: typeof(int))
                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<string>(
                name: "ZipCode",
                table: "Addresses",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Line2",
                table: "Addresses",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Line1",
                table: "Addresses",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Coordinates",
                table: "Addresses",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CityId",
                table: "Addresses",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Addresses",
                nullable: false,
                oldClrType: typeof(int))
                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<int>(
                name: "FarmerId",
                table: "Farms",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AddressId",
                table: "Farms",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Farms",
                nullable: false,
                oldClrType: typeof(int))
                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Farms",
                table: "Farms",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Addresses_Citys_CityId",
                table: "Addresses",
                column: "CityId",
                principalTable: "Citys",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Documents_Farms_FarmId",
                table: "Documents",
                column: "FarmId",
                principalTable: "Farms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Documents_Farms_FarmId2",
                table: "Documents",
                column: "FarmId2",
                principalTable: "Farms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Farms_Addresses_AddressId",
                table: "Farms",
                column: "AddressId",
                principalTable: "Addresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Farms_Persons_FarmerId",
                table: "Farms",
                column: "FarmerId",
                principalTable: "Persons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Addresses_Citys_CityId",
                table: "Addresses");

            migrationBuilder.DropForeignKey(
                name: "FK_Documents_Farms_FarmId",
                table: "Documents");

            migrationBuilder.DropForeignKey(
                name: "FK_Documents_Farms_FarmId2",
                table: "Documents");

            migrationBuilder.DropForeignKey(
                name: "FK_Farms_Addresses_AddressId",
                table: "Farms");

            migrationBuilder.DropForeignKey(
                name: "FK_Farms_Persons_FarmerId",
                table: "Farms");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Farms",
                table: "Farms");

            migrationBuilder.RenameTable(
                name: "Farms",
                newName: "Farm");

            migrationBuilder.RenameColumn(
                name: "FarmId2",
                table: "Documents",
                newName: "FarmId1");

            migrationBuilder.RenameIndex(
                name: "IX_Documents_FarmId2",
                table: "Documents",
                newName: "IX_Documents_FarmId1");

            migrationBuilder.RenameIndex(
                name: "IX_Farms_FarmerId",
                table: "Farm",
                newName: "IX_Farm_FarmerId");

            migrationBuilder.RenameIndex(
                name: "IX_Farms_AddressId",
                table: "Farm",
                newName: "IX_Farm_AddressId");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Persons",
                nullable: false,
                oldClrType: typeof(int))
                .OldAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Documents",
                nullable: false,
                oldClrType: typeof(int))
                .OldAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Citys",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Citys",
                nullable: false,
                oldClrType: typeof(int))
                .OldAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<string>(
                name: "ZipCode",
                table: "Addresses",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Line2",
                table: "Addresses",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Line1",
                table: "Addresses",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Coordinates",
                table: "Addresses",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<int>(
                name: "CityId",
                table: "Addresses",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Addresses",
                nullable: false,
                oldClrType: typeof(int))
                .OldAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<int>(
                name: "FarmerId",
                table: "Farm",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "AddressId",
                table: "Farm",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Farm",
                nullable: false,
                oldClrType: typeof(int))
                .OldAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Farm",
                table: "Farm",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Addresses_Citys_CityId",
                table: "Addresses",
                column: "CityId",
                principalTable: "Citys",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Documents_Farm_FarmId1",
                table: "Documents",
                column: "FarmId1",
                principalTable: "Farm",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Documents_Farm_FarmId",
                table: "Documents",
                column: "FarmId",
                principalTable: "Farm",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Farm_Addresses_AddressId",
                table: "Farm",
                column: "AddressId",
                principalTable: "Addresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Farm_Persons_FarmerId",
                table: "Farm",
                column: "FarmerId",
                principalTable: "Persons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
