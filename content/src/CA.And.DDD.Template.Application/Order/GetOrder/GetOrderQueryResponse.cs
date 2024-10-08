﻿using CA.And.DDD.Template.Application.Order;

namespace CA.And.DDD.Template.Application.Customer.GetCustomer
{
    public sealed record GetOrderQueryResponse(Guid OrderId, List<OrderItemDto> orderItems);

}
