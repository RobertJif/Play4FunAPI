using FluentValidation;

namespace Play4Fun.Models.Requests
{
    public class LoginRequest
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }

    public class LoginRequestValidator : AbstractValidator<LoginRequest>
    {
        public LoginRequestValidator()
        {
            RuleFor(x => x.Username).NotNull().MaximumLength(16).MinimumLength(8);
            RuleFor(x => x.Password).NotNull().MaximumLength(16).MinimumLength(8);
        }
    }
}
