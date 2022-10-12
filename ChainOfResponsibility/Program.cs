using ChainOfResponsibility.ChainOfResponsibility.Business;

class Program
{
    static void Main(string[] args)
    {
        ValidationHandler validationHandler = new HazzardValidationHandler();
        validationHandler
            .SetNext(new LossValidationHandler()
                .SetNext(new UcaValidationHandler()));


        var hazzard = new Hazzard()
        {
            Id = "HS-01",
        };
        var loss = new Loss()
        {
            Id = "LS-01",
        }; var uca = new Uca()
        {
            Id = "UC-01",
        };
        validationHandler.HandleRequest(hazzard);
        validationHandler.HandleRequest(loss);
        validationHandler.HandleRequest(uca);
    }
}
