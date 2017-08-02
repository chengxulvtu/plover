using System;
namespace Plover.Data.Entities
{
    /// <summary>
    /// 会员收藏的主题
    /// </summary>
    public class CollectedTopic
    {
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
    }
}
