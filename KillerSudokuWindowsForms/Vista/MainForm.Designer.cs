namespace KillerSudokuWindowsForms {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.panelGeneracion = new System.Windows.Forms.Panel();
            this.lblGeneracion = new System.Windows.Forms.Label();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.lblTamMax = new System.Windows.Forms.Label();
            this.lblTamMin = new System.Windows.Forms.Label();
            this.lblTam = new System.Windows.Forms.Label();
            this.trckTam = new System.Windows.Forms.TrackBar();
            this.panelOpciones = new System.Windows.Forms.Panel();
            this.lblBacktracking = new System.Windows.Forms.Label();
            this.lblCantBacktracking = new System.Windows.Forms.Label();
            this.lblOpciones = new System.Windows.Forms.Label();
            this.btnCargar = new System.Windows.Forms.Button();
            this.btnSolucionar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panelGeneracion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trckTam)).BeginInit();
            this.panelOpciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // panelGeneracion
            // 
            this.panelGeneracion.Controls.Add(this.lblGeneracion);
            this.panelGeneracion.Controls.Add(this.btnGenerar);
            this.panelGeneracion.Controls.Add(this.lblTamMax);
            this.panelGeneracion.Controls.Add(this.lblTamMin);
            this.panelGeneracion.Controls.Add(this.lblTam);
            this.panelGeneracion.Controls.Add(this.trckTam);
            this.panelGeneracion.Location = new System.Drawing.Point(802, 12);
            this.panelGeneracion.Name = "panelGeneracion";
            this.panelGeneracion.Size = new System.Drawing.Size(239, 178);
            this.panelGeneracion.TabIndex = 0;
            // 
            // lblGeneracion
            // 
            this.lblGeneracion.AccessibleName = "Sudoku generation";
            this.lblGeneracion.AutoSize = true;
            this.lblGeneracion.Font = new System.Drawing.Font("Bahnschrift Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGeneracion.Location = new System.Drawing.Point(19, -3);
            this.lblGeneracion.Name = "lblGeneracion";
            this.lblGeneracion.Size = new System.Drawing.Size(200, 23);
            this.lblGeneracion.TabIndex = 1;
            this.lblGeneracion.Text = "Generación del sudoku";
            this.lblGeneracion.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnGenerar
            // 
            this.btnGenerar.AccessibleName = "Generate button";
            this.btnGenerar.Font = new System.Drawing.Font("Bahnschrift Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerar.Location = new System.Drawing.Point(3, 138);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(233, 40);
            this.btnGenerar.TabIndex = 10;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // lblTamMax
            // 
            this.lblTamMax.AccessibleName = "Maximum size: 19";
            this.lblTamMax.AutoSize = true;
            this.lblTamMax.Font = new System.Drawing.Font("Bahnschrift Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTamMax.Location = new System.Drawing.Point(187, 96);
            this.lblTamMax.Name = "lblTamMax";
            this.lblTamMax.Size = new System.Drawing.Size(21, 18);
            this.lblTamMax.TabIndex = 5;
            this.lblTamMax.Text = "19";
            this.lblTamMax.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblTamMin
            // 
            this.lblTamMin.AccessibleName = "Minimun size: 5";
            this.lblTamMin.AutoSize = true;
            this.lblTamMin.Font = new System.Drawing.Font("Bahnschrift Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTamMin.Location = new System.Drawing.Point(46, 96);
            this.lblTamMin.Name = "lblTamMin";
            this.lblTamMin.Size = new System.Drawing.Size(16, 18);
            this.lblTamMin.TabIndex = 4;
            this.lblTamMin.Text = "5";
            // 
            // lblTam
            // 
            this.lblTam.AccessibleName = "Size of the sudoku";
            this.lblTam.AutoSize = true;
            this.lblTam.Font = new System.Drawing.Font("Bahnschrift Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTam.Location = new System.Drawing.Point(55, 48);
            this.lblTam.Name = "lblTam";
            this.lblTam.Size = new System.Drawing.Size(133, 18);
            this.lblTam.TabIndex = 3;
            this.lblTam.Text = "Tamaño del sudoku";
            this.lblTam.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // trckTam
            // 
            this.trckTam.AccessibleDescription = "Choose the size of the sudoku\'s dimensions";
            this.trckTam.AccessibleName = "Sudoku size track bar";
            this.trckTam.BackColor = System.Drawing.SystemColors.Control;
            this.trckTam.Location = new System.Drawing.Point(40, 69);
            this.trckTam.Maximum = 19;
            this.trckTam.Minimum = 5;
            this.trckTam.Name = "trckTam";
            this.trckTam.Size = new System.Drawing.Size(168, 45);
            this.trckTam.TabIndex = 2;
            this.trckTam.Value = 5;
            // 
            // panelOpciones
            // 
            this.panelOpciones.Controls.Add(this.lblBacktracking);
            this.panelOpciones.Controls.Add(this.lblCantBacktracking);
            this.panelOpciones.Controls.Add(this.lblOpciones);
            this.panelOpciones.Controls.Add(this.btnCargar);
            this.panelOpciones.Controls.Add(this.btnSolucionar);
            this.panelOpciones.Controls.Add(this.btnGuardar);
            this.panelOpciones.Location = new System.Drawing.Point(802, 338);
            this.panelOpciones.Name = "panelOpciones";
            this.panelOpciones.Size = new System.Drawing.Size(239, 219);
            this.panelOpciones.TabIndex = 1;
            // 
            // lblBacktracking
            // 
            this.lblBacktracking.AccessibleName = "Amount of backtracking done to solve sudoku";
            this.lblBacktracking.AutoSize = true;
            this.lblBacktracking.Font = new System.Drawing.Font("Bahnschrift Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBacktracking.Location = new System.Drawing.Point(187, 190);
            this.lblBacktracking.Name = "lblBacktracking";
            this.lblBacktracking.Size = new System.Drawing.Size(16, 18);
            this.lblBacktracking.TabIndex = 9;
            this.lblBacktracking.Text = "0";
            // 
            // lblCantBacktracking
            // 
            this.lblCantBacktracking.AccessibleName = "Number of backtracking";
            this.lblCantBacktracking.AutoSize = true;
            this.lblCantBacktracking.Font = new System.Drawing.Font("Bahnschrift Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantBacktracking.Location = new System.Drawing.Point(3, 190);
            this.lblCantBacktracking.Name = "lblCantBacktracking";
            this.lblCantBacktracking.Size = new System.Drawing.Size(131, 18);
            this.lblCantBacktracking.TabIndex = 8;
            this.lblCantBacktracking.Text = "Num backtracking:";
            // 
            // lblOpciones
            // 
            this.lblOpciones.AccessibleName = "Options";
            this.lblOpciones.AutoSize = true;
            this.lblOpciones.Font = new System.Drawing.Font("Bahnschrift Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpciones.Location = new System.Drawing.Point(85, 0);
            this.lblOpciones.Name = "lblOpciones";
            this.lblOpciones.Size = new System.Drawing.Size(87, 23);
            this.lblOpciones.TabIndex = 4;
            this.lblOpciones.Text = "Opciones";
            this.lblOpciones.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // btnCargar
            // 
            this.btnCargar.AccessibleName = "Load template button";
            this.btnCargar.Font = new System.Drawing.Font("Bahnschrift Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargar.Location = new System.Drawing.Point(3, 57);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(122, 40);
            this.btnCargar.TabIndex = 6;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnSolucionar
            // 
            this.btnSolucionar.AccessibleName = "Solve button";
            this.btnSolucionar.Font = new System.Drawing.Font("Bahnschrift Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSolucionar.Location = new System.Drawing.Point(3, 126);
            this.btnSolucionar.Name = "btnSolucionar";
            this.btnSolucionar.Size = new System.Drawing.Size(233, 40);
            this.btnSolucionar.TabIndex = 5;
            this.btnSolucionar.Text = "Solucionar";
            this.btnSolucionar.UseVisualStyleBackColor = true;
            this.btnSolucionar.Click += new System.EventHandler(this.btnSolucionar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.AccessibleName = "Save template button";
            this.btnGuardar.Font = new System.Drawing.Font("Bahnschrift Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(131, 57);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(105, 40);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(784, 545);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 569);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panelOpciones);
            this.Controls.Add(this.panelGeneracion);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Killer Sudoku";
            this.panelGeneracion.ResumeLayout(false);
            this.panelGeneracion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trckTam)).EndInit();
            this.panelOpciones.ResumeLayout(false);
            this.panelOpciones.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Panel panelGeneracion;
        private System.Windows.Forms.Label lblGeneracion;
        private System.Windows.Forms.Panel panelOpciones;
        private System.Windows.Forms.Label lblTam;
        private System.Windows.Forms.TrackBar trckTam;
        private System.Windows.Forms.Label lblOpciones;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Button btnSolucionar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblTamMax;
        private System.Windows.Forms.Label lblTamMin;
        private System.Windows.Forms.Label lblBacktracking;
        private System.Windows.Forms.Label lblCantBacktracking;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}

