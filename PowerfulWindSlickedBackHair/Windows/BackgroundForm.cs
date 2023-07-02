using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using Sunny.UI;

namespace PowerfulWindSlickedBackHair.Windows
{
    // Token: 0x02000008 RID: 8
    public partial class BackgroundForm : Form
    {
        // Token: 0x0600001D RID: 29 RVA: 0x0000359C File Offset: 0x0000179C
        public BackgroundForm()
        {
            this.InitializeComponent();
            this.backColorY = Color.FromArgb(16701521);
            this.backColorY = Color.FromArgb(255, (int)this.backColorY.R, (int)this.backColorY.G, (int)this.backColorY.B);
            this.BackColor = this.backColorY;
            this.backColorB = Color.FromArgb(6471671);
            this.backColorB = Color.FromArgb(255, (int)this.backColorB.R, (int)this.backColorB.G, (int)this.backColorB.B);
            base.StartPosition = FormStartPosition.Manual;
            this.text.Font = new Font(MainForm.otherFont.Families[0], 100f, FontStyle.Bold, GraphicsUnit.Point, 134);
        }

        // Token: 0x0600001E RID: 30 RVA: 0x00003658 File Offset: 0x00001858
        public void ShowDialog(Point pos, int endFrame)
        {
            base.Location = pos;
            Thread thread = new Thread(delegate ()
            {
                int endFrame2 = endFrame;
                bool flag;
                do
                {
                    this.UpdateText(Tracker.frame);
                    flag = (Tracker.frame > (long)endFrame);
                }
                while (!flag);
                this.Hide();
            });
            thread.Start();
            base.ShowDialog();
        }

