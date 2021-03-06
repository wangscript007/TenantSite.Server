﻿using AlonsoAdmin.Entities.System;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlonsoAdmin.Services.System.Response
{
    /// <summary>
    /// ForList 实体对象（一般用于列表页展示数据用）
    /// </summary>
    public class OperationLogForListResponse
    {
        /// <summary>
        /// 编号
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// 昵称
        /// </summary>
        public string RealName { get; set; }

        /// <summary>
        /// 接口标题
        /// </summary>
        public string ApiTitle { get; set; }

        /// <summary>
        /// 接口地址
        /// </summary>
        public string ApiPath { get; set; }

        /// <summary>
        /// 接口提交方法
        /// </summary>
        public string ApiMethod { get; set; }

        /// <summary>
        /// IP
        /// </summary>
        public string IP { get; set; }

        /// <summary>
        /// 浏览器
        /// </summary>
        public string Browser { get; set; }

        /// <summary>
        /// 操作系统
        /// </summary>
        public string Os { get; set; }

        /// <summary>
        /// 设备
        /// </summary>
        public string Device { get; set; }

        /// <summary>
        /// 耗时（毫秒）
        /// </summary>
        public long ElapsedMilliseconds { get; set; }

        /// <summary>
        /// 操作状态
        /// </summary>
        public bool Status { get; set; }

        /// <summary>
        /// 操作消息
        /// </summary>
        public string Message { get; set; }


        /// <summary>
        /// 创建者
        /// </summary>
        public string CreatedBy { get; set; }

        /// <summary>
        /// 创建者用户名
        /// </summary>
        public string CreatedByName { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime? CreatedTime { get; set; }
    }
    /// <summary>
    /// ForIem 实体对象（一般用于明细页展示数据用）
    /// </summary>
    public class OperationLogForItemResponse : SysOperationLogEntity
    {

    }
}
