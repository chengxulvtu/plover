using System;
using System.Collections.Generic;

namespace Plover.Data.Entities
{
    /// <summary>
    /// 主题
    /// </summary>
    public class Topic
    {
        public int Id { get; set; }

        /// <summary>
        /// 主题标题
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 主题内容
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// 浏览数
        /// </summary>
        public int ViewCount { get; set; }

        /// <summary>
        /// 发表时间
        /// </summary>
        public DateTime PubTime { get; set; }

        /// <summary>
        /// 最后编辑时间
        /// </summary>
        /// <value>The last edit time.</value>
        public DateTime LastEditTime { get; set; }

        /// <summary>
        /// 会员Id
        /// </summary>
        public int MemberId { get; set; }

        /// <summary>
        /// 会员
        /// </summary>
        public Member Member { get; set; }

        /// <summary>
        /// 节点Id
        /// </summary>
        public int NodeId { get; set; }

        /// <summary>
        /// 主题归属的节点
        /// </summary>
        public virtual Node Node { get; set; }

        /// <summary>
        /// 主题回复
        /// </summary>
        public virtual ICollection<Reply> Replies { get; set; }


        /// <summary>
        /// 标签
        /// </summary>
        public virtual ICollection<Tag> Tags { get; set; }
    }
}
