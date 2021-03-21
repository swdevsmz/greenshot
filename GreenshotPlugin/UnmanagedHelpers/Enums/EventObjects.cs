﻿/*
 * Greenshot - a free and open source screenshot tool
 * Copyright (C) 2007-2021 Thomas Braun, Jens Klingen, Robin Krom
 * 
 * For more information see: http://getgreenshot.org/
 * The Greenshot project is hosted on GitHub https://github.com/greenshot/greenshot
 * 
 * This program is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 1 of the License, or
 * (at your option) any later version.
 * 
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 * 
 * You should have received a copy of the GNU General Public License
 * along with this program.  If not, see <http://www.gnu.org/licenses/>.
 */

using System.Diagnostics.CodeAnalysis;

namespace GreenshotPlugin.UnmanagedHelpers.Enums
{
    /// <summary>
    /// Used for User32.SetWinEventHook
    /// See: http://msdn.microsoft.com/en-us/library/windows/desktop/dd373606%28v=vs.85%29.aspx#OBJID_WINDOW
    /// </summary>
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    public enum EventObjects
    {
        OBJID_ALERT = -10,
        OBJID_CARET = -8,
        OBJID_CLIENT = -4,
        OBJID_CURSOR = -9,
        OBJID_HSCROLL = -6,
        OBJID_MENU = -3,
        OBJID_SIZEGRIP = -7,
        OBJID_SOUND = -11,
        OBJID_SYSMENU = -1,
        OBJID_TITLEBAR = -2,
        OBJID_VSCROLL = -5,
        OBJID_WINDOW = 0
    }
}