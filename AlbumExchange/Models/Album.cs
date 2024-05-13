namespace AlbumExchange.Models
{
    public class Album
    {
        public int album_id { get; set; }
        public string album_name { get; set; }
        public string artist { get; set; }
        public string genre { get; set; }
        public string release_date { get; set; }
        public string album_cover { get; set; }
        public string description { get; set; }
    }
}
