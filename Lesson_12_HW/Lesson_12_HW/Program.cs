using System.Security.Cryptography.X509Certificates;

namespace Lesson_12_HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> listForsale = new List<string>();
            ProductsForSale productsForSale = new ProductsForSale();
            productsForSale.ProductName = "\n Videocards\n Motherboards\n Processors\n Processors\n Power Supply\n Phones\n";


            List<Order> orders = new List<Order>();
            Order order = new Order();
            order.CustomerName = "Artur Rudawski";
            order.CustomerEmail = "Bart.Rudawski@gml.com";
            order.ProductName = "\"New Videocard RTX 4090\"";
            order.CustomerPhone = "\"+38099754154\"";
            order.CustomerAdress = "\'Random Adress GO!\'";
            order.OrderID = 359764;
            order.ProductID = 45771;
            order.Date_Time = DateTime.Now.AddMinutes(54);
            order.SaveOrder(orders);

            Order order1 = new Order()
            {
                OrderID = 276144,
                ProductID = 122376,
                ProductName = "\"New Phone X13\"",
                Date_Time = DateTime.Now.AddMinutes(50)
            };

            Customer customerInfo = new Customer()
            {
                CustomerFirstName = "Artur",
                CustomerMidlleName = "Bartosz",
                CustomerSecondName = "Rudawski",
                CustomerAge = 20,
                CustomerEmail = "Bart.Rudawski@gml.com",
                CustomerPhoneNumber = "+38099754154",
                CustomerCity = "Mykachevo",
                CustomerAddress = "\'Random street go!\'"

            };

            Seller sellerInfo = new Seller()
            {
                SellerFirstName = "Asterix",
                SellerMidlleName = "Sofron",
                SellerSecondName = "Vasylysk",
                SellerAge = 35,
                SellerCompanyName = "Asterix's Electro - Shop"
            };

            Order.OrdersInfo(order.OrderID, order.ProductID, order.ProductName, order.Date_Time, order.CustomerName,
                order.CustomerEmail, order.CustomerPhone, order.CustomerAdress);

            Order.SecondOrdersInfo(order1.OrderID, order1.ProductID, order1.ProductName, order1.Date_Time);

            Customer.customerBio(customerInfo.CustomerFirstName, customerInfo.CustomerMidlleName, customerInfo.CustomerSecondName,
                customerInfo.CustomerAge, customerInfo.CustomerPhoneNumber, customerInfo.CustomerEmail, customerInfo.CustomerCity,
                customerInfo.CustomerAddress);

            Seller.sellerBio(sellerInfo.SellerFirstName, sellerInfo.SellerMidlleName, sellerInfo.SellerSecondName,
                sellerInfo.SellerAge, sellerInfo.SellerCompanyName);

            ProductsForSale.productForSale(productsForSale.ProductName);
        }
    }

    //Order Info
    public class Order : IOrder
    {

        public int OrderID { get; set; }
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public DateTime Date_Time { get; set; }
        public string CustomerName { get; set; }

        public string CustomerEmail { get; set; }
        public string CustomerPhone { get; set; }
        public string CustomerAdress { get; set; }

        public void SaveOrder(List<Order> userOrder)
        {
            if (OrderID > 0) userOrder.Add(this);
        }

        public static void OrdersInfo(int orderID, int productID, string productName, DateTime dateTime,
            string customerName, string customerEmail,
            string customerPhone, string customerAdress) => Console.WriteLine($"Hello {customerName}, your Id order is \"{orderID}\" and product Id is \"{productID}\": {productName} is on the way to you! " +
                $"\nPlease, check your Email {customerEmail} or call {customerPhone} to your post office on your adress: {customerAdress}.");

        public static void SecondOrdersInfo(int orderID, int productID, string productName, DateTime date_Time) => Console.WriteLine($"\nHello \'Unkown Person\', your Id order: {orderID}, Id product: {productID} and {productName} is on the way!");
    }

    //About Customer
    public class Customer : ICustomer
    {
        public string CustomerFirstName { get; set; }
        public string CustomerMidlleName { get; set; }
        public string CustomerSecondName { get; set; }
        public int CustomerAge { get; set; }
        public string CustomerPhoneNumber { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerCity { get; set; }
        public string CustomerAddress { get; set; }

        public static void customerBio(string customerFirstName, string customerMidlleName, string customerSecondName,
            int customerAge, string customerPhoneNumber, string customerEmail, string customerCity,
            string customerAddress) => Console.WriteLine($"\nAbout You.\n Your Full Name: {customerFirstName} {customerMidlleName} {customerSecondName}\n " +
                $"Your Age: {customerAge}\n Your Phone Number: {customerPhoneNumber}\n Your Email: {customerEmail} \n Your Place of Living: {customerCity}\n Your Adress {customerAddress}");
    }

    //About Seller
    public class Seller : ISeller
    {
        public string SellerFirstName { get; set; }
        public string SellerMidlleName { get; set; }
        public string SellerSecondName { get; set; }
        public int SellerAge { get; set; }
        public string SellerCompanyName { get; set; }

        public static void sellerBio(string SellerFirstName, string SellerMidlleName, string SellerSecondName,
            int SellerAge, string SellerCompanyName) => Console.WriteLine($"\nAbout Our Seller!\n Seller Name: {SellerFirstName} {SellerMidlleName} {SellerSecondName}" +
                $"\n Seller Age: {SellerAge}\n Company Name: {SellerCompanyName}");
    }

    public class ProductsForSale
    {
        public string ProductName { get; set; }
        public static void productForSale(string ProductName) => Console.WriteLine($"\nLook at our products: {ProductName}");
    }
}