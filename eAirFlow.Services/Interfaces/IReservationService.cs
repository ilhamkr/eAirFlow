using eAirFlow.Model.Models;
using eAirFlow.Model.Requests;
using eAirFlow.Model.SearchObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eAirFlow.Services.Interfaces
{
    public interface IReservationService : ICRUDService<Reservation, ReservationSearchObject, ReservationInsertRequest, ReservationUpdateRequest>
    {
        public Reservation Confirm(int id);
        public Reservation Cancel(int id);
        public Reservation Complete(int id);
        public Reservation Pay(int id);
        Reservation MarkAsPaid(int reservationId, int paymentId);
        List<Reservation> GetByUser(int userId);
        void Delete(int id);



    }
}
