namespace ServerExample
{
    partial class Ships
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
            this.components = new System.ComponentModel.Container();
            this.shipList = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.addShipButton = new System.Windows.Forms.Button();
            this.shipOwnerTextInput = new System.Windows.Forms.TextBox();
            this.shipNameTextInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.refreshButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.removeShipButton = new System.Windows.Forms.Button();
            this.removeShipTextInput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.serverBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.serverBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.modifyOldShipNameTextInput = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.modifyShipButton = new System.Windows.Forms.Button();
            this.modifyNewShipOwnerTextInput = new System.Windows.Forms.TextBox();
            this.modifyNewShipNameTextInput = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.serverBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serverBindingSource1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // shipList
            // 
            this.shipList.FormattingEnabled = true;
            this.shipList.Location = new System.Drawing.Point(12, 33);
            this.shipList.Name = "shipList";
            this.shipList.Size = new System.Drawing.Size(776, 277);
            this.shipList.TabIndex = 0;
            this.shipList.SelectedIndexChanged += new System.EventHandler(this.shipList_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.addShipButton);
            this.groupBox1.Controls.Add(this.shipOwnerTextInput);
            this.groupBox1.Controls.Add(this.shipNameTextInput);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(543, 316);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(245, 132);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Ship";
            // 
            // addShipButton
            // 
            this.addShipButton.Location = new System.Drawing.Point(57, 93);
            this.addShipButton.Name = "addShipButton";
            this.addShipButton.Size = new System.Drawing.Size(75, 23);
            this.addShipButton.TabIndex = 4;
            this.addShipButton.Text = "Add Ship";
            this.addShipButton.UseVisualStyleBackColor = true;
            this.addShipButton.Click += new System.EventHandler(this.addShipButton_Click);
            // 
            // shipOwnerTextInput
            // 
            this.shipOwnerTextInput.Location = new System.Drawing.Point(57, 45);
            this.shipOwnerTextInput.Name = "shipOwnerTextInput";
            this.shipOwnerTextInput.Size = new System.Drawing.Size(182, 20);
            this.shipOwnerTextInput.TabIndex = 3;
            // 
            // shipNameTextInput
            // 
            this.shipNameTextInput.Location = new System.Drawing.Point(57, 16);
            this.shipNameTextInput.Name = "shipNameTextInput";
            this.shipNameTextInput.Size = new System.Drawing.Size(182, 20);
            this.shipNameTextInput.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Owner";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(719, 4);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(75, 23);
            this.refreshButton.TabIndex = 2;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.removeShipButton);
            this.groupBox2.Controls.Add(this.removeShipTextInput);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(12, 316);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(238, 132);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Remove Ship";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.textBox2);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(281, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(257, 119);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Add Ship";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(170, 93);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Add Ship";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(57, 49);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(188, 20);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(57, 23);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(188, 20);
            this.textBox2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Owner";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Name";
            // 
            // removeShipButton
            // 
            this.removeShipButton.Location = new System.Drawing.Point(40, 96);
            this.removeShipButton.Name = "removeShipButton";
            this.removeShipButton.Size = new System.Drawing.Size(106, 23);
            this.removeShipButton.TabIndex = 4;
            this.removeShipButton.Text = "Remove Ship";
            this.removeShipButton.UseVisualStyleBackColor = true;
            this.removeShipButton.Click += new System.EventHandler(this.removeShip_Click);
            // 
            // removeShipTextInput
            // 
            this.removeShipTextInput.Location = new System.Drawing.Point(40, 16);
            this.removeShipTextInput.Name = "removeShipTextInput";
            this.removeShipTextInput.Size = new System.Drawing.Size(188, 20);
            this.removeShipTextInput.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Name";
            // 
            // serverBindingSource
            // 
            this.serverBindingSource.DataSource = typeof(ServerExample.Data.Server);
            // 
            // serverBindingSource1
            // 
            this.serverBindingSource1.DataSource = typeof(ServerExample.Data.Server);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.modifyOldShipNameTextInput);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.modifyShipButton);
            this.groupBox4.Controls.Add(this.modifyNewShipOwnerTextInput);
            this.groupBox4.Controls.Add(this.modifyNewShipNameTextInput);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Location = new System.Drawing.Point(256, 316);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(281, 132);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Modify Ship";
            // 
            // modifyOldShipNameTextInput
            // 
            this.modifyOldShipNameTextInput.Location = new System.Drawing.Point(77, 16);
            this.modifyOldShipNameTextInput.Name = "modifyOldShipNameTextInput";
            this.modifyOldShipNameTextInput.Size = new System.Drawing.Size(198, 20);
            this.modifyOldShipNameTextInput.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Old Name";
            // 
            // modifyShipButton
            // 
            this.modifyShipButton.Location = new System.Drawing.Point(77, 96);
            this.modifyShipButton.Name = "modifyShipButton";
            this.modifyShipButton.Size = new System.Drawing.Size(75, 23);
            this.modifyShipButton.TabIndex = 4;
            this.modifyShipButton.Text = "Modify Ship";
            this.modifyShipButton.UseVisualStyleBackColor = true;
            this.modifyShipButton.Click += new System.EventHandler(this.modifyShipButton_Click);
            // 
            // modifyNewShipOwnerTextInput
            // 
            this.modifyNewShipOwnerTextInput.Location = new System.Drawing.Point(77, 68);
            this.modifyNewShipOwnerTextInput.Name = "modifyNewShipOwnerTextInput";
            this.modifyNewShipOwnerTextInput.Size = new System.Drawing.Size(198, 20);
            this.modifyNewShipOwnerTextInput.TabIndex = 3;
            // 
            // modifyNewShipNameTextInput
            // 
            this.modifyNewShipNameTextInput.Location = new System.Drawing.Point(77, 42);
            this.modifyNewShipNameTextInput.Name = "modifyNewShipNameTextInput";
            this.modifyNewShipNameTextInput.Size = new System.Drawing.Size(198, 20);
            this.modifyNewShipNameTextInput.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "New Owner";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "New Name";
            // 
            // Ships
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.shipList);
            this.Name = "Ships";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.serverBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serverBindingSource1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource serverBindingSource;
        private System.Windows.Forms.BindingSource serverBindingSource1;
        private System.Windows.Forms.ListBox shipList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button addShipButton;
        private System.Windows.Forms.TextBox shipOwnerTextInput;
        private System.Windows.Forms.TextBox shipNameTextInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button removeShipButton;
        private System.Windows.Forms.TextBox removeShipTextInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button modifyShipButton;
        private System.Windows.Forms.TextBox modifyNewShipOwnerTextInput;
        private System.Windows.Forms.TextBox modifyNewShipNameTextInput;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox modifyOldShipNameTextInput;
        private System.Windows.Forms.Label label8;
    }
}

