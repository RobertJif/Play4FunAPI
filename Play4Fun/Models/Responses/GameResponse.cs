namespace Play4Fun.Models.Responses
{
    public class GameResponse
    {

        public int Id { get; set; }
        public string Code { get; set; } = "";
        public string DescriptionHTML { get; set; } = "";
        public string GameImagePath { get; set; } = "";
        public string Name { get; set; } = "";
        public int PlayerCount { get; set; }

    }
}
