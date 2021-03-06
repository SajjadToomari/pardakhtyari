﻿using System.ComponentModel;

namespace Shaparak.PaymentFacilitation.Enums {

    /// <summary>
    /// نوع ملیت
    /// </summary>
    public enum ShaparakResidencyType {
        
        [Description("ایرانی")]
        Iranian = 0,
        
        [Description("غیرایرانی")]
        Foreign = 1
        
    }
}
