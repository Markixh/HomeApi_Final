using FluentValidation;
using HomeApi.Contracts.Models.Rooms;

namespace HomeApi.Contracts.Validation
{
    /// <summary>
    /// Класс-валидатор запросов обновления комнаты
    /// </summary>
    public class EditRoomRequestValidator : AbstractValidator<EditRoomRequest>
    {
        /// <summary>
        /// Метод, конструктор, устанавливающий правила
        /// </summary>
        public EditRoomRequestValidator()
        {
            RuleFor(x => x.NewName).NotEmpty();
            RuleFor(x => x.NewArea).NotEmpty().InclusiveBetween(1, 2000)
                .WithMessage($"The area must be between 1 and 2000");
            RuleFor(x => x.NewVoltage).NotEmpty().InclusiveBetween(120, 220)
                .WithMessage($"Voltage must be between 120 and 220");
            RuleFor(x => x.NewGasConnected).NotEmpty();
        }
    }
}
