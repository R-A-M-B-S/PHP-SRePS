using System;
namespace SalesApp
{
    public class Asset
    {
		public readonly int id;
		public string name, description;
		public double price;

        public Asset(int id, string name, string description, double price)
        {
			this.id = id;
			this.name = name;
			this.description = description;
			this.price = price;
        }
    }

	public class NullAsset : Asset
	{
		public NullAsset() : base(-1, "Unknown", "Item does not exist", 0) 
		{
		}
	}
}
