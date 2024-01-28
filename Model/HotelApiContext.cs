using Microsoft.EntityFrameworkCore;

namespace hotel_api
{
    public class HotelApiContext : DbContext
    {
        public DbSet<Filial> Filiais { get; set; }
        public DbSet<Quarto> Quartos { get; set; }
        public DbSet<ConsumoRestauranteFrigobar> Consumos { get; set; }
        public DbSet<ServicoLavanderia> ServicosLavanderia { get; set; }
        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<FuncionarioCargo> FuncionariosCargos { get; set; }
        public DbSet<Reserva> Reservas { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
    public DbSet<NotaFiscal> NotasFiscais { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost, 1433;Database=HotelDb;User Id=SA;Password=MyPass@word;TrustServerCertificate=True;MultipleActiveResultSets=true");
        }
    }
}