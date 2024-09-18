
namespace _7th_Continent_Saver
{
    partial class frmSevenSaver
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
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lstDB = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbFilter = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTerrain = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lbTerrainCard = new System.Windows.Forms.Label();
            this.lbConsole = new System.Windows.Forms.Label();
            this.btnActionDeck = new System.Windows.Forms.Button();
            this.listDiscard = new System.Windows.Forms.ListBox();
            this.lstAction = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDiscard = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lstSachel = new System.Windows.Forms.ListBox();
            this.btnSachel = new System.Windows.Forms.Button();
            this.rbP1 = new System.Windows.Forms.RadioButton();
            this.tbP2 = new System.Windows.Forms.RadioButton();
            this.rbP3 = new System.Windows.Forms.RadioButton();
            this.rbP4 = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.lstInventory = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lstGreenHand = new System.Windows.Forms.ListBox();
            this.lstBlueHand = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lbCharacterCard = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lstPast = new System.Windows.Forms.ListBox();
            this.label12 = new System.Windows.Forms.Label();
            this.lstBanished = new System.Windows.Forms.ListBox();
            this.btnPast = new System.Windows.Forms.Button();
            this.btnBanished = new System.Windows.Forms.Button();
            this.btnCharacter = new System.Windows.Forms.Button();
            this.btnBlueHand = new System.Windows.Forms.Button();
            this.btnGreenHand = new System.Windows.Forms.Button();
            this.btnItem = new System.Windows.Forms.Button();
            this.ndDurability = new System.Windows.Forms.NumericUpDown();
            this.lstStatus = new System.Windows.Forms.ListBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnStatus = new System.Windows.Forms.Button();
            this.btnActionDel = new System.Windows.Forms.Button();
            this.btnDiscardDel = new System.Windows.Forms.Button();
            this.btnSachelDel = new System.Windows.Forms.Button();
            this.btnPastDel = new System.Windows.Forms.Button();
            this.btnBanishedDel = new System.Windows.Forms.Button();
            this.btnBlueHandDel = new System.Windows.Forms.Button();
            this.btnGreenHandDel = new System.Windows.Forms.Button();
            this.btnIventoryDel = new System.Windows.Forms.Button();
            this.btnStatusDel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ndDurability)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(12, 12);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(58, 23);
            this.btnLoad.TabIndex = 0;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(76, 12);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(56, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lstDB
            // 
            this.lstDB.FormattingEnabled = true;
            this.lstDB.Location = new System.Drawing.Point(953, 34);
            this.lstDB.Name = "lstDB";
            this.lstDB.Size = new System.Drawing.Size(352, 602);
            this.lstDB.TabIndex = 2;
            this.lstDB.SelectedIndexChanged += new System.EventHandler(this.lstDB_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1227, 646);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Card Database";
            // 
            // tbFilter
            // 
            this.tbFilter.Location = new System.Drawing.Point(1185, 10);
            this.tbFilter.Name = "tbFilter";
            this.tbFilter.Size = new System.Drawing.Size(120, 20);
            this.tbFilter.TabIndex = 4;
            this.tbFilter.TextChanged += new System.EventHandler(this.tbFilter_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1064, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Card Search and Save";
            // 
            // btnTerrain
            // 
            this.btnTerrain.Location = new System.Drawing.Point(827, 34);
            this.btnTerrain.Name = "btnTerrain";
            this.btnTerrain.Size = new System.Drawing.Size(120, 23);
            this.btnTerrain.TabIndex = 7;
            this.btnTerrain.Text = "Standing on Terrain";
            this.btnTerrain.UseVisualStyleBackColor = true;
            this.btnTerrain.Click += new System.EventHandler(this.btnTerrain_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Standing on:";
            // 
            // lbTerrainCard
            // 
            this.lbTerrainCard.AutoSize = true;
            this.lbTerrainCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTerrainCard.Location = new System.Drawing.Point(85, 64);
            this.lbTerrainCard.Name = "lbTerrainCard";
            this.lbTerrainCard.Size = new System.Drawing.Size(23, 13);
            this.lbTerrainCard.TabIndex = 9;
            this.lbTerrainCard.Text = "----";
            // 
            // lbConsole
            // 
            this.lbConsole.AutoSize = true;
            this.lbConsole.Location = new System.Drawing.Point(138, 17);
            this.lbConsole.Name = "lbConsole";
            this.lbConsole.Size = new System.Drawing.Size(0, 13);
            this.lbConsole.TabIndex = 10;
            // 
            // btnActionDeck
            // 
            this.btnActionDeck.Location = new System.Drawing.Point(828, 117);
            this.btnActionDeck.Name = "btnActionDeck";
            this.btnActionDeck.Size = new System.Drawing.Size(120, 23);
            this.btnActionDeck.TabIndex = 11;
            this.btnActionDeck.Text = "Action Deck";
            this.btnActionDeck.UseVisualStyleBackColor = true;
            this.btnActionDeck.Click += new System.EventHandler(this.btnActionDeck_Click);
            // 
            // listDiscard
            // 
            this.listDiscard.FormattingEnabled = true;
            this.listDiscard.Location = new System.Drawing.Point(12, 111);
            this.listDiscard.Name = "listDiscard";
            this.listDiscard.Size = new System.Drawing.Size(166, 225);
            this.listDiscard.TabIndex = 12;
            // 
            // lstAction
            // 
            this.lstAction.FormattingEnabled = true;
            this.lstAction.Location = new System.Drawing.Point(184, 111);
            this.lstAction.Name = "lstAction";
            this.lstAction.Size = new System.Drawing.Size(160, 225);
            this.lstAction.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Discard Deck";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(181, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Action Deck";
            // 
            // btnDiscard
            // 
            this.btnDiscard.Location = new System.Drawing.Point(828, 88);
            this.btnDiscard.Name = "btnDiscard";
            this.btnDiscard.Size = new System.Drawing.Size(120, 23);
            this.btnDiscard.TabIndex = 16;
            this.btnDiscard.Text = "Discard Deck";
            this.btnDiscard.UseVisualStyleBackColor = true;
            this.btnDiscard.Click += new System.EventHandler(this.btnDiscard_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(347, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Sachel and Journal";
            // 
            // lstSachel
            // 
            this.lstSachel.FormattingEnabled = true;
            this.lstSachel.Location = new System.Drawing.Point(350, 111);
            this.lstSachel.Name = "lstSachel";
            this.lstSachel.Size = new System.Drawing.Size(194, 225);
            this.lstSachel.TabIndex = 17;
            // 
            // btnSachel
            // 
            this.btnSachel.Location = new System.Drawing.Point(827, 165);
            this.btnSachel.Name = "btnSachel";
            this.btnSachel.Size = new System.Drawing.Size(120, 23);
            this.btnSachel.TabIndex = 19;
            this.btnSachel.Text = "Sachel and Journal";
            this.btnSachel.UseVisualStyleBackColor = true;
            this.btnSachel.Click += new System.EventHandler(this.btnSachel_Click);
            // 
            // rbP1
            // 
            this.rbP1.AutoSize = true;
            this.rbP1.Checked = true;
            this.rbP1.Location = new System.Drawing.Point(16, 406);
            this.rbP1.Name = "rbP1";
            this.rbP1.Size = new System.Drawing.Size(63, 17);
            this.rbP1.TabIndex = 20;
            this.rbP1.TabStop = true;
            this.rbP1.Text = "Player 1";
            this.rbP1.UseVisualStyleBackColor = true;
            this.rbP1.CheckedChanged += new System.EventHandler(this.rbPChanged);
            // 
            // tbP2
            // 
            this.tbP2.AutoSize = true;
            this.tbP2.Location = new System.Drawing.Point(16, 429);
            this.tbP2.Name = "tbP2";
            this.tbP2.Size = new System.Drawing.Size(63, 17);
            this.tbP2.TabIndex = 21;
            this.tbP2.Text = "Player 2";
            this.tbP2.UseVisualStyleBackColor = true;
            this.tbP2.CheckedChanged += new System.EventHandler(this.rbPChanged);
            // 
            // rbP3
            // 
            this.rbP3.AutoSize = true;
            this.rbP3.Location = new System.Drawing.Point(16, 452);
            this.rbP3.Name = "rbP3";
            this.rbP3.Size = new System.Drawing.Size(63, 17);
            this.rbP3.TabIndex = 22;
            this.rbP3.Text = "Player 3";
            this.rbP3.UseVisualStyleBackColor = true;
            this.rbP3.CheckedChanged += new System.EventHandler(this.rbPChanged);
            // 
            // rbP4
            // 
            this.rbP4.AutoSize = true;
            this.rbP4.Location = new System.Drawing.Point(16, 475);
            this.rbP4.Name = "rbP4";
            this.rbP4.Size = new System.Drawing.Size(63, 17);
            this.rbP4.TabIndex = 23;
            this.rbP4.Text = "Player 4";
            this.rbP4.UseVisualStyleBackColor = true;
            this.rbP4.CheckedChanged += new System.EventHandler(this.rbPChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(569, 386);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "Inventory";
            // 
            // lstInventory
            // 
            this.lstInventory.FormattingEnabled = true;
            this.lstInventory.Location = new System.Drawing.Point(572, 404);
            this.lstInventory.Name = "lstInventory";
            this.lstInventory.Size = new System.Drawing.Size(194, 108);
            this.lstInventory.TabIndex = 28;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(403, 386);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Green Hand";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(234, 386);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "Blue Hand";
            // 
            // lstGreenHand
            // 
            this.lstGreenHand.FormattingEnabled = true;
            this.lstGreenHand.Location = new System.Drawing.Point(406, 404);
            this.lstGreenHand.Name = "lstGreenHand";
            this.lstGreenHand.Size = new System.Drawing.Size(160, 225);
            this.lstGreenHand.TabIndex = 25;
            // 
            // lstBlueHand
            // 
            this.lstBlueHand.FormattingEnabled = true;
            this.lstBlueHand.Location = new System.Drawing.Point(234, 404);
            this.lstBlueHand.Name = "lstBlueHand";
            this.lstBlueHand.Size = new System.Drawing.Size(166, 225);
            this.lstBlueHand.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 352);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 30;
            this.label10.Text = "Character";
            // 
            // lbCharacterCard
            // 
            this.lbCharacterCard.AutoSize = true;
            this.lbCharacterCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCharacterCard.Location = new System.Drawing.Point(13, 365);
            this.lbCharacterCard.Name = "lbCharacterCard";
            this.lbCharacterCard.Size = new System.Drawing.Size(23, 13);
            this.lbCharacterCard.TabIndex = 31;
            this.lbCharacterCard.Text = "----";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(547, 92);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(28, 13);
            this.label11.TabIndex = 33;
            this.label11.Text = "Past";
            // 
            // lstPast
            // 
            this.lstPast.FormattingEnabled = true;
            this.lstPast.Location = new System.Drawing.Point(550, 110);
            this.lstPast.Name = "lstPast";
            this.lstPast.Size = new System.Drawing.Size(133, 225);
            this.lstPast.TabIndex = 32;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(686, 92);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 13);
            this.label12.TabIndex = 35;
            this.label12.Text = "Banished";
            // 
            // lstBanished
            // 
            this.lstBanished.FormattingEnabled = true;
            this.lstBanished.Location = new System.Drawing.Point(689, 110);
            this.lstBanished.Name = "lstBanished";
            this.lstBanished.Size = new System.Drawing.Size(133, 225);
            this.lstBanished.TabIndex = 34;
            // 
            // btnPast
            // 
            this.btnPast.Location = new System.Drawing.Point(827, 224);
            this.btnPast.Name = "btnPast";
            this.btnPast.Size = new System.Drawing.Size(120, 23);
            this.btnPast.TabIndex = 36;
            this.btnPast.Text = "Past";
            this.btnPast.UseVisualStyleBackColor = true;
            this.btnPast.Click += new System.EventHandler(this.btnPast_Click);
            // 
            // btnBanished
            // 
            this.btnBanished.Location = new System.Drawing.Point(827, 253);
            this.btnBanished.Name = "btnBanished";
            this.btnBanished.Size = new System.Drawing.Size(120, 23);
            this.btnBanished.TabIndex = 37;
            this.btnBanished.Text = "Banished";
            this.btnBanished.UseVisualStyleBackColor = true;
            this.btnBanished.Click += new System.EventHandler(this.btnBanished_Click);
            // 
            // btnCharacter
            // 
            this.btnCharacter.Location = new System.Drawing.Point(827, 410);
            this.btnCharacter.Name = "btnCharacter";
            this.btnCharacter.Size = new System.Drawing.Size(120, 23);
            this.btnCharacter.TabIndex = 38;
            this.btnCharacter.Text = "Character";
            this.btnCharacter.UseVisualStyleBackColor = true;
            this.btnCharacter.Click += new System.EventHandler(this.btnCharacter_Click);
            // 
            // btnBlueHand
            // 
            this.btnBlueHand.Location = new System.Drawing.Point(827, 439);
            this.btnBlueHand.Name = "btnBlueHand";
            this.btnBlueHand.Size = new System.Drawing.Size(120, 23);
            this.btnBlueHand.TabIndex = 39;
            this.btnBlueHand.Text = "Blue";
            this.btnBlueHand.UseVisualStyleBackColor = true;
            this.btnBlueHand.Click += new System.EventHandler(this.btnBlueHand_Click);
            // 
            // btnGreenHand
            // 
            this.btnGreenHand.Location = new System.Drawing.Point(827, 468);
            this.btnGreenHand.Name = "btnGreenHand";
            this.btnGreenHand.Size = new System.Drawing.Size(120, 23);
            this.btnGreenHand.TabIndex = 40;
            this.btnGreenHand.Text = "Green";
            this.btnGreenHand.UseVisualStyleBackColor = true;
            this.btnGreenHand.Click += new System.EventHandler(this.btnGreenHand_Click);
            // 
            // btnItem
            // 
            this.btnItem.Location = new System.Drawing.Point(827, 497);
            this.btnItem.Name = "btnItem";
            this.btnItem.Size = new System.Drawing.Size(75, 23);
            this.btnItem.TabIndex = 41;
            this.btnItem.Text = "Inventory";
            this.btnItem.UseVisualStyleBackColor = true;
            this.btnItem.Click += new System.EventHandler(this.btnItem_Click);
            // 
            // ndDurability
            // 
            this.ndDurability.Location = new System.Drawing.Point(908, 497);
            this.ndDurability.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.ndDurability.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ndDurability.Name = "ndDurability";
            this.ndDurability.Size = new System.Drawing.Size(39, 20);
            this.ndDurability.TabIndex = 42;
            this.ndDurability.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ndDurability.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // lstStatus
            // 
            this.lstStatus.FormattingEnabled = true;
            this.lstStatus.Location = new System.Drawing.Point(572, 534);
            this.lstStatus.Name = "lstStatus";
            this.lstStatus.Size = new System.Drawing.Size(194, 95);
            this.lstStatus.TabIndex = 43;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(569, 515);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(37, 13);
            this.label13.TabIndex = 44;
            this.label13.Text = "Status";
            // 
            // btnStatus
            // 
            this.btnStatus.Location = new System.Drawing.Point(827, 526);
            this.btnStatus.Name = "btnStatus";
            this.btnStatus.Size = new System.Drawing.Size(120, 23);
            this.btnStatus.TabIndex = 45;
            this.btnStatus.Text = "Status";
            this.btnStatus.UseVisualStyleBackColor = true;
            this.btnStatus.Click += new System.EventHandler(this.btnStatus_Click);
            // 
            // btnActionDel
            // 
            this.btnActionDel.Location = new System.Drawing.Point(253, 88);
            this.btnActionDel.Name = "btnActionDel";
            this.btnActionDel.Size = new System.Drawing.Size(24, 23);
            this.btnActionDel.TabIndex = 46;
            this.btnActionDel.Text = "D";
            this.btnActionDel.UseVisualStyleBackColor = true;
            this.btnActionDel.Click += new System.EventHandler(this.btnActionDel_Click);
            // 
            // btnDiscardDel
            // 
            this.btnDiscardDel.Location = new System.Drawing.Point(90, 87);
            this.btnDiscardDel.Name = "btnDiscardDel";
            this.btnDiscardDel.Size = new System.Drawing.Size(24, 23);
            this.btnDiscardDel.TabIndex = 47;
            this.btnDiscardDel.Text = "D";
            this.btnDiscardDel.UseVisualStyleBackColor = true;
            this.btnDiscardDel.Click += new System.EventHandler(this.btnDiscardDel_Click);
            // 
            // btnSachelDel
            // 
            this.btnSachelDel.Location = new System.Drawing.Point(444, 87);
            this.btnSachelDel.Name = "btnSachelDel";
            this.btnSachelDel.Size = new System.Drawing.Size(24, 23);
            this.btnSachelDel.TabIndex = 48;
            this.btnSachelDel.Text = "D";
            this.btnSachelDel.UseVisualStyleBackColor = true;
            this.btnSachelDel.Click += new System.EventHandler(this.btnSachelDel_Click);
            // 
            // btnPastDel
            // 
            this.btnPastDel.Location = new System.Drawing.Point(581, 87);
            this.btnPastDel.Name = "btnPastDel";
            this.btnPastDel.Size = new System.Drawing.Size(24, 23);
            this.btnPastDel.TabIndex = 49;
            this.btnPastDel.Text = "D";
            this.btnPastDel.UseVisualStyleBackColor = true;
            this.btnPastDel.Click += new System.EventHandler(this.btnPastDel_Click);
            // 
            // btnBanishedDel
            // 
            this.btnBanishedDel.Location = new System.Drawing.Point(742, 87);
            this.btnBanishedDel.Name = "btnBanishedDel";
            this.btnBanishedDel.Size = new System.Drawing.Size(24, 23);
            this.btnBanishedDel.TabIndex = 50;
            this.btnBanishedDel.Text = "D";
            this.btnBanishedDel.UseVisualStyleBackColor = true;
            this.btnBanishedDel.Click += new System.EventHandler(this.btnBanishedDel_Click);
            // 
            // btnBlueHandDel
            // 
            this.btnBlueHandDel.Location = new System.Drawing.Point(297, 381);
            this.btnBlueHandDel.Name = "btnBlueHandDel";
            this.btnBlueHandDel.Size = new System.Drawing.Size(24, 23);
            this.btnBlueHandDel.TabIndex = 51;
            this.btnBlueHandDel.Text = "D";
            this.btnBlueHandDel.UseVisualStyleBackColor = true;
            this.btnBlueHandDel.Click += new System.EventHandler(this.btnBlueHandDel_Click);
            // 
            // btnGreenHandDel
            // 
            this.btnGreenHandDel.Location = new System.Drawing.Point(474, 381);
            this.btnGreenHandDel.Name = "btnGreenHandDel";
            this.btnGreenHandDel.Size = new System.Drawing.Size(24, 23);
            this.btnGreenHandDel.TabIndex = 52;
            this.btnGreenHandDel.Text = "D";
            this.btnGreenHandDel.UseVisualStyleBackColor = true;
            this.btnGreenHandDel.Click += new System.EventHandler(this.btnGreenHandDel_Click);
            // 
            // btnIventoryDel
            // 
            this.btnIventoryDel.Location = new System.Drawing.Point(626, 381);
            this.btnIventoryDel.Name = "btnIventoryDel";
            this.btnIventoryDel.Size = new System.Drawing.Size(24, 23);
            this.btnIventoryDel.TabIndex = 53;
            this.btnIventoryDel.Text = "D";
            this.btnIventoryDel.UseVisualStyleBackColor = true;
            this.btnIventoryDel.Click += new System.EventHandler(this.btnIventoryDel_Click);
            // 
            // btnStatusDel
            // 
            this.btnStatusDel.Location = new System.Drawing.Point(612, 510);
            this.btnStatusDel.Name = "btnStatusDel";
            this.btnStatusDel.Size = new System.Drawing.Size(24, 23);
            this.btnStatusDel.TabIndex = 54;
            this.btnStatusDel.Text = "D";
            this.btnStatusDel.UseVisualStyleBackColor = true;
            this.btnStatusDel.Click += new System.EventHandler(this.btnStatusDel_Click);
            // 
            // frmSevenSaver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1317, 668);
            this.Controls.Add(this.btnStatusDel);
            this.Controls.Add(this.btnIventoryDel);
            this.Controls.Add(this.btnGreenHandDel);
            this.Controls.Add(this.btnBlueHandDel);
            this.Controls.Add(this.btnBanishedDel);
            this.Controls.Add(this.btnPastDel);
            this.Controls.Add(this.btnSachelDel);
            this.Controls.Add(this.btnDiscardDel);
            this.Controls.Add(this.btnActionDel);
            this.Controls.Add(this.btnStatus);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lstStatus);
            this.Controls.Add(this.ndDurability);
            this.Controls.Add(this.btnItem);
            this.Controls.Add(this.btnGreenHand);
            this.Controls.Add(this.btnBlueHand);
            this.Controls.Add(this.btnCharacter);
            this.Controls.Add(this.btnBanished);
            this.Controls.Add(this.btnPast);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lstBanished);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lstPast);
            this.Controls.Add(this.lbCharacterCard);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lstInventory);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lstGreenHand);
            this.Controls.Add(this.lstBlueHand);
            this.Controls.Add(this.rbP4);
            this.Controls.Add(this.rbP3);
            this.Controls.Add(this.tbP2);
            this.Controls.Add(this.rbP1);
            this.Controls.Add(this.btnSachel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lstSachel);
            this.Controls.Add(this.btnDiscard);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lstAction);
            this.Controls.Add(this.listDiscard);
            this.Controls.Add(this.btnActionDeck);
            this.Controls.Add(this.lbConsole);
            this.Controls.Add(this.lbTerrainCard);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnTerrain);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbFilter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstDB);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnLoad);
            this.Name = "frmSevenSaver";
            this.Text = "7th Continent Saver";
            ((System.ComponentModel.ISupportInitialize)(this.ndDurability)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ListBox lstDB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbFilter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTerrain;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbTerrainCard;
        private System.Windows.Forms.Label lbConsole;
        private System.Windows.Forms.Button btnActionDeck;
        private System.Windows.Forms.ListBox listDiscard;
        private System.Windows.Forms.ListBox lstAction;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDiscard;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lstSachel;
        private System.Windows.Forms.Button btnSachel;
        private System.Windows.Forms.RadioButton rbP1;
        private System.Windows.Forms.RadioButton tbP2;
        private System.Windows.Forms.RadioButton rbP3;
        private System.Windows.Forms.RadioButton rbP4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox lstInventory;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox lstGreenHand;
        private System.Windows.Forms.ListBox lstBlueHand;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbCharacterCard;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ListBox lstPast;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ListBox lstBanished;
        private System.Windows.Forms.Button btnPast;
        private System.Windows.Forms.Button btnBanished;
        private System.Windows.Forms.Button btnCharacter;
        private System.Windows.Forms.Button btnBlueHand;
        private System.Windows.Forms.Button btnGreenHand;
        private System.Windows.Forms.Button btnItem;
        private System.Windows.Forms.NumericUpDown ndDurability;
        private System.Windows.Forms.ListBox lstStatus;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnStatus;
        private System.Windows.Forms.Button btnActionDel;
        private System.Windows.Forms.Button btnDiscardDel;
        private System.Windows.Forms.Button btnSachelDel;
        private System.Windows.Forms.Button btnPastDel;
        private System.Windows.Forms.Button btnBanishedDel;
        private System.Windows.Forms.Button btnBlueHandDel;
        private System.Windows.Forms.Button btnGreenHandDel;
        private System.Windows.Forms.Button btnIventoryDel;
        private System.Windows.Forms.Button btnStatusDel;
    }
}

