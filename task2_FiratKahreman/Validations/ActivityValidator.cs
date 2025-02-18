﻿using FluentValidation;
using task2_FiratKahreman.Models;

namespace task2_FiratKahreman.Validations
{
    public class ActivityValidator : AbstractValidator<Activity>
    {
        public ActivityValidator()
        {
            RuleFor(a => a.ActivityName).NotEmpty().WithMessage("Lütfen etkinlik ismini giriniz");
            RuleFor(a => a.Description).NotEmpty().WithMessage("Lütfen etkinlik açıklamasını giriniz");
            RuleFor(a => a.ActivityDate).NotEmpty().WithMessage("Lütfen etkinlik tarihini giriniz");
            RuleFor(a => a.Adress).NotEmpty().WithMessage("Lütfen etkinlik adresini giriniz");
            RuleFor(a => a.Limit).NotEmpty().WithMessage("Lütfen etkinlik kontenjanını giriniz");
            RuleFor(a => a.TicketPrice).NotEmpty().WithMessage("Biletli etkinliklerde bilet fiyatı boş bırakılamaz!").When(a => a.NeedTicket == true);
        }
    }
}
