class Program
{
    static void Main(String[] args)
    {
        PemrosesData data = new PemrosesData();
        Console.WriteLine(data.DapatkanNilaiTerbesar<double>(1.0, 3.0, 2.2));
    }
}

class PemrosesData 
{
    public T DapatkanNilaiTerbesar<T>(T input1, T input2, T input3)
    {
        dynamic d1= input1;
        dynamic d2= input2;
        dynamic d3= input3;
        dynamic hasil;

       if (d1 > d2 && d1 > d3)
        {
            hasil = d1;
        }
        else if (d2 > d1 && d2 > d3)
        {
            hasil = d2;
        }
        else
        {
            hasil = d3;
        }
        return hasil;
    }
}