﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Fulu.Passport.Domain.Models
{
    public class LoginBySmsInputDto
    {
        /// <summary>
        ///短信验证码
        /// </summary>
        [Required]
        public string Code { get; set; }
        [RegularExpression(RegexConstance.IsPhone, ErrorMessage = "手机号码格式不正确")]
        public string Phone { get; set; }
    }
}
