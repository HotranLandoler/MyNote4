using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNote4.Model
{
    public class Note
    {
        /// <summary>
        /// 笔记标题
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// 笔记正文
        /// </summary>
        public string Content { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime UpdateTime { get; set; }
    }
}
