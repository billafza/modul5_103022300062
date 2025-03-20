<<<<<<< HEAD
﻿class Program
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
=======
﻿using System.Xml.Serialization;

class Program
{
    static void Main(String[] args)
    {
        SimpleDataBase<int> data = new SimpleDataBase<int>();
        data.AddNewData(10);
        data.AddNewData(30);
        data.AddNewData(22);
        data.PrintAllData();
    }
}

class SimpleDataBase<T>
{
    private List<T> storedData;
    private List<DateTime> inputDates;

    public SimpleDataBase()
    {
        this.storedData = new List<T>();
        this.inputDates = new List<DateTime>();
    }

    public void AddNewData(T data)
    {
        this.storedData.Add(data);
        this.inputDates.Add(DateTime.Now);
    }

    public void PrintAllData()
    {
        for (int i = 0; i < this.storedData.Count; i++)
        {
            Console.WriteLine("Data " + (i+1) + " berisi: " + storedData[i] + 
                ", yang disimpan pada waktu UTC: " + inputDates[i]);
        }
       
>>>>>>> implementasi-generic-class
    }
}