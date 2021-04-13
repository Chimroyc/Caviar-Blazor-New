﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Caviar.Models.SystemData
{
    /// <summary>
    /// 权限菜单关联表
    /// </summary>
    public class SysPermissionMenu:SysBaseModel
    {
        [JsonIgnore]
        public virtual SysPermission Permission { get; set; }
        [JsonIgnore]
        public virtual SysPowerMenu PowerMenu { get; set; }

        public int PowerMenuId { get; set; }

        public int PermissionId { get; set; }
    }
}
