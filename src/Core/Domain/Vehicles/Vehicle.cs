using Domain.Abstractions;
using Domain.Shared;

namespace Domain.Vehicles
{
    public sealed class Vehicle(
        Guid id,
        Model model,
        Plate plate,
        Currency price,
        Currency maintenance,
        DateTime lastRentalDate,
        List<Accessory> accessories,
        Address address
    ) : Entity(id)
    {
        public Model? Model { get; private set; } = model;
        public Plate? Plate { get; private set; } = plate;
        public Address? Address { get; private set; } = address;
        public Currency? Price { get; private set; } = price;
        public Currency? Maintenance { get; private set; } = maintenance;
        public DateTime LastRentalDate { get; private set; } = lastRentalDate;
        public List<Accessory>? Accessories { get; private set; } = accessories;
    }
}