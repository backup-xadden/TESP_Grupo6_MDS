namespace PrototipoFuncional
{
    partial class View_details
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(View_details));
            System.Windows.Forms.Label diagnosesLabel;
            System.Windows.Forms.Label symptomsLabel;
            System.Windows.Forms.Label medicationLabel;
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label ageLabel;
            System.Windows.Forms.Label genderLabel;
            System.Windows.Forms.Label ocupationLabel;
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.infoDataSet = new PrototipoFuncional.InfoDataSet();
            this.informationSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.informationSetTableAdapter = new PrototipoFuncional.InfoDataSetTableAdapters.InformationSetTableAdapter();
            this.tableAdapterManager = new PrototipoFuncional.InfoDataSetTableAdapters.TableAdapterManager();
            this.informationSetBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.informationSetBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.diagnosesTextBox = new System.Windows.Forms.TextBox();
            this.symptomsTextBox = new System.Windows.Forms.TextBox();
            this.medicationTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.ageTextBox = new System.Windows.Forms.TextBox();
            this.genderTextBox = new System.Windows.Forms.TextBox();
            this.ocupationTextBox = new System.Windows.Forms.TextBox();
            diagnosesLabel = new System.Windows.Forms.Label();
            symptomsLabel = new System.Windows.Forms.Label();
            medicationLabel = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            ageLabel = new System.Windows.Forms.Label();
            genderLabel = new System.Windows.Forms.Label();
            ocupationLabel = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.infoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.informationSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.informationSetBindingNavigator)).BeginInit();
            this.informationSetBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(13, 403);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(415, 99);
            this.button2.TabIndex = 25;
            this.button2.Text = "Return";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(medicationLabel);
            this.groupBox2.Controls.Add(this.medicationTextBox);
            this.groupBox2.Controls.Add(symptomsLabel);
            this.groupBox2.Controls.Add(this.symptomsTextBox);
            this.groupBox2.Controls.Add(diagnosesLabel);
            this.groupBox2.Controls.Add(this.diagnosesTextBox);
            this.groupBox2.Location = new System.Drawing.Point(436, 35);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(591, 480);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Clinic Information";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(ocupationLabel);
            this.groupBox1.Controls.Add(this.ocupationTextBox);
            this.groupBox1.Controls.Add(genderLabel);
            this.groupBox1.Controls.Add(this.genderTextBox);
            this.groupBox1.Controls.Add(ageLabel);
            this.groupBox1.Controls.Add(this.ageTextBox);
            this.groupBox1.Controls.Add(nameLabel);
            this.groupBox1.Controls.Add(this.nameTextBox);
            this.groupBox1.Controls.Add(idLabel);
            this.groupBox1.Controls.Add(this.idTextBox);
            this.groupBox1.Location = new System.Drawing.Point(13, 35);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(415, 360);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Patient personal information";
            // 
            // infoDataSet
            // 
            this.infoDataSet.DataSetName = "InfoDataSet";
            this.infoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // informationSetBindingSource
            // 
            this.informationSetBindingSource.DataMember = "InformationSet";
            this.informationSetBindingSource.DataSource = this.infoDataSet;
            // 
            // informationSetTableAdapter
            // 
            this.informationSetTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.InformationSetTableAdapter = this.informationSetTableAdapter;
            this.tableAdapterManager.UpdateOrder = PrototipoFuncional.InfoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // informationSetBindingNavigator
            // 
            this.informationSetBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.informationSetBindingNavigator.BindingSource = this.informationSetBindingSource;
            this.informationSetBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.informationSetBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.informationSetBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.informationSetBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.informationSetBindingNavigatorSaveItem});
            this.informationSetBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.informationSetBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.informationSetBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.informationSetBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.informationSetBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.informationSetBindingNavigator.Name = "informationSetBindingNavigator";
            this.informationSetBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.informationSetBindingNavigator.Size = new System.Drawing.Size(1064, 27);
            this.informationSetBindingNavigator.TabIndex = 26;
            this.informationSetBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 22);
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
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 20);
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
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
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
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // informationSetBindingNavigatorSaveItem
            // 
            this.informationSetBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.informationSetBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("informationSetBindingNavigatorSaveItem.Image")));
            this.informationSetBindingNavigatorSaveItem.Name = "informationSetBindingNavigatorSaveItem";
            this.informationSetBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.informationSetBindingNavigatorSaveItem.Text = "Save Data";
            this.informationSetBindingNavigatorSaveItem.Click += new System.EventHandler(this.informationSetBindingNavigatorSaveItem_Click);
            // 
            // diagnosesLabel
            // 
            diagnosesLabel.AutoSize = true;
            diagnosesLabel.Location = new System.Drawing.Point(11, 315);
            diagnosesLabel.Name = "diagnosesLabel";
            diagnosesLabel.Size = new System.Drawing.Size(79, 17);
            diagnosesLabel.TabIndex = 3;
            diagnosesLabel.Text = "Diagnoses:";
            // 
            // diagnosesTextBox
            // 
            this.diagnosesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.informationSetBindingSource, "Diagnoses", true));
            this.diagnosesTextBox.Location = new System.Drawing.Point(96, 312);
            this.diagnosesTextBox.Multiline = true;
            this.diagnosesTextBox.Name = "diagnosesTextBox";
            this.diagnosesTextBox.Size = new System.Drawing.Size(474, 148);
            this.diagnosesTextBox.TabIndex = 4;
            // 
            // symptomsLabel
            // 
            symptomsLabel.AutoSize = true;
            symptomsLabel.Location = new System.Drawing.Point(7, 179);
            symptomsLabel.Name = "symptomsLabel";
            symptomsLabel.Size = new System.Drawing.Size(77, 17);
            symptomsLabel.TabIndex = 4;
            symptomsLabel.Text = "Symptoms:";
            // 
            // symptomsTextBox
            // 
            this.symptomsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.informationSetBindingSource, "Symptoms", true));
            this.symptomsTextBox.Location = new System.Drawing.Point(96, 176);
            this.symptomsTextBox.Multiline = true;
            this.symptomsTextBox.Name = "symptomsTextBox";
            this.symptomsTextBox.Size = new System.Drawing.Size(474, 130);
            this.symptomsTextBox.TabIndex = 5;
            // 
            // medicationLabel
            // 
            medicationLabel.AutoSize = true;
            medicationLabel.Location = new System.Drawing.Point(11, 37);
            medicationLabel.Name = "medicationLabel";
            medicationLabel.Size = new System.Drawing.Size(80, 17);
            medicationLabel.TabIndex = 5;
            medicationLabel.Text = "Medication:";
            // 
            // medicationTextBox
            // 
            this.medicationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.informationSetBindingSource, "Medication", true));
            this.medicationTextBox.Location = new System.Drawing.Point(97, 34);
            this.medicationTextBox.Multiline = true;
            this.medicationTextBox.Name = "medicationTextBox";
            this.medicationTextBox.Size = new System.Drawing.Size(473, 136);
            this.medicationTextBox.TabIndex = 6;
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(56, 95);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(23, 17);
            idLabel.TabIndex = 0;
            idLabel.Text = "Id:";
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.informationSetBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(85, 92);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(275, 22);
            this.idTextBox.TabIndex = 1;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(30, 123);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(49, 17);
            nameLabel.TabIndex = 2;
            nameLabel.Text = "Name:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.informationSetBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(85, 120);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(275, 22);
            this.nameTextBox.TabIndex = 3;
            // 
            // ageLabel
            // 
            ageLabel.AutoSize = true;
            ageLabel.Location = new System.Drawing.Point(42, 151);
            ageLabel.Name = "ageLabel";
            ageLabel.Size = new System.Drawing.Size(37, 17);
            ageLabel.TabIndex = 4;
            ageLabel.Text = "Age:";
            // 
            // ageTextBox
            // 
            this.ageTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.informationSetBindingSource, "Age", true));
            this.ageTextBox.Location = new System.Drawing.Point(85, 148);
            this.ageTextBox.Name = "ageTextBox";
            this.ageTextBox.Size = new System.Drawing.Size(275, 22);
            this.ageTextBox.TabIndex = 5;
            // 
            // genderLabel
            // 
            genderLabel.AutoSize = true;
            genderLabel.Location = new System.Drawing.Point(19, 179);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new System.Drawing.Size(60, 17);
            genderLabel.TabIndex = 6;
            genderLabel.Text = "Gender:";
            // 
            // genderTextBox
            // 
            this.genderTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.informationSetBindingSource, "Gender", true));
            this.genderTextBox.Location = new System.Drawing.Point(85, 176);
            this.genderTextBox.Name = "genderTextBox";
            this.genderTextBox.Size = new System.Drawing.Size(275, 22);
            this.genderTextBox.TabIndex = 7;
            // 
            // ocupationLabel
            // 
            ocupationLabel.AutoSize = true;
            ocupationLabel.Location = new System.Drawing.Point(2, 207);
            ocupationLabel.Name = "ocupationLabel";
            ocupationLabel.Size = new System.Drawing.Size(77, 17);
            ocupationLabel.TabIndex = 8;
            ocupationLabel.Text = "Ocupation:";
            // 
            // ocupationTextBox
            // 
            this.ocupationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.informationSetBindingSource, "Ocupation", true));
            this.ocupationTextBox.Location = new System.Drawing.Point(85, 204);
            this.ocupationTextBox.Name = "ocupationTextBox";
            this.ocupationTextBox.Size = new System.Drawing.Size(275, 22);
            this.ocupationTextBox.TabIndex = 9;
            // 
            // View_details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 536);
            this.Controls.Add(this.informationSetBindingNavigator);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "View_details";
            this.Text = "View_details";
            this.Load += new System.EventHandler(this.View_details_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.infoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.informationSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.informationSetBindingNavigator)).EndInit();
            this.informationSetBindingNavigator.ResumeLayout(false);
            this.informationSetBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private InfoDataSet infoDataSet;
        private System.Windows.Forms.BindingSource informationSetBindingSource;
        private InfoDataSetTableAdapters.InformationSetTableAdapter informationSetTableAdapter;
        private InfoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator informationSetBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton informationSetBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox medicationTextBox;
        private System.Windows.Forms.TextBox symptomsTextBox;
        private System.Windows.Forms.TextBox diagnosesTextBox;
        private System.Windows.Forms.TextBox ocupationTextBox;
        private System.Windows.Forms.TextBox genderTextBox;
        private System.Windows.Forms.TextBox ageTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox idTextBox;
    }
}