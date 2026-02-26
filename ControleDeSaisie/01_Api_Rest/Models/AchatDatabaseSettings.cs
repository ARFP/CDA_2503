namespace _01_Api_Rest.Models
{
    public class AchatDatabaseSettings
    {
        public string ConnectionString { get; set; } = null!;

        public string DatabaseName { get; set; } = null!;

        public string AchatCollectionName { get; set; } = null!;
    }
}
