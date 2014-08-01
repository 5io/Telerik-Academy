﻿namespace Phonebook.Data.Commands
{
    using System;
    using Phonebook.Data.Contracts;

    public abstract class BaseCommand : ICommand
    {
        private IPhonebookRepository phonebookRepository;

        public BaseCommand(IPhonebookRepository phonebookRepository)
        {
            this.PhonebookRepository = phonebookRepository;
        }
 
        public IPhonebookRepository PhonebookRepository
        {
            get 
            { 
                return this.phonebookRepository; 
            }

            protected set
            {
                if (value == null)
                {
                    throw new NullReferenceException("Phonebook repository instance cannot be null.");
                }

                this.phonebookRepository = value;
            }
        }

        public abstract string Execute(string[] arguments);
    }
}