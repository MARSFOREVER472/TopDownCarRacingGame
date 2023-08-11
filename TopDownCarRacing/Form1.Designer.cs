namespace TopDownCarRacing
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Player = new System.Windows.Forms.PictureBox();
            this.explosion = new System.Windows.Forms.PictureBox();
            this.logros = new System.Windows.Forms.PictureBox();
            this.AI2 = new System.Windows.Forms.PictureBox();
            this.AI1 = new System.Windows.Forms.PictureBox();
            this.pistaCircuito2 = new System.Windows.Forms.PictureBox();
            this.pistaCircuito1 = new System.Windows.Forms.PictureBox();
            this.botonInicio = new System.Windows.Forms.Button();
            this.lblScore = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.explosion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AI2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AI1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pistaCircuito2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pistaCircuito1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.Player);
            this.panel1.Controls.Add(this.explosion);
            this.panel1.Controls.Add(this.logros);
            this.panel1.Controls.Add(this.AI2);
            this.panel1.Controls.Add(this.AI1);
            this.panel1.Controls.Add(this.pistaCircuito2);
            this.panel1.Controls.Add(this.pistaCircuito1);
            this.panel1.Location = new System.Drawing.Point(20, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(450, 532);
            this.panel1.TabIndex = 0;
            // 
            // Player
            // 
            this.Player.Image = global::TopDownCarRacing.Properties.Resources.carYellow;
            this.Player.Location = new System.Drawing.Point(205, 375);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(50, 99);
            this.Player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Player.TabIndex = 6;
            this.Player.TabStop = false;
            // 
            // explosion
            // 
            this.explosion.Image = global::TopDownCarRacing.Properties.Resources.explosion;
            this.explosion.Location = new System.Drawing.Point(75, 375);
            this.explosion.Name = "explosion";
            this.explosion.Size = new System.Drawing.Size(64, 64);
            this.explosion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.explosion.TabIndex = 5;
            this.explosion.TabStop = false;
            // 
            // logros
            // 
            this.logros.Image = global::TopDownCarRacing.Properties.Resources.bronze;
            this.logros.Location = new System.Drawing.Point(50, 200);
            this.logros.Name = "logros";
            this.logros.Size = new System.Drawing.Size(250, 100);
            this.logros.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.logros.TabIndex = 4;
            this.logros.TabStop = false;
            // 
            // AI2
            // 
            this.AI2.Image = global::TopDownCarRacing.Properties.Resources.carGrey;
            this.AI2.Location = new System.Drawing.Point(350, 25);
            this.AI2.Name = "AI2";
            this.AI2.Size = new System.Drawing.Size(50, 100);
            this.AI2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.AI2.TabIndex = 3;
            this.AI2.TabStop = false;
            this.AI2.Tag = "carRight";
            // 
            // AI1
            // 
            this.AI1.Image = global::TopDownCarRacing.Properties.Resources.carGreen;
            this.AI1.Location = new System.Drawing.Point(50, 25);
            this.AI1.Name = "AI1";
            this.AI1.Size = new System.Drawing.Size(50, 101);
            this.AI1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.AI1.TabIndex = 2;
            this.AI1.TabStop = false;
            this.AI1.Tag = "carLeft";
            // 
            // pistaCircuito2
            // 
            this.pistaCircuito2.Image = global::TopDownCarRacing.Properties.Resources.roadTrack;
            this.pistaCircuito2.Location = new System.Drawing.Point(0, 0);
            this.pistaCircuito2.Name = "pistaCircuito2";
            this.pistaCircuito2.Size = new System.Drawing.Size(450, 532);
            this.pistaCircuito2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pistaCircuito2.TabIndex = 1;
            this.pistaCircuito2.TabStop = false;
            // 
            // pistaCircuito1
            // 
            this.pistaCircuito1.Image = global::TopDownCarRacing.Properties.Resources.roadTrack;
            this.pistaCircuito1.Location = new System.Drawing.Point(0, -425);
            this.pistaCircuito1.Name = "pistaCircuito1";
            this.pistaCircuito1.Size = new System.Drawing.Size(450, 424);
            this.pistaCircuito1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pistaCircuito1.TabIndex = 0;
            this.pistaCircuito1.TabStop = false;
            // 
            // botonInicio
            // 
            this.botonInicio.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonInicio.Location = new System.Drawing.Point(190, 580);
            this.botonInicio.Name = "botonInicio";
            this.botonInicio.Size = new System.Drawing.Size(100, 50);
            this.botonInicio.TabIndex = 1;
            this.botonInicio.Text = "Start";
            this.botonInicio.UseVisualStyleBackColor = true;
            // 
            // lblScore
            // 
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(185, 550);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(120, 27);
            this.lblScore.TabIndex = 2;
            this.lblScore.Text = "Score: 0";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 650);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(475, 103);
            this.label2.TabIndex = 3;
            this.label2.Text = "Use Left and Right Key to move the car.\r\n\r\nDon\'t hit any other cars in the game a" +
    "nd survive as long as you can.\r\n";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.EventoTemporizadorJuego);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 764);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.botonInicio);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Car Racing Game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TeclaPresionada);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TeclaSoltada);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.explosion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AI2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AI1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pistaCircuito2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pistaCircuito1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button botonInicio;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pistaCircuito1;
        private System.Windows.Forms.PictureBox pistaCircuito2;
        private System.Windows.Forms.PictureBox logros;
        private System.Windows.Forms.PictureBox AI2;
        private System.Windows.Forms.PictureBox AI1;
        private System.Windows.Forms.PictureBox Player;
        private System.Windows.Forms.PictureBox explosion;
        private System.Windows.Forms.Timer gameTimer;
    }
}

