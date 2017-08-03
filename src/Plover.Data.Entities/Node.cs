using System;
using System.Collections.Generic;

namespace Plover.Data.Entities
{
    /// <summary>
    /// 节点
    /// </summary>
    public class Node
    {
        public int Id { get; set; }

        /// <summary>
        /// 节点名称
        /// </summary>
        /// <value>The name.</value>
        public string Name { get; set; }




        /// <summary>
        /// 节点归属的板块
        /// </summary>
        public virtual Board Board { get; set; }

        /// <summary>
        /// 节点下的主题
        /// </summary>
        public virtual ICollection<Topic> Topics { get; set; }
    }
}
