namespace JaredRAmazon
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnAdd = new Button();
            btnRemove = new Button();
            btnClear = new Button();
            btnCount = new Button();
            btnExit = new Button();
            listView = new ListView();
            lblCount = new Label();
            txtPID = new TextBox();
            txtName = new TextBox();
            txtDescription = new TextBox();
            txtBrand = new TextBox();
            txtPrice = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 30);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 0;
            label1.Text = "ProductID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 80);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 1;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 130);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 2;
            label3.Text = "Description";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 180);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 3;
            label4.Text = "Brand";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(30, 230);
            label5.Name = "label5";
            label5.Size = new Size(33, 15);
            label5.TabIndex = 4;
            label5.Text = "Price";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(34, 331);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(87, 29);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(127, 331);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(87, 29);
            btnRemove.TabIndex = 6;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(220, 331);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(87, 29);
            btnClear.TabIndex = 7;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnCount
            // 
            btnCount.Location = new Point(34, 376);
            btnCount.Name = "btnCount";
            btnCount.Size = new Size(87, 29);
            btnCount.TabIndex = 8;
            btnCount.Text = "Count";
            btnCount.UseVisualStyleBackColor = true;
            btnCount.Click += btnCount_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(127, 376);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(87, 29);
            btnExit.TabIndex = 9;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // listView
            // 
            listView.Location = new Point(362, 12);
            listView.Name = "listView";
            listView.Size = new Size(426, 426);
            listView.TabIndex = 10;
            listView.UseCompatibleStateImageBehavior = false;
            listView.SelectedIndexChanged += listView_SelectedIndexChanged;
            // 
            // lblCount
            // 
            lblCount.AutoSize = true;
            lblCount.Location = new Point(229, 383);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(0, 15);
            lblCount.TabIndex = 11;
            // 
            // txtPID
            // 
            txtPID.Location = new Point(101, 27);
            txtPID.Name = "txtPID";
            txtPID.Size = new Size(166, 23);
            txtPID.TabIndex = 12;
            // 
            // txtName
            // 
            txtName.Location = new Point(101, 77);
            txtName.Name = "txtName";
            txtName.Size = new Size(166, 23);
            txtName.TabIndex = 13;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(101, 127);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(166, 23);
            txtDescription.TabIndex = 14;
            // 
            // txtBrand
            // 
            txtBrand.Location = new Point(101, 177);
            txtBrand.Name = "txtBrand";
            txtBrand.Size = new Size(166, 23);
            txtBrand.TabIndex = 15;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(101, 227);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(166, 23);
            txtPrice.TabIndex = 16;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(800, 450);
            Controls.Add(txtPrice);
            Controls.Add(txtBrand);
            Controls.Add(txtDescription);
            Controls.Add(txtName);
            Controls.Add(txtPID);
            Controls.Add(lblCount);
            Controls.Add(listView);
            Controls.Add(btnExit);
            Controls.Add(btnCount);
            Controls.Add(btnClear);
            Controls.Add(btnRemove);
            Controls.Add(btnAdd);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Amazon Product Description";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnAdd;
        private Button btnRemove;
        private Button btnClear;
        private Button btnCount;
        private Button btnExit;
        private ListView listView;
        private Label lblCount;
        private TextBox txtPID;
        private TextBox txtName;
        private TextBox txtDescription;
        private TextBox txtBrand;
        private TextBox txtPrice;
    }
}
