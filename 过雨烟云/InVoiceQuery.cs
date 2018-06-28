using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 过雨烟云
{
    public partial class InVoiceQuery : Form
    {
        public InVoiceQuery()
        {
            InitializeComponent();
        }

        List<Control> listBtn = new List<Control>();
        private Point gbPoint;              //记录控件的位置
        private bool isMouseDown = false;   //鼠标左键是否按下
        private Point mouseOffset;          //记录鼠标指针的坐标
        private void InVoiceQuery_Load(object sender, EventArgs e)
        {
            ControlSort();
            MouseEventBind();
        }


        #region 鼠标按下后事件的触发
        /// <summary>
        /// 鼠标按下后事件的触发
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                
                mouseOffset.X = e.X;
                mouseOffset.Y = e.Y;
                isMouseDown = true;
            }
        }

        #endregion

        #region 鼠标移动事件
        /// <summary>
        /// 鼠标移动
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                int left = ActiveControl.Left + e.X - mouseOffset.X;
                int top = ActiveControl.Top + e.Y - mouseOffset.Y;
                ActiveControl.Location = new Point(left, top);
            }
        }

        #endregion

        #region 鼠标放下
        /// <summary>
        /// 鼠标放下
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isMouseDown = false;
            }
        }


        #endregion

        #region 按钮控件排序

        private void ControlSort()
        {
            if (listBtn.Count == 0)
            {
                foreach (Control ctl in groupBox2.Controls)
                {
                    if (ctl.GetType().Name.Equals("Button")) listBtn.Add(ctl);
                }
            }
            gbPoint.X = groupBox2.Left + 10;
            gbPoint.Y = (groupBox2.Height - listBtn[0].Height) / 2 + 5;

            for (int i = 0; i < listBtn.Count; i++)
            {
                listBtn[i].Left = gbPoint.X;
                listBtn[i].Top = gbPoint.Y;
                gbPoint.X = listBtn[i].Right + 3;
            }
        }

        #endregion

        #region 所有按钮的事件绑定
        /// <summary>
        /// 所有按钮的事件绑定
        /// </summary>
        private void MouseEventBind()
        {
            for (int i = 0; i < listBtn.Count; i++)
            {
                listBtn[i].MouseDown += new MouseEventHandler(MouseDown);
                listBtn[i].MouseMove += new MouseEventHandler(MouseMove);
                listBtn[i].MouseUp += new MouseEventHandler(MouseUp);
            }
            groupBox3.DragEnter += new DragEventHandler(DragEnter);
        }

        #endregion

        #region 鼠标进入控件事件

        private void DragEnter(object sender, EventArgs e)
        {
            MessageBox.Show("");
        }

        #endregion
    }
}
