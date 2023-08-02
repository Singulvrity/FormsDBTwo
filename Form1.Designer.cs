namespace FormsDBTwo
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label city_nameLabel;
            System.Windows.Forms.Label minLabel;
            System.Windows.Forms.Label maxLabel;
            System.Windows.Forms.Label windLabel;
            this.formsDBTwoDataSet = new FormsDBTwo.FormsDBTwoDataSet();
            this.cityDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cityDataTableAdapter = new FormsDBTwo.FormsDBTwoDataSetTableAdapters.CityDataTableAdapter();
            this.tableAdapterManager = new FormsDBTwo.FormsDBTwoDataSetTableAdapters.TableAdapterManager();
            this.cityDataBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.cityDataBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.cityDataDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.city_nameTextBox = new System.Windows.Forms.TextBox();
            this.minTextBox = new System.Windows.Forms.TextBox();
            this.maxTextBox = new System.Windows.Forms.TextBox();
            this.windTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            idLabel = new System.Windows.Forms.Label();
            city_nameLabel = new System.Windows.Forms.Label();
            minLabel = new System.Windows.Forms.Label();
            maxLabel = new System.Windows.Forms.Label();
            windLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.formsDBTwoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityDataBindingNavigator)).BeginInit();
            this.cityDataBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cityDataDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // formsDBTwoDataSet
            // 
            this.formsDBTwoDataSet.DataSetName = "FormsDBTwoDataSet";
            this.formsDBTwoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cityDataBindingSource
            // 
            this.cityDataBindingSource.DataMember = "CityData";
            this.cityDataBindingSource.DataSource = this.formsDBTwoDataSet;
            // 
            // cityDataTableAdapter
            // 
            this.cityDataTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CityDataTableAdapter = this.cityDataTableAdapter;
            this.tableAdapterManager.UpdateOrder = FormsDBTwo.FormsDBTwoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cityDataBindingNavigator
            // 
            this.cityDataBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.cityDataBindingNavigator.BindingSource = this.cityDataBindingSource;
            this.cityDataBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.cityDataBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.cityDataBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.cityDataBindingNavigatorSaveItem});
            this.cityDataBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.cityDataBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.cityDataBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.cityDataBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.cityDataBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.cityDataBindingNavigator.Name = "cityDataBindingNavigator";
            this.cityDataBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.cityDataBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.cityDataBindingNavigator.TabIndex = 0;
            this.cityDataBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // cityDataBindingNavigatorSaveItem
            // 
            this.cityDataBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cityDataBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("cityDataBindingNavigatorSaveItem.Image")));
            this.cityDataBindingNavigatorSaveItem.Name = "cityDataBindingNavigatorSaveItem";
            this.cityDataBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.cityDataBindingNavigatorSaveItem.Text = "Save Data";
            this.cityDataBindingNavigatorSaveItem.Click += new System.EventHandler(this.cityDataBindingNavigatorSaveItem_Click);
            // 
            // cityDataDataGridView
            // 
            this.cityDataDataGridView.AutoGenerateColumns = false;
            this.cityDataDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cityDataDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.cityDataDataGridView.DataSource = this.cityDataBindingSource;
            this.cityDataDataGridView.Location = new System.Drawing.Point(87, 71);
            this.cityDataDataGridView.Name = "cityDataDataGridView";
            this.cityDataDataGridView.Size = new System.Drawing.Size(544, 176);
            this.cityDataDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "City name";
            this.dataGridViewTextBoxColumn2.HeaderText = "City name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Min";
            this.dataGridViewTextBoxColumn3.HeaderText = "Min";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Max";
            this.dataGridViewTextBoxColumn4.HeaderText = "Max";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Wind";
            this.dataGridViewTextBoxColumn5.HeaderText = "Wind";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(179, 351);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 2;
            idLabel.Text = "Id:";
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cityDataBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(241, 348);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(100, 20);
            this.idTextBox.TabIndex = 3;
            // 
            // city_nameLabel
            // 
            city_nameLabel.AutoSize = true;
            city_nameLabel.Location = new System.Drawing.Point(179, 377);
            city_nameLabel.Name = "city_nameLabel";
            city_nameLabel.Size = new System.Drawing.Size(56, 13);
            city_nameLabel.TabIndex = 4;
            city_nameLabel.Text = "City name:";
            // 
            // city_nameTextBox
            // 
            this.city_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cityDataBindingSource, "City name", true));
            this.city_nameTextBox.Location = new System.Drawing.Point(241, 374);
            this.city_nameTextBox.Name = "city_nameTextBox";
            this.city_nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.city_nameTextBox.TabIndex = 5;
            // 
            // minLabel
            // 
            minLabel.AutoSize = true;
            minLabel.Location = new System.Drawing.Point(179, 403);
            minLabel.Name = "minLabel";
            minLabel.Size = new System.Drawing.Size(27, 13);
            minLabel.TabIndex = 6;
            minLabel.Text = "Min:";
            // 
            // minTextBox
            // 
            this.minTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cityDataBindingSource, "Min", true));
            this.minTextBox.Location = new System.Drawing.Point(241, 400);
            this.minTextBox.Name = "minTextBox";
            this.minTextBox.Size = new System.Drawing.Size(100, 20);
            this.minTextBox.TabIndex = 7;
            // 
            // maxLabel
            // 
            maxLabel.AutoSize = true;
            maxLabel.Location = new System.Drawing.Point(179, 429);
            maxLabel.Name = "maxLabel";
            maxLabel.Size = new System.Drawing.Size(30, 13);
            maxLabel.TabIndex = 8;
            maxLabel.Text = "Max:";
            // 
            // maxTextBox
            // 
            this.maxTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cityDataBindingSource, "Max", true));
            this.maxTextBox.Location = new System.Drawing.Point(241, 426);
            this.maxTextBox.Name = "maxTextBox";
            this.maxTextBox.Size = new System.Drawing.Size(100, 20);
            this.maxTextBox.TabIndex = 9;
            // 
            // windLabel
            // 
            windLabel.AutoSize = true;
            windLabel.Location = new System.Drawing.Point(179, 455);
            windLabel.Name = "windLabel";
            windLabel.Size = new System.Drawing.Size(35, 13);
            windLabel.TabIndex = 10;
            windLabel.Text = "Wind:";
            // 
            // windTextBox
            // 
            this.windTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cityDataBindingSource, "Wind", true));
            this.windTextBox.Location = new System.Drawing.Point(241, 452);
            this.windTextBox.Name = "windTextBox";
            this.windTextBox.Size = new System.Drawing.Size(100, 20);
            this.windTextBox.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(479, 351);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Insert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(479, 381);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(479, 411);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 14;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(479, 445);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 15;
            this.button4.Text = "Clear";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 492);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(city_nameLabel);
            this.Controls.Add(this.city_nameTextBox);
            this.Controls.Add(minLabel);
            this.Controls.Add(this.minTextBox);
            this.Controls.Add(maxLabel);
            this.Controls.Add(this.maxTextBox);
            this.Controls.Add(windLabel);
            this.Controls.Add(this.windTextBox);
            this.Controls.Add(this.cityDataDataGridView);
            this.Controls.Add(this.cityDataBindingNavigator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.formsDBTwoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityDataBindingNavigator)).EndInit();
            this.cityDataBindingNavigator.ResumeLayout(false);
            this.cityDataBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cityDataDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FormsDBTwoDataSet formsDBTwoDataSet;
        private System.Windows.Forms.BindingSource cityDataBindingSource;
        private FormsDBTwoDataSetTableAdapters.CityDataTableAdapter cityDataTableAdapter;
        private FormsDBTwoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator cityDataBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton cityDataBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView cityDataDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox city_nameTextBox;
        private System.Windows.Forms.TextBox minTextBox;
        private System.Windows.Forms.TextBox maxTextBox;
        private System.Windows.Forms.TextBox windTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

