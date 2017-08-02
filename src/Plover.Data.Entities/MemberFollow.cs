using System;
namespace Plover.Data.Entities
{
    /// <summary>
    /// 会员关注（或被关注）
    /// 比如A关注B，A是B的Follower（粉丝），B是A的Followee（关注的人）
    /// </summary>
    public class MemberFollow
    {
        /// <summary>
        /// 关注者Id
        /// </summary>
        public int FollowerId { get; set; }

        /// <summary>
        /// 关注者
        /// </summary>
        public virtual Member Follower { get; set; }

        /// <summary>
        /// 被关注者Id
        /// </summary>
        public int FolloweeId { get; set; }

        /// <summary>
        /// 被关注者
        /// </summary>
        public virtual Member Followee { get; set; }
    }
}
