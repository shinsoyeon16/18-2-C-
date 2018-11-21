using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YICMS.BL
{
    class Order
    {
        public Customer CustomerInfo { get; set; }
        //public Address { get; set; }
        public Order(int orderId)
        {
            OrderId = orderId;
        }
    public int CustomerId { get; set; }
    public DateTimeOffset? OrderDate { get; set; }
    public int OrderId { get; private set; }
    public List<OrderItem> orderItems { get; set; }
    public int shippingAddressId { get; set; }

    public Order Retrieve(int orderId)
    {
        Order order = new Order(orderId);

        return order;
    }
}