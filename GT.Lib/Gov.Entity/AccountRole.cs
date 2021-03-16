using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
namespace Gov.Entity
{
    /// <summary>
    /// 用户角色表
    /// </summary>
    public class AccountRole
    {
        [ForeignKey("AccountId")]
        public Account Account { get; set; }
        [ForeignKey("RoleId")]
        public Role Role { get; set; }
        public Guid AccountId { get; set; }
        public Guid RoleId { get; set; }
        public DateTimeOffset CreatedTime { get; set; }
    }
}
