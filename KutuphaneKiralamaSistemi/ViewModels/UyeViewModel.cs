namespace KutuphaneKiralamaSistemi.ViewModels
{
    public class UyeViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public bool KitabıVarmı { get; set; }

        public override string ToString() => $"{Name} {Surname}";
    }
}