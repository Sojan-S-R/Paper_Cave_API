namespace PaperCave_Models.People.Interfaces
{
    interface IPeopleModel
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateModel Dob { get; set; }
        public string PhoneNo { get; set; }
        public AddressModel Address { get; set; }
    }
}
