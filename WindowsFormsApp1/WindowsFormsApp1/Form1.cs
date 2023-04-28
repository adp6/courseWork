using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e) 
        {
            hero[] heroArr = { new hero("genji", "crosshairs", 1, 10, 100, 100, 0, 5, 100), new hero("tracer", "crosshairs", 1,5,5,100,100,2,0), new hero("reaper", "circle", 1, 11, 20, 100, 0, 2, 0), new hero("kiriko", "crosshairs", 1,0,0,0,0,5,100), new hero("d.va","circle",3,10,80,100,0,4,100), new hero("roadhog", "circle",1,4,30,100,0,2,0), new hero("soldier-76","crosshairs",1,21,12,100,0,2,0), new hero("orisa","crosshairs",1,10,6,100,0,5,0), new hero("moira","circle",1,10,75,100,0,2,0), new hero("ashe","crosshairs",1,10,0,100,0,2,0), new hero("zenyatta","crosshairs",1,7,6,100,0,2,0), new hero("sigma","crosshairs",1,8,24,100,100,2,0), new hero("cassidy","crosshairs",1,10,10,100,0,2,0), new hero("widowmaker","crosshairs",1,10,0,100,0,2,0), new hero("sombra","circle",1,10,60,100,0,4,100), new hero("torbjorn","circle and crosshairs",1,13,15,100,50,2,0), new hero("zarya","circle",1,0,13,100,0,2,100), new hero("symmetra","circle",1,0,13,100,0,2,100), new hero("mei","crosshairs",2,8,0,100,0,2,100),new hero("pharah","circle",1,0,13,100,0,2,100), new hero("lucio","circle",1,4,25,100,0,2,0), new hero("hanzo","circle",1,15,8,100,0,6,100), new hero("sojourn", "crosshairs",1,10,10,100,0,2,0),new hero("doomfist","circle",1,0,30,100,100,2,100), new hero("junker queen","circle and crosshair",1,6,20,50,50,2,100), new hero("reinhardt","crosshairs",1,10,5,100,50,8,0), new hero("winston","crosshairs",1,7,7,100,100,2,0), new hero("wrecking ball", "crosshairs",1,7,7,100,100,2,0), new hero("bastion","crosshairs",1,7,7,100,100,2,0), new hero("echo", "crosshairs", 1, 7, 7, 100, 100, 2, 0), new hero("baptise", "crosshairs", 1, 7, 7, 100, 100, 2, 0), new hero("mercy","circle",1,0,10,100,100,2,0), new hero("anna","crosshairs",1,7,7,100,100,2,0) };

            for (var i = 0; i < heroArr.Length; i++)
            {
                if (comboBox1.Text == heroArr[i].name)
                {
                    listBox1.Items[0] = $"TYPE: {heroArr[i].type.ToString()}";
                    listBox1.Items[1] = $"THICKNESS: {heroArr[i].thickness.ToString()}";
                    listBox1.Items[2] = $"CROSSHAIR LENGTH: {heroArr[i].crosshairLenght.ToString()}";
                    listBox1.Items[3] = $"CENTER GAP: {heroArr[i].centerGap.ToString()}";
                    listBox1.Items[4] = $"OPACITY: {heroArr[i].oppacity.ToString()}%";
                    listBox1.Items[5] = $"OUTLINE OPACITY: {heroArr[i].outlineOppacity.ToString()}%";
                    listBox1.Items[6] = $"DOT SIZE: {heroArr[i].dotSize.ToString()}";
                    listBox1.Items[7] = $"DOT OPPACITY: {heroArr[i].dotOppacity.ToString()}%";


                    pictureBox1.BackgroundImage = Image.FromFile($@"../../img\{heroArr[i].name}Crosshair.jpg");


                    listBox1.Visible = true;
                    countersBox.Text = heroArr[i].counters();
                    countersBox.Visible = true;
                    labelCounters.Visible = true;
                    break;
                }
                
            }
            
        }

        public class hero
        {
            public string name;
            public string type;
            public int thickness;
            public int crosshairLenght;
            public int centerGap;
            public int oppacity;
            public int outlineOppacity;
            public int dotSize;
            public int dotOppacity;

            public hero(string name, string type,int thickness, int crosshairLenght, int centerGap, int oppacity, int outlineOppacity, int dotSize, int dotOppacity)
            {
                this.name = name;
                this.type = type;
                this.thickness = thickness;
                this.crosshairLenght = crosshairLenght;
                this.centerGap = centerGap;
                this.oppacity = oppacity;
                this.outlineOppacity = outlineOppacity;
                this.dotSize = dotSize;
                this.dotOppacity = dotOppacity;

            }
            public string counters()
            {
                switch (name)
                {
                    case "genji":
                        return "Pharah, Brigitte, Zarya, Anna";
                    case "reaper":
                        return "Widowmaker, Hanzo, Soujurn, Soldier-76";
                    case "tracer":
                        return "Winston, Brigitte, Pharah, Tourbjorn";
                    case "hanzo":
                        return "Widowmaker, Winston, Genji, D.VA";
                    case "junkrat":
                        return "Pharah, Kiriko, Echo, Widowmaker";
                    case "d.va":
                        return "Sombra, Zarya, Roadhog, Junkrat";
                    case "doomfist":
                        return "Reaper, Pharah, Genji, Echo";
                    case "junker queen":
                        return "Bastion, Zenyatta, Mei, Orisa";
                    case "reinhardt":
                        return "Reaper, Bastion, Pharah, Junkrat";
                    case "roadhog":
                        return "Anna, Zarya, Widowmaker, Reaper";
                    case "sigma":
                        return "Orisa, Reaper, Genji, Reinhardt";
                    case "winston":
                        return "Roadhog, Anna, Junkrat, Moira";
                    case "wrecking ball":
                        return "Sombra, Reaper, Bastion, Pharah";
                    case "zarya":
                        return "Pharah, Sombra, Zenyatta, Bastion";
                    case "ashe":
                        return "Widowmaker, Hanzo, Tracer, Reinhardt";
                    case "bastion":
                        return "Roadhog, Junkrat, Anna, Reaper";
                    case "casidy":
                        return "Widowmaker, Winston, Baptise";
                    case "echo":
                        return "Widowmaker, Soujurn, Hanzo, Sombra";
                    case "mei":
                        return "Pharah, Sombra, Widowmaker, Soldier-76";
                    case "pharah":
                        return "Widowmaker, Hanzo, Soujurn, Soldier-76";
                    case "soujurn":
                        return "Winston, Zarya, Widowmaker, Lucio";
                    case "soldier-76":
                        return "Roadhog, Winston, Genji, Sigma";
                    case "sombra":
                        return "Hanzo, Junkrat, Widowmaker, Tracer";
                    case "symmetra":
                        return "D.VA, Pharah, Winston, Junker queen";
                    case "torbjorn":
                        return "Pharah, Widowmaker, Anna, Echo";
                    case "widowmaker":
                        return "Winston, Wrecking Ball, Soujurn, Reinhardt";
                    case "baptise":
                        return "D.VA, Genji, Hanzo, Roadhog";
                    case "brigitte":
                        return "Bastion, Pharah, Junkrat, Hanzo";
                    case "kiriko":
                        return "Widowmaker, Sombra, Soujurn, Tracer";
                    case "lucio":
                        return "Pharah, Torbjorn, Moira, Bastion";
                    case "mercy":
                        return "Widowmaker, Winston, Roadhog, Soujurn";
                    case "moira":
                        return "Widowmaker, Sombra, Wrecking Ball, Winston";
                    case "zenyatta":
                        return "Junker queen, Winston, Widowmaker, Genji";
                    case "anna":
                        return "D.va, Widowmaker, Tracer, Junker Queen";
                    case "orisa":
                        return "Winston, Junkrat, Reaper, Zenyatta";
                    default:
                        return "none";
                }
            }

        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
