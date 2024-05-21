namespace AlbumExchange.Models
{
    public class Album
    {
        public int album_id { get; set; }
        public string title { get; set; }
        public string release_date { get; set; }
        public string artist_id { get; set; }
        public string genre { get; set; }
        
        public string album_cover { get; set; }
        public string description { get; set; }
    }
}
