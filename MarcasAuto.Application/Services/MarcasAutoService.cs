using MarcasAuto.Application.Interfaces;
using MarcasAuto.Domain.Entities;
using MarcasAuto.Infraestructure.DBContexts;
using Microsoft.EntityFrameworkCore;

namespace MarcasAuto.Application.Services
{
    public class MarcasAutoService(MarcasAutoDBContext marcasAutoDBContext) : IMarcasAutoService
    {
        private MarcasAutoDBContext _marcasAutoDBContext { get; set; } = marcasAutoDBContext;

        public async Task<List<MarcasAutoEntity>> GetAll()
        {
            return await _marcasAutoDBContext.Set<MarcasAutoEntity>().ToListAsync();
        }
    }
}
