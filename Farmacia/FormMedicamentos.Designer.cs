﻿namespace Farmacia
{
    partial class FormMedicamentos
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
            System.Windows.Forms.Label activoLabel;
            System.Windows.Forms.Label descripcionLabel;
            System.Windows.Forms.Label existenciaLabel;
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label precioLabel;
            System.Windows.Forms.Label tipoIdLabel;
            System.Windows.Forms.Label categoriaIdLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMedicamentos));
            this.listaMedicamentosBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.listaMedicamentosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.listaMedicamentosBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonCancelar = new System.Windows.Forms.ToolStripButton();
            this.activoCheckBox = new System.Windows.Forms.CheckBox();
            this.descripcionTextBox = new System.Windows.Forms.TextBox();
            this.existenciaTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.precioTextBox = new System.Windows.Forms.TextBox();
            this.fotoPictureBox = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.listaTiposBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tipoIdComboBox = new System.Windows.Forms.ComboBox();
            this.listaCategoriasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoriaIdComboBox = new System.Windows.Forms.ComboBox();
            activoLabel = new System.Windows.Forms.Label();
            descripcionLabel = new System.Windows.Forms.Label();
            existenciaLabel = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            precioLabel = new System.Windows.Forms.Label();
            tipoIdLabel = new System.Windows.Forms.Label();
            categoriaIdLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.listaMedicamentosBindingNavigator)).BeginInit();
            this.listaMedicamentosBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaMedicamentosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fotoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaTiposBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaCategoriasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // activoLabel
            // 
            activoLabel.AutoSize = true;
            activoLabel.Location = new System.Drawing.Point(69, 288);
            activoLabel.Name = "activoLabel";
            activoLabel.Size = new System.Drawing.Size(40, 13);
            activoLabel.TabIndex = 1;
            activoLabel.Text = "Activo:";
            // 
            // descripcionLabel
            // 
            descripcionLabel.AutoSize = true;
            descripcionLabel.Location = new System.Drawing.Point(69, 99);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new System.Drawing.Size(66, 13);
            descripcionLabel.TabIndex = 3;
            descripcionLabel.Text = "Descripcion:";
            // 
            // existenciaLabel
            // 
            existenciaLabel.AutoSize = true;
            existenciaLabel.Location = new System.Drawing.Point(69, 247);
            existenciaLabel.Name = "existenciaLabel";
            existenciaLabel.Size = new System.Drawing.Size(58, 13);
            existenciaLabel.TabIndex = 5;
            existenciaLabel.Text = "Existencia:";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(69, 63);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 7;
            idLabel.Text = "Id:";
            // 
            // precioLabel
            // 
            precioLabel.AutoSize = true;
            precioLabel.Location = new System.Drawing.Point(69, 208);
            precioLabel.Name = "precioLabel";
            precioLabel.Size = new System.Drawing.Size(40, 13);
            precioLabel.TabIndex = 9;
            precioLabel.Text = "Precio:";
            // 
            // tipoIdLabel
            // 
            tipoIdLabel.AutoSize = true;
            tipoIdLabel.Location = new System.Drawing.Point(69, 135);
            tipoIdLabel.Name = "tipoIdLabel";
            tipoIdLabel.Size = new System.Drawing.Size(31, 13);
            tipoIdLabel.TabIndex = 14;
            tipoIdLabel.Text = "Tipo:";
            // 
            // categoriaIdLabel
            // 
            categoriaIdLabel.AutoSize = true;
            categoriaIdLabel.Location = new System.Drawing.Point(68, 175);
            categoriaIdLabel.Name = "categoriaIdLabel";
            categoriaIdLabel.Size = new System.Drawing.Size(55, 13);
            categoriaIdLabel.TabIndex = 16;
            categoriaIdLabel.Text = "Categoria:";
            // 
            // listaMedicamentosBindingNavigator
            // 
            this.listaMedicamentosBindingNavigator.AddNewItem = null;
            this.listaMedicamentosBindingNavigator.BindingSource = this.listaMedicamentosBindingSource;
            this.listaMedicamentosBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.listaMedicamentosBindingNavigator.DeleteItem = null;
            this.listaMedicamentosBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.listaMedicamentosBindingNavigatorSaveItem,
            this.toolStripButtonCancelar});
            this.listaMedicamentosBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.listaMedicamentosBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.listaMedicamentosBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.listaMedicamentosBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.listaMedicamentosBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.listaMedicamentosBindingNavigator.Name = "listaMedicamentosBindingNavigator";
            this.listaMedicamentosBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.listaMedicamentosBindingNavigator.Size = new System.Drawing.Size(650, 25);
            this.listaMedicamentosBindingNavigator.TabIndex = 0;
            this.listaMedicamentosBindingNavigator.Text = "bindingNavigator1";
            this.listaMedicamentosBindingNavigator.RefreshItems += new System.EventHandler(this.listaMedicamentosBindingNavigator_RefreshItems);
            // 
            // listaMedicamentosBindingSource
            // 
            this.listaMedicamentosBindingSource.DataMember = "listaMedicamentos";
            this.listaMedicamentosBindingSource.DataSource = typeof(BL.Farmacia.MedicamentosBL);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // listaMedicamentosBindingNavigatorSaveItem
            // 
            this.listaMedicamentosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.listaMedicamentosBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("listaMedicamentosBindingNavigatorSaveItem.Image")));
            this.listaMedicamentosBindingNavigatorSaveItem.Name = "listaMedicamentosBindingNavigatorSaveItem";
            this.listaMedicamentosBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.listaMedicamentosBindingNavigatorSaveItem.Text = "Guardar datos";
            this.listaMedicamentosBindingNavigatorSaveItem.Click += new System.EventHandler(this.listaMedicamentosBindingNavigatorSaveItem_Click);
            // 
            // toolStripButtonCancelar
            // 
            this.toolStripButtonCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonCancelar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonCancelar.Image")));
            this.toolStripButtonCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCancelar.Name = "toolStripButtonCancelar";
            this.toolStripButtonCancelar.Size = new System.Drawing.Size(57, 22);
            this.toolStripButtonCancelar.Text = "Cancelar";
            this.toolStripButtonCancelar.Visible = false;
            this.toolStripButtonCancelar.Click += new System.EventHandler(this.toolStripButtonCancelar_Click);
            // 
            // activoCheckBox
            // 
            this.activoCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.listaMedicamentosBindingSource, "Activo", true));
            this.activoCheckBox.Location = new System.Drawing.Point(141, 283);
            this.activoCheckBox.Name = "activoCheckBox";
            this.activoCheckBox.Size = new System.Drawing.Size(104, 24);
            this.activoCheckBox.TabIndex = 2;
            this.activoCheckBox.UseVisualStyleBackColor = true;
            // 
            // descripcionTextBox
            // 
            this.descripcionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaMedicamentosBindingSource, "Descripcion", true));
            this.descripcionTextBox.Location = new System.Drawing.Point(141, 96);
            this.descripcionTextBox.Name = "descripcionTextBox";
            this.descripcionTextBox.Size = new System.Drawing.Size(180, 20);
            this.descripcionTextBox.TabIndex = 4;
            // 
            // existenciaTextBox
            // 
            this.existenciaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaMedicamentosBindingSource, "Existencia", true));
            this.existenciaTextBox.Location = new System.Drawing.Point(141, 244);
            this.existenciaTextBox.Name = "existenciaTextBox";
            this.existenciaTextBox.Size = new System.Drawing.Size(180, 20);
            this.existenciaTextBox.TabIndex = 6;
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaMedicamentosBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(141, 60);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(180, 20);
            this.idTextBox.TabIndex = 8;
            // 
            // precioTextBox
            // 
            this.precioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaMedicamentosBindingSource, "Precio", true));
            this.precioTextBox.Location = new System.Drawing.Point(141, 205);
            this.precioTextBox.Name = "precioTextBox";
            this.precioTextBox.Size = new System.Drawing.Size(180, 20);
            this.precioTextBox.TabIndex = 10;
            // 
            // fotoPictureBox
            // 
            this.fotoPictureBox.BackColor = System.Drawing.Color.Silver;
            this.fotoPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.listaMedicamentosBindingSource, "Foto", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.fotoPictureBox.Location = new System.Drawing.Point(363, 60);
            this.fotoPictureBox.Name = "fotoPictureBox";
            this.fotoPictureBox.Size = new System.Drawing.Size(225, 168);
            this.fotoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fotoPictureBox.TabIndex = 12;
            this.fotoPictureBox.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(363, 248);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Agregar Foto";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(499, 248);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Remover";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "jpg, png | *.jpg; *.png";
            // 
            // listaTiposBindingSource
            // 
            this.listaTiposBindingSource.DataSource = typeof(BL.Farmacia.Tipo);
            // 
            // tipoIdComboBox
            // 
            this.tipoIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.listaMedicamentosBindingSource, "TipoId", true));
            this.tipoIdComboBox.DataSource = this.listaTiposBindingSource;
            this.tipoIdComboBox.DisplayMember = "Descripcion";
            this.tipoIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tipoIdComboBox.FormattingEnabled = true;
            this.tipoIdComboBox.Location = new System.Drawing.Point(141, 132);
            this.tipoIdComboBox.Name = "tipoIdComboBox";
            this.tipoIdComboBox.Size = new System.Drawing.Size(180, 21);
            this.tipoIdComboBox.TabIndex = 15;
            this.tipoIdComboBox.ValueMember = "Id";
            // 
            // listaCategoriasBindingSource
            // 
            this.listaCategoriasBindingSource.DataSource = typeof(BL.Farmacia.Categoria);
            // 
            // categoriaIdComboBox
            // 
            this.categoriaIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.listaMedicamentosBindingSource, "CategoriaId", true));
            this.categoriaIdComboBox.DataSource = this.listaCategoriasBindingSource;
            this.categoriaIdComboBox.DisplayMember = "Descripcion";
            this.categoriaIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoriaIdComboBox.FormattingEnabled = true;
            this.categoriaIdComboBox.Location = new System.Drawing.Point(141, 172);
            this.categoriaIdComboBox.Name = "categoriaIdComboBox";
            this.categoriaIdComboBox.Size = new System.Drawing.Size(180, 21);
            this.categoriaIdComboBox.TabIndex = 17;
            this.categoriaIdComboBox.ValueMember = "Id";
            // 
            // FormMedicamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 543);
            this.Controls.Add(categoriaIdLabel);
            this.Controls.Add(this.categoriaIdComboBox);
            this.Controls.Add(tipoIdLabel);
            this.Controls.Add(this.tipoIdComboBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.fotoPictureBox);
            this.Controls.Add(activoLabel);
            this.Controls.Add(this.activoCheckBox);
            this.Controls.Add(descripcionLabel);
            this.Controls.Add(this.descripcionTextBox);
            this.Controls.Add(existenciaLabel);
            this.Controls.Add(this.existenciaTextBox);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(precioLabel);
            this.Controls.Add(this.precioTextBox);
            this.Controls.Add(this.listaMedicamentosBindingNavigator);
            this.Name = "FormMedicamentos";
            this.Text = "Medicamentos";
            ((System.ComponentModel.ISupportInitialize)(this.listaMedicamentosBindingNavigator)).EndInit();
            this.listaMedicamentosBindingNavigator.ResumeLayout(false);
            this.listaMedicamentosBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaMedicamentosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fotoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaTiposBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaCategoriasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource listaMedicamentosBindingSource;
        private System.Windows.Forms.BindingNavigator listaMedicamentosBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton listaMedicamentosBindingNavigatorSaveItem;
        private System.Windows.Forms.CheckBox activoCheckBox;
        private System.Windows.Forms.TextBox descripcionTextBox;
        private System.Windows.Forms.TextBox existenciaTextBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox precioTextBox;
        private System.Windows.Forms.ToolStripButton toolStripButtonCancelar;
        private System.Windows.Forms.PictureBox fotoPictureBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.BindingSource listaTiposBindingSource;
        private System.Windows.Forms.ComboBox tipoIdComboBox;
        private System.Windows.Forms.BindingSource listaCategoriasBindingSource;
        private System.Windows.Forms.ComboBox categoriaIdComboBox;
    }
}