        // Token: 0x0600001F RID: 31 RVA: 0x000036A4 File Offset: 0x000018A4
        private void UpdateText(long f)
        {
            long num = 0L;
            long num2 = f - num;
            long num3 = num2;
            if (num3 <= 1386L)
            {
                if (num3 <= 772L)
                {
                    if (num3 <= 257L)
                    {
                        if (num3 <= 152L)
                        {
                            if (num3 <= 68L)
                            {
                                if (num3 != 10L)
                                {
                                    if (num3 != 48L)
                                    {
                                        if (num3 == 68L)
                                        {
                                            this.text.Text = "";
                                        }
                                    }
                                    else
                                    {
                                        this.text.Text = "就感觉完蛋啦\r\n";
                                    }
                                }
                                else
                                {
                                    this.text.Text = "出考场的瞬间\r\n";
                                }
                            }
                            else if (num3 <= 125L)
                            {
                                if (num3 != 86L)
                                {
                                    if (num3 == 125L)
                                    {
                                        this.text.Text = "也寸步难行\r\n";
                                    }
                                }
                                else
                                {
                                    this.text.Text = "即使感觉考的再好\r\n";
                                }
                            }
                            else if (num3 != 146L)
                            {
                                if (num3 == 152L)
                                {
                                    this.text.Text = "风";
                                }
                            }
                            else
                            {
                                this.text.Text = "";
                                this.text.Font = new Font(MainForm.otherFont.Families[0], 186f, FontStyle.Bold, GraphicsUnit.Point, 134);
                            }
                        }
                        else if (num3 <= 201L)
                        {
                            if (num3 != 167L)
                            {
                                if (num3 != 172L)
                                {
                                    if (num3 == 201L)
                                    {
                                        this.text.Text = "把我给吞噬\r\n";
                                    }
                                }
                                else
                                {
                                    this.text.Text = "大的就要\r\n";
                                }
                            }
                            else
                            {
                                this.text.Text = "";
                                this.text.Font = new Font(MainForm.otherFont.Families[0], 100f, FontStyle.Bold, GraphicsUnit.Point, 134);
                            }
                        }
                        else if (num3 <= 238L)
                        {
                            if (num3 != 221L)
                            {
                                if (num3 == 238L)
                                {
                                    this.text.Text = "担忧      \r\n";
                                }
                            }
                            else
                            {
                                this.text.Text = "";
                            }
                        }
                        else if (num3 != 247L)
                        {
                            if (num3 == 257L)
                            {
                                this.text.Text = "担忧担忧\r\n的";
                            }
                        }
                        else
                        {
                            this.text.Text = "担忧担忧\r\n";
                        }
                    }
                    else if (num3 <= 618L)
                    {
                        if (num3 <= 390L)
                        {
                            if (num3 != 272L)
                            {
                                if (num3 != 309L)
                                {
                                    if (num3 == 390L)
                                    {
                                        this.BackColor = this.backColorB;
                                    }
                                }
                                else
                                {
                                    this.text.Text = "";
                                }
                            }
                            else
                            {
                                this.text.Text = "被考成大零蛋\r\n";
                            }
                        }
                        else if (num3 <= 467L)
                        {
                            if (num3 != 460L)
                            {
                                if (num3 == 467L)
                                {
                                    this.BackColor = this.backColorY;
                                    this.text.Text = "強风大背头但是考试版\r\n";
                                }
                            }
                            else
                            {
                                this.text.Font = new Font(MainForm.otherFont.Families[0], 72f, FontStyle.Bold, GraphicsUnit.Point, 134);
                            }
                        }
                        else if (num3 != 542L)
                        {
                            if (num3 == 618L)
                            {
                                this.text.Text = "";
                                this.text.Font = new Font(MainForm.otherFont.Families[0], 100f, FontStyle.Bold, GraphicsUnit.Point, 134);
                            }
                        }
                        else
                        {
                            this.BackColor = this.backColorB;
                        }
                    }
                    else if (num3 <= 714L)
                    {
                        if (num3 <= 652L)
                        {
                            if (num3 != 619L)
                            {
                                if (num3 == 652L)
                                {
                                    this.text.Text = "再检查卷子\r\n";
                                }
                            }
                            else
                            {
                                this.text.Text = "真的好想\r\n";
                                this.BackColor = this.backColorY;
                            }
                        }
                        else if (num3 != 701L)
                        {
                            if (num3 == 714L)
                            {
                                this.text.Text = "哎\r\n";
                            }
                        }
                        else
                        {
                            this.text.Text = "";
                        }
                    }
                    else if (num3 <= 729L)
                    {
                        if (num3 != 726L)
                        {
                            if (num3 == 729L)
                            {
                                this.text.Text = "真的有想过啊\r\n";
                            }
                        }
                        else
                        {
                            this.text.Text = "";
                        }
                    }
                    else if (num3 != 762L)
                    {
                        if (num3 == 772L)
                        {
                            this.text.Text = "如果题\r\n";
                        }
                    }
                    else
                    {
                        this.text.Text = "";
                    }
                }
                else if (num3 <= 1142L)
                {
                    if (num3 <= 997L)
                    {
                        if (num3 <= 876L)
                        {
                            if (num3 != 810L)
                            {
                                if (num3 != 843L)
                                {
                                    if (num3 == 876L)
                                    {
                                        this.text.Text = "就考好了吧\r\n";
                                    }
                                }
                                else
                                {
                                    this.text.Text = "";
                                    this.text.Font = new Font(MainForm.otherFont.Families[0], 86f, FontStyle.Bold, GraphicsUnit.Point, 134);
                                }
                            }
                            else
                            {
                                this.text.Text = "可以不太难\r\n";
                            }
                        }
                        else if (num3 <= 924L)
                        {
                            if (num3 != 909L)
                            {
                                if (num3 == 924L)
                                {
                                    this.text.Text = "我真的好想\r\n";
                                }
                            }
                            else
                            {
                                this.text.Text = "";
                                this.text.Font = new Font(MainForm.otherFont.Families[0], 100f, FontStyle.Bold, GraphicsUnit.Point, 134);
                            }
                        }
                        else if (num3 != 958L)
                        {
                            if (num3 == 997L)
                            {
                                this.text.Text = "";
                            }
                        }
                        else
                        {
                            this.text.Text = "就在家安逸\r\n";
                        }
                    }
                    else if (num3 <= 1034L)
                    {
                        if (num3 != 1018L)
                        {
                            if (num3 != 1029L)
                            {
                                if (num3 == 1034L)
                                {
                                    this.text.Text = "真的好想啊\r\n";
                                }
                            }
                            else
                            {
                                this.text.Text = "";
                            }
                        }
                        else
                        {
                            this.text.Text = "唉\r\n";
                        }
                    }
                    else if (num3 <= 1109L)
                    {
                        if (num3 != 1076L)
                        {
                            if (num3 == 1109L)
                            {
                                this.text.Text = "在\r\n";
                            }
                        }
                        else
                        {
                            this.text.Text = "不啦不啦\r\n";
                        }
                    }
                    else if (num3 != 1114L)
                    {
                        if (num3 == 1142L)
                        {
                            this.text.Text = "";
                        }
                    }
                    else
                    {
                        this.text.Text = "外面的话\r\n";
                    }
                }
                else if (num3 <= 1212L)
                {
                    if (num3 <= 1170L)
                    {
                        if (num3 != 1152L)
                        {
                            if (num3 != 1161L)
                            {
                                if (num3 == 1170L)
                                {
                                    this.text.Text = "      语文   \r\n";
                                }
                            }
                            else
                            {
                                this.text.Text = "   数学      \r\n";
                            }
                        }
                        else
                        {
                            this.text.Text = "英语         \r\n";
                        }
                    }
                    else if (num3 <= 1185L)
                    {
                        if (num3 != 1179L)
                        {
                            if (num3 == 1185L)
                            {
                                this.text.Text = "";
                            }
                        }
                        else
                        {
                            this.text.Text = "         道科\r\n";
                        }
                    }
                    else if (num3 != 1191L)
                    {
                        if (num3 == 1212L)
                        {
                            this.text.Text = "";
                        }
                    }
                    else
                    {
                        this.text.Text = "试卷大乱斗啊\r\n";
                    }
                }
                else if (num3 <= 1304L)
                {
                    if (num3 <= 1266L)
                    {
                        if (num3 != 1228L)
                        {
                            if (num3 == 1266L)
                            {
                                this.text.Text = "就要完蛋啦\r\n";
                            }
                        }
                        else
                        {
                            this.text.Text = "冲出考场的一瞬间\r\n";
                        }
                    }
                    else if (num3 != 1288L)
                    {
                        if (num3 == 1304L)
                        {
                            this.text.Text = "就算自我感觉良好\r\n";
                        }
                    }
                    else
                    {
                        this.text.Text = "";
                    }
                }
                else if (num3 <= 1364L)
                {
                    if (num3 != 1343L)
                    {
                        if (num3 == 1364L)
                        {
                            this.text.Text = "";
                            this.text.Font = new Font(MainForm.otherFont.Families[0], 186f, FontStyle.Bold, GraphicsUnit.Point, 134);
                        }
                    }
                    else
                    {
                        this.text.Text = "也想改试卷\r\n";
                    }
                }
                else if (num3 != 1371L)
                {
                    if (num3 == 1386L)
                    {
                        this.text.Text = "";
                        this.text.Font = new Font(MainForm.otherFont.Families[0], 100f, FontStyle.Bold, GraphicsUnit.Point, 134);
                    }
                }
                else
                {
                    this.text.Text = "风";
                }
            }
            else if (num3 <= 2099L)
            {
                if (num3 <= 1851L)
                {
                    if (num3 <= 1491L)
                    {
                        if (num3 <= 1441L)
                        {
                            if (num3 != 1391L)
                            {
                                if (num3 != 1420L)
                                {
                                    if (num3 == 1441L)
                                    {
                                        this.text.Text = "";
                                    }
                                }
                                else
                                {
                                    this.text.Text = "在家逝掉啊\r\n";
                                }
                            }
                            else
                            {
                                this.text.Text = "强到我想\r\n";
                            }
                        }
                        else if (num3 <= 1466L)
                        {
                            if (num3 != 1456L)
                            {
                                if (num3 == 1466L)
                                {
                                    this.text.Text = "这担忧\r\n";
                                }
                            }
                            else
                            {
                                this.text.Text = "担忧      \r\n";
                            }
                        }
                        else if (num3 != 1476L)
                        {
                            if (num3 == 1491L)
                            {
                                this.text.Text = "考成大零蛋\r\n";
                            }
                        }
                        else
                        {
                            this.text.Text = "如期而来的\r\n的担忧";
                        }
                    }
                    else if (num3 <= 1810L)
                    {
                        if (num3 != 1527L)
                        {
                            if (num3 != 1685L)
                            {
                                if (num3 == 1810L)
                                {
                                    this.text.Text = "";
                                    this.text.Font = new Font(MainForm.otherFont.Families[0], 100f, FontStyle.Bold, GraphicsUnit.Point, 134);
                                }
                            }
                            else
                            {
                                this.text.Text = "试卷大零蛋\r\n";
                            }
                        }
                        else
                        {
                            this.text.Text = "";
                            this.text.Font = new Font(MainForm.otherFont.Families[0], 72f, FontStyle.Bold, GraphicsUnit.Point, 134);
                        }
                    }
                    else if (num3 <= 1843L)
                    {
                        if (num3 != 1836L)
                        {
                            if (num3 == 1843L)
                            {
                                this.text.Text = "冲出\r\n";
                            }
                        }
                        else
                        {
                            this.text.Text = "冲\r\n";
                        }
                    }
                    else if (num3 != 1847L)
                    {
                        if (num3 == 1851L)
                        {
                            this.text.Text = "冲出的瞬\r\n";
                        }
                    }
                    else
                    {
                        this.text.Text = "冲出的\r\n";
                    }
                }
                else if (num3 <= 1979L)
                {
                    if (num3 <= 1895L)
                    {
                        if (num3 != 1865L)
                        {
                            if (num3 != 1874L)
                            {
                                if (num3 == 1895L)
                                {
                                    this.text.Text = "";
                                }
                            }
                            else
                            {
                                this.text.Text = "就完蛋了啦\r\n";
                            }
                        }
                        else
                        {
                            this.text.Text = "冲出的瞬间\r\n";
                        }
                    }
                    else if (num3 <= 1951L)
                    {
                        if (num3 != 1912L)
                        {
                            if (num3 == 1951L)
                            {
                                this.text.Text = "一直担忧啊\r\n";
                            }
                        }
                        else
                        {
                            this.text.Text = "自我感觉良好也是\r\n";
                        }
                    }
                    else if (num3 != 1973L)
                    {
                        if (num3 == 1979L)
                        {
                            this.text.Text = "错啦";
                        }
                    }
                    else
                    {
                        this.text.Text = "";
                        this.text.Font = new Font(MainForm.otherFont.Families[0], 186f, FontStyle.Bold, GraphicsUnit.Point, 134);
                    }
                }
                else if (num3 <= 2048L)
                {
                    if (num3 <= 1998L)
                    {
                        if (num3 != 1994L)
                        {
                            if (num3 == 1998L)
                            {
                                this.text.Text = "想到就想哭喊\r\n";
                            }
                        }
                        else
                        {
                            this.text.Text = "";
                            this.text.Font = new Font(MainForm.otherFont.Families[0], 100f, FontStyle.Bold, GraphicsUnit.Point, 134);
                        }
                    }
                    else if (num3 != 2028L)
                    {
                        if (num3 == 2048L)
                        {
                            this.text.Text = "";
                        }
                    }
                    else
                    {
                        this.text.Text = "妈妈我想回家\r\n";
                    }
                }
                else if (num3 <= 2074L)
                {
                    if (num3 != 2065L)
                    {
                        if (num3 == 2074L)
                        {
                            this.text.Text = "担忧担忧\r\n";
                        }
                    }
                    else
                    {
                        this.text.Text = "担忧      \r\n";
                    }
                }
                else if (num3 != 2084L)
                {
                    if (num3 == 2099L)
                    {
                        this.text.Text = "一个大零蛋呐\r\n";
                    }
                }
                else
                {
                    this.text.Text = "担忧担忧\r\n考成";
                }
            }
            else if (num3 <= 2333L)
            {
                if (num3 <= 2180L)
                {
                    if (num3 <= 2141L)
                    {
                        if (num3 != 2131L)
                        {
                            if (num3 != 2135L)
                            {
                                if (num3 == 2141L)
                                {
                                    this.text.Text = "啊啊\r\n";
                                }
                            }
                            else
                            {
                                this.text.Text = "";
                            }
                        }
                        else
                        {
                            this.text.Text = "啊\r\n";
                        }
                    }
                    else if (num3 <= 2151L)
                    {
                        if (num3 != 2148L)
                        {
                            if (num3 == 2151L)
                            {
                                this.text.Text = "出考场一瞬\r\n";
                            }
                        }
                        else
                        {
                            this.text.Text = "";
                        }
                    }
                    else if (num3 != 2172L)
                    {
                        if (num3 == 2180L)
                        {
                            this.text.Text = "就感觉完蛋啦\r\n";
                        }
                    }
                    else
                    {
                        this.text.Text = "";
                    }
                }
                else if (num3 <= 2277L)
                {
                    if (num3 <= 2218L)
                    {
                        if (num3 != 2200L)
                        {
                            if (num3 == 2218L)
                            {
                                this.text.Text = "就算发挥良好也\r\n";
                            }
                        }
                        else
                        {
                            this.text.Text = "";
                        }
                    }
                    else if (num3 != 2255L)
                    {
                        if (num3 == 2277L)
                        {
                            this.text.Text = "";
                            this.text.Font = new Font(MainForm.otherFont.Families[0], 186f, FontStyle.Bold, GraphicsUnit.Point, 134);
                        }
                    }
                    else
                    {
                        this.text.Text = "一直担忧啊\r\n";
                    }
                }
                else if (num3 <= 2300L)
                {
                    if (num3 != 2285L)
                    {
                        if (num3 == 2300L)
                        {
                            this.text.Text = "";
                            this.text.Font = new Font(MainForm.otherFont.Families[0], 100f, FontStyle.Bold, GraphicsUnit.Point, 134);
                        }
                    }
                    else
                    {
                        this.text.Text = "风";
                    }
                }
                else if (num3 != 2304L)
                {
                    if (num3 == 2333L)
                    {
                        this.text.Text = "给吹上天堂啊\r\n";
                    }
                }
                else
                {
                    this.text.Text = "强到可以把我\r\n";
                }
            }
            else if (num3 <= 2445L)
            {
                if (num3 <= 2381L)
                {
                    if (num3 != 2356L)
                    {
                        if (num3 != 2371L)
                        {
                            if (num3 == 2381L)
                            {
                                this.text.Text = "一直一直\r\n";
                            }
                        }
                        else
                        {
                            this.text.Text = "一直      \r\n";
                        }
                    }
                    else
                    {
                        this.text.Text = "";
                    }
                }
                else if (num3 <= 2405L)
                {
                    if (num3 != 2391L)
                    {
                        if (num3 == 2405L)
                        {
                            this.text.Text = "一个大零蛋啊\r\n";
                        }
                    }
                    else
                    {
                        this.text.Text = "一直一直\r\n担忧考成";
                    }
                }
                else if (num3 != 2438L)
                {
                    if (num3 == 2445L)
                    {
                        this.text.Text = "成绩令人唏嘘的\r\n";
                    }
                }
                else
                {
                    this.text.Text = "";
                }
            }
            else if (num3 <= 2523L)
            {
                if (num3 <= 2476L)
                {
                    if (num3 != 2461L)
                    {
                        if (num3 == 2476L)
                        {
                            this.text.Text = "大零蛋\r\n";
                        }
                    }
                    else
                    {
                        this.text.Text = "一个\r\n";
                    }
                }
                else if (num3 != 2502L)
                {
                    if (num3 == 2523L)
                    {
                        if (!changedLeft)
                            this.Left -= 400;
                        changedLeft = true;
                        this.text.Font = new Font(MainForm.otherFont.Families[0], 25f, FontStyle.Bold, GraphicsUnit.Point, 134);
                        this.text.TextAlign = ContentAlignment.MiddleLeft;
                        this.text.Text = "考试大零蛋\r\n";
                    }
                }
                else
                {
                    this.text.Text = "";
                }
            }
            else if (num3 <= 2677L)
            {
                if (num3 != 2602L)
                {
                    if (num3 == 2677L)
                    {
                        this.text.Text = "改:Orange\r\n显示: winform\r\n不过还是祝考生考个好成绩！\r\n";
                    }
                }
                else
                {
                    this.text.Text = "原代码作者:\r\n 钅离_LX\r\n";
                }
            }
            else if (num3 != 2753L)
            {
                if (num3 == 2818L)
                {
                    if (!changedLeft2)
                        this.Left += 400;
                    changedLeft2 = true;
                    this.text.Font = new Font(MainForm.otherFont.Families[0], 100f, FontStyle.Bold, GraphicsUnit.Point, 134);
                    this.text.TextAlign = ContentAlignment.MiddleCenter;
                    this.text.Text = "谢谢观看\r\n~";
                }
            }
            else
            {
                this.text.Text = " ";
            }
        }

        bool changedLeft, changedLeft2;

        // Token: 0x0400001A RID: 26
        private Color backColorY;

        // Token: 0x0400001B RID: 27
        private Color backColorB;
    }
}
