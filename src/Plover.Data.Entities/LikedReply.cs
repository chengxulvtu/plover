using System;
namespace Plover.Data.Entities
{
    /// <summary>
    /// 点赞的回复
    /// </summary>
    public class LikedReply
    {
        /// <summary>
        /// 点赞时间
        /// </summary>
        public DateTime LikeTime { get; set; }

        /// <summary>
        /// 会员Id
        /// </summary>
        public int MemberId { get; set; }

        /// <summary>
        /// 会员
        /// </summary>
        public virtual Member Member { get; set; }


        public int ReplyId { get; set; }


        public virtual Reply Reply { get; set; }
    }
}
