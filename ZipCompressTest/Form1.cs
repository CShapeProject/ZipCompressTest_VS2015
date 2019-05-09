using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZipCompressTest.Model;

namespace ZipCompressTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 压缩事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnZipFlo_Click(object sender, EventArgs e)
        {
            string[] strs = new string[2];
            //待压缩文件目录
            strs[0] = "D:\\DeBug1\\";
            //压缩后的目标文件
            strs[1] = "D:\\Debug2\\FrpTest.zip";
            ZipFloClass zc = new ZipFloClass();
            zc.ZipFile(strs[0], strs[1]);
        }

        /// <summary>
        /// 解压事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUnZipFlo_Click(object sender, EventArgs e)
        {
            string[] strs = new string[2];
            string msg = "";
            //待解压的文件
            strs[0] = "D:\\Debug2\\FrpTest.zip";
            //解压后放置的目标文件
            strs[1] = "D:\\Debug3";
            UnZipFloClass uzc = new UnZipFloClass();
            uzc.unZipFile(strs[0], strs[1], ref msg);
            MessageBox.Show("信息：" + msg);
        }

        /// <summary>
        /// 批量压缩事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBatchZipFlo_Click(object sender, EventArgs e)
        {
            string path1 = "D:\\DeBug1\\";   //待压缩的目录文件
            string path2 = "D:\\Debug2\\";   //压缩后存放目录文件
            //获取指定目录下所有文件和子文件名称(所有待压缩的文件)
            string[] files = Directory.GetFileSystemEntries(path1);
            ZipFloClass zc = new ZipFloClass();
            //遍历指定目录下文件路径
            foreach (string file in files)
            {
                //截取文件路径的文件名
                var filename = file.Substring(file.LastIndexOf("\\") + 1);
                //调用压缩方法（参数1：待压缩的文件目录，参数2：压缩后的文件目录（包含后缀））
                zc.ZipFile(path1 + filename, path2 + filename + ".zip");
            }
        }

        /// <summary>
        /// 批量解压事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBatchUnZipFlo_Click(object sender, EventArgs e)
        {
            string msg = "";
            string path2 = "D:\\Debug2\\";
            string path3 = "D:\\Debug3\\";
            //获取指定目录下所有文件和子文件名称（所有待解压的压缩文件）
            string[] files = Directory.GetFileSystemEntries(path2);
            UnZipFloClass uzc = new UnZipFloClass();
            //遍历所有压缩文件路径
            foreach (string file in files)
            {
                //获取压缩包名称（包括后缀名）
                var filename  = file.Substring(file.LastIndexOf("\\") + 1);
                //得到压缩包名称（没有后缀）
                filename = filename.Substring(0, filename.LastIndexOf("."));
                //判断解压的路径是否存在
                if (!Directory.Exists(path3 + filename))
                {
                    //没有，则创建这个路径
                    Directory.CreateDirectory(path3 + filename);
                }
                //调用解压方法（参数1：待解压的压缩文件路径（带后缀名），参数2：解压后存放的文件路径，参数3：返工是否解压成功）
                uzc.unZipFile(file, path3 + filename, ref msg);
            }
            MessageBox.Show("批量解压成功");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
