namespace SingleResponsibility
{
    public class ProductService
    {
        public int AddProduct(string name, decimal price)
        {
            //Environment Values olmalı:
            string connectionString = "Data Source=(localdb)\\Mssqllocaldb;Initial Catalog=Northwind;Integrated Security=True";
            string commandText = "Insert into Products (ProductName, UnitPrice) values (@name,@price)";

            Dictionary<string, object> parameters = new Dictionary<string, object>();

            parameters.Add("@name", name);
            parameters.Add("@price", price);

            DataAccess dataAccess = new DataAccess(connectionString);
            var affectedRows = dataAccess.ExecuteNonQuery(commandText, parameters);

            return affectedRows;
        }

        public int UpdateProduct(string name, decimal price)
        {
            return 0;
        }

        public void SendInfoMailToProductOwner(string mail)
        {

        }


    }
}
