namespace Practice_1.Models
{
    public class HeaderSocialMedia
    {
        public int Id { get; set; }
        public  string  Name { get; set; }
        public string Url { get; set; }
        public string Icon { get; set; }
        public int SettingId { get; set; }
        public Setting Settings { get; set; }
    }
}
