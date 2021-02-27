﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    //static de newlemiyoruz
    public static class Messages
    {
        
        public static string CarAdded = "Araba Eklendi";
        public static string CarDeleted = "Araba Silindi";
        public static string CarUpdated = "Araba Güncellendi";
        public static string CarDailyPriceInvalid = "Araba Fiyat Biligisi  Geçersiz";

        public static string BrandAdded = " Marka  Eklendi";
        public static string BrandDeleted = "Marka Silindi";

        
        public static string BrandUpdated = "Marka Güncellendi";
        public static string BrandBrandNameInvalid = "Araba Markası  Geçersiz";

        public static string ColorAdded = " Renk  Eklendi";
        public static string ColorDeleted = "Renk Silindi";
        public static string ColorUpdated = "Renk  Güncellendi";
        public static string MaintenanceTime = "sistem bakımda";
        public static string CarsListed = "ürünler listelendi";

        public static string CustomerAdded = "Müşteri Eklendi";
        public static string CustomerDeleted = "Müşteri Silindi";
        public static string CustomerUpdated = "Müşteri Güncellendi";

        public static string RentalAdded = "Araba Kiralama işlemi baraşıyla gerçekleşti.";
        public static string RentalDeleted = "Araba Kiralama işlemi iptal edildi.";
        public static string RentalUpdated = "Araba Kiralama işlemi güncellendi.";
        public static string RentalAddedError = "Aracın kiraya verilebilmesi için önce teslim edilmesi gerekir.";
        public static string RentalReturned = "Kiraladığınız araç teslim edildi";

        public static string UserAdded = "Kullanıcı Eklendi";
        public static string USerDeleted = "Kullanıcı Silindi";
        public static  string UserUpdated = "Kullanıcı Güncellendi";
    }
}