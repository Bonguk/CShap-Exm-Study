namespace CuteCat
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.CatSceen = new System.Windows.Forms.Label();
            this.Play = new System.Windows.Forms.Button();
            this.Feed = new System.Windows.Forms.Button();
            this.CatTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // CatSceen
            // 
            this.CatSceen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CatSceen.Location = new System.Drawing.Point(13, 16);
            this.CatSceen.Name = "CatSceen";
            this.CatSceen.Size = new System.Drawing.Size(303, 65);
            this.CatSceen.TabIndex = 0;
            this.CatSceen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Play
            // 
            this.Play.Location = new System.Drawing.Point(13, 104);
            this.Play.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(66, 39);
            this.Play.TabIndex = 1;
            this.Play.Text = "Play";
            this.Play.UseVisualStyleBackColor = true;
            this.Play.Click += new System.EventHandler(this.Play_Click);
            // 
            // Feed
            // 
            this.Feed.Location = new System.Drawing.Point(93, 104);
            this.Feed.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Feed.Name = "Feed";
            this.Feed.Size = new System.Drawing.Size(71, 39);
            this.Feed.TabIndex = 2;
            this.Feed.Text = "Feed";
            this.Feed.UseVisualStyleBackColor = true;
            this.Feed.Click += new System.EventHandler(this.Feed_Click);
            // 
            // CatTimer
            // 
            this.CatTimer.Enabled = true;
            this.CatTimer.Interval = 5000;
            this.CatTimer.Tick += new System.EventHandler(this.CatTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 414);
            this.Controls.Add(this.Feed);
            this.Controls.Add(this.Play);
            this.Controls.Add(this.CatSceen);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label CatSceen;
        private System.Windows.Forms.Button Play;
        private System.Windows.Forms.Button Feed;
        private System.Windows.Forms.Timer CatTimer;
    }
}

