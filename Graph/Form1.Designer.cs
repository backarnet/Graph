namespace Graph
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.txt_info = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdCircular = new System.Windows.Forms.RadioButton();
            this.rdManual = new System.Windows.Forms.RadioButton();
            this.rdAuto = new System.Windows.Forms.RadioButton();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.txt_v2_del_edge = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_v1_del_edge = new System.Windows.Forms.TextBox();
            this.txt_v2_add_edge = new System.Windows.Forms.TextBox();
            this.txt_v1_add_edge = new System.Windows.Forms.TextBox();
            this.txt_y = new System.Windows.Forms.TextBox();
            this.txt_x = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_v_del = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_v = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_matrix = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(646, 565);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.txt_info);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            this.splitContainer1.Panel1.Controls.Add(this.txt_matrix);
            this.splitContainer1.Panel1.Controls.Add(this.button2);
            this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(10);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox1);
            this.splitContainer1.Size = new System.Drawing.Size(1096, 565);
            this.splitContainer1.SplitterDistance = 446;
            this.splitContainer1.TabIndex = 11;
            // 
            // txt_info
            // 
            this.txt_info.AcceptsTab = true;
            this.txt_info.Dock = System.Windows.Forms.DockStyle.Top;
            this.txt_info.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txt_info.Location = new System.Drawing.Point(10, 422);
            this.txt_info.Multiline = true;
            this.txt_info.Name = "txt_info";
            this.txt_info.ReadOnly = true;
            this.txt_info.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_info.Size = new System.Drawing.Size(426, 132);
            this.txt_info.TabIndex = 9;
            this.txt_info.WordWrap = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdCircular);
            this.panel1.Controls.Add(this.rdManual);
            this.panel1.Controls.Add(this.rdAuto);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.txt_v2_del_edge);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.txt_v1_del_edge);
            this.panel1.Controls.Add(this.txt_v2_add_edge);
            this.panel1.Controls.Add(this.txt_v1_add_edge);
            this.panel1.Controls.Add(this.txt_y);
            this.panel1.Controls.Add(this.txt_x);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txt_v_del);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txt_v);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(10, 245);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(426, 177);
            this.panel1.TabIndex = 10;
            // 
            // rdCircular
            // 
            this.rdCircular.AutoSize = true;
            this.rdCircular.Location = new System.Drawing.Point(17, 84);
            this.rdCircular.Name = "rdCircular";
            this.rdCircular.Size = new System.Drawing.Size(61, 17);
            this.rdCircular.TabIndex = 11;
            this.rdCircular.Text = "Circular";
            this.rdCircular.UseVisualStyleBackColor = true;
            this.rdCircular.CheckedChanged += new System.EventHandler(this.rdAuto_CheckedChanged);
            // 
            // rdManual
            // 
            this.rdManual.AutoSize = true;
            this.rdManual.Location = new System.Drawing.Point(17, 61);
            this.rdManual.Name = "rdManual";
            this.rdManual.Size = new System.Drawing.Size(59, 17);
            this.rdManual.TabIndex = 10;
            this.rdManual.Text = "Manual";
            this.rdManual.UseVisualStyleBackColor = true;
            this.rdManual.CheckedChanged += new System.EventHandler(this.rdAuto_CheckedChanged);
            // 
            // rdAuto
            // 
            this.rdAuto.AutoSize = true;
            this.rdAuto.Checked = true;
            this.rdAuto.Location = new System.Drawing.Point(17, 38);
            this.rdAuto.Name = "rdAuto";
            this.rdAuto.Size = new System.Drawing.Size(88, 17);
            this.rdAuto.TabIndex = 9;
            this.rdAuto.TabStop = true;
            this.rdAuto.Text = "Auto position";
            this.rdAuto.UseVisualStyleBackColor = true;
            this.rdAuto.CheckedChanged += new System.EventHandler(this.rdAuto_CheckedChanged);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(287, 133);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(136, 23);
            this.button7.TabIndex = 8;
            this.button7.Text = "BFS  search";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(140, 133);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(141, 23);
            this.button6.TabIndex = 7;
            this.button6.Text = "DFS  search";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(313, 33);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Remove Vertex";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(313, 91);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(110, 23);
            this.button5.TabIndex = 4;
            this.button5.Text = "Remove Edge";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(313, 62);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(110, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "Add Edge";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // txt_v2_del_edge
            // 
            this.txt_v2_del_edge.Location = new System.Drawing.Point(246, 93);
            this.txt_v2_del_edge.Name = "txt_v2_del_edge";
            this.txt_v2_del_edge.Size = new System.Drawing.Size(61, 20);
            this.txt_v2_del_edge.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(313, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Add Vertex";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // txt_v1_del_edge
            // 
            this.txt_v1_del_edge.Location = new System.Drawing.Point(140, 93);
            this.txt_v1_del_edge.Name = "txt_v1_del_edge";
            this.txt_v1_del_edge.Size = new System.Drawing.Size(71, 20);
            this.txt_v1_del_edge.TabIndex = 2;
            // 
            // txt_v2_add_edge
            // 
            this.txt_v2_add_edge.Location = new System.Drawing.Point(246, 64);
            this.txt_v2_add_edge.Name = "txt_v2_add_edge";
            this.txt_v2_add_edge.Size = new System.Drawing.Size(61, 20);
            this.txt_v2_add_edge.TabIndex = 3;
            // 
            // txt_v1_add_edge
            // 
            this.txt_v1_add_edge.Location = new System.Drawing.Point(140, 64);
            this.txt_v1_add_edge.Name = "txt_v1_add_edge";
            this.txt_v1_add_edge.Size = new System.Drawing.Size(71, 20);
            this.txt_v1_add_edge.TabIndex = 2;
            // 
            // txt_y
            // 
            this.txt_y.Location = new System.Drawing.Point(246, 6);
            this.txt_y.Name = "txt_y";
            this.txt_y.Size = new System.Drawing.Size(61, 20);
            this.txt_y.TabIndex = 3;
            // 
            // txt_x
            // 
            this.txt_x.Location = new System.Drawing.Point(140, 6);
            this.txt_x.Name = "txt_x";
            this.txt_x.Size = new System.Drawing.Size(71, 20);
            this.txt_x.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(217, 96);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "V2:";
            // 
            // txt_v_del
            // 
            this.txt_v_del.Location = new System.Drawing.Point(246, 35);
            this.txt_v_del.Name = "txt_v_del";
            this.txt_v_del.Size = new System.Drawing.Size(61, 20);
            this.txt_v_del.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(217, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "V2:";
            // 
            // txt_v
            // 
            this.txt_v.Location = new System.Drawing.Point(46, 6);
            this.txt_v.Name = "txt_v";
            this.txt_v.Size = new System.Drawing.Size(65, 20);
            this.txt_v.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(111, 96);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "V1:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(223, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Y:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(111, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "V1:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(203, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Value:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(117, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "X:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Value:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Information:";
            // 
            // txt_matrix
            // 
            this.txt_matrix.AcceptsTab = true;
            this.txt_matrix.Dock = System.Windows.Forms.DockStyle.Top;
            this.txt_matrix.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold);
            this.txt_matrix.Location = new System.Drawing.Point(10, 54);
            this.txt_matrix.Multiline = true;
            this.txt_matrix.Name = "txt_matrix";
            this.txt_matrix.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_matrix.Size = new System.Drawing.Size(426, 191);
            this.txt_matrix.TabIndex = 7;
            this.txt_matrix.Text = "\tv1\tv2\tv3\tv4\t\r\nv1\t0\t1\t1\t0\t\r\nv2\t1\t0\t0\t1\t\r\nv3\t1\t0\t0\t1\t\r\nv4\t0\t1\t1\t0\t";
            this.txt_matrix.WordWrap = false;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.Font = new System.Drawing.Font("Tahoma", 12F);
            this.button2.Location = new System.Drawing.Point(10, 10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(426, 44);
            this.button2.TabIndex = 5;
            this.button2.Text = "Create Ghrap from adj matrix and Draw";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 565);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox txt_info;
        private System.Windows.Forms.TextBox txt_matrix;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_y;
        private System.Windows.Forms.TextBox txt_x;
        private System.Windows.Forms.TextBox txt_v;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txt_v_del;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txt_v2_del_edge;
        private System.Windows.Forms.TextBox txt_v1_del_edge;
        private System.Windows.Forms.TextBox txt_v2_add_edge;
        private System.Windows.Forms.TextBox txt_v1_add_edge;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.RadioButton rdCircular;
        private System.Windows.Forms.RadioButton rdManual;
        private System.Windows.Forms.RadioButton rdAuto;
    }
}

