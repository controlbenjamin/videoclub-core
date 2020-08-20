using Microsoft.EntityFrameworkCore.Migrations;

namespace VideoClubCore.Data.Migrations
{
    public partial class InsertarRegistrosTablaClientes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Clientes(Apellidos, Nombres, Dni) " +
         "VALUES ('Correa', 'Benjamin', '32635236')");
            migrationBuilder.Sql("INSERT INTO Clientes(Apellidos, Nombres, Dni) " +
         "VALUES ('Perez', 'Juana Miriam', '39526536')");
            migrationBuilder.Sql("INSERT INTO Clientes(Apellidos, Nombres, Dni) " +
         "VALUES ('Montenegro de la Fuente', 'Adrian Marcelo', '12369456')");
            migrationBuilder.Sql("INSERT INTO Clientes(Apellidos, Nombres, Dni) " +
         "VALUES ('Vai', 'Steve', '22563587')");
            migrationBuilder.Sql("INSERT INTO Clientes(Apellidos, Nombres, Dni) " +
         "VALUES ('San Martin', 'Jose Maria del Corazón de Jesús', '11222666')");

        }
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Clientes");
        }
    }
}
