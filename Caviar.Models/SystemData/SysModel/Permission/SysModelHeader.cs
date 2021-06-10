﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caviar.Models.SystemData
{
    [DisplayName("数据模块")]
    public class SysModelHeader:SysBaseModel
    {
        /// <summary>
        /// 类型名称，判断是否为同一属性的唯一条件
        /// 修改后需要重新设置，或者同步设置
        /// </summary>
        [DisplayName("类型名称")]
        public string TypeName { get; set; }
        /// <summary>
        /// 字段需要的宽度
        /// </summary>
        [DisplayName("表宽")]
        public string Width { get; set; }
        /// <summary>
        /// 字段需要的高度
        /// </summary>
        [DisplayName("表高")]
        public string Height { get; set; }
        /// <summary>
        /// 字段长度
        /// </summary>
        public int? ValueLen { get; set; }
    }
}
