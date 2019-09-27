using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace RollTheDice {
    public partial class RollDisplay : UserControl {
        private const int MAX_FLASH_INTENSITY = 128;
        private const int FLASH_TICK_FREQUENCY_MS = 10;
        private const float FLASH_DECAY_PER_S = 256;
        private bool highlighted = false;
        private Timer flash_timer = null;
        private float flash_intensity = 0;
        private Color flash_colour = Color.Yellow;


        public RollDisplay(int roll_number = 0, int roll_modifier = 0, StructCollection.Rule rule = new StructCollection.Rule()) {
            InitializeComponent();

            
            RuleNameLabel.Text = rule.rule_name;
            if (rule.results != null) {
                (string roll, string result, Color colour) display = rule.results.Display(roll_number, roll_modifier, rule.colour);
                RollNumberLabel.Text = display.roll;
                ResultTextLabel.Text = display.result;
                flash_colour = display.colour;
            }
            else {
                RollNumberLabel.Text = "";
                ResultTextLabel.Text = "";
            }
        }

        public RollDisplay(int roll_number = 0, int roll_modifier = 0, string roll_name = "") {
            InitializeComponent();

            RollNumberLabel.Text = (roll_number + roll_modifier).ToString();
            RuleNameLabel.Text = roll_name;
            ResultTextLabel.Text = "";
        }

        private void FlashTick(object sender, EventArgs e)
        {
            flash_intensity -= FLASH_DECAY_PER_S / 1000 * FLASH_TICK_FREQUENCY_MS;
            if (flash_intensity <= 0)
            {
                flash_timer = null;
                BackColor = Color.Transparent;
                return;
            }
            BackColor = Color.FromArgb((int)flash_intensity, ((Color)flash_colour).R, ((Color)flash_colour).G, ((Color)flash_colour).B);
        }

        public void Flash(Color? colour = null, int intensity = MAX_FLASH_INTENSITY)
        {
            if (colour != null)
            {
                flash_colour = (Color)colour;
            }
            flash_intensity = Math.Min(intensity, MAX_FLASH_INTENSITY);
            if (flash_timer == null)
            {
                flash_timer = new Timer();
                flash_timer.Interval = FLASH_TICK_FREQUENCY_MS;
                flash_timer.Tick += new EventHandler(FlashTick);
                flash_timer.Start();
            }
        }

        // WIP - not sure if needed
        public void SetHighlighted(bool highlighted)
        {
            this.highlighted = highlighted;
            if (highlighted)
            {

            }
            else
            {

            }
        }
    }
}
