using System;
namespace Plover.Data.Entities
{
    /// <summary>
    /// 通知
    /// </summary>
    public class Notification
    {
        public int Id { get; set; }

        /// <summary>
        /// 通知内容
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// 通知时间
        /// </summary>
        public DateTime NotifyTime { get; set; }

        /// <summary>
        /// 是否已读
        /// </summary>
        public bool Read { get; set; }


        /// <summary>
        /// 会员Id
        /// </summary>
        public int MemberId { get; set; }

        /// <summary>
        /// 会员
        /// </summary>
        public virtual Member Member { get; set; }
    }

    // @我（提及我的） 格式：xx 在主题 xx 中 @了你 ，xx在主题 xx的回复中 @了你

    // 赞了我的回复    格式：xx 赞了你的回复 xx （xx为主题）

    // 收藏我的主题    格式：xx 收藏了你的主题  xx

    // 回复我的主题    格式：xx 回复了你的主题 xx

    // 关注我         格式：xx 关注了你
}
