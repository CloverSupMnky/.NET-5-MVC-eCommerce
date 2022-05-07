﻿using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    /// <summary>
    /// 演員
    /// </summary>
    public class Actor
    {
        /// <summary>
        /// 編號
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// 大頭貼路徑
        /// </summary>
        public string ProfilePictureURL { get; set; }

        /// <summary>
        /// 名字
        /// </summary>
        public string FullName { get; set; }

        /// <summary>
        /// 傳記
        /// </summary>
        public string Bio { get; set; }
    }
}
