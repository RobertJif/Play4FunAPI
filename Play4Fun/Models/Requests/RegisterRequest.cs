using FluentValidation;
using Play4Fun.Utils;

namespace Play4Fun.Models.Requests
{
    public class RegisterRequest
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }

    public class RegisterRequestValidator : AbstractValidator<RegisterRequest>
    {
        public RegisterRequestValidator()
        {
            var rules = new ValidationRules();

            RuleFor(x => x.Username).NotNull().MaximumLength(20).MinimumLength(8).Matches(rules.REGEX_CONTAIN_LETTER_AND_NUMBER);
            RuleFor(x => x.Password).NotNull().MaximumLength(16).MinimumLength(8).Matches(rules.REGEX_CONTAIN_LETTER_AND_NUMBER);
        }
    }
}
