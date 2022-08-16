namespace ChainOfResponsibility.ChainOfResponsibility.Interface
{
    public interface IValidationCommand
    {
        public void Validation(object obj);
        public bool CanValidation(object obj);
    }
}
