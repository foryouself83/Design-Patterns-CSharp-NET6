using State.Interface;

namespace State.Model
{
    internal abstract class User : Interface.IUser
    {
        private Enum.UserType _userType;
        public User ChangeUserType(Enum.UserType userType)
        {
            Console.WriteLine($"ChangeUserType: {userType.ToString()}");
            _userType = userType;
            switch (_userType)
            {
                case Enum.UserType.Fmea:
                    return new FmeaUser();
                case Enum.UserType.Stpa:
                    return new StpaUser();
                case Enum.UserType.Fta:
                    return new FtaUser();
                case Enum.UserType.Ultimate:
                    return new UltimateUser();
                default:
                    return new GuestUser();
                    
            }
        }
        public abstract void GetReport();
    }
}
