namespace Database.Model
{
    public class Department
    {
        private int _id;
        private string _name;

        public int Id
        {
            get { return _id; }
        }
        public string Name
        {
            get { return _name; }
        }

        public Department(int id, string name)
        {
            _id = id;
            _name = name;
        }

        public override string ToString()
        {
            return _name;
        }
    }
}
