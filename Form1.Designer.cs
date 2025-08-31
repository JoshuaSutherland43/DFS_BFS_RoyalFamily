namespace Prog_IceTask3
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
            this.tvOutput = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearchMember = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUnderParent = new System.Windows.Forms.TextBox();
            this.txtAddChild = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bfsOutput = new System.Windows.Forms.Label();
            this.dfsOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tvOutput
            // 
            this.tvOutput.Location = new System.Drawing.Point(114, 12);
            this.tvOutput.Name = "tvOutput";
            this.tvOutput.Size = new System.Drawing.Size(1112, 552);
            this.tvOutput.TabIndex = 0;
            this.tvOutput.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvOutput_AfterSelect);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(125, 587);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search a Member:";
            // 
            // txtSearchMember
            // 
            this.txtSearchMember.Location = new System.Drawing.Point(305, 587);
            this.txtSearchMember.Multiline = true;
            this.txtSearchMember.Name = "txtSearchMember";
            this.txtSearchMember.Size = new System.Drawing.Size(389, 25);
            this.txtSearchMember.TabIndex = 2;
            this.txtSearchMember.TextChanged += new System.EventHandler(this.txtSearchMember_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(774, 587);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Under Parent:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(803, 649);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Add Child:";
            // 
            // txtUnderParent
            // 
            this.txtUnderParent.Location = new System.Drawing.Point(913, 587);
            this.txtUnderParent.Multiline = true;
            this.txtUnderParent.Name = "txtUnderParent";
            this.txtUnderParent.Size = new System.Drawing.Size(304, 25);
            this.txtUnderParent.TabIndex = 5;
            this.txtUnderParent.TextChanged += new System.EventHandler(this.txtUnderParent_TextChanged);
            // 
            // txtAddChild
            // 
            this.txtAddChild.Location = new System.Drawing.Point(913, 649);
            this.txtAddChild.Multiline = true;
            this.txtAddChild.Name = "txtAddChild";
            this.txtAddChild.Size = new System.Drawing.Size(304, 25);
            this.txtAddChild.TabIndex = 6;
            this.txtAddChild.TextChanged += new System.EventHandler(this.txtAddChild_TextChanged);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.Location = new System.Drawing.Point(346, 638);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(305, 50);
            this.btnGenerate.TabIndex = 7;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1258, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "BFS Score:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1258, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "DFS Scrore:";
            // 
            // bfsOutput
            // 
            this.bfsOutput.AutoSize = true;
            this.bfsOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bfsOutput.Location = new System.Drawing.Point(1415, 146);
            this.bfsOutput.Name = "bfsOutput";
            this.bfsOutput.Size = new System.Drawing.Size(23, 25);
            this.bfsOutput.TabIndex = 10;
            this.bfsOutput.Text = "0";
            this.bfsOutput.Click += new System.EventHandler(this.bfsOutput_Click);
            // 
            // dfsOutput
            // 
            this.dfsOutput.AutoSize = true;
            this.dfsOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dfsOutput.Location = new System.Drawing.Point(1420, 245);
            this.dfsOutput.Name = "dfsOutput";
            this.dfsOutput.Size = new System.Drawing.Size(23, 25);
            this.dfsOutput.TabIndex = 11;
            this.dfsOutput.Text = "0";
            this.dfsOutput.Click += new System.EventHandler(this.dfsOutput_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1565, 705);
            this.Controls.Add(this.dfsOutput);
            this.Controls.Add(this.bfsOutput);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.txtAddChild);
            this.Controls.Add(this.txtUnderParent);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSearchMember);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tvOutput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView tvOutput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearchMember;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUnderParent;
        private System.Windows.Forms.TextBox txtAddChild;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label bfsOutput;
        private System.Windows.Forms.Label dfsOutput;
    }
}

