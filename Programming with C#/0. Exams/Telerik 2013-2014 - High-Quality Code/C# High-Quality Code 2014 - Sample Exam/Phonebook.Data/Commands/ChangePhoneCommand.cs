﻿namespace Phonebook.Data.Commands
{
    using System;
    using Phonebook.Common;
    using Phonebook.Data.Contracts;

    public class ChangePhoneCommand : BaseCommand
    {
        private const string PhoneEntriesChangedMessage = "{0} numbers changed";

        public ChangePhoneCommand(IPhonebookRepository phonebookRepository)
            : base(phonebookRepository)
        {
        }

        public override string Execute(string[] arguments)
        {
            if (arguments == null || arguments.Length != 2)
            {
                throw new ArgumentException("Invalid input arguments collection.");
            }

            var oldPhoneNumber = arguments[0].ConvertPhoneToCannonicalForm();
            var newPhoneNumber = arguments[1].ConvertPhoneToCannonicalForm();

            var numberOfChangedPhones = this.PhonebookRepository.ChangePhone(oldPhoneNumber, newPhoneNumber);
            return string.Format(PhoneEntriesChangedMessage, numberOfChangedPhones);
        }
    }
}