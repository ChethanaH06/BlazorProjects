﻿using BaseLibrary.DTOs;

namespace ClientBlazorWebAssembly.ApplicationStates
{
    public class UserProfileState
    {
        public Action? Action { get; set; }
        public UserProfile userProfile { get; set; } = new();
        public void ProfileUpdated()=>Action!.Invoke();
    }
}
