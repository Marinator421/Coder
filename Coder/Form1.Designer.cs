namespace Coder
{
    partial class ZcoderForm
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ZcoderForm));
            this.ContainerMain = new System.Windows.Forms.SplitContainer();
            this.EncodeBox1 = new System.Windows.Forms.GroupBox();
            this.ContainerEncode = new System.Windows.Forms.SplitContainer();
            this.EncodeIntputBox = new System.Windows.Forms.GroupBox();
            this.TextEncodeInput = new System.Windows.Forms.RichTextBox();
            this.EncodeOutputBox = new System.Windows.Forms.GroupBox();
            this.TextEncodeOutput = new System.Windows.Forms.RichTextBox();
            this.ContainerMainRight = new System.Windows.Forms.SplitContainer();
            this.ContainerKeys = new System.Windows.Forms.SplitContainer();
            this.EncodeButton1 = new System.Windows.Forms.Button();
            this.KeyBox3 = new System.Windows.Forms.GroupBox();
            this.KeyThirdBox6 = new System.Windows.Forms.GroupBox();
            this.NumThird = new System.Windows.Forms.NumericUpDown();
            this.KeySecondBox5 = new System.Windows.Forms.GroupBox();
            this.NumSecond = new System.Windows.Forms.NumericUpDown();
            this.KeyFirstBox4 = new System.Windows.Forms.GroupBox();
            this.NumFirst = new System.Windows.Forms.NumericUpDown();
            this.DecodeButton2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ContainerMain)).BeginInit();
            this.ContainerMain.Panel1.SuspendLayout();
            this.ContainerMain.Panel2.SuspendLayout();
            this.ContainerMain.SuspendLayout();
            this.EncodeBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ContainerEncode)).BeginInit();
            this.ContainerEncode.Panel1.SuspendLayout();
            this.ContainerEncode.Panel2.SuspendLayout();
            this.ContainerEncode.SuspendLayout();
            this.EncodeIntputBox.SuspendLayout();
            this.EncodeOutputBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ContainerMainRight)).BeginInit();
            this.ContainerMainRight.Panel1.SuspendLayout();
            this.ContainerMainRight.Panel2.SuspendLayout();
            this.ContainerMainRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ContainerKeys)).BeginInit();
            this.ContainerKeys.Panel1.SuspendLayout();
            this.ContainerKeys.Panel2.SuspendLayout();
            this.ContainerKeys.SuspendLayout();
            this.KeyBox3.SuspendLayout();
            this.KeyThirdBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumThird)).BeginInit();
            this.KeySecondBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumSecond)).BeginInit();
            this.KeyFirstBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumFirst)).BeginInit();
            this.SuspendLayout();
            // 
            // ContainerMain
            // 
            this.ContainerMain.BackColor = System.Drawing.Color.Black;
            this.ContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContainerMain.Location = new System.Drawing.Point(0, 0);
            this.ContainerMain.Name = "ContainerMain";
            // 
            // ContainerMain.Panel1
            // 
            this.ContainerMain.Panel1.Controls.Add(this.EncodeBox1);
            // 
            // ContainerMain.Panel2
            // 
            this.ContainerMain.Panel2.Controls.Add(this.ContainerMainRight);
            this.ContainerMain.Size = new System.Drawing.Size(860, 534);
            this.ContainerMain.SplitterDistance = 618;
            this.ContainerMain.TabIndex = 0;
            // 
            // EncodeBox1
            // 
            this.EncodeBox1.BackColor = System.Drawing.Color.White;
            this.EncodeBox1.Controls.Add(this.ContainerEncode);
            this.EncodeBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EncodeBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EncodeBox1.Location = new System.Drawing.Point(0, 0);
            this.EncodeBox1.Name = "EncodeBox1";
            this.EncodeBox1.Size = new System.Drawing.Size(618, 534);
            this.EncodeBox1.TabIndex = 2;
            this.EncodeBox1.TabStop = false;
            this.EncodeBox1.Text = "Definetly the best encoding algorithm";
            // 
            // ContainerEncode
            // 
            this.ContainerEncode.BackColor = System.Drawing.Color.Black;
            this.ContainerEncode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContainerEncode.Location = new System.Drawing.Point(3, 27);
            this.ContainerEncode.Name = "ContainerEncode";
            this.ContainerEncode.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // ContainerEncode.Panel1
            // 
            this.ContainerEncode.Panel1.Controls.Add(this.EncodeIntputBox);
            // 
            // ContainerEncode.Panel2
            // 
            this.ContainerEncode.Panel2.Controls.Add(this.EncodeOutputBox);
            this.ContainerEncode.Size = new System.Drawing.Size(612, 504);
            this.ContainerEncode.SplitterDistance = 250;
            this.ContainerEncode.TabIndex = 0;
            // 
            // EncodeIntputBox
            // 
            this.EncodeIntputBox.BackColor = System.Drawing.Color.DarkGray;
            this.EncodeIntputBox.Controls.Add(this.TextEncodeInput);
            this.EncodeIntputBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EncodeIntputBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EncodeIntputBox.Location = new System.Drawing.Point(0, 0);
            this.EncodeIntputBox.Name = "EncodeIntputBox";
            this.EncodeIntputBox.Size = new System.Drawing.Size(612, 250);
            this.EncodeIntputBox.TabIndex = 0;
            this.EncodeIntputBox.TabStop = false;
            this.EncodeIntputBox.Text = "Input";
            // 
            // TextEncodeInput
            // 
            this.TextEncodeInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextEncodeInput.Location = new System.Drawing.Point(3, 18);
            this.TextEncodeInput.Name = "TextEncodeInput";
            this.TextEncodeInput.Size = new System.Drawing.Size(606, 229);
            this.TextEncodeInput.TabIndex = 0;
            this.TextEncodeInput.Text = "";
            // 
            // EncodeOutputBox
            // 
            this.EncodeOutputBox.BackColor = System.Drawing.Color.DarkGray;
            this.EncodeOutputBox.Controls.Add(this.TextEncodeOutput);
            this.EncodeOutputBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EncodeOutputBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EncodeOutputBox.Location = new System.Drawing.Point(0, 0);
            this.EncodeOutputBox.Name = "EncodeOutputBox";
            this.EncodeOutputBox.Size = new System.Drawing.Size(612, 250);
            this.EncodeOutputBox.TabIndex = 1;
            this.EncodeOutputBox.TabStop = false;
            this.EncodeOutputBox.Text = "Output";
            // 
            // TextEncodeOutput
            // 
            this.TextEncodeOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextEncodeOutput.Location = new System.Drawing.Point(3, 18);
            this.TextEncodeOutput.Name = "TextEncodeOutput";
            this.TextEncodeOutput.ReadOnly = true;
            this.TextEncodeOutput.Size = new System.Drawing.Size(606, 229);
            this.TextEncodeOutput.TabIndex = 1;
            this.TextEncodeOutput.Text = "";
            // 
            // ContainerMainRight
            // 
            this.ContainerMainRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContainerMainRight.Location = new System.Drawing.Point(0, 0);
            this.ContainerMainRight.Name = "ContainerMainRight";
            this.ContainerMainRight.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // ContainerMainRight.Panel1
            // 
            this.ContainerMainRight.Panel1.Controls.Add(this.ContainerKeys);
            // 
            // ContainerMainRight.Panel2
            // 
            this.ContainerMainRight.Panel2.Controls.Add(this.DecodeButton2);
            this.ContainerMainRight.Size = new System.Drawing.Size(238, 534);
            this.ContainerMainRight.SplitterDistance = 435;
            this.ContainerMainRight.TabIndex = 0;
            // 
            // ContainerKeys
            // 
            this.ContainerKeys.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContainerKeys.Location = new System.Drawing.Point(0, 0);
            this.ContainerKeys.Name = "ContainerKeys";
            this.ContainerKeys.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // ContainerKeys.Panel1
            // 
            this.ContainerKeys.Panel1.Controls.Add(this.EncodeButton1);
            // 
            // ContainerKeys.Panel2
            // 
            this.ContainerKeys.Panel2.Controls.Add(this.KeyBox3);
            this.ContainerKeys.Size = new System.Drawing.Size(238, 435);
            this.ContainerKeys.SplitterDistance = 101;
            this.ContainerKeys.TabIndex = 0;
            // 
            // EncodeButton1
            // 
            this.EncodeButton1.BackColor = System.Drawing.Color.DimGray;
            this.EncodeButton1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EncodeButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EncodeButton1.Location = new System.Drawing.Point(0, 0);
            this.EncodeButton1.Name = "EncodeButton1";
            this.EncodeButton1.Size = new System.Drawing.Size(238, 101);
            this.EncodeButton1.TabIndex = 1;
            this.EncodeButton1.Text = "Encode";
            this.EncodeButton1.UseVisualStyleBackColor = false;
            this.EncodeButton1.Click += new System.EventHandler(this.Encode);
            // 
            // KeyBox3
            // 
            this.KeyBox3.BackColor = System.Drawing.Color.DarkGray;
            this.KeyBox3.Controls.Add(this.KeyThirdBox6);
            this.KeyBox3.Controls.Add(this.KeySecondBox5);
            this.KeyBox3.Controls.Add(this.KeyFirstBox4);
            this.KeyBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.KeyBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.KeyBox3.Location = new System.Drawing.Point(0, 0);
            this.KeyBox3.Name = "KeyBox3";
            this.KeyBox3.Size = new System.Drawing.Size(238, 330);
            this.KeyBox3.TabIndex = 1;
            this.KeyBox3.TabStop = false;
            this.KeyBox3.Text = "Keys";
            // 
            // KeyThirdBox6
            // 
            this.KeyThirdBox6.BackColor = System.Drawing.Color.DarkGray;
            this.KeyThirdBox6.Controls.Add(this.NumThird);
            this.KeyThirdBox6.Dock = System.Windows.Forms.DockStyle.Top;
            this.KeyThirdBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.KeyThirdBox6.Location = new System.Drawing.Point(3, 227);
            this.KeyThirdBox6.Name = "KeyThirdBox6";
            this.KeyThirdBox6.Size = new System.Drawing.Size(232, 100);
            this.KeyThirdBox6.TabIndex = 2;
            this.KeyThirdBox6.TabStop = false;
            this.KeyThirdBox6.Text = "Third";
            // 
            // NumThird
            // 
            this.NumThird.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NumThird.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NumThird.Location = new System.Drawing.Point(3, 25);
            this.NumThird.Name = "NumThird";
            this.NumThird.Size = new System.Drawing.Size(226, 44);
            this.NumThird.TabIndex = 1;
            // 
            // KeySecondBox5
            // 
            this.KeySecondBox5.BackColor = System.Drawing.Color.DarkGray;
            this.KeySecondBox5.Controls.Add(this.NumSecond);
            this.KeySecondBox5.Dock = System.Windows.Forms.DockStyle.Top;
            this.KeySecondBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.KeySecondBox5.Location = new System.Drawing.Point(3, 127);
            this.KeySecondBox5.Name = "KeySecondBox5";
            this.KeySecondBox5.Size = new System.Drawing.Size(232, 100);
            this.KeySecondBox5.TabIndex = 1;
            this.KeySecondBox5.TabStop = false;
            this.KeySecondBox5.Text = "Second";
            // 
            // NumSecond
            // 
            this.NumSecond.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NumSecond.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NumSecond.Location = new System.Drawing.Point(3, 25);
            this.NumSecond.Name = "NumSecond";
            this.NumSecond.Size = new System.Drawing.Size(226, 44);
            this.NumSecond.TabIndex = 1;
            // 
            // KeyFirstBox4
            // 
            this.KeyFirstBox4.BackColor = System.Drawing.Color.DarkGray;
            this.KeyFirstBox4.Controls.Add(this.NumFirst);
            this.KeyFirstBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.KeyFirstBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.KeyFirstBox4.Location = new System.Drawing.Point(3, 27);
            this.KeyFirstBox4.Name = "KeyFirstBox4";
            this.KeyFirstBox4.Size = new System.Drawing.Size(232, 100);
            this.KeyFirstBox4.TabIndex = 0;
            this.KeyFirstBox4.TabStop = false;
            this.KeyFirstBox4.Text = "First";
            // 
            // NumFirst
            // 
            this.NumFirst.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NumFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NumFirst.Location = new System.Drawing.Point(3, 25);
            this.NumFirst.Name = "NumFirst";
            this.NumFirst.Size = new System.Drawing.Size(226, 44);
            this.NumFirst.TabIndex = 0;
            // 
            // DecodeButton2
            // 
            this.DecodeButton2.BackColor = System.Drawing.Color.DimGray;
            this.DecodeButton2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DecodeButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DecodeButton2.Location = new System.Drawing.Point(0, 0);
            this.DecodeButton2.Name = "DecodeButton2";
            this.DecodeButton2.Size = new System.Drawing.Size(238, 95);
            this.DecodeButton2.TabIndex = 0;
            this.DecodeButton2.Text = "Decode";
            this.DecodeButton2.UseVisualStyleBackColor = false;
            this.DecodeButton2.Click += new System.EventHandler(this.Decode);
            // 
            // ZcoderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 534);
            this.Controls.Add(this.ContainerMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ZcoderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Coder";
            this.ContainerMain.Panel1.ResumeLayout(false);
            this.ContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ContainerMain)).EndInit();
            this.ContainerMain.ResumeLayout(false);
            this.EncodeBox1.ResumeLayout(false);
            this.ContainerEncode.Panel1.ResumeLayout(false);
            this.ContainerEncode.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ContainerEncode)).EndInit();
            this.ContainerEncode.ResumeLayout(false);
            this.EncodeIntputBox.ResumeLayout(false);
            this.EncodeOutputBox.ResumeLayout(false);
            this.ContainerMainRight.Panel1.ResumeLayout(false);
            this.ContainerMainRight.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ContainerMainRight)).EndInit();
            this.ContainerMainRight.ResumeLayout(false);
            this.ContainerKeys.Panel1.ResumeLayout(false);
            this.ContainerKeys.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ContainerKeys)).EndInit();
            this.ContainerKeys.ResumeLayout(false);
            this.KeyBox3.ResumeLayout(false);
            this.KeyThirdBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NumThird)).EndInit();
            this.KeySecondBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NumSecond)).EndInit();
            this.KeyFirstBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NumFirst)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer ContainerMain;
        private System.Windows.Forms.SplitContainer ContainerMainRight;
        private System.Windows.Forms.Button DecodeButton2;
        private System.Windows.Forms.SplitContainer ContainerKeys;
        private System.Windows.Forms.Button EncodeButton1;
        private System.Windows.Forms.GroupBox KeyBox3;
        private System.Windows.Forms.GroupBox KeyThirdBox6;
        private System.Windows.Forms.NumericUpDown NumThird;
        private System.Windows.Forms.GroupBox KeySecondBox5;
        private System.Windows.Forms.NumericUpDown NumSecond;
        private System.Windows.Forms.GroupBox KeyFirstBox4;
        private System.Windows.Forms.NumericUpDown NumFirst;
        private System.Windows.Forms.GroupBox EncodeBox1;
        private System.Windows.Forms.SplitContainer ContainerEncode;
        private System.Windows.Forms.GroupBox EncodeIntputBox;
        private System.Windows.Forms.RichTextBox TextEncodeInput;
        private System.Windows.Forms.GroupBox EncodeOutputBox;
        private System.Windows.Forms.RichTextBox TextEncodeOutput;
    }
}

