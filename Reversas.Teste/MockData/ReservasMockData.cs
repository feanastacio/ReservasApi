using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reservas.Api.Models;

namespace Reversas.Teste.MockData
{
    public class ReservasMockData
    {
        public static List<Reserva> GetReservas()
        {
            return new List<Reserva>() {
                new Reserva {ReservaId = 1, Nome="Marcos", InicioLocacao="Sâo Paulo", FimLocacao="Campinas"},
                new Reserva {ReservaId = 2, Nome="Fernanda", InicioLocacao="Sâo Paulo", FimLocacao="Rio de Janeiro"},
                new Reserva {ReservaId = 3, Nome="Samantha", InicioLocacao="Sâo Paulo", FimLocacao="Niterói"}
            };
        }
    }
}