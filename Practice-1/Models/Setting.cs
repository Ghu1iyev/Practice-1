using System.Collections.Generic;

namespace Practice_1.Models
{
    public class Setting
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public int Number { get; set; }
        public List<HeaderSocialMedia> HeaderSocialMedias { get; set; }
        public List<FooterSocialMedia> FooterSocialMedias { get; set; }
    }
}
