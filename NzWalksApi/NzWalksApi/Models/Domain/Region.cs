namespace NzWalksApi.Models.Domain
{
    public class Region
    {
        public Guid Id { get; set; }
        public int Code { get; set; }
        public string Name { get; set; }
        public double Area { get; set; }
        public double lat { get; set; }
        public long  Population { get; set; }


        //Navigation property

        public IEnumerable<Walk> Walks { get; set; }

    }




}
