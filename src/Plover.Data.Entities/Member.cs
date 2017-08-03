using System;
namespace Plover.Data.Entities
{
    /// <summary>
    /// 会员
    /// </summary>
    public class Member
    {
        public int Id { get; set; }

        /// <summary>
        /// 用户名
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// Email
        /// </summary>
        public string Email { get; set; }


        /// <summary>
        /// 加入时间
        /// </summary>
        public DateTime JoinTime { get; set; }

        /// <summary>
        /// 头像
        /// </summary>
        public string Avatar { get; set; }

        /// <summary>
        /// 个人网站
        /// </summary>
        public string Website { get; set; }


        /// <summary>
        /// 公司
        /// </summary>
        public string Company { get; set; }

        /// <summary>
        /// 职位
        /// </summary>
        public string Position { get; set; }

        /// <summary>
        /// 所在地
        /// </summary>
        public string Location { get; set; }

        /// <summary>
        /// 个性签名
        /// </summary>
        public string Signature { get; set; }

        /// <summary>
        /// GitHub
        /// </summary>
        public string GitHub { get; set; }

        /// <summary>
        /// Reddit
        /// </summary>
        public string Reddit { get; set; }

        /// <summary>
        /// Twitter
        /// </summary>
        public string Twitter { get; set; }

        /// <summary>
        /// Coding.net
        /// </summary>
        /// <value>The coding net.</value>
        public string CodingNet { get; set; }

        /// <summary>
        /// 码云
        /// </summary>
        public string Gitee { get; set; }
    }
}
