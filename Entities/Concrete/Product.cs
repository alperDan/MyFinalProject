using System;
using Entities.Abstract;

namespace Entities.Concrete
{
	public class Product:IEntity
	{
		public int ProductId { get; set; }
		public int CatagoryId { get; set; }
		public string ProductName { get; set; }
		public short UnitsInStock { get; set; }
		public decimal UnitPrice { get; set; }

	}
}

