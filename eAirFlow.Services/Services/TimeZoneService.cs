using eAirFlow.Services.Database;
using eAirFlow.Services.Interfaces;
using MapsterMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eAirFlow.Services.Services
{
    public class TimeZoneService : ITimeZoneService
    {
        private readonly _210019Context _context;
        private readonly IMapper _mapper;

        public TimeZoneService(_210019Context context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<Model.Models.TimeZone> GetAll() {
            var entities = _context.TimeZones
                .OrderBy(tz => tz.TimeZoneId)
                .ToList();

            return _mapper.Map<List<Model.Models.TimeZone>>(entities);
        }
    }
}
