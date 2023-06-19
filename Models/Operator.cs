namespace Pro.APIConsume.Models
{
    public class Operator
    {
        public Result[] results { get; set; }
        public bool hasMore { get; set; }
    }

    public class Result
    {
        public int id { get; set; }
        public Name name { get; set; }
        public object regionId { get; set; }
    }

    public class Name
    {
        public string fi { get; set; }
        public string sv { get; set; }
        public string en { get; set; }
    }
}
