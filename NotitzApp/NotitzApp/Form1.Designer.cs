namespace NotitzApp
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grdTasks = new System.Windows.Forms.DataGridView();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtTitel = new System.Windows.Forms.TextBox();
            this.txtNachricht = new System.Windows.Forms.TextBox();
            this.cboxHohePrioritaet = new System.Windows.Forms.CheckBox();
            this.cboxMittlereprioritaet = new System.Windows.Forms.CheckBox();
            this.cboxUnwichtig = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdTasks)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Titel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nachricht";
            // 
            // grdTasks
            // 
            this.grdTasks.AllowUserToAddRows = false;
            this.grdTasks.AllowUserToDeleteRows = false;
            this.grdTasks.AllowUserToResizeColumns = false;
            this.grdTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdTasks.Location = new System.Drawing.Point(499, 87);
            this.grdTasks.Name = "grdTasks";
            this.grdTasks.ReadOnly = true;
            this.grdTasks.RowHeadersVisible = false;
            this.grdTasks.Size = new System.Drawing.Size(438, 341);
            this.grdTasks.TabIndex = 4;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(499, 434);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 63);
            this.btnNew.TabIndex = 5;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(580, 434);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 63);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(774, 434);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(75, 63);
            this.btnRead.TabIndex = 7;
            this.btnRead.Text = "Read";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(862, 434);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 63);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtTitel
            // 
            this.txtTitel.Location = new System.Drawing.Point(102, 87);
            this.txtTitel.Name = "txtTitel";
            this.txtTitel.Size = new System.Drawing.Size(338, 20);
            this.txtTitel.TabIndex = 9;
            // 
            // txtNachricht
            // 
            this.txtNachricht.Location = new System.Drawing.Point(102, 123);
            this.txtNachricht.Multiline = true;
            this.txtNachricht.Name = "txtNachricht";
            this.txtNachricht.Size = new System.Drawing.Size(338, 374);
            this.txtNachricht.TabIndex = 10;
            // 
            // cboxHohePrioritaet
            // 
            this.cboxHohePrioritaet.AutoSize = true;
            this.cboxHohePrioritaet.Location = new System.Drawing.Point(102, 525);
            this.cboxHohePrioritaet.Name = "cboxHohePrioritaet";
            this.cboxHohePrioritaet.Size = new System.Drawing.Size(90, 17);
            this.cboxHohePrioritaet.TabIndex = 11;
            this.cboxHohePrioritaet.Text = "Hohe Priorität";
            this.cboxHohePrioritaet.UseVisualStyleBackColor = true;
            this.cboxHohePrioritaet.CheckedChanged += new System.EventHandler(this.cboxHohePrioritaet_CheckedChanged);
            // 
            // cboxMittlereprioritaet
            // 
            this.cboxMittlereprioritaet.AutoSize = true;
            this.cboxMittlereprioritaet.Location = new System.Drawing.Point(224, 525);
            this.cboxMittlereprioritaet.Name = "cboxMittlereprioritaet";
            this.cboxMittlereprioritaet.Size = new System.Drawing.Size(95, 17);
            this.cboxMittlereprioritaet.TabIndex = 12;
            this.cboxMittlereprioritaet.Text = "Mitlere Priorität";
            this.cboxMittlereprioritaet.UseVisualStyleBackColor = true;
            this.cboxMittlereprioritaet.CheckedChanged += new System.EventHandler(this.cboxMittlereprioritaet_CheckedChanged);
            // 
            // cboxUnwichtig
            // 
            this.cboxUnwichtig.AutoSize = true;
            this.cboxUnwichtig.Location = new System.Drawing.Point(352, 525);
            this.cboxUnwichtig.Name = "cboxUnwichtig";
            this.cboxUnwichtig.Size = new System.Drawing.Size(88, 17);
            this.cboxUnwichtig.TabIndex = 13;
            this.cboxUnwichtig.Text = "Tiefe Priorität";
            this.cboxUnwichtig.UseVisualStyleBackColor = true;
            this.cboxUnwichtig.CheckedChanged += new System.EventHandler(this.cboxUnwichtig_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 581);
            this.Controls.Add(this.cboxUnwichtig);
            this.Controls.Add(this.cboxMittlereprioritaet);
            this.Controls.Add(this.cboxHohePrioritaet);
            this.Controls.Add(this.txtNachricht);
            this.Controls.Add(this.txtTitel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.grdTasks);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdTasks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView grdTasks;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtTitel;
        private System.Windows.Forms.TextBox txtNachricht;
        private System.Windows.Forms.CheckBox cboxHohePrioritaet;
        private System.Windows.Forms.CheckBox cboxMittlereprioritaet;
        private System.Windows.Forms.CheckBox cboxUnwichtig;
    }
}

