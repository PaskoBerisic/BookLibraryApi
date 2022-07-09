using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class M09072022_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 9, 20, 43, 46, 422, DateTimeKind.Utc).AddTicks(3826), new DateTime(2022, 7, 9, 20, 43, 46, 422, DateTimeKind.Utc).AddTicks(3828) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 9, 20, 43, 46, 422, DateTimeKind.Utc).AddTicks(3833), new DateTime(2022, 7, 9, 20, 43, 46, 422, DateTimeKind.Utc).AddTicks(3834) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 9, 20, 43, 46, 422, DateTimeKind.Utc).AddTicks(3837), new DateTime(2022, 7, 9, 20, 43, 46, 422, DateTimeKind.Utc).AddTicks(3838) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 9, 20, 43, 46, 422, DateTimeKind.Utc).AddTicks(3840), new DateTime(2022, 7, 9, 20, 43, 46, 422, DateTimeKind.Utc).AddTicks(3841) });

            migrationBuilder.UpdateData(
                table: "BookRentals",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 9, 20, 43, 46, 422, DateTimeKind.Utc).AddTicks(4866), new DateTime(2022, 7, 9, 20, 43, 46, 422, DateTimeKind.Utc).AddTicks(4868) });

            migrationBuilder.UpdateData(
                table: "BookRentals",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 9, 20, 43, 46, 422, DateTimeKind.Utc).AddTicks(4873), new DateTime(2022, 7, 9, 20, 43, 46, 422, DateTimeKind.Utc).AddTicks(4875) });

            migrationBuilder.UpdateData(
                table: "BookRentals",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 9, 20, 43, 46, 422, DateTimeKind.Utc).AddTicks(4877), new DateTime(2022, 7, 9, 20, 43, 46, 422, DateTimeKind.Utc).AddTicks(4878) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 9, 20, 43, 46, 422, DateTimeKind.Utc).AddTicks(4803), new DateTime(2022, 7, 9, 20, 43, 46, 422, DateTimeKind.Utc).AddTicks(4805) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 9, 20, 43, 46, 422, DateTimeKind.Utc).AddTicks(4810), new DateTime(2022, 7, 9, 20, 43, 46, 422, DateTimeKind.Utc).AddTicks(4811) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 9, 20, 43, 46, 422, DateTimeKind.Utc).AddTicks(4814), new DateTime(2022, 7, 9, 20, 43, 46, 422, DateTimeKind.Utc).AddTicks(4814) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 9, 20, 43, 46, 422, DateTimeKind.Utc).AddTicks(4817), new DateTime(2022, 7, 9, 20, 43, 46, 422, DateTimeKind.Utc).AddTicks(4818) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 9, 20, 43, 46, 422, DateTimeKind.Utc).AddTicks(4912), new DateTime(2022, 7, 9, 20, 43, 46, 422, DateTimeKind.Utc).AddTicks(4913) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 9, 20, 43, 46, 422, DateTimeKind.Utc).AddTicks(4916), new DateTime(2022, 7, 9, 20, 43, 46, 422, DateTimeKind.Utc).AddTicks(4917) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 9, 20, 43, 46, 422, DateTimeKind.Utc).AddTicks(4920), new DateTime(2022, 7, 9, 20, 43, 46, 422, DateTimeKind.Utc).AddTicks(4920) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 9, 20, 43, 46, 422, DateTimeKind.Utc).AddTicks(4962), new DateTime(2022, 7, 9, 20, 43, 46, 422, DateTimeKind.Utc).AddTicks(4964) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 9, 20, 43, 46, 422, DateTimeKind.Utc).AddTicks(4967), new DateTime(2022, 7, 9, 20, 43, 46, 422, DateTimeKind.Utc).AddTicks(4968) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 9, 20, 43, 46, 422, DateTimeKind.Utc).AddTicks(4970), new DateTime(2022, 7, 9, 20, 43, 46, 422, DateTimeKind.Utc).AddTicks(4972) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 9, 20, 43, 46, 422, DateTimeKind.Utc).AddTicks(4973), new DateTime(2022, 7, 9, 20, 43, 46, 422, DateTimeKind.Utc).AddTicks(4974) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 9, 20, 43, 46, 422, DateTimeKind.Utc).AddTicks(5539), new DateTime(2022, 7, 9, 20, 43, 46, 422, DateTimeKind.Utc).AddTicks(5541) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 9, 20, 43, 46, 422, DateTimeKind.Utc).AddTicks(5543), new DateTime(2022, 7, 9, 20, 43, 46, 422, DateTimeKind.Utc).AddTicks(5544) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 9, 20, 43, 46, 422, DateTimeKind.Utc).AddTicks(5546), new DateTime(2022, 7, 9, 20, 43, 46, 422, DateTimeKind.Utc).AddTicks(5547) });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Currency", "Date", "TotalRentalPrice", "TotalRentalPriceWithVAT", "UserId" },
                values: new object[] { 4, "E", new DateTime(2021, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.60m, 2m, 2 });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 9, 20, 43, 46, 422, DateTimeKind.Utc).AddTicks(5952), new DateTime(2022, 7, 9, 20, 43, 46, 422, DateTimeKind.Utc).AddTicks(5953) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 9, 20, 43, 46, 422, DateTimeKind.Utc).AddTicks(5956), new DateTime(2022, 7, 9, 20, 43, 46, 422, DateTimeKind.Utc).AddTicks(5958) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 9, 20, 43, 46, 422, DateTimeKind.Utc).AddTicks(5960), new DateTime(2022, 7, 9, 20, 43, 46, 422, DateTimeKind.Utc).AddTicks(5960) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 9, 20, 43, 46, 422, DateTimeKind.Utc).AddTicks(5993), new DateTime(2022, 7, 9, 20, 43, 46, 422, DateTimeKind.Utc).AddTicks(5994) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 9, 20, 43, 46, 422, DateTimeKind.Utc).AddTicks(5999), new DateTime(2022, 7, 9, 20, 43, 46, 422, DateTimeKind.Utc).AddTicks(6000) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "FirstName", "LastName", "Updated", "Username" },
                values: new object[] { new DateTime(2022, 7, 9, 20, 43, 46, 422, DateTimeKind.Utc).AddTicks(6003), "Name 3", "Surname 3", new DateTime(2022, 7, 9, 20, 43, 46, 422, DateTimeKind.Utc).AddTicks(6004), "User3" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 9, 17, 27, 2, 388, DateTimeKind.Utc).AddTicks(6263), new DateTime(2022, 7, 9, 17, 27, 2, 388, DateTimeKind.Utc).AddTicks(6266) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 9, 17, 27, 2, 388, DateTimeKind.Utc).AddTicks(6268), new DateTime(2022, 7, 9, 17, 27, 2, 388, DateTimeKind.Utc).AddTicks(6268) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 9, 17, 27, 2, 388, DateTimeKind.Utc).AddTicks(6273), new DateTime(2022, 7, 9, 17, 27, 2, 388, DateTimeKind.Utc).AddTicks(6273) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 9, 17, 27, 2, 388, DateTimeKind.Utc).AddTicks(6275), new DateTime(2022, 7, 9, 17, 27, 2, 388, DateTimeKind.Utc).AddTicks(6276) });

            migrationBuilder.UpdateData(
                table: "BookRentals",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 9, 17, 27, 2, 388, DateTimeKind.Utc).AddTicks(6716), new DateTime(2022, 7, 9, 17, 27, 2, 388, DateTimeKind.Utc).AddTicks(6716) });

            migrationBuilder.UpdateData(
                table: "BookRentals",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 9, 17, 27, 2, 388, DateTimeKind.Utc).AddTicks(6718), new DateTime(2022, 7, 9, 17, 27, 2, 388, DateTimeKind.Utc).AddTicks(6719) });

            migrationBuilder.UpdateData(
                table: "BookRentals",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 9, 17, 27, 2, 388, DateTimeKind.Utc).AddTicks(6720), new DateTime(2022, 7, 9, 17, 27, 2, 388, DateTimeKind.Utc).AddTicks(6720) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 9, 17, 27, 2, 388, DateTimeKind.Utc).AddTicks(6692), new DateTime(2022, 7, 9, 17, 27, 2, 388, DateTimeKind.Utc).AddTicks(6693) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 9, 17, 27, 2, 388, DateTimeKind.Utc).AddTicks(6695), new DateTime(2022, 7, 9, 17, 27, 2, 388, DateTimeKind.Utc).AddTicks(6696) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 9, 17, 27, 2, 388, DateTimeKind.Utc).AddTicks(6697), new DateTime(2022, 7, 9, 17, 27, 2, 388, DateTimeKind.Utc).AddTicks(6698) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 9, 17, 27, 2, 388, DateTimeKind.Utc).AddTicks(6699), new DateTime(2022, 7, 9, 17, 27, 2, 388, DateTimeKind.Utc).AddTicks(6699) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 9, 17, 27, 2, 388, DateTimeKind.Utc).AddTicks(6739), new DateTime(2022, 7, 9, 17, 27, 2, 388, DateTimeKind.Utc).AddTicks(6739) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 9, 17, 27, 2, 388, DateTimeKind.Utc).AddTicks(6741), new DateTime(2022, 7, 9, 17, 27, 2, 388, DateTimeKind.Utc).AddTicks(6741) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 9, 17, 27, 2, 388, DateTimeKind.Utc).AddTicks(6742), new DateTime(2022, 7, 9, 17, 27, 2, 388, DateTimeKind.Utc).AddTicks(6743) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 9, 17, 27, 2, 388, DateTimeKind.Utc).AddTicks(6754), new DateTime(2022, 7, 9, 17, 27, 2, 388, DateTimeKind.Utc).AddTicks(6754) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 9, 17, 27, 2, 388, DateTimeKind.Utc).AddTicks(6756), new DateTime(2022, 7, 9, 17, 27, 2, 388, DateTimeKind.Utc).AddTicks(6756) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 9, 17, 27, 2, 388, DateTimeKind.Utc).AddTicks(6757), new DateTime(2022, 7, 9, 17, 27, 2, 388, DateTimeKind.Utc).AddTicks(6758) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 9, 17, 27, 2, 388, DateTimeKind.Utc).AddTicks(6758), new DateTime(2022, 7, 9, 17, 27, 2, 388, DateTimeKind.Utc).AddTicks(6759) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 9, 17, 27, 2, 388, DateTimeKind.Utc).AddTicks(6992), new DateTime(2022, 7, 9, 17, 27, 2, 388, DateTimeKind.Utc).AddTicks(6993) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 9, 17, 27, 2, 388, DateTimeKind.Utc).AddTicks(6994), new DateTime(2022, 7, 9, 17, 27, 2, 388, DateTimeKind.Utc).AddTicks(6994) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 9, 17, 27, 2, 388, DateTimeKind.Utc).AddTicks(6995), new DateTime(2022, 7, 9, 17, 27, 2, 388, DateTimeKind.Utc).AddTicks(6996) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 9, 17, 27, 2, 388, DateTimeKind.Utc).AddTicks(7170), new DateTime(2022, 7, 9, 17, 27, 2, 388, DateTimeKind.Utc).AddTicks(7171) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 9, 17, 27, 2, 388, DateTimeKind.Utc).AddTicks(7172), new DateTime(2022, 7, 9, 17, 27, 2, 388, DateTimeKind.Utc).AddTicks(7172) });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 9, 17, 27, 2, 388, DateTimeKind.Utc).AddTicks(7173), new DateTime(2022, 7, 9, 17, 27, 2, 388, DateTimeKind.Utc).AddTicks(7174) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 9, 17, 27, 2, 388, DateTimeKind.Utc).AddTicks(7191), new DateTime(2022, 7, 9, 17, 27, 2, 388, DateTimeKind.Utc).AddTicks(7191) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 7, 9, 17, 27, 2, 388, DateTimeKind.Utc).AddTicks(7194), new DateTime(2022, 7, 9, 17, 27, 2, 388, DateTimeKind.Utc).AddTicks(7194) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "FirstName", "LastName", "Updated", "Username" },
                values: new object[] { new DateTime(2022, 7, 9, 17, 27, 2, 388, DateTimeKind.Utc).AddTicks(7196), "Name 2", "Surname 2", new DateTime(2022, 7, 9, 17, 27, 2, 388, DateTimeKind.Utc).AddTicks(7196), "User2" });
        }
    }
}
