using ChainOfResponsibility.ChainOfResponsibility.Interface;

namespace ChainOfResponsibility.ChainOfResponsibility.Business
{
    public abstract class ValidationHandler : IValidationCommand
    {
        private ValidationHandler? _handle;

        public ValidationHandler()
        {
        }
        public ValidationHandler SetNext(ValidationHandler handle)
        {
            this._handle = handle;
            return this;
        }

        public void HandleRequest(object obj)
        {
            if (CanValidation(obj))
            {
                Validation(obj);
            }
            else if (_handle != null)
            {
                _handle.HandleRequest(obj);
            }
        }

        public abstract void Validation(object obj);

        public abstract bool CanValidation(object obj);
    }
}
