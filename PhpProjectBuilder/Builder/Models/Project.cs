using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.Models
{
    /// <summary>
    /// 项目属性
    /// </summary>
    public class Project
    {
        /// <summary>
        /// 项目根目录
        /// </summary>
        public string RootPath { get; set; }
        /// <summary>
        /// 控制器路径
        /// </summary>
        public string ControllerPath { get; set; }
        /// <summary>
        /// 页面路径
        /// </summary>
        public string ViewPath { get; set; }
        public string JsPath { get; set; }
        /// <summary>
        /// 控制器命名
        /// </summary>
        public string ControllerNameStyle { get; set; }
        /// <summary>
        /// 页面模板命名
        /// </summary>
        public string ViewNameStyle { get; set; }
        public string JsNameStyle { get; set; }
    }
}
