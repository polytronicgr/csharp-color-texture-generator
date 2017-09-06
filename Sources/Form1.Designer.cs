namespace csharp_color_texture_generator
{
	partial class Form1
	{
		/// <summary>
		/// 必要なデザイナー変数です。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 使用中のリソースをすべてクリーンアップします。
		/// </summary>
		/// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows フォーム デザイナーで生成されたコード

		/// <summary>
		/// デザイナー サポートに必要なメソッドです。このメソッドの内容を
		/// コード エディターで変更しないでください。
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.textBox_R = new System.Windows.Forms.TextBox();
			this.textBox_G = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox_B = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.button_Generate = new System.Windows.Forms.Button();
			this.textBox_Width = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.textBox_Height = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.textBox_TaskCount = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(11, 65);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(13, 12);
			this.label1.TabIndex = 4;
			this.label1.Text = "R";
			// 
			// textBox_R
			// 
			this.textBox_R.Location = new System.Drawing.Point(59, 62);
			this.textBox_R.Name = "textBox_R";
			this.textBox_R.Size = new System.Drawing.Size(100, 19);
			this.textBox_R.TabIndex = 5;
			this.textBox_R.Text = "5";
			// 
			// textBox_G
			// 
			this.textBox_G.Location = new System.Drawing.Point(59, 87);
			this.textBox_G.Name = "textBox_G";
			this.textBox_G.Size = new System.Drawing.Size(100, 19);
			this.textBox_G.TabIndex = 7;
			this.textBox_G.Text = "5";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(11, 90);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(13, 12);
			this.label2.TabIndex = 6;
			this.label2.Text = "G";
			// 
			// textBox_B
			// 
			this.textBox_B.Location = new System.Drawing.Point(59, 112);
			this.textBox_B.Name = "textBox_B";
			this.textBox_B.Size = new System.Drawing.Size(100, 19);
			this.textBox_B.TabIndex = 9;
			this.textBox_B.Text = "5";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(11, 115);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(13, 12);
			this.label3.TabIndex = 8;
			this.label3.Text = "B";
			// 
			// button_Generate
			// 
			this.button_Generate.Location = new System.Drawing.Point(84, 162);
			this.button_Generate.Name = "button_Generate";
			this.button_Generate.Size = new System.Drawing.Size(75, 23);
			this.button_Generate.TabIndex = 12;
			this.button_Generate.Text = "生成";
			this.button_Generate.UseVisualStyleBackColor = true;
			this.button_Generate.Click += new System.EventHandler(this.button_Generate_Click);
			// 
			// textBox_Width
			// 
			this.textBox_Width.Location = new System.Drawing.Point(59, 12);
			this.textBox_Width.Name = "textBox_Width";
			this.textBox_Width.Size = new System.Drawing.Size(100, 19);
			this.textBox_Width.TabIndex = 1;
			this.textBox_Width.Text = "256";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(11, 15);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(17, 12);
			this.label4.TabIndex = 0;
			this.label4.Text = "幅";
			// 
			// textBox_Height
			// 
			this.textBox_Height.Location = new System.Drawing.Point(59, 37);
			this.textBox_Height.Name = "textBox_Height";
			this.textBox_Height.Size = new System.Drawing.Size(100, 19);
			this.textBox_Height.TabIndex = 3;
			this.textBox_Height.Text = "128";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(11, 40);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(25, 12);
			this.label5.TabIndex = 2;
			this.label5.Text = "高さ";
			// 
			// textBox_TaskCount
			// 
			this.textBox_TaskCount.Location = new System.Drawing.Point(59, 137);
			this.textBox_TaskCount.Name = "textBox_TaskCount";
			this.textBox_TaskCount.Size = new System.Drawing.Size(100, 19);
			this.textBox_TaskCount.TabIndex = 11;
			this.textBox_TaskCount.Text = "16";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(11, 140);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(42, 12);
			this.label6.TabIndex = 10;
			this.label6.Text = "タスク数";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 262);
			this.Controls.Add(this.textBox_TaskCount);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.textBox_Height);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.textBox_Width);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.button_Generate);
			this.Controls.Add(this.textBox_B);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textBox_G);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBox_R);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox_R;
		private System.Windows.Forms.TextBox textBox_G;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox_B;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button button_Generate;
		private System.Windows.Forms.TextBox textBox_Width;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBox_Height;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBox_TaskCount;
		private System.Windows.Forms.Label label6;
	}
}

