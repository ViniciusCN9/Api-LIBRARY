using library.domain.Exceptions;

namespace library.domain.ValueObjects
{
    public class Address
    {
        public string Street { get; private set; }
        public string City { get; private set; }
        public string State { get; private set; }

        public Address(string street, string city, string state)
        {
            if (string.IsNullOrEmpty(street) && street.Length < 3 || street.Length > 30)
                throw new RequestInvalidException("Rua deve ter entre 3 e 30 caracteres");

            if (string.IsNullOrEmpty(city) && city.Length < 3 || city.Length > 30)
                throw new RequestInvalidException("Cidade deve ter entre 3 e 30 caracteres");

            if (string.IsNullOrEmpty(state) && state.Length < 3 || state.Length > 30)
                throw new RequestInvalidException("Estado deve ter entre 3 e 30 caracteres");

            Street = street;
            City = city;
            State = state;
        }
    }
}