﻿namespace FoodManager.Models
{
    public class ChangePassword
    {
        public ChangePassword()
        {
            UserName = "";
            OldPassword = "";
            NewPassword = "";
        }

        public string UserName { get; set; }
        public string OldPassword { get; set; }
        public string NewPassword { get; set; }
    }
}