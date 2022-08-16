namespace ChainOfResponsibility.ChainOfResponsibility.Business
{
    public class Loss
    {
        public string Id { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
    }
    public class LossValidationHandler : ValidationHandler
    {
        public LossValidationHandler()
        {
        }

        public override bool CanValidation(object obj)
        {
            return obj is Loss { } uca && uca.Id.StartsWith("LS");
        }

        public override void Validation(object obj)
        {
            if (obj is Loss loss)
            {
                loss.Content = "손실";
                Console.WriteLine(loss.Content);
            }

        }
    }
}
