using Microsoft.EntityFrameworkCore;

public class Contexto : DbContext{

    public DbSet<Coins> Coins { get; set; }

    public Contexto(DbContextOptions<Contexto> options) : base(options){

    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Coins>().HasData(new Coins(){
            MonedaId = 1,
            Descripcion = "Bitcoin",
            Valor = 23000,
            ImageUrl = "https://s2.coinmarketcap.com/static/img/coins/64x64/1.png"
        });

        modelBuilder.Entity<Coins>().HasData(new Coins(){
            MonedaId = 2,
            Descripcion = "Ethereum",
            Valor = 1247.75,
            ImageUrl = "https://s2.coinmarketcap.com/static/img/coins/64x64/1027.png"
        });

        modelBuilder.Entity<Coins>().HasData(new Coins(){
            MonedaId = 3,
            Descripcion = "Tether",
            Valor = 1.00,
            ImageUrl = "https://s2.coinmarketcap.com/static/img/coins/64x64/825.png"
        });

        modelBuilder.Entity<Coins>().HasData(new Coins(){
            MonedaId = 4,
            Descripcion = "Binance Coin",
            Valor = 239.56,
            ImageUrl = "https://s2.coinmarketcap.com/static/img/coins/64x64/4687.png"
        });
        modelBuilder.Entity<Coins>().HasData(new Coins(){
            MonedaId = 5,
            Descripcion = "Cardano Coin",
            Valor = 27.32,
            ImageUrl = "https://s2.coinmarketcap.com/static/img/coins/64x64/2010.png"
        });

        modelBuilder.Entity<Coins>().HasData(new Coins(){
            MonedaId = 6,
            Descripcion = "LiteCoin",
            Valor = 59.23,
            ImageUrl = "https://s2.coinmarketcap.com/static/img/coins/64x64/2.png"
        });

        modelBuilder.Entity<Coins>().HasData(new Coins(){
            MonedaId = 7,
            Descripcion = "Stellar",
            Valor = 0.127494,
            ImageUrl = "https://s2.coinmarketcap.com/static/img/coins/64x64/512.png"
        });

        modelBuilder.Entity<Coins>().HasData(new Coins(){
            MonedaId = 8,
            Descripcion = "DogeCoin",
            Valor = 0.069,
            ImageUrl = "https://s2.coinmarketcap.com/static/img/coins/64x64/74.png"
        });

        modelBuilder.Entity<Coins>().HasData(new Coins(){
            MonedaId = 9,
            Descripcion = "XRP",
            Valor = 0.361051,
            ImageUrl = "https://s2.coinmarketcap.com/static/img/coins/64x64/52.png"
        });

        modelBuilder.Entity<Coins>().HasData(new Coins(){
            MonedaId = 10,
            Descripcion = "BNB",
            Valor = 239.60,
            ImageUrl = "https://s2.coinmarketcap.com/static/img/coins/64x64/1839.png"
        });

        modelBuilder.Entity<Coins>().HasData(new Coins(){
            MonedaId = 11,
            Descripcion = "TRON",
            Valor = 0.065,
            ImageUrl = "https://s2.coinmarketcap.com/static/img/coins/64x64/1958.png"
        });

        modelBuilder.Entity<Coins>().HasData(new Coins(){
            MonedaId = 12,
            Descripcion = "Uniswap",
            Valor =5.34,
            ImageUrl = "https://s2.coinmarketcap.com/static/img/coins/64x64/7083.png"
        });

        modelBuilder.Entity<Coins>().HasData(new Coins(){
            MonedaId = 13,
            Descripcion = "Cronos",
            Valor = 2723.60,
            ImageUrl = "https://s2.coinmarketcap.com/static/img/coins/64x64/3635.png"
        });

        modelBuilder.Entity<Coins>().HasData(new Coins(){
            MonedaId = 14,
            Descripcion = "Algorand",
            Valor = 0.341862,
            ImageUrl = "https://s2.coinmarketcap.com/static/img/coins/64x64/4030.png"
        });

        modelBuilder.Entity<Coins>().HasData(new Coins(){
            MonedaId = 15,
            Descripcion = "Aave",
            Valor = 67.14,
            ImageUrl = "https://s2.coinmarketcap.com/static/img/coins/64x64/7278.png"
        });
    }
}