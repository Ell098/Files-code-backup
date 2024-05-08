using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FarmApplication.Migrations
{
    /// <inheritdoc />
    public partial class addingnulltasks : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_Equipment_EquipmentValuesId",
                table: "Tasks");

            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_Fields_FieldValuesFieldID",
                table: "Tasks");

            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_Resources_ResourcesValuesResourceId",
                table: "Tasks");

            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_Workers_WorkersValuesWorkerID",
                table: "Tasks");

            migrationBuilder.AlterColumn<int>(
                name: "WorkersValuesWorkerID",
                table: "Tasks",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "TaskWorker",
                table: "Tasks",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "TaskResources",
                table: "Tasks",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "TaskResourceCount",
                table: "Tasks",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "TaskField",
                table: "Tasks",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "TaskEquipmentCount",
                table: "Tasks",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "TaskEquipment",
                table: "Tasks",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ResourcesValuesResourceId",
                table: "Tasks",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "FieldValuesFieldID",
                table: "Tasks",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "EquipmentValuesId",
                table: "Tasks",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_Equipment_EquipmentValuesId",
                table: "Tasks",
                column: "EquipmentValuesId",
                principalTable: "Equipment",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_Fields_FieldValuesFieldID",
                table: "Tasks",
                column: "FieldValuesFieldID",
                principalTable: "Fields",
                principalColumn: "FieldID");

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_Resources_ResourcesValuesResourceId",
                table: "Tasks",
                column: "ResourcesValuesResourceId",
                principalTable: "Resources",
                principalColumn: "ResourceId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_Workers_WorkersValuesWorkerID",
                table: "Tasks",
                column: "WorkersValuesWorkerID",
                principalTable: "Workers",
                principalColumn: "WorkerID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_Equipment_EquipmentValuesId",
                table: "Tasks");

            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_Fields_FieldValuesFieldID",
                table: "Tasks");

            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_Resources_ResourcesValuesResourceId",
                table: "Tasks");

            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_Workers_WorkersValuesWorkerID",
                table: "Tasks");

            migrationBuilder.AlterColumn<int>(
                name: "WorkersValuesWorkerID",
                table: "Tasks",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "TaskWorker",
                table: "Tasks",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "TaskResources",
                table: "Tasks",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "TaskResourceCount",
                table: "Tasks",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "TaskField",
                table: "Tasks",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "TaskEquipmentCount",
                table: "Tasks",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "TaskEquipment",
                table: "Tasks",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ResourcesValuesResourceId",
                table: "Tasks",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "FieldValuesFieldID",
                table: "Tasks",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "EquipmentValuesId",
                table: "Tasks",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_Equipment_EquipmentValuesId",
                table: "Tasks",
                column: "EquipmentValuesId",
                principalTable: "Equipment",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_Fields_FieldValuesFieldID",
                table: "Tasks",
                column: "FieldValuesFieldID",
                principalTable: "Fields",
                principalColumn: "FieldID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_Resources_ResourcesValuesResourceId",
                table: "Tasks",
                column: "ResourcesValuesResourceId",
                principalTable: "Resources",
                principalColumn: "ResourceId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_Workers_WorkersValuesWorkerID",
                table: "Tasks",
                column: "WorkersValuesWorkerID",
                principalTable: "Workers",
                principalColumn: "WorkerID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
