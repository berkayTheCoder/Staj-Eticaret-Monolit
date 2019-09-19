using Microsoft.AspNetCore.Authorization.Infrastructure;

namespace EticaretMonolit.Authorization
{
    public static class Islem
    {
        public static OperationAuthorizationRequirement Create =   
          new OperationAuthorizationRequirement {Name=Islemler.OlusturmaIslem};
        public static OperationAuthorizationRequirement Read = 
          new OperationAuthorizationRequirement {Name=Islemler.OkumaIslem};  
        public static OperationAuthorizationRequirement Update = 
          new OperationAuthorizationRequirement {Name=Islemler.GuncellemeIslem}; 
        public static OperationAuthorizationRequirement Delete = 
          new OperationAuthorizationRequirement {Name=Islemler.SilmeIslem};
        public static OperationAuthorizationRequirement Onayla = 
          new OperationAuthorizationRequirement {Name=Islemler.OnaylamaIslem};
        public static OperationAuthorizationRequirement Reject = 
          new OperationAuthorizationRequirement {Name=Islemler.RedIslem};
    }

    public class Islemler
    {
        public static readonly string OlusturmaIslem = "Create";
        public static readonly string OkumaIslem = "Read";
        public static readonly string GuncellemeIslem = "Update";
        public static readonly string SilmeIslem = "Delete";
        public static readonly string OnaylamaIslem = "Onayla";
        public static readonly string RedIslem = "Red";
    }
    public class Roller { 
        public static readonly string AdminRole = "Başgan";
        public static readonly string ManagerRole = "Yönetici";
        public static readonly string Uye = "Uye";
    }
}