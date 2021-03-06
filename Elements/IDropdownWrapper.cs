﻿using System.Collections.Generic;
using JetBrains.Annotations;

namespace Behavioral.Automation.Elements
{
    public interface IDropdownWrapper : IWebElementWrapper
    {
        void Select(params string[] elements);

        string SelectedValue { [CanBeNull] get; }

        IEnumerable<string> Items { [NotNull, ItemNotNull] get; }

        IEnumerable<string> GroupTexts { [NotNull, ItemNotNull] get; }

        bool Empty { get; }

        bool Autocomplete { get; }
    }
}