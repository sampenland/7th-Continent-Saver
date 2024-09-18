using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7th_Continent_Saver
{
    public partial class frmSevenSaver : Form
    {
        public class Character
        {
            public List<ItemCard> Inventory;
            public List<Card> HandBlue;
            public List<Card> HandGreen;
            public List<Card> Status;
            public Card CharacterCard;

            public Character(string num)
            {
                Inventory = new List<ItemCard>();
                HandBlue = new List<Card>();
                HandGreen = new List<Card>();
                Status = new List<Card>();
                CharacterCard = new Card(num);
            }
        }

        public class Save
        {
            public List<Card> Past;
            public List<Card> Banished;
            public List<Card> DiscardDeck;
            public List<Card> ActionDeck;
            public List<Card> SatchelJournal;

            public Character[] Characters;
            public Card TerrainCard;

            public Save(string terrain)
            {
                Banished = new List<Card>();
                Past = new List<Card>();
                
                DiscardDeck = new List<Card>();
                ActionDeck = new List<Card>();
                
                SatchelJournal = new List<Card>();
                Characters = new Character[4];

                Characters[0] = new Character("");
                Characters[1] = new Character("");
                Characters[2] = new Character("");
                Characters[3] = new Character("");

                TerrainCard = new Card(terrain);
            }
        }

        public class Card
        {
            public string number;
            public Card(string num) { number = num; }
        }

        public class ItemCard : Card
        {
            public int durability;

            public ItemCard(string num, int dur) : base(num)
            {
                durability = dur;
            }
        }

        public static string DB_NAME = "card_db.txt";
        public static List<string> DB;
        public static string CurrentSelected = "";
        public static int CurrentCharacterIndex = 0;

        public Save saveFile;

        public frmSevenSaver()
        {
            InitializeComponent();
            saveFile = new Save("");

            DB = new List<string>();
            string[] cards = File.ReadAllLines(DB_NAME);

            foreach(string card in cards)
            {
                DB.Add(card);
            }

            refreshList();
        }

        private void tbFilter_TextChanged(object sender, EventArgs e)
        {
            refreshList();
        }

        private void refreshList()
        {
            lstDB.Items.Clear();
            foreach (string card in DB)
            {
                if (card.Contains(tbFilter.Text))
                {
                    lstDB.Items.Add(card);
                }
            }
        }

        private void load(string path)
        {
            saveFile = new Save("");

            string[] readin = File.ReadAllLines(path);

            if (readin == null || readin.Length < 2 || readin[0] != "CHARACTERS")
            {
                lbConsole.Text = "Failed to load.";
                return;
            }

            int line = 1;
            string current = readin[line];
            while(!current.Contains("TERRAIN"))
            {
                int characterCount = 0;
                if (current == "CHARACTER")
                {
                    characterCount++;
                    line++;
                    current = readin[line];
                    Character character = new Character(current);
                    line++;
                    current = readin[line];
                    character.CharacterCard.number = current;
                    for(int i = line + 1;  readin[i] == "CHARACTER END"; i++)
                    {
                        current = readin[line];
                        if (current.Contains("INVENTORY")) character.Inventory.Add(new ItemCard(current.Replace("INVENTORY ", "").Substring(0, current.Length - 1), int.Parse(current.Substring(current.LastIndexOf(" ")))));
                        if (current.Contains("STATUS")) character.Status.Add(new Card(current.Replace("STATUS ", "")));
                        if (current.Contains("HANDBLUE")) character.HandBlue.Add(new Card(current.Replace("HANDBLUE ", "")));
                        if (current.Contains("HANDGREEN")) character.HandGreen.Add(new Card(current.Replace("HANDGREEN ", "")));
                    }

                    saveFile.Characters[characterCount - 1] = character;
                }

                line++;
                current = readin[line];
            }

            if (current == "TERRAIN") saveFile.TerrainCard = new Card(current);

            line++;
            current = readin[line];

            while (current != "END")
            {

                if (current.Contains("BANISHED")) saveFile.Banished.Add(new Card(current.Replace("BANISHED ", "")));
                if (current.Contains("DISCARD")) saveFile.Banished.Add(new Card(current.Replace("DISCARD ", "")));
                if (current.Contains("ACTION")) saveFile.Banished.Add(new Card(current.Replace("ACTION ", "")));
                if (current.Contains("SACHELJOURNAL")) saveFile.Banished.Add(new Card(current.Replace("SACHELJOURNAL ", "")));

                line++;
                current = readin[line];
            }

            refreshActionDeck();
            refreshDiscardDeck();
            refreshBanished();
            refreshPast();
            refreshSachel();

            refreshCharactere();

        }

        private void save(string path)
        {
            string savetext = "CHARACTERS" + Environment.NewLine;
            
            foreach(Character character in saveFile.Characters)
            {
                savetext += "CHARACTER" + Environment.NewLine;
                savetext += character.CharacterCard.number;
                savetext += Environment.NewLine;

                foreach (ItemCard card in character.Inventory)
                {
                    savetext += "INVENTORY " + card.number + " " + card.durability + Environment.NewLine;
                }

                foreach (Card card in character.Status)
                {
                    savetext += "STATUS " + card.number + Environment.NewLine;
                }

                foreach (Card card in character.HandBlue)
                {
                    savetext += "HANDBLUE " + card.number + Environment.NewLine;
                }

                foreach (Card card in character.HandGreen)
                {
                    savetext += "HANDGREEN " + card.number + Environment.NewLine;
                }

                savetext += "CHARACTER END" + Environment.NewLine;
            }

            savetext += "TERRAIN " + saveFile.TerrainCard.number + Environment.NewLine;

            foreach (Card card in saveFile.Banished)
            {
                savetext += "BANISHED " + card.number + Environment.NewLine;
            }
            savetext += Environment.NewLine;

            foreach (Card card in saveFile.DiscardDeck)
            {
                savetext += "DISCARD " + card.number + Environment.NewLine;
            }
            savetext += Environment.NewLine;

            foreach (Card card in saveFile.ActionDeck)
            {
                savetext += "ACTION " + card.number + Environment.NewLine;
            }
            savetext += Environment.NewLine;

            foreach (Card card in saveFile.SatchelJournal)
            {
                savetext += "SATCHELJOURNAL " + card.number + Environment.NewLine;
            }
            savetext += Environment.NewLine;

            savetext += "END" + Environment.NewLine;

            File.WriteAllText(path, savetext);
        }

        private void btnTerrain_Click(object sender, EventArgs e)
        {
            if (CurrentSelected == "")
            {
                lbConsole.Text = "Terrain not added.";
            }

            lbConsole.Text = "Terrain added";

            saveFile.TerrainCard = new Card(CurrentSelected);
            lbTerrainCard.Text = CurrentSelected;
        }

        private void lstDB_SelectedIndexChanged(object sender, EventArgs e)
        {
            CurrentSelected = lstDB.Items[lstDB.SelectedIndex].ToString();
        }

        private void btnActionDeck_Click(object sender, EventArgs e)
        {
            if (CurrentSelected != "")
            {
                Card card = new Card(CurrentSelected);
                if (!saveFile.ActionDeck.Contains(card))
                {
                    saveFile.ActionDeck.Add(card); 
                }
                else
                {
                    lbConsole.Text = "Already present";
                }
            }
            else
            {
                lbConsole.Text = "Couldn't add";
            }

            refreshActionDeck();
        }

        private void refreshActionDeck()
        {
            lstAction.Items.Clear();
            foreach (Card card in saveFile.ActionDeck)
            {
                lstAction.Items.Add(card.number);
            }
        }
        private void refreshSachel()
        {
            lstSachel.Items.Clear();
            foreach (Card card in saveFile.SatchelJournal)
            {
                lstSachel.Items.Add(card.number);
            }
        }

        private void refreshDiscardDeck()
        {
            listDiscard.Items.Clear();
            foreach (Card card in saveFile.DiscardDeck)
            {
                listDiscard.Items.Add(card.number);
            }
        }

        private void refreshBanished()
        {
            lstBanished.Items.Clear();
            foreach (Card card in saveFile.Banished)
            {
                lstBanished.Items.Add(card.number);
            }
        }

        private void refreshPast()
        {
            lstPast.Items.Clear();
            foreach (Card card in saveFile.Past)
            {
                lstPast.Items.Add(card.number);
            }
        }

        private void btnDiscard_Click(object sender, EventArgs e)
        {
            if (CurrentSelected != "")
            {
                Card card = new Card(CurrentSelected);
                if (!saveFile.DiscardDeck.Contains(card))
                {
                    saveFile.DiscardDeck.Add(card);
                }
                else
                {
                    lbConsole.Text = "Already present";
                }
            }
            else
            {
                lbConsole.Text = "Couldn't add";
            }

            refreshDiscardDeck();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.ShowDialog();

            if(sfd.FileName != null)
            {
                save(sfd.FileName);
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();

            if(ofd.FileName != null)
            {
                load(ofd.FileName);
            }
        }

        private void btnSachel_Click(object sender, EventArgs e)
        {
            if (CurrentSelected != "")
            {
                Card card = new Card(CurrentSelected);
                if (!saveFile.SatchelJournal.Contains(card))
                {
                    saveFile.SatchelJournal.Add(card);
                }
                else
                {
                    lbConsole.Text = "Already present";
                }
            }
            else
            {
                lbConsole.Text = "Couldn't add";
            }

            refreshSachel();
        }

        private void btnPast_Click(object sender, EventArgs e)
        {
            if (CurrentSelected != "")
            {
                Card card = new Card(CurrentSelected);
                if (!saveFile.Past.Contains(card))
                {
                    saveFile.Past.Add(card);
                }
                else
                {
                    lbConsole.Text = "Already present";
                }
            }
            else
            {
                lbConsole.Text = "Couldn't add";
            }

            refreshPast();
        }

        private void btnBanished_Click(object sender, EventArgs e)
        {
            if (CurrentSelected != "")
            {
                Card card = new Card(CurrentSelected);
                if (!saveFile.Banished.Contains(card))
                {
                    saveFile.Banished.Add(card);
                }
                else
                {
                    lbConsole.Text = "Already present";
                }
            }
            else
            {
                lbConsole.Text = "Couldn't add";
            }

            refreshBanished();
        }

        private void rbPChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;

            int characterIndex = 0;
            if (rb.Name.Contains("2"))
            {
                characterIndex = 1;
            }
            else if (rb.Name.Contains("3"))
            {
                characterIndex = 2;
            }
            else if (rb.Name.Contains("4"))
            {
                characterIndex = 3;
            }

            CurrentCharacterIndex = characterIndex;
            refreshCharactere();

        }

        private void btnCharacter_Click(object sender, EventArgs e)
        {
            if (CurrentSelected != "")
            {
                saveFile.Characters[CurrentCharacterIndex].CharacterCard = new Card(CurrentSelected);
                lbCharacterCard.Text = CurrentSelected;
            }
        }

        private void refreshCharactere()
        {
            lbCharacterCard.Text = saveFile.Characters[CurrentCharacterIndex].CharacterCard.number;
            refreshBlueHand();
            refreshGreenHand();
            refreshInventory();
            refreshStatus();
        }

        private void refreshBlueHand()
        {
            lstBlueHand.Items.Clear();
            foreach (Card card in saveFile.Characters[CurrentCharacterIndex].HandBlue)
            {
                lstBlueHand.Items.Add(card.number);
            }
        }

        private void refreshGreenHand()
        {
            lstGreenHand.Items.Clear();
            foreach (Card card in saveFile.Characters[CurrentCharacterIndex].HandGreen)
            {
                lstGreenHand.Items.Add(card.number);
            }
        }

        private void refreshInventory()
        {
            lstInventory.Items.Clear();
            foreach (ItemCard card in saveFile.Characters[CurrentCharacterIndex].Inventory)
            {
                lstInventory.Items.Add(card.number + " DUR: " + card.durability);
            }
        }
        
        private void refreshStatus()
        {
            lstStatus.Items.Clear();
            foreach (Card card in saveFile.Characters[CurrentCharacterIndex].Status)
            {
                lstStatus.Items.Add(card.number);
            }
        }

        private void btnBlueHand_Click(object sender, EventArgs e)
        {
            if (CurrentSelected != "")
            {
                Card card = new Card(CurrentSelected);
                if (!saveFile.Characters[CurrentCharacterIndex].HandBlue.Contains(card))
                {
                    saveFile.Characters[CurrentCharacterIndex].HandBlue.Add(card);
                }
                else
                {
                    lbConsole.Text = "Already present";
                }
            }
            else
            {
                lbConsole.Text = "Couldn't add";
            }

            refreshBlueHand();
        }

        private void btnGreenHand_Click(object sender, EventArgs e)
        {
            if (CurrentSelected != "")
            {
                Card card = new Card(CurrentSelected);
                if (!saveFile.Characters[CurrentCharacterIndex].HandGreen.Contains(card))
                {
                    saveFile.Characters[CurrentCharacterIndex].HandGreen.Add(card);
                }
                else
                {
                    lbConsole.Text = "Already present";
                }
            }
            else
            {
                lbConsole.Text = "Couldn't add";
            }

            refreshGreenHand();
        }

        private void btnStatus_Click(object sender, EventArgs e)
        {
            if (CurrentSelected != "")
            {
                Card card = new Card(CurrentSelected);
                if (!saveFile.Characters[CurrentCharacterIndex].Status.Contains(card))
                {
                    saveFile.Characters[CurrentCharacterIndex].Status.Add(card);
                }
                else
                {
                    lbConsole.Text = "Already present";
                }
            }
            else
            {
                lbConsole.Text = "Couldn't add";
            }

            refreshStatus();
        }

        private void btnItem_Click(object sender, EventArgs e)
        {
            if (CurrentSelected != "")
            {
                ItemCard card = new ItemCard(CurrentSelected, (int)ndDurability.Value);
                if (!saveFile.Characters[CurrentCharacterIndex].Inventory.Contains(card))
                {
                    saveFile.Characters[CurrentCharacterIndex].Inventory.Add(card);
                }
                else
                {
                    lbConsole.Text = "Already present";
                }
            }
            else
            {
                lbConsole.Text = "Couldn't add";
            }

            refreshInventory();
        }

        private void btnActionDel_Click(object sender, EventArgs e)
        {
            if (lstAction.SelectedItem == null) return;
            string current = lstAction.SelectedItem.ToString();
            if (current != "")
            {
                int found = -1;
                for(int i = 0; i < saveFile.ActionDeck.Count; i++)
                {
                    if (saveFile.ActionDeck[i].number == current)
                    {
                        found = i;
                        break;
                    }
                }

                if(found != -1)
                {
                    saveFile.ActionDeck.RemoveAt(found);
                }
            }

            refreshActionDeck();
        }

        private void btnDiscardDel_Click(object sender, EventArgs e)
        {
            if (listDiscard.SelectedItem == null) return;
            string current = listDiscard.SelectedItem.ToString();
            if (current != "")
            {
                int found = -1;
                for (int i = 0; i < saveFile.DiscardDeck.Count; i++)
                {
                    if (saveFile.DiscardDeck[i].number == current)
                    {
                        found = i;
                        break;
                    }
                }

                if (found != -1)
                {
                    saveFile.DiscardDeck.RemoveAt(found);
                }
            }

            refreshDiscardDeck();
        }

        private void btnSachelDel_Click(object sender, EventArgs e)
        {
            if (lstSachel.SelectedItem == null) return;
            string current = lstSachel.SelectedItem.ToString();
            if (current != "")
            {
                int found = -1;
                for (int i = 0; i < saveFile.SatchelJournal.Count; i++)
                {
                    if (saveFile.SatchelJournal[i].number == current)
                    {
                        found = i;
                        break;
                    }
                }

                if (found != -1)
                {
                    saveFile.SatchelJournal.RemoveAt(found);
                }
            }

            refreshSachel();
        }

        private void btnPastDel_Click(object sender, EventArgs e)
        {
            if (lstPast.SelectedItem == null) return;
            string current = lstPast.SelectedItem.ToString();
            if (current != "")
            {
                int found = -1;
                for (int i = 0; i < saveFile.Past.Count; i++)
                {
                    if (saveFile.Past[i].number == current)
                    {
                        found = i;
                        break;
                    }
                }

                if (found != -1)
                {
                    saveFile.Past.RemoveAt(found);
                }
            }

            refreshPast();
        }

        private void btnBanishedDel_Click(object sender, EventArgs e)
        {
            if (lstBanished.SelectedItem == null) return;
            string current = lstBanished.SelectedItem.ToString();
            if (current != "")
            {
                int found = -1;
                for (int i = 0; i < saveFile.Banished.Count; i++)
                {
                    if (saveFile.Banished[i].number == current)
                    {
                        found = i;
                        break;
                    }
                }

                if (found != -1)
                {
                    saveFile.Banished.RemoveAt(found);
                }
            }

            refreshBanished();
        }

        private void btnBlueHandDel_Click(object sender, EventArgs e)
        {
            if (lstBlueHand.SelectedItem == null) return;
            string current = lstBlueHand.SelectedItem.ToString();
            if (current != "")
            {
                int found = -1;
                for (int i = 0; i < saveFile.Characters[CurrentCharacterIndex].HandBlue.Count; i++)
                {
                    if (saveFile.Characters[CurrentCharacterIndex].HandBlue[i].number == current)
                    {
                        found = i;
                        break;
                    }
                }

                if (found != -1)
                {
                    saveFile.Characters[CurrentCharacterIndex].HandBlue.RemoveAt(found);
                }
            }

            refreshBlueHand();
        }

        private void btnGreenHandDel_Click(object sender, EventArgs e)
        {
            if (lstGreenHand.SelectedItem == null) return;
            string current = lstGreenHand.SelectedItem.ToString();
            if (current != "")
            {
                int found = -1;
                for (int i = 0; i < saveFile.Characters[CurrentCharacterIndex].HandGreen.Count; i++)
                {
                    if (saveFile.Characters[CurrentCharacterIndex].HandGreen[i].number == current)
                    {
                        found = i;
                        break;
                    }
                }

                if (found != -1)
                {
                    saveFile.Characters[CurrentCharacterIndex].HandGreen.RemoveAt(found);
                }
            }

            refreshGreenHand();
        }

        private void btnIventoryDel_Click(object sender, EventArgs e)
        {
            if (lstInventory.SelectedItem == null) return;
            string current = lstInventory.SelectedItem.ToString();
            if (current != "")
            {
                int found = -1;
                for (int i = 0; i < saveFile.Characters[CurrentCharacterIndex].Inventory.Count; i++)
                {
                    if (current.Contains(saveFile.Characters[CurrentCharacterIndex].Inventory[i].number))
                    {
                        found = i;
                        break;
                    }
                }

                if (found != -1)
                {
                    saveFile.Characters[CurrentCharacterIndex].Inventory.RemoveAt(found);
                }
            }

            refreshInventory();
        }

        private void btnStatusDel_Click(object sender, EventArgs e)
        {
            if (lstStatus.SelectedItem == null) return;
            string current = lstStatus.SelectedItem.ToString();
            if (current != "")
            {
                int found = -1;
                for (int i = 0; i < saveFile.Characters[CurrentCharacterIndex].Status.Count; i++)
                {
                    if (saveFile.Characters[CurrentCharacterIndex].Status[i].number == current)
                    {
                        found = i;
                        break;
                    }
                }

                if (found != -1)
                {
                    saveFile.Characters[CurrentCharacterIndex].Status.RemoveAt(found);
                }
            }

            refreshStatus();
        }
    }
}
