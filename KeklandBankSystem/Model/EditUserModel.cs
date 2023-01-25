namespace KeklandBankSystem.Model
{
    public class EditUserModel
    {
        public string Name { get; set; }
        public int Money { get; set; }
        public int Id { get; set; }
        public int PremiumDay { get; set; }
        public string Role { get; set; }
        public bool IsArrested { get; set; }
    }
}
