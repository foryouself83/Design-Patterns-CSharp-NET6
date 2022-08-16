namespace ChainOfResponsibility.ChainOfResponsibility.Business
{
    public class Uca
    {
        public string Id { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
    }
    public class UcaValidationHandler : ValidationHandler
    {
        public UcaValidationHandler()
        {
        }

        public override bool CanValidation(object obj)
        {
            return obj is Uca { } uca && uca.Id.StartsWith("UC");
        }

        public override void Validation(object obj)
        {
            if (obj is Uca hazzard)
            {
                hazzard.Content = "UCA";
                Console.WriteLine(hazzard.Content);
            }
        }
    }
}
