using System.Windows.Forms;

namespace Calculator
{
    partial class Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            this.button30 = new System.Windows.Forms.Button();
            this.display = new System.Windows.Forms.TextBox();
            this.button29 = new System.Windows.Forms.Button();
            this.button27 = new System.Windows.Forms.Button();
            this.button26 = new System.Windows.Forms.Button();
            this.button25 = new System.Windows.Forms.Button();
            this.button28 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button31 = new System.Windows.Forms.Button();
            this.button32 = new System.Windows.Forms.Button();
            this.button33 = new System.Windows.Forms.Button();
            this.buttonResult = new System.Windows.Forms.Button();
            this.button35 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.equation = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button30
            // 
            this.button30.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.button30.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button30.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.button30.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button30.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button30.ForeColor = System.Drawing.Color.Black;
            this.button30.Image = ((System.Drawing.Image)(resources.GetObject("button30.Image")));
            this.button30.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button30.Location = new System.Drawing.Point(220, 133);
            this.button30.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button30.Name = "button30";
            this.button30.Size = new System.Drawing.Size(68, 39);
            this.button30.TabIndex = 101;
            this.button30.UseVisualStyleBackColor = true;
            this.button30.Click += new System.EventHandler(this.backspace);
            // 
            // display
            // 
            this.display.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.display.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.display.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.display.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.display.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.display.ForeColor = System.Drawing.Color.Black;
            this.display.Location = new System.Drawing.Point(0, 72);
            this.display.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.display.Multiline = true;
            this.display.Name = "display";
            this.display.ReadOnly = true;
            this.display.Size = new System.Drawing.Size(288, 62);
            this.display.TabIndex = 98;
            this.display.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button29
            // 
            this.button29.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.button29.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.button29.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button29.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button29.ForeColor = System.Drawing.Color.Black;
            this.button29.Location = new System.Drawing.Point(184, 134);
            this.button29.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button29.Name = "button29";
            this.button29.Size = new System.Drawing.Size(46, 38);
            this.button29.TabIndex = 97;
            this.button29.Text = "MS";
            this.button29.UseVisualStyleBackColor = false;
            this.button29.Click += new System.EventHandler(this.MemoryClicked);
            // 
            // button27
            // 
            this.button27.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.button27.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.button27.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button27.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button27.ForeColor = System.Drawing.Color.Black;
            this.button27.Location = new System.Drawing.Point(138, 134);
            this.button27.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button27.Name = "button27";
            this.button27.Size = new System.Drawing.Size(46, 38);
            this.button27.TabIndex = 96;
            this.button27.Text = "M-";
            this.button27.UseVisualStyleBackColor = false;
            this.button27.Click += new System.EventHandler(this.MemoryClicked);
            // 
            // button26
            // 
            this.button26.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.button26.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.button26.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button26.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button26.ForeColor = System.Drawing.Color.Black;
            this.button26.Location = new System.Drawing.Point(92, 134);
            this.button26.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(46, 38);
            this.button26.TabIndex = 95;
            this.button26.Text = "M+";
            this.button26.UseVisualStyleBackColor = false;
            this.button26.Click += new System.EventHandler(this.MemoryClicked);
            // 
            // button25
            // 
            this.button25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.button25.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.button25.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button25.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button25.ForeColor = System.Drawing.Color.Black;
            this.button25.Location = new System.Drawing.Point(46, 134);
            this.button25.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(46, 38);
            this.button25.TabIndex = 94;
            this.button25.Text = "MR";
            this.button25.UseVisualStyleBackColor = false;
            this.button25.Click += new System.EventHandler(this.MemoryClicked);
            // 
            // button28
            // 
            this.button28.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.button28.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.button28.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button28.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button28.ForeColor = System.Drawing.Color.Black;
            this.button28.Location = new System.Drawing.Point(0, 134);
            this.button28.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button28.Name = "button28";
            this.button28.Size = new System.Drawing.Size(46, 38);
            this.button28.TabIndex = 93;
            this.button28.Text = "MC";
            this.button28.UseVisualStyleBackColor = false;
            this.button28.Click += new System.EventHandler(this.MemoryClicked);
            // 
            // button21
            // 
            this.button21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.button21.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.button21.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button21.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button21.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button21.ForeColor = System.Drawing.Color.Black;
            this.button21.Location = new System.Drawing.Point(144, 173);
            this.button21.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(72, 53);
            this.button21.TabIndex = 92;
            this.button21.Text = "x²";
            this.button21.UseVisualStyleBackColor = false;
            this.button21.Click += new System.EventHandler(this.operator_click);
            // 
            // button22
            // 
            this.button22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.button22.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.button22.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button22.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button22.ForeColor = System.Drawing.Color.Black;
            this.button22.Location = new System.Drawing.Point(72, 173);
            this.button22.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(72, 53);
            this.button22.TabIndex = 90;
            this.button22.Text = "√";
            this.button22.UseVisualStyleBackColor = false;
            this.button22.Click += new System.EventHandler(this.operator_click);
            // 
            // button23
            // 
            this.button23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.button23.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.button23.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button23.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button23.ForeColor = System.Drawing.Color.Black;
            this.button23.Location = new System.Drawing.Point(216, 173);
            this.button23.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(72, 53);
            this.button23.TabIndex = 91;
            this.button23.Text = "1/x";
            this.button23.UseVisualStyleBackColor = false;
            this.button23.Click += new System.EventHandler(this.operator_click);
            // 
            // button24
            // 
            this.button24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.button24.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.button24.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button24.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button24.ForeColor = System.Drawing.Color.Black;
            this.button24.Location = new System.Drawing.Point(0, 173);
            this.button24.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(72, 53);
            this.button24.TabIndex = 89;
            this.button24.Text = "%";
            this.button24.UseVisualStyleBackColor = false;
            this.button24.Click += new System.EventHandler(this.operator_click);
            // 
            // button17
            // 
            this.button17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.button17.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.button17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button17.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button17.ForeColor = System.Drawing.Color.Black;
            this.button17.Location = new System.Drawing.Point(144, 226);
            this.button17.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(72, 53);
            this.button17.TabIndex = 88;
            this.button17.Text = "!";
            this.button17.UseVisualStyleBackColor = false;
            this.button17.Click += new System.EventHandler(this.operator_click);
            // 
            // button18
            // 
            this.button18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.button18.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.button18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button18.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button18.ForeColor = System.Drawing.Color.Black;
            this.button18.Location = new System.Drawing.Point(72, 226);
            this.button18.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(72, 53);
            this.button18.TabIndex = 86;
            this.button18.Text = "C";
            this.button18.UseVisualStyleBackColor = false;
            this.button18.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // button19
            // 
            this.button19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.button19.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.button19.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button19.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button19.ForeColor = System.Drawing.Color.Black;
            this.button19.Location = new System.Drawing.Point(216, 226);
            this.button19.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(72, 53);
            this.button19.TabIndex = 87;
            this.button19.Text = "÷";
            this.button19.UseVisualStyleBackColor = false;
            this.button19.Click += new System.EventHandler(this.operator_click);
            // 
            // button20
            // 
            this.button20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.button20.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.button20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button20.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button20.ForeColor = System.Drawing.Color.Black;
            this.button20.Location = new System.Drawing.Point(0, 226);
            this.button20.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(72, 53);
            this.button20.TabIndex = 85;
            this.button20.Text = "CE";
            this.button20.UseVisualStyleBackColor = false;
            this.button20.Click += new System.EventHandler(this.buttonCE_Click);
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.button13.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button13.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button13.ForeColor = System.Drawing.Color.Black;
            this.button13.Location = new System.Drawing.Point(144, 279);
            this.button13.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(72, 53);
            this.button13.TabIndex = 84;
            this.button13.Text = "9";
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.button_click);
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.button14.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button14.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button14.ForeColor = System.Drawing.Color.Black;
            this.button14.Location = new System.Drawing.Point(72, 279);
            this.button14.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(72, 53);
            this.button14.TabIndex = 82;
            this.button14.Text = "8";
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Click += new System.EventHandler(this.button_click);
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.button15.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button15.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button15.ForeColor = System.Drawing.Color.Black;
            this.button15.Location = new System.Drawing.Point(216, 279);
            this.button15.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(72, 53);
            this.button15.TabIndex = 83;
            this.button15.Text = "×";
            this.button15.UseVisualStyleBackColor = false;
            this.button15.Click += new System.EventHandler(this.operator_click);
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.button16.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.button16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button16.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button16.ForeColor = System.Drawing.Color.Black;
            this.button16.Location = new System.Drawing.Point(0, 279);
            this.button16.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(72, 53);
            this.button16.TabIndex = 81;
            this.button16.Text = "7";
            this.button16.UseVisualStyleBackColor = false;
            this.button16.Click += new System.EventHandler(this.button_click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.button9.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button9.ForeColor = System.Drawing.Color.Black;
            this.button9.Location = new System.Drawing.Point(144, 332);
            this.button9.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(72, 53);
            this.button9.TabIndex = 80;
            this.button9.Text = "6";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button_click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.button10.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button10.ForeColor = System.Drawing.Color.Black;
            this.button10.Location = new System.Drawing.Point(72, 332);
            this.button10.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(72, 53);
            this.button10.TabIndex = 78;
            this.button10.Text = "5";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button_click);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.button11.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button11.ForeColor = System.Drawing.Color.Black;
            this.button11.Location = new System.Drawing.Point(216, 332);
            this.button11.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(72, 53);
            this.button11.TabIndex = 79;
            this.button11.Text = "-";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.operator_click);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.button12.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button12.ForeColor = System.Drawing.Color.Black;
            this.button12.Location = new System.Drawing.Point(0, 332);
            this.button12.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(72, 53);
            this.button12.TabIndex = 77;
            this.button12.Text = "4";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.button_click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.button6.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.ForeColor = System.Drawing.Color.Black;
            this.button6.Location = new System.Drawing.Point(144, 385);
            this.button6.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(72, 53);
            this.button6.TabIndex = 76;
            this.button6.Text = "3";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button_click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.button7.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button7.ForeColor = System.Drawing.Color.Black;
            this.button7.Location = new System.Drawing.Point(72, 385);
            this.button7.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(72, 53);
            this.button7.TabIndex = 74;
            this.button7.Text = "2";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button_click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.button8.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button8.ForeColor = System.Drawing.Color.Black;
            this.button8.Location = new System.Drawing.Point(216, 385);
            this.button8.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(72, 53);
            this.button8.TabIndex = 75;
            this.button8.Text = "+";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.operator_click);
            // 
            // button31
            // 
            this.button31.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.button31.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.button31.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button31.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button31.ForeColor = System.Drawing.Color.Black;
            this.button31.Location = new System.Drawing.Point(0, 385);
            this.button31.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button31.Name = "button31";
            this.button31.Size = new System.Drawing.Size(72, 53);
            this.button31.TabIndex = 73;
            this.button31.Text = "1";
            this.button31.UseVisualStyleBackColor = false;
            this.button31.Click += new System.EventHandler(this.button_click);
            // 
            // button32
            // 
            this.button32.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.button32.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.button32.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button32.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button32.ForeColor = System.Drawing.Color.Black;
            this.button32.Location = new System.Drawing.Point(144, 438);
            this.button32.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button32.Name = "button32";
            this.button32.Size = new System.Drawing.Size(72, 53);
            this.button32.TabIndex = 72;
            this.button32.Text = ",";
            this.button32.UseVisualStyleBackColor = false;
            this.button32.Click += new System.EventHandler(this.button_click);
            // 
            // button33
            // 
            this.button33.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.button33.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.button33.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button33.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button33.ForeColor = System.Drawing.Color.Black;
            this.button33.Location = new System.Drawing.Point(72, 438);
            this.button33.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button33.Name = "button33";
            this.button33.Size = new System.Drawing.Size(72, 53);
            this.button33.TabIndex = 71;
            this.button33.Text = "0";
            this.button33.UseVisualStyleBackColor = false;
            this.button33.Click += new System.EventHandler(this.button_click);
            // 
            // buttonResult
            // 
            this.buttonResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.buttonResult.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.buttonResult.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(131)))), ((int)(((byte)(204)))));
            this.buttonResult.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(131)))), ((int)(((byte)(204)))));
            this.buttonResult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonResult.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonResult.ForeColor = System.Drawing.Color.Black;
            this.buttonResult.Location = new System.Drawing.Point(216, 438);
            this.buttonResult.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonResult.Name = "buttonResult";
            this.buttonResult.Size = new System.Drawing.Size(72, 53);
            this.buttonResult.TabIndex = 70;
            this.buttonResult.Text = "=";
            this.buttonResult.UseVisualStyleBackColor = false;
            this.buttonResult.Click += new System.EventHandler(this.buttonResult_Click);
            // 
            // button35
            // 
            this.button35.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.button35.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.button35.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button35.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button35.ForeColor = System.Drawing.Color.Black;
            this.button35.Location = new System.Drawing.Point(0, 438);
            this.button35.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button35.Name = "button35";
            this.button35.Size = new System.Drawing.Size(72, 53);
            this.button35.TabIndex = 69;
            this.button35.Text = "±";
            this.button35.UseVisualStyleBackColor = false;
            this.button35.Click += new System.EventHandler(this.plus_minus);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(-1, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 53);
            this.label1.TabIndex = 100;
            this.label1.Text = "    STANDARD";
            // 
            // equation
            // 
            this.equation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.equation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.equation.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.equation.ForeColor = System.Drawing.Color.Black;
            this.equation.Location = new System.Drawing.Point(0, 44);
            this.equation.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.equation.Multiline = true;
            this.equation.Name = "equation";
            this.equation.ReadOnly = true;
            this.equation.Size = new System.Drawing.Size(288, 32);
            this.equation.TabIndex = 99;
            this.equation.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(288, 491);
            this.Controls.Add(this.button30);
            this.Controls.Add(this.equation);
            this.Controls.Add(this.display);
            this.Controls.Add(this.button29);
            this.Controls.Add(this.button27);
            this.Controls.Add(this.button26);
            this.Controls.Add(this.button25);
            this.Controls.Add(this.button28);
            this.Controls.Add(this.button21);
            this.Controls.Add(this.button22);
            this.Controls.Add(this.button23);
            this.Controls.Add(this.button24);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button31);
            this.Controls.Add(this.button32);
            this.Controls.Add(this.button33);
            this.Controls.Add(this.buttonResult);
            this.Controls.Add(this.button35);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Calculator";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button30;
        private System.Windows.Forms.TextBox display;
        private System.Windows.Forms.Button button29;
        private System.Windows.Forms.Button button27;
        private System.Windows.Forms.Button button26;
        private System.Windows.Forms.Button button25;
        private System.Windows.Forms.Button button28;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button31;
        private System.Windows.Forms.Button button32;
        private System.Windows.Forms.Button button33;
        private System.Windows.Forms.Button buttonResult;
        private System.Windows.Forms.Button button35;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox equation;
    }
}