#nullable enable

using library.domain.Exceptions;
using library.domain.ValueObjects;

namespace library.domain.Entities
{
    public class User : Base
    {
        public string Username { get; private set; }
        public bool IsEnabled { get; private set; }

        public Address? Address { get; private set; }

        public User(string username, Address? address)
        {
            if (string.IsNullOrEmpty(username) && username.Length < 3 || username.Length > 25)
                throw new RequestInvalidException("Nome do usuário deve ter entre 3 e 25 caracteres");

            Username = username;
            IsEnabled = true;
            Address = address;
        }

        public void DisableUser()
        {
            IsEnabled = false;
        }
    }
}