using Domain.Abstractions;

namespace Domain.Users
{
    public static class UserErrors
    {
        public static Error NotFound = new(
            "User.Found",
            "El usuario con ese id no existe."
        );

        public static Error InvalidCredentials = new(
            "User.InvalidCredentials",
            "Las credenciales son incorrectas."
        );
    }
}