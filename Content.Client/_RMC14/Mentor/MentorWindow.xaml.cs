﻿using Robust.Client.AutoGenerated;
using Robust.Client.UserInterface.Controls;
using Robust.Client.UserInterface.CustomControls;
using Robust.Client.UserInterface.XAML;
using Robust.Shared.Network;

namespace Content.Client._RMC14.Mentor;

[GenerateTypedNameReferences]
public sealed partial class MentorWindow : DefaultWindow
{
    public NetUserId SelectedPlayer { get; set; }
    public readonly Dictionary<NetUserId, Button> PlayerDict = new();

    public MentorWindow()
    {
        RobustXamlLoader.Load(this);
    }
}