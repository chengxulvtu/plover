using System;
using System.Collections.Generic;

namespace Plover.Data.Entities
{
    /// <summary>
    /// 板块
    /// </summary>
    public class Board
    {
        public int Id { get; set; }

        /// <summary>
        /// 版块名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 板块下的节点
        /// </summary>
        public virtual ICollection<Node> Nodes { get; set; }
    }
}
