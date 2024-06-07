using System;

    namespace ExCases{ 
public class Invoice 
{
    public DateTime IssueDate { get; private set; } 

    public Invoice(DateTime issueDate) 
    {

            if(issueDate == null)
            {
                throw new ArgumentNullException( "Дата выставления счёта не может быть null :( ");
            }
        
        if(issueDate.Date < DateTime.Today)
        {
            throw new InvoiceDateException("Дата выставления счёта уже прошла!");
        }
        else
        {
            IssueDate = issueDate;
        }
    }
}
}
