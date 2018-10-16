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
            this.panelOpciones = new System.Windows.Forms.Panel();
            this.lblGeneracion = new System.Windows.Forms.Label();
            this.trckTam = new System.Windows.Forms.TrackBar();
            this.lblTam = new System.Windows.Forms.Label();
            this.lblOpciones = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnSolucionar = new System.Windows.Forms.Button();
            this.btnCargar = new System.Windows.Forms.Button();
            this.lblTamMin = new System.Windows.Forms.Label();
            this.lblTamMax = new System.Windows.Forms.Label();
            this.lblCantBacktracking = new System.Windows.Forms.Label();
            this.lblBacktracking = new System.Windows.Forms.Label();
            this.panelTablaLayout = new System.Windows.Forms.TableLayoutPanel();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panelGeneracion.SuspendLayout();
            this.panelOpciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trckTam)).BeginInit();
            this.SuspendLayout();
            // 
            // panelGeneracion
            // 
            this.panelGeneracion.Controls.Add(this.lblGeneracion);
            this.panelGeneracion.Controls.Add(this.btnGenerar);
            this.panelGeneracion.Controls.Add(this.lblTamMax);
            this.panelGeneracion.Controls.Add(this.lblTamMin);
            this.panelGeneracion.Controls.Add(this.lblTam);
            this.panelGeneracion.Controls.Add(this.trckTam);
            this.panelGeneracion.Location = new System.Drawing.Point(498, 17);
            this.panelGeneracion.Name = "panelGeneracion";
            this.panelGeneracion.Size = new System.Drawing.Size(286, 178);
            this.panelGeneracion.TabIndex = 0;
            // 
            // panelOpciones
            // 
            this.panelOpciones.Controls.Add(this.lblBacktracking);
            this.panelOpciones.Controls.Add(this.lblCantBacktracking);
            this.panelOpciones.Controls.Add(this.lblOpciones);
            this.panelOpciones.Controls.Add(this.btnCargar);
            this.panelOpciones.Controls.Add(this.btnSolucionar);
            this.panelOpciones.Controls.Add(this.btnGuardar);
            this.panelOpciones.Location = new System.Drawing.Point(498, 219);
            this.panelOpciones.Name = "panelOpciones";
            this.panelOpciones.Size = new System.Drawing.Size(286, 219);
            this.panelOpciones.TabIndex = 1;
            // 
            // lblGeneracion
            // 
            this.lblGeneracion.AccessibleName = "Sudoku generation";
            this.lblGeneracion.AutoSize = true;
            this.lblGeneracion.Font = new System.Drawing.Font("Bahnschrift Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGeneracion.Location = new System.Drawing.Point(40, 0);
            this.lblGeneracion.Name = "lblGeneracion";
            this.lblGeneracion.Size = new System.Drawing.Size(200, 23);
            this.lblGeneracion.TabIndex = 1;
            this.lblGeneracion.Text = "Generación del sudoku";
            this.lblGeneracion.Click += new System.EventHandler(this.label1_Click);
            // 
            // trckTam
            // 
            this.trckTam.AccessibleDescription = "Choose the size of the sudoku\'s dimensions";
            this.trckTam.AccessibleName = "Sudoku size track bar";
            this.trckTam.BackColor = System.Drawing.SystemColors.Control;
            this.trckTam.Location = new System.Drawing.Point(13, 69);
            this.trckTam.Maximum = 19;
            this.trckTam.Minimum = 5;
            this.trckTam.Name = "trckTam";
            this.trckTam.Size = new System.Drawing.Size(260, 45);
            this.trckTam.TabIndex = 2;
            this.trckTam.Value = 5;
            // 
            // lblTam
            // 
            this.lblTam.AccessibleName = "Size of the sudoku";
            this.lblTam.AutoSize = true;
            this.lblTam.Font = new System.Drawing.Font("Bahnschrift Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTam.Location = new System.Drawing.Point(21, 48);
            this.lblTam.Name = "lblTam";
            this.lblTam.Size = new System.Drawing.Size(133, 18);
            this.lblTam.TabIndex = 3;
            this.lblTam.Text = "Tamaño del sudoku";
            this.lblTam.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lblOpciones
            // 
            this.lblOpciones.AccessibleName = "Options";
            this.lblOpciones.AutoSize = true;
            this.lblOpciones.Font = new System.Drawing.Font("Bahnschrift Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpciones.Location = new System.Drawing.Point(101, 0);
            this.lblOpciones.Name = "lblOpciones";
            this.lblOpciones.Size = new System.Drawing.Size(87, 23);
            this.lblOpciones.TabIndex = 4;
            this.lblOpciones.Text = "Opciones";
            this.lblOpciones.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // btnGuardar
            // 
            this.btnGuardar.AccessibleName = "Save template button";
            this.btnGuardar.Font = new System.Drawing.Font("Bahnschrift Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(146, 57);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(127, 40);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "Guardar plantilla";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnSolucionar
            // 
            this.btnSolucionar.AccessibleName = "Solve button";
            this.btnSolucionar.Font = new System.Drawing.Font("Bahnschrift Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSolucionar.Location = new System.Drawing.Point(13, 112);
            this.btnSolucionar.Name = "btnSolucionar";
            this.btnSolucionar.Size = new System.Drawing.Size(260, 40);
            this.btnSolucionar.TabIndex = 5;
            this.btnSolucionar.Text = "Solucionar";
            this.btnSolucionar.UseVisualStyleBackColor = true;
            // 
            // btnCargar
            // 
            this.btnCargar.AccessibleName = "Load template button";
            this.btnCargar.Font = new System.Drawing.Font("Bahnschrift Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargar.Location = new System.Drawing.Point(13, 57);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(127, 40);
            this.btnCargar.TabIndex = 6;
            this.btnCargar.Text = "Cargar plantilla";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.button3_Click);
            // 
            // lblTamMin
            // 
            this.lblTamMin.AccessibleName = "Minimun size: 5";
            this.lblTamMin.AutoSize = true;
            this.lblTamMin.Font = new System.Drawing.Font("Bahnschrift Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTamMin.Location = new System.Drawing.Point(20, 101);
            this.lblTamMin.Name = "lblTamMin";
            this.lblTamMin.Size = new System.Drawing.Size(16, 18);
            this.lblTamMin.TabIndex = 4;
            this.lblTamMin.Text = "5";
            // 
            // lblTamMax
            // 
            this.lblTamMax.AccessibleName = "Maximum size: 19";
            this.lblTamMax.AutoSize = true;
            this.lblTamMax.Font = new System.Drawing.Font("Bahnschrift Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTamMax.Location = new System.Drawing.Point(251, 101);
            this.lblTamMax.Name = "lblTamMax";
            this.lblTamMax.Size = new System.Drawing.Size(21, 18);
            this.lblTamMax.TabIndex = 5;
            this.lblTamMax.Text = "19";
            this.lblTamMax.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblCantBacktracking
            // 
            this.lblCantBacktracking.AccessibleName = "Number of backtracking";
            this.lblCantBacktracking.AutoSize = true;
            this.lblCantBacktracking.Font = new System.Drawing.Font("Bahnschrift Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantBacktracking.Location = new System.Drawing.Point(10, 190);
            this.lblCantBacktracking.Name = "lblCantBacktracking";
            this.lblCantBacktracking.Size = new System.Drawing.Size(131, 18);
            this.lblCantBacktracking.TabIndex = 8;
            this.lblCantBacktracking.Text = "Num backtracking:";
            // 
            // lblBacktracking
            // 
            this.lblBacktracking.AccessibleName = "Amount of backtracking done to solve sudoku";
            this.lblBacktracking.AutoSize = true;
            this.lblBacktracking.Font = new System.Drawing.Font("Bahnschrift Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBacktracking.Location = new System.Drawing.Point(252, 190);
            this.lblBacktracking.Name = "lblBacktracking";
            this.lblBacktracking.Size = new System.Drawing.Size(16, 18);
            this.lblBacktracking.TabIndex = 9;
            this.lblBacktracking.Text = "0";
            // 
            // panelTablaLayout
            // 
            this.panelTablaLayout.AutoSize = true;
            this.panelTablaLayout.ColumnCount = 5;
            this.panelTablaLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.panelTablaLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.panelTablaLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.panelTablaLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.panelTablaLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.panelTablaLayout.Location = new System.Drawing.Point(13, 17);
            this.panelTablaLayout.Name = "panelTablaLayout";
            this.panelTablaLayout.RowCount = 5;
            this.panelTablaLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panelTablaLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panelTablaLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panelTablaLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panelTablaLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panelTablaLayout.Size = new System.Drawing.Size(479, 421);
            this.panelTablaLayout.TabIndex = 2;
            // 
            // btnGenerar
            // 
            this.btnGenerar.AccessibleName = "Generate button";
            this.btnGenerar.Font = new System.Drawing.Font("Bahnschrift Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerar.Location = new System.Drawing.Point(13, 135);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(260, 40);
            this.btnGenerar.TabIndex = 10;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelTablaLayout);
            this.Controls.Add(this.panelOpciones);
            this.Controls.Add(this.panelGeneracion);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Killer Sudoku";
            this.panelGeneracion.ResumeLayout(false);
            this.panelGeneracion.PerformLayout();
            this.panelOpciones.ResumeLayout(false);
            this.panelOpciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trckTam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.TableLayoutPanel panelTablaLayout;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

