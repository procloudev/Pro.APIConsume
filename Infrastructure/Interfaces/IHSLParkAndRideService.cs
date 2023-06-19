using Pro.APIConsume.Models;

namespace Pro.APIConsume.Infrastructure.Interfaces
{
    public interface IHSLParkAndRideService
    {
        public Task<IEnumerable<string>> GetServices();
        public Task<IEnumerable<string>> GetPaymentMethods();
        public Task<IEnumerable<string>> GetPricingMethods();
        public Task<IEnumerable<string>> GetFacilityStatuses();
        public Task<Operator> GetOperators();
        public Task<IEnumerable<Contact>> GetContacts();
        public Task<IEnumerable<Facility>> GetFacilities();

    }
}
