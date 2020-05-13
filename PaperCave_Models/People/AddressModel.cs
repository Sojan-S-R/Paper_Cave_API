namespace PaperCave_Models.People
{
    class AddressModel
    {
        public long HouseNumber { get; set; }
        public string Street { get; set; }
        public string Locality { get; set; }
        public string CityorTown { get; set; }
        public string State { get; set; }
        public string PostCode { get; set; }
    }
}
