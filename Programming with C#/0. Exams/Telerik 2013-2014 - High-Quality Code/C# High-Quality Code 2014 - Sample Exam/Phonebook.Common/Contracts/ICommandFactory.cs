﻿namespace Phonebook.Common.Contracts
{
    using System;
    using System.Linq;

    public interface ICommandFactory
    {
        ICommand Parse(string command);
    }
}