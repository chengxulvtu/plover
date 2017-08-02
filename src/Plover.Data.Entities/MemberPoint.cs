using System;
namespace Plover.Data.Entities
{
    /// <summary>
    /// 会员积分（记录）
    /// </summary>
    public class MemberPoint
    {
        public string Id { get; set; }

        /// <summary>
        /// 会员Id
        /// </summary>
        public int MemberId { get; set; }

        /// <summary>
        /// 会员
        /// </summary>
        public virtual Member Member { get; set; }

        /// <summary>
        /// 积分（本次得分）
        /// </summary>
        public int Point { get; set; }

        /// <summary>
        /// 备注（为什么得积分，比如注册送20积分，发表主题得2积分等）
        /// </summary>
        public string Memo { get; set; }
    }
}
