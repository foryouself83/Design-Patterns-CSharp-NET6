namespace ChainOfResponsibility.ChainOfResponsibility.Business
{
    public class Hazzard
    {
        public string Id { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
    }
    public class HazzardValidationHandler : ValidationHandler
    {
        public HazzardValidationHandler()
        {
        }

        public override bool CanValidation(object obj)
        {
            return obj is Hazzard { } uca && uca.Id.StartsWith("HS");
        }

        public override void Validation(object obj)
        {
            if (obj is Hazzard hazzard)
            {
                hazzard.Content = "위험원";
                Console.WriteLine(hazzard.Content);
            }
        }
    }
}
