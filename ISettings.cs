﻿namespace dotSwitcher
{
    public interface ISettings
    {
        KeyboardEventArgs SwitchHotkey { get; set; }
        KeyboardEventArgs ConvertSelectionHotkey { get; set; }
        int SwitchDelay { get; set; }
    }
}