namespace PaperlessRestAPI.BusinessLogic.Entities
{
    public class Correspondents
    {
        public int Id { get; set; }
        public string Slug { get; set; }
        public string Name { get; set; }

        public string Match { get; set; }
        public int MatchingAlgorithm { get; set; }
        public bool IsInsensitive { get; set; }

        public Correspondents LastCorrespondents { get; set; }
        public int Owner { get; set; }

        public IHasPremission View { get; set; }
        public IHasPremission Change { get; set; }

    }

    public interface IHasPremission
    {
        User[] Users { get; set; }
        Group[] Groups { get; set; }
    }
}