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

        private GroupBox _groupBox;
        List<Control> listBtn = new List<Control>();
        private bool isMouseDown = false;   //鼠标左键是否按下
        private Point mouseOffset;          //记录鼠标指针的坐标
        private void InVoiceQuery_Load(object sender, EventArgs e)
        {
            //获取控件到list
            foreach (Control ctl in groupBox2.Controls)
            {
                if (ctl.GetType().Name.Equals("Button")) listBtn.Add(ctl);
            }
            foreach (Control ctl in groupBox5.Controls)
            {
                if (ctl.GetType().Name.Equals("Button")) listBtn.Add(ctl);
            }

            //绑定鼠标和GroupBox事件
            MouseEventBind();
            //排序按钮
            ControlSort(groupBox2);
            ControlSort(groupBox5);

            // 允许拖放
            groupBox3.AllowDrop = true;
            groupBox2.AllowDrop = true;
            groupBox4.AllowDrop = true;
            groupBox5.AllowDrop = true;
        }

        #region 鼠标按下后事件的触发
        /// <summary>
        /// 鼠标按下后事件的触发
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private new void MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Button btn = (Button)sender;
                _groupBox = (GroupBox)btn.Parent;
                btn.DoDragDrop(btn, DragDropEffects.Move);
            }
        }

        #endregion

        #region 鼠标进入控件事件

        private new void DragEnter(object sender, DragEventArgs e)
        {
            
            e.Effect = DragDropEffects.Move;
            isMouseDown = true;
        }

        #endregion

        #region 放下控件

        private new void DragDrop(object sender, DragEventArgs e)
        {
            GroupBox groupBox = (GroupBox)sender;

            if (groupBox.Name == "groupBox2" || groupBox.Name == "groupBox3")
            {
                if (groupBox == _groupBox && groupBox.Name == "groupBox2")
                {
                    ActiveControl.Parent = groupBox3;
                }

                if (groupBox == _groupBox && groupBox.Name == "groupBox3")
                {
                    ActiveControl.Parent = groupBox2;
                }

                if (groupBox != _groupBox && groupBox.Name == "groupBox3")
                {
                    ActiveControl.Parent = groupBox3;
                }

                if (groupBox != _groupBox && groupBox.Name == "groupBox2")
                {
                    ActiveControl.Parent = groupBox2;
                }

                ControlSort(groupBox3);
                ControlSort(groupBox2);
            }

            if (groupBox.Name == "groupBox4" || groupBox.Name == "groupBox5")
            {
                if (groupBox == _groupBox && groupBox.Name == "groupBox4")
                {
                    ActiveControl.Parent = groupBox5;
                }

                if (groupBox == _groupBox && groupBox.Name == "groupBox5")
                {
                    ActiveControl.Parent = groupBox4;
                }

                if (groupBox != _groupBox && groupBox.Name == "groupBox4")
                {
                    ActiveControl.Parent = groupBox4;
                }

                if (groupBox != _groupBox && groupBox.Name == "groupBox5")
                {
                    ActiveControl.Parent = groupBox5;
                }

                ControlSort(groupBox4);
                ControlSort(groupBox5);
            }

            // 从事件参数 DragEventArgs 中获取被拖动的元素
            //Button btn = (Button)e.Data.GetData(typeof(Button));
            //GroupBox grp = (GroupBox)btn.Parent;
            //grp.Controls.Remove(btn);
            //((GroupBox)sender).Controls.Add(btn);
            //RefreshControls(new Control[] { grp, (GroupBox)sender });
            //isMouseDown = false;
        }

        #endregion

        #region 按钮控件排序

        private void ControlSort(GroupBox groupBox)
        {
            Point gbPoint = new Point();              //记录控件的位置
            int ctlCount = groupBox.Controls.Count;
            if (ctlCount == 0) return;

            //gbPoint.X = groupBox.Left + 10;
            gbPoint.X = 10;
            gbPoint.Y = (groupBox.Height - groupBox.Controls[0].Height) / 2 + 5;

            for (int i = 0; i < ctlCount; i++)
            {
                groupBox.Controls[i].Left = gbPoint.X;
                groupBox.Controls[i].Top = gbPoint.Y;
                gbPoint.X = groupBox.Controls[i].Right + 3;
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
            //if (isMouseDown)
            //{
            //    int left = ActiveControl.Left + e.X - mouseOffset.X;
            //    int top = ActiveControl.Top + e.Y - mouseOffset.Y;
            //    ActiveControl.Location = new Point(left, top);
            //}
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
            //if (e.Button == MouseButtons.Left)
            //{
            //    isMouseDown = false;
            //}
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
                listBtn[i].DragEnter += new DragEventHandler(DragEnter);
            }
            // 拖动对象进入控件边界时触发
            groupBox3.DragEnter += new DragEventHandler(DragEnter);
            groupBox2.DragEnter += new DragEventHandler(DragEnter);
            groupBox4.DragEnter += new DragEventHandler(DragEnter);
            groupBox5.DragEnter += new DragEventHandler(DragEnter);
            // 完成拖动时触发
            groupBox3.DragDrop += new DragEventHandler(DragDrop);
            groupBox2.DragDrop += new DragEventHandler(DragDrop);
            groupBox4.DragDrop += new DragEventHandler(DragDrop);
            groupBox5.DragDrop += new DragEventHandler(DragDrop);

        }

        #endregion

        #region 取消所有事件

        private void CancelEventBind()
        {
            for (int i = 0; i < listBtn.Count; i++)
            {
                listBtn[i].MouseDown -= new MouseEventHandler(MouseDown);
                listBtn[i].MouseMove -= new MouseEventHandler(MouseMove);
                listBtn[i].MouseUp -= new MouseEventHandler(MouseUp);
            }
            // 拖动对象进入控件边界时触发
            groupBox3.DragEnter -= new DragEventHandler(DragEnter);
            groupBox2.DragEnter -= new DragEventHandler(DragEnter);
            groupBox4.DragEnter -= new DragEventHandler(DragEnter);
            groupBox5.DragEnter -= new DragEventHandler(DragEnter);
            // 完成拖动时触发
            groupBox3.DragDrop -= new DragEventHandler(DragDrop);
            groupBox2.DragDrop -= new DragEventHandler(DragDrop);
            groupBox4.DragDrop -= new DragEventHandler(DragDrop);
            groupBox5.DragDrop -= new DragEventHandler(DragDrop);

        }


        #endregion


        


       
    }
}
