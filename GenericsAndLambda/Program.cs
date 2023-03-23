using GenericsAndLambda;

// Generics
MyClass<int> myClass = new MyClass<int>();
int a = myClass.Data;

MyClass<string> myClass2 = new MyClass<string>();
string b = myClass2.Data;

// Lambda functions
int[] myPrices = {100, 200, 300, 100};

void Modify(int[] prices, Operation fn)
{
    for (int i = 0; i < prices.Length; i++)
    {
        prices[i] = fn(prices[i]);
    }
}

int AddTwo(int price)
{
    return price + 2;
}

Console.WriteLine(string.Join(", ", myPrices));

// +2kč
// Modify(myPrices, AddTwo);
Modify(myPrices, price => price + 2);
Console.WriteLine(string.Join(", ", myPrices));

// -DPH
Modify(myPrices, price => (int)(price / 1.21));
Console.WriteLine(string.Join(", ", myPrices));

delegate int Operation(int price);