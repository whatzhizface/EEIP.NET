
namespace Test_Application
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
            this.btnWriteDigitalOutput = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReadDI = new System.Windows.Forms.Button();
            this.btnReadAI = new System.Windows.Forms.Button();
            this.btnWriteValues = new System.Windows.Forms.Button();
            this.btnDiscover = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tbIpAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPort = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbResults = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnWriteDigitalOutput
            // 
            this.btnWriteDigitalOutput.Location = new System.Drawing.Point(18, 330);
            this.btnWriteDigitalOutput.Name = "btnWriteDigitalOutput";
            this.btnWriteDigitalOutput.Size = new System.Drawing.Size(103, 32);
            this.btnWriteDigitalOutput.TabIndex = 0;
            this.btnWriteDigitalOutput.Text = "Write DO";
            this.btnWriteDigitalOutput.UseVisualStyleBackColor = true;
            this.btnWriteDigitalOutput.Click += new System.EventHandler(this.btnWriteDigitalOutput_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Discovered Devices (Only discoverable on connected networks)";
            // 
            // btnReadDI
            // 
            this.btnReadDI.Location = new System.Drawing.Point(18, 292);
            this.btnReadDI.Name = "btnReadDI";
            this.btnReadDI.Size = new System.Drawing.Size(103, 32);
            this.btnReadDI.TabIndex = 0;
            this.btnReadDI.Text = "Read DI";
            this.btnReadDI.UseVisualStyleBackColor = true;
            this.btnReadDI.Click += new System.EventHandler(this.btnReadDI_Click);
            // 
            // btnReadAI
            // 
            this.btnReadAI.Location = new System.Drawing.Point(18, 368);
            this.btnReadAI.Name = "btnReadAI";
            this.btnReadAI.Size = new System.Drawing.Size(103, 32);
            this.btnReadAI.TabIndex = 0;
            this.btnReadAI.Text = "Read AI";
            this.btnReadAI.UseVisualStyleBackColor = true;
            // 
            // btnWriteValues
            // 
            this.btnWriteValues.Location = new System.Drawing.Point(18, 406);
            this.btnWriteValues.Name = "btnWriteValues";
            this.btnWriteValues.Size = new System.Drawing.Size(103, 32);
            this.btnWriteValues.TabIndex = 0;
            this.btnWriteValues.Text = "Write Values";
            this.btnWriteValues.UseVisualStyleBackColor = true;
            this.btnWriteValues.Click += new System.EventHandler(this.btnWriteValues_Click);
            // 
            // btnDiscover
            // 
            this.btnDiscover.Location = new System.Drawing.Point(18, 12);
            this.btnDiscover.Name = "btnDiscover";
            this.btnDiscover.Size = new System.Drawing.Size(103, 32);
            this.btnDiscover.TabIndex = 0;
            this.btnDiscover.Text = "Discover Devices";
            this.btnDiscover.UseVisualStyleBackColor = true;
            this.btnDiscover.Click += new System.EventHandler(this.btnDiscover_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(18, 71);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(886, 165);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Description";
            this.columnHeader1.Width = 300;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "IP Address";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Port";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Vendor ID";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Product Code";
            this.columnHeader5.Width = 90;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Type Code";
            this.columnHeader6.Width = 90;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Serial Number";
            this.columnHeader7.Width = 90;
            // 
            // tbIpAddress
            // 
            this.tbIpAddress.Location = new System.Drawing.Point(18, 266);
            this.tbIpAddress.Name = "tbIpAddress";
            this.tbIpAddress.Size = new System.Drawing.Size(194, 20);
            this.tbIpAddress.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Device Address";
            // 
            // tbPort
            // 
            this.tbPort.Location = new System.Drawing.Point(218, 266);
            this.tbPort.Name = "tbPort";
            this.tbPort.Size = new System.Drawing.Size(129, 20);
            this.tbPort.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(215, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Device Address";
            // 
            // tbResults
            // 
            this.tbResults.Location = new System.Drawing.Point(399, 247);
            this.tbResults.Multiline = true;
            this.tbResults.Name = "tbResults";
            this.tbResults.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbResults.Size = new System.Drawing.Size(505, 190);
            this.tbResults.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 450);
            this.Controls.Add(this.tbResults);
            this.Controls.Add(this.tbPort);
            this.Controls.Add(this.tbIpAddress);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDiscover);
            this.Controls.Add(this.btnWriteValues);
            this.Controls.Add(this.btnReadAI);
            this.Controls.Add(this.btnReadDI);
            this.Controls.Add(this.btnWriteDigitalOutput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnWriteDigitalOutput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReadDI;
        private System.Windows.Forms.Button btnReadAI;
        private System.Windows.Forms.Button btnWriteValues;
        private System.Windows.Forms.Button btnDiscover;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.TextBox tbIpAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbResults;
    }
}

