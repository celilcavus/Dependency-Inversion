using CelilCavus.DependencyInversion.Dependency;

internal class Program
{
    private static void Main(string[] args)
    {
        Imalat kek = new Imalat(new Kek());
        kek.Olustur();

         Imalat pizza = new Imalat(new Pizza());
        pizza.Olustur();
    }
}