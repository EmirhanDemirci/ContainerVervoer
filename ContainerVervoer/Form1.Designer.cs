namespace ContainerVervoer
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
            this.rbStandard = new System.Windows.Forms.RadioButton();
            this.lblCount = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.rbxLog = new System.Windows.Forms.RichTextBox();
            this.LblLogMessage = new System.Windows.Forms.Label();
            this.rbCooled = new System.Windows.Forms.RadioButton();
            this.TsmiFile = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiFileReset = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblBalance = new System.Windows.Forms.Label();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblFullWeight = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.rbValuable = new System.Windows.Forms.RadioButton();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.lbContainers = new System.Windows.Forms.ListBox();
            this.lblPlace1 = new System.Windows.Forms.ListBox();
            this.lblPlace4 = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblPlace2 = new System.Windows.Forms.ListBox();
            this.lblPlace3 = new System.Windows.Forms.ListBox();
            this.lblPlace5 = new System.Windows.Forms.ListBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnBegin = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.nudContainerWeight = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblPlace6 = new System.Windows.Forms.ListBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnSet = new System.Windows.Forms.Button();
            this.ndShipWeight = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox8.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudContainerWeight)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ndShipWeight)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbStandard
            // 
            this.rbStandard.AutoSize = true;
            this.rbStandard.Location = new System.Drawing.Point(105, 58);
            this.rbStandard.Name = "rbStandard";
            this.rbStandard.Size = new System.Drawing.Size(68, 17);
            this.rbStandard.TabIndex = 20;
            this.rbStandard.TabStop = true;
            this.rbStandard.Text = "Standard";
            this.rbStandard.UseVisualStyleBackColor = true;
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(284, 204);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(19, 13);
            this.lblCount.TabIndex = 9;
            this.lblCount.Text = "00";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(6, 199);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(272, 23);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // rbxLog
            // 
            this.rbxLog.ForeColor = System.Drawing.Color.Red;
            this.rbxLog.Location = new System.Drawing.Point(6, 19);
            this.rbxLog.Name = "rbxLog";
            this.rbxLog.Size = new System.Drawing.Size(278, 204);
            this.rbxLog.TabIndex = 1;
            this.rbxLog.Text = "";
            // 
            // LblLogMessage
            // 
            this.LblLogMessage.AutoSize = true;
            this.LblLogMessage.ForeColor = System.Drawing.Color.Red;
            this.LblLogMessage.Location = new System.Drawing.Point(7, 20);
            this.LblLogMessage.Name = "LblLogMessage";
            this.LblLogMessage.Size = new System.Drawing.Size(0, 13);
            this.LblLogMessage.TabIndex = 0;
            // 
            // rbCooled
            // 
            this.rbCooled.AutoSize = true;
            this.rbCooled.Location = new System.Drawing.Point(6, 80);
            this.rbCooled.Name = "rbCooled";
            this.rbCooled.Size = new System.Drawing.Size(58, 17);
            this.rbCooled.TabIndex = 19;
            this.rbCooled.TabStop = true;
            this.rbCooled.Text = "Cooled";
            this.rbCooled.UseVisualStyleBackColor = true;
            // 
            // TsmiFile
            // 
            this.TsmiFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmiFileReset,
            this.saveToolStripMenuItem});
            this.TsmiFile.Name = "TsmiFile";
            this.TsmiFile.Size = new System.Drawing.Size(37, 20);
            this.TsmiFile.Text = "File";
            // 
            // TsmiFileReset
            // 
            this.TsmiFileReset.Name = "TsmiFileReset";
            this.TsmiFileReset.Size = new System.Drawing.Size(180, 22);
            this.TsmiFileReset.Text = "Reset";
            this.TsmiFileReset.Click += new System.EventHandler(this.TsmiFileReset_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Location = new System.Drawing.Point(541, 247);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(16, 13);
            this.lblBalance.TabIndex = 29;
            this.lblBalance.Text = "...";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // lblFullWeight
            // 
            this.lblFullWeight.AutoSize = true;
            this.lblFullWeight.Location = new System.Drawing.Point(307, 247);
            this.lblFullWeight.Name = "lblFullWeight";
            this.lblFullWeight.Size = new System.Drawing.Size(16, 13);
            this.lblFullWeight.TabIndex = 28;
            this.lblFullWeight.Text = "...";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(463, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Ship balance:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(236, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Ship weight:";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.rbxLog);
            this.groupBox8.Controls.Add(this.LblLogMessage);
            this.groupBox8.Location = new System.Drawing.Point(521, 7);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(290, 229);
            this.groupBox8.TabIndex = 24;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Log";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmiFile,
            this.aboutToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 25;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // rbValuable
            // 
            this.rbValuable.AutoSize = true;
            this.rbValuable.Location = new System.Drawing.Point(6, 58);
            this.rbValuable.Name = "rbValuable";
            this.rbValuable.Size = new System.Drawing.Size(66, 17);
            this.rbValuable.TabIndex = 10;
            this.rbValuable.TabStop = true;
            this.rbValuable.Text = "Valuable";
            this.rbValuable.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox7.Controls.Add(this.lblCount);
            this.groupBox7.Controls.Add(this.btnDelete);
            this.groupBox7.Controls.Add(this.lbContainers);
            this.groupBox7.Location = new System.Drawing.Point(206, 7);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(309, 229);
            this.groupBox7.TabIndex = 23;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Unsorted containers";
            // 
            // lbContainers
            // 
            this.lbContainers.FormattingEnabled = true;
            this.lbContainers.Location = new System.Drawing.Point(6, 19);
            this.lbContainers.Name = "lbContainers";
            this.lbContainers.Size = new System.Drawing.Size(297, 173);
            this.lbContainers.TabIndex = 7;
            // 
            // lblPlace1
            // 
            this.lblPlace1.FormattingEnabled = true;
            this.lblPlace1.Location = new System.Drawing.Point(6, 19);
            this.lblPlace1.Name = "lblPlace1";
            this.lblPlace1.Size = new System.Drawing.Size(252, 69);
            this.lblPlace1.TabIndex = 0;
            // 
            // lblPlace4
            // 
            this.lblPlace4.FormattingEnabled = true;
            this.lblPlace4.Location = new System.Drawing.Point(6, 94);
            this.lblPlace4.Name = "lblPlace4";
            this.lblPlace4.Size = new System.Drawing.Size(252, 69);
            this.lblPlace4.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblPlace2);
            this.groupBox1.Controls.Add(this.lblPlace1);
            this.groupBox1.Location = new System.Drawing.Point(6, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(264, 179);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Front ship";
            // 
            // lblPlace2
            // 
            this.lblPlace2.FormattingEnabled = true;
            this.lblPlace2.Location = new System.Drawing.Point(6, 94);
            this.lblPlace2.Name = "lblPlace2";
            this.lblPlace2.Size = new System.Drawing.Size(252, 69);
            this.lblPlace2.TabIndex = 0;
            // 
            // lblPlace3
            // 
            this.lblPlace3.FormattingEnabled = true;
            this.lblPlace3.Location = new System.Drawing.Point(6, 19);
            this.lblPlace3.Name = "lblPlace3";
            this.lblPlace3.Size = new System.Drawing.Size(252, 69);
            this.lblPlace3.TabIndex = 0;
            // 
            // lblPlace5
            // 
            this.lblPlace5.FormattingEnabled = true;
            this.lblPlace5.Location = new System.Drawing.Point(6, 19);
            this.lblPlace5.Name = "lblPlace5";
            this.lblPlace5.Size = new System.Drawing.Size(252, 69);
            this.lblPlace5.TabIndex = 3;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.rbStandard);
            this.groupBox6.Controls.Add(this.rbCooled);
            this.groupBox6.Controls.Add(this.rbValuable);
            this.groupBox6.Controls.Add(this.btnBegin);
            this.groupBox6.Controls.Add(this.btnAdd);
            this.groupBox6.Controls.Add(this.nudContainerWeight);
            this.groupBox6.Controls.Add(this.label2);
            this.groupBox6.Location = new System.Drawing.Point(-5, 102);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(205, 134);
            this.groupBox6.TabIndex = 22;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Add container";
            // 
            // btnBegin
            // 
            this.btnBegin.Location = new System.Drawing.Point(105, 104);
            this.btnBegin.Name = "btnBegin";
            this.btnBegin.Size = new System.Drawing.Size(94, 23);
            this.btnBegin.TabIndex = 18;
            this.btnBegin.Text = "Begin";
            this.btnBegin.UseVisualStyleBackColor = true;
            this.btnBegin.Click += new System.EventHandler(this.btnBegin_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(6, 104);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(94, 23);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // nudContainerWeight
            // 
            this.nudContainerWeight.Location = new System.Drawing.Point(6, 32);
            this.nudContainerWeight.Maximum = new decimal(new int[] {
            30000,
            0,
            0,
            0});
            this.nudContainerWeight.Minimum = new decimal(new int[] {
            4000,
            0,
            0,
            0});
            this.nudContainerWeight.Name = "nudContainerWeight";
            this.nudContainerWeight.Size = new System.Drawing.Size(193, 20);
            this.nudContainerWeight.TabIndex = 2;
            this.nudContainerWeight.Value = new decimal(new int[] {
            4000,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Weight in kg:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblPlace6);
            this.groupBox3.Controls.Add(this.lblPlace5);
            this.groupBox3.Location = new System.Drawing.Point(546, 18);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(264, 179);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Back ship";
            // 
            // lblPlace6
            // 
            this.lblPlace6.FormattingEnabled = true;
            this.lblPlace6.Location = new System.Drawing.Point(6, 94);
            this.lblPlace6.Name = "lblPlace6";
            this.lblPlace6.Size = new System.Drawing.Size(252, 69);
            this.lblPlace6.TabIndex = 3;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnSet);
            this.groupBox5.Controls.Add(this.ndShipWeight);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Location = new System.Drawing.Point(-5, 7);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(205, 89);
            this.groupBox5.TabIndex = 21;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Ship configuration";
            // 
            // btnSet
            // 
            this.btnSet.Location = new System.Drawing.Point(6, 59);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(193, 23);
            this.btnSet.TabIndex = 16;
            this.btnSet.Text = "Set";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // ndShipWeight
            // 
            this.ndShipWeight.Location = new System.Drawing.Point(7, 33);
            this.ndShipWeight.Maximum = new decimal(new int[] {
            900000,
            0,
            0,
            0});
            this.ndShipWeight.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.ndShipWeight.Name = "ndShipWeight";
            this.ndShipWeight.Size = new System.Drawing.Size(192, 20);
            this.ndShipWeight.TabIndex = 1;
            this.ndShipWeight.Value = new decimal(new int[] {
            900000,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Weight in kg:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.groupBox1);
            this.groupBox4.Controls.Add(this.groupBox3);
            this.groupBox4.Controls.Add(this.groupBox2);
            this.groupBox4.Location = new System.Drawing.Point(-5, 267);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(816, 203);
            this.groupBox4.TabIndex = 20;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Ship";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblPlace4);
            this.groupBox2.Controls.Add(this.lblPlace3);
            this.groupBox2.Location = new System.Drawing.Point(276, 18);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(264, 179);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Middle ship";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.lblFullWeight);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudContainerWeight)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ndShipWeight)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbStandard;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.RichTextBox rbxLog;
        private System.Windows.Forms.Label LblLogMessage;
        private System.Windows.Forms.RadioButton rbCooled;
        private System.Windows.Forms.ToolStripMenuItem TsmiFile;
        private System.Windows.Forms.ToolStripMenuItem TsmiFileReset;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Label lblFullWeight;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.RadioButton rbValuable;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.ListBox lbContainers;
        private System.Windows.Forms.ListBox lblPlace1;
        private System.Windows.Forms.ListBox lblPlace4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lblPlace2;
        private System.Windows.Forms.ListBox lblPlace3;
        private System.Windows.Forms.ListBox lblPlace5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnBegin;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.NumericUpDown nudContainerWeight;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox lblPlace6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.NumericUpDown ndShipWeight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

