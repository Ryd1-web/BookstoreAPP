using BookstoreAPP.Models;
using BookstoreAPP.Repository;
using System;
using System.Collections.Generic;
using System.Linq;

public class OrderRepository : IOrderRepository
{
	private List<Order> _orders;
	private int _nextOrderId = 1;

	public OrderRepository()
	{
		_orders = new List<Order>();
	}

	public Order PlaceOrder(Order order)
	{
		order.Id = _nextOrderId++;
		_orders.Add(order);
		return order;
	}

	public Order GetOrderById(int orderId)
	{
		return _orders.FirstOrDefault(order => order.Id == orderId);
	}
}
