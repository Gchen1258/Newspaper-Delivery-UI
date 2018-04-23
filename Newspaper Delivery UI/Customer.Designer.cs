namespace Newspaper_Delivery_UI
{
    partial class Customer
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
            this.StreetNumLabel = new System.Windows.Forms.Label();
            this.ApartmentField = new System.Windows.Forms.TextBox();
            this.StNumberField = new System.Windows.Forms.TextBox();
            this.ZipField = new System.Windows.Forms.TextBox();
            this.ZipLabel = new System.Windows.Forms.Label();
            this.ApartmentLabel = new System.Windows.Forms.Label();
            this.StNameField = new System.Windows.Forms.TextBox();
            this.StNameLabel = new System.Windows.Forms.Label();
            this.addressBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.householdsDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.householdsDataSet = new Newspaper_Delivery_UI.HouseholdsDataSet();
            this.householdsDataSet1 = new Newspaper_Delivery_UI.HouseholdsDataSet();
            this.addressBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager = new Newspaper_Delivery_UI.HouseholdsDataSetTableAdapters.TableAdapterManager();
            this.customerTableAdapter = new Newspaper_Delivery_UI.HouseholdsDataSetTableAdapters.CustomerTableAdapter();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.addressBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.householdsDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.householdsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.householdsDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressBindingSource)).BeginInit();
            this.fillByToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // StreetNumLabel
            // 
            this.StreetNumLabel.AutoSize = true;
            this.StreetNumLabel.Font = new System.Drawing.Font("Unispace", 11.25F);
            this.StreetNumLabel.ForeColor = System.Drawing.Color.Black;
            this.StreetNumLabel.Location = new System.Drawing.Point(16, 215);
            this.StreetNumLabel.Name = "StreetNumLabel";
            this.StreetNumLabel.Size = new System.Drawing.Size(134, 18);
            this.StreetNumLabel.TabIndex = 3;
            this.StreetNumLabel.Text = "Street Number:";
            // 
            // ApartmentField
            // 
            this.ApartmentField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(50)))), ((int)(((byte)(150)))));
            this.ApartmentField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ApartmentField.Font = new System.Drawing.Font("Unispace", 12F);
            this.ApartmentField.Location = new System.Drawing.Point(153, 281);
            this.ApartmentField.Margin = new System.Windows.Forms.Padding(0);
            this.ApartmentField.Name = "ApartmentField";
            this.ApartmentField.ReadOnly = true;
            this.ApartmentField.Size = new System.Drawing.Size(189, 20);
            this.ApartmentField.TabIndex = 8;
            // 
            // StNumberField
            // 
            this.StNumberField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(50)))), ((int)(((byte)(150)))));
            this.StNumberField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.StNumberField.Font = new System.Drawing.Font("Unispace", 12F);
            this.StNumberField.Location = new System.Drawing.Point(153, 213);
            this.StNumberField.Margin = new System.Windows.Forms.Padding(0);
            this.StNumberField.Name = "StNumberField";
            this.StNumberField.ReadOnly = true;
            this.StNumberField.Size = new System.Drawing.Size(189, 20);
            this.StNumberField.TabIndex = 1;
            // 
            // ZipField
            // 
            this.ZipField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(50)))), ((int)(((byte)(150)))));
            this.ZipField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ZipField.Font = new System.Drawing.Font("Unispace", 12F);
            this.ZipField.Location = new System.Drawing.Point(153, 316);
            this.ZipField.Margin = new System.Windows.Forms.Padding(0);
            this.ZipField.Name = "ZipField";
            this.ZipField.ReadOnly = true;
            this.ZipField.Size = new System.Drawing.Size(189, 20);
            this.ZipField.TabIndex = 9;
            // 
            // ZipLabel
            // 
            this.ZipLabel.AutoSize = true;
            this.ZipLabel.Font = new System.Drawing.Font("Unispace", 11.25F);
            this.ZipLabel.ForeColor = System.Drawing.Color.Black;
            this.ZipLabel.Location = new System.Drawing.Point(61, 317);
            this.ZipLabel.Name = "ZipLabel";
            this.ZipLabel.Size = new System.Drawing.Size(89, 18);
            this.ZipLabel.TabIndex = 11;
            this.ZipLabel.Text = "Zip Code:";
            // 
            // ApartmentLabel
            // 
            this.ApartmentLabel.AutoSize = true;
            this.ApartmentLabel.Font = new System.Drawing.Font("Unispace", 11.25F);
            this.ApartmentLabel.ForeColor = System.Drawing.Color.Black;
            this.ApartmentLabel.Location = new System.Drawing.Point(52, 282);
            this.ApartmentLabel.Name = "ApartmentLabel";
            this.ApartmentLabel.Size = new System.Drawing.Size(98, 18);
            this.ApartmentLabel.TabIndex = 10;
            this.ApartmentLabel.Text = "Apartment:";
            // 
            // StNameField
            // 
            this.StNameField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(50)))), ((int)(((byte)(150)))));
            this.StNameField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.StNameField.Font = new System.Drawing.Font("Unispace", 12F);
            this.StNameField.Location = new System.Drawing.Point(153, 248);
            this.StNameField.Margin = new System.Windows.Forms.Padding(0);
            this.StNameField.Name = "StNameField";
            this.StNameField.ReadOnly = true;
            this.StNameField.Size = new System.Drawing.Size(189, 20);
            this.StNameField.TabIndex = 5;
            // 
            // StNameLabel
            // 
            this.StNameLabel.AutoSize = true;
            this.StNameLabel.Font = new System.Drawing.Font("Unispace", 11.25F);
            this.StNameLabel.ForeColor = System.Drawing.Color.Black;
            this.StNameLabel.Location = new System.Drawing.Point(34, 248);
            this.StNameLabel.Name = "StNameLabel";
            this.StNameLabel.Size = new System.Drawing.Size(116, 18);
            this.StNameLabel.TabIndex = 7;
            this.StNameLabel.Text = "Street Name:";
            // 
            // addressBindingSource1
            // 
            this.addressBindingSource1.DataMember = "Address";
            this.addressBindingSource1.DataSource = this.householdsDataSetBindingSource;
            // 
            // householdsDataSetBindingSource
            // 
            this.householdsDataSetBindingSource.DataSource = this.householdsDataSet;
            this.householdsDataSetBindingSource.Position = 0;
            // 
            // householdsDataSet
            // 
            this.householdsDataSet.DataSetName = "HouseholdsDataSet";
            this.householdsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // householdsDataSet1
            // 
            this.householdsDataSet1.DataSetName = "HouseholdsDataSet";
            this.householdsDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // addressBindingSource
            // 
            this.addressBindingSource.DataMember = "Address";
            this.addressBindingSource.DataSource = this.householdsDataSet;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.CouriersTableAdapter = null;
            this.tableAdapterManager.CustomerTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Newspaper_Delivery_UI.HouseholdsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillByToolStripButton});
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(1115, 25);
            this.fillByToolStrip.TabIndex = 17;
            this.fillByToolStrip.Text = "fillByToolStrip";
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(39, 22);
            this.fillByToolStripButton.Text = "FillBy";
            this.fillByToolStripButton.Click += new System.EventHandler(this.fillByToolStripButton_Click);
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 683);
            this.Controls.Add(this.fillByToolStrip);
            this.Controls.Add(this.StNameLabel);
            this.Controls.Add(this.StreetNumLabel);
            this.Controls.Add(this.StNameField);
            this.Controls.Add(this.ApartmentField);
            this.Controls.Add(this.StNumberField);
            this.Controls.Add(this.ApartmentLabel);
            this.Controls.Add(this.ZipField);
            this.Controls.Add(this.ZipLabel);
            this.Name = "Customer";
            this.Text = "Customer";
            this.Load += new System.EventHandler(this.Customer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.addressBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.householdsDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.householdsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.householdsDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressBindingSource)).EndInit();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource householdsDataSetBindingSource;
        private HouseholdsDataSet householdsDataSet;
        private HouseholdsDataSet householdsDataSet1;
        private System.Windows.Forms.BindingSource addressBindingSource;
        private HouseholdsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox ApartmentField;
        private System.Windows.Forms.TextBox ZipField;
        private System.Windows.Forms.Label ZipLabel;
        private System.Windows.Forms.Label ApartmentLabel;
        private System.Windows.Forms.TextBox StNameField;
        private System.Windows.Forms.Label StNameLabel;
        private System.Windows.Forms.TextBox StNumberField;
        private System.Windows.Forms.Label StreetNumLabel;
        private System.Windows.Forms.BindingSource addressBindingSource1;
        private HouseholdsDataSetTableAdapters.CustomerTableAdapter customerTableAdapter;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
    }
}