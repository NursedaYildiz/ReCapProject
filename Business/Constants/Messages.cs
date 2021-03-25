using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string MaintenanceTime = "Sistem bakımda";

        public static string Added = "Ekleme işlemi başarıyla gerçekleştirildi.";
        public static string Updated = "Güncelleme işlemi başarıyla gerçekleştirildi.";
        public static string Deleted = "Silme işlemi başarıyla gerçekleştirildi.";
        public static string Listed = "Listeleme işlemi başarıyla gerçekleştirildi";

        public static string ImagesAdded = "Resim ekleme işlemi başarıyla gerçekleştirildi.";
        public static string FailAddedImageLimit = "Resim ekleme limiti aşıldı";

        public static string AddRentalMessage = "Kiralama işlemi gerçekleştirildi.";
        public static string FailedRentalAddOrUpdate = "Bu araba henüz teslim edilmediği için kiralayamazsınız.";
        public static string ReturnedRental = "Kiraladığınız araç teslim edildi.";
        public static string RentalNotAvailable = "Kiralama işlemi seçilen tarihler arasında uygun değil.";

        public static string UserNotFound = "Kullanıcı bulunamadı.";
        public static string PasswordError = "Parola hatalı.";
        public static string SuccessfulLogin = "Sisteme giriş başarılı.";
        public static string UserAlreadyExists = "Bu kullanıcı zaten mevcut.";
        public static string UserRegistered = "Kullanıcı başarıyla kaydedildi.";
        public static string AccessTokenCreated = "Access token başarıyla oluşturuldu";

        public static string AuthorizationDenied = "Yetkiniz yok.";

        public static string InsufficientBalance = "Yetersiz bakiye";

        public static string PaymentCompleted = "Ödeme yapıldı";
    }
}
