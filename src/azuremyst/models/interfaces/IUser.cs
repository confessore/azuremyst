using azuremyst.models.enums;

namespace azuremyst.models.interfaces
{
    public interface IUser
    {
        UserType UserType { get; set; }
    }
}
