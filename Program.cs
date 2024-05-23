using System;
    namespace ExCases{
        class Program
{
    static void Main()
    {
        try
        {
            
            var invoice = new Invoice(new DateTime(2022, 1, 1));
        }
        catch (InvoiceDateException ex)
        {
            Console.WriteLine(ex.Message);
            
            var invoice = new Invoice(DateTime.Today);
        }
        catch (Exception ex)
        {
            
            Console.WriteLine($"Произошла ошибка: {ex.Message}");
        }
        finally
        {
            
            Console.WriteLine($"Дата выставления счёта: {DateTime.Today.ToShortDateString()}");
        }
            Console.ReadKey();
    }
        
}
}