using System;

namespace Database.Model
{
    public class StockRequest
    {
        private int _id;
        private int _productId;
        private int _quantity;
        private string _description;
        private int _departmentId;
        private DateTime _date;
        private bool _approved;

        public StockRequest(int id, int productId, int quantity, string description, int departmentId,
            DateTime date, bool approved)
        {
            _id = id;
            _productId = productId;
            _quantity = quantity;
            _description = description;
            _departmentId = departmentId;
            _date = date;
            _approved = approved;
        }

        public int Id
        {
            get { return _id; }
        }
        public int ProductId
        {
            get { return _productId; }
        }
        public int Quantity
        {
            get { return _quantity; }
        }
        public string Description
        {
            get { return _description; }
        }
        public int DepartmentId
        {
            get { return _departmentId; }
        }
        public DateTime Date
        {
             get { return _date; }
        }
        public bool Approved
        {
             get { return _approved; }
        }

        public override string ToString()
        {
            Product product = DatabaseController.GetProduct(_productId);
            return $"{product.Name} - {_quantity} units";
        }
    }
}
