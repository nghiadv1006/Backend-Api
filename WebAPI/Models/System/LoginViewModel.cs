﻿using System.ComponentModel.DataAnnotations;

namespace WebAPI.Models.System
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Bạn cần nhập tài khoản")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Bạn cần nhập mật khẩu")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public bool RememberMe { get; set; }
    }
}