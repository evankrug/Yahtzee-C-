
namespace Yahtzee_game
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.diceImageList = new System.Windows.Forms.ImageList(this.components);
            this.txtPlayerName = new System.Windows.Forms.TextBox();
            this.btnAddPlayer = new System.Windows.Forms.Button();
            this.btnStartGame = new System.Windows.Forms.Button();
            this.lblAddPlayerMsg = new System.Windows.Forms.Label();
            this.boxDieFive = new System.Windows.Forms.CheckBox();
            this.boxDieFour = new System.Windows.Forms.CheckBox();
            this.boxDieThree = new System.Windows.Forms.CheckBox();
            this.boxDieTwo = new System.Windows.Forms.CheckBox();
            this.boxDieOne = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // diceImageList
            // 
            this.diceImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("diceImageList.ImageStream")));
            this.diceImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.diceImageList.Images.SetKeyName(0, "one die.PNG");
            this.diceImageList.Images.SetKeyName(1, "die 2.PNG");
            this.diceImageList.Images.SetKeyName(2, "die 3.PNG");
            this.diceImageList.Images.SetKeyName(3, "die 4.PNG");
            this.diceImageList.Images.SetKeyName(4, "die 5.PNG");
            this.diceImageList.Images.SetKeyName(5, "die 6.PNG");
            // 
            // txtPlayerName
            // 
            this.txtPlayerName.Location = new System.Drawing.Point(595, 91);
            this.txtPlayerName.Margin = new System.Windows.Forms.Padding(2);
            this.txtPlayerName.Name = "txtPlayerName";
            this.txtPlayerName.Size = new System.Drawing.Size(200, 20);
            this.txtPlayerName.TabIndex = 11;
           
            // 
            // btnAddPlayer
            // 
            this.btnAddPlayer.Location = new System.Drawing.Point(595, 128);
            this.btnAddPlayer.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddPlayer.Name = "btnAddPlayer";
            this.btnAddPlayer.Size = new System.Drawing.Size(83, 31);
            this.btnAddPlayer.TabIndex = 13;
            this.btnAddPlayer.Text = "Add Player";
            this.btnAddPlayer.UseVisualStyleBackColor = true;
            this.btnAddPlayer.Click += new System.EventHandler(this.btnAddPlayer_Click);
            // 
            // btnStartGame
            // 
            this.btnStartGame.Location = new System.Drawing.Point(708, 129);
            this.btnStartGame.Margin = new System.Windows.Forms.Padding(2);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(86, 30);
            this.btnStartGame.TabIndex = 14;
            this.btnStartGame.Text = "Start Game";
            this.btnStartGame.UseVisualStyleBackColor = true;
            this.btnStartGame.Click += new System.EventHandler(this.btnStartGame_Click);
            // 
            // lblAddPlayerMsg
            // 
            this.lblAddPlayerMsg.AutoSize = true;
            this.lblAddPlayerMsg.Location = new System.Drawing.Point(604, 62);
            this.lblAddPlayerMsg.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddPlayerMsg.Name = "lblAddPlayerMsg";
            this.lblAddPlayerMsg.Size = new System.Drawing.Size(0, 13);
            this.lblAddPlayerMsg.TabIndex = 15;
            // 
            // boxDieFive
            // 
            this.boxDieFive.AutoSize = true;
            this.boxDieFive.Image = global::Yahtzee_game.Properties.Resources.die1;
            this.boxDieFive.Location = new System.Drawing.Point(822, 258);
            this.boxDieFive.Margin = new System.Windows.Forms.Padding(2);
            this.boxDieFive.Name = "boxDieFive";
            this.boxDieFive.Size = new System.Drawing.Size(139, 127);
            this.boxDieFive.TabIndex = 10;
            this.boxDieFive.Text = "Die 5";
            this.boxDieFive.UseVisualStyleBackColor = true;
            // 
            // boxDieFour
            // 
            this.boxDieFour.AutoSize = true;
            this.boxDieFour.Image = global::Yahtzee_game.Properties.Resources.die1;
            this.boxDieFour.Location = new System.Drawing.Point(642, 258);
            this.boxDieFour.Margin = new System.Windows.Forms.Padding(2);
            this.boxDieFour.Name = "boxDieFour";
            this.boxDieFour.Size = new System.Drawing.Size(139, 127);
            this.boxDieFour.TabIndex = 9;
            this.boxDieFour.Text = "Die 4";
            this.boxDieFour.UseVisualStyleBackColor = true;
            // 
            // boxDieThree
            // 
            this.boxDieThree.AutoSize = true;
            this.boxDieThree.Image = global::Yahtzee_game.Properties.Resources.die1;
            this.boxDieThree.Location = new System.Drawing.Point(419, 258);
            this.boxDieThree.Margin = new System.Windows.Forms.Padding(2);
            this.boxDieThree.Name = "boxDieThree";
            this.boxDieThree.Size = new System.Drawing.Size(139, 127);
            this.boxDieThree.TabIndex = 8;
            this.boxDieThree.Text = "Die 3";
            this.boxDieThree.UseVisualStyleBackColor = true;
            // 
            // boxDieTwo
            // 
            this.boxDieTwo.AutoSize = true;
            this.boxDieTwo.Image = global::Yahtzee_game.Properties.Resources.die1;
            this.boxDieTwo.Location = new System.Drawing.Point(224, 258);
            this.boxDieTwo.Margin = new System.Windows.Forms.Padding(2);
            this.boxDieTwo.Name = "boxDieTwo";
            this.boxDieTwo.Size = new System.Drawing.Size(139, 127);
            this.boxDieTwo.TabIndex = 7;
            this.boxDieTwo.Text = "Die 2";
            this.boxDieTwo.UseVisualStyleBackColor = true;
            // 
            // boxDieOne
            // 
            this.boxDieOne.Image = global::Yahtzee_game.Properties.Resources.die1;
            this.boxDieOne.Location = new System.Drawing.Point(11, 240);
            this.boxDieOne.Margin = new System.Windows.Forms.Padding(2);
            this.boxDieOne.Name = "boxDieOne";
            this.boxDieOne.Size = new System.Drawing.Size(200, 163);
            this.boxDieOne.TabIndex = 6;
            this.boxDieOne.Text = "Die 1";
            this.boxDieOne.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 616);
            this.Controls.Add(this.lblAddPlayerMsg);
            this.Controls.Add(this.btnStartGame);
            this.Controls.Add(this.btnAddPlayer);
            this.Controls.Add(this.txtPlayerName);
            this.Controls.Add(this.boxDieFive);
            this.Controls.Add(this.boxDieFour);
            this.Controls.Add(this.boxDieThree);
            this.Controls.Add(this.boxDieTwo);
            this.Controls.Add(this.boxDieOne);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox boxDieOne;
        private System.Windows.Forms.CheckBox boxDieTwo;
        private System.Windows.Forms.CheckBox boxDieThree;
        private System.Windows.Forms.CheckBox boxDieFour;
        private System.Windows.Forms.CheckBox boxDieFive;
        private System.Windows.Forms.ImageList diceImageList;
        private System.Windows.Forms.TextBox txtPlayerName;
        private System.Windows.Forms.Button btnAddPlayer;
        private System.Windows.Forms.Button btnStartGame;
        private System.Windows.Forms.Label lblAddPlayerMsg;
    }
}

