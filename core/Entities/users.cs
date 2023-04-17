namespace core.Entities
{
    public class users
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string discriminator { get; set; }
        public string Email { get; set; }
        public string Avatar { get; set; }
        public int Verified { get; set; }
        public string Locale { get; set; }
        public string SteamId { get; set; }
        public string SteamAvatar { get; set; }
        public string SteamLink { get; set; }
        public string SteamUsername { get; set; }
        public int mfa_enabled { get; set; }
        public string refresh_token { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }

    }
}
