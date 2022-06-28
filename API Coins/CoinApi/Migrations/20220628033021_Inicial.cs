using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoinApi.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Coins",
                columns: table => new
                {
                    MonedaId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Descripcion = table.Column<string>(type: "TEXT", nullable: true),
                    Valor = table.Column<double>(type: "REAL", nullable: true),
                    ImageUrl = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coins", x => x.MonedaId);
                });

            migrationBuilder.InsertData(
                table: "Coins",
                columns: new[] { "MonedaId", "Descripcion", "ImageUrl", "Valor" },
                values: new object[] { 1, "Bitcoin", "https://s2.coinmarketcap.com/static/img/coins/64x64/1.png", 23000.0 });

            migrationBuilder.InsertData(
                table: "Coins",
                columns: new[] { "MonedaId", "Descripcion", "ImageUrl", "Valor" },
                values: new object[] { 2, "Ethereum", "https://s2.coinmarketcap.com/static/img/coins/64x64/1027.png", 1247.75 });

            migrationBuilder.InsertData(
                table: "Coins",
                columns: new[] { "MonedaId", "Descripcion", "ImageUrl", "Valor" },
                values: new object[] { 3, "Tether", "https://s2.coinmarketcap.com/static/img/coins/64x64/825.png", 1.0 });

            migrationBuilder.InsertData(
                table: "Coins",
                columns: new[] { "MonedaId", "Descripcion", "ImageUrl", "Valor" },
                values: new object[] { 4, "Binance Coin", "https://s2.coinmarketcap.com/static/img/coins/64x64/4687.png", 239.56 });

            migrationBuilder.InsertData(
                table: "Coins",
                columns: new[] { "MonedaId", "Descripcion", "ImageUrl", "Valor" },
                values: new object[] { 5, "Cardano Coin", "https://s2.coinmarketcap.com/static/img/coins/64x64/2010.png", 27.32 });

            migrationBuilder.InsertData(
                table: "Coins",
                columns: new[] { "MonedaId", "Descripcion", "ImageUrl", "Valor" },
                values: new object[] { 6, "LiteCoin", "https://s2.coinmarketcap.com/static/img/coins/64x64/2.png", 59.229999999999997 });

            migrationBuilder.InsertData(
                table: "Coins",
                columns: new[] { "MonedaId", "Descripcion", "ImageUrl", "Valor" },
                values: new object[] { 7, "Stellar", "https://s2.coinmarketcap.com/static/img/coins/64x64/512.png", 0.127494 });

            migrationBuilder.InsertData(
                table: "Coins",
                columns: new[] { "MonedaId", "Descripcion", "ImageUrl", "Valor" },
                values: new object[] { 8, "DogeCoin", "https://s2.coinmarketcap.com/static/img/coins/64x64/74.png", 0.069000000000000006 });

            migrationBuilder.InsertData(
                table: "Coins",
                columns: new[] { "MonedaId", "Descripcion", "ImageUrl", "Valor" },
                values: new object[] { 9, "XRP", "https://s2.coinmarketcap.com/static/img/coins/64x64/52.png", 0.36105100000000001 });

            migrationBuilder.InsertData(
                table: "Coins",
                columns: new[] { "MonedaId", "Descripcion", "ImageUrl", "Valor" },
                values: new object[] { 10, "BNB", "https://s2.coinmarketcap.com/static/img/coins/64x64/1839.png", 239.59999999999999 });

            migrationBuilder.InsertData(
                table: "Coins",
                columns: new[] { "MonedaId", "Descripcion", "ImageUrl", "Valor" },
                values: new object[] { 11, "TRON", "https://s2.coinmarketcap.com/static/img/coins/64x64/1958.png", 0.065000000000000002 });

            migrationBuilder.InsertData(
                table: "Coins",
                columns: new[] { "MonedaId", "Descripcion", "ImageUrl", "Valor" },
                values: new object[] { 12, "Uniswap", "https://s2.coinmarketcap.com/static/img/coins/64x64/7083.png", 5.3399999999999999 });

            migrationBuilder.InsertData(
                table: "Coins",
                columns: new[] { "MonedaId", "Descripcion", "ImageUrl", "Valor" },
                values: new object[] { 13, "Cronos", "https://s2.coinmarketcap.com/static/img/coins/64x64/3635.png", 2723.5999999999999 });

            migrationBuilder.InsertData(
                table: "Coins",
                columns: new[] { "MonedaId", "Descripcion", "ImageUrl", "Valor" },
                values: new object[] { 14, "Algorand", "https://s2.coinmarketcap.com/static/img/coins/64x64/4030.png", 0.341862 });

            migrationBuilder.InsertData(
                table: "Coins",
                columns: new[] { "MonedaId", "Descripcion", "ImageUrl", "Valor" },
                values: new object[] { 15, "Aave", "https://s2.coinmarketcap.com/static/img/coins/64x64/7278.png", 67.140000000000001 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Coins");
        }
    }
}
