﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Gov.Entity
{
    /// <summary>
    /// 审批流配置表
    /// </summary>
    public class ApproveFlowRelation
    {
        public Guid TargetId { get; set; }
        public Guid FlowId { get; set; }
        public ApproveFlow Flow { get; set; }
    }
}
