using CelilCavus.DependencyInversion.Dependency.Interfaces;

namespace CelilCavus.DependencyInversion.Dependency
{
    public class Imalat
    {
        //High Level Class    
        IGida gida;

        public Imalat(IGida gida)
        {
            this.gida = gida;
        }

        public void Olustur()
        {
            gida.Yap(true);
        }
    }

    public class Kek : IGida
    {
        //Low Level Method
        public void Yap(bool Olustur)
        {
            System.Console.WriteLine("Kek Yapılıyor..");
        }
    }
    public class Pizza : IGida
    {
        public void Yap(bool Olustur)
        {
           System.Console.WriteLine("Pizza Yapılıyor");
        }
    }
}