namespace Database.Model
{
    public class Product
    {
        private int _id;
        private string _name;
        private string _manufacturer;
        private double _priceBought;
        private double _priceSelling;
        private double _weight;
        private double _height;
        private double _width;
        private double _depth;
        private int _quantity;
        private int _departmentId;
        private int _storeIsle;
        private int _warehouseIsle;
        private int _restocked;
        private string _description;
        
        public Product(int id, string name, string manufacturer, double priceBought, 
            double priceSelling, double weight, double height, double width, double depth, 
            int quantity, int departmentId, int storeIsle, int warehouseIsle, int restocked, string description)
        {
            _id = id;
            _name = name;
            _manufacturer = manufacturer;
            _priceBought = priceBought;
            _priceSelling = priceSelling;
            _weight = weight;
            _height = height;
            _width = width;
            _depth = depth;
            _quantity = quantity;
            _departmentId = departmentId;
            _storeIsle = storeIsle;
            _warehouseIsle = warehouseIsle;
            _restocked = restocked;
            _description = description;
        }

        public int Id
        {
            get { return _id; }
        }
        public string Name
        {
            get { return _name; }
        }
        public string Manufacturer
        {
            get { return _manufacturer; }
        }
        public double PriceBought
        {
            get { return _priceBought; }
        }
        public double PriceSelling
        {
            get { return _priceSelling; }
        }
        public double Weight
        {
            get { return _weight; }
        }
        public double Height
        {
            get { return _height; }
        }
        public double Width
        {
            get { return _width; }
        }
        public double Depth
        {
            get { return _depth; }
        }
        public int Quantity
        {
            get { return _quantity; }
        }
        public int DepartmentId
        {
            get { return _departmentId; }
        }
        public int Restocked
        {
            get { return _restocked; }
            set { _restocked = value; }
        }
        public double StoreIsle
        {
            get { return _storeIsle; }
        }
        public double WarehouseIsle
        {
            get { return _warehouseIsle; }
        }
        public string Description
        {
            get { return _description; }
        }

        public override string ToString()
        {
            return _name;
        }
    }
}
