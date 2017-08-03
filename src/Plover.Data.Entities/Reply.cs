using System;
using System.Collections.Generic;

namespace Plover.Data.Entities
{
    /// <summary>
    /// 主题回复(评论）
    /// </summary>
    public class Reply
    {
        public int Id { get; set; }

        /// <summary>
        /// 回复（评论）内容
        /// </summary>
        public string Content { get; set; }


        /// <summary>
        /// 回复时间
        /// </summary>
        public DateTime ReplyTime { get; set; }

        /// <summary>
        /// 点赞数
        /// </summary>
        public int LikeCount { get; set; }


        /// <summary>
        /// 会员Id
        /// </summary>
        public int MemberId { get; set; }

        /// <summary>
        /// 会员
        /// </summary>
        public virtual Member Member { get; set; }


        /// <summary>
        /// 主题Id
        /// </summary>
        public int TopicId { get; set; }

        /// <summary>
        /// 主题
        /// </summary>
        public virtual Topic Topic { get; set; }

        /// <summary>
        /// 回复的点赞
        /// </summary>
        public virtual ICollection<LikedReply> LikedReplies { get; set; }
    }
}
