using System;
using System.Collections.Generic;

namespace Plover.Data.Entities
{
    /// <summary>
    /// 主题
    /// </summary>
    public class Topic
    {


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
