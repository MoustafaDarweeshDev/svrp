namespace core.Entities
{
    public class failed_jobs
    {
        public int Id { get; set; }
        public string Uuid { get; set; }
        public string Connection { get; set; }
        public string Queue { get; set; }
        public string Payload { get; set; }
        public string Exception { get; set; }
        public DateTime Failed_at { get; set; }


    }
}
