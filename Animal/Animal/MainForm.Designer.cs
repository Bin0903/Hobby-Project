namespace Animal
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.gp_play = new System.Windows.Forms.GroupBox();
            this.bt_exit = new System.Windows.Forms.Button();
            this.bt_modify = new System.Windows.Forms.Button();
            this.bt_input = new System.Windows.Forms.Button();
            this.bt_explain = new System.Windows.Forms.Button();
            this.bt_create = new System.Windows.Forms.Button();
            this.gp_play.SuspendLayout();
            this.SuspendLayout();
            // 
            // gp_play
            // 
            this.gp_play.Controls.Add(this.bt_exit);
            this.gp_play.Controls.Add(this.bt_modify);
            this.gp_play.Controls.Add(this.bt_input);
            this.gp_play.Controls.Add(this.bt_explain);
            this.gp_play.Controls.Add(this.bt_create);
            this.gp_play.Location = new System.Drawing.Point(12, 12);
            this.gp_play.Name = "gp_play";
            this.gp_play.Size = new System.Drawing.Size(214, 379);
            this.gp_play.TabIndex = 0;
            this.gp_play.TabStop = false;
            this.gp_play.Text = "操作平台";
            this.gp_play.Enter += new System.EventHandler(this.gp_play_Enter);
            // 
            // bt_exit
            // 
            this.bt_exit.Location = new System.Drawing.Point(33, 298);
            this.bt_exit.Name = "bt_exit";
            this.bt_exit.Size = new System.Drawing.Size(149, 29);
            this.bt_exit.TabIndex = 5;
            this.bt_exit.Text = "退出系统";
            this.bt_exit.UseVisualStyleBackColor = true;
            this.bt_exit.Click += new System.EventHandler(this.bt_exit_Click);
            // 
            // bt_modify
            // 
            this.bt_modify.Location = new System.Drawing.Point(33, 211);
            this.bt_modify.Name = "bt_modify";
            this.bt_modify.Size = new System.Drawing.Size(149, 32);
            this.bt_modify.TabIndex = 4;
            this.bt_modify.Text = "数据修改";
            this.bt_modify.UseVisualStyleBackColor = true;
            this.bt_modify.Click += new System.EventHandler(this.bt_modify_Click);
            // 
            // bt_input
            // 
            this.bt_input.Location = new System.Drawing.Point(33, 88);
            this.bt_input.Name = "bt_input";
            this.bt_input.Size = new System.Drawing.Size(149, 32);
            this.bt_input.TabIndex = 3;
            this.bt_input.Text = "输入事实并推理";
            this.bt_input.UseVisualStyleBackColor = true;
            this.bt_input.Click += new System.EventHandler(this.bt_input_Click);
            // 
            // bt_explain
            // 
            this.bt_explain.Location = new System.Drawing.Point(33, 150);
            this.bt_explain.Name = "bt_explain";
            this.bt_explain.Size = new System.Drawing.Size(149, 32);
            this.bt_explain.TabIndex = 1;
            this.bt_explain.Text = "推理解释";
            this.bt_explain.UseVisualStyleBackColor = true;
            this.bt_explain.Click += new System.EventHandler(this.bt_explain_Click);
            // 
            // bt_create
            // 
            this.bt_create.Location = new System.Drawing.Point(33, 30);
            this.bt_create.Name = "bt_create";
            this.bt_create.Size = new System.Drawing.Size(149, 32);
            this.bt_create.TabIndex = 0;
            this.bt_create.Text = "创建知识库";
            this.bt_create.UseVisualStyleBackColor = true;
            this.bt_create.Click += new System.EventHandler(this.bt_create_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 403);
            this.Controls.Add(this.gp_play);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Animal";
            this.gp_play.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gp_play;
        private System.Windows.Forms.Button bt_exit;
        private System.Windows.Forms.Button bt_modify;
        private System.Windows.Forms.Button bt_input;
        private System.Windows.Forms.Button bt_explain;
        private System.Windows.Forms.Button bt_create;
    }
}

