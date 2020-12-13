
namespace TestXYZ
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.ck = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.attacker = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hittype = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hitid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.weaponid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fx = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fy = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fz = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MySqlLoader = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.SetPosGroup = new System.Windows.Forms.GroupBox();
            this.CCK = new System.Windows.Forms.CheckBox();
            this.SetPosGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(845, 180);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 112);
            this.button1.TabIndex = 0;
            this.button1.Text = "그래프";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(9, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(174, 21);
            this.textBox1.TabIndex = 9;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(9, 52);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(174, 21);
            this.textBox2.TabIndex = 10;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(9, 91);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(174, 21);
            this.textBox3.TabIndex = 11;
            // 
            // listView1
            // 
            this.listView1.CheckBoxes = true;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ck,
            this.attacker,
            this.hittype,
            this.hitid,
            this.weaponid,
            this.fx,
            this.fy,
            this.fz,
            this.time});
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(2, 180);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(781, 475);
            this.listView1.TabIndex = 13;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.listView1_ItemChecked);
            // 
            // ck
            // 
            this.ck.Text = "";
            this.ck.Width = 30;
            // 
            // attacker
            // 
            this.attacker.Text = "attacker";
            this.attacker.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.attacker.Width = 100;
            // 
            // hittype
            // 
            this.hittype.Text = "hittype";
            this.hittype.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.hittype.Width = 70;
            // 
            // hitid
            // 
            this.hitid.Text = "hitid";
            this.hitid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.hitid.Width = 110;
            // 
            // weaponid
            // 
            this.weaponid.Text = "weaponid";
            this.weaponid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.weaponid.Width = 70;
            // 
            // fx
            // 
            this.fx.Text = "fx";
            this.fx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.fx.Width = 85;
            // 
            // fy
            // 
            this.fy.Text = "fy";
            this.fy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.fy.Width = 85;
            // 
            // fz
            // 
            this.fz.Text = "fz";
            this.fz.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.fz.Width = 85;
            // 
            // time
            // 
            this.time.Text = "time";
            this.time.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.time.Width = 115;
            // 
            // MySqlLoader
            // 
            this.MySqlLoader.Location = new System.Drawing.Point(291, 34);
            this.MySqlLoader.Name = "MySqlLoader";
            this.MySqlLoader.Size = new System.Drawing.Size(138, 56);
            this.MySqlLoader.TabIndex = 16;
            this.MySqlLoader.Text = "조회";
            this.MySqlLoader.UseVisualStyleBackColor = true;
            this.MySqlLoader.Click += new System.EventHandler(this.MySqlLoader_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(132, 53);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(111, 21);
            this.textBox4.TabIndex = 15;
            this.textBox4.Text = "Seok_Oh";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(85, 56);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(41, 12);
            this.NameLabel.TabIndex = 17;
            this.NameLabel.Text = "이름 : ";
            // 
            // SetPosGroup
            // 
            this.SetPosGroup.Controls.Add(this.textBox3);
            this.SetPosGroup.Controls.Add(this.textBox2);
            this.SetPosGroup.Controls.Add(this.textBox1);
            this.SetPosGroup.Location = new System.Drawing.Point(836, 52);
            this.SetPosGroup.Name = "SetPosGroup";
            this.SetPosGroup.Size = new System.Drawing.Size(197, 128);
            this.SetPosGroup.TabIndex = 18;
            this.SetPosGroup.TabStop = false;
            this.SetPosGroup.Text = "기준점";
            // 
            // CCK
            // 
            this.CCK.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CCK.AutoSize = true;
            this.CCK.Location = new System.Drawing.Point(11, 188);
            this.CCK.Name = "CCK";
            this.CCK.Size = new System.Drawing.Size(15, 14);
            this.CCK.TabIndex = 19;
            this.CCK.UseVisualStyleBackColor = true;
            this.CCK.CheckedChanged += new System.EventHandler(this.CCK_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1047, 667);
            this.Controls.Add(this.CCK);
            this.Controls.Add(this.SetPosGroup);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.MySqlLoader);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.SetPosGroup.ResumeLayout(false);
            this.SetPosGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.TextBox textBox2;
        public System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader attacker;
        private System.Windows.Forms.ColumnHeader hittype;
        private System.Windows.Forms.ColumnHeader hitid;
        private System.Windows.Forms.ColumnHeader weaponid;
        private System.Windows.Forms.ColumnHeader fx;
        private System.Windows.Forms.ColumnHeader fy;
        private System.Windows.Forms.ColumnHeader fz;
        private System.Windows.Forms.ColumnHeader time;
        private System.Windows.Forms.ColumnHeader ck;
        private System.Windows.Forms.Button MySqlLoader;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.GroupBox SetPosGroup;
        private System.Windows.Forms.CheckBox CCK;
    }
}

