namespace Model
{
    public class CommpanyInfo
    {
        private int _id;
        private string _commpanyname;
        private string _taxnumber;
        private string _address;
        private string _bank;
        private string _contact;
        private string _phone;

        public int Id { get => _id; set => _id = value; }
        public string Commpanyname { get => _commpanyname; set => _commpanyname = value; }
        public string Taxnumber { get => _taxnumber; set => _taxnumber = value; }
        public string Address { get => _address; set => _address = value; }
        public string Bank { get => _bank; set => _bank = value; }
        public string Contact { get => _contact; set => _contact = value; }
        public string Phone { get => _phone; set => _phone = value; }
    }
}