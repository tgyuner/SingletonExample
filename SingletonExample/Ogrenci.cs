namespace SingletonExample
{
   public class Ogrenci
    {
        // Tugay ÜNER 2018 ©

        public string OgrenciAd { get; set; }
        public string OgrenciSoyad { get; set; }

        private static Ogrenci _ogrenci;

        private Ogrenci()
        {

        }

        public static Ogrenci Instance()
        {
            if (_ogrenci==null)
            {
                _ogrenci = new Ogrenci();
                return _ogrenci;
            }
            else
            {
                return _ogrenci;
            }
        }


    }
}
