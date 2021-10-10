using System;

namespace PrevisaoTempo.Application.SearchUser.DTO
{
    public class SearchResultDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Temp { get; set; }
        public string Weather { get; set; }
        public string Humidity { get; set; }
        public string Icon { get; set; }
        public DateTime CreationDate { get; set; }
        
    }
}