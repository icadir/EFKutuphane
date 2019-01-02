namespace KutuphaneKiralamaSistemi.ViewModels
{
    public class YazarViewModel
    {
        public int YazarId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public override string ToString() => $"{Name} {Surname}";
    }
}