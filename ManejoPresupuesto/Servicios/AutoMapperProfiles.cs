using AutoMapper;
using ManejoPresupuesto.Models;
using System.Transactions;

namespace ManejoPresupuesto.Servicios
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            // Desde -> Hacia
            CreateMap<Cuenta, CuentaCreacionViewModel>();            
        }
    }
}