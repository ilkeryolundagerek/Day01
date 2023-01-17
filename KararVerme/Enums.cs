using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KararVerme
{
    //enum (enumerate/numaralandırılmış nesne): Girilen her değer için bir numara ataması yapar. Özel olarak belirtilmezse başlangıç konumu 0 olur.
    public enum Gunler
    {
        Pazartesi,
        Sali,
        Carsamba,
        Persembe,
        Cuma,
        Cumartesi,
        Pazar
    }

    public enum PageType
    {
        Home=1000,
        Index,
        About,
        News=1200,
        Finance=1350,
        Account=2130
    }

    public enum ResponseType
    {
        Success,
        Danger,
        Warning,
        Info,
        Critical
    }
}
