namespace europian_countries
{
    partial class FormCountryEdit
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
            components = new System.ComponentModel.Container();
            textBox1 = new TextBox();
            bindingSource1 = new BindingSource(components);
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            Ok_gomb = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.DataBindings.Add(new Binding("Text", bindingSource1, "Name", true));
            textBox1.Location = new Point(71, 54);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(155, 23);
            textBox1.TabIndex = 0;
            textBox1.Tag = "";
            // 
            // bindingSource1
            // 
            bindingSource1.DataSource = typeof(CountryData);
            // 
            // textBox2
            // 
            textBox2.DataBindings.Add(new Binding("Text", bindingSource1, "Population", true));
            textBox2.Location = new Point(71, 146);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(155, 23);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.DataBindings.Add(new Binding("Text", bindingSource1, "AreaInSquareKm", true));
            textBox3.Location = new Point(71, 251);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(155, 23);
            textBox3.TabIndex = 2;
            // 
            // Ok_gomb
            // 
            Ok_gomb.Location = new Point(222, 316);
            Ok_gomb.Name = "Ok_gomb";
            Ok_gomb.Size = new Size(75, 23);
            Ok_gomb.TabIndex = 3;
            Ok_gomb.Text = "Ok";
            Ok_gomb.UseVisualStyleBackColor = true;
            //Ok_gomb.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(77, 30);
            label1.Name = "label1";
            label1.Size = new Size(86, 15);
            label1.TabIndex = 4;
            label1.Text = "Country name:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(72, 122);
            label2.Name = "label2";
            label2.Size = new Size(68, 15);
            label2.TabIndex = 5;
            label2.Text = "Population:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(75, 225);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 6;
            label3.Text = "Area in km2:";
            // 
            // FormCountryEdit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(319, 351);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Ok_gomb);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "FormCountryEdit";
            Text = "FormCountryEdit";
            Load += FormCountryEdit_Load;
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button Ok_gomb;
        private Label label1;
        private Label label2;
        private Label label3;
        private BindingSource bindingSource1;
    }
}