using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookManagementSystem.Web.Models.Layout
{
    /// <summary>
    /// 定义EasyUI树的相关数据，方便控制器生成Json数据进行传递
    /// </summary>
    //[Serializable]
    public class EasyTreeModel
    {
        /// <summary>
        /// ID
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// 节点名称
        /// </summary>
        public string text { get; set; }

        /// <summary>
        /// 是否展开
        /// </summary>
        public string state { get; set; }

        /// <summary>
        /// 图标样式
        /// </summary>
        public string iconCls { get; set; }


        /// <summary>
        /// 子节点集合
        /// </summary>
        public List<EasyTreeModel> children { get; set; }

        /// <summary>
        /// 默认构造函数
        /// </summary>
        public EasyTreeModel()
        {
            children = new List<EasyTreeModel>();
            state = "open";
        }

        /// <summary>
        /// 常用构造函数
        /// </summary>
        public EasyTreeModel(string id, string text, string iconCls = "", string state = "open")
                : this()
            {
            this.id = id;
            this.text = text;
            this.state = state;
            this.iconCls = iconCls;
        }

        /// <summary>
        /// 常用构造函数
        /// </summary>
        public EasyTreeModel(int id, string text, string iconCls = "", string state = "open")
                : this()
            {
            this.id = id.ToString();
            this.text = text;
            this.state = state;
            this.iconCls = iconCls;
        }

    }
}