namespace Enum1.Entities.Enums
{
    enum OrderStatus : int
    {
        PendingPayment = 0, // Se não colocar valor começa com 0 
        Processing = 1,
        Shipped = 2,
        Delivered = 3,
    }
}
