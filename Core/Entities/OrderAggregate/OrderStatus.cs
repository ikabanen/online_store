using System.Runtime.Serialization;

namespace Core.Entities.OrderAggregate
{
    public enum OrderStatus
    {
        [EnumMember(Value = "Pending")]
        Pending,
        [EnumMember(Value = "Payment Received")]

        //PaymentReceived misspelled in tutorial
        PaymentReceived,
        [EnumMember(Value = "Payment Failed")]
        PaymentFailed
        // Shipped,
        // Delivered
    }
}