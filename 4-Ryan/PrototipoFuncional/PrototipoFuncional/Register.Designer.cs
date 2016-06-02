namespace PrototipoFuncional
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label ageLabel;
            System.Windows.Forms.Label genderLabel;
            System.Windows.Forms.Label ocupationLabel;
            System.Windows.Forms.Label symptomsLabel;
            System.Windows.Forms.Label medicationLabel;
            System.Windows.Forms.Label diagnosesLabel;
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
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.ageTextBox = new System.Windows.Forms.TextBox();
            this.genderTextBox = new System.Windows.Forms.TextBox();
            this.ocupationTextBox = new System.Windows.Forms.TextBox();
            this.symptomsTextBox = new System.Windows.Forms.TextBox();
            this.medicationTextBox = new System.Windows.Forms.TextBox();
            this.diagnosesTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            idLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            ageLabel = new System.Windows.Forms.Label();
            genderLabel = new System.Windows.Forms.Label();
            ocupationLabel = new System.Windows.Forms.Label();
            symptomsLabel = new System.Windows.Forms.Label();
            medicationLabel = new System.Windows.Forms.Label();
            diagnosesLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.infoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.informationSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.informationSetBindingNavigator)).BeginInit();
            this.informationSetBindingNavigator.SuspendLayout();
            this.SuspendLayout();
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
            this.informationSetBindingNavigator.Size = new System.Drawing.Size(646, 27);
            this.informationSetBindingNavigator.TabIndex = 0;
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
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(12, 63);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(23, 17);
            idLabel.TabIndex = 1;
            idLabel.Text = "Id:";
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.informationSetBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(98, 60);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(166, 22);
            this.idTextBox.TabIndex = 2;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(12, 91);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(49, 17);
            nameLabel.TabIndex = 3;
            nameLabel.Text = "Name:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.informationSetBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(98, 88);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(166, 22);
            this.nameTextBox.TabIndex = 4;
            // 
            // ageLabel
            // 
            ageLabel.AutoSize = true;
            ageLabel.Location = new System.Drawing.Point(12, 119);
            ageLabel.Name = "ageLabel";
            ageLabel.Size = new System.Drawing.Size(37, 17);
            ageLabel.TabIndex = 5;
            ageLabel.Text = "Age:";
            // 
            // ageTextBox
            // 
            this.ageTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.informationSetBindingSource, "Age", true));
            this.ageTextBox.Location = new System.Drawing.Point(98, 116);
            this.ageTextBox.Name = "ageTextBox";
            this.ageTextBox.Size = new System.Drawing.Size(166, 22);
            this.ageTextBox.TabIndex = 6;
            // 
            // genderLabel
            // 
            genderLabel.AutoSize = true;
            genderLabel.Location = new System.Drawing.Point(12, 147);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new System.Drawing.Size(60, 17);
            genderLabel.TabIndex = 7;
            genderLabel.Text = "Gender:";
            // 
            // genderTextBox
            // 
            this.genderTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.informationSetBindingSource, "Gender", true));
            this.genderTextBox.Location = new System.Drawing.Point(98, 144);
            this.genderTextBox.Name = "genderTextBox";
            this.genderTextBox.Size = new System.Drawing.Size(166, 22);
            this.genderTextBox.TabIndex = 8;
            // 
            // ocupationLabel
            // 
            ocupationLabel.AutoSize = true;
            ocupationLabel.Location = new System.Drawing.Point(12, 175);
            ocupationLabel.Name = "ocupationLabel";
            ocupationLabel.Size = new System.Drawing.Size(77, 17);
            ocupationLabel.TabIndex = 9;
            ocupationLabel.Text = "Ocupation:";
            // 
            // ocupationTextBox
            // 
            this.ocupationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.informationSetBindingSource, "Ocupation", true));
            this.ocupationTextBox.Location = new System.Drawing.Point(98, 172);
            this.ocupationTextBox.Name = "ocupationTextBox";
            this.ocupationTextBox.Size = new System.Drawing.Size(166, 22);
            this.ocupationTextBox.TabIndex = 10;
            // 
            // symptomsLabel
            // 
            symptomsLabel.AutoSize = true;
            symptomsLabel.Location = new System.Drawing.Point(48, 230);
            symptomsLabel.Name = "symptomsLabel";
            symptomsLabel.Size = new System.Drawing.Size(77, 17);
            symptomsLabel.TabIndex = 11;
            symptomsLabel.Text = "Symptoms:";
            // 
            // symptomsTextBox
            // 
            this.symptomsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.informationSetBindingSource, "Symptoms", true));
            this.symptomsTextBox.Location = new System.Drawing.Point(134, 227);
            this.symptomsTextBox.Name = "symptomsTextBox";
            this.symptomsTextBox.Size = new System.Drawing.Size(302, 22);
            this.symptomsTextBox.TabIndex = 12;
            // 
            // medicationLabel
            // 
            medicationLabel.AutoSize = true;
            medicationLabel.Location = new System.Drawing.Point(48, 258);
            medicationLabel.Name = "medicationLabel";
            medicationLabel.Size = new System.Drawing.Size(80, 17);
            medicationLabel.TabIndex = 13;
            medicationLabel.Text = "Medication:";
            // 
            // medicationTextBox
            // 
            this.medicationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.informationSetBindingSource, "Medication", true));
            this.medicationTextBox.Location = new System.Drawing.Point(134, 255);
            this.medicationTextBox.Name = "medicationTextBox";
            this.medicationTextBox.Size = new System.Drawing.Size(302, 22);
            this.medicationTextBox.TabIndex = 14;
            // 
            // diagnosesLabel
            // 
            diagnosesLabel.AutoSize = true;
            diagnosesLabel.Location = new System.Drawing.Point(48, 286);
            diagnosesLabel.Name = "diagnosesLabel";
            diagnosesLabel.Size = new System.Drawing.Size(79, 17);
            diagnosesLabel.TabIndex = 15;
            diagnosesLabel.Text = "Diagnoses:";
            // 
            // diagnosesTextBox
            // 
            this.diagnosesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.informationSetBindingSource, "Diagnoses", true));
            this.diagnosesTextBox.Location = new System.Drawing.Point(134, 283);
            this.diagnosesTextBox.Name = "diagnosesTextBox";
            this.diagnosesTextBox.Size = new System.Drawing.Size(302, 22);
            this.diagnosesTextBox.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 334);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 31);
            this.button1.TabIndex = 17;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(545, 334);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 31);
            this.button2.TabIndex = 18;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 377);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(ageLabel);
            this.Controls.Add(this.ageTextBox);
            this.Controls.Add(genderLabel);
            this.Controls.Add(this.genderTextBox);
            this.Controls.Add(ocupationLabel);
            this.Controls.Add(this.ocupationTextBox);
            this.Controls.Add(symptomsLabel);
            this.Controls.Add(this.symptomsTextBox);
            this.Controls.Add(medicationLabel);
            this.Controls.Add(this.medicationTextBox);
            this.Controls.Add(diagnosesLabel);
            this.Controls.Add(this.diagnosesTextBox);
            this.Controls.Add(this.informationSetBindingNavigator);
            this.Name = "Register";
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Register_Load);
            ((System.ComponentModel.ISupportInitialize)(this.infoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.informationSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.informationSetBindingNavigator)).EndInit();
            this.informationSetBindingNavigator.ResumeLayout(false);
            this.informationSetBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox ageTextBox;
        private System.Windows.Forms.TextBox genderTextBox;
        private System.Windows.Forms.TextBox ocupationTextBox;
        private System.Windows.Forms.TextBox symptomsTextBox;
        private System.Windows.Forms.TextBox medicationTextBox;
        private System.Windows.Forms.TextBox diagnosesTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}