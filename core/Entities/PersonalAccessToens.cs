namespace core.Entities
{
    public class PersonalAccessToens
    {
        public int Id { get; set; }
        public string TokenEnableType { get; set; }
        public int TokenEnableId { get; set; }
        public string Name { get; set; }
        public string Token { get; set; }
        public string Abilities { get; set; }
        public DateTime LastUsedAt { get; set; }
        public DateTime ExpiresAt { get; set; }
        public DateTime CreatrdAt { get; set; }
        public DateTime UpdatedAt { get; set; }

    }
}
