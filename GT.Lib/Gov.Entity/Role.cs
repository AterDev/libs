﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Gov.Entity
{
    /// <summary>
    /// 角色表
    /// </summary>
    public class Role : EntityBase
    {
        /// <summary>
        /// 角色名称
        /// </summary>
        [MaxLength(50)]
        public string Name { get; set; }
        /// <summary>
        /// 图标
        /// </summary>
        [MaxLength(30)]
        public string Icon { get; set; }


    }
}