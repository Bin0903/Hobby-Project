namespace Animal
{
    partial class GoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GoForm));
            this.bt_input = new System.Windows.Forms.Button();
            this.tb_shape = new System.Windows.Forms.TextBox();
            this.lb_shape = new System.Windows.Forms.Label();
            this.rtb_shape = new System.Windows.Forms.RichTextBox();
            this.bt_go = new System.Windows.Forms.Button();
            this.gb_shape = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rtb_res = new System.Windows.Forms.RichTextBox();
            this.bt_empty = new System.Windows.Forms.Button();
            this.gb_shape.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_input
            // 
            resources.ApplyResources(this.bt_input, "bt_input");
            this.bt_input.Name = "bt_input";
            this.bt_input.UseVisualStyleBackColor = true;
            this.bt_input.Click += new System.EventHandler(this.bt_input_Click);
            // 
            // tb_shape
            // 
            resources.ApplyResources(this.tb_shape, "tb_shape");
            this.tb_shape.Name = "tb_shape";
            // 
            // lb_shape
            // 
            resources.ApplyResources(this.lb_shape, "lb_shape");
            this.lb_shape.Name = "lb_shape";
            // 
            // rtb_shape
            // 
            resources.ApplyResources(this.rtb_shape, "rtb_shape");
            this.rtb_shape.Name = "rtb_shape";
            // 
            // bt_go
            // 
            resources.ApplyResources(this.bt_go, "bt_go");
            this.bt_go.Name = "bt_go";
            this.bt_go.UseVisualStyleBackColor = true;
            this.bt_go.Click += new System.EventHandler(this.bt_go_Click);
            // 
            // gb_shape
            // 
            this.gb_shape.Controls.Add(this.rtb_shape);
            resources.ApplyResources(this.gb_shape, "gb_shape");
            this.gb_shape.Name = "gb_shape";
            this.gb_shape.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rtb_res);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // rtb_res
            // 
            resources.ApplyResources(this.rtb_res, "rtb_res");
            this.rtb_res.Name = "rtb_res";
            // 
            // bt_empty
            // 
            resources.ApplyResources(this.bt_empty, "bt_empty");
            this.bt_empty.Name = "bt_empty";
            this.bt_empty.UseVisualStyleBackColor = true;
            this.bt_empty.Click += new System.EventHandler(this.button1_Click);
            // 
            // GoForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bt_empty);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gb_shape);
            this.Controls.Add(this.bt_go);
            this.Controls.Add(this.lb_shape);
            this.Controls.Add(this.tb_shape);
            this.Controls.Add(this.bt_input);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GoForm";
            this.Load += new System.EventHandler(this.GoForm_Load);
            this.gb_shape.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_input;
        private System.Windows.Forms.TextBox tb_shape;
        private System.Windows.Forms.Label lb_shape;
        private System.Windows.Forms.RichTextBox rtb_shape;
        private System.Windows.Forms.Button bt_go;
        private System.Windows.Forms.GroupBox gb_shape;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox rtb_res;
        private System.Windows.Forms.Button bt_empty;
    }
}