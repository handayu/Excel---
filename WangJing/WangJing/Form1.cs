using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WangJing
{
    public partial class Form1 : Form
    {
        private string m_rootPath = string.Empty;  //根目录

        private Dictionary<string,List<DayGlobleData>> m_txtDataDic = new Dictionary<string,List<DayGlobleData>>(); //每一个txt存一个List缓存


        public Form1()
        {
            InitializeComponent();
        }

        private string GetRootPath()
        {
            return m_rootPath = @"C:\Users\hanyu\Desktop\WangJing\WangJing\WorkSpace";
        }


        /// <summary>
        /// 读取目录下文件数量
        /// </summary>
        private int ReadDictionlaryFileNum()
        {
            return 5;
        }

        /// <summary>
        /// 读取文件目录下TxT文档数量
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private int ReadDictionlaryTxTFileNum()
        {
            return 4;
        }

        /// <summary>
        /// 读取文件目录下Excel文档数量
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private int ReadDictionlaryExcelFileNum()
        {
            return 1;
        }

        /// <summary>
        /// 返回所有txt的List数据缓存
        /// </summary>
        /// <returns></returns>
        private  Dictionary<string,List<DayGlobleData>> GetTxtDayGlobleDataToDIc()
        {
            if(ReadDictionlaryTxTFileNum() == 0)
            {
                throw new Exception("对应文件夹下不存在等待处理的TxT文件");
            }
            if(ReadDictionlaryExcelFileNum() == 0)
            {
                throw new Exception("对应文件夹下不存在等待处理的Excel文件");
            }

            //找到根目录下文件数遍历打开存取
            //foreach(File in )
            //{
                 //m_txtDataDic.add()所有
            //}

            return m_txtDataDic;
        }

        /// <summary>
        /// 返回所有Excel的List数据缓存
        /// </summary>
        /// <returns></returns>
        private Dictionary<string, List<DayGlobleData>> GetTxtDayGlobleDataToDIc()
        {
            Dictionary<string, List<DayGlobleData>> dayGlobleDataDic = new Dictionary<string, List<DayGlobleData>>();

            if (ReadDictionlaryTxTFileNum() == 0)
            {
                throw new Exception("对应文件夹下不存在等待处理的TxT文件");
            }
            if (ReadDictionlaryExcelFileNum() == 0)
            {
                throw new Exception("对应文件夹下不存在等待处理的Excel文件");
            }

            //找到根目录下文件数遍历打开存取
            //foreach(File in )
            //{
                  //m_txtDataDic.add() 处理样本量
            //}

            return m_txtDataDic;
        }



        private void button_Save_Click(object sender, EventArgs e)
        {

        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {

        }

        private void HelpStrip_Click(object sender, EventArgs e)
        {

        }

        private void Form_Load(object sender, EventArgs e)
        {
        
        }
    }
}
