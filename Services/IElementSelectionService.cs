﻿using JetBrains.Annotations;
using OpenQA.Selenium;

namespace Behavioral.Automation.Services
{
    public interface IElementSelectionService
    {
        [CanBeNull]
        IWebElement Find([NotNull] string caption);
    }
}