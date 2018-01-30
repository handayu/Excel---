using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WangJing
{
    public class DayGlobleData
    {
        /// <summary>
        /// 主题
        /// </summary>
        public string Title
        {
            get;
            set;
        }

        /// <summary>
        /// 日期暂不用
        /// </summary>
        public DateTime DateNotUse
        {
            get;
            set;
        }
        /// <summary>
        /// 时间暂不用
        /// </summary>
        public DateTime TimeNotUse
        {
            get;
            set;
        }
        /// <summary>
        /// 日期筛选用
        /// </summary>
        public DateTime DateUse
        {
            get;
            set;
        }
        /// <summary>
        /// 时间临时
        /// </summary>
        public DateTime TimeUse
        {
            get;
            set;
        }
        /// <summary>
        /// 是否是白金用户
        /// </summary>
        public string IsWhiteGold
        {
            get;

            set;
        }
        /// <summary>
        /// 回访原因
        /// </summary>
        public string RollBackWhy
        {
            get;
            set;
        }
        /// <summary>
        /// 客户数量
        /// </summary>
        public int Num
        {
            get;
            set;
        }

    }
}
