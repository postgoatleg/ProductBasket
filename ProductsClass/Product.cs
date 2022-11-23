using ExceptionHandling;

namespace ProductsClass
{
public class Product
{
    string name;
    double price=0;

    public Product(string name, double price)
    {
            try
            {
                if (name != null)
                    this.name = name;
                else
                    throw new ProductVoidName();
            }
            catch(ProductVoidName)
            {
                this.name = "";
            }
        
            try
            {
                if(price > 0)
                    this.price = price;
                else
                    throw new ProductVoidPrice();
            }
            catch(ProductVoidPrice)
            {
                this.price = 0;
            }
    }

    public static Product operator +(Product p1, Product p2)
    {
        return new Product(p1.name, p1.price + p2.price);
    }

    public static Product operator -(Product p1, Product p2)
    {

            if (p1.name == p2.name)
                return new Product(p1.name, p1.price - p2.price);
            else
                throw new DifferentProductMinus();


    }

    public static Product operator *(Product p1, double n)
    {
            if(n < 0)
                throw new ProductMulpNegative();
            return new Product(p1.name, p1.price * n);
    }

    public static Product operator /(Product p1, double n)
    {
            if (n < 0)
                throw new ProductDivNegative();
            return new Product(p1.name, p1.price / n);
    }

    public static Product operator ++(Product p1)
    {
        return new Product(p1.name, p1.price + p1.price);
    }

        public static bool operator <(Product p1, Product p2)
        {
            if (p1.price < p2.price)
                return true;
            else
                return false;
        }

        public static bool operator >(Product p1, Product p2)
        {
            if (p1.price > p2.price)
                return true;
            else
                return false;
        }

        public static bool operator <=(Product p1, Product p2)
        {
            if (p1.price <= p2.price)
                return true;
            else
                return false;
        }

        public static bool operator >=(Product p1, Product p2)
        {
            if (p1.price >= p2.price)
                return true;
            else
                return false;
        }

        public static bool operator ==(Product p1, Product p2)
        {
            if (p1.price == p2.price && p1.name == p2.name)
                return true;
            else
                return false;
        }

        public static bool operator !=(Product p1, Product p2)
        {
            if (p1.price != p2.price || p1.name != p2.name)
                return true;
            else
                return false;
        }

        public static double GetSum(params Product[] basket)
        {
            double sum=0;
            for(int i = 0; i<basket.Length; i++)
            {
                sum += basket[i].price;
            }
            return sum;
        }

    public string GetName()
    {
        return this.name;
    }

    public double GetPrice()
    {
        return this.price;
    }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(this, obj) || ReferenceEquals(this, null) || ReferenceEquals(this, ))
            {
                return true;
            }
            else return false;

            throw new NotImplementedException();
        }

        public override int GetHashCode()
        {
            return (int)this.price;
        }
    }
}
