using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PurchasingSystemApps.Migrations
{
    public partial class BigUpdateFromStaging03Okt2024 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrdPurchaseOrder_MstDueDate_DueDateId",
                schema: "dbo",
                table: "OrdPurchaseOrder");

            migrationBuilder.DropForeignKey(
                name: "FK_OrdPurchaseRequest_MstDueDate_DueDateId",
                schema: "dbo",
                table: "OrdPurchaseRequest");

            migrationBuilder.DropIndex(
                name: "IX_OrdPurchaseRequest_DueDateId",
                schema: "dbo",
                table: "OrdPurchaseRequest");

            migrationBuilder.DropIndex(
                name: "IX_OrdPurchaseOrder_DueDateId",
                schema: "dbo",
                table: "OrdPurchaseOrder");

            migrationBuilder.DropColumn(
                name: "DueDateId",
                schema: "dbo",
                table: "OrdPurchaseRequest");

            migrationBuilder.DropColumn(
                name: "DueDateId",
                schema: "dbo",
                table: "OrdPurchaseOrder");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "UpdateDateTime",
                schema: "dbo",
                table: "WrhWarehouseTransferDetail",
                type: "datetimeoffset",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DeleteDateTime",
                schema: "dbo",
                table: "WrhWarehouseTransferDetail",
                type: "datetimeoffset",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "CreateDateTime",
                schema: "dbo",
                table: "WrhWarehouseTransferDetail",
                type: "datetimeoffset",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "UpdateDateTime",
                schema: "dbo",
                table: "WrhWarehouseTransfer",
                type: "datetimeoffset",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DeleteDateTime",
                schema: "dbo",
                table: "WrhWarehouseTransfer",
                type: "datetimeoffset",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "CreateDateTime",
                schema: "dbo",
                table: "WrhWarehouseTransfer",
                type: "datetimeoffset",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "UpdateDateTime",
                schema: "dbo",
                table: "WrhWarehouseRequestDetail",
                type: "datetimeoffset",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DeleteDateTime",
                schema: "dbo",
                table: "WrhWarehouseRequestDetail",
                type: "datetimeoffset",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "CreateDateTime",
                schema: "dbo",
                table: "WrhWarehouseRequestDetail",
                type: "datetimeoffset",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "UpdateDateTime",
                schema: "dbo",
                table: "WrhWarehouseRequest",
                type: "datetimeoffset",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DeleteDateTime",
                schema: "dbo",
                table: "WrhWarehouseRequest",
                type: "datetimeoffset",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "CreateDateTime",
                schema: "dbo",
                table: "WrhWarehouseRequest",
                type: "datetimeoffset",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "UpdateDateTime",
                schema: "dbo",
                table: "WrhReceiveOrderDetail",
                type: "datetimeoffset",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DeleteDateTime",
                schema: "dbo",
                table: "WrhReceiveOrderDetail",
                type: "datetimeoffset",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "CreateDateTime",
                schema: "dbo",
                table: "WrhReceiveOrderDetail",
                type: "datetimeoffset",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "UpdateDateTime",
                schema: "dbo",
                table: "WrhReceiveOrder",
                type: "datetimeoffset",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DeleteDateTime",
                schema: "dbo",
                table: "WrhReceiveOrder",
                type: "datetimeoffset",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "CreateDateTime",
                schema: "dbo",
                table: "WrhReceiveOrder",
                type: "datetimeoffset",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "UpdateDateTime",
                schema: "dbo",
                table: "WrhQtyDifferenceDetail",
                type: "datetimeoffset",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DeleteDateTime",
                schema: "dbo",
                table: "WrhQtyDifferenceDetail",
                type: "datetimeoffset",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "CreateDateTime",
                schema: "dbo",
                table: "WrhQtyDifferenceDetail",
                type: "datetimeoffset",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "UpdateDateTime",
                schema: "dbo",
                table: "WrhQtyDifference",
                type: "datetimeoffset",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DeleteDateTime",
                schema: "dbo",
                table: "WrhQtyDifference",
                type: "datetimeoffset",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "CreateDateTime",
                schema: "dbo",
                table: "WrhQtyDifference",
                type: "datetimeoffset",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "UpdateDateTime",
                schema: "dbo",
                table: "WrhApprovalRequest",
                type: "datetimeoffset",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DeleteDateTime",
                schema: "dbo",
                table: "WrhApprovalRequest",
                type: "datetimeoffset",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "CreateDateTime",
                schema: "dbo",
                table: "WrhApprovalRequest",
                type: "datetimeoffset",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "UpdateDateTime",
                schema: "dbo",
                table: "TscUnitRequestDetail",
                type: "datetimeoffset",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DeleteDateTime",
                schema: "dbo",
                table: "TscUnitRequestDetail",
                type: "datetimeoffset",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "CreateDateTime",
                schema: "dbo",
                table: "TscUnitRequestDetail",
                type: "datetimeoffset",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "UpdateDateTime",
                schema: "dbo",
                table: "TscUnitRequest",
                type: "datetimeoffset",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DeleteDateTime",
                schema: "dbo",
                table: "TscUnitRequest",
                type: "datetimeoffset",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "CreateDateTime",
                schema: "dbo",
                table: "TscUnitRequest",
                type: "datetimeoffset",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "UpdateDateTime",
                schema: "dbo",
                table: "OrdQtyDifferenceRequest",
                type: "datetimeoffset",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DeleteDateTime",
                schema: "dbo",
                table: "OrdQtyDifferenceRequest",
                type: "datetimeoffset",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "CreateDateTime",
                schema: "dbo",
                table: "OrdQtyDifferenceRequest",
                type: "datetimeoffset",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "UpdateDateTime",
                schema: "dbo",
                table: "OrdPurchaseRequestDetail",
                type: "datetimeoffset",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DeleteDateTime",
                schema: "dbo",
                table: "OrdPurchaseRequestDetail",
                type: "datetimeoffset",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "CreateDateTime",
                schema: "dbo",
                table: "OrdPurchaseRequestDetail",
                type: "datetimeoffset",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "UpdateDateTime",
                schema: "dbo",
                table: "OrdPurchaseRequest",
                type: "datetimeoffset",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "ExpiredDate",
                schema: "dbo",
                table: "OrdPurchaseRequest",
                type: "datetimeoffset",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DeleteDateTime",
                schema: "dbo",
                table: "OrdPurchaseRequest",
                type: "datetimeoffset",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "CreateDateTime",
                schema: "dbo",
                table: "OrdPurchaseRequest",
                type: "datetimeoffset",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<int>(
                name: "ExpiredDay",
                schema: "dbo",
                table: "OrdPurchaseRequest",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RemainingDay",
                schema: "dbo",
                table: "OrdPurchaseRequest",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "UpdateDateTime",
                schema: "dbo",
                table: "OrdPurchaseOrderDetail",
                type: "datetimeoffset",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DeleteDateTime",
                schema: "dbo",
                table: "OrdPurchaseOrderDetail",
                type: "datetimeoffset",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "CreateDateTime",
                schema: "dbo",
                table: "OrdPurchaseOrderDetail",
                type: "datetimeoffset",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "UpdateDateTime",
                schema: "dbo",
                table: "OrdPurchaseOrder",
                type: "datetimeoffset",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DeleteDateTime",
                schema: "dbo",
                table: "OrdPurchaseOrder",
                type: "datetimeoffset",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "CreateDateTime",
                schema: "dbo",
                table: "OrdPurchaseOrder",
                type: "datetimeoffset",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<string>(
                name: "ApproveStatusUser1",
                schema: "dbo",
                table: "OrdPurchaseOrder",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ApproveStatusUser2",
                schema: "dbo",
                table: "OrdPurchaseOrder",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ApproveStatusUser3",
                schema: "dbo",
                table: "OrdPurchaseOrder",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "ExpiredDate",
                schema: "dbo",
                table: "OrdPurchaseOrder",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "UpdateDateTime",
                schema: "dbo",
                table: "OrdApproval",
                type: "datetimeoffset",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "ExpiredDate",
                schema: "dbo",
                table: "OrdApproval",
                type: "datetimeoffset",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DeleteDateTime",
                schema: "dbo",
                table: "OrdApproval",
                type: "datetimeoffset",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "CreateDateTime",
                schema: "dbo",
                table: "OrdApproval",
                type: "datetimeoffset",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "ApprovalDate",
                schema: "dbo",
                table: "OrdApproval",
                type: "datetimeoffset",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<int>(
                name: "ExpiredDay",
                schema: "dbo",
                table: "OrdApproval",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RemainingDay",
                schema: "dbo",
                table: "OrdApproval",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "UpdateDateTime",
                schema: "dbo",
                table: "MstWarehouseLocation",
                type: "datetimeoffset",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DeleteDateTime",
                schema: "dbo",
                table: "MstWarehouseLocation",
                type: "datetimeoffset",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "CreateDateTime",
                schema: "dbo",
                table: "MstWarehouseLocation",
                type: "datetimeoffset",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "UpdateDateTime",
                schema: "dbo",
                table: "MstUserActive",
                type: "datetimeoffset",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DeleteDateTime",
                schema: "dbo",
                table: "MstUserActive",
                type: "datetimeoffset",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "CreateDateTime",
                schema: "dbo",
                table: "MstUserActive",
                type: "datetimeoffset",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "UpdateDateTime",
                schema: "dbo",
                table: "MstUnitLocation",
                type: "datetimeoffset",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DeleteDateTime",
                schema: "dbo",
                table: "MstUnitLocation",
                type: "datetimeoffset",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "CreateDateTime",
                schema: "dbo",
                table: "MstUnitLocation",
                type: "datetimeoffset",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "UpdateDateTime",
                schema: "dbo",
                table: "MstTermOfPayment",
                type: "datetimeoffset",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DeleteDateTime",
                schema: "dbo",
                table: "MstTermOfPayment",
                type: "datetimeoffset",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "CreateDateTime",
                schema: "dbo",
                table: "MstTermOfPayment",
                type: "datetimeoffset",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "UpdateDateTime",
                schema: "dbo",
                table: "MstSupplier",
                type: "datetimeoffset",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DeleteDateTime",
                schema: "dbo",
                table: "MstSupplier",
                type: "datetimeoffset",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "CreateDateTime",
                schema: "dbo",
                table: "MstSupplier",
                type: "datetimeoffset",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "UpdateDateTime",
                schema: "dbo",
                table: "MstProduct",
                type: "datetimeoffset",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DeleteDateTime",
                schema: "dbo",
                table: "MstProduct",
                type: "datetimeoffset",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "CreateDateTime",
                schema: "dbo",
                table: "MstProduct",
                type: "datetimeoffset",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "UpdateDateTime",
                schema: "dbo",
                table: "MstPosition",
                type: "datetimeoffset",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DeleteDateTime",
                schema: "dbo",
                table: "MstPosition",
                type: "datetimeoffset",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "CreateDateTime",
                schema: "dbo",
                table: "MstPosition",
                type: "datetimeoffset",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "UpdateDateTime",
                schema: "dbo",
                table: "MstMeasurement",
                type: "datetimeoffset",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DeleteDateTime",
                schema: "dbo",
                table: "MstMeasurement",
                type: "datetimeoffset",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "CreateDateTime",
                schema: "dbo",
                table: "MstMeasurement",
                type: "datetimeoffset",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "UpdateDateTime",
                schema: "dbo",
                table: "MstLeadTime",
                type: "datetimeoffset",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DeleteDateTime",
                schema: "dbo",
                table: "MstLeadTime",
                type: "datetimeoffset",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "CreateDateTime",
                schema: "dbo",
                table: "MstLeadTime",
                type: "datetimeoffset",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "UpdateDateTime",
                schema: "dbo",
                table: "MstInitialStock",
                type: "datetimeoffset",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DeleteDateTime",
                schema: "dbo",
                table: "MstInitialStock",
                type: "datetimeoffset",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "CreateDateTime",
                schema: "dbo",
                table: "MstInitialStock",
                type: "datetimeoffset",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "UpdateDateTime",
                schema: "dbo",
                table: "MstDueDate",
                type: "datetimeoffset",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DeleteDateTime",
                schema: "dbo",
                table: "MstDueDate",
                type: "datetimeoffset",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "CreateDateTime",
                schema: "dbo",
                table: "MstDueDate",
                type: "datetimeoffset",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "UpdateDateTime",
                schema: "dbo",
                table: "MstDiscount",
                type: "datetimeoffset",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DeleteDateTime",
                schema: "dbo",
                table: "MstDiscount",
                type: "datetimeoffset",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "CreateDateTime",
                schema: "dbo",
                table: "MstDiscount",
                type: "datetimeoffset",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "UpdateDateTime",
                schema: "dbo",
                table: "MstDepartment",
                type: "datetimeoffset",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DeleteDateTime",
                schema: "dbo",
                table: "MstDepartment",
                type: "datetimeoffset",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "CreateDateTime",
                schema: "dbo",
                table: "MstDepartment",
                type: "datetimeoffset",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "UpdateDateTime",
                schema: "dbo",
                table: "MstCategory",
                type: "datetimeoffset",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DeleteDateTime",
                schema: "dbo",
                table: "MstCategory",
                type: "datetimeoffset",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "CreateDateTime",
                schema: "dbo",
                table: "MstCategory",
                type: "datetimeoffset",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "UpdateDateTime",
                schema: "dbo",
                table: "MstBank",
                type: "datetimeoffset",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "DeleteDateTime",
                schema: "dbo",
                table: "MstBank",
                type: "datetimeoffset",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "CreateDateTime",
                schema: "dbo",
                table: "MstBank",
                type: "datetimeoffset",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ExpiredDay",
                schema: "dbo",
                table: "OrdPurchaseRequest");

            migrationBuilder.DropColumn(
                name: "RemainingDay",
                schema: "dbo",
                table: "OrdPurchaseRequest");

            migrationBuilder.DropColumn(
                name: "ApproveStatusUser1",
                schema: "dbo",
                table: "OrdPurchaseOrder");

            migrationBuilder.DropColumn(
                name: "ApproveStatusUser2",
                schema: "dbo",
                table: "OrdPurchaseOrder");

            migrationBuilder.DropColumn(
                name: "ApproveStatusUser3",
                schema: "dbo",
                table: "OrdPurchaseOrder");

            migrationBuilder.DropColumn(
                name: "ExpiredDate",
                schema: "dbo",
                table: "OrdPurchaseOrder");

            migrationBuilder.DropColumn(
                name: "ExpiredDay",
                schema: "dbo",
                table: "OrdApproval");

            migrationBuilder.DropColumn(
                name: "RemainingDay",
                schema: "dbo",
                table: "OrdApproval");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDateTime",
                schema: "dbo",
                table: "WrhWarehouseTransferDetail",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeleteDateTime",
                schema: "dbo",
                table: "WrhWarehouseTransferDetail",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDateTime",
                schema: "dbo",
                table: "WrhWarehouseTransferDetail",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDateTime",
                schema: "dbo",
                table: "WrhWarehouseTransfer",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeleteDateTime",
                schema: "dbo",
                table: "WrhWarehouseTransfer",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDateTime",
                schema: "dbo",
                table: "WrhWarehouseTransfer",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDateTime",
                schema: "dbo",
                table: "WrhWarehouseRequestDetail",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeleteDateTime",
                schema: "dbo",
                table: "WrhWarehouseRequestDetail",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDateTime",
                schema: "dbo",
                table: "WrhWarehouseRequestDetail",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDateTime",
                schema: "dbo",
                table: "WrhWarehouseRequest",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeleteDateTime",
                schema: "dbo",
                table: "WrhWarehouseRequest",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDateTime",
                schema: "dbo",
                table: "WrhWarehouseRequest",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDateTime",
                schema: "dbo",
                table: "WrhReceiveOrderDetail",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeleteDateTime",
                schema: "dbo",
                table: "WrhReceiveOrderDetail",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDateTime",
                schema: "dbo",
                table: "WrhReceiveOrderDetail",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDateTime",
                schema: "dbo",
                table: "WrhReceiveOrder",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeleteDateTime",
                schema: "dbo",
                table: "WrhReceiveOrder",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDateTime",
                schema: "dbo",
                table: "WrhReceiveOrder",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDateTime",
                schema: "dbo",
                table: "WrhQtyDifferenceDetail",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeleteDateTime",
                schema: "dbo",
                table: "WrhQtyDifferenceDetail",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDateTime",
                schema: "dbo",
                table: "WrhQtyDifferenceDetail",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDateTime",
                schema: "dbo",
                table: "WrhQtyDifference",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeleteDateTime",
                schema: "dbo",
                table: "WrhQtyDifference",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDateTime",
                schema: "dbo",
                table: "WrhQtyDifference",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDateTime",
                schema: "dbo",
                table: "WrhApprovalRequest",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeleteDateTime",
                schema: "dbo",
                table: "WrhApprovalRequest",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDateTime",
                schema: "dbo",
                table: "WrhApprovalRequest",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDateTime",
                schema: "dbo",
                table: "TscUnitRequestDetail",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeleteDateTime",
                schema: "dbo",
                table: "TscUnitRequestDetail",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDateTime",
                schema: "dbo",
                table: "TscUnitRequestDetail",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDateTime",
                schema: "dbo",
                table: "TscUnitRequest",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeleteDateTime",
                schema: "dbo",
                table: "TscUnitRequest",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDateTime",
                schema: "dbo",
                table: "TscUnitRequest",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDateTime",
                schema: "dbo",
                table: "OrdQtyDifferenceRequest",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeleteDateTime",
                schema: "dbo",
                table: "OrdQtyDifferenceRequest",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDateTime",
                schema: "dbo",
                table: "OrdQtyDifferenceRequest",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDateTime",
                schema: "dbo",
                table: "OrdPurchaseRequestDetail",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeleteDateTime",
                schema: "dbo",
                table: "OrdPurchaseRequestDetail",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDateTime",
                schema: "dbo",
                table: "OrdPurchaseRequestDetail",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDateTime",
                schema: "dbo",
                table: "OrdPurchaseRequest",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ExpiredDate",
                schema: "dbo",
                table: "OrdPurchaseRequest",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeleteDateTime",
                schema: "dbo",
                table: "OrdPurchaseRequest",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDateTime",
                schema: "dbo",
                table: "OrdPurchaseRequest",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset");

            migrationBuilder.AddColumn<Guid>(
                name: "DueDateId",
                schema: "dbo",
                table: "OrdPurchaseRequest",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDateTime",
                schema: "dbo",
                table: "OrdPurchaseOrderDetail",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeleteDateTime",
                schema: "dbo",
                table: "OrdPurchaseOrderDetail",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDateTime",
                schema: "dbo",
                table: "OrdPurchaseOrderDetail",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDateTime",
                schema: "dbo",
                table: "OrdPurchaseOrder",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeleteDateTime",
                schema: "dbo",
                table: "OrdPurchaseOrder",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDateTime",
                schema: "dbo",
                table: "OrdPurchaseOrder",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset");

            migrationBuilder.AddColumn<Guid>(
                name: "DueDateId",
                schema: "dbo",
                table: "OrdPurchaseOrder",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDateTime",
                schema: "dbo",
                table: "OrdApproval",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ExpiredDate",
                schema: "dbo",
                table: "OrdApproval",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeleteDateTime",
                schema: "dbo",
                table: "OrdApproval",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDateTime",
                schema: "dbo",
                table: "OrdApproval",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ApprovalDate",
                schema: "dbo",
                table: "OrdApproval",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDateTime",
                schema: "dbo",
                table: "MstWarehouseLocation",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeleteDateTime",
                schema: "dbo",
                table: "MstWarehouseLocation",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDateTime",
                schema: "dbo",
                table: "MstWarehouseLocation",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDateTime",
                schema: "dbo",
                table: "MstUserActive",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeleteDateTime",
                schema: "dbo",
                table: "MstUserActive",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDateTime",
                schema: "dbo",
                table: "MstUserActive",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDateTime",
                schema: "dbo",
                table: "MstUnitLocation",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeleteDateTime",
                schema: "dbo",
                table: "MstUnitLocation",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDateTime",
                schema: "dbo",
                table: "MstUnitLocation",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDateTime",
                schema: "dbo",
                table: "MstTermOfPayment",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeleteDateTime",
                schema: "dbo",
                table: "MstTermOfPayment",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDateTime",
                schema: "dbo",
                table: "MstTermOfPayment",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDateTime",
                schema: "dbo",
                table: "MstSupplier",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeleteDateTime",
                schema: "dbo",
                table: "MstSupplier",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDateTime",
                schema: "dbo",
                table: "MstSupplier",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDateTime",
                schema: "dbo",
                table: "MstProduct",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeleteDateTime",
                schema: "dbo",
                table: "MstProduct",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDateTime",
                schema: "dbo",
                table: "MstProduct",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDateTime",
                schema: "dbo",
                table: "MstPosition",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeleteDateTime",
                schema: "dbo",
                table: "MstPosition",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDateTime",
                schema: "dbo",
                table: "MstPosition",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDateTime",
                schema: "dbo",
                table: "MstMeasurement",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeleteDateTime",
                schema: "dbo",
                table: "MstMeasurement",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDateTime",
                schema: "dbo",
                table: "MstMeasurement",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDateTime",
                schema: "dbo",
                table: "MstLeadTime",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeleteDateTime",
                schema: "dbo",
                table: "MstLeadTime",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDateTime",
                schema: "dbo",
                table: "MstLeadTime",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDateTime",
                schema: "dbo",
                table: "MstInitialStock",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeleteDateTime",
                schema: "dbo",
                table: "MstInitialStock",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDateTime",
                schema: "dbo",
                table: "MstInitialStock",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDateTime",
                schema: "dbo",
                table: "MstDueDate",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeleteDateTime",
                schema: "dbo",
                table: "MstDueDate",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDateTime",
                schema: "dbo",
                table: "MstDueDate",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDateTime",
                schema: "dbo",
                table: "MstDiscount",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeleteDateTime",
                schema: "dbo",
                table: "MstDiscount",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDateTime",
                schema: "dbo",
                table: "MstDiscount",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDateTime",
                schema: "dbo",
                table: "MstDepartment",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeleteDateTime",
                schema: "dbo",
                table: "MstDepartment",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDateTime",
                schema: "dbo",
                table: "MstDepartment",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDateTime",
                schema: "dbo",
                table: "MstCategory",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeleteDateTime",
                schema: "dbo",
                table: "MstCategory",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDateTime",
                schema: "dbo",
                table: "MstCategory",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDateTime",
                schema: "dbo",
                table: "MstBank",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeleteDateTime",
                schema: "dbo",
                table: "MstBank",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDateTime",
                schema: "dbo",
                table: "MstBank",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset");

            migrationBuilder.CreateIndex(
                name: "IX_OrdPurchaseRequest_DueDateId",
                schema: "dbo",
                table: "OrdPurchaseRequest",
                column: "DueDateId");

            migrationBuilder.CreateIndex(
                name: "IX_OrdPurchaseOrder_DueDateId",
                schema: "dbo",
                table: "OrdPurchaseOrder",
                column: "DueDateId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrdPurchaseOrder_MstDueDate_DueDateId",
                schema: "dbo",
                table: "OrdPurchaseOrder",
                column: "DueDateId",
                principalSchema: "dbo",
                principalTable: "MstDueDate",
                principalColumn: "DueDateId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OrdPurchaseRequest_MstDueDate_DueDateId",
                schema: "dbo",
                table: "OrdPurchaseRequest",
                column: "DueDateId",
                principalSchema: "dbo",
                principalTable: "MstDueDate",
                principalColumn: "DueDateId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
