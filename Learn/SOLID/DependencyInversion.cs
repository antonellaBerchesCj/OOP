using System.Security.Claims;

namespace Learn.SOLID
{
    // Una classe dovrebbe dipendere dalle astrazioni, non da classi concrete.
    // creare classi che non dipendono da implementazioni concrete ma da interfacce o astrazioni.

    public static class DependencyInversion
    {
    }

    public interface IDatabase
    {
        public void Connect();
    }
    public class MYSQLDB : IDatabase
    {
        public void Connect() => throw new NotImplementedException();
    }

    public class MongoDB : IDatabase
    {
        public void Connect() => throw new NotImplementedException();
    }

    public class ChangePassword
    {
        //public void ChangePass(IDatabase db) => db.ChangePass();    
    }
}
