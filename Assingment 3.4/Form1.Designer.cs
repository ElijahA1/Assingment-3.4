namespace Assingment_3._4
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
            components = new System.ComponentModel.Container();
            dataGridView = new DataGridView();
            bindingSource3 = new BindingSource(components);
            bindingSource1 = new BindingSource(components);
            bindingSource2 = new BindingSource(components);
            coffeeBindingSource1 = new BindingSource(components);
            dataSourcesBindingSource = new BindingSource(components);
            bindingSource4 = new BindingSource(components);
            bindingSource5 = new BindingSource(components);
            roastDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ExpDate = new DataGridViewTextBoxColumn();
            flavorDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            orderIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            orderNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            containerDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            sizeInOzDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            bevTempDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            isCaffinatedDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)coffeeBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataSourcesBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource5).BeginInit();
            SuspendLayout();
            // 
            // dataGridView
            // 
            dataGridView.AutoGenerateColumns = false;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { roastDataGridViewTextBoxColumn, ExpDate, flavorDataGridViewTextBoxColumn, orderIdDataGridViewTextBoxColumn, orderNameDataGridViewTextBoxColumn, containerDataGridViewTextBoxColumn, sizeInOzDataGridViewTextBoxColumn, bevTempDataGridViewTextBoxColumn, isCaffinatedDataGridViewCheckBoxColumn });
            dataGridView.DataSource = bindingSource3;
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Location = new Point(0, 0);
            dataGridView.Name = "dataGridView";
            dataGridView.Size = new Size(796, 440);
            dataGridView.TabIndex = 0;
            // 
            // bindingSource3
            // 
            bindingSource3.DataSource = typeof(Data.Coffee);
            // 
            // bindingSource1
            // 
            bindingSource1.DataSource = typeof(Data.Coffee);
            // 
            // bindingSource2
            // 
            bindingSource2.DataSource = typeof(Data.DataSources);
            // 
            // coffeeBindingSource1
            // 
            coffeeBindingSource1.DataSource = typeof(Data.Coffee);
            // 
            // dataSourcesBindingSource
            // 
            dataSourcesBindingSource.DataSource = typeof(Data.DataSources);
            // 
            // bindingSource4
            // 
            bindingSource4.DataSource = typeof(Data.Coffee);
            // 
            // bindingSource5
            // 
            bindingSource5.DataSource = typeof(Data.Coffee);
            // 
            // roastDataGridViewTextBoxColumn
            // 
            roastDataGridViewTextBoxColumn.DataPropertyName = "Roast";
            roastDataGridViewTextBoxColumn.HeaderText = "Roast";
            roastDataGridViewTextBoxColumn.Name = "roastDataGridViewTextBoxColumn";
            // 
            // ExpDate
            // 
            ExpDate.DataPropertyName = "ExpDate";
            ExpDate.HeaderText = "ExpDate";
            ExpDate.Name = "ExpDate";
            // 
            // flavorDataGridViewTextBoxColumn
            // 
            flavorDataGridViewTextBoxColumn.DataPropertyName = "Flavor";
            flavorDataGridViewTextBoxColumn.HeaderText = "Flavor";
            flavorDataGridViewTextBoxColumn.Name = "flavorDataGridViewTextBoxColumn";
            // 
            // orderIdDataGridViewTextBoxColumn
            // 
            orderIdDataGridViewTextBoxColumn.DataPropertyName = "OrderId";
            orderIdDataGridViewTextBoxColumn.HeaderText = "OrderId";
            orderIdDataGridViewTextBoxColumn.Name = "orderIdDataGridViewTextBoxColumn";
            // 
            // orderNameDataGridViewTextBoxColumn
            // 
            orderNameDataGridViewTextBoxColumn.DataPropertyName = "OrderName";
            orderNameDataGridViewTextBoxColumn.HeaderText = "OrderName";
            orderNameDataGridViewTextBoxColumn.Name = "orderNameDataGridViewTextBoxColumn";
            // 
            // containerDataGridViewTextBoxColumn
            // 
            containerDataGridViewTextBoxColumn.DataPropertyName = "Container";
            containerDataGridViewTextBoxColumn.HeaderText = "Container";
            containerDataGridViewTextBoxColumn.Name = "containerDataGridViewTextBoxColumn";
            // 
            // sizeInOzDataGridViewTextBoxColumn
            // 
            sizeInOzDataGridViewTextBoxColumn.DataPropertyName = "SizeInOz";
            sizeInOzDataGridViewTextBoxColumn.HeaderText = "SizeInOz";
            sizeInOzDataGridViewTextBoxColumn.Name = "sizeInOzDataGridViewTextBoxColumn";
            // 
            // bevTempDataGridViewTextBoxColumn
            // 
            bevTempDataGridViewTextBoxColumn.DataPropertyName = "BevTemp";
            bevTempDataGridViewTextBoxColumn.HeaderText = "BevTemp";
            bevTempDataGridViewTextBoxColumn.Name = "bevTempDataGridViewTextBoxColumn";
            // 
            // isCaffinatedDataGridViewCheckBoxColumn
            // 
            isCaffinatedDataGridViewCheckBoxColumn.DataPropertyName = "IsCaffinated";
            isCaffinatedDataGridViewCheckBoxColumn.HeaderText = "IsCaffinated";
            isCaffinatedDataGridViewCheckBoxColumn.Name = "isCaffinatedDataGridViewCheckBoxColumn";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(796, 440);
            Controls.Add(dataGridView);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource3).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource2).EndInit();
            ((System.ComponentModel.ISupportInitialize)coffeeBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataSourcesBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource4).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource5).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView;
        private BindingSource dataSourcesBindingSource;
        private BindingSource dataSourcesBindingSource1;
        private BindingSource dataSourcesBindingSource2;
        private BindingSource coffeeBindingSource;
        private BindingSource form1BindingSource;
        private BindingSource coffeeBindingSource1;
        private BindingSource bindingSource1;
        private BindingSource bindingSource2;
        private BindingSource bindingSource3;
        private DataGridViewTextBoxColumn expDateDataGridViewTextBoxColumn;
        private BindingSource bindingSource5;
        private BindingSource bindingSource4;
        private DataGridViewTextBoxColumn roastDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ExpDate;
        private DataGridViewTextBoxColumn flavorDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn orderIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn orderNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn containerDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sizeInOzDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn bevTempDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn isCaffinatedDataGridViewCheckBoxColumn;
    }
}